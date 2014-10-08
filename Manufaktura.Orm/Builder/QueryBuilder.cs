using Manufaktura.Orm.SortModes;
using Manufaktura.Orm.SpecialColumns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.Builder
{
    public class QueryBuilder
    {
        public int Offset { get; protected set; }
        public int Limit { get; protected set; }
        public SqlPredicate WhereStatement { get; protected set; }
        public List<string> Columns { get; protected set; }
        public List<SpecialColumn> SpecialColumns { get; protected set; }
        public List<SortMode> SortModes { get; protected set; }

        protected QueryBuilder()
        {
            SpecialColumns = new List<SpecialColumn>();
            SortModes = new List<SortMode>();
            Columns = new List<string>();
        }

        public static QueryBuilder Create()
        {
            return new QueryBuilder();
        }

        public QueryBuilder SetWindow(int offset, int limit)
        {
            Offset = offset;
            Limit = limit;
            return this;
        }

        public QueryBuilder SetWhereStatement(SqlPredicate whereStatement)
        {
            WhereStatement = whereStatement;
            return this;
        }

        public QueryBuilder AddSpecialColumn(SpecialColumn column)
        {
            SpecialColumns.Add(column);
            return this;
        }

        public QueryBuilder AddSortMode(SortMode sortMode)
        {
            SortModes.Add(sortMode);
            return this;
        }
    }
}
