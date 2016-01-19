
using System.Collections.Generic;

using Manufaktura.Controls.Model.Fonts;
using Windows.UI.Xaml.Media;

namespace Manufaktura.Controls.XamlForHtml5
{
    public static class Fonts
    {
		private static FontFamily PolihymniaFamily = new FontFamily("Polihymnia");// new DummyControl().dummyTextBlock.FontFamily;

        private static Dictionary<MusicFontStyles, FontFamily> _fonts = new Dictionary<Model.Fonts.MusicFontStyles, FontFamily>()
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

        private static Dictionary<MusicFontStyles, double> _fontSizes = new Dictionary<MusicFontStyles, double>()
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

        public static FontFamily Get(MusicFontStyles style)
        {
            return _fonts[style];
        }

        public static double GetSize(MusicFontStyles style)
        {
            return _fontSizes[style];
        }
    }
}
