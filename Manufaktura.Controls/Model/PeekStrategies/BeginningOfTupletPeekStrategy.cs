using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.PeekStrategies
{
    public class BeginningOfTupletPeekStrategy<TSymbol> : PeekStrategy<TSymbol> where TSymbol : MusicalSymbol
    {
        public BeginningOfTupletPeekStrategy(Staff staff) : base(staff)
        {
        }

        public override TSymbol Peek(MusicalSymbol relativeTo)
        {
            MusicalSymbol currentSymbol = null;
            TSymbol matchedSymbol = null;
            int indexOfCurrentElement = Staff.Elements.IndexOf(relativeTo);
            for (int i = indexOfCurrentElement; i > 0 && i < Staff.Elements.Count; i--)
            {
                currentSymbol = Staff.Elements[i];
                if (currentSymbol is TSymbol && currentSymbol is ICanBeElementOfTuplet)
                {
                    if (((ICanBeElementOfTuplet)currentSymbol).Tuplet == TupletType.Start) matchedSymbol = (TSymbol)currentSymbol;
                }
                if (currentSymbol is ICanBeElementOfTuplet && ((ICanBeElementOfTuplet)currentSymbol).Tuplet == TupletType.Start) break;
            }
            return matchedSymbol;
        }
    }
}
