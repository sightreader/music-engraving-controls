#define DemoVersion

using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Strategies
{
    public class DemoVersionFinishingTouch : IFinishingTouch
    {
        public void PerformOnScore(Score score, ScoreRendererBase renderer)
        {
#if DemoVersion
            renderer.DrawString("DEMO", MusicFontStyles.LyricsFont, new Point(0, 0), Color.Red, MusicalSymbol.Null);
#endif
        }

        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
        {
        }
    }
}
