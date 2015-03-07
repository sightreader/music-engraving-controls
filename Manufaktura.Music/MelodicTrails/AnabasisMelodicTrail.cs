using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MelodicTrails
{
    public class AnabasisMelodicTrail : RandomIntervalsMelodicTrail
    {
        private Dictionary<DiatonicInterval, double> allowedIntervals = new Dictionary<DiatonicInterval, double>
        {
            {DiatonicInterval.Second, 8},
            {DiatonicInterval.Third, 4},
            {DiatonicInterval.Second.MakeDescending(), 2},
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

        public AnabasisMelodicTrail(Pitch minPitch, Pitch maxPitch)
        {
            MinPitch = minPitch;
            MaxPitch = maxPitch;
        }
    }
}
