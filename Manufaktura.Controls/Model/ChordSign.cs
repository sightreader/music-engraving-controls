using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    public class ChordSign : MusicalSymbol
    {
        public Chord Chord { get; private set; }

        public override MusicalSymbolType Type
        {
            get
            {
                return MusicalSymbolType.ChordSign;
            }
        }

        public ChordSign(Chord chord)
        {
            Chord = chord;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", base.ToString(), Chord.ToString());
        }
    }
}