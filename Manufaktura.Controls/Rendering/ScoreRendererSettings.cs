using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;

namespace Manufaktura.Controls.Rendering
{
    public class ScoreRendererSettings
    {
        public MusicFont CurrentFont { get; set; }

        public double CustomElementPositionRatio { get; set; }

        public Color DefaultColor { get; set; }

        public bool IgnoreCustomElementPositions { get; set; }

        public bool IsManualMode { get; set; }

        public bool IsPanoramaMode { get; set; }

        public int LineSpacing { get; private set; }

        public int PaddingTop { get; private set; }

        public double PageWidth { get; set; }

        public ScoreRendererSettings()
        {
            IsPanoramaMode = true;
            IgnoreCustomElementPositions = false;
            CustomElementPositionRatio = 0.7d;
            PageWidth = 200;
            PaddingTop = 20;
            LineSpacing = 6;
            DefaultColor = Color.Black;
            CurrentFont = new PolihymniaFont();
        }
    }
}