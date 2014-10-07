using Manufaktura.Orm.SortModes;
using Manufaktura.Orm.SpecialColumns;
using Manufaktura.Orm.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Manufaktura.Orm
{
    public abstract class AdoNetRepository<TConnection, TAdapter> : Repository, IDisposable
        where TConnection : DbConnection, new()
        where TAdapter : DbDataAdapter, new()
    {
        public SqlBuilder SqlBuilder { get; protected set; }
        protected abstract SqlBuilder CreateSqlBuilder();
        public DbConnection Connection { get; protected set; }
        protected abstract DbConnection CreateConnection(string connectionString);

        protected AdoNetRepository(string connectionString)
        {
            SqlBuilder = CreateSqlBuilder();
            Connection = CreateConnection(connectionString);
        }

        public override TEntity Load<TEntity>(object id)
        {
            DbCommand command = Connection.CreateCommand();
            Connection.Open();
            command.Connection = Connection;
            TAdapter adapter = new TAdapter();
            adapter.SelectCommand = command;
            adapter.SelectCommand.CommandText = SqlBuilder.GetSelectCommand(typeof(TEntity), "'" + id + "'");
            DataTable table = new DataTable();
            adapter.FillError += adapter_FillError;
            adapter.Fill(table);
            if (table.Rows.Count == 0) return null;
            if (table.Rows.Count > 1) throw new Exception("There is more than 1 row with same id.");
            return Entity.FromRow<TEntity>(table.Rows[0]);
        }

        public override List<TEntity> LoadAll<TEntity>(int offset, int limit)
        {
            DbCommand command = Connection.CreateCommand();
            Connection.Open();
            command.Connection = Connection;
            TAdapter adapter = new TAdapter();
            adapter.SelectCommand = command;
            adapter.SelectCommand.CommandText = SqlBuilder.GetSelectCommand(offset, limit, typeof(TEntity), null);
            DataTable table = new DataTable();
            adapter.Fill(table);
            List<TEntity> results = new List<TEntity>();
            foreach (DataRow row in table.Rows)
            {
                results.Add(Entity.FromRow<TEntity>(row));
            }
            return results;
        }

        public override List<TEntity> LoadAllByQuery<TEntity>(int offset, int limit, SqlPredicate predicate, SpecialColumn[] specialColumns, SortMode[] sortModes)
        {
            DbCommand command = Connection.CreateCommand();
            Connection.Open();
            command.Connection = Connection;
            TAdapter adapter = new TAdapter();
            adapter.SelectCommand = command;
            adapter.SelectCommand.CommandText = SqlBuilder.GetSelectCommandWithQuery(offset, limit, typeof(TEntity), predicate, specialColumns, sortModes);
            DataTable table = new DataTable();
            adapter.Fill(table);
            List<TEntity> results = new List<TEntity>();
            foreach (DataRow row in table.Rows)
            {
                results.Add(Entity.FromRow<TEntity>(row));
            }
            return results;
        }

        public override Entity Save(Entity entity)
        {
            DbCommand command = Connection.CreateCommand();
            Connection.Open();
            command.Connection = Connection;
            command.CommandText = entity.IsNew ? SqlBuilder.GetInsertCommand(entity) : SqlBuilder.GetUpdateCommand(entity);
            command.ExecuteNonQuery();
            entity.IsNew = false;
            return entity;
        }

        void adapter_FillError(object sender, FillErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }

}