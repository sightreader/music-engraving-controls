using System;
using System.Linq;
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

        /// <summary>
        /// This method does nothing in this implementation of IFinishingTouch.
        /// </summary>
        /// <param name="measure">Measure</param>
        /// <param name="renderer">Score renderer</param>
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

        private void Draw(Staff staff, ScoreRendererBase renderer, StaffFragment staffFragment, StaffSystem system)
        {
            renderer.DrawLine(0, staffFragment.LinePositions[0], 0, staffFragment.LinePositions[4], new Pen(renderer.CoalesceColor(staffFragment), renderer.Settings.DefaultStaffLineThickness), staffFragment);
            foreach (double position in staffFragment.LinePositions)
            {
                var positionX = staff.Measures.LastOrDefault(m => m.System == system)?.BarlineLocationX ?? system.Width;
                if (positionX == 0) positionX = system.Width;
                Point startPoint = new Point(0, position);
                Point endPoint = new Point(positionX, position);
                renderer.DrawLine(startPoint, endPoint, new Pen(renderer.CoalesceColor(staffFragment), renderer.Settings.DefaultStaffLineThickness, -1), staffFragment);
            }
        }
    }
}