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
    public abstract class DialectProvider
    {
        public DbConnection Connection { get; protected set; }
       
        public abstract DbDataAdapter CreateDataAdapter();

        protected DialectProvider(DbConnection connection)
        {
            Connection = connection;
        }

        public abstract DbCommand GetSelectCommand<TEntity>(QueryBuilder query);
        public abstract DbCommand GetInsertCommand(Entity entity);
        public abstract DbCommand GetUpdateCommand(Entity entity);
        public abstract DbCommand GetDeleteCommand(object id);

    }
}