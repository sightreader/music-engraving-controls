using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Manufaktura.Controls.IoC
{
    /// <summary>
    /// Helper class to create objects using expression tree compilation.
    /// </summary>
    public class ExpressionActivator
    {
        /// <summary>
        /// Create instance of type <typeparam name="T" />.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <returns></returns>
        public static T CreateInstance<T>(Type type) where T : class
        {
            var expr = Expression.Lambda(Expression.New(type));
            return expr.Compile().DynamicInvoke() as T;
        }

        /// <summary>
        /// Creates instance of an object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="constructor"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static T CreateInstance<T>(ConstructorInfo constructor, params object[] parameters) where T : class
        {
            var expr = Expression.Lambda(Expression.New(constructor, parameters.Select(p => Expression.Parameter(p.GetType(), 
                string.Format("p{0}", parameters.ToList().IndexOf(p))))));
            return expr.Compile().DynamicInvoke(parameters) as T;
        }
    }
}