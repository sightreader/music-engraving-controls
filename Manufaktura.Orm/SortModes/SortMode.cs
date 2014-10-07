using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manufaktura.Orm.SortModes
{
    public abstract class SortMode
    {
        public abstract string GetOrderByStatement();
    }
}