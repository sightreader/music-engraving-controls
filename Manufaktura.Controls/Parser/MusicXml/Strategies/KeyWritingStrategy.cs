using Manufaktura.Controls.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class KeyWritingStrategy : MusicXmlWritingStrategy<Key>
    {
        public override string ElementName => "key";

        public override bool IsAttributeElement => true;

        protected override void WriteElementInner(Key symbol, XElement element)
        {
            element.Add(new XElement("fifths", symbol.Fifths));
        }
    }
}