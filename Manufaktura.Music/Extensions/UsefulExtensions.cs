using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Extensions
{
    public static class UsefulExtensions
    {
        public static string ToStringInvariant(this double d)
        {
            return d.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this long l)
        {
            return l.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this int i)
        {
            return i.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this byte b)
        {
            return b.ToString(CultureInfo.InvariantCulture);
        }
    }
}
