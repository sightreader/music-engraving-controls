using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MelodicTrails
{
    public class ConjunctMovementTrail : RandomIntervalsMelodicTrail
    {
        private MovementType movementType;
        private Dictionary<DiatonicInterval, double> allowedIntervals;

        public override Dictionary<Model.DiatonicInterval, double> AllowedIntervals
        {
            get { return allowedIntervals; }
        }

        public ConjunctMovementTrail(MovementType movementType, Pitch minPitch, Pitch maxPitch, int minNotes, int maxNotes)
            : base(minPitch, maxPitch, minNotes, maxNotes)
        {
            this.movementType = movementType;
            switch (movementType)
            {
                case MovementType.Anabasis:
                    allowedIntervals = new Dictionary<DiatonicInterval, double>
                    {
                        {DiatonicInterval.Second, 16},
                        {DiatonicInterval.Third, 8},
                        {DiatonicInterval.Second.MakeDescending(), 2},
                        {DiatonicInterval.Third.MakeDescending(), 1}
                    };
                    break;
                case MovementType.Katabasis:
                    allowedIntervals = new Dictionary<DiatonicInterval, double>
                    {
                        {DiatonicInterval.Second, 2},
                        {DiatonicInterval.Third, 1},
                        {DiatonicInterval.Second.MakeDescending(), 16},
                        {DiatonicInterval.Third.MakeDescending(), 8}
                    };
                    break;
                case MovementType.Metabasis:
                    allowedIntervals = new Dictionary<DiatonicInterval, double>
                    {
                        {DiatonicInterval.Second, 1},
                        {DiatonicInterval.Third, 1},
                        {DiatonicInterval.Second.MakeDescending(), 1},
                        {DiatonicInterval.Third.MakeDescending(), 1}
                    };
                    break;
                default:
                    throw new NotImplementedException("Unsupported movement type.");
            }
        }
    }
}
