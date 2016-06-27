using Manufaktura.Controls.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class NoteWritingStrategy : MusicXmlWritingStrategy<Note>
    {
        public override string ElementName => "note";

        public override bool IsAttributeElement => false;

        protected override void WriteElementInner(Note symbol, XElement element)
        {
            var pitchNode = new XElement("pitch");
            element.Add(pitchNode);

            pitchNode.Add(new XElement("step", symbol.Pitch.StepName));
            pitchNode.Add(new XElement("octave", symbol.Pitch.Octave));
            if (symbol.Alter != 0) pitchNode.Add(new XElement("alter", symbol.Pitch.Alter));

            if (symbol.Voice != 0) element.Add(new XElement("voice", symbol.Voice));
            element.Add(new XElement("type", GetDurationName(symbol)));
        }

        private static string GetDurationName(NoteOrRest symbol)
        {
            switch (symbol.BaseDuration.Denominator)
            {
                case 1:
                    return "whole";

                case 2:
                    return "half";

                case 4:
                    return "quarter";

                case 8:
                    return "eighth";

                case 16:
                    return "16th";

                case 32:
                    return "32nd";

                case 64:
                    return "64th";

                case 128:
                    return "128th";

                case 256:
                    return "256th";

                case 512:
                    return "512th";

                default:
                    throw new ScoreWriterException(symbol, $"Invalid rhythmic duration denominator {symbol.BaseDuration.Denominator}.");
            }
        }
    }
}