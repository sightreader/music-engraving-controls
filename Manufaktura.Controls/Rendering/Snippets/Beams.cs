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
			double xPos = beamingService.CurrentStemPositionX;
			if (element.StemDirection == VerticalDirection.Down)
			{
				if (element.IsGraceNote || element.IsCueNote)
					renderer.DrawCharacter(element.GetNoteFlagCharacter(renderer.Settings.CurrentFont, true), MusicFontStyles.GraceNoteFont, new Point(xPos, beamingService.CurrentStemEndPositionY), element);
				else
					renderer.DrawCharacter(element.GetNoteFlagCharacter(renderer.Settings.CurrentFont, true), MusicFontStyles.MusicFont, new Point(xPos, beamingService.CurrentStemEndPositionY), element);
			}
			else
			{
				if (element.IsGraceNote || element.IsCueNote)
					renderer.DrawCharacter(element.GetNoteFlagCharacter(renderer.Settings.CurrentFont, false), MusicFontStyles.GraceNoteFont, new Point(xPos, beamingService.CurrentStemEndPositionY), element);
				else
					renderer.DrawCharacter(element.GetNoteFlagCharacter(renderer.Settings.CurrentFont, false), MusicFontStyles.MusicFont, new Point(xPos, beamingService.CurrentStemEndPositionY), element);
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

            var tupletBracketPen = renderer.CreatePenFromDefaults(element, "tupletBracketThickness", s => s.DefaultTupletBracketThickness);

			Staff staff = scoreService.CurrentStaff;

			NoteOrRest firstElementInTuplet = staff.Peek<NoteOrRest>(element, PeekType.BeginningOfTuplet);
			int index = staff.Elements.IndexOf(firstElementInTuplet);
			List<MusicalSymbol> elementsUnderTuplet = staff.Elements.GetRange(index, staff.Elements.IndexOf(element) - index);
			var elementsUnderTupletForAverageStemLength = elementsUnderTuplet.OfType<Note>().Where(n => MusicalSymbol.DirectionToPlacement(n.StemDirection) == measurementService.TupletState.TupletPlacement).ToList();
			double averageStemLength = elementsUnderTupletForAverageStemLength.Count == 0 ? 0 : elementsUnderTupletForAverageStemLength.Average(n => n.ActualStemLength);
			averageStemLength += 10;    //Add space
			int placementMod = measurementService.TupletState.TupletPlacement == VerticalPlacement.Above ? -1 : 1;
			double tupletBracketStartXPosition = firstElementInTuplet.TextBlockLocation.X;
			double tupletBracketStartYPosition = firstElementInTuplet.TextBlockLocation.Y + averageStemLength * placementMod;
			double tupletBracketEndXPosition = element.TextBlockLocation.X + 12;
			double tupletBracketEndYPosition = element.TextBlockLocation.Y + averageStemLength * placementMod;

			if (measurementService.TupletState.AreSingleBeamsPresentUnderTuplet)    //Draw tuplet bracket
			{
				renderer.DrawLine(new Point(tupletBracketStartXPosition, tupletBracketStartYPosition),
								  new Point(tupletBracketEndXPosition, tupletBracketEndYPosition), tupletBracketPen, element);
				renderer.DrawLine(new Point(tupletBracketStartXPosition, tupletBracketStartYPosition),
								  new Point(tupletBracketStartXPosition, firstElementInTuplet.TextBlockLocation.Y + (averageStemLength - 4) * placementMod), tupletBracketPen, element);
				renderer.DrawLine(new Point(tupletBracketEndXPosition, tupletBracketEndYPosition),
								  new Point(tupletBracketEndXPosition, element.TextBlockLocation.Y + (averageStemLength - 4) * placementMod), tupletBracketPen, element);
			}

            double numberOfNotesYTranslation = measurementService.TupletState.TupletPlacement == VerticalPlacement.Above ? -18 : 18;
			if (!measurementService.TupletState.AreSingleBeamsPresentUnderTuplet) numberOfNotesYTranslation += 10 * (measurementService.TupletState.TupletPlacement == VerticalPlacement.Above ? 1 : -1);

			var allElementsUnderTuplet = elementsUnderTuplet.OfType<NoteOrRest>().ToList();
			allElementsUnderTuplet.Add(element);
			var tupletNumber = CalculateTupletNumber(allElementsUnderTuplet);
			renderer.DrawString(Convert.ToString(tupletNumber), MusicFontStyles.LyricsFont,
					new Point(tupletBracketStartXPosition + (tupletBracketEndXPosition - tupletBracketStartXPosition) / 2 - 7,
							  tupletBracketStartYPosition + (tupletBracketEndYPosition - tupletBracketStartYPosition) / 2 + numberOfNotesYTranslation), element);
		}

		private static int CalculateTupletNumber(IEnumerable<NoteOrRest> elements)
		{
            var smallNotes = EnumerateSmallNotes(elements).ToArray();
            var largeNotes = EnumerateLargeNotes(elements).ToArray();

            var query = largeNotes.Length == 0 ? smallNotes : largeNotes;

            double weight = 0;
			double smallestDenominator = query.Min(p => p.BaseDuration.Denominator);
			foreach (var element in query)
			{
				if (element.TupletWeightOverride.HasValue) weight += element.TupletWeightOverride.Value;
				else weight += smallestDenominator / element.BaseDuration.Denominator;
			}
			return (int)weight;
		}

        private static IEnumerable<NoteOrRest> EnumerateSmallNotes(IEnumerable<NoteOrRest> elements)
        {
            foreach (var element in elements)
            {
                if (element is Rest) yield return element;
                if (element is Note note && (note.IsCueNote || note.IsGraceNote)) yield return note;
            }
        }

        private static IEnumerable<NoteOrRest> EnumerateLargeNotes(IEnumerable<NoteOrRest> elements)
        {
            foreach (var element in elements)
            {
                if (element is Rest) yield return element;
                if (element is Note note && !note.IsCueNote && !note.IsGraceNote) yield return note;
            }
        }
    }
}