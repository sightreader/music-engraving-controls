using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.Model
{
    [DataContract]
    public abstract class Entity
    {
        [DataMember]
        public bool IsNew { get; set; }

        protected Entity()
        {
            IsNew = true;
        }

        public static T FromRow<T>(DataRow row) where T : Entity, new()
        {
            T entity = new T();
            entity.IsNew = false;
            foreach (DataColumn column in row.Table.Columns)
            {
                entity.SetPropertyFromCell(column.ColumnName, row[column.ColumnName]);
            }
            return entity;
        }

        private void SetPropertyFromCell(string columnName, object cellValue)
        {
            var properties = GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (var property in properties)
            {
                MappingAttribute attribute = property.GetCustomAttributes(typeof(MappingAttribute), true).Cast<MappingAttribute>().FirstOrDefault();
                if (attribute == null) continue;
                if (attribute.Name == columnName)
                {
                    if (property.PropertyType == typeof(bool) && cellValue is Int16)
                        cellValue = (Int16)cellValue != 0;
                    if (cellValue == DBNull.Value) cellValue = null;

                    property.SetValue(this, cellValue, null);
                }
            }
        }
    }
}
