using Manufaktura.Orm.Builder;
using Manufaktura.Orm.Portable;
using Manufaktura.Orm.Portable.Builder;
using Manufaktura.Orm.Portable.Predicates;
using Manufaktura.Orm.Portable.SpecialColumns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace Manufaktura.Orm
{
    public class DbRepository : IDisposable
    {
        public DialectProvider Provider { get; protected set; }
        private bool _isConnectionOpen;

        public DbRepository(DialectProvider provider)
        {
            Provider = provider;
        }

        public DbRepository(string providerClassName, string providerAssemblyFile, string connectionString)
        {
            Assembly assembly = Assembly.LoadFrom(providerAssemblyFile);
            Type providerType = assembly.GetType(providerClassName);
            if (providerType == null)
                throw new Exception(string.Format("Failed to create dialect provider type {0}. Make sure that namespace is correct.", providerClassName));
            Provider = Activator.CreateInstance(providerType, connectionString) as DialectProvider;
            if (Provider == null) throw new Exception(string.Format("Failed to create dialect provider {0}.", providerClassName));
        }

        public static MappingAttribute FindIdentity<TEntity>() where TEntity : new()
        {
            var properties = typeof(TEntity).GetRuntimeProperties();
            if (properties == null) return null;
            var mappings = properties.SelectMany(p => p.GetCustomAttributes<MappingAttribute>());
            return mappings.FirstOrDefault(m => m.IsPrimaryKey);
        }

        public List<TEntity> LoadAll<TEntity>() where TEntity : new()
        {
            return Load<TEntity>(QueryBuilder.Create());
        }

        public TEntity Load<TEntity>(object id) where TEntity : new()
        {
            if (id is SqlPredicate)
                throw new ArgumentException("Entity id was expected but SqlPredicate found. You probably wanted to use Load<TEntity>(QueryBuilder.Create().SetWhereStatement(sqlPredicate)).");

            MappingAttribute identityMapping = FindIdentity<TEntity>();
            if (identityMapping == null) throw new Exception(string.Format("Entity {0} has no primary key defined.", typeof(TEntity).Name));
            var results = Load<TEntity>(QueryBuilder.Create().SetWhereStatement(QB.Eq(identityMapping.Name, id)));
            if (results.Count > 1) throw new Exception(string.Format("There is more than one record with id {0} of entity {1}.", id, typeof(TEntity).Name));
            return results.FirstOrDefault();
        }

        public List<TEntity> Load<TEntity>(QueryBuilder builder) where TEntity : new()
        {
            EnsureConnectionOpen();
            DbDataAdapter adapter = Provider.CreateDataAdapter();
            adapter.SelectCommand = Provider.GetSelectCommand<TEntity>(builder);
            DataTable table = new DataTable();
            adapter.Fill(table);
            List<TEntity> results = new List<TEntity>();
            foreach (DataRow row in table.Rows)
            {
                results.Add(FromRow<TEntity>(row));
            }
            return results;
        }

        public TScalar ExecuteScalar<TEntity, TScalar>(QueryBuilder builder) where TEntity : new()
        {
            EnsureConnectionOpen();
            DbCommand command = Provider.GetSelectCommand<TEntity>(builder);
            return (TScalar)command.ExecuteScalar();
        }

        public long Count<TEntity>(string columnName, SqlPredicate whereStatement) where TEntity : new()
        {
            EnsureConnectionOpen();
            QueryBuilder builder = QueryBuilder.Create().SpecifyColumns(null).AddSpecialColumn(new CountSpecialColumn(columnName, $"{(columnName == "*" ? "AllColumns" : columnName)}Count"));
            if (whereStatement != null) builder.SetWhereStatement(whereStatement);
            return ExecuteScalar<TEntity, long>(builder);
        }

        public long CountAll<TEntity>(string columnName) where TEntity : new()
        {
            return Count<TEntity>(columnName, null);
        }

        public object Insert(object entity)
        {
            EnsureConnectionOpen();
            DbCommand command = Provider.Connection.CreateCommand();
            Provider.GetInsertCommand(entity).ExecuteNonQuery();
            return entity;
        }

        public object Update(object entity)
        {
            EnsureConnectionOpen();
            DbCommand command = Provider.Connection.CreateCommand();
            Provider.GetUpdateCommand(entity).ExecuteNonQuery();
            return entity;
        }

        public void UpdateSchema<TEntity>()
        {
            EnsureConnectionOpen();
            var command = Provider.GetUpdateSchemaCommand<TEntity>();
            if (command != null) command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            if (Provider == null) return;
            Provider.Dispose();
        }

        private void EnsureConnectionOpen()
        {
            if (_isConnectionOpen) return;
            Provider.Connection.Open();
            _isConnectionOpen = true;
        }

        public static T FromRow<T>(DataRow row) where T : new()
        {
            T entity = new T();
            foreach (DataColumn column in row.Table.Columns)
            {
                SetPropertyFromCell(entity, column.ColumnName, row[column.ColumnName]);
            }
            return entity;
        }

        private static void SetPropertyFromCell(object entity, string columnName, object cellValue)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            var properties = entity.GetType().GetRuntimeProperties();
            foreach (var property in properties)
            {
                MappingAttribute attribute = property.GetCustomAttributes(typeof(MappingAttribute), true).Cast<MappingAttribute>().FirstOrDefault();
                if (attribute == null) continue;
                if (attribute.Name == columnName)
                {
                    if (property.PropertyType == typeof(bool) && cellValue is short)
                        cellValue = (short)cellValue != 0;
                    if (property.PropertyType == typeof(bool) && cellValue is int)
                        cellValue = (int)cellValue != 0;
                    if (property.PropertyType == typeof(bool) && cellValue is long)
                        cellValue = (long)cellValue != 0;
                    if (cellValue == DBNull.Value) cellValue = null;

                    property.SetValue(entity, cellValue, null);
                }
            }
        }
    }
}