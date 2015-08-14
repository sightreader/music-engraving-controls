using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Manufaktura.Controls.IoC
{
    public class ExpressionActivator
    {
        public static T CreateInstance<T>(Type type) where T : class
        {
            var expr = Expression.Lambda(Expression.New(type));
            return expr.Compile().DynamicInvoke() as T;
        }

        public static T CreateInstance<T>(ConstructorInfo constructor, params object[] parameters) where T : class
        {
            var expr = Expression.Lambda(Expression.New(constructor, parameters.Select(p => Expression.Parameter(p.GetType(), 
                string.Format("p{0}", parameters.ToList().IndexOf(p))))));
            return expr.Compile().DynamicInvoke(parameters) as T;
        }
    }
}