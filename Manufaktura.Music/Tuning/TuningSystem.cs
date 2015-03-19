using Manufaktura.Music.Model;
using Manufaktura.Music.Model.Intervals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Tuning
{
    public abstract class TuningSystem
    {
        public abstract IEnumerable<double> TuneScale(Scale scale);

        public TuningDictionary AllIntervalRatios { get; protected set; }
    }
}
