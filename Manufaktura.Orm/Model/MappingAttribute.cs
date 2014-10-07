using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manufaktura.Orm
{
    public class MappingAttribute : Attribute
    {
        public MappingAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public bool IsPrimaryKey { get; set; }

        public bool IsSpecialColumn { get; set; }
    }
}