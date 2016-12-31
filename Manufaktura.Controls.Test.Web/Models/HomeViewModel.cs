using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using Manufaktura.Controls.Rendering.Implementations;

namespace Manufaktura.Controls.Test.Web.Models
{
	public class HomeViewModel
	{
		public static HtmlScoreRendererSettings ScoreRendererSettings
		{
			get
			{
				var settings = new HtmlScoreRendererSettings();
				settings.RenderSurface = HtmlScoreRendererSettings.HtmlRenderSurface.Svg;
				var musicFontUris = new[] { "/fonts/Polihymnia.svg", "/fonts/Polihymnia.ttf", "/fonts/Polihymnia.woff" };
				settings.RenderingMode = ScoreRenderingModes.AllPages;
				settings.Fonts.Add(MusicFontStyles.MusicFont, new HtmlFontInfo("Polihymnia", 22, musicFontUris));
                settings.Fonts.Add(MusicFontStyles.StaffFont, new HtmlFontInfo("Polihymnia", 24, musicFontUris));
                settings.Fonts.Add(MusicFontStyles.GraceNoteFont, new HtmlFontInfo("Polihymnia", 14, musicFontUris));
				settings.Fonts.Add(MusicFontStyles.LyricsFont, new HtmlFontInfo("Open Sans", 9, "/fonts/OpenSans-Regular.ttf"));
				settings.Fonts.Add(MusicFontStyles.TimeSignatureFont, new HtmlFontInfo("Open Sans", 12, "/fonts/OpenSans-Regular.ttf"));
				settings.Fonts.Add(MusicFontStyles.DirectionFont, new HtmlFontInfo("Open Sans", 10, "/fonts/OpenSans-Regular.ttf"));
				return settings;
			}
		}

		public Score SampleScore { get; set; }
		public HtmlScoreRendererSettings Settings => ScoreRendererSettings;
	}
}