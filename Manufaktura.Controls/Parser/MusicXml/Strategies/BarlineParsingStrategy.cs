using Manufaktura.Controls.Model;
using Manufaktura.Music.Xml;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    internal class BarlineParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "barline"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var b = new Barline();

            element.IfAttribute("location").HasValue("left")
                .Then(() => b.Location = HorizontalPlacement.Left)
                .Otherwise(r => b.Location = HorizontalPlacement.Right);

            element.IfElement("bar-style").HasValue("light-heavy").Then(() => b.Style = BarlineStyle.LightHeavy);
            element.IfElement("bar-style").HasValue("none").Then(() => b.Style = BarlineStyle.None);
            element.IfElement("bar-style").HasValue("dashed").Then(() => b.Style = BarlineStyle.Dashed);
            var repeatAttribute = element.Elements().FirstOrDefault(e => e.Name == "repeat");
            var attribute = repeatAttribute?.Attribute("direction");

            bool add = false;
            if (attribute != null)
            {
                if (attribute.Value == "forward") b.RepeatSign = RepeatSignType.Forward;
                else if (attribute.Value == "backward")
                {
                    b.RepeatSign = RepeatSignType.Backward;
                    state.BarlineAlreadyAdded = true;
                }
                add = true;
            }
            else if (b.Style != BarlineStyle.Regular)
            {
                state.BarlineAlreadyAdded = true;
                add = true;
            }

            if (add)
            {
                if (staff.Part?.Staves.Any() ?? false)  //If part contains many staves, add to all staves
                {
                    foreach (var s in staff.Part.Staves)
                    {
                        s.Elements.Add(b);
                    }
                }
                else
                {
                    staff.Elements.Add(b);
                }
            }
        }
    }
}