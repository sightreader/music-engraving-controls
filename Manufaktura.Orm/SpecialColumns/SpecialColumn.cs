using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manufaktura.Orm.SpecialColumns
{
    public abstract class SpecialColumn
    {
        public abstract string Alias { get; }

        public abstract string GetColumnStatement();
    }
}