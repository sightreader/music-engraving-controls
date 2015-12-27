//#define DemoVersion

using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
    /// <summary>
    /// Draws text "Demo" in the corners of controls.
    /// </summary>
    public class DemoVersionFinishingTouch : IFinishingTouch
    {
        public void PerformOnScore(Score score, ScoreRendererBase renderer)
        {
#if DemoVersion
            foreach (var location in new[] {
                new Point(0, 0),
                new Point(renderer.ScoreInformation.Systems.Max(s => s.Width) - 30, 0)})
            {
                renderer.DrawString("DEMO", MusicFontStyles.LyricsFont, location, Color.Red, MusicalSymbol.Null);
            }
#endif
        }

        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
        {
        }
    }
}