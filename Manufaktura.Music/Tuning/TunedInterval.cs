using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Tuning
{
    public struct TunedInterval
    {
        public Interval Interval { get; private set; }
        public Proportion IntervalProportion { get; private set; }

        public TunedInterval(Interval interval, Proportion proportion) : this()
        {
            Interval = interval;
            IntervalProportion = proportion;
        }
    }
}
