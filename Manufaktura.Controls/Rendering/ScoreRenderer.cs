using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering
{
    public abstract class ScoreRenderer<TCanvas> : ScoreRendererBase
    {
        public TCanvas Canvas { get; internal set; }

        public List<Exception> Exceptions { get; protected set; }

        public ScoreRenderer(TCanvas canvas)
        {
            Canvas = canvas;
            Exceptions = new List<Exception>();
        }

        public void Render(Score score)
        {
            scoreService.BeginNewScore(score);
            DrawSelectionBox();
            foreach (Staff staff in score.Staves)
            {
                try
                {
                    RenderStaff(staff);
                }
                catch (Exception ex)
                {
                    Exceptions.Add(ex);
                }
            }
        }

        private void DetermineClef(Staff staff)
        {
            var clef = staff.Elements.FirstOrDefault(MusicalSymbolType.Clef) as Clef; //Perform one pass to determine current clef / Wykonaj jeden przebieg żeby określić bieżący klucz
            if (clef == null) return;

            State.CurrentClef = clef;
            State.CurrentClefPositionY = scoreService.CurrentLinePositions[4] - ((clef.Line - 1) * Settings.LineSpacing);
            State.CurrentClefTextBlockPositionY = State.CurrentClefPositionY - TextBlockHeight;
            State.CurrentClef = clef;
            DrawString(State.CurrentClef.MusicalCharacter, MusicFontStyles.MusicFont, State.CursorPositionX, State.CurrentClefTextBlockPositionY, clef);
            State.CursorPositionX += 20;
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
                        if (note.StemDirection == VerticalDirection.Down)
                            DrawLine(new Point(note.StemEndLocation.X, note.TextBlockLocation.Y + 25), new Point(newStemEndPoint.X, newStemEndPoint.Y + 23 + 5), note);
                        else
                            DrawLine(new Point(note.StemEndLocation.X, note.TextBlockLocation.Y + 23), new Point(newStemEndPoint.X, newStemEndPoint.Y + 23 + 5), note);
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

        private void RenderStaff(Staff staff)
        {
            BreakToNextStaff();
            if (!Settings.IgnoreCustomElementPositions && Settings.IsPanoramaMode)
            {
                double newPageWidth = staff.MeasureWidths.Where(w => w.HasValue).Sum(w => w.Value * Settings.CustomElementPositionRatio);
                if (newPageWidth > Settings.PageWidth) Settings.PageWidth = newPageWidth;
            }

            DetermineClef(staff);

            alterationService.Reset();
            State.firstNoteInIncipit = true;

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
            scoreService.CurrentSystem.Width = State.CursorPositionX;
            //scoreService.CurrentSystem.Width = scoreService.Systems.Sum(s => s.Width);
            //if (scoreService.CurrentSystem.Width == 0) scoreService.CurrentSystem.Width = State.CursorPositionX;

            //Draw all lines:
            for (int system = 1; system <= scoreService.CurrentSystemNo; system++)
            {
                StaffRenderStrategy.Draw(staff, this, scoreService.LinePositions[system, scoreService.CurrentStaffNo], scoreService.Systems[system - 1].Width);
            }
        }
    }
}