using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{

    public class Interval : DiatonicInterval
    {
        public int Halftones { get; protected set; }

        public Interval(int steps, int halftones)
            : base(steps)
        {
            Halftones = halftones;
        }

        public new Interval MakeDescending()
        {
            return new Interval(Math.Abs(Steps) * -1, Math.Abs(Halftones) * -1);
        }

        public new Interval MakeAscending()
        {
            return new Interval(Math.Abs(Steps), Math.Abs(Halftones));
        }

        public static int HalfTone = 1;
        public static int WholeTone = 2;
        public static int Tritone = 6;

        public static Interval PerfectUnison { get { return new Interval(1, 0); } }
        public static Interval AugmentedUnison { get { return new Interval(1, HalfTone); ; } }
        public static Interval MinorSecond { get { return new Interval(2, HalfTone); } }
        public static Interval MajorSecond { get { return new Interval(2, WholeTone); } }
        public static Interval AugmentedSecond { get { return new Interval(2, 3); } }
        public static Interval DimnishedThird { get { return new Interval(3, 2); } }
        public static Interval MinorThird { get { return new Interval(3, 3); } }
        public static Interval MajorThird { get { return new Interval(3, 4); } }
        public static Interval AugmentedThird { get { return new Interval(3, 5); } }
        public static Interval DimnishedFourth { get { return new Interval(4, 4); } }
        public static Interval PerfectFourth { get { return new Interval(4, 5); } }
        public static Interval AugmentedFourth { get { return new Interval(4, Tritone); } }
        public static Interval DimnishedFifth { get { return new Interval(5, Tritone); } }
        public static Interval PerfectFifth { get { return new Interval(5, 7); } }
        public static Interval DimnishedSixth { get { return new Interval(6, 7); } }
        public static Interval AugmentedFifth { get { return new Interval(5, 8); } }
        public static Interval MinorSixth { get { return new Interval(6, 8); } }
        public static Interval MajorSixth { get { return new Interval(6, 9); } }
        public static Interval DimnishedSeventh { get { return new Interval(7, 9); } }
        public static Interval MinorSeventh { get { return new Interval(7, 10); } }
        public static Interval MajorSeventh { get { return new Interval(7, 11); } }
        public static Interval AugmentedSeventh { get { return new Interval(7, 12); } }
        public static Interval DimnishedOctave { get { return new Interval(8, 11); } }
        public static Interval PerfectOctave { get { return new Interval(8, 12); } }
    }
}
