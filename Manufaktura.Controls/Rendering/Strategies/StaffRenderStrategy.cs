using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    class StaffRenderStrategy : MusicalSymbolRenderStrategy<Staff>
    {
        public bool WasSystemChanged { get; set; }

        public override void Render(Staff element, ScoreRendererBase renderer)
        {
            double sharpLineModifier = 0.5;

            if (!WasSystemChanged)
            {
                for (int i = 0; i < 5; i++)
                {
                    renderer.State.LinePositions[renderer.State.CurrentSystem][i] = renderer.Settings.PaddingTop + i * renderer.Settings.LineSpacing + sharpLineModifier;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Point startPoint = new Point(0, renderer.State.LinePositions[renderer.State.CurrentSystem][i]);
                Point endPoint = new Point(renderer.Settings.PageWidth, renderer.State.LinePositions[renderer.State.CurrentSystem][i]);
                renderer.DrawLine(startPoint, endPoint, element);
            }
        }
    }
}
