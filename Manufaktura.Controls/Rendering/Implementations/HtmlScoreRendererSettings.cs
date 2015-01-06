using Manufaktura.Controls.Model;
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
        public Dictionary<FontStyles, HtmlFontInfo> Fonts { get; private set; }
        public HtmlRenderSurface RenderSurface { get; set; }
        public double Height { get; set; }

        public HtmlScoreRendererSettings()
        {
            Fonts = new Dictionary<FontStyles, HtmlFontInfo>();
            RenderSurface = HtmlRenderSurface.Canvas;
            Height = 150;
            IsPanoramaMode = true;
        }

        public enum HtmlRenderSurface
        {
            Canvas,
            Svg
        }
    }
}
