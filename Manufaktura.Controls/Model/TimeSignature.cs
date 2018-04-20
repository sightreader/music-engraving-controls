using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    public class TimeSignature : MusicalSymbol, IRenderedAsTextBlock
    {
        protected Proportion numberValue;
        protected TimeSignatureType signatureType;

        public TimeSignature(TimeSignatureType sType, int beats, int beatType)
        {
            numberValue = new Proportion(beats, beatType);
            signatureType = sType;
        }

        public static TimeSignature CommonTime => new TimeSignature(TimeSignatureType.Common, 4, 4);

        public static TimeSignature CutTime => new TimeSignature(TimeSignatureType.Cut, 2, 2);

        public int NumberOfBeats { get { return numberValue.Numerator; } }

        public Proportion NumberValue { get { return numberValue; } set { numberValue = value; OnPropertyChanged(); } }

        public TimeSignatureType SignatureType { get { return signatureType; } set { signatureType = value; } }

        public Point TextBlockLocation { get; internal set; }
        public int TypeOfBeats { get { return numberValue.Denominator; } }

        /// <summary>
        /// Returns how many whole notes can be fitted into one measure.
        /// </summary>
        public double WholeNoteCapacity => numberValue.DoubleValue;

        public char GetCharacter(IMusicFont font)
        {
            if (SignatureType == TimeSignatureType.Common) return font.CommonTime;
            else if (SignatureType == TimeSignatureType.Cut) return font.CutTime;
            else return '\0';
        }
    }
}