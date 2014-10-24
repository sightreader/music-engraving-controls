using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Model
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
    }
}
