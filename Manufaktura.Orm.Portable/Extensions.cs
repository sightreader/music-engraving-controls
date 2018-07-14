/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Manufaktura.Orm.Portable
{
    public static class Extensions
    {
        public static IEnumerable<PropertyInfo> GetOrderedProperties(this Type type)
        {
            return type.GetRuntimeProperties().OrderBy(p =>
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