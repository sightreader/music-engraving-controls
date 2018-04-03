using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Primitives;

namespace Manufaktura.Controls.Rendering
{
	/// <summary>
	/// Initial settings of score renderer.
	/// </summary>
	public class ScoreRendererSettings
	{
		/// <summary>
		/// Initializes a new instance of ScoreRendererSettings
		/// </summary>
		public ScoreRendererSettings()
		{
			RenderingMode = ScoreRenderingModes.Panorama;
			IgnoreCustomElementPositions = false;
			CustomElementPositionRatio = 0.7d;
			PageWidth = 200;
			PaddingTop = 20;
			LineSpacing = 6;
			DefaultColor = Color.Black;
			CurrentFont = new PolihymniaFont();
		}

		/// <summary>
		/// Key mapping for current font
		/// </summary>
		public IMusicFont CurrentFont { get; set; }

        public SMuFLFontMetadata CurrentSMuFLMetadata { get; set; }

		/// <summary>
		/// Page to display if renderer is in SinglePage mode.
		/// </summary>
		public int CurrentPage { get; set; }

		public double CustomElementPositionRatio { get; set; }

		/// <summary>
		/// Default color
		/// </summary>
		public Color DefaultColor { get; set; }

		/// <summary>
		/// True, to ignore element positions which are implicitly set in MusicXml file
		/// </summary>
		public bool IgnoreCustomElementPositions { get; set; }

		/// <summary>
		/// Default line spacing
		/// </summary>
		public int LineSpacing { get; private set; }

		/// <summary>
		/// Default padding top
		/// </summary>
		public int PaddingTop { get; private set; }

		/// <summary>
		/// Default page width
		/// </summary>
		public double PageWidth { get; set; }

		/// <summary>
		/// Rendering moed
		/// </summary>
		public ScoreRenderingModes RenderingMode { get; set; }

	}
}