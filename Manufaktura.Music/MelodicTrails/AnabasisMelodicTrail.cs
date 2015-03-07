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

        public AnabasisMelodicTrail(Pitch minPitch, Pitch maxPitch, int minNotes, int maxNotes)
            : base(minPitch, maxPitch, minNotes, maxNotes)
        {

        }
    }
}
