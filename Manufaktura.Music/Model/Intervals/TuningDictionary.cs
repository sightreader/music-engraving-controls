using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model.Intervals
{
    public class TuningDictionary : Dictionary<BoundInterval, double>
    {
        public new double this[BoundInterval interval]
        {
            get
            {
                var bin = base.Keys.FirstOrDefault(bi => bi.StartingPitch == interval.StartingPitch && bi.EndingPitch == interval.EndingPitch);
                if (bin != null) return base[bin];
                var startingPitch = base.Keys.First().StartingPitch;
                var intervalToStartingPitch = base.Keys.FirstOrDefault(bi => NormalizePitch(bi.StartingPitch) == NormalizePitch(startingPitch) && NormalizePitch(bi.EndingPitch) == NormalizePitch(interval.StartingPitch));
                var intervalToEndingPitch = base.Keys.FirstOrDefault(bi => NormalizePitch(bi.StartingPitch) == NormalizePitch(startingPitch) && NormalizePitch(bi.EndingPitch) == NormalizePitch(interval.EndingPitch));
                base[interval] = base[intervalToEndingPitch] - base[intervalToStartingPitch];
                return base[interval];
            }
            set
            {
                base[interval] = value;
            }
        }

        private Pitch NormalizePitch(Pitch p)
        {
            return Pitch.FromStep(p.ToStep(), 4);
        }
    }
}
