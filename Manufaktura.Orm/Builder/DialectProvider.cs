using Manufaktura.Orm.Portable.Builder;
using Manufaktura.Orm.Portable.SortModes;
using Manufaktura.Orm.Portable.SpecialColumns;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

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
        public abstract DbCommand GetInsertCommand(object entity);
        public abstract DbCommand GetUpdateCommand(object entity);
        public abstract DbCommand GetDeleteCommand(object id);
        public abstract DbCommand GetUpdateSchemaCommand(object entity);


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