using Manufaktura.Controls.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class TimeSignatureWritingStrategy : MusicXmlWritingStrategy<TimeSignature>
    {
        public override string ElementName => "time";

        public override bool IsAttributeElement => true;

        protected override void WriteElementInner(TimeSignature symbol, XElement element, int quarterNoteDuration)
        {
            element.Add(new XElement("beats", symbol.NumberOfBeats));
            element.Add(new XElement("beat-type", symbol.TypeOfBeats));
        }
    }
}