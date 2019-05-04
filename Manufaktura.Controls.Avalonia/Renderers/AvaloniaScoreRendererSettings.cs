/*
 * Copyright 2019 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Avalonia.Media;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Avalonia.Renderers
{
    public class AvaloniaScoreRendererSettings : ScoreRendererSettings
    {
        private static FontFamily PolihymniaFamily = new FontFamily("./#Polihymnia", new Uri("pack://application:,,,/Manufaktura.Controls.Avalonia;component/"));

        private Dictionary<MusicFontStyles, Typeface> defaultFonts = new Dictionary<MusicFontStyles, Typeface>()
            {
                {MusicFontStyles.MusicFont, new Typeface(PolihymniaFamily, 27.5, FontStyle.Normal, FontWeight.Normal)},
                {MusicFontStyles.GraceNoteFont, new Typeface(PolihymniaFamily, 22, FontStyle.Normal, FontWeight.Normal)},
                {MusicFontStyles.StaffFont, new Typeface(PolihymniaFamily, 30.5, FontStyle.Normal, FontWeight.Normal)},
                {MusicFontStyles.LyricsFont, new Typeface("Times New Roman", 11)},
                {MusicFontStyles.DirectionFont, new Typeface("Microsoft Sans Serif", 14.5)},
                {MusicFontStyles.TimeSignatureFont, new Typeface(new FontFamily("Microsoft Sans Serif"), 14.5, FontStyle.Normal, FontWeight.Bold)}
            };

        private Dictionary<MusicFontStyles, Typeface> fonts = new Dictionary<MusicFontStyles, Typeface>()
            {
                {MusicFontStyles.MusicFont, new Typeface(PolihymniaFamily, 27.5, FontStyle.Normal, FontWeight.Normal)},
                {MusicFontStyles.GraceNoteFont, new Typeface(PolihymniaFamily, 22, FontStyle.Normal, FontWeight.Normal)},
                {MusicFontStyles.StaffFont, new Typeface(PolihymniaFamily, 30.5, FontStyle.Normal, FontWeight.Normal)},
                {MusicFontStyles.LyricsFont, new Typeface("Times New Roman", 11)},
                {MusicFontStyles.DirectionFont, new Typeface("Microsoft Sans Serif", 14.5)},
                {MusicFontStyles.TimeSignatureFont, new Typeface(new FontFamily("Microsoft Sans Serif"), 14.5, FontStyle.Normal, FontWeight.Bold)}
            };

        public Typeface GetFont(MusicFontStyles style)
        {
            return fonts[style];
        }

        public double GetFontSize(MusicFontStyles style)
        {
            return fonts[style].FontSize;
        }

        public void SetFont(MusicFontStyles style, FontFamily family, double fontSize = 0)
        {
            fonts[style] = new Typeface(family, fontSize, FontStyle.Normal, FontWeight.Normal);
        }

        public override void SetPolihymniaFont()
        {
            base.SetPolihymniaFont();

            fonts[MusicFontStyles.MusicFont] = defaultFonts[MusicFontStyles.MusicFont];
            fonts[MusicFontStyles.GraceNoteFont] = defaultFonts[MusicFontStyles.GraceNoteFont];
            fonts[MusicFontStyles.StaffFont] = defaultFonts[MusicFontStyles.StaffFont];
            fonts[MusicFontStyles.TimeSignatureFont] = defaultFonts[MusicFontStyles.TimeSignatureFont];
        }
    }
}