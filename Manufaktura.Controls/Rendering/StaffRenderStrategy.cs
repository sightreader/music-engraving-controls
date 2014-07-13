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
            //Draw staff lines / Rysuj pięciolinię
            string staff = MusicalCharacters.Staff5Lines;
            for (int i = 0; i < renderer.State.PageWidth / 10; i++)
                staff = staff + MusicalCharacters.Staff5Lines;

            Point startPoint = new Point(0, renderer.State.paddingTop);
            Point endPoint = new Point(renderer.State.PageWidth, renderer.State.paddingTop);

            for (int i = 0; i < 5; i++)
            {
                renderer.DrawLine(startPoint, endPoint);
                renderer.State.LinePositions[i] = renderer.State.paddingTop + i * renderer.State.lineSpacing;
                startPoint.Y += renderer.State.lineSpacing;
                endPoint.Y += renderer.State.lineSpacing;

            }
            renderer.DrawString(staff, FontStyles.StaffFont, renderer.State.CursorPositionX, renderer.State.paddingTop - 3);

            
        }
    }
}
