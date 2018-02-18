using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using System.Diagnostics.Contracts;

namespace Manufaktura.Controls.Interactivity
{
	/// <summary>
	/// Strategy of dragging notes
	/// </summary>
	public class NoteDraggingStrategy : DraggingStrategy<Note>
	{
		protected override void DragInternal(ScoreRendererBase renderer, Note draggedElement, DraggingState draggingState, double delta, double smallDelta)
		{
#if !CSHTML5
            Contract.Assert(draggedElement != null);
#endif
			int midiPitch = draggingState.MidiPitchOnStartDragging + (int)(delta / 2);
			draggedElement.SuppressEvents = true;
			draggedElement.ApplyMidiPitch(midiPitch);     //TODO: Wstawianie kasownika, jeśli jest znak przykluczowy, a obniżyliśmy o pół tonu
														  //TODO: Ustalanie kierunku ogonka. Sprawdzić czy gdzieś to nie jest już zrobione, np. w PSAMie

			DetermineStemDirection(draggedElement);

			draggedElement.SuppressEvents = false;
			draggedElement.InvalidateMeasure();
		}

		public static void DetermineStemDirection (Note draggedElement)
		{
			if (draggedElement.TextBlockLocation.Y < draggedElement.StemStartLocation.Y)
				draggedElement.StemDirection = VerticalDirection.Down;
			else
				draggedElement.StemDirection = VerticalDirection.Up;
		}
	}
}