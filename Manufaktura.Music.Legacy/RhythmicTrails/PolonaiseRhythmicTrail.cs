using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.RhythmicTrails
{
    public class PolonaiseRhythmicTrail : LimitedPatternsRhythmicTrail
    {
        public override Proportion TimeSignature
        {
            get { return new Proportion(3, 4); }
        }

        public override RhythmicUnit[][] RhythmicPatterns
        {
            get 
            { 
                return new[] { RhythmicUnit.Parse(8, 16, 16, 8, 8, 8, 8).ToArray(), 
                               RhythmicUnit.Parse(8, 8, 8, 8, 8, 8).ToArray()};
            }
        }
    }
}
