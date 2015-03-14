using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.RhythmicTrails
{
    public abstract class LimitedPatternsRhythmicTrail : IRhythmicTrail
    {
        public abstract Proportion TimeSignature
        {
            get;
        }
        public abstract RhythmicUnit[][] RhythmicPatterns { get; }

        public IEnumerable<RhythmicUnit> BuildRhythm(int measures)
        {
            List<RhythmicUnit> result = new List<RhythmicUnit>();
            var randomGenerator = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < measures; i++)
            {
                var index = randomGenerator.Next(0, RhythmicPatterns.Length);
                result.AddRange(RhythmicPatterns[index]);
            }
            return result;
        }
    }
}
