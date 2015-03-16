using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Tuning
{
    public abstract class TuningSystem
    {
        public abstract Dictionary<Interval, double> Build(Pitch startingPitch);
    }
}
