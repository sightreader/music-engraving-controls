using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.PeekStrategies;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public class NoteRenderStrategy : MusicalSymbolRenderStrategy<Note>
    {
        private readonly IMeasurementService measurementService;
        private readonly IAlterationService alterationService;
        public NoteRenderStrategy(IMeasurementService measurementService, IAlterationService alterationService)
        {
            this.measurementService = measurementService;
            this.alterationService = alterationService;
        }

        public override void Render(Note element, ScoreRendererBase renderer)
        {
            //Jeśli ustalono default-x, to pozycjonuj wg default-x, a nie automatycznie
            if (!renderer.Settings.IgnoreCustomElementPositions && element.DefaultXPosition.HasValue)
            {
                renderer.State.CursorPositionX = measurementService.LastMeasurePositionX + element.DefaultXPosition.Value * renderer.Settings.CustomElementPositionRatio;
            }

            if (renderer.State.firstNoteInIncipit) renderer.State.firstNoteInMeasureXPosition = renderer.State.CursorPositionX;
            renderer.State.firstNoteInIncipit = false;

            //If it's second voice, rewind position to the beginning of measure (but only if default-x is not set or is ignored):
            if (element.Voice > renderer.State.CurrentVoice && (renderer.Settings.IgnoreCustomElementPositions || !element.DefaultXPosition.HasValue))
            {
                renderer.State.CursorPositionX = renderer.State.firstNoteInMeasureXPosition;
                measurementService.lastNoteInMeasureEndXPosition = measurementService.LastNoteEndXPosition;
            }
            renderer.State.CurrentVoice = element.Voice;

            if (element.Tuplet == TupletType.Start)
            {
                Tuplet tuplet = new Tuplet();
                measurementService.TupletState = tuplet;
                tuplet.NumberOfNotesUnderTuplet = 0;
                tuplet.TupletPlacement = element.TupletPlacement.HasValue ? element.TupletPlacement.Value : 
                    (element.StemDirection == VerticalDirection.Down ? VerticalPlacement.Below : VerticalPlacement.Above);
            }
            if (measurementService.TupletState != null && !element.IsChordElement) measurementService.TupletState.NumberOfNotesUnderTuplet++;

            if (element.IsChordElement) renderer.State.CursorPositionX = measurementService.LastNotePositionX;

            double noteTextBlockPositionY = renderer.State.CurrentClefTextBlockPositionY + Pitch.StepDistance(renderer.State.CurrentClef.Pitch,
                element.Pitch) * ((double)renderer.Settings.LineSpacing / 2.0f);

            int numberOfSingleAccidentals = Math.Abs(element.Alter) % 2;
            int numberOfDoubleAccidentals = Convert.ToInt32(Math.Floor((double)(Math.Abs(element.Alter) / 2)));

            MakeSpaceForAccidentals(renderer, element, 
                numberOfSingleAccidentals, numberOfDoubleAccidentals);          //Move the element a bit to the right if it has accidentals / Przesuń nutę trochę w prawo, jeśli nuta ma znaki przygodne
            DrawNote(renderer, element, noteTextBlockPositionY);                //Draw an element / Rysuj nutę
            DrawLedgerLines(renderer, element, noteTextBlockPositionY);         //Ledger lines / Linie dodane
            DrawStems(renderer, element, noteTextBlockPositionY);               //Stems are vertical lines, beams are horizontal lines / Rysuj ogonki (ogonki to są te w pionie - poziome są belki)
            DrawBeams(renderer, element);                                       //Draw beams / Rysuj belki
            DrawTies(renderer, element, noteTextBlockPositionY);                //Draw ties / Rysuj łuki
            DrawSlurs(renderer, element, noteTextBlockPositionY);               //Draw slurs / Rysuj łuki legatowe
            DrawLyrics(renderer, element);                                      //Draw lyrics / Rysuj tekst
            DrawArticulation(renderer, element, noteTextBlockPositionY);        //Draw articulation / Rysuj artykulację:
            DrawTrills(renderer, element, noteTextBlockPositionY);              //Draw trills / Rysuj tryle //TODO: REFAKTOR - Przenieść do DrawOrnaments
            DrawOrnaments(renderer, element, noteTextBlockPositionY);           //Draw ornaments / Rysuj ornamenty
            DrawTremolos(renderer, element, noteTextBlockPositionY);            //Draw tremolos / Rysuj tremola
            DrawFermataSign(renderer, element, noteTextBlockPositionY);         //Draw fermata sign / Rysuj symbol fermaty
            DrawAccidentals(renderer, element, noteTextBlockPositionY, 
                numberOfSingleAccidentals, numberOfDoubleAccidentals);          //Draw accidentals / Rysuj znaki przygodne:
            DrawDots(renderer, element, noteTextBlockPositionY);                //Draw dots / Rysuj kropki

            if (renderer.Settings.IgnoreCustomElementPositions || !element.DefaultXPosition.HasValue) //Pozycjonowanie automatyczne tylko, gdy nie określono default-x
            {
                if (element.Duration == RhythmicDuration.Whole) renderer.State.CursorPositionX += 50;
                else if (element.Duration == RhythmicDuration.Half) renderer.State.CursorPositionX += 30;
                else if (element.Duration == RhythmicDuration.Quarter) renderer.State.CursorPositionX += 18;
                else if (element.Duration == RhythmicDuration.Eighth) renderer.State.CursorPositionX += 15;
                else renderer.State.CursorPositionX += 14;

                //Przesuń trochę w prawo, jeśli nuta ma tekst, żeby litery nie wchodziły na siebie
                //Move a bit right if the element has a lyric to prevent letters from hiding each other
                if (element.Lyrics.Count > 0)
                {
                    renderer.State.CursorPositionX += element.Lyrics[0].Text.Length * 2;
                }
            }
            measurementService.LastNoteEndXPosition = renderer.State.CursorPositionX;
        }

        private void DrawNote(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if (element.IsGraceNote || element.IsCueNote)
                renderer.DrawString(element.MusicalCharacter, MusicFontStyles.GraceNoteFont, renderer.State.CursorPositionX + 1, notePositionY + 7, element);
            else
                renderer.DrawString(element.MusicalCharacter, MusicFontStyles.MusicFont, renderer.State.CursorPositionX, notePositionY, element);

            measurementService.LastNotePositionX = renderer.State.CursorPositionX;
            element.TextBlockLocation = new Point(renderer.State.CursorPositionX, notePositionY);
        }

        private void DrawTupletMark(ScoreRendererBase renderer, Note element, int beamLoop)
        {
            if (measurementService.TupletState == null) throw new Exception("DrawTupletMark was called but no tuplet is currently open in staff.");
            Staff staff = renderer.State.CurrentStaff;

            NoteOrRest firstElementInTuplet = staff.Peek<NoteOrRest>(element, PeekType.BeginningOfTuplet);
            int index = staff.Elements.IndexOf(firstElementInTuplet);
            List<MusicalSymbol> elementsUnderTuplet = staff.Elements.GetRange(index, staff.Elements.IndexOf(element) - index);
            double averageStemLength = elementsUnderTuplet.OfType<Note>().Where(n => MusicalSymbol.DirectionToPlacement(n.StemDirection) == measurementService.TupletState.TupletPlacement).
                Average(n => n.ActualStemLength);
            averageStemLength += 10;    //Add space
            int placementMod = measurementService.TupletState.TupletPlacement == VerticalPlacement.Above ? -1 : 1;
            double tupletBracketStartXPosition = firstElementInTuplet.TextBlockLocation.X + 6;
            double tupletBracketStartYPosition = firstElementInTuplet.TextBlockLocation.Y + 25 + averageStemLength * placementMod;
            double tupletBracketEndXPosition   = element.TextBlockLocation.X + 12;
            double tupletBracketEndYPosition   = element.TextBlockLocation.Y + 25 + averageStemLength * placementMod;

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
                    new Point(tupletBracketStartXPosition  + ( tupletBracketEndXPosition - tupletBracketStartXPosition ) / 2 - 6,
                              tupletBracketStartYPosition  + ( tupletBracketEndYPosition - tupletBracketStartYPosition ) / 2 + numberOfNotesYTranslation), element);
        }

        private void DrawLedgerLines(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            double tmpXPos = renderer.State.CursorPositionX + 16;
            if (notePositionY + 25.0f > renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][4] + renderer.Settings.LineSpacing / 2.0f)
            {
                for (double i = renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][4]; i < notePositionY + 24f - renderer.Settings.LineSpacing / 2.0f; i += renderer.Settings.LineSpacing)
                {

                    renderer.DrawLine(new Point(renderer.State.CursorPositionX + 4, i + renderer.Settings.LineSpacing),
                        new Point(tmpXPos, i + renderer.Settings.LineSpacing), element);
                }
            }
            if (notePositionY + 25.0f < renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][0] - renderer.Settings.LineSpacing / 2)
            {

                for (double i = renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][0]; i > notePositionY + 26.0f + renderer.Settings.LineSpacing / 2.0f; i -= renderer.Settings.LineSpacing)
                {

                    renderer.DrawLine(new Point(renderer.State.CursorPositionX + 4, i - renderer.Settings.LineSpacing),
                        new Point(tmpXPos, i - renderer.Settings.LineSpacing), element);
                }
            }
        }
        private void DrawStems(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if (element.Duration != RhythmicDuration.Whole)
            {
                double tmpStemPosY;
                tmpStemPosY = renderer.State.CurrentSystemShiftY + element.StemDefaultY * -1.0f / 2.0f;

                if (element.StemDirection == VerticalDirection.Down)
                {
                    //Ogonki elementów akordów nie były dobrze wyświetlane, jeśli stosowałem
                    //default-y. Dlatego dla akordów zostawiam domyślne rysowanie ogonków.
                    //Stems of chord elements were displayed wrong when I used default-y
                    //so I left default stem drawing routine for chords.
                    if (element.IsChordElement)
                        renderer.State.currentStemEndPositionY = notePositionY + 18;
                    else if ((renderer.State.IsManualMode) || (!(element.CustomStemEndPosition)))
                        renderer.State.currentStemEndPositionY = notePositionY + 18 > renderer.State.currentStemEndPositionY ? renderer.State.currentStemEndPositionY : notePositionY + 18;
                    else
                        renderer.State.currentStemEndPositionY = tmpStemPosY - 4;
                    renderer.State.currentStemPositionX = renderer.State.CursorPositionX + 7 + (element.IsGraceNote || element.IsCueNote ? -0.5 : 0);

                    if (element.BeamList.Count > 0)
                        if ((element.BeamList[0] != NoteBeamType.Continue) || element.CustomStemEndPosition)
                            renderer.DrawLine(new Point(renderer.State.currentStemPositionX, notePositionY - 1 + 28),
                                new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28), element);
                }
                else
                {
                    //Ogonki elementów akordów nie były dobrze wyświetlane, jeśli stosowałem
                    //default-y. Dlatego dla akordów zostawiam domyślne rysowanie ogonków.
                    //Stems of chord elements were displayed wrong when I used default-y
                    //so I left default stem drawing routine for chords.
                    if (element.IsChordElement)
                        renderer.State.currentStemEndPositionY = notePositionY - 25 < renderer.State.currentStemEndPositionY ? renderer.State.currentStemEndPositionY : notePositionY - 25;
                    else if (renderer.State.IsManualMode || (!(element.CustomStemEndPosition)))
                        renderer.State.currentStemEndPositionY = notePositionY - 25;
                    else
                        renderer.State.currentStemEndPositionY = tmpStemPosY - 6;
                    renderer.State.currentStemPositionX = renderer.State.CursorPositionX + 13 + (element.IsGraceNote || element.IsCueNote ? -2 : 0); 

                    if (element.BeamList.Count > 0)
                        if ((element.BeamList[0] != NoteBeamType.Continue) || element.CustomStemEndPosition)
                            renderer.DrawLine(new Point(renderer.State.currentStemPositionX, notePositionY - 7 + 30),
                                new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28), element);
                }
                element.StemEndLocation = new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY);
            }
        }

        private void DrawBeams(ScoreRendererBase renderer, Note element)
        {
            int beamOffset = 0;
            //Powiększ listę poprzednich pozycji stemów jeśli aktualna liczba belek jest większa
            //Extend the list of previous stem positions if current number of beams is greater than the list size
            if (measurementService.previousStemEndPositionsY.Count < element.BeamList.Count)
            {
                int tmpCount = measurementService.previousStemEndPositionsY.Count;
                for (int i = 0; i < element.BeamList.Count - tmpCount; i++)
                    measurementService.previousStemEndPositionsY.Add(new int());
            }
            if (measurementService.previousStemPositionsX.Count < element.BeamList.Count)
            {
                int tmpCount = measurementService.previousStemPositionsX.Count;
                for (int i = 0; i < element.BeamList.Count - tmpCount; i++)
                    measurementService.previousStemPositionsX.Add(new int());
            }
            int beamLoop = 0;
            foreach (NoteBeamType beam in element.BeamList)
            {

                int beamSpaceDirection = 1;
                if (element.StemDirection == VerticalDirection.Up) beamSpaceDirection = 1;
                else beamSpaceDirection = -1;
                //if (beam != NoteBeamType.Single) MessageBox.Show(Convert.ToString(currentStemPositionX));
                if (beam == NoteBeamType.Start)
                {
                    measurementService.previousStemEndPositionsY[beamLoop] = renderer.State.currentStemEndPositionY;
                    measurementService.previousStemPositionsX[beamLoop] = renderer.State.currentStemPositionX;

                }
                else if (beam == NoteBeamType.Continue)
                {
                    //int prevStemPosY = currentStemEndPositionY;
                    //currentStemEndPositionY = previousStemEndPositionsY[i];
                    //renderer.DrawLine(pen, new Point(currentStemPositionX, prevStemPosY + 28),
                    //    new Point(currentStemPositionX, currentStemEndPositionY + 28));
                }
                else if (beam == NoteBeamType.End)
                {
                    //MessageBox.Show(Convert.ToString(previousStemPositionsX[beamLoop])
                    //    + "," + Convert.ToString(currentStemPositionX));
                    renderer.DrawLine(new Point(measurementService.previousStemPositionsX[beamLoop], measurementService.previousStemEndPositionsY[beamLoop] + 28
                        + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28
                            + beamOffset * beamSpaceDirection), element);
                    renderer.DrawLine(new Point(measurementService.previousStemPositionsX[beamLoop], measurementService.previousStemEndPositionsY[beamLoop]
                        + 28 + 1 * beamSpaceDirection + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28
                            + 1 * beamSpaceDirection + beamOffset * beamSpaceDirection), element);
                    //Draw tuplet mark / Rysuj oznaczenie trioli:
                    if (element.Tuplet == TupletType.Stop && measurementService.TupletState != null)
                    {
                        DrawTupletMark(renderer, element, beamLoop);
                        measurementService.TupletState = null;
                    }
                }
                else if ((beam == NoteBeamType.Single) && (!element.IsChordElement))
                {   //Rysuj chorągiewkę tylko najniższego dźwięku w akordzie
                    //Draw a hook only of the lowest element in a chord
                    double xPos = renderer.State.currentStemPositionX - 4;
                    if (element.StemDirection == VerticalDirection.Down)
                    {
                        if (element.IsGraceNote || element.IsCueNote)
                            renderer.DrawString(element.NoteFlagCharacterRev, MusicFontStyles.GraceNoteFont, new Point(xPos, renderer.State.currentStemEndPositionY + 11), element);
                        else
                            renderer.DrawString(element.NoteFlagCharacterRev, MusicFontStyles.MusicFont, new Point(xPos, renderer.State.currentStemEndPositionY + 7), element);
                    }
                    else
                    {
                        if (element.IsGraceNote || element.IsCueNote)
                            renderer.DrawString(element.NoteFlagCharacter, MusicFontStyles.GraceNoteFont, new Point(xPos + 0.5, renderer.State.currentStemEndPositionY + 6), element);
                        else
                            renderer.DrawString(element.NoteFlagCharacter, MusicFontStyles.MusicFont, new Point(xPos, renderer.State.currentStemEndPositionY - 1), element);
                    }
                    if (measurementService.TupletState != null)
                    {
                        measurementService.TupletState.AreSingleBeamsPresentUnderTuplet = true;
                        if (element.Tuplet == TupletType.Stop)
                        {
                            DrawTupletMark(renderer, element, beamLoop);
                            measurementService.TupletState = null;
                        }
                    }
                }
                else if (beam == NoteBeamType.ForwardHook)
                {
                    renderer.DrawLine(new Point(renderer.State.currentStemPositionX + 6,
                        renderer.State.currentStemEndPositionY + 28 + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28
                        + beamOffset * beamSpaceDirection), element);
                    renderer.DrawLine(new Point(renderer.State.currentStemPositionX + 6,
                        renderer.State.currentStemEndPositionY + 29 + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 29
                        + beamOffset * beamSpaceDirection), element);
                }
                else if (beam == NoteBeamType.BackwardHook)
                {
                    renderer.DrawLine(new Point(renderer.State.currentStemPositionX - 6,
                        renderer.State.currentStemEndPositionY + 28 + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28
                        + beamOffset * beamSpaceDirection), element);
                    renderer.DrawLine(new Point(renderer.State.currentStemPositionX - 6,
                        renderer.State.currentStemEndPositionY + 29 + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 29
                        + beamOffset * beamSpaceDirection), element);
                }

                beamOffset += 4;
                beamLoop++;

            }
        }

        private void DrawTies(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if (element.TieType == NoteTieType.Start)
            {
                measurementService.tieStartPoint = new Point(renderer.State.CursorPositionX, notePositionY);
            }
            else if (element.TieType != NoteTieType.None) //Stop or StopAndStartAnother / Stop lub StopAndStartAnother
            {
                double arcWidth = renderer.State.CursorPositionX - measurementService.tieStartPoint.X - 12;
                double arcHeight = arcWidth * 0.7d;
                if (element.StemDirection == VerticalDirection.Down)
                {
                    renderer.DrawArc(new Rectangle(measurementService.tieStartPoint.X + 16, measurementService.tieStartPoint.Y + 6,
                        arcWidth, arcHeight), 180, 180, new Pen(renderer.Settings.DefaultColor, 1.5), element);
                }
                else if (element.StemDirection == VerticalDirection.Up)
                {
                    renderer.DrawArc(new Rectangle(measurementService.tieStartPoint.X + 16, measurementService.tieStartPoint.Y + 22,
                        arcWidth, arcHeight), 0, 180, new Pen(renderer.Settings.DefaultColor, 1.5), element);
                }
                if (element.TieType == NoteTieType.StopAndStartAnother)
                {
                    measurementService.tieStartPoint = new Point(renderer.State.CursorPositionX + 2, notePositionY);
                }

            }
        }

        private VerticalPlacement slurStartPlacement = VerticalPlacement.Above;
        private void DrawSlurs(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if (element.Slur == null) return;
            VerticalPlacement slurPlacement;
            if (element.Slur.Placement.HasValue) slurPlacement = element.Slur.Placement.Value;
            else slurPlacement = element.StemDirection == VerticalDirection.Up ? VerticalPlacement.Below : VerticalPlacement.Above;

            if (element.Slur.Type == NoteSlurType.Start)
            {
                slurStartPlacement = slurPlacement;
                if (slurPlacement == VerticalPlacement.Above)
                    measurementService.SlurStartPoint = new Point(renderer.State.CursorPositionX, element.StemDirection == VerticalDirection.Down ? notePositionY : notePositionY + element.StemDefaultY);
                else
                    measurementService.SlurStartPoint = new Point(renderer.State.CursorPositionX, notePositionY);
            }
            else if (element.Slur.Type == NoteSlurType.Stop)
            {
                if (slurStartPlacement == VerticalPlacement.Above)
                {
                    renderer.DrawBezier(measurementService.SlurStartPoint.X + 10, measurementService.SlurStartPoint.Y + 18,
                        measurementService.SlurStartPoint.X + 12, measurementService.SlurStartPoint.Y + 9,
                        renderer.State.CursorPositionX + 8, (element.StemDirection == VerticalDirection.Up ? element.StemDefaultY + renderer.State.CurrentSystemShiftY: notePositionY + 9),
                        renderer.State.CursorPositionX + 10, (element.StemDirection == VerticalDirection.Up ? element.StemDefaultY + renderer.State.CurrentSystemShiftY + 9 : notePositionY + 18), element);
                }
                else if (slurStartPlacement == VerticalPlacement.Below)
                {
                    renderer.DrawBezier(measurementService.SlurStartPoint.X + 10, measurementService.SlurStartPoint.Y + 30,
                        measurementService.SlurStartPoint.X + 12, measurementService.SlurStartPoint.Y + 44,
                        renderer.State.CursorPositionX + 8, notePositionY + 44,
                        renderer.State.CursorPositionX + 10, notePositionY + 30, element);
                }
            }
        }

        private void DrawLyrics(ScoreRendererBase renderer, Note element)
        {
            double textPositionY = renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][4] + 10;    //Default value if default-y is not set
            foreach (Lyrics lyrics in element.Lyrics)
            {
                if (lyrics.DefaultYPosition.HasValue) textPositionY = renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][0] + lyrics.DefaultYPosition.Value * -1 - 40;  //TODO: Sprawdzić względem czego jest default-y i usunąć to durne -40

                StringBuilder sBuilder = new StringBuilder();
                sBuilder.Append(lyrics.Text);

                //TODO: Dodać do kalkulacji wyliczoną szerokość stringa w poprzednim lyricu i odkomentować :)
                //A, i jeszcze wtedy wywalić warunek na middleDistance.
                //double middleDistanceBetweenTwoLyrics = (renderer.State.CursorPositionX - renderer.State.LastNoteEndXPosition) / 2.0d;
                // double hyphenXPosition = renderer.State.CursorPositionX - middleDistanceBetweenTwoLyrics;
                //if ((lyrics.Type == SyllableType.Middle || lyrics.Type == SyllableType.End) && middleDistanceBetweenTwoLyrics > 20)
                //{
                //    renderer.DrawString("-", FontStyles.LyricsFont, hyphenXPosition, textPositionY, element);
                //}
                //else 
                if (lyrics.Type == SyllableType.Begin || lyrics.Type == SyllableType.Middle) sBuilder.Append("-");

                renderer.DrawString(sBuilder.ToString(), MusicFontStyles.LyricsFont, renderer.State.CursorPositionX, textPositionY, element);

                if (!lyrics.DefaultYPosition.HasValue) textPositionY += 12; //Move down if default-y is not set
            }
        }

        private void DrawArticulation(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if (element.Articulation != ArticulationType.None)
            {
                double articulationPosition = notePositionY + 10;
                if (element.ArticulationPlacement == VerticalPlacement.Above)
                    articulationPosition = notePositionY - 10;
                else if (element.ArticulationPlacement == VerticalPlacement.Below)
                    articulationPosition = notePositionY + 10;

                if (element.Articulation == ArticulationType.Staccato)
                    renderer.DrawString(renderer.State.CurrentFont.Dot, MusicFontStyles.MusicFont, renderer.State.CursorPositionX + 6, articulationPosition, element);
                else if (element.Articulation == ArticulationType.Accent)
                    renderer.DrawString(">", MusicFontStyles.MiscArticulationFont, renderer.State.CursorPositionX + 6, articulationPosition + 16, element);

            }
        }

        private void DrawTrills(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if (element.TrillMark != NoteTrillMark.None)
            {
                double trillPos = notePositionY - 1;
                if (element.TrillMark == NoteTrillMark.Above)
                {
                    trillPos = notePositionY - 1;
                    if (trillPos > renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][0] - renderer.TextBlockHeight)
                    {
                        trillPos = renderer.State.LinePositions[renderer.State.CurrentSystem][renderer.State.CurrentLine][0] - renderer.TextBlockHeight - 1.0f;
                    }
                }
                else if (element.TrillMark == NoteTrillMark.Below)
                {
                    trillPos = notePositionY + 10;
                }
                renderer.DrawString(renderer.State.CurrentFont.Trill, MusicFontStyles.MusicFont, renderer.State.CursorPositionX + 6, trillPos, element);
            }
        }

        private void DrawOrnaments(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            foreach (Ornament ornament in element.Ornaments)
            {
                double yPositionShift = ornament.DefaultYPosition.HasValue ? ornament.DefaultYPosition.Value * -1 * 0.5d : (ornament.Placement == VerticalPlacement.Above ? - 20 : 20);
                Mordent mordent = ornament as Mordent;
                if (mordent != null)
                {
                    renderer.DrawString(renderer.State.CurrentFont.MordentShort, MusicFontStyles.GraceNoteFont, renderer.State.CursorPositionX - 2, notePositionY + yPositionShift, element);
                    renderer.DrawString(renderer.State.CurrentFont.Mordent, MusicFontStyles.GraceNoteFont, renderer.State.CursorPositionX + 3.5, notePositionY + yPositionShift, element);
                }
            }
        }

        private void DrawTremolos(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            double currentTremoloPos = notePositionY + 18;
            for (int j = 0; j < element.TremoloLevel; j++)
            {
                if (element.StemDirection == VerticalDirection.Up)
                {
                    currentTremoloPos -= 4;
                    renderer.DrawLine(renderer.State.CursorPositionX + 9, currentTremoloPos + 1, renderer.State.CursorPositionX + 16, currentTremoloPos - 1, element);
                    renderer.DrawLine(renderer.State.CursorPositionX + 9, currentTremoloPos + 2, renderer.State.CursorPositionX + 16, currentTremoloPos, element);
                }
                else
                {
                    currentTremoloPos += 4;
                    renderer.DrawLine(renderer.State.CursorPositionX + 3, currentTremoloPos + 11 + 1, renderer.State.CursorPositionX + 11, currentTremoloPos + 11 - 1, element);
                    renderer.DrawLine(renderer.State.CursorPositionX + 3, currentTremoloPos + 11 + 2, renderer.State.CursorPositionX + 11, currentTremoloPos + 11, element);
                }
            }
        }

        private void DrawFermataSign(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if (element.HasFermataSign)
            {
                double ferPos = notePositionY - renderer.TextBlockHeight;
                string fermataVersion = renderer.State.CurrentFont.FermataUp;

                renderer.DrawString(fermataVersion, MusicFontStyles.MusicFont, renderer.State.CursorPositionX, ferPos, element);
            }
        }

        private void DrawAccidentals(ScoreRendererBase renderer, Note element, double notePositionY, int numberOfSingleAccidentals, int numberOfDoubleAccidentals)
        {
            if (element.Alter - renderer.State.CurrentKey.StepToAlter(element.Step) - alterationService.Get(element.Step) > 0)
            {
                alterationService.Set(element.Step, element.Alter - renderer.State.CurrentKey.StepToAlter(element.Step));
                double accPlacement = renderer.State.CursorPositionX - 9 * numberOfSingleAccidentals - 9 * numberOfDoubleAccidentals;
                for (int i = 0; i < numberOfSingleAccidentals; i++)
                {
                    renderer.DrawString(renderer.State.CurrentFont.Sharp, MusicFontStyles.MusicFont, accPlacement, notePositionY, element);
                    accPlacement += 9;
                }
                for (int i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    renderer.DrawString(renderer.State.CurrentFont.DoubleSharp, MusicFontStyles.MusicFont, accPlacement, notePositionY, element);
                    accPlacement += 9;
                }
            }
            else if (element.Alter - renderer.State.CurrentKey.StepToAlter(element.Step) - alterationService.Get(element.Step) < 0)
            {
                alterationService.Set(element.Step, element.Alter - renderer.State.CurrentKey.StepToAlter(element.Step));
                double accPlacement = renderer.State.CursorPositionX - 9 * numberOfSingleAccidentals -
                    9 * numberOfDoubleAccidentals;
                for (int i = 0; i < numberOfSingleAccidentals; i++)
                {
                    renderer.DrawString(renderer.State.CurrentFont.Flat, MusicFontStyles.MusicFont, accPlacement, notePositionY, element);
                    accPlacement += 9;
                }
                for (int i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    renderer.DrawString(renderer.State.CurrentFont.DoubleFlat, MusicFontStyles.MusicFont, accPlacement, notePositionY, element);
                    accPlacement += 9;
                }
            }
            if (element.HasNatural == true)
            {
                renderer.DrawString(renderer.State.CurrentFont.Natural, MusicFontStyles.MusicFont, renderer.State.CursorPositionX - 9, notePositionY, element);
            }
        }

        private void DrawDots(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if (element.NumberOfDots > 0) renderer.State.CursorPositionX += 16;
            for (int i = 0; i < element.NumberOfDots; i++)
            {
                renderer.DrawString(renderer.State.CurrentFont.Dot, MusicFontStyles.MusicFont, renderer.State.CursorPositionX, notePositionY, element);
                renderer.State.CursorPositionX += 6;
            }
        }

        private void MakeSpaceForAccidentals(ScoreRendererBase renderer, Note element, int numberOfSingleAccidentals, int numberOfDoubleAccidentals)
        {
            if (renderer.Settings.IgnoreCustomElementPositions || !element.DefaultXPosition.HasValue)
            {
                if (element.Alter - renderer.State.CurrentKey.StepToAlter(element.Step) != 0)
                {
                    if (numberOfSingleAccidentals > 0) renderer.State.CursorPositionX += 9;
                    if (numberOfDoubleAccidentals > 0)
                        renderer.State.CursorPositionX += (numberOfDoubleAccidentals) * 9;
                }
                if (element.HasNatural == true) renderer.State.CursorPositionX += 9;
            }
        }
    }
}
