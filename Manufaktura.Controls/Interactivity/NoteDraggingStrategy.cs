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
			Contract.Assert(draggedElement != null);
			int midiPitch = draggingState.MidiPitchOnStartDragging + (int)(delta / 2);
			draggedElement.ApplyMidiPitch(midiPitch);     //TODO: Wstawianie kasownika, jeśli jest znak przykluczowy, a obniżyliśmy o pół tonu
														  //TODO: Ustalanie kierunku ogonka. Sprawdzić czy gdzieś to nie jest już zrobione, np. w PSAMie
		}
	}
}