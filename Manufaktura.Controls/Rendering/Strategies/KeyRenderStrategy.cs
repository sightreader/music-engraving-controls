/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Services;
using Manufaktura.Music.Model;
using System;
using System.Linq;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering a Key.
    /// </summary>
    public class KeyRenderStrategy : MusicalSymbolRenderStrategy<Key>
    {

        public bool IsVirtualKey { get; set; }

        /// <summary>
        /// /// Initializes a new instance of KeyRenderStrategy
        /// </summary>
        /// <param name="scoreService"></param>
        public KeyRenderStrategy(IScoreService scoreService) : base(scoreService)
        {
        }

        public override void Render(Key element, ScoreRendererBase renderer)
        {
            if (element.Fifths != 0 && element.Measure.Elements.FirstOrDefault() == element)
                scoreService.CursorPositionX += renderer.LinespacesToPixels(1); //Żeby był lekki margines między kreską taktową a symbolem. Być może ta linijka będzie do usunięcia

            scoreService.CurrentKey = element;
            double flatOrSharpPositionY = 0;
            bool jumpFourth = false;
            int jumpDirection = 1;
            int octaveShiftSharp = 0; //In G clef sharps (not flats) should be written an octave higher / W kluczu g krzyżyki (bemole nie) powinny być zapisywane o oktawę wyżej
            if (scoreService.CurrentClef.TypeOfClef == ClefType.GClef) octaveShiftSharp = 1;
            int octaveShiftFlat = 0;
            if (scoreService.CurrentClef.TypeOfClef == ClefType.FClef) octaveShiftFlat = -1;

            if (!IsVirtualKey) element.TextBlockLocation = new Primitives.Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[0]);

            if (scoreService.CurrentKey.Fifths > 0)
            {
                flatOrSharpPositionY = scoreService.CurrentClef.TextBlockLocation.Y
                    + Pitch.StepDistance(scoreService.CurrentClef,
                      Pitch.FromStep(Step.F, scoreService.CurrentClef.Pitch.Octave + octaveShiftSharp))
                      * (renderer.Settings.LineSpacing / 2);
                jumpFourth = true;
                jumpDirection = 1;
            }
            else if (scoreService.CurrentKey.Fifths < 0)
            {
                flatOrSharpPositionY = scoreService.CurrentClef.TextBlockLocation.Y +
                    Pitch.StepDistance(scoreService.CurrentClef,
                    Pitch.FromStep(Step.B, scoreService.CurrentClef.Pitch.Octave + octaveShiftFlat))
                    * (renderer.Settings.LineSpacing / 2);
                jumpFourth = true;
                jumpDirection = -1;
            }

            for (int i = 0; i < Math.Abs(scoreService.CurrentKey.Fifths); i++)
            {
                renderer.DrawCharacter(element.GetCharacter(renderer.Settings.CurrentFont), MusicFontStyles.MusicFont, scoreService.CursorPositionX, flatOrSharpPositionY, element);
                if (jumpFourth) flatOrSharpPositionY += 3 * 3 * jumpDirection;
                else flatOrSharpPositionY += 3 * 4 * jumpDirection;
                jumpFourth = !jumpFourth;
                jumpDirection *= -1;
                scoreService.CursorPositionX += 8;
            }
            scoreService.CursorPositionX += 10;
        }
    }
}