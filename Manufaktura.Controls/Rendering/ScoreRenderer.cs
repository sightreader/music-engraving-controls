using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public abstract class ScoreRenderer<TCanvas> : ScoreRendererBase
    {
        public TCanvas Canvas { get; protected set; }

        public List<Exception> Exceptions { get; protected set; }

        public ScoreRenderer(TCanvas canvas)
        {
            Canvas = canvas;
            Exceptions = new List<Exception>();
        }

        public void Render(Score score)
        {
            State.CurrentScore = score;

            DrawSelectionBox();
            foreach (Staff staff in score.Staves)
            {
                try
                {
                    State.CurrentStaff = staff;

                    try
                    {
                        var staffRenderStrategy = GetProperRenderStrategy(staff);
                        if (staffRenderStrategy != null) staffRenderStrategy.Render(staff, this);
                    }
                    catch (Exception ex)
                    {
                        Exceptions.Add(ex);
                    }

                    DetermineClef(staff);

                    State.alterationsWithinOneBar = new int[7];
                    State.firstNoteInIncipit = true;
                    State.CurrentMeasure = 0;

                    foreach (MusicalSymbol symbol in staff.Elements)
                    {
                        try
                        {
                            var renderStrategy = GetProperRenderStrategy(symbol);
                            if (renderStrategy != null) renderStrategy.Render(symbol, this);
                        }
                        catch (Exception ex)
                        {
                            Exceptions.Add(ex);
                        }
                    }
                    DrawMissingStems(staff);
                }
                catch (Exception ex)
                {
                    Exceptions.Add(ex);
                }
            }          
        }

        private void DetermineClef(Staff staff)
        {
            foreach (MusicalSymbol symbol in staff.Elements) //Perform one pass to determine current clef / Wykonaj jeden przebieg żeby określić bieżący klucz
            {
                if (symbol.Type == MusicalSymbolType.Clef)
                {
                    State.CurrentClef = (Clef)symbol;
                    State.currentClefPositionY = State.LinePositions[4] - 24.4f - (((Clef)symbol).Line - 1) * State.lineSpacing;
                    State.CurrentClef = (Clef)symbol;
                    DrawString(symbol.MusicalCharacter, FontStyles.MusicFont, State.CursorPositionX, State.currentClefPositionY);
                    State.CursorPositionX += 20;
                    break;
                }
            }
        }

        private void DrawMissingStems(Staff staff)
        {
            //Draw missing stems / Dorysuj brakujące ogonki:
            Note lastNoteInBeam = null;
            Note firstNoteInBeam = null;
            foreach (Note note in staff.Elements.OfType<Note>())
            {
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
                        for (int i = staff.Elements.IndexOf(note) + 1; i < staff.Elements.Count; i++)
                        {
                            if (staff.Elements[i].Type != MusicalSymbolType.Note) continue;
                            Note note2 = (Note)staff.Elements[i];
                            if (note2.BeamList.Count > 0)
                            {
                                if (note2.BeamList[0] == NoteBeamType.End)
                                {
                                    lastNoteInBeam = note2;
                                    break;
                                }
                            }
                        }
                        double newStemEndPosition = Math.Abs(note.StemEndLocation.X -
                            firstNoteInBeam.StemEndLocation.X) *
                            ((Math.Abs(lastNoteInBeam.StemEndLocation.Y - firstNoteInBeam.StemEndLocation.Y)) /
                            (Math.Abs(lastNoteInBeam.StemEndLocation.X - firstNoteInBeam.StemEndLocation.X)));

                        //Jeśli ostatnia nuta jest wyżej, to odejmij y zamiast dodać
                        //If the last note is higher, subtract y instead of adding
                        if (lastNoteInBeam.StemEndLocation.Y < firstNoteInBeam.StemEndLocation.Y)
                            newStemEndPosition *= -1;

                        Point newStemEndPoint = new Point(note.StemEndLocation.X, firstNoteInBeam.StemEndLocation.Y + newStemEndPosition);
                        if (note.StemDirection == NoteStemDirection.Down)
                            DrawLine(new Point(note.StemEndLocation.X, note.Location.Y + 25), new Point(newStemEndPoint.X, newStemEndPoint.Y + 23 + 5));
                        else
                            DrawLine(new Point(note.StemEndLocation.X, note.Location.Y + 23), new Point(newStemEndPoint.X, newStemEndPoint.Y + 23 + 5));


                    }
                }
                if (lastNoteInBeam == null) continue;
            }
        }

        private void DrawSelectionBox()
        {
            //Draw selection box / Rysuj zaznaczenie:
            /*if (State.isSelected)
            {
                renderer.FillRectangle(new SolidBrush(SystemColors.GradientInactiveCaption),
                    new Rectangle(0, 0, Width, Height));
            }

            if (drawOnlySelectionAndButtons) return;
            if (drawOnParentControl && !print && (this.Parent != null))
            {
                g = this.Parent.CreateGraphics();
                renderer.TranslateTransform(this.Location.X, this.Location.Y);
            }*/
        }
    }
}
