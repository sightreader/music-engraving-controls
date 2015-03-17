using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public struct Proportion
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public decimal DecimalValue
        {
            get
            {
                return (decimal)Numerator / (decimal)Denominator;
            }
        }
        public double DoubleValue
        {
            get
            {
                return (double)Numerator / (double)Denominator;
            }
        }
        public double Cents
        {
            get
            {
                return 1200 * Math.Log(DoubleValue, 2);
            }
        }

        public Proportion FractionalPart
        {
            get
            {
                var prop = new Proportion(Numerator, Denominator);
                while (prop.Numerator > prop.Denominator)
                {
                    prop.Numerator -= prop.Denominator;
                }
                return prop;
            }
        }

        public Proportion(int numerator, int denominator) : this()
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Proportion Normalize()
        {
            for (int i = Denominator; i > 1; i--)
            {
                if (Numerator % i == 0 && Denominator % i == 0) return new Proportion(Numerator / i, Denominator / i).Normalize();
            }
            return this;
        }

        public override string ToString()
        {
            return string.Format("{0} / {1}", Numerator, Denominator);
        }

        public static Proportion Dupla { get { return new Proportion(2, 1); } }
        public static Proportion Tripla { get { return new Proportion(3, 1); } }
        public static Proportion Quadrupla { get { return new Proportion(4, 1); } }
        public static Proportion Quintupla { get { return new Proportion(5, 1); } }
        public static Proportion Sesquialtera { get { return new Proportion(3, 2); } }
        public static Proportion Sesquitertia { get { return new Proportion(4, 3); } }
        public static Proportion Sesquiquarta { get { return new Proportion(5, 4); } }
        public static Proportion Sesquiquinta { get { return new Proportion(6, 5); } }
        public static Proportion Sesquisexta { get { return new Proportion(7, 6); } }
        public static Proportion Sesquiseptima { get { return new Proportion(8, 7); } }
        public static Proportion Sesquioctava { get { return new Proportion(9, 8); } }

        private static int GetCommonDenominator(Proportion d1, Proportion d2)
        {
            return d1.Denominator * d2.Denominator;
        }

        public static bool operator ==(Proportion p1, Proportion p2)
        {
            return p1.DecimalValue == p2.DecimalValue;
        }

        public static bool operator !=(Proportion p1, Proportion p2)
        {
            return p1.DecimalValue != p2.DecimalValue;
        }

        public static bool operator >(Proportion p1, Proportion p2)
        {
            if (p1.Denominator == p2.Denominator) return p1.Numerator > p2.Numerator;
            return p1.Numerator * p2.Denominator > p2.Numerator * p1.Denominator;
        }

        public static bool operator <(Proportion p1, Proportion p2)
        {
            if (p1.Denominator == p2.Denominator) return p1.Numerator < p2.Numerator;
            return p1.Numerator * p2.Denominator < p2.Numerator * p1.Denominator;
        }

        public static bool operator >=(Proportion p1, Proportion p2)
        {
            if (p1.Denominator == p2.Denominator) return p1.Numerator >= p2.Numerator;
            return p1.Numerator * p2.Denominator >= p2.Numerator * p1.Denominator;
        }

        public static bool operator <=(Proportion p1, Proportion p2)
        {
            if (p1.Denominator == p2.Denominator) return p1.Numerator <= p2.Numerator;
            return p1.Numerator * p2.Denominator <= p2.Numerator * p1.Denominator;
        }

        public static bool operator ==(Proportion p1, decimal d)
        {
            return p1.DecimalValue == d;
        }

        public static bool operator !=(Proportion p1, decimal d)
        {
            return p1.DecimalValue != d;
        }

        public static bool operator ==(Proportion p1, double d)
        {
            return p1.DoubleValue == d;
        }

        public static bool operator !=(Proportion p1, double d)
        {
            return p1.DoubleValue != d;
        }

        public static bool operator ==(Proportion p1, int i)
        {
            return p1.DoubleValue == i;
        }

        public static bool operator !=(Proportion p1, int i)
        {
            return p1.DoubleValue != i;
        }

        public static Proportion operator *(Proportion p1, Proportion p2)
        {
            return new Proportion(p1.Numerator * p2.Numerator, p1.Denominator * p2.Denominator).Normalize();
        }

        public static decimal operator *(Proportion p1, decimal d2)
        {
            return p1.DecimalValue * d2;
        }

        public static double operator *(Proportion p1, double d2)
        {
            return p1.DoubleValue * d2;
        }

        public static Proportion operator *(Proportion p1, int d2)
        {
            return new Proportion(p1.Numerator * d2, p1.Denominator).Normalize();
        }

        public static Proportion operator /(Proportion p1, int d2)
        {
            return new Proportion(p1.Numerator, p1.Denominator * d2).Normalize();
        }

        public static Proportion operator +(Proportion d1, Proportion d2)
        {
            if (d1.Denominator == d2.Denominator) return new Proportion(d1.Numerator + d2.Numerator, d1.Denominator);
            var commonDenominator = GetCommonDenominator(d1, d2);
            var numeratorSum = d1.Numerator * d2.Denominator + d2.Numerator * d1.Denominator;
            return new Proportion(numeratorSum, commonDenominator).Normalize();
        }

        public static Proportion operator -(Proportion d1, Proportion d2)
        {
            if (d1.Denominator == d2.Denominator) return new Proportion(d1.Numerator - d2.Numerator, d1.Denominator);
            var commonDenominator = GetCommonDenominator(d1, d2);
            var numeratorSum = d1.Numerator * d2.Denominator - d2.Numerator * d1.Denominator;
            return new Proportion(numeratorSum, commonDenominator).Normalize();
        }

        public static Proportion GetApproximatedProportionFromCents(double cents, int precision = 6)
        {
            if (precision < 1 || precision > 20)
                throw new ArgumentException("Precision must be between 1 and 20.", "precision");

            var decimalValue = UsefulMath.CentsToProportion(cents);
            var normalizedValue = decimalValue;
            var denominator = 1;
            var maxDenominator = Math.Pow(10, precision);
            while (normalizedValue % 10 != 0 && denominator <= maxDenominator)
            {
                denominator *= 10;
                normalizedValue *= 10;
            }
            return new Proportion((int)normalizedValue, denominator).Normalize();
        }
    }
}
