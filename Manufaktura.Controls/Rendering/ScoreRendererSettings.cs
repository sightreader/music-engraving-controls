using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public class ScoreRendererSettings
    {
        public double PageWidth { get; set; }
        public bool IgnoreCustomElementPositions { get; set; }
        public double CustomElementPositionRatio { get; set; }
        public bool IsPanoramaMode { get; set; }
        public int PaddingTop { get; private set; }
        public int LineSpacing { get; private set; }

        public ScoreRendererSettings()
        {
            IsPanoramaMode = true;
            IgnoreCustomElementPositions = false;
            CustomElementPositionRatio = 0.7d;
            PageWidth = 200;
            PaddingTop = 20;
            LineSpacing = 6;
        }
    }
}
