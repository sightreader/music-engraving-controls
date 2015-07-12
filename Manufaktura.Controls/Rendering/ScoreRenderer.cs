using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Base class for rendering scores on specific canvas.
    /// </summary>
    /// <typeparam name="TCanvas">Canvas object</typeparam>
    public abstract class ScoreRenderer<TCanvas> : ScoreRendererBase
    {
        public TCanvas Canvas { get; internal set; }

        public List<Exception> Exceptions { get; protected set; }

        public ScoreRenderer(TCanvas canvas)
        {
            Canvas = canvas;
            Exceptions = new List<Exception>();
        }

        /// <summary>
        /// Render score on canvas.
        /// </summary>
        /// <param name="score">Score</param>
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
            DrawLinesBetweenStaves();

            //Set height of current system in Panorama mode. This is used for determining the size of the control:
            if (Settings.IsPanoramaMode && scoreService.CurrentSystem.Height == 0)
            {
                scoreService.CurrentSystem.Height = (scoreService.CurrentStaffHeight + Settings.LineSpacing) * scoreService.CurrentScore.Staves.Count;
            }
        }

        private void DetermineClef(Staff staff)
        {
            var clef = staff.Elements.FirstOrDefault(MusicalSymbolType.Clef) as Clef; //Perform one pass to determine current clef / Wykonaj jeden przebieg żeby określić bieżący klucz
            if (clef == null) return;

            scoreService.CurrentClef = clef;
            var clefPositionY = scoreService.CurrentLinePositions[4] - ((clef.Line - 1) * Settings.LineSpacing);
            clef.TextBlockLocation = new Point(scoreService.CursorPositionX, clefPositionY - TextBlockHeight);
            DrawString(clef.MusicalCharacter, MusicFontStyles.MusicFont, clef.TextBlockLocation.X, clef.TextBlockLocation.Y, clef);
            scoreService.CursorPositionX += 20;
        }

        private void DrawLinesBetweenStaves()
        {
            for (var i = 0; i < scoreService.CurrentScore.Staves.Count - 1; i++)
            {
                var staff = scoreService.CurrentScore.Staves[i];
                foreach (var system in scoreService.Systems)
                {
                    foreach (var measure in scoreService.AllMeasures.Where(m => m.Barline != null && m.System == system && m.Staff == staff))
                    {
                        DrawLine(measure.BarlineLocationX, system.LinePositions[i + 1][4], measure.BarlineLocationX, system.LinePositions[i + 2][0], measure.Barline);
                    }
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
            scoreService.CurrentSystem.Width = scoreService.CursorPositionX;

            //Draw all lines:
            for (int system = 1; system <= scoreService.CurrentSystemNo; system++)
            {
                StaffRenderStrategy.Draw(staff, this, scoreService.LinePositions[system, scoreService.CurrentStaffNo], scoreService.Systems[system - 1].Width);
            }
        }
    }
}