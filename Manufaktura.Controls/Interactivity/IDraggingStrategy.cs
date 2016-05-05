using Manufaktura.Controls.Primitives;
using System;

namespace Manufaktura.Controls.Interactivity
{
	public interface IDraggingStrategy
	{
		Type ElementType { get; }

		void Drag(object draggedElement, DraggingState draggingState, Point currentPosition);
	}
}