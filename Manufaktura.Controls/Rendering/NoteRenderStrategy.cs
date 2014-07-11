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
            if (renderer.State.firstNoteInIncipit) renderer.State.firstNoteInMeasureXPosition = renderer.State.currentXPosition;
            renderer.State.firstNoteInIncipit = false;

            if (element.Voice > renderer.State.currentVoice)
            {
                renderer.State.currentXPosition = renderer.State.firstNoteInMeasureXPosition;
                renderer.State.lastNoteInMeasureEndXPosition = renderer.State.lastNoteEndXPosition;
            }
            renderer.State.currentVoice = element.Voice;



            if (element.Tuplet == TupletType.Start) renderer.State.numberOfNotesUnderTuplet = 0;
            renderer.State.numberOfNotesUnderTuplet++;

            if (element.IsChordElement) renderer.State.currentXPosition = renderer.State.lastXPosition;

            double notePositionY = renderer.State.currentClefPositionY + MusicalSymbol.StepDifference(renderer.State.CurrentClef,
                element) * ((double)renderer.State.lineSpacing / 2.0f);
            if (renderer.State.print) notePositionY -= 0.8f;

            int numberOfSingleAccidentals = Math.Abs(element.Alter) % 2;
            int numberOfDoubleAccidentals =
                Convert.ToInt32(Math.Floor((double)(Math.Abs(element.Alter) / 2)));

            //Move the element a bit to the right if it has accidentals / Przesuń nutę trochę w prawo, jeśli nuta ma znaki przygodne
            if (element.Alter - renderer.State.currentKey.StepToAlter(element.Step) != 0)
            {
                if (numberOfSingleAccidentals > 0) renderer.State.currentXPosition += 9;
                if (numberOfDoubleAccidentals > 0)
                    renderer.State.currentXPosition += (numberOfDoubleAccidentals) * 9;

            }
            if (element.HasNatural == true) renderer.State.currentXPosition += 9;

            //Draw a element / Rysuj nutę:
            if (!element.IsGraceNote)
                renderer.DrawString(element.MusicalCharacter, FontStyles.MusicFont, renderer.State.currentXPosition, notePositionY);
            else
                renderer.DrawString(element.MusicalCharacter, FontStyles.GraceNoteFont, renderer.State.currentXPosition + 1, notePositionY + 2);
            renderer.State.lastXPosition = renderer.State.currentXPosition;
            element.Location = new Point(renderer.State.currentXPosition, notePositionY);

            //Ledger lines / Linie dodane
            double tmpXPos = renderer.State.currentXPosition + 16;
            if (renderer.State.print) tmpXPos += 1.5f;
            if (notePositionY + 25.0f > renderer.State.lines[4] + renderer.State.lineSpacing / 2.0f)
            {
                for (int i = renderer.State.lines[4]; i < notePositionY + 24f - renderer.State.lineSpacing / 2.0f; i += renderer.State.lineSpacing)
                {

                    renderer.DrawLine(new Point(renderer.State.currentXPosition + 4, i + renderer.State.lineSpacing),
                        new Point(tmpXPos, i + renderer.State.lineSpacing));
                }
            }
            if (notePositionY + 25.0f < renderer.State.lines[0] - renderer.State.lineSpacing / 2)
            {

                for (int i = renderer.State.lines[0]; i > notePositionY + 26.0f + renderer.State.lineSpacing / 2.0f; i -= renderer.State.lineSpacing)
                {

                    renderer.DrawLine(new Point(renderer.State.currentXPosition + 4, i - renderer.State.lineSpacing),
                        new Point(tmpXPos, i - renderer.State.lineSpacing));
                }
            }

            //Draw stems (stems are vertical lines, beams are horizontal lines :P)/ Rysuj ogonki: (ogonki to są te w pionie - poziome są belki ;P ;P ;P)
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
                    renderer.State.currentStemPositionX = renderer.State.currentXPosition + 7;
                    if (renderer.State.print) renderer.State.currentStemPositionX += 0.1f;

                    if (element.BeamList.Count > 0)
                        if ((element.BeamList[0] != NoteBeamType.Continue) || element.CustomStemEndPosition)
                            renderer.DrawLine(new Point(renderer.State.currentStemPositionX, notePositionY - 1 + 28), new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28));
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
                    renderer.State.currentStemPositionX = renderer.State.currentXPosition + 13;
                    if (renderer.State.print) renderer.State.currentStemPositionX += 0.9f;

                    if (element.BeamList.Count > 0)
                        if ((element.BeamList[0] != NoteBeamType.Continue) || element.CustomStemEndPosition)
                            renderer.DrawLine(new Point(renderer.State.currentStemPositionX, notePositionY - 7 + 30),
                                new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28));
                }
                element.StemEndLocation = new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY);
            }
            //Draw beams / Rysuj belki:
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
                            + beamOffset * beamSpaceDirection));
                    renderer.DrawLine(new Point(renderer.State.previousStemPositionsX[beamLoop], renderer.State.previousStemEndPositionsY[beamLoop]
                        + 28 + 1 * beamSpaceDirection + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28
                            + 1 * beamSpaceDirection + beamOffset * beamSpaceDirection));
                    //Draw tuplet mark / Rysuj oznaczenie trioli:
                    if (element.Tuplet == TupletType.Stop && !alreadyPaintedNumberOfNotesInTuplet)
                    {
                        int tmpMod;
                        if (element.StemDirection == NoteStemDirection.Up) tmpMod = 12;
                        else tmpMod = 28;
                        renderer.DrawString(Convert.ToString(renderer.State.numberOfNotesUnderTuplet), FontStyles.LyricsFont,
                                new Point(renderer.State.previousStemPositionsX[beamLoop] + (renderer.State.currentStemPositionX - renderer.State.previousStemPositionsX[beamLoop]) / 2 - 1,
                                renderer.State.previousStemEndPositionsY[beamLoop] - (renderer.State.currentStemEndPositionY - renderer.State.previousStemEndPositionsY[beamLoop]) / 2 + tmpMod));
                        alreadyPaintedNumberOfNotesInTuplet = true;
                    }
                }
                else if ((beam == NoteBeamType.Single) && (!element.IsChordElement))
                {   //Rysuj chorągiewkę tylko najniższego dźwięku w akordzie
                    //Draw a hook only of the lowest element in a chord
                    double xPos = renderer.State.currentStemPositionX - 4;
                    if (renderer.State.print) xPos -= 0.9f;
                    if (element.StemDirection == NoteStemDirection.Down)
                    {
                        renderer.DrawString(element.NoteFlagCharacterRev, FontStyles.MusicFont, new Point(xPos, renderer.State.currentStemEndPositionY + 7));
                    }
                    else
                    {
                        renderer.DrawString(element.NoteFlagCharacter, FontStyles.MusicFont, new Point(xPos, renderer.State.currentStemEndPositionY - 1));
                    }
                }
                else if (beam == NoteBeamType.ForwardHook)
                {
                    renderer.DrawLine(new Point(renderer.State.currentStemPositionX + 6,
                        renderer.State.currentStemEndPositionY + 28 + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28
                        + beamOffset * beamSpaceDirection));
                    renderer.DrawLine(new Point(renderer.State.currentStemPositionX + 6,
                        renderer.State.currentStemEndPositionY + 29 + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 29
                        + beamOffset * beamSpaceDirection));
                }
                else if (beam == NoteBeamType.BackwardHook)
                {
                    renderer.DrawLine(new Point(renderer.State.currentStemPositionX - 6,
                        renderer.State.currentStemEndPositionY + 28 + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28
                        + beamOffset * beamSpaceDirection));
                    renderer.DrawLine(new Point(renderer.State.currentStemPositionX - 6,
                        renderer.State.currentStemEndPositionY + 29 + beamOffset * beamSpaceDirection),
                        new Point(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 29
                        + beamOffset * beamSpaceDirection));
                }

                beamOffset += 4;
                beamLoop++;

            }

            //Draw ties / Rysuj łuki:
            if (element.TieType == NoteTieType.Start)
            {
                renderer.State.tieStartPoint = new Point(renderer.State.currentXPosition, notePositionY);
            }
            else if (element.TieType != NoteTieType.None) //Stop or StopAndStartAnother / Stop lub StopAndStartAnother
            {
                if (element.StemDirection == NoteStemDirection.Down)
                {
                    renderer.DrawArc(new Rectangle(renderer.State.tieStartPoint.X + 10, renderer.State.tieStartPoint.Y + 6,
                        renderer.State.currentXPosition - renderer.State.tieStartPoint.X, 20), 180, 180);
                    renderer.DrawArc(new Rectangle(renderer.State.tieStartPoint.X + 10, renderer.State.tieStartPoint.Y + 7,
                        renderer.State.currentXPosition - renderer.State.tieStartPoint.X, 20), 180, 180);
                }
                else if (element.StemDirection == NoteStemDirection.Up)
                {
                    renderer.DrawArc(new Rectangle(renderer.State.tieStartPoint.X + 10, renderer.State.tieStartPoint.Y + 22,
                        renderer.State.currentXPosition - renderer.State.tieStartPoint.X, 20), 0, 180);
                    renderer.DrawArc(new Rectangle(renderer.State.tieStartPoint.X + 10, renderer.State.tieStartPoint.Y + 23,
                        renderer.State.currentXPosition - renderer.State.tieStartPoint.X, 20), 0, 180);
                }
                if (element.TieType == NoteTieType.StopAndStartAnother)
                {
                    renderer.State.tieStartPoint = new Point(renderer.State.currentXPosition + 2, notePositionY);
                }

            }

            //Draw slurs / Rysuj łuki legatowe:
            if (element.Slur == NoteSlurType.Start)
            {
                renderer.State.slurStartPoint = new Point(renderer.State.currentXPosition, notePositionY);
            }
            else if (element.Slur == NoteSlurType.Stop)
            {
                if (element.StemDirection == NoteStemDirection.Down)
                {
                    renderer.DrawBezier(renderer.State.slurStartPoint.X + 10, renderer.State.slurStartPoint.Y + 18,
                        renderer.State.slurStartPoint.X + 12, renderer.State.slurStartPoint.Y + 9,
                        renderer.State.currentXPosition + 8, notePositionY + 9,
                        renderer.State.currentXPosition + 10, notePositionY + 18);
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
                        renderer.State.currentXPosition + 8, notePositionY + 44,
                        renderer.State.currentXPosition + 10, notePositionY + 30);
                    /*
                    renderer.DrawArc(pen, new Rectangle((int)slurStartPoint.X + 10, (int)slurStartPoint.Y + 24,
                        (int)currentXPosition - (int)slurStartPoint.X, 20), 0, 180);
                    renderer.DrawArc(pen, new Rectangle((int)slurStartPoint.X + 10, (int)slurStartPoint.Y + 25,
                        (int)currentXPosition - (int)slurStartPoint.X, 20), 0, 180);
                     * */
                }
            }

            //Draw lyrics / Rysuj tekst:
            int textPositionY = renderer.State.lines[4] + 10;
            for (int j = 0; (j < (element.Lyrics.Count)) &&
                (j < (element.LyricTexts.Count))
                ; j++)
            {
                StringBuilder sBuilder = new StringBuilder();
                if ((element.Lyrics[j] == LyricsType.End) ||
                    (element.Lyrics[j] == LyricsType.Middle))
                    sBuilder.Append("-");
                sBuilder.Append(element.LyricTexts[j]);
                if ((element.Lyrics[j] == LyricsType.Begin) ||
                    (element.Lyrics[j] == LyricsType.Middle))
                    sBuilder.Append("-");
                renderer.DrawString(sBuilder.ToString(), FontStyles.LyricsFont, renderer.State.currentXPosition, textPositionY);
                textPositionY += 12;
            }

            //Draw articulation / Rysuj artykulację:
            if (element.Articulation != ArticulationType.None)
            {
                double articulationPosition = notePositionY + 10;
                if (element.ArticulationPlacement == ArticulationPlacementType.Above)
                    articulationPosition = notePositionY - 10;
                else if (element.ArticulationPlacement == ArticulationPlacementType.Below)
                    articulationPosition = notePositionY + 10;

                if (element.Articulation == ArticulationType.Staccato)
                    renderer.DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, renderer.State.currentXPosition + 6, articulationPosition);
                else if (element.Articulation == ArticulationType.Accent)
                    renderer.DrawString(">", FontStyles.MiscArticulationFont, renderer.State.currentXPosition + 6, articulationPosition + 16);

            }

            //Draw trills / Rysuj tryle:
            if (element.TrillMark != NoteTrillMark.None)
            {
                double trillPos = notePositionY - 1;
                if (element.TrillMark == NoteTrillMark.Above)
                {
                    trillPos = notePositionY - 1;
                    if (trillPos > renderer.State.lines[0] - 24.4f)
                    {
                        trillPos = renderer.State.lines[0] - 24.4f - 1.0f;
                    }
                }
                else if (element.TrillMark == NoteTrillMark.Below)
                {
                    trillPos = notePositionY + 10;
                }
                renderer.DrawString("tr", FontStyles.TrillFont, renderer.State.currentXPosition + 6, trillPos);
            }

            //Draw tremolos / Rysuj tremola:
            double currentTremoloPos = notePositionY + 18;
            for (int j = 0; j < element.TremoloLevel; j++)
            {
                if (element.StemDirection == NoteStemDirection.Up)
                {
                    currentTremoloPos -= 4;
                    renderer.DrawLine(renderer.State.currentXPosition + 9, currentTremoloPos + 1, renderer.State.currentXPosition + 16, currentTremoloPos - 1);
                    renderer.DrawLine(renderer.State.currentXPosition + 9, currentTremoloPos + 2, renderer.State.currentXPosition + 16, currentTremoloPos);
                }
                else
                {
                    currentTremoloPos += 4;
                    renderer.DrawLine(renderer.State.currentXPosition + 3, currentTremoloPos + 11 + 1, renderer.State.currentXPosition + 11, currentTremoloPos + 11 - 1);
                    renderer.DrawLine(renderer.State.currentXPosition + 3, currentTremoloPos + 11 + 2, renderer.State.currentXPosition + 11, currentTremoloPos + 11);
                }

            }

            //Draw fermata sign / Rysuj symbol fermaty:
            if (element.HasFermataSign)
            {
                double ferPos = notePositionY - 9;
                if (ferPos > renderer.State.lines[0] - 24.4f) ferPos = renderer.State.lines[0] - 24.4f - 9.0f;

                renderer.DrawArc(new Rectangle(renderer.State.currentXPosition + 5, (int)ferPos + 17,
                       10, 10), 180, 180);
                renderer.DrawArc(new Rectangle(renderer.State.currentXPosition + 5, (int)ferPos + 18,
                        10, 10), 180, 180);
                renderer.DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, renderer.State.currentXPosition + 6, ferPos);
            }

            //Draw accidental signs / Rysuj akcydencje:
            if (element.Alter - renderer.State.currentKey.StepToAlter(element.Step)
                - renderer.State.alterationsWithinOneBar[element.StepToStepNumber()] > 0)
            {
                renderer.State.alterationsWithinOneBar[element.StepToStepNumber()] =
                    element.Alter - renderer.State.currentKey.StepToAlter(element.Step);
                double accPlacement = renderer.State.currentXPosition - 9 * numberOfSingleAccidentals - 9 * numberOfDoubleAccidentals;
                for (int i = 0; i < numberOfSingleAccidentals; i++)
                {
                    renderer.DrawString(MusicalCharacters.Sharp, FontStyles.MusicFont, accPlacement, notePositionY);
                    accPlacement += 9;
                }
                for (int i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    renderer.DrawString(MusicalCharacters.DoubleSharp, FontStyles.MusicFont, accPlacement, notePositionY);
                    accPlacement += 9;
                }
            }
            else if (element.Alter - renderer.State.currentKey.StepToAlter(element.Step)
                - renderer.State.alterationsWithinOneBar[element.StepToStepNumber()] < 0)
            {
                renderer.State.alterationsWithinOneBar[element.StepToStepNumber()] =
                    element.Alter - renderer.State.currentKey.StepToAlter(element.Step);
                double accPlacement = renderer.State.currentXPosition - 9 * numberOfSingleAccidentals -
                    9 * numberOfDoubleAccidentals;
                for (int i = 0; i < numberOfSingleAccidentals; i++)
                {
                    renderer.DrawString(MusicalCharacters.Flat, FontStyles.MusicFont, accPlacement, notePositionY);
                    accPlacement += 9;
                }
                for (int i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    renderer.DrawString(MusicalCharacters.DoubleFlat, FontStyles.MusicFont, accPlacement, notePositionY);
                    accPlacement += 9;
                }
            }
            if (element.HasNatural == true)
            {
                renderer.DrawString(MusicalCharacters.Natural, FontStyles.MusicFont, renderer.State.currentXPosition - 9, notePositionY);
            }

            //Draw dots / Rysuj kropki:
            if (element.NumberOfDots > 0) renderer.State.currentXPosition += 16;
            for (int i = 0; i < element.NumberOfDots; i++)
            {
                renderer.DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, renderer.State.currentXPosition, notePositionY);
                renderer.State.currentXPosition += 6;
            }


            if (element.Duration == MusicalSymbolDuration.Whole) renderer.State.currentXPosition += 50;
            else if (element.Duration == MusicalSymbolDuration.Half) renderer.State.currentXPosition += 30;
            else if (element.Duration == MusicalSymbolDuration.Quarter) renderer.State.currentXPosition += 18;
            else if (element.Duration == MusicalSymbolDuration.Eighth) renderer.State.currentXPosition += 15;
            else if (element.Duration == MusicalSymbolDuration.Unknown) renderer.State.currentXPosition += 25;
            else renderer.State.currentXPosition += 14;

            //Przesuń trochę w prawo, jeśli nuta ma tekst, żeby litery nie wchodziły na siebie
            //Move a bit right if the element has a lyric to prevent letters from hiding each other
            if (element.Lyrics.Count > 0)
            {
                renderer.State.currentXPosition += element.LyricTexts[0].Length * 2;
            }

            renderer.State.lastNoteEndXPosition = renderer.State.currentXPosition;
        }
    }
}
