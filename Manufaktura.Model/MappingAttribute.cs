using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Model
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