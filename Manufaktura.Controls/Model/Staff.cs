using Manufaktura.Controls.Model.PeekStrategies;
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
            PeekStrategy<TSymbol> strategy;
            switch (peekType)
            {
                case PeekType.BeginningOfMeasure:
                    strategy = new BeginningOfMeasurePeekStrategy<TSymbol>(this);
                    break;
                case PeekType.BeginningOfTuplet:
                    strategy = new BeginningOfTupletPeekStrategy<TSymbol>(this);
                    break;
                case PeekType.EndOfTuplet:
                    strategy = new EndOfTupletPeekStrategy<TSymbol>(this);
                    break;
                case PeekType.NextElement:
                    strategy = new NextElementPeekStrategy<TSymbol>(this);
                    break;
                case PeekType.HighestNoteInMeasure:
                    strategy = new HighestNoteInChordPeekStrategy<TSymbol>(this);
                    break;
                default:
                    throw new NotImplementedException("Peek type not implemented.");
            }
            return strategy.Peek(relativeTo);
        }

        

    }
}
