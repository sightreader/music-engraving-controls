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

        public TSymbol Peek<TSymbol>(MusicalSymbol relativeTo, PeekType peekType, PeekDirection peekDirection) where TSymbol : MusicalSymbol
        {
            if (peekDirection == PeekDirection.Forward) throw new NotImplementedException("Peek forward is currently not implemented.");

            MusicalSymbol currentSymbol = null;
            TSymbol matchedSymbol = null;
            for (int i = Elements.IndexOf(relativeTo); i > 0 && i < Elements.Count; i += (int)peekDirection)
            {
                currentSymbol = Elements[i];             
                if (currentSymbol is TSymbol) matchedSymbol = (TSymbol)currentSymbol;

                //Conditions to end search:
                if (currentSymbol is ICanBeElementOfTuplet && peekType == PeekType.BeginningOfTuplet && ((ICanBeElementOfTuplet)currentSymbol).Tuplet == TupletType.Start) break;
                if (currentSymbol is Barline && peekType == PeekType.BeginningOfMeasure) break;
            }
            return matchedSymbol;
        }

        public enum PeekType
        {
            BeginningOfMeasure,
            BeginningOfTuplet
        }

        public enum PeekDirection
        {
            Forward = 1,
            Backward = -1
        }
    }
}
