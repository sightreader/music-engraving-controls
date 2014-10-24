using Manufaktura.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.UnitTests.Model
{
    [KnownType(typeof(Melody))]
    [DataContract]
    public abstract class KolbergEntity : Entity
    {
        [DataMember]
        [Mapping("Id", IsPrimaryKey = true)]
        public Guid Id { get; set; }

        protected KolbergEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
