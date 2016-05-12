using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Manufaktura.Music.Xml
{
	public interface IXHelper
	{
		XHelperExistsResult Exists();

		XHelperHasValueResult<string> HasAnyValue();

		XHelperHasValueResult<T> HasValue<T>(Dictionary<string, T> values);

		XHelperHasValueResult<T> HasValue<T>(Func<Dictionary<string, T>, Dictionary<string, T>> valueFactory);

		XHelperHasValueResult<T> HasValue<T>() where T : struct;

		XHelperHasValueResult<string> HasValue(string s);
	}
}