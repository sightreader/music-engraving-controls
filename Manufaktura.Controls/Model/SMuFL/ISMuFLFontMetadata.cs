
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Manufaktura.Controls.Model.SMuFL
{
    public interface ISMuFLFontMetadata
    {
        [DataMember(Name="fontName")]
        string FontName { get; set; }

        [DataMember(Name="fontVersion")]
        double FontVersion { get; set; }

        [DataMember(Name="engravingDefaults")]
        Dictionary<string, double> EngravingDefaults { get; set; }

        [DataMember(Name="glyphBBoxes")]
        IGlyphBBoxes GlyphBBoxes { get; set; }

        [DataMember(Name="glyphsWithAlternates")]
        Dictionary<string, GlyphsWithAlternate> GlyphsWithAlternates { get; set; }

        [DataMember(Name="glyphsWithAnchors")]
        GlyphsWithAnchors GlyphsWithAnchors { get; set; }
        [DataMember(Name="ligatures")]
        Dictionary<string, Ligature> Ligatures { get; set; }

        [DataMember(Name="optionalGlyphs")]
        OptionalGlyphs OptionalGlyphs { get; set; }

        [DataMember(Name="sets")]
        Dictionary<string, GlyphSet> Sets { get; set; }
    }
}
