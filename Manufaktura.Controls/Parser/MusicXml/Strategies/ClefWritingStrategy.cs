using Manufaktura.Controls.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    internal class ClefWritingStrategy : MusicXmlWritingStrategy<Clef>
    {
        public override string ElementName
        {
            get { return "clef"; }
        }

        protected override void WriteElementInner(Clef symbol, XElement element)
        {
            element.Add("sign", symbol.Pitch.StepName);
            element.Add("line", symbol.Line);
        }
    }
}