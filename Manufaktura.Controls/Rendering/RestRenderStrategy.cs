using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    class RestRenderStrategy : MusicalSymbolRenderStrategy<Rest>
    {
        public override void Render(Rest element, ScoreRendererBase renderer)
        {
            if (renderer.State.firstNoteInIncipit) renderer.State.firstNoteInMeasureXPosition = renderer.State.CursorPositionX;
            renderer.State.firstNoteInIncipit = false;

            if ((element).Voice > renderer.State.CurrentVoice)
            {
                renderer.State.CursorPositionX = renderer.State.firstNoteInMeasureXPosition;
                renderer.State.lastNoteInMeasureEndXPosition = renderer.State.lastNoteEndXPosition;
            }
            renderer.State.CurrentVoice = element.Voice;


            double restPositionY = (renderer.State.LinePositions[0] - 9);
            if (renderer.State.IsPrintMode) restPositionY -= 0.6f;

            renderer.DrawString(element.MusicalCharacter, FontStyles.MusicFont, renderer.State.CursorPositionX, restPositionY);
            renderer.State.LastCursorPositionX = renderer.State.CursorPositionX;

            //Draw number of measures for multimeasure rests / Rysuj ilość taktów dla pauz wielotaktowych:
            if (element.MultiMeasure > 1)
            {
                renderer.DrawString(Convert.ToString(element.MultiMeasure), FontStyles.LyricsFontBold, renderer.State.CursorPositionX + 6, restPositionY);
            }

            //Draw dots / Rysuj kropki:
            if (element.NumberOfDots > 0) renderer.State.CursorPositionX += 16;
            for (int i = 0; i < element.NumberOfDots; i++)
            {
                renderer.DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, renderer.State.CursorPositionX, restPositionY);
                renderer.State.CursorPositionX += 6;
            }

            if (element.Duration == MusicalSymbolDuration.Whole) renderer.State.CursorPositionX += 48;
            else if (element.Duration == MusicalSymbolDuration.Half) renderer.State.CursorPositionX += 28;
            else if (element.Duration == MusicalSymbolDuration.Quarter) renderer.State.CursorPositionX += 17;
            else if (element.Duration == MusicalSymbolDuration.Eighth) renderer.State.CursorPositionX += 15;
            else renderer.State.CursorPositionX += 14;

            renderer.State.lastNoteEndXPosition = renderer.State.CursorPositionX;
        }
    }
}
