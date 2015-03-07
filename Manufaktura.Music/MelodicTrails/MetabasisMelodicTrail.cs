using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MelodicTrails
{
    public class MetabasisMelodicTrail : RandomIntervalsMelodicTrail
    {
        private Dictionary<DiatonicInterval, double> allowedIntervals = new Dictionary<DiatonicInterval, double>
        {
            {DiatonicInterval.Second, 1},
            {DiatonicInterval.Third, 1},
            {DiatonicInterval.Second.MakeDescending(), 1},
            {DiatonicInterval.Third.MakeDescending(), 1}
        };

        public override Dictionary<Model.DiatonicInterval, double> AllowedIntervals
        {
            get { return allowedIntervals; }
        }

        public MetabasisMelodicTrail(Pitch minPitch, Pitch maxPitch, int minNotes, int maxNotes)
            :base (minPitch, maxPitch, minNotes, maxNotes)
        {
        }
    }
}
