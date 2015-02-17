using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.MusicTheory.Model
{
    public class PentatonicScale : RelativeScale
    {
        public override IEnumerable<int> Intervals
        {
            get { return new[] { 2, 2, 1, 2, 2 }; }
        }
    }
}
