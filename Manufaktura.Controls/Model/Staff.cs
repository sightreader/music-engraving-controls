using Manufaktura.Controls.Model.PeekStrategies;
using Manufaktura.Controls.Model.Rules;
using Manufaktura.Music.Model;
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
        /// <summary>
        /// Elements in Staff
        /// </summary>
        public MusicalSymbolCollection Elements { get; private set; }

        /// <summary>
        /// Height of Staff
        /// </summary>
        public double Height { get; set; }

        public MeasureAddingRuleEnum MeasureAddingRule { get; set; }

        /// <summary>
        /// Measures in Staff
        /// </summary>
        public List<Measure> Measures { get; private set; }

        /// <summary>
        /// Parent Part
        /// </summary>
        public Part Part { get; internal set; }

        /// <summary>
        /// Rules to apply when adding notes to the staff.
        /// </summary>
        public List<StaffRule> Rules { get; private set; }

        /// <summary>
        /// Parent Score
        /// </summary>
        public Score Score { get; internal set; }

        public override MusicalSymbolType Type
        {
            get
            {
                return MusicalSymbolType.Staff;
            }
        }

        /// <summary>
        /// Initializes a new Staff.
        /// </summary>
        public Staff()
        {
            Elements = new MusicalSymbolCollection(this);
            Rules = new List<StaffRule> { new NoteStemRule(), new ManualAddMeasuresRule(), new AutomaticAddMeasuresRule() };
            Measures = new List<Measure>();
            MeasureAddingRule = MeasureAddingRuleEnum.AddMeasureOnInsertingBarline;
        }

        /// <summary>
        /// Way of adding new Measures
        /// </summary>
        public enum MeasureAddingRuleEnum
        {
            /// <summary>
            /// Measure is added automatically when new Barline is addes to Staff's Elements collection.
            /// </summary>
            AddMeasureOnInsertingBarline,
            /// <summary>
            /// Measures can be added only manually. This setting is used by MusicXml parsers.
            /// </summary>
            AddMeasuresManually
        }

        /// <summary>
        /// Retrieves a symbol that meats specific requirements and is relative to specific symbol. 
        /// </summary>
        /// <typeparam name="TSymbol">Type of symbol</typeparam>
        /// <param name="relativeTo"></param>
        /// <param name="peekType"></param>
        /// <returns></returns>
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

                case PeekType.PreviousElement:
                    strategy = new PreviousElementPeekStrategy<TSymbol>(this);
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

        public override string ToString()
        {
            if (Score == null || !Score.Staves.Contains(this)) string.Format("Staff (detached from score).");
            if (Part == null || !Part.Staves.Contains(this)) return string.Format("Staff ({0} in score).", UsefulMath.NumberToOrdinal(Score.Staves.IndexOf(this) + 1));
            return string.Format("Staff {0} of part {1} ({2} in score).", Part.Staves.IndexOf(this) + 1, Part.PartId, UsefulMath.NumberToOrdinal(Score.Staves.IndexOf(this) + 1));
        }

        internal void ApplyRules(MusicalSymbol item)
        {
            foreach (var rule in Rules.Where(r => r.Condition(this, item))) rule.Apply(this, item);
        }
    }
}