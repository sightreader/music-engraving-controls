namespace Manufaktura.Controls.Formatting
{
    /// <summary>
    /// Rebeam mode
    /// </summary>
	public enum RebeamMode
	{
        /// <summary>
        /// Indicates that notes will be rebeamed using SimpleRebeamStrategy
        /// </summary>
		Simple,
        /// <summary>
        /// Indicates that notes will be rebeamed using LyricsRebeamStrategy
        /// </summary>
		ToLyrics,
        /// <summary>
        /// Indicates that notes will be rebeamed using BeatRebeamStrategy
        /// </summary>
		ToBeats
	}
}