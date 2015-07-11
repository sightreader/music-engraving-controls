using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public class StaffRenderStrategy : MusicalSymbolRenderStrategy<Staff>
    {
        private readonly IScoreService scoreService;
        public StaffRenderStrategy(IScoreService scoreService)
        {
            this.scoreService = scoreService;
        }
        public bool WasSystemChanged { get; set; }

        public override void Render(Staff element, ScoreRendererBase renderer)
        {
            double sharpLineModifier = 0.5;

            if (!WasSystemChanged)
            {
                for (int i = 0; i < 5; i++)
                {
                    scoreService.CurrentLinePositions[i] = renderer.Settings.PaddingTop + i * renderer.Settings.LineSpacing + sharpLineModifier;
                }
            }
        }

        public static void Draw(Staff staff, ScoreRendererBase renderer, double[] linePositions, double width)
        {
            foreach (double position in linePositions)
            {
                Point startPoint = new Point(0, position);
                Point endPoint = new Point(width, position);
                renderer.DrawLine(startPoint, endPoint, new Pen(renderer.Settings.DefaultColor, 1, -1), staff);
            }
        }
    }
}
