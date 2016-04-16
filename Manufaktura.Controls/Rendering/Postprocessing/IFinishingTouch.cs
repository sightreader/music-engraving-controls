using Manufaktura.Controls.Model;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
	/// <summary>
	/// Indicates that the class will be used as finishing touch when drawing score or staff.
	/// The proper method will be automatically called at the end of drawing.
	/// </summary>
	public interface IFinishingTouch
	{
		/// <summary>
		/// Performs finishing touch on measure. Called when measure is redrawn.
		/// </summary>
		/// <param name="measure">Measure</param>
		/// <param name="renderer">Renderer</param>
		void PerformOnMeasure(Measure measure, ScoreRendererBase renderer);

		/// <summary>
		/// Performs finishing touch on score
		/// </summary>
		/// <param name="score">Score</param>
		/// <param name="renderer">Renderer</param>
		void PerformOnScore(Score score, ScoreRendererBase renderer);

		/// <summary>
		/// Performs finishing touch on staff
		/// </summary>
		/// <param name="staff">Staff</param>
		/// <param name="renderer">Renderer</param>
		void PerformOnStaff(Staff staff, ScoreRendererBase renderer);
	}
}