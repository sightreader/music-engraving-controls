using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public class Proportion
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

        public Proportion(int numerator, int denominator)
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

        public static Proportion Dupla { get { return new Proportion(2, 1); } }
        public static Proportion Tripla { get { return new Proportion(3, 1); } }
        public static Proportion Sesquialtera { get { return new Proportion(3, 2); } }
        public static Proportion Sesquitertia { get { return new Proportion(4, 3); } }
        public static Proportion Sesquiquarta { get { return new Proportion(5, 4); } }
        public static Proportion Sesquiquinta { get { return new Proportion(6, 5); } }
        public static Proportion Sesquisexta { get { return new Proportion(7, 6); } }
        public static Proportion Sesquiseptima { get { return new Proportion(8, 7); } }
        public static Proportion Sesquioctava { get { return new Proportion(9, 8); } }

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
    }
}
