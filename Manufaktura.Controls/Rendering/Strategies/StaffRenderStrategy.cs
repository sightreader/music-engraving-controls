using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;

namespace Manufaktura.Controls.Rendering
{
    public class StaffRenderStrategy : MusicalSymbolRenderStrategy<Staff>
    {
        private readonly IScoreService scoreService;

        public StaffRenderStrategy(IScoreService scoreService)
        {
            this.scoreService = scoreService;
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

        public override void Render(Staff element, ScoreRendererBase renderer)
        {
           
        }
    }
}