using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
	/// <summary>
	/// Finishing touch that draws lines between staves if multiple staves are present in the score.
	/// </summary>
	public class DrawLinesBetweenStavesFinishingTouch : IFinishingTouch
	{
		private readonly IScoreService scoreService;

		public DrawLinesBetweenStavesFinishingTouch(IScoreService scoreService)
		{
			this.scoreService = scoreService;
		}

		public void PerformOnMeasure(Measure measure, ScoreRendererBase renderer)
		{
		}

		public void PerformOnScore(Score score, ScoreRendererBase renderer)
		{
			var lightPen = new Pen(renderer.Settings.DefaultColor, 1);
			var thickPen = new Pen(renderer.Settings.DefaultColor, 3);

			for (var i = 0; i < scoreService.CurrentScore.Staves.Count - 1; i++)
			{
				var staff = scoreService.CurrentScore.Staves[i];
				foreach (var system in scoreService.CurrentScore.Systems)
				{
					if (renderer.Settings.RenderingMode == ScoreRenderingModes.SinglePage)
					{
						var page = staff.Score.Pages.FirstOrDefault(p => p.Systems.Contains(system));
						var pageNumber = page == null ? -1 : staff.Score.Pages.IndexOf(page) + 1;
						if (pageNumber != renderer.Settings.CurrentPage) continue;
					}

					if (system.LinePositions == null) continue;
					var staffFragment = system.Staves[i];
					if (!system.LinePositions.ContainsKey(i + 1) || !system.LinePositions.ContainsKey(i + 2)) continue;
					renderer.DrawLine(0, system.LinePositions[i + 1][4], 0, system.LinePositions[i + 2][0], staffFragment);
					foreach (var measure in staff.Measures.Where(m => m.Barline != null && m.System == system))
					{
						if (measure.Barline?.Style == BarlineStyle.LightHeavy)
						{
							renderer.DrawLine(measure.BarlineLocationX - 6, system.LinePositions[i + 1][4], measure.BarlineLocationX - 6, system.LinePositions[i + 2][0], lightPen, measure.Barline);
							renderer.DrawLine(measure.BarlineLocationX - 1.5, system.LinePositions[i + 1][4], measure.BarlineLocationX - 1.5, system.LinePositions[i + 2][0], thickPen, measure.Barline);
						}
						else
						{
							renderer.DrawLine(measure.BarlineLocationX, system.LinePositions[i + 1][4], measure.BarlineLocationX, system.LinePositions[i + 2][0], measure.Barline);
						}
					}
				}
			}
		}

		public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
		{
		}
	}
}