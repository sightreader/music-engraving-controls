using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using Manufaktura.Core.Reflection;
using Newtonsoft.Json.Linq;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace Manufaktura.Core.Serialization
{
    public class LazyLoadJsonProxy<TInterface> : DispatchProxy
    {

        private ConcurrentDictionary<string, object> cache = new ConcurrentDictionary<string, object>();
        private string jsonString;
        public ConcurrentDictionary<string, TimeSpan> PerformanceLog { get; } = new ConcurrentDictionary<string, TimeSpan>();

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
