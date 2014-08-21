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
        public override void Render(Staff element, ScoreRendererBase renderer)
        {
            double sharpLineModifier = 0.5;

            Point startPoint = new Point(0, renderer.Settings.PaddingTop + sharpLineModifier);
            Point endPoint = new Point(renderer.Settings.PageWidth, renderer.Settings.PaddingTop + sharpLineModifier);

            for (int i = 0; i < 5; i++)
            {
                renderer.DrawLine(startPoint, endPoint, element);
                renderer.State.LinePositions[i] = renderer.Settings.PaddingTop + i * renderer.Settings.LineSpacing;
                startPoint.Y += renderer.Settings.LineSpacing;
                endPoint.Y += renderer.Settings.LineSpacing;
            }
        }
    }
}
