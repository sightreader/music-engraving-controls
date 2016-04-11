using Manufaktura.Music.Model;
using Manufaktura.Music.Model.Intervals;
using System.Collections.Generic;

namespace Manufaktura.Music.Tuning
{
    /// <summary>
    /// Base class for representing a tuning system.
    /// </summary>
    public abstract class TuningSystem
    {
        public TuningDictionary AllIntervalRatios { get; protected set; }

        public abstract IEnumerable<double> TuneScale(Scale scale);
    }
}