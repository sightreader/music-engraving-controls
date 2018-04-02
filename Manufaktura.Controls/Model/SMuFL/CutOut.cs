using Newtonsoft.Json;

namespace Manufaktura.Controls.Model.SMuFL
{
    public partial class CutOut
    {
        [JsonProperty("cutOutNW")]
        public double[] CutOutNw { get; set; }

        [JsonProperty("cutOutSE")]
        public double[] CutOutSe { get; set; }

        [JsonProperty("cutOutSW")]
        public double[] CutOutSw { get; set; }

        [JsonProperty("cutOutNE")]
        public double[] CutOutNe { get; set; }
    }
}