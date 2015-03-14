using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Key : MusicalSymbol, IRenderedAsTextBlock
    {
        #region Private fields

        private int fifths;
        private string musicalCharacter;
        private MusicFont musicFont = new PolihymniaFont();

        #endregion

        #region Properties

        public int Fifths { get { return fifths; } }
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
        public MusicFont MusicFont { get { return musicFont; } set { musicFont = value; OnPropertyChanged(() => MusicFont); } }

        public string MusicalCharacter
        {
            get { return musicalCharacter; }
        }

        #endregion

        #region Constructor

        public Key(int numberOfFifths)
        {
            type = MusicalSymbolType.Key;
            fifths = numberOfFifths;
            if (fifths > 0)
                musicalCharacter = MusicFont.Sharp;
            else if (fifths < 0)
                musicalCharacter = MusicFont.Flat;
            else
                musicalCharacter = " ";
        }

        #endregion

        #region Public methods

        public static Key FromTonic(Step step, MajorAndMinorScaleFlags flags)
        {
            return new Key(CircleOfFifths.CalculateFifths(step, flags));
        }

        public static Key FromScale(MajorOrMinorScale scale)
        {
            return new Key(scale.Fifths);
        }

        public static Key FromMidiPitch(int midiPitch, MajorAndMinorScaleFlags flags)
        {
            return new Key(CircleOfFifths.CalculateFifths(midiPitch, flags));
        }

        public int StepToAlter(string step)
        {
            return CircleOfFifths.GetAlterOfStepFromNumberOfFifths(step, Fifths);
        }

        #endregion



    }
}
