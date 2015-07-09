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
                renderer.BreakSystem(element.SystemDistance);

                

                MusicalSymbolRenderStrategyBase strategy = new ClefRenderStrategy() { WasSystemChanged = true };
                strategy.Render(renderer.State.CurrentClef, renderer);

                strategy = new StaffRenderStrategy() { WasSystemChanged = true };
                strategy.Render(renderer.State.CurrentStaff, renderer);

                strategy = new KeyRenderStrategy();
                strategy.Render(renderer.State.CurrentKey, renderer);

                //Time signature is not rendered in new line.
            
                //Render measure number:
                renderer.DrawString((renderer.State.CurrentMeasure + 1).ToString(), MusicFontStyles.LyricsFont,
                    new Primitives.Point(0, renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][0] - 25), renderer.State.CurrentStaff);
            }
        }
    }
}
