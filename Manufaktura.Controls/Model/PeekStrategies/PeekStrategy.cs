using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.PeekStrategies
{
    public abstract class PeekStrategy<TSymbol> where TSymbol : MusicalSymbol
    {
        public Staff Staff { get; protected set; }

        protected PeekStrategy(Staff staff)
        {
            Staff = staff;
        }

        public abstract TSymbol Peek(MusicalSymbol relativeTo);

    }

    public enum PeekType
    {
        BeginningOfMeasure,
        BeginningOfTuplet,
        NextElement,
        PreviousElement,
        EndOfTuplet,
        HighestNoteInChord,
        BeginningOfSlur
    }
}
