using Manufaktura.Core.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Manufaktura.Core.Serialization
{
    public abstract class LazyLoadJsonProxy : DispatchProxy
    {
        protected ConcurrentDictionary<string, object> cache = new ConcurrentDictionary<string, object>();
        public int NumberOfAccessedMethods => cache.Count;
        public ConcurrentDictionary<string, TimeSpan> PerformanceLog { get; } = new ConcurrentDictionary<string, TimeSpan>();

        public TimeSpan TotalTimeSpentOnDeserialization => TimeSpan.FromTicks(PerformanceLog.Sum(pl => pl.Value.Ticks));
        public static object Create(Type interfaceType, string json)
        {
            var proxyType = typeof(LazyLoadJsonProxy<>).MakeGenericType(interfaceType);
            var method = proxyType.GetTypeInfo().GetDeclaredMethods(nameof(Create)).First(m => m.GetParameters().First().ParameterType == typeof(string));
            return method.Invoke(null, new object[] { json });
        }

        public TimeSpan GetTotalDeserializationTimeWithChildElements()
        {
            var time = TotalTimeSpentOnDeserialization;
            foreach (var prop in GetType().GetRuntimeProperties().Where(p => p.PropertyType.GetTypeInfo().IsInterface))
            {
                var proxy = prop.GetValue(this) as LazyLoadJsonProxy;
                if (proxy == null) continue;
                time += proxy.GetTotalDeserializationTimeWithChildElements();
            }
            return time;
        }

        public int GetTotalNumberOfAccessedMethodsWithChildElements()
        {
            var count = NumberOfAccessedMethods;
            foreach (var prop in GetType().GetRuntimeProperties().Where(p => p.PropertyType.GetTypeInfo().IsInterface))
            {
                var proxy = prop.GetValue(this) as LazyLoadJsonProxy;
                if (proxy == null) continue;
                count += proxy.GetTotalNumberOfAccessedMethodsWithChildElements();
            }
            return count;
        }
    }

    public class LazyLoadJsonProxy<TInterface> : LazyLoadJsonProxy
    {
        private string jsonString;

        public static TInterface Create(string json)
        {
            var proxy = Create<TInterface, LazyLoadJsonProxy<TInterface>>() as LazyLoadJsonProxy<TInterface>;
            proxy.jsonString = json;
            return (TInterface)(object)proxy;
        }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            if (cache.ContainsKey(targetMethod.Name)) return cache[targetMethod.Name];

            var sw = new Stopwatch();
            sw.Start();
            try
            {
                var jsonPropertyAttribute = targetMethod.DeclaringType
                    .GetTypeInfo()
                    .GetDeclaredProperty(targetMethod.Name.Replace("get_", ""))?
                    .GetCustomAttribute<JsonPropertyAttribute>();

                if (jsonPropertyAttribute == null) return TryAddDefaultValue(targetMethod.Name, targetMethod.ReturnType);

                using (var textReader = new StringReader(jsonString))
                using (var reader = new JsonTextReader(textReader))
                {
                    while (reader.Read())
                    {
                        if (reader.Path != jsonPropertyAttribute.PropertyName) continue;

                        var token = JToken.Load(reader);
                        if (targetMethod.ReturnType.GetTypeInfo().IsInterface)
                        {
                            var prop = token as JProperty;
                            if (prop != null)
                            {
                                var proxy = Create(targetMethod.ReturnType, prop.Value.ToString());
                                return TryAddValue(targetMethod.Name, proxy);
                            }
                            else
                            {
                                var proxy = Create(targetMethod.ReturnType, token.ToString());
                                return TryAddValue(targetMethod.Name, proxy);
                            }
                        }

                        var property = token as JProperty;
                        if (property != null)
                            return TryAddValue(targetMethod.Name, property.Value.ToObject(targetMethod.ReturnType));
                        else
                            return TryAddValue(targetMethod.Name, token.ToObject(targetMethod.ReturnType));
                    }
                }
                return TryAddDefaultValue(targetMethod.Name, targetMethod.ReturnType);
            }
            finally
            {
                sw.Stop();
                PerformanceLog.TryAdd(targetMethod.Name, sw.Elapsed);
            }
        }

        private object TryAddDefaultValue(string name, Type type)
        {
            var value = type.GetDefaultValue();
            return TryAddValue(name, value);
        }

        private object TryAddValue(string name, object value)
        {
            cache.TryAdd(name, value);
            return value;
        }
    }
}