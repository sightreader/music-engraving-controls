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
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
                {MusicFontStyles.DirectionFont, new Typeface("Microsoft Sans Serif")},
                {MusicFontStyles.TimeSignatureFont, new Typeface(new FontFamily("Microsoft Sans Serif"), FontStyles.Normal, FontWeights.Bold, FontStretches.Normal)}
            };

        private Dictionary<MusicFontStyles, double> defaultFontSizes = new Dictionary<MusicFontStyles, double>()
        {
                {MusicFontStyles.MusicFont, 27.5},
                {MusicFontStyles.GraceNoteFont, 22},
                {MusicFontStyles.StaffFont, 30.5},
                {MusicFontStyles.LyricsFont, 11},
                {MusicFontStyles.DirectionFont, 11},
                {MusicFontStyles.TimeSignatureFont, 14.5}
        };

        private Dictionary<MusicFontStyles, Typeface> fonts = new Dictionary<MusicFontStyles, Typeface>()
            {
                {MusicFontStyles.MusicFont, new Typeface(PolihymniaFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal)},
                {MusicFontStyles.GraceNoteFont, new Typeface(PolihymniaFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal)},
                {MusicFontStyles.StaffFont, new Typeface(PolihymniaFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal)},
                {MusicFontStyles.LyricsFont, new Typeface("Times New Roman")},
                {MusicFontStyles.DirectionFont, new Typeface("Microsoft Sans Serif")},
                {MusicFontStyles.TimeSignatureFont, new Typeface(new FontFamily("Microsoft Sans Serif"), FontStyles.Normal, FontWeights.Bold, FontStretches.Normal)}
            };

        private Dictionary<MusicFontStyles, double> fontSizes = new Dictionary<MusicFontStyles, double>()
        {
                {MusicFontStyles.MusicFont, 27.5},
                {MusicFontStyles.GraceNoteFont, 22},
                {MusicFontStyles.StaffFont, 30.5},
                {MusicFontStyles.LyricsFont, 11},
                {MusicFontStyles.DirectionFont, 11},
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

        public void LoadSMuFLMetadataFromBinaryStream(Stream stream)
        {
            var serializer = new BinaryFormatter();
            var metadata = serializer.Deserialize(stream) as SMuFLFontMetadata;
            CurrentSMuFLMetadata = metadata;
        }

        public Stream GetSMuFLMetadataBinaryStream()
        {
            if (CurrentSMuFLMetadata == null) return null;

            var serializer = new BinaryFormatter();
            var ms = new MemoryStream();
            serializer.Serialize(ms, CurrentSMuFLMetadata);
            ms.Seek(0, SeekOrigin.Begin);
            return ms;
        }

        public void SaveSMuFLMetadataAsBinary(string filePath)
        {
            using (var ms = GetSMuFLMetadataBinaryStream())
            {
                using (var fs = new FileStream(filePath, FileMode.CreateNew))
                {
                    ms.CopyTo(fs);
                }
            }
        }

        public void SetFont(MusicFontStyles style, FontFamily family, double fontSize = 0)
        {
            fonts[style] = new Typeface(family, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
            if (fontSize != 0) fontSizes[style] = fontSize;
            else fontSizes[style] = defaultFontSizes[MusicFontStyles.DirectionFont];
        }

        public override void SetPolihymniaFont()
        {
            base.SetPolihymniaFont();

            fonts[MusicFontStyles.MusicFont] = defaultFonts[MusicFontStyles.MusicFont];
            fonts[MusicFontStyles.GraceNoteFont] = defaultFonts[MusicFontStyles.GraceNoteFont];
            fonts[MusicFontStyles.StaffFont] = defaultFonts[MusicFontStyles.StaffFont];
            fonts[MusicFontStyles.TimeSignatureFont] = defaultFonts[MusicFontStyles.TimeSignatureFont];

            fontSizes[MusicFontStyles.MusicFont] = defaultFontSizes[MusicFontStyles.MusicFont];
            fontSizes[MusicFontStyles.GraceNoteFont] = defaultFontSizes[MusicFontStyles.GraceNoteFont];
            fontSizes[MusicFontStyles.StaffFont] = defaultFontSizes[MusicFontStyles.StaffFont];
            fontSizes[MusicFontStyles.TimeSignatureFont] = defaultFontSizes[MusicFontStyles.TimeSignatureFont];
        }
    }
}