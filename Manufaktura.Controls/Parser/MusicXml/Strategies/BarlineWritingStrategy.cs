using Manufaktura.Controls.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class BarlineWritingStrategy : MusicXmlWritingStrategy<Barline>
    {
        public override string ElementName => "barline";

        public override bool IsAttributeElement => false;

        protected override void WriteElementInner(Barline symbol, XElement element, int quarterNoteDuration)
        {
            if (symbol.Style == BarlineStyle.Regular) return;
            element.Add(new XAttribute("location", symbol.Location.ToString().ToLowerInvariant()));
            element.Add(new XElement("bar-style", GetBarlineStyle(symbol)));
        }

        private static string GetBarlineStyle(Barline barline)
        {
            switch (barline.Style)
            {
                case BarlineStyle.Regular:
                    return "regular";

                case BarlineStyle.LightHeavy:
                    return "light-heavy";

                default:
                    throw new ScoreWriterException(barline, $"Unsupported barline style {barline.Style}.");
            }
        }
    }
}