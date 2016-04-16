namespace Manufaktura.Controls.Model
{
	public struct Hook
	{
		public Hook(double x, double y, int beamNumber, bool isForward)
		{
			HookStartPositionX = x;
			HookStartPositionY = y;
			BeamNumber = beamNumber;
			IsForward = isForward;
		}

		public int BeamNumber { get; set; }
		public double HookStartPositionX { get; set; }
		public double HookStartPositionY { get; set; }

		public bool IsForward { get; set; }
	}
}