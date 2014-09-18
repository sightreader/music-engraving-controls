using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.PeekStrategies
{
    public class BeginningOfMeasurePeekStrategy<TSymbol> : PeekStrategy<TSymbol> where TSymbol : MusicalSymbol
    {
        public BeginningOfMeasurePeekStrategy(Staff staff) : base(staff)
        {
        }

        public override TSymbol Peek(MusicalSymbol relativeTo)
        {
            MusicalSymbol currentSymbol = null;
            TSymbol matchedSymbol = null;
            int indexOfCurrentElement = Staff.Elements.IndexOf(relativeTo);
            for (int i = indexOfCurrentElement; i > 0; i--)
            {
                currentSymbol = Staff.Elements[i];
                if (currentSymbol is TSymbol)
                {
                    matchedSymbol = (TSymbol)currentSymbol;
                }

                if (currentSymbol is Barline) break;
            }
            return matchedSymbol;
        }
    }
}
