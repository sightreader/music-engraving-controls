﻿using Manufaktura.Controls.Model;
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

        public void PerformOnScore(Score score, ScoreRendererBase renderer)
        {
        }

        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
        {
            foreach (var system in scoreService.Systems)
            {
                if (system.LinePositions == null) continue;
                Draw(staff, renderer, system.LinePositions[scoreService.CurrentStaffNo], system.Width);
            }
        }

        private void Draw(Staff staff, ScoreRendererBase renderer, double[] linePositions, double width)
        {
            renderer.DrawLine(0, linePositions[0], 0, linePositions[4], staff);
            foreach (double position in linePositions)
            {
                Point startPoint = new Point(0, position);
                Point endPoint = new Point(width, position);
                renderer.DrawLine(startPoint, endPoint, new Pen(renderer.Settings.DefaultColor, 1, -1), staff);
            }
        }
    }
}