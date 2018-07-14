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
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Manufaktura.Controls.Model.SMuFL
{
    public partial class GlyphsWithAnchors
    {
        [JsonProperty("accidental1CommaFlat")]
        public CutOut Accidental1CommaFlat { get; set; }

        [JsonProperty("accidental1CommaSharp")]
        public CutOut Accidental1CommaSharp { get; set; }

        [JsonProperty("accidental2CommaFlat")]
        public CutOut Accidental2CommaFlat { get; set; }

        [JsonProperty("accidental2CommaSharp")]
        public CutOut Accidental2CommaSharp { get; set; }

        [JsonProperty("accidental3CommaFlat")]
        public CutOut Accidental3CommaFlat { get; set; }

        [JsonProperty("accidental3CommaSharp")]
        public CutOut Accidental3CommaSharp { get; set; }

        [JsonProperty("accidental4CommaFlat")]
        public CutOut Accidental4CommaFlat { get; set; }

        [JsonProperty("accidental5CommaSharp")]
        public CutOut Accidental5CommaSharp { get; set; }

        [JsonProperty("accidentalArrowDown")]
        public CutOut AccidentalArrowDown { get; set; }

        [JsonProperty("accidentalArrowUp")]
        public CutOut AccidentalArrowUp { get; set; }

        [JsonProperty("accidentalBakiyeFlat")]
        public CutOut AccidentalBakiyeFlat { get; set; }

        [JsonProperty("accidentalBakiyeSharp")]
        public CutOut AccidentalBakiyeSharp { get; set; }

        [JsonProperty("accidentalBuyukMucennebFlat")]
        public CutOut AccidentalBuyukMucennebFlat { get; set; }

        [JsonProperty("accidentalBuyukMucennebSharp")]
        public CutOut AccidentalBuyukMucennebSharp { get; set; }

        [JsonProperty("accidentalDoubleFlat")]
        public CutOut AccidentalDoubleFlat { get; set; }

        [JsonProperty("accidentalDoubleFlatEqualTempered")]
        public CutOut AccidentalDoubleFlatEqualTempered { get; set; }

        [JsonProperty("accidentalDoubleFlatOneArrowDown")]
        public CutOut AccidentalDoubleFlatOneArrowDown { get; set; }

        [JsonProperty("accidentalDoubleFlatOneArrowUp")]
        public CutOut AccidentalDoubleFlatOneArrowUp { get; set; }

        [JsonProperty("accidentalDoubleFlatReversed")]
        public CutOut AccidentalDoubleFlatReversed { get; set; }

        [JsonProperty("accidentalDoubleFlatThreeArrowsDown")]
        public CutOut AccidentalDoubleFlatThreeArrowsDown { get; set; }

        [JsonProperty("accidentalDoubleFlatThreeArrowsUp")]
        public CutOut AccidentalDoubleFlatThreeArrowsUp { get; set; }

        [JsonProperty("accidentalDoubleFlatTurned")]
        public CutOut AccidentalDoubleFlatTurned { get; set; }

        [JsonProperty("accidentalDoubleFlatTwoArrowsDown")]
        public CutOut AccidentalDoubleFlatTwoArrowsDown { get; set; }

        [JsonProperty("accidentalDoubleFlatTwoArrowsUp")]
        public CutOut AccidentalDoubleFlatTwoArrowsUp { get; set; }

        [JsonProperty("accidentalFilledReversedFlatAndFlat")]
        public CutOut AccidentalFilledReversedFlatAndFlat { get; set; }

        [JsonProperty("accidentalFilledReversedFlatAndFlatArrowDown")]
        public CutOut AccidentalFilledReversedFlatAndFlatArrowDown { get; set; }

        [JsonProperty("accidentalFilledReversedFlatAndFlatArrowUp")]
        public CutOut AccidentalFilledReversedFlatAndFlatArrowUp { get; set; }

        [JsonProperty("accidentalFilledReversedFlatArrowDown")]
        public CutOut AccidentalFilledReversedFlatArrowDown { get; set; }

        [JsonProperty("accidentalFilledReversedFlatArrowUp")]
        public CutOut AccidentalFilledReversedFlatArrowUp { get; set; }

        [JsonProperty("accidentalFiveQuarterTonesFlatArrowDown")]
        public CutOut AccidentalFiveQuarterTonesFlatArrowDown { get; set; }

        [JsonProperty("CutOut")]
        public CutOut CutOut { get; set; }

        [JsonProperty("accidentalFlat")]
        public CutOut AccidentalFlat { get; set; }

        [JsonProperty("accidentalFlatEqualTempered")]
        public CutOut AccidentalFlatEqualTempered { get; set; }

        [JsonProperty("accidentalFlatOneArrowDown")]
        public CutOut AccidentalFlatOneArrowDown { get; set; }

        [JsonProperty("accidentalFlatOneArrowUp")]
        public CutOut AccidentalFlatOneArrowUp { get; set; }

        [JsonProperty("accidentalFlatThreeArrowsDown")]
        public CutOut AccidentalFlatThreeArrowsDown { get; set; }

        [JsonProperty("accidentalFlatThreeArrowsUp")]
        public CutOut AccidentalFlatThreeArrowsUp { get; set; }

        [JsonProperty("accidentalFlatTurned")]
        public CutOut AccidentalFlatTurned { get; set; }

        [JsonProperty("accidentalFlatTwoArrowsDown")]
        public CutOut AccidentalFlatTwoArrowsDown { get; set; }

        [JsonProperty("accidentalFlatTwoArrowsUp")]
        public CutOut AccidentalFlatTwoArrowsUp { get; set; }

        [JsonProperty("accidentalHalfSharpArrowDown")]
        public CutOut AccidentalHalfSharpArrowDown { get; set; }

        [JsonProperty("accidentalHalfSharpArrowUp")]
        public CutOut AccidentalHalfSharpArrowUp { get; set; }

        [JsonProperty("accidentalKomaFlat")]
        public CutOut AccidentalKomaFlat { get; set; }

        [JsonProperty("accidentalKomaSharp")]
        public CutOut AccidentalKomaSharp { get; set; }

        [JsonProperty("accidentalKoron")]
        public CutOut AccidentalKoron { get; set; }

        [JsonProperty("accidentalKucukMucennebFlat")]
        public CutOut AccidentalKucukMucennebFlat { get; set; }

        [JsonProperty("accidentalKucukMucennebSharp")]
        public CutOut AccidentalKucukMucennebSharp { get; set; }

        [JsonProperty("accidentalLowerOneSeptimalComma")]
        public CutOut AccidentalLowerOneSeptimalComma { get; set; }

        [JsonProperty("accidentalLowerOneTridecimalQuartertone")]
        public CutOut AccidentalLowerOneTridecimalQuartertone { get; set; }

        [JsonProperty("accidentalLowerOneUndecimalQuartertone")]
        public CutOut AccidentalLowerOneUndecimalQuartertone { get; set; }

        [JsonProperty("accidentalLowerTwoSeptimalCommas")]
        public CutOut AccidentalLowerTwoSeptimalCommas { get; set; }

        [JsonProperty("accidentalNarrowReversedFlat")]
        public CutOut AccidentalNarrowReversedFlat { get; set; }

        [JsonProperty("accidentalNarrowReversedFlatAndFlat")]
        public CutOut AccidentalNarrowReversedFlatAndFlat { get; set; }

        [JsonProperty("accidentalNatural")]
        public CutOut AccidentalNatural { get; set; }

        [JsonProperty("accidentalNaturalEqualTempered")]
        public CutOut AccidentalNaturalEqualTempered { get; set; }

        [JsonProperty("accidentalNaturalFlat")]
        public CutOut AccidentalNaturalFlat { get; set; }

        [JsonProperty("accidentalNaturalOneArrowDown")]
        public CutOut AccidentalNaturalOneArrowDown { get; set; }

        [JsonProperty("accidentalNaturalOneArrowUp")]
        public CutOut AccidentalNaturalOneArrowUp { get; set; }

        [JsonProperty("accidentalNaturalReversed")]
        public CutOut AccidentalNaturalReversed { get; set; }

        [JsonProperty("accidentalNaturalSharp")]
        public CutOut AccidentalNaturalSharp { get; set; }

        [JsonProperty("accidentalNaturalThreeArrowsDown")]
        public CutOut AccidentalNaturalThreeArrowsDown { get; set; }

        [JsonProperty("accidentalNaturalThreeArrowsUp")]
        public CutOut AccidentalNaturalThreeArrowsUp { get; set; }

        [JsonProperty("accidentalNaturalTwoArrowsDown")]
        public CutOut AccidentalNaturalTwoArrowsDown { get; set; }

        [JsonProperty("accidentalNaturalTwoArrowsUp")]
        public CutOut AccidentalNaturalTwoArrowsUp { get; set; }

        [JsonProperty("accidentalOneAndAHalfSharpsArrowDown")]
        public CutOut AccidentalOneAndAHalfSharpsArrowDown { get; set; }

        [JsonProperty("accidentalOneAndAHalfSharpsArrowUp")]
        public CutOut AccidentalOneAndAHalfSharpsArrowUp { get; set; }

        [JsonProperty("accidentalQuarterFlatEqualTempered")]
        public CutOut AccidentalQuarterFlatEqualTempered { get; set; }

        [JsonProperty("accidentalQuarterSharpEqualTempered")]
        public CutOut AccidentalQuarterSharpEqualTempered { get; set; }

        [JsonProperty("accidentalQuarterToneFlat4")]
        public CutOut AccidentalQuarterToneFlat4 { get; set; }

        [JsonProperty("accidentalQuarterToneFlatArrowUp")]
        public CutOut AccidentalQuarterToneFlatArrowUp { get; set; }

        [JsonProperty("accidentalQuarterToneFlatFilledReversed")]
        public CutOut AccidentalQuarterToneFlatFilledReversed { get; set; }

        [JsonProperty("accidentalQuarterToneFlatNaturalArrowDown")]
        public CutOut AccidentalQuarterToneFlatNaturalArrowDown { get; set; }

        [JsonProperty("accidentalQuarterToneFlatPenderecki")]
        public CutOut AccidentalQuarterToneFlatPenderecki { get; set; }

        [JsonProperty("accidentalQuarterToneFlatStein")]
        public CutOut AccidentalQuarterToneFlatStein { get; set; }

        [JsonProperty("accidentalQuarterToneFlatVanBlankenburg")]
        public CutOut AccidentalQuarterToneFlatVanBlankenburg { get; set; }

        [JsonProperty("accidentalQuarterToneSharp4")]
        public CutOut AccidentalQuarterToneSharp4 { get; set; }

        [JsonProperty("accidentalQuarterToneSharpArrowDown")]
        public CutOut AccidentalQuarterToneSharpArrowDown { get; set; }

        [JsonProperty("accidentalQuarterToneSharpBusotti")]
        public CutOut AccidentalQuarterToneSharpBusotti { get; set; }

        [JsonProperty("accidentalQuarterToneSharpNaturalArrowUp")]
        public CutOut AccidentalQuarterToneSharpNaturalArrowUp { get; set; }

        [JsonProperty("accidentalQuarterToneSharpStein")]
        public CutOut AccidentalQuarterToneSharpStein { get; set; }

        [JsonProperty("accidentalQuarterToneSharpWiggle")]
        public CutOut AccidentalQuarterToneSharpWiggle { get; set; }

        [JsonProperty("accidentalRaiseOneSeptimalComma")]
        public CutOut AccidentalRaiseOneSeptimalComma { get; set; }

        [JsonProperty("accidentalRaiseOneTridecimalQuartertone")]
        public CutOut AccidentalRaiseOneTridecimalQuartertone { get; set; }

        [JsonProperty("accidentalRaiseOneUndecimalQuartertone")]
        public CutOut AccidentalRaiseOneUndecimalQuartertone { get; set; }

        [JsonProperty("accidentalRaiseTwoSeptimalCommas")]
        public CutOut AccidentalRaiseTwoSeptimalCommas { get; set; }

        [JsonProperty("accidentalReversedFlatAndFlatArrowDown")]
        public CutOut AccidentalReversedFlatAndFlatArrowDown { get; set; }

        [JsonProperty("accidentalReversedFlatAndFlatArrowUp")]
        public CutOut AccidentalReversedFlatAndFlatArrowUp { get; set; }

        [JsonProperty("accidentalReversedFlatArrowDown")]
        public CutOut AccidentalReversedFlatArrowDown { get; set; }

        [JsonProperty("accidentalReversedFlatArrowUp")]
        public CutOut AccidentalReversedFlatArrowUp { get; set; }

        [JsonProperty("accidentalSharp")]
        public CutOut AccidentalSharp { get; set; }

        [JsonProperty("accidentalSharpOneArrowDown")]
        public CutOut AccidentalSharpOneArrowDown { get; set; }

        [JsonProperty("accidentalSharpOneArrowUp")]
        public CutOut AccidentalSharpOneArrowUp { get; set; }

        [JsonProperty("accidentalSharpOneHorizontalStroke")]
        public CutOut AccidentalSharpOneHorizontalStroke { get; set; }

        [JsonProperty("accidentalSharpReversed")]
        public CutOut AccidentalSharpReversed { get; set; }

        [JsonProperty("accidentalSharpSharp")]
        public CutOut AccidentalSharpSharp { get; set; }

        [JsonProperty("accidentalSharpThreeArrowsDown")]
        public CutOut AccidentalSharpThreeArrowsDown { get; set; }

        [JsonProperty("accidentalSharpThreeArrowsUp")]
        public CutOut AccidentalSharpThreeArrowsUp { get; set; }

        [JsonProperty("accidentalSharpTwoArrowsDown")]
        public CutOut AccidentalSharpTwoArrowsDown { get; set; }

        [JsonProperty("accidentalSharpTwoArrowsUp")]
        public CutOut AccidentalSharpTwoArrowsUp { get; set; }

        [JsonProperty("accidentalSims12Down")]
        public CutOut AccidentalSims12Down { get; set; }

        [JsonProperty("accidentalSims12Up")]
        public CutOut AccidentalSims12Up { get; set; }

        [JsonProperty("accidentalSims4Down")]
        public CutOut AccidentalSims4Down { get; set; }

        [JsonProperty("accidentalSims6Down")]
        public CutOut AccidentalSims6Down { get; set; }

        [JsonProperty("accidentalSims6Up")]
        public CutOut AccidentalSims6Up { get; set; }

        [JsonProperty("accidentalSori")]
        public CutOut AccidentalSori { get; set; }

        [JsonProperty("accidentalTavenerFlat")]
        public CutOut AccidentalTavenerFlat { get; set; }

        [JsonProperty("accidentalTavenerSharp")]
        public CutOut AccidentalTavenerSharp { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatArrowDown")]
        public CutOut AccidentalThreeQuarterTonesFlatArrowDown { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatArrowUp")]
        public CutOut AccidentalThreeQuarterTonesFlatArrowUp { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatCouper")]
        public CutOut AccidentalThreeQuarterTonesFlatCouper { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatGrisey")]
        public CutOut AccidentalThreeQuarterTonesFlatGrisey { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatTartini")]
        public CutOut AccidentalThreeQuarterTonesFlatTartini { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatZimmermann")]
        public CutOut AccidentalThreeQuarterTonesFlatZimmermann { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpArrowDown")]
        public CutOut AccidentalThreeQuarterTonesSharpArrowDown { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpArrowUp")]
        public CutOut AccidentalThreeQuarterTonesSharpArrowUp { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpBusotti")]
        public CutOut AccidentalThreeQuarterTonesSharpBusotti { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpStein")]
        public CutOut AccidentalThreeQuarterTonesSharpStein { get; set; }

        [JsonProperty("accidentalTripleFlat")]
        public CutOut AccidentalTripleFlat { get; set; }

        [JsonProperty("accidentalTripleSharp")]
        public CutOut AccidentalTripleSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky10TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky10TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky10TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky10TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky11TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky11TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky11TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky11TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky1TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky1TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky1TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky1TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky2TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky2TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky2TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky2TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky3TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky3TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky3TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky3TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky4TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky4TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky4TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky4TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky5TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky5TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky5TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky5TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky6TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky6TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky6TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky6TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky7TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky7TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky7TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky7TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky8TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky8TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky8TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky8TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky9TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky9TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky9TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky9TwelfthsSharp { get; set; }

        [JsonProperty("accidentalXenakisOneThirdToneSharp")]
        public CutOut AccidentalXenakisOneThirdToneSharp { get; set; }

        [JsonProperty("accidentalXenakisTwoThirdTonesSharp")]
        public CutOut AccidentalXenakisTwoThirdTonesSharp { get; set; }

        [JsonProperty("beamAccelRit1")]
        public RepeatDefinition BeamAccelRit1 { get; set; }

        [JsonProperty("beamAccelRit10")]
        public RepeatDefinition BeamAccelRit10 { get; set; }

        [JsonProperty("beamAccelRit11")]
        public RepeatDefinition BeamAccelRit11 { get; set; }

        [JsonProperty("beamAccelRit12")]
        public RepeatDefinition BeamAccelRit12 { get; set; }

        [JsonProperty("beamAccelRit13")]
        public RepeatDefinition BeamAccelRit13 { get; set; }

        [JsonProperty("beamAccelRit14")]
        public RepeatDefinition BeamAccelRit14 { get; set; }

        [JsonProperty("beamAccelRit15")]
        public RepeatDefinition BeamAccelRit15 { get; set; }

        [JsonProperty("beamAccelRit2")]
        public RepeatDefinition BeamAccelRit2 { get; set; }

        [JsonProperty("beamAccelRit3")]
        public RepeatDefinition BeamAccelRit3 { get; set; }

        [JsonProperty("beamAccelRit4")]
        public RepeatDefinition BeamAccelRit4 { get; set; }

        [JsonProperty("beamAccelRit5")]
        public RepeatDefinition BeamAccelRit5 { get; set; }

        [JsonProperty("beamAccelRit6")]
        public RepeatDefinition BeamAccelRit6 { get; set; }

        [JsonProperty("beamAccelRit7")]
        public RepeatDefinition BeamAccelRit7 { get; set; }

        [JsonProperty("beamAccelRit8")]
        public RepeatDefinition BeamAccelRit8 { get; set; }

        [JsonProperty("beamAccelRit9")]
        public RepeatDefinition BeamAccelRit9 { get; set; }

        [JsonProperty("dynamicFF")]
        public Dynamic DynamicFf { get; set; }

        [JsonProperty("dynamicFFF")]
        public Dynamic DynamicFff { get; set; }

        [JsonProperty("dynamicFFFF")]
        public Dynamic DynamicFfff { get; set; }

        [JsonProperty("dynamicFFFFF")]
        public Dynamic DynamicFffff { get; set; }

        [JsonProperty("dynamicFFFFFF")]
        public Dynamic DynamicFfffff { get; set; }

        [JsonProperty("dynamicForte")]
        public Dynamic DynamicForte { get; set; }

        [JsonProperty("dynamicFortePiano")]
        public Dynamic DynamicFortePiano { get; set; }

        [JsonProperty("dynamicForzando")]
        public Dynamic DynamicForzando { get; set; }

        [JsonProperty("dynamicMF")]
        public Dynamic DynamicMf { get; set; }

        [JsonProperty("dynamicMP")]
        public Dynamic DynamicMp { get; set; }

        [JsonProperty("dynamicMezzo")]
        public Dynamic DynamicMezzo { get; set; }

        [JsonProperty("dynamicNiente")]
        public Dynamic DynamicNiente { get; set; }

        [JsonProperty("dynamicPF")]
        public Dynamic DynamicPf { get; set; }

        [JsonProperty("dynamicPP")]
        public Dynamic DynamicPp { get; set; }

        [JsonProperty("dynamicPPP")]
        public Dynamic DynamicPpp { get; set; }

        [JsonProperty("dynamicPPPP")]
        public Dynamic DynamicPppp { get; set; }

        [JsonProperty("dynamicPPPPP")]
        public Dynamic DynamicPpppp { get; set; }

        [JsonProperty("dynamicPPPPPP")]
        public Dynamic DynamicPppppp { get; set; }

        [JsonProperty("dynamicPiano")]
        public Dynamic DynamicPiano { get; set; }

        [JsonProperty("dynamicRinforzando")]
        public Dynamic DynamicRinforzando { get; set; }

        [JsonProperty("dynamicRinforzando1")]
        public Dynamic DynamicRinforzando1 { get; set; }

        [JsonProperty("dynamicRinforzando2")]
        public Dynamic DynamicRinforzando2 { get; set; }

        [JsonProperty("dynamicSforzando")]
        public Dynamic DynamicSforzando { get; set; }

        [JsonProperty("dynamicSforzando1")]
        public Dynamic DynamicSforzando1 { get; set; }

        [JsonProperty("dynamicSforzandoPianissimo")]
        public Dynamic DynamicSforzandoPianissimo { get; set; }

        [JsonProperty("dynamicSforzandoPiano")]
        public Dynamic DynamicSforzandoPiano { get; set; }

        [JsonProperty("dynamicSforzato")]
        public Dynamic DynamicSforzato { get; set; }

        [JsonProperty("dynamicSforzatoFF")]
        public Dynamic DynamicSforzatoFf { get; set; }

        [JsonProperty("dynamicSforzatoPiano")]
        public Dynamic DynamicSforzatoPiano { get; set; }

        [JsonProperty("dynamicZ")]
        public Dynamic DynamicZ { get; set; }

        [JsonProperty("flag1024thDown")]
        public StemBoundaries Flag1024ThDown { get; set; }

        [JsonProperty("flag1024thDownSmall")]
        public StemBoundaries Flag1024ThDownSmall { get; set; }

        [JsonProperty("flag1024thDownStraight")]
        public StemBoundaries Flag1024ThDownStraight { get; set; }

        [JsonProperty("flag1024thUp")]
        public StemBoundaries Flag1024ThUp { get; set; }

        [JsonProperty("flag1024thUpShort")]
        public StemBoundaries Flag1024ThUpShort { get; set; }

        [JsonProperty("flag1024thUpSmall")]
        public StemBoundaries Flag1024ThUpSmall { get; set; }

        [JsonProperty("flag1024thUpStraight")]
        public StemBoundaries Flag1024ThUpStraight { get; set; }

        [JsonProperty("flag128thDown")]
        public StemBoundaries Flag128ThDown { get; set; }

        [JsonProperty("flag128thDownSmall")]
        public StemBoundaries Flag128ThDownSmall { get; set; }

        [JsonProperty("flag128thDownStraight")]
        public StemBoundaries Flag128ThDownStraight { get; set; }

        [JsonProperty("flag128thUp")]
        public StemBoundaries Flag128ThUp { get; set; }

        [JsonProperty("flag128thUpShort")]
        public StemBoundaries Flag128ThUpShort { get; set; }

        [JsonProperty("flag128thUpSmall")]
        public StemBoundaries Flag128ThUpSmall { get; set; }

        [JsonProperty("flag128thUpStraight")]
        public StemBoundaries Flag128ThUpStraight { get; set; }

        [JsonProperty("flag16thDown")]
        public StemBoundaries Flag16ThDown { get; set; }

        [JsonProperty("flag16thDownSmall")]
        public StemBoundaries Flag16ThDownSmall { get; set; }

        [JsonProperty("flag16thDownStraight")]
        public StemBoundaries Flag16ThDownStraight { get; set; }

        [JsonProperty("flag16thUp")]
        public StemBoundaries Flag16ThUp { get; set; }

        [JsonProperty("flag16thUpShort")]
        public StemBoundaries Flag16ThUpShort { get; set; }

        [JsonProperty("flag16thUpSmall")]
        public StemBoundaries Flag16ThUpSmall { get; set; }

        [JsonProperty("flag16thUpStraight")]
        public StemBoundaries Flag16ThUpStraight { get; set; }

        [JsonProperty("flag256thDown")]
        public StemBoundaries Flag256ThDown { get; set; }

        [JsonProperty("flag256thDownSmall")]
        public StemBoundaries Flag256ThDownSmall { get; set; }

        [JsonProperty("flag256thDownStraight")]
        public StemBoundaries Flag256ThDownStraight { get; set; }

        [JsonProperty("flag256thUp")]
        public StemBoundaries Flag256ThUp { get; set; }

        [JsonProperty("flag256thUpShort")]
        public StemBoundaries Flag256ThUpShort { get; set; }

        [JsonProperty("flag256thUpSmall")]
        public StemBoundaries Flag256ThUpSmall { get; set; }

        [JsonProperty("flag256thUpStraight")]
        public StemBoundaries Flag256ThUpStraight { get; set; }

        [JsonProperty("flag32ndDown")]
        public StemBoundaries Flag32NdDown { get; set; }

        [JsonProperty("flag32ndDownSmall")]
        public StemBoundaries Flag32NdDownSmall { get; set; }

        [JsonProperty("flag32ndDownStraight")]
        public StemBoundaries Flag32NdDownStraight { get; set; }

        [JsonProperty("flag32ndUp")]
        public StemBoundaries Flag32NdUp { get; set; }

        [JsonProperty("flag32ndUpShort")]
        public StemBoundaries Flag32NdUpShort { get; set; }

        [JsonProperty("flag32ndUpSmall")]
        public StemBoundaries Flag32NdUpSmall { get; set; }

        [JsonProperty("flag32ndUpStraight")]
        public StemBoundaries Flag32NdUpStraight { get; set; }

        [JsonProperty("flag512thDown")]
        public StemBoundaries Flag512ThDown { get; set; }

        [JsonProperty("flag512thDownSmall")]
        public StemBoundaries Flag512ThDownSmall { get; set; }

        [JsonProperty("flag512thDownStraight")]
        public StemBoundaries Flag512ThDownStraight { get; set; }

        [JsonProperty("flag512thUp")]
        public StemBoundaries Flag512ThUp { get; set; }

        [JsonProperty("flag512thUpShort")]
        public StemBoundaries Flag512ThUpShort { get; set; }

        [JsonProperty("flag512thUpSmall")]
        public StemBoundaries Flag512ThUpSmall { get; set; }

        [JsonProperty("flag512thUpStraight")]
        public StemBoundaries Flag512ThUpStraight { get; set; }

        [JsonProperty("flag64thDown")]
        public StemBoundaries Flag64ThDown { get; set; }

        [JsonProperty("flag64thDownSmall")]
        public StemBoundaries Flag64ThDownSmall { get; set; }

        [JsonProperty("flag64thDownStraight")]
        public StemBoundaries Flag64ThDownStraight { get; set; }

        [JsonProperty("flag64thUp")]
        public StemBoundaries Flag64ThUp { get; set; }

        [JsonProperty("flag64thUpShort")]
        public StemBoundaries Flag64ThUpShort { get; set; }

        [JsonProperty("flag64thUpSmall")]
        public StemBoundaries Flag64ThUpSmall { get; set; }

        [JsonProperty("flag64thUpStraight")]
        public StemBoundaries Flag64ThUpStraight { get; set; }

        [JsonProperty("flag8thDown")]
        public GraceNoteStemBoundaries Flag8ThDown { get; set; }

        [JsonProperty("StemBoundaries")]
        public StemBoundaries StemBoundaries { get; set; }

        [JsonProperty("flag8thDownStraight")]
        public StemBoundaries Flag8ThDownStraight { get; set; }

        [JsonProperty("flag8thUp")]
        public GraceNoteStemBoundaries Flag8ThUp { get; set; }

        [JsonProperty("flag8thUpShort")]
        public StemBoundaries Flag8ThUpShort { get; set; }

        [JsonProperty("flag8thUpSmall")]
        public StemBoundaries Flag8thUpSmall { get; set; }

        [JsonProperty("flag8thUpStraight")]
        public StemBoundaries Flag8ThUpStraight { get; set; }

        [JsonProperty("gClefLigatedNumberAbove")]
        public GClefLigatedNumber GClefLigatedNumberAbove { get; set; }

        [JsonProperty("gClefLigatedNumberBelow")]
        public GClefLigatedNumber GClefLigatedNumberBelow { get; set; }

        [JsonProperty("guitarVibratoStroke")]
        public RepeatDefinition GuitarVibratoStroke { get; set; }

        [JsonProperty("guitarWideVibratoStroke")]
        public RepeatDefinition GuitarWideVibratoStroke { get; set; }

        [JsonProperty("noteABlack")]
        public StemBoundaries NoteABlack { get; set; }

        [JsonProperty("noteAFlatBlack")]
        public StemBoundaries NoteAFlatBlack { get; set; }

        [JsonProperty("noteAFlatHalf")]
        public StemBoundaries NoteAFlatHalf { get; set; }

        [JsonProperty("noteAHalf")]
        public StemBoundaries NoteAHalf { get; set; }

        [JsonProperty("noteASharpBlack")]
        public StemBoundaries NoteASharpBlack { get; set; }

        [JsonProperty("noteASharpHalf")]
        public StemBoundaries NoteASharpHalf { get; set; }

        [JsonProperty("noteBBlack")]
        public StemBoundaries NoteBBlack { get; set; }

        [JsonProperty("noteBFlatBlack")]
        public StemBoundaries NoteBFlatBlack { get; set; }

        [JsonProperty("noteBFlatHalf")]
        public StemBoundaries NoteBFlatHalf { get; set; }

        [JsonProperty("noteBHalf")]
        public StemBoundaries NoteBHalf { get; set; }

        [JsonProperty("noteBSharpBlack")]
        public StemBoundaries NoteBSharpBlack { get; set; }

        [JsonProperty("noteBSharpHalf")]
        public StemBoundaries NoteBSharpHalf { get; set; }

        [JsonProperty("noteCBlack")]
        public StemBoundaries NoteCBlack { get; set; }

        [JsonProperty("noteCFlatBlack")]
        public StemBoundaries NoteCFlatBlack { get; set; }

        [JsonProperty("noteCFlatHalf")]
        public StemBoundaries NoteCFlatHalf { get; set; }

        [JsonProperty("noteCHalf")]
        public StemBoundaries NoteCHalf { get; set; }

        [JsonProperty("noteCSharpBlack")]
        public StemBoundaries NoteCSharpBlack { get; set; }

        [JsonProperty("noteCSharpHalf")]
        public StemBoundaries NoteCSharpHalf { get; set; }

        [JsonProperty("noteDBlack")]
        public StemBoundaries NoteDBlack { get; set; }

        [JsonProperty("noteDFlatBlack")]
        public StemBoundaries NoteDFlatBlack { get; set; }

        [JsonProperty("noteDFlatHalf")]
        public StemBoundaries NoteDFlatHalf { get; set; }

        [JsonProperty("noteDHalf")]
        public StemBoundaries NoteDHalf { get; set; }

        [JsonProperty("noteDSharpBlack")]
        public StemBoundaries NoteDSharpBlack { get; set; }

        [JsonProperty("noteDSharpHalf")]
        public StemBoundaries NoteDSharpHalf { get; set; }

        [JsonProperty("noteDoBlack")]
        public StemBoundaries NoteDoBlack { get; set; }

        [JsonProperty("noteDoHalf")]
        public StemBoundaries NoteDoHalf { get; set; }

        [JsonProperty("noteEBlack")]
        public StemBoundaries NoteEBlack { get; set; }

        [JsonProperty("noteEFlatBlack")]
        public StemBoundaries NoteEFlatBlack { get; set; }

        [JsonProperty("noteEFlatHalf")]
        public StemBoundaries NoteEFlatHalf { get; set; }

        [JsonProperty("noteEHalf")]
        public StemBoundaries NoteEHalf { get; set; }

        [JsonProperty("noteESharpBlack")]
        public StemBoundaries NoteESharpBlack { get; set; }

        [JsonProperty("noteESharpHalf")]
        public StemBoundaries NoteESharpHalf { get; set; }

        [JsonProperty("noteEmptyBlack")]
        public StemBoundaries NoteEmptyBlack { get; set; }

        [JsonProperty("noteEmptyHalf")]
        public StemBoundaries NoteEmptyHalf { get; set; }

        [JsonProperty("noteFBlack")]
        public StemBoundaries NoteFBlack { get; set; }

        [JsonProperty("noteFFlatBlack")]
        public StemBoundaries NoteFFlatBlack { get; set; }

        [JsonProperty("noteFFlatHalf")]
        public StemBoundaries NoteFFlatHalf { get; set; }

        [JsonProperty("noteFHalf")]
        public StemBoundaries NoteFHalf { get; set; }

        [JsonProperty("noteFSharpBlack")]
        public StemBoundaries NoteFSharpBlack { get; set; }

        [JsonProperty("noteFSharpHalf")]
        public StemBoundaries NoteFSharpHalf { get; set; }

        [JsonProperty("noteFaBlack")]
        public StemBoundaries NoteFaBlack { get; set; }

        [JsonProperty("noteFaHalf")]
        public StemBoundaries NoteFaHalf { get; set; }

        [JsonProperty("noteGBlack")]
        public StemBoundaries NoteGBlack { get; set; }

        [JsonProperty("noteGFlatBlack")]
        public StemBoundaries NoteGFlatBlack { get; set; }

        [JsonProperty("noteGFlatHalf")]
        public StemBoundaries NoteGFlatHalf { get; set; }

        [JsonProperty("noteGHalf")]
        public StemBoundaries NoteGHalf { get; set; }

        [JsonProperty("noteGSharpBlack")]
        public StemBoundaries NoteGSharpBlack { get; set; }

        [JsonProperty("noteGSharpHalf")]
        public StemBoundaries NoteGSharpHalf { get; set; }

        [JsonProperty("noteHBlack")]
        public StemBoundaries NoteHBlack { get; set; }

        [JsonProperty("noteHHalf")]
        public StemBoundaries NoteHHalf { get; set; }

        [JsonProperty("noteHSharpBlack")]
        public StemBoundaries NoteHSharpBlack { get; set; }

        [JsonProperty("noteHSharpHalf")]
        public StemBoundaries NoteHSharpHalf { get; set; }

        [JsonProperty("noteLaBlack")]
        public StemBoundaries NoteLaBlack { get; set; }

        [JsonProperty("noteLaHalf")]
        public StemBoundaries NoteLaHalf { get; set; }

        [JsonProperty("noteMiBlack")]
        public StemBoundaries NoteMiBlack { get; set; }

        [JsonProperty("noteMiHalf")]
        public StemBoundaries NoteMiHalf { get; set; }

        [JsonProperty("noteReBlack")]
        public StemBoundaries NoteReBlack { get; set; }

        [JsonProperty("noteReHalf")]
        public StemBoundaries NoteReHalf { get; set; }

        [JsonProperty("noteShapeDiamondBlack")]
        public StemBoundaries NoteShapeDiamondBlack { get; set; }

        [JsonProperty("noteShapeDiamondWhite")]
        public StemBoundaries NoteShapeDiamondWhite { get; set; }

        [JsonProperty("noteShapeMoonBlack")]
        public StemBoundaries NoteShapeMoonBlack { get; set; }

        [JsonProperty("noteShapeMoonWhite")]
        public StemBoundaries NoteShapeMoonWhite { get; set; }

        [JsonProperty("noteShapeRoundBlack")]
        public StemBoundaries NoteShapeRoundBlack { get; set; }

        [JsonProperty("noteShapeRoundWhite")]
        public StemBoundaries NoteShapeRoundWhite { get; set; }

        [JsonProperty("noteShapeSquareBlack")]
        public StemBoundaries NoteShapeSquareBlack { get; set; }

        [JsonProperty("noteShapeSquareWhite")]
        public StemBoundaries NoteShapeSquareWhite { get; set; }

        [JsonProperty("noteShapeTriangleLeftBlack")]
        public StemBoundaries NoteShapeTriangleLeftBlack { get; set; }

        [JsonProperty("noteShapeTriangleLeftWhite")]
        public StemBoundaries NoteShapeTriangleLeftWhite { get; set; }

        [JsonProperty("noteShapeTriangleRightBlack")]
        public StemBoundaries NoteShapeTriangleRightBlack { get; set; }

        [JsonProperty("noteShapeTriangleRightWhite")]
        public StemBoundaries NoteShapeTriangleRightWhite { get; set; }

        [JsonProperty("noteShapeTriangleRoundBlack")]
        public StemBoundaries NoteShapeTriangleRoundBlack { get; set; }

        [JsonProperty("noteShapeTriangleRoundWhite")]
        public StemBoundaries NoteShapeTriangleRoundWhite { get; set; }

        [JsonProperty("noteShapeTriangleUpBlack")]
        public StemBoundaries NoteShapeTriangleUpBlack { get; set; }

        [JsonProperty("noteShapeTriangleUpWhite")]
        public StemBoundaries NoteShapeTriangleUpWhite { get; set; }

        [JsonProperty("noteSiBlack")]
        public StemBoundaries NoteSiBlack { get; set; }

        [JsonProperty("noteSiHalf")]
        public StemBoundaries NoteSiHalf { get; set; }

        [JsonProperty("noteSoBlack")]
        public StemBoundaries NoteSoBlack { get; set; }

        [JsonProperty("noteSoHalf")]
        public StemBoundaries NoteSoHalf { get; set; }

        [JsonProperty("noteTiBlack")]
        public StemBoundaries NoteTiBlack { get; set; }

        [JsonProperty("noteTiHalf")]
        public StemBoundaries NoteTiHalf { get; set; }

        [JsonProperty("noteheadBlack")]
        public Dictionary<string, double[]> NoteheadBlack { get; set; }

        [JsonProperty("noteheadBlackOversized")]
        public Dictionary<string, double[]> NoteheadBlackOversized { get; set; }

        [JsonProperty("noteheadBlackSmall")]
        public StemBoundaries NoteheadBlackSmall { get; set; }

        [JsonProperty("noteheadCircleSlash")]
        public StemBoundaries NoteheadCircleSlash { get; set; }

        [JsonProperty("noteheadCircleX")]
        public StemBoundaries NoteheadCircleX { get; set; }

        [JsonProperty("noteheadCircleXDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadCircleXDoubleWhole { get; set; }

        [JsonProperty("noteheadCircleXHalf")]
        public StemBoundaries NoteheadCircleXHalf { get; set; }

        [JsonProperty("noteheadCircledBlack")]
        public StemBoundaries NoteheadCircledBlack { get; set; }

        [JsonProperty("noteheadCircledBlackLarge")]
        public StemBoundaries NoteheadCircledBlackLarge { get; set; }

        [JsonProperty("noteheadCircledDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadCircledDoubleWhole { get; set; }

        [JsonProperty("noteheadCircledDoubleWholeLarge")]
        public StemBoundaries NoteheadCircledDoubleWholeLarge { get; set; }

        [JsonProperty("noteheadCircledHalf")]
        public StemBoundaries NoteheadCircledHalf { get; set; }

        [JsonProperty("noteheadCircledHalfLarge")]
        public StemBoundaries NoteheadCircledHalfLarge { get; set; }

        [JsonProperty("noteheadCircledWholeLarge")]
        public StemBoundaries NoteheadCircledWholeLarge { get; set; }

        [JsonProperty("noteheadCircledXLarge")]
        public StemBoundaries NoteheadCircledXLarge { get; set; }

        [JsonProperty("noteheadClusterDoubleWhole2nd")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadClusterDoubleWhole2Nd { get; set; }

        [JsonProperty("noteheadClusterDoubleWhole3rd")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadClusterDoubleWhole3Rd { get; set; }

        [JsonProperty("noteheadClusterHalf2nd")]
        public StemBoundaries NoteheadClusterHalf2Nd { get; set; }

        [JsonProperty("noteheadClusterHalf3rd")]
        public StemBoundaries NoteheadClusterHalf3Rd { get; set; }

        [JsonProperty("noteheadClusterHalfBottom")]
        public StemBoundaries NoteheadClusterHalfBottom { get; set; }

        [JsonProperty("noteheadClusterHalfTop")]
        public StemBoundaries NoteheadClusterHalfTop { get; set; }

        [JsonProperty("noteheadClusterQuarter2nd")]
        public StemBoundaries NoteheadClusterQuarter2Nd { get; set; }

        [JsonProperty("noteheadClusterQuarter3rd")]
        public StemBoundaries NoteheadClusterQuarter3Rd { get; set; }

        [JsonProperty("noteheadClusterQuarterBottom")]
        public StemBoundaries NoteheadClusterQuarterBottom { get; set; }

        [JsonProperty("noteheadClusterQuarterTop")]
        public StemBoundaries NoteheadClusterQuarterTop { get; set; }

        [JsonProperty("noteheadClusterRoundBlack")]
        public StemBoundaries NoteheadClusterRoundBlack { get; set; }

        [JsonProperty("noteheadClusterRoundWhite")]
        public StemBoundaries NoteheadClusterRoundWhite { get; set; }

        [JsonProperty("noteheadClusterSquareBlack")]
        public StemBoundaries NoteheadClusterSquareBlack { get; set; }

        [JsonProperty("noteheadClusterSquareWhite")]
        public StemBoundaries NoteheadClusterSquareWhite { get; set; }

        [JsonProperty("noteheadDiamondBlack")]
        public StemBoundaries NoteheadDiamondBlack { get; set; }

        [JsonProperty("noteheadDiamondBlackOld")]
        public StemBoundaries NoteheadDiamondBlackOld { get; set; }

        [JsonProperty("noteheadDiamondBlackWide")]
        public StemBoundaries NoteheadDiamondBlackWide { get; set; }

        [JsonProperty("noteheadDiamondClusterBlack2nd")]
        public StemBoundaries NoteheadDiamondClusterBlack2Nd { get; set; }

        [JsonProperty("noteheadDiamondClusterBlack3rd")]
        public StemBoundaries NoteheadDiamondClusterBlack3Rd { get; set; }

        [JsonProperty("noteheadDiamondClusterBlackBottom")]
        public StemBoundaries NoteheadDiamondClusterBlackBottom { get; set; }

        [JsonProperty("noteheadDiamondClusterBlackTop")]
        public StemBoundaries NoteheadDiamondClusterBlackTop { get; set; }

        [JsonProperty("noteheadDiamondClusterWhite2nd")]
        public StemBoundaries NoteheadDiamondClusterWhite2Nd { get; set; }

        [JsonProperty("noteheadDiamondClusterWhite3rd")]
        public StemBoundaries NoteheadDiamondClusterWhite3Rd { get; set; }

        [JsonProperty("noteheadDiamondClusterWhiteBottom")]
        public StemBoundaries NoteheadDiamondClusterWhiteBottom { get; set; }

        [JsonProperty("noteheadDiamondClusterWhiteTop")]
        public StemBoundaries NoteheadDiamondClusterWhiteTop { get; set; }

        [JsonProperty("noteheadDiamondDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadDiamondDoubleWhole { get; set; }

        [JsonProperty("noteheadDiamondDoubleWholeOld")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadDiamondDoubleWholeOld { get; set; }

        [JsonProperty("noteheadDiamondHalf")]
        public StemBoundaries NoteheadDiamondHalf { get; set; }

        [JsonProperty("noteheadDiamondHalfFilled")]
        public StemBoundaries NoteheadDiamondHalfFilled { get; set; }

        [JsonProperty("noteheadDiamondHalfOld")]
        public StemBoundaries NoteheadDiamondHalfOld { get; set; }

        [JsonProperty("noteheadDiamondHalfWide")]
        public StemBoundaries NoteheadDiamondHalfWide { get; set; }

        [JsonProperty("noteheadDiamondOpen")]
        public StemBoundaries NoteheadDiamondOpen { get; set; }

        [JsonProperty("noteheadDiamondWhite")]
        public StemBoundaries NoteheadDiamondWhite { get; set; }

        [JsonProperty("noteheadDiamondWhiteWide")]
        public StemBoundaries NoteheadDiamondWhiteWide { get; set; }

        [JsonProperty("noteheadDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadDoubleWhole { get; set; }

        [JsonProperty("noteheadDoubleWholeOversized")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadDoubleWholeOversized { get; set; }

        [JsonProperty("noteheadDoubleWholeWithX")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadDoubleWholeWithX { get; set; }

        [JsonProperty("noteheadHalf")]
        public Dictionary<string, double[]> NoteheadHalf { get; set; }

        [JsonProperty("noteheadHalfOversized")]
        public Dictionary<string, double[]> NoteheadHalfOversized { get; set; }

        [JsonProperty("noteheadHalfSmall")]
        public StemBoundaries NoteheadHalfSmall { get; set; }

        [JsonProperty("noteheadHalfWithX")]
        public StemBoundaries NoteheadHalfWithX { get; set; }

        [JsonProperty("noteheadHeavyX")]
        public StemBoundaries NoteheadHeavyX { get; set; }

        [JsonProperty("noteheadHeavyXHat")]
        public StemBoundaries NoteheadHeavyXHat { get; set; }

        [JsonProperty("noteheadLargeArrowDownBlack")]
        public StemBoundaries NoteheadLargeArrowDownBlack { get; set; }

        [JsonProperty("noteheadLargeArrowDownDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadLargeArrowDownDoubleWhole { get; set; }

        [JsonProperty("noteheadLargeArrowDownHalf")]
        public StemBoundaries NoteheadLargeArrowDownHalf { get; set; }

        [JsonProperty("noteheadLargeArrowUpBlack")]
        public StemBoundaries NoteheadLargeArrowUpBlack { get; set; }

        [JsonProperty("noteheadLargeArrowUpDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadLargeArrowUpDoubleWhole { get; set; }

        [JsonProperty("noteheadLargeArrowUpHalf")]
        public StemBoundaries NoteheadLargeArrowUpHalf { get; set; }

        [JsonProperty("noteheadMoonBlack")]
        public StemBoundaries NoteheadMoonBlack { get; set; }

        [JsonProperty("noteheadMoonWhite")]
        public StemBoundaries NoteheadMoonWhite { get; set; }

        [JsonProperty("noteheadPlusBlack")]
        public StemBoundaries NoteheadPlusBlack { get; set; }

        [JsonProperty("noteheadPlusDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadPlusDoubleWhole { get; set; }

        [JsonProperty("noteheadPlusHalf")]
        public StemBoundaries NoteheadPlusHalf { get; set; }

        [JsonProperty("noteheadRoundBlack")]
        public StemBoundaries NoteheadRoundBlack { get; set; }

        [JsonProperty("noteheadRoundBlackDoubleSlashed")]
        public StemBoundaries NoteheadRoundBlackDoubleSlashed { get; set; }

        [JsonProperty("noteheadRoundBlackLarge")]
        public StemBoundaries NoteheadRoundBlackLarge { get; set; }

        [JsonProperty("noteheadRoundBlackSlashed")]
        public StemBoundaries NoteheadRoundBlackSlashed { get; set; }

        [JsonProperty("noteheadRoundBlackSlashedLarge")]
        public StemBoundaries NoteheadRoundBlackSlashedLarge { get; set; }

        [JsonProperty("noteheadRoundWhite")]
        public StemBoundaries NoteheadRoundWhite { get; set; }

        [JsonProperty("noteheadRoundWhiteDoubleSlashed")]
        public StemBoundaries NoteheadRoundWhiteDoubleSlashed { get; set; }

        [JsonProperty("noteheadRoundWhiteLarge")]
        public StemBoundaries NoteheadRoundWhiteLarge { get; set; }

        [JsonProperty("noteheadRoundWhiteSlashed")]
        public StemBoundaries NoteheadRoundWhiteSlashed { get; set; }

        [JsonProperty("noteheadRoundWhiteSlashedLarge")]
        public StemBoundaries NoteheadRoundWhiteSlashedLarge { get; set; }

        [JsonProperty("noteheadRoundWhiteWithDot")]
        public StemBoundaries NoteheadRoundWhiteWithDot { get; set; }

        [JsonProperty("noteheadRoundWhiteWithDotLarge")]
        public StemBoundaries NoteheadRoundWhiteWithDotLarge { get; set; }

        [JsonProperty("noteheadSlashDiamondWhite")]
        public StemBoundaries NoteheadSlashDiamondWhite { get; set; }

        [JsonProperty("noteheadSlashHorizontalEnds")]
        public StemBoundaries NoteheadSlashHorizontalEnds { get; set; }

        [JsonProperty("noteheadSlashHorizontalEndsMuted")]
        public StemBoundaries NoteheadSlashHorizontalEndsMuted { get; set; }

        [JsonProperty("noteheadSlashVerticalEnds")]
        public StemBoundaries NoteheadSlashVerticalEnds { get; set; }

        [JsonProperty("noteheadSlashVerticalEndsMuted")]
        public StemBoundaries NoteheadSlashVerticalEndsMuted { get; set; }

        [JsonProperty("noteheadSlashVerticalEndsSmall")]
        public StemBoundaries NoteheadSlashVerticalEndsSmall { get; set; }

        [JsonProperty("noteheadSlashWhiteHalf")]
        public StemBoundaries NoteheadSlashWhiteHalf { get; set; }

        [JsonProperty("noteheadSlashWhiteMuted")]
        public StemBoundaries NoteheadSlashWhiteMuted { get; set; }

        [JsonProperty("noteheadSlashX")]
        public StemBoundaries NoteheadSlashX { get; set; }

        [JsonProperty("noteheadSlashedBlack1")]
        public StemBoundaries NoteheadSlashedBlack1 { get; set; }

        [JsonProperty("noteheadSlashedBlack2")]
        public StemBoundaries NoteheadSlashedBlack2 { get; set; }

        [JsonProperty("noteheadSlashedDoubleWhole1")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadSlashedDoubleWhole1 { get; set; }

        [JsonProperty("noteheadSlashedDoubleWhole2")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadSlashedDoubleWhole2 { get; set; }

        [JsonProperty("noteheadSlashedHalf1")]
        public StemBoundaries NoteheadSlashedHalf1 { get; set; }

        [JsonProperty("noteheadSlashedHalf2")]
        public StemBoundaries NoteheadSlashedHalf2 { get; set; }

        [JsonProperty("noteheadSquareBlack")]
        public StemBoundaries NoteheadSquareBlack { get; set; }

        [JsonProperty("noteheadSquareBlackLarge")]
        public StemBoundaries NoteheadSquareBlackLarge { get; set; }

        [JsonProperty("noteheadSquareBlackWhite")]
        public StemBoundaries NoteheadSquareBlackWhite { get; set; }

        [JsonProperty("noteheadSquareWhite")]
        public StemBoundaries NoteheadSquareWhite { get; set; }

        [JsonProperty("noteheadTriangleDownBlack")]
        public StemBoundaries NoteheadTriangleDownBlack { get; set; }

        [JsonProperty("noteheadTriangleDownDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadTriangleDownDoubleWhole { get; set; }

        [JsonProperty("noteheadTriangleDownHalf")]
        public StemBoundaries NoteheadTriangleDownHalf { get; set; }

        [JsonProperty("noteheadTriangleDownWhite")]
        public StemBoundaries NoteheadTriangleDownWhite { get; set; }

        [JsonProperty("noteheadTriangleLeftBlack")]
        public StemBoundaries NoteheadTriangleLeftBlack { get; set; }

        [JsonProperty("noteheadTriangleLeftWhite")]
        public StemBoundaries NoteheadTriangleLeftWhite { get; set; }

        [JsonProperty("noteheadTriangleRightBlack")]
        public StemBoundaries NoteheadTriangleRightBlack { get; set; }

        [JsonProperty("noteheadTriangleRightWhite")]
        public StemBoundaries NoteheadTriangleRightWhite { get; set; }

        [JsonProperty("noteheadTriangleRoundDownBlack")]
        public StemBoundaries NoteheadTriangleRoundDownBlack { get; set; }

        [JsonProperty("noteheadTriangleRoundDownWhite")]
        public StemBoundaries NoteheadTriangleRoundDownWhite { get; set; }

        [JsonProperty("noteheadTriangleUpBlack")]
        public StemBoundaries NoteheadTriangleUpBlack { get; set; }

        [JsonProperty("noteheadTriangleUpDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadTriangleUpDoubleWhole { get; set; }

        [JsonProperty("noteheadTriangleUpHalf")]
        public StemBoundaries NoteheadTriangleUpHalf { get; set; }

        [JsonProperty("noteheadTriangleUpRightBlack")]
        public StemBoundaries NoteheadTriangleUpRightBlack { get; set; }

        [JsonProperty("noteheadTriangleUpRightWhite")]
        public StemBoundaries NoteheadTriangleUpRightWhite { get; set; }

        [JsonProperty("noteheadTriangleUpWhite")]
        public StemBoundaries NoteheadTriangleUpWhite { get; set; }

        [JsonProperty("noteheadVoidWithX")]
        public StemBoundaries NoteheadVoidWithX { get; set; }

        [JsonProperty("noteheadWhole")]
        public CutOut NoteheadWhole { get; set; }

        [JsonProperty("noteheadXBlack")]
        public StemBoundaries NoteheadXBlack { get; set; }

        [JsonProperty("noteheadXDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadXDoubleWhole { get; set; }

        [JsonProperty("noteheadXHalf")]
        public StemBoundaries NoteheadXHalf { get; set; }

        [JsonProperty("noteheadXOrnate")]
        public StemBoundaries NoteheadXOrnate { get; set; }

        [JsonProperty("noteheadXOrnateEllipse")]
        public StemBoundaries NoteheadXOrnateEllipse { get; set; }

        [JsonProperty("ornamentBottomLeftConcaveStroke")]
        public RepeatDefinition OrnamentBottomLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentBottomLeftConcaveStrokeLarge")]
        public RepeatDefinition OrnamentBottomLeftConcaveStrokeLarge { get; set; }

        [JsonProperty("ornamentBottomLeftConvexStroke")]
        public RepeatDefinition OrnamentBottomLeftConvexStroke { get; set; }

        [JsonProperty("ornamentHighLeftConcaveStroke")]
        public RepeatDefinition OrnamentHighLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentHighLeftConvexStroke")]
        public RepeatDefinition OrnamentHighLeftConvexStroke { get; set; }

        [JsonProperty("ornamentLeftPlus")]
        public RepeatDefinition OrnamentLeftPlus { get; set; }

        [JsonProperty("ornamentLeftShakeT")]
        public RepeatDefinition OrnamentLeftShakeT { get; set; }

        [JsonProperty("ornamentLeftVerticalStroke")]
        public RepeatDefinition OrnamentLeftVerticalStroke { get; set; }

        [JsonProperty("ornamentLeftVerticalStrokeWithCross")]
        public RepeatDefinition OrnamentLeftVerticalStrokeWithCross { get; set; }

        [JsonProperty("ornamentLowLeftConcaveStroke")]
        public RepeatDefinition OrnamentLowLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentLowLeftConvexStroke")]
        public RepeatDefinition OrnamentLowLeftConvexStroke { get; set; }

        [JsonProperty("ornamentMiddleVerticalStroke")]
        public RepeatDefinition OrnamentMiddleVerticalStroke { get; set; }

        [JsonProperty("ornamentTopLeftConcaveStroke")]
        public RepeatDefinition OrnamentTopLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentTopLeftConvexStroke")]
        public RepeatDefinition OrnamentTopLeftConvexStroke { get; set; }

        [JsonProperty("ornamentZigZagLineNoRightEnd")]
        public RepeatDefinition OrnamentZigZagLineNoRightEnd { get; set; }

        [JsonProperty("ornamentZigZagLineWithRightEnd")]
        public RepeatDefinition OrnamentZigZagLineWithRightEnd { get; set; }

        [JsonProperty("wiggleArpeggiatoDown")]
        public RepeatDefinition WiggleArpeggiatoDown { get; set; }

        [JsonProperty("wiggleArpeggiatoDownArrow")]
        public RepeatDefinition WiggleArpeggiatoDownArrow { get; set; }

        [JsonProperty("wiggleArpeggiatoDownSwash")]
        public RepeatDefinition WiggleArpeggiatoDownSwash { get; set; }

        [JsonProperty("wiggleArpeggiatoUp")]
        public RepeatDefinition WiggleArpeggiatoUp { get; set; }

        [JsonProperty("wiggleArpeggiatoUpArrow")]
        public RepeatDefinition WiggleArpeggiatoUpArrow { get; set; }

        [JsonProperty("wiggleArpeggiatoUpSwash")]
        public RepeatDefinition WiggleArpeggiatoUpSwash { get; set; }

        [JsonProperty("wiggleCircular")]
        public RepeatDefinition WiggleCircular { get; set; }

        [JsonProperty("wiggleCircularConstant")]
        public RepeatDefinition WiggleCircularConstant { get; set; }

        [JsonProperty("wiggleCircularConstantFlipped")]
        public RepeatDefinition WiggleCircularConstantFlipped { get; set; }

        [JsonProperty("wiggleCircularConstantFlippedLarge")]
        public RepeatDefinition WiggleCircularConstantFlippedLarge { get; set; }

        [JsonProperty("wiggleCircularConstantLarge")]
        public RepeatDefinition WiggleCircularConstantLarge { get; set; }

        [JsonProperty("wiggleCircularEnd")]
        public RepeatDefinition WiggleCircularEnd { get; set; }

        [JsonProperty("wiggleCircularLarge")]
        public RepeatDefinition WiggleCircularLarge { get; set; }

        [JsonProperty("wiggleCircularLarger")]
        public RepeatDefinition WiggleCircularLarger { get; set; }

        [JsonProperty("wiggleCircularLargerStill")]
        public RepeatDefinition WiggleCircularLargerStill { get; set; }

        [JsonProperty("wiggleCircularLargest")]
        public RepeatDefinition WiggleCircularLargest { get; set; }

        [JsonProperty("wiggleCircularSmall")]
        public RepeatDefinition WiggleCircularSmall { get; set; }

        [JsonProperty("wiggleCircularStart")]
        public RepeatDefinition WiggleCircularStart { get; set; }

        [JsonProperty("wiggleGlissando")]
        public RepeatDefinition WiggleGlissando { get; set; }

        [JsonProperty("wiggleGlissandoGroup1")]
        public RepeatDefinition WiggleGlissandoGroup1 { get; set; }

        [JsonProperty("wiggleGlissandoGroup2")]
        public RepeatDefinition WiggleGlissandoGroup2 { get; set; }

        [JsonProperty("wiggleGlissandoGroup3")]
        public RepeatDefinition WiggleGlissandoGroup3 { get; set; }

        [JsonProperty("wiggleRandom1")]
        public RepeatDefinition WiggleRandom1 { get; set; }

        [JsonProperty("wiggleRandom2")]
        public RepeatDefinition WiggleRandom2 { get; set; }

        [JsonProperty("wiggleRandom3")]
        public RepeatDefinition WiggleRandom3 { get; set; }

        [JsonProperty("wiggleRandom4")]
        public RepeatDefinition WiggleRandom4 { get; set; }

        [JsonProperty("wiggleSawtooth")]
        public RepeatDefinition WiggleSawtooth { get; set; }

        [JsonProperty("wiggleSawtoothNarrow")]
        public RepeatDefinition WiggleSawtoothNarrow { get; set; }

        [JsonProperty("wiggleSawtoothWide")]
        public Wiggle WiggleSawtoothWide { get; set; }

        [JsonProperty("wiggleSquareWave")]
        public Wiggle WiggleSquareWave { get; set; }

        [JsonProperty("wiggleSquareWaveNarrow")]
        public Wiggle WiggleSquareWaveNarrow { get; set; }

        [JsonProperty("wiggleSquareWaveWide")]
        public Wiggle WiggleSquareWaveWide { get; set; }

        [JsonProperty("wiggleTrill")]
        public RepeatDefinition WiggleTrill { get; set; }

        [JsonProperty("wiggleTrillFast")]
        public RepeatDefinition WiggleTrillFast { get; set; }

        [JsonProperty("wiggleTrillFaster")]
        public RepeatDefinition WiggleTrillFaster { get; set; }

        [JsonProperty("wiggleTrillFasterStill")]
        public RepeatDefinition WiggleTrillFasterStill { get; set; }

        [JsonProperty("wiggleTrillFastest")]
        public RepeatDefinition WiggleTrillFastest { get; set; }

        [JsonProperty("wiggleTrillSlow")]
        public RepeatDefinition WiggleTrillSlow { get; set; }

        [JsonProperty("wiggleTrillSlower")]
        public RepeatDefinition WiggleTrillSlower { get; set; }

        [JsonProperty("wiggleTrillSlowerStill")]
        public RepeatDefinition WiggleTrillSlowerStill { get; set; }

        [JsonProperty("wiggleTrillSlowest")]
        public RepeatDefinition WiggleTrillSlowest { get; set; }

        [JsonProperty("wiggleVIbratoLargestSlower")]
        public RepeatDefinition WiggleVIbratoLargestSlower { get; set; }

        [JsonProperty("wiggleVIbratoMediumSlower")]
        public RepeatDefinition WiggleVIbratoMediumSlower { get; set; }

        [JsonProperty("wiggleVibrato")]
        public RepeatDefinition WiggleVibrato { get; set; }

        [JsonProperty("wiggleVibratoLargeFast")]
        public RepeatDefinition WiggleVibratoLargeFast { get; set; }

        [JsonProperty("wiggleVibratoLargeFaster")]
        public RepeatDefinition WiggleVibratoLargeFaster { get; set; }

        [JsonProperty("wiggleVibratoLargeFasterStill")]
        public RepeatDefinition WiggleVibratoLargeFasterStill { get; set; }

        [JsonProperty("wiggleVibratoLargeFastest")]
        public RepeatDefinition WiggleVibratoLargeFastest { get; set; }

        [JsonProperty("wiggleVibratoLargeSlow")]
        public RepeatDefinition WiggleVibratoLargeSlow { get; set; }

        [JsonProperty("wiggleVibratoLargeSlower")]
        public RepeatDefinition WiggleVibratoLargeSlower { get; set; }

        [JsonProperty("wiggleVibratoLargeSlowest")]
        public RepeatDefinition WiggleVibratoLargeSlowest { get; set; }

        [JsonProperty("wiggleVibratoLargestFast")]
        public RepeatDefinition WiggleVibratoLargestFast { get; set; }

        [JsonProperty("wiggleVibratoLargestFaster")]
        public RepeatDefinition WiggleVibratoLargestFaster { get; set; }

        [JsonProperty("wiggleVibratoLargestFasterStill")]
        public RepeatDefinition WiggleVibratoLargestFasterStill { get; set; }

        [JsonProperty("wiggleVibratoLargestFastest")]
        public RepeatDefinition WiggleVibratoLargestFastest { get; set; }

        [JsonProperty("wiggleVibratoLargestSlow")]
        public RepeatDefinition WiggleVibratoLargestSlow { get; set; }

        [JsonProperty("wiggleVibratoLargestSlowest")]
        public RepeatDefinition WiggleVibratoLargestSlowest { get; set; }

        [JsonProperty("wiggleVibratoMediumFast")]
        public RepeatDefinition WiggleVibratoMediumFast { get; set; }

        [JsonProperty("wiggleVibratoMediumFaster")]
        public RepeatDefinition WiggleVibratoMediumFaster { get; set; }

        [JsonProperty("wiggleVibratoMediumFasterStill")]
        public RepeatDefinition WiggleVibratoMediumFasterStill { get; set; }

        [JsonProperty("wiggleVibratoMediumFastest")]
        public RepeatDefinition WiggleVibratoMediumFastest { get; set; }

        [JsonProperty("wiggleVibratoMediumSlow")]
        public RepeatDefinition WiggleVibratoMediumSlow { get; set; }

        [JsonProperty("wiggleVibratoMediumSlowest")]
        public Wiggle WiggleVibratoMediumSlowest { get; set; }

        [JsonProperty("wiggleVibratoSmallFast")]
        public RepeatDefinition WiggleVibratoSmallFast { get; set; }

        [JsonProperty("wiggleVibratoSmallFaster")]
        public RepeatDefinition WiggleVibratoSmallFaster { get; set; }

        [JsonProperty("wiggleVibratoSmallFasterStill")]
        public RepeatDefinition WiggleVibratoSmallFasterStill { get; set; }

        [JsonProperty("wiggleVibratoSmallFastest")]
        public RepeatDefinition WiggleVibratoSmallFastest { get; set; }

        [JsonProperty("wiggleVibratoSmallSlow")]
        public RepeatDefinition WiggleVibratoSmallSlow { get; set; }

        [JsonProperty("wiggleVibratoSmallSlower")]
        public RepeatDefinition WiggleVibratoSmallSlower { get; set; }

        [JsonProperty("wiggleVibratoSmallSlowest")]
        public RepeatDefinition WiggleVibratoSmallSlowest { get; set; }

        [JsonProperty("wiggleVibratoSmallestFast")]
        public RepeatDefinition WiggleVibratoSmallestFast { get; set; }

        [JsonProperty("wiggleVibratoSmallestFaster")]
        public RepeatDefinition WiggleVibratoSmallestFaster { get; set; }

        [JsonProperty("wiggleVibratoSmallestFasterStill")]
        public RepeatDefinition WiggleVibratoSmallestFasterStill { get; set; }

        [JsonProperty("wiggleVibratoSmallestFastest")]
        public RepeatDefinition WiggleVibratoSmallestFastest { get; set; }

        [JsonProperty("wiggleVibratoSmallestSlow")]
        public RepeatDefinition WiggleVibratoSmallestSlow { get; set; }

        [JsonProperty("wiggleVibratoSmallestSlower")]
        public RepeatDefinition WiggleVibratoSmallestSlower { get; set; }

        [JsonProperty("wiggleVibratoSmallestSlowest")]
        public RepeatDefinition WiggleVibratoSmallestSlowest { get; set; }

        [JsonProperty("wiggleVibratoStart")]
        public RepeatDefinition WiggleVibratoStart { get; set; }

        [JsonProperty("wiggleVibratoWide")]
        public RepeatDefinition WiggleVibratoWide { get; set; }

        [JsonProperty("wiggleWavy")]
        public Wiggle WiggleWavy { get; set; }

        [JsonProperty("wiggleWavyNarrow")]
        public Wiggle WiggleWavyNarrow { get; set; }

        [JsonProperty("wiggleWavyWide")]
        public Wiggle WiggleWavyWide { get; set; }
    }
}