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

namespace Manufaktura.Controls.Model.SMuFL
{
    public partial class OptionalGlyphs
    {
        [JsonProperty("4stringTabClefSerif")]
        public The4StringTabClefSerif The4StringTabClefSerif { get; set; }

        [JsonProperty("4stringTabClefTall")]
        public The4StringTabClefSerif The4StringTabClefTall { get; set; }

        [JsonProperty("6stringTabClefSerif")]
        public The4StringTabClefSerif The6StringTabClefSerif { get; set; }

        [JsonProperty("6stringTabClefTall")]
        public The4StringTabClefSerif The6StringTabClefTall { get; set; }

        [JsonProperty("accdnPushAlt")]
        public The4StringTabClefSerif AccdnPushAlt { get; set; }

        [JsonProperty("accidentalDoubleFlatJoinedStems")]
        public The4StringTabClefSerif AccidentalDoubleFlatJoinedStems { get; set; }

        [JsonProperty("accidentalDoubleFlatParens")]
        public AccidentalDoubleFlatParens AccidentalDoubleFlatParens { get; set; }

        [JsonProperty("accidentalDoubleSharpParens")]
        public AccidentalDoubleFlatParens AccidentalDoubleSharpParens { get; set; }

        [JsonProperty("accidentalFlatJohnstonDown")]
        public AccidentalDoubleFlatParens AccidentalFlatJohnstonDown { get; set; }

        [JsonProperty("accidentalFlatJohnstonEl")]
        public AccidentalDoubleFlatParens AccidentalFlatJohnstonEl { get; set; }

        [JsonProperty("accidentalFlatJohnstonElDown")]
        public AccidentalDoubleFlatParens AccidentalFlatJohnstonElDown { get; set; }

        [JsonProperty("accidentalFlatJohnstonUp")]
        public AccidentalDoubleFlatParens AccidentalFlatJohnstonUp { get; set; }

        [JsonProperty("accidentalFlatJohnstonUpEl")]
        public AccidentalDoubleFlatParens AccidentalFlatJohnstonUpEl { get; set; }

        [JsonProperty("accidentalFlatParens")]
        public AccidentalDoubleFlatParens AccidentalFlatParens { get; set; }

        [JsonProperty("accidentalFlatSmall")]
        public The4StringTabClefSerif AccidentalFlatSmall { get; set; }

        [JsonProperty("accidentalJohnstonDownEl")]
        public AccidentalDoubleFlatParens AccidentalJohnstonDownEl { get; set; }

        [JsonProperty("accidentalJohnstonSevenDown")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenDown { get; set; }

        [JsonProperty("accidentalJohnstonSevenFlat")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenFlat { get; set; }

        [JsonProperty("accidentalJohnstonSevenFlatDown")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenFlatDown { get; set; }

        [JsonProperty("accidentalJohnstonSevenFlatUp")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenFlatUp { get; set; }

        [JsonProperty("accidentalJohnstonSevenSharp")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenSharp { get; set; }

        [JsonProperty("accidentalJohnstonSevenSharpDown")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenSharpDown { get; set; }

        [JsonProperty("accidentalJohnstonSevenSharpUp")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenSharpUp { get; set; }

        [JsonProperty("accidentalJohnstonSevenUp")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenUp { get; set; }

        [JsonProperty("accidentalJohnstonUpEl")]
        public AccidentalDoubleFlatParens AccidentalJohnstonUpEl { get; set; }

        [JsonProperty("accidentalNaturalParens")]
        public AccidentalDoubleFlatParens AccidentalNaturalParens { get; set; }

        [JsonProperty("accidentalNaturalSmall")]
        public The4StringTabClefSerif AccidentalNaturalSmall { get; set; }

        [JsonProperty("accidentalSharpJohnstonDown")]
        public AccidentalDoubleFlatParens AccidentalSharpJohnstonDown { get; set; }

        [JsonProperty("accidentalSharpJohnstonDownEl")]
        public AccidentalDoubleFlatParens AccidentalSharpJohnstonDownEl { get; set; }

        [JsonProperty("accidentalSharpJohnstonEl")]
        public AccidentalDoubleFlatParens AccidentalSharpJohnstonEl { get; set; }

        [JsonProperty("accidentalSharpJohnstonUp")]
        public AccidentalDoubleFlatParens AccidentalSharpJohnstonUp { get; set; }

        [JsonProperty("accidentalSharpJohnstonUpEl")]
        public AccidentalDoubleFlatParens AccidentalSharpJohnstonUpEl { get; set; }

        [JsonProperty("accidentalSharpParens")]
        public AccidentalDoubleFlatParens AccidentalSharpParens { get; set; }

        [JsonProperty("accidentalSharpSmall")]
        public The4StringTabClefSerif AccidentalSharpSmall { get; set; }

        [JsonProperty("accidentalTripleFlatJoinedStems")]
        public The4StringTabClefSerif AccidentalTripleFlatJoinedStems { get; set; }

        [JsonProperty("analyticsHauptrhythmusR")]
        public The4StringTabClefSerif AnalyticsHauptrhythmusR { get; set; }

        [JsonProperty("articAccentAboveLarge")]
        public The4StringTabClefSerif ArticAccentAboveLarge { get; set; }

        [JsonProperty("articAccentAboveSmall")]
        public The4StringTabClefSerif ArticAccentAboveSmall { get; set; }

        [JsonProperty("articAccentBelowLarge")]
        public The4StringTabClefSerif ArticAccentBelowLarge { get; set; }

        [JsonProperty("articAccentBelowSmall")]
        public The4StringTabClefSerif ArticAccentBelowSmall { get; set; }

        [JsonProperty("articAccentStaccatoAboveSmall")]
        public The4StringTabClefSerif ArticAccentStaccatoAboveSmall { get; set; }

        [JsonProperty("articAccentStaccatoBelowSmall")]
        public The4StringTabClefSerif ArticAccentStaccatoBelowSmall { get; set; }

        [JsonProperty("articMarcatoAboveSmall")]
        public The4StringTabClefSerif ArticMarcatoAboveSmall { get; set; }

        [JsonProperty("articMarcatoBelowSmall")]
        public The4StringTabClefSerif ArticMarcatoBelowSmall { get; set; }

        [JsonProperty("articMarcatoStaccatoAboveSmall")]
        public The4StringTabClefSerif ArticMarcatoStaccatoAboveSmall { get; set; }

        [JsonProperty("articMarcatoStaccatoBelowSmall")]
        public The4StringTabClefSerif ArticMarcatoStaccatoBelowSmall { get; set; }

        [JsonProperty("articStaccatissimoAboveSmall")]
        public The4StringTabClefSerif ArticStaccatissimoAboveSmall { get; set; }

        [JsonProperty("articStaccatissimoBelowSmall")]
        public The4StringTabClefSerif ArticStaccatissimoBelowSmall { get; set; }

        [JsonProperty("articStaccatissimoStrokeAboveSmall")]
        public The4StringTabClefSerif ArticStaccatissimoStrokeAboveSmall { get; set; }

        [JsonProperty("articStaccatissimoStrokeBelowSmall")]
        public The4StringTabClefSerif ArticStaccatissimoStrokeBelowSmall { get; set; }

        [JsonProperty("articStaccatissimoWedgeAboveSmall")]
        public The4StringTabClefSerif ArticStaccatissimoWedgeAboveSmall { get; set; }

        [JsonProperty("articStaccatissimoWedgeBelowSmall")]
        public The4StringTabClefSerif ArticStaccatissimoWedgeBelowSmall { get; set; }

        [JsonProperty("articStaccatoAboveSmall")]
        public The4StringTabClefSerif ArticStaccatoAboveSmall { get; set; }

        [JsonProperty("articStaccatoBelowSmall")]
        public The4StringTabClefSerif ArticStaccatoBelowSmall { get; set; }

        [JsonProperty("articTenutoAboveSmall")]
        public The4StringTabClefSerif ArticTenutoAboveSmall { get; set; }

        [JsonProperty("articTenutoAccentAboveSmall")]
        public The4StringTabClefSerif ArticTenutoAccentAboveSmall { get; set; }

        [JsonProperty("articTenutoAccentBelowSmall")]
        public The4StringTabClefSerif ArticTenutoAccentBelowSmall { get; set; }

        [JsonProperty("articTenutoBelowSmall")]
        public The4StringTabClefSerif ArticTenutoBelowSmall { get; set; }

        [JsonProperty("articTenutoStaccatoAboveSmall")]
        public The4StringTabClefSerif ArticTenutoStaccatoAboveSmall { get; set; }

        [JsonProperty("articTenutoStaccatoBelowSmall")]
        public The4StringTabClefSerif ArticTenutoStaccatoBelowSmall { get; set; }

        [JsonProperty("braceFlat")]
        public The4StringTabClefSerif BraceFlat { get; set; }

        [JsonProperty("braceLarge")]
        public The4StringTabClefSerif BraceLarge { get; set; }

        [JsonProperty("braceLarger")]
        public The4StringTabClefSerif BraceLarger { get; set; }

        [JsonProperty("braceSmall")]
        public The4StringTabClefSerif BraceSmall { get; set; }

        [JsonProperty("cClefFrench")]
        public The4StringTabClefSerif CClefFrench { get; set; }

        [JsonProperty("cClefFrench20C")]
        public The4StringTabClefSerif CClefFrench20C { get; set; }

        [JsonProperty("cClefFrench20CChange")]
        public The4StringTabClefSerif CClefFrench20CChange { get; set; }

        [JsonProperty("cClefSmall")]
        public The4StringTabClefSerif CClefSmall { get; set; }

        [JsonProperty("caesuraSingleStroke")]
        public The4StringTabClefSerif CaesuraSingleStroke { get; set; }

        [JsonProperty("chantCclefHufnagel")]
        public The4StringTabClefSerif ChantCclefHufnagel { get; set; }

        [JsonProperty("chantFclefHufnagel")]
        public The4StringTabClefSerif ChantFclefHufnagel { get; set; }

        [JsonProperty("codaJapanese")]
        public The4StringTabClefSerif CodaJapanese { get; set; }

        [JsonProperty("doubleTongueAboveNoSlur")]
        public The4StringTabClefSerif DoubleTongueAboveNoSlur { get; set; }

        [JsonProperty("doubleTongueBelowNoSlur")]
        public The4StringTabClefSerif DoubleTongueBelowNoSlur { get; set; }

        [JsonProperty("dynamicForteSmall")]
        public The4StringTabClefSerif DynamicForteSmall { get; set; }

        [JsonProperty("dynamicMezzoSmall")]
        public The4StringTabClefSerif DynamicMezzoSmall { get; set; }

        [JsonProperty("dynamicNienteSmall")]
        public The4StringTabClefSerif DynamicNienteSmall { get; set; }

        [JsonProperty("dynamicPianoSmall")]
        public The4StringTabClefSerif DynamicPianoSmall { get; set; }

        [JsonProperty("dynamicRinforzandoSmall")]
        public The4StringTabClefSerif DynamicRinforzandoSmall { get; set; }

        [JsonProperty("dynamicSforzandoSmall")]
        public The4StringTabClefSerif DynamicSforzandoSmall { get; set; }

        [JsonProperty("dynamicZSmall")]
        public The4StringTabClefSerif DynamicZSmall { get; set; }

        [JsonProperty("fClef19thCentury")]
        public The4StringTabClefSerif FClef19ThCentury { get; set; }

        [JsonProperty("fClef5Below")]
        public AccidentalDoubleFlatParens FClef5Below { get; set; }

        [JsonProperty("fClefFrench")]
        public The4StringTabClefSerif FClefFrench { get; set; }

        [JsonProperty("fClefSmall")]
        public The4StringTabClefSerif FClefSmall { get; set; }

        [JsonProperty("flag1024thDownSmall")]
        public The4StringTabClefSerif Flag1024ThDownSmall { get; set; }

        [JsonProperty("flag1024thDownStraight")]
        public The4StringTabClefSerif Flag1024ThDownStraight { get; set; }

        [JsonProperty("flag1024thUpShort")]
        public The4StringTabClefSerif Flag1024ThUpShort { get; set; }

        [JsonProperty("flag1024thUpSmall")]
        public The4StringTabClefSerif Flag1024ThUpSmall { get; set; }

        [JsonProperty("flag1024thUpStraight")]
        public The4StringTabClefSerif Flag1024ThUpStraight { get; set; }

        [JsonProperty("flag128thDownSmall")]
        public The4StringTabClefSerif Flag128ThDownSmall { get; set; }

        [JsonProperty("flag128thDownStraight")]
        public The4StringTabClefSerif Flag128ThDownStraight { get; set; }

        [JsonProperty("flag128thUpShort")]
        public The4StringTabClefSerif Flag128ThUpShort { get; set; }

        [JsonProperty("flag128thUpSmall")]
        public The4StringTabClefSerif Flag128ThUpSmall { get; set; }

        [JsonProperty("flag128thUpStraight")]
        public The4StringTabClefSerif Flag128ThUpStraight { get; set; }

        [JsonProperty("flag16thDownSmall")]
        public The4StringTabClefSerif Flag16ThDownSmall { get; set; }

        [JsonProperty("flag16thDownStraight")]
        public The4StringTabClefSerif Flag16ThDownStraight { get; set; }

        [JsonProperty("flag16thUpShort")]
        public The4StringTabClefSerif Flag16ThUpShort { get; set; }

        [JsonProperty("flag16thUpSmall")]
        public The4StringTabClefSerif Flag16ThUpSmall { get; set; }

        [JsonProperty("flag16thUpStraight")]
        public The4StringTabClefSerif Flag16ThUpStraight { get; set; }

        [JsonProperty("flag256thDownSmall")]
        public The4StringTabClefSerif Flag256ThDownSmall { get; set; }

        [JsonProperty("flag256thDownStraight")]
        public The4StringTabClefSerif Flag256ThDownStraight { get; set; }

        [JsonProperty("flag256thUpShort")]
        public The4StringTabClefSerif Flag256ThUpShort { get; set; }

        [JsonProperty("flag256thUpSmall")]
        public The4StringTabClefSerif Flag256ThUpSmall { get; set; }

        [JsonProperty("flag256thUpStraight")]
        public The4StringTabClefSerif Flag256ThUpStraight { get; set; }

        [JsonProperty("flag32ndDownSmall")]
        public The4StringTabClefSerif Flag32NdDownSmall { get; set; }

        [JsonProperty("flag32ndDownStraight")]
        public The4StringTabClefSerif Flag32NdDownStraight { get; set; }

        [JsonProperty("flag32ndUpShort")]
        public The4StringTabClefSerif Flag32NdUpShort { get; set; }

        [JsonProperty("flag32ndUpSmall")]
        public The4StringTabClefSerif Flag32NdUpSmall { get; set; }

        [JsonProperty("flag32ndUpStraight")]
        public The4StringTabClefSerif Flag32NdUpStraight { get; set; }

        [JsonProperty("flag512thDownSmall")]
        public The4StringTabClefSerif Flag512ThDownSmall { get; set; }

        [JsonProperty("flag512thDownStraight")]
        public The4StringTabClefSerif Flag512ThDownStraight { get; set; }

        [JsonProperty("flag512thUpShort")]
        public The4StringTabClefSerif Flag512ThUpShort { get; set; }

        [JsonProperty("flag512thUpSmall")]
        public The4StringTabClefSerif Flag512ThUpSmall { get; set; }

        [JsonProperty("flag512thUpStraight")]
        public The4StringTabClefSerif Flag512ThUpStraight { get; set; }

        [JsonProperty("flag64thDownSmall")]
        public The4StringTabClefSerif Flag64ThDownSmall { get; set; }

        [JsonProperty("flag64thDownStraight")]
        public The4StringTabClefSerif Flag64ThDownStraight { get; set; }

        [JsonProperty("flag64thUpShort")]
        public The4StringTabClefSerif Flag64ThUpShort { get; set; }

        [JsonProperty("flag64thUpSmall")]
        public The4StringTabClefSerif Flag64ThUpSmall { get; set; }

        [JsonProperty("flag64thUpStraight")]
        public The4StringTabClefSerif Flag64ThUpStraight { get; set; }

        [JsonProperty("flag8thDownSmall")]
        public The4StringTabClefSerif Flag8ThDownSmall { get; set; }

        [JsonProperty("flag8thDownStraight")]
        public The4StringTabClefSerif Flag8ThDownStraight { get; set; }

        [JsonProperty("flag8thUpShort")]
        public The4StringTabClefSerif Flag8ThUpShort { get; set; }

        [JsonProperty("flag8thUpSmall")]
        public The4StringTabClefSerif Flag8ThUpSmall { get; set; }

        [JsonProperty("flag8thUpStraight")]
        public The4StringTabClefSerif Flag8ThUpStraight { get; set; }

        [JsonProperty("gClef0Below")]
        public AccidentalDoubleFlatParens GClef0Below { get; set; }

        [JsonProperty("gClef10Below")]
        public AccidentalDoubleFlatParens GClef10Below { get; set; }

        [JsonProperty("gClef11Below")]
        public AccidentalDoubleFlatParens GClef11Below { get; set; }

        [JsonProperty("gClef12Below")]
        public AccidentalDoubleFlatParens GClef12Below { get; set; }

        [JsonProperty("gClef13Below")]
        public AccidentalDoubleFlatParens GClef13Below { get; set; }

        [JsonProperty("gClef14Below")]
        public AccidentalDoubleFlatParens GClef14Below { get; set; }

        [JsonProperty("gClef15Below")]
        public AccidentalDoubleFlatParens GClef15Below { get; set; }

        [JsonProperty("gClef16Below")]
        public AccidentalDoubleFlatParens GClef16Below { get; set; }

        [JsonProperty("gClef17Below")]
        public AccidentalDoubleFlatParens GClef17Below { get; set; }

        [JsonProperty("gClef2Above")]
        public AccidentalDoubleFlatParens GClef2Above { get; set; }

        [JsonProperty("gClef2Below")]
        public AccidentalDoubleFlatParens GClef2Below { get; set; }

        [JsonProperty("gClef3Above")]
        public AccidentalDoubleFlatParens GClef3Above { get; set; }

        [JsonProperty("gClef3Below")]
        public AccidentalDoubleFlatParens GClef3Below { get; set; }

        [JsonProperty("gClef4Above")]
        public AccidentalDoubleFlatParens GClef4Above { get; set; }

        [JsonProperty("gClef4Below")]
        public AccidentalDoubleFlatParens GClef4Below { get; set; }

        [JsonProperty("gClef5Above")]
        public AccidentalDoubleFlatParens GClef5Above { get; set; }

        [JsonProperty("gClef5Below")]
        public AccidentalDoubleFlatParens GClef5Below { get; set; }

        [JsonProperty("gClef6Above")]
        public AccidentalDoubleFlatParens GClef6Above { get; set; }

        [JsonProperty("gClef6Below")]
        public AccidentalDoubleFlatParens GClef6Below { get; set; }

        [JsonProperty("gClef7Above")]
        public AccidentalDoubleFlatParens GClef7Above { get; set; }

        [JsonProperty("gClef7Below")]
        public AccidentalDoubleFlatParens GClef7Below { get; set; }

        [JsonProperty("gClef8Above")]
        public AccidentalDoubleFlatParens GClef8Above { get; set; }

        [JsonProperty("gClef8Below")]
        public AccidentalDoubleFlatParens GClef8Below { get; set; }

        [JsonProperty("gClef9Above")]
        public AccidentalDoubleFlatParens GClef9Above { get; set; }

        [JsonProperty("gClef9Below")]
        public AccidentalDoubleFlatParens GClef9Below { get; set; }

        [JsonProperty("gClefFlat10Below")]
        public AccidentalDoubleFlatParens GClefFlat10Below { get; set; }

        [JsonProperty("gClefFlat11Below")]
        public AccidentalDoubleFlatParens GClefFlat11Below { get; set; }

        [JsonProperty("gClefFlat13Below")]
        public AccidentalDoubleFlatParens GClefFlat13Below { get; set; }

        [JsonProperty("gClefFlat14Below")]
        public AccidentalDoubleFlatParens GClefFlat14Below { get; set; }

        [JsonProperty("gClefFlat15Below")]
        public AccidentalDoubleFlatParens GClefFlat15Below { get; set; }

        [JsonProperty("gClefFlat16Below")]
        public AccidentalDoubleFlatParens GClefFlat16Below { get; set; }

        [JsonProperty("gClefFlat1Below")]
        public AccidentalDoubleFlatParens GClefFlat1Below { get; set; }

        [JsonProperty("gClefFlat2Above")]
        public AccidentalDoubleFlatParens GClefFlat2Above { get; set; }

        [JsonProperty("gClefFlat2Below")]
        public AccidentalDoubleFlatParens GClefFlat2Below { get; set; }

        [JsonProperty("gClefFlat3Above")]
        public AccidentalDoubleFlatParens GClefFlat3Above { get; set; }

        [JsonProperty("gClefFlat3Below")]
        public AccidentalDoubleFlatParens GClefFlat3Below { get; set; }

        [JsonProperty("gClefFlat4Below")]
        public AccidentalDoubleFlatParens GClefFlat4Below { get; set; }

        [JsonProperty("gClefFlat5Above")]
        public AccidentalDoubleFlatParens GClefFlat5Above { get; set; }

        [JsonProperty("gClefFlat6Above")]
        public AccidentalDoubleFlatParens GClefFlat6Above { get; set; }

        [JsonProperty("gClefFlat6Below")]
        public AccidentalDoubleFlatParens GClefFlat6Below { get; set; }

        [JsonProperty("gClefFlat7Above")]
        public AccidentalDoubleFlatParens GClefFlat7Above { get; set; }

        [JsonProperty("gClefFlat7Below")]
        public AccidentalDoubleFlatParens GClefFlat7Below { get; set; }

        [JsonProperty("gClefFlat8Above")]
        public AccidentalDoubleFlatParens GClefFlat8Above { get; set; }

        [JsonProperty("gClefFlat9Above")]
        public AccidentalDoubleFlatParens GClefFlat9Above { get; set; }

        [JsonProperty("gClefFlat9Below")]
        public AccidentalDoubleFlatParens GClefFlat9Below { get; set; }

        [JsonProperty("gClefNat2Below")]
        public AccidentalDoubleFlatParens GClefNat2Below { get; set; }

        [JsonProperty("gClefNatural10Below")]
        public AccidentalDoubleFlatParens GClefNatural10Below { get; set; }

        [JsonProperty("gClefNatural13Below")]
        public AccidentalDoubleFlatParens GClefNatural13Below { get; set; }

        [JsonProperty("gClefNatural17Below")]
        public AccidentalDoubleFlatParens GClefNatural17Below { get; set; }

        [JsonProperty("gClefNatural2Above")]
        public AccidentalDoubleFlatParens GClefNatural2Above { get; set; }

        [JsonProperty("gClefNatural3Above")]
        public AccidentalDoubleFlatParens GClefNatural3Above { get; set; }

        [JsonProperty("gClefNatural3Below")]
        public AccidentalDoubleFlatParens GClefNatural3Below { get; set; }

        [JsonProperty("gClefNatural6Above")]
        public AccidentalDoubleFlatParens GClefNatural6Above { get; set; }

        [JsonProperty("gClefNatural6Below")]
        public AccidentalDoubleFlatParens GClefNatural6Below { get; set; }

        [JsonProperty("gClefNatural7Above")]
        public AccidentalDoubleFlatParens GClefNatural7Above { get; set; }

        [JsonProperty("gClefNatural9Above")]
        public AccidentalDoubleFlatParens GClefNatural9Above { get; set; }

        [JsonProperty("gClefNatural9Below")]
        public AccidentalDoubleFlatParens GClefNatural9Below { get; set; }

        [JsonProperty("gClefSharp12Below")]
        public AccidentalDoubleFlatParens GClefSharp12Below { get; set; }

        [JsonProperty("gClefSharp1Above")]
        public AccidentalDoubleFlatParens GClefSharp1Above { get; set; }

        [JsonProperty("gClefSharp4Above")]
        public AccidentalDoubleFlatParens GClefSharp4Above { get; set; }

        [JsonProperty("gClefSharp5Below")]
        public AccidentalDoubleFlatParens GClefSharp5Below { get; set; }

        [JsonProperty("gClefSmall")]
        public The4StringTabClefSerif GClefSmall { get; set; }

        [JsonProperty("guitarBarreHalfHorizontalFractionSlash")]
        public The4StringTabClefSerif GuitarBarreHalfHorizontalFractionSlash { get; set; }

        [JsonProperty("guitarGolpeFlamenco")]
        public The4StringTabClefSerif GuitarGolpeFlamenco { get; set; }

        [JsonProperty("harpMetalRodAlt")]
        public The4StringTabClefSerif HarpMetalRodAlt { get; set; }

        [JsonProperty("harpTuningKeyAlt")]
        public The4StringTabClefSerif HarpTuningKeyAlt { get; set; }

        [JsonProperty("keyboardPedalPedNoDot")]
        public The4StringTabClefSerif KeyboardPedalPedNoDot { get; set; }

        [JsonProperty("keyboardPedalSostNoDot")]
        public The4StringTabClefSerif KeyboardPedalSostNoDot { get; set; }

        [JsonProperty("luteFingeringRHThirdAlt")]
        public The4StringTabClefSerif LuteFingeringRhThirdAlt { get; set; }

        [JsonProperty("luteFrench10thCourseRight")]
        public The4StringTabClefSerif LuteFrench10ThCourseRight { get; set; }

        [JsonProperty("luteFrench10thCourseStrikethru")]
        public The4StringTabClefSerif LuteFrench10ThCourseStrikethru { get; set; }

        [JsonProperty("luteFrench10thCourseUnderline")]
        public The4StringTabClefSerif LuteFrench10ThCourseUnderline { get; set; }

        [JsonProperty("luteFrench7thCourseRight")]
        public The4StringTabClefSerif LuteFrench7ThCourseRight { get; set; }

        [JsonProperty("luteFrench7thCourseStrikethru")]
        public The4StringTabClefSerif LuteFrench7ThCourseStrikethru { get; set; }

        [JsonProperty("luteFrench7thCourseUnderline")]
        public The4StringTabClefSerif LuteFrench7ThCourseUnderline { get; set; }

        [JsonProperty("luteFrench8thCourseRight")]
        public The4StringTabClefSerif LuteFrench8ThCourseRight { get; set; }

        [JsonProperty("luteFrench8thCourseStrikethru")]
        public The4StringTabClefSerif LuteFrench8ThCourseStrikethru { get; set; }

        [JsonProperty("luteFrench8thCourseUnderline")]
        public The4StringTabClefSerif LuteFrench8ThCourseUnderline { get; set; }

        [JsonProperty("luteFrench9thCourseRight")]
        public The4StringTabClefSerif LuteFrench9ThCourseRight { get; set; }

        [JsonProperty("luteFrench9thCourseStrikethru")]
        public The4StringTabClefSerif LuteFrench9ThCourseStrikethru { get; set; }

        [JsonProperty("luteFrench9thCourseUnderline")]
        public The4StringTabClefSerif LuteFrench9ThCourseUnderline { get; set; }

        [JsonProperty("luteFrenchFretCAlt")]
        public The4StringTabClefSerif LuteFrenchFretCAlt { get; set; }

        [JsonProperty("medRenFlatSoftBHufnagel")]
        public The4StringTabClefSerif MedRenFlatSoftBHufnagel { get; set; }

        [JsonProperty("medRenFlatSoftBOld")]
        public The4StringTabClefSerif MedRenFlatSoftBOld { get; set; }

        [JsonProperty("mensuralCclefBlack")]
        public The4StringTabClefSerif MensuralCclefBlack { get; set; }

        [JsonProperty("mensuralCclefVoid")]
        public The4StringTabClefSerif MensuralCclefVoid { get; set; }

        [JsonProperty("mensuralFusaBlackStemDown")]
        public AccidentalDoubleFlatParens MensuralFusaBlackStemDown { get; set; }

        [JsonProperty("mensuralFusaBlackStemUp")]
        public AccidentalDoubleFlatParens MensuralFusaBlackStemUp { get; set; }

        [JsonProperty("mensuralFusaBlackVoidStemDown")]
        public AccidentalDoubleFlatParens MensuralFusaBlackVoidStemDown { get; set; }

        [JsonProperty("mensuralFusaBlackVoidStemUp")]
        public AccidentalDoubleFlatParens MensuralFusaBlackVoidStemUp { get; set; }

        [JsonProperty("mensuralFusaVoidStemDown")]
        public AccidentalDoubleFlatParens MensuralFusaVoidStemDown { get; set; }

        [JsonProperty("mensuralFusaVoidStemUp")]
        public AccidentalDoubleFlatParens MensuralFusaVoidStemUp { get; set; }

        [JsonProperty("mensuralLongaBlackStemDownLeft")]
        public AccidentalDoubleFlatParens MensuralLongaBlackStemDownLeft { get; set; }

        [JsonProperty("mensuralLongaBlackStemDownRight")]
        public AccidentalDoubleFlatParens MensuralLongaBlackStemDownRight { get; set; }

        [JsonProperty("mensuralLongaBlackStemUpLeft")]
        public AccidentalDoubleFlatParens MensuralLongaBlackStemUpLeft { get; set; }

        [JsonProperty("mensuralLongaBlackStemUpRight")]
        public AccidentalDoubleFlatParens MensuralLongaBlackStemUpRight { get; set; }

        [JsonProperty("mensuralLongaBlackVoidStemDownLeft")]
        public AccidentalDoubleFlatParens MensuralLongaBlackVoidStemDownLeft { get; set; }

        [JsonProperty("mensuralLongaBlackVoidStemDownRight")]
        public AccidentalDoubleFlatParens MensuralLongaBlackVoidStemDownRight { get; set; }

        [JsonProperty("mensuralLongaBlackVoidStemUpLeft")]
        public AccidentalDoubleFlatParens MensuralLongaBlackVoidStemUpLeft { get; set; }

        [JsonProperty("mensuralLongaBlackVoidStemUpRight")]
        public AccidentalDoubleFlatParens MensuralLongaBlackVoidStemUpRight { get; set; }

        [JsonProperty("mensuralLongaVoidStemDownLeft")]
        public AccidentalDoubleFlatParens MensuralLongaVoidStemDownLeft { get; set; }

        [JsonProperty("mensuralLongaVoidStemDownRight")]
        public AccidentalDoubleFlatParens MensuralLongaVoidStemDownRight { get; set; }

        [JsonProperty("mensuralLongaVoidStemUpLeft")]
        public AccidentalDoubleFlatParens MensuralLongaVoidStemUpLeft { get; set; }

        [JsonProperty("mensuralLongaVoidStemUpRight")]
        public AccidentalDoubleFlatParens MensuralLongaVoidStemUpRight { get; set; }

        [JsonProperty("mensuralMaximaBlackStemDownLeft")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackStemDownLeft { get; set; }

        [JsonProperty("mensuralMaximaBlackStemDownRight")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackStemDownRight { get; set; }

        [JsonProperty("mensuralMaximaBlackStemUpLeft")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackStemUpLeft { get; set; }

        [JsonProperty("mensuralMaximaBlackStemUpRight")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackStemUpRight { get; set; }

        [JsonProperty("mensuralMaximaBlackVoidStemDownLeft")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackVoidStemDownLeft { get; set; }

        [JsonProperty("mensuralMaximaBlackVoidStemDownRight")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackVoidStemDownRight { get; set; }

        [JsonProperty("mensuralMaximaBlackVoidStemUpLeft")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackVoidStemUpLeft { get; set; }

        [JsonProperty("mensuralMaximaBlackVoidStemUpRight")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackVoidStemUpRight { get; set; }

        [JsonProperty("mensuralMaximaVoidStemDownLeft")]
        public AccidentalDoubleFlatParens MensuralMaximaVoidStemDownLeft { get; set; }

        [JsonProperty("mensuralMaximaVoidStemDownRight")]
        public AccidentalDoubleFlatParens MensuralMaximaVoidStemDownRight { get; set; }

        [JsonProperty("mensuralMaximaVoidStemUpLeft")]
        public AccidentalDoubleFlatParens MensuralMaximaVoidStemUpLeft { get; set; }

        [JsonProperty("mensuralMaximaVoidStemUpRight")]
        public AccidentalDoubleFlatParens MensuralMaximaVoidStemUpRight { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDown")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemDown { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDownExtendedFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemDownExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDownFlagLeft")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemDownFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDownFlagRight")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemDownFlagRight { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDownFlaredFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemDownFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUp")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemUp { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUpExtendedFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemUpExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUpFlagLeft")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemUpFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUpFlagRight")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemUpFlagRight { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUpFlaredFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemUpFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDown")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemDown { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDownExtendedFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemDownExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDownFlagLeft")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemDownFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDownFlagRight")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemDownFlagRight { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDownFlaredFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemDownFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUp")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemUp { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUpExtendedFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemUpExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUpFlagLeft")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemUpFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUpFlagRight")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemUpFlagRight { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUpFlaredFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemUpFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDown")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemDown { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDownExtendedFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemDownExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDownFlagLeft")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemDownFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDownFlagRight")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemDownFlagRight { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDownFlaredFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemDownFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUp")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemUp { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUpExtendedFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemUpExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUpFlagLeft")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemUpFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUpFlagRight")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemUpFlagRight { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUpFlaredFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemUpFlaredFlag { get; set; }

        [JsonProperty("mensuralProportion4Old")]
        public The4StringTabClefSerif MensuralProportion4Old { get; set; }

        [JsonProperty("mensuralSemiminimaBlackStemDown")]
        public AccidentalDoubleFlatParens MensuralSemiminimaBlackStemDown { get; set; }

        [JsonProperty("mensuralSemiminimaBlackStemUp")]
        public AccidentalDoubleFlatParens MensuralSemiminimaBlackStemUp { get; set; }

        [JsonProperty("mensuralSemiminimaBlackVoidStemDown")]
        public AccidentalDoubleFlatParens MensuralSemiminimaBlackVoidStemDown { get; set; }

        [JsonProperty("mensuralSemiminimaBlackVoidStemUp")]
        public AccidentalDoubleFlatParens MensuralSemiminimaBlackVoidStemUp { get; set; }

        [JsonProperty("mensuralSemiminimaVoidStemDown")]
        public AccidentalDoubleFlatParens MensuralSemiminimaVoidStemDown { get; set; }

        [JsonProperty("mensuralSemiminimaVoidStemUp")]
        public AccidentalDoubleFlatParens MensuralSemiminimaVoidStemUp { get; set; }

        [JsonProperty("noteDoubleWholeAlt")]
        public The4StringTabClefSerif NoteDoubleWholeAlt { get; set; }

        [JsonProperty("noteheadBlackOversized")]
        public The4StringTabClefSerif NoteheadBlackOversized { get; set; }

        [JsonProperty("noteheadBlackParens")]
        public AccidentalDoubleFlatParens NoteheadBlackParens { get; set; }

        [JsonProperty("noteheadBlackSmall")]
        public The4StringTabClefSerif NoteheadBlackSmall { get; set; }

        [JsonProperty("noteheadDoubleWholeAlt")]
        public The4StringTabClefSerif NoteheadDoubleWholeAlt { get; set; }

        [JsonProperty("noteheadDoubleWholeOversized")]
        public The4StringTabClefSerif NoteheadDoubleWholeOversized { get; set; }

        [JsonProperty("noteheadDoubleWholeParens")]
        public AccidentalDoubleFlatParens NoteheadDoubleWholeParens { get; set; }

        [JsonProperty("noteheadDoubleWholeSmall")]
        public The4StringTabClefSerif NoteheadDoubleWholeSmall { get; set; }

        [JsonProperty("noteheadDoubleWholeSquareOversized")]
        public The4StringTabClefSerif NoteheadDoubleWholeSquareOversized { get; set; }

        [JsonProperty("noteheadHalfOversized")]
        public The4StringTabClefSerif NoteheadHalfOversized { get; set; }

        [JsonProperty("noteheadHalfParens")]
        public AccidentalDoubleFlatParens NoteheadHalfParens { get; set; }

        [JsonProperty("noteheadHalfSmall")]
        public The4StringTabClefSerif NoteheadHalfSmall { get; set; }

        [JsonProperty("noteheadWholeOversized")]
        public The4StringTabClefSerif NoteheadWholeOversized { get; set; }

        [JsonProperty("noteheadWholeParens")]
        public AccidentalDoubleFlatParens NoteheadWholeParens { get; set; }

        [JsonProperty("noteheadWholeSmall")]
        public The4StringTabClefSerif NoteheadWholeSmall { get; set; }

        [JsonProperty("ornamentTrillFlatAbove")]
        public AccidentalDoubleFlatParens OrnamentTrillFlatAbove { get; set; }

        [JsonProperty("ornamentTrillNaturalAbove")]
        public AccidentalDoubleFlatParens OrnamentTrillNaturalAbove { get; set; }

        [JsonProperty("ornamentTrillSharpAbove")]
        public AccidentalDoubleFlatParens OrnamentTrillSharpAbove { get; set; }

        [JsonProperty("ornamentTurnFlatAbove")]
        public AccidentalDoubleFlatParens OrnamentTurnFlatAbove { get; set; }

        [JsonProperty("ornamentTurnFlatAboveSharpBelow")]
        public AccidentalDoubleFlatParens OrnamentTurnFlatAboveSharpBelow { get; set; }

        [JsonProperty("ornamentTurnFlatBelow")]
        public AccidentalDoubleFlatParens OrnamentTurnFlatBelow { get; set; }

        [JsonProperty("ornamentTurnNaturalAbove")]
        public AccidentalDoubleFlatParens OrnamentTurnNaturalAbove { get; set; }

        [JsonProperty("ornamentTurnNaturalBelow")]
        public AccidentalDoubleFlatParens OrnamentTurnNaturalBelow { get; set; }

        [JsonProperty("ornamentTurnSharpAbove")]
        public AccidentalDoubleFlatParens OrnamentTurnSharpAbove { get; set; }

        [JsonProperty("ornamentTurnSharpAboveFlatBelow")]
        public AccidentalDoubleFlatParens OrnamentTurnSharpAboveFlatBelow { get; set; }

        [JsonProperty("ornamentTurnSharpBelow")]
        public AccidentalDoubleFlatParens OrnamentTurnSharpBelow { get; set; }

        [JsonProperty("pictBassDrumPeinkofer")]
        public The4StringTabClefSerif PictBassDrumPeinkofer { get; set; }

        [JsonProperty("pictBongosPeinkofer")]
        public The4StringTabClefSerif PictBongosPeinkofer { get; set; }

        [JsonProperty("pictCastanetsSmithBrindle")]
        public The4StringTabClefSerif PictCastanetsSmithBrindle { get; set; }

        [JsonProperty("pictCongaPeinkofer")]
        public The4StringTabClefSerif PictCongaPeinkofer { get; set; }

        [JsonProperty("pictCowBellBerio")]
        public The4StringTabClefSerif PictCowBellBerio { get; set; }

        [JsonProperty("pictFlexatonePeinkofer")]
        public The4StringTabClefSerif PictFlexatonePeinkofer { get; set; }

        [JsonProperty("pictGlspPeinkofer")]
        public The4StringTabClefSerif PictGlspPeinkofer { get; set; }

        [JsonProperty("pictGuiroPeinkofer")]
        public The4StringTabClefSerif PictGuiroPeinkofer { get; set; }

        [JsonProperty("pictGuiroSevsay")]
        public The4StringTabClefSerif PictGuiroSevsay { get; set; }

        [JsonProperty("pictLithophonePeinkofer")]
        public The4StringTabClefSerif PictLithophonePeinkofer { get; set; }

        [JsonProperty("pictLotusFlutePeinkofer")]
        public The4StringTabClefSerif PictLotusFlutePeinkofer { get; set; }

        [JsonProperty("pictMarPeinkofer")]
        public The4StringTabClefSerif PictMarPeinkofer { get; set; }

        [JsonProperty("pictMaracaSmithBrindle")]
        public The4StringTabClefSerif PictMaracaSmithBrindle { get; set; }

        [JsonProperty("pictMusicalSawPeinkofer")]
        public The4StringTabClefSerif PictMusicalSawPeinkofer { get; set; }

        [JsonProperty("pictSleighBellSmithBrindle")]
        public The4StringTabClefSerif PictSleighBellSmithBrindle { get; set; }

        [JsonProperty("pictTambourineStockhausen")]
        public The4StringTabClefSerif PictTambourineStockhausen { get; set; }

        [JsonProperty("pictTimbalesPeinkofer")]
        public The4StringTabClefSerif PictTimbalesPeinkofer { get; set; }

        [JsonProperty("pictTimpaniPeinkofer")]
        public The4StringTabClefSerif PictTimpaniPeinkofer { get; set; }

        [JsonProperty("pictTomTomChinesePeinkofer")]
        public The4StringTabClefSerif PictTomTomChinesePeinkofer { get; set; }

        [JsonProperty("pictTomTomPeinkofer")]
        public The4StringTabClefSerif PictTomTomPeinkofer { get; set; }

        [JsonProperty("pictTubaphonePeinkofer")]
        public The4StringTabClefSerif PictTubaphonePeinkofer { get; set; }

        [JsonProperty("pictVibMotorOffPeinkofer")]
        public The4StringTabClefSerif PictVibMotorOffPeinkofer { get; set; }

        [JsonProperty("pictVibPeinkofer")]
        public The4StringTabClefSerif PictVibPeinkofer { get; set; }

        [JsonProperty("pictXylBassPeinkofer")]
        public The4StringTabClefSerif PictXylBassPeinkofer { get; set; }

        [JsonProperty("pictXylPeinkofer")]
        public The4StringTabClefSerif PictXylPeinkofer { get; set; }

        [JsonProperty("pictXylTenorPeinkofer")]
        public The4StringTabClefSerif PictXylTenorPeinkofer { get; set; }

        [JsonProperty("pluckedSnapPizzicatoAboveGerman")]
        public The4StringTabClefSerif PluckedSnapPizzicatoAboveGerman { get; set; }

        [JsonProperty("pluckedSnapPizzicatoBelowGerman")]
        public The4StringTabClefSerif PluckedSnapPizzicatoBelowGerman { get; set; }

        [JsonProperty("repeatRightLeftThick")]
        public The4StringTabClefSerif RepeatRightLeftThick { get; set; }

        [JsonProperty("sedicesima")]
        public The4StringTabClefSerif Sedicesima { get; set; }

        [JsonProperty("sedicesimaAlta")]
        public The4StringTabClefSerif SedicesimaAlta { get; set; }

        [JsonProperty("sedicesimaBassa")]
        public The4StringTabClefSerif SedicesimaBassa { get; set; }

        [JsonProperty("sedicesimaBassaMb")]
        public The4StringTabClefSerif SedicesimaBassaMb { get; set; }

        [JsonProperty("segnoJapanese")]
        public The4StringTabClefSerif SegnoJapanese { get; set; }

        [JsonProperty("stringsChangeBowDirectionImposed")]
        public The4StringTabClefSerif StringsChangeBowDirectionImposed { get; set; }

        [JsonProperty("stringsChangeBowDirectionLiga")]
        public The4StringTabClefSerif StringsChangeBowDirectionLiga { get; set; }

        [JsonProperty("timeSig0Denominator")]
        public AccidentalDoubleFlatParens TimeSig0Denominator { get; set; }

        [JsonProperty("timeSig0Large")]
        public The4StringTabClefSerif TimeSig0Large { get; set; }

        [JsonProperty("timeSig0Numerator")]
        public AccidentalDoubleFlatParens TimeSig0Numerator { get; set; }

        [JsonProperty("timeSig0Small")]
        public The4StringTabClefSerif TimeSig0Small { get; set; }

        [JsonProperty("timeSig12over8")]
        public AccidentalDoubleFlatParens TimeSig12Over8 { get; set; }

        [JsonProperty("timeSig1Denominator")]
        public AccidentalDoubleFlatParens TimeSig1Denominator { get; set; }

        [JsonProperty("timeSig1Large")]
        public The4StringTabClefSerif TimeSig1Large { get; set; }

        [JsonProperty("timeSig1Numerator")]
        public AccidentalDoubleFlatParens TimeSig1Numerator { get; set; }

        [JsonProperty("timeSig1Small")]
        public The4StringTabClefSerif TimeSig1Small { get; set; }

        [JsonProperty("timeSig2Denominator")]
        public AccidentalDoubleFlatParens TimeSig2Denominator { get; set; }

        [JsonProperty("timeSig2Large")]
        public The4StringTabClefSerif TimeSig2Large { get; set; }

        [JsonProperty("timeSig2Numerator")]
        public AccidentalDoubleFlatParens TimeSig2Numerator { get; set; }

        [JsonProperty("timeSig2Small")]
        public The4StringTabClefSerif TimeSig2Small { get; set; }

        [JsonProperty("timeSig2over2")]
        public AccidentalDoubleFlatParens TimeSig2Over2 { get; set; }

        [JsonProperty("timeSig2over4")]
        public AccidentalDoubleFlatParens TimeSig2Over4 { get; set; }

        [JsonProperty("timeSig3Denominator")]
        public AccidentalDoubleFlatParens TimeSig3Denominator { get; set; }

        [JsonProperty("timeSig3Large")]
        public The4StringTabClefSerif TimeSig3Large { get; set; }

        [JsonProperty("timeSig3Numerator")]
        public AccidentalDoubleFlatParens TimeSig3Numerator { get; set; }

        [JsonProperty("timeSig3Small")]
        public The4StringTabClefSerif TimeSig3Small { get; set; }

        [JsonProperty("timeSig3over2")]
        public AccidentalDoubleFlatParens TimeSig3Over2 { get; set; }

        [JsonProperty("timeSig3over4")]
        public AccidentalDoubleFlatParens TimeSig3Over4 { get; set; }

        [JsonProperty("timeSig3over8")]
        public AccidentalDoubleFlatParens TimeSig3Over8 { get; set; }

        [JsonProperty("timeSig4Denominator")]
        public AccidentalDoubleFlatParens TimeSig4Denominator { get; set; }

        [JsonProperty("timeSig4Large")]
        public The4StringTabClefSerif TimeSig4Large { get; set; }

        [JsonProperty("timeSig4Numerator")]
        public AccidentalDoubleFlatParens TimeSig4Numerator { get; set; }

        [JsonProperty("timeSig4Small")]
        public The4StringTabClefSerif TimeSig4Small { get; set; }

        [JsonProperty("timeSig4over4")]
        public AccidentalDoubleFlatParens TimeSig4Over4 { get; set; }

        [JsonProperty("timeSig5Denominator")]
        public AccidentalDoubleFlatParens TimeSig5Denominator { get; set; }

        [JsonProperty("timeSig5Large")]
        public The4StringTabClefSerif TimeSig5Large { get; set; }

        [JsonProperty("timeSig5Numerator")]
        public AccidentalDoubleFlatParens TimeSig5Numerator { get; set; }

        [JsonProperty("timeSig5Small")]
        public The4StringTabClefSerif TimeSig5Small { get; set; }

        [JsonProperty("timeSig5over4")]
        public AccidentalDoubleFlatParens TimeSig5Over4 { get; set; }

        [JsonProperty("timeSig5over8")]
        public AccidentalDoubleFlatParens TimeSig5Over8 { get; set; }

        [JsonProperty("timeSig6Denominator")]
        public AccidentalDoubleFlatParens TimeSig6Denominator { get; set; }

        [JsonProperty("timeSig6Large")]
        public The4StringTabClefSerif TimeSig6Large { get; set; }

        [JsonProperty("timeSig6Numerator")]
        public AccidentalDoubleFlatParens TimeSig6Numerator { get; set; }

        [JsonProperty("timeSig6Small")]
        public The4StringTabClefSerif TimeSig6Small { get; set; }

        [JsonProperty("timeSig6over4")]
        public AccidentalDoubleFlatParens TimeSig6Over4 { get; set; }

        [JsonProperty("timeSig6over8")]
        public AccidentalDoubleFlatParens TimeSig6Over8 { get; set; }

        [JsonProperty("timeSig7Denominator")]
        public AccidentalDoubleFlatParens TimeSig7Denominator { get; set; }

        [JsonProperty("timeSig7Large")]
        public The4StringTabClefSerif TimeSig7Large { get; set; }

        [JsonProperty("timeSig7Numerator")]
        public AccidentalDoubleFlatParens TimeSig7Numerator { get; set; }

        [JsonProperty("timeSig7Small")]
        public The4StringTabClefSerif TimeSig7Small { get; set; }

        [JsonProperty("timeSig7over8")]
        public AccidentalDoubleFlatParens TimeSig7Over8 { get; set; }

        [JsonProperty("timeSig8Denominator")]
        public AccidentalDoubleFlatParens TimeSig8Denominator { get; set; }

        [JsonProperty("timeSig8Large")]
        public The4StringTabClefSerif TimeSig8Large { get; set; }

        [JsonProperty("timeSig8Numerator")]
        public AccidentalDoubleFlatParens TimeSig8Numerator { get; set; }

        [JsonProperty("timeSig8Small")]
        public The4StringTabClefSerif TimeSig8Small { get; set; }

        [JsonProperty("timeSig9Denominator")]
        public AccidentalDoubleFlatParens TimeSig9Denominator { get; set; }

        [JsonProperty("timeSig9Large")]
        public The4StringTabClefSerif TimeSig9Large { get; set; }

        [JsonProperty("timeSig9Numerator")]
        public AccidentalDoubleFlatParens TimeSig9Numerator { get; set; }

        [JsonProperty("timeSig9Small")]
        public The4StringTabClefSerif TimeSig9Small { get; set; }

        [JsonProperty("timeSig9over8")]
        public AccidentalDoubleFlatParens TimeSig9Over8 { get; set; }

        [JsonProperty("timeSigCommonLarge")]
        public The4StringTabClefSerif TimeSigCommonLarge { get; set; }

        [JsonProperty("timeSigCutCommonLarge")]
        public The4StringTabClefSerif TimeSigCutCommonLarge { get; set; }

        [JsonProperty("timeSigPlusLarge")]
        public The4StringTabClefSerif TimeSigPlusLarge { get; set; }

        [JsonProperty("tripleTongueAboveNoSlur")]
        public The4StringTabClefSerif TripleTongueAboveNoSlur { get; set; }

        [JsonProperty("tripleTongueBelowNoSlur")]
        public The4StringTabClefSerif TripleTongueBelowNoSlur { get; set; }

        [JsonProperty("unpitchedPercussionClef1Alt")]
        public The4StringTabClefSerif UnpitchedPercussionClef1Alt { get; set; }

        [JsonProperty("ventiquattresima")]
        public The4StringTabClefSerif Ventiquattresima { get; set; }

        [JsonProperty("ventiquattresimaAlta")]
        public The4StringTabClefSerif VentiquattresimaAlta { get; set; }

        [JsonProperty("ventiquattresimaBassa")]
        public The4StringTabClefSerif VentiquattresimaBassa { get; set; }

        [JsonProperty("ventiquattresimaBassaMb")]
        public The4StringTabClefSerif VentiquattresimaBassaMb { get; set; }

        [JsonProperty("wiggleArpeggiatoDownSwashCouperin")]
        public The4StringTabClefSerif WiggleArpeggiatoDownSwashCouperin { get; set; }

        [JsonProperty("wiggleArpeggiatoUpSwashCouperin")]
        public The4StringTabClefSerif WiggleArpeggiatoUpSwashCouperin { get; set; }
    }
}