namespace Manufaktura.Controls.Rendering
{
	public struct DraggingState<TPoint> where TPoint : struct
	{
		public bool IsDragging { get; private set; }

		public int MidiPitchOnStartDragging { get; set; }

		public TPoint MousePositionOnStartDragging { get; private set; }

		public void StartDragging(TPoint startingPosition)
		{
			IsDragging = true;
			MousePositionOnStartDragging = startingPosition;
		}

		public void StopDragging()
		{
			IsDragging = false;
			MousePositionOnStartDragging = default(TPoint);
			MidiPitchOnStartDragging = 0;
		}
	}
}