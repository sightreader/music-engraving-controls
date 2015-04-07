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
        public bool InjectGoogleWebFontLoader { get; set; }

        public HtmlScoreRendererSettings()
        {
            Fonts = new Dictionary<MusicFontStyles, HtmlFontInfo>();
            RenderSurface = HtmlRenderSurface.Canvas;
            Height = 150;
            IsPanoramaMode = true;
            InjectGoogleWebFontLoader = false;
        }

        public enum HtmlRenderSurface
        {
            Canvas,
            Svg
        }
    }
}
