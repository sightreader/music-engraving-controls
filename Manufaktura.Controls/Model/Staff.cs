using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Staff : MusicalSymbol
    {
        public List<MusicalSymbol> Elements { get; private set; }
        public List<double?> MeasureWidths { get; private set; }
        public Staff()
        {
            Elements = new List<MusicalSymbol>();
            MeasureWidths = new List<double?>();
        }

        public TSymbol Peek<TSymbol>(MusicalSymbol relativeTo, PeekType peekType) where TSymbol : MusicalSymbol
        {
            MusicalSymbol currentSymbol = null;
            TSymbol matchedSymbol = null;
            int indexOfCurrentElement = Elements.IndexOf(relativeTo);
            for (int i = indexOfCurrentElement; i > 0 && i < Elements.Count; i += Math.Sign((int)peekType))
            {
                currentSymbol = Elements[i];
                if (currentSymbol is TSymbol)
                {
                    matchedSymbol = (TSymbol)currentSymbol;
                    if (i > indexOfCurrentElement && peekType == PeekType.NextElement) break;
                }

                //Conditions to end search:
                if (currentSymbol is ICanBeElementOfTuplet && peekType == PeekType.BeginningOfTuplet && ((ICanBeElementOfTuplet)currentSymbol).Tuplet == TupletType.Start) break;
                if (currentSymbol is ICanBeElementOfTuplet && peekType == PeekType.EndOfTuplet && ((ICanBeElementOfTuplet)currentSymbol).Tuplet == TupletType.Stop) break;
                if (currentSymbol is Barline && peekType == PeekType.BeginningOfMeasure) break;
            }
            return matchedSymbol;
        }

        public enum PeekType
        {
            BeginningOfMeasure = -1,
            BeginningOfTuplet = -2,
            NextElement = 1,
            EndOfTuplet = 2
        }

    }
}
