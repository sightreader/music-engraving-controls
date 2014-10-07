using Manufaktura.Orm.SortModes;
using Manufaktura.Orm.SpecialColumns;
using Manufaktura.Orm.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Manufaktura.Orm.Builder
{
    public abstract class CommandBuilder
    {
        public DbConnection Connection { get; protected set; }
        public int Offset { get; protected set; }
        public int Limit { get; protected set; }
        public SqlPredicate WhereStatement { get; protected set; }
        public List<string> Columns { get; protected set; }
        public List<SpecialColumn> SpecialColumns { get; protected set; }
        public List<SortMode> SortModes { get; protected set; }

        protected CommandBuilder(DbConnection connection)
        {
            SpecialColumns = new List<SpecialColumn>();
            SortModes = new List<SortMode>();
            Columns = new List<string>();
        }

        public CommandBuilder SetWindow(int offset, int limit)
        {
            Offset = offset;
            Limit = limit;
            return this;
        }

        public CommandBuilder SetWhereStatement(SqlPredicate whereStatement)
        {
            WhereStatement = whereStatement;
            return this;
        }

        public CommandBuilder AddSpecialColumn(SpecialColumn column)
        {
            SpecialColumns.Add(column);
            return this;
        }

        public CommandBuilder AddSortMode(SortMode sortMode)
        {
            SortModes.Add(sortMode);
            return this;
        }

        public abstract DbCommand GetSelectCommand<TEntity>();
        public abstract DbCommand GetInsertCommand(Entity entity);
        public abstract DbCommand GetUpdateCommand(Entity entity);
        public abstract DbCommand GetDeleteCommand(object id);

    }
}