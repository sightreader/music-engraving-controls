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

        public ScoreRendererSettings()
        {
            IgnoreCustomElementPositions = false;
            CustomElementPositionRatio = 0.7d;
            PageWidth = 200;
        }
    }
}
