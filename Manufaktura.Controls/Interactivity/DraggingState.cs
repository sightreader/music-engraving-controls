using Manufaktura.Controls.Primitives;
using System.Diagnostics;

namespace Manufaktura.Controls.Interactivity
{
	public class DraggingState
	{
		public bool IsDragging { get; private set; }

		public int MidiPitchOnStartDragging { get; set; }

		public Point MousePositionOnStartDragging { get; private set; }
		public Point MousePreviousPosition { get; internal set; }

		public void StartDragging(Point startingPosition)
		{
			IsDragging = true;
			MousePositionOnStartDragging = startingPosition;
			MousePreviousPosition = startingPosition;
			Debug.WriteLine("Dragging started");
		}

		public void StopDragging()
		{
			IsDragging = false;
			MousePositionOnStartDragging = default(Point);
			MousePreviousPosition = default(Point);
			MidiPitchOnStartDragging = 0;
			Debug.WriteLine("Dragging stopped");
		}
	}
}