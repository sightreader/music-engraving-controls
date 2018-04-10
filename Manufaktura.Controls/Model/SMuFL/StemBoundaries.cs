using Newtonsoft.Json;

namespace Manufaktura.Controls.Model.SMuFL
{
    public class StemBoundaries
    {
        [JsonProperty("stemDownSW")]
        public double[] StemDownSw { get; set; }

        [JsonProperty("stemUpNW")]
        public double[] StemUpNw { get; set; }

        [JsonProperty("stemDownNW")]
        public double[] StemDownNw { get; set; }

        [JsonProperty("stemUpSE")]
        public double[] StemUpSe { get; set; }
    }

    public class GraceNoteStemBoundaries : StemBoundaries
    {
        [JsonProperty("graceNoteSlashNW")]
        public double[] GraceNoteSlashNw { get; set; }

        [JsonProperty("graceNoteSlashSE")]
        public double[] GraceNoteSlashSe { get; set; }

        [JsonProperty("graceNoteSlashNE")]
        public double[] GraceNoteSlashNe { get; set; }

        [JsonProperty("graceNoteSlashSW")]
        public double[] GraceNoteSlashSw { get; set; }
    }
}