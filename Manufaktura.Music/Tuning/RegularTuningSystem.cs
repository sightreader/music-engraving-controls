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
        public Pitch StartingPitch { get; protected set; }

        /// <summary>
        /// Returns a comma between last interval and perfect octave (a Pythagorean Comma in Pythagorean Tuning).
        /// </summary>
        public double CommaBetweenLastIntervalAndPerfectOctave
        {
            get;
            protected set;
        }

        protected RegularTuningSystem(Pitch startingPitch)
        {
            StartingPitch = startingPitch;
            AllIntervalRatios = new Dictionary<BoundInterval, double>();
            GenerateIntervals();
        }

        private void GenerateIntervals()
        {
            var intervals = new List<double>();

            var currentProportion = new Proportion(1, 1);
            var currentPitch = StartingPitch;
            var endPitch = StartingPitch.OctaveUp();
            do
            {
                currentProportion = (currentProportion * Generator.IntervalProportion).Normalize();
                currentPitch = currentPitch.Translate(Generator.Interval, Pitch.MidiPitchTranslationMode.Auto);
                while (currentProportion > Proportion.Dupla)
                {
                    currentProportion /= 2;
                    currentPitch = currentPitch.OctaveDown();
                }
                AllIntervalRatios[new BoundInterval(StartingPitch, currentPitch)] = currentProportion.Cents;
                intervals.Add(currentProportion.Cents);
            }
            while (Math.Abs(currentPitch.MidiPitch - endPitch.MidiPitch) % 12 != 0);
            CommaBetweenLastIntervalAndPerfectOctave = intervals.Last();
        }


        public override IEnumerable<double> TuneScale(Scale scale)
        {
            throw new NotImplementedException();
        }
    }
}
