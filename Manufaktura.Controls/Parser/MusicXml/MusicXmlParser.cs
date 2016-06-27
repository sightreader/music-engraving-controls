using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Exceptions;
using Manufaktura.Controls.Parser.MusicXml;
using Manufaktura.Controls.Parser.MusicXml.Strategies;
using Manufaktura.Music.Model;
using Manufaktura.Music.Xml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser
{
    /// <summary>
    /// Parser that parsers xml documents into scores.
    /// </summary>
    public class MusicXmlParser : ScoreParser<XDocument>
    {
        public override Score Parse(XDocument xmlDocument)  //TODO: Exception handling!
        {
            Score score = new Score();
            var firstSystem = new StaffSystem(score);
            score.Pages.Last().Systems.Add(firstSystem);
            MusicXmlParserState state = new MusicXmlParserState();

            foreach (XElement defaultSettingsNode in xmlDocument.Descendants().Where(d => d.Name == "defaults" || d.Name == "identification"))
            {
                foreach (XElement settingNode in defaultSettingsNode.Elements())
                {
                    var dummyStaff = new Staff { Score = score };   //Nasty workaround
                    MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(settingNode);
                    if (parsingStrategy != null) parsingStrategy.ParseElement(state, dummyStaff, settingNode);
                }
            }

            foreach (XElement partNode in xmlDocument.Descendants(XName.Get("part")))
            {
                state.CurrentSystemNo = 1;

                var partId = partNode.ParseAttribute("id");
                state.FirstLoop = true;
                Staff staff = new Staff() { MeasureAddingRule = Staff.MeasureAddingRuleEnum.AddMeasuresManually };
                score.Staves.Add(staff);
                var part = score.Parts.FirstOrDefault(p => p.PartId == partId) ?? new Part(staff) { PartId = partId };
                staff.Part = part;
                score.Parts.Add(part);
                foreach (XElement node in partNode.Elements())
                {
                    MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(node);
                    if (parsingStrategy != null) parsingStrategy.ParseElement(state, staff, node);
                }
            }

            var partListNode = xmlDocument.Descendants(XName.Get("part-list"));
            PartGroup currentPartGroup = null;
            foreach (var partListElementNode in partListNode.Elements())
            {
                if (partListElementNode.Name == "part-group")
                {
                    partListElementNode.IfAttribute("type").HasValue("start").Then(() =>
                    {
                        currentPartGroup = new PartGroup() { Number = score.PartGroups.Count + 1 };
                        score.PartGroups.Add(currentPartGroup);
                    });

                    partListElementNode.IfAttribute("type").HasValue("stop").Then(() => currentPartGroup = null);
                    if (currentPartGroup != null)
                    {
                        partListElementNode.IfElement("group-barline").HasValue<GroupBarlineType>(d =>
                        {
                            d.Add("Yes", GroupBarlineType.Enabled);
                            d.Add("No", GroupBarlineType.Disabled);
                            d.Add("Mensurstrich", GroupBarlineType.Mensurstrich);
                            return d;
                        }).Then(r => currentPartGroup.GroupBarline = r);
                    }
                }
                if (partListElementNode.Name == "score-part" && currentPartGroup != null)
                {
                    var scorePartId = partListElementNode.IfAttribute("id").HasAnyValue().ThenReturnResult();
                    var matchingScorePart = score.Parts.FirstOrDefault(p => p.PartId == scorePartId);
                    if (matchingScorePart != null) matchingScorePart.Group = currentPartGroup;
                }
            }

            //Sibelius hack:
            if (score.Encoding?.Software?.Any(s => s.Contains("Sibelius")) ?? false)
            {
                new DefaultScoreFormatter().Format(score);
            }

            foreach (var staff in score.Staves) staff.MeasureAddingRule = Staff.MeasureAddingRuleEnum.AddMeasureOnInsertingBarline;
            return score;
        }

        public override XDocument ParseBack(Score score)
        {
            if (!score.Parts.Any()) throw new ScoreException(score, $"Score does not contain any parts therefore it does not conform to score-partwise schema. You have to add parts to {nameof(Score.Parts)} collection before exporting to MusicXml.");
            var quarterNoteDuration = CalculateQuarterNoteDuration(score);

            var document = new XDocument();
            document.Declaration = new XDeclaration("1.0", "UTF-8", "no");
            document.Add(new XDocumentType("score-partwise", @"-//Recordare//DTD MusicXML 3.0 Partwise//EN", @"http://www.musicxml.org/dtds/partwise.dtd", ""));
            var root = new XElement(XName.Get("score-partwise"));
            root.Add(new XAttribute(XName.Get("version"), "3.0"));
            document.Add(root);

            var identificationNode = new XElement(XName.Get("identification"));
            root.Add(identificationNode);

            identificationNode.Add(
                new XElement("software", "Manufaktura.Controls"),
                new XElement("encoding-date", DateTime.Now.ToString(CultureInfo.InvariantCulture)));

            var defaultsNode = new XElement("defaults");
            root.Add(defaultsNode);

            var partListNode = new XElement("part-list");
            foreach (var part in score.Parts)
            {
                if (string.IsNullOrWhiteSpace(part.PartId)) throw new ScoreException(part, "Part has to contain id.");
                var scorePartNode = new XElement("score-part");
                scorePartNode.Add(new XAttribute("id", part.PartId));
                scorePartNode.Add(new XElement("part-name", part.Name));
                partListNode.Add(scorePartNode);
            }
            root.Add(partListNode);

            foreach (var part in score.Parts)
            {
                var partNode = new XElement("part");
                partNode.Add(new XAttribute("id", part.PartId));
                root.Add(partNode);
                ExportStaves(partNode, part.Staves, quarterNoteDuration);
            }
            return document;
        }

        private void ExportStaves(XElement parent, IEnumerable<Staff> staves, int quarterNoteDuration)
        {
            foreach (var staff in staves)
            {
                foreach (var measure in staff.Measures)
                {
                    var measureNode = new XElement("measure");
                    measureNode.Add(new XAttribute("number", measure.Number));
                    if (measure.Width.HasValue) measureNode.Add(new XAttribute("width", measure.Width));
                    parent.Add(measureNode);
                    foreach (var element in measure.Elements)
                    {
                        MusicXmlWritingStrategyBase.GetProperStrategy(element.GetType())?.WriteElement(element, measureNode, quarterNoteDuration);
                    }
                }
            }
        }

        private static int CalculateQuarterNoteDuration(Score score)
        {
            var smallestRhythmicValue = score.Staves.SelectMany(s => s.Elements).OfType<IHasDuration>().Min(e => e.BaseDuration.ToDouble());
            return (int)(RhythmicDuration.Quarter.ToDouble() / smallestRhythmicValue);
        }
    }
}