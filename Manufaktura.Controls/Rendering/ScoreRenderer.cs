using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public abstract class ScoreRenderer<TCanvas> : ScoreRendererBase  //TODO: SilverlightScoreRenderer, WPFScoreRenderer, itp.
    {
        //TODO: Niech metoda Render w ScoreRenderer będzie taka sama dla wszystkich platform.
        //Zamiast odrębnych strategii rysowania poszczególnych symboli zrobić metody abstrakcyjne DrawLine i DrawSymbol
        //A strategie zrobić tylko w obrębie przenośnej biblioteki

        public void Render(Score score)
        {
            foreach (Staff staff in score.Staves)
            {
                foreach (MusicalSymbol symbol in staff.Elements)
                {

                }
            }

            float currentClefPositionY = 0;
            
            Key currentKey = new Key(0);
            int currentXPosition = 0;
            int lastXPosition = 0; //for chords / dla akordów
            int lastNoteEndXPosition = 0; //for many voices / dla wielu głosów
            int firstNoteInMeasureXPosition = 0; //for many voices - starting point for all voices / dla wielu głosów - punkt rozpoczęcia wszystkich głosów
            int lastNoteInMeasureEndXPosition = 0; //for many voices - location of the last note in the measure / dla wielu głosów - punkt ostatniej nuty w takcie
            const int paddingTop = 20;
            const int lineSpacing = 6;
            float currentStemEndPositionY = 0;
            int numberOfNotesUnderTuplet = 0;
            List<float> previousStemEndPositionsY = new List<float>();
            float currentStemPositionX = 0;
            List<float> previousStemPositionsX = new List<float>();
            List<Point> beamStartPositionsY = new List<Point>();
            List<Point> beamEndPositionsY = new List<Point>();
            PointF tieStartPoint = new PointF();
            PointF slurStartPoint = new PointF();
            int currentVoice = 1;

            int[] lines = new int[5];

            //Draw selection box / Rysuj zaznaczenie:
            if (isSelected)
            {
                g.FillRectangle(new SolidBrush(SystemColors.GradientInactiveCaption),
                    new Rectangle(0, 0, Width, Height));
            }

            if (drawOnlySelectionAndButtons) return;
            if (drawOnParentControl && !print && (this.Parent != null))
            {
                g = this.Parent.CreateGraphics();
                g.TranslateTransform(this.Location.X, this.Location.Y);
            }

            //Draw staff lines / Rysuj pięciolinię
            string staff = MusicalCharacters.Staff5Lines;
            for (int i = 0; i < Width / 10; i++)
                staff = staff + MusicalCharacters.Staff5Lines;

            Point startPoint = new Point(0, paddingTop);
            Point endPoint = new Point(Width, paddingTop);

            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(pen, startPoint, endPoint);
                lines[i] = paddingTop + i * lineSpacing;
                startPoint.Y += lineSpacing;
                endPoint.Y += lineSpacing;

            }
            //g.DrawString(staff, FontStyles.StaffFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, paddingTop - 3);


            try
            {
                foreach (MusicalSymbol symbol in incipit) //Perform one pass to determine current clef / Wykonaj jeden przebieg żeby określić bieżący klucz
                {
                    if (symbol.Type == MusicalSymbolType.Clef)
                    {
                        currentClef = (Clef)symbol;
                        currentClefPositionY = lines[4] - 24.4f - (((Clef)symbol).Line - 1) * lineSpacing;
                        currentClef = (Clef)symbol;
                        g.DrawString(symbol.MusicalCharacter, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor),
                            currentXPosition, currentClefPositionY);
                        currentXPosition += 20;
                        break;
                    }
                }
                int[] alterationsWithinOneBar = new int[7];
                bool firstNoteInIncipit = true;
                int currentMeasure = 0;
                foreach (MusicalSymbol symbol in incipit)
                {
                    if (symbol.Type == MusicalSymbolType.Clef)
                    {
                        
                    }
                    else if (symbol.Type == MusicalSymbolType.Key)
                    {
                        currentKey = (Key)symbol;
                        float flatOrSharpPositionY = 0;
                        bool jumpFourth = false;
                        int jumpDirection = 1;
                        int octaveShiftSharp = 0; //In G clef sharps (not flats) should be written an octave higher / W kluczu g krzyżyki (bemole nie) powinny być zapisywane o oktawę wyżej
                        if (currentClef.TypeOfClef == ClefType.GClef) octaveShiftSharp = 1;
                        int octaveShiftFlat = 0;
                        if (currentClef.TypeOfClef == ClefType.FClef) octaveShiftFlat = -1;
                        if (currentKey.Fifths > 0)
                        {
                            flatOrSharpPositionY = currentClefPositionY + MusicalSymbol.StepDifference(currentClef,
                            (new Note("F", 0, currentClef.Octave + octaveShiftSharp, MusicalSymbolDuration.Whole, NoteStemDirection.Up,
                                NoteTieType.None, null)))
                            * (lineSpacing / 2);
                            jumpFourth = true;
                            jumpDirection = 1;

                        }
                        else if (currentKey.Fifths < 0)
                        {
                            flatOrSharpPositionY = currentClefPositionY + MusicalSymbol.StepDifference(currentClef,
                            (new Note("B", 0, currentClef.Octave + octaveShiftFlat, MusicalSymbolDuration.Whole, NoteStemDirection.Up,
                                NoteTieType.None, null)))
                            * (lineSpacing / 2);
                            jumpFourth = true;
                            jumpDirection = -1;
                        }
                        for (int i = 0; i < Math.Abs(currentKey.Fifths); i++)
                        {

                            g.DrawString(symbol.MusicalCharacter, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor),
                                currentXPosition, flatOrSharpPositionY);
                            if (jumpFourth) flatOrSharpPositionY += 3 * 3 * jumpDirection;
                            else flatOrSharpPositionY += 3 * 4 * jumpDirection;
                            jumpFourth = !jumpFourth;
                            jumpDirection *= -1;
                            currentXPosition += 8;
                        }
                        currentXPosition += 10;

                    }
                    else if (symbol.Type == MusicalSymbolType.TimeSignature)
                    {
                        float timeSignaturePositionY = (lines[0] - 11);
                        if (print) timeSignaturePositionY -= 0.6f;
                        if (((TimeSignature)symbol).SignatureType == TimeSignatureType.Common)
                            g.DrawString(MusicalCharacters.CommonTime, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor),
                            currentXPosition, timeSignaturePositionY);
                        else if (((TimeSignature)symbol).SignatureType == TimeSignatureType.Cut)
                            g.DrawString(MusicalCharacters.CutTime, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor),
                            currentXPosition, timeSignaturePositionY);
                        else
                        {
                            g.DrawString(Convert.ToString(((TimeSignature)symbol).NumberOfBeats),
                                FontStyles.TimeSignatureFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, timeSignaturePositionY + 9);
                            g.DrawString(Convert.ToString(((TimeSignature)symbol).TypeOfBeats),
                                FontStyles.TimeSignatureFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, timeSignaturePositionY + 21);
                        }
                        currentXPosition += 20;
                    }
                    else if (symbol.Type == MusicalSymbolType.Direction)
                    {
                        //Performance directions / Wskazówki wykonawcze:
                        Direction dir = ((Direction)symbol);
                        float dirPositionY = 0;
                        if (dir.Placement == DirectionPlacementType.Custom)
                            dirPositionY = dir.DefaultY * -1.0f / 2.0f;
                        else if (dir.Placement == DirectionPlacementType.Above)
                            dirPositionY = 0;
                        else if (dir.Placement == DirectionPlacementType.Below)
                            dirPositionY = 50;
                        g.DrawString(dir.Text, FontStyles.DirectionFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, dirPositionY);

                    }
                    else if (symbol.Type == MusicalSymbolType.Note)
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
                    else if (symbol.Type == MusicalSymbolType.Rest)
                    {
                        if (firstNoteInIncipit) firstNoteInMeasureXPosition = currentXPosition;
                        firstNoteInIncipit = false;

                        if (((Rest)symbol).Voice > currentVoice)
                        {
                            currentXPosition = firstNoteInMeasureXPosition;
                            lastNoteInMeasureEndXPosition = lastNoteEndXPosition;
                        }
                        currentVoice = ((Rest)symbol).Voice;


                        float restPositionY = (lines[0] - 9);
                        if (print) restPositionY -= 0.6f;

                        g.DrawString(symbol.MusicalCharacter, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, restPositionY);
                        lastXPosition = currentXPosition;

                        //Draw number of measures for multimeasure rests / Rysuj ilość taktów dla pauz wielotaktowych:
                        if (((Rest)symbol).MultiMeasure > 1)
                        {
                            g.DrawString(Convert.ToString(((Rest)symbol).MultiMeasure),
                                FontStyles.LyricFontBold, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition + 6, restPositionY);
                        }

                        //Draw dots / Rysuj kropki:
                        if (((Rest)symbol).NumberOfDots > 0) currentXPosition += 16;
                        for (int i = 0; i < ((Rest)symbol).NumberOfDots; i++)
                        {
                            g.DrawString(MusicalCharacters.Dot, FontStyles.MusicFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition, restPositionY);
                            currentXPosition += 6;
                        }

                        if (((Rest)symbol).Duration == MusicalSymbolDuration.Whole) currentXPosition += 48;
                        else if (((Rest)symbol).Duration == MusicalSymbolDuration.Half) currentXPosition += 28;
                        else if (((Rest)symbol).Duration == MusicalSymbolDuration.Quarter) currentXPosition += 17;
                        else if (((Rest)symbol).Duration == MusicalSymbolDuration.Eighth) currentXPosition += 15;
                        else currentXPosition += 14;

                        lastNoteEndXPosition = currentXPosition;
                    }
                    else if (symbol.Type == MusicalSymbolType.Barline)
                    {
                        Barline barline = (Barline)symbol;
                        if (lastNoteInMeasureEndXPosition > currentXPosition)
                        {
                            currentXPosition = lastNoteInMeasureEndXPosition;
                        }
                        if (barline.RepeatSign == RepeatSignType.None)
                        {
                            currentXPosition += 16;
                            g.DrawLine(pen, new Point(currentXPosition, lines[4]), new Point(currentXPosition, lines[0]));
                            currentXPosition += 6;
                        }
                        else if (barline.RepeatSign == RepeatSignType.Forward)
                        {
                            //Przesuń w lewo jeśli przed znakiem repetycji znajduje się zwykła kreska taktowa
                            //Move to the left if there is a plain measure bar before the repeat sign
                            if (incipit.IndexOf(symbol) > 0)
                            {
                                MusicalSymbol s = incipit[incipit.IndexOf(symbol) - 1];
                                if (s.Type == MusicalSymbolType.Barline)
                                {
                                    if (((Barline)s).RepeatSign == RepeatSignType.None)
                                        currentXPosition -= 16;
                                }
                            }
                            currentXPosition += 2;
                            g.DrawString(MusicalCharacters.RepeatForward, FontStyles.StaffFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition,
                                lines[0] - 15.5f);
                            currentXPosition += 20;
                        }
                        else if (barline.RepeatSign == RepeatSignType.Backward)
                        {
                            currentXPosition -= 2;
                            g.DrawString(MusicalCharacters.RepeatBackward, FontStyles.StaffFont, new SolidBrush(symbol.MusicalCharacterColor), currentXPosition,
                                lines[0] - 15.5f);
                            currentXPosition += 6;
                        }
                        firstNoteInMeasureXPosition = currentXPosition;

                        for (int i = 0; i < 7; i++)
                            alterationsWithinOneBar[i] = 0;

                        currentMeasure++;
                    }

                    if (currentXPosition > Width - 10) break; //Fell out of control bounds / Wyszło poza długość kontrolki
                }


                //Draw missing stems / Dorysuj brakujące ogonki:
                Note lastNoteInBeam = null;
                Note firstNoteInBeam = null;
                foreach (MusicalSymbol m in incipit)
                {
                    if (m.Type != MusicalSymbolType.Note) continue;
                    Note note = (Note)m;

                    //Search for the end of the beam / Przeszukaj i znajdź koniec belki:
                    if (note.BeamList.Count > 0)
                    {
                        if (note.BeamList[0] == NoteBeamType.End) continue;
                        if (note.BeamList[0] == NoteBeamType.Start)
                        {
                            firstNoteInBeam = note;
                            continue;
                        }
                        if (note.BeamList[0] == NoteBeamType.Continue)
                        {
                            if (note.CustomStemEndPosition) continue;
                            for (int i = incipit.IndexOf(m) + 1; i < incipit.Count; i++)
                            {
                                if (incipit[i].Type != MusicalSymbolType.Note) continue;
                                Note note2 = (Note)incipit[i];
                                if (note2.BeamList.Count > 0)
                                {
                                    if (note2.BeamList[0] == NoteBeamType.End)
                                    {
                                        lastNoteInBeam = note2;
                                        break;
                                    }
                                }
                            }
                            float newStemEndPosition = Math.Abs(note.StemEndLocation.X -
                                firstNoteInBeam.StemEndLocation.X) *
                                ((Math.Abs(lastNoteInBeam.StemEndLocation.Y - firstNoteInBeam.StemEndLocation.Y)) /
                                (Math.Abs(lastNoteInBeam.StemEndLocation.X - firstNoteInBeam.StemEndLocation.X)));

                            //Jeśli ostatnia nuta jest wyżej, to odejmij y zamiast dodać
                            //If the last note is higher, subtract y instead of adding
                            if (lastNoteInBeam.StemEndLocation.Y < firstNoteInBeam.StemEndLocation.Y)
                                newStemEndPosition *= -1;

                            PointF newStemEndPoint = new PointF(note.StemEndLocation.X,
                                firstNoteInBeam.StemEndLocation.Y +
                                newStemEndPosition);
                            if (note.StemDirection == NoteStemDirection.Down)
                                g.DrawLine(new Pen(note.MusicalCharacterColor), new PointF(note.StemEndLocation.X, note.Location.Y + 25),
                                    new PointF(newStemEndPoint.X, newStemEndPoint.Y + 23 + 5));
                            else
                                g.DrawLine(new Pen(note.MusicalCharacterColor), new PointF(note.StemEndLocation.X, note.Location.Y + 23),
                                    new PointF(newStemEndPoint.X, newStemEndPoint.Y + 23 + 5));


                        }
                    }
                    if (lastNoteInBeam == null) continue;
                }


            }
            catch
            {
                return;
            }
        }
    }
}
