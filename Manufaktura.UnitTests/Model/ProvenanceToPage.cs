using Manufaktura.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.UnitTests.Model
{
    [DataContract]
    [Mapping("provenanceToPage")]
    class ProvenanceToPage : KolbergEntity
    {
        [DataMember]
        [Mapping("ProvenanceId", ForeignTable="Provenance", ForeignColumn="Id", Order=1)]
        public Guid ProvenanceId { get; set; }

        [DataMember]
        [Mapping("Volume", Order=2)]
        public int Volume { get; set; }

        [DataMember]
        [Mapping("Page", Order=3)]
        public int Page { get; set; }
    }
}
