using Manufaktura.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.UnitTests.Model
{
    [DataContract]
    [Mapping("provenanceToPage")]
    class ProvenanceToPage : KolbergEntity
    {
        [DataMember]
        [Mapping("ProvenanceId", ForeignTable="Provenance", ForeignColumn="Id")]
        public Guid ProvenanceId { get; set; }

        [DataMember]
        [Mapping("Volume")]
        public int Volume { get; set; }

        [DataMember]
        [Mapping("Page")]
        public int Page { get; set; }
    }
}
