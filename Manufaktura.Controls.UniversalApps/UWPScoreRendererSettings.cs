using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using Windows.UI.Xaml.Media;

namespace Manufaktura.Controls.UniversalApps
{
    public class UWPScoreRendererSettings : ScoreRendererSettings
    {
        private static FontFamily PolihymniaFamily = new FontFamily("Polihymnia.ttf#Polihymnia");

        private static Dictionary<MusicFontStyles, FontFamily> fonts = new Dictionary<MusicFontStyles, FontFamily>()
            {
                {MusicFontStyles.MusicFont, PolihymniaFamily},
                {MusicFontStyles.GraceNoteFont, PolihymniaFamily},
                {MusicFontStyles.StaffFont, PolihymniaFamily},
                {MusicFontStyles.LyricsFont, new FontFamily("Segoe UI")},
                {MusicFontStyles.LyricsFontBold, new FontFamily("Segoe UI")},
                {MusicFontStyles.MiscArticulationFont, new FontFamily("Microsoft Sans Serif")},
                {MusicFontStyles.DirectionFont, new FontFamily("Microsoft Sans Serif")},
                {MusicFontStyles.TrillFont, new FontFamily("Times New Roman")},
                {MusicFontStyles.TimeSignatureFont, new FontFamily("Microsoft Sans Serif")}
            };

        private static Dictionary<MusicFontStyles, double> fontSizes = new Dictionary<MusicFontStyles, double>()
        {
                {MusicFontStyles.MusicFont, 27.5},
                {MusicFontStyles.GraceNoteFont, 20},
                {MusicFontStyles.StaffFont, 30},
                {MusicFontStyles.LyricsFont, 11},
                {MusicFontStyles.LyricsFontBold, 0.8},
                {MusicFontStyles.MiscArticulationFont, 14},
                {MusicFontStyles.DirectionFont, 11},
                {MusicFontStyles.TrillFont, 14},
                {MusicFontStyles.TimeSignatureFont, 14.5}
        };

        private static Dictionary<MusicFontStyles, FontFamily> defaultFonts = new Dictionary<MusicFontStyles, FontFamily>()
            {
                {MusicFontStyles.MusicFont, PolihymniaFamily},
                {MusicFontStyles.GraceNoteFont, PolihymniaFamily},
                {MusicFontStyles.StaffFont, PolihymniaFamily},
                {MusicFontStyles.LyricsFont, new FontFamily("Segoe UI")},
                {MusicFontStyles.LyricsFontBold, new FontFamily("Segoe UI")},
                {MusicFontStyles.MiscArticulationFont, new FontFamily("Microsoft Sans Serif")},
                {MusicFontStyles.DirectionFont, new FontFamily("Microsoft Sans Serif")},
                {MusicFontStyles.TrillFont, new FontFamily("Times New Roman")},
                {MusicFontStyles.TimeSignatureFont, new FontFamily("Microsoft Sans Serif")}
            };

        private static Dictionary<MusicFontStyles, double> defaultFontSizes = new Dictionary<MusicFontStyles, double>()
        {
                {MusicFontStyles.MusicFont, 27.5},
                {MusicFontStyles.GraceNoteFont, 20},
                {MusicFontStyles.StaffFont, 30},
                {MusicFontStyles.LyricsFont, 11},
                {MusicFontStyles.LyricsFontBold, 0.8},
                {MusicFontStyles.MiscArticulationFont, 14},
                {MusicFontStyles.DirectionFont, 11},
                {MusicFontStyles.TrillFont, 14},
                {MusicFontStyles.TimeSignatureFont, 14.5}
        };

        public FontFamily GetFont(MusicFontStyles style)
        {
            return fonts[style];
        }

        public double GetFontSize(MusicFontStyles style)
        {
            return fontSizes[style];
        }

        public void SetFont(MusicFontStyles style, FontFamily family, double fontSize = 0)
        {
            fonts[style] = family;
            if (fontSize != 0) fontSizes[style] = fontSize;
            else fontSizes[style] = defaultFontSizes[MusicFontStyles.TrillFont];
        }

        public void SetPolihymniaFont()
        {
            fonts[MusicFontStyles.MusicFont] = defaultFonts[MusicFontStyles.MusicFont];
            fonts[MusicFontStyles.GraceNoteFont] = defaultFonts[MusicFontStyles.GraceNoteFont];
            fonts[MusicFontStyles.StaffFont] = defaultFonts[MusicFontStyles.StaffFont];
            fonts[MusicFontStyles.TimeSignatureFont] = defaultFonts[MusicFontStyles.TimeSignatureFont];
            fonts[MusicFontStyles.TrillFont] = defaultFonts[MusicFontStyles.TrillFont];

            fontSizes[MusicFontStyles.MusicFont] = defaultFontSizes[MusicFontStyles.MusicFont];
            fontSizes[MusicFontStyles.GraceNoteFont] = defaultFontSizes[MusicFontStyles.GraceNoteFont];
            fontSizes[MusicFontStyles.StaffFont] = defaultFontSizes[MusicFontStyles.StaffFont];
            fontSizes[MusicFontStyles.TimeSignatureFont] = defaultFontSizes[MusicFontStyles.TimeSignatureFont];
            fontSizes[MusicFontStyles.TrillFont] = defaultFontSizes[MusicFontStyles.TrillFont];
        }
    }
}