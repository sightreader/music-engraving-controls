using Manufaktura.Controls.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class PrintSuggestionWritingStrategy : MusicXmlWritingStrategy<PrintSuggestion>
    {
        public override string ElementName => "print";

        public override bool IsAttributeElement => false;

        protected override void WriteElementInner(PrintSuggestion symbol, XElement element, int quarterNoteDuration)
        {
            if (symbol.IsSystemBreak) element.Add(new XAttribute("new-system", "yes"));
            if (symbol.SystemDistance.HasValue)
            {
                var layoutElement = new XElement("system-layout");
                element.Add(layoutElement);
                layoutElement.Add(new XElement("system-distance", symbol.SystemDistance));
            }
        }
    }
}