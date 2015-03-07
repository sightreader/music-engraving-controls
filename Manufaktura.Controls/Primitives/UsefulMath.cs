﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Manufaktura.Controls.Primitives
{
    public static class UsefulMath
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
            if (double.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out result)) return result;
            return null;
        }

        public static double GradToRadians(double angle)
        {
            return angle * (Math.PI / 180d);
        }

        public static string NumberToOrdinal(int number)
        {
            if (number == 1) return "1st";
            if (number == 2) return "2nd";
            if (number == 3) return "3rd";
            if (number > 3) return number + "th";
            else return number.ToString();
        }
    }
}
