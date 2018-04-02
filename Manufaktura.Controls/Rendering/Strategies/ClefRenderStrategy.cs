using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public override void Render(Clef element, ScoreRendererBase renderer)
        {
			if (element.OctaveChange > 0)
			{
				renderer.DrawString((8 * element.OctaveChange).ToString(), MusicFontStyles.DirectionFont, element.TextBlockLocation.X + 6, element.TextBlockLocation.Y, element);
			}
			if (element.OctaveChange < 0)
			{
				renderer.DrawString((8 * element.OctaveChange * -1).ToString(), MusicFontStyles.DirectionFont, element.TextBlockLocation.X + 6, element.TextBlockLocation.Y + 42, element);
			}

			//Don't draw clef if it's current clef:
			if (!WasSystemChanged && element.TypeOfClef == scoreService.CurrentClef.TypeOfClef && element.Pitch == scoreService.CurrentClef.Pitch && element.Line == scoreService.CurrentClef.Line) return;

            element.TextBlockLocation = new Point(scoreService.CursorPositionX,  scoreService.CurrentLinePositions[4] - 24.4f - (element.Line - 1) * renderer.Settings.LineSpacing);
            scoreService.CurrentClef = element;
            if (element.TypeOfClef == ClefType.Percussion)
                DrawPercussionClef(element, renderer);
            else
                renderer.DrawCharacter(element.GetCharacter(renderer.Settings.CurrentFont), MusicFontStyles.MusicFont, element.TextBlockLocation.X, element.TextBlockLocation.Y, element);

			scoreService.CursorPositionX += 20;
        }

        public void DrawPercussionClef(Clef element, ScoreRendererBase renderer)
        {
            renderer.DrawLine(new Point(element.TextBlockLocation.X + 10, scoreService.CurrentLinePositions[1]),
                new Point(element.TextBlockLocation.X + 10, scoreService.CurrentLinePositions[3]), new Pen(element.CoalesceColor(renderer), 3), element);
            renderer.DrawLine(new Point(element.TextBlockLocation.X + 15, scoreService.CurrentLinePositions[1]),
                new Point(element.TextBlockLocation.X + 15, scoreService.CurrentLinePositions[3]), new Pen(element.CoalesceColor(renderer), 3), element);
        }
    }
}
