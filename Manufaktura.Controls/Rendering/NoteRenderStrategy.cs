using Manufaktura.Controls.Model;
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
            Note note = ((Note)symbol);
            if (firstNoteInIncipit) firstNoteInMeasureXPosition = currentXPosition;
            firstNoteInIncipit = false;

            if (note.Voice > currentVoice)
            {
                currentXPosition = firstNoteInMeasureXPosition;
                lastNoteInMeasureEndXPosition = lastNoteEndXPosition;
            }
            currentVoice = note.Voice;



            if (note.Tuplet == TupletType.Start) numberOfNotesUnderTuplet = 0;
            numberOfNotesUnderTuplet++;

            if (note.IsChordElement) currentXPosition = lastXPosition;

            float notePositionY = currentClefPositionY + MusicalSymbol.StepDifference(currentClef,
                note) * ((float)lineSpacing / 2.0f);
            if (print) notePositionY -= 0.8f;

            int numberOfSingleAccidentals = Math.Abs(note.Alter) % 2;
            int numberOfDoubleAccidentals =
                Convert.ToInt32(Math.Floor((double)(Math.Abs(note.Alter) / 2)));

            //Move the note a bit to the right if it has accidentals / Przesuń nutę trochę w prawo, jeśli nuta ma znaki przygodne
            if (note.Alter - currentKey.StepToAlter(note.Step) != 0)
            {
                if (numberOfSingleAccidentals > 0) currentXPosition += 9;
                if (numberOfDoubleAccidentals > 0)
                    currentXPosition += (numberOfDoubleAccidentals) * 9;

            }
            if (note.HasNatural == true) currentXPosition += 9;

            //Draw a note / Rysuj nutę:
            if (!note.IsGraceNote)
                g.DrawString(symbol.MusicalCharacter, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, notePositionY);
            else
                g.DrawString(symbol.MusicalCharacter, FontStyles.GraceNoteFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition + 1,
                    notePositionY + 2);
            lastXPosition = currentXPosition;
            note.Location = new PointF(currentXPosition, notePositionY);

            //Ledger lines / Linie dodane
            float tmpXPos = currentXPosition + 16;
            if (print) tmpXPos += 1.5f;
            if (notePositionY + 25.0f > lines[4] + lineSpacing / 2.0f)
            {
                for (int i = lines[4]; i < notePositionY + 24f - lineSpacing / 2.0f; i += lineSpacing)
                {

                    g.DrawLine(pen, new Point(currentXPosition + 4, i + lineSpacing),
                        new PointF(tmpXPos, i + lineSpacing));
                }
            }
            if (notePositionY + 25.0f < lines[0] - lineSpacing / 2)
            {

                for (int i = lines[0]; i > notePositionY + 26.0f + lineSpacing / 2.0f; i -= lineSpacing)
                {

                    g.DrawLine(pen, new Point(currentXPosition + 4, i - lineSpacing),
                        new PointF(tmpXPos, i - lineSpacing));
                }
            }

            //Draw stems (stems are vertical lines, beams are horizontal lines :P)/ Rysuj ogonki: (ogonki to są te w pionie - poziome są belki ;P ;P ;P)
            if ((note.Duration != MusicalSymbolDuration.Whole) &&
                (note.Duration != MusicalSymbolDuration.Unknown))
            {
                float tmpStemPosY;

                tmpStemPosY = note.StemDefaultY * -1.0f / 2.0f;


                if (note.StemDirection == NoteStemDirection.Down)
                {
                    //Ogonki elementów akordów nie były dobrze wyświetlane, jeśli stosowałem
                    //default-y. Dlatego dla akordów zostawiam domyślne rysowanie ogonków.
                    //Stems of chord elements were displayed wrong when I used default-y
                    //so I left default stem drawing routine for chords.
                    if (((note.IsChordElement) || xmlIncipit.InnerXml.Length == 0)
                        || (!(note.CustomStemEndPosition)))
                        currentStemEndPositionY = notePositionY + 18;
                    else
                        currentStemEndPositionY = tmpStemPosY - 4;
                    currentStemPositionX = currentXPosition + 7;
                    if (print) currentStemPositionX += 0.1f;

                    if (note.BeamList.Count > 0)
                        if ((note.BeamList[0] != NoteBeamType.Continue) || note.CustomStemEndPosition)
                            g.DrawLine(new Pen(note.MusicalCharacterColor), new PointF(currentStemPositionX, notePositionY - 1 + 28),
                                new PointF(currentStemPositionX, currentStemEndPositionY + 28));
                }
                else
                {
                    //Ogonki elementów akordów nie były dobrze wyświetlane, jeśli stosowałem
                    //default-y. Dlatego dla akordów zostawiam domyślne rysowanie ogonków.
                    //Stems of chord elements were displayed wrong when I used default-y
                    //so I left default stem drawing routine for chords.
                    if ((note.IsChordElement) || xmlIncipit.InnerXml.Length == 0
                        || (!(note.CustomStemEndPosition)))
                        currentStemEndPositionY = notePositionY - 25;

                    else
                        currentStemEndPositionY = tmpStemPosY - 6;
                    currentStemPositionX = currentXPosition + 13;
                    if (print) currentStemPositionX += 0.9f;

                    if (note.BeamList.Count > 0)
                        if ((note.BeamList[0] != NoteBeamType.Continue) || note.CustomStemEndPosition)
                            g.DrawLine(pen, new PointF(currentStemPositionX, notePositionY - 7 + 30),
                                new PointF(currentStemPositionX, currentStemEndPositionY + 28));
                }
                note.StemEndLocation = new PointF(currentStemPositionX, currentStemEndPositionY);
            }
            //Draw beams / Rysuj belki:
            int beamOffset = 0;
            //Powiększ listę poprzednich pozycji stemów jeśli aktualna liczba belek jest większa
            //Extend the list of previous stem positions if current number of beams is greater than the list size
            if (previousStemEndPositionsY.Count < ((Note)symbol).BeamList.Count)
            {
                int tmpCount = previousStemEndPositionsY.Count;
                for (int i = 0; i < ((Note)symbol).BeamList.Count - tmpCount; i++)
                    previousStemEndPositionsY.Add(new int());
            }
            if (previousStemPositionsX.Count < ((Note)symbol).BeamList.Count)
            {
                int tmpCount = previousStemPositionsX.Count;
                for (int i = 0; i < ((Note)symbol).BeamList.Count - tmpCount; i++)
                    previousStemPositionsX.Add(new int());
            }
            int beamLoop = 0;
            bool alreadyPaintedNumberOfNotesInTuplet = false;
            foreach (NoteBeamType beam in ((Note)symbol).BeamList)
            {

                int beamSpaceDirection = 1;
                if (((Note)symbol).StemDirection == NoteStemDirection.Up) beamSpaceDirection = 1;
                else beamSpaceDirection = -1;
                //if (beam != NoteBeamType.Single) MessageBox.Show(Convert.ToString(currentStemPositionX));
                if (beam == NoteBeamType.Start)
                {
                    previousStemEndPositionsY[beamLoop] = currentStemEndPositionY;
                    previousStemPositionsX[beamLoop] = currentStemPositionX;

                }
                else if (beam == NoteBeamType.Continue)
                {
                    //int prevStemPosY = currentStemEndPositionY;
                    //currentStemEndPositionY = previousStemEndPositionsY[i];
                    //g.DrawLine(pen, new Point(currentStemPositionX, prevStemPosY + 28),
                    //    new Point(currentStemPositionX, currentStemEndPositionY + 28));
                }
                else if (beam == NoteBeamType.End)
                {
                    //MessageBox.Show(Convert.ToString(previousStemPositionsX[beamLoop])
                    //    + "," + Convert.ToString(currentStemPositionX));
                    g.DrawLine(new Pen(note.MusicalCharacterColor), new PointF(previousStemPositionsX[beamLoop], previousStemEndPositionsY[beamLoop] + 28
                        + beamOffset * beamSpaceDirection),
                        new PointF(currentStemPositionX, currentStemEndPositionY + 28
                            + beamOffset * beamSpaceDirection));
                    g.DrawLine(new Pen(note.MusicalCharacterColor), new PointF(previousStemPositionsX[beamLoop], previousStemEndPositionsY[beamLoop]
                        + 28 + 1 * beamSpaceDirection + beamOffset * beamSpaceDirection),
                        new PointF(currentStemPositionX, currentStemEndPositionY + 28
                            + 1 * beamSpaceDirection + beamOffset * beamSpaceDirection));
                    //Draw tuplet mark / Rysuj oznaczenie trioli:
                    if ((((Note)symbol).Tuplet == TupletType.Stop) && (!alreadyPaintedNumberOfNotesInTuplet))
                    {
                        int tmpMod;
                        if (((Note)symbol).StemDirection == NoteStemDirection.Up) tmpMod = 12;
                        else tmpMod = 28;
                        g.DrawString(Convert.ToString(numberOfNotesUnderTuplet), FontStyles.LyricFont,
                            new SolidBrush(symbol.MusicalCharacterColor),
                            new PointF(previousStemPositionsX[beamLoop] + (currentStemPositionX - previousStemPositionsX[beamLoop]) / 2 - 1,
                                previousStemEndPositionsY[beamLoop] - (currentStemEndPositionY - previousStemEndPositionsY[beamLoop]) / 2 + tmpMod));
                        alreadyPaintedNumberOfNotesInTuplet = true;
                    }
                }
                else if ((beam == NoteBeamType.Single) && (!((Note)symbol).IsChordElement))
                {   //Rysuj chorągiewkę tylko najniższego dźwięku w akordzie
                    //Draw a hook only of the lowest note in a chord
                    float xPos = currentStemPositionX - 4;
                    if (print) xPos -= 0.9f;
                    if (((Note)symbol).StemDirection == NoteStemDirection.Down)
                    {
                        g.DrawString(((Note)symbol).NoteFlagCharacterRev, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor),
                            new PointF(xPos, currentStemEndPositionY + 7));
                    }
                    else
                    {
                        g.DrawString(((Note)symbol).NoteFlagCharacter, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor),
                            new PointF(xPos, currentStemEndPositionY - 1));
                    }
                }
                else if (beam == NoteBeamType.ForwardHook)
                {
                    g.DrawLine(new Pen(note.MusicalCharacterColor), new PointF(currentStemPositionX + 6,
                        currentStemEndPositionY + 28 + beamOffset * beamSpaceDirection),
                        new PointF(currentStemPositionX, currentStemEndPositionY + 28
                        + beamOffset * beamSpaceDirection));
                    g.DrawLine(new Pen(note.MusicalCharacterColor), new PointF(currentStemPositionX + 6,
                        currentStemEndPositionY + 29 + beamOffset * beamSpaceDirection),
                        new PointF(currentStemPositionX, currentStemEndPositionY + 29
                        + beamOffset * beamSpaceDirection));
                }
                else if (beam == NoteBeamType.BackwardHook)
                {
                    g.DrawLine(new Pen(note.MusicalCharacterColor), new PointF(currentStemPositionX - 6,
                        currentStemEndPositionY + 28 + beamOffset * beamSpaceDirection),
                        new PointF(currentStemPositionX, currentStemEndPositionY + 28
                        + beamOffset * beamSpaceDirection));
                    g.DrawLine(new Pen(note.MusicalCharacterColor), new PointF(currentStemPositionX - 6,
                        currentStemEndPositionY + 29 + beamOffset * beamSpaceDirection),
                        new PointF(currentStemPositionX, currentStemEndPositionY + 29
                        + beamOffset * beamSpaceDirection));
                }

                beamOffset += 4;
                beamLoop++;

            }

            //Draw ties / Rysuj łuki:
            if (((Note)symbol).TieType == NoteTieType.Start)
            {
                tieStartPoint = new PointF(currentXPosition, notePositionY);
            }
            else if (((Note)symbol).TieType != NoteTieType.None) //Stop or StopAndStartAnother / Stop lub StopAndStartAnother
            {
                if (((Note)symbol).StemDirection == NoteStemDirection.Down)
                {
                    g.DrawArc(new Pen(note.MusicalCharacterColor), new Rectangle((int)tieStartPoint.X + 10, (int)tieStartPoint.Y + 6,
                        (int)currentXPosition - (int)tieStartPoint.X, 20), 180, 180);
                    g.DrawArc(new Pen(note.MusicalCharacterColor), new Rectangle((int)tieStartPoint.X + 10, (int)tieStartPoint.Y + 7,
                        (int)currentXPosition - (int)tieStartPoint.X, 20), 180, 180);
                }
                else if (((Note)symbol).StemDirection == NoteStemDirection.Up)
                {
                    g.DrawArc(new Pen(note.MusicalCharacterColor), new Rectangle((int)tieStartPoint.X + 10, (int)tieStartPoint.Y + 22,
                        (int)currentXPosition - (int)tieStartPoint.X, 20), 0, 180);
                    g.DrawArc(new Pen(note.MusicalCharacterColor), new Rectangle((int)tieStartPoint.X + 10, (int)tieStartPoint.Y + 23,
                        (int)currentXPosition - (int)tieStartPoint.X, 20), 0, 180);
                }
                if (((Note)symbol).TieType == NoteTieType.StopAndStartAnother)
                {
                    tieStartPoint = new PointF(currentXPosition + 2, notePositionY);
                }

            }

            //Draw slurs / Rysuj łuki legatowe:
            if (((Note)symbol).Slur == NoteSlurType.Start)
            {
                slurStartPoint = new PointF(currentXPosition, notePositionY);
            }
            else if (((Note)symbol).Slur == NoteSlurType.Stop)
            {
                if (((Note)symbol).StemDirection == NoteStemDirection.Down)
                {
                    g.DrawBezier(new Pen(note.MusicalCharacterColor, 2), slurStartPoint.X + 10, slurStartPoint.Y + 18,
                        slurStartPoint.X + 12, slurStartPoint.Y + 9,
                        currentXPosition + 8, notePositionY + 9,
                        currentXPosition + 10, notePositionY + 18);
                    /*
                    g.DrawArc(pen, new Rectangle((int)slurStartPoint.X + 10, (int)slurStartPoint.Y + 4,
                        (int)currentXPosition - (int)slurStartPoint.X, 20), 180, 180);
                    g.DrawArc(pen, new Rectangle((int)slurStartPoint.X + 10, (int)slurStartPoint.Y + 5,
                        (int)currentXPosition - (int)slurStartPoint.X, 20), 180, 180);
                    */
                }
                else if (((Note)symbol).StemDirection == NoteStemDirection.Up)
                {
                    g.DrawBezier(new Pen(note.MusicalCharacterColor, 2), slurStartPoint.X + 10, slurStartPoint.Y + 30,
                        slurStartPoint.X + 12, slurStartPoint.Y + 44,
                        currentXPosition + 8, notePositionY + 44,
                        currentXPosition + 10, notePositionY + 30);
                    /*
                    g.DrawArc(pen, new Rectangle((int)slurStartPoint.X + 10, (int)slurStartPoint.Y + 24,
                        (int)currentXPosition - (int)slurStartPoint.X, 20), 0, 180);
                    g.DrawArc(pen, new Rectangle((int)slurStartPoint.X + 10, (int)slurStartPoint.Y + 25,
                        (int)currentXPosition - (int)slurStartPoint.X, 20), 0, 180);
                     * */
                }
            }

            //Draw lyrics / Rysuj tekst:
            int textPositionY = lines[4] + 10;
            for (int j = 0; (j < (((Note)symbol).Lyrics.Count)) &&
                (j < (((Note)symbol).LyricTexts.Count))
                ; j++)
            {
                StringBuilder sBuilder = new StringBuilder();
                if ((((Note)symbol).Lyrics[j] == LyricsType.End) ||
                    (((Note)symbol).Lyrics[j] == LyricsType.Middle))
                    sBuilder.Append("-");
                sBuilder.Append(((Note)symbol).LyricTexts[j]);
                if ((((Note)symbol).Lyrics[j] == LyricsType.Begin) ||
                    (((Note)symbol).Lyrics[j] == LyricsType.Middle))
                    sBuilder.Append("-");
                g.DrawString(sBuilder.ToString(), FontStyles.LyricFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, textPositionY);
                textPositionY += 12;
            }

            //Draw articulation / Rysuj artykulację:
            if (((Note)symbol).Articulation != ArticulationType.None)
            {
                float articulationPosition = notePositionY + 10;
                if (((Note)symbol).ArticulationPlacement == ArticulationPlacementType.Above)
                    articulationPosition = notePositionY - 10;
                else if (((Note)symbol).ArticulationPlacement == ArticulationPlacementType.Below)
                    articulationPosition = notePositionY + 10;

                if (((Note)symbol).Articulation == ArticulationType.Staccato)
                    g.DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition + 6, articulationPosition);
                else if (((Note)symbol).Articulation == ArticulationType.Accent)
                    g.DrawString(">", FontStyles.MiscArticulationFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition + 6, articulationPosition + 16);

            }

            //Draw trills / Rysuj tryle:
            if (((Note)symbol).TrillMark != NoteTrillMark.None)
            {
                float trillPos = notePositionY - 1;
                if (((Note)symbol).TrillMark == NoteTrillMark.Above)
                {
                    trillPos = notePositionY - 1;
                    if (trillPos > lines[0] - 24.4f)
                    {
                        trillPos = lines[0] - 24.4f - 1.0f;
                    }
                }
                else if (((Note)symbol).TrillMark == NoteTrillMark.Below)
                {
                    trillPos = notePositionY + 10;
                }
                g.DrawString("tr", FontStyles.TrillFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition + 6, trillPos);
            }

            //Draw tremolos / Rysuj tremola:
            float currentTremoloPos = notePositionY + 18;
            for (int j = 0; j < ((Note)symbol).TremoloLevel; j++)
            {
                if (((Note)symbol).StemDirection == NoteStemDirection.Up)
                {
                    currentTremoloPos -= 4;
                    g.DrawLine(new Pen(note.MusicalCharacterColor), currentXPosition + 9, currentTremoloPos + 1,
                        currentXPosition + 16, currentTremoloPos - 1);
                    g.DrawLine(new Pen(note.MusicalCharacterColor), currentXPosition + 9, currentTremoloPos + 2,
                        currentXPosition + 16, currentTremoloPos);
                }
                else
                {
                    currentTremoloPos += 4;
                    g.DrawLine(new Pen(note.MusicalCharacterColor), currentXPosition + 3, currentTremoloPos + 11 + 1,
                        currentXPosition + 11, currentTremoloPos + 11 - 1);
                    g.DrawLine(new Pen(note.MusicalCharacterColor), currentXPosition + 3, currentTremoloPos + 11 + 2,
                        currentXPosition + 11, currentTremoloPos + 11);
                }

            }

            //Draw fermata sign / Rysuj symbol fermaty:
            if (((Note)symbol).HasFermataSign)
            {
                float ferPos = notePositionY - 9;
                if (ferPos > lines[0] - 24.4f) ferPos = lines[0] - 24.4f - 9.0f;

                g.DrawArc(new Pen(note.MusicalCharacterColor), new Rectangle(currentXPosition + 5, (int)ferPos + 17,
                       10, 10), 180, 180);
                g.DrawArc(new Pen(note.MusicalCharacterColor), new Rectangle(currentXPosition + 5, (int)ferPos + 18,
                        10, 10), 180, 180);
                g.DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition + 6, ferPos);
            }

            //Draw accidental signs / Rysuj akcydencje:
            if (((Note)symbol).Alter - currentKey.StepToAlter(((Note)symbol).Step)
                - alterationsWithinOneBar[((Note)symbol).StepToStepNumber()] > 0)
            {
                alterationsWithinOneBar[((Note)symbol).StepToStepNumber()] =
                    ((Note)symbol).Alter - currentKey.StepToAlter(((Note)symbol).Step);
                int accPlacement = currentXPosition - 9 * numberOfSingleAccidentals -
                    9 * numberOfDoubleAccidentals;
                for (int i = 0; i < numberOfSingleAccidentals; i++)
                {
                    g.DrawString(MusicalCharacters.Sharp, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), accPlacement, notePositionY);
                    accPlacement += 9;
                }
                for (int i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    g.DrawString(MusicalCharacters.DoubleSharp, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), accPlacement, notePositionY);
                    accPlacement += 9;
                }
            }
            else if (((Note)symbol).Alter - currentKey.StepToAlter(((Note)symbol).Step)
                - alterationsWithinOneBar[((Note)symbol).StepToStepNumber()] < 0)
            {
                alterationsWithinOneBar[((Note)symbol).StepToStepNumber()] =
                    ((Note)symbol).Alter - currentKey.StepToAlter(((Note)symbol).Step);
                int accPlacement = currentXPosition - 9 * numberOfSingleAccidentals -
                    9 * numberOfDoubleAccidentals;
                for (int i = 0; i < numberOfSingleAccidentals; i++)
                {
                    g.DrawString(MusicalCharacters.Flat, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), accPlacement, notePositionY);
                    accPlacement += 9;
                }
                for (int i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    g.DrawString(MusicalCharacters.DoubleFlat, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), accPlacement, notePositionY);
                    accPlacement += 9;
                }
            }
            if (((Note)symbol).HasNatural == true)
            {
                g.DrawString(MusicalCharacters.Natural, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition - 9, notePositionY);
            }

            //Draw dots / Rysuj kropki:
            if (((Note)symbol).NumberOfDots > 0) currentXPosition += 16;
            for (int i = 0; i < ((Note)symbol).NumberOfDots; i++)
            {
                g.DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, notePositionY);
                currentXPosition += 6;
            }


            if (((Note)symbol).Duration == MusicalSymbolDuration.Whole) currentXPosition += 50;
            else if (((Note)symbol).Duration == MusicalSymbolDuration.Half) currentXPosition += 30;
            else if (((Note)symbol).Duration == MusicalSymbolDuration.Quarter) currentXPosition += 18;
            else if (((Note)symbol).Duration == MusicalSymbolDuration.Eighth) currentXPosition += 15;
            else if (((Note)symbol).Duration == MusicalSymbolDuration.Unknown) currentXPosition += 25;
            else currentXPosition += 14;

            //Przesuń trochę w prawo, jeśli nuta ma tekst, żeby litery nie wchodziły na siebie
            //Move a bit right if the note has a lyric to prevent letters from hiding each other
            if (((Note)symbol).Lyrics.Count > 0)
            {
                currentXPosition += ((Note)symbol).LyricTexts[0].Length * 2;
            }

            lastNoteEndXPosition = currentXPosition;
        }
    }
}
