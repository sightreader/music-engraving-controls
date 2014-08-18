using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Primitives
{
    public class UsefulMath
    {
        public static decimal Mean(params int[] values)
        {
            if (values == null) throw new ArgumentNullException("values");
            return (decimal)values.Sum(v => v) / values.Count();
        }

        public static decimal Median(params int[] values)
        {
            if (values == null) throw new ArgumentNullException("values");

            int valuesCount = values.Count();
            if (valuesCount == 0) return 0;
            if (valuesCount == 1) return values.First();
            var sortedValues = values.OrderBy(v => v);
            int midIndex = valuesCount / 2;
            if (valuesCount % 2 == 0)
            {
                return Mean(values[midIndex - 1], values[midIndex]);
            }
            else
            {
                return values[midIndex];
            }

        }
    }
}
