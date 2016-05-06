using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Formatting
{
	public class BeatRebeamStrategy : IRebeamStrategy
	{
		public RebeamMode Mode => RebeamMode.ToBeats;

		public IEnumerable<NoteOrRest> Rebeam(IEnumerable<NoteOrRest> notes, HookDirectionAlgorithm hookDirectionAlgorithm = HookDirectionAlgorithm.ProductionCandidate)
		{
			var staff = notes.FirstOrDefault(n => n.Staff != null)?.Staff;
			if (staff == null) throw new Exception($"Staff property is null. Notes must be added to staff before using {nameof(BeatRebeamStrategy)}.");

			var timeSignature = staff.Peek<TimeSignature>(notes.First(), Model.PeekStrategies.PeekType.PreviousElement);
			if (timeSignature == null) throw new Exception($"Could not determine time signature. Check if time signature is added to the staff before first note to rebeam.");

			var splittedNotes = notes.SplitByBeats(timeSignature);
			foreach (var noteGroup in splittedNotes)
			{
				noteGroup.Rebeam(RebeamMode.Simple, hookDirectionAlgorithm);
			}
			return notes;
		}
	}
}