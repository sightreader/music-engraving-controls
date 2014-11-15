using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manufaktura.Orm.SpecialColumns
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