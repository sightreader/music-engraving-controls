using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using System;

namespace Manufaktura.Controls.Interactivity
{
	public interface IDraggingStrategy
	{
		Type ElementType { get; }

		void Drag(ScoreRendererBase renderer, object draggedElement, DraggingState draggingState, Point currentPosition);
	}
}