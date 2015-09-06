using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class MeasureParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "measure"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, System.Xml.Linq.XElement element)
        {
            var part = staff.Part;
            var system = staff.Score.Systems.LastOrDefault();
            if (system == null)
            {
                system = new StaffSystem();
                staff.Score.Systems.Add(system);
            }
            var measure = new Measure(staff, system);
            measure.Number = element.ParseAttribute<int>("number");
            staff.Measures.Add(measure);
            state.BarlineAlreadyAdded = false;
            if (element.Parent.Name == "part")  //Don't take the other voices than the upper into account / Nie uwzględniaj innych głosów niż górny
            {
                if (!state.FirstLoop)
                {
                    if (element.Parent.Attribute(XName.Get("id")).Value != state.PartID) return;
                }
                else
                {
                    state.PartID = element.Parent.Attribute(XName.Get("id")).Value;
                }
            }

            //Skip measure if needed:
            if (state.SkipMeasures > 0) { state.SkipMeasures--; return; }

            //Read width measure:
            measure.Width = element.ParseAttribute<double>("width");

            //Skip if measure node is empty:
            if (!element.HasElements) return;

            //Parse measure nodes:
            foreach (XElement elementNode in element.Elements().Where(e => e.Name == "attributes"))
            {
                MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(elementNode);
                if (parsingStrategy != null) parsingStrategy.ParseElement(state, staff, elementNode);
            }
            foreach (var partStaff in part.Staves.Skip(1))
            {
                partStaff.Measures.Add(new Measure(partStaff, measure.System));
            }

            //Parse measure nodes:
            foreach (XElement elementNode in element.Elements().Where(e => e.Name != "attributes"))
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
}