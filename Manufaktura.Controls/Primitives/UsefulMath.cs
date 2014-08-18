using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Primitives
{
    public class UsefulMath
    {
        public static double Mean(params double[] values) 
        {
            if (values == null) throw new ArgumentNullException("values");
            return (double)values.Sum(t => t) / values.Count();
        }

        public static double Median(params double[] values)
        {
            if (values == null) throw new ArgumentNullException("values");

            int valuesCount = values.Count();
            if (valuesCount == 0) return default(double);
            if (valuesCount == 1) return values.First();
            var sortedValues = values.OrderBy(v => v).ToArray();
            int midIndex = valuesCount / 2;
            if (valuesCount % 2 == 0)
            {
                return Mean(sortedValues[midIndex - 1], sortedValues[midIndex]);
            }
            else
            {
                return sortedValues[midIndex];
            }

        }

        public static double? TryParse(string s)
        {
            double result;
            if (double.TryParse(s, out result)) return result;
            return null;
        }
    }
}
