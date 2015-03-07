using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MelodicTrails
{
    public class HeadMotiveMelodicTrail : RandomIntervalsMelodicTrail
    {
        private Dictionary<DiatonicInterval, double> allowedIntervals = new Dictionary<DiatonicInterval, double>
        {
            {DiatonicInterval.Fifth, 10},
            {DiatonicInterval.Fourth, 10},
            {DiatonicInterval.Octave, 5},
            {DiatonicInterval.Sixth, 3},
            {DiatonicInterval.Third, 3},
            {DiatonicInterval.Fifth.MakeDescending(), 10},
            {DiatonicInterval.Fourth.MakeDescending(), 10},
            {DiatonicInterval.Octave.MakeDescending(), 5},
            {DiatonicInterval.Sixth.MakeDescending(), 3},
            {DiatonicInterval.Third.MakeDescending(), 3}
        };

        public override Dictionary<DiatonicInterval, double> AllowedIntervals
        {
            get { return allowedIntervals; }
        }

        public HeadMotiveMelodicTrail(Pitch minPitch, Pitch maxPitch, int minNotes, int maxNotes)
            : base(minPitch, maxPitch, minNotes, maxNotes)
        {
        }

        protected override DiatonicInterval OnAmbitusExceeded(DiatonicInterval generatedInterval, Pitch generatedPitch)
        {
            if (generatedPitch > MaxPitch) generatedInterval = generatedInterval.MakeDescending();
            if (generatedPitch < MinPitch) generatedInterval = generatedInterval.MakeAscending();
            return generatedInterval;
        }
    }
}
