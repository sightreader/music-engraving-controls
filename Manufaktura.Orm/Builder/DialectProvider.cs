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
    public abstract class DialectProvider : IDisposable
    {
        public DbConnection Connection { get; protected set; }
        public bool IsDisposed { get; private set; }
       
        public abstract DbDataAdapter CreateDataAdapter();

        protected DialectProvider(DbConnection connection)
        {
            Connection = connection;
        }

        public abstract DbCommand GetSelectCommand<TEntity>(QueryBuilder query);
        public abstract DbCommand GetInsertCommand(Entity entity);
        public abstract DbCommand GetUpdateCommand(Entity entity);
        public abstract DbCommand GetDeleteCommand(object id);


        public void Dispose()
        {
            if (Connection == null) return;
            if (IsDisposed) return;
            
            Connection.Close();
            Connection.Dispose();
            IsDisposed = true;
        }
    }
}