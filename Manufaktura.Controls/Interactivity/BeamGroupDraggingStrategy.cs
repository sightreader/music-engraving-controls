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

			draggedElement.Start = new Primitives.Point(draggedElement.Start.X, draggedElement.Start.Y + delta);
			draggedElement.End = new Primitives.Point(draggedElement.End.X, draggedElement.End.Y + delta);

			firstElement.SuppressEvents = true;
			lastElement.SuppressEvents = true;

			firstElement.StemEndLocation = new Primitives.Point(firstElement.StemEndLocation.X, firstElement.StemEndLocation.Y + smallDelta);
			firstElement.StemDefaultY = firstElement.TextBlockLocation.Y - 25 + (firstElement.StemEndLocation.Y);
			firstElement.HasCustomStemEndPosition = true;

			lastElement.StemEndLocation = new Primitives.Point(lastElement.StemEndLocation.X, lastElement.StemEndLocation.Y + smallDelta);
			lastElement.StemDefaultY = lastElement.TextBlockLocation.Y - 25 + (lastElement.StemEndLocation.Y);
			lastElement.HasCustomStemEndPosition = true;

			firstElement.SuppressEvents = false;
			lastElement.SuppressEvents = false;
			draggedElement.InvalidateMeasure();
		}
	}
}