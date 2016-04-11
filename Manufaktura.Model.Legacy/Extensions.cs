using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Manufaktura.Model
{
    public static class Extensions
    {
        public static IEnumerable<PropertyInfo> GetOrderedProperties(this Type type)
        {
            return type.GetProperties().OrderBy(p =>
            {
                MappingAttribute a = p.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
                return a == null ? 0 : a.Order;
            }
            ).ThenByDescending(p =>
            {
                MappingAttribute a = p.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
                if (a == null) return 0;
                return a.IsPrimaryKey ? 1 : 0;
            });
        }

        public static bool IsNullOrWhiteSpaceOrEmptyParentheses(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            return s.Replace(" ", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty).Length == 0;
        }
    }
}
