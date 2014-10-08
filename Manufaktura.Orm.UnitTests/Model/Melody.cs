using Manufaktura.Orm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.UnitTests.Model
{
    [DataContract]
    [Mapping("melody")]
    public class Melody : KolbergEntity
    {
        [DataMember]
        [Mapping("Lyrics")]
        public string Lyrics { get; set; }

        [DataMember]
        [Mapping("Title")]
        public string Title { get; set; }

        [DataMember]
        [Mapping("ProvenanceExact")]
        public string ProvenanceExact { get; set; }

        [DataMember]
        [Mapping("Xml")]
        public string Xml { get; set; }

        [DataMember]
        [Mapping("SimpleQuery")]
        public string SimpleQuery { get; set; }

        [DataMember]
        [Mapping("RhythmQuery")]
        public string RhythmQuery { get; set; }

        [DataMember]
        [Mapping("RhythmNormalizedQuery")]
        public string RhythmNormalizedQuery { get; set; }

        [DataMember]
        [Mapping("MelodyContour1")]
        public int MelodyContour1 { get; set; }

        [DataMember]
        [Mapping("MelodyContour2")]
        public int MelodyContour2 { get; set; }

        [DataMember]
        [Mapping("MelodyContour3")]
        public int MelodyContour3 { get; set; }

        [DataMember]
        [Mapping("MelodyContour4")]
        public int MelodyContour4 { get; set; }

        [DataMember]
        [Mapping("MelodyContour5")]
        public int MelodyContour5 { get; set; }

        [DataMember]
        [Mapping("MelodyContour6")]
        public int MelodyContour6 { get; set; }

        [DataMember]
        [Mapping("MelodyContour7")]
        public int MelodyContour7 { get; set; }

        [DataMember]
        [Mapping("MelodyContour8")]
        public int MelodyContour8 { get; set; }

        [DataMember]
        [Mapping("MelodyContourDistance", IsSpecialColumn = true)]
        public double MelodyContourDistance { get; set; }
    }
}
