/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
namespace Manufaktura.Controls.Model.SMuFL
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class SMuFLFontMetadata
    {
        [JsonProperty("fontName")]
        public string FontName { get; set; }

        [JsonProperty("fontVersion")]
        public double FontVersion { get; set; }

        [JsonProperty("engravingDefaults")]
        public Dictionary<string, double> EngravingDefaults { get; set; }

        [JsonProperty("glyphBBoxes")]
        public GlyphBBoxes GlyphBBoxes { get; set; }

        [JsonProperty("glyphsWithAlternates")]
        public Dictionary<string, GlyphsWithAlternate> GlyphsWithAlternates { get; set; }

        [JsonProperty("glyphsWithAnchors")]
        public GlyphsWithAnchors GlyphsWithAnchors { get; set; }

        [JsonProperty("ligatures")]
        public Dictionary<string, Ligature> Ligatures { get; set; }

        [JsonProperty("optionalGlyphs")]
        public OptionalGlyphs OptionalGlyphs { get; set; }

        [JsonProperty("sets")]
        public Dictionary<string, GlyphSet> Sets { get; set; }
    }

    public partial class BoundingBox
    {
        [JsonProperty("bBoxNE")]
        public double[] BBoxNe { get; set; }

        [JsonProperty("bBoxSW")]
        public double[] BBoxSw { get; set; }
    }

    public partial class GlyphsWithAlternate
    {
        [JsonProperty("alternates")]
        public Alternate[] Alternates { get; set; }
    }

    public partial class Alternate
    {
        [JsonProperty("codepoint")]
        public string Codepoint { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class RepeatDefinition
    {
        [JsonProperty("repeatOffset")]
        public double[] RepeatOffset { get; set; }
    }

    public partial class Dynamic
    {
        [JsonProperty("opticalCenter")]
        public double[] OpticalCenter { get; set; }
    }

    public partial class GClefLigatedNumber
    {
        [JsonProperty("numeralBottom")]
        public double[] NumeralBottom { get; set; }
    }

    public partial class GlyphsWithAnchorsNoteheadCircleXDoubleWhole
    {
        [JsonProperty("noteheadOrigin")]
        public double[] NoteheadOrigin { get; set; }
    }

    public partial class Wiggle
    {
        [JsonProperty("repeatOffset")]
        public long[] RepeatOffset { get; set; }
    }

    public partial class Ligature
    {
        [JsonProperty("codepoint")]
        public string Codepoint { get; set; }

        [JsonProperty("componentGlyphs")]
        public string[] ComponentGlyphs { get; set; }
    }

    public partial class The4StringTabClefSerif
    {
        [JsonProperty("classes")]
        public string[] Classes { get; set; }

        [JsonProperty("codepoint")]
        public string Codepoint { get; set; }
    }

    public partial class AccidentalDoubleFlatParens
    {
        [JsonProperty("codepoint")]
        public string Codepoint { get; set; }
    }

}