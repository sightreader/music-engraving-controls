using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model 
{

    public static class Interval
    {
        public static int Unison { get { return 0; } }
        public static int AugmentedUnison { get { return 1; } }
        public static int MinorSecond { get { return 1; } }
        public static int HalfTone { get { return 1; } }
        public static int MajorSecond { get { return 2; } }
        public static int WholeTone { get { return 2; } }
        public static int DimnishedThird { get { return 2; } }
        public static int MinorThird { get { return 3; } }
        public static int MajorThird { get { return 4; } }
        public static int AugmentedThird { get { return 5; } }
        public static int PerfectFourth { get { return 5; } }
        public static int Tritone { get { return 6; } }
        public static int AugmentedFourth { get { return 6; } }
        public static int DimnishedFifth { get { return 6; } }
        public static int PerfectFifth { get { return 7; } }
        public static int DimnishedSixth { get { return 7; } }
        public static int AugmentedFifth { get { return 8; } }
        public static int MinorSixth { get { return 8; } }
        public static int MajorSixth { get { return 9; } }
        public static int DimnishedSeventh { get { return 9; } }
        public static int MinorSeventh { get { return 10; } }
        public static int MajorSeventh { get { return 11; } }
        public static int DimnishedOctave { get { return 11; } }
        public static int Octave { get { return 12; } }
    }
}
