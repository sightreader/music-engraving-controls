namespace Manufaktura.Controls.Model.PeekStrategies
{
    public class PreviousElementPeekStrategy<TSymbol> : PeekStrategy<TSymbol> where TSymbol : MusicalSymbol
    {
        public PreviousElementPeekStrategy(Staff staff)
            : base(staff)
        {
        }

        public override TSymbol Peek(MusicalSymbol relativeTo)
        {
            MusicalSymbol currentSymbol = null;
            TSymbol matchedSymbol = null;
            int indexOfCurrentElement = Staff.Elements.IndexOf(relativeTo);
            for (int i = indexOfCurrentElement; i >= 0; i--)
            {
                currentSymbol = Staff.Elements[i];
                if (currentSymbol is TSymbol)
                {
                    matchedSymbol = (TSymbol)currentSymbol;
                    if (i < indexOfCurrentElement) break;
                }
            }
            return matchedSymbol;
        }
    }
}