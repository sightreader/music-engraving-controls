using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Tuning
{
    public class PythagoreanTuning : RegularTuningSystem
    {
        public override TunedInterval GetGenerator(int tuningIteration)
        {
            return new TunedInterval(Interval.PerfectFifth, Proportion.Sesquialtera);
        }

        public PythagoreanTuning(Pitch startingPitch)
            : base(startingPitch)
        {

        }
    }
}
