using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model.MajorAndMinor
{
    public struct MajorAndMinorScaleFlags
    {
        public bool IsMinor { get; set; }   //TODO: Zamienić na enumy Major,Minor / Flat, Sharp
        public bool IsFlat { get; set; }

        private MajorAndMinorScaleFlags(bool isMinor, bool isFlat) : this()
        {
            IsMinor = isMinor;
            IsFlat = isFlat;
        }

        public static MajorAndMinorScaleFlags MajorSharp { get { return new MajorAndMinorScaleFlags(false, false); } }
        public static MajorAndMinorScaleFlags MajorFlat { get { return new MajorAndMinorScaleFlags(false, true); } }
        public static MajorAndMinorScaleFlags MinorSharp { get { return new MajorAndMinorScaleFlags(true, true); } }
        public static MajorAndMinorScaleFlags MinorFlat { get { return new MajorAndMinorScaleFlags(true, true); } }
    }
}
