using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using System;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a key signature.
    /// </summary>
    public class Key : MusicalSymbol, IRenderedAsTextBlock
    {
        private int fifths;
        private string musicalCharacter;
        private IMusicFont musicFont = new PolihymniaFont();

        public int Fifths { get { return fifths; } }

        public string MusicalCharacter
        {
            get { return musicalCharacter; }
        }

        public IMusicFont MusicFont { get { return musicFont; } set { musicFont = value; OnPropertyChanged(() => MusicFont); } }

        public Primitives.Point TextBlockLocation
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override MusicalSymbolType Type
        {
            get
            {
                return MusicalSymbolType.Key;
            }
        }

        public Key(int numberOfFifths)
        {
            fifths = numberOfFifths;
            if (fifths > 0)
                musicalCharacter = MusicFont.Sharp;
            else if (fifths < 0)
                musicalCharacter = MusicFont.Flat;
            else
                musicalCharacter = " ";
        }

        public static Key FromMidiPitch(int midiPitch, MajorAndMinorScaleFlags flags)
        {
            return new Key(CircleOfFifths.CalculateFifths(midiPitch, flags));
        }

        public static Key FromScale(MajorOrMinorScale scale)
        {
            return new Key(scale.Fifths);
        }

        public static Key FromTonic(Step step, MajorAndMinorScaleFlags flags)
        {
            return new Key(CircleOfFifths.CalculateFifths(step, flags));
        }

        public int StepToAlter(string step)
        {
            return CircleOfFifths.GetAlterOfStepFromNumberOfFifths(step, Fifths);
        }

        public override string ToString()
        {
            return string.Format("{0} with {1} generator intervals.", base.ToString(), Fifths);
        }
    }
}