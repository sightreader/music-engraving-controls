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

        public override int MinNotes
        {
            get { return 6; }
        }

        public override int MaxNotes
        {
            get { return 12; }
        }

        public MetabasisMelodicTrail(Pitch minPitch, Pitch maxPitch)
        {
            MinPitch = minPitch;
            MaxPitch = maxPitch;
        }
    }
}
