using Manufaktura.Controls.Model;
using Manufaktura.Music.MusicTheory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Generators
{
    public class RandomMelodyGenerator
    {
        public Scale Scale { get; set; }

        public Score Generate()
        {
            var score = new Score();
            var staff = new Staff();
            score.Staves.Add(staff);

            foreach (var interval in Scale.Mode.Intervals)
            {

            }

            return score;
        }
    }
}
