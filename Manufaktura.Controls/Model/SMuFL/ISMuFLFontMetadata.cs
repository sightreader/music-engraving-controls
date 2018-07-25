using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manufaktura.Controls.Model.SMuFL
{
    public interface ISMuFLFontMetadata
    {
        [JsonProperty("fontName")]
        string FontName { get; set; }

        [JsonProperty("fontVersion")]
        double FontVersion { get; set; }

        [JsonProperty("engravingDefaults")]
        Dictionary<string, double> EngravingDefaults { get; set; }

        [JsonProperty("glyphBBoxes")]
        IGlyphBBoxes GlyphBBoxes { get; set; }

        [JsonProperty("glyphsWithAlternates")]
        Dictionary<string, GlyphsWithAlternate> GlyphsWithAlternates { get; set; }

        [JsonProperty("glyphsWithAnchors")]
        GlyphsWithAnchors GlyphsWithAnchors { get; set; }
        [JsonProperty("ligatures")]
        Dictionary<string, Ligature> Ligatures { get; set; }

        [JsonProperty("optionalGlyphs")]
        OptionalGlyphs OptionalGlyphs { get; set; }

        [JsonProperty("sets")]
        Dictionary<string, GlyphSet> Sets { get; set; }
    }
}
