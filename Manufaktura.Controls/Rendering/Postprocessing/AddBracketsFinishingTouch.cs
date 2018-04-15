using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
    /// <summary>
    /// Adds brackets for parts.
    /// </summary>
    public class AddBracketsFinishingTouch : IFinishingTouch
    {
        /// <summary>
        /// This method does nothing in this implementation of IFinishingTouch.
        /// </summary>
        /// <param name="measure">Measure</param>
        /// <param name="renderer">Score renderer</param>
		public void PerformOnMeasure(Measure measure, ScoreRendererBase renderer)
        {
        }

        /// <summary>
        /// Applies AddBracketsFinishingTouch to the score.
        /// </summary>
        /// <param name="score">Score</param>
        /// <param name="renderer">Score renderer</param>
		public void PerformOnScore(Score score, ScoreRendererBase renderer)
        {
            foreach (var part in score.Parts)
            {
                if (part.Staves.Count < 2) continue;
                foreach (var system in score.Systems)
                {
                    DrawBracket(system, part, renderer);
                }
            }
        }

        /// <summary>
        /// This method does nothing in this implementation of IFinishingTouch.
        /// </summary>
        /// <param name="staff">Staff</param>
        /// <param name="renderer">Score renderer</param>
        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
        {
        }

        private void DrawBracket(StaffSystem system, Part part, ScoreRendererBase renderer)
        {
            if (system.LinePositions == null) return;

            var locationXAndWidth = GetBraceLocationXAndWidth(renderer);

            var location = new Point(locationXAndWidth.Item1, system.LinePositions[1][0]);
            var size = new Size(locationXAndWidth.Item2, system.LinePositions[part.Staves.Count][4] - system.LinePositions[1][0]);
            renderer.DrawCharacterInBounds(renderer.Settings.CurrentFont.BraceLeft, Model.Fonts.MusicFontStyles.MusicFont, location, size,
                renderer.Settings.DefaultColor, part.Staves.First());
        }

        private Tuple<double, double> GetBraceLocationXAndWidth(ScoreRendererBase renderer)
        {
            if (renderer.IsSMuFLFont && renderer.Settings.CurrentSMuFLMetadata != null)
            {
                var bounds = renderer.Settings.CurrentSMuFLMetadata.GlyphBBoxes.Brace;
                var width = (bounds.BBoxNe[0] + bounds.BBoxSw[0]) * 3;  //TODO: Sprawdzić czemu Brace ma tak mały bounding box w SMuFL
                return new Tuple<double, double>(renderer.LinespacesToPixels(bounds.BBoxSw[0] * -3 - width), renderer.LinespacesToPixels(width));
            }
            else return new Tuple<double, double>(-17.5, 15);
        }
    }
}