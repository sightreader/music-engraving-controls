using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Services;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public class RestRenderStrategy : MusicalSymbolRenderStrategy<Rest>
    {
        private readonly IMeasurementService measurementService;
        private readonly IScoreService scoreService;
        public RestRenderStrategy(IMeasurementService measurementService, IScoreService scoreService)
        {
            this.measurementService = measurementService;
            this.scoreService = scoreService;
        }

        public override void Render(Rest element, ScoreRendererBase renderer)
        {
            //Jeśli ustalono default-x, to pozycjonuj wg default-x, a nie automatycznie
            if (!renderer.Settings.IgnoreCustomElementPositions && element.DefaultXPosition.HasValue)
            {
                renderer.State.CursorPositionX = measurementService.LastMeasurePositionX + element.DefaultXPosition.Value * renderer.Settings.CustomElementPositionRatio;
            }

            if (renderer.State.firstNoteInIncipit) scoreService.CurrentMeasure.FirstNoteInMeasureXPosition = renderer.State.CursorPositionX;
            renderer.State.firstNoteInIncipit = false;

            //If it's second voice, rewind position to the beginning of measure (but only if default-x is not set or is ignored):
            if (element.Voice > scoreService.CurrentVoice && (renderer.Settings.IgnoreCustomElementPositions || !element.DefaultXPosition.HasValue))
            {
                renderer.State.CursorPositionX = scoreService.CurrentMeasure.FirstNoteInMeasureXPosition;
                measurementService.lastNoteInMeasureEndXPosition = measurementService.LastNoteEndXPosition;
            }
            scoreService.CurrentVoice = element.Voice;


            double restPositionY = (scoreService.CurrentLinePositions[0] - 9);

            renderer.DrawString(element.MusicalCharacter, MusicFontStyles.MusicFont, renderer.State.CursorPositionX, restPositionY, element);
            measurementService.LastNotePositionX = renderer.State.CursorPositionX;

            //Draw number of measures for multimeasure rests / Rysuj ilość taktów dla pauz wielotaktowych:
            if (element.MultiMeasure > 1)
            {
                renderer.DrawString(Convert.ToString(element.MultiMeasure), MusicFontStyles.LyricsFontBold, renderer.State.CursorPositionX + 6, restPositionY, element);
            }

            //Draw dots / Rysuj kropki:
            if (element.NumberOfDots > 0) renderer.State.CursorPositionX += 16;
            for (int i = 0; i < element.NumberOfDots; i++)
            {
                renderer.DrawString(renderer.Settings.CurrentFont.Dot, MusicFontStyles.MusicFont, renderer.State.CursorPositionX, restPositionY, element);
                renderer.State.CursorPositionX += 6;
            }

            if (renderer.Settings.IgnoreCustomElementPositions || !element.DefaultXPosition.HasValue) //Pozycjonowanie automatyczne tylko, gdy nie określono default-x
            {
                if (element.Duration == RhythmicDuration.Whole) renderer.State.CursorPositionX += 48;
                else if (element.Duration == RhythmicDuration.Half) renderer.State.CursorPositionX += 28;
                else if (element.Duration == RhythmicDuration.Quarter) renderer.State.CursorPositionX += 17;
                else if (element.Duration == RhythmicDuration.Eighth) renderer.State.CursorPositionX += 15;
                else renderer.State.CursorPositionX += 14;
            }

            measurementService.LastNoteEndXPosition = renderer.State.CursorPositionX;
        }
    }
}
