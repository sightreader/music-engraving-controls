using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using Manufaktura.Controls.Rendering.Implementations;

namespace Manufaktura.Controls.Test.Web.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
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
            settings.Scale = 1;
            settings.CustomElementPositionRatio = 0.8;
            settings.IgnorePageMargins = true;
            Settings = settings;

            RadialChartSettings = new HtmlRadialChartRendererSettings();
            Samples = new[] {
                new RadialChartSample("A", "A", 5),
                new RadialChartSample("B", "B", 5.2),
                new RadialChartSample("C", "C", 1.8),
                new RadialChartSample("D", "D", 3),
                new RadialChartSample("E", "E", 3.7)
                };
        }

        public HtmlRadialChartRendererSettings RadialChartSettings { get; private set; }
        public RadialChartSample[] Samples { get; set; }
        public Score SampleScore { get; set; }
        public HtmlScoreRendererSettings Settings { get; private set; }
    }
}