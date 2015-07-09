using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
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
            if (renderer.State.lastNoteInMeasureEndXPosition > renderer.State.CursorPositionX)
            {
                renderer.State.CursorPositionX = renderer.State.lastNoteInMeasureEndXPosition;
            }

            double? measureWidth = GetCursorPositionForCurrentBarline(renderer);
            if (!renderer.Settings.IgnoreCustomElementPositions && measureWidth.HasValue && element.Location == HorizontalPlacement.Right) renderer.State.CursorPositionX = measureWidth.Value;

            if (element.RepeatSign == RepeatSignType.None)
            {
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) renderer.State.CursorPositionX += 16;
                if (element.Location == HorizontalPlacement.Right) renderer.State.LastMeasurePositionX = renderer.State.CursorPositionX;
                renderer.DrawLine(new Point(renderer.State.CursorPositionX, renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][4]),
                                  new Point(renderer.State.CursorPositionX, renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][0]), element);
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) renderer.State.CursorPositionX += 6;
            }
            else if (element.RepeatSign == RepeatSignType.Forward)
            {
                if (renderer.State.CurrentStaff.Elements.IndexOf(element) > 0)
                {
                        renderer.State.CursorPositionX -= 8;   //TODO: Temporary workaround!!
                }
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) renderer.State.CursorPositionX += 2;
                if (element.Location == HorizontalPlacement.Right)  renderer.State.LastMeasurePositionX = renderer.State.CursorPositionX;
                renderer.DrawString(renderer.State.CurrentFont.RepeatForward, MusicFontStyles.StaffFont, renderer.State.CursorPositionX,
                    renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][0] - 15.5f, element);
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) renderer.State.CursorPositionX += 20;
            }
            else if (element.RepeatSign == RepeatSignType.Backward)
            {
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) renderer.State.CursorPositionX -= 2;
                if (element.Location == HorizontalPlacement.Right) renderer.State.LastMeasurePositionX = renderer.State.CursorPositionX;
                renderer.DrawString(renderer.State.CurrentFont.RepeatBackward, MusicFontStyles.StaffFont, renderer.State.CursorPositionX - 17.5,
                    renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][0] - 15, element);
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) renderer.State.CursorPositionX += 6;
            }
            renderer.State.firstNoteInMeasureXPosition = renderer.State.CursorPositionX;

            if (element.Location == HorizontalPlacement.Right)   //Start new measure only if it's right barline
            {
                for (int i = 0; i < 7; i++)
                    renderer.State.alterationsWithinOneBar[i] = 0;

                renderer.State.CurrentMeasure++;
            }
        }

        public double? GetCursorPositionForCurrentBarline(ScoreRendererBase renderer)
        {
            Staff staff = renderer.State.CurrentStaff;
            if (staff.MeasureWidths.Count <= renderer.State.CurrentMeasure) return null;
            double? width = staff.MeasureWidths[renderer.State.CurrentMeasure];
            if (!width.HasValue) return null;
            return renderer.State.LastMeasurePositionX + width * renderer.Settings.CustomElementPositionRatio;
        }
    }
}
