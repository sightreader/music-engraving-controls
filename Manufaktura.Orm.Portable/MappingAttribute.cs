using System;

namespace Manufaktura.Orm.Portable
{
    public class MappingAttribute : Attribute
    {
        public MappingAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        private bool isPrimaryKey;

        public bool IsPrimaryKey
        {
            get
            {
                return isPrimaryKey;
            }
            set
            {
                isPrimaryKey = value;
                if (value) IsNotNull = true;
            }
        }

        public bool IsNotNull { get; set; }

        public bool IsSpecialColumn { get; set; }
        public int Length { get; set; }
        public string ForeignTable { get; set; }
        public string ForeignColumn { get; set; }
        public int Order { get; set; }
    }
}