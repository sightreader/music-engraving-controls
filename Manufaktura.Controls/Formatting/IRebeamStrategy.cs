using Manufaktura.Controls.Model;
using System.Collections.Generic;

namespace Manufaktura.Controls.Formatting
{
    /// <summary>
    /// Interface for implementing beaming strategies
    /// </summary>
	internal interface IRebeamStrategy
	{
        /// <summary>
        /// Rebeam mode that this strategy is relevant for
        /// </summary>
		RebeamMode Mode { get; }

        /// <summary>
        /// Performs rebeaming
        /// </summary>
        /// <param name="notes">Notes to rebeam</param>
        /// <param name="hookDirectionAlgorithm">Algorithm for determining hook direction in beams</param>
        /// <returns>Rebeamed notes</returns>
		IEnumerable<NoteOrRest> Rebeam(IEnumerable<NoteOrRest> notes, HookDirectionAlgorithm hookDirectionAlgorithm = HookDirectionAlgorithm.ProductionCandidate);
	}
}