namespace Manufaktura.Controls.SMuFL
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class MusicFontMetadata
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
        public Dictionary<string, Set> Sets { get; set; }
    }

    public partial class AccdnCombDot
    {
        [JsonProperty("bBoxNE")]
        public double[] BBoxNe { get; set; }

        [JsonProperty("bBoxSW")]
        public long[] BBoxSw { get; set; }
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

    public partial class GlyphsWithAnchorsAccidental1CommaFlat
    {
        [JsonProperty("cutOutSE")]
        public double[] CutOutSe { get; set; }
    }

    public partial class GlyphsWithAnchorsAccidental1CommaSharp
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

    public partial class GlyphsWithAnchorsAccidentalArrowDown
    {
        [JsonProperty("cutOutNE")]
        public double[] CutOutNe { get; set; }

        [JsonProperty("cutOutNW")]
        public double[] CutOutNw { get; set; }
    }

    public partial class GlyphsWithAnchorsAccidentalArrowUp
    {
        [JsonProperty("cutOutSE")]
        public double[] CutOutSe { get; set; }

        [JsonProperty("cutOutSW")]
        public double[] CutOutSw { get; set; }
    }

    public partial class GlyphsWithAnchorsAccidentalDoubleFlat
    {
        [JsonProperty("cutOutNE")]
        public double[] CutOutNe { get; set; }

        [JsonProperty("cutOutSE")]
        public double[] CutOutSe { get; set; }
    }

    public partial class GlyphsWithAnchorsAccidentalDoubleFlatReversed
    {
        [JsonProperty("cutOutNW")]
        public double[] CutOutNw { get; set; }

        [JsonProperty("cutOutSW")]
        public double[] CutOutSw { get; set; }
    }

    public partial class AccidentalFiveQuarterTonesSharpArrowUp
    {
        [JsonProperty("cutOutNW")]
        public double[] CutOutNw { get; set; }
    }

    public partial class GlyphsWithAnchorsAccidentalLowerOneSeptimalComma
    {
        [JsonProperty("cutOutNE")]
        public double[] CutOutNe { get; set; }
    }

    public partial class GlyphsWithAnchorsAccidentalNatural
    {
        [JsonProperty("cutOutNE")]
        public double[] CutOutNe { get; set; }

        [JsonProperty("cutOutSW")]
        public double[] CutOutSw { get; set; }
    }

    public partial class GlyphsWithAnchorsAccidentalNaturalEqualTempered
    {
        [JsonProperty("cutOutSW")]
        public double[] CutOutSw { get; set; }
    }

    public partial class AccidentalNaturalReversed
    {
        [JsonProperty("cutOutNW")]
        public double[] CutOutNw { get; set; }

        [JsonProperty("cutOutSE")]
        public double[] CutOutSe { get; set; }
    }

    public partial class BeamAccelRit1
    {
        [JsonProperty("repeatOffset")]
        public double[] RepeatOffset { get; set; }
    }

    public partial class Dynamic
    {
        [JsonProperty("opticalCenter")]
        public double[] OpticalCenter { get; set; }
    }

    public partial class GlyphsWithAnchorsFlag1024ThDown
    {
        [JsonProperty("stemDownSW")]
        public double[] StemDownSw { get; set; }
    }

    public partial class GlyphsWithAnchorsFlag1024ThUp
    {
        [JsonProperty("stemUpNW")]
        public double[] StemUpNw { get; set; }
    }

    public partial class Flag8ThDown
    {
        [JsonProperty("graceNoteSlashNW")]
        public double[] GraceNoteSlashNw { get; set; }

        [JsonProperty("graceNoteSlashSE")]
        public double[] GraceNoteSlashSe { get; set; }

        [JsonProperty("stemDownSW")]
        public double[] StemDownSw { get; set; }
    }

    public partial class Flag8ThDownSmall
    {
        [JsonProperty("stemDownSW")]
        public long[] StemDownSw { get; set; }
    }

    public partial class Flag8ThUp
    {
        [JsonProperty("graceNoteSlashNE")]
        public double[] GraceNoteSlashNe { get; set; }

        [JsonProperty("graceNoteSlashSW")]
        public double[] GraceNoteSlashSw { get; set; }

        [JsonProperty("stemUpNW")]
        public double[] StemUpNw { get; set; }
    }

    public partial class Flag8ThUpSmall
    {
        [JsonProperty("stemUpNW")]
        public long[] StemUpNw { get; set; }
    }

    public partial class GClefLigatedNumber
    {
        [JsonProperty("numeralBottom")]
        public double[] NumeralBottom { get; set; }
    }

    public partial class GlyphsWithAnchorsNoteABlack
    {
        [JsonProperty("stemDownNW")]
        public double[] StemDownNw { get; set; }

        [JsonProperty("stemUpSE")]
        public double[] StemUpSe { get; set; }
    }

    public partial class GlyphsWithAnchorsNoteShapeDiamondBlack
    {
        [JsonProperty("stemDownNW")]
        public long[] StemDownNw { get; set; }

        [JsonProperty("stemUpSE")]
        public double[] StemUpSe { get; set; }
    }

    public partial class NoteheadCircleSlash
    {
        [JsonProperty("stemDownNW")]
        public double[] StemDownNw { get; set; }

        [JsonProperty("stemUpSE")]
        public long[] StemUpSe { get; set; }
    }

    public partial class GlyphsWithAnchorsNoteheadCircleXDoubleWhole
    {
        [JsonProperty("noteheadOrigin")]
        public double[] NoteheadOrigin { get; set; }
    }

    public partial class GlyphsWithAnchorsNoteheadCircleXHalf
    {
        [JsonProperty("stemDownNW")]
        public long[] StemDownNw { get; set; }

        [JsonProperty("stemUpSE")]
        public long[] StemUpSe { get; set; }
    }

    public partial class NoteheadBottom
    {
        [JsonProperty("stemDownNW")]
        public double[] StemDownNw { get; set; }
    }

    public partial class NoteheadTop
    {
        [JsonProperty("stemUpSE")]
        public double[] StemUpSe { get; set; }
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

    public partial class Set
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("glyphs")]
        public Glyph[] Glyphs { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Glyph
    {
        [JsonProperty("alternateFor")]
        public string AlternateFor { get; set; }

        [JsonProperty("codepoint")]
        public string Codepoint { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}