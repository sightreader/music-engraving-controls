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
                        

                    }
                    else if (symbol.Type == MusicalSymbolType.TimeSignature)
                    {
                        
                    }
                    else if (symbol.Type == MusicalSymbolType.Direction)
                    {
                        

                    }
                    else if (symbol.Type == MusicalSymbolType.Note)
                    {
                       
                    }
                    else if (symbol.Type == MusicalSymbolType.Rest)
                    {
                        
                    }
                    else if (symbol.Type == MusicalSymbolType.Barline)
                    {
                        
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
