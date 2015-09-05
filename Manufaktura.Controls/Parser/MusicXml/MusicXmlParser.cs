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
            var firstSystem = new StaffSystem();
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

            foreach (XElement staffNode in xmlDocument.Descendants(XName.Get("part")))
            {
                state.FirstLoop = true;
                Staff staff = new Staff() { MeasureAddingRule = Staff.MeasureAddingRuleEnum.AddMeasuresManually };
                score.Staves.Add(staff);
                var part = new Part(staff);
                score.Parts.Add(part);
                foreach (XElement measureNode in staffNode.Descendants(XName.Get("measure")))
                {
                    var measure = new Measure(staff, firstSystem);
                    staff.Measures.Add(measure);
                    state.BarlineAlreadyAdded = false;
                    if (measureNode.Parent.Name == "part")  //Don't take the other voices than the upper into account / Nie uwzględniaj innych głosów niż górny
                    {
                        if (!state.FirstLoop)
                        {
                            if (measureNode.Parent.Attribute(XName.Get("id")).Value != state.PartID) break;
                        }
                        else
                        {
                            state.PartID = measureNode.Parent.Attribute(XName.Get("id")).Value;
                        }
                    }

                    //Skip measure if needed:
                    if (state.SkipMeasures > 0) { state.SkipMeasures--; continue; }

                    //Read width measure:
                    measure.Width = measureNode.ParseAttribute<double>("width");

                    //Skip if measure node is empty:
                    if (!measureNode.HasElements) continue;

                    //Parse measure nodes:
                    foreach (XElement elementNode in measureNode.Elements().Where(e => e.Name == "attributes"))
                    {
                        MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(elementNode);
                        if (parsingStrategy != null) parsingStrategy.ParseElement(state, staff, elementNode);
                    }
                    foreach (var partStaff in part.Staves.Skip(1))
                    {
                        partStaff.Measures.Add(new Measure(partStaff, measure.System));
                    }

                    //Parse measure nodes:
                    foreach (XElement elementNode in measureNode.Elements().Where(e => e.Name != "attributes"))
                    {
                        MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(elementNode);
                        if (parsingStrategy != null) parsingStrategy.ParseElement(state, staff, elementNode);
                    }


                    if (!state.BarlineAlreadyAdded)
                    {
                        if (staff.Part != null && staff.Part.Staves.Any())  //If part contains many staves, add to all staves
                        {
                            foreach (var s in staff.Part.Staves)
                            {
                                s.Elements.Add(new Barline());
                            }
                        }
                        else
                        {
                            staff.Elements.Add(new Barline());
                        }
                    }
                    state.FirstLoop = false;
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