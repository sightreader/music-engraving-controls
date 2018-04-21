using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using Windows.UI.Xaml.Media;

namespace Manufaktura.Controls.UniversalApps
{
    public class UWPScoreRendererSettings : ScoreRendererSettings
    {
        private static FontFamily PolihymniaFamily = //new DummyControl().DummyFontFamily;//
            new FontFamily("Polihymnia.ttf#Polihymnia");

        private Dictionary<MusicFontStyles, System.Drawing.Font> compatibilityFonts = new Dictionary<MusicFontStyles, System.Drawing.Font>()
            {
                {MusicFontStyles.MusicFont, new System.Drawing.Font("Polihymnia", 27.5f, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.GraceNoteFont, new System.Drawing.Font("Polihymnia", 20, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.StaffFont, new System.Drawing.Font("Polihymnia", 30.5f, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.LyricsFont, new System.Drawing.Font("Times New Roman", 11, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.LyricsFontBold, new System.Drawing.Font("Times New Roman", 11, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.MiscArticulationFont, new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.DirectionFont, new System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.TrillFont, new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.TimeSignatureFont, new System.Drawing.Font("Microsoft Sans Serif", 14.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)}
            };

        private Dictionary<MusicFontStyles, System.Drawing.Font> defaultCompatibilityFonts = new Dictionary<MusicFontStyles, System.Drawing.Font>()
            {
                {MusicFontStyles.MusicFont, new System.Drawing.Font("Polihymnia", 27.5f, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.GraceNoteFont, new System.Drawing.Font("Polihymnia", 20, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.StaffFont, new System.Drawing.Font("Polihymnia", 30.5f, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.LyricsFont, new System.Drawing.Font("Times New Roman", 11, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.LyricsFontBold, new System.Drawing.Font("Times New Roman", 11, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.MiscArticulationFont, new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.DirectionFont, new System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.TrillFont, new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)},
                {MusicFontStyles.TimeSignatureFont, new System.Drawing.Font("Microsoft Sans Serif", 14.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)}
            };

        private Dictionary<MusicFontStyles, FontFamily> defaultFonts = new Dictionary<MusicFontStyles, FontFamily>()
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

        private Dictionary<MusicFontStyles, FontFamily> fonts = new Dictionary<MusicFontStyles, FontFamily>()
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
        public System.Drawing.Font GetCompatibleFont(MusicFontStyles style)
        {
            return compatibilityFonts[style];
        }

        public FontFamily GetFont(MusicFontStyles style)
        {
            return fonts[style];
        }

        public double GetFontSize(MusicFontStyles style)
        {
            return compatibilityFonts[style].Size;
        }

        public void SetFont(MusicFontStyles style, FontFamily family, double fontSize = 0)
        {
            fonts[style] = family;
            if (fontSize == 0)
                fontSize = compatibilityFonts[MusicFontStyles.TrillFont].Size;
            var compatibilityFont = compatibilityFonts[style];
            compatibilityFonts[style] = new System.Drawing.Font(compatibilityFont.FontFamily, (float)fontSize, compatibilityFont.Style, System.Drawing.GraphicsUnit.Pixel);
        }

        public void SetPolihymniaFont()
        {
            fonts[MusicFontStyles.MusicFont] = defaultFonts[MusicFontStyles.MusicFont];
            fonts[MusicFontStyles.GraceNoteFont] = defaultFonts[MusicFontStyles.GraceNoteFont];
            fonts[MusicFontStyles.StaffFont] = defaultFonts[MusicFontStyles.StaffFont];
            fonts[MusicFontStyles.TimeSignatureFont] = defaultFonts[MusicFontStyles.TimeSignatureFont];
            fonts[MusicFontStyles.TrillFont] = defaultFonts[MusicFontStyles.TrillFont];

            compatibilityFonts[MusicFontStyles.MusicFont] = defaultCompatibilityFonts[MusicFontStyles.MusicFont];
            compatibilityFonts[MusicFontStyles.GraceNoteFont] = defaultCompatibilityFonts[MusicFontStyles.GraceNoteFont];
            compatibilityFonts[MusicFontStyles.StaffFont] = defaultCompatibilityFonts[MusicFontStyles.StaffFont];
            compatibilityFonts[MusicFontStyles.TimeSignatureFont] = defaultCompatibilityFonts[MusicFontStyles.TimeSignatureFont];
            compatibilityFonts[MusicFontStyles.TrillFont] = defaultCompatibilityFonts[MusicFontStyles.TrillFont];
        }
    }
}