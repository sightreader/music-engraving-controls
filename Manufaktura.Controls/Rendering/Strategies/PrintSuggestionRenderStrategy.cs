using Manufaktura.Controls.Model;
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
                renderer.State.CursorPositionX = 0;
                double staffHeight = renderer.State.LinePositions[renderer.State.CurrentSystem].Max() - renderer.State.LinePositions[renderer.State.CurrentSystem].Min();
                double shift = element.SystemDistance == 0 ? staffHeight + renderer.Settings.LineSpacing : element.SystemDistance;

                List<double> newLinePositions = new List<double>();
                foreach (var position in renderer.State.LinePositions[renderer.State.CurrentSystem]) newLinePositions.Add(position + shift);
                renderer.State.CurrentSystem++;
                renderer.State.LinePositions.Add(renderer.State.CurrentSystem, newLinePositions.ToArray());
            }
        }
    }
}
