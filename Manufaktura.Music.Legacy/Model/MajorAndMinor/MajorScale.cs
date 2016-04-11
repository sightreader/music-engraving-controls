using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model.MajorAndMinor
{
    public class MajorScale : MajorOrMinorScale
    {
        public MajorScale(Step step, bool isFlat) : base(step, isFlat ? MajorAndMinorScaleFlags.MajorFlat : MajorAndMinorScaleFlags.MajorSharp)
        {
        }

        public static MajorScale C
        {
            get { return new MajorScale(Step.C, false); }
        }

        public static MajorScale D
        {
            get { return new MajorScale(Step.D, false); }
        }

        public static MajorScale E
        {
            get { return new MajorScale(Step.E, false); }
        }

        public static MajorScale F
        {
            get { return new MajorScale(Step.F, true); }
        }

        public static MajorScale G
        {
            get { return new MajorScale(Step.G, false); }
        }

        public static MajorScale A
        {
            get { return new MajorScale(Step.A, false); }
        }

        public static MajorScale B
        {
            get { return new MajorScale(Step.B, false); }
        }

        public static MajorScale Bb
        {
            get { return new MajorScale(Step.Bb, true); }
        }
    }
}
