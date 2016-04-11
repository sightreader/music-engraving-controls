using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Tuning
{
    public class TertianTuning : RegularTuningSystem
    {
        
        public TertianTuning(Pitch startingPitch) : base(startingPitch)
        {

        }

        public override TunedInterval GetGenerator(int tuningIteration)
        {
            return tuningIteration < 2 ? 
                new TunedInterval(Interval.PerfectFifth, Proportion.Sesquialtera) :
                new TunedInterval(Interval.MajorThird, Proportion.Sesquiquarta);
        }

        protected override void GenerateIntervals()
        {
            AllIntervalRatios[new BoundInterval(StartingPitch, Step.F.ToPitch(StartingPitch.Octave))] = Proportion.Sesquitertia.Cents;
            base.GenerateIntervals();
        }
    }
}
