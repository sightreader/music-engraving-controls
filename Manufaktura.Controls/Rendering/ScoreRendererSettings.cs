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

        public int PaddingTop { get; private set; }
        public int LineSpacing { get; private set; }

        public ScoreRendererSettings()
        {
            IgnoreCustomElementPositions = false;
            CustomElementPositionRatio = 0.6d;
            PageWidth = 200;
            PaddingTop = 20;
            LineSpacing = 6;
        }
    }
}
