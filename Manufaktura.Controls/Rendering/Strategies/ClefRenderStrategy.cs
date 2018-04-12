using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering a Clef.
    /// </summary>
    public class ClefRenderStrategy : MusicalSymbolRenderStrategy<Clef>
    {
        private readonly IScoreService scoreService;

        /// <summary>
        /// /// Initializes a new instance of ClefRenderStrategy
        /// </summary>
        /// <param name="scoreService"></param>
        public ClefRenderStrategy(IScoreService scoreService)
        {
            this.scoreService = scoreService;
        }

        public bool WasSystemChanged { get; set; }

        public void DrawPercussionClef(Clef element, ScoreRendererBase renderer)
        {
            renderer.DrawLine(new Point(element.TextBlockLocation.X + 10, scoreService.CurrentLinePositions[1]),
                new Point(element.TextBlockLocation.X + 10, scoreService.CurrentLinePositions[3]), new Pen(element.CoalesceColor(renderer), 3), element);
            renderer.DrawLine(new Point(element.TextBlockLocation.X + 15, scoreService.CurrentLinePositions[1]),
                new Point(element.TextBlockLocation.X + 15, scoreService.CurrentLinePositions[3]), new Pen(element.CoalesceColor(renderer), 3), element);
        }

        public override void Render(Clef element, ScoreRendererBase renderer)
        {
            if (!(renderer.Settings.CurrentFont is SMuFLMusicFont))
            {
                var yPosition = element.OctaveChange > 0 ? scoreService.CurrentLinePositions[0] - renderer.LinespacesToPixels(2) : scoreService.CurrentLinePositions[4] + renderer.LinespacesToPixels(3.5);
                var octaveChangeText = GetOctaveChangeNumberForPolihymniaFont(element.OctaveChange);
                renderer.DrawString(octaveChangeText, MusicFontStyles.DirectionFont, element.TextBlockLocation.X + 6, yPosition, element);
            }

            //Don't draw clef if it's current clef:
            if (!WasSystemChanged && element.TypeOfClef == scoreService.CurrentClef.TypeOfClef && element.Pitch == scoreService.CurrentClef.Pitch && element.Line == scoreService.CurrentClef.Line) return;

            element.TextBlockLocation = new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[4] - (element.Line - 1) * renderer.Settings.LineSpacing);
            scoreService.CurrentClef = element;
            if (element.TypeOfClef == ClefType.Percussion)
                DrawPercussionClef(element, renderer);
            else
                renderer.DrawCharacter(element.GetCharacter(renderer.Settings.CurrentFont), MusicFontStyles.MusicFont, element.TextBlockLocation.X, element.TextBlockLocation.Y, element);

            scoreService.CursorPositionX += 20;
        }

        private static string GetOctaveChangeNumberForPolihymniaFont(int octaveChange)
        {
            switch (octaveChange)
            {
                case 1: return "8";
                case -1: return "8";
                case 2: return "15";
                case -2: return "15";
                default: return "";
            }
        }
    }
}