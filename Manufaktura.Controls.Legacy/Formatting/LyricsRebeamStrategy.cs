using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using System.Collections.Generic;

namespace Manufaktura.Controls.Formatting
{
	public class LyricsRebeamStrategy : IRebeamStrategy
	{
		public RebeamMode Mode => RebeamMode.ToLyrics;

		public IEnumerable<NoteOrRest> Rebeam(IEnumerable<NoteOrRest> notes, HookDirectionAlgorithm hookDirectionAlgorith = HookDirectionAlgorithm.ProductionCandidate)
		{
			var splittedNotes = notes.SplitByLyrics();
			foreach (var noteGroup in splittedNotes)
			{
				noteGroup.Rebeam(RebeamMode.Simple, hookDirectionAlgorith);
			}
			return notes;
		}
	}
}