using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Key : MusicalSymbol
    {
        #region Private fields

        private int fifths;

        #endregion

        #region Properties

        public int Fifths { get { return fifths; } }

        #endregion

        #region Constructor

        public Key(int numberOfFifths)
        {
            type = MusicalSymbolType.Key;
            fifths = numberOfFifths;
            if (fifths > 0)
                musicalCharacter = MusicalCharacters.Sharp;
            else if (fifths < 0)
                musicalCharacter = MusicalCharacters.Flat;
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
