using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model.MajorAndMinor
{
    public class MinorMode : Mode
    {
        public override IEnumerable<int> Intervals
        {
            get { return new[] { 2, 1, 2, 2, 1, 2, 2 }; }
        }

        public override IEnumerable<Rules.MusicalRule> Rules
        {
            get { throw new NotImplementedException(); }
        }
    }
}
