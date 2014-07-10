using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    class KeyRenderStrategy : MusicalSymbolRenderStrategy<Key>
    {
        public override void Render(Key element, ScoreRendererBase renderer)
        {
            currentKey = (Key)symbol;
            float flatOrSharpPositionY = 0;
            bool jumpFourth = false;
            int jumpDirection = 1;
            int octaveShiftSharp = 0; //In G clef sharps (not flats) should be written an octave higher / W kluczu g krzyżyki (bemole nie) powinny być zapisywane o oktawę wyżej
            if (currentClef.TypeOfClef == ClefType.GClef) octaveShiftSharp = 1;
            int octaveShiftFlat = 0;
            if (currentClef.TypeOfClef == ClefType.FClef) octaveShiftFlat = -1;
            if (currentKey.Fifths > 0)
            {
                flatOrSharpPositionY = currentClefPositionY + MusicalSymbol.StepDifference(currentClef,
                (new Note("F", 0, currentClef.Octave + octaveShiftSharp, MusicalSymbolDuration.Whole, NoteStemDirection.Up,
                    NoteTieType.None, null)))
                * (lineSpacing / 2);
                jumpFourth = true;
                jumpDirection = 1;

            }
            else if (currentKey.Fifths < 0)
            {
                flatOrSharpPositionY = currentClefPositionY + MusicalSymbol.StepDifference(currentClef,
                (new Note("B", 0, currentClef.Octave + octaveShiftFlat, MusicalSymbolDuration.Whole, NoteStemDirection.Up,
                    NoteTieType.None, null)))
                * (lineSpacing / 2);
                jumpFourth = true;
                jumpDirection = -1;
            }
            for (int i = 0; i < Math.Abs(currentKey.Fifths); i++)
            {

                g.DrawString(symbol.MusicalCharacter, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor),
                    currentXPosition, flatOrSharpPositionY);
                if (jumpFourth) flatOrSharpPositionY += 3 * 3 * jumpDirection;
                else flatOrSharpPositionY += 3 * 4 * jumpDirection;
                jumpFourth = !jumpFourth;
                jumpDirection *= -1;
                currentXPosition += 8;
            }
            currentXPosition += 10;
        }
    }
}
