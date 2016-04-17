using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Extensions
{
	public static class StaffBuilder
	{
		public static IEnumerable<Note> AddDots(this IEnumerable<Note> notes, params int[] dots)
		{
			if (dots.Count() != dots.Length) throw new Exception("Dots must have the same count as notes.");
			int i = 0;
			foreach (var n in notes)
			{
				n.NumberOfDots = dots[i];
				i++;
			}
			return notes;
		}

		public static IEnumerable<Note> AddRhythm(this IEnumerable<Pitch> pitches, params int[] durations)
		{
			if (pitches.Count() != durations.Length) throw new Exception("Durations must have the same count as pitches.");
			var units = new Queue<RhythmicUnit>(RhythmicUnit.Parse(durations));
			return pitches.Select(p => new Note(p, units.Dequeue().Duration)).ToArray();
		}

		public static IEnumerable<Note> ApplyStemDirection(this IEnumerable<Note> notes, VerticalDirection direction)
		{
			foreach (var n in notes)
			{
				n.StemDirection = direction;
				n.SubjectToNoteStemRule = false;
			}
			return notes;
		}

		public static IEnumerable<Pitch> FromPitches(params Pitch[] pitches)
		{
			return pitches;
		}

		public static IEnumerable<Note> Rebeam(this IEnumerable<Note> notes)
		{
			Note previousNote = null;
			Note currentNote = null;
			Note nextNote = null;
			var noteArray = notes.ToArray();
			for (int i=0; i< noteArray.Length; i++)
			{
				previousNote = i == 0 ? null : noteArray[i - 1];
				currentNote = noteArray[i];
				nextNote = i == noteArray.Length - 1 ? null : noteArray[i + 1];

				currentNote.BeamList.Clear();
				var numberOfBeams = Math.Log(currentNote.BaseDuration.Denominator, 2) - 2;
				var numberOfBeamsOnPreviousNote = previousNote == null ? 0 : Math.Log(previousNote.BaseDuration.Denominator, 2) - 2;
				var numberOfBeamsOnNextNote  = nextNote == null ? 0 : Math.Log(nextNote.BaseDuration.Denominator, 2) - 2;
				for (var b = 0; b < numberOfBeams; b++)
				{
					if (previousNote == null)
					{
						if (nextNote != null && numberOfBeamsOnNextNote < b + 1)
						{
							currentNote.BeamList.Add(NoteBeamType.ForwardHook);
						}
						else currentNote.BeamList.Add(NoteBeamType.Start);
					}
					else if (nextNote == null)
					{
						if (previousNote != null && numberOfBeamsOnPreviousNote < b + 1)
						{
							currentNote.BeamList.Add(NoteBeamType.BackwardHook);
						}
						else currentNote.BeamList.Add(NoteBeamType.End);
					}
					else
					{
						if (numberOfBeamsOnPreviousNote >= b + 1 && numberOfBeamsOnNextNote >= b + 1) currentNote.BeamList.Add(NoteBeamType.Continue);
						else if (numberOfBeamsOnPreviousNote < b + 1 && numberOfBeamsOnNextNote < b + 1) currentNote.BeamList.Add(NoteBeamType.ForwardHook);
						else if (numberOfBeamsOnPreviousNote < b + 1) currentNote.BeamList.Add(NoteBeamType.Start);
						else if (numberOfBeamsOnNextNote < b + 1) currentNote.BeamList.Add(NoteBeamType.End);
					}
				}
			}
			return notes;
		}
	}
}