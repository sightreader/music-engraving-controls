using Manufaktura.Controls.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Key : MusicalSymbol
    {
        private static readonly string[] MajorSharpTonics = new[] { "G", "D", "A", "E", "B", "F", "C" };
        private static readonly string[] MajorFlatTonics = new[] { "F", "B", "E", "A", "D", "G", "C" };
        private static readonly string[] MinorSharpTonics = new[] { "e", "h", "f", "c", "g", "d", "a" };
        private static readonly string[] MinorFlatTonics = new[] { "d", "g", "c", "f", "b", "e", "a" };

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

        public static Key FromTonic (Step step, bool isMinor, bool isFlat) //TODO: To nie zadziała, za chuja
        {
            if (step == Step.C || step == Step.A) return new Key(0);
            string[] arrayToUse = null;
            if (isMinor && isFlat) arrayToUse = MinorFlatTonics;
            if (isMinor && !isFlat) arrayToUse = MinorSharpTonics;
            if (!isMinor && isFlat) arrayToUse = MajorFlatTonics;
            if (!isMinor && !isFlat) arrayToUse = MajorSharpTonics;
            int fifths = arrayToUse.ToList().IndexOf(step.StepName) + 1 + step.Alter;
            return new Key(fifths);
        }

        public static Key FromMidiPitch(int midiPitch, bool isMinor, bool isFlat)
        {
            var step = Pitch.FromMidiPitch(midiPitch).ToStep();
            return Key.FromTonic(step, isMinor, isFlat);
        }

        public int StepToAlter(string step)
        {
            int[] alterTable = new int[7];
            int numberOfStepsToAlter = Math.Abs(fifths);
            for (int i = 0; i < numberOfStepsToAlter; i++)
            {
                alterTable[i] += 1;
                if (i == 6)
                {
                    i = -1;
                    numberOfStepsToAlter -= 6;
                }

            }
            if (fifths > 0)
            {
                if (step == "C") return alterTable[1];
                else if (step == "D") return alterTable[3];
                else if (step == "E") return alterTable[5];
                else if (step == "F") return alterTable[0];
                else if (step == "G") return alterTable[2];
                else if (step == "A") return alterTable[4];
                else if (step == "B") return alterTable[6];
            }
            else if (fifths < 0)
            {
                if (step == "C") return alterTable[5] * -1;
                else if (step == "D") return alterTable[3] * -1;
                else if (step == "E") return alterTable[1] * -1;
                else if (step == "F") return alterTable[6] * -1;
                else if (step == "G") return alterTable[4] * -1;
                else if (step == "A") return alterTable[2] * -1;
                else if (step == "B") return alterTable[0] * -1;
            }

            return 0;
        }

        #endregion

    }
}
