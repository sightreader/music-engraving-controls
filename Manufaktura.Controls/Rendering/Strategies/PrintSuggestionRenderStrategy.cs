using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Services;

namespace Manufaktura.Controls.Rendering.Strategies
{
	/// <summary>
	/// Strategy for rendering a print suggestion.
	/// </summary>
	public class PrintSuggestionRenderStrategy : MusicalSymbolRenderStrategy<PrintSuggestion>
	{
		private readonly IScoreService scoreService;

		public PrintSuggestionRenderStrategy(IScoreService scoreService)
		{
			this.scoreService = scoreService;
		}

		public override void Render(PrintSuggestion element, ScoreRendererBase renderer)
		{
			if (element.IsSystemBreak && renderer.Settings.RenderingMode != ScoreRenderingModes.Panorama)
			{
				renderer.BreakSystem(renderer.TenthsToPixels(element.SystemDistance ?? scoreService.CurrentScore.DefaultPageSettings.DefaultSystemDistance ?? 0));

				MusicalSymbolRenderStrategyBase strategy = new ClefRenderStrategy(scoreService) { WasSystemChanged = true };
				strategy.Render(scoreService.CurrentClef, renderer);

				strategy = new KeyRenderStrategy(scoreService);
				strategy.Render(scoreService.CurrentKey, renderer);

				//Time signature is not rendered in new line.

				//Render measure number:
				renderer.DrawString((scoreService.CurrentMeasureNo).ToString(), MusicFontStyles.LyricsFont,
					new Primitives.Point(0, scoreService.CurrentLinePositions[0] - 25), scoreService.CurrentStaff);
			}
		}
	}
}