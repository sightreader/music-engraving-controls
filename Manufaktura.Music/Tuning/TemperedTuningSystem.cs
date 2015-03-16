using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Tuning
{
    /// <summary>
    /// Base class for creating tempered tunings. In tempered tunings octave is divided
    /// logarythmically. Every octave is perfect (with ratio 2:1) but interval ratios may vary in different keys.
    /// </summary>
    public abstract class TemperedTuningSystem : TuningSystem
    {
    }
}
