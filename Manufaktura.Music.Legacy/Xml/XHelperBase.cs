using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Manufaktura.Music.Xml
{
	public abstract class XHelperBase : IXHelper
	{
		public XHelperExistsResult Exists()
		{
			return new XHelperExistsResult(ElementExists(), GetObject());
		}

		public XHelperHasValueResult<string> HasAnyValue()
		{
			if (!ElementExists()) return new XHelperHasValueResult<string>();
			var value = GetValue();
			return !string.IsNullOrWhiteSpace(value) ? new XHelperHasValueResult<string>(value) : new XHelperHasValueResult<string>();
		}

		public XHelperHasValueResult<T> HasValue<T>(Dictionary<string, T> values)
		{
			if (ElementExists() && values.ContainsKey(GetValue())) return new XHelperHasValueResult<T>(values[GetValue()]);
			return new XHelperHasValueResult<T>();
		}

		public XHelperHasValueResult<T> HasValue<T>() where T : struct
		{
			if (!ElementExists()) return new XHelperHasValueResult<T>();
			var value = ParseValue<T>(GetValue());
			return value.HasValue ? new XHelperHasValueResult<T>(value.Value) : new XHelperHasValueResult<T>();
		}

		public XHelperHasValueResult<string> HasValue(string s)
		{
			if (!ElementExists()) return new XHelperHasValueResult<string>();
			var value = GetValue();
			return !string.IsNullOrWhiteSpace(value) && s == value ? new XHelperHasValueResult<string>(value) : new XHelperHasValueResult<string>();
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
			var dict = valueFactory(new Dictionary<string, T>());
			return HasValue(dict);
		}
	}
}