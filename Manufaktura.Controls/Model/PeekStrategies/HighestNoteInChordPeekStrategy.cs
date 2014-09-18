using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.PeekStrategies
{
    public class HighestNoteInChordPeekStrategy<TSymbol> : PeekStrategy<TSymbol> where TSymbol : MusicalSymbol
    {
        public HighestNoteInChordPeekStrategy(Staff staff) : base(staff)
        {
            if (typeof(TSymbol) != typeof(Note)) throw new Exception("This strategy can be only used for notes.");
        }

        public override TSymbol Peek(MusicalSymbol relativeTo)
        {
            Note lowestNote = relativeTo as Note;
            List<Note> chordElements = new List<Note>() { lowestNote };
            for (int i = Staff.Elements.IndexOf(lowestNote) + 1; i < Staff.Elements.Count(); i++)
            {
                Note currentNote = Staff.Elements[i] as Note;
                if (currentNote == null) continue;
                if (currentNote.IsChordElement) chordElements.Add(currentNote);
                else break;
            }
            return chordElements.First(n => n.MidiPitch == chordElements.Max(n1 => n1.MidiPitch)) as TSymbol;
        }
    }
}
