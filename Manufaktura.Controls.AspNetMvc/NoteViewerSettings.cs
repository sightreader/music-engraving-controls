using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Controls.AspNetMvc
{
    public class NoteViewerSettings
    {
        public Dictionary<FontStyles, HtmlFontInfo> Fonts { get; private set; }
        public HtmlRenderSurface RenderSurface { get; set; }
        public double Height { get; set; }

        public NoteViewerSettings()
        {
            Fonts = new Dictionary<FontStyles, HtmlFontInfo>();
            RenderSurface = HtmlRenderSurface.Canvas;
            Height = 150;
        }

        public enum HtmlRenderSurface
        {
            Canvas,
            Svg
        }
    }
}
