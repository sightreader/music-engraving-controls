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
            throw new NotImplementedException();
        }

        public override DbCommand GetUpdateCommand(Entity entity)
        {
            throw new NotImplementedException();
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

            if (Limit > 0)  //TODO: Wprowadzić obsługę dialektów SQL
            {
                sb.Append(" LIMIT ");
                if (Offset > 0) sb.Append(string.Format(" {0},", Offset));
                sb.Append(string.Format(" {0}", Limit));
            }
            return sb.ToString();
        }
    }
}