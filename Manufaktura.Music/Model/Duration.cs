using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public class Duration
    {
        public int Denominator { get; private set; }
        public int Dots { get; private set; }

        protected Duration(int denominator, int dots)
        {
            Denominator = denominator;
        }

        protected Duration(int denominator)
            : this(denominator, 0)
        {
        }

        public TimeSpan ToTimeSpan(Tempo tempo)
        {
            var proportion = this.ToFractionOf(tempo.BeatUnit);
            return TimeSpan.FromMilliseconds(tempo.BeatTimeSpan.Milliseconds * proportion.DoubleValue);
        }

        public Proportion ToFractionOf(Duration duration)
        {
            return new Proportion(duration.Denominator, Denominator);
        }

        public Proportion ToProportion()
        {
            return new Proportion(1, Denominator);
        }

        public double ToDouble()
        {
            return ToProportion().DoubleValue;
        }

        public decimal ToDecimal()
        {
            return ToProportion().DecimalValue;
        }

        public Duration WithoutDots()
        {
            return new Duration(Denominator);
        }

        public static bool operator== (Duration d1, Duration d2) 
        {
            return d1.Denominator == d2.Denominator && d1.Dots == d2.Dots;
        }

        public static bool operator!= (Duration d1, Duration d2) 
        {
            return d1.Denominator != d2.Denominator || d1.Dots != d2.Dots;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            var sum = d1.ToProportion() + d2.ToProportion();
            sum = sum.Normalize();
            return new Duration(sum.Denominator);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            var sum = d1.ToProportion() - d2.ToProportion();
            sum = sum.Normalize();
            return new Duration(sum.Denominator);
        }

        public static Duration Whole { get { return new Duration(1); } }
        public static Duration Half { get { return new Duration(2); } }
        public static Duration Quarter { get { return new Duration(4); } }
        public static Duration Eighth { get { return new Duration(8); } }
        public static Duration Sixteenth { get { return new Duration(16); } }
        public static Duration D32th { get { return new Duration(32); } }
        public static Duration D64th { get { return new Duration(64); } }
        public static Duration D128th { get { return new Duration(128); } }
        public static Duration D256th { get { return new Duration(256); } }
    }
}
