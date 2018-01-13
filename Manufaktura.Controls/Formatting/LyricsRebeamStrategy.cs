using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using System.Collections.Generic;

namespace Manufaktura.Controls.Formatting
{
    /// <summary>
    /// Implementation of IRebeamStrategy that performs rebeaming according to lyric syllables
    /// </summary>
	public class LyricsRebeamStrategy : IRebeamStrategy
	{
		public RebeamMode Mode => RebeamMode.ToLyrics;

        /// <summary>
        /// Performs rebeaming with respect to lyric syllables.
        /// </summary>
        /// <param name="notes"></param>
        /// <param name="hookDirectionAlgorith"></param>
        /// <returns></returns>
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