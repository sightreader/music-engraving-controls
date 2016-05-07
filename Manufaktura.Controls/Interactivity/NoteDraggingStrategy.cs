using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;

namespace Manufaktura.Controls.Interactivity
{
	/// <summary>
	/// Strategy of dragging notes
	/// </summary>
	public class NoteDraggingStrategy : DraggingStrategy<Note>
	{
		protected override void DragInternal(ScoreRendererBase renderer, Note draggedElement, DraggingState draggingState, double delta, double smallDelta)
		{
			int midiPitch = draggingState.MidiPitchOnStartDragging + (int)(delta / 2);
			draggedElement.ApplyMidiPitch(midiPitch);     //TODO: Wstawianie kasownika, jeśli jest znak przykluczowy, a obniżyliśmy o pół tonu
														  //TODO: Ustalanie kierunku ogonka. Sprawdzić czy gdzieś to nie jest już zrobione, np. w PSAMie
		}
	}
}