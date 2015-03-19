using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Tuning
{
    /// <summary>
    /// Base class for creating tunings based on various algorithms. In algorithmic tunings
    /// octaves can be imperfect and interval ratios may vary in different keys.
    /// </summary>
    public abstract class RegularTuningSystem : TuningSystem
    {
        public abstract TunedInterval Generator { get; }
        public abstract int GeneratorPassesToFormOctave { get; }
        public double[] AllIntervalRatios {get; protected set;}

        /// <summary>
        /// Returns a comma between last interval and perfect octave (a Pythagorean Comma in Pythagorean Tuning).
        /// </summary>
        public double CommaBetweenLastIntervalAndPerfectOctave
        {
            get;
            protected set;
        }

        //TODO: Zrobić jednak w konstruktorze Step i budować od tego stopnia. 
        //TODO: Słownik <Step, Step, double> z interwałami od konkretnych stopni.
        protected RegularTuningSystem()
        {
            AllIntervalRatios = GenerateIntervals(GeneratorPassesToFormOctave);
        }

        private double[] GenerateIntervals(int iterations)
        {
            var intervals = new List<double>();

            var currentProportion = new Proportion(1, 1);
            for (int i = 0; i < iterations; i++)
            {
                currentProportion = (currentProportion * Generator.IntervalProportion).Normalize();
                while (currentProportion > Proportion.Dupla) currentProportion /= 2;
                intervals.Add(currentProportion.Cents);
            }
            CommaBetweenLastIntervalAndPerfectOctave = intervals.Last();
            return intervals.Except(new [] {intervals.Last()}).OrderBy(d => d).ToArray();
        }


        public override IEnumerable<double> TuneScale(Scale scale)
        {
            throw new NotImplementedException();
        }
    }
}
