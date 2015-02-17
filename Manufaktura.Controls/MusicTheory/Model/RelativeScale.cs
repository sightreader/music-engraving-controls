using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.MusicTheory.Model
{
    public abstract class RelativeScale
    {
        public abstract IEnumerable<int> Intervals { get; }
    }
}
