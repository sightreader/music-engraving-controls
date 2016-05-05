using Manufaktura.Controls.Primitives;

namespace Manufaktura.Controls.Interactivity
{
	public struct DraggingState
	{
		public bool IsDragging { get; private set; }

		public int MidiPitchOnStartDragging { get; set; }

		public Point MousePositionOnStartDragging { get; private set; }

		public void StartDragging(Point startingPosition)
		{
			IsDragging = true;
			MousePositionOnStartDragging = startingPosition;
		}

		public void StopDragging()
		{
			IsDragging = false;
			MousePositionOnStartDragging = default(Point);
			MidiPitchOnStartDragging = 0;
		}
	}
}