using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Orm.Portable.SortModes
{
    public abstract class SortMode
    {
        public abstract string GetOrderByStatement();
    }
}