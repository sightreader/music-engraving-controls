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

            float notePositionY = renderer.State.currentClefPositionY + MusicalSymbol.StepDifference(renderer.State.CurrentClef,
                element) * ((float)renderer.State.lineSpacing / 2.0f);
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
                DrawString(element.MusicalCharacter, FontStyles.MusicFont, new SolidBrush(element.MusicalCharacterColor), renderer.State.currentXPosition, notePositionY);
            else
                DrawString(element.MusicalCharacter, FontStyles.GraceNoteFont, new SolidBrush(element.MusicalCharacterColor), renderer.State.currentXPosition + 1,
                    notePositionY + 2);
            renderer.State.lastXPosition = renderer.State.currentXPosition;
            element.Location = new PointF(renderer.State.currentXPosition, notePositionY);

            //Ledger lines / Linie dodane
            float tmpXPos = renderer.State.currentXPosition + 16;
            if (renderer.State.print) tmpXPos += 1.5f;
            if (notePositionY + 25.0f > renderer.State.lines[4] + renderer.State.lineSpacing / 2.0f)
            {
                for (int i = renderer.State.lines[4]; i < notePositionY + 24f - renderer.State.lineSpacing / 2.0f; i += renderer.State.lineSpacing)
                {

                    g.DrawLine(pen, new Point(renderer.State.currentXPosition + 4, i + renderer.State.lineSpacing),
                        new PointF(tmpXPos, i + renderer.State.lineSpacing));
                }
            }
            if (notePositionY + 25.0f < renderer.State.lines[0] - renderer.State.lineSpacing / 2)
            {

                for (int i = renderer.State.lines[0]; i > notePositionY + 26.0f + renderer.State.lineSpacing / 2.0f; i -= renderer.State.lineSpacing)
                {

                    g.DrawLine(pen, new Point(renderer.State.currentXPosition + 4, i - renderer.State.lineSpacing),
                        new PointF(tmpXPos, i - renderer.State.lineSpacing));
                }
            }

            //Draw stems (stems are vertical lines, beams are horizontal lines :P)/ Rysuj ogonki: (ogonki to są te w pionie - poziome są belki ;P ;P ;P)
            if ((element.Duration != MusicalSymbolDuration.Whole) &&
                (element.Duration != MusicalSymbolDuration.Unknown))
            {
                float tmpStemPosY;

                tmpStemPosY = element.StemDefaultY * -1.0f / 2.0f;


                if (element.StemDirection == NoteStemDirection.Down)
                {
                    //Ogonki elementów akordów nie były dobrze wyświetlane, jeśli stosowałem
                    //default-y. Dlatego dla akordów zostawiam domyślne rysowanie ogonków.
                    //Stems of chord elements were displayed wrong when I used default-y
                    //so I left default stem drawing routine for chords.
                    if (((element.IsChordElement) || xmlIncipit.InnerXml.Length == 0)
                        || (!(element.CustomStemEndPosition)))
                        renderer.State.currentStemEndPositionY = notePositionY + 18;
                    else
                        renderer.State.currentStemEndPositionY = tmpStemPosY - 4;
                    renderer.State.currentStemPositionX = renderer.State.currentXPosition + 7;
                    if (renderer.State.print) renderer.State.currentStemPositionX += 0.1f;

                    if (element.BeamList.Count > 0)
                        if ((element.BeamList[0] != NoteBeamType.Continue) || element.CustomStemEndPosition)
                            g.DrawLine(new Pen(element.MusicalCharacterColor), new PointF(renderer.State.currentStemPositionX, notePositionY - 1 + 28),
                                new PointF(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28));
                }
                else
                {
                    //Ogonki elementów akordów nie były dobrze wyświetlane, jeśli stosowałem
                    //default-y. Dlatego dla akordów zostawiam domyślne rysowanie ogonków.
                    //Stems of chord elements were displayed wrong when I used default-y
                    //so I left default stem drawing routine for chords.
                    if ((element.IsChordElement) || xmlIncipit.InnerXml.Length == 0
                        || (!(element.CustomStemEndPosition)))
                        renderer.State.currentStemEndPositionY = notePositionY - 25;

                    else
                        renderer.State.currentStemEndPositionY = tmpStemPosY - 6;
                    renderer.State.currentStemPositionX = renderer.State.currentXPosition + 13;
                    if (renderer.State.print) renderer.State.currentStemPositionX += 0.9f;

                    if (element.BeamList.Count > 0)
                        if ((element.BeamList[0] != NoteBeamType.Continue) || element.CustomStemEndPosition)
                            g.DrawLine(pen, new PointF(renderer.State.currentStemPositionX, notePositionY - 7 + 30),
                                new PointF(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28));
                }
                element.StemEndLocation = new PointF(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY);
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
                    //g.DrawLine(pen, new Point(currentStemPositionX, prevStemPosY + 28),
                    //    new Point(currentStemPositionX, currentStemEndPositionY + 28));
                }
                else if (beam == NoteBeamType.End)
                {
                    //MessageBox.Show(Convert.ToString(previousStemPositionsX[beamLoop])
                    //    + "," + Convert.ToString(currentStemPositionX));
                    g.DrawLine(new Pen(element.MusicalCharacterColor), new PointF(renderer.State.previousStemPositionsX[beamLoop], renderer.State.previousStemEndPositionsY[beamLoop] + 28
                        + beamOffset * beamSpaceDirection),
                        new PointF(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28
                            + beamOffset * beamSpaceDirection));
                    g.DrawLine(new Pen(element.MusicalCharacterColor), new PointF(renderer.State.previousStemPositionsX[beamLoop], renderer.State.previousStemEndPositionsY[beamLoop]
                        + 28 + 1 * beamSpaceDirection + beamOffset * beamSpaceDirection),
                        new PointF(renderer.State.currentStemPositionX, renderer.State.currentStemEndPositionY + 28
                            + 1 * beamSpaceDirection + beamOffset * beamSpaceDirection));
                    //Draw tuplet mark / Rysuj oznaczenie trioli:
                    if ((((Note)symbol).Tuplet == TupletType.Stop) && (!alreadyPaintedNumberOfNotesInTuplet))
                    {
                        int tmpMod;
                        if (((Note)symbol).StemDirection == NoteStemDirection.Up) tmpMod = 12;
                        else tmpMod = 28;
                        DrawString(Convert.ToString(renderer.State.numberOfNotesUnderTuplet), FontStyles.LyricFont,
                            new SolidBrush(symbol.MusicalCharacterColor),
                            new PointF(renderer.State.previousStemPositionsX[beamLoop] + (renderer.State.currentStemPositionX - renderer.State.previousStemPositionsX[beamLoop]) / 2 - 1,
                                renderer.State.previousStemEndPositionsY[beamLoop] - (renderer.State.currentStemEndPositionY - renderer.State.previousStemEndPositionsY[beamLoop]) / 2 + tmpMod));
                        alreadyPaintedNumberOfNotesInTuplet = true;
                    }
                }
                else if ((beam == NoteBeamType.Single) && (!((Note)symbol).IsChordElement))
                {   //Rysuj chorągiewkę tylko najniższego dźwięku w akordzie
                    //Draw a hook only of the lowest element in a chord
                    float xPos = renderer.State.currentStemPositionX - 4;
                    if (renderer.State.print) xPos -= 0.9f;
                    if (element.StemDirection == NoteStemDirection.Down)
                    {
                        renderer.DrawString(element.NoteFlagCharacterRev, FontStyles.MusicFont, new Point(xPos, renderer.State.currentStemEndPositionY + 7));
                    }
                    else
                    {
                        renderer.DrawString(element.NoteFlagCharacter, FontStyles.MusicFont,                             new Point(xPos, renderer.State.currentStemEndPositionY - 1));
                    }
                }
                else if (beam == NoteBeamType.ForwardHook)
                {
                    g.DrawLine(new Pen(element.MusicalCharacterColor), new PointF(currentStemPositionX + 6,
                        renderer.State.currentStemEndPositionY + 28 + beamOffset * beamSpaceDirection),
                        new PointF(currentStemPositionX, currentStemEndPositionY + 28
                        + beamOffset * beamSpaceDirection));
                    g.DrawLine(new Pen(element.MusicalCharacterColor), new PointF(currentStemPositionX + 6,
                        currentStemEndPositionY + 29 + beamOffset * beamSpaceDirection),
                        new PointF(currentStemPositionX, currentStemEndPositionY + 29
                        + beamOffset * beamSpaceDirection));
                }
                else if (beam == NoteBeamType.BackwardHook)
                {
                    g.DrawLine(new Pen(element.MusicalCharacterColor), new PointF(currentStemPositionX - 6,
                        currentStemEndPositionY + 28 + beamOffset * beamSpaceDirection),
                        new PointF(currentStemPositionX, currentStemEndPositionY + 28
                        + beamOffset * beamSpaceDirection));
                    g.DrawLine(new Pen(element.MusicalCharacterColor), new PointF(currentStemPositionX - 6,
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
                    g.DrawArc(new Pen(element.MusicalCharacterColor), new Rectangle((int)tieStartPoint.X + 10, (int)tieStartPoint.Y + 6,
                        (int)currentXPosition - (int)tieStartPoint.X, 20), 180, 180);
                    g.DrawArc(new Pen(element.MusicalCharacterColor), new Rectangle((int)tieStartPoint.X + 10, (int)tieStartPoint.Y + 7,
                        (int)currentXPosition - (int)tieStartPoint.X, 20), 180, 180);
                }
                else if (((Note)symbol).StemDirection == NoteStemDirection.Up)
                {
                    g.DrawArc(new Pen(element.MusicalCharacterColor), new Rectangle((int)tieStartPoint.X + 10, (int)tieStartPoint.Y + 22,
                        (int)currentXPosition - (int)tieStartPoint.X, 20), 0, 180);
                    g.DrawArc(new Pen(element.MusicalCharacterColor), new Rectangle((int)tieStartPoint.X + 10, (int)tieStartPoint.Y + 23,
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
                    g.DrawBezier(new Pen(element.MusicalCharacterColor, 2), slurStartPoint.X + 10, slurStartPoint.Y + 18,
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
                    g.DrawBezier(new Pen(element.MusicalCharacterColor, 2), slurStartPoint.X + 10, slurStartPoint.Y + 30,
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
                DrawString(sBuilder.ToString(), FontStyles.LyricFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, textPositionY);
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
                    DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition + 6, articulationPosition);
                else if (((Note)symbol).Articulation == ArticulationType.Accent)
                    DrawString(">", FontStyles.MiscArticulationFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition + 6, articulationPosition + 16);

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
                DrawString("tr", FontStyles.TrillFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition + 6, trillPos);
            }

            //Draw tremolos / Rysuj tremola:
            float currentTremoloPos = notePositionY + 18;
            for (int j = 0; j < ((Note)symbol).TremoloLevel; j++)
            {
                if (((Note)symbol).StemDirection == NoteStemDirection.Up)
                {
                    currentTremoloPos -= 4;
                    g.DrawLine(new Pen(element.MusicalCharacterColor), currentXPosition + 9, currentTremoloPos + 1,
                        currentXPosition + 16, currentTremoloPos - 1);
                    g.DrawLine(new Pen(element.MusicalCharacterColor), currentXPosition + 9, currentTremoloPos + 2,
                        currentXPosition + 16, currentTremoloPos);
                }
                else
                {
                    currentTremoloPos += 4;
                    g.DrawLine(new Pen(element.MusicalCharacterColor), currentXPosition + 3, currentTremoloPos + 11 + 1,
                        currentXPosition + 11, currentTremoloPos + 11 - 1);
                    g.DrawLine(new Pen(element.MusicalCharacterColor), currentXPosition + 3, currentTremoloPos + 11 + 2,
                        currentXPosition + 11, currentTremoloPos + 11);
                }

            }

            //Draw fermata sign / Rysuj symbol fermaty:
            if (((Note)symbol).HasFermataSign)
            {
                float ferPos = notePositionY - 9;
                if (ferPos > lines[0] - 24.4f) ferPos = lines[0] - 24.4f - 9.0f;

                g.DrawArc(new Pen(element.MusicalCharacterColor), new Rectangle(currentXPosition + 5, (int)ferPos + 17,
                       10, 10), 180, 180);
                g.DrawArc(new Pen(element.MusicalCharacterColor), new Rectangle(currentXPosition + 5, (int)ferPos + 18,
                        10, 10), 180, 180);
                DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition + 6, ferPos);
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
                    DrawString(MusicalCharacters.Sharp, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), accPlacement, notePositionY);
                    accPlacement += 9;
                }
                for (int i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    DrawString(MusicalCharacters.DoubleSharp, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), accPlacement, notePositionY);
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
                    DrawString(MusicalCharacters.Flat, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), accPlacement, notePositionY);
                    accPlacement += 9;
                }
                for (int i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    DrawString(MusicalCharacters.DoubleFlat, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), accPlacement, notePositionY);
                    accPlacement += 9;
                }
            }
            if (((Note)symbol).HasNatural == true)
            {
                DrawString(MusicalCharacters.Natural, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition - 9, notePositionY);
            }

            //Draw dots / Rysuj kropki:
            if (((Note)symbol).NumberOfDots > 0) currentXPosition += 16;
            for (int i = 0; i < ((Note)symbol).NumberOfDots; i++)
            {
                DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, notePositionY);
                currentXPosition += 6;
            }


            if (((Note)symbol).Duration == MusicalSymbolDuration.Whole) currentXPosition += 50;
            else if (((Note)symbol).Duration == MusicalSymbolDuration.Half) currentXPosition += 30;
            else if (((Note)symbol).Duration == MusicalSymbolDuration.Quarter) currentXPosition += 18;
            else if (((Note)symbol).Duration == MusicalSymbolDuration.Eighth) currentXPosition += 15;
            else if (((Note)symbol).Duration == MusicalSymbolDuration.Unknown) currentXPosition += 25;
            else currentXPosition += 14;

            //Przesuń trochę w prawo, jeśli nuta ma tekst, żeby litery nie wchodziły na siebie
            //Move a bit right if the element has a lyric to prevent letters from hiding each other
            if (((Note)symbol).Lyrics.Count > 0)
            {
                currentXPosition += ((Note)symbol).LyricTexts[0].Length * 2;
            }

            lastNoteEndXPosition = currentXPosition;
        }
    }
}
