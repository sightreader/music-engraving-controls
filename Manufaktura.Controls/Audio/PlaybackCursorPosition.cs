using System;

namespace Manufaktura.Controls.Audio
{
	public struct PlaybackCursorPosition
	{
		public PlaybackCursorPosition(int systemNumber, double positionX, DateTime timestamp, TimeSpan duration)
		{
			SystemNumber = systemNumber;
			PositionX = positionX;
			Timestamp = timestamp;
			Duration = duration;
			IsValid = systemNumber != 0;
		}

		public TimeSpan Duration { get; private set; }
		public bool IsValid { get; private set; }
		public double PositionX { get; private set; }
		public int SystemNumber { get; private set; }

		public DateTime Timestamp { get; private set; }

	}
}