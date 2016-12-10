using Manufaktura.Controls.Model.Fonts;
using System.Collections.Generic;

namespace Manufaktura.Controls.Rendering.Implementations
{
	public class HtmlScoreRendererSettings : ScoreRendererSettings
	{
		public Dictionary<MusicFontStyles, HtmlFontInfo> Fonts { get; private set; }
		public HtmlRenderSurface RenderSurface { get; set; }
		public double Height { get; set; }
		public double MusicalFontShiftX { get; set; }
		public double MusicalFontShiftY { get; set; }
		public int PlaybackTempo { get; set; } = 120;

		public HtmlScoreRendererSettings()
		{
			Fonts = new Dictionary<MusicFontStyles, HtmlFontInfo>();
			RenderSurface = HtmlRenderSurface.Canvas;
			Height = 150;
			RenderingMode = ScoreRenderingModes.Panorama;
		}

		public enum HtmlRenderSurface
		{
			/// <summary>
			/// Indicates that the score will be rendered on HTML Canvas
			/// </summary>
			Canvas,

			/// <summary>
			/// Indicates that the score will be renderer in SVG tag
			/// </summary>
			Svg
		}
	}
}