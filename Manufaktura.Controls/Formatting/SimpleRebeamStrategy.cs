using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Formatting
{
    /// <summary>
    /// Rebeam strategy with simple rules
    /// </summary>
	public class SimpleRebeamStrategy : IRebeamStrategy
	{
		public RebeamMode Mode => RebeamMode.Simple;

        /// <summary>
        /// Performs rebeaming with simple rules
        /// </summary>
        /// <param name="notes">Notes to rebeam</param>
        /// <param name="hookDirectionAlgorithm">Algorithm for determining hook direction in beams</param>
        /// <returns>Rebeamed notes</returns>
        public IEnumerable<NoteOrRest> Rebeam(IEnumerable<NoteOrRest> notes, HookDirectionAlgorithm hookDirectionAlgorithm = HookDirectionAlgorithm.ProductionCandidate)
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
							currentNote.BeamList.Add(DetermineHookDirection(notes.ToList(), currentNote, hookDirectionAlgorithm));
						}
						else currentNote.BeamList.Add(NoteBeamType.Start);
					}
					else if (nextNote == null)
					{
						if (previousNote != null && numberOfBeamsOnPreviousNote < b + 1)
						{
							currentNote.BeamList.Add(DetermineHookDirection(notes.ToList(), currentNote, hookDirectionAlgorithm));
						}
						else currentNote.BeamList.Add(NoteBeamType.End);
					}
					else
					{
						if (numberOfBeamsOnPreviousNote >= b + 1 && numberOfBeamsOnNextNote >= b + 1) currentNote.BeamList.Add(NoteBeamType.Continue);
						else if (numberOfBeamsOnPreviousNote < b + 1 && numberOfBeamsOnNextNote < b + 1) currentNote.BeamList.Add(DetermineHookDirection(notes.ToList(), currentNote, hookDirectionAlgorithm));
						else if (numberOfBeamsOnPreviousNote < b + 1) currentNote.BeamList.Add(NoteBeamType.Start);
						else if (numberOfBeamsOnNextNote < b + 1) currentNote.BeamList.Add(NoteBeamType.End);
					}
				}
			}
			return notes;
		}

		private NoteBeamType DetermineHookDirection(List<NoteOrRest> notes, Note currentNote, HookDirectionAlgorithm hookDirectionAlgorithm = HookDirectionAlgorithm.ProductionCandidate)
		{
			if (currentNote.DesiredHookDirection == DesiredHookDirections.BackwardHook) return NoteBeamType.BackwardHook;
			if (currentNote.DesiredHookDirection == DesiredHookDirections.ForwardHook) return NoteBeamType.ForwardHook;
			if (currentNote == notes.Last()) return NoteBeamType.BackwardHook;
			if (currentNote == notes.First()) return NoteBeamType.ForwardHook;

			int pulse;
			double currentBeat;
			switch (hookDirectionAlgorithm)
			{
				case HookDirectionAlgorithm.ProductionCandidate:
					pulse = notes.Min(n => n.BaseDuration.Denominator);
					currentBeat = notes.Take(notes.IndexOf(currentNote)).Sum(n => n.Duration.ToDouble() * pulse);
					return currentBeat + currentNote.Duration.ToDouble() * pulse > Math.Ceiling(currentBeat) ? NoteBeamType.ForwardHook : NoteBeamType.BackwardHook;

				case HookDirectionAlgorithm.Second:
					pulse = notes.Min(n => n.BaseDuration.Denominator);
					currentBeat = notes.Take(notes.IndexOf(currentNote)).Sum(n => n.Duration.ToDouble() * pulse);
					return currentBeat - Math.Floor(currentBeat) >= Math.Ceiling(currentBeat) - currentBeat ? NoteBeamType.ForwardHook : NoteBeamType.BackwardHook;

				case HookDirectionAlgorithm.Third:
					pulse = (int)notes.Pulse();
					currentBeat = notes.Take(notes.IndexOf(currentNote)).Sum(n => (1d / pulse * n.BaseDuration.Denominator));
					return currentBeat - Math.Floor(currentBeat) > Math.Ceiling(currentBeat) - currentBeat ? NoteBeamType.ForwardHook : NoteBeamType.BackwardHook;

				default:
					throw new Exception("Unknown hook direction algorithm.");
			}
		}
	}
}