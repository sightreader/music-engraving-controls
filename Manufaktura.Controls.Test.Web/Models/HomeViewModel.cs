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

            RadialChartSettings = new HtmlRadarChartRendererSettings();
            Samples = new[] {
            new RadarChartSample("Performance", "Performance", 50) { ValidationMinValue = 40, ValidationMaxValue = 60 },
            new RadarChartSample("User experience", "User experience", 52) { ValidationMinValue = 20, ValidationMaxValue = 40 },
            new RadarChartSample("Responsiveness", "Responsiveness", 18) { ValidationMinValue = 20, ValidationMaxValue = 40 },
            new RadarChartSample("Cost", "Cost", 30) { ValidationMinValue = 30, ValidationMaxValue = 60 },
            new RadarChartSample("Awesomeness", "Awesomeness", 37) { ValidationMinValue = 20, ValidationMaxValue = 40 }
            };
        }

        public HtmlRadarChartRendererSettings RadialChartSettings { get; private set; }
        public RadarChartSample[] Samples { get; set; }
        public Score SampleScore { get; set; }
        public HtmlScoreRendererSettings Settings { get; private set; }
    }
}