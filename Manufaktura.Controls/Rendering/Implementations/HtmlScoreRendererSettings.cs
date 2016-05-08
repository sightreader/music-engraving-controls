using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using Manufaktura.Controls.Rendering.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class HtmlScoreRendererSettings : ScoreRendererSettings
    {
        public Dictionary<MusicFontStyles, HtmlFontInfo> Fonts { get; private set; }
        public HtmlRenderSurface RenderSurface { get; set; }
        public double Height { get; set; }
        public double MusicalFontShiftX { get; set; }
        public double MusicalFontShiftY { get; set; }

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
    }
}
