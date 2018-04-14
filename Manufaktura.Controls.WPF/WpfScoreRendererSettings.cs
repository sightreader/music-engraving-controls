using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Manufaktura.Controls.WPF
{
    public class WpfScoreRendererSettings : ScoreRendererSettings
    {
        private static FontFamily PolihymniaFamily = new FontFamily(new Uri("pack://application:,,,/Manufaktura.Controls.WPF;component/"), "./#Polihymnia");

        private Dictionary<MusicFontStyles, Typeface> defaultFonts = new Dictionary<MusicFontStyles, Typeface>()
            {
                {MusicFontStyles.MusicFont, new Typeface(PolihymniaFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal)},
                {MusicFontStyles.GraceNoteFont, new Typeface(PolihymniaFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal)},
                {MusicFontStyles.StaffFont, new Typeface(PolihymniaFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal)},
                {MusicFontStyles.LyricsFont, new Typeface("Times New Roman")},
                {MusicFontStyles.LyricsFontBold, new Typeface("Times New Roman")},
                {MusicFontStyles.MiscArticulationFont, new Typeface("Microsoft Sans Serif")},
                {MusicFontStyles.DirectionFont, new Typeface("Microsoft Sans Serif")},
                {MusicFontStyles.TrillFont, new Typeface("Times New Roman")},
                {MusicFontStyles.TimeSignatureFont, new Typeface(new FontFamily("Microsoft Sans Serif"), FontStyles.Normal, FontWeights.Bold, FontStretches.Normal)}
            };

        private Dictionary<MusicFontStyles, double> defaultFontSizes = new Dictionary<MusicFontStyles, double>()
        {
                {MusicFontStyles.MusicFont, 27.5},
                {MusicFontStyles.GraceNoteFont, 20},
                {MusicFontStyles.StaffFont, 30.5},
                {MusicFontStyles.LyricsFont, 11},
                {MusicFontStyles.LyricsFontBold, 0.8},
                {MusicFontStyles.MiscArticulationFont, 14},
                {MusicFontStyles.DirectionFont, 11},
                {MusicFontStyles.TrillFont, 14},
                {MusicFontStyles.TimeSignatureFont, 14.5}
        };

        private Dictionary<MusicFontStyles, Typeface> fonts = new Dictionary<MusicFontStyles, Typeface>()
            {
                {MusicFontStyles.MusicFont, new Typeface(PolihymniaFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal)},
                {MusicFontStyles.GraceNoteFont, new Typeface(PolihymniaFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal)},
                {MusicFontStyles.StaffFont, new Typeface(PolihymniaFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal)},
                {MusicFontStyles.LyricsFont, new Typeface("Times New Roman")},
                {MusicFontStyles.LyricsFontBold, new Typeface("Times New Roman")},
                {MusicFontStyles.MiscArticulationFont, new Typeface("Microsoft Sans Serif")},
                {MusicFontStyles.DirectionFont, new Typeface("Microsoft Sans Serif")},
                {MusicFontStyles.TrillFont, new Typeface("Times New Roman")},
                {MusicFontStyles.TimeSignatureFont, new Typeface(new FontFamily("Microsoft Sans Serif"), FontStyles.Normal, FontWeights.Bold, FontStretches.Normal)}
            };

        private Dictionary<MusicFontStyles, double> fontSizes = new Dictionary<MusicFontStyles, double>()
        {
                {MusicFontStyles.MusicFont, 27.5},
                {MusicFontStyles.GraceNoteFont, 20},
                {MusicFontStyles.StaffFont, 30.5},
                {MusicFontStyles.LyricsFont, 11},
                {MusicFontStyles.LyricsFontBold, 0.8},
                {MusicFontStyles.MiscArticulationFont, 14},
                {MusicFontStyles.DirectionFont, 11},
                {MusicFontStyles.TrillFont, 14},
                {MusicFontStyles.TimeSignatureFont, 14.5}
        };

        public Typeface GetFont(MusicFontStyles style)
        {
            return fonts[style];
        }

        public double GetFontSize(MusicFontStyles style)
        {
            return fontSizes[style];
        }

        public void SetFont(MusicFontStyles style, FontFamily family, double fontSize = 0)
        {
            fonts[style] = new Typeface(family, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
            if (fontSize != 0) fontSizes[style] = fontSize;
            else fontSizes[style] = defaultFontSizes[MusicFontStyles.TrillFont];
        }

        public void SetPolihymniaFont()
        {
            CurrentFont = new PolihymniaFont();
            CurrentSMuFLMetadata = null;

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