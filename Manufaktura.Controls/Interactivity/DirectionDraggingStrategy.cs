using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;

namespace Manufaktura.Controls.Interactivity
{
	/// <summary>
	/// Strategy of dragging directions
	/// </summary>
	public class DirectionDraggingStrategy : DraggingStrategy<Direction>
	{
		protected override void DragInternal(ScoreRendererBase renderer, Direction draggedElement, DraggingState draggingState, double delta, double smallDelta)
		{
			draggedElement.SuppressEvents = true;
			draggedElement.Placement = DirectionPlacementType.Custom;
			draggedElement.SuppressEvents = false;
			draggedElement.DefaultYPosition -= renderer.PixelsToTenths(smallDelta);
		}
	}
}