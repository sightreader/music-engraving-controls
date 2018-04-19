/*using Manufaktura.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.UnitTests.Model
{
    [DataContract]
    [Mapping("provenance")]
    public class Provenance : KolbergEntity
    {
        [DataMember]
        [Mapping("Name", Length = 255, Order = 1)]
        public string Name { get; set; }

        [DataMember]
        [Mapping("AdditionalText", Length = 512, Order = 2)]
        public string AdditionalText { get; set; }
    }
}
*/