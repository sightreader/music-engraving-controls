using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Xml
{
    public interface IXHelper
    {
        XHelperExistsResult Exists();
        XHelperHasValueResult<T> HasValue<T>(Dictionary<string, T> values);
        XHelperHasValueResult<T> HasValue<T>() where T : struct;
        XHelperHasValueResult<string> HasValue(string s);

    }
}
