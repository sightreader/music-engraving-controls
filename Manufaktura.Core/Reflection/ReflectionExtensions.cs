using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Manufaktura.Core.Reflection
{
    public static class ReflectionExtensions
    {
        public static object GetDefaultValue(this Type type)
        {
            if (type.GetTypeInfo().IsValueType)
            {
                return Activator.CreateInstance(type);
            }
            return null;
        }
    }
}
