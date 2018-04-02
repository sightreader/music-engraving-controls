using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
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
			var location = new Point(-30, system.LinePositions[1][0]);
			var size = new Size(25, system.LinePositions[part.Staves.Count][4] - system.LinePositions[1][0]);
			renderer.DrawCharacterInBounds(renderer.Settings.CurrentFont.LeftBracket, Model.Fonts.MusicFontStyles.MusicFont, location, size,
				renderer.Settings.DefaultColor, part.Staves.First());
		}
	}
}