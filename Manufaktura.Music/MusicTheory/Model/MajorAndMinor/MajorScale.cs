using Manufaktura.Controls.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model.MajorAndMinor
{
    public class MajorScale : MajorOrMinorScale
    {
        public MajorScale(Step step, bool isFlat) : base(step, false, isFlat)
        {
        }
    }
}
