﻿/*
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

using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using SkiaSharp;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Skia
{
    public class SKScoreRendererSettings : ScoreRendererSettings
    {
        private readonly Dictionary<MusicFontStyles, float> fontSizes = new Dictionary<MusicFontStyles, float>()
        {
                {MusicFontStyles.MusicFont, 27.5f},
                {MusicFontStyles.GraceNoteFont, 22},
                {MusicFontStyles.StaffFont, 30.5f},
                {MusicFontStyles.LyricsFont, 11},
                {MusicFontStyles.DirectionFont, 11},
                {MusicFontStyles.TimeSignatureFont, 14.5f}
        };

        private readonly Dictionary<MusicFontStyles, SKTypeface> typefaces = new Dictionary<MusicFontStyles, SKTypeface>();

        public SKTypeface CreateTypefaceFromResource<TSomeTypeInNamespace>(string resourceFileName)
        {
            var assembly = typeof(TSomeTypeInNamespace).Assembly;
            var resourceFullName = $"{typeof(TSomeTypeInNamespace).Namespace}.{resourceFileName}";
            var stream = assembly.GetManifestResourceStream(resourceFullName);  //SKTypeface takes ownership of stream so don't dispose here
            return SKTypeface.FromStream(stream);
        }

        public SKTypeface GetFont(MusicFontStyles style)
        {
            if (!typefaces.ContainsKey(style)) throw new Exception($"Font information missing for style {style}. Call {nameof(SetFontFromResource)}.");
            return typefaces[style];
        }

        public float GetFontSize(MusicFontStyles style) => fontSizes[style];

        public void SetFontFromResource<TSomeTypeInNamespace>(MusicFontStyles style, string resourceFileName, float fontSize)
        {
            var typeface = CreateTypefaceFromResource<TSomeTypeInNamespace>(resourceFileName);
            SetFontFromTypeface(style, typeface, fontSize);
        }

        public void SetFontFromTypeface(MusicFontStyles style, SKTypeface typeface, float fontSize)
        {
            typefaces[style] = typeface;
            fontSizes[style] = fontSize;
        }
    }
}