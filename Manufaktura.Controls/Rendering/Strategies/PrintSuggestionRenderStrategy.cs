using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Services;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Strategies
{
	/// <summary>
	/// Strategy for rendering a print suggestion.
	/// </summary>
	public class PrintSuggestionRenderStrategy : MusicalSymbolRenderStrategy<PrintSuggestion>
	{
		private readonly IScoreService scoreService;

        /// <summary>
        /// Initializes a new instance of PrintSuggestionRenderStrategy
        /// </summary>
        /// <param name="scoreService"></param>
        public PrintSuggestionRenderStrategy(IScoreService scoreService)
		{
			this.scoreService = scoreService;
		}

        /// <summary>
        /// Renders print suggestion with specific score renderer
        /// </summary>
        /// <param name="element"></param>
        /// <param name="renderer"></param>
		public override void Render(PrintSuggestion element, ScoreRendererBase renderer)
		{
			if (element.IsSystemBreak && renderer.Settings.RenderingMode != ScoreRenderingModes.Panorama)
			{
				renderer.BreakSystem(renderer.TenthsToPixels(element.SystemDistance ?? scoreService.CurrentScore.DefaultPageSettings.DefaultSystemDistance ?? 0), element.IsPageBreak);

				MusicalSymbolRenderStrategyBase strategy = new ClefRenderStrategy(scoreService) { WasSystemChanged = true };
				strategy.Render(scoreService.CurrentClef, renderer);

				strategy = new KeyRenderStrategy(scoreService);
				strategy.Render(scoreService.CurrentKey, renderer);

				//Time signature is not rendered in new line.

				//Render measure number:
				renderer.DrawString((scoreService.CurrentMeasureNo).ToString(), MusicFontStyles.LyricsFont,
					new Primitives.Point(0, scoreService.CurrentLinePositions[0] - 25), scoreService.CurrentStaff);
			}

			//Issue #44: Jeśli jesteśmy w trybie panoramy, to trzeba uzupełnić line positions dla pozostałych systemów:
			if (renderer.Settings.RenderingMode == ScoreRenderingModes.Panorama)
			{
				var firstSystem = scoreService.Systems.First();
				foreach (var system in scoreService.Systems)
				{
					system.BuildStaffFragments(firstSystem.LinePositions.ToDictionary(p => scoreService.CurrentScore.Staves[p.Key - 1], p => p.Value));
				}
			}
		}
	}
}