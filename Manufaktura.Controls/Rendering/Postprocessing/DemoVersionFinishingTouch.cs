#define DemoVersion

using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
	/// <summary>
	/// Draws text "Demo" in the corners of controls.
	/// </summary>
	public class DemoVersionFinishingTouch : IFinishingTouch
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
        /// Applies DemoVersionFinishingTouch to the score.
        /// </summary>
        /// <param name="score">Score</param>
        /// <param name="renderer">Score renderer</param>
		public void PerformOnScore(Score score, ScoreRendererBase renderer)
		{
#if DemoVersion
			foreach (var location in new[] {
				new Point(0, 15),
				new Point(renderer.ScoreInformation.Systems.Max(s => s.Width) - 30, 15)})
			{
				renderer.DrawString("DEMO", MusicFontStyles.LyricsFont, location, Color.Red, MusicalSymbol.Null);
			}
#endif
		}

        /// <summary>
        /// This method does nothing in this implementation of IFinishingTouch.
        /// </summary>
        /// <param name="staff">staff</param>
        /// <param name="renderer">Score renderer</param>
        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
		{
		}
	}
}