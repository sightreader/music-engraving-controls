using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class RestWritingStrategy : MusicXmlWritingStrategy<Rest>
    {
        public override string ElementName => "note";

        public override bool IsAttributeElement => false;

        protected override void WriteElementInner(Rest symbol, XElement element, int quarterNoteDuration)
        {
            element.Add(new XElement("rest"));

            element.Add(new XElement("duration", (symbol.Duration.ToDouble() * quarterNoteDuration) / RhythmicDuration.Quarter.ToDouble()));

            if (symbol.Voice != 0) element.Add(new XElement("voice", symbol.Voice));
            element.Add(new XElement("type", NoteWritingStrategy.GetDurationName(symbol)));

            for (var dot = 0; dot < symbol.NumberOfDots; dot++) element.Add(new XElement("dot"));
        }
    }
}