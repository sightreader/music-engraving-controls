﻿using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
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
            if (renderer.State.lastNoteInMeasureEndXPosition > renderer.State.currentXPosition)
            {
                renderer.State.currentXPosition = renderer.State.lastNoteInMeasureEndXPosition;
            }
            if (element.RepeatSign == RepeatSignType.None)
            {
                renderer.State.currentXPosition += 16;
                renderer.DrawLine(new Point(renderer.State.currentXPosition, renderer.State.lines[4]), new Point(renderer.State.currentXPosition, renderer.State.lines[0]));
                renderer.State.currentXPosition += 6;
            }
            else if (element.RepeatSign == RepeatSignType.Forward)
            {
                //Przesuń w lewo jeśli przed znakiem repetycji znajduje się zwykła kreska taktowa
                //Move to the left if there is a plain measure bar before the repeat sign
                if (renderer.State.CurrentStaff.Elements.IndexOf(element) > 0)
                {
                    MusicalSymbol s = renderer.State.CurrentStaff.Elements[renderer.State.CurrentStaff.Elements.IndexOf(element) - 1];
                    if (s.Type == MusicalSymbolType.Barline)
                    {
                        if (((Barline)s).RepeatSign == RepeatSignType.None)
                            renderer.State.currentXPosition -= 16;
                    }
                }
                renderer.State.currentXPosition += 2;
                renderer.DrawString(MusicalCharacters.RepeatForward, FontStyles.StaffFont, renderer.State.currentXPosition,
                    renderer.State.lines[0] - 15.5f);
                renderer.State.currentXPosition += 20;
            }
            else if (element.RepeatSign == RepeatSignType.Backward)
            {
                renderer.State.currentXPosition -= 2;
                renderer.DrawString(MusicalCharacters.RepeatBackward, FontStyles.StaffFont, renderer.State.currentXPosition,
                    renderer.State.lines[0] - 15.5f);
                renderer.State.currentXPosition += 6;
            }
            renderer.State.firstNoteInMeasureXPosition = renderer.State.currentXPosition;

            for (int i = 0; i < 7; i++)
                renderer.State.alterationsWithinOneBar[i] = 0;

            renderer.State.currentMeasure++;
        }
    }
}