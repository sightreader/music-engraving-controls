namespace Manufaktura.Controls.Formatting
{
    /// <summary>
    /// Type of algorithm for determining hook direction in beams. These algorithms are currently used only in SimpleRebeamStrategy.
    /// </summary>
	public enum HookDirectionAlgorithm
    {
        /// <summary>
        /// Default algorithm
        /// </summary>
		ProductionCandidate,

        /// <summary>
        /// Second algorithm
        /// </summary>
		Second,

        /// <summary>
        /// Third algorithm
        /// </summary>
		Third
    }
}