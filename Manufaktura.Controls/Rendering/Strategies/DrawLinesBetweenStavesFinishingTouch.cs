using Manufaktura.Controls.Model;
using Manufaktura.Controls.Services;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Strategies
{
    public class DrawLinesBetweenStavesFinishingTouch : IFinishingTouch
    {
        private readonly IScoreService scoreService;

        public DrawLinesBetweenStavesFinishingTouch(IScoreService scoreService)
        {
            this.scoreService = scoreService;
        }

        public void PerformOnScore(Score score, ScoreRendererBase renderer)
        {
            for (var i = 0; i < scoreService.CurrentScore.Staves.Count - 1; i++)
            {
                var staff = scoreService.CurrentScore.Staves[i];
                foreach (var system in scoreService.Systems)
                {
                    foreach (var measure in scoreService.AllMeasures.Where(m => m.Barline != null && m.System == system && m.Staff == staff))
                    {
                        renderer.DrawLine(measure.BarlineLocationX, system.LinePositions[i + 1][4], measure.BarlineLocationX, system.LinePositions[i + 2][0], measure.Barline);
                    }
                }
            }
        }

        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
        {
        }
    }
}