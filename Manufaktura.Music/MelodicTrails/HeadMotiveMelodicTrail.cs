using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MelodicTrails
{
    public class HeadMotiveMelodicTrail : RandomIntervalsMelodicTrail
    {
        private Dictionary<IntervalBase, double> allowedIntervals = new Dictionary<IntervalBase, double>
        {
            {IntervalBase.Fifth, 10},
            {IntervalBase.Fourth, 10},
            {IntervalBase.Octave, 5},
            {IntervalBase.Sixth, 3},
            {IntervalBase.Third, 3},
            {IntervalBase.Fifth.MakeDescending(), 10},
            {IntervalBase.Fourth.MakeDescending(), 10},
            {IntervalBase.Octave.MakeDescending(), 5},
            {IntervalBase.Sixth.MakeDescending(), 3},
            {IntervalBase.Third.MakeDescending(), 3}
        };

        public override Dictionary<IntervalBase, double> AllowedIntervals
        {
            get { return allowedIntervals; }
        }

        public override int MinNotes
        {
            get { return 2; }
        }

        public override int MaxNotes
        {
            get { return 5; }
        }

        public HeadMotiveMelodicTrail(Pitch minPitch, Pitch maxPitch)
        {
            MinPitch = minPitch;
            MaxPitch = maxPitch;
        }

        protected override IntervalBase OnAmbitusExceeded(IntervalBase generatedInterval, Pitch generatedPitch)
        {
            if (generatedPitch > MaxPitch) generatedInterval = generatedInterval.MakeDescending();
            if (generatedPitch < MinPitch) generatedInterval = generatedInterval.MakeAscending();
            return generatedInterval;
        }
    }
}
