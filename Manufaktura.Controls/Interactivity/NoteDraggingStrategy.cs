using Manufaktura.Controls.Model;

namespace Manufaktura.Controls.Interactivity
{
	public class NoteDraggingStrategy : DraggingStrategy<Note>
	{
		protected override void DragInternal(Note draggedElement, DraggingState draggingState, double delta, double smallDelta)
		{
			int midiPitch = draggingState.MidiPitchOnStartDragging + (int)(delta / 2);
			draggedElement.ApplyMidiPitch(midiPitch);     //TODO: Wstawianie kasownika, jeśli jest znak przykluczowy, a obniżyliśmy o pół tonu
														  //TODO: Ustalanie kierunku ogonka. Sprawdzić czy gdzieś to nie jest już zrobione, np. w PSAMie
		}
	}
}