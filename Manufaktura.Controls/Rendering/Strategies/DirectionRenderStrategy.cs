using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering a Direction.
    /// </summary>
    public class DirectionRenderStrategy : MusicalSymbolRenderStrategy<Direction>
    {
        private readonly IScoreService scoreService;
        public DirectionRenderStrategy(IScoreService scoreService)
        {
            this.scoreService = scoreService;
        }

        public override void Render(Direction element, ScoreRendererBase renderer)
        {
			//Performance directions / Wskazówki wykonawcze:
			double dirPositionY = 0;
			if (element.Placement == DirectionPlacementType.Custom)
				dirPositionY = scoreService.CurrentStaffTop + renderer.TenthsToPixels(element.DefaultYPosition.Value);
			else if (element.Placement == DirectionPlacementType.Above)
				dirPositionY = 0;
			else if (element.Placement == DirectionPlacementType.Below)
				dirPositionY = 50;

			var metronomeDirection = element as MetronomeDirection;
			if (metronomeDirection != null)
			{
				var note = new Note(metronomeDirection.Tempo.BeatUnit);
				renderer.DrawString(note.MusicalCharacter, MusicFontStyles.GraceNoteFont, scoreService.CursorPositionX, dirPositionY - 8, element);
				if (metronomeDirection.Tempo.BeatUnit.Denominator > 1)
				{
					renderer.DrawLine(scoreService.CursorPositionX + 10, dirPositionY + 9, scoreService.CursorPositionX + 10, dirPositionY - 2, metronomeDirection);
					if (metronomeDirection.Tempo.BeatUnit.Denominator > 4)
					{
						renderer.DrawString(note.NoteFlagCharacter, MusicFontStyles.GraceNoteFont, new Point(scoreService.CursorPositionX + 6, dirPositionY - 24), element);
					}
				}
				renderer.DrawString($" = {metronomeDirection.Tempo.BeatsPerMinute}", MusicFontStyles.DirectionFont, scoreService.CursorPositionX + 12, dirPositionY, element);
				return;
			}

            
            renderer.DrawString(element.Text, MusicFontStyles.DirectionFont, scoreService.CursorPositionX, dirPositionY, element);
        }
    }
}
