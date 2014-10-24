using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using Manufaktura.Orm.SpecialColumns;
using System.Text;
using System.Reflection;
using Manufaktura.Orm.SortModes;
using MySql.Data.MySqlClient;
using Manufaktura.Model;

namespace Manufaktura.Orm.Builder
{
    public class MySqlDialectProvider : DialectProvider
    {
        public MySqlDialectProvider(MySqlConnection connection) : base(connection)
        {

        }

        public MySqlDialectProvider(string connectionString) : base(new MySqlConnection(connectionString))
        {

        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new MySqlDataAdapter();
        }

        public override DbCommand GetSelectCommand<TEntity>(QueryBuilder builder)
        {
            int parameterCounter = 0;
            MappingAttribute typeAttribute = typeof(TEntity).GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
            if (typeAttribute == null) throw new Exception(string.Format("Nazwa tabeli nie została określona dla typu {0}.", typeof(TEntity).Name));

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ");
            bool first = true;
            foreach (PropertyInfo property in typeof(TEntity).GetProperties())
            {
                MappingAttribute attribute = property.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
                if (attribute == null) continue;
                if (attribute.IsSpecialColumn) continue;    //Ta kolumna będzie dodana przez klasę SpecialColumn
                if (!first) sb.Append(", ");
                sb.Append(string.Format("{0}", attribute.Name));
                first = false;
            }
            foreach (SpecialColumn specialColumn in builder.SpecialColumns)
            {
                if (!first) sb.Append(", ");
                sb.Append(string.Format("{0} AS {1}", specialColumn.GetColumnStatement(), specialColumn.Alias));
                first = false;
            }
            sb.Append(string.Format(" FROM {0}", typeAttribute.Name));

            if (builder.WhereStatement != null)
            {
                string sql = builder.WhereStatement.GetSql(ref parameterCounter);
                if (!string.IsNullOrWhiteSpace(sql))
                {
                    sb.Append(" WHERE ");
                    sb.Append(sql);
                }
            }
            if (builder.SortModes.Count > 0)
            {
                sb.Append(" ORDER BY ");
                sb.Append(string.Join(", ", builder.SortModes.Select(sm => sm.GetOrderByStatement())));
            }

            if (builder.Limit > 0)
            {
                sb.Append(" LIMIT ");
                if (builder.Offset > 0) sb.Append(string.Format(" {0},", builder.Offset));
                sb.Append(string.Format(" {0}", builder.Limit));
            }

            DbCommand command = Connection.CreateCommand();
            command.CommandText = sb.ToString();
            if (builder.WhereStatement != null)
            {
                int paramNumber = 0;
                foreach (var parameter in builder.WhereStatement.GetParameterValues())
                {
                    command.Parameters.Add(new MySqlParameter(string.Format("@P{0}", paramNumber), parameter));
                    paramNumber++;
                }
            }
            return command;
        }

        public override DbCommand GetInsertCommand(Entity entity)
        {
            MappingAttribute typeAttribute = entity.GetType().GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
            if (typeAttribute == null) throw new Exception(string.Format("Nazwa tabeli nie została określona dla typu {0}.", entity.GetType().Name));

            MySqlCommand command = Connection.CreateCommand() as MySqlCommand;

            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO ");
            sb.Append(typeAttribute.Name);
            sb.Append(" (");
            bool first = true;
            foreach (var property in entity.GetType().GetProperties())
            {
                if (property.GetValue(entity) == null) continue;
                MappingAttribute attribute = property.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
                if (attribute == null) continue;
                if (attribute.IsSpecialColumn) continue;
                if (!first) sb.Append(", ");
                sb.Append(string.Format("{0}", attribute.Name));
                first = false;
            }
            sb.Append(") VALUES (");
            first = true;
            int parameter = 0;
            foreach (var property in entity.GetType().GetProperties())
            {
                if (property.GetValue(entity) == null) continue;
                MappingAttribute attribute = property.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
                if (attribute == null) continue;
                if (attribute.IsSpecialColumn) continue;
                if (!first) sb.Append(", ");
                sb.Append(string.Format("@P{0}", parameter));
                command.Parameters.Add(string.Format("@P{0}", parameter), property.GetValue(entity));
                first = false;
                parameter++;
            }
            sb.Append(")");

            
            command.CommandText = sb.ToString();
            return command;
        }

        public override DbCommand GetUpdateCommand(Entity entity)
        {
            MappingAttribute typeAttribute = entity.GetType().GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
            if (typeAttribute == null) throw new Exception(string.Format("Nazwa tabeli nie została określona dla typu {0}.", entity.GetType().Name));

            MySqlCommand command = Connection.CreateCommand() as MySqlCommand;

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE ");
            sb.Append(typeAttribute.Name);
            sb.Append(" SET ");
            bool first = true;
            PropertyInfo idProperty = null;
            int parameter = 0;
            foreach (var property in entity.GetType().GetProperties())
            {
                if (property.GetValue(entity) == null) continue;
                MappingAttribute attribute = property.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
                if (attribute == null) continue;
                if (attribute.IsSpecialColumn) continue;
                if (attribute.IsPrimaryKey)
                {
                    idProperty = property;
                    continue;
                }
                if (!first) sb.Append(", ");
                sb.Append(string.Format("{0} = @P{1}", attribute.Name, parameter));
                command.Parameters.Add(string.Format("@P{0}", parameter), property.GetValue(entity));
                first = false;
                parameter++;
            }
            if (idProperty == null) throw new Exception("Brak kolumny id.");
            MappingAttribute idAttribute = idProperty.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
            sb.Append(string.Format(" WHERE {0}={1};", idAttribute.Name, idProperty.GetValue(entity)));

            
            command.CommandText = sb.ToString();
            return command;
        }

        public override DbCommand GetDeleteCommand(object id)
        {
            throw new NotImplementedException();
        }
       
    }
}