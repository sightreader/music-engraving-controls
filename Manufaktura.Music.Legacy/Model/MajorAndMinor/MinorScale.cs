using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model.MajorAndMinor
{
    public class MinorScale : MajorOrMinorScale
    {
        public MinorScale(Step step, bool isFlat) : base(step, isFlat ? MajorAndMinorScaleFlags.MinorFlat : MajorAndMinorScaleFlags.MinorSharp)
        {
        }
    }
}
