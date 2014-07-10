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
            if (firstNoteInIncipit) firstNoteInMeasureXPosition = currentXPosition;
            firstNoteInIncipit = false;

            if (((Rest)symbol).Voice > currentVoice)
            {
                currentXPosition = firstNoteInMeasureXPosition;
                lastNoteInMeasureEndXPosition = lastNoteEndXPosition;
            }
            currentVoice = ((Rest)symbol).Voice;


            float restPositionY = (lines[0] - 9);
            if (print) restPositionY -= 0.6f;

            g.DrawString(symbol.MusicalCharacter, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, restPositionY);
            lastXPosition = currentXPosition;

            //Draw number of measures for multimeasure rests / Rysuj ilość taktów dla pauz wielotaktowych:
            if (((Rest)symbol).MultiMeasure > 1)
            {
                g.DrawString(Convert.ToString(((Rest)symbol).MultiMeasure),
                    FontStyles.LyricFontBold, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition + 6, restPositionY);
            }

            //Draw dots / Rysuj kropki:
            if (((Rest)symbol).NumberOfDots > 0) currentXPosition += 16;
            for (int i = 0; i < ((Rest)symbol).NumberOfDots; i++)
            {
                g.DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, restPositionY);
                currentXPosition += 6;
            }

            if (((Rest)symbol).Duration == MusicalSymbolDuration.Whole) currentXPosition += 48;
            else if (((Rest)symbol).Duration == MusicalSymbolDuration.Half) currentXPosition += 28;
            else if (((Rest)symbol).Duration == MusicalSymbolDuration.Quarter) currentXPosition += 17;
            else if (((Rest)symbol).Duration == MusicalSymbolDuration.Eighth) currentXPosition += 15;
            else currentXPosition += 14;

            lastNoteEndXPosition = currentXPosition;
        }
    }
}
