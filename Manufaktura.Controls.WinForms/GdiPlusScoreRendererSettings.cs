using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using System.Drawing;

namespace Manufaktura.Controls.WinForms
{
    public class GdiPlusScoreRendererSettings : ScoreRendererSettings
    {
        private Dictionary<MusicFontStyles, Font> defaultFonts = new Dictionary<MusicFontStyles, Font>()
            {
                {MusicFontStyles.MusicFont, new Font("Polihymnia", 27.5f, GraphicsUnit.Pixel)},
                {MusicFontStyles.GraceNoteFont, new Font("Polihymnia", 20, GraphicsUnit.Pixel)},
                {MusicFontStyles.StaffFont, new Font("Polihymnia", 30.5f, GraphicsUnit.Pixel)},
                {MusicFontStyles.LyricsFont, new Font("Times New Roman", 11, GraphicsUnit.Pixel)},
                {MusicFontStyles.LyricsFontBold, new Font("Times New Roman", 11, FontStyle.Bold, GraphicsUnit.Pixel)},
                {MusicFontStyles.MiscArticulationFont, new Font("Microsoft Sans Serif", 14, FontStyle.Bold, GraphicsUnit.Pixel)},
                {MusicFontStyles.DirectionFont, new Font("Microsoft Sans Serif", 11, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel)},
                {MusicFontStyles.TrillFont, new Font("Times New Roman", 14, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel)},
                {MusicFontStyles.TimeSignatureFont, new Font("Microsoft Sans Serif", 14.5f, FontStyle.Bold, GraphicsUnit.Pixel)}
            };

        private Dictionary<MusicFontStyles, Font> fonts = new Dictionary<MusicFontStyles, Font>()
            {
                {MusicFontStyles.MusicFont, new Font("Polihymnia", 27.5f, GraphicsUnit.Pixel)},
                {MusicFontStyles.GraceNoteFont, new Font("Polihymnia", 20, GraphicsUnit.Pixel)},
                {MusicFontStyles.StaffFont, new Font("Polihymnia", 30.5f, GraphicsUnit.Pixel)},
                {MusicFontStyles.LyricsFont, new Font("Times New Roman", 11, GraphicsUnit.Pixel)},
                {MusicFontStyles.LyricsFontBold, new Font("Times New Roman", 11, FontStyle.Bold, GraphicsUnit.Pixel)},
                {MusicFontStyles.MiscArticulationFont, new Font("Microsoft Sans Serif", 14, FontStyle.Bold, GraphicsUnit.Pixel)},
                {MusicFontStyles.DirectionFont, new Font("Microsoft Sans Serif", 11, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel)},
                {MusicFontStyles.TrillFont, new Font("Times New Roman", 14, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel)},
                {MusicFontStyles.TimeSignatureFont, new Font("Microsoft Sans Serif", 14.5f, FontStyle.Bold, GraphicsUnit.Pixel)}
            };
        public GdiPlusScoreRendererSettings()
        {
        }

        public Font GetFont(MusicFontStyles style)
        {
            return fonts[style];
        }

        public void SetFont(MusicFontStyles style, string fontName, float fontSize, FontStyle fontStyle = FontStyle.Regular)
        {
            fonts[style] = new Font(fontName, fontSize, fontStyle, GraphicsUnit.Pixel);
        }

        public override void SetPolihymniaFont()
        {
            base.SetPolihymniaFont();

            fonts[MusicFontStyles.MusicFont] = defaultFonts[MusicFontStyles.MusicFont];
            fonts[MusicFontStyles.GraceNoteFont] = defaultFonts[MusicFontStyles.GraceNoteFont];
            fonts[MusicFontStyles.StaffFont] = defaultFonts[MusicFontStyles.StaffFont];
            fonts[MusicFontStyles.TimeSignatureFont] = defaultFonts[MusicFontStyles.TimeSignatureFont];
            fonts[MusicFontStyles.TrillFont] = defaultFonts[MusicFontStyles.TrillFont];
        }
    }
}