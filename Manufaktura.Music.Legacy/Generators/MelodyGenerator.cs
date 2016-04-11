using Manufaktura.Music.Model;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Generators
{
    public class MelodyGenerator
    {
        public Scale Scale { get; set; }

        public IEnumerable<Pitch> Generate()
        {

            foreach (var interval in Scale.Mode.Intervals)
            {

            }

            return null;
        }
    }
}
