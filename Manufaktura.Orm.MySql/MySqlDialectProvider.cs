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
using System.Data;

namespace Manufaktura.Orm.Builder
{
    public class MySqlDialectProvider : DialectProvider
    {
        public MySqlDialectProvider(MySqlConnection connection)
            : base(connection)
        {

        }

        public MySqlDialectProvider(string connectionString)
            : base(new MySqlConnection(connectionString))
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
            //Jeśli kolumny nie są wyspecyfikowane, dodaj na podstawie propertiesów:
            if (!builder.AreColumnsSpecified)
            {
                foreach (PropertyInfo property in typeof(TEntity).GetOrderedProperties())
                {
                    MappingAttribute attribute = property.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
                    if (attribute == null) continue;
                    if (attribute.IsSpecialColumn) continue;    //Ta kolumna będzie dodana przez klasę SpecialColumn
                    if (!first) sb.Append(", ");
                    sb.Append(string.Format("{0}", attribute.Name));
                    first = false;
                }
            }
            else
            {
                if (!builder.SpecialColumns.Any() && !builder.Columns.Any()) sb.Append("*");    //Nie ma żadnych kolumn, ale programista użył SpecifyColumns. Dodaj gwiazdkę.
                else sb.Append(string.Join(", ", builder.Columns));  //Kolumny są wyspecyfikowane
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
                if (!Extensions.IsNullOrWhiteSpaceOrEmptyParentheses(sql))
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
            var properties = entity.GetType().GetOrderedProperties().ToList();
            foreach (var property in properties)
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
            foreach (var property in properties)
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
            foreach (var property in entity.GetType().GetOrderedProperties())
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
            sb.Append(string.Format(" WHERE {0}=@P{1};", idAttribute.Name, parameter));
            command.Parameters.Add(string.Format("@P{0}", parameter), idProperty.GetValue(entity));
            parameter++;
            
            command.CommandText = sb.ToString();
            return command;
        }

        public override DbCommand GetDeleteCommand(object id)
        {
            throw new NotImplementedException();
        }


        public override DbCommand GetUpdateSchemaCommand(Entity entity)
        {
            MappingAttribute typeAttribute = entity.GetType().GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
            if (typeAttribute == null) throw new Exception(string.Format("Nazwa tabeli nie została określona dla typu {0}.", entity.GetType().Name));

            MySqlCommand command = Connection.CreateCommand() as MySqlCommand;
            command.CommandText = string.Format("SELECT * FROM information_schema.tables WHERE table_schema = '{0}' AND table_name = '{1}' LIMIT 1;", Connection.Database, typeAttribute.Name);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            bool tableExists = table.Rows.Count > 0;

            var properties = entity.GetType().GetOrderedProperties().ToList();
            var sb = new StringBuilder();
            if (tableExists)
            {
                command = Connection.CreateCommand() as MySqlCommand;
                command.CommandText = string.Format("SHOW COLUMNS FROM {0}", typeAttribute.Name);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);

                sb.AppendFormat("ALTER TABLE {0} ", typeAttribute.Name);
                bool first = true;
                bool newPropertiesExist = false;
                foreach (var property in properties)
                {
                    MappingAttribute attribute = property.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
                    if (attribute == null) continue;
                    if (attribute.IsSpecialColumn) continue;
                    if (table.Rows.Cast<DataRow>().Any(r => (string)r["Field"] == attribute.Name)) continue;
                    if (!first) sb.Append(",");
                    newPropertiesExist = true;
                    sb.AppendFormat(" ADD COLUMN {0} {1}", attribute.Name, GetDbType(property.PropertyType, attribute));
                    first = false;
                }
                if (!newPropertiesExist) return null;
            }
            else
            {
                sb.AppendFormat("CREATE TABLE {0} (", typeAttribute.Name);
                bool first = true;
                MappingAttribute primaryKeyAttribute = null;
                var foreignKeyAttributes = new List<MappingAttribute>();
                foreach (var property in properties)
                {
                    MappingAttribute attribute = property.GetCustomAttributes(typeof(MappingAttribute), true).FirstOrDefault() as MappingAttribute;
                    if (attribute == null) continue;
                    if (attribute.IsSpecialColumn) continue;
                    if (attribute.IsPrimaryKey) primaryKeyAttribute = attribute;
                    if (!string.IsNullOrWhiteSpace(attribute.ForeignColumn) && !string.IsNullOrWhiteSpace(attribute.ForeignTable))
                    {
                        foreignKeyAttributes.Add(attribute);
                    }
                    if (!first) sb.Append(",");
                    sb.AppendFormat(" {0} {1} {2}", attribute.Name, GetDbType(property.PropertyType, attribute), attribute.IsPrimaryKey || attribute.IsNotNull ? "NOT NULL" : "DEFAULT NULL");
                    first = false;
                }
                if (primaryKeyAttribute != null)
                {
                    if (!first) sb.Append(",");
                    sb.AppendFormat(" PRIMARY KEY ({0}), UNIQUE KEY {0}_UNIQUE ({0})", primaryKeyAttribute.Name);
                }
                first = false;
                foreach (var attribute in foreignKeyAttributes)
                {
                    if (!first) sb.Append(",");
                    sb.AppendFormat(" KEY FK_{0}_idx ({0}), CONSTRAINT FK_{0} FOREIGN KEY ({0}) REFERENCES {1} ({2}) ON DELETE NO ACTION ON UPDATE NO ACTION", 
                        attribute.Name, attribute.ForeignTable, attribute.ForeignColumn);
                }
                sb.Append(") ENGINE=InnoDB DEFAULT CHARSET=utf8;");
            }

            command = Connection.CreateCommand() as MySqlCommand;
            command.CommandText = sb.ToString();
            return command;
        }

        private string GetDbType(Type type, MappingAttribute attribute)
        {
            int length = attribute.Length == 0 ? 255 : attribute.Length;
            if (type == typeof(string)) return string.Format("VARCHAR({0})", length);
            if (type == typeof(int)) return "INT";
            if (type == typeof(Guid)) return "CHAR(36)";
            return string.Format("VARCHAR({0})", length);
        }
    }
}