using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.PeekStrategies;
using Manufaktura.Controls.Model.SMuFL;
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
            if (measurementService.TupletState == null)
                throw new Exception("DrawTupletMark was called but no tuplet is currently open in staff.");

            var tupletBracketPen = renderer.CreatePenFromDefaults(element, "tupletBracketThickness", s => s.DefaultTupletBracketThickness);
            Staff staff = scoreService.CurrentStaff;

            NoteOrRest firstElementInTuplet = staff.Peek<NoteOrRest>(element, PeekType.BeginningOfTuplet);
            int index = staff.Elements.IndexOf(firstElementInTuplet);
            List<MusicalSymbol> elementsUnderTuplet = staff.Elements.GetRange(index, staff.Elements.IndexOf(element) - index + 1);

            var noteGroupBounds = elementsUnderTuplet.OfType<Note>().GetBounds(renderer);
            renderer.DrawLine(noteGroupBounds.NW, noteGroupBounds.NE, new Pen(Color.Red), element);
            renderer.DrawLine(noteGroupBounds.NE, noteGroupBounds.SE, new Pen(Color.Red), element);
            renderer.DrawLine(noteGroupBounds.SE, noteGroupBounds.SW, new Pen(Color.Red), element);
            renderer.DrawLine(noteGroupBounds.SW, noteGroupBounds.NW, new Pen(Color.Red), element);

            var boundsOnOneSide = measurementService.TupletState.TupletPlacement == VerticalPlacement.Above ?
                new Tuple<Point, Point>(noteGroupBounds.NW, noteGroupBounds.NE) :
                new Tuple<Point, Point>(noteGroupBounds.SW, noteGroupBounds.SE);

            int placementMod = measurementService.TupletState.TupletPlacement == VerticalPlacement.Above ? -1 : 1;
            var bracketDefinition = new TupletBracketDefinition(
                boundsOnOneSide.Item1.X, 
                boundsOnOneSide.Item1.Y + renderer.LinespacesToPixels(2) * placementMod, 
                boundsOnOneSide.Item2.X, 
                boundsOnOneSide.Item2.Y + renderer.LinespacesToPixels(2) * placementMod);

            if (measurementService.TupletState.AreSingleBeamsPresentUnderTuplet)    //Draw tuplet bracket
            {
                renderer.DrawLine(bracketDefinition.StartPoint, bracketDefinition.Point25, tupletBracketPen, element);
                renderer.DrawLine(bracketDefinition.Point75, bracketDefinition.EndPoint, tupletBracketPen, element);
                renderer.DrawLine(bracketDefinition.StartPoint, bracketDefinition.StartPoint.Translate(0, renderer.LinespacesToPixels(-1) * placementMod), tupletBracketPen, element);
                renderer.DrawLine(bracketDefinition.EndPoint, bracketDefinition.EndPoint.Translate(0, renderer.LinespacesToPixels(-1) * placementMod), tupletBracketPen, element);
            }

            var allElementsUnderTuplet = elementsUnderTuplet.OfType<NoteOrRest>().ToList();
            var tupletNumber = CalculateTupletNumber(allElementsUnderTuplet);

            if (renderer.IsSMuFLFont)
                renderer.DrawString(SMuFLGlyphs.Instance.BuildNumberFromGlyphs(tupletNumber), MusicFontStyles.GraceNoteFont, bracketDefinition.MidPoint, element);
            else
                renderer.DrawString(Convert.ToString(tupletNumber), MusicFontStyles.LyricsFont, bracketDefinition.MidPoint, element);
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

        private static IEnumerable<NoteOrRest> EnumerateLargeNotes(IEnumerable<NoteOrRest> elements)
        {
            foreach (var element in elements)
            {
                if (element is Rest) yield return element;
                if (element is Note note && !note.IsCueNote && !note.IsGraceNote && !note.IsUpperMemberOfChord) yield return note;
            }
        }

        private static IEnumerable<NoteOrRest> EnumerateSmallNotes(IEnumerable<NoteOrRest> elements)
        {
            foreach (var element in elements)
            {
                if (element is Rest) yield return element;
                if (element is Note note && (note.IsCueNote || note.IsGraceNote) && !note.IsUpperMemberOfChord) yield return note;
            }
        }

        private static double GetAverageStemLength(IEnumerable<Note> notes, IMeasurementService measurementService)
        {
            var elementsUnderTupletForAverageStemLength = notes.Where(n => MusicalSymbol.DirectionToPlacement(n.StemDirection) == measurementService.TupletState.TupletPlacement).ToList();
            double averageStemLength = elementsUnderTupletForAverageStemLength.Count == 0 ? 0 : elementsUnderTupletForAverageStemLength.Average(n => n.ActualStemLength);
            averageStemLength += 10;    //Add space
            return averageStemLength;
        }
    }
}