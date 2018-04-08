using Newtonsoft.Json;

namespace Manufaktura.Controls.Model.SMuFL
{
    public class GlyphSet
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("glyphs")]
        public Glyph[] Glyphs { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Glyph
    {
        [JsonProperty("alternateFor")]
        public string AlternateFor { get; set; }

        [JsonProperty("codepoint")]
        public string Codepoint { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}