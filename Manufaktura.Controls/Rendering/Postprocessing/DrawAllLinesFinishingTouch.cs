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
            var staffLinePen = renderer.CreatePenFromDefaults(staff, "staffLineThickness", s => s.DefaultStaffLineThickness);
            staffLinePen.ZIndex = -1;

            foreach (var system in scoreService.Systems)
            {
                if (system.LinePositions == null) continue;
				var staffFragment = system.Staves[scoreService.CurrentStaffNo - 1];
				Draw(staff, renderer, staffFragment, system, staffLinePen);
            }
        }

        private void Draw(Staff staff, ScoreRendererBase renderer, StaffFragment staffFragment, StaffSystem system, Pen staffLinePen)
        {
            renderer.DrawLine(0, staffFragment.LinePositions[0], 0, staffFragment.LinePositions[4], staffLinePen, staffFragment);
            foreach (double linePositionY in staffFragment.LinePositions)
            {
                var positionX = staff.Measures.LastOrDefault(m => m.System == system)?.BarlineLocationX ?? system.Width;
                if (positionX == 0) positionX = system.Width;
                Point startPoint = new Point(0, linePositionY);
                Point endPoint = new Point(positionX, linePositionY);
                renderer.DrawLine(startPoint, endPoint, staffLinePen, staffFragment);
            }
        }
    }
}