using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.PeekStrategies;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Snippets
{
	public static class Beams
	{
		public static void Hook(IBeamingService beamingService, ScoreRendererBase renderer, Note element, int beamSpaceDirection, int beamNumber, int beamOffset, bool forward)
		{
			int hookLength = forward ? 6 : -6;
			double hookPositionY = beamingService.CurrentStemEndPositionY;
			if (beamNumber > 0)
			{
				hookPositionY = beamingService.PreviousStemEndPositionsY[0] + ScoreMath.StemEnd(beamingService.PreviousStemPositionsX[0], beamingService.PreviousStemEndPositionsY[0],
					beamingService.CurrentStemPositionX + hookLength, beamingService.CurrentStemPositionX, beamingService.CurrentStemEndPositionY);
			}

			renderer.DrawLine(new Point(beamingService.CurrentStemPositionX + hookLength,
				hookPositionY + 28 + beamOffset * beamSpaceDirection),
				new Point(beamingService.CurrentStemPositionX, beamingService.CurrentStemEndPositionY + 28
				+ beamOffset * beamSpaceDirection), new Pen { Color = renderer.Settings.DefaultColor, Thickness = 2 }, element);
		}

		public static void Flag (IBeamingService beamingService, IMeasurementService measurementService, IScoreService scoreService, ScoreRendererBase renderer, Note element, int beamSpaceDirection, int beamNumber, int beamOffset)
		{
			//Rysuj chorągiewkę tylko najniższego dźwięku w akordzie
			//Draw a hook only of the lowest element in a chord
			double xPos = beamingService.CurrentStemPositionX - 4;
			if (element.StemDirection == VerticalDirection.Down)
			{
				if (element.IsGraceNote || element.IsCueNote)
					renderer.DrawString(element.NoteFlagCharacterRev, MusicFontStyles.GraceNoteFont, new Point(xPos, beamingService.CurrentStemEndPositionY + 11), element);
				else
					renderer.DrawString(element.NoteFlagCharacterRev, MusicFontStyles.MusicFont, new Point(xPos, beamingService.CurrentStemEndPositionY + 7), element);
			}
			else
			{
				if (element.IsGraceNote || element.IsCueNote)
					renderer.DrawString(element.NoteFlagCharacter, MusicFontStyles.GraceNoteFont, new Point(xPos + 0.5, beamingService.CurrentStemEndPositionY + 6), element);
				else
					renderer.DrawString(element.NoteFlagCharacter, MusicFontStyles.MusicFont, new Point(xPos, beamingService.CurrentStemEndPositionY - 1), element);
			}
			if (measurementService.TupletState != null)
			{
				measurementService.TupletState.AreSingleBeamsPresentUnderTuplet = true;
				if (element.Tuplet == TupletType.Stop)
				{
					TupletMark(measurementService, scoreService, renderer, element, beamNumber);
					measurementService.TupletState = null;
				}
			}
		}

		public static void TupletMark(IMeasurementService measurementService, IScoreService scoreService, ScoreRendererBase renderer, Note element, int beamLoop)
		{
			if (measurementService.TupletState == null) throw new Exception("DrawTupletMark was called but no tuplet is currently open in staff.");
			Staff staff = scoreService.CurrentStaff;

			NoteOrRest firstElementInTuplet = staff.Peek<NoteOrRest>(element, PeekType.BeginningOfTuplet);
			int index = staff.Elements.IndexOf(firstElementInTuplet);
			List<MusicalSymbol> elementsUnderTuplet = staff.Elements.GetRange(index, staff.Elements.IndexOf(element) - index);
			double averageStemLength = elementsUnderTuplet.OfType<Note>().Where(n => MusicalSymbol.DirectionToPlacement(n.StemDirection) == measurementService.TupletState.TupletPlacement).
				Average(n => n.ActualStemLength);
			averageStemLength += 10;    //Add space
			int placementMod = measurementService.TupletState.TupletPlacement == VerticalPlacement.Above ? -1 : 1;
			double tupletBracketStartXPosition = firstElementInTuplet.TextBlockLocation.X + 6;
			double tupletBracketStartYPosition = firstElementInTuplet.TextBlockLocation.Y + 25 + averageStemLength * placementMod;
			double tupletBracketEndXPosition = element.TextBlockLocation.X + 12;
			double tupletBracketEndYPosition = element.TextBlockLocation.Y + 25 + averageStemLength * placementMod;

			if (measurementService.TupletState.AreSingleBeamsPresentUnderTuplet)    //Draw tuplet bracket
			{
				renderer.DrawLine(new Point(tupletBracketStartXPosition, tupletBracketStartYPosition),
								  new Point(tupletBracketEndXPosition, tupletBracketEndYPosition), element);
				renderer.DrawLine(new Point(tupletBracketStartXPosition, tupletBracketStartYPosition),
								  new Point(tupletBracketStartXPosition, firstElementInTuplet.TextBlockLocation.Y + 25 + (averageStemLength - 4) * placementMod), element);
				renderer.DrawLine(new Point(tupletBracketEndXPosition, tupletBracketEndYPosition),
								  new Point(tupletBracketEndXPosition, element.TextBlockLocation.Y + 25 + (averageStemLength - 4) * placementMod), element);
			}

			double numberOfNotesYTranslation = 0;
			if (measurementService.TupletState.TupletPlacement == VerticalPlacement.Above) numberOfNotesYTranslation -= 18; //If text should appear above the tuplet, move a bit to up
																															//If bracket is not drawn, move up or down to fill space
			if (!measurementService.TupletState.AreSingleBeamsPresentUnderTuplet) numberOfNotesYTranslation += 10 * (measurementService.TupletState.TupletPlacement == VerticalPlacement.Above ? 1 : -1);

			renderer.DrawString(Convert.ToString(measurementService.TupletState.NumberOfNotesUnderTuplet), MusicFontStyles.LyricsFont,
					new Point(tupletBracketStartXPosition + (tupletBracketEndXPosition - tupletBracketStartXPosition) / 2 - 6,
							  tupletBracketStartYPosition + (tupletBracketEndYPosition - tupletBracketStartYPosition) / 2 + numberOfNotesYTranslation), element);
		}
	}
}