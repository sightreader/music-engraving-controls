using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;

namespace Manufaktura.Controls.Rendering
{
    public class ScoreRendererSettings
    {
        /// <summary>
        /// Key mapping for current font
        /// </summary>
        public MusicFont CurrentFont { get; set; }

        public double CustomElementPositionRatio { get; set; }

        /// <summary>
        /// Default font color
        /// </summary>
        public Color DefaultColor { get; set; }

        /// <summary>
        /// True, to ignore element positions which are implicitly set in MusicXml file
        /// </summary>
        public bool IgnoreCustomElementPositions { get; set; }

        /// <summary>
        /// If true, all system breaks are ignored (the score is displayed in single staff system).
        /// </summary>
        public bool IsPanoramaMode { get; set; }

        /// <summary>
        /// Default line spacing
        /// </summary>
        public int LineSpacing { get; private set; }

        /// <summary>
        /// Default padding top
        /// </summary>
        public int PaddingTop { get; private set; }

        /// <summary>
        /// Default page width
        /// </summary>
        public double PageWidth { get; set; }

        internal double TextBlockHeight { get; set; }

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
            TextBlockHeight = 25;
        }
    }
}