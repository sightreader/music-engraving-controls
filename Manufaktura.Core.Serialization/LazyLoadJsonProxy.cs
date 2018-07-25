using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using Manufaktura.Core.Reflection;
using Newtonsoft.Json.Linq;

namespace Manufaktura.Core.Serialization
{
    public class LazyLoadJsonProxy<TInterface> : DispatchProxy
    {

        private string jsonString;

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            var jsonPropertyAttribute = targetMethod.DeclaringType
                .GetTypeInfo()
                .GetDeclaredProperty(targetMethod.Name.Replace("get_", ""))?
                .GetCustomAttribute<JsonPropertyAttribute>();

            if (jsonPropertyAttribute == null) return targetMethod.ReturnType.GetDefaultValue();

            using (var textReader = new StringReader(jsonString))
            using (var reader = new JsonTextReader(textReader))
            {
                while (reader.Read())
                {
                    if (reader.Path != jsonPropertyAttribute.PropertyName) continue;

                    var token = JToken.Load(reader);
                    var property = token as JProperty;
                    if (property != null)
                        return property.Value.ToObject(targetMethod.ReturnType);
                    else
                        return token.ToObject(targetMethod.ReturnType);
                }
            }
            return targetMethod.ReturnType.GetDefaultValue();
        }

        public static TInterface Create(string json)
        {
            var proxy = Create<TInterface, LazyLoadJsonProxy<TInterface>>() as LazyLoadJsonProxy<TInterface>;
            proxy.jsonString = json;
            return (TInterface)(object)proxy;
        }

    }
}
