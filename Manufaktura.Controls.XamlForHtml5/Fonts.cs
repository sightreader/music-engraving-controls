/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/


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
