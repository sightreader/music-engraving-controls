using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser.MusicXml;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
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
            MusicXmlParserState state = new MusicXmlParserState();

            foreach (XElement staffNode in xmlDocument.Descendants(XName.Get("part")))
            {
                state.FirstLoop = true;
                Staff staff = new Staff();
                score.Staves.Add(staff);
                var part = new Part(staff);
                score.Parts.Add(part);
                foreach (XElement measureNode in staffNode.Descendants(XName.Get("measure")))
                {
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

                    //Skip if measure node is empty:
                    if (!measureNode.HasElements) continue;

                    //Read widths of all measures:
                    double? measureWidth = null;
                    var widthAttribute = measureNode.Attributes().FirstOrDefault(a => a.Name == "width");
                    if (widthAttribute != null) measureWidth = UsefulMath.TryParse(widthAttribute.Value);
                    staff.MeasureWidths.Add(measureWidth);

                    //Parse measure nodes:
                    foreach (XElement elementNode in measureNode.Elements())
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
            return score;
        }

        public override XDocument ParseBack(Score score)
        {
            throw new NotImplementedException("This parser does not support saving to MusicXml.");
        }
    }
}
