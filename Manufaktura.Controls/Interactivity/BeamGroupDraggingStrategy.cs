using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using System.Linq;

namespace Manufaktura.Controls.Interactivity
{
	public class BeamGroupDraggingStrategy : DraggingStrategy<BeamGroup>
	{
		protected override void DragInternal(ScoreRendererBase renderer, BeamGroup draggedElement, DraggingState draggingState, double delta, double smallDelta)
		{
			if (draggedElement.Members.OfType<Note>().Count() < 2) return;
			var firstElement = draggedElement.Members.OfType<Note>().First();
			var lastElement = draggedElement.Members.OfType<Note>().Last();

			firstElement.SuppressEvents = true;
			lastElement.SuppressEvents = true;

			if (!firstElement.HasCustomStemEndPosition)
			{
				firstElement.StemDefaultY = renderer.PixelsToTenths(firstElement.StemEndLocation.Y - firstElement.TextBlockLocation.Y);
				firstElement.HasCustomStemEndPosition = true;
			}
			if (!lastElement.HasCustomStemEndPosition)
			{
				lastElement.StemDefaultY = renderer.PixelsToTenths(lastElement.StemEndLocation.Y - firstElement.TextBlockLocation.Y);
				lastElement.HasCustomStemEndPosition = true;
			}

			firstElement.StemDefaultY -= smallDelta;
			lastElement.StemDefaultY -= smallDelta;

			firstElement.SuppressEvents = false;
			lastElement.SuppressEvents = false;
			draggedElement.InvalidateMeasure();
		}
	}
}