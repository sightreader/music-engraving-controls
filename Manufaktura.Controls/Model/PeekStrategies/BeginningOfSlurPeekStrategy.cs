namespace Manufaktura.Controls.Model.PeekStrategies
{
    public class BeginningOfSlurPeekStrategy<TSymbol> : PeekStrategy<TSymbol> where TSymbol : MusicalSymbol
    {
        public BeginningOfSlurPeekStrategy(Staff staff) : base(staff)
        {
        }

        public override TSymbol Peek(MusicalSymbol relativeTo)
        {
            MusicalSymbol currentSymbol = null;
            TSymbol matchedSymbol = null;
            int indexOfCurrentElement = Staff.Elements.IndexOf(relativeTo);
            for (int i = indexOfCurrentElement; i > 0 && i < Staff.Elements.Count; i--)
            {
                currentSymbol = Staff.Elements[i] as Note;
                if (currentSymbol is TSymbol && currentSymbol is Note)
                {
                    if (((Note)currentSymbol).Slur == null) continue;
                    if (((Note)currentSymbol).Slur.Type == NoteSlurType.Start)
                    {
                        matchedSymbol = (TSymbol)currentSymbol;
                        break;
                    }
                }
            }
            return matchedSymbol;
        }
    }
}