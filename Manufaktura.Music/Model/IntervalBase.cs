using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public class IntervalBase
    {
        public int Steps { get; protected set; }

        public IntervalBase(int steps)
        {
            Steps = steps;
        }

        public Interval ToInterval(int halftones)
        {
            return new Interval(this.Steps, halftones);
        } 

        public static IntervalBase Unison { get { return new IntervalBase(1); } }
        public static IntervalBase Second { get { return new IntervalBase(2); } }
        public static IntervalBase Third { get { return new IntervalBase(3); } }
        public static IntervalBase Fourth { get { return new IntervalBase(4); } }
        public static IntervalBase Fifth { get { return new IntervalBase(5); } }
        public static IntervalBase Sixth { get { return new IntervalBase(6); } }
        public static IntervalBase Seventh { get { return new IntervalBase(7); } }
        public static IntervalBase Octave { get { return new IntervalBase(8); } }
    }
}
