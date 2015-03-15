using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Tuning
{
    /// <summary>
    /// Base class for creating tunings based on various algorithms. In algorithmic tunings
    /// octaves can be imperfect and interval ratios may vary in different keys.
    /// </summary>
    public abstract class AlgorithmicTuningSystem : TuningSystem
    {
    }
}
