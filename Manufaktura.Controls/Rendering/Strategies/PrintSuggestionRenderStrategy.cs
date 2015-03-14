using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Strategies
{
    class PrintSuggestionRenderStrategy : MusicalSymbolRenderStrategy<PrintSuggestion>
    {
        public override void Render(PrintSuggestion element, ScoreRendererBase renderer)
        {
            if (element.IsSystemBreak && !renderer.Settings.IsPanoramaMode)
            {
                if (renderer.State.CurrentStaff.ActualSystemWidths.Count < renderer.State.CurrentSystem) renderer.State.CurrentStaff.ActualSystemWidths.Add(0);
                renderer.State.CurrentStaff.ActualSystemWidths[renderer.State.CurrentSystem - 1] = renderer.State.CursorPositionX;

                renderer.State.CursorPositionX = 0;
                double staffHeight = renderer.State.LinePositions[renderer.State.CurrentSystem].Max() - renderer.State.LinePositions[renderer.State.CurrentSystem].Min();
                double shift = element.SystemDistance == 0 ? staffHeight + renderer.Settings.LineSpacing : element.SystemDistance;
                renderer.State.CurrentSystemShiftY += shift;

                List<double> newLinePositions = new List<double>();
                foreach (var position in renderer.State.LinePositions[renderer.State.CurrentSystem]) newLinePositions.Add(position + shift);
                renderer.State.CurrentSystem++;
                renderer.State.LinePositions.Add(renderer.State.CurrentSystem, newLinePositions.ToArray());
                renderer.State.LastMeasurePositionX = 0;

                MusicalSymbolRenderStrategyBase strategy = new ClefRenderStrategy() { WasSystemChanged = true };
                strategy.Render(renderer.State.CurrentClef, renderer);

                strategy = new StaffRenderStrategy() { WasSystemChanged = true };
                strategy.Render(renderer.State.CurrentStaff, renderer);

                strategy = new KeyRenderStrategy();
                strategy.Render(renderer.State.CurrentKey, renderer);

                //Time signature is not rendered in new line.
            
                //Render measure number:
                renderer.DrawString((renderer.State.CurrentMeasure + 1).ToString(), MusicFontStyles.LyricsFont, 
                    new Primitives.Point(0, renderer.State.LinePositions[renderer.State.CurrentSystem][0] - 25), renderer.State.CurrentStaff);
            }
        }
    }
}
