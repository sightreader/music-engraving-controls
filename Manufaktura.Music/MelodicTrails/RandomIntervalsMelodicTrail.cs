﻿using Manufaktura.Music.Model;
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
        public abstract Dictionary<IntervalBase, double> AllowedIntervals { get; }

        public abstract int MinNotes { get; }

        public abstract int MaxNotes { get; }

        public IEnumerable<Pitch> BuildMelody(Scale scale, Pitch startingPitch)
        {
            if (MinNotes < 1) throw new ArgumentException("MinNotes must be greater than 0.", "MinNotes");
            if (MinNotes > MaxNotes) throw new ArgumentException("MinNotes must not be greater than MaxNotes.", "MinNotes");

            var randomGenerator = new Random((int)DateTime.Now.Ticks);
            var numberOfNotes = randomGenerator.Next(MinNotes, MaxNotes);

            var sumOfWeights = AllowedIntervals.Sum(ai => ai.Value);
            var sortedIntervals = AllowedIntervals.OrderBy(ai => ai.Value).ToList();
            var newSortedIntervals = new List<KeyValuePair<IntervalBase, double>>();
            double previousValues = 0;
            foreach (var kvp in sortedIntervals)
            {
                newSortedIntervals.Add(new KeyValuePair<IntervalBase, double>(kvp.Key, kvp.Value + previousValues));
                previousValues += kvp.Value;
            }
            sortedIntervals = newSortedIntervals;

            var melody = new List<Pitch> { startingPitch };
            for (var i = 1; i < numberOfNotes; i++)
            {
                var randomNumber = randomGenerator.NextDouble() * sumOfWeights;
                var interval = sortedIntervals.Where(ai => (double)ai.Value >= randomNumber).First().Key;
                melody.Add(scale.TranslatePitch(melody.Last(), interval));
            }
            return melody;
        }
    }
}
