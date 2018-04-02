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
    /// <summary>
    /// Helper class for drawing beams
    /// </summary>
	public static class Beams
	{
        /// <summary>
        /// Draws note flag
        /// </summary>
        /// <param name="beamingService"></param>
        /// <param name="measurementService"></param>
        /// <param name="scoreService"></param>
        /// <param name="renderer"></param>
        /// <param name="element"></param>
        /// <param name="beamSpaceDirection"></param>
        /// <param name="beamNumber"></param>
        /// <param name="beamOffset"></param>
		public static void Flag(IBeamingService beamingService, IMeasurementService measurementService, IScoreService scoreService, ScoreRendererBase renderer, Note element, int beamSpaceDirection, int beamNumber, int beamOffset)
		{
			//Rysuj chorągiewkę tylko najniższego dźwięku w akordzie
			//Draw a hook only of the lowest element in a chord
			double xPos = beamingService.CurrentStemPositionX - 4;
			if (element.StemDirection == VerticalDirection.Down)
			{
				if (element.IsGraceNote || element.IsCueNote)
					renderer.DrawCharacter(element.NoteFlagCharacterRev, MusicFontStyles.GraceNoteFont, new Point(xPos, beamingService.CurrentStemEndPositionY + 11), element);
				else
					renderer.DrawCharacter(element.NoteFlagCharacterRev, MusicFontStyles.MusicFont, new Point(xPos, beamingService.CurrentStemEndPositionY + 7), element);
			}
			else
			{
				if (element.IsGraceNote || element.IsCueNote)
					renderer.DrawCharacter(element.NoteFlagCharacter, MusicFontStyles.GraceNoteFont, new Point(xPos + 0.5, beamingService.CurrentStemEndPositionY + 10), element);
				else
					renderer.DrawCharacter(element.NoteFlagCharacter, MusicFontStyles.MusicFont, new Point(xPos, beamingService.CurrentStemEndPositionY - 1), element);
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

        /// <summary>
        /// Draws tuplet mark
        /// </summary>
        /// <param name="measurementService"></param>
        /// <param name="scoreService"></param>
        /// <param name="renderer"></param>
        /// <param name="element"></param>
        /// <param name="beamLoop"></param>
		public static void TupletMark(IMeasurementService measurementService, IScoreService scoreService, ScoreRendererBase renderer, NoteOrRest element, int beamLoop)
		{
			if (measurementService.TupletState == null) throw new Exception("DrawTupletMark was called but no tuplet is currently open in staff.");
			Staff staff = scoreService.CurrentStaff;

			NoteOrRest firstElementInTuplet = staff.Peek<NoteOrRest>(element, PeekType.BeginningOfTuplet);
			int index = staff.Elements.IndexOf(firstElementInTuplet);
			List<MusicalSymbol> elementsUnderTuplet = staff.Elements.GetRange(index, staff.Elements.IndexOf(element) - index);
			var elementsUnderTupletForAverageStemLength = elementsUnderTuplet.OfType<Note>().Where(n => MusicalSymbol.DirectionToPlacement(n.StemDirection) == measurementService.TupletState.TupletPlacement).ToList();
			double averageStemLength = elementsUnderTupletForAverageStemLength.Count == 0 ? 0 : elementsUnderTupletForAverageStemLength.Average(n => n.ActualStemLength);
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

			var allElementsUnderTuplet = elementsUnderTuplet.OfType<NoteOrRest>().ToList();
			allElementsUnderTuplet.Add(element);
			var tupletNumber = CalculateTupletNumber(allElementsUnderTuplet);
			renderer.DrawString(Convert.ToString(tupletNumber), MusicFontStyles.LyricsFont,
					new Point(tupletBracketStartXPosition + (tupletBracketEndXPosition - tupletBracketStartXPosition) / 2 - 6 - 7,
							  tupletBracketStartYPosition + (tupletBracketEndYPosition - tupletBracketStartYPosition) / 2 + numberOfNotesYTranslation), element);
		}

		private static int CalculateTupletNumber<TElement>(IEnumerable<TElement> elements) where TElement : ICanBeElementOfTuplet, IHasDuration
		{
			double weight = 0;
			double smallestDenominator = elements.Min(p => p.BaseDuration.Denominator);
			foreach (var element in elements)
			{
				if (element.TupletWeightOverride.HasValue) weight += element.TupletWeightOverride.Value;
				else weight += smallestDenominator / element.BaseDuration.Denominator;
			}
			return (int)weight;
		}
	}
}