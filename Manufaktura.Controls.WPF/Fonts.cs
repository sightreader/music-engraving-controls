using Manufaktura.Controls.Model.Fonts;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Manufaktura.Controls.WPF
{
    public static class Fonts
    {
        private static FontFamily PolihymniaFamily = new FontFamily(new Uri("pack://application:,,,/Manufaktura.Controls.WPF;component/"), "./#Polihymnia");

        private static Dictionary<MusicFontStyles, Typeface> _fonts = new Dictionary<MusicFontStyles, Typeface>()
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

        private static Dictionary<MusicFontStyles, double> _fontSizes = new Dictionary<MusicFontStyles, double>()
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

        public static Typeface Get(MusicFontStyles style)
        {
            return _fonts[style];
        }

        public static void Set(MusicFontStyles style, FontFamily family)
        {
            _fonts[style] = new Typeface(family, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
        }

        public static double GetSize(MusicFontStyles style)
        {
            return _fontSizes[style];
        }
    }
}