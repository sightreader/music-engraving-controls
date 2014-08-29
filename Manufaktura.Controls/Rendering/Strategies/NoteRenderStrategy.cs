using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    class NoteRenderStrategy : MusicalSymbolRenderStrategy<Note>
    {
        public override void Render(Note element, ScoreRendererBase renderer)
        {
            //Jeśli ustalono default-x, to pozycjonuj wg default-x, a nie automatycznie
            if (!renderer.Settings.IgnoreCustomElementPositions && element.DefaultXPosition > 0)
            {
                renderer.State.CursorPositionX = renderer.State.LastMeasurePositionX + element.DefaultXPosition * renderer.Settings.CustomElementPositionRatio;
            }

            if (renderer.State.firstNoteInIncipit) renderer.State.firstNoteInMeasureXPosition = renderer.State.CursorPositionX;
            renderer.State.firstNoteInIncipit = false;

            //If it's second voice, rewind position to the beginning of measure (but only if default-x is not set or is ignored):
            if (element.Voice > renderer.State.CurrentVoice && (renderer.Settings.IgnoreCustomElementPositions || element.DefaultXPosition == 0))
            {
                renderer.State.CursorPositionX = renderer.State.firstNoteInMeasureXPosition;
                renderer.State.lastNoteInMeasureEndXPosition = renderer.State.lastNoteEndXPosition;
            }
            renderer.State.CurrentVoice = element.Voice;

            if (element.Tuplet == TupletType.Start)
            {
                renderer.State.NumberOfNotesUnderTuplet = 0;
                renderer.State.TupletPlacement = element.TupletPlacement.HasValue ? element.TupletPlacement.Value : 
                    (element.StemDirection == NoteStemDirection.Down ? VerticalPlacement.Below : VerticalPlacement.Above);
            }
            renderer.State.NumberOfNotesUnderTuplet++;

            if (element.IsChordElement) renderer.State.CursorPositionX = renderer.State.LastCursorPositionX;

            double notePositionY = renderer.State.currentClefPositionY + MusicalSymbol.StepDifference(renderer.State.CurrentClef,
                element) * ((double)renderer.Settings.LineSpacing / 2.0f);
            if (renderer.State.IsPrintMode) notePositionY -= 0.8f;

            int numberOfSingleAccidentals = Math.Abs(element.Alter) % 2;
            int numberOfDoubleAccidentals = Convert.ToInt32(Math.Floor((double)(Math.Abs(element.Alter) / 2)));

            MakeSpaceForAccidentals(renderer, element, 
                numberOfSingleAccidentals, numberOfDoubleAccidentals); //Move the element a bit to the right if it has accidentals / Przesuń nutę trochę w prawo, jeśli nuta ma znaki przygodne
            DrawNote(renderer, element, notePositionY);                //Draw an element / Rysuj nutę
            DrawLedgerLines(renderer, element, notePositionY);         //Ledger lines / Linie dodane
            DrawStems(renderer, element, notePositionY);               //Stems are vertical lines, beams are horizontal lines / Rysuj ogonki (ogonki to są te w pionie - poziome są belki)
            DrawBeams(renderer, element);                              //Draw beams / Rysuj belki
            DrawTies(renderer, element, notePositionY);                //Draw ties / Rysuj łuki
            DrawSlurs(renderer, element, notePositionY);               //Draw slurs / Rysuj łuki legatowe
            DrawLyrics(renderer, element);                             //Draw lyrics / Rysuj tekst
            DrawArticulation(renderer, element, notePositionY);        //Draw articulation / Rysuj artykulację:
            DrawTrills(renderer, element, notePositionY);              //Draw trills / Rysuj tryle
            DrawTremolos(renderer, element, notePositionY);            //Draw tremolos / Rysuj tremola
            DrawFermataSign(renderer, element, notePositionY);         //Draw fermata sign / Rysuj symbol fermaty
            DrawAccidentals(renderer, element, notePositionY, 
                numberOfSingleAccidentals, numberOfDoubleAccidentals); //Draw accidentals / Rysuj znaki przygodne:
            DrawDots(renderer, element, notePositionY);                //Draw dots / Rysuj kropki
            

            if (renderer.Settings.IgnoreCustomElementPositions || element.DefaultXPosition == 0) //Pozycjonowanie automatyczne tylko, gdy nie określono default-x
            {
                if (element.Duration == MusicalSymbolDuration.Whole) renderer.State.CursorPositionX += 50;
                else if (element.Duration == MusicalSymbolDuration.Half) renderer.State.CursorPositionX += 30;
                else if (element.Duration == MusicalSymbolDuration.Quarter) renderer.State.CursorPositionX += 18;
                else if (element.Duration == MusicalSymbolDuration.Eighth) renderer.State.CursorPositionX += 15;
                else if (element.Duration == MusicalSymbolDuration.Unknown) renderer.State.CursorPositionX += 25;
                else renderer.State.CursorPositionX += 14;

                //Przesuń trochę w prawo, jeśli nuta ma tekst, żeby litery nie wchodziły na siebie
                //Move a bit right if the element has a lyric to prevent letters from hiding each other
                if (element.Lyrics.Count > 0)
                {
                    renderer.State.CursorPositionX += element.Lyrics[0].Text.Length * 2;
                }
            }
            renderer.State.lastNoteEndXPosition = renderer.State.CursorPositionX;
        }

        private void DrawNote(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if (element.IsGraceNote || element.IsCueNote)
                renderer.DrawString(element.MusicalCharacter, FontStyles.GraceNoteFont, renderer.State.CursorPositionX + 1, notePositionY + 4, element);
            else
                renderer.DrawString(element.MusicalCharacter, FontStyles.MusicFont, renderer.State.CursorPositionX, notePositionY, element);

            renderer.State.LastCursorPositionX = renderer.State.CursorPositionX;
            element.Location = new Point(renderer.State.CursorPositionX, notePositionY);
        }

        private void DrawTupletMark(ScoreRendererBase renderer, Note element, int beamLoop)
        {
            int tmpMod;
            if (renderer.State.TupletPlacement == VerticalPlacement.Above) tmpMod = 6;
            else tmpMod = 28;
            renderer.DrawString(Convert.ToString(renderer.State.NumberOfNotesUnderTuplet), FontStyles.LyricsFont,
                    new Point(renderer.State.previousStemPositionsX[beamLoop] + (renderer.State.currentStemPositionX - renderer.State.previousStemPositionsX[beamLoop]) / 2 - 1,
                    renderer.State.previousStemEndPositionsY[beamLoop] - (renderer.State.currentStemEndPositionY - renderer.State.previousStemEndPositionsY[beamLoop]) / 2 + tmpMod), element);
        }

        private void DrawLedgerLines(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            double tmpXPos = renderer.State.CursorPositionX + 16;
            if (renderer.State.IsPrintMode) tmpXPos += 1.5f;
            if (notePositionY + 25.0f > renderer.State.LinePositions[4] + renderer.Settings.LineSpacing / 2.0f)
            {
                for (int i = renderer.State.LinePositions[4]; i < notePositionY + 24f - renderer.Settings.LineSpacing / 2.0f; i += renderer.Settings.LineSpacing)
                {

                    renderer.DrawLine(new Point(renderer.State.CursorPositionX + 4, i + renderer.Settings.LineSpacing),
                        new Point(tmpXPos, i + renderer.Settings.LineSpacing), element);
                }
            }
            if (notePositionY + 25.0f < renderer.State.LinePositions[0] - renderer.Settings.LineSpacing / 2)
            {

                for (int i = renderer.State.LinePositions[0]; i > notePositionY + 26.0f + renderer.Settings.LineSpacing / 2.0f; i -= renderer.Settings.LineSpacing)
                {

                    renderer.DrawLine(new Point(renderer.State.CursorPositionX + 4, i - renderer.Settings.LineSpacing),
                        new Point(tmpXPos, i - renderer.Settings.LineSpacing), element);
                }
            }
        }
        private void DrawStems(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if ((element.Duration != MusicalSymbolDuration.Whole) &&
                (element.Duration != MusicalSymbolDuration.Unknown))
            {
                double tmpStemPosY;

                tmpStemPosY = element.StemDefaultY * -1.0f / 2.0f;


                if (element.StemDirection == NoteStemDirection.Down)
                {
                    //Ogonki elementów akordów nie były dobrze wyświetlane, jeśli stosowałem
                    //default-y. Dlatego dla akordów zostawiam domyślne rysowanie ogonków.
                    //Stems of chord elements were displayed wrong when I used default-y
                    //so I left default stem drawing routine for chords.
                    if (((element.IsChordElement) || renderer.State.IsManualMode)
                        || (!(element.CustomStemEndPosition)))
                        renderer.State.currentStemEndPositionY = notePositionY + 18;
                    else
                        renderer.State.currentStemEndPositionY = tmpStemPosY - 4;
                    renderer.State.currentStemPositionX = renderer.State.CursorPositionX + 7;
                    if (renderer.State.IsPrintMode) renderer.State.currentStemPositionX += 0.1f;

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
                    if ((element.IsChordElement) || renderer.State.IsManualMode
                        || (!(element.CustomStemEndPosition)))
                        renderer.State.currentStemEndPositionY = notePositionY - 25;

                    else
                        renderer.State.currentStemEndPositionY = tmpStemPosY - 6;
                    renderer.State.currentStemPositionX = renderer.State.CursorPositionX + 13;
                    if (renderer.State.IsPrintMode) renderer.State.currentStemPositionX += 0.9f;

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
            if (renderer.State.previousStemEndPositionsY.Count < element.BeamList.Count)
            {
                int tmpCount = renderer.State.previousStemEndPositionsY.Count;
                for (int i = 0; i < element.BeamList.Count - tmpCount; i++)
                    renderer.State.previousStemEndPositionsY.Add(new int());
            }
            if (renderer.State.previousStemPositionsX.Count < element.BeamList.Count)
            {
                int tmpCount = renderer.State.previousStemPositionsX.Count;
                for (int i = 0; i < element.BeamList.Count - tmpCount; i++)
                    renderer.State.previousStemPositionsX.Add(new int());
            }
            int beamLoop = 0;
            bool alreadyPaintedNumberOfNotesInTuplet = false;
            foreach (NoteBeamType beam in element.BeamList)
            {

                int beamSpaceDirection = 1;
                if (element.StemDirection == NoteStemDirection.Up) beamSpaceDirection = 1;
                else beamSpaceDirection = -1;
                //if (beam != NoteBeamType.Single) MessageBox.Show(Convert.ToString(currentStemPositionX));
                if (beam == NoteBeamType.Start)
                {
                    renderer.State.previousStemEndPositionsY[beamLoop] = renderer.State.currentStemEndPositionY;
                    renderer.State.previousStemPositionsX[beamLoop] = renderer.State.currentStemPositionX;

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
                    renderer.DrawLine(new Point(renderer.State.previousStemPositionsX[beamLoop], renderer.State.previousStemEndPositionsY[beamLoop] + 28
                        + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28
                            + beamOffset * beamSpaceDirection), element);
                    renderer.DrawLine(new Point(renderer.State.previousStemPositionsX[beamLoop], renderer.State.previousStemEndPositionsY[beamLoop]
                        + 28 + 1 * beamSpaceDirection + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28
                            + 1 * beamSpaceDirection + beamOffset * beamSpaceDirection), element);
                    //Draw tuplet mark / Rysuj oznaczenie trioli:
                    if (element.Tuplet == TupletType.Stop && !alreadyPaintedNumberOfNotesInTuplet)
                    {
                        DrawTupletMark(renderer, element, beamLoop);
                        alreadyPaintedNumberOfNotesInTuplet = true;
                    }
                }
                else if ((beam == NoteBeamType.Single) && (!element.IsChordElement))
                {   //Rysuj chorągiewkę tylko najniższego dźwięku w akordzie
                    //Draw a hook only of the lowest element in a chord
                    double xPos = renderer.State.currentStemPositionX - 4;
                    if (renderer.State.IsPrintMode) xPos -= 0.9f;
                    if (element.StemDirection == NoteStemDirection.Down)
                    {
                        if (element.IsGraceNote || element.IsCueNote)
                            renderer.DrawString(element.NoteFlagCharacterRev, FontStyles.GraceNoteFont, new Point(xPos, renderer.State.currentStemEndPositionY + 11), element);
                        else
                            renderer.DrawString(element.NoteFlagCharacterRev, FontStyles.MusicFont, new Point(xPos, renderer.State.currentStemEndPositionY + 7), element);
                    }
                    else
                    {
                        if (element.IsGraceNote || element.IsCueNote)
                            renderer.DrawString(element.NoteFlagCharacter, FontStyles.GraceNoteFont, new Point(xPos + 0.5, renderer.State.currentStemEndPositionY + 3.5), element);
                        else
                            renderer.DrawString(element.NoteFlagCharacter, FontStyles.MusicFont, new Point(xPos, renderer.State.currentStemEndPositionY - 1), element);
                    }
                    if (element.Tuplet == TupletType.Stop && !alreadyPaintedNumberOfNotesInTuplet)
                    {
                        DrawTupletMark(renderer, element, beamLoop);
                        alreadyPaintedNumberOfNotesInTuplet = true;
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
                renderer.State.tieStartPoint = new Point(renderer.State.CursorPositionX, notePositionY);
            }
            else if (element.TieType != NoteTieType.None) //Stop or StopAndStartAnother / Stop lub StopAndStartAnother
            {
                if (element.StemDirection == NoteStemDirection.Down)
                {
                    renderer.DrawArc(new Rectangle(renderer.State.tieStartPoint.X + 10, renderer.State.tieStartPoint.Y + 6,
                        renderer.State.CursorPositionX - renderer.State.tieStartPoint.X, 20), 180, 180, element);
                    renderer.DrawArc(new Rectangle(renderer.State.tieStartPoint.X + 10, renderer.State.tieStartPoint.Y + 7,
                        renderer.State.CursorPositionX - renderer.State.tieStartPoint.X, 20), 180, 180, element);
                }
                else if (element.StemDirection == NoteStemDirection.Up)
                {
                    renderer.DrawArc(new Rectangle(renderer.State.tieStartPoint.X + 10, renderer.State.tieStartPoint.Y + 22,
                        renderer.State.CursorPositionX - renderer.State.tieStartPoint.X, 20), 0, 180, element);
                    renderer.DrawArc(new Rectangle(renderer.State.tieStartPoint.X + 10, renderer.State.tieStartPoint.Y + 23,
                        renderer.State.CursorPositionX - renderer.State.tieStartPoint.X, 20), 0, 180, element);
                }
                if (element.TieType == NoteTieType.StopAndStartAnother)
                {
                    renderer.State.tieStartPoint = new Point(renderer.State.CursorPositionX + 2, notePositionY);
                }

            }
        }

        private void DrawSlurs(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if (element.Slur == NoteSlurType.Start)
            {
                renderer.State.slurStartPoint = new Point(renderer.State.CursorPositionX, notePositionY);
            }
            else if (element.Slur == NoteSlurType.Stop)
            {
                if (element.StemDirection == NoteStemDirection.Down)
                {
                    renderer.DrawBezier(renderer.State.slurStartPoint.X + 10, renderer.State.slurStartPoint.Y + 18,
                        renderer.State.slurStartPoint.X + 12, renderer.State.slurStartPoint.Y + 9,
                        renderer.State.CursorPositionX + 8, notePositionY + 9,
                        renderer.State.CursorPositionX + 10, notePositionY + 18, element);
                    /*
                    renderer.DrawArc(pen, new Rectangle((int)slurStartPoint.X + 10, (int)slurStartPoint.Y + 4,
                        (int)currentXPosition - (int)slurStartPoint.X, 20), 180, 180);
                    renderer.DrawArc(pen, new Rectangle((int)slurStartPoint.X + 10, (int)slurStartPoint.Y + 5,
                        (int)currentXPosition - (int)slurStartPoint.X, 20), 180, 180);
                    */
                }
                else if (element.StemDirection == NoteStemDirection.Up)
                {
                    renderer.DrawBezier(renderer.State.slurStartPoint.X + 10, renderer.State.slurStartPoint.Y + 30,
                        renderer.State.slurStartPoint.X + 12, renderer.State.slurStartPoint.Y + 44,
                        renderer.State.CursorPositionX + 8, notePositionY + 44,
                        renderer.State.CursorPositionX + 10, notePositionY + 30, element);
                    /*
                    renderer.DrawArc(pen, new Rectangle((int)slurStartPoint.X + 10, (int)slurStartPoint.Y + 24,
                        (int)currentXPosition - (int)slurStartPoint.X, 20), 0, 180);
                    renderer.DrawArc(pen, new Rectangle((int)slurStartPoint.X + 10, (int)slurStartPoint.Y + 25,
                        (int)currentXPosition - (int)slurStartPoint.X, 20), 0, 180);
                     * */
                }
            }
        }

        private void DrawLyrics(ScoreRendererBase renderer, Note element)
        {
            int textPositionY = renderer.State.LinePositions[4] + 10;
            for (int j = 0; j < element.Lyrics.Count; j++)
            {
                StringBuilder sBuilder = new StringBuilder();
                if ((element.Lyrics[j].Type == LyricsType.End) ||
                    (element.Lyrics[j].Type == LyricsType.Middle))
                    sBuilder.Append("-");
                sBuilder.Append(element.Lyrics[j].Text);
                if ((element.Lyrics[j].Type == LyricsType.Begin) ||
                    (element.Lyrics[j].Type == LyricsType.Middle))
                    sBuilder.Append("-");
                renderer.DrawString(sBuilder.ToString(), FontStyles.LyricsFont, renderer.State.CursorPositionX, textPositionY, element);
                textPositionY += 12;
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
                    renderer.DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, renderer.State.CursorPositionX + 6, articulationPosition, element);
                else if (element.Articulation == ArticulationType.Accent)
                    renderer.DrawString(">", FontStyles.MiscArticulationFont, renderer.State.CursorPositionX + 6, articulationPosition + 16, element);

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
                    if (trillPos > renderer.State.LinePositions[0] - 24.4f)
                    {
                        trillPos = renderer.State.LinePositions[0] - 24.4f - 1.0f;
                    }
                }
                else if (element.TrillMark == NoteTrillMark.Below)
                {
                    trillPos = notePositionY + 10;
                }
                renderer.DrawString("tr", FontStyles.TrillFont, renderer.State.CursorPositionX + 6, trillPos, element);
            }
        }

        private void DrawTremolos(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            double currentTremoloPos = notePositionY + 18;
            for (int j = 0; j < element.TremoloLevel; j++)
            {
                if (element.StemDirection == NoteStemDirection.Up)
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
                double ferPos = notePositionY - 9;
                if (ferPos > renderer.State.LinePositions[0] - 24.4f) ferPos = renderer.State.LinePositions[0] - 24.4f - 9.0f;

                renderer.DrawArc(new Rectangle(renderer.State.CursorPositionX + 5, (int)ferPos + 17,
                       10, 10), 180, 180, element);
                renderer.DrawArc(new Rectangle(renderer.State.CursorPositionX + 5, (int)ferPos + 18,
                        10, 10), 180, 180, element);
                renderer.DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, renderer.State.CursorPositionX + 6, ferPos, element);
            }
        }

        private void DrawAccidentals(ScoreRendererBase renderer, Note element, double notePositionY, int numberOfSingleAccidentals, int numberOfDoubleAccidentals)
        {
            if (element.Alter - renderer.State.CurrentKey.StepToAlter(element.Step)
                - renderer.State.alterationsWithinOneBar[element.StepToStepNumber()] > 0)
            {
                renderer.State.alterationsWithinOneBar[element.StepToStepNumber()] =
                    element.Alter - renderer.State.CurrentKey.StepToAlter(element.Step);
                double accPlacement = renderer.State.CursorPositionX - 9 * numberOfSingleAccidentals - 9 * numberOfDoubleAccidentals;
                for (int i = 0; i < numberOfSingleAccidentals; i++)
                {
                    renderer.DrawString(MusicalCharacters.Sharp, FontStyles.MusicFont, accPlacement, notePositionY, element);
                    accPlacement += 9;
                }
                for (int i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    renderer.DrawString(MusicalCharacters.DoubleSharp, FontStyles.MusicFont, accPlacement, notePositionY, element);
                    accPlacement += 9;
                }
            }
            else if (element.Alter - renderer.State.CurrentKey.StepToAlter(element.Step)
                - renderer.State.alterationsWithinOneBar[element.StepToStepNumber()] < 0)
            {
                renderer.State.alterationsWithinOneBar[element.StepToStepNumber()] =
                    element.Alter - renderer.State.CurrentKey.StepToAlter(element.Step);
                double accPlacement = renderer.State.CursorPositionX - 9 * numberOfSingleAccidentals -
                    9 * numberOfDoubleAccidentals;
                for (int i = 0; i < numberOfSingleAccidentals; i++)
                {
                    renderer.DrawString(MusicalCharacters.Flat, FontStyles.MusicFont, accPlacement, notePositionY, element);
                    accPlacement += 9;
                }
                for (int i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    renderer.DrawString(MusicalCharacters.DoubleFlat, FontStyles.MusicFont, accPlacement, notePositionY, element);
                    accPlacement += 9;
                }
            }
            if (element.HasNatural == true)
            {
                renderer.DrawString(MusicalCharacters.Natural, FontStyles.MusicFont, renderer.State.CursorPositionX - 9, notePositionY, element);
            }
        }

        private void DrawDots(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if (element.NumberOfDots > 0) renderer.State.CursorPositionX += 16;
            for (int i = 0; i < element.NumberOfDots; i++)
            {
                renderer.DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, renderer.State.CursorPositionX, notePositionY, element);
                renderer.State.CursorPositionX += 6;
            }
        }

        private void MakeSpaceForAccidentals(ScoreRendererBase renderer, Note element, int numberOfSingleAccidentals, int numberOfDoubleAccidentals)
        {
            if (renderer.Settings.IgnoreCustomElementPositions || element.DefaultXPosition == 0)
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
