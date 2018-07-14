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

using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using Manufaktura.Controls.UniversalApps.Common;
using System.Collections.Generic;
using Windows.UI.Xaml.Media;

namespace Manufaktura.Controls.UniversalApps
{
    public class UWPScoreRendererSettings : ScoreRendererSettings
    {
        private static Windows.UI.Xaml.Media.FontFamily PolihymniaFamily = //new DummyControl().DummyFontFamily;//
            new Windows.UI.Xaml.Media.FontFamily("Polihymnia.ttf#Polihymnia");

        /// <summary>
        /// Font mappings
        /// </summary>
        public Dictionary<MusicFontStyles, UWPFontInfo> Fonts { get; private set; } = new Dictionary<MusicFontStyles, UWPFontInfo>
        {
            {  MusicFontStyles.MusicFont, new UWPFontInfo("Polihymnia", PolihymniaFamily, 27.5) },
            {  MusicFontStyles.GraceNoteFont, new UWPFontInfo("Polihymnia",PolihymniaFamily, 20) },
            {  MusicFontStyles.StaffFont, new UWPFontInfo("Polihymnia", PolihymniaFamily, 30.5) },
            {  MusicFontStyles.LyricsFont, new UWPFontInfo("Segoe UI", new Windows.UI.Xaml.Media.FontFamily("Segoe UI"), 11, 0) },
            {  MusicFontStyles.DirectionFont, new UWPFontInfo("Microsoft Sans Serif", new Windows.UI.Xaml.Media.FontFamily("Microsoft Sans Serif"), 11, 0) },
            {  MusicFontStyles.TimeSignatureFont, new UWPFontInfo("Microsoft Sans Serif", new Windows.UI.Xaml.Media.FontFamily("Microsoft Sans Serif"), 14.5, 15) }
        };

        public static double CalculateCellAscent(string fontPath, float size)
        {
            var font = new System.Drawing.Font(new System.Drawing.FontFamily(fontPath), size);
            var baselineDesignUnits = font.FontFamily.GetCellAscent(font.Style);
            var baselinePixels = (baselineDesignUnits * font.Size) / font.FontFamily.GetEmHeight(font.Style);
            return baselinePixels;
        }

        public void SetFont(string fontName, FontFamily family, double fontSizeMusic, double fontSizeGrace, double fontSizeStaff, double cellAscent = 24.8)
        {
            Fonts[MusicFontStyles.MusicFont] = new UWPFontInfo(fontName, family, fontSizeMusic, cellAscent);
            Fonts[MusicFontStyles.GraceNoteFont] = new UWPFontInfo(fontName, family, fontSizeGrace, cellAscent);
            Fonts[MusicFontStyles.StaffFont] = new UWPFontInfo(fontName, family, fontSizeStaff, cellAscent);
        }

        public override void SetPolihymniaFont()
        {
            base.SetPolihymniaFont();

            Fonts = new Dictionary<MusicFontStyles, UWPFontInfo>
        {
            {  MusicFontStyles.MusicFont, new UWPFontInfo("Polihymnia", PolihymniaFamily, 27.5) },
            {  MusicFontStyles.GraceNoteFont, new UWPFontInfo("Polihymnia",PolihymniaFamily, 20) },
            {  MusicFontStyles.StaffFont, new UWPFontInfo("Polihymnia", PolihymniaFamily, 30.5) },
            {  MusicFontStyles.LyricsFont, new UWPFontInfo("Segoe UI", new Windows.UI.Xaml.Media.FontFamily("Segoe UI"), 30.5) },
            {  MusicFontStyles.DirectionFont, new UWPFontInfo("Microsoft Sans Serif", new Windows.UI.Xaml.Media.FontFamily("Microsoft Sans Serif"), 30.5) },
            {  MusicFontStyles.TimeSignatureFont, new UWPFontInfo("Microsoft Sans Serif", new Windows.UI.Xaml.Media.FontFamily("Microsoft Sans Serif"), 30.5) }
        };
        }
    }
}