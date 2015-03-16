using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Tuning
{
    public class PythagoreanTuning : RegularTuningSystem
    {
        public override TunedInterval Generator
        {
            get { return new TunedInterval(Interval.PerfectFifth, Proportion.Sesquialtera); }
        }
    }
}
