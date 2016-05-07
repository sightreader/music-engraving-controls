using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;

namespace Manufaktura.Controls.Interactivity
{
	/// <summary>
	/// Strategy of dragging lyrics
	/// </summary>
	public class LyricsDraggingStrategy : DraggingStrategy<Lyrics>
	{
		protected override void DragInternal(ScoreRendererBase renderer, Lyrics draggedElement, DraggingState draggingState, double delta, double smallDelta)
		{
			draggedElement.SuppressEvents = true;
			if (!draggedElement.DefaultYPosition.HasValue)
			{
				draggedElement.DefaultYPosition = renderer.PixelsToTenths(-30);
			}
			draggedElement.DefaultYPosition += renderer.PixelsToTenths(smallDelta);
			draggedElement.SuppressEvents = false;
			draggedElement.InvalidateMeasure();
		}
	}
}