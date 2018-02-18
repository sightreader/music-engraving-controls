namespace Manufaktura.Controls.Model.PeekStrategies
{
    /// <summary>
    /// Strategy of peeking elements on a staff
    /// </summary>
    /// <typeparam name="TSymbol"></typeparam>
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
        HighestNoteInChord
    }
}