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
using System.Reflection;
using Manufaktura.Orm.Predicates;

namespace Manufaktura.Orm
{
    public class DbRepository : IDisposable
    {       
        public DialectProvider CommandBuilder { get; protected set; }
        private bool isConnectionOpen;

        public DbRepository(DialectProvider commandBuilder)
        {
            CommandBuilder = commandBuilder;
        }

        public DbRepository(string commandBuilderClassName, string commandBuilderAssembly, string connectionString)
        {
            throw new NotImplementedException();    //Tu będzie automatyczne tworzenie command buildera w oparciu o dane z pliku konfiguracyjnego
        }

        public static MappingAttribute FindIdentity<TEntity>() where TEntity : Entity, new()
        {
            var properties = typeof(TEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (properties == null) return null;
            var mappings = properties.SelectMany(p => p.GetCustomAttributes<MappingAttribute>());
            return mappings.FirstOrDefault(m => m.IsPrimaryKey);
        }

        public List<TEntity> LoadAll<TEntity>() where TEntity : Entity, new()
        {
            return Load<TEntity>(QueryBuilder.Create());
        }

        public TEntity Load<TEntity>(object id) where TEntity : Entity, new()
        {
            MappingAttribute identityMapping = FindIdentity<TEntity>();
            if (identityMapping == null) throw new Exception(string.Format("Entity {0} has no primary key defined.", typeof(TEntity).Name));
            var results = Load<TEntity>(QueryBuilder.Create().SetWhereStatement(QB.Eq(identityMapping.Name, id)));
            if (results.Count > 1) throw new Exception(string.Format("There is more than one record with id {0} of entity {1}.", id, typeof(TEntity).Name));
            return results.FirstOrDefault();
        }

        public List<TEntity> Load<TEntity>(QueryBuilder builder) where TEntity : Entity, new()
        {
            DbCommand command = CommandBuilder.Connection.CreateCommand();
            if (!isConnectionOpen)
            {
                CommandBuilder.Connection.Open();
                isConnectionOpen = true;
            }
            command.Connection = CommandBuilder.Connection;
            DbDataAdapter adapter = CommandBuilder.CreateDataAdapter();
            adapter.SelectCommand = CommandBuilder.GetSelectCommand<TEntity>(builder);
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
            DbCommand command = CommandBuilder.Connection.CreateCommand();
            if (!isConnectionOpen)
            {
                CommandBuilder.Connection.Open();
                isConnectionOpen = true;
            }
            command = entity.IsNew ? CommandBuilder.GetInsertCommand(entity) : CommandBuilder.GetUpdateCommand(entity);
            command.ExecuteNonQuery();
            entity.IsNew = false;
            return entity;
        }

        public void Dispose()
        {
            CommandBuilder.Connection.Close();
        }
    }

}