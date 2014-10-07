using Manufaktura.Orm.SortModes;
using Manufaktura.Orm.SpecialColumns;
using Manufaktura.Orm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace Manufaktura.Orm
{
    [Obsolete("Zamienić na CommandBuilder")]
    public class SqlBuilder //TODO: Refaktor !!!!!!!!!!!!!
    {
        public string GetSelectCommand(Type entityType, object id)
        {
            return GetSelectCommand(0, 0, entityType, id, null, null);
        }

        public virtual string GetSelectCommand(int offset, int limit, Type entityType, object id, SpecialColumn[] specialColumns = null, SortMode[] sortModes = null)
        {
            MappingAttribute typeAttribute = entityType.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
            if (typeAttribute == null) throw new Exception(string.Format("Nazwa tabeli nie została określona dla typu {0}.", entityType.Name));

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ");
            bool first = true;
            foreach (PropertyInfo property in entityType.GetProperties())
            {
                MappingAttribute attribute = property.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
                if (attribute == null) continue;
                if (attribute.IsSpecialColumn) continue;    //Ta kolumna będzie dodana przez klasę SpecialColumn
                if (!first) sb.Append(", ");
                sb.Append(string.Format("{0}", attribute.Name));
                first = false;
            }
            if (specialColumns != null)
            {
                foreach (SpecialColumn specialColumn in specialColumns)
                {
                    if (!first) sb.Append(", ");
                    sb.Append(string.Format("{0} AS {1}", specialColumn.GetColumnStatement(), specialColumn.Alias));
                    first = false;
                }
            }
            sb.Append(string.Format(" FROM {0}", typeAttribute.Name));

            if (id != null) sb.Append(string.Format(" WHERE ID={0};", id));
            if (sortModes != null && sortModes.Length > 0)
            {
                sb.Append(" ORDER BY ");
                foreach (SortMode sortMode in sortModes)
                {
                    sb.Append(sortMode.GetOrderByStatement());
                }
            }

            if (limit > 0)  //TODO: Wprowadzić obsługę dialektów SQL
            {
                sb.Append(" LIMIT ");
                if (offset > 0) sb.Append(string.Format(" {0},", offset));
                sb.Append(string.Format(" {0}", limit));
            }

            return sb.ToString();
        }

        public virtual string GetSelectCommandWithQuery(int offset, int limit, Type entityType, SqlPredicate predicate, SpecialColumn[] specialColumns, SortMode[] sortModes)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(GetSelectCommand(0, 0, entityType, null, specialColumns));
            string sql = predicate.GetSql();
            if (!string.IsNullOrWhiteSpace(sql))
            {
                sb.Append(" WHERE ");
                sb.Append(sql);
            }
            if (sortModes != null && sortModes.Length > 0)
            {
                sb.Append(" ORDER BY ");
                foreach (SortMode sortMode in sortModes)
                {
                    sb.Append(sortMode.GetOrderByStatement());
                }
            }

            if (limit > 0)  //TODO: Wprowadzić obsługę dialektów SQL
            {
                sb.Append(" LIMIT ");
                if (offset > 0) sb.Append(string.Format(" {0},", offset));
                sb.Append(string.Format(" {0}", limit));
            }
            return sb.ToString();
        }

        public virtual string GetInsertCommand(Entity entity)
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
            return sb.ToString();
        }

        public virtual string GetUpdateCommand(Entity entity)
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
            return sb.ToString();
        }

        private string FormatValue(object value)
        {
            if (value is string) return string.Format("'{0}'", value == null ? value : ((string)value).Replace("'", ""));
            if (value is Guid) return string.Format("'{0}'", value);
            else return value.ToString();
        }
    }
}