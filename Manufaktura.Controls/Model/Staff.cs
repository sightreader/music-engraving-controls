using Manufaktura.Controls.Model.PeekStrategies;
using Manufaktura.Controls.Model.Rules;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a staff.
    /// </summary>
    public class Staff : MusicalSymbol
    {
        public MusicalSymbolCollection Elements { get; private set; }

        public double Height { get; set; }

        public List<double?> MeasureWidths { get; private set; }

        public Part Part { get; internal set; }

        /// <summary>
        /// Rules to apply when adding notes to the staff.
        /// </summary>
        public List<StaffRule> Rules { get; private set; }

        public Score Score { get; internal set; }

        /// <summary>
        /// Initializes a new Staff.
        /// </summary>
        public Staff()
        {
            Elements = new MusicalSymbolCollection(this);
            MeasureWidths = new List<double?>();
            Rules = new List<StaffRule> { new NoteStemRule() };
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

                case PeekType.HighestNoteInChord:
                    strategy = new HighestNoteInChordPeekStrategy<TSymbol>(this);
                    break;

                default:
                    throw new NotImplementedException("Peek type not implemented.");
            }
            return strategy.Peek(relativeTo);
        }

        /// <summary>
        /// Wraps the staff with a score (creates a new score with this staff).
        /// </summary>
        /// <returns>Score</returns>
        public Score ToOneStaffScore()
        {
            var score = new Score();
            score.Staves.Add(this);
            return score;
        }

        internal void ApplyRules(MusicalSymbol item)
        {
            foreach (var rule in Rules.Where(r => r.Condition(this, item))) rule.Apply(this, item);
        }
    }
}