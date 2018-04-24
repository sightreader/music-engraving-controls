﻿using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Services;
using Manufaktura.Music.Model;
using System;

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
            if (element.Fifths != 0)
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