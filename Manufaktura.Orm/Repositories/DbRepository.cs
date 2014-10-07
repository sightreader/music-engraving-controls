using Manufaktura.Orm.SortModes;
using Manufaktura.Orm.SpecialColumns;
using Manufaktura.Orm.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using Manufaktura.Orm.Builder;

namespace Manufaktura.Orm
{
    public abstract class DbRepository<TConnection, TAdapter> : IDisposable
        where TConnection : DbConnection, new()
        where TAdapter : DbDataAdapter, new()
    {
        public DbConnection Connection { get; protected set; }
        protected abstract DbConnection CreateConnection(string connectionString);
        public CommandBuilder DefaultCommandBuilder { get; protected set; }

        protected DbRepository(CommandBuilder defaultCommandBuilder, string connectionString)
        {
            DefaultCommandBuilder = defaultCommandBuilder;
            Connection = CreateConnection(connectionString);
        }

        public List<TEntity> LoadAll<TEntity>() where TEntity : Entity, new()
        {
            return Load<TEntity>(DefaultCommandBuilder);
        }

        public List<TEntity> Load<TEntity>(CommandBuilder builder) where TEntity : Entity, new()
        {
            DbCommand command = Connection.CreateCommand();
            Connection.Open();
            command.Connection = Connection;
            TAdapter adapter = new TAdapter();
            adapter.SelectCommand = builder.GetSelectCommand<TEntity>();
            DataTable table = new DataTable();
            adapter.Fill(table);
            List<TEntity> results = new List<TEntity>();
            foreach (DataRow row in table.Rows)
            {
                results.Add(Entity.FromRow<TEntity>(row));
            }
            return results;
        }


        public Entity Save(Entity entity)
        {
            DbCommand command = Connection.CreateCommand();
            Connection.Open();
            command = entity.IsNew ? DefaultCommandBuilder.GetInsertCommand(entity) : DefaultCommandBuilder.GetUpdateCommand(entity);
            command.ExecuteNonQuery();
            entity.IsNew = false;
            return entity;
        }

        public void Dispose()
        {
        }
    }

}