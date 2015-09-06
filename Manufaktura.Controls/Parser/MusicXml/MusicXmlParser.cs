using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser.MusicXml;
using Manufaktura.Music.Model;
using System;
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

            //Sibelius hack:
            if (score.Encoding.Software.Any(s => s.Contains("Sibelius")))
            {
                score.DefaultPageSettings.DefaultSystemDistance *= 1.39;
                new DefaultScoreFormatter().Format(score);
            }

            foreach (var staff in score.Staves) staff.MeasureAddingRule = Staff.MeasureAddingRuleEnum.AddMeasureOnInsertingBarline;
            return score;
        }

        public override XDocument ParseBack(Score score)
        {
            throw new NotImplementedException("This parser does not support saving to MusicXml.");
        }
    }
}