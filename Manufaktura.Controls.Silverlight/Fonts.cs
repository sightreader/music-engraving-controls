using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Manufaktura.Controls.Silverlight
{
    public static class Fonts
    {
        private static FontFamily PolihymniaFamily = new DummyControl().dummyTextBlock.FontFamily;

        private static Dictionary<Model.FontStyles, FontFamily> _fonts = new Dictionary<Model.FontStyles, FontFamily>()
            {
                {Model.FontStyles.MusicFont, PolihymniaFamily},
                {Model.FontStyles.GraceNoteFont, PolihymniaFamily},
                {Model.FontStyles.StaffFont, PolihymniaFamily},
                {Model.FontStyles.LyricsFont, new FontFamily("Segoe UI")},
                {Model.FontStyles.LyricsFontBold, new FontFamily("Segoe UI")},
                {Model.FontStyles.MiscArticulationFont, new FontFamily("Microsoft Sans Serif")},
                {Model.FontStyles.DirectionFont, new FontFamily("Microsoft Sans Serif")},
                {Model.FontStyles.TrillFont, new FontFamily("Times New Roman")},
                {Model.FontStyles.TimeSignatureFont, new FontFamily("Microsoft Sans Serif")}
            };

        private static Dictionary<Model.FontStyles, double> _fontSizes = new Dictionary<Model.FontStyles, double>()
        {
                {Model.FontStyles.MusicFont, 27.5},
                {Model.FontStyles.GraceNoteFont, 20},
                {Model.FontStyles.StaffFont, 1.9},
                {Model.FontStyles.LyricsFont, 11},
                {Model.FontStyles.LyricsFontBold, 0.8},
                {Model.FontStyles.MiscArticulationFont, 14},
                {Model.FontStyles.DirectionFont, 11},
                {Model.FontStyles.TrillFont, 14},
                {Model.FontStyles.TimeSignatureFont, 14.5}
        };

        public static FontFamily Get(Model.FontStyles style)
        {
            return _fonts[style];
        }

        public static double GetSize(Model.FontStyles style)
        {
            return _fontSizes[style];
        }
    }
}
