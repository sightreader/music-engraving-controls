using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser.MusicXml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser
{
    public class MusicXmlParser : ScoreParser<string>
    {
        public override Score Parse(string xmlDocument)  //TODO: Exception handling!
        {
            Score score = new Score();
            MusicXmlParserState state = new MusicXmlParserState();

            XDocument document = XDocument.Parse(xmlDocument);
            foreach (XElement staffNode in document.Descendants(XName.Get("part")))
            {
                Staff staff = new Staff();
                score.Staves.Add(staff);
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

                    //Parse measure nodes:
                    foreach (XElement elementNode in measureNode.Elements())
                    {
                        if (elementNode.HasElements == false) continue;
                        MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(elementNode);
                        if (parsingStrategy != null) parsingStrategy.ParseElement(state, staff, elementNode);
                    }

                    if (!state.BarlineAlreadyAdded)
                        staff.Elements.Add(new Barline());
                    state.FirstLoop = false;
                }
            }
            return score;
        }

        public override string ParseBack(Score score)
        {
            throw new NotImplementedException("This parser does not support saving to MusicXml.");
        }
    }
}
