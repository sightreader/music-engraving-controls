using Manufaktura.Controls.Primitives;
using System;

namespace Manufaktura.Controls.Interactivity
{
	public interface IDraggingStrategy
	{
		Type ElementType { get; }

		void Drag<TPoint>(object draggedElement, DraggingState<TPoint> draggingState, int midiPitchOnStartDragging, Point startPosition, Point currentPosition) where TPoint : struct;
	}
}