using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    [Obsolete("Alpha version. Don't use it. :)")]
    public class PentatonicMode : Mode
    {
        public override IEnumerable<int> Intervals
        {
            get { return new[] { 3, 2, 2, 3 }; }
        }

    }
}
