using Manufaktura.Controls.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class PrintSuggestionWritingStrategy : MusicXmlWritingStrategy<PrintSuggestion>
    {
        public override string ElementName => "print";

        public override bool IsAttributeElement => false;

        protected override void WriteElementInner(PrintSuggestion symbol, XElement element)
        {
        }
    }
}