using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model.MajorAndMinor
{
    public class MajorScale : MajorOrMinorScale
    {
        public MajorScale(Step step, bool isFlat) : base(step, false, isFlat)
        {
        }
    }
}
