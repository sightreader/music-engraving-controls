using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using System;

namespace Manufaktura.Controls.Interactivity
{
	/// <summary>
	/// Strategy that describes dragging behavior of specific elements
	/// </summary>
	public interface IDraggingStrategy
	{
		/// <summary>
		/// Type of MusicalSymbol which dragging behavior is managed by this class
		/// </summary>
		Type ElementType { get; }

		/// <summary>
		/// Manages dragging behavior
		/// </summary>
		/// <param name="renderer">Score renderer</param>
		/// <param name="draggedElement">Dragged element</param>
		/// <param name="draggingState">Dragging state</param>
		/// <param name="currentPosition">Current cursor position</param>
		void Drag(ScoreRendererBase renderer, object draggedElement, DraggingState draggingState, Point currentPosition);
	}
}