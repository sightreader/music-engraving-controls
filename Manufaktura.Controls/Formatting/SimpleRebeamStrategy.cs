using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Formatting
{
	public class SimpleRebeamStrategy : IRebeamStrategy
	{
		public RebeamMode Mode => RebeamMode.Simple;

		public IEnumerable<NoteOrRest> Rebeam(IEnumerable<NoteOrRest> notes)
		{
			Note previousNote = null;
			Note currentNote = null;
			Note nextNote = null;
			var noteArray = notes.ToArray();
			for (int i = 0; i < noteArray.Length; i++)
			{
				previousNote = i == 0 ? null : noteArray[i - 1] as Note;
				currentNote = noteArray[i] as Note;
				nextNote = i == noteArray.Length - 1 ? null : noteArray[i + 1] as Note;

				currentNote.BeamList.Clear();
				var numberOfBeams = Math.Log(currentNote.BaseDuration.Denominator, 2) - 2;
				var numberOfBeamsOnPreviousNote = previousNote == null ? 0 : Math.Log(previousNote.BaseDuration.Denominator, 2) - 2;
				var numberOfBeamsOnNextNote = nextNote == null ? 0 : Math.Log(nextNote.BaseDuration.Denominator, 2) - 2;
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