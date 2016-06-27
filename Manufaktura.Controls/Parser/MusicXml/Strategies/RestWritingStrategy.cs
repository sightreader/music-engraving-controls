using Manufaktura.Controls.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class RestWritingStrategy : MusicXmlWritingStrategy<Rest>
    {
        public override string ElementName => "note";

        public override bool IsAttributeElement => false;

        protected override void WriteElementInner(Rest symbol, XElement element)
        {
            element.Add(new XElement("rest"));
        }
    }
}