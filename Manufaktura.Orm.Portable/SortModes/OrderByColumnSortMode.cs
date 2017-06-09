using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Orm.Portable.SortModes
{
    public class OrderByColumnSortMode : SortMode
    {
        public string ColumnName { get; private set; }

        public bool IsDescending { get; private set; }

        public OrderByColumnSortMode(string columnName, bool isDescending)
        {
            ColumnName = columnName;
            IsDescending = isDescending;
        }

        public override string GetOrderByStatement()
        {
            return string.Format(" {0} {1}", ColumnName, IsDescending ? "DESC" : "ASC" );
        }
    }
}