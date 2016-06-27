using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;

namespace Manufaktura.Controls.Interactivity
{
	/// <summary>
	/// Strategy of dragging rests
	/// </summary>
	public class RestDraggingStrategy : DraggingStrategy<Rest>
	{
		protected override void DragInternal(ScoreRendererBase renderer, Rest draggedElement, DraggingState draggingState, double delta, double smallDelta)
		{
			if (!draggedElement.DefaultYPosition.HasValue)
			{
				draggedElement.SuppressEvents = true;
				draggedElement.DefaultYPosition = 0;
				draggedElement.SuppressEvents = false;
			}
			draggedElement.DefaultYPosition -= renderer.PixelsToTenths(smallDelta);
		}
	}
}