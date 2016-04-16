using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
	internal class DrawMissingStemsFinishingTouch : IFinishingTouch
	{
		public void PerformOnMeasure(Measure measure, ScoreRendererBase renderer)
		{
			Perform(measure.Staff, measure, renderer);
		}

		public void PerformOnScore(Score score, ScoreRendererBase renderer)
		{
		}

		public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
		{
			Perform(staff, null, renderer);
		}

		private void Perform(Staff staff, Measure measure, ScoreRendererBase renderer)
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
						if (note.HasCustomStemEndPosition) continue;
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

						if (measure != null && note.Measure != measure) continue;	//Odśwież tylko stemy z wybranego taktu w trybie odświeżania jednego taktu
						if (note.StemDirection == VerticalDirection.Down)
							renderer.DrawLine(new Point(note.StemEndLocation.X, note.TextBlockLocation.Y + 25), new Point(newStemEndPoint.X, newStemEndPoint.Y + 23 + 5), note);
						else
							renderer.DrawLine(new Point(note.StemEndLocation.X, note.TextBlockLocation.Y + 23), new Point(newStemEndPoint.X, newStemEndPoint.Y + 23 + 5), note);
					}
				}
				if (lastNoteInBeam == null) continue;
			}
		}
	}
}