using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;

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
            var unparsedValue = GetValue();
            var value = ParseValue<T>(unparsedValue);
#if CSHTML5
            if (value == null) return new XHelperHasValueResult<T>(default(T), GetValue(), false);
            if (typeof(T) == typeof(int)) return new XHelperHasValueResult<T>((T)(object)((int?)value).Value, GetValue(), true);
            if (typeof(T) == typeof(double)) return new XHelperHasValueResult<T>((T)(object)((double?)value).Value, GetValue(), true);
            if (typeof(T) == typeof(float)) return new XHelperHasValueResult<T>((T)(object)((float?)value).Value, GetValue(), true);
            if (typeof(T) == typeof(DateTime)) return new XHelperHasValueResult<T>((T)(object)((DateTime?)value).Value, GetValue(), true);
            throw new NotImplementedException("Type not supported");
#else
            return value.HasValue ? new XHelperHasValueResult<T>(value.Value, GetValue(), true) : new XHelperHasValueResult<T>(default(T), GetValue(), false);
#endif
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

#if !CSHTML5
        private static T? ParseValue<T>(string value) where T : struct
        {
            if (typeof(T) == typeof(int)) return UsefulMath.TryParseInt(value) as T?;
            if (typeof(T) == typeof(double)) return UsefulMath.TryParse(value) as T?;
            if (typeof(T) == typeof(float)) return UsefulMath.TryParse(value) as T?;
            if (typeof(T) == typeof(DateTime)) return UsefulMath.TryParseDateTime(value) as T?;
            throw new NotImplementedException("Type not supported");
        }
#else

        private static object ParseValue<T>(string value) where T : struct
        {
            if (typeof(T) == typeof(int)) return UsefulMath.TryParseInt(value);
            if (typeof(T) == typeof(double)) return UsefulMath.TryParse(value);
            if (typeof(T) == typeof(float)) return UsefulMath.TryParse(value);
            if (typeof(T) == typeof(DateTime)) return UsefulMath.TryParseDateTime(value);
            throw new NotImplementedException("Type not supported");
        }

#endif

        public XHelperHasValueResult<T> HasValue<T>(Func<Dictionary<string, T>, Dictionary<string, T>> valueFactory)
        {
            var dict = valueFactory(new Dictionary<string, T>());
            return HasValue(dict);
        }
    }
}