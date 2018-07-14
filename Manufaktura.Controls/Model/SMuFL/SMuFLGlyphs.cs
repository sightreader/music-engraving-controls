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
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Manufaktura.Controls.Model.SMuFL
{
    public class SMuFLGlyphs
    {
        private static Lazy<SMuFLGlyphs> instance = new Lazy<SMuFLGlyphs>(() =>
        {
            var assembly = typeof(SMuFLGlyphs).GetTypeInfo().Assembly;
            //var x = assembly.GetManifestResourceNames();
            var resourceName = $"{typeof(SMuFLGlyphs).Namespace}.glyphnames.json";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<SMuFLGlyphs>(result);
            }
        });

        public string BuildTimeSignatureNumberFromGlyphs(int number)
        {
            var sb = new StringBuilder();
            var digits = number.ToString();
            foreach (var digit in digits)
            {
                if (digit == '0') sb.Append(TimeSig0.Character);
                if (digit == '1') sb.Append(TimeSig1.Character);
                if (digit == '2') sb.Append(TimeSig2.Character);
                if (digit == '3') sb.Append(TimeSig3.Character);
                if (digit == '4') sb.Append(TimeSig4.Character);
                if (digit == '5') sb.Append(TimeSig5.Character);
                if (digit == '6') sb.Append(TimeSig6.Character);
                if (digit == '7') sb.Append(TimeSig7.Character);
                if (digit == '8') sb.Append(TimeSig8.Character);
                if (digit == '9') sb.Append(TimeSig9.Character);
            }
            return sb.ToString();
        }

        public string BuildTupletNumberFromGlyphs(int number)
        {
            var sb = new StringBuilder();
            var digits = number.ToString();
            foreach (var digit in digits)
            {
                if (digit == '0') sb.Append(Tuplet0.Character);
                if (digit == '1') sb.Append(Tuplet1.Character);
                if (digit == '2') sb.Append(Tuplet2.Character);
                if (digit == '3') sb.Append(Tuplet3.Character);
                if (digit == '4') sb.Append(Tuplet4.Character);
                if (digit == '5') sb.Append(Tuplet5.Character);
                if (digit == '6') sb.Append(Tuplet6.Character);
                if (digit == '7') sb.Append(Tuplet7.Character);
                if (digit == '8') sb.Append(Tuplet8.Character);
                if (digit == '9') sb.Append(Tuplet9.Character);
            }
            return sb.ToString();
        }

        public static SMuFLGlyphs Instance => instance.Value;

        [JsonProperty("4stringTabClef")]
        public GlyphDefinition The4StringTabClef { get; set; }

        [JsonProperty("6stringTabClef")]
        public GlyphDefinition The6StringTabClef { get; set; }

        [JsonProperty("accSagittal11LargeDiesisDown")]
        public GlyphDefinition AccSagittal11LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal11LargeDiesisUp")]
        public GlyphDefinition AccSagittal11LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal11MediumDiesisDown")]
        public GlyphDefinition AccSagittal11MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal11MediumDiesisUp")]
        public GlyphDefinition AccSagittal11MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal11v19LargeDiesisDown")]
        public GlyphDefinition AccSagittal11V19LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal11v19LargeDiesisUp")]
        public GlyphDefinition AccSagittal11V19LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal11v19MediumDiesisDown")]
        public GlyphDefinition AccSagittal11V19MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal11v19MediumDiesisUp")]
        public GlyphDefinition AccSagittal11V19MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal11v49CommaDown")]
        public GlyphDefinition AccSagittal11V49CommaDown { get; set; }

        [JsonProperty("accSagittal11v49CommaUp")]
        public GlyphDefinition AccSagittal11V49CommaUp { get; set; }

        [JsonProperty("accSagittal143CommaDown")]
        public GlyphDefinition AccSagittal143CommaDown { get; set; }

        [JsonProperty("accSagittal143CommaUp")]
        public GlyphDefinition AccSagittal143CommaUp { get; set; }

        [JsonProperty("accSagittal17CommaDown")]
        public GlyphDefinition AccSagittal17CommaDown { get; set; }

        [JsonProperty("accSagittal17CommaUp")]
        public GlyphDefinition AccSagittal17CommaUp { get; set; }

        [JsonProperty("accSagittal17KleismaDown")]
        public GlyphDefinition AccSagittal17KleismaDown { get; set; }

        [JsonProperty("accSagittal17KleismaUp")]
        public GlyphDefinition AccSagittal17KleismaUp { get; set; }

        [JsonProperty("accSagittal19CommaDown")]
        public GlyphDefinition AccSagittal19CommaDown { get; set; }

        [JsonProperty("accSagittal19CommaUp")]
        public GlyphDefinition AccSagittal19CommaUp { get; set; }

        [JsonProperty("accSagittal19SchismaDown")]
        public GlyphDefinition AccSagittal19SchismaDown { get; set; }

        [JsonProperty("accSagittal19SchismaUp")]
        public GlyphDefinition AccSagittal19SchismaUp { get; set; }

        [JsonProperty("accSagittal23CommaDown")]
        public GlyphDefinition AccSagittal23CommaDown { get; set; }

        [JsonProperty("accSagittal23CommaUp")]
        public GlyphDefinition AccSagittal23CommaUp { get; set; }

        [JsonProperty("accSagittal23SmallDiesisDown")]
        public GlyphDefinition AccSagittal23SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal23SmallDiesisUp")]
        public GlyphDefinition AccSagittal23SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal25SmallDiesisDown")]
        public GlyphDefinition AccSagittal25SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal25SmallDiesisUp")]
        public GlyphDefinition AccSagittal25SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal35LargeDiesisDown")]
        public GlyphDefinition AccSagittal35LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal35LargeDiesisUp")]
        public GlyphDefinition AccSagittal35LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal35MediumDiesisDown")]
        public GlyphDefinition AccSagittal35MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal35MediumDiesisUp")]
        public GlyphDefinition AccSagittal35MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal49LargeDiesisDown")]
        public GlyphDefinition AccSagittal49LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal49LargeDiesisUp")]
        public GlyphDefinition AccSagittal49LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal49MediumDiesisDown")]
        public GlyphDefinition AccSagittal49MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal49MediumDiesisUp")]
        public GlyphDefinition AccSagittal49MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal49SmallDiesisDown")]
        public GlyphDefinition AccSagittal49SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal49SmallDiesisUp")]
        public GlyphDefinition AccSagittal49SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal55CommaDown")]
        public GlyphDefinition AccSagittal55CommaDown { get; set; }

        [JsonProperty("accSagittal55CommaUp")]
        public GlyphDefinition AccSagittal55CommaUp { get; set; }

        [JsonProperty("accSagittal5CommaDown")]
        public GlyphDefinition AccSagittal5CommaDown { get; set; }

        [JsonProperty("accSagittal5CommaUp")]
        public GlyphDefinition AccSagittal5CommaUp { get; set; }

        [JsonProperty("accSagittal5v11SmallDiesisDown")]
        public GlyphDefinition AccSagittal5V11SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal5v11SmallDiesisUp")]
        public GlyphDefinition AccSagittal5V11SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal5v13LargeDiesisDown")]
        public GlyphDefinition AccSagittal5V13LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal5v13LargeDiesisUp")]
        public GlyphDefinition AccSagittal5V13LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal5v13MediumDiesisDown")]
        public GlyphDefinition AccSagittal5V13MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal5v13MediumDiesisUp")]
        public GlyphDefinition AccSagittal5V13MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal5v19CommaDown")]
        public GlyphDefinition AccSagittal5V19CommaDown { get; set; }

        [JsonProperty("accSagittal5v19CommaUp")]
        public GlyphDefinition AccSagittal5V19CommaUp { get; set; }

        [JsonProperty("accSagittal5v23SmallDiesisDown")]
        public GlyphDefinition AccSagittal5V23SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal5v23SmallDiesisUp")]
        public GlyphDefinition AccSagittal5V23SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal5v49MediumDiesisDown")]
        public GlyphDefinition AccSagittal5V49MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal5v49MediumDiesisUp")]
        public GlyphDefinition AccSagittal5V49MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal5v7KleismaDown")]
        public GlyphDefinition AccSagittal5V7KleismaDown { get; set; }

        [JsonProperty("accSagittal5v7KleismaUp")]
        public GlyphDefinition AccSagittal5V7KleismaUp { get; set; }

        [JsonProperty("accSagittal7CommaDown")]
        public GlyphDefinition AccSagittal7CommaDown { get; set; }

        [JsonProperty("accSagittal7CommaUp")]
        public GlyphDefinition AccSagittal7CommaUp { get; set; }

        [JsonProperty("accSagittal7v11CommaDown")]
        public GlyphDefinition AccSagittal7V11CommaDown { get; set; }

        [JsonProperty("accSagittal7v11CommaUp")]
        public GlyphDefinition AccSagittal7V11CommaUp { get; set; }

        [JsonProperty("accSagittal7v11KleismaDown")]
        public GlyphDefinition AccSagittal7V11KleismaDown { get; set; }

        [JsonProperty("accSagittal7v11KleismaUp")]
        public GlyphDefinition AccSagittal7V11KleismaUp { get; set; }

        [JsonProperty("accSagittal7v19CommaDown")]
        public GlyphDefinition AccSagittal7V19CommaDown { get; set; }

        [JsonProperty("accSagittal7v19CommaUp")]
        public GlyphDefinition AccSagittal7V19CommaUp { get; set; }

        [JsonProperty("accSagittalAcute")]
        public GlyphDefinition AccSagittalAcute { get; set; }

        [JsonProperty("accSagittalDoubleFlat")]
        public GlyphDefinition AccSagittalDoubleFlat { get; set; }

        [JsonProperty("accSagittalDoubleFlat11v49CUp")]
        public GlyphDefinition AccSagittalDoubleFlat11V49CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat143CUp")]
        public GlyphDefinition AccSagittalDoubleFlat143CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat17CUp")]
        public GlyphDefinition AccSagittalDoubleFlat17CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat17kUp")]
        public GlyphDefinition AccSagittalDoubleFlat17KUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat19CUp")]
        public GlyphDefinition AccSagittalDoubleFlat19CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat19sUp")]
        public GlyphDefinition AccSagittalDoubleFlat19SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat23CUp")]
        public GlyphDefinition AccSagittalDoubleFlat23CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat23SUp")]
        public GlyphDefinition AccSagittalDoubleFlat23SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat25SUp")]
        public GlyphDefinition AccSagittalDoubleFlat25SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat49SUp")]
        public GlyphDefinition AccSagittalDoubleFlat49SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat55CUp")]
        public GlyphDefinition AccSagittalDoubleFlat55CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5CUp")]
        public GlyphDefinition AccSagittalDoubleFlat5CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5v11SUp")]
        public GlyphDefinition AccSagittalDoubleFlat5V11SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5v19CUp")]
        public GlyphDefinition AccSagittalDoubleFlat5V19CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5v23SUp")]
        public GlyphDefinition AccSagittalDoubleFlat5V23SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5v7kUp")]
        public GlyphDefinition AccSagittalDoubleFlat5V7KUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat7CUp")]
        public GlyphDefinition AccSagittalDoubleFlat7CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat7v11CUp")]
        public GlyphDefinition AccSagittalDoubleFlat7V11CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat7v11kUp")]
        public GlyphDefinition AccSagittalDoubleFlat7V11KUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat7v19CUp")]
        public GlyphDefinition AccSagittalDoubleFlat7V19CUp { get; set; }

        [JsonProperty("accSagittalDoubleSharp")]
        public GlyphDefinition AccSagittalDoubleSharp { get; set; }

        [JsonProperty("accSagittalDoubleSharp11v49CDown")]
        public GlyphDefinition AccSagittalDoubleSharp11V49CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp143CDown")]
        public GlyphDefinition AccSagittalDoubleSharp143CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp17CDown")]
        public GlyphDefinition AccSagittalDoubleSharp17CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp17kDown")]
        public GlyphDefinition AccSagittalDoubleSharp17KDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp19CDown")]
        public GlyphDefinition AccSagittalDoubleSharp19CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp19sDown")]
        public GlyphDefinition AccSagittalDoubleSharp19SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp23CDown")]
        public GlyphDefinition AccSagittalDoubleSharp23CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp23SDown")]
        public GlyphDefinition AccSagittalDoubleSharp23SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp25SDown")]
        public GlyphDefinition AccSagittalDoubleSharp25SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp49SDown")]
        public GlyphDefinition AccSagittalDoubleSharp49SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp55CDown")]
        public GlyphDefinition AccSagittalDoubleSharp55CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5CDown")]
        public GlyphDefinition AccSagittalDoubleSharp5CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5v11SDown")]
        public GlyphDefinition AccSagittalDoubleSharp5V11SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5v19CDown")]
        public GlyphDefinition AccSagittalDoubleSharp5V19CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5v23SDown")]
        public GlyphDefinition AccSagittalDoubleSharp5V23SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5v7kDown")]
        public GlyphDefinition AccSagittalDoubleSharp5V7KDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp7CDown")]
        public GlyphDefinition AccSagittalDoubleSharp7CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp7v11CDown")]
        public GlyphDefinition AccSagittalDoubleSharp7V11CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp7v11kDown")]
        public GlyphDefinition AccSagittalDoubleSharp7V11KDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp7v19CDown")]
        public GlyphDefinition AccSagittalDoubleSharp7V19CDown { get; set; }

        [JsonProperty("accSagittalFlat")]
        public GlyphDefinition AccSagittalFlat { get; set; }

        [JsonProperty("accSagittalFlat11LDown")]
        public GlyphDefinition AccSagittalFlat11LDown { get; set; }

        [JsonProperty("accSagittalFlat11MDown")]
        public GlyphDefinition AccSagittalFlat11MDown { get; set; }

        [JsonProperty("accSagittalFlat11v19LDown")]
        public GlyphDefinition AccSagittalFlat11V19LDown { get; set; }

        [JsonProperty("accSagittalFlat11v19MDown")]
        public GlyphDefinition AccSagittalFlat11V19MDown { get; set; }

        [JsonProperty("accSagittalFlat11v49CDown")]
        public GlyphDefinition AccSagittalFlat11V49CDown { get; set; }

        [JsonProperty("accSagittalFlat11v49CUp")]
        public GlyphDefinition AccSagittalFlat11V49CUp { get; set; }

        [JsonProperty("accSagittalFlat143CDown")]
        public GlyphDefinition AccSagittalFlat143CDown { get; set; }

        [JsonProperty("accSagittalFlat143CUp")]
        public GlyphDefinition AccSagittalFlat143CUp { get; set; }

        [JsonProperty("accSagittalFlat17CDown")]
        public GlyphDefinition AccSagittalFlat17CDown { get; set; }

        [JsonProperty("accSagittalFlat17CUp")]
        public GlyphDefinition AccSagittalFlat17CUp { get; set; }

        [JsonProperty("accSagittalFlat17kDown")]
        public GlyphDefinition AccSagittalFlat17KDown { get; set; }

        [JsonProperty("accSagittalFlat17kUp")]
        public GlyphDefinition AccSagittalFlat17KUp { get; set; }

        [JsonProperty("accSagittalFlat19CDown")]
        public GlyphDefinition AccSagittalFlat19CDown { get; set; }

        [JsonProperty("accSagittalFlat19CUp")]
        public GlyphDefinition AccSagittalFlat19CUp { get; set; }

        [JsonProperty("accSagittalFlat19sDown")]
        public GlyphDefinition AccSagittalFlat19SDown { get; set; }

        [JsonProperty("accSagittalFlat19sUp")]
        public GlyphDefinition AccSagittalFlat19SUp { get; set; }

        [JsonProperty("accSagittalFlat23CDown")]
        public GlyphDefinition AccSagittalFlat23CDown { get; set; }

        [JsonProperty("accSagittalFlat23CUp")]
        public GlyphDefinition AccSagittalFlat23CUp { get; set; }

        [JsonProperty("accSagittalFlat23SDown")]
        public GlyphDefinition AccSagittalFlat23SDown { get; set; }

        [JsonProperty("accSagittalFlat23SUp")]
        public GlyphDefinition AccSagittalFlat23SUp { get; set; }

        [JsonProperty("accSagittalFlat25SDown")]
        public GlyphDefinition AccSagittalFlat25SDown { get; set; }

        [JsonProperty("accSagittalFlat25SUp")]
        public GlyphDefinition AccSagittalFlat25SUp { get; set; }

        [JsonProperty("accSagittalFlat35LDown")]
        public GlyphDefinition AccSagittalFlat35LDown { get; set; }

        [JsonProperty("accSagittalFlat35MDown")]
        public GlyphDefinition AccSagittalFlat35MDown { get; set; }

        [JsonProperty("accSagittalFlat49LDown")]
        public GlyphDefinition AccSagittalFlat49LDown { get; set; }

        [JsonProperty("accSagittalFlat49MDown")]
        public GlyphDefinition AccSagittalFlat49MDown { get; set; }

        [JsonProperty("accSagittalFlat49SDown")]
        public GlyphDefinition AccSagittalFlat49SDown { get; set; }

        [JsonProperty("accSagittalFlat49SUp")]
        public GlyphDefinition AccSagittalFlat49SUp { get; set; }

        [JsonProperty("accSagittalFlat55CDown")]
        public GlyphDefinition AccSagittalFlat55CDown { get; set; }

        [JsonProperty("accSagittalFlat55CUp")]
        public GlyphDefinition AccSagittalFlat55CUp { get; set; }

        [JsonProperty("accSagittalFlat5CDown")]
        public GlyphDefinition AccSagittalFlat5CDown { get; set; }

        [JsonProperty("accSagittalFlat5CUp")]
        public GlyphDefinition AccSagittalFlat5CUp { get; set; }

        [JsonProperty("accSagittalFlat5v11SDown")]
        public GlyphDefinition AccSagittalFlat5V11SDown { get; set; }

        [JsonProperty("accSagittalFlat5v11SUp")]
        public GlyphDefinition AccSagittalFlat5V11SUp { get; set; }

        [JsonProperty("accSagittalFlat5v13LDown")]
        public GlyphDefinition AccSagittalFlat5V13LDown { get; set; }

        [JsonProperty("accSagittalFlat5v13MDown")]
        public GlyphDefinition AccSagittalFlat5V13MDown { get; set; }

        [JsonProperty("accSagittalFlat5v19CDown")]
        public GlyphDefinition AccSagittalFlat5V19CDown { get; set; }

        [JsonProperty("accSagittalFlat5v19CUp")]
        public GlyphDefinition AccSagittalFlat5V19CUp { get; set; }

        [JsonProperty("accSagittalFlat5v23SDown")]
        public GlyphDefinition AccSagittalFlat5V23SDown { get; set; }

        [JsonProperty("accSagittalFlat5v23SUp")]
        public GlyphDefinition AccSagittalFlat5V23SUp { get; set; }

        [JsonProperty("accSagittalFlat5v49MDown")]
        public GlyphDefinition AccSagittalFlat5V49MDown { get; set; }

        [JsonProperty("accSagittalFlat5v7kDown")]
        public GlyphDefinition AccSagittalFlat5V7KDown { get; set; }

        [JsonProperty("accSagittalFlat5v7kUp")]
        public GlyphDefinition AccSagittalFlat5V7KUp { get; set; }

        [JsonProperty("accSagittalFlat7CDown")]
        public GlyphDefinition AccSagittalFlat7CDown { get; set; }

        [JsonProperty("accSagittalFlat7CUp")]
        public GlyphDefinition AccSagittalFlat7CUp { get; set; }

        [JsonProperty("accSagittalFlat7v11CDown")]
        public GlyphDefinition AccSagittalFlat7V11CDown { get; set; }

        [JsonProperty("accSagittalFlat7v11CUp")]
        public GlyphDefinition AccSagittalFlat7V11CUp { get; set; }

        [JsonProperty("accSagittalFlat7v11kDown")]
        public GlyphDefinition AccSagittalFlat7V11KDown { get; set; }

        [JsonProperty("accSagittalFlat7v11kUp")]
        public GlyphDefinition AccSagittalFlat7V11KUp { get; set; }

        [JsonProperty("accSagittalFlat7v19CDown")]
        public GlyphDefinition AccSagittalFlat7V19CDown { get; set; }

        [JsonProperty("accSagittalFlat7v19CUp")]
        public GlyphDefinition AccSagittalFlat7V19CUp { get; set; }

        [JsonProperty("accSagittalGrave")]
        public GlyphDefinition AccSagittalGrave { get; set; }

        [JsonProperty("accSagittalShaftDown")]
        public GlyphDefinition AccSagittalShaftDown { get; set; }

        [JsonProperty("accSagittalShaftUp")]
        public GlyphDefinition AccSagittalShaftUp { get; set; }

        [JsonProperty("accSagittalSharp")]
        public GlyphDefinition AccSagittalSharp { get; set; }

        [JsonProperty("accSagittalSharp11LUp")]
        public GlyphDefinition AccSagittalSharp11LUp { get; set; }

        [JsonProperty("accSagittalSharp11MUp")]
        public GlyphDefinition AccSagittalSharp11MUp { get; set; }

        [JsonProperty("accSagittalSharp11v19LUp")]
        public GlyphDefinition AccSagittalSharp11V19LUp { get; set; }

        [JsonProperty("accSagittalSharp11v19MUp")]
        public GlyphDefinition AccSagittalSharp11V19MUp { get; set; }

        [JsonProperty("accSagittalSharp11v49CDown")]
        public GlyphDefinition AccSagittalSharp11V49CDown { get; set; }

        [JsonProperty("accSagittalSharp11v49CUp")]
        public GlyphDefinition AccSagittalSharp11V49CUp { get; set; }

        [JsonProperty("accSagittalSharp143CDown")]
        public GlyphDefinition AccSagittalSharp143CDown { get; set; }

        [JsonProperty("accSagittalSharp143CUp")]
        public GlyphDefinition AccSagittalSharp143CUp { get; set; }

        [JsonProperty("accSagittalSharp17CDown")]
        public GlyphDefinition AccSagittalSharp17CDown { get; set; }

        [JsonProperty("accSagittalSharp17CUp")]
        public GlyphDefinition AccSagittalSharp17CUp { get; set; }

        [JsonProperty("accSagittalSharp17kDown")]
        public GlyphDefinition AccSagittalSharp17KDown { get; set; }

        [JsonProperty("accSagittalSharp17kUp")]
        public GlyphDefinition AccSagittalSharp17KUp { get; set; }

        [JsonProperty("accSagittalSharp19CDown")]
        public GlyphDefinition AccSagittalSharp19CDown { get; set; }

        [JsonProperty("accSagittalSharp19CUp")]
        public GlyphDefinition AccSagittalSharp19CUp { get; set; }

        [JsonProperty("accSagittalSharp19sDown")]
        public GlyphDefinition AccSagittalSharp19SDown { get; set; }

        [JsonProperty("accSagittalSharp19sUp")]
        public GlyphDefinition AccSagittalSharp19SUp { get; set; }

        [JsonProperty("accSagittalSharp23CDown")]
        public GlyphDefinition AccSagittalSharp23CDown { get; set; }

        [JsonProperty("accSagittalSharp23CUp")]
        public GlyphDefinition AccSagittalSharp23CUp { get; set; }

        [JsonProperty("accSagittalSharp23SDown")]
        public GlyphDefinition AccSagittalSharp23SDown { get; set; }

        [JsonProperty("accSagittalSharp23SUp")]
        public GlyphDefinition AccSagittalSharp23SUp { get; set; }

        [JsonProperty("accSagittalSharp25SDown")]
        public GlyphDefinition AccSagittalSharp25SDown { get; set; }

        [JsonProperty("accSagittalSharp25SUp")]
        public GlyphDefinition AccSagittalSharp25SUp { get; set; }

        [JsonProperty("accSagittalSharp35LUp")]
        public GlyphDefinition AccSagittalSharp35LUp { get; set; }

        [JsonProperty("accSagittalSharp35MUp")]
        public GlyphDefinition AccSagittalSharp35MUp { get; set; }

        [JsonProperty("accSagittalSharp49LUp")]
        public GlyphDefinition AccSagittalSharp49LUp { get; set; }

        [JsonProperty("accSagittalSharp49MUp")]
        public GlyphDefinition AccSagittalSharp49MUp { get; set; }

        [JsonProperty("accSagittalSharp49SDown")]
        public GlyphDefinition AccSagittalSharp49SDown { get; set; }

        [JsonProperty("accSagittalSharp49SUp")]
        public GlyphDefinition AccSagittalSharp49SUp { get; set; }

        [JsonProperty("accSagittalSharp55CDown")]
        public GlyphDefinition AccSagittalSharp55CDown { get; set; }

        [JsonProperty("accSagittalSharp55CUp")]
        public GlyphDefinition AccSagittalSharp55CUp { get; set; }

        [JsonProperty("accSagittalSharp5CDown")]
        public GlyphDefinition AccSagittalSharp5CDown { get; set; }

        [JsonProperty("accSagittalSharp5CUp")]
        public GlyphDefinition AccSagittalSharp5CUp { get; set; }

        [JsonProperty("accSagittalSharp5v11SDown")]
        public GlyphDefinition AccSagittalSharp5V11SDown { get; set; }

        [JsonProperty("accSagittalSharp5v11SUp")]
        public GlyphDefinition AccSagittalSharp5V11SUp { get; set; }

        [JsonProperty("accSagittalSharp5v13LUp")]
        public GlyphDefinition AccSagittalSharp5V13LUp { get; set; }

        [JsonProperty("accSagittalSharp5v13MUp")]
        public GlyphDefinition AccSagittalSharp5V13MUp { get; set; }

        [JsonProperty("accSagittalSharp5v19CDown")]
        public GlyphDefinition AccSagittalSharp5V19CDown { get; set; }

        [JsonProperty("accSagittalSharp5v19CUp")]
        public GlyphDefinition AccSagittalSharp5V19CUp { get; set; }

        [JsonProperty("accSagittalSharp5v23SDown")]
        public GlyphDefinition AccSagittalSharp5V23SDown { get; set; }

        [JsonProperty("accSagittalSharp5v23SUp")]
        public GlyphDefinition AccSagittalSharp5V23SUp { get; set; }

        [JsonProperty("accSagittalSharp5v49MUp")]
        public GlyphDefinition AccSagittalSharp5V49MUp { get; set; }

        [JsonProperty("accSagittalSharp5v7kDown")]
        public GlyphDefinition AccSagittalSharp5V7KDown { get; set; }

        [JsonProperty("accSagittalSharp5v7kUp")]
        public GlyphDefinition AccSagittalSharp5V7KUp { get; set; }

        [JsonProperty("accSagittalSharp7CDown")]
        public GlyphDefinition AccSagittalSharp7CDown { get; set; }

        [JsonProperty("accSagittalSharp7CUp")]
        public GlyphDefinition AccSagittalSharp7CUp { get; set; }

        [JsonProperty("accSagittalSharp7v11CDown")]
        public GlyphDefinition AccSagittalSharp7V11CDown { get; set; }

        [JsonProperty("accSagittalSharp7v11CUp")]
        public GlyphDefinition AccSagittalSharp7V11CUp { get; set; }

        [JsonProperty("accSagittalSharp7v11kDown")]
        public GlyphDefinition AccSagittalSharp7V11KDown { get; set; }

        [JsonProperty("accSagittalSharp7v11kUp")]
        public GlyphDefinition AccSagittalSharp7V11KUp { get; set; }

        [JsonProperty("accSagittalSharp7v19CDown")]
        public GlyphDefinition AccSagittalSharp7V19CDown { get; set; }

        [JsonProperty("accSagittalSharp7v19CUp")]
        public GlyphDefinition AccSagittalSharp7V19CUp { get; set; }

        [JsonProperty("accSagittalUnused1")]
        public GlyphDefinition AccSagittalUnused1 { get; set; }

        [JsonProperty("accSagittalUnused2")]
        public GlyphDefinition AccSagittalUnused2 { get; set; }

        [JsonProperty("accSagittalUnused3")]
        public GlyphDefinition AccSagittalUnused3 { get; set; }

        [JsonProperty("accSagittalUnused4")]
        public GlyphDefinition AccSagittalUnused4 { get; set; }

        [JsonProperty("accdnCombDot")]
        public GlyphDefinition AccdnCombDot { get; set; }

        [JsonProperty("accdnCombLH2RanksEmpty")]
        public GlyphDefinition AccdnCombLh2RanksEmpty { get; set; }

        [JsonProperty("accdnCombLH3RanksEmptySquare")]
        public GlyphDefinition AccdnCombLh3RanksEmptySquare { get; set; }

        [JsonProperty("accdnCombRH3RanksEmpty")]
        public GlyphDefinition AccdnCombRh3RanksEmpty { get; set; }

        [JsonProperty("accdnCombRH4RanksEmpty")]
        public GlyphDefinition AccdnCombRh4RanksEmpty { get; set; }

        [JsonProperty("accdnDiatonicClef")]
        public GlyphDefinition AccdnDiatonicClef { get; set; }

        [JsonProperty("accdnLH2Ranks16Round")]
        public GlyphDefinition AccdnLh2Ranks16Round { get; set; }

        [JsonProperty("accdnLH2Ranks8Plus16Round")]
        public GlyphDefinition AccdnLh2Ranks8Plus16Round { get; set; }

        [JsonProperty("accdnLH2Ranks8Round")]
        public GlyphDefinition AccdnLh2Ranks8Round { get; set; }

        [JsonProperty("accdnLH2RanksFullMasterRound")]
        public GlyphDefinition AccdnLh2RanksFullMasterRound { get; set; }

        [JsonProperty("accdnLH2RanksMasterPlus16Round")]
        public GlyphDefinition AccdnLh2RanksMasterPlus16Round { get; set; }

        [JsonProperty("accdnLH2RanksMasterRound")]
        public GlyphDefinition AccdnLh2RanksMasterRound { get; set; }

        [JsonProperty("accdnLH3Ranks2Plus8Square")]
        public GlyphDefinition AccdnLh3Ranks2Plus8Square { get; set; }

        [JsonProperty("accdnLH3Ranks2Square")]
        public GlyphDefinition AccdnLh3Ranks2Square { get; set; }

        [JsonProperty("accdnLH3Ranks8Square")]
        public GlyphDefinition AccdnLh3Ranks8Square { get; set; }

        [JsonProperty("accdnLH3RanksDouble8Square")]
        public GlyphDefinition AccdnLh3RanksDouble8Square { get; set; }

        [JsonProperty("accdnLH3RanksTuttiSquare")]
        public GlyphDefinition AccdnLh3RanksTuttiSquare { get; set; }

        [JsonProperty("accdnPull")]
        public GlyphDefinition AccdnPull { get; set; }

        [JsonProperty("accdnPush")]
        public GlyphDefinition AccdnPush { get; set; }

        [JsonProperty("accdnRH3RanksAccordion")]
        public GlyphDefinition AccdnRh3RanksAccordion { get; set; }

        [JsonProperty("accdnRH3RanksAuthenticMusette")]
        public GlyphDefinition AccdnRh3RanksAuthenticMusette { get; set; }

        [JsonProperty("accdnRH3RanksBandoneon")]
        public GlyphDefinition AccdnRh3RanksBandoneon { get; set; }

        [JsonProperty("accdnRH3RanksBassoon")]
        public GlyphDefinition AccdnRh3RanksBassoon { get; set; }

        [JsonProperty("accdnRH3RanksClarinet")]
        public GlyphDefinition AccdnRh3RanksClarinet { get; set; }

        [JsonProperty("accdnRH3RanksDoubleTremoloLower8ve")]
        public GlyphDefinition AccdnRh3RanksDoubleTremoloLower8Ve { get; set; }

        [JsonProperty("accdnRH3RanksDoubleTremoloUpper8ve")]
        public GlyphDefinition AccdnRh3RanksDoubleTremoloUpper8Ve { get; set; }

        [JsonProperty("accdnRH3RanksFullFactory")]
        public GlyphDefinition AccdnRh3RanksFullFactory { get; set; }

        [JsonProperty("accdnRH3RanksHarmonium")]
        public GlyphDefinition AccdnRh3RanksHarmonium { get; set; }

        [JsonProperty("accdnRH3RanksImitationMusette")]
        public GlyphDefinition AccdnRh3RanksImitationMusette { get; set; }

        [JsonProperty("accdnRH3RanksLowerTremolo8")]
        public GlyphDefinition AccdnRh3RanksLowerTremolo8 { get; set; }

        [JsonProperty("accdnRH3RanksMaster")]
        public GlyphDefinition AccdnRh3RanksMaster { get; set; }

        [JsonProperty("accdnRH3RanksOboe")]
        public GlyphDefinition AccdnRh3RanksOboe { get; set; }

        [JsonProperty("accdnRH3RanksOrgan")]
        public GlyphDefinition AccdnRh3RanksOrgan { get; set; }

        [JsonProperty("accdnRH3RanksPiccolo")]
        public GlyphDefinition AccdnRh3RanksPiccolo { get; set; }

        [JsonProperty("accdnRH3RanksTremoloLower8ve")]
        public GlyphDefinition AccdnRh3RanksTremoloLower8Ve { get; set; }

        [JsonProperty("accdnRH3RanksTremoloUpper8ve")]
        public GlyphDefinition AccdnRh3RanksTremoloUpper8Ve { get; set; }

        [JsonProperty("accdnRH3RanksTwoChoirs")]
        public GlyphDefinition AccdnRh3RanksTwoChoirs { get; set; }

        [JsonProperty("accdnRH3RanksUpperTremolo8")]
        public GlyphDefinition AccdnRh3RanksUpperTremolo8 { get; set; }

        [JsonProperty("accdnRH3RanksViolin")]
        public GlyphDefinition AccdnRh3RanksViolin { get; set; }

        [JsonProperty("accdnRH4RanksAlto")]
        public GlyphDefinition AccdnRh4RanksAlto { get; set; }

        [JsonProperty("accdnRH4RanksBassAlto")]
        public GlyphDefinition AccdnRh4RanksBassAlto { get; set; }

        [JsonProperty("accdnRH4RanksMaster")]
        public GlyphDefinition AccdnRh4RanksMaster { get; set; }

        [JsonProperty("accdnRH4RanksSoftBass")]
        public GlyphDefinition AccdnRh4RanksSoftBass { get; set; }

        [JsonProperty("accdnRH4RanksSoftTenor")]
        public GlyphDefinition AccdnRh4RanksSoftTenor { get; set; }

        [JsonProperty("accdnRH4RanksSoprano")]
        public GlyphDefinition AccdnRh4RanksSoprano { get; set; }

        [JsonProperty("accdnRH4RanksTenor")]
        public GlyphDefinition AccdnRh4RanksTenor { get; set; }

        [JsonProperty("accdnRicochet2")]
        public GlyphDefinition AccdnRicochet2 { get; set; }

        [JsonProperty("accdnRicochet3")]
        public GlyphDefinition AccdnRicochet3 { get; set; }

        [JsonProperty("accdnRicochet4")]
        public GlyphDefinition AccdnRicochet4 { get; set; }

        [JsonProperty("accdnRicochet5")]
        public GlyphDefinition AccdnRicochet5 { get; set; }

        [JsonProperty("accdnRicochet6")]
        public GlyphDefinition AccdnRicochet6 { get; set; }

        [JsonProperty("accdnRicochetStem2")]
        public GlyphDefinition AccdnRicochetStem2 { get; set; }

        [JsonProperty("accdnRicochetStem3")]
        public GlyphDefinition AccdnRicochetStem3 { get; set; }

        [JsonProperty("accdnRicochetStem4")]
        public GlyphDefinition AccdnRicochetStem4 { get; set; }

        [JsonProperty("accdnRicochetStem5")]
        public GlyphDefinition AccdnRicochetStem5 { get; set; }

        [JsonProperty("accdnRicochetStem6")]
        public GlyphDefinition AccdnRicochetStem6 { get; set; }

        [JsonProperty("accidental1CommaFlat")]
        public GlyphDefinition Accidental1CommaFlat { get; set; }

        [JsonProperty("accidental1CommaSharp")]
        public GlyphDefinition Accidental1CommaSharp { get; set; }

        [JsonProperty("accidental2CommaFlat")]
        public GlyphDefinition Accidental2CommaFlat { get; set; }

        [JsonProperty("accidental2CommaSharp")]
        public GlyphDefinition Accidental2CommaSharp { get; set; }

        [JsonProperty("accidental3CommaFlat")]
        public GlyphDefinition Accidental3CommaFlat { get; set; }

        [JsonProperty("accidental3CommaSharp")]
        public GlyphDefinition Accidental3CommaSharp { get; set; }

        [JsonProperty("accidental4CommaFlat")]
        public GlyphDefinition Accidental4CommaFlat { get; set; }

        [JsonProperty("accidental5CommaSharp")]
        public GlyphDefinition Accidental5CommaSharp { get; set; }

        [JsonProperty("accidentalArrowDown")]
        public GlyphDefinition AccidentalArrowDown { get; set; }

        [JsonProperty("accidentalArrowUp")]
        public GlyphDefinition AccidentalArrowUp { get; set; }

        [JsonProperty("accidentalBakiyeFlat")]
        public GlyphDefinition AccidentalBakiyeFlat { get; set; }

        [JsonProperty("accidentalBakiyeSharp")]
        public GlyphDefinition AccidentalBakiyeSharp { get; set; }

        [JsonProperty("accidentalBuyukMucennebFlat")]
        public GlyphDefinition AccidentalBuyukMucennebFlat { get; set; }

        [JsonProperty("accidentalBuyukMucennebSharp")]
        public GlyphDefinition AccidentalBuyukMucennebSharp { get; set; }

        [JsonProperty("accidentalCombiningCloseCurlyBrace")]
        public GlyphDefinition AccidentalCombiningCloseCurlyBrace { get; set; }

        [JsonProperty("accidentalCombiningLower17Schisma")]
        public GlyphDefinition AccidentalCombiningLower17Schisma { get; set; }

        [JsonProperty("accidentalCombiningLower19Schisma")]
        public GlyphDefinition AccidentalCombiningLower19Schisma { get; set; }

        [JsonProperty("accidentalCombiningLower23Limit29LimitComma")]
        public GlyphDefinition AccidentalCombiningLower23Limit29LimitComma { get; set; }

        [JsonProperty("accidentalCombiningLower31Schisma")]
        public GlyphDefinition AccidentalCombiningLower31Schisma { get; set; }

        [JsonProperty("accidentalCombiningOpenCurlyBrace")]
        public GlyphDefinition AccidentalCombiningOpenCurlyBrace { get; set; }

        [JsonProperty("accidentalCombiningRaise17Schisma")]
        public GlyphDefinition AccidentalCombiningRaise17Schisma { get; set; }

        [JsonProperty("accidentalCombiningRaise19Schisma")]
        public GlyphDefinition AccidentalCombiningRaise19Schisma { get; set; }

        [JsonProperty("accidentalCombiningRaise23Limit29LimitComma")]
        public GlyphDefinition AccidentalCombiningRaise23Limit29LimitComma { get; set; }

        [JsonProperty("accidentalCombiningRaise31Schisma")]
        public GlyphDefinition AccidentalCombiningRaise31Schisma { get; set; }

        [JsonProperty("accidentalCommaSlashDown")]
        public GlyphDefinition AccidentalCommaSlashDown { get; set; }

        [JsonProperty("accidentalCommaSlashUp")]
        public GlyphDefinition AccidentalCommaSlashUp { get; set; }

        [JsonProperty("GlyphDefinition")]
        public GlyphDefinition GlyphDefinition { get; set; }

        [JsonProperty("GlyphDefinitionEqualTempered")]
        public GlyphDefinition GlyphDefinitionEqualTempered { get; set; }

        [JsonProperty("GlyphDefinitionOneArrowDown")]
        public GlyphDefinition GlyphDefinitionOneArrowDown { get; set; }

        [JsonProperty("GlyphDefinitionOneArrowUp")]
        public GlyphDefinition GlyphDefinitionOneArrowUp { get; set; }

        [JsonProperty("GlyphDefinitionReversed")]
        public GlyphDefinition GlyphDefinitionReversed { get; set; }

        [JsonProperty("GlyphDefinitionThreeArrowsDown")]
        public GlyphDefinition GlyphDefinitionThreeArrowsDown { get; set; }

        [JsonProperty("GlyphDefinitionThreeArrowsUp")]
        public GlyphDefinition GlyphDefinitionThreeArrowsUp { get; set; }

        [JsonProperty("GlyphDefinitionTurned")]
        public GlyphDefinition GlyphDefinitionTurned { get; set; }

        [JsonProperty("GlyphDefinitionTwoArrowsDown")]
        public GlyphDefinition GlyphDefinitionTwoArrowsDown { get; set; }

        [JsonProperty("GlyphDefinitionTwoArrowsUp")]
        public GlyphDefinition GlyphDefinitionTwoArrowsUp { get; set; }

        [JsonProperty("accidentalDoubleSharp")]
        public GlyphDefinition AccidentalDoubleSharp { get; set; }

        [JsonProperty("accidentalDoubleSharpEqualTempered")]
        public GlyphDefinition AccidentalDoubleSharpEqualTempered { get; set; }

        [JsonProperty("accidentalDoubleSharpOneArrowDown")]
        public GlyphDefinition AccidentalDoubleSharpOneArrowDown { get; set; }

        [JsonProperty("accidentalDoubleSharpOneArrowUp")]
        public GlyphDefinition AccidentalDoubleSharpOneArrowUp { get; set; }

        [JsonProperty("accidentalDoubleSharpThreeArrowsDown")]
        public GlyphDefinition AccidentalDoubleSharpThreeArrowsDown { get; set; }

        [JsonProperty("accidentalDoubleSharpThreeArrowsUp")]
        public GlyphDefinition AccidentalDoubleSharpThreeArrowsUp { get; set; }

        [JsonProperty("accidentalDoubleSharpTwoArrowsDown")]
        public GlyphDefinition AccidentalDoubleSharpTwoArrowsDown { get; set; }

        [JsonProperty("accidentalDoubleSharpTwoArrowsUp")]
        public GlyphDefinition AccidentalDoubleSharpTwoArrowsUp { get; set; }

        [JsonProperty("accidentalFilledReversedFlatAndFlat")]
        public GlyphDefinition AccidentalFilledReversedFlatAndFlat { get; set; }

        [JsonProperty("accidentalFilledReversedFlatAndFlatArrowDown")]
        public GlyphDefinition AccidentalFilledReversedFlatAndFlatArrowDown { get; set; }

        [JsonProperty("accidentalFilledReversedFlatAndFlatArrowUp")]
        public GlyphDefinition AccidentalFilledReversedFlatAndFlatArrowUp { get; set; }

        [JsonProperty("accidentalFilledReversedFlatArrowDown")]
        public GlyphDefinition AccidentalFilledReversedFlatArrowDown { get; set; }

        [JsonProperty("accidentalFilledReversedFlatArrowUp")]
        public GlyphDefinition AccidentalFilledReversedFlatArrowUp { get; set; }

        [JsonProperty("accidentalFiveQuarterTonesFlatArrowDown")]
        public GlyphDefinition AccidentalFiveQuarterTonesFlatArrowDown { get; set; }

        [JsonProperty("accidentalFiveQuarterTonesSharpArrowUp")]
        public GlyphDefinition AccidentalFiveQuarterTonesSharpArrowUp { get; set; }

        [JsonProperty("accidentalFlat")]
        public GlyphDefinition AccidentalFlat { get; set; }

        [JsonProperty("accidentalFlatEqualTempered")]
        public GlyphDefinition AccidentalFlatEqualTempered { get; set; }

        [JsonProperty("accidentalFlatOneArrowDown")]
        public GlyphDefinition AccidentalFlatOneArrowDown { get; set; }

        [JsonProperty("accidentalFlatOneArrowUp")]
        public GlyphDefinition AccidentalFlatOneArrowUp { get; set; }

        [JsonProperty("accidentalFlatThreeArrowsDown")]
        public GlyphDefinition AccidentalFlatThreeArrowsDown { get; set; }

        [JsonProperty("accidentalFlatThreeArrowsUp")]
        public GlyphDefinition AccidentalFlatThreeArrowsUp { get; set; }

        [JsonProperty("accidentalFlatTurned")]
        public GlyphDefinition AccidentalFlatTurned { get; set; }

        [JsonProperty("accidentalFlatTwoArrowsDown")]
        public GlyphDefinition AccidentalFlatTwoArrowsDown { get; set; }

        [JsonProperty("accidentalFlatTwoArrowsUp")]
        public GlyphDefinition AccidentalFlatTwoArrowsUp { get; set; }

        [JsonProperty("accidentalHalfSharpArrowDown")]
        public GlyphDefinition AccidentalHalfSharpArrowDown { get; set; }

        [JsonProperty("accidentalHalfSharpArrowUp")]
        public GlyphDefinition AccidentalHalfSharpArrowUp { get; set; }

        [JsonProperty("accidentalJohnston13")]
        public GlyphDefinition AccidentalJohnston13 { get; set; }

        [JsonProperty("accidentalJohnston31")]
        public GlyphDefinition AccidentalJohnston31 { get; set; }

        [JsonProperty("accidentalJohnstonDown")]
        public GlyphDefinition AccidentalJohnstonDown { get; set; }

        [JsonProperty("accidentalJohnstonEl")]
        public GlyphDefinition AccidentalJohnstonEl { get; set; }

        [JsonProperty("accidentalJohnstonMinus")]
        public GlyphDefinition AccidentalJohnstonMinus { get; set; }

        [JsonProperty("accidentalJohnstonPlus")]
        public GlyphDefinition AccidentalJohnstonPlus { get; set; }

        [JsonProperty("accidentalJohnstonSeven")]
        public GlyphDefinition AccidentalJohnstonSeven { get; set; }

        [JsonProperty("accidentalJohnstonUp")]
        public GlyphDefinition AccidentalJohnstonUp { get; set; }

        [JsonProperty("accidentalKomaFlat")]
        public GlyphDefinition AccidentalKomaFlat { get; set; }

        [JsonProperty("accidentalKomaSharp")]
        public GlyphDefinition AccidentalKomaSharp { get; set; }

        [JsonProperty("accidentalKoron")]
        public GlyphDefinition AccidentalKoron { get; set; }

        [JsonProperty("accidentalKucukMucennebFlat")]
        public GlyphDefinition AccidentalKucukMucennebFlat { get; set; }

        [JsonProperty("accidentalKucukMucennebSharp")]
        public GlyphDefinition AccidentalKucukMucennebSharp { get; set; }

        [JsonProperty("accidentalLargeDoubleSharp")]
        public GlyphDefinition AccidentalLargeDoubleSharp { get; set; }

        [JsonProperty("accidentalLowerOneSeptimalComma")]
        public GlyphDefinition AccidentalLowerOneSeptimalComma { get; set; }

        [JsonProperty("accidentalLowerOneTridecimalQuartertone")]
        public GlyphDefinition AccidentalLowerOneTridecimalQuartertone { get; set; }

        [JsonProperty("accidentalLowerOneUndecimalQuartertone")]
        public GlyphDefinition AccidentalLowerOneUndecimalQuartertone { get; set; }

        [JsonProperty("accidentalLowerTwoSeptimalCommas")]
        public GlyphDefinition AccidentalLowerTwoSeptimalCommas { get; set; }

        [JsonProperty("accidentalNarrowReversedFlat")]
        public GlyphDefinition AccidentalNarrowReversedFlat { get; set; }

        [JsonProperty("accidentalNarrowReversedFlatAndFlat")]
        public GlyphDefinition AccidentalNarrowReversedFlatAndFlat { get; set; }

        [JsonProperty("accidentalNatural")]
        public GlyphDefinition AccidentalNatural { get; set; }

        [JsonProperty("accidentalNaturalEqualTempered")]
        public GlyphDefinition AccidentalNaturalEqualTempered { get; set; }

        [JsonProperty("accidentalNaturalFlat")]
        public GlyphDefinition AccidentalNaturalFlat { get; set; }

        [JsonProperty("accidentalNaturalOneArrowDown")]
        public GlyphDefinition AccidentalNaturalOneArrowDown { get; set; }

        [JsonProperty("accidentalNaturalOneArrowUp")]
        public GlyphDefinition AccidentalNaturalOneArrowUp { get; set; }

        [JsonProperty("accidentalNaturalReversed")]
        public GlyphDefinition AccidentalNaturalReversed { get; set; }

        [JsonProperty("accidentalNaturalSharp")]
        public GlyphDefinition AccidentalNaturalSharp { get; set; }

        [JsonProperty("accidentalNaturalThreeArrowsDown")]
        public GlyphDefinition AccidentalNaturalThreeArrowsDown { get; set; }

        [JsonProperty("accidentalNaturalThreeArrowsUp")]
        public GlyphDefinition AccidentalNaturalThreeArrowsUp { get; set; }

        [JsonProperty("accidentalNaturalTwoArrowsDown")]
        public GlyphDefinition AccidentalNaturalTwoArrowsDown { get; set; }

        [JsonProperty("accidentalNaturalTwoArrowsUp")]
        public GlyphDefinition AccidentalNaturalTwoArrowsUp { get; set; }

        [JsonProperty("accidentalOneAndAHalfSharpsArrowDown")]
        public GlyphDefinition AccidentalOneAndAHalfSharpsArrowDown { get; set; }

        [JsonProperty("accidentalOneAndAHalfSharpsArrowUp")]
        public GlyphDefinition AccidentalOneAndAHalfSharpsArrowUp { get; set; }

        [JsonProperty("accidentalOneThirdToneFlatFerneyhough")]
        public GlyphDefinition AccidentalOneThirdToneFlatFerneyhough { get; set; }

        [JsonProperty("accidentalOneThirdToneSharpFerneyhough")]
        public GlyphDefinition AccidentalOneThirdToneSharpFerneyhough { get; set; }

        [JsonProperty("accidentalParensLeft")]
        public GlyphDefinition AccidentalParensLeft { get; set; }

        [JsonProperty("accidentalParensRight")]
        public GlyphDefinition AccidentalParensRight { get; set; }

        [JsonProperty("accidentalQuarterToneFlat4")]
        public GlyphDefinition AccidentalQuarterToneFlat4 { get; set; }

        [JsonProperty("accidentalQuarterToneFlatArrowUp")]
        public GlyphDefinition AccidentalQuarterToneFlatArrowUp { get; set; }

        [JsonProperty("accidentalQuarterToneFlatFilledReversed")]
        public GlyphDefinition AccidentalQuarterToneFlatFilledReversed { get; set; }

        [JsonProperty("accidentalQuarterToneFlatNaturalArrowDown")]
        public GlyphDefinition AccidentalQuarterToneFlatNaturalArrowDown { get; set; }

        [JsonProperty("accidentalQuarterToneFlatPenderecki")]
        public GlyphDefinition AccidentalQuarterToneFlatPenderecki { get; set; }

        [JsonProperty("accidentalQuarterToneFlatStein")]
        public GlyphDefinition AccidentalQuarterToneFlatStein { get; set; }

        [JsonProperty("accidentalQuarterToneFlatVanBlankenburg")]
        public GlyphDefinition AccidentalQuarterToneFlatVanBlankenburg { get; set; }

        [JsonProperty("accidentalQuarterToneSharp4")]
        public GlyphDefinition AccidentalQuarterToneSharp4 { get; set; }

        [JsonProperty("accidentalQuarterToneSharpArrowDown")]
        public GlyphDefinition AccidentalQuarterToneSharpArrowDown { get; set; }

        [JsonProperty("accidentalQuarterToneSharpBusotti")]
        public GlyphDefinition AccidentalQuarterToneSharpBusotti { get; set; }

        [JsonProperty("accidentalQuarterToneSharpNaturalArrowUp")]
        public GlyphDefinition AccidentalQuarterToneSharpNaturalArrowUp { get; set; }

        [JsonProperty("accidentalQuarterToneSharpStein")]
        public GlyphDefinition AccidentalQuarterToneSharpStein { get; set; }

        [JsonProperty("accidentalQuarterToneSharpWiggle")]
        public GlyphDefinition AccidentalQuarterToneSharpWiggle { get; set; }

        [JsonProperty("accidentalRaiseOneSeptimalComma")]
        public GlyphDefinition AccidentalRaiseOneSeptimalComma { get; set; }

        [JsonProperty("accidentalRaiseOneTridecimalQuartertone")]
        public GlyphDefinition AccidentalRaiseOneTridecimalQuartertone { get; set; }

        [JsonProperty("accidentalRaiseOneUndecimalQuartertone")]
        public GlyphDefinition AccidentalRaiseOneUndecimalQuartertone { get; set; }

        [JsonProperty("accidentalRaiseTwoSeptimalCommas")]
        public GlyphDefinition AccidentalRaiseTwoSeptimalCommas { get; set; }

        [JsonProperty("accidentalReversedFlatAndFlatArrowDown")]
        public GlyphDefinition AccidentalReversedFlatAndFlatArrowDown { get; set; }

        [JsonProperty("accidentalReversedFlatAndFlatArrowUp")]
        public GlyphDefinition AccidentalReversedFlatAndFlatArrowUp { get; set; }

        [JsonProperty("accidentalReversedFlatArrowDown")]
        public GlyphDefinition AccidentalReversedFlatArrowDown { get; set; }

        [JsonProperty("accidentalReversedFlatArrowUp")]
        public GlyphDefinition AccidentalReversedFlatArrowUp { get; set; }

        [JsonProperty("accidentalSharp")]
        public GlyphDefinition AccidentalSharp { get; set; }

        [JsonProperty("accidentalSharpEqualTempered")]
        public GlyphDefinition AccidentalSharpEqualTempered { get; set; }

        [JsonProperty("accidentalSharpOneArrowDown")]
        public GlyphDefinition AccidentalSharpOneArrowDown { get; set; }

        [JsonProperty("accidentalSharpOneArrowUp")]
        public GlyphDefinition AccidentalSharpOneArrowUp { get; set; }

        [JsonProperty("accidentalSharpOneHorizontalStroke")]
        public GlyphDefinition AccidentalSharpOneHorizontalStroke { get; set; }

        [JsonProperty("accidentalSharpReversed")]
        public GlyphDefinition AccidentalSharpReversed { get; set; }

        [JsonProperty("accidentalSharpSharp")]
        public GlyphDefinition AccidentalSharpSharp { get; set; }

        [JsonProperty("accidentalSharpThreeArrowsDown")]
        public GlyphDefinition AccidentalSharpThreeArrowsDown { get; set; }

        [JsonProperty("accidentalSharpThreeArrowsUp")]
        public GlyphDefinition AccidentalSharpThreeArrowsUp { get; set; }

        [JsonProperty("accidentalSharpTwoArrowsDown")]
        public GlyphDefinition AccidentalSharpTwoArrowsDown { get; set; }

        [JsonProperty("accidentalSharpTwoArrowsUp")]
        public GlyphDefinition AccidentalSharpTwoArrowsUp { get; set; }

        [JsonProperty("accidentalSims12Down")]
        public GlyphDefinition AccidentalSims12Down { get; set; }

        [JsonProperty("accidentalSims12Up")]
        public GlyphDefinition AccidentalSims12Up { get; set; }

        [JsonProperty("accidentalSims4Down")]
        public GlyphDefinition AccidentalSims4Down { get; set; }

        [JsonProperty("accidentalSims4Up")]
        public GlyphDefinition AccidentalSims4Up { get; set; }

        [JsonProperty("accidentalSims6Down")]
        public GlyphDefinition AccidentalSims6Down { get; set; }

        [JsonProperty("accidentalSims6Up")]
        public GlyphDefinition AccidentalSims6Up { get; set; }

        [JsonProperty("accidentalSori")]
        public GlyphDefinition AccidentalSori { get; set; }

        [JsonProperty("accidentalTavenerFlat")]
        public GlyphDefinition AccidentalTavenerFlat { get; set; }

        [JsonProperty("accidentalTavenerSharp")]
        public GlyphDefinition AccidentalTavenerSharp { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatArrowDown")]
        public GlyphDefinition AccidentalThreeQuarterTonesFlatArrowDown { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatArrowUp")]
        public GlyphDefinition AccidentalThreeQuarterTonesFlatArrowUp { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatCouper")]
        public GlyphDefinition AccidentalThreeQuarterTonesFlatCouper { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatGrisey")]
        public GlyphDefinition AccidentalThreeQuarterTonesFlatGrisey { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatTartini")]
        public GlyphDefinition AccidentalThreeQuarterTonesFlatTartini { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatZimmermann")]
        public GlyphDefinition AccidentalThreeQuarterTonesFlatZimmermann { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpArrowDown")]
        public GlyphDefinition AccidentalThreeQuarterTonesSharpArrowDown { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpArrowUp")]
        public GlyphDefinition AccidentalThreeQuarterTonesSharpArrowUp { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpBusotti")]
        public GlyphDefinition AccidentalThreeQuarterTonesSharpBusotti { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpStein")]
        public GlyphDefinition AccidentalThreeQuarterTonesSharpStein { get; set; }

        [JsonProperty("accidentalTripleFlat")]
        public GlyphDefinition AccidentalTripleFlat { get; set; }

        [JsonProperty("accidentalTripleSharp")]
        public GlyphDefinition AccidentalTripleSharp { get; set; }

        [JsonProperty("accidentalTwoThirdTonesFlatFerneyhough")]
        public GlyphDefinition AccidentalTwoThirdTonesFlatFerneyhough { get; set; }

        [JsonProperty("accidentalTwoThirdTonesSharpFerneyhough")]
        public GlyphDefinition AccidentalTwoThirdTonesSharpFerneyhough { get; set; }

        [JsonProperty("accidentalWilsonMinus")]
        public GlyphDefinition AccidentalWilsonMinus { get; set; }

        [JsonProperty("accidentalWilsonPlus")]
        public GlyphDefinition AccidentalWilsonPlus { get; set; }

        [JsonProperty("accidentalWyschnegradsky10TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky10TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky10TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky10TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky11TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky11TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky11TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky11TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky1TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky1TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky1TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky1TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky2TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky2TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky2TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky2TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky3TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky3TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky3TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky3TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky4TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky4TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky4TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky4TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky5TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky5TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky5TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky5TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky6TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky6TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky6TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky6TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky7TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky7TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky7TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky7TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky8TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky8TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky8TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky8TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky9TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky9TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky9TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky9TwelfthsSharp { get; set; }

        [JsonProperty("accidentalXenakisOneThirdToneSharp")]
        public GlyphDefinition AccidentalXenakisOneThirdToneSharp { get; set; }

        [JsonProperty("accidentalXenakisTwoThirdTonesSharp")]
        public GlyphDefinition AccidentalXenakisTwoThirdTonesSharp { get; set; }

        [JsonProperty("analyticsChoralmelodie")]
        public GlyphDefinition AnalyticsChoralmelodie { get; set; }

        [JsonProperty("analyticsEndStimme")]
        public GlyphDefinition AnalyticsEndStimme { get; set; }

        [JsonProperty("analyticsHauptrhythmus")]
        public GlyphDefinition AnalyticsHauptrhythmus { get; set; }

        [JsonProperty("analyticsHauptstimme")]
        public GlyphDefinition AnalyticsHauptstimme { get; set; }

        [JsonProperty("analyticsInversion1")]
        public GlyphDefinition AnalyticsInversion1 { get; set; }

        [JsonProperty("analyticsNebenstimme")]
        public GlyphDefinition AnalyticsNebenstimme { get; set; }

        [JsonProperty("analyticsStartStimme")]
        public GlyphDefinition AnalyticsStartStimme { get; set; }

        [JsonProperty("analyticsTheme")]
        public GlyphDefinition AnalyticsTheme { get; set; }

        [JsonProperty("analyticsTheme1")]
        public GlyphDefinition AnalyticsTheme1 { get; set; }

        [JsonProperty("analyticsThemeInversion")]
        public GlyphDefinition AnalyticsThemeInversion { get; set; }

        [JsonProperty("analyticsThemeRetrograde")]
        public GlyphDefinition AnalyticsThemeRetrograde { get; set; }

        [JsonProperty("analyticsThemeRetrogradeInversion")]
        public GlyphDefinition AnalyticsThemeRetrogradeInversion { get; set; }

        [JsonProperty("arpeggiatoDown")]
        public GlyphDefinition ArpeggiatoDown { get; set; }

        [JsonProperty("arpeggiatoUp")]
        public GlyphDefinition ArpeggiatoUp { get; set; }

        [JsonProperty("arrowBlackDown")]
        public GlyphDefinition ArrowBlackDown { get; set; }

        [JsonProperty("arrowBlackDownLeft")]
        public GlyphDefinition ArrowBlackDownLeft { get; set; }

        [JsonProperty("arrowBlackDownRight")]
        public GlyphDefinition ArrowBlackDownRight { get; set; }

        [JsonProperty("arrowBlackLeft")]
        public GlyphDefinition ArrowBlackLeft { get; set; }

        [JsonProperty("arrowBlackRight")]
        public GlyphDefinition ArrowBlackRight { get; set; }

        [JsonProperty("arrowBlackUp")]
        public GlyphDefinition ArrowBlackUp { get; set; }

        [JsonProperty("arrowBlackUpLeft")]
        public GlyphDefinition ArrowBlackUpLeft { get; set; }

        [JsonProperty("arrowBlackUpRight")]
        public GlyphDefinition ArrowBlackUpRight { get; set; }

        [JsonProperty("arrowOpenDown")]
        public GlyphDefinition ArrowOpenDown { get; set; }

        [JsonProperty("arrowOpenDownLeft")]
        public GlyphDefinition ArrowOpenDownLeft { get; set; }

        [JsonProperty("arrowOpenDownRight")]
        public GlyphDefinition ArrowOpenDownRight { get; set; }

        [JsonProperty("arrowOpenLeft")]
        public GlyphDefinition ArrowOpenLeft { get; set; }

        [JsonProperty("arrowOpenRight")]
        public GlyphDefinition ArrowOpenRight { get; set; }

        [JsonProperty("arrowOpenUp")]
        public GlyphDefinition ArrowOpenUp { get; set; }

        [JsonProperty("arrowOpenUpLeft")]
        public GlyphDefinition ArrowOpenUpLeft { get; set; }

        [JsonProperty("arrowOpenUpRight")]
        public GlyphDefinition ArrowOpenUpRight { get; set; }

        [JsonProperty("arrowWhiteDown")]
        public GlyphDefinition ArrowWhiteDown { get; set; }

        [JsonProperty("arrowWhiteDownLeft")]
        public GlyphDefinition ArrowWhiteDownLeft { get; set; }

        [JsonProperty("arrowWhiteDownRight")]
        public GlyphDefinition ArrowWhiteDownRight { get; set; }

        [JsonProperty("arrowWhiteLeft")]
        public GlyphDefinition ArrowWhiteLeft { get; set; }

        [JsonProperty("arrowWhiteRight")]
        public GlyphDefinition ArrowWhiteRight { get; set; }

        [JsonProperty("arrowWhiteUp")]
        public GlyphDefinition ArrowWhiteUp { get; set; }

        [JsonProperty("arrowWhiteUpLeft")]
        public GlyphDefinition ArrowWhiteUpLeft { get; set; }

        [JsonProperty("arrowWhiteUpRight")]
        public GlyphDefinition ArrowWhiteUpRight { get; set; }

        [JsonProperty("arrowheadBlackDown")]
        public GlyphDefinition ArrowheadBlackDown { get; set; }

        [JsonProperty("arrowheadBlackDownLeft")]
        public GlyphDefinition ArrowheadBlackDownLeft { get; set; }

        [JsonProperty("arrowheadBlackDownRight")]
        public GlyphDefinition ArrowheadBlackDownRight { get; set; }

        [JsonProperty("arrowheadBlackLeft")]
        public GlyphDefinition ArrowheadBlackLeft { get; set; }

        [JsonProperty("arrowheadBlackRight")]
        public GlyphDefinition ArrowheadBlackRight { get; set; }

        [JsonProperty("arrowheadBlackUp")]
        public GlyphDefinition ArrowheadBlackUp { get; set; }

        [JsonProperty("arrowheadBlackUpLeft")]
        public GlyphDefinition ArrowheadBlackUpLeft { get; set; }

        [JsonProperty("arrowheadBlackUpRight")]
        public GlyphDefinition ArrowheadBlackUpRight { get; set; }

        [JsonProperty("arrowheadOpenDown")]
        public GlyphDefinition ArrowheadOpenDown { get; set; }

        [JsonProperty("arrowheadOpenDownLeft")]
        public GlyphDefinition ArrowheadOpenDownLeft { get; set; }

        [JsonProperty("arrowheadOpenDownRight")]
        public GlyphDefinition ArrowheadOpenDownRight { get; set; }

        [JsonProperty("arrowheadOpenLeft")]
        public GlyphDefinition ArrowheadOpenLeft { get; set; }

        [JsonProperty("arrowheadOpenRight")]
        public GlyphDefinition ArrowheadOpenRight { get; set; }

        [JsonProperty("arrowheadOpenUp")]
        public GlyphDefinition ArrowheadOpenUp { get; set; }

        [JsonProperty("arrowheadOpenUpLeft")]
        public GlyphDefinition ArrowheadOpenUpLeft { get; set; }

        [JsonProperty("arrowheadOpenUpRight")]
        public GlyphDefinition ArrowheadOpenUpRight { get; set; }

        [JsonProperty("arrowheadWhiteDown")]
        public GlyphDefinition ArrowheadWhiteDown { get; set; }

        [JsonProperty("arrowheadWhiteDownLeft")]
        public GlyphDefinition ArrowheadWhiteDownLeft { get; set; }

        [JsonProperty("arrowheadWhiteDownRight")]
        public GlyphDefinition ArrowheadWhiteDownRight { get; set; }

        [JsonProperty("arrowheadWhiteLeft")]
        public GlyphDefinition ArrowheadWhiteLeft { get; set; }

        [JsonProperty("arrowheadWhiteRight")]
        public GlyphDefinition ArrowheadWhiteRight { get; set; }

        [JsonProperty("arrowheadWhiteUp")]
        public GlyphDefinition ArrowheadWhiteUp { get; set; }

        [JsonProperty("arrowheadWhiteUpLeft")]
        public GlyphDefinition ArrowheadWhiteUpLeft { get; set; }

        [JsonProperty("arrowheadWhiteUpRight")]
        public GlyphDefinition ArrowheadWhiteUpRight { get; set; }

        [JsonProperty("articAccentAbove")]
        public GlyphDefinition ArticAccentAbove { get; set; }

        [JsonProperty("articAccentBelow")]
        public GlyphDefinition ArticAccentBelow { get; set; }

        [JsonProperty("articAccentStaccatoAbove")]
        public GlyphDefinition ArticAccentStaccatoAbove { get; set; }

        [JsonProperty("articAccentStaccatoBelow")]
        public GlyphDefinition ArticAccentStaccatoBelow { get; set; }

        [JsonProperty("articLaissezVibrerAbove")]
        public GlyphDefinition ArticLaissezVibrerAbove { get; set; }

        [JsonProperty("articLaissezVibrerBelow")]
        public GlyphDefinition ArticLaissezVibrerBelow { get; set; }

        [JsonProperty("articMarcatoAbove")]
        public GlyphDefinition ArticMarcatoAbove { get; set; }

        [JsonProperty("articMarcatoBelow")]
        public GlyphDefinition ArticMarcatoBelow { get; set; }

        [JsonProperty("articMarcatoStaccatoAbove")]
        public GlyphDefinition ArticMarcatoStaccatoAbove { get; set; }

        [JsonProperty("articMarcatoStaccatoBelow")]
        public GlyphDefinition ArticMarcatoStaccatoBelow { get; set; }

        [JsonProperty("articStaccatissimoAbove")]
        public GlyphDefinition ArticStaccatissimoAbove { get; set; }

        [JsonProperty("articStaccatissimoBelow")]
        public GlyphDefinition ArticStaccatissimoBelow { get; set; }

        [JsonProperty("articStaccatissimoStrokeAbove")]
        public GlyphDefinition ArticStaccatissimoStrokeAbove { get; set; }

        [JsonProperty("articStaccatissimoStrokeBelow")]
        public GlyphDefinition ArticStaccatissimoStrokeBelow { get; set; }

        [JsonProperty("articStaccatissimoWedgeAbove")]
        public GlyphDefinition ArticStaccatissimoWedgeAbove { get; set; }

        [JsonProperty("articStaccatissimoWedgeBelow")]
        public GlyphDefinition ArticStaccatissimoWedgeBelow { get; set; }

        [JsonProperty("articStaccatoAbove")]
        public GlyphDefinition ArticStaccatoAbove { get; set; }

        [JsonProperty("articStaccatoBelow")]
        public GlyphDefinition ArticStaccatoBelow { get; set; }

        [JsonProperty("articStressAbove")]
        public GlyphDefinition ArticStressAbove { get; set; }

        [JsonProperty("articStressBelow")]
        public GlyphDefinition ArticStressBelow { get; set; }

        [JsonProperty("articTenutoAbove")]
        public GlyphDefinition ArticTenutoAbove { get; set; }

        [JsonProperty("articTenutoAccentAbove")]
        public GlyphDefinition ArticTenutoAccentAbove { get; set; }

        [JsonProperty("articTenutoAccentBelow")]
        public GlyphDefinition ArticTenutoAccentBelow { get; set; }

        [JsonProperty("articTenutoBelow")]
        public GlyphDefinition ArticTenutoBelow { get; set; }

        [JsonProperty("articTenutoStaccatoAbove")]
        public GlyphDefinition ArticTenutoStaccatoAbove { get; set; }

        [JsonProperty("articTenutoStaccatoBelow")]
        public GlyphDefinition ArticTenutoStaccatoBelow { get; set; }

        [JsonProperty("articUnstressAbove")]
        public GlyphDefinition ArticUnstressAbove { get; set; }

        [JsonProperty("articUnstressBelow")]
        public GlyphDefinition ArticUnstressBelow { get; set; }

        [JsonProperty("augmentationDot")]
        public GlyphDefinition AugmentationDot { get; set; }

        [JsonProperty("barlineDashed")]
        public GlyphDefinition BarlineDashed { get; set; }

        [JsonProperty("barlineDotted")]
        public GlyphDefinition BarlineDotted { get; set; }

        [JsonProperty("barlineDouble")]
        public GlyphDefinition BarlineDouble { get; set; }

        [JsonProperty("barlineFinal")]
        public GlyphDefinition BarlineFinal { get; set; }

        [JsonProperty("barlineHeavy")]
        public GlyphDefinition BarlineHeavy { get; set; }

        [JsonProperty("barlineHeavyHeavy")]
        public GlyphDefinition BarlineHeavyHeavy { get; set; }

        [JsonProperty("barlineReverseFinal")]
        public GlyphDefinition BarlineReverseFinal { get; set; }

        [JsonProperty("barlineShort")]
        public GlyphDefinition BarlineShort { get; set; }

        [JsonProperty("barlineSingle")]
        public GlyphDefinition BarlineSingle { get; set; }

        [JsonProperty("barlineTick")]
        public GlyphDefinition BarlineTick { get; set; }

        [JsonProperty("beamAccelRit1")]
        public GlyphDefinition BeamAccelRit1 { get; set; }

        [JsonProperty("beamAccelRit10")]
        public GlyphDefinition BeamAccelRit10 { get; set; }

        [JsonProperty("beamAccelRit11")]
        public GlyphDefinition BeamAccelRit11 { get; set; }

        [JsonProperty("beamAccelRit12")]
        public GlyphDefinition BeamAccelRit12 { get; set; }

        [JsonProperty("beamAccelRit13")]
        public GlyphDefinition BeamAccelRit13 { get; set; }

        [JsonProperty("beamAccelRit14")]
        public GlyphDefinition BeamAccelRit14 { get; set; }

        [JsonProperty("beamAccelRit15")]
        public GlyphDefinition BeamAccelRit15 { get; set; }

        [JsonProperty("beamAccelRit2")]
        public GlyphDefinition BeamAccelRit2 { get; set; }

        [JsonProperty("beamAccelRit3")]
        public GlyphDefinition BeamAccelRit3 { get; set; }

        [JsonProperty("beamAccelRit4")]
        public GlyphDefinition BeamAccelRit4 { get; set; }

        [JsonProperty("beamAccelRit5")]
        public GlyphDefinition BeamAccelRit5 { get; set; }

        [JsonProperty("beamAccelRit6")]
        public GlyphDefinition BeamAccelRit6 { get; set; }

        [JsonProperty("beamAccelRit7")]
        public GlyphDefinition BeamAccelRit7 { get; set; }

        [JsonProperty("beamAccelRit8")]
        public GlyphDefinition BeamAccelRit8 { get; set; }

        [JsonProperty("beamAccelRit9")]
        public GlyphDefinition BeamAccelRit9 { get; set; }

        [JsonProperty("beamAccelRitFinal")]
        public GlyphDefinition BeamAccelRitFinal { get; set; }

        [JsonProperty("brace")]
        public GlyphDefinition Brace { get; set; }

        [JsonProperty("bracket")]
        public GlyphDefinition Bracket { get; set; }

        [JsonProperty("bracketBottom")]
        public GlyphDefinition BracketBottom { get; set; }

        [JsonProperty("bracketTop")]
        public GlyphDefinition BracketTop { get; set; }

        [JsonProperty("brassBend")]
        public GlyphDefinition BrassBend { get; set; }

        [JsonProperty("brassDoitLong")]
        public GlyphDefinition BrassDoitLong { get; set; }

        [JsonProperty("brassDoitMedium")]
        public GlyphDefinition BrassDoitMedium { get; set; }

        [JsonProperty("brassDoitShort")]
        public GlyphDefinition BrassDoitShort { get; set; }

        [JsonProperty("brassFallLipLong")]
        public GlyphDefinition BrassFallLipLong { get; set; }

        [JsonProperty("brassFallLipMedium")]
        public GlyphDefinition BrassFallLipMedium { get; set; }

        [JsonProperty("brassFallLipShort")]
        public GlyphDefinition BrassFallLipShort { get; set; }

        [JsonProperty("brassFallRoughLong")]
        public GlyphDefinition BrassFallRoughLong { get; set; }

        [JsonProperty("brassFallRoughMedium")]
        public GlyphDefinition BrassFallRoughMedium { get; set; }

        [JsonProperty("brassFallRoughShort")]
        public GlyphDefinition BrassFallRoughShort { get; set; }

        [JsonProperty("brassFallSmoothLong")]
        public GlyphDefinition BrassFallSmoothLong { get; set; }

        [JsonProperty("brassFallSmoothMedium")]
        public GlyphDefinition BrassFallSmoothMedium { get; set; }

        [JsonProperty("brassFallSmoothShort")]
        public GlyphDefinition BrassFallSmoothShort { get; set; }

        [JsonProperty("brassFlip")]
        public GlyphDefinition BrassFlip { get; set; }

        [JsonProperty("brassHarmonMuteClosed")]
        public GlyphDefinition BrassHarmonMuteClosed { get; set; }

        [JsonProperty("brassHarmonMuteStemHalfLeft")]
        public GlyphDefinition BrassHarmonMuteStemHalfLeft { get; set; }

        [JsonProperty("brassHarmonMuteStemHalfRight")]
        public GlyphDefinition BrassHarmonMuteStemHalfRight { get; set; }

        [JsonProperty("brassHarmonMuteStemOpen")]
        public GlyphDefinition BrassHarmonMuteStemOpen { get; set; }

        [JsonProperty("brassJazzTurn")]
        public GlyphDefinition BrassJazzTurn { get; set; }

        [JsonProperty("brassLiftLong")]
        public GlyphDefinition BrassLiftLong { get; set; }

        [JsonProperty("brassLiftMedium")]
        public GlyphDefinition BrassLiftMedium { get; set; }

        [JsonProperty("brassLiftShort")]
        public GlyphDefinition BrassLiftShort { get; set; }

        [JsonProperty("brassLiftSmoothLong")]
        public GlyphDefinition BrassLiftSmoothLong { get; set; }

        [JsonProperty("brassLiftSmoothMedium")]
        public GlyphDefinition BrassLiftSmoothMedium { get; set; }

        [JsonProperty("brassLiftSmoothShort")]
        public GlyphDefinition BrassLiftSmoothShort { get; set; }

        [JsonProperty("brassMuteClosed")]
        public GlyphDefinition BrassMuteClosed { get; set; }

        [JsonProperty("brassMuteHalfClosed")]
        public GlyphDefinition BrassMuteHalfClosed { get; set; }

        [JsonProperty("brassMuteOpen")]
        public GlyphDefinition BrassMuteOpen { get; set; }

        [JsonProperty("brassPlop")]
        public GlyphDefinition BrassPlop { get; set; }

        [JsonProperty("brassScoop")]
        public GlyphDefinition BrassScoop { get; set; }

        [JsonProperty("brassSmear")]
        public GlyphDefinition BrassSmear { get; set; }

        [JsonProperty("breathMarkComma")]
        public GlyphDefinition BreathMarkComma { get; set; }

        [JsonProperty("breathMarkSalzedo")]
        public GlyphDefinition BreathMarkSalzedo { get; set; }

        [JsonProperty("breathMarkTick")]
        public GlyphDefinition BreathMarkTick { get; set; }

        [JsonProperty("breathMarkUpbow")]
        public GlyphDefinition BreathMarkUpbow { get; set; }

        [JsonProperty("bridgeClef")]
        public GlyphDefinition BridgeClef { get; set; }

        [JsonProperty("buzzRoll")]
        public GlyphDefinition BuzzRoll { get; set; }

        [JsonProperty("cClef")]
        public GlyphDefinition CClef { get; set; }

        [JsonProperty("cClef8vb")]
        public GlyphDefinition CClef8Vb { get; set; }

        [JsonProperty("cClefArrowDown")]
        public GlyphDefinition CClefArrowDown { get; set; }

        [JsonProperty("cClefArrowUp")]
        public GlyphDefinition CClefArrowUp { get; set; }

        [JsonProperty("cClefChange")]
        public GlyphDefinition CClefChange { get; set; }

        [JsonProperty("cClefCombining")]
        public GlyphDefinition CClefCombining { get; set; }

        [JsonProperty("cClefReversed")]
        public GlyphDefinition CClefReversed { get; set; }

        [JsonProperty("cClefSquare")]
        public GlyphDefinition CClefSquare { get; set; }

        [JsonProperty("cClefTriangular")]
        public GlyphDefinition CClefTriangular { get; set; }

        [JsonProperty("cClefTriangularToFClef")]
        public GlyphDefinition CClefTriangularToFClef { get; set; }

        [JsonProperty("caesura")]
        public GlyphDefinition Caesura { get; set; }

        [JsonProperty("caesuraCurved")]
        public GlyphDefinition CaesuraCurved { get; set; }

        [JsonProperty("caesuraShort")]
        public GlyphDefinition CaesuraShort { get; set; }

        [JsonProperty("caesuraThick")]
        public GlyphDefinition CaesuraThick { get; set; }

        [JsonProperty("chantAccentusAbove")]
        public GlyphDefinition ChantAccentusAbove { get; set; }

        [JsonProperty("chantAccentusBelow")]
        public GlyphDefinition ChantAccentusBelow { get; set; }

        [JsonProperty("chantAuctumAsc")]
        public GlyphDefinition ChantAuctumAsc { get; set; }

        [JsonProperty("chantAuctumDesc")]
        public GlyphDefinition ChantAuctumDesc { get; set; }

        [JsonProperty("chantAugmentum")]
        public GlyphDefinition ChantAugmentum { get; set; }

        [JsonProperty("chantCaesura")]
        public GlyphDefinition ChantCaesura { get; set; }

        [JsonProperty("chantCclef")]
        public GlyphDefinition ChantCclef { get; set; }

        [JsonProperty("chantCirculusAbove")]
        public GlyphDefinition ChantCirculusAbove { get; set; }

        [JsonProperty("chantCirculusBelow")]
        public GlyphDefinition ChantCirculusBelow { get; set; }

        [JsonProperty("chantConnectingLineAsc2nd")]
        public GlyphDefinition ChantConnectingLineAsc2Nd { get; set; }

        [JsonProperty("chantConnectingLineAsc3rd")]
        public GlyphDefinition ChantConnectingLineAsc3Rd { get; set; }

        [JsonProperty("chantConnectingLineAsc4th")]
        public GlyphDefinition ChantConnectingLineAsc4Th { get; set; }

        [JsonProperty("chantConnectingLineAsc5th")]
        public GlyphDefinition ChantConnectingLineAsc5Th { get; set; }

        [JsonProperty("chantConnectingLineAsc6th")]
        public GlyphDefinition ChantConnectingLineAsc6Th { get; set; }

        [JsonProperty("chantCustosStemDownPosHigh")]
        public GlyphDefinition ChantCustosStemDownPosHigh { get; set; }

        [JsonProperty("chantCustosStemDownPosHighest")]
        public GlyphDefinition ChantCustosStemDownPosHighest { get; set; }

        [JsonProperty("chantCustosStemDownPosMiddle")]
        public GlyphDefinition ChantCustosStemDownPosMiddle { get; set; }

        [JsonProperty("chantCustosStemUpPosLow")]
        public GlyphDefinition ChantCustosStemUpPosLow { get; set; }

        [JsonProperty("chantCustosStemUpPosLowest")]
        public GlyphDefinition ChantCustosStemUpPosLowest { get; set; }

        [JsonProperty("chantCustosStemUpPosMiddle")]
        public GlyphDefinition ChantCustosStemUpPosMiddle { get; set; }

        [JsonProperty("chantDeminutumLower")]
        public GlyphDefinition ChantDeminutumLower { get; set; }

        [JsonProperty("chantDeminutumUpper")]
        public GlyphDefinition ChantDeminutumUpper { get; set; }

        [JsonProperty("chantDivisioFinalis")]
        public GlyphDefinition ChantDivisioFinalis { get; set; }

        [JsonProperty("chantDivisioMaior")]
        public GlyphDefinition ChantDivisioMaior { get; set; }

        [JsonProperty("chantDivisioMaxima")]
        public GlyphDefinition ChantDivisioMaxima { get; set; }

        [JsonProperty("chantDivisioMinima")]
        public GlyphDefinition ChantDivisioMinima { get; set; }

        [JsonProperty("chantEntryLineAsc2nd")]
        public GlyphDefinition ChantEntryLineAsc2Nd { get; set; }

        [JsonProperty("chantEntryLineAsc3rd")]
        public GlyphDefinition ChantEntryLineAsc3Rd { get; set; }

        [JsonProperty("chantEntryLineAsc4th")]
        public GlyphDefinition ChantEntryLineAsc4Th { get; set; }

        [JsonProperty("chantEntryLineAsc5th")]
        public GlyphDefinition ChantEntryLineAsc5Th { get; set; }

        [JsonProperty("chantEntryLineAsc6th")]
        public GlyphDefinition ChantEntryLineAsc6Th { get; set; }

        [JsonProperty("chantEpisema")]
        public GlyphDefinition ChantEpisema { get; set; }

        [JsonProperty("chantFclef")]
        public GlyphDefinition ChantFclef { get; set; }

        [JsonProperty("chantIctusAbove")]
        public GlyphDefinition ChantIctusAbove { get; set; }

        [JsonProperty("chantIctusBelow")]
        public GlyphDefinition ChantIctusBelow { get; set; }

        [JsonProperty("chantLigaturaDesc2nd")]
        public GlyphDefinition ChantLigaturaDesc2Nd { get; set; }

        [JsonProperty("chantLigaturaDesc3rd")]
        public GlyphDefinition ChantLigaturaDesc3Rd { get; set; }

        [JsonProperty("chantLigaturaDesc4th")]
        public GlyphDefinition ChantLigaturaDesc4Th { get; set; }

        [JsonProperty("chantLigaturaDesc5th")]
        public GlyphDefinition ChantLigaturaDesc5Th { get; set; }

        [JsonProperty("chantOriscusAscending")]
        public GlyphDefinition ChantOriscusAscending { get; set; }

        [JsonProperty("chantOriscusDescending")]
        public GlyphDefinition ChantOriscusDescending { get; set; }

        [JsonProperty("chantOriscusLiquescens")]
        public GlyphDefinition ChantOriscusLiquescens { get; set; }

        [JsonProperty("chantPodatusLower")]
        public GlyphDefinition ChantPodatusLower { get; set; }

        [JsonProperty("chantPodatusUpper")]
        public GlyphDefinition ChantPodatusUpper { get; set; }

        [JsonProperty("chantPunctum")]
        public GlyphDefinition ChantPunctum { get; set; }

        [JsonProperty("chantPunctumCavum")]
        public GlyphDefinition ChantPunctumCavum { get; set; }

        [JsonProperty("chantPunctumDeminutum")]
        public GlyphDefinition ChantPunctumDeminutum { get; set; }

        [JsonProperty("chantPunctumInclinatum")]
        public GlyphDefinition ChantPunctumInclinatum { get; set; }

        [JsonProperty("chantPunctumInclinatumAuctum")]
        public GlyphDefinition ChantPunctumInclinatumAuctum { get; set; }

        [JsonProperty("chantPunctumInclinatumDeminutum")]
        public GlyphDefinition ChantPunctumInclinatumDeminutum { get; set; }

        [JsonProperty("chantPunctumLinea")]
        public GlyphDefinition ChantPunctumLinea { get; set; }

        [JsonProperty("chantPunctumLineaCavum")]
        public GlyphDefinition ChantPunctumLineaCavum { get; set; }

        [JsonProperty("chantPunctumVirga")]
        public GlyphDefinition ChantPunctumVirga { get; set; }

        [JsonProperty("chantPunctumVirgaReversed")]
        public GlyphDefinition ChantPunctumVirgaReversed { get; set; }

        [JsonProperty("chantQuilisma")]
        public GlyphDefinition ChantQuilisma { get; set; }

        [JsonProperty("chantSemicirculusAbove")]
        public GlyphDefinition ChantSemicirculusAbove { get; set; }

        [JsonProperty("chantSemicirculusBelow")]
        public GlyphDefinition ChantSemicirculusBelow { get; set; }

        [JsonProperty("chantStaff")]
        public GlyphDefinition ChantStaff { get; set; }

        [JsonProperty("chantStaffNarrow")]
        public GlyphDefinition ChantStaffNarrow { get; set; }

        [JsonProperty("chantStaffWide")]
        public GlyphDefinition ChantStaffWide { get; set; }

        [JsonProperty("chantStrophicus")]
        public GlyphDefinition ChantStrophicus { get; set; }

        [JsonProperty("chantStrophicusAuctus")]
        public GlyphDefinition ChantStrophicusAuctus { get; set; }

        [JsonProperty("chantStrophicusLiquescens2nd")]
        public GlyphDefinition ChantStrophicusLiquescens2Nd { get; set; }

        [JsonProperty("chantStrophicusLiquescens3rd")]
        public GlyphDefinition ChantStrophicusLiquescens3Rd { get; set; }

        [JsonProperty("chantStrophicusLiquescens4th")]
        public GlyphDefinition ChantStrophicusLiquescens4Th { get; set; }

        [JsonProperty("chantStrophicusLiquescens5th")]
        public GlyphDefinition ChantStrophicusLiquescens5Th { get; set; }

        [JsonProperty("chantVirgula")]
        public GlyphDefinition ChantVirgula { get; set; }

        [JsonProperty("clef15")]
        public GlyphDefinition Clef15 { get; set; }

        [JsonProperty("clef8")]
        public GlyphDefinition Clef8 { get; set; }

        [JsonProperty("clefChangeCombining")]
        public GlyphDefinition ClefChangeCombining { get; set; }

        [JsonProperty("coda")]
        public GlyphDefinition Coda { get; set; }

        [JsonProperty("codaSquare")]
        public GlyphDefinition CodaSquare { get; set; }

        [JsonProperty("conductorBeat2Compound")]
        public GlyphDefinition ConductorBeat2Compound { get; set; }

        [JsonProperty("conductorBeat2Simple")]
        public GlyphDefinition ConductorBeat2Simple { get; set; }

        [JsonProperty("conductorBeat3Compound")]
        public GlyphDefinition ConductorBeat3Compound { get; set; }

        [JsonProperty("conductorBeat3Simple")]
        public GlyphDefinition ConductorBeat3Simple { get; set; }

        [JsonProperty("conductorBeat4Compound")]
        public GlyphDefinition ConductorBeat4Compound { get; set; }

        [JsonProperty("conductorBeat4Simple")]
        public GlyphDefinition ConductorBeat4Simple { get; set; }

        [JsonProperty("conductorLeftBeat")]
        public GlyphDefinition ConductorLeftBeat { get; set; }

        [JsonProperty("conductorRightBeat")]
        public GlyphDefinition ConductorRightBeat { get; set; }

        [JsonProperty("conductorStrongBeat")]
        public GlyphDefinition ConductorStrongBeat { get; set; }

        [JsonProperty("conductorWeakBeat")]
        public GlyphDefinition ConductorWeakBeat { get; set; }

        [JsonProperty("controlBeginBeam")]
        public GlyphDefinition ControlBeginBeam { get; set; }

        [JsonProperty("controlBeginPhrase")]
        public GlyphDefinition ControlBeginPhrase { get; set; }

        [JsonProperty("controlBeginSlur")]
        public GlyphDefinition ControlBeginSlur { get; set; }

        [JsonProperty("controlBeginTie")]
        public GlyphDefinition ControlBeginTie { get; set; }

        [JsonProperty("controlEndBeam")]
        public GlyphDefinition ControlEndBeam { get; set; }

        [JsonProperty("controlEndPhrase")]
        public GlyphDefinition ControlEndPhrase { get; set; }

        [JsonProperty("controlEndSlur")]
        public GlyphDefinition ControlEndSlur { get; set; }

        [JsonProperty("controlEndTie")]
        public GlyphDefinition ControlEndTie { get; set; }

        [JsonProperty("csymAugmented")]
        public GlyphDefinition CsymAugmented { get; set; }

        [JsonProperty("csymBracketLeftTall")]
        public GlyphDefinition CsymBracketLeftTall { get; set; }

        [JsonProperty("csymBracketRightTall")]
        public GlyphDefinition CsymBracketRightTall { get; set; }

        [JsonProperty("csymDiminished")]
        public GlyphDefinition CsymDiminished { get; set; }

        [JsonProperty("csymHalfDiminished")]
        public GlyphDefinition CsymHalfDiminished { get; set; }

        [JsonProperty("csymMajorSeventh")]
        public GlyphDefinition CsymMajorSeventh { get; set; }

        [JsonProperty("csymMinor")]
        public GlyphDefinition CsymMinor { get; set; }

        [JsonProperty("csymParensLeftTall")]
        public GlyphDefinition CsymParensLeftTall { get; set; }

        [JsonProperty("csymParensRightTall")]
        public GlyphDefinition CsymParensRightTall { get; set; }

        [JsonProperty("curlewSign")]
        public GlyphDefinition CurlewSign { get; set; }

        [JsonProperty("daCapo")]
        public GlyphDefinition DaCapo { get; set; }

        [JsonProperty("dalSegno")]
        public GlyphDefinition DalSegno { get; set; }

        [JsonProperty("daseianExcellentes1")]
        public GlyphDefinition DaseianExcellentes1 { get; set; }

        [JsonProperty("daseianExcellentes2")]
        public GlyphDefinition DaseianExcellentes2 { get; set; }

        [JsonProperty("daseianExcellentes3")]
        public GlyphDefinition DaseianExcellentes3 { get; set; }

        [JsonProperty("daseianExcellentes4")]
        public GlyphDefinition DaseianExcellentes4 { get; set; }

        [JsonProperty("daseianFinales1")]
        public GlyphDefinition DaseianFinales1 { get; set; }

        [JsonProperty("daseianFinales2")]
        public GlyphDefinition DaseianFinales2 { get; set; }

        [JsonProperty("daseianFinales3")]
        public GlyphDefinition DaseianFinales3 { get; set; }

        [JsonProperty("daseianFinales4")]
        public GlyphDefinition DaseianFinales4 { get; set; }

        [JsonProperty("daseianGraves1")]
        public GlyphDefinition DaseianGraves1 { get; set; }

        [JsonProperty("daseianGraves2")]
        public GlyphDefinition DaseianGraves2 { get; set; }

        [JsonProperty("daseianGraves3")]
        public GlyphDefinition DaseianGraves3 { get; set; }

        [JsonProperty("daseianGraves4")]
        public GlyphDefinition DaseianGraves4 { get; set; }

        [JsonProperty("daseianResidua1")]
        public GlyphDefinition DaseianResidua1 { get; set; }

        [JsonProperty("daseianResidua2")]
        public GlyphDefinition DaseianResidua2 { get; set; }

        [JsonProperty("daseianSuperiores1")]
        public GlyphDefinition DaseianSuperiores1 { get; set; }

        [JsonProperty("daseianSuperiores2")]
        public GlyphDefinition DaseianSuperiores2 { get; set; }

        [JsonProperty("daseianSuperiores3")]
        public GlyphDefinition DaseianSuperiores3 { get; set; }

        [JsonProperty("daseianSuperiores4")]
        public GlyphDefinition DaseianSuperiores4 { get; set; }

        [JsonProperty("doubleTongueAbove")]
        public GlyphDefinition DoubleTongueAbove { get; set; }

        [JsonProperty("doubleTongueBelow")]
        public GlyphDefinition DoubleTongueBelow { get; set; }

        [JsonProperty("dynamicCrescendoHairpin")]
        public GlyphDefinition DynamicCrescendoHairpin { get; set; }

        [JsonProperty("dynamicDiminuendoHairpin")]
        public GlyphDefinition DynamicDiminuendoHairpin { get; set; }

        [JsonProperty("dynamicFF")]
        public GlyphDefinition DynamicFf { get; set; }

        [JsonProperty("dynamicFFF")]
        public GlyphDefinition DynamicFff { get; set; }

        [JsonProperty("dynamicFFFF")]
        public GlyphDefinition DynamicFfff { get; set; }

        [JsonProperty("dynamicFFFFF")]
        public GlyphDefinition DynamicFffff { get; set; }

        [JsonProperty("dynamicFFFFFF")]
        public GlyphDefinition DynamicFfffff { get; set; }

        [JsonProperty("dynamicForte")]
        public GlyphDefinition DynamicForte { get; set; }

        [JsonProperty("dynamicFortePiano")]
        public GlyphDefinition DynamicFortePiano { get; set; }

        [JsonProperty("dynamicForzando")]
        public GlyphDefinition DynamicForzando { get; set; }

        [JsonProperty("dynamicMF")]
        public GlyphDefinition DynamicMf { get; set; }

        [JsonProperty("dynamicMP")]
        public GlyphDefinition DynamicMp { get; set; }

        [JsonProperty("dynamicMessaDiVoce")]
        public GlyphDefinition DynamicMessaDiVoce { get; set; }

        [JsonProperty("dynamicMezzo")]
        public GlyphDefinition DynamicMezzo { get; set; }

        [JsonProperty("dynamicNiente")]
        public GlyphDefinition DynamicNiente { get; set; }

        [JsonProperty("dynamicNienteForHairpin")]
        public GlyphDefinition DynamicNienteForHairpin { get; set; }

        [JsonProperty("dynamicPF")]
        public GlyphDefinition DynamicPf { get; set; }

        [JsonProperty("dynamicPP")]
        public GlyphDefinition DynamicPp { get; set; }

        [JsonProperty("dynamicPPP")]
        public GlyphDefinition DynamicPpp { get; set; }

        [JsonProperty("dynamicPPPP")]
        public GlyphDefinition DynamicPppp { get; set; }

        [JsonProperty("dynamicPPPPP")]
        public GlyphDefinition DynamicPpppp { get; set; }

        [JsonProperty("dynamicPPPPPP")]
        public GlyphDefinition DynamicPppppp { get; set; }

        [JsonProperty("dynamicPiano")]
        public GlyphDefinition DynamicPiano { get; set; }

        [JsonProperty("dynamicRinforzando")]
        public GlyphDefinition DynamicRinforzando { get; set; }

        [JsonProperty("dynamicRinforzando1")]
        public GlyphDefinition DynamicRinforzando1 { get; set; }

        [JsonProperty("dynamicRinforzando2")]
        public GlyphDefinition DynamicRinforzando2 { get; set; }

        [JsonProperty("dynamicSforzando")]
        public GlyphDefinition DynamicSforzando { get; set; }

        [JsonProperty("dynamicSforzando1")]
        public GlyphDefinition DynamicSforzando1 { get; set; }

        [JsonProperty("dynamicSforzandoPianissimo")]
        public GlyphDefinition DynamicSforzandoPianissimo { get; set; }

        [JsonProperty("dynamicSforzandoPiano")]
        public GlyphDefinition DynamicSforzandoPiano { get; set; }

        [JsonProperty("dynamicSforzato")]
        public GlyphDefinition DynamicSforzato { get; set; }

        [JsonProperty("dynamicSforzatoFF")]
        public GlyphDefinition DynamicSforzatoFf { get; set; }

        [JsonProperty("dynamicSforzatoPiano")]
        public GlyphDefinition DynamicSforzatoPiano { get; set; }

        [JsonProperty("dynamicZ")]
        public GlyphDefinition DynamicZ { get; set; }

        [JsonProperty("elecAudioChannelsEight")]
        public GlyphDefinition ElecAudioChannelsEight { get; set; }

        [JsonProperty("elecAudioChannelsFive")]
        public GlyphDefinition ElecAudioChannelsFive { get; set; }

        [JsonProperty("elecAudioChannelsFour")]
        public GlyphDefinition ElecAudioChannelsFour { get; set; }

        [JsonProperty("elecAudioChannelsOne")]
        public GlyphDefinition ElecAudioChannelsOne { get; set; }

        [JsonProperty("elecAudioChannelsSeven")]
        public GlyphDefinition ElecAudioChannelsSeven { get; set; }

        [JsonProperty("elecAudioChannelsSix")]
        public GlyphDefinition ElecAudioChannelsSix { get; set; }

        [JsonProperty("elecAudioChannelsThreeFrontal")]
        public GlyphDefinition ElecAudioChannelsThreeFrontal { get; set; }

        [JsonProperty("elecAudioChannelsThreeSurround")]
        public GlyphDefinition ElecAudioChannelsThreeSurround { get; set; }

        [JsonProperty("elecAudioChannelsTwo")]
        public GlyphDefinition ElecAudioChannelsTwo { get; set; }

        [JsonProperty("elecAudioIn")]
        public GlyphDefinition ElecAudioIn { get; set; }

        [JsonProperty("elecAudioMono")]
        public GlyphDefinition ElecAudioMono { get; set; }

        [JsonProperty("elecAudioOut")]
        public GlyphDefinition ElecAudioOut { get; set; }

        [JsonProperty("elecAudioStereo")]
        public GlyphDefinition ElecAudioStereo { get; set; }

        [JsonProperty("elecCamera")]
        public GlyphDefinition ElecCamera { get; set; }

        [JsonProperty("elecDataIn")]
        public GlyphDefinition ElecDataIn { get; set; }

        [JsonProperty("elecDataOut")]
        public GlyphDefinition ElecDataOut { get; set; }

        [JsonProperty("elecDisc")]
        public GlyphDefinition ElecDisc { get; set; }

        [JsonProperty("elecDownload")]
        public GlyphDefinition ElecDownload { get; set; }

        [JsonProperty("elecEject")]
        public GlyphDefinition ElecEject { get; set; }

        [JsonProperty("elecFastForward")]
        public GlyphDefinition ElecFastForward { get; set; }

        [JsonProperty("elecHeadphones")]
        public GlyphDefinition ElecHeadphones { get; set; }

        [JsonProperty("elecHeadset")]
        public GlyphDefinition ElecHeadset { get; set; }

        [JsonProperty("elecLineIn")]
        public GlyphDefinition ElecLineIn { get; set; }

        [JsonProperty("elecLineOut")]
        public GlyphDefinition ElecLineOut { get; set; }

        [JsonProperty("elecLoop")]
        public GlyphDefinition ElecLoop { get; set; }

        [JsonProperty("elecLoudspeaker")]
        public GlyphDefinition ElecLoudspeaker { get; set; }

        [JsonProperty("elecMIDIController0")]
        public GlyphDefinition ElecMidiController0 { get; set; }

        [JsonProperty("elecMIDIController100")]
        public GlyphDefinition ElecMidiController100 { get; set; }

        [JsonProperty("elecMIDIController20")]
        public GlyphDefinition ElecMidiController20 { get; set; }

        [JsonProperty("elecMIDIController40")]
        public GlyphDefinition ElecMidiController40 { get; set; }

        [JsonProperty("elecMIDIController60")]
        public GlyphDefinition ElecMidiController60 { get; set; }

        [JsonProperty("elecMIDIController80")]
        public GlyphDefinition ElecMidiController80 { get; set; }

        [JsonProperty("elecMIDIIn")]
        public GlyphDefinition ElecMidiIn { get; set; }

        [JsonProperty("elecMIDIOut")]
        public GlyphDefinition ElecMidiOut { get; set; }

        [JsonProperty("elecMicrophone")]
        public GlyphDefinition ElecMicrophone { get; set; }

        [JsonProperty("elecMicrophoneMute")]
        public GlyphDefinition ElecMicrophoneMute { get; set; }

        [JsonProperty("elecMicrophoneUnmute")]
        public GlyphDefinition ElecMicrophoneUnmute { get; set; }

        [JsonProperty("elecMixingConsole")]
        public GlyphDefinition ElecMixingConsole { get; set; }

        [JsonProperty("elecMonitor")]
        public GlyphDefinition ElecMonitor { get; set; }

        [JsonProperty("elecMute")]
        public GlyphDefinition ElecMute { get; set; }

        [JsonProperty("elecPause")]
        public GlyphDefinition ElecPause { get; set; }

        [JsonProperty("elecPlay")]
        public GlyphDefinition ElecPlay { get; set; }

        [JsonProperty("elecPowerOnOff")]
        public GlyphDefinition ElecPowerOnOff { get; set; }

        [JsonProperty("elecProjector")]
        public GlyphDefinition ElecProjector { get; set; }

        [JsonProperty("elecReplay")]
        public GlyphDefinition ElecReplay { get; set; }

        [JsonProperty("elecRewind")]
        public GlyphDefinition ElecRewind { get; set; }

        [JsonProperty("elecShuffle")]
        public GlyphDefinition ElecShuffle { get; set; }

        [JsonProperty("elecSkipBackwards")]
        public GlyphDefinition ElecSkipBackwards { get; set; }

        [JsonProperty("elecSkipForwards")]
        public GlyphDefinition ElecSkipForwards { get; set; }

        [JsonProperty("elecStop")]
        public GlyphDefinition ElecStop { get; set; }

        [JsonProperty("elecTape")]
        public GlyphDefinition ElecTape { get; set; }

        [JsonProperty("elecUSB")]
        public GlyphDefinition ElecUsb { get; set; }

        [JsonProperty("elecUnmute")]
        public GlyphDefinition ElecUnmute { get; set; }

        [JsonProperty("elecUpload")]
        public GlyphDefinition ElecUpload { get; set; }

        [JsonProperty("elecVideoCamera")]
        public GlyphDefinition ElecVideoCamera { get; set; }

        [JsonProperty("elecVideoIn")]
        public GlyphDefinition ElecVideoIn { get; set; }

        [JsonProperty("elecVideoOut")]
        public GlyphDefinition ElecVideoOut { get; set; }

        [JsonProperty("elecVolumeFader")]
        public GlyphDefinition ElecVolumeFader { get; set; }

        [JsonProperty("elecVolumeFaderThumb")]
        public GlyphDefinition ElecVolumeFaderThumb { get; set; }

        [JsonProperty("elecVolumeLevel0")]
        public GlyphDefinition ElecVolumeLevel0 { get; set; }

        [JsonProperty("elecVolumeLevel100")]
        public GlyphDefinition ElecVolumeLevel100 { get; set; }

        [JsonProperty("elecVolumeLevel20")]
        public GlyphDefinition ElecVolumeLevel20 { get; set; }

        [JsonProperty("elecVolumeLevel40")]
        public GlyphDefinition ElecVolumeLevel40 { get; set; }

        [JsonProperty("elecVolumeLevel60")]
        public GlyphDefinition ElecVolumeLevel60 { get; set; }

        [JsonProperty("elecVolumeLevel80")]
        public GlyphDefinition ElecVolumeLevel80 { get; set; }

        [JsonProperty("fClef")]
        public GlyphDefinition FClef { get; set; }

        [JsonProperty("fClef15ma")]
        public GlyphDefinition FClef15Ma { get; set; }

        [JsonProperty("fClef15mb")]
        public GlyphDefinition FClef15Mb { get; set; }

        [JsonProperty("fClef8va")]
        public GlyphDefinition FClef8Va { get; set; }

        [JsonProperty("fClef8vb")]
        public GlyphDefinition FClef8Vb { get; set; }

        [JsonProperty("fClefArrowDown")]
        public GlyphDefinition FClefArrowDown { get; set; }

        [JsonProperty("fClefArrowUp")]
        public GlyphDefinition FClefArrowUp { get; set; }

        [JsonProperty("fClefChange")]
        public GlyphDefinition FClefChange { get; set; }

        [JsonProperty("fClefReversed")]
        public GlyphDefinition FClefReversed { get; set; }

        [JsonProperty("fClefTriangular")]
        public GlyphDefinition FClefTriangular { get; set; }

        [JsonProperty("fClefTriangularToCClef")]
        public GlyphDefinition FClefTriangularToCClef { get; set; }

        [JsonProperty("fClefTurned")]
        public GlyphDefinition FClefTurned { get; set; }

        [JsonProperty("fermataAbove")]
        public GlyphDefinition FermataAbove { get; set; }

        [JsonProperty("fermataBelow")]
        public GlyphDefinition FermataBelow { get; set; }

        [JsonProperty("fermataLongAbove")]
        public GlyphDefinition FermataLongAbove { get; set; }

        [JsonProperty("fermataLongBelow")]
        public GlyphDefinition FermataLongBelow { get; set; }

        [JsonProperty("fermataLongHenzeAbove")]
        public GlyphDefinition FermataLongHenzeAbove { get; set; }

        [JsonProperty("fermataLongHenzeBelow")]
        public GlyphDefinition FermataLongHenzeBelow { get; set; }

        [JsonProperty("fermataShortAbove")]
        public GlyphDefinition FermataShortAbove { get; set; }

        [JsonProperty("fermataShortBelow")]
        public GlyphDefinition FermataShortBelow { get; set; }

        [JsonProperty("fermataShortHenzeAbove")]
        public GlyphDefinition FermataShortHenzeAbove { get; set; }

        [JsonProperty("fermataShortHenzeBelow")]
        public GlyphDefinition FermataShortHenzeBelow { get; set; }

        [JsonProperty("fermataVeryLongAbove")]
        public GlyphDefinition FermataVeryLongAbove { get; set; }

        [JsonProperty("fermataVeryLongBelow")]
        public GlyphDefinition FermataVeryLongBelow { get; set; }

        [JsonProperty("fermataVeryShortAbove")]
        public GlyphDefinition FermataVeryShortAbove { get; set; }

        [JsonProperty("fermataVeryShortBelow")]
        public GlyphDefinition FermataVeryShortBelow { get; set; }

        [JsonProperty("figbass0")]
        public GlyphDefinition Figbass0 { get; set; }

        [JsonProperty("figbass1")]
        public GlyphDefinition Figbass1 { get; set; }

        [JsonProperty("figbass2")]
        public GlyphDefinition Figbass2 { get; set; }

        [JsonProperty("figbass2Raised")]
        public GlyphDefinition Figbass2Raised { get; set; }

        [JsonProperty("figbass3")]
        public GlyphDefinition Figbass3 { get; set; }

        [JsonProperty("figbass4")]
        public GlyphDefinition Figbass4 { get; set; }

        [JsonProperty("figbass4Raised")]
        public GlyphDefinition Figbass4Raised { get; set; }

        [JsonProperty("figbass5")]
        public GlyphDefinition Figbass5 { get; set; }

        [JsonProperty("figbass5Raised1")]
        public GlyphDefinition Figbass5Raised1 { get; set; }

        [JsonProperty("figbass5Raised2")]
        public GlyphDefinition Figbass5Raised2 { get; set; }

        [JsonProperty("figbass5Raised3")]
        public GlyphDefinition Figbass5Raised3 { get; set; }

        [JsonProperty("figbass6")]
        public GlyphDefinition Figbass6 { get; set; }

        [JsonProperty("figbass6Raised")]
        public GlyphDefinition Figbass6Raised { get; set; }

        [JsonProperty("figbass7")]
        public GlyphDefinition Figbass7 { get; set; }

        [JsonProperty("figbass7Raised1")]
        public GlyphDefinition Figbass7Raised1 { get; set; }

        [JsonProperty("figbass7Raised2")]
        public GlyphDefinition Figbass7Raised2 { get; set; }

        [JsonProperty("figbass8")]
        public GlyphDefinition Figbass8 { get; set; }

        [JsonProperty("figbass9")]
        public GlyphDefinition Figbass9 { get; set; }

        [JsonProperty("figbass9Raised")]
        public GlyphDefinition Figbass9Raised { get; set; }

        [JsonProperty("figbassBracketLeft")]
        public GlyphDefinition FigbassBracketLeft { get; set; }

        [JsonProperty("figbassBracketRight")]
        public GlyphDefinition FigbassBracketRight { get; set; }

        [JsonProperty("figbassCombiningLowering")]
        public GlyphDefinition FigbassCombiningLowering { get; set; }

        [JsonProperty("figbassCombiningRaising")]
        public GlyphDefinition FigbassCombiningRaising { get; set; }

        [JsonProperty("figbassDoubleFlat")]
        public GlyphDefinition FigbassDoubleFlat { get; set; }

        [JsonProperty("figbassDoubleSharp")]
        public GlyphDefinition FigbassDoubleSharp { get; set; }

        [JsonProperty("figbassFlat")]
        public GlyphDefinition FigbassFlat { get; set; }

        [JsonProperty("figbassNatural")]
        public GlyphDefinition FigbassNatural { get; set; }

        [JsonProperty("figbassParensLeft")]
        public GlyphDefinition FigbassParensLeft { get; set; }

        [JsonProperty("figbassParensRight")]
        public GlyphDefinition FigbassParensRight { get; set; }

        [JsonProperty("figbassPlus")]
        public GlyphDefinition FigbassPlus { get; set; }

        [JsonProperty("figbassSharp")]
        public GlyphDefinition FigbassSharp { get; set; }

        [JsonProperty("flag1024thDown")]
        public GlyphDefinition Flag1024ThDown { get; set; }

        [JsonProperty("flag1024thUp")]
        public GlyphDefinition Flag1024ThUp { get; set; }

        [JsonProperty("flag128thDown")]
        public GlyphDefinition Flag128ThDown { get; set; }

        [JsonProperty("flag128thUp")]
        public GlyphDefinition Flag128ThUp { get; set; }

        [JsonProperty("flag16thDown")]
        public GlyphDefinition Flag16ThDown { get; set; }

        [JsonProperty("flag16thUp")]
        public GlyphDefinition Flag16ThUp { get; set; }

        [JsonProperty("flag256thDown")]
        public GlyphDefinition Flag256ThDown { get; set; }

        [JsonProperty("flag256thUp")]
        public GlyphDefinition Flag256ThUp { get; set; }

        [JsonProperty("flag32ndDown")]
        public GlyphDefinition Flag32NdDown { get; set; }

        [JsonProperty("flag32ndUp")]
        public GlyphDefinition Flag32NdUp { get; set; }

        [JsonProperty("flag512thDown")]
        public GlyphDefinition Flag512ThDown { get; set; }

        [JsonProperty("flag512thUp")]
        public GlyphDefinition Flag512ThUp { get; set; }

        [JsonProperty("flag64thDown")]
        public GlyphDefinition Flag64ThDown { get; set; }

        [JsonProperty("flag64thUp")]
        public GlyphDefinition Flag64ThUp { get; set; }

        [JsonProperty("flag8thDown")]
        public GlyphDefinition Flag8ThDown { get; set; }

        [JsonProperty("flag8thUp")]
        public GlyphDefinition Flag8ThUp { get; set; }

        [JsonProperty("flagInternalDown")]
        public GlyphDefinition FlagInternalDown { get; set; }

        [JsonProperty("flagInternalUp")]
        public GlyphDefinition FlagInternalUp { get; set; }

        [JsonProperty("fretboard3String")]
        public GlyphDefinition Fretboard3String { get; set; }

        [JsonProperty("fretboard3StringNut")]
        public GlyphDefinition Fretboard3StringNut { get; set; }

        [JsonProperty("fretboard4String")]
        public GlyphDefinition Fretboard4String { get; set; }

        [JsonProperty("fretboard4StringNut")]
        public GlyphDefinition Fretboard4StringNut { get; set; }

        [JsonProperty("fretboard5String")]
        public GlyphDefinition Fretboard5String { get; set; }

        [JsonProperty("fretboard5StringNut")]
        public GlyphDefinition Fretboard5StringNut { get; set; }

        [JsonProperty("fretboard6String")]
        public GlyphDefinition Fretboard6String { get; set; }

        [JsonProperty("fretboard6StringNut")]
        public GlyphDefinition Fretboard6StringNut { get; set; }

        [JsonProperty("fretboardFilledCircle")]
        public GlyphDefinition FretboardFilledCircle { get; set; }

        [JsonProperty("fretboardO")]
        public GlyphDefinition FretboardO { get; set; }

        [JsonProperty("fretboardX")]
        public GlyphDefinition FretboardX { get; set; }

        [JsonProperty("functionAngleLeft")]
        public GlyphDefinition FunctionAngleLeft { get; set; }

        [JsonProperty("functionAngleRight")]
        public GlyphDefinition FunctionAngleRight { get; set; }

        [JsonProperty("functionBracketLeft")]
        public GlyphDefinition FunctionBracketLeft { get; set; }

        [JsonProperty("functionBracketRight")]
        public GlyphDefinition FunctionBracketRight { get; set; }

        [JsonProperty("functionDD")]
        public GlyphDefinition FunctionDd { get; set; }

        [JsonProperty("functionDLower")]
        public GlyphDefinition FunctionDLower { get; set; }

        [JsonProperty("functionDUpper")]
        public GlyphDefinition FunctionDUpper { get; set; }

        [JsonProperty("functionEight")]
        public GlyphDefinition FunctionEight { get; set; }

        [JsonProperty("functionFive")]
        public GlyphDefinition FunctionFive { get; set; }

        [JsonProperty("functionFour")]
        public GlyphDefinition FunctionFour { get; set; }

        [JsonProperty("functionGLower")]
        public GlyphDefinition FunctionGLower { get; set; }

        [JsonProperty("functionGUpper")]
        public GlyphDefinition FunctionGUpper { get; set; }

        [JsonProperty("functionGreaterThan")]
        public GlyphDefinition FunctionGreaterThan { get; set; }

        [JsonProperty("functionLessThan")]
        public GlyphDefinition FunctionLessThan { get; set; }

        [JsonProperty("functionMinus")]
        public GlyphDefinition FunctionMinus { get; set; }

        [JsonProperty("functionNLower")]
        public GlyphDefinition FunctionNLower { get; set; }

        [JsonProperty("functionNUpper")]
        public GlyphDefinition FunctionNUpper { get; set; }

        [JsonProperty("functionNine")]
        public GlyphDefinition FunctionNine { get; set; }

        [JsonProperty("functionOne")]
        public GlyphDefinition FunctionOne { get; set; }

        [JsonProperty("functionPLower")]
        public GlyphDefinition FunctionPLower { get; set; }

        [JsonProperty("functionPUpper")]
        public GlyphDefinition FunctionPUpper { get; set; }

        [JsonProperty("functionParensLeft")]
        public GlyphDefinition FunctionParensLeft { get; set; }

        [JsonProperty("functionParensRight")]
        public GlyphDefinition FunctionParensRight { get; set; }

        [JsonProperty("functionPlus")]
        public GlyphDefinition FunctionPlus { get; set; }

        [JsonProperty("functionRepetition1")]
        public GlyphDefinition FunctionRepetition1 { get; set; }

        [JsonProperty("functionRepetition2")]
        public GlyphDefinition FunctionRepetition2 { get; set; }

        [JsonProperty("functionRing")]
        public GlyphDefinition FunctionRing { get; set; }

        [JsonProperty("functionSLower")]
        public GlyphDefinition FunctionSLower { get; set; }

        [JsonProperty("functionSSLower")]
        public GlyphDefinition FunctionSsLower { get; set; }

        [JsonProperty("functionSSUpper")]
        public GlyphDefinition FunctionSsUpper { get; set; }

        [JsonProperty("functionSUpper")]
        public GlyphDefinition FunctionSUpper { get; set; }

        [JsonProperty("functionSeven")]
        public GlyphDefinition FunctionSeven { get; set; }

        [JsonProperty("functionSix")]
        public GlyphDefinition FunctionSix { get; set; }

        [JsonProperty("functionSlashedDD")]
        public GlyphDefinition FunctionSlashedDd { get; set; }

        [JsonProperty("functionTLower")]
        public GlyphDefinition FunctionTLower { get; set; }

        [JsonProperty("functionTUpper")]
        public GlyphDefinition FunctionTUpper { get; set; }

        [JsonProperty("functionThree")]
        public GlyphDefinition FunctionThree { get; set; }

        [JsonProperty("functionTwo")]
        public GlyphDefinition FunctionTwo { get; set; }

        [JsonProperty("functionVLower")]
        public GlyphDefinition FunctionVLower { get; set; }

        [JsonProperty("functionVUpper")]
        public GlyphDefinition FunctionVUpper { get; set; }

        [JsonProperty("functionZero")]
        public GlyphDefinition FunctionZero { get; set; }

        [JsonProperty("gClef")]
        public GlyphDefinition GClef { get; set; }

        [JsonProperty("gClef15ma")]
        public GlyphDefinition GClef15Ma { get; set; }

        [JsonProperty("gClef15mb")]
        public GlyphDefinition GClef15Mb { get; set; }

        [JsonProperty("gClef8va")]
        public GlyphDefinition GClef8Va { get; set; }

        [JsonProperty("gClef8vb")]
        public GlyphDefinition GClef8Vb { get; set; }

        [JsonProperty("gClef8vbCClef")]
        public GlyphDefinition GClef8VbCClef { get; set; }

        [JsonProperty("gClef8vbOld")]
        public GlyphDefinition GClef8VbOld { get; set; }

        [JsonProperty("gClef8vbParens")]
        public GlyphDefinition GClef8VbParens { get; set; }

        [JsonProperty("gClefArrowDown")]
        public GlyphDefinition GClefArrowDown { get; set; }

        [JsonProperty("gClefArrowUp")]
        public GlyphDefinition GClefArrowUp { get; set; }

        [JsonProperty("gClefChange")]
        public GlyphDefinition GClefChange { get; set; }

        [JsonProperty("gClefLigatedNumberAbove")]
        public GlyphDefinition GClefLigatedNumberAbove { get; set; }

        [JsonProperty("gClefLigatedNumberBelow")]
        public GlyphDefinition GClefLigatedNumberBelow { get; set; }

        [JsonProperty("gClefReversed")]
        public GlyphDefinition GClefReversed { get; set; }

        [JsonProperty("gClefTurned")]
        public GlyphDefinition GClefTurned { get; set; }

        [JsonProperty("glissandoDown")]
        public GlyphDefinition GlissandoDown { get; set; }

        [JsonProperty("glissandoUp")]
        public GlyphDefinition GlissandoUp { get; set; }

        [JsonProperty("graceNoteAcciaccaturaStemDown")]
        public GlyphDefinition GraceNoteAcciaccaturaStemDown { get; set; }

        [JsonProperty("graceNoteAcciaccaturaStemUp")]
        public GlyphDefinition GraceNoteAcciaccaturaStemUp { get; set; }

        [JsonProperty("graceNoteAppoggiaturaStemDown")]
        public GlyphDefinition GraceNoteAppoggiaturaStemDown { get; set; }

        [JsonProperty("graceNoteAppoggiaturaStemUp")]
        public GlyphDefinition GraceNoteAppoggiaturaStemUp { get; set; }

        [JsonProperty("graceNoteSlashStemDown")]
        public GlyphDefinition GraceNoteSlashStemDown { get; set; }

        [JsonProperty("graceNoteSlashStemUp")]
        public GlyphDefinition GraceNoteSlashStemUp { get; set; }

        [JsonProperty("guitarClosePedal")]
        public GlyphDefinition GuitarClosePedal { get; set; }

        [JsonProperty("guitarFadeIn")]
        public GlyphDefinition GuitarFadeIn { get; set; }

        [JsonProperty("guitarFadeOut")]
        public GlyphDefinition GuitarFadeOut { get; set; }

        [JsonProperty("guitarGolpe")]
        public GlyphDefinition GuitarGolpe { get; set; }

        [JsonProperty("guitarHalfOpenPedal")]
        public GlyphDefinition GuitarHalfOpenPedal { get; set; }

        [JsonProperty("guitarLeftHandTapping")]
        public GlyphDefinition GuitarLeftHandTapping { get; set; }

        [JsonProperty("guitarOpenPedal")]
        public GlyphDefinition GuitarOpenPedal { get; set; }

        [JsonProperty("guitarRightHandTapping")]
        public GlyphDefinition GuitarRightHandTapping { get; set; }

        [JsonProperty("guitarShake")]
        public GlyphDefinition GuitarShake { get; set; }

        [JsonProperty("guitarString0")]
        public GlyphDefinition GuitarString0 { get; set; }

        [JsonProperty("guitarString1")]
        public GlyphDefinition GuitarString1 { get; set; }

        [JsonProperty("guitarString2")]
        public GlyphDefinition GuitarString2 { get; set; }

        [JsonProperty("guitarString3")]
        public GlyphDefinition GuitarString3 { get; set; }

        [JsonProperty("guitarString4")]
        public GlyphDefinition GuitarString4 { get; set; }

        [JsonProperty("guitarString5")]
        public GlyphDefinition GuitarString5 { get; set; }

        [JsonProperty("guitarString6")]
        public GlyphDefinition GuitarString6 { get; set; }

        [JsonProperty("guitarString7")]
        public GlyphDefinition GuitarString7 { get; set; }

        [JsonProperty("guitarString8")]
        public GlyphDefinition GuitarString8 { get; set; }

        [JsonProperty("guitarString9")]
        public GlyphDefinition GuitarString9 { get; set; }

        [JsonProperty("guitarStrumDown")]
        public GlyphDefinition GuitarStrumDown { get; set; }

        [JsonProperty("guitarStrumUp")]
        public GlyphDefinition GuitarStrumUp { get; set; }

        [JsonProperty("guitarVibratoBarDip")]
        public GlyphDefinition GuitarVibratoBarDip { get; set; }

        [JsonProperty("guitarVibratoBarScoop")]
        public GlyphDefinition GuitarVibratoBarScoop { get; set; }

        [JsonProperty("guitarVibratoStroke")]
        public GlyphDefinition GuitarVibratoStroke { get; set; }

        [JsonProperty("guitarVolumeSwell")]
        public GlyphDefinition GuitarVolumeSwell { get; set; }

        [JsonProperty("guitarWideVibratoStroke")]
        public GlyphDefinition GuitarWideVibratoStroke { get; set; }

        [JsonProperty("handbellsBelltree")]
        public GlyphDefinition HandbellsBelltree { get; set; }

        [JsonProperty("handbellsDamp3")]
        public GlyphDefinition HandbellsDamp3 { get; set; }

        [JsonProperty("handbellsEcho1")]
        public GlyphDefinition HandbellsEcho1 { get; set; }

        [JsonProperty("handbellsEcho2")]
        public GlyphDefinition HandbellsEcho2 { get; set; }

        [JsonProperty("handbellsGyro")]
        public GlyphDefinition HandbellsGyro { get; set; }

        [JsonProperty("handbellsHandMartellato")]
        public GlyphDefinition HandbellsHandMartellato { get; set; }

        [JsonProperty("handbellsMalletBellOnTable")]
        public GlyphDefinition HandbellsMalletBellOnTable { get; set; }

        [JsonProperty("handbellsMalletBellSuspended")]
        public GlyphDefinition HandbellsMalletBellSuspended { get; set; }

        [JsonProperty("handbellsMalletLft")]
        public GlyphDefinition HandbellsMalletLft { get; set; }

        [JsonProperty("handbellsMartellato")]
        public GlyphDefinition HandbellsMartellato { get; set; }

        [JsonProperty("handbellsMartellatoLift")]
        public GlyphDefinition HandbellsMartellatoLift { get; set; }

        [JsonProperty("handbellsMutedMartellato")]
        public GlyphDefinition HandbellsMutedMartellato { get; set; }

        [JsonProperty("handbellsPluckLift")]
        public GlyphDefinition HandbellsPluckLift { get; set; }

        [JsonProperty("handbellsSwing")]
        public GlyphDefinition HandbellsSwing { get; set; }

        [JsonProperty("handbellsSwingDown")]
        public GlyphDefinition HandbellsSwingDown { get; set; }

        [JsonProperty("handbellsSwingUp")]
        public GlyphDefinition HandbellsSwingUp { get; set; }

        [JsonProperty("handbellsTablePairBells")]
        public GlyphDefinition HandbellsTablePairBells { get; set; }

        [JsonProperty("handbellsTableSingleBell")]
        public GlyphDefinition HandbellsTableSingleBell { get; set; }

        [JsonProperty("harpMetalRod")]
        public GlyphDefinition HarpMetalRod { get; set; }

        [JsonProperty("harpPedalCentered")]
        public GlyphDefinition HarpPedalCentered { get; set; }

        [JsonProperty("harpPedalDivider")]
        public GlyphDefinition HarpPedalDivider { get; set; }

        [JsonProperty("harpPedalLowered")]
        public GlyphDefinition HarpPedalLowered { get; set; }

        [JsonProperty("harpPedalRaised")]
        public GlyphDefinition HarpPedalRaised { get; set; }

        [JsonProperty("harpSalzedoAeolianAscending")]
        public GlyphDefinition HarpSalzedoAeolianAscending { get; set; }

        [JsonProperty("harpSalzedoAeolianDescending")]
        public GlyphDefinition HarpSalzedoAeolianDescending { get; set; }

        [JsonProperty("harpSalzedoFluidicSoundsLeft")]
        public GlyphDefinition HarpSalzedoFluidicSoundsLeft { get; set; }

        [JsonProperty("harpSalzedoFluidicSoundsRight")]
        public GlyphDefinition HarpSalzedoFluidicSoundsRight { get; set; }

        [JsonProperty("harpSalzedoMetallicSounds")]
        public GlyphDefinition HarpSalzedoMetallicSounds { get; set; }

        [JsonProperty("harpSalzedoMuffleTotally")]
        public GlyphDefinition HarpSalzedoMuffleTotally { get; set; }

        [JsonProperty("harpSalzedoOboicFlux")]
        public GlyphDefinition HarpSalzedoOboicFlux { get; set; }

        [JsonProperty("harpSalzedoPlayUpperEnd")]
        public GlyphDefinition HarpSalzedoPlayUpperEnd { get; set; }

        [JsonProperty("harpSalzedoSlideWithSuppleness")]
        public GlyphDefinition HarpSalzedoSlideWithSuppleness { get; set; }

        [JsonProperty("harpSalzedoTamTamSounds")]
        public GlyphDefinition HarpSalzedoTamTamSounds { get; set; }

        [JsonProperty("harpSalzedoThunderEffect")]
        public GlyphDefinition HarpSalzedoThunderEffect { get; set; }

        [JsonProperty("harpSalzedoTimpanicSounds")]
        public GlyphDefinition HarpSalzedoTimpanicSounds { get; set; }

        [JsonProperty("harpSalzedoWhistlingSounds")]
        public GlyphDefinition HarpSalzedoWhistlingSounds { get; set; }

        [JsonProperty("harpStringNoiseStem")]
        public GlyphDefinition HarpStringNoiseStem { get; set; }

        [JsonProperty("harpTuningKey")]
        public GlyphDefinition HarpTuningKey { get; set; }

        [JsonProperty("harpTuningKeyGlissando")]
        public GlyphDefinition HarpTuningKeyGlissando { get; set; }

        [JsonProperty("harpTuningKeyHandle")]
        public GlyphDefinition HarpTuningKeyHandle { get; set; }

        [JsonProperty("harpTuningKeyShank")]
        public GlyphDefinition HarpTuningKeyShank { get; set; }

        [JsonProperty("keyboardBebung2DotsAbove")]
        public GlyphDefinition KeyboardBebung2DotsAbove { get; set; }

        [JsonProperty("keyboardBebung2DotsBelow")]
        public GlyphDefinition KeyboardBebung2DotsBelow { get; set; }

        [JsonProperty("keyboardBebung3DotsAbove")]
        public GlyphDefinition KeyboardBebung3DotsAbove { get; set; }

        [JsonProperty("keyboardBebung3DotsBelow")]
        public GlyphDefinition KeyboardBebung3DotsBelow { get; set; }

        [JsonProperty("keyboardBebung4DotsAbove")]
        public GlyphDefinition KeyboardBebung4DotsAbove { get; set; }

        [JsonProperty("keyboardBebung4DotsBelow")]
        public GlyphDefinition KeyboardBebung4DotsBelow { get; set; }

        [JsonProperty("keyboardLeftPedalPictogram")]
        public GlyphDefinition KeyboardLeftPedalPictogram { get; set; }

        [JsonProperty("keyboardMiddlePedalPictogram")]
        public GlyphDefinition KeyboardMiddlePedalPictogram { get; set; }

        [JsonProperty("keyboardPedalD")]
        public GlyphDefinition KeyboardPedalD { get; set; }

        [JsonProperty("keyboardPedalDot")]
        public GlyphDefinition KeyboardPedalDot { get; set; }

        [JsonProperty("keyboardPedalE")]
        public GlyphDefinition KeyboardPedalE { get; set; }

        [JsonProperty("keyboardPedalHalf")]
        public GlyphDefinition KeyboardPedalHalf { get; set; }

        [JsonProperty("keyboardPedalHalf2")]
        public GlyphDefinition KeyboardPedalHalf2 { get; set; }

        [JsonProperty("keyboardPedalHalf3")]
        public GlyphDefinition KeyboardPedalHalf3 { get; set; }

        [JsonProperty("keyboardPedalHeel1")]
        public GlyphDefinition KeyboardPedalHeel1 { get; set; }

        [JsonProperty("keyboardPedalHeel2")]
        public GlyphDefinition KeyboardPedalHeel2 { get; set; }

        [JsonProperty("keyboardPedalHeel3")]
        public GlyphDefinition KeyboardPedalHeel3 { get; set; }

        [JsonProperty("keyboardPedalHeelToe")]
        public GlyphDefinition KeyboardPedalHeelToe { get; set; }

        [JsonProperty("keyboardPedalHyphen")]
        public GlyphDefinition KeyboardPedalHyphen { get; set; }

        [JsonProperty("keyboardPedalP")]
        public GlyphDefinition KeyboardPedalP { get; set; }

        [JsonProperty("keyboardPedalPed")]
        public GlyphDefinition KeyboardPedalPed { get; set; }

        [JsonProperty("keyboardPedalS")]
        public GlyphDefinition KeyboardPedalS { get; set; }

        [JsonProperty("keyboardPedalSost")]
        public GlyphDefinition KeyboardPedalSost { get; set; }

        [JsonProperty("keyboardPedalToe1")]
        public GlyphDefinition KeyboardPedalToe1 { get; set; }

        [JsonProperty("keyboardPedalToe2")]
        public GlyphDefinition KeyboardPedalToe2 { get; set; }

        [JsonProperty("keyboardPedalUp")]
        public GlyphDefinition KeyboardPedalUp { get; set; }

        [JsonProperty("keyboardPedalUpNotch")]
        public GlyphDefinition KeyboardPedalUpNotch { get; set; }

        [JsonProperty("keyboardPedalUpSpecial")]
        public GlyphDefinition KeyboardPedalUpSpecial { get; set; }

        [JsonProperty("keyboardPlayWithLH")]
        public GlyphDefinition KeyboardPlayWithLh { get; set; }

        [JsonProperty("keyboardPlayWithLHEnd")]
        public GlyphDefinition KeyboardPlayWithLhEnd { get; set; }

        [JsonProperty("keyboardPlayWithRH")]
        public GlyphDefinition KeyboardPlayWithRh { get; set; }

        [JsonProperty("keyboardPlayWithRHEnd")]
        public GlyphDefinition KeyboardPlayWithRhEnd { get; set; }

        [JsonProperty("keyboardPluckInside")]
        public GlyphDefinition KeyboardPluckInside { get; set; }

        [JsonProperty("keyboardRightPedalPictogram")]
        public GlyphDefinition KeyboardRightPedalPictogram { get; set; }

        [JsonProperty("kievanAccidentalFlat")]
        public GlyphDefinition KievanAccidentalFlat { get; set; }

        [JsonProperty("kievanAccidentalSharp")]
        public GlyphDefinition KievanAccidentalSharp { get; set; }

        [JsonProperty("kievanAugmentationDot")]
        public GlyphDefinition KievanAugmentationDot { get; set; }

        [JsonProperty("kievanCClef")]
        public GlyphDefinition KievanCClef { get; set; }

        [JsonProperty("kievanEndingSymbol")]
        public GlyphDefinition KievanEndingSymbol { get; set; }

        [JsonProperty("kievanNote8thStemDown")]
        public GlyphDefinition KievanNote8ThStemDown { get; set; }

        [JsonProperty("kievanNote8thStemUp")]
        public GlyphDefinition KievanNote8ThStemUp { get; set; }

        [JsonProperty("kievanNoteBeam")]
        public GlyphDefinition KievanNoteBeam { get; set; }

        [JsonProperty("kievanNoteHalfStaffLine")]
        public GlyphDefinition KievanNoteHalfStaffLine { get; set; }

        [JsonProperty("kievanNoteHalfStaffSpace")]
        public GlyphDefinition KievanNoteHalfStaffSpace { get; set; }

        [JsonProperty("kievanNoteQuarterStemDown")]
        public GlyphDefinition KievanNoteQuarterStemDown { get; set; }

        [JsonProperty("kievanNoteQuarterStemUp")]
        public GlyphDefinition KievanNoteQuarterStemUp { get; set; }

        [JsonProperty("kievanNoteReciting")]
        public GlyphDefinition KievanNoteReciting { get; set; }

        [JsonProperty("kievanNoteWhole")]
        public GlyphDefinition KievanNoteWhole { get; set; }

        [JsonProperty("kievanNoteWholeFinal")]
        public GlyphDefinition KievanNoteWholeFinal { get; set; }

        [JsonProperty("kodalyHandDo")]
        public GlyphDefinition KodalyHandDo { get; set; }

        [JsonProperty("kodalyHandFa")]
        public GlyphDefinition KodalyHandFa { get; set; }

        [JsonProperty("kodalyHandLa")]
        public GlyphDefinition KodalyHandLa { get; set; }

        [JsonProperty("kodalyHandMi")]
        public GlyphDefinition KodalyHandMi { get; set; }

        [JsonProperty("kodalyHandRe")]
        public GlyphDefinition KodalyHandRe { get; set; }

        [JsonProperty("kodalyHandSo")]
        public GlyphDefinition KodalyHandSo { get; set; }

        [JsonProperty("kodalyHandTi")]
        public GlyphDefinition KodalyHandTi { get; set; }

        [JsonProperty("leftRepeatSmall")]
        public GlyphDefinition LeftRepeatSmall { get; set; }

        [JsonProperty("legerLine")]
        public GlyphDefinition LegerLine { get; set; }

        [JsonProperty("legerLineNarrow")]
        public GlyphDefinition LegerLineNarrow { get; set; }

        [JsonProperty("legerLineWide")]
        public GlyphDefinition LegerLineWide { get; set; }

        [JsonProperty("luteBarlineEndRepeat")]
        public GlyphDefinition LuteBarlineEndRepeat { get; set; }

        [JsonProperty("luteBarlineFinal")]
        public GlyphDefinition LuteBarlineFinal { get; set; }

        [JsonProperty("luteBarlineStartRepeat")]
        public GlyphDefinition LuteBarlineStartRepeat { get; set; }

        [JsonProperty("luteDuration16th")]
        public GlyphDefinition LuteDuration16Th { get; set; }

        [JsonProperty("luteDuration32nd")]
        public GlyphDefinition LuteDuration32Nd { get; set; }

        [JsonProperty("luteDuration8th")]
        public GlyphDefinition LuteDuration8Th { get; set; }

        [JsonProperty("luteDurationDoubleWhole")]
        public GlyphDefinition LuteDurationDoubleWhole { get; set; }

        [JsonProperty("luteDurationHalf")]
        public GlyphDefinition LuteDurationHalf { get; set; }

        [JsonProperty("luteDurationQuarter")]
        public GlyphDefinition LuteDurationQuarter { get; set; }

        [JsonProperty("luteDurationWhole")]
        public GlyphDefinition LuteDurationWhole { get; set; }

        [JsonProperty("luteFingeringRHFirst")]
        public GlyphDefinition LuteFingeringRhFirst { get; set; }

        [JsonProperty("luteFingeringRHSecond")]
        public GlyphDefinition LuteFingeringRhSecond { get; set; }

        [JsonProperty("luteFingeringRHThird")]
        public GlyphDefinition LuteFingeringRhThird { get; set; }

        [JsonProperty("luteFingeringRHThumb")]
        public GlyphDefinition LuteFingeringRhThumb { get; set; }

        [JsonProperty("luteFrench10thCourse")]
        public GlyphDefinition LuteFrench10ThCourse { get; set; }

        [JsonProperty("luteFrench7thCourse")]
        public GlyphDefinition LuteFrench7ThCourse { get; set; }

        [JsonProperty("luteFrench8thCourse")]
        public GlyphDefinition LuteFrench8ThCourse { get; set; }

        [JsonProperty("luteFrench9thCourse")]
        public GlyphDefinition LuteFrench9ThCourse { get; set; }

        [JsonProperty("luteFrenchAppoggiaturaAbove")]
        public GlyphDefinition LuteFrenchAppoggiaturaAbove { get; set; }

        [JsonProperty("luteFrenchAppoggiaturaBelow")]
        public GlyphDefinition LuteFrenchAppoggiaturaBelow { get; set; }

        [JsonProperty("luteFrenchFretA")]
        public GlyphDefinition LuteFrenchFretA { get; set; }

        [JsonProperty("luteFrenchFretB")]
        public GlyphDefinition LuteFrenchFretB { get; set; }

        [JsonProperty("luteFrenchFretC")]
        public GlyphDefinition LuteFrenchFretC { get; set; }

        [JsonProperty("luteFrenchFretD")]
        public GlyphDefinition LuteFrenchFretD { get; set; }

        [JsonProperty("luteFrenchFretE")]
        public GlyphDefinition LuteFrenchFretE { get; set; }

        [JsonProperty("luteFrenchFretF")]
        public GlyphDefinition LuteFrenchFretF { get; set; }

        [JsonProperty("luteFrenchFretG")]
        public GlyphDefinition LuteFrenchFretG { get; set; }

        [JsonProperty("luteFrenchFretH")]
        public GlyphDefinition LuteFrenchFretH { get; set; }

        [JsonProperty("luteFrenchFretI")]
        public GlyphDefinition LuteFrenchFretI { get; set; }

        [JsonProperty("luteFrenchFretK")]
        public GlyphDefinition LuteFrenchFretK { get; set; }

        [JsonProperty("luteFrenchFretL")]
        public GlyphDefinition LuteFrenchFretL { get; set; }

        [JsonProperty("luteFrenchFretM")]
        public GlyphDefinition LuteFrenchFretM { get; set; }

        [JsonProperty("luteFrenchFretN")]
        public GlyphDefinition LuteFrenchFretN { get; set; }

        [JsonProperty("luteFrenchMordentInverted")]
        public GlyphDefinition LuteFrenchMordentInverted { get; set; }

        [JsonProperty("luteFrenchMordentLower")]
        public GlyphDefinition LuteFrenchMordentLower { get; set; }

        [JsonProperty("luteFrenchMordentUpper")]
        public GlyphDefinition LuteFrenchMordentUpper { get; set; }

        [JsonProperty("luteGermanALower")]
        public GlyphDefinition LuteGermanALower { get; set; }

        [JsonProperty("luteGermanAUpper")]
        public GlyphDefinition LuteGermanAUpper { get; set; }

        [JsonProperty("luteGermanBLower")]
        public GlyphDefinition LuteGermanBLower { get; set; }

        [JsonProperty("luteGermanBUpper")]
        public GlyphDefinition LuteGermanBUpper { get; set; }

        [JsonProperty("luteGermanCLower")]
        public GlyphDefinition LuteGermanCLower { get; set; }

        [JsonProperty("luteGermanCUpper")]
        public GlyphDefinition LuteGermanCUpper { get; set; }

        [JsonProperty("luteGermanDLower")]
        public GlyphDefinition LuteGermanDLower { get; set; }

        [JsonProperty("luteGermanDUpper")]
        public GlyphDefinition LuteGermanDUpper { get; set; }

        [JsonProperty("luteGermanELower")]
        public GlyphDefinition LuteGermanELower { get; set; }

        [JsonProperty("luteGermanEUpper")]
        public GlyphDefinition LuteGermanEUpper { get; set; }

        [JsonProperty("luteGermanFLower")]
        public GlyphDefinition LuteGermanFLower { get; set; }

        [JsonProperty("luteGermanFUpper")]
        public GlyphDefinition LuteGermanFUpper { get; set; }

        [JsonProperty("luteGermanGLower")]
        public GlyphDefinition LuteGermanGLower { get; set; }

        [JsonProperty("luteGermanGUpper")]
        public GlyphDefinition LuteGermanGUpper { get; set; }

        [JsonProperty("luteGermanHLower")]
        public GlyphDefinition LuteGermanHLower { get; set; }

        [JsonProperty("luteGermanHUpper")]
        public GlyphDefinition LuteGermanHUpper { get; set; }

        [JsonProperty("luteGermanILower")]
        public GlyphDefinition LuteGermanILower { get; set; }

        [JsonProperty("luteGermanIUpper")]
        public GlyphDefinition LuteGermanIUpper { get; set; }

        [JsonProperty("luteGermanKLower")]
        public GlyphDefinition LuteGermanKLower { get; set; }

        [JsonProperty("luteGermanKUpper")]
        public GlyphDefinition LuteGermanKUpper { get; set; }

        [JsonProperty("luteGermanLLower")]
        public GlyphDefinition LuteGermanLLower { get; set; }

        [JsonProperty("luteGermanLUpper")]
        public GlyphDefinition LuteGermanLUpper { get; set; }

        [JsonProperty("luteGermanMLower")]
        public GlyphDefinition LuteGermanMLower { get; set; }

        [JsonProperty("luteGermanMUpper")]
        public GlyphDefinition LuteGermanMUpper { get; set; }

        [JsonProperty("luteGermanNLower")]
        public GlyphDefinition LuteGermanNLower { get; set; }

        [JsonProperty("luteGermanNUpper")]
        public GlyphDefinition LuteGermanNUpper { get; set; }

        [JsonProperty("luteGermanOLower")]
        public GlyphDefinition LuteGermanOLower { get; set; }

        [JsonProperty("luteGermanPLower")]
        public GlyphDefinition LuteGermanPLower { get; set; }

        [JsonProperty("luteGermanQLower")]
        public GlyphDefinition LuteGermanQLower { get; set; }

        [JsonProperty("luteGermanRLower")]
        public GlyphDefinition LuteGermanRLower { get; set; }

        [JsonProperty("luteGermanSLower")]
        public GlyphDefinition LuteGermanSLower { get; set; }

        [JsonProperty("luteGermanTLower")]
        public GlyphDefinition LuteGermanTLower { get; set; }

        [JsonProperty("luteGermanVLower")]
        public GlyphDefinition LuteGermanVLower { get; set; }

        [JsonProperty("luteGermanXLower")]
        public GlyphDefinition LuteGermanXLower { get; set; }

        [JsonProperty("luteGermanYLower")]
        public GlyphDefinition LuteGermanYLower { get; set; }

        [JsonProperty("luteGermanZLower")]
        public GlyphDefinition LuteGermanZLower { get; set; }

        [JsonProperty("luteItalianClefCSolFaUt")]
        public GlyphDefinition LuteItalianClefCSolFaUt { get; set; }

        [JsonProperty("luteItalianClefFFaUt")]
        public GlyphDefinition LuteItalianClefFFaUt { get; set; }

        [JsonProperty("luteItalianFret0")]
        public GlyphDefinition LuteItalianFret0 { get; set; }

        [JsonProperty("luteItalianFret1")]
        public GlyphDefinition LuteItalianFret1 { get; set; }

        [JsonProperty("luteItalianFret2")]
        public GlyphDefinition LuteItalianFret2 { get; set; }

        [JsonProperty("luteItalianFret3")]
        public GlyphDefinition LuteItalianFret3 { get; set; }

        [JsonProperty("luteItalianFret4")]
        public GlyphDefinition LuteItalianFret4 { get; set; }

        [JsonProperty("luteItalianFret5")]
        public GlyphDefinition LuteItalianFret5 { get; set; }

        [JsonProperty("luteItalianFret6")]
        public GlyphDefinition LuteItalianFret6 { get; set; }

        [JsonProperty("luteItalianFret7")]
        public GlyphDefinition LuteItalianFret7 { get; set; }

        [JsonProperty("luteItalianFret8")]
        public GlyphDefinition LuteItalianFret8 { get; set; }

        [JsonProperty("luteItalianFret9")]
        public GlyphDefinition LuteItalianFret9 { get; set; }

        [JsonProperty("luteItalianHoldFinger")]
        public GlyphDefinition LuteItalianHoldFinger { get; set; }

        [JsonProperty("luteItalianHoldNote")]
        public GlyphDefinition LuteItalianHoldNote { get; set; }

        [JsonProperty("luteItalianReleaseFinger")]
        public GlyphDefinition LuteItalianReleaseFinger { get; set; }

        [JsonProperty("luteItalianTempoFast")]
        public GlyphDefinition LuteItalianTempoFast { get; set; }

        [JsonProperty("luteItalianTempoNeitherFastNorSlow")]
        public GlyphDefinition LuteItalianTempoNeitherFastNorSlow { get; set; }

        [JsonProperty("luteItalianTempoSlow")]
        public GlyphDefinition LuteItalianTempoSlow { get; set; }

        [JsonProperty("luteItalianTempoSomewhatFast")]
        public GlyphDefinition LuteItalianTempoSomewhatFast { get; set; }

        [JsonProperty("luteItalianTempoVerySlow")]
        public GlyphDefinition LuteItalianTempoVerySlow { get; set; }

        [JsonProperty("luteItalianTimeTriple")]
        public GlyphDefinition LuteItalianTimeTriple { get; set; }

        [JsonProperty("luteItalianTremolo")]
        public GlyphDefinition LuteItalianTremolo { get; set; }

        [JsonProperty("luteItalianVibrato")]
        public GlyphDefinition LuteItalianVibrato { get; set; }

        [JsonProperty("luteStaff6Lines")]
        public GlyphDefinition LuteStaff6Lines { get; set; }

        [JsonProperty("luteStaff6LinesNarrow")]
        public GlyphDefinition LuteStaff6LinesNarrow { get; set; }

        [JsonProperty("luteStaff6LinesWide")]
        public GlyphDefinition LuteStaff6LinesWide { get; set; }

        [JsonProperty("lyricsElision")]
        public GlyphDefinition LyricsElision { get; set; }

        [JsonProperty("lyricsElisionNarrow")]
        public GlyphDefinition LyricsElisionNarrow { get; set; }

        [JsonProperty("lyricsElisionWide")]
        public GlyphDefinition LyricsElisionWide { get; set; }

        [JsonProperty("lyricsHyphenBaseline")]
        public GlyphDefinition LyricsHyphenBaseline { get; set; }

        [JsonProperty("lyricsHyphenBaselineNonBreaking")]
        public GlyphDefinition LyricsHyphenBaselineNonBreaking { get; set; }

        [JsonProperty("medRenFlatHardB")]
        public GlyphDefinition MedRenFlatHardB { get; set; }

        [JsonProperty("medRenFlatSoftB")]
        public GlyphDefinition MedRenFlatSoftB { get; set; }

        [JsonProperty("medRenFlatWithDot")]
        public GlyphDefinition MedRenFlatWithDot { get; set; }

        [JsonProperty("medRenGClefCMN")]
        public GlyphDefinition MedRenGClefCmn { get; set; }

        [JsonProperty("medRenLiquescenceCMN")]
        public GlyphDefinition MedRenLiquescenceCmn { get; set; }

        [JsonProperty("medRenLiquescentAscCMN")]
        public GlyphDefinition MedRenLiquescentAscCmn { get; set; }

        [JsonProperty("medRenLiquescentDescCMN")]
        public GlyphDefinition MedRenLiquescentDescCmn { get; set; }

        [JsonProperty("medRenNatural")]
        public GlyphDefinition MedRenNatural { get; set; }

        [JsonProperty("medRenNaturalWithCross")]
        public GlyphDefinition MedRenNaturalWithCross { get; set; }

        [JsonProperty("medRenOriscusCMN")]
        public GlyphDefinition MedRenOriscusCmn { get; set; }

        [JsonProperty("medRenPlicaCMN")]
        public GlyphDefinition MedRenPlicaCmn { get; set; }

        [JsonProperty("medRenPunctumCMN")]
        public GlyphDefinition MedRenPunctumCmn { get; set; }

        [JsonProperty("medRenQuilismaCMN")]
        public GlyphDefinition MedRenQuilismaCmn { get; set; }

        [JsonProperty("medRenSharpCroix")]
        public GlyphDefinition MedRenSharpCroix { get; set; }

        [JsonProperty("medRenStrophicusCMN")]
        public GlyphDefinition MedRenStrophicusCmn { get; set; }

        [JsonProperty("mensuralAlterationSign")]
        public GlyphDefinition MensuralAlterationSign { get; set; }

        [JsonProperty("mensuralBlackBrevis")]
        public GlyphDefinition MensuralBlackBrevis { get; set; }

        [JsonProperty("mensuralBlackBrevisVoid")]
        public GlyphDefinition MensuralBlackBrevisVoid { get; set; }

        [JsonProperty("mensuralBlackDragma")]
        public GlyphDefinition MensuralBlackDragma { get; set; }

        [JsonProperty("mensuralBlackLonga")]
        public GlyphDefinition MensuralBlackLonga { get; set; }

        [JsonProperty("mensuralBlackMaxima")]
        public GlyphDefinition MensuralBlackMaxima { get; set; }

        [JsonProperty("mensuralBlackMinima")]
        public GlyphDefinition MensuralBlackMinima { get; set; }

        [JsonProperty("mensuralBlackMinimaVoid")]
        public GlyphDefinition MensuralBlackMinimaVoid { get; set; }

        [JsonProperty("mensuralBlackSemibrevis")]
        public GlyphDefinition MensuralBlackSemibrevis { get; set; }

        [JsonProperty("mensuralBlackSemibrevisCaudata")]
        public GlyphDefinition MensuralBlackSemibrevisCaudata { get; set; }

        [JsonProperty("mensuralBlackSemibrevisOblique")]
        public GlyphDefinition MensuralBlackSemibrevisOblique { get; set; }

        [JsonProperty("mensuralBlackSemibrevisVoid")]
        public GlyphDefinition MensuralBlackSemibrevisVoid { get; set; }

        [JsonProperty("mensuralBlackSemiminima")]
        public GlyphDefinition MensuralBlackSemiminima { get; set; }

        [JsonProperty("mensuralCclef")]
        public GlyphDefinition MensuralCclef { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosHigh")]
        public GlyphDefinition MensuralCclefPetrucciPosHigh { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosHighest")]
        public GlyphDefinition MensuralCclefPetrucciPosHighest { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosLow")]
        public GlyphDefinition MensuralCclefPetrucciPosLow { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosLowest")]
        public GlyphDefinition MensuralCclefPetrucciPosLowest { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosMiddle")]
        public GlyphDefinition MensuralCclefPetrucciPosMiddle { get; set; }

        [JsonProperty("mensuralColorationEndRound")]
        public GlyphDefinition MensuralColorationEndRound { get; set; }

        [JsonProperty("mensuralColorationEndSquare")]
        public GlyphDefinition MensuralColorationEndSquare { get; set; }

        [JsonProperty("mensuralColorationStartRound")]
        public GlyphDefinition MensuralColorationStartRound { get; set; }

        [JsonProperty("mensuralColorationStartSquare")]
        public GlyphDefinition MensuralColorationStartSquare { get; set; }

        [JsonProperty("mensuralCombStemDiagonal")]
        public GlyphDefinition MensuralCombStemDiagonal { get; set; }

        [JsonProperty("mensuralCombStemDown")]
        public GlyphDefinition MensuralCombStemDown { get; set; }

        [JsonProperty("mensuralCombStemDownFlagExtended")]
        public GlyphDefinition MensuralCombStemDownFlagExtended { get; set; }

        [JsonProperty("mensuralCombStemDownFlagFlared")]
        public GlyphDefinition MensuralCombStemDownFlagFlared { get; set; }

        [JsonProperty("mensuralCombStemDownFlagFusa")]
        public GlyphDefinition MensuralCombStemDownFlagFusa { get; set; }

        [JsonProperty("mensuralCombStemDownFlagLeft")]
        public GlyphDefinition MensuralCombStemDownFlagLeft { get; set; }

        [JsonProperty("mensuralCombStemDownFlagRight")]
        public GlyphDefinition MensuralCombStemDownFlagRight { get; set; }

        [JsonProperty("mensuralCombStemDownFlagSemiminima")]
        public GlyphDefinition MensuralCombStemDownFlagSemiminima { get; set; }

        [JsonProperty("mensuralCombStemUp")]
        public GlyphDefinition MensuralCombStemUp { get; set; }

        [JsonProperty("mensuralCombStemUpFlagExtended")]
        public GlyphDefinition MensuralCombStemUpFlagExtended { get; set; }

        [JsonProperty("mensuralCombStemUpFlagFlared")]
        public GlyphDefinition MensuralCombStemUpFlagFlared { get; set; }

        [JsonProperty("mensuralCombStemUpFlagFusa")]
        public GlyphDefinition MensuralCombStemUpFlagFusa { get; set; }

        [JsonProperty("mensuralCombStemUpFlagLeft")]
        public GlyphDefinition MensuralCombStemUpFlagLeft { get; set; }

        [JsonProperty("mensuralCombStemUpFlagRight")]
        public GlyphDefinition MensuralCombStemUpFlagRight { get; set; }

        [JsonProperty("mensuralCombStemUpFlagSemiminima")]
        public GlyphDefinition MensuralCombStemUpFlagSemiminima { get; set; }

        [JsonProperty("mensuralCustosCheckmark")]
        public GlyphDefinition MensuralCustosCheckmark { get; set; }

        [JsonProperty("mensuralCustosDown")]
        public GlyphDefinition MensuralCustosDown { get; set; }

        [JsonProperty("mensuralCustosTurn")]
        public GlyphDefinition MensuralCustosTurn { get; set; }

        [JsonProperty("mensuralCustosUp")]
        public GlyphDefinition MensuralCustosUp { get; set; }

        [JsonProperty("mensuralFclef")]
        public GlyphDefinition MensuralFclef { get; set; }

        [JsonProperty("mensuralFclefPetrucci")]
        public GlyphDefinition MensuralFclefPetrucci { get; set; }

        [JsonProperty("mensuralGclef")]
        public GlyphDefinition MensuralGclef { get; set; }

        [JsonProperty("mensuralGclefPetrucci")]
        public GlyphDefinition MensuralGclefPetrucci { get; set; }

        [JsonProperty("mensuralModusImperfectumVert")]
        public GlyphDefinition MensuralModusImperfectumVert { get; set; }

        [JsonProperty("mensuralModusPerfectumVert")]
        public GlyphDefinition MensuralModusPerfectumVert { get; set; }

        [JsonProperty("mensuralNoteheadLongaBlack")]
        public GlyphDefinition MensuralNoteheadLongaBlack { get; set; }

        [JsonProperty("mensuralNoteheadLongaBlackVoid")]
        public GlyphDefinition MensuralNoteheadLongaBlackVoid { get; set; }

        [JsonProperty("mensuralNoteheadLongaVoid")]
        public GlyphDefinition MensuralNoteheadLongaVoid { get; set; }

        [JsonProperty("mensuralNoteheadLongaWhite")]
        public GlyphDefinition MensuralNoteheadLongaWhite { get; set; }

        [JsonProperty("mensuralNoteheadMaximaBlack")]
        public GlyphDefinition MensuralNoteheadMaximaBlack { get; set; }

        [JsonProperty("mensuralNoteheadMaximaBlackVoid")]
        public GlyphDefinition MensuralNoteheadMaximaBlackVoid { get; set; }

        [JsonProperty("mensuralNoteheadMaximaVoid")]
        public GlyphDefinition MensuralNoteheadMaximaVoid { get; set; }

        [JsonProperty("mensuralNoteheadMaximaWhite")]
        public GlyphDefinition MensuralNoteheadMaximaWhite { get; set; }

        [JsonProperty("mensuralNoteheadMinimaWhite")]
        public GlyphDefinition MensuralNoteheadMinimaWhite { get; set; }

        [JsonProperty("mensuralNoteheadSemibrevisBlack")]
        public GlyphDefinition MensuralNoteheadSemibrevisBlack { get; set; }

        [JsonProperty("mensuralNoteheadSemibrevisBlackVoid")]
        public GlyphDefinition MensuralNoteheadSemibrevisBlackVoid { get; set; }

        [JsonProperty("mensuralNoteheadSemibrevisBlackVoidTurned")]
        public GlyphDefinition MensuralNoteheadSemibrevisBlackVoidTurned { get; set; }

        [JsonProperty("mensuralNoteheadSemibrevisVoid")]
        public GlyphDefinition MensuralNoteheadSemibrevisVoid { get; set; }

        [JsonProperty("mensuralNoteheadSemiminimaWhite")]
        public GlyphDefinition MensuralNoteheadSemiminimaWhite { get; set; }

        [JsonProperty("mensuralObliqueAsc2ndBlack")]
        public GlyphDefinition MensuralObliqueAsc2NdBlack { get; set; }

        [JsonProperty("mensuralObliqueAsc2ndBlackVoid")]
        public GlyphDefinition MensuralObliqueAsc2NdBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc2ndVoid")]
        public GlyphDefinition MensuralObliqueAsc2NdVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc2ndWhite")]
        public GlyphDefinition MensuralObliqueAsc2NdWhite { get; set; }

        [JsonProperty("mensuralObliqueAsc3rdBlack")]
        public GlyphDefinition MensuralObliqueAsc3RdBlack { get; set; }

        [JsonProperty("mensuralObliqueAsc3rdBlackVoid")]
        public GlyphDefinition MensuralObliqueAsc3RdBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc3rdVoid")]
        public GlyphDefinition MensuralObliqueAsc3RdVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc3rdWhite")]
        public GlyphDefinition MensuralObliqueAsc3RdWhite { get; set; }

        [JsonProperty("mensuralObliqueAsc4thBlack")]
        public GlyphDefinition MensuralObliqueAsc4ThBlack { get; set; }

        [JsonProperty("mensuralObliqueAsc4thBlackVoid")]
        public GlyphDefinition MensuralObliqueAsc4ThBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc4thVoid")]
        public GlyphDefinition MensuralObliqueAsc4ThVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc4thWhite")]
        public GlyphDefinition MensuralObliqueAsc4ThWhite { get; set; }

        [JsonProperty("mensuralObliqueAsc5thBlack")]
        public GlyphDefinition MensuralObliqueAsc5ThBlack { get; set; }

        [JsonProperty("mensuralObliqueAsc5thBlackVoid")]
        public GlyphDefinition MensuralObliqueAsc5ThBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc5thVoid")]
        public GlyphDefinition MensuralObliqueAsc5ThVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc5thWhite")]
        public GlyphDefinition MensuralObliqueAsc5ThWhite { get; set; }

        [JsonProperty("mensuralObliqueDesc2ndBlack")]
        public GlyphDefinition MensuralObliqueDesc2NdBlack { get; set; }

        [JsonProperty("mensuralObliqueDesc2ndBlackVoid")]
        public GlyphDefinition MensuralObliqueDesc2NdBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc2ndVoid")]
        public GlyphDefinition MensuralObliqueDesc2NdVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc2ndWhite")]
        public GlyphDefinition MensuralObliqueDesc2NdWhite { get; set; }

        [JsonProperty("mensuralObliqueDesc3rdBlack")]
        public GlyphDefinition MensuralObliqueDesc3RdBlack { get; set; }

        [JsonProperty("mensuralObliqueDesc3rdBlackVoid")]
        public GlyphDefinition MensuralObliqueDesc3RdBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc3rdVoid")]
        public GlyphDefinition MensuralObliqueDesc3RdVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc3rdWhite")]
        public GlyphDefinition MensuralObliqueDesc3RdWhite { get; set; }

        [JsonProperty("mensuralObliqueDesc4thBlack")]
        public GlyphDefinition MensuralObliqueDesc4ThBlack { get; set; }

        [JsonProperty("mensuralObliqueDesc4thBlackVoid")]
        public GlyphDefinition MensuralObliqueDesc4ThBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc4thVoid")]
        public GlyphDefinition MensuralObliqueDesc4ThVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc4thWhite")]
        public GlyphDefinition MensuralObliqueDesc4ThWhite { get; set; }

        [JsonProperty("mensuralObliqueDesc5thBlack")]
        public GlyphDefinition MensuralObliqueDesc5ThBlack { get; set; }

        [JsonProperty("mensuralObliqueDesc5thBlackVoid")]
        public GlyphDefinition MensuralObliqueDesc5ThBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc5thVoid")]
        public GlyphDefinition MensuralObliqueDesc5ThVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc5thWhite")]
        public GlyphDefinition MensuralObliqueDesc5ThWhite { get; set; }

        [JsonProperty("mensuralProlation1")]
        public GlyphDefinition MensuralProlation1 { get; set; }

        [JsonProperty("mensuralProlation10")]
        public GlyphDefinition MensuralProlation10 { get; set; }

        [JsonProperty("mensuralProlation11")]
        public GlyphDefinition MensuralProlation11 { get; set; }

        [JsonProperty("mensuralProlation2")]
        public GlyphDefinition MensuralProlation2 { get; set; }

        [JsonProperty("mensuralProlation3")]
        public GlyphDefinition MensuralProlation3 { get; set; }

        [JsonProperty("mensuralProlation4")]
        public GlyphDefinition MensuralProlation4 { get; set; }

        [JsonProperty("mensuralProlation5")]
        public GlyphDefinition MensuralProlation5 { get; set; }

        [JsonProperty("mensuralProlation6")]
        public GlyphDefinition MensuralProlation6 { get; set; }

        [JsonProperty("mensuralProlation7")]
        public GlyphDefinition MensuralProlation7 { get; set; }

        [JsonProperty("mensuralProlation8")]
        public GlyphDefinition MensuralProlation8 { get; set; }

        [JsonProperty("mensuralProlation9")]
        public GlyphDefinition MensuralProlation9 { get; set; }

        [JsonProperty("mensuralProlationCombiningDot")]
        public GlyphDefinition MensuralProlationCombiningDot { get; set; }

        [JsonProperty("mensuralProlationCombiningDotVoid")]
        public GlyphDefinition MensuralProlationCombiningDotVoid { get; set; }

        [JsonProperty("mensuralProlationCombiningStroke")]
        public GlyphDefinition MensuralProlationCombiningStroke { get; set; }

        [JsonProperty("mensuralProlationCombiningThreeDots")]
        public GlyphDefinition MensuralProlationCombiningThreeDots { get; set; }

        [JsonProperty("mensuralProlationCombiningThreeDotsTri")]
        public GlyphDefinition MensuralProlationCombiningThreeDotsTri { get; set; }

        [JsonProperty("mensuralProlationCombiningTwoDots")]
        public GlyphDefinition MensuralProlationCombiningTwoDots { get; set; }

        [JsonProperty("mensuralProportion1")]
        public GlyphDefinition MensuralProportion1 { get; set; }

        [JsonProperty("mensuralProportion2")]
        public GlyphDefinition MensuralProportion2 { get; set; }

        [JsonProperty("mensuralProportion3")]
        public GlyphDefinition MensuralProportion3 { get; set; }

        [JsonProperty("mensuralProportion4")]
        public GlyphDefinition MensuralProportion4 { get; set; }

        [JsonProperty("mensuralProportionMajor")]
        public GlyphDefinition MensuralProportionMajor { get; set; }

        [JsonProperty("mensuralProportionMinor")]
        public GlyphDefinition MensuralProportionMinor { get; set; }

        [JsonProperty("mensuralProportionProportioDupla1")]
        public GlyphDefinition MensuralProportionProportioDupla1 { get; set; }

        [JsonProperty("mensuralProportionProportioDupla2")]
        public GlyphDefinition MensuralProportionProportioDupla2 { get; set; }

        [JsonProperty("mensuralProportionProportioQuadrupla")]
        public GlyphDefinition MensuralProportionProportioQuadrupla { get; set; }

        [JsonProperty("mensuralProportionProportioTripla")]
        public GlyphDefinition MensuralProportionProportioTripla { get; set; }

        [JsonProperty("mensuralProportionTempusPerfectum")]
        public GlyphDefinition MensuralProportionTempusPerfectum { get; set; }

        [JsonProperty("mensuralRestBrevis")]
        public GlyphDefinition MensuralRestBrevis { get; set; }

        [JsonProperty("mensuralRestFusa")]
        public GlyphDefinition MensuralRestFusa { get; set; }

        [JsonProperty("mensuralRestLongaImperfecta")]
        public GlyphDefinition MensuralRestLongaImperfecta { get; set; }

        [JsonProperty("mensuralRestLongaPerfecta")]
        public GlyphDefinition MensuralRestLongaPerfecta { get; set; }

        [JsonProperty("mensuralRestMaxima")]
        public GlyphDefinition MensuralRestMaxima { get; set; }

        [JsonProperty("mensuralRestMinima")]
        public GlyphDefinition MensuralRestMinima { get; set; }

        [JsonProperty("mensuralRestSemibrevis")]
        public GlyphDefinition MensuralRestSemibrevis { get; set; }

        [JsonProperty("mensuralRestSemifusa")]
        public GlyphDefinition MensuralRestSemifusa { get; set; }

        [JsonProperty("mensuralRestSemiminima")]
        public GlyphDefinition MensuralRestSemiminima { get; set; }

        [JsonProperty("mensuralSignumDown")]
        public GlyphDefinition MensuralSignumDown { get; set; }

        [JsonProperty("mensuralSignumUp")]
        public GlyphDefinition MensuralSignumUp { get; set; }

        [JsonProperty("mensuralTempusImperfectumHoriz")]
        public GlyphDefinition MensuralTempusImperfectumHoriz { get; set; }

        [JsonProperty("mensuralTempusPerfectumHoriz")]
        public GlyphDefinition MensuralTempusPerfectumHoriz { get; set; }

        [JsonProperty("mensuralWhiteBrevis")]
        public GlyphDefinition MensuralWhiteBrevis { get; set; }

        [JsonProperty("mensuralWhiteFusa")]
        public GlyphDefinition MensuralWhiteFusa { get; set; }

        [JsonProperty("mensuralWhiteLonga")]
        public GlyphDefinition MensuralWhiteLonga { get; set; }

        [JsonProperty("mensuralWhiteMaxima")]
        public GlyphDefinition MensuralWhiteMaxima { get; set; }

        [JsonProperty("mensuralWhiteMinima")]
        public GlyphDefinition MensuralWhiteMinima { get; set; }

        [JsonProperty("mensuralWhiteSemiminima")]
        public GlyphDefinition MensuralWhiteSemiminima { get; set; }

        [JsonProperty("metricModulationArrowLeft")]
        public GlyphDefinition MetricModulationArrowLeft { get; set; }

        [JsonProperty("metricModulationArrowRight")]
        public GlyphDefinition MetricModulationArrowRight { get; set; }

        [JsonProperty("miscDoNotCopy")]
        public GlyphDefinition MiscDoNotCopy { get; set; }

        [JsonProperty("miscDoNotPhotocopy")]
        public GlyphDefinition MiscDoNotPhotocopy { get; set; }

        [JsonProperty("miscEyeglasses")]
        public GlyphDefinition MiscEyeglasses { get; set; }

        [JsonProperty("note1024thDown")]
        public GlyphDefinition Note1024ThDown { get; set; }

        [JsonProperty("note1024thUp")]
        public GlyphDefinition Note1024ThUp { get; set; }

        [JsonProperty("note128thDown")]
        public GlyphDefinition Note128ThDown { get; set; }

        [JsonProperty("note128thUp")]
        public GlyphDefinition Note128ThUp { get; set; }

        [JsonProperty("note16thDown")]
        public GlyphDefinition Note16ThDown { get; set; }

        [JsonProperty("note16thUp")]
        public GlyphDefinition Note16ThUp { get; set; }

        [JsonProperty("note256thDown")]
        public GlyphDefinition Note256ThDown { get; set; }

        [JsonProperty("note256thUp")]
        public GlyphDefinition Note256ThUp { get; set; }

        [JsonProperty("note32ndDown")]
        public GlyphDefinition Note32NdDown { get; set; }

        [JsonProperty("note32ndUp")]
        public GlyphDefinition Note32NdUp { get; set; }

        [JsonProperty("note512thDown")]
        public GlyphDefinition Note512ThDown { get; set; }

        [JsonProperty("note512thUp")]
        public GlyphDefinition Note512ThUp { get; set; }

        [JsonProperty("note64thDown")]
        public GlyphDefinition Note64ThDown { get; set; }

        [JsonProperty("note64thUp")]
        public GlyphDefinition Note64ThUp { get; set; }

        [JsonProperty("note8thDown")]
        public GlyphDefinition Note8ThDown { get; set; }

        [JsonProperty("note8thUp")]
        public GlyphDefinition Note8ThUp { get; set; }

        [JsonProperty("noteABlack")]
        public GlyphDefinition NoteABlack { get; set; }

        [JsonProperty("noteAFlatBlack")]
        public GlyphDefinition NoteAFlatBlack { get; set; }

        [JsonProperty("noteAFlatHalf")]
        public GlyphDefinition NoteAFlatHalf { get; set; }

        [JsonProperty("noteAFlatWhole")]
        public GlyphDefinition NoteAFlatWhole { get; set; }

        [JsonProperty("noteAHalf")]
        public GlyphDefinition NoteAHalf { get; set; }

        [JsonProperty("noteASharpBlack")]
        public GlyphDefinition NoteASharpBlack { get; set; }

        [JsonProperty("noteASharpHalf")]
        public GlyphDefinition NoteASharpHalf { get; set; }

        [JsonProperty("noteASharpWhole")]
        public GlyphDefinition NoteASharpWhole { get; set; }

        [JsonProperty("noteAWhole")]
        public GlyphDefinition NoteAWhole { get; set; }

        [JsonProperty("noteBBlack")]
        public GlyphDefinition NoteBBlack { get; set; }

        [JsonProperty("noteBFlatBlack")]
        public GlyphDefinition NoteBFlatBlack { get; set; }

        [JsonProperty("noteBFlatHalf")]
        public GlyphDefinition NoteBFlatHalf { get; set; }

        [JsonProperty("noteBFlatWhole")]
        public GlyphDefinition NoteBFlatWhole { get; set; }

        [JsonProperty("noteBHalf")]
        public GlyphDefinition NoteBHalf { get; set; }

        [JsonProperty("noteBSharpBlack")]
        public GlyphDefinition NoteBSharpBlack { get; set; }

        [JsonProperty("noteBSharpHalf")]
        public GlyphDefinition NoteBSharpHalf { get; set; }

        [JsonProperty("noteBSharpWhole")]
        public GlyphDefinition NoteBSharpWhole { get; set; }

        [JsonProperty("noteBWhole")]
        public GlyphDefinition NoteBWhole { get; set; }

        [JsonProperty("noteCBlack")]
        public GlyphDefinition NoteCBlack { get; set; }

        [JsonProperty("noteCFlatBlack")]
        public GlyphDefinition NoteCFlatBlack { get; set; }

        [JsonProperty("noteCFlatHalf")]
        public GlyphDefinition NoteCFlatHalf { get; set; }

        [JsonProperty("noteCFlatWhole")]
        public GlyphDefinition NoteCFlatWhole { get; set; }

        [JsonProperty("noteCHalf")]
        public GlyphDefinition NoteCHalf { get; set; }

        [JsonProperty("noteCSharpBlack")]
        public GlyphDefinition NoteCSharpBlack { get; set; }

        [JsonProperty("noteCSharpHalf")]
        public GlyphDefinition NoteCSharpHalf { get; set; }

        [JsonProperty("noteCSharpWhole")]
        public GlyphDefinition NoteCSharpWhole { get; set; }

        [JsonProperty("noteCWhole")]
        public GlyphDefinition NoteCWhole { get; set; }

        [JsonProperty("noteDBlack")]
        public GlyphDefinition NoteDBlack { get; set; }

        [JsonProperty("noteDFlatBlack")]
        public GlyphDefinition NoteDFlatBlack { get; set; }

        [JsonProperty("noteDFlatHalf")]
        public GlyphDefinition NoteDFlatHalf { get; set; }

        [JsonProperty("noteDFlatWhole")]
        public GlyphDefinition NoteDFlatWhole { get; set; }

        [JsonProperty("noteDHalf")]
        public GlyphDefinition NoteDHalf { get; set; }

        [JsonProperty("noteDSharpBlack")]
        public GlyphDefinition NoteDSharpBlack { get; set; }

        [JsonProperty("noteDSharpHalf")]
        public GlyphDefinition NoteDSharpHalf { get; set; }

        [JsonProperty("noteDSharpWhole")]
        public GlyphDefinition NoteDSharpWhole { get; set; }

        [JsonProperty("noteDWhole")]
        public GlyphDefinition NoteDWhole { get; set; }

        [JsonProperty("noteDoBlack")]
        public GlyphDefinition NoteDoBlack { get; set; }

        [JsonProperty("noteDoHalf")]
        public GlyphDefinition NoteDoHalf { get; set; }

        [JsonProperty("noteDoWhole")]
        public GlyphDefinition NoteDoWhole { get; set; }

        [JsonProperty("noteDoubleWhole")]
        public GlyphDefinition NoteDoubleWhole { get; set; }

        [JsonProperty("noteDoubleWholeSquare")]
        public GlyphDefinition NoteDoubleWholeSquare { get; set; }

        [JsonProperty("noteEBlack")]
        public GlyphDefinition NoteEBlack { get; set; }

        [JsonProperty("noteEFlatBlack")]
        public GlyphDefinition NoteEFlatBlack { get; set; }

        [JsonProperty("noteEFlatHalf")]
        public GlyphDefinition NoteEFlatHalf { get; set; }

        [JsonProperty("noteEFlatWhole")]
        public GlyphDefinition NoteEFlatWhole { get; set; }

        [JsonProperty("noteEHalf")]
        public GlyphDefinition NoteEHalf { get; set; }

        [JsonProperty("noteESharpBlack")]
        public GlyphDefinition NoteESharpBlack { get; set; }

        [JsonProperty("noteESharpHalf")]
        public GlyphDefinition NoteESharpHalf { get; set; }

        [JsonProperty("noteESharpWhole")]
        public GlyphDefinition NoteESharpWhole { get; set; }

        [JsonProperty("noteEWhole")]
        public GlyphDefinition NoteEWhole { get; set; }

        [JsonProperty("noteEmptyBlack")]
        public GlyphDefinition NoteEmptyBlack { get; set; }

        [JsonProperty("noteEmptyHalf")]
        public GlyphDefinition NoteEmptyHalf { get; set; }

        [JsonProperty("noteEmptyWhole")]
        public GlyphDefinition NoteEmptyWhole { get; set; }

        [JsonProperty("noteFBlack")]
        public GlyphDefinition NoteFBlack { get; set; }

        [JsonProperty("noteFFlatBlack")]
        public GlyphDefinition NoteFFlatBlack { get; set; }

        [JsonProperty("noteFFlatHalf")]
        public GlyphDefinition NoteFFlatHalf { get; set; }

        [JsonProperty("noteFFlatWhole")]
        public GlyphDefinition NoteFFlatWhole { get; set; }

        [JsonProperty("noteFHalf")]
        public GlyphDefinition NoteFHalf { get; set; }

        [JsonProperty("noteFSharpBlack")]
        public GlyphDefinition NoteFSharpBlack { get; set; }

        [JsonProperty("noteFSharpHalf")]
        public GlyphDefinition NoteFSharpHalf { get; set; }

        [JsonProperty("noteFSharpWhole")]
        public GlyphDefinition NoteFSharpWhole { get; set; }

        [JsonProperty("noteFWhole")]
        public GlyphDefinition NoteFWhole { get; set; }

        [JsonProperty("noteFaBlack")]
        public GlyphDefinition NoteFaBlack { get; set; }

        [JsonProperty("noteFaHalf")]
        public GlyphDefinition NoteFaHalf { get; set; }

        [JsonProperty("noteFaWhole")]
        public GlyphDefinition NoteFaWhole { get; set; }

        [JsonProperty("noteGBlack")]
        public GlyphDefinition NoteGBlack { get; set; }

        [JsonProperty("noteGFlatBlack")]
        public GlyphDefinition NoteGFlatBlack { get; set; }

        [JsonProperty("noteGFlatHalf")]
        public GlyphDefinition NoteGFlatHalf { get; set; }

        [JsonProperty("noteGFlatWhole")]
        public GlyphDefinition NoteGFlatWhole { get; set; }

        [JsonProperty("noteGHalf")]
        public GlyphDefinition NoteGHalf { get; set; }

        [JsonProperty("noteGSharpBlack")]
        public GlyphDefinition NoteGSharpBlack { get; set; }

        [JsonProperty("noteGSharpHalf")]
        public GlyphDefinition NoteGSharpHalf { get; set; }

        [JsonProperty("noteGSharpWhole")]
        public GlyphDefinition NoteGSharpWhole { get; set; }

        [JsonProperty("noteGWhole")]
        public GlyphDefinition NoteGWhole { get; set; }

        [JsonProperty("noteHBlack")]
        public GlyphDefinition NoteHBlack { get; set; }

        [JsonProperty("noteHHalf")]
        public GlyphDefinition NoteHHalf { get; set; }

        [JsonProperty("noteHSharpBlack")]
        public GlyphDefinition NoteHSharpBlack { get; set; }

        [JsonProperty("noteHSharpHalf")]
        public GlyphDefinition NoteHSharpHalf { get; set; }

        [JsonProperty("noteHSharpWhole")]
        public GlyphDefinition NoteHSharpWhole { get; set; }

        [JsonProperty("noteHWhole")]
        public GlyphDefinition NoteHWhole { get; set; }

        [JsonProperty("noteHalfDown")]
        public GlyphDefinition NoteHalfDown { get; set; }

        [JsonProperty("noteHalfUp")]
        public GlyphDefinition NoteHalfUp { get; set; }

        [JsonProperty("noteLaBlack")]
        public GlyphDefinition NoteLaBlack { get; set; }

        [JsonProperty("noteLaHalf")]
        public GlyphDefinition NoteLaHalf { get; set; }

        [JsonProperty("noteLaWhole")]
        public GlyphDefinition NoteLaWhole { get; set; }

        [JsonProperty("noteMiBlack")]
        public GlyphDefinition NoteMiBlack { get; set; }

        [JsonProperty("noteMiHalf")]
        public GlyphDefinition NoteMiHalf { get; set; }

        [JsonProperty("noteMiWhole")]
        public GlyphDefinition NoteMiWhole { get; set; }

        [JsonProperty("noteQuarterDown")]
        public GlyphDefinition NoteQuarterDown { get; set; }

        [JsonProperty("noteQuarterUp")]
        public GlyphDefinition NoteQuarterUp { get; set; }

        [JsonProperty("noteReBlack")]
        public GlyphDefinition NoteReBlack { get; set; }

        [JsonProperty("noteReHalf")]
        public GlyphDefinition NoteReHalf { get; set; }

        [JsonProperty("noteReWhole")]
        public GlyphDefinition NoteReWhole { get; set; }

        [JsonProperty("noteShapeArrowheadLeftBlack")]
        public GlyphDefinition NoteShapeArrowheadLeftBlack { get; set; }

        [JsonProperty("noteShapeArrowheadLeftWhite")]
        public GlyphDefinition NoteShapeArrowheadLeftWhite { get; set; }

        [JsonProperty("noteShapeDiamondBlack")]
        public GlyphDefinition NoteShapeDiamondBlack { get; set; }

        [JsonProperty("noteShapeDiamondWhite")]
        public GlyphDefinition NoteShapeDiamondWhite { get; set; }

        [JsonProperty("noteShapeIsoscelesTriangleBlack")]
        public GlyphDefinition NoteShapeIsoscelesTriangleBlack { get; set; }

        [JsonProperty("noteShapeIsoscelesTriangleWhite")]
        public GlyphDefinition NoteShapeIsoscelesTriangleWhite { get; set; }

        [JsonProperty("noteShapeKeystoneBlack")]
        public GlyphDefinition NoteShapeKeystoneBlack { get; set; }

        [JsonProperty("noteShapeKeystoneWhite")]
        public GlyphDefinition NoteShapeKeystoneWhite { get; set; }

        [JsonProperty("noteShapeMoonBlack")]
        public GlyphDefinition NoteShapeMoonBlack { get; set; }

        [JsonProperty("noteShapeMoonLeftBlack")]
        public GlyphDefinition NoteShapeMoonLeftBlack { get; set; }

        [JsonProperty("noteShapeMoonLeftWhite")]
        public GlyphDefinition NoteShapeMoonLeftWhite { get; set; }

        [JsonProperty("noteShapeMoonWhite")]
        public GlyphDefinition NoteShapeMoonWhite { get; set; }

        [JsonProperty("noteShapeQuarterMoonBlack")]
        public GlyphDefinition NoteShapeQuarterMoonBlack { get; set; }

        [JsonProperty("noteShapeQuarterMoonWhite")]
        public GlyphDefinition NoteShapeQuarterMoonWhite { get; set; }

        [JsonProperty("noteShapeRoundBlack")]
        public GlyphDefinition NoteShapeRoundBlack { get; set; }

        [JsonProperty("noteShapeRoundWhite")]
        public GlyphDefinition NoteShapeRoundWhite { get; set; }

        [JsonProperty("noteShapeSquareBlack")]
        public GlyphDefinition NoteShapeSquareBlack { get; set; }

        [JsonProperty("noteShapeSquareWhite")]
        public GlyphDefinition NoteShapeSquareWhite { get; set; }

        [JsonProperty("noteShapeTriangleLeftBlack")]
        public GlyphDefinition NoteShapeTriangleLeftBlack { get; set; }

        [JsonProperty("noteShapeTriangleLeftWhite")]
        public GlyphDefinition NoteShapeTriangleLeftWhite { get; set; }

        [JsonProperty("noteShapeTriangleRightBlack")]
        public GlyphDefinition NoteShapeTriangleRightBlack { get; set; }

        [JsonProperty("noteShapeTriangleRightWhite")]
        public GlyphDefinition NoteShapeTriangleRightWhite { get; set; }

        [JsonProperty("noteShapeTriangleRoundBlack")]
        public GlyphDefinition NoteShapeTriangleRoundBlack { get; set; }

        [JsonProperty("noteShapeTriangleRoundLeftBlack")]
        public GlyphDefinition NoteShapeTriangleRoundLeftBlack { get; set; }

        [JsonProperty("noteShapeTriangleRoundLeftWhite")]
        public GlyphDefinition NoteShapeTriangleRoundLeftWhite { get; set; }

        [JsonProperty("noteShapeTriangleRoundWhite")]
        public GlyphDefinition NoteShapeTriangleRoundWhite { get; set; }

        [JsonProperty("noteShapeTriangleUpBlack")]
        public GlyphDefinition NoteShapeTriangleUpBlack { get; set; }

        [JsonProperty("noteShapeTriangleUpWhite")]
        public GlyphDefinition NoteShapeTriangleUpWhite { get; set; }

        [JsonProperty("noteSiBlack")]
        public GlyphDefinition NoteSiBlack { get; set; }

        [JsonProperty("noteSiHalf")]
        public GlyphDefinition NoteSiHalf { get; set; }

        [JsonProperty("noteSiWhole")]
        public GlyphDefinition NoteSiWhole { get; set; }

        [JsonProperty("noteSoBlack")]
        public GlyphDefinition NoteSoBlack { get; set; }

        [JsonProperty("noteSoHalf")]
        public GlyphDefinition NoteSoHalf { get; set; }

        [JsonProperty("noteSoWhole")]
        public GlyphDefinition NoteSoWhole { get; set; }

        [JsonProperty("noteTiBlack")]
        public GlyphDefinition NoteTiBlack { get; set; }

        [JsonProperty("noteTiHalf")]
        public GlyphDefinition NoteTiHalf { get; set; }

        [JsonProperty("noteTiWhole")]
        public GlyphDefinition NoteTiWhole { get; set; }

        [JsonProperty("noteWhole")]
        public GlyphDefinition NoteWhole { get; set; }

        [JsonProperty("noteheadBlack")]
        public GlyphDefinition NoteheadBlack { get; set; }

        [JsonProperty("noteheadCircleSlash")]
        public GlyphDefinition NoteheadCircleSlash { get; set; }

        [JsonProperty("noteheadCircleX")]
        public GlyphDefinition NoteheadCircleX { get; set; }

        [JsonProperty("noteheadCircleXDoubleWhole")]
        public GlyphDefinition NoteheadCircleXDoubleWhole { get; set; }

        [JsonProperty("noteheadCircleXHalf")]
        public GlyphDefinition NoteheadCircleXHalf { get; set; }

        [JsonProperty("noteheadCircleXWhole")]
        public GlyphDefinition NoteheadCircleXWhole { get; set; }

        [JsonProperty("noteheadCircledBlack")]
        public GlyphDefinition NoteheadCircledBlack { get; set; }

        [JsonProperty("noteheadCircledBlackLarge")]
        public GlyphDefinition NoteheadCircledBlackLarge { get; set; }

        [JsonProperty("noteheadCircledDoubleWhole")]
        public GlyphDefinition NoteheadCircledDoubleWhole { get; set; }

        [JsonProperty("noteheadCircledDoubleWholeLarge")]
        public GlyphDefinition NoteheadCircledDoubleWholeLarge { get; set; }

        [JsonProperty("noteheadCircledHalf")]
        public GlyphDefinition NoteheadCircledHalf { get; set; }

        [JsonProperty("noteheadCircledHalfLarge")]
        public GlyphDefinition NoteheadCircledHalfLarge { get; set; }

        [JsonProperty("noteheadCircledWhole")]
        public GlyphDefinition NoteheadCircledWhole { get; set; }

        [JsonProperty("noteheadCircledWholeLarge")]
        public GlyphDefinition NoteheadCircledWholeLarge { get; set; }

        [JsonProperty("noteheadCircledXLarge")]
        public GlyphDefinition NoteheadCircledXLarge { get; set; }

        [JsonProperty("noteheadClusterDoubleWhole2nd")]
        public GlyphDefinition NoteheadClusterDoubleWhole2Nd { get; set; }

        [JsonProperty("noteheadClusterDoubleWhole3rd")]
        public GlyphDefinition NoteheadClusterDoubleWhole3Rd { get; set; }

        [JsonProperty("noteheadClusterDoubleWholeBottom")]
        public GlyphDefinition NoteheadClusterDoubleWholeBottom { get; set; }

        [JsonProperty("noteheadClusterDoubleWholeMiddle")]
        public GlyphDefinition NoteheadClusterDoubleWholeMiddle { get; set; }

        [JsonProperty("noteheadClusterDoubleWholeTop")]
        public GlyphDefinition NoteheadClusterDoubleWholeTop { get; set; }

        [JsonProperty("noteheadClusterHalf2nd")]
        public GlyphDefinition NoteheadClusterHalf2Nd { get; set; }

        [JsonProperty("noteheadClusterHalf3rd")]
        public GlyphDefinition NoteheadClusterHalf3Rd { get; set; }

        [JsonProperty("noteheadClusterHalfBottom")]
        public GlyphDefinition NoteheadClusterHalfBottom { get; set; }

        [JsonProperty("noteheadClusterHalfMiddle")]
        public GlyphDefinition NoteheadClusterHalfMiddle { get; set; }

        [JsonProperty("noteheadClusterHalfTop")]
        public GlyphDefinition NoteheadClusterHalfTop { get; set; }

        [JsonProperty("noteheadClusterQuarter2nd")]
        public GlyphDefinition NoteheadClusterQuarter2Nd { get; set; }

        [JsonProperty("noteheadClusterQuarter3rd")]
        public GlyphDefinition NoteheadClusterQuarter3Rd { get; set; }

        [JsonProperty("noteheadClusterQuarterBottom")]
        public GlyphDefinition NoteheadClusterQuarterBottom { get; set; }

        [JsonProperty("noteheadClusterQuarterMiddle")]
        public GlyphDefinition NoteheadClusterQuarterMiddle { get; set; }

        [JsonProperty("noteheadClusterQuarterTop")]
        public GlyphDefinition NoteheadClusterQuarterTop { get; set; }

        [JsonProperty("noteheadClusterRoundBlack")]
        public GlyphDefinition NoteheadClusterRoundBlack { get; set; }

        [JsonProperty("noteheadClusterRoundWhite")]
        public GlyphDefinition NoteheadClusterRoundWhite { get; set; }

        [JsonProperty("noteheadClusterSquareBlack")]
        public GlyphDefinition NoteheadClusterSquareBlack { get; set; }

        [JsonProperty("noteheadClusterSquareWhite")]
        public GlyphDefinition NoteheadClusterSquareWhite { get; set; }

        [JsonProperty("noteheadClusterWhole2nd")]
        public GlyphDefinition NoteheadClusterWhole2Nd { get; set; }

        [JsonProperty("noteheadClusterWhole3rd")]
        public GlyphDefinition NoteheadClusterWhole3Rd { get; set; }

        [JsonProperty("noteheadClusterWholeBottom")]
        public GlyphDefinition NoteheadClusterWholeBottom { get; set; }

        [JsonProperty("noteheadClusterWholeMiddle")]
        public GlyphDefinition NoteheadClusterWholeMiddle { get; set; }

        [JsonProperty("noteheadClusterWholeTop")]
        public GlyphDefinition NoteheadClusterWholeTop { get; set; }

        [JsonProperty("noteheadDiamondBlack")]
        public GlyphDefinition NoteheadDiamondBlack { get; set; }

        [JsonProperty("noteheadDiamondBlackOld")]
        public GlyphDefinition NoteheadDiamondBlackOld { get; set; }

        [JsonProperty("noteheadDiamondBlackWide")]
        public GlyphDefinition NoteheadDiamondBlackWide { get; set; }

        [JsonProperty("noteheadDiamondClusterBlack2nd")]
        public GlyphDefinition NoteheadDiamondClusterBlack2Nd { get; set; }

        [JsonProperty("noteheadDiamondClusterBlack3rd")]
        public GlyphDefinition NoteheadDiamondClusterBlack3Rd { get; set; }

        [JsonProperty("noteheadDiamondClusterBlackBottom")]
        public GlyphDefinition NoteheadDiamondClusterBlackBottom { get; set; }

        [JsonProperty("noteheadDiamondClusterBlackMiddle")]
        public GlyphDefinition NoteheadDiamondClusterBlackMiddle { get; set; }

        [JsonProperty("noteheadDiamondClusterBlackTop")]
        public GlyphDefinition NoteheadDiamondClusterBlackTop { get; set; }

        [JsonProperty("noteheadDiamondClusterWhite2nd")]
        public GlyphDefinition NoteheadDiamondClusterWhite2Nd { get; set; }

        [JsonProperty("noteheadDiamondClusterWhite3rd")]
        public GlyphDefinition NoteheadDiamondClusterWhite3Rd { get; set; }

        [JsonProperty("noteheadDiamondClusterWhiteBottom")]
        public GlyphDefinition NoteheadDiamondClusterWhiteBottom { get; set; }

        [JsonProperty("noteheadDiamondClusterWhiteMiddle")]
        public GlyphDefinition NoteheadDiamondClusterWhiteMiddle { get; set; }

        [JsonProperty("noteheadDiamondClusterWhiteTop")]
        public GlyphDefinition NoteheadDiamondClusterWhiteTop { get; set; }

        [JsonProperty("noteheadDiamondDoubleWhole")]
        public GlyphDefinition NoteheadDiamondDoubleWhole { get; set; }

        [JsonProperty("noteheadDiamondDoubleWholeOld")]
        public GlyphDefinition NoteheadDiamondDoubleWholeOld { get; set; }

        [JsonProperty("noteheadDiamondHalf")]
        public GlyphDefinition NoteheadDiamondHalf { get; set; }

        [JsonProperty("noteheadDiamondHalfFilled")]
        public GlyphDefinition NoteheadDiamondHalfFilled { get; set; }

        [JsonProperty("noteheadDiamondHalfOld")]
        public GlyphDefinition NoteheadDiamondHalfOld { get; set; }

        [JsonProperty("noteheadDiamondHalfWide")]
        public GlyphDefinition NoteheadDiamondHalfWide { get; set; }

        [JsonProperty("noteheadDiamondOpen")]
        public GlyphDefinition NoteheadDiamondOpen { get; set; }

        [JsonProperty("noteheadDiamondWhite")]
        public GlyphDefinition NoteheadDiamondWhite { get; set; }

        [JsonProperty("noteheadDiamondWhiteWide")]
        public GlyphDefinition NoteheadDiamondWhiteWide { get; set; }

        [JsonProperty("noteheadDiamondWhole")]
        public GlyphDefinition NoteheadDiamondWhole { get; set; }

        [JsonProperty("noteheadDiamondWholeOld")]
        public GlyphDefinition NoteheadDiamondWholeOld { get; set; }

        [JsonProperty("noteheadDoubleWhole")]
        public GlyphDefinition NoteheadDoubleWhole { get; set; }

        [JsonProperty("noteheadDoubleWholeSquare")]
        public GlyphDefinition NoteheadDoubleWholeSquare { get; set; }

        [JsonProperty("noteheadDoubleWholeWithX")]
        public GlyphDefinition NoteheadDoubleWholeWithX { get; set; }

        [JsonProperty("noteheadHalf")]
        public GlyphDefinition NoteheadHalf { get; set; }

        [JsonProperty("noteheadHalfFilled")]
        public GlyphDefinition NoteheadHalfFilled { get; set; }

        [JsonProperty("noteheadHalfWithX")]
        public GlyphDefinition NoteheadHalfWithX { get; set; }

        [JsonProperty("noteheadHeavyX")]
        public GlyphDefinition NoteheadHeavyX { get; set; }

        [JsonProperty("noteheadHeavyXHat")]
        public GlyphDefinition NoteheadHeavyXHat { get; set; }

        [JsonProperty("noteheadLargeArrowDownBlack")]
        public GlyphDefinition NoteheadLargeArrowDownBlack { get; set; }

        [JsonProperty("noteheadLargeArrowDownDoubleWhole")]
        public GlyphDefinition NoteheadLargeArrowDownDoubleWhole { get; set; }

        [JsonProperty("noteheadLargeArrowDownHalf")]
        public GlyphDefinition NoteheadLargeArrowDownHalf { get; set; }

        [JsonProperty("noteheadLargeArrowDownWhole")]
        public GlyphDefinition NoteheadLargeArrowDownWhole { get; set; }

        [JsonProperty("noteheadLargeArrowUpBlack")]
        public GlyphDefinition NoteheadLargeArrowUpBlack { get; set; }

        [JsonProperty("noteheadLargeArrowUpDoubleWhole")]
        public GlyphDefinition NoteheadLargeArrowUpDoubleWhole { get; set; }

        [JsonProperty("noteheadLargeArrowUpHalf")]
        public GlyphDefinition NoteheadLargeArrowUpHalf { get; set; }

        [JsonProperty("noteheadLargeArrowUpWhole")]
        public GlyphDefinition NoteheadLargeArrowUpWhole { get; set; }

        [JsonProperty("noteheadMoonBlack")]
        public GlyphDefinition NoteheadMoonBlack { get; set; }

        [JsonProperty("noteheadMoonWhite")]
        public GlyphDefinition NoteheadMoonWhite { get; set; }

        [JsonProperty("noteheadNull")]
        public GlyphDefinition NoteheadNull { get; set; }

        [JsonProperty("noteheadParenthesis")]
        public GlyphDefinition NoteheadParenthesis { get; set; }

        [JsonProperty("noteheadParenthesisLeft")]
        public GlyphDefinition NoteheadParenthesisLeft { get; set; }

        [JsonProperty("noteheadParenthesisRight")]
        public GlyphDefinition NoteheadParenthesisRight { get; set; }

        [JsonProperty("noteheadPlusBlack")]
        public GlyphDefinition NoteheadPlusBlack { get; set; }

        [JsonProperty("noteheadPlusDoubleWhole")]
        public GlyphDefinition NoteheadPlusDoubleWhole { get; set; }

        [JsonProperty("noteheadPlusHalf")]
        public GlyphDefinition NoteheadPlusHalf { get; set; }

        [JsonProperty("noteheadPlusWhole")]
        public GlyphDefinition NoteheadPlusWhole { get; set; }

        [JsonProperty("noteheadRectangularClusterBlackBottom")]
        public GlyphDefinition NoteheadRectangularClusterBlackBottom { get; set; }

        [JsonProperty("noteheadRectangularClusterBlackMiddle")]
        public GlyphDefinition NoteheadRectangularClusterBlackMiddle { get; set; }

        [JsonProperty("noteheadRectangularClusterBlackTop")]
        public GlyphDefinition NoteheadRectangularClusterBlackTop { get; set; }

        [JsonProperty("noteheadRectangularClusterWhiteBottom")]
        public GlyphDefinition NoteheadRectangularClusterWhiteBottom { get; set; }

        [JsonProperty("noteheadRectangularClusterWhiteMiddle")]
        public GlyphDefinition NoteheadRectangularClusterWhiteMiddle { get; set; }

        [JsonProperty("noteheadRectangularClusterWhiteTop")]
        public GlyphDefinition NoteheadRectangularClusterWhiteTop { get; set; }

        [JsonProperty("noteheadRoundBlack")]
        public GlyphDefinition NoteheadRoundBlack { get; set; }

        [JsonProperty("noteheadRoundBlackLarge")]
        public GlyphDefinition NoteheadRoundBlackLarge { get; set; }

        [JsonProperty("noteheadRoundBlackSlashed")]
        public GlyphDefinition NoteheadRoundBlackSlashed { get; set; }

        [JsonProperty("noteheadRoundBlackSlashedLarge")]
        public GlyphDefinition NoteheadRoundBlackSlashedLarge { get; set; }

        [JsonProperty("noteheadRoundWhite")]
        public GlyphDefinition NoteheadRoundWhite { get; set; }

        [JsonProperty("noteheadRoundWhiteLarge")]
        public GlyphDefinition NoteheadRoundWhiteLarge { get; set; }

        [JsonProperty("noteheadRoundWhiteSlashed")]
        public GlyphDefinition NoteheadRoundWhiteSlashed { get; set; }

        [JsonProperty("noteheadRoundWhiteSlashedLarge")]
        public GlyphDefinition NoteheadRoundWhiteSlashedLarge { get; set; }

        [JsonProperty("noteheadRoundWhiteWithDot")]
        public GlyphDefinition NoteheadRoundWhiteWithDot { get; set; }

        [JsonProperty("noteheadRoundWhiteWithDotLarge")]
        public GlyphDefinition NoteheadRoundWhiteWithDotLarge { get; set; }

        [JsonProperty("noteheadSlashDiamondWhite")]
        public GlyphDefinition NoteheadSlashDiamondWhite { get; set; }

        [JsonProperty("noteheadSlashHorizontalEnds")]
        public GlyphDefinition NoteheadSlashHorizontalEnds { get; set; }

        [JsonProperty("noteheadSlashHorizontalEndsMuted")]
        public GlyphDefinition NoteheadSlashHorizontalEndsMuted { get; set; }

        [JsonProperty("noteheadSlashVerticalEnds")]
        public GlyphDefinition NoteheadSlashVerticalEnds { get; set; }

        [JsonProperty("noteheadSlashVerticalEndsMuted")]
        public GlyphDefinition NoteheadSlashVerticalEndsMuted { get; set; }

        [JsonProperty("noteheadSlashVerticalEndsSmall")]
        public GlyphDefinition NoteheadSlashVerticalEndsSmall { get; set; }

        [JsonProperty("noteheadSlashWhiteHalf")]
        public GlyphDefinition NoteheadSlashWhiteHalf { get; set; }

        [JsonProperty("noteheadSlashWhiteMuted")]
        public GlyphDefinition NoteheadSlashWhiteMuted { get; set; }

        [JsonProperty("noteheadSlashWhiteWhole")]
        public GlyphDefinition NoteheadSlashWhiteWhole { get; set; }

        [JsonProperty("noteheadSlashX")]
        public GlyphDefinition NoteheadSlashX { get; set; }

        [JsonProperty("noteheadSlashedBlack1")]
        public GlyphDefinition NoteheadSlashedBlack1 { get; set; }

        [JsonProperty("noteheadSlashedBlack2")]
        public GlyphDefinition NoteheadSlashedBlack2 { get; set; }

        [JsonProperty("noteheadSlashedDoubleWhole1")]
        public GlyphDefinition NoteheadSlashedDoubleWhole1 { get; set; }

        [JsonProperty("noteheadSlashedDoubleWhole2")]
        public GlyphDefinition NoteheadSlashedDoubleWhole2 { get; set; }

        [JsonProperty("noteheadSlashedHalf1")]
        public GlyphDefinition NoteheadSlashedHalf1 { get; set; }

        [JsonProperty("noteheadSlashedHalf2")]
        public GlyphDefinition NoteheadSlashedHalf2 { get; set; }

        [JsonProperty("noteheadSlashedWhole1")]
        public GlyphDefinition NoteheadSlashedWhole1 { get; set; }

        [JsonProperty("noteheadSlashedWhole2")]
        public GlyphDefinition NoteheadSlashedWhole2 { get; set; }

        [JsonProperty("noteheadSquareBlack")]
        public GlyphDefinition NoteheadSquareBlack { get; set; }

        [JsonProperty("noteheadSquareBlackLarge")]
        public GlyphDefinition NoteheadSquareBlackLarge { get; set; }

        [JsonProperty("noteheadSquareBlackWhite")]
        public GlyphDefinition NoteheadSquareBlackWhite { get; set; }

        [JsonProperty("noteheadSquareWhite")]
        public GlyphDefinition NoteheadSquareWhite { get; set; }

        [JsonProperty("noteheadTriangleDownBlack")]
        public GlyphDefinition NoteheadTriangleDownBlack { get; set; }

        [JsonProperty("noteheadTriangleDownDoubleWhole")]
        public GlyphDefinition NoteheadTriangleDownDoubleWhole { get; set; }

        [JsonProperty("noteheadTriangleDownHalf")]
        public GlyphDefinition NoteheadTriangleDownHalf { get; set; }

        [JsonProperty("noteheadTriangleDownWhite")]
        public GlyphDefinition NoteheadTriangleDownWhite { get; set; }

        [JsonProperty("noteheadTriangleDownWhole")]
        public GlyphDefinition NoteheadTriangleDownWhole { get; set; }

        [JsonProperty("noteheadTriangleLeftBlack")]
        public GlyphDefinition NoteheadTriangleLeftBlack { get; set; }

        [JsonProperty("noteheadTriangleLeftWhite")]
        public GlyphDefinition NoteheadTriangleLeftWhite { get; set; }

        [JsonProperty("noteheadTriangleRightBlack")]
        public GlyphDefinition NoteheadTriangleRightBlack { get; set; }

        [JsonProperty("noteheadTriangleRightWhite")]
        public GlyphDefinition NoteheadTriangleRightWhite { get; set; }

        [JsonProperty("noteheadTriangleRoundDownBlack")]
        public GlyphDefinition NoteheadTriangleRoundDownBlack { get; set; }

        [JsonProperty("noteheadTriangleRoundDownWhite")]
        public GlyphDefinition NoteheadTriangleRoundDownWhite { get; set; }

        [JsonProperty("noteheadTriangleUpBlack")]
        public GlyphDefinition NoteheadTriangleUpBlack { get; set; }

        [JsonProperty("noteheadTriangleUpDoubleWhole")]
        public GlyphDefinition NoteheadTriangleUpDoubleWhole { get; set; }

        [JsonProperty("noteheadTriangleUpHalf")]
        public GlyphDefinition NoteheadTriangleUpHalf { get; set; }

        [JsonProperty("noteheadTriangleUpRightBlack")]
        public GlyphDefinition NoteheadTriangleUpRightBlack { get; set; }

        [JsonProperty("noteheadTriangleUpRightWhite")]
        public GlyphDefinition NoteheadTriangleUpRightWhite { get; set; }

        [JsonProperty("noteheadTriangleUpWhite")]
        public GlyphDefinition NoteheadTriangleUpWhite { get; set; }

        [JsonProperty("noteheadTriangleUpWhole")]
        public GlyphDefinition NoteheadTriangleUpWhole { get; set; }

        [JsonProperty("noteheadVoidWithX")]
        public GlyphDefinition NoteheadVoidWithX { get; set; }

        [JsonProperty("noteheadWhole")]
        public GlyphDefinition NoteheadWhole { get; set; }

        [JsonProperty("noteheadWholeFilled")]
        public GlyphDefinition NoteheadWholeFilled { get; set; }

        [JsonProperty("noteheadWholeWithX")]
        public GlyphDefinition NoteheadWholeWithX { get; set; }

        [JsonProperty("noteheadXBlack")]
        public GlyphDefinition NoteheadXBlack { get; set; }

        [JsonProperty("noteheadXDoubleWhole")]
        public GlyphDefinition NoteheadXDoubleWhole { get; set; }

        [JsonProperty("noteheadXHalf")]
        public GlyphDefinition NoteheadXHalf { get; set; }

        [JsonProperty("noteheadXOrnate")]
        public GlyphDefinition NoteheadXOrnate { get; set; }

        [JsonProperty("noteheadXOrnateEllipse")]
        public GlyphDefinition NoteheadXOrnateEllipse { get; set; }

        [JsonProperty("noteheadXWhole")]
        public GlyphDefinition NoteheadXWhole { get; set; }

        [JsonProperty("octaveBassa")]
        public GlyphDefinition OctaveBassa { get; set; }

        [JsonProperty("octaveLoco")]
        public GlyphDefinition OctaveLoco { get; set; }

        [JsonProperty("octaveParensLeft")]
        public GlyphDefinition OctaveParensLeft { get; set; }

        [JsonProperty("octaveParensRight")]
        public GlyphDefinition OctaveParensRight { get; set; }

        [JsonProperty("ornamentBottomLeftConcaveStroke")]
        public GlyphDefinition OrnamentBottomLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentBottomLeftConcaveStrokeLarge")]
        public GlyphDefinition OrnamentBottomLeftConcaveStrokeLarge { get; set; }

        [JsonProperty("ornamentBottomLeftConvexStroke")]
        public GlyphDefinition OrnamentBottomLeftConvexStroke { get; set; }

        [JsonProperty("ornamentBottomRightConcaveStroke")]
        public GlyphDefinition OrnamentBottomRightConcaveStroke { get; set; }

        [JsonProperty("ornamentBottomRightConvexStroke")]
        public GlyphDefinition OrnamentBottomRightConvexStroke { get; set; }

        [JsonProperty("ornamentComma")]
        public GlyphDefinition OrnamentComma { get; set; }

        [JsonProperty("ornamentDoubleObliqueLinesAfterNote")]
        public GlyphDefinition OrnamentDoubleObliqueLinesAfterNote { get; set; }

        [JsonProperty("ornamentDoubleObliqueLinesBeforeNote")]
        public GlyphDefinition OrnamentDoubleObliqueLinesBeforeNote { get; set; }

        [JsonProperty("ornamentDownCurve")]
        public GlyphDefinition OrnamentDownCurve { get; set; }

        [JsonProperty("ornamentHaydn")]
        public GlyphDefinition OrnamentHaydn { get; set; }

        [JsonProperty("ornamentHighLeftConcaveStroke")]
        public GlyphDefinition OrnamentHighLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentHighLeftConvexStroke")]
        public GlyphDefinition OrnamentHighLeftConvexStroke { get; set; }

        [JsonProperty("ornamentHighRightConcaveStroke")]
        public GlyphDefinition OrnamentHighRightConcaveStroke { get; set; }

        [JsonProperty("ornamentHighRightConvexStroke")]
        public GlyphDefinition OrnamentHighRightConvexStroke { get; set; }

        [JsonProperty("ornamentHookAfterNote")]
        public GlyphDefinition OrnamentHookAfterNote { get; set; }

        [JsonProperty("ornamentHookBeforeNote")]
        public GlyphDefinition OrnamentHookBeforeNote { get; set; }

        [JsonProperty("ornamentLeftFacingHalfCircle")]
        public GlyphDefinition OrnamentLeftFacingHalfCircle { get; set; }

        [JsonProperty("ornamentLeftFacingHook")]
        public GlyphDefinition OrnamentLeftFacingHook { get; set; }

        [JsonProperty("ornamentLeftPlus")]
        public GlyphDefinition OrnamentLeftPlus { get; set; }

        [JsonProperty("ornamentLeftShakeT")]
        public GlyphDefinition OrnamentLeftShakeT { get; set; }

        [JsonProperty("ornamentLeftVerticalStroke")]
        public GlyphDefinition OrnamentLeftVerticalStroke { get; set; }

        [JsonProperty("ornamentLeftVerticalStrokeWithCross")]
        public GlyphDefinition OrnamentLeftVerticalStrokeWithCross { get; set; }

        [JsonProperty("ornamentLowLeftConcaveStroke")]
        public GlyphDefinition OrnamentLowLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentLowLeftConvexStroke")]
        public GlyphDefinition OrnamentLowLeftConvexStroke { get; set; }

        [JsonProperty("ornamentLowRightConcaveStroke")]
        public GlyphDefinition OrnamentLowRightConcaveStroke { get; set; }

        [JsonProperty("ornamentLowRightConvexStroke")]
        public GlyphDefinition OrnamentLowRightConvexStroke { get; set; }

        [JsonProperty("ornamentMiddleVerticalStroke")]
        public GlyphDefinition OrnamentMiddleVerticalStroke { get; set; }

        [JsonProperty("ornamentMordent")]
        public GlyphDefinition OrnamentMordent { get; set; }

        [JsonProperty("ornamentMordentInverted")]
        public GlyphDefinition OrnamentMordentInverted { get; set; }

        [JsonProperty("ornamentObliqueLineAfterNote")]
        public GlyphDefinition OrnamentObliqueLineAfterNote { get; set; }

        [JsonProperty("ornamentObliqueLineBeforeNote")]
        public GlyphDefinition OrnamentObliqueLineBeforeNote { get; set; }

        [JsonProperty("ornamentObliqueLineHorizAfterNote")]
        public GlyphDefinition OrnamentObliqueLineHorizAfterNote { get; set; }

        [JsonProperty("ornamentObliqueLineHorizBeforeNote")]
        public GlyphDefinition OrnamentObliqueLineHorizBeforeNote { get; set; }

        [JsonProperty("ornamentOriscus")]
        public GlyphDefinition OrnamentOriscus { get; set; }

        [JsonProperty("ornamentPinceCouperin")]
        public GlyphDefinition OrnamentPinceCouperin { get; set; }

        [JsonProperty("ornamentPortDeVoixV")]
        public GlyphDefinition OrnamentPortDeVoixV { get; set; }

        [JsonProperty("ornamentPrecompAppoggTrill")]
        public GlyphDefinition OrnamentPrecompAppoggTrill { get; set; }

        [JsonProperty("ornamentPrecompAppoggTrillSuffix")]
        public GlyphDefinition OrnamentPrecompAppoggTrillSuffix { get; set; }

        [JsonProperty("ornamentPrecompCadence")]
        public GlyphDefinition OrnamentPrecompCadence { get; set; }

        [JsonProperty("ornamentPrecompCadenceUpperPrefix ")]
        public GlyphDefinition OrnamentPrecompCadenceUpperPrefix { get; set; }

        [JsonProperty("ornamentPrecompCadenceUpperPrefixTurn")]
        public GlyphDefinition OrnamentPrecompCadenceUpperPrefixTurn { get; set; }

        [JsonProperty("ornamentPrecompCadenceWithTurn ")]
        public GlyphDefinition OrnamentPrecompCadenceWithTurn { get; set; }

        [JsonProperty("ornamentPrecompDescendingSlide")]
        public GlyphDefinition OrnamentPrecompDescendingSlide { get; set; }

        [JsonProperty("ornamentPrecompDoubleCadenceLowerPrefix")]
        public GlyphDefinition OrnamentPrecompDoubleCadenceLowerPrefix { get; set; }

        [JsonProperty("ornamentPrecompDoubleCadenceUpperPrefix ")]
        public GlyphDefinition OrnamentPrecompDoubleCadenceUpperPrefix { get; set; }

        [JsonProperty("ornamentPrecompDoubleCadenceUpperPrefixTurn")]
        public GlyphDefinition OrnamentPrecompDoubleCadenceUpperPrefixTurn { get; set; }

        [JsonProperty("ornamentPrecompInvertedMordentUpperPrefix")]
        public GlyphDefinition OrnamentPrecompInvertedMordentUpperPrefix { get; set; }

        [JsonProperty("ornamentPrecompMordentRelease")]
        public GlyphDefinition OrnamentPrecompMordentRelease { get; set; }

        [JsonProperty("ornamentPrecompMordentUpperPrefix")]
        public GlyphDefinition OrnamentPrecompMordentUpperPrefix { get; set; }

        [JsonProperty("ornamentPrecompPortDeVoixMordent")]
        public GlyphDefinition OrnamentPrecompPortDeVoixMordent { get; set; }

        [JsonProperty("ornamentPrecompSlide")]
        public GlyphDefinition OrnamentPrecompSlide { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillBach")]
        public GlyphDefinition OrnamentPrecompSlideTrillBach { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillDAnglebert")]
        public GlyphDefinition OrnamentPrecompSlideTrillDAnglebert { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillMarpurg")]
        public GlyphDefinition OrnamentPrecompSlideTrillMarpurg { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillMuffat")]
        public GlyphDefinition OrnamentPrecompSlideTrillMuffat { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillSuffixMuffat")]
        public GlyphDefinition OrnamentPrecompSlideTrillSuffixMuffat { get; set; }

        [JsonProperty("ornamentPrecompTrillLowerSuffix")]
        public GlyphDefinition OrnamentPrecompTrillLowerSuffix { get; set; }

        [JsonProperty("ornamentPrecompTrillSuffixDandrieu")]
        public GlyphDefinition OrnamentPrecompTrillSuffixDandrieu { get; set; }

        [JsonProperty("ornamentPrecompTrillWithMordent")]
        public GlyphDefinition OrnamentPrecompTrillWithMordent { get; set; }

        [JsonProperty("ornamentPrecompTurnTrillBach")]
        public GlyphDefinition OrnamentPrecompTurnTrillBach { get; set; }

        [JsonProperty("ornamentPrecompTurnTrillDAnglebert")]
        public GlyphDefinition OrnamentPrecompTurnTrillDAnglebert { get; set; }

        [JsonProperty("ornamentQuilisma")]
        public GlyphDefinition OrnamentQuilisma { get; set; }

        [JsonProperty("ornamentRightFacingHalfCircle")]
        public GlyphDefinition OrnamentRightFacingHalfCircle { get; set; }

        [JsonProperty("ornamentRightFacingHook")]
        public GlyphDefinition OrnamentRightFacingHook { get; set; }

        [JsonProperty("ornamentRightVerticalStroke")]
        public GlyphDefinition OrnamentRightVerticalStroke { get; set; }

        [JsonProperty("ornamentSchleifer")]
        public GlyphDefinition OrnamentSchleifer { get; set; }

        [JsonProperty("ornamentShake3")]
        public GlyphDefinition OrnamentShake3 { get; set; }

        [JsonProperty("ornamentShakeMuffat1")]
        public GlyphDefinition OrnamentShakeMuffat1 { get; set; }

        [JsonProperty("ornamentShortObliqueLineAfterNote")]
        public GlyphDefinition OrnamentShortObliqueLineAfterNote { get; set; }

        [JsonProperty("ornamentShortObliqueLineBeforeNote")]
        public GlyphDefinition OrnamentShortObliqueLineBeforeNote { get; set; }

        [JsonProperty("ornamentTopLeftConcaveStroke")]
        public GlyphDefinition OrnamentTopLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentTopLeftConvexStroke")]
        public GlyphDefinition OrnamentTopLeftConvexStroke { get; set; }

        [JsonProperty("ornamentTopRightConcaveStroke")]
        public GlyphDefinition OrnamentTopRightConcaveStroke { get; set; }

        [JsonProperty("ornamentTopRightConvexStroke")]
        public GlyphDefinition OrnamentTopRightConvexStroke { get; set; }

        [JsonProperty("ornamentTremblement")]
        public GlyphDefinition OrnamentTremblement { get; set; }

        [JsonProperty("ornamentTremblementCouperin")]
        public GlyphDefinition OrnamentTremblementCouperin { get; set; }

        [JsonProperty("ornamentTrill")]
        public GlyphDefinition OrnamentTrill { get; set; }

        [JsonProperty("ornamentTurn")]
        public GlyphDefinition OrnamentTurn { get; set; }

        [JsonProperty("ornamentTurnInverted")]
        public GlyphDefinition OrnamentTurnInverted { get; set; }

        [JsonProperty("ornamentTurnSlash")]
        public GlyphDefinition OrnamentTurnSlash { get; set; }

        [JsonProperty("ornamentTurnUp")]
        public GlyphDefinition OrnamentTurnUp { get; set; }

        [JsonProperty("ornamentTurnUpS")]
        public GlyphDefinition OrnamentTurnUpS { get; set; }

        [JsonProperty("ornamentUpCurve")]
        public GlyphDefinition OrnamentUpCurve { get; set; }

        [JsonProperty("ornamentVerticalLine")]
        public GlyphDefinition OrnamentVerticalLine { get; set; }

        [JsonProperty("ornamentZigZagLineNoRightEnd")]
        public GlyphDefinition OrnamentZigZagLineNoRightEnd { get; set; }

        [JsonProperty("ornamentZigZagLineWithRightEnd")]
        public GlyphDefinition OrnamentZigZagLineWithRightEnd { get; set; }

        [JsonProperty("ottava")]
        public GlyphDefinition Ottava { get; set; }

        [JsonProperty("ottavaAlta")]
        public GlyphDefinition OttavaAlta { get; set; }

        [JsonProperty("ottavaBassa")]
        public GlyphDefinition OttavaBassa { get; set; }

        [JsonProperty("ottavaBassaBa")]
        public GlyphDefinition OttavaBassaBa { get; set; }

        [JsonProperty("ottavaBassaVb")]
        public GlyphDefinition OttavaBassaVb { get; set; }

        [JsonProperty("pendereckiTremolo")]
        public GlyphDefinition PendereckiTremolo { get; set; }

        [JsonProperty("pictAgogo")]
        public GlyphDefinition PictAgogo { get; set; }

        [JsonProperty("pictAlmglocken")]
        public GlyphDefinition PictAlmglocken { get; set; }

        [JsonProperty("pictAnvil")]
        public GlyphDefinition PictAnvil { get; set; }

        [JsonProperty("pictBambooChimes")]
        public GlyphDefinition PictBambooChimes { get; set; }

        [JsonProperty("pictBambooScraper")]
        public GlyphDefinition PictBambooScraper { get; set; }

        [JsonProperty("pictBassDrum")]
        public GlyphDefinition PictBassDrum { get; set; }

        [JsonProperty("pictBassDrumOnSide")]
        public GlyphDefinition PictBassDrumOnSide { get; set; }

        [JsonProperty("pictBeaterBow")]
        public GlyphDefinition PictBeaterBow { get; set; }

        [JsonProperty("pictBeaterBox")]
        public GlyphDefinition PictBeaterBox { get; set; }

        [JsonProperty("pictBeaterBrassMalletsDown")]
        public GlyphDefinition PictBeaterBrassMalletsDown { get; set; }

        [JsonProperty("pictBeaterBrassMalletsUp")]
        public GlyphDefinition PictBeaterBrassMalletsUp { get; set; }

        [JsonProperty("pictBeaterCombiningDashedCircle")]
        public GlyphDefinition PictBeaterCombiningDashedCircle { get; set; }

        [JsonProperty("pictBeaterCombiningParentheses")]
        public GlyphDefinition PictBeaterCombiningParentheses { get; set; }

        [JsonProperty("pictBeaterDoubleBassDrumDown")]
        public GlyphDefinition PictBeaterDoubleBassDrumDown { get; set; }

        [JsonProperty("pictBeaterDoubleBassDrumUp")]
        public GlyphDefinition PictBeaterDoubleBassDrumUp { get; set; }

        [JsonProperty("pictBeaterFinger")]
        public GlyphDefinition PictBeaterFinger { get; set; }

        [JsonProperty("pictBeaterFingernails")]
        public GlyphDefinition PictBeaterFingernails { get; set; }

        [JsonProperty("pictBeaterFist")]
        public GlyphDefinition PictBeaterFist { get; set; }

        [JsonProperty("pictBeaterGuiroScraper")]
        public GlyphDefinition PictBeaterGuiroScraper { get; set; }

        [JsonProperty("pictBeaterHammer")]
        public GlyphDefinition PictBeaterHammer { get; set; }

        [JsonProperty("pictBeaterHammerMetalDown")]
        public GlyphDefinition PictBeaterHammerMetalDown { get; set; }

        [JsonProperty("pictBeaterHammerMetalUp")]
        public GlyphDefinition PictBeaterHammerMetalUp { get; set; }

        [JsonProperty("pictBeaterHammerPlasticDown")]
        public GlyphDefinition PictBeaterHammerPlasticDown { get; set; }

        [JsonProperty("pictBeaterHammerPlasticUp")]
        public GlyphDefinition PictBeaterHammerPlasticUp { get; set; }

        [JsonProperty("pictBeaterHammerWoodDown")]
        public GlyphDefinition PictBeaterHammerWoodDown { get; set; }

        [JsonProperty("pictBeaterHammerWoodUp")]
        public GlyphDefinition PictBeaterHammerWoodUp { get; set; }

        [JsonProperty("pictBeaterHand")]
        public GlyphDefinition PictBeaterHand { get; set; }

        [JsonProperty("pictBeaterHardBassDrumDown")]
        public GlyphDefinition PictBeaterHardBassDrumDown { get; set; }

        [JsonProperty("pictBeaterHardBassDrumUp")]
        public GlyphDefinition PictBeaterHardBassDrumUp { get; set; }

        [JsonProperty("pictBeaterHardGlockenspielDown")]
        public GlyphDefinition PictBeaterHardGlockenspielDown { get; set; }

        [JsonProperty("pictBeaterHardGlockenspielLeft")]
        public GlyphDefinition PictBeaterHardGlockenspielLeft { get; set; }

        [JsonProperty("pictBeaterHardGlockenspielRight")]
        public GlyphDefinition PictBeaterHardGlockenspielRight { get; set; }

        [JsonProperty("pictBeaterHardGlockenspielUp")]
        public GlyphDefinition PictBeaterHardGlockenspielUp { get; set; }

        [JsonProperty("pictBeaterHardTimpaniDown")]
        public GlyphDefinition PictBeaterHardTimpaniDown { get; set; }

        [JsonProperty("pictBeaterHardTimpaniLeft")]
        public GlyphDefinition PictBeaterHardTimpaniLeft { get; set; }

        [JsonProperty("pictBeaterHardTimpaniRight")]
        public GlyphDefinition PictBeaterHardTimpaniRight { get; set; }

        [JsonProperty("pictBeaterHardTimpaniUp")]
        public GlyphDefinition PictBeaterHardTimpaniUp { get; set; }

        [JsonProperty("pictBeaterHardXylophoneDown")]
        public GlyphDefinition PictBeaterHardXylophoneDown { get; set; }

        [JsonProperty("pictBeaterHardXylophoneLeft")]
        public GlyphDefinition PictBeaterHardXylophoneLeft { get; set; }

        [JsonProperty("pictBeaterHardXylophoneRight")]
        public GlyphDefinition PictBeaterHardXylophoneRight { get; set; }

        [JsonProperty("pictBeaterHardXylophoneUp")]
        public GlyphDefinition PictBeaterHardXylophoneUp { get; set; }

        [JsonProperty("pictBeaterHardYarnDown")]
        public GlyphDefinition PictBeaterHardYarnDown { get; set; }

        [JsonProperty("pictBeaterHardYarnLeft")]
        public GlyphDefinition PictBeaterHardYarnLeft { get; set; }

        [JsonProperty("pictBeaterHardYarnRight")]
        public GlyphDefinition PictBeaterHardYarnRight { get; set; }

        [JsonProperty("pictBeaterHardYarnUp")]
        public GlyphDefinition PictBeaterHardYarnUp { get; set; }

        [JsonProperty("pictBeaterJazzSticksDown")]
        public GlyphDefinition PictBeaterJazzSticksDown { get; set; }

        [JsonProperty("pictBeaterJazzSticksUp")]
        public GlyphDefinition PictBeaterJazzSticksUp { get; set; }

        [JsonProperty("pictBeaterKnittingNeedle")]
        public GlyphDefinition PictBeaterKnittingNeedle { get; set; }

        [JsonProperty("pictBeaterMallet")]
        public GlyphDefinition PictBeaterMallet { get; set; }

        [JsonProperty("pictBeaterMediumBassDrumDown")]
        public GlyphDefinition PictBeaterMediumBassDrumDown { get; set; }

        [JsonProperty("pictBeaterMediumBassDrumUp")]
        public GlyphDefinition PictBeaterMediumBassDrumUp { get; set; }

        [JsonProperty("pictBeaterMediumTimpaniDown")]
        public GlyphDefinition PictBeaterMediumTimpaniDown { get; set; }

        [JsonProperty("pictBeaterMediumTimpaniLeft")]
        public GlyphDefinition PictBeaterMediumTimpaniLeft { get; set; }

        [JsonProperty("pictBeaterMediumTimpaniRight")]
        public GlyphDefinition PictBeaterMediumTimpaniRight { get; set; }

        [JsonProperty("pictBeaterMediumTimpaniUp")]
        public GlyphDefinition PictBeaterMediumTimpaniUp { get; set; }

        [JsonProperty("pictBeaterMediumXylophoneDown")]
        public GlyphDefinition PictBeaterMediumXylophoneDown { get; set; }

        [JsonProperty("pictBeaterMediumXylophoneLeft")]
        public GlyphDefinition PictBeaterMediumXylophoneLeft { get; set; }

        [JsonProperty("pictBeaterMediumXylophoneRight")]
        public GlyphDefinition PictBeaterMediumXylophoneRight { get; set; }

        [JsonProperty("pictBeaterMediumXylophoneUp")]
        public GlyphDefinition PictBeaterMediumXylophoneUp { get; set; }

        [JsonProperty("pictBeaterMediumYarnDown")]
        public GlyphDefinition PictBeaterMediumYarnDown { get; set; }

        [JsonProperty("pictBeaterMediumYarnLeft")]
        public GlyphDefinition PictBeaterMediumYarnLeft { get; set; }

        [JsonProperty("pictBeaterMediumYarnRight")]
        public GlyphDefinition PictBeaterMediumYarnRight { get; set; }

        [JsonProperty("pictBeaterMediumYarnUp")]
        public GlyphDefinition PictBeaterMediumYarnUp { get; set; }

        [JsonProperty("pictBeaterMetalBassDrumDown")]
        public GlyphDefinition PictBeaterMetalBassDrumDown { get; set; }

        [JsonProperty("pictBeaterMetalBassDrumUp")]
        public GlyphDefinition PictBeaterMetalBassDrumUp { get; set; }

        [JsonProperty("pictBeaterMetalDown")]
        public GlyphDefinition PictBeaterMetalDown { get; set; }

        [JsonProperty("pictBeaterMetalHammer")]
        public GlyphDefinition PictBeaterMetalHammer { get; set; }

        [JsonProperty("pictBeaterMetalLeft")]
        public GlyphDefinition PictBeaterMetalLeft { get; set; }

        [JsonProperty("pictBeaterMetalRight")]
        public GlyphDefinition PictBeaterMetalRight { get; set; }

        [JsonProperty("pictBeaterMetalUp")]
        public GlyphDefinition PictBeaterMetalUp { get; set; }

        [JsonProperty("pictBeaterSnareSticksDown")]
        public GlyphDefinition PictBeaterSnareSticksDown { get; set; }

        [JsonProperty("pictBeaterSnareSticksUp")]
        public GlyphDefinition PictBeaterSnareSticksUp { get; set; }

        [JsonProperty("pictBeaterSoftBassDrumDown")]
        public GlyphDefinition PictBeaterSoftBassDrumDown { get; set; }

        [JsonProperty("pictBeaterSoftBassDrumUp")]
        public GlyphDefinition PictBeaterSoftBassDrumUp { get; set; }

        [JsonProperty("pictBeaterSoftGlockenspielDown")]
        public GlyphDefinition PictBeaterSoftGlockenspielDown { get; set; }

        [JsonProperty("pictBeaterSoftGlockenspielLeft")]
        public GlyphDefinition PictBeaterSoftGlockenspielLeft { get; set; }

        [JsonProperty("pictBeaterSoftGlockenspielRight")]
        public GlyphDefinition PictBeaterSoftGlockenspielRight { get; set; }

        [JsonProperty("pictBeaterSoftGlockenspielUp")]
        public GlyphDefinition PictBeaterSoftGlockenspielUp { get; set; }

        [JsonProperty("pictBeaterSoftTimpaniDown")]
        public GlyphDefinition PictBeaterSoftTimpaniDown { get; set; }

        [JsonProperty("pictBeaterSoftTimpaniLeft")]
        public GlyphDefinition PictBeaterSoftTimpaniLeft { get; set; }

        [JsonProperty("pictBeaterSoftTimpaniRight")]
        public GlyphDefinition PictBeaterSoftTimpaniRight { get; set; }

        [JsonProperty("pictBeaterSoftTimpaniUp")]
        public GlyphDefinition PictBeaterSoftTimpaniUp { get; set; }

        [JsonProperty("pictBeaterSoftXylophone")]
        public GlyphDefinition PictBeaterSoftXylophone { get; set; }

        [JsonProperty("pictBeaterSoftXylophoneDown")]
        public GlyphDefinition PictBeaterSoftXylophoneDown { get; set; }

        [JsonProperty("pictBeaterSoftXylophoneLeft")]
        public GlyphDefinition PictBeaterSoftXylophoneLeft { get; set; }

        [JsonProperty("pictBeaterSoftXylophoneRight")]
        public GlyphDefinition PictBeaterSoftXylophoneRight { get; set; }

        [JsonProperty("pictBeaterSoftXylophoneUp")]
        public GlyphDefinition PictBeaterSoftXylophoneUp { get; set; }

        [JsonProperty("pictBeaterSoftYarnDown")]
        public GlyphDefinition PictBeaterSoftYarnDown { get; set; }

        [JsonProperty("pictBeaterSoftYarnLeft")]
        public GlyphDefinition PictBeaterSoftYarnLeft { get; set; }

        [JsonProperty("pictBeaterSoftYarnRight")]
        public GlyphDefinition PictBeaterSoftYarnRight { get; set; }

        [JsonProperty("pictBeaterSoftYarnUp")]
        public GlyphDefinition PictBeaterSoftYarnUp { get; set; }

        [JsonProperty("pictBeaterSpoonWoodenMallet")]
        public GlyphDefinition PictBeaterSpoonWoodenMallet { get; set; }

        [JsonProperty("pictBeaterSuperballDown")]
        public GlyphDefinition PictBeaterSuperballDown { get; set; }

        [JsonProperty("pictBeaterSuperballLeft")]
        public GlyphDefinition PictBeaterSuperballLeft { get; set; }

        [JsonProperty("pictBeaterSuperballRight")]
        public GlyphDefinition PictBeaterSuperballRight { get; set; }

        [JsonProperty("pictBeaterSuperballUp")]
        public GlyphDefinition PictBeaterSuperballUp { get; set; }

        [JsonProperty("pictBeaterTriangleDown")]
        public GlyphDefinition PictBeaterTriangleDown { get; set; }

        [JsonProperty("pictBeaterTriangleUp")]
        public GlyphDefinition PictBeaterTriangleUp { get; set; }

        [JsonProperty("pictBeaterWireBrushesDown")]
        public GlyphDefinition PictBeaterWireBrushesDown { get; set; }

        [JsonProperty("pictBeaterWireBrushesUp")]
        public GlyphDefinition PictBeaterWireBrushesUp { get; set; }

        [JsonProperty("pictBeaterWoodTimpaniDown")]
        public GlyphDefinition PictBeaterWoodTimpaniDown { get; set; }

        [JsonProperty("pictBeaterWoodTimpaniLeft")]
        public GlyphDefinition PictBeaterWoodTimpaniLeft { get; set; }

        [JsonProperty("pictBeaterWoodTimpaniRight")]
        public GlyphDefinition PictBeaterWoodTimpaniRight { get; set; }

        [JsonProperty("pictBeaterWoodTimpaniUp")]
        public GlyphDefinition PictBeaterWoodTimpaniUp { get; set; }

        [JsonProperty("pictBeaterWoodXylophoneDown")]
        public GlyphDefinition PictBeaterWoodXylophoneDown { get; set; }

        [JsonProperty("pictBeaterWoodXylophoneLeft")]
        public GlyphDefinition PictBeaterWoodXylophoneLeft { get; set; }

        [JsonProperty("pictBeaterWoodXylophoneRight")]
        public GlyphDefinition PictBeaterWoodXylophoneRight { get; set; }

        [JsonProperty("pictBeaterWoodXylophoneUp")]
        public GlyphDefinition PictBeaterWoodXylophoneUp { get; set; }

        [JsonProperty("pictBell")]
        public GlyphDefinition PictBell { get; set; }

        [JsonProperty("pictBellOfCymbal")]
        public GlyphDefinition PictBellOfCymbal { get; set; }

        [JsonProperty("pictBellPlate")]
        public GlyphDefinition PictBellPlate { get; set; }

        [JsonProperty("pictBellTree")]
        public GlyphDefinition PictBellTree { get; set; }

        [JsonProperty("pictBirdWhistle")]
        public GlyphDefinition PictBirdWhistle { get; set; }

        [JsonProperty("pictBoardClapper")]
        public GlyphDefinition PictBoardClapper { get; set; }

        [JsonProperty("pictBongos")]
        public GlyphDefinition PictBongos { get; set; }

        [JsonProperty("pictBrakeDrum")]
        public GlyphDefinition PictBrakeDrum { get; set; }

        [JsonProperty("pictCabasa")]
        public GlyphDefinition PictCabasa { get; set; }

        [JsonProperty("pictCannon")]
        public GlyphDefinition PictCannon { get; set; }

        [JsonProperty("pictCarHorn")]
        public GlyphDefinition PictCarHorn { get; set; }

        [JsonProperty("pictCastanets")]
        public GlyphDefinition PictCastanets { get; set; }

        [JsonProperty("pictCastanetsWithHandle")]
        public GlyphDefinition PictCastanetsWithHandle { get; set; }

        [JsonProperty("pictCelesta")]
        public GlyphDefinition PictCelesta { get; set; }

        [JsonProperty("pictCencerro")]
        public GlyphDefinition PictCencerro { get; set; }

        [JsonProperty("pictCenter1")]
        public GlyphDefinition PictCenter1 { get; set; }

        [JsonProperty("pictCenter2")]
        public GlyphDefinition PictCenter2 { get; set; }

        [JsonProperty("pictCenter3")]
        public GlyphDefinition PictCenter3 { get; set; }

        [JsonProperty("pictChainRattle")]
        public GlyphDefinition PictChainRattle { get; set; }

        [JsonProperty("pictChimes")]
        public GlyphDefinition PictChimes { get; set; }

        [JsonProperty("pictChineseCymbal")]
        public GlyphDefinition PictChineseCymbal { get; set; }

        [JsonProperty("pictChokeCymbal")]
        public GlyphDefinition PictChokeCymbal { get; set; }

        [JsonProperty("pictClaves")]
        public GlyphDefinition PictClaves { get; set; }

        [JsonProperty("pictCoins")]
        public GlyphDefinition PictCoins { get; set; }

        [JsonProperty("pictConga")]
        public GlyphDefinition PictConga { get; set; }

        [JsonProperty("pictCowBell")]
        public GlyphDefinition PictCowBell { get; set; }

        [JsonProperty("pictCrashCymbals")]
        public GlyphDefinition PictCrashCymbals { get; set; }

        [JsonProperty("pictCrotales")]
        public GlyphDefinition PictCrotales { get; set; }

        [JsonProperty("pictCrushStem")]
        public GlyphDefinition PictCrushStem { get; set; }

        [JsonProperty("pictCuica")]
        public GlyphDefinition PictCuica { get; set; }

        [JsonProperty("pictCymbalTongs")]
        public GlyphDefinition PictCymbalTongs { get; set; }

        [JsonProperty("pictDamp1")]
        public GlyphDefinition PictDamp1 { get; set; }

        [JsonProperty("pictDamp2")]
        public GlyphDefinition PictDamp2 { get; set; }

        [JsonProperty("pictDamp3")]
        public GlyphDefinition PictDamp3 { get; set; }

        [JsonProperty("pictDamp4")]
        public GlyphDefinition PictDamp4 { get; set; }

        [JsonProperty("pictDeadNoteStem")]
        public GlyphDefinition PictDeadNoteStem { get; set; }

        [JsonProperty("pictDrumStick")]
        public GlyphDefinition PictDrumStick { get; set; }

        [JsonProperty("pictDuckCall")]
        public GlyphDefinition PictDuckCall { get; set; }

        [JsonProperty("pictEdgeOfCymbal")]
        public GlyphDefinition PictEdgeOfCymbal { get; set; }

        [JsonProperty("pictEmptyTrap")]
        public GlyphDefinition PictEmptyTrap { get; set; }

        [JsonProperty("pictFingerCymbals")]
        public GlyphDefinition PictFingerCymbals { get; set; }

        [JsonProperty("pictFlexatone")]
        public GlyphDefinition PictFlexatone { get; set; }

        [JsonProperty("pictFootballRatchet")]
        public GlyphDefinition PictFootballRatchet { get; set; }

        [JsonProperty("pictGlassHarmonica")]
        public GlyphDefinition PictGlassHarmonica { get; set; }

        [JsonProperty("pictGlassHarp")]
        public GlyphDefinition PictGlassHarp { get; set; }

        [JsonProperty("pictGlassPlateChimes")]
        public GlyphDefinition PictGlassPlateChimes { get; set; }

        [JsonProperty("pictGlassTubeChimes")]
        public GlyphDefinition PictGlassTubeChimes { get; set; }

        [JsonProperty("pictGlsp")]
        public GlyphDefinition PictGlsp { get; set; }

        [JsonProperty("pictGlspSmithBrindle")]
        public GlyphDefinition PictGlspSmithBrindle { get; set; }

        [JsonProperty("pictGobletDrum")]
        public GlyphDefinition PictGobletDrum { get; set; }

        [JsonProperty("pictGong")]
        public GlyphDefinition PictGong { get; set; }

        [JsonProperty("pictGongWithButton")]
        public GlyphDefinition PictGongWithButton { get; set; }

        [JsonProperty("pictGuiro")]
        public GlyphDefinition PictGuiro { get; set; }

        [JsonProperty("pictGumHardDown")]
        public GlyphDefinition PictGumHardDown { get; set; }

        [JsonProperty("pictGumHardLeft")]
        public GlyphDefinition PictGumHardLeft { get; set; }

        [JsonProperty("pictGumHardRight")]
        public GlyphDefinition PictGumHardRight { get; set; }

        [JsonProperty("pictGumHardUp")]
        public GlyphDefinition PictGumHardUp { get; set; }

        [JsonProperty("pictGumMediumDown")]
        public GlyphDefinition PictGumMediumDown { get; set; }

        [JsonProperty("pictGumMediumLeft")]
        public GlyphDefinition PictGumMediumLeft { get; set; }

        [JsonProperty("pictGumMediumRight")]
        public GlyphDefinition PictGumMediumRight { get; set; }

        [JsonProperty("pictGumMediumUp")]
        public GlyphDefinition PictGumMediumUp { get; set; }

        [JsonProperty("pictGumSoftDown")]
        public GlyphDefinition PictGumSoftDown { get; set; }

        [JsonProperty("pictGumSoftLeft")]
        public GlyphDefinition PictGumSoftLeft { get; set; }

        [JsonProperty("pictGumSoftRight")]
        public GlyphDefinition PictGumSoftRight { get; set; }

        [JsonProperty("pictGumSoftUp")]
        public GlyphDefinition PictGumSoftUp { get; set; }

        [JsonProperty("pictHalfOpen1")]
        public GlyphDefinition PictHalfOpen1 { get; set; }

        [JsonProperty("pictHalfOpen2")]
        public GlyphDefinition PictHalfOpen2 { get; set; }

        [JsonProperty("pictHandbell")]
        public GlyphDefinition PictHandbell { get; set; }

        [JsonProperty("pictHiHat")]
        public GlyphDefinition PictHiHat { get; set; }

        [JsonProperty("pictHiHatOnStand")]
        public GlyphDefinition PictHiHatOnStand { get; set; }

        [JsonProperty("pictJawHarp")]
        public GlyphDefinition PictJawHarp { get; set; }

        [JsonProperty("pictJingleBells")]
        public GlyphDefinition PictJingleBells { get; set; }

        [JsonProperty("pictKlaxonHorn")]
        public GlyphDefinition PictKlaxonHorn { get; set; }

        [JsonProperty("pictLeftHandCircle")]
        public GlyphDefinition PictLeftHandCircle { get; set; }

        [JsonProperty("pictLionsRoar")]
        public GlyphDefinition PictLionsRoar { get; set; }

        [JsonProperty("pictLithophone")]
        public GlyphDefinition PictLithophone { get; set; }

        [JsonProperty("pictLogDrum")]
        public GlyphDefinition PictLogDrum { get; set; }

        [JsonProperty("pictLotusFlute")]
        public GlyphDefinition PictLotusFlute { get; set; }

        [JsonProperty("pictMar")]
        public GlyphDefinition PictMar { get; set; }

        [JsonProperty("pictMarSmithBrindle")]
        public GlyphDefinition PictMarSmithBrindle { get; set; }

        [JsonProperty("pictMaraca")]
        public GlyphDefinition PictMaraca { get; set; }

        [JsonProperty("pictMaracas")]
        public GlyphDefinition PictMaracas { get; set; }

        [JsonProperty("pictMegaphone")]
        public GlyphDefinition PictMegaphone { get; set; }

        [JsonProperty("pictMetalPlateChimes")]
        public GlyphDefinition PictMetalPlateChimes { get; set; }

        [JsonProperty("pictMetalTubeChimes")]
        public GlyphDefinition PictMetalTubeChimes { get; set; }

        [JsonProperty("pictMusicalSaw")]
        public GlyphDefinition PictMusicalSaw { get; set; }

        [JsonProperty("pictNormalPosition")]
        public GlyphDefinition PictNormalPosition { get; set; }

        [JsonProperty("pictOnRim")]
        public GlyphDefinition PictOnRim { get; set; }

        [JsonProperty("pictOpen")]
        public GlyphDefinition PictOpen { get; set; }

        [JsonProperty("pictOpenRimShot")]
        public GlyphDefinition PictOpenRimShot { get; set; }

        [JsonProperty("pictPistolShot")]
        public GlyphDefinition PictPistolShot { get; set; }

        [JsonProperty("pictPoliceWhistle")]
        public GlyphDefinition PictPoliceWhistle { get; set; }

        [JsonProperty("pictQuijada")]
        public GlyphDefinition PictQuijada { get; set; }

        [JsonProperty("pictRainstick")]
        public GlyphDefinition PictRainstick { get; set; }

        [JsonProperty("pictRatchet")]
        public GlyphDefinition PictRatchet { get; set; }

        [JsonProperty("pictRecoReco")]
        public GlyphDefinition PictRecoReco { get; set; }

        [JsonProperty("pictRightHandSquare")]
        public GlyphDefinition PictRightHandSquare { get; set; }

        [JsonProperty("pictRim1")]
        public GlyphDefinition PictRim1 { get; set; }

        [JsonProperty("pictRim2")]
        public GlyphDefinition PictRim2 { get; set; }

        [JsonProperty("pictRim3")]
        public GlyphDefinition PictRim3 { get; set; }

        [JsonProperty("pictRimShotOnStem")]
        public GlyphDefinition PictRimShotOnStem { get; set; }

        [JsonProperty("pictSandpaperBlocks")]
        public GlyphDefinition PictSandpaperBlocks { get; set; }

        [JsonProperty("pictScrapeAroundRim")]
        public GlyphDefinition PictScrapeAroundRim { get; set; }

        [JsonProperty("pictScrapeCenterToEdge")]
        public GlyphDefinition PictScrapeCenterToEdge { get; set; }

        [JsonProperty("pictScrapeEdgeToCenter")]
        public GlyphDefinition PictScrapeEdgeToCenter { get; set; }

        [JsonProperty("pictShellBells")]
        public GlyphDefinition PictShellBells { get; set; }

        [JsonProperty("pictShellChimes")]
        public GlyphDefinition PictShellChimes { get; set; }

        [JsonProperty("pictSiren")]
        public GlyphDefinition PictSiren { get; set; }

        [JsonProperty("pictSistrum")]
        public GlyphDefinition PictSistrum { get; set; }

        [JsonProperty("pictSizzleCymbal")]
        public GlyphDefinition PictSizzleCymbal { get; set; }

        [JsonProperty("pictSleighBell")]
        public GlyphDefinition PictSleighBell { get; set; }

        [JsonProperty("pictSlideBrushOnGong")]
        public GlyphDefinition PictSlideBrushOnGong { get; set; }

        [JsonProperty("pictSlideWhistle")]
        public GlyphDefinition PictSlideWhistle { get; set; }

        [JsonProperty("pictSlitDrum")]
        public GlyphDefinition PictSlitDrum { get; set; }

        [JsonProperty("pictSnareDrum")]
        public GlyphDefinition PictSnareDrum { get; set; }

        [JsonProperty("pictSnareDrumMilitary")]
        public GlyphDefinition PictSnareDrumMilitary { get; set; }

        [JsonProperty("pictSnareDrumSnaresOff")]
        public GlyphDefinition PictSnareDrumSnaresOff { get; set; }

        [JsonProperty("pictSteelDrums")]
        public GlyphDefinition PictSteelDrums { get; set; }

        [JsonProperty("pictStickShot")]
        public GlyphDefinition PictStickShot { get; set; }

        [JsonProperty("pictSuperball")]
        public GlyphDefinition PictSuperball { get; set; }

        [JsonProperty("pictSuspendedCymbal")]
        public GlyphDefinition PictSuspendedCymbal { get; set; }

        [JsonProperty("pictSwishStem")]
        public GlyphDefinition PictSwishStem { get; set; }

        [JsonProperty("pictTabla")]
        public GlyphDefinition PictTabla { get; set; }

        [JsonProperty("pictTamTam")]
        public GlyphDefinition PictTamTam { get; set; }

        [JsonProperty("pictTamTamWithBeater")]
        public GlyphDefinition PictTamTamWithBeater { get; set; }

        [JsonProperty("pictTambourine")]
        public GlyphDefinition PictTambourine { get; set; }

        [JsonProperty("pictTempleBlocks")]
        public GlyphDefinition PictTempleBlocks { get; set; }

        [JsonProperty("pictTenorDrum")]
        public GlyphDefinition PictTenorDrum { get; set; }

        [JsonProperty("pictThundersheet")]
        public GlyphDefinition PictThundersheet { get; set; }

        [JsonProperty("pictTimbales")]
        public GlyphDefinition PictTimbales { get; set; }

        [JsonProperty("pictTimpani")]
        public GlyphDefinition PictTimpani { get; set; }

        [JsonProperty("pictTomTom")]
        public GlyphDefinition PictTomTom { get; set; }

        [JsonProperty("pictTomTomChinese")]
        public GlyphDefinition PictTomTomChinese { get; set; }

        [JsonProperty("pictTomTomIndoAmerican")]
        public GlyphDefinition PictTomTomIndoAmerican { get; set; }

        [JsonProperty("pictTomTomJapanese")]
        public GlyphDefinition PictTomTomJapanese { get; set; }

        [JsonProperty("pictTriangle")]
        public GlyphDefinition PictTriangle { get; set; }

        [JsonProperty("pictTubaphone")]
        public GlyphDefinition PictTubaphone { get; set; }

        [JsonProperty("pictTubularBells")]
        public GlyphDefinition PictTubularBells { get; set; }

        [JsonProperty("pictTurnLeftStem")]
        public GlyphDefinition PictTurnLeftStem { get; set; }

        [JsonProperty("pictTurnRightLeftStem")]
        public GlyphDefinition PictTurnRightLeftStem { get; set; }

        [JsonProperty("pictTurnRightStem")]
        public GlyphDefinition PictTurnRightStem { get; set; }

        [JsonProperty("pictVib")]
        public GlyphDefinition PictVib { get; set; }

        [JsonProperty("pictVibMotorOff")]
        public GlyphDefinition PictVibMotorOff { get; set; }

        [JsonProperty("pictVibSmithBrindle")]
        public GlyphDefinition PictVibSmithBrindle { get; set; }

        [JsonProperty("pictVibraslap")]
        public GlyphDefinition PictVibraslap { get; set; }

        [JsonProperty("pictVietnameseHat")]
        public GlyphDefinition PictVietnameseHat { get; set; }

        [JsonProperty("pictWhip")]
        public GlyphDefinition PictWhip { get; set; }

        [JsonProperty("pictWindChimesGlass")]
        public GlyphDefinition PictWindChimesGlass { get; set; }

        [JsonProperty("pictWindMachine")]
        public GlyphDefinition PictWindMachine { get; set; }

        [JsonProperty("pictWindWhistle")]
        public GlyphDefinition PictWindWhistle { get; set; }

        [JsonProperty("pictWoodBlock")]
        public GlyphDefinition PictWoodBlock { get; set; }

        [JsonProperty("pictWoundHardDown")]
        public GlyphDefinition PictWoundHardDown { get; set; }

        [JsonProperty("pictWoundHardLeft")]
        public GlyphDefinition PictWoundHardLeft { get; set; }

        [JsonProperty("pictWoundHardRight")]
        public GlyphDefinition PictWoundHardRight { get; set; }

        [JsonProperty("pictWoundHardUp")]
        public GlyphDefinition PictWoundHardUp { get; set; }

        [JsonProperty("pictWoundSoftDown")]
        public GlyphDefinition PictWoundSoftDown { get; set; }

        [JsonProperty("pictWoundSoftLeft")]
        public GlyphDefinition PictWoundSoftLeft { get; set; }

        [JsonProperty("pictWoundSoftRight")]
        public GlyphDefinition PictWoundSoftRight { get; set; }

        [JsonProperty("pictWoundSoftUp")]
        public GlyphDefinition PictWoundSoftUp { get; set; }

        [JsonProperty("pictXyl")]
        public GlyphDefinition PictXyl { get; set; }

        [JsonProperty("pictXylBass")]
        public GlyphDefinition PictXylBass { get; set; }

        [JsonProperty("pictXylSmithBrindle")]
        public GlyphDefinition PictXylSmithBrindle { get; set; }

        [JsonProperty("pictXylTenor")]
        public GlyphDefinition PictXylTenor { get; set; }

        [JsonProperty("pictXylTenorTrough")]
        public GlyphDefinition PictXylTenorTrough { get; set; }

        [JsonProperty("pictXylTrough")]
        public GlyphDefinition PictXylTrough { get; set; }

        [JsonProperty("pluckedBuzzPizzicato")]
        public GlyphDefinition PluckedBuzzPizzicato { get; set; }

        [JsonProperty("pluckedDamp")]
        public GlyphDefinition PluckedDamp { get; set; }

        [JsonProperty("pluckedDampAll")]
        public GlyphDefinition PluckedDampAll { get; set; }

        [JsonProperty("pluckedDampOnStem")]
        public GlyphDefinition PluckedDampOnStem { get; set; }

        [JsonProperty("pluckedFingernailFlick")]
        public GlyphDefinition PluckedFingernailFlick { get; set; }

        [JsonProperty("pluckedLeftHandPizzicato")]
        public GlyphDefinition PluckedLeftHandPizzicato { get; set; }

        [JsonProperty("pluckedPlectrum")]
        public GlyphDefinition PluckedPlectrum { get; set; }

        [JsonProperty("pluckedSnapPizzicatoAbove")]
        public GlyphDefinition PluckedSnapPizzicatoAbove { get; set; }

        [JsonProperty("pluckedSnapPizzicatoBelow")]
        public GlyphDefinition PluckedSnapPizzicatoBelow { get; set; }

        [JsonProperty("pluckedWithFingernails")]
        public GlyphDefinition PluckedWithFingernails { get; set; }

        [JsonProperty("quindicesima")]
        public GlyphDefinition Quindicesima { get; set; }

        [JsonProperty("quindicesimaAlta")]
        public GlyphDefinition QuindicesimaAlta { get; set; }

        [JsonProperty("quindicesimaBassa")]
        public GlyphDefinition QuindicesimaBassa { get; set; }

        [JsonProperty("quindicesimaBassaMb")]
        public GlyphDefinition QuindicesimaBassaMb { get; set; }

        [JsonProperty("repeat1Bar")]
        public GlyphDefinition Repeat1Bar { get; set; }

        [JsonProperty("repeat2Bars")]
        public GlyphDefinition Repeat2Bars { get; set; }

        [JsonProperty("repeat4Bars")]
        public GlyphDefinition Repeat4Bars { get; set; }

        [JsonProperty("repeatDot")]
        public GlyphDefinition RepeatDot { get; set; }

        [JsonProperty("repeatDots")]
        public GlyphDefinition RepeatDots { get; set; }

        [JsonProperty("repeatLeft")]
        public GlyphDefinition RepeatLeft { get; set; }

        [JsonProperty("repeatRight")]
        public GlyphDefinition RepeatRight { get; set; }

        [JsonProperty("repeatRightLeft")]
        public GlyphDefinition RepeatRightLeft { get; set; }

        [JsonProperty("rest1024th")]
        public GlyphDefinition Rest1024Th { get; set; }

        [JsonProperty("rest128th")]
        public GlyphDefinition Rest128Th { get; set; }

        [JsonProperty("rest16th")]
        public GlyphDefinition Rest16Th { get; set; }

        [JsonProperty("rest256th")]
        public GlyphDefinition Rest256Th { get; set; }

        [JsonProperty("rest32nd")]
        public GlyphDefinition Rest32Nd { get; set; }

        [JsonProperty("rest512th")]
        public GlyphDefinition Rest512Th { get; set; }

        [JsonProperty("rest64th")]
        public GlyphDefinition Rest64Th { get; set; }

        [JsonProperty("rest8th")]
        public GlyphDefinition Rest8Th { get; set; }

        [JsonProperty("restDoubleWhole")]
        public GlyphDefinition RestDoubleWhole { get; set; }

        [JsonProperty("restDoubleWholeLegerLine")]
        public GlyphDefinition RestDoubleWholeLegerLine { get; set; }

        [JsonProperty("restHBar")]
        public GlyphDefinition RestHBar { get; set; }

        [JsonProperty("restHBarLeft")]
        public GlyphDefinition RestHBarLeft { get; set; }

        [JsonProperty("restHBarMiddle")]
        public GlyphDefinition RestHBarMiddle { get; set; }

        [JsonProperty("restHBarRight")]
        public GlyphDefinition RestHBarRight { get; set; }

        [JsonProperty("restHalf")]
        public GlyphDefinition RestHalf { get; set; }

        [JsonProperty("restHalfLegerLine")]
        public GlyphDefinition RestHalfLegerLine { get; set; }

        [JsonProperty("restLonga")]
        public GlyphDefinition RestLonga { get; set; }

        [JsonProperty("restMaxima")]
        public GlyphDefinition RestMaxima { get; set; }

        [JsonProperty("restQuarter")]
        public GlyphDefinition RestQuarter { get; set; }

        [JsonProperty("restQuarterOld")]
        public GlyphDefinition RestQuarterOld { get; set; }

        [JsonProperty("restWhole")]
        public GlyphDefinition RestWhole { get; set; }

        [JsonProperty("restWholeLegerLine")]
        public GlyphDefinition RestWholeLegerLine { get; set; }

        [JsonProperty("reversedBrace")]
        public GlyphDefinition ReversedBrace { get; set; }

        [JsonProperty("reversedBracketBottom")]
        public GlyphDefinition ReversedBracketBottom { get; set; }

        [JsonProperty("reversedBracketTop")]
        public GlyphDefinition ReversedBracketTop { get; set; }

        [JsonProperty("rightRepeatSmall")]
        public GlyphDefinition RightRepeatSmall { get; set; }

        [JsonProperty("segno")]
        public GlyphDefinition Segno { get; set; }

        [JsonProperty("segnoSerpent1")]
        public GlyphDefinition SegnoSerpent1 { get; set; }

        [JsonProperty("segnoSerpent2")]
        public GlyphDefinition SegnoSerpent2 { get; set; }

        [JsonProperty("semipitchedPercussionClef1")]
        public GlyphDefinition SemipitchedPercussionClef1 { get; set; }

        [JsonProperty("semipitchedPercussionClef2")]
        public GlyphDefinition SemipitchedPercussionClef2 { get; set; }

        [JsonProperty("smnFlat")]
        public GlyphDefinition SmnFlat { get; set; }

        [JsonProperty("smnFlatWhite")]
        public GlyphDefinition SmnFlatWhite { get; set; }

        [JsonProperty("smnHistoryDoubleFlat")]
        public GlyphDefinition SmnHistoryDoubleFlat { get; set; }

        [JsonProperty("smnHistoryDoubleSharp")]
        public GlyphDefinition SmnHistoryDoubleSharp { get; set; }

        [JsonProperty("smnHistoryFlat")]
        public GlyphDefinition SmnHistoryFlat { get; set; }

        [JsonProperty("smnHistorySharp")]
        public GlyphDefinition SmnHistorySharp { get; set; }

        [JsonProperty("smnNatural")]
        public GlyphDefinition SmnNatural { get; set; }

        [JsonProperty("smnSharp")]
        public GlyphDefinition SmnSharp { get; set; }

        [JsonProperty("smnSharpDown")]
        public GlyphDefinition SmnSharpDown { get; set; }

        [JsonProperty("smnSharpWhite")]
        public GlyphDefinition SmnSharpWhite { get; set; }

        [JsonProperty("smnSharpWhiteDown")]
        public GlyphDefinition SmnSharpWhiteDown { get; set; }

        [JsonProperty("splitBarDivider")]
        public GlyphDefinition SplitBarDivider { get; set; }

        [JsonProperty("staff1Line")]
        public GlyphDefinition Staff1Line { get; set; }

        [JsonProperty("staff1LineNarrow")]
        public GlyphDefinition Staff1LineNarrow { get; set; }

        [JsonProperty("staff1LineWide")]
        public GlyphDefinition Staff1LineWide { get; set; }

        [JsonProperty("staff2Lines")]
        public GlyphDefinition Staff2Lines { get; set; }

        [JsonProperty("staff2LinesNarrow")]
        public GlyphDefinition Staff2LinesNarrow { get; set; }

        [JsonProperty("staff2LinesWide")]
        public GlyphDefinition Staff2LinesWide { get; set; }

        [JsonProperty("staff3Lines")]
        public GlyphDefinition Staff3Lines { get; set; }

        [JsonProperty("staff3LinesNarrow")]
        public GlyphDefinition Staff3LinesNarrow { get; set; }

        [JsonProperty("staff3LinesWide")]
        public GlyphDefinition Staff3LinesWide { get; set; }

        [JsonProperty("staff4Lines")]
        public GlyphDefinition Staff4Lines { get; set; }

        [JsonProperty("staff4LinesNarrow")]
        public GlyphDefinition Staff4LinesNarrow { get; set; }

        [JsonProperty("staff4LinesWide")]
        public GlyphDefinition Staff4LinesWide { get; set; }

        [JsonProperty("staff5Lines")]
        public GlyphDefinition Staff5Lines { get; set; }

        [JsonProperty("staff5LinesNarrow")]
        public GlyphDefinition Staff5LinesNarrow { get; set; }

        [JsonProperty("staff5LinesWide")]
        public GlyphDefinition Staff5LinesWide { get; set; }

        [JsonProperty("staff6Lines")]
        public GlyphDefinition Staff6Lines { get; set; }

        [JsonProperty("staff6LinesNarrow")]
        public GlyphDefinition Staff6LinesNarrow { get; set; }

        [JsonProperty("staff6LinesWide")]
        public GlyphDefinition Staff6LinesWide { get; set; }

        [JsonProperty("staffDivideArrowDown")]
        public GlyphDefinition StaffDivideArrowDown { get; set; }

        [JsonProperty("staffDivideArrowUp")]
        public GlyphDefinition StaffDivideArrowUp { get; set; }

        [JsonProperty("staffDivideArrowUpDown")]
        public GlyphDefinition StaffDivideArrowUpDown { get; set; }

        [JsonProperty("staffPosLower1")]
        public GlyphDefinition StaffPosLower1 { get; set; }

        [JsonProperty("staffPosLower2")]
        public GlyphDefinition StaffPosLower2 { get; set; }

        [JsonProperty("staffPosLower3")]
        public GlyphDefinition StaffPosLower3 { get; set; }

        [JsonProperty("staffPosLower4")]
        public GlyphDefinition StaffPosLower4 { get; set; }

        [JsonProperty("staffPosLower5")]
        public GlyphDefinition StaffPosLower5 { get; set; }

        [JsonProperty("staffPosLower6")]
        public GlyphDefinition StaffPosLower6 { get; set; }

        [JsonProperty("staffPosLower7")]
        public GlyphDefinition StaffPosLower7 { get; set; }

        [JsonProperty("staffPosLower8")]
        public GlyphDefinition StaffPosLower8 { get; set; }

        [JsonProperty("staffPosRaise1")]
        public GlyphDefinition StaffPosRaise1 { get; set; }

        [JsonProperty("staffPosRaise2")]
        public GlyphDefinition StaffPosRaise2 { get; set; }

        [JsonProperty("staffPosRaise3")]
        public GlyphDefinition StaffPosRaise3 { get; set; }

        [JsonProperty("staffPosRaise4")]
        public GlyphDefinition StaffPosRaise4 { get; set; }

        [JsonProperty("staffPosRaise5")]
        public GlyphDefinition StaffPosRaise5 { get; set; }

        [JsonProperty("staffPosRaise6")]
        public GlyphDefinition StaffPosRaise6 { get; set; }

        [JsonProperty("staffPosRaise7")]
        public GlyphDefinition StaffPosRaise7 { get; set; }

        [JsonProperty("staffPosRaise8")]
        public GlyphDefinition StaffPosRaise8 { get; set; }

        [JsonProperty("stem")]
        public GlyphDefinition Stem { get; set; }

        [JsonProperty("stemBowOnBridge")]
        public GlyphDefinition StemBowOnBridge { get; set; }

        [JsonProperty("stemBowOnTailpiece")]
        public GlyphDefinition StemBowOnTailpiece { get; set; }

        [JsonProperty("stemBuzzRoll")]
        public GlyphDefinition StemBuzzRoll { get; set; }

        [JsonProperty("stemDamp")]
        public GlyphDefinition StemDamp { get; set; }

        [JsonProperty("stemHarpStringNoise")]
        public GlyphDefinition StemHarpStringNoise { get; set; }

        [JsonProperty("stemMultiphonicsBlack")]
        public GlyphDefinition StemMultiphonicsBlack { get; set; }

        [JsonProperty("stemMultiphonicsBlackWhite")]
        public GlyphDefinition StemMultiphonicsBlackWhite { get; set; }

        [JsonProperty("stemMultiphonicsWhite")]
        public GlyphDefinition StemMultiphonicsWhite { get; set; }

        [JsonProperty("stemPendereckiTremolo")]
        public GlyphDefinition StemPendereckiTremolo { get; set; }

        [JsonProperty("stemRimShot")]
        public GlyphDefinition StemRimShot { get; set; }

        [JsonProperty("stemSprechgesang")]
        public GlyphDefinition StemSprechgesang { get; set; }

        [JsonProperty("stemSulPonticello")]
        public GlyphDefinition StemSulPonticello { get; set; }

        [JsonProperty("stemSussurando")]
        public GlyphDefinition StemSussurando { get; set; }

        [JsonProperty("stemSwished")]
        public GlyphDefinition StemSwished { get; set; }

        [JsonProperty("stemVibratoPulse")]
        public GlyphDefinition StemVibratoPulse { get; set; }

        [JsonProperty("stringsBowBehindBridge")]
        public GlyphDefinition StringsBowBehindBridge { get; set; }

        [JsonProperty("stringsBowOnBridge")]
        public GlyphDefinition StringsBowOnBridge { get; set; }

        [JsonProperty("stringsBowOnTailpiece")]
        public GlyphDefinition StringsBowOnTailpiece { get; set; }

        [JsonProperty("stringsChangeBowDirection")]
        public GlyphDefinition StringsChangeBowDirection { get; set; }

        [JsonProperty("stringsDownBow")]
        public GlyphDefinition StringsDownBow { get; set; }

        [JsonProperty("stringsDownBowTurned")]
        public GlyphDefinition StringsDownBowTurned { get; set; }

        [JsonProperty("stringsFouette")]
        public GlyphDefinition StringsFouette { get; set; }

        [JsonProperty("stringsHalfHarmonic")]
        public GlyphDefinition StringsHalfHarmonic { get; set; }

        [JsonProperty("stringsHarmonic")]
        public GlyphDefinition StringsHarmonic { get; set; }

        [JsonProperty("stringsJeteAbove")]
        public GlyphDefinition StringsJeteAbove { get; set; }

        [JsonProperty("stringsJeteBelow")]
        public GlyphDefinition StringsJeteBelow { get; set; }

        [JsonProperty("stringsMuteOff")]
        public GlyphDefinition StringsMuteOff { get; set; }

        [JsonProperty("stringsMuteOn")]
        public GlyphDefinition StringsMuteOn { get; set; }

        [JsonProperty("stringsOverpressureDownBow")]
        public GlyphDefinition StringsOverpressureDownBow { get; set; }

        [JsonProperty("stringsOverpressureNoDirection")]
        public GlyphDefinition StringsOverpressureNoDirection { get; set; }

        [JsonProperty("stringsOverpressurePossibileDownBow")]
        public GlyphDefinition StringsOverpressurePossibileDownBow { get; set; }

        [JsonProperty("stringsOverpressurePossibileUpBow")]
        public GlyphDefinition StringsOverpressurePossibileUpBow { get; set; }

        [JsonProperty("stringsOverpressureUpBow")]
        public GlyphDefinition StringsOverpressureUpBow { get; set; }

        [JsonProperty("stringsThumbPosition")]
        public GlyphDefinition StringsThumbPosition { get; set; }

        [JsonProperty("stringsThumbPositionTurned")]
        public GlyphDefinition StringsThumbPositionTurned { get; set; }

        [JsonProperty("stringsUpBow")]
        public GlyphDefinition StringsUpBow { get; set; }

        [JsonProperty("stringsUpBowTurned")]
        public GlyphDefinition StringsUpBowTurned { get; set; }

        [JsonProperty("stringsVibratoPulse")]
        public GlyphDefinition StringsVibratoPulse { get; set; }

        [JsonProperty("systemDivider")]
        public GlyphDefinition SystemDivider { get; set; }

        [JsonProperty("systemDividerExtraLong")]
        public GlyphDefinition SystemDividerExtraLong { get; set; }

        [JsonProperty("systemDividerLong")]
        public GlyphDefinition SystemDividerLong { get; set; }

        [JsonProperty("textAugmentationDot")]
        public GlyphDefinition TextAugmentationDot { get; set; }

        [JsonProperty("textBlackNoteFrac16thLongStem")]
        public GlyphDefinition TextBlackNoteFrac16ThLongStem { get; set; }

        [JsonProperty("textBlackNoteFrac16thShortStem")]
        public GlyphDefinition TextBlackNoteFrac16ThShortStem { get; set; }

        [JsonProperty("textBlackNoteFrac32ndLongStem")]
        public GlyphDefinition TextBlackNoteFrac32NdLongStem { get; set; }

        [JsonProperty("textBlackNoteFrac8thLongStem")]
        public GlyphDefinition TextBlackNoteFrac8ThLongStem { get; set; }

        [JsonProperty("textBlackNoteFrac8thShortStem")]
        public GlyphDefinition TextBlackNoteFrac8ThShortStem { get; set; }

        [JsonProperty("textBlackNoteLongStem")]
        public GlyphDefinition TextBlackNoteLongStem { get; set; }

        [JsonProperty("textBlackNoteShortStem")]
        public GlyphDefinition TextBlackNoteShortStem { get; set; }

        [JsonProperty("textCont16thBeamLongStem")]
        public GlyphDefinition TextCont16ThBeamLongStem { get; set; }

        [JsonProperty("textCont16thBeamShortStem")]
        public GlyphDefinition TextCont16ThBeamShortStem { get; set; }

        [JsonProperty("textCont32ndBeamLongStem")]
        public GlyphDefinition TextCont32NdBeamLongStem { get; set; }

        [JsonProperty("textCont8thBeamLongStem")]
        public GlyphDefinition TextCont8ThBeamLongStem { get; set; }

        [JsonProperty("textCont8thBeamShortStem")]
        public GlyphDefinition TextCont8ThBeamShortStem { get; set; }

        [JsonProperty("textTie")]
        public GlyphDefinition TextTie { get; set; }

        [JsonProperty("textTuplet3LongStem")]
        public GlyphDefinition TextTuplet3LongStem { get; set; }

        [JsonProperty("textTuplet3ShortStem")]
        public GlyphDefinition TextTuplet3ShortStem { get; set; }

        [JsonProperty("textTupletBracketEndLongStem")]
        public GlyphDefinition TextTupletBracketEndLongStem { get; set; }

        [JsonProperty("textTupletBracketEndShortStem")]
        public GlyphDefinition TextTupletBracketEndShortStem { get; set; }

        [JsonProperty("textTupletBracketStartLongStem")]
        public GlyphDefinition TextTupletBracketStartLongStem { get; set; }

        [JsonProperty("textTupletBracketStartShortStem")]
        public GlyphDefinition TextTupletBracketStartShortStem { get; set; }

        [JsonProperty("timeSig0")]
        public GlyphDefinition TimeSig0 { get; set; }

        [JsonProperty("timeSig1")]
        public GlyphDefinition TimeSig1 { get; set; }

        [JsonProperty("timeSig2")]
        public GlyphDefinition TimeSig2 { get; set; }

        [JsonProperty("timeSig3")]
        public GlyphDefinition TimeSig3 { get; set; }

        [JsonProperty("timeSig4")]
        public GlyphDefinition TimeSig4 { get; set; }

        [JsonProperty("timeSig5")]
        public GlyphDefinition TimeSig5 { get; set; }

        [JsonProperty("timeSig6")]
        public GlyphDefinition TimeSig6 { get; set; }

        [JsonProperty("timeSig7")]
        public GlyphDefinition TimeSig7 { get; set; }

        [JsonProperty("timeSig8")]
        public GlyphDefinition TimeSig8 { get; set; }

        [JsonProperty("timeSig9")]
        public GlyphDefinition TimeSig9 { get; set; }

        [JsonProperty("timeSigBracketLeft")]
        public GlyphDefinition TimeSigBracketLeft { get; set; }

        [JsonProperty("timeSigBracketLeftSmall")]
        public GlyphDefinition TimeSigBracketLeftSmall { get; set; }

        [JsonProperty("timeSigBracketRight")]
        public GlyphDefinition TimeSigBracketRight { get; set; }

        [JsonProperty("timeSigBracketRightSmall")]
        public GlyphDefinition TimeSigBracketRightSmall { get; set; }

        [JsonProperty("timeSigCombDenominator")]
        public GlyphDefinition TimeSigCombDenominator { get; set; }

        [JsonProperty("timeSigCombNumerator")]
        public GlyphDefinition TimeSigCombNumerator { get; set; }

        [JsonProperty("timeSigComma")]
        public GlyphDefinition TimeSigComma { get; set; }

        [JsonProperty("timeSigCommon")]
        public GlyphDefinition TimeSigCommon { get; set; }

        [JsonProperty("timeSigCut2")]
        public GlyphDefinition TimeSigCut2 { get; set; }

        [JsonProperty("timeSigCutCommon")]
        public GlyphDefinition TimeSigCutCommon { get; set; }

        [JsonProperty("timeSigEquals")]
        public GlyphDefinition TimeSigEquals { get; set; }

        [JsonProperty("timeSigFractionHalf")]
        public GlyphDefinition TimeSigFractionHalf { get; set; }

        [JsonProperty("timeSigFractionOneThird")]
        public GlyphDefinition TimeSigFractionOneThird { get; set; }

        [JsonProperty("timeSigFractionQuarter")]
        public GlyphDefinition TimeSigFractionQuarter { get; set; }

        [JsonProperty("timeSigFractionThreeQuarters")]
        public GlyphDefinition TimeSigFractionThreeQuarters { get; set; }

        [JsonProperty("timeSigFractionTwoThirds")]
        public GlyphDefinition TimeSigFractionTwoThirds { get; set; }

        [JsonProperty("timeSigFractionalSlash")]
        public GlyphDefinition TimeSigFractionalSlash { get; set; }

        [JsonProperty("timeSigMinus")]
        public GlyphDefinition TimeSigMinus { get; set; }

        [JsonProperty("timeSigMultiply")]
        public GlyphDefinition TimeSigMultiply { get; set; }

        [JsonProperty("timeSigOpenPenderecki")]
        public GlyphDefinition TimeSigOpenPenderecki { get; set; }

        [JsonProperty("timeSigParensLeft")]
        public GlyphDefinition TimeSigParensLeft { get; set; }

        [JsonProperty("timeSigParensLeftSmall")]
        public GlyphDefinition TimeSigParensLeftSmall { get; set; }

        [JsonProperty("timeSigParensRight")]
        public GlyphDefinition TimeSigParensRight { get; set; }

        [JsonProperty("timeSigParensRightSmall")]
        public GlyphDefinition TimeSigParensRightSmall { get; set; }

        [JsonProperty("timeSigPlus")]
        public GlyphDefinition TimeSigPlus { get; set; }

        [JsonProperty("timeSigPlusSmall")]
        public GlyphDefinition TimeSigPlusSmall { get; set; }

        [JsonProperty("timeSigSlash")]
        public GlyphDefinition TimeSigSlash { get; set; }

        [JsonProperty("timeSigX")]
        public GlyphDefinition TimeSigX { get; set; }

        [JsonProperty("tremolo1")]
        public GlyphDefinition Tremolo1 { get; set; }

        [JsonProperty("tremolo2")]
        public GlyphDefinition Tremolo2 { get; set; }

        [JsonProperty("tremolo3")]
        public GlyphDefinition Tremolo3 { get; set; }

        [JsonProperty("tremolo4")]
        public GlyphDefinition Tremolo4 { get; set; }

        [JsonProperty("tremolo5")]
        public GlyphDefinition Tremolo5 { get; set; }

        [JsonProperty("tremoloDivisiDots2")]
        public GlyphDefinition TremoloDivisiDots2 { get; set; }

        [JsonProperty("tremoloDivisiDots3")]
        public GlyphDefinition TremoloDivisiDots3 { get; set; }

        [JsonProperty("tremoloDivisiDots4")]
        public GlyphDefinition TremoloDivisiDots4 { get; set; }

        [JsonProperty("tremoloDivisiDots6")]
        public GlyphDefinition TremoloDivisiDots6 { get; set; }

        [JsonProperty("tremoloFingered1")]
        public GlyphDefinition TremoloFingered1 { get; set; }

        [JsonProperty("tremoloFingered2")]
        public GlyphDefinition TremoloFingered2 { get; set; }

        [JsonProperty("tremoloFingered3")]
        public GlyphDefinition TremoloFingered3 { get; set; }

        [JsonProperty("tremoloFingered4")]
        public GlyphDefinition TremoloFingered4 { get; set; }

        [JsonProperty("tremoloFingered5")]
        public GlyphDefinition TremoloFingered5 { get; set; }

        [JsonProperty("tripleTongueAbove")]
        public GlyphDefinition TripleTongueAbove { get; set; }

        [JsonProperty("tripleTongueBelow")]
        public GlyphDefinition TripleTongueBelow { get; set; }

        [JsonProperty("tuplet0")]
        public GlyphDefinition Tuplet0 { get; set; }

        [JsonProperty("tuplet1")]
        public GlyphDefinition Tuplet1 { get; set; }

        [JsonProperty("tuplet2")]
        public GlyphDefinition Tuplet2 { get; set; }

        [JsonProperty("tuplet3")]
        public GlyphDefinition Tuplet3 { get; set; }

        [JsonProperty("tuplet4")]
        public GlyphDefinition Tuplet4 { get; set; }

        [JsonProperty("tuplet5")]
        public GlyphDefinition Tuplet5 { get; set; }

        [JsonProperty("tuplet6")]
        public GlyphDefinition Tuplet6 { get; set; }

        [JsonProperty("tuplet7")]
        public GlyphDefinition Tuplet7 { get; set; }

        [JsonProperty("tuplet8")]
        public GlyphDefinition Tuplet8 { get; set; }

        [JsonProperty("tuplet9")]
        public GlyphDefinition Tuplet9 { get; set; }

        [JsonProperty("tupletColon")]
        public GlyphDefinition TupletColon { get; set; }

        [JsonProperty("unmeasuredTremolo")]
        public GlyphDefinition UnmeasuredTremolo { get; set; }

        [JsonProperty("unmeasuredTremoloSimple")]
        public GlyphDefinition UnmeasuredTremoloSimple { get; set; }

        [JsonProperty("unpitchedPercussionClef1")]
        public GlyphDefinition UnpitchedPercussionClef1 { get; set; }

        [JsonProperty("unpitchedPercussionClef2")]
        public GlyphDefinition UnpitchedPercussionClef2 { get; set; }

        [JsonProperty("ventiduesima")]
        public GlyphDefinition Ventiduesima { get; set; }

        [JsonProperty("ventiduesimaAlta")]
        public GlyphDefinition VentiduesimaAlta { get; set; }

        [JsonProperty("ventiduesimaBassa")]
        public GlyphDefinition VentiduesimaBassa { get; set; }

        [JsonProperty("ventiduesimaBassaMb")]
        public GlyphDefinition VentiduesimaBassaMb { get; set; }

        [JsonProperty("vocalMouthClosed")]
        public GlyphDefinition VocalMouthClosed { get; set; }

        [JsonProperty("vocalMouthOpen")]
        public GlyphDefinition VocalMouthOpen { get; set; }

        [JsonProperty("vocalMouthPursed")]
        public GlyphDefinition VocalMouthPursed { get; set; }

        [JsonProperty("vocalMouthSlightlyOpen")]
        public GlyphDefinition VocalMouthSlightlyOpen { get; set; }

        [JsonProperty("vocalMouthWideOpen")]
        public GlyphDefinition VocalMouthWideOpen { get; set; }

        [JsonProperty("vocalSprechgesang")]
        public GlyphDefinition VocalSprechgesang { get; set; }

        [JsonProperty("vocalsSussurando")]
        public GlyphDefinition VocalsSussurando { get; set; }

        [JsonProperty("wiggleArpeggiatoDown")]
        public GlyphDefinition WiggleArpeggiatoDown { get; set; }

        [JsonProperty("wiggleArpeggiatoDownArrow")]
        public GlyphDefinition WiggleArpeggiatoDownArrow { get; set; }

        [JsonProperty("wiggleArpeggiatoDownSwash")]
        public GlyphDefinition WiggleArpeggiatoDownSwash { get; set; }

        [JsonProperty("wiggleArpeggiatoUp")]
        public GlyphDefinition WiggleArpeggiatoUp { get; set; }

        [JsonProperty("wiggleArpeggiatoUpArrow")]
        public GlyphDefinition WiggleArpeggiatoUpArrow { get; set; }

        [JsonProperty("wiggleArpeggiatoUpSwash")]
        public GlyphDefinition WiggleArpeggiatoUpSwash { get; set; }

        [JsonProperty("wiggleCircular")]
        public GlyphDefinition WiggleCircular { get; set; }

        [JsonProperty("wiggleCircularConstant")]
        public GlyphDefinition WiggleCircularConstant { get; set; }

        [JsonProperty("wiggleCircularConstantFlipped")]
        public GlyphDefinition WiggleCircularConstantFlipped { get; set; }

        [JsonProperty("wiggleCircularConstantFlippedLarge")]
        public GlyphDefinition WiggleCircularConstantFlippedLarge { get; set; }

        [JsonProperty("wiggleCircularConstantLarge")]
        public GlyphDefinition WiggleCircularConstantLarge { get; set; }

        [JsonProperty("wiggleCircularEnd")]
        public GlyphDefinition WiggleCircularEnd { get; set; }

        [JsonProperty("wiggleCircularLarge")]
        public GlyphDefinition WiggleCircularLarge { get; set; }

        [JsonProperty("wiggleCircularLarger")]
        public GlyphDefinition WiggleCircularLarger { get; set; }

        [JsonProperty("wiggleCircularLargerStill")]
        public GlyphDefinition WiggleCircularLargerStill { get; set; }

        [JsonProperty("wiggleCircularLargest")]
        public GlyphDefinition WiggleCircularLargest { get; set; }

        [JsonProperty("wiggleCircularSmall")]
        public GlyphDefinition WiggleCircularSmall { get; set; }

        [JsonProperty("wiggleCircularStart")]
        public GlyphDefinition WiggleCircularStart { get; set; }

        [JsonProperty("wiggleGlissando")]
        public GlyphDefinition WiggleGlissando { get; set; }

        [JsonProperty("wiggleGlissandoGroup1")]
        public GlyphDefinition WiggleGlissandoGroup1 { get; set; }

        [JsonProperty("wiggleGlissandoGroup2")]
        public GlyphDefinition WiggleGlissandoGroup2 { get; set; }

        [JsonProperty("wiggleGlissandoGroup3")]
        public GlyphDefinition WiggleGlissandoGroup3 { get; set; }

        [JsonProperty("wiggleRandom1")]
        public GlyphDefinition WiggleRandom1 { get; set; }

        [JsonProperty("wiggleRandom2")]
        public GlyphDefinition WiggleRandom2 { get; set; }

        [JsonProperty("wiggleRandom3")]
        public GlyphDefinition WiggleRandom3 { get; set; }

        [JsonProperty("wiggleRandom4")]
        public GlyphDefinition WiggleRandom4 { get; set; }

        [JsonProperty("wiggleSawtooth")]
        public GlyphDefinition WiggleSawtooth { get; set; }

        [JsonProperty("wiggleSawtoothNarrow")]
        public GlyphDefinition WiggleSawtoothNarrow { get; set; }

        [JsonProperty("wiggleSawtoothWide")]
        public GlyphDefinition WiggleSawtoothWide { get; set; }

        [JsonProperty("wiggleSquareWave")]
        public GlyphDefinition WiggleSquareWave { get; set; }

        [JsonProperty("wiggleSquareWaveNarrow")]
        public GlyphDefinition WiggleSquareWaveNarrow { get; set; }

        [JsonProperty("wiggleSquareWaveWide")]
        public GlyphDefinition WiggleSquareWaveWide { get; set; }

        [JsonProperty("wiggleTrill")]
        public GlyphDefinition WiggleTrill { get; set; }

        [JsonProperty("wiggleTrillFast")]
        public GlyphDefinition WiggleTrillFast { get; set; }

        [JsonProperty("wiggleTrillFaster")]
        public GlyphDefinition WiggleTrillFaster { get; set; }

        [JsonProperty("wiggleTrillFasterStill")]
        public GlyphDefinition WiggleTrillFasterStill { get; set; }

        [JsonProperty("wiggleTrillFastest")]
        public GlyphDefinition WiggleTrillFastest { get; set; }

        [JsonProperty("wiggleTrillSlow")]
        public GlyphDefinition WiggleTrillSlow { get; set; }

        [JsonProperty("wiggleTrillSlower")]
        public GlyphDefinition WiggleTrillSlower { get; set; }

        [JsonProperty("wiggleTrillSlowerStill")]
        public GlyphDefinition WiggleTrillSlowerStill { get; set; }

        [JsonProperty("wiggleTrillSlowest")]
        public GlyphDefinition WiggleTrillSlowest { get; set; }

        [JsonProperty("wiggleVIbratoLargestSlower")]
        public GlyphDefinition WiggleVIbratoLargestSlower { get; set; }

        [JsonProperty("wiggleVIbratoMediumSlower")]
        public GlyphDefinition WiggleVIbratoMediumSlower { get; set; }

        [JsonProperty("wiggleVibrato")]
        public GlyphDefinition WiggleVibrato { get; set; }

        [JsonProperty("wiggleVibratoLargeFast")]
        public GlyphDefinition WiggleVibratoLargeFast { get; set; }

        [JsonProperty("wiggleVibratoLargeFaster")]
        public GlyphDefinition WiggleVibratoLargeFaster { get; set; }

        [JsonProperty("wiggleVibratoLargeFasterStill")]
        public GlyphDefinition WiggleVibratoLargeFasterStill { get; set; }

        [JsonProperty("wiggleVibratoLargeFastest")]
        public GlyphDefinition WiggleVibratoLargeFastest { get; set; }

        [JsonProperty("wiggleVibratoLargeSlow")]
        public GlyphDefinition WiggleVibratoLargeSlow { get; set; }

        [JsonProperty("wiggleVibratoLargeSlower")]
        public GlyphDefinition WiggleVibratoLargeSlower { get; set; }

        [JsonProperty("wiggleVibratoLargeSlowest")]
        public GlyphDefinition WiggleVibratoLargeSlowest { get; set; }

        [JsonProperty("wiggleVibratoLargestFast")]
        public GlyphDefinition WiggleVibratoLargestFast { get; set; }

        [JsonProperty("wiggleVibratoLargestFaster")]
        public GlyphDefinition WiggleVibratoLargestFaster { get; set; }

        [JsonProperty("wiggleVibratoLargestFasterStill")]
        public GlyphDefinition WiggleVibratoLargestFasterStill { get; set; }

        [JsonProperty("wiggleVibratoLargestFastest")]
        public GlyphDefinition WiggleVibratoLargestFastest { get; set; }

        [JsonProperty("wiggleVibratoLargestSlow")]
        public GlyphDefinition WiggleVibratoLargestSlow { get; set; }

        [JsonProperty("wiggleVibratoLargestSlowest")]
        public GlyphDefinition WiggleVibratoLargestSlowest { get; set; }

        [JsonProperty("wiggleVibratoMediumFast")]
        public GlyphDefinition WiggleVibratoMediumFast { get; set; }

        [JsonProperty("wiggleVibratoMediumFaster")]
        public GlyphDefinition WiggleVibratoMediumFaster { get; set; }

        [JsonProperty("wiggleVibratoMediumFasterStill")]
        public GlyphDefinition WiggleVibratoMediumFasterStill { get; set; }

        [JsonProperty("wiggleVibratoMediumFastest")]
        public GlyphDefinition WiggleVibratoMediumFastest { get; set; }

        [JsonProperty("wiggleVibratoMediumSlow")]
        public GlyphDefinition WiggleVibratoMediumSlow { get; set; }

        [JsonProperty("wiggleVibratoMediumSlowest")]
        public GlyphDefinition WiggleVibratoMediumSlowest { get; set; }

        [JsonProperty("wiggleVibratoSmallFast")]
        public GlyphDefinition WiggleVibratoSmallFast { get; set; }

        [JsonProperty("wiggleVibratoSmallFaster")]
        public GlyphDefinition WiggleVibratoSmallFaster { get; set; }

        [JsonProperty("wiggleVibratoSmallFasterStill")]
        public GlyphDefinition WiggleVibratoSmallFasterStill { get; set; }

        [JsonProperty("wiggleVibratoSmallFastest")]
        public GlyphDefinition WiggleVibratoSmallFastest { get; set; }

        [JsonProperty("wiggleVibratoSmallSlow")]
        public GlyphDefinition WiggleVibratoSmallSlow { get; set; }

        [JsonProperty("wiggleVibratoSmallSlower")]
        public GlyphDefinition WiggleVibratoSmallSlower { get; set; }

        [JsonProperty("wiggleVibratoSmallSlowest")]
        public GlyphDefinition WiggleVibratoSmallSlowest { get; set; }

        [JsonProperty("wiggleVibratoSmallestFast")]
        public GlyphDefinition WiggleVibratoSmallestFast { get; set; }

        [JsonProperty("wiggleVibratoSmallestFaster")]
        public GlyphDefinition WiggleVibratoSmallestFaster { get; set; }

        [JsonProperty("wiggleVibratoSmallestFasterStill")]
        public GlyphDefinition WiggleVibratoSmallestFasterStill { get; set; }

        [JsonProperty("wiggleVibratoSmallestFastest")]
        public GlyphDefinition WiggleVibratoSmallestFastest { get; set; }

        [JsonProperty("wiggleVibratoSmallestSlow")]
        public GlyphDefinition WiggleVibratoSmallestSlow { get; set; }

        [JsonProperty("wiggleVibratoSmallestSlower")]
        public GlyphDefinition WiggleVibratoSmallestSlower { get; set; }

        [JsonProperty("wiggleVibratoSmallestSlowest")]
        public GlyphDefinition WiggleVibratoSmallestSlowest { get; set; }

        [JsonProperty("wiggleVibratoStart")]
        public GlyphDefinition WiggleVibratoStart { get; set; }

        [JsonProperty("wiggleVibratoWide")]
        public GlyphDefinition WiggleVibratoWide { get; set; }

        [JsonProperty("wiggleWavy")]
        public GlyphDefinition WiggleWavy { get; set; }

        [JsonProperty("wiggleWavyNarrow")]
        public GlyphDefinition WiggleWavyNarrow { get; set; }

        [JsonProperty("wiggleWavyWide")]
        public GlyphDefinition WiggleWavyWide { get; set; }

        [JsonProperty("windClosedHole")]
        public GlyphDefinition WindClosedHole { get; set; }

        [JsonProperty("windFlatEmbouchure")]
        public GlyphDefinition WindFlatEmbouchure { get; set; }

        [JsonProperty("windHalfClosedHole1")]
        public GlyphDefinition WindHalfClosedHole1 { get; set; }

        [JsonProperty("windHalfClosedHole2")]
        public GlyphDefinition WindHalfClosedHole2 { get; set; }

        [JsonProperty("windHalfClosedHole3")]
        public GlyphDefinition WindHalfClosedHole3 { get; set; }

        [JsonProperty("windLessRelaxedEmbouchure")]
        public GlyphDefinition WindLessRelaxedEmbouchure { get; set; }

        [JsonProperty("windLessTightEmbouchure")]
        public GlyphDefinition WindLessTightEmbouchure { get; set; }

        [JsonProperty("windMultiphonicsBlackStem")]
        public GlyphDefinition WindMultiphonicsBlackStem { get; set; }

        [JsonProperty("windMultiphonicsBlackWhiteStem")]
        public GlyphDefinition WindMultiphonicsBlackWhiteStem { get; set; }

        [JsonProperty("windMultiphonicsWhiteStem")]
        public GlyphDefinition WindMultiphonicsWhiteStem { get; set; }

        [JsonProperty("windOpenHole")]
        public GlyphDefinition WindOpenHole { get; set; }

        [JsonProperty("windReedPositionIn")]
        public GlyphDefinition WindReedPositionIn { get; set; }

        [JsonProperty("windReedPositionNormal")]
        public GlyphDefinition WindReedPositionNormal { get; set; }

        [JsonProperty("windReedPositionOut")]
        public GlyphDefinition WindReedPositionOut { get; set; }

        [JsonProperty("windRelaxedEmbouchure")]
        public GlyphDefinition WindRelaxedEmbouchure { get; set; }

        [JsonProperty("windSharpEmbouchure")]
        public GlyphDefinition WindSharpEmbouchure { get; set; }

        [JsonProperty("windStrongAirPressure")]
        public GlyphDefinition WindStrongAirPressure { get; set; }

        [JsonProperty("windThreeQuartersClosedHole")]
        public GlyphDefinition WindThreeQuartersClosedHole { get; set; }

        [JsonProperty("windTightEmbouchure")]
        public GlyphDefinition WindTightEmbouchure { get; set; }

        [JsonProperty("windTrillKey")]
        public GlyphDefinition WindTrillKey { get; set; }

        [JsonProperty("windVeryTightEmbouchure")]
        public GlyphDefinition WindVeryTightEmbouchure { get; set; }

        [JsonProperty("windWeakAirPressure")]
        public GlyphDefinition WindWeakAirPressure { get; set; }
    }
}