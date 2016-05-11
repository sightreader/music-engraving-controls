namespace Manufaktura.Controls.Audio
{
	public struct PlaybackCursorPosition
	{
		public PlaybackCursorPosition(int systemNumber, double positionX)
		{
			SystemNumber = systemNumber;
			PositionX = positionX;
		}

		public double PositionX { get; private set; }
		public int SystemNumber { get; private set; }
	}
}