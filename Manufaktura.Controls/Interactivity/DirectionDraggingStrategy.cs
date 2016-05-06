using Manufaktura.Controls.Model;

namespace Manufaktura.Controls.Interactivity
{
	public class DirectionDraggingStrategy : DraggingStrategy<Direction>
	{
		protected override void DragInternal(Direction draggedElement, DraggingState draggingState, double delta, double smallDelta)
		{
			draggedElement.SuppressEvents = true;
			draggedElement.Placement = DirectionPlacementType.Custom;
			draggedElement.SuppressEvents = false;
			draggedElement.DefaultY += (int)smallDelta;
		}
	}
}