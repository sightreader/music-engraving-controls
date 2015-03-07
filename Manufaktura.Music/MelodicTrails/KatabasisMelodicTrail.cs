using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MelodicTrails
{
    public class KatabasisMelodicTrail : RandomIntervalsMelodicTrail
    {
        private Dictionary<DiatonicInterval, double> allowedIntervals = new Dictionary<DiatonicInterval, double>
        {
            {DiatonicInterval.Second, 2},
            {DiatonicInterval.Third, 1},
            {DiatonicInterval.Second.MakeDescending(), 8},
            {DiatonicInterval.Third.MakeDescending(), 4}
        };

        public override Dictionary<Model.DiatonicInterval, double> AllowedIntervals
        {
            get { return allowedIntervals; }
        }

        public override int MinNotes
        {
            get { return 6; }
        }

        public override int MaxNotes
        {
            get { return 12; }
        }

        public KatabasisMelodicTrail(Pitch minPitch, Pitch maxPitch)
        {
            MinPitch = minPitch;
            MaxPitch = maxPitch;
        }
    }
}
