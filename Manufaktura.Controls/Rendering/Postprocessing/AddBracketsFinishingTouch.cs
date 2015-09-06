using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
    public class AddBracketsFinishingTouch : IFinishingTouch
    {
        public void PerformOnScore(Score score, ScoreRendererBase renderer)
        {
            foreach (var part in score.Parts)
            {
                if (!part.Staves.Any()) continue;
                foreach (var system in score.Systems)
                {
                    DrawBracket(system, part, renderer);
                }
            }
        }

        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
        {
        }

        private void DrawBracket(StaffSystem system, Part part, ScoreRendererBase renderer)
        {
            var location = new Point(-20, system.LinePositions[1][0]);
            var size = new Size(15, system.LinePositions[part.Staves.Count][4] - system.LinePositions[1][0]);
            renderer.DrawStringInBounds(renderer.Settings.CurrentFont.LeftBracket, Model.Fonts.MusicFontStyles.MusicFont, location, size, Color.Black, part.Staves.First());
        }
    }
}