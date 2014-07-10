using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    class BarlineRenderStrategy : MusicalSymbolRenderStrategy<Barline>
    {
        public override void Render(Barline element, ScoreRendererBase renderer)
        {
            Barline barline = (Barline)symbol;
            if (lastNoteInMeasureEndXPosition > currentXPosition)
            {
                currentXPosition = lastNoteInMeasureEndXPosition;
            }
            if (barline.RepeatSign == RepeatSignType.None)
            {
                currentXPosition += 16;
                g.DrawLine(pen, new Point(currentXPosition, lines[4]), new Point(currentXPosition, lines[0]));
                currentXPosition += 6;
            }
            else if (barline.RepeatSign == RepeatSignType.Forward)
            {
                //Przesuń w lewo jeśli przed znakiem repetycji znajduje się zwykła kreska taktowa
                //Move to the left if there is a plain measure bar before the repeat sign
                if (incipit.IndexOf(symbol) > 0)
                {
                    MusicalSymbol s = incipit[incipit.IndexOf(symbol) - 1];
                    if (s.Type == MusicalSymbolType.Barline)
                    {
                        if (((Barline)s).RepeatSign == RepeatSignType.None)
                            currentXPosition -= 16;
                    }
                }
                currentXPosition += 2;
                g.DrawString(MusicalCharacters.RepeatForward, FontStyles.StaffFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition,
                    lines[0] - 15.5f);
                currentXPosition += 20;
            }
            else if (barline.RepeatSign == RepeatSignType.Backward)
            {
                currentXPosition -= 2;
                g.DrawString(MusicalCharacters.RepeatBackward, FontStyles.StaffFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition,
                    lines[0] - 15.5f);
                currentXPosition += 6;
            }
            firstNoteInMeasureXPosition = currentXPosition;

            for (int i = 0; i < 7; i++)
                alterationsWithinOneBar[i] = 0;

            currentMeasure++;
        }
    }
}
