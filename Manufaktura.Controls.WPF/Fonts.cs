using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Manufaktura.Controls.WPF
{
    public static class Fonts
    {
        private static FontFamily PolihymniaFamily = new FontFamily(new Uri("pack://application:,,,/Manufaktura.Controls.WPF;component/"), "./#Polihymnia");

        private static Dictionary<Model.FontStyles, Typeface> _fonts = new Dictionary<Model.FontStyles, Typeface>()
            {
                {Model.FontStyles.MusicFont, new Typeface(PolihymniaFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal)},
                {Model.FontStyles.GraceNoteFont, new Typeface(PolihymniaFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal)},
                {Model.FontStyles.StaffFont, new Typeface(PolihymniaFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal)},
                {Model.FontStyles.LyricsFont, new Typeface("Times New Roman")},
                {Model.FontStyles.LyricsFontBold, new Typeface("Times New Roman")},
                {Model.FontStyles.MiscArticulationFont, new Typeface("Microsoft Sans Serif")},
                {Model.FontStyles.DirectionFont, new Typeface("Microsoft Sans Serif")},
                {Model.FontStyles.TrillFont, new Typeface("Times New Roman")},
                {Model.FontStyles.TimeSignatureFont, new Typeface(new FontFamily("Microsoft Sans Serif"), FontStyles.Normal, FontWeights.Bold, FontStretches.Normal)}
            };

        private static Dictionary<Model.FontStyles, double> _fontSizes = new Dictionary<Model.FontStyles, double>()
        {
                {Model.FontStyles.MusicFont, 27.5},
                {Model.FontStyles.GraceNoteFont, 24.5},
                {Model.FontStyles.StaffFont, 1.9},
                {Model.FontStyles.LyricsFont, 11},
                {Model.FontStyles.LyricsFontBold, 0.8},
                {Model.FontStyles.MiscArticulationFont, 14},
                {Model.FontStyles.DirectionFont, 11},
                {Model.FontStyles.TrillFont, 14},
                {Model.FontStyles.TimeSignatureFont, 14.5}
        };

        public static Typeface Get(Model.FontStyles style)
        {
            return _fonts[style];
        }

        public static double GetSize(Model.FontStyles style)
        {
            return _fontSizes[style];
        }
    }
}
