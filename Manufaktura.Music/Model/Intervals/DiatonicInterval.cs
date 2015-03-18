using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public class DiatonicInterval
    {
        public int Steps { get; protected set; }

        public DiatonicInterval(int steps)
        {
            Steps = steps;
        }

        public Interval ToInterval(int halftones)
        {
            return new Interval(this.Steps, halftones);
        }

        public DiatonicInterval MakeDescending()
        {
            return new DiatonicInterval(Math.Abs(Steps) * -1);
        }

        public DiatonicInterval MakeAscending()
        {
            return new DiatonicInterval(Math.Abs(Steps));
        }

        public static DiatonicInterval Unison { get { return new DiatonicInterval(1); } }
        public static DiatonicInterval Second { get { return new DiatonicInterval(2); } }
        public static DiatonicInterval Third { get { return new DiatonicInterval(3); } }
        public static DiatonicInterval Fourth { get { return new DiatonicInterval(4); } }
        public static DiatonicInterval Fifth { get { return new DiatonicInterval(5); } }
        public static DiatonicInterval Sixth { get { return new DiatonicInterval(6); } }
        public static DiatonicInterval Seventh { get { return new DiatonicInterval(7); } }
        public static DiatonicInterval Octave { get { return new DiatonicInterval(8); } }
    }
}
