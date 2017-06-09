using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Orm.Portable.SpecialColumns
{
    public abstract class SpecialColumn
    {
        public string Alias { get; protected set; }

        protected SpecialColumn(string alias)
        {
            Alias = alias;
        }

        public abstract string GetColumnStatement();
    }
}