﻿using Manufaktura.Controls.Model.Fonts;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public enum HtmlSizeHint
    {
        None,
        /// <summary>
        /// Score will be rendered in fixed width. In SVG mode it will also have viewBox attribute.
        /// </summary>
        FixedWidth,
        /// <summary>
        /// Score will be rendered in 100% width
        /// </summary>
        Stretch
    }

    public class HtmlScoreRendererSettings : ScoreRendererSettings
    {
        public HtmlScoreRendererSettings()
        {
            Fonts = new Dictionary<MusicFontStyles, HtmlFontInfo>();
            RenderSurface = HtmlRenderSurface.Canvas;
            Height = 150;
            RenderingMode = ScoreRenderingModes.Panorama;
        }

        public enum HtmlRenderSurface
        {
            /// <summary>
            /// Indicates that the score will be rendered on HTML Canvas
            /// </summary>
            Canvas,

            /// <summary>
            /// Indicates that the score will be renderer in SVG tag
            /// </summary>
            Svg
        }

        public Dictionary<MusicFontStyles, HtmlFontInfo> Fonts { get; private set; }
        [Obsolete("Use ScoreClass property instead to set class of the score container and set height in css class definition. You can also use AddFullWidthStyle property to automatically generate css style.")]
        public double Height { get; set; }

        public double MusicalFontShiftX { get; set; }
        public double MusicalFontShiftY { get; set; }
        public int PlaybackTempo { get; set; } = 120;
        public HtmlRenderSurface RenderSurface { get; set; }
        public string ScoreClass { get; set; }
        public HtmlSizeHint SizeHint { get; set; } = HtmlSizeHint.FixedWidth;
    }
}