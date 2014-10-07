using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using Manufaktura.Orm.SpecialColumns;
using Manufaktura.Orm.Model;
using System.Text;
using System.Reflection;
using Manufaktura.Orm.SortModes;

namespace Manufaktura.Orm.Builder
{
    public class MySqlCommandBuilder : CommandBuilder
    {
        protected MySqlCommandBuilder(DbConnection connection)
            : base(connection)
        {

        }

        public MySqlCommandBuilder Create(DbConnection connection)
        {
            return new MySqlCommandBuilder(connection);
        }

        public override DbCommand GetSelectCommand<TEntity>()
        {
            DbCommand command = Connection.CreateCommand();
            command.CommandText = GetSelectCommandText<TEntity>();
            return command;
        }

        public override DbCommand GetInsertCommand(Entity entity)
        {
            MappingAttribute typeAttribute = entity.GetType().GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
            if (typeAttribute == null) throw new Exception(string.Format("Nazwa tabeli nie została określona dla typu {0}.", entity.GetType().Name));

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
            foreach (var property in entity.GetType().GetProperties())
            {
                if (property.GetValue(entity) == null) continue;
                MappingAttribute attribute = property.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
                if (attribute == null) continue;
                if (attribute.IsSpecialColumn) continue;
                if (!first) sb.Append(", ");
                sb.Append(string.Format("{0}", FormatValue(property.GetValue(entity))));
                first = false;
            }
            sb.Append(")");

            DbCommand command = Connection.CreateCommand();
            command.CommandText = sb.ToString();
            return command;
        }

        public override DbCommand GetUpdateCommand(Entity entity)
        {
            MappingAttribute typeAttribute = entity.GetType().GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
            if (typeAttribute == null) throw new Exception(string.Format("Nazwa tabeli nie została określona dla typu {0}.", entity.GetType().Name));

            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE ");
            sb.Append(typeAttribute.Name);
            sb.Append(" SET ");
            bool first = true;
            PropertyInfo idProperty = null;
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
                sb.Append(string.Format("{0} = {1}", attribute.Name, FormatValue(property.GetValue(entity))));
                first = false;
            }
            if (idProperty == null) throw new Exception("Brak kolumny id.");
            MappingAttribute idAttribute = idProperty.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
            sb.Append(string.Format(" WHERE {0}={1};", idAttribute.Name, idProperty.GetValue(entity)));

            DbCommand command = Connection.CreateCommand();
            command.CommandText = sb.ToString();
            return command;
        }

        public override DbCommand GetDeleteCommand(object id)
        {
            throw new NotImplementedException();
        }

        private string GetSelectCommandText<TEntity>()
        {
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
            foreach (SpecialColumn specialColumn in SpecialColumns)
            {
                if (!first) sb.Append(", ");
                sb.Append(string.Format("{0} AS {1}", specialColumn.GetColumnStatement(), specialColumn.Alias));
                first = false;
            }
            sb.Append(string.Format(" FROM {0}", typeAttribute.Name));

            if (WhereStatement != null)
            {
                string sql = WhereStatement.GetSql();   //TODO: Parametry!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                if (!string.IsNullOrWhiteSpace(sql))
                {
                    sb.Append(" WHERE ");
                    sb.Append(sql);
                }
            }
            if (SortModes.Count > 0)
            {
                sb.Append(" ORDER BY ");
                foreach (SortMode sortMode in SortModes)
                {
                    sb.Append(sortMode.GetOrderByStatement());
                }
            }

            if (Limit > 0)
            {
                sb.Append(" LIMIT ");
                if (Offset > 0) sb.Append(string.Format(" {0},", Offset));
                sb.Append(string.Format(" {0}", Limit));
            }
            return sb.ToString();
        }

        [Obsolete("Używać parametrów")]
        private string FormatValue(object value)
        {
            if (value is string) return string.Format("'{0}'", value == null ? value : ((string)value).Replace("'", ""));
            if (value is Guid) return string.Format("'{0}'", value);
            else return value.ToString();
        }
    }
}