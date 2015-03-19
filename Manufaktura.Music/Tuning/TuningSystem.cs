using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Tuning
{
    public abstract class TuningSystem
    {
        public abstract IEnumerable<double> TuneScale(Scale scale);

        //TODO: Zamienić na jakieś IntervalDictionary czy coś, żeby dynamicznie liczyło każdy możliwy interwał
        public Dictionary<BoundInterval, double> AllIntervalRatios { get; protected set; }
    }
}
