using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Manufaktura.Controls.IoC
{
    /// <summary>
    /// Simple dependency resolver.
    /// </summary>
    public class ManufakturaResolver
    {
        private List<object> createdServices = new List<object>();

        /// <summary>
        /// Register object which will be used as a dependency when needed.
        /// </summary>
        /// <param name="service">Any object</param>
        public void AddService(object service)
        {
            createdServices.Add(service);
        }

        /// <summary>
        /// Register objects which will be used as dependencies when needed.
        /// </summary>
        /// <param name="services">Any objects</param>
        public void AddServices(params object[] services)
        {
            createdServices.AddRange(services);
        }

        /// <summary>
        /// Create objects of type T. If the constructor has dependencies they will be matched from createdServices list.
        /// </summary>
        /// <typeparam name="T">Type of objects to create</typeparam>
        /// <returns>Created object</returns>
        public IEnumerable<T> ResolveAll<T>() where T:class
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => !t.IsAbstract && (t.IsSubclassOf(typeof(T)) || typeof(T).IsAssignableFrom(t)));
            foreach (var type in types)
            {
                var constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
                if (!constructors.Any()) yield return ExpressionActivator.CreateInstance<T>(type);
                foreach (var constructor in constructors)
                {
                    object[] matchedParameters;
                    if (TryBindParameters(constructor, out matchedParameters))
                        yield return Activator.CreateInstance(type, matchedParameters) as T;
                }
            }
        }

        private bool TryBindParameters(ConstructorInfo constructor, out object[] matchedParameters)
        {
            var matchedParameterList = new List<object>();
            var constructorParameters = constructor.GetParameters();
            foreach (var parameter in constructorParameters)
            {
                var matchingService = createdServices.FirstOrDefault(cs => parameter.ParameterType == cs.GetType() ||
                    parameter.ParameterType.IsAssignableFrom(cs.GetType()));
                if (matchingService == null) break;
                matchedParameterList.Add(matchingService);
            }
            matchedParameters = matchedParameterList.ToArray();
            return constructorParameters.Length == matchedParameters.Length;
        }
    }
}
