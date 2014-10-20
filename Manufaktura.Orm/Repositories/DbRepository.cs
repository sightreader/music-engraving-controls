﻿using Manufaktura.Orm.SortModes;
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
            DbCommand command = Provider.Connection.CreateCommand();
            if (!_isConnectionOpen)
            {
                Provider.Connection.Open();
                _isConnectionOpen = true;
            }
            command.Connection = Provider.Connection;
            DbDataAdapter adapter = Provider.CreateDataAdapter();
            adapter.SelectCommand = Provider.GetSelectCommand<TEntity>(builder);
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
            DbCommand command = Provider.Connection.CreateCommand();
            if (!_isConnectionOpen)
            {
                Provider.Connection.Open();
                _isConnectionOpen = true;
            }
            command = entity.IsNew ? Provider.GetInsertCommand(entity) : Provider.GetUpdateCommand(entity);
            command.ExecuteNonQuery();
            entity.IsNew = false;
            return entity;
        }

        public void Dispose()
        {
            if (Provider == null) return;
            Provider.Dispose();
        }
    }

}