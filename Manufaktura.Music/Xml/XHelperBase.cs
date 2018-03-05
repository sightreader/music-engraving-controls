using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Music.Xml
{
    public abstract class XHelperBase : IXHelper
    {
        public XHelperExistsResult Exists()
        {
            return new XHelperExistsResult(ElementExists(), GetObject(), GetValue());
        }

        public XHelperHasValueResult<string> HasAnyValue()
        {
            if (!ElementExists()) return new XHelperHasValueResult<string>(null, null, false);
            var value = GetValue();
            return !string.IsNullOrWhiteSpace(value) ? new XHelperHasValueResult<string>(value, value, true) : new XHelperHasValueResult<string>(null, null, false);
        }

        public XHelperHasValueResult<T> HasValue<T>(Dictionary<string, T> values)
        {
            if (ElementExists() && values.ContainsKey(GetValue())) return new XHelperHasValueResult<T>(values[GetValue()], GetValue(), true);
            return new XHelperHasValueResult<T>(default(T), GetValue(), false);
        }

        public XHelperHasValueResult<T> HasValue<T>() where T : struct
        {
            if (!ElementExists()) return new XHelperHasValueResult<T>(default(T), null, false);
            var value = ParseValue<T>(GetValue());
            return value.HasValue ? new XHelperHasValueResult<T>(value.Value, GetValue(), true) : new XHelperHasValueResult<T>(default(T), GetValue(), false);
        }

        public XHelperHasValueResult<string> HasValue(string s)
        {
            if (!ElementExists()) return new XHelperHasValueResult<string>(null, null, false);
            var value = GetValue();
            return !string.IsNullOrWhiteSpace(value) && s == value ? new XHelperHasValueResult<string>(value, GetValue(), true) : new XHelperHasValueResult<string>(null, GetValue(), false);
        }

        protected abstract bool ElementExists();

        protected abstract string GetValue();

        protected abstract object GetObject();

        private static T? ParseValue<T>(string value) where T : struct
        {
            if (typeof(T) == typeof(int)) return UsefulMath.TryParseInt(value) as T?;
            if (typeof(T) == typeof(double)) return UsefulMath.TryParse(value) as T?;
            if (typeof(T) == typeof(float)) return UsefulMath.TryParse(value) as T?;
            if (typeof(T) == typeof(DateTime)) return UsefulMath.TryParseDateTime(value) as T?;
            throw new NotImplementedException("Type not supported");
        }

        public XHelperHasValueResult<T> HasValue<T>(Func<Dictionary<string, T>, Dictionary<string, T>> valueFactory)
        {
#if !CSHTML5
            var dict = valueFactory(new Dictionary<string, T>());
#else
            var dict = valueFactory(new List<KeyValuePair<string, T>>().ToDictionary(x => x.Key, x => x.Value));
#endif
            return HasValue(dict);
        }
    }
}