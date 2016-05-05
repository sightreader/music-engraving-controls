using System;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
    /// <summary>
    /// Draws lines of the staff
    /// </summary>
    public class DrawAllLinesFinishingTouch : IFinishingTouch
    {
        private readonly IScoreService scoreService;

        public DrawAllLinesFinishingTouch(IScoreService scoreService)
        {
            this.scoreService = scoreService;
        }

		public void PerformOnMeasure(Measure measure, ScoreRendererBase renderer)
		{
		}

		public void PerformOnScore(Score score, ScoreRendererBase renderer)
        {
        }

        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
        {
            foreach (var system in scoreService.Systems)
            {
                if (system.LinePositions == null) continue;
				var staffFragment = system.Staves[scoreService.CurrentStaffNo - 1];
				Draw(staff, renderer, staffFragment, system);
            }
        }

        private void Draw(Staff staff, ScoreRendererBase renderer, StaffFragmentInSystem staffFragment, StaffSystem system)
        {
            renderer.DrawLine(0, staffFragment.LinePositions[0], 0, staffFragment.LinePositions[4], staffFragment);
            foreach (double position in staffFragment.LinePositions)
            {
                Point startPoint = new Point(0, position);
                Point endPoint = new Point(system.Width, position);
                renderer.DrawLine(startPoint, endPoint, new Pen(renderer.Settings.DefaultColor, 1, -1), staffFragment);
            }
        }
    }
}