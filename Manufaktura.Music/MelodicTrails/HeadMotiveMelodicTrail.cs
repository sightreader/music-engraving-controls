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
            {IntervalBase.Sixth, 5}
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
    }
}
