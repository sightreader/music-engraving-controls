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
            if (renderer.State.firstNoteInIncipit) renderer.State.firstNoteInMeasureXPosition = renderer.State.currentXPosition;
            renderer.State.firstNoteInIncipit = false;

            if ((element).Voice > renderer.State.currentVoice)
            {
                renderer.State.currentXPosition = renderer.State.firstNoteInMeasureXPosition;
                renderer.State.lastNoteInMeasureEndXPosition = renderer.State.lastNoteEndXPosition;
            }
            renderer.State.currentVoice = element.Voice;


            float restPositionY = (renderer.State.lines[0] - 9);
            if (renderer.State.print) restPositionY -= 0.6f;

            DrawString(symbol.MusicalCharacter, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), renderer.State.currentXPosition, restPositionY);
            renderer.State.lastXPosition = renderer.State.currentXPosition;

            //Draw number of measures for multimeasure rests / Rysuj ilość taktów dla pauz wielotaktowych:
            if (((Rest)symbol).MultiMeasure > 1)
            {
                DrawString(Convert.ToString((element.MultiMeasure),
                    FontStyles.LyricFontBold, new SolidBrush(symbol.MusicalCharacterColor), renderer.State.currentXPosition + 6, restPositionY);
            }

            //Draw dots / Rysuj kropki:
            if ((element.NumberOfDots > 0) renderer.State.currentXPosition += 16;
            for (int i = 0; i < element.NumberOfDots; i++)
            {
                DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), renderer.State.currentXPosition, restPositionY);
                renderer.State.currentXPosition += 6;
            }

            if (element.Duration == MusicalSymbolDuration.Whole) renderer.State.currentXPosition += 48;
            else if (element.Duration == MusicalSymbolDuration.Half) renderer.State.currentXPosition += 28;
            else if (element.Duration == MusicalSymbolDuration.Quarter) renderer.State.currentXPosition += 17;
            else if (element.Duration == MusicalSymbolDuration.Eighth) renderer.State.currentXPosition += 15;
            else renderer.State.currentXPosition += 14;

            renderer.State.lastNoteEndXPosition = renderer.State.currentXPosition;
        }
    }
}
