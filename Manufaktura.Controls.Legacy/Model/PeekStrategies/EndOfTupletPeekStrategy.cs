using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.PeekStrategies
{
    public class EndOfTupletPeekStrategy<TSymbol> : PeekStrategy<TSymbol> where TSymbol : MusicalSymbol
    {
        public EndOfTupletPeekStrategy(Staff staff) : base(staff)
        {
        }

        public override TSymbol Peek(MusicalSymbol relativeTo)
        {
            MusicalSymbol currentSymbol = null;
            TSymbol matchedSymbol = null;
            int indexOfCurrentElement = Staff.Elements.IndexOf(relativeTo);
            for (int i = indexOfCurrentElement; i < Staff.Elements.Count; i++)
            {
                currentSymbol = Staff.Elements[i];
                if (currentSymbol is TSymbol)
                {
                    matchedSymbol = (TSymbol)currentSymbol;
                }
                if (currentSymbol is ICanBeElementOfTuplet && ((ICanBeElementOfTuplet)currentSymbol).Tuplet == TupletType.Stop) break;
            }
            return matchedSymbol;
        }
    }
}
