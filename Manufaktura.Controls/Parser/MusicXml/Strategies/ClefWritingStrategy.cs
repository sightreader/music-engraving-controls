using Manufaktura.Controls.Model;
using System.Xml.Linq;
using System;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    internal class ClefWritingStrategy : MusicXmlWritingStrategy<Clef>
    {
        public override string ElementName
        {
            get { return "clef"; }
        }

        public override bool IsAttributeElement => true;

        protected override void WriteElementInner(Clef symbol, XElement element, int quarterNoteDuration)
        {
            element.Add(new XElement("sign", symbol.Pitch.StepName));
            element.Add(new XElement("line", symbol.Line));
        }
    }
}