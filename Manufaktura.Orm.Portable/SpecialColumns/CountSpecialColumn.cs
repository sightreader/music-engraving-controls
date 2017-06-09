using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.Portable.SpecialColumns
{
    public class CountSpecialColumn : SpecialColumn
    {
        public string Column { get; protected set; }

        public CountSpecialColumn(string column, string alias) : base(alias)
        {
            Column = column;
        }

        public override string GetColumnStatement()
        {
            return string.Format("COUNT({0})", Column);
        }
    }
}
