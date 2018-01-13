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
        /// <param name="notes">Notes to rebeam</param>
        /// <param name="hookDirectionAlgorithm">Algorithm for determining hook direction in beams</param>
        /// <returns>Rebeamed notes</returns>
		public IEnumerable<NoteOrRest> Rebeam(IEnumerable<NoteOrRest> notes, HookDirectionAlgorithm hookDirectionAlgorithm = HookDirectionAlgorithm.ProductionCandidate)
		{
			var splittedNotes = notes.SplitByLyrics();
			foreach (var noteGroup in splittedNotes)
			{
				noteGroup.Rebeam(RebeamMode.Simple, hookDirectionAlgorithm);
			}
			return notes;
		}
	}
}