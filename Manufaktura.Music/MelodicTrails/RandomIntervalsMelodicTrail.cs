using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MelodicTrails
{
    /// <summary>
    /// This class builds melodic trails by randomizing intervals
    /// </summary>
    public abstract class RandomIntervalsMelodicTrail : IMelodicTrail
    {
        /// <summary>
        /// Allowed intervals with weights
        /// </summary>
        public abstract Dictionary<DiatonicInterval, double> AllowedIntervals { get; }

        public int MinNotes { get; set; }
        public int MaxNotes { get; set; }
        public Pitch MaxPitch { get; set; }
        public Pitch MinPitch { get; set; }

        protected RandomIntervalsMelodicTrail()
        {
            MinPitch = Pitch.FromMidiPitch(0, Pitch.MidiPitchTranslationMode.Auto);
            MaxPitch = Pitch.FromMidiPitch(int.MaxValue, Pitch.MidiPitchTranslationMode.Auto);
            MinNotes = 2;
            MaxNotes = 10;
        }

        protected RandomIntervalsMelodicTrail(Pitch minPitch, Pitch maxPitch, int minNotes, int maxNotes)
        {
            MinPitch = minPitch;
            MaxPitch = maxPitch;
            MinNotes = minNotes;
            MaxNotes = maxNotes;
        }

        protected virtual DiatonicInterval OnAmbitusExceeded(DiatonicInterval generatedInterval, Pitch generatedPitch)
        {
            return generatedInterval;
        }

        public IEnumerable<Pitch> BuildMelody(Scale scale, Pitch startingPitch)
        {
            if (MinNotes < 1) throw new ArgumentException("MinNotes must be greater than 0.", "MinNotes");
            if (MinNotes > MaxNotes) throw new ArgumentException("MinNotes must not be greater than MaxNotes.", "MinNotes");

            var randomGenerator = new Random((int)DateTime.Now.Ticks);
            var numberOfNotes = randomGenerator.Next(MinNotes, MaxNotes);

            var sumOfWeights = AllowedIntervals.Sum(ai => ai.Value);
            var sortedIntervals = AllowedIntervals.OrderBy(ai => ai.Value).ToList();
            var newSortedIntervals = new List<KeyValuePair<DiatonicInterval, double>>();
            double previousValues = 0;
            foreach (var kvp in sortedIntervals)
            {
                newSortedIntervals.Add(new KeyValuePair<DiatonicInterval, double>(kvp.Key, kvp.Value + previousValues));
                previousValues += kvp.Value;
            }
            sortedIntervals = newSortedIntervals;

            var melody = new List<Pitch> { startingPitch };
            for (var i = 1; i < numberOfNotes; i++)
            {
                var randomNumber = randomGenerator.NextDouble() * sumOfWeights;
                var interval = sortedIntervals.Where(ai => ai.Value >= randomNumber).First().Key;
                var newPitch = scale.TranslatePitch(melody.Last(), interval);
                if (newPitch > MaxPitch || newPitch < MinPitch)
                {
                    interval = OnAmbitusExceeded(interval, newPitch);
                    newPitch = scale.TranslatePitch(melody.Last(), interval);
                }
                melody.Add(newPitch);
            }
            return melody;
        }
    }
}
