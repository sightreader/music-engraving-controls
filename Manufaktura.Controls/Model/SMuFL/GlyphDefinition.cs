using Newtonsoft.Json;
using System;

namespace Manufaktura.Controls.Model.SMuFL
{
    public partial class GlyphDefinition
    {
        [JsonIgnore]
        public char AlternateCharacter => GetCharFromCodepoint(AlternateCodepoint);

        [JsonProperty("alternateCodepoint")]
        public string AlternateCodepoint { get; set; }

        [JsonIgnore]
        public char Character => GetCharFromCodepoint(Codepoint);

        [JsonProperty("codepoint")]
        public string Codepoint { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }

        private static char GetCharFromCodepoint(string codepoint)
        {
            return Convert.ToChar(Convert.ToUInt32(codepoint?.Replace("U+", ""), 16));
        }
    }
}