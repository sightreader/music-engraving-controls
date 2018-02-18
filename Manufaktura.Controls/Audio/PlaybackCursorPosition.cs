using System;

namespace Manufaktura.Controls.Audio
{
    /// <summary>
    /// Describes a position of the playback cursor in time and space.
    /// </summary>
	public struct PlaybackCursorPosition
    {
        /// <summary>
        /// Initializes a new instance of PlaybackCursorPosition.
        /// </summary>
        /// <param name="systemNumber"></param>
        /// <param name="positionX"></param>
        /// <param name="timestamp"></param>
        /// <param name="duration"></param>
		public PlaybackCursorPosition(int systemNumber, double positionX, DateTime timestamp, TimeSpan duration)
        {
            SystemNumber = systemNumber;
            PositionX = positionX;
            Timestamp = timestamp;
            Duration = duration;
            IsValid = systemNumber != 0;
        }

        /// <summary>
        /// Duration of displaying the cursor at specific position.
        /// </summary>
		public TimeSpan Duration { get; private set; }

        /// <summary>
        /// True if playback cursor is placed in valid location. Affects cursor visibility.
        /// </summary>
		public bool IsValid { get; private set; }

        /// <summary>
        /// Position in space
        /// </summary>
		public double PositionX { get; private set; }

        /// <summary>
        /// Number of system on which the playback cursor will be drawn.
        /// </summary>
        public int SystemNumber { get; private set; }

        /// <summary>
        /// Used to deterine if playback cursor position is outdated too avoid drawing too late.
        /// </summary>
        public DateTime Timestamp { get; private set; }
    }
}