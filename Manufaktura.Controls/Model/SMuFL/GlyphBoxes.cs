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
using System.Collections.Generic;
using System.Text;

namespace Manufaktura.Controls.Model.SMuFL
{
    public partial class GlyphBBoxes
    {
        [JsonProperty("4stringTabClef")]
        public BoundingBox The4StringTabClef { get; set; }

        [JsonProperty("4stringTabClefSerif")]
        public BoundingBox The4StringTabClefSerif { get; set; }

        [JsonProperty("4stringTabClefTall")]
        public BoundingBox The4StringTabClefTall { get; set; }

        [JsonProperty("6stringTabClef")]
        public BoundingBox The6StringTabClef { get; set; }

        [JsonProperty("6stringTabClefSerif")]
        public BoundingBox The6StringTabClefSerif { get; set; }

        [JsonProperty("6stringTabClefTall")]
        public BoundingBox The6StringTabClefTall { get; set; }

        [JsonProperty("accSagittal11LargeDiesisDown")]
        public BoundingBox AccSagittal11LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal11LargeDiesisUp")]
        public BoundingBox AccSagittal11LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal11MediumDiesisDown")]
        public BoundingBox AccSagittal11MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal11MediumDiesisUp")]
        public BoundingBox AccSagittal11MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal11v19LargeDiesisDown")]
        public BoundingBox AccSagittal11V19LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal11v19LargeDiesisUp")]
        public BoundingBox AccSagittal11V19LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal11v19MediumDiesisDown")]
        public BoundingBox AccSagittal11V19MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal11v19MediumDiesisUp")]
        public BoundingBox AccSagittal11V19MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal11v49CommaDown")]
        public BoundingBox AccSagittal11V49CommaDown { get; set; }

        [JsonProperty("accSagittal11v49CommaUp")]
        public BoundingBox AccSagittal11V49CommaUp { get; set; }

        [JsonProperty("accSagittal143CommaDown")]
        public BoundingBox AccSagittal143CommaDown { get; set; }

        [JsonProperty("accSagittal143CommaUp")]
        public BoundingBox AccSagittal143CommaUp { get; set; }

        [JsonProperty("accSagittal17CommaDown")]
        public BoundingBox AccSagittal17CommaDown { get; set; }

        [JsonProperty("accSagittal17CommaUp")]
        public BoundingBox AccSagittal17CommaUp { get; set; }

        [JsonProperty("accSagittal17KleismaDown")]
        public BoundingBox AccSagittal17KleismaDown { get; set; }

        [JsonProperty("accSagittal17KleismaUp")]
        public BoundingBox AccSagittal17KleismaUp { get; set; }

        [JsonProperty("accSagittal19CommaDown")]
        public BoundingBox AccSagittal19CommaDown { get; set; }

        [JsonProperty("accSagittal19CommaUp")]
        public BoundingBox AccSagittal19CommaUp { get; set; }

        [JsonProperty("accSagittal19SchismaDown")]
        public BoundingBox AccSagittal19SchismaDown { get; set; }

        [JsonProperty("accSagittal19SchismaUp")]
        public BoundingBox AccSagittal19SchismaUp { get; set; }

        [JsonProperty("accSagittal23CommaDown")]
        public BoundingBox AccSagittal23CommaDown { get; set; }

        [JsonProperty("accSagittal23CommaUp")]
        public BoundingBox AccSagittal23CommaUp { get; set; }

        [JsonProperty("accSagittal23SmallDiesisDown")]
        public BoundingBox AccSagittal23SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal23SmallDiesisUp")]
        public BoundingBox AccSagittal23SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal25SmallDiesisDown")]
        public BoundingBox AccSagittal25SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal25SmallDiesisUp")]
        public BoundingBox AccSagittal25SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal35LargeDiesisDown")]
        public BoundingBox AccSagittal35LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal35LargeDiesisUp")]
        public BoundingBox AccSagittal35LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal35MediumDiesisDown")]
        public BoundingBox AccSagittal35MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal35MediumDiesisUp")]
        public BoundingBox AccSagittal35MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal49LargeDiesisDown")]
        public BoundingBox AccSagittal49LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal49LargeDiesisUp")]
        public BoundingBox AccSagittal49LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal49MediumDiesisDown")]
        public BoundingBox AccSagittal49MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal49MediumDiesisUp")]
        public BoundingBox AccSagittal49MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal49SmallDiesisDown")]
        public BoundingBox AccSagittal49SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal49SmallDiesisUp")]
        public BoundingBox AccSagittal49SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal55CommaDown")]
        public BoundingBox AccSagittal55CommaDown { get; set; }

        [JsonProperty("accSagittal55CommaUp")]
        public BoundingBox AccSagittal55CommaUp { get; set; }

        [JsonProperty("accSagittal5CommaDown")]
        public BoundingBox AccSagittal5CommaDown { get; set; }

        [JsonProperty("accSagittal5CommaUp")]
        public BoundingBox AccSagittal5CommaUp { get; set; }

        [JsonProperty("accSagittal5v11SmallDiesisDown")]
        public BoundingBox AccSagittal5V11SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal5v11SmallDiesisUp")]
        public BoundingBox AccSagittal5V11SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal5v13LargeDiesisDown")]
        public BoundingBox AccSagittal5V13LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal5v13LargeDiesisUp")]
        public BoundingBox AccSagittal5V13LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal5v13MediumDiesisDown")]
        public BoundingBox AccSagittal5V13MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal5v13MediumDiesisUp")]
        public BoundingBox AccSagittal5V13MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal5v19CommaDown")]
        public BoundingBox AccSagittal5V19CommaDown { get; set; }

        [JsonProperty("accSagittal5v19CommaUp")]
        public BoundingBox AccSagittal5V19CommaUp { get; set; }

        [JsonProperty("accSagittal5v23SmallDiesisDown")]
        public BoundingBox AccSagittal5V23SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal5v23SmallDiesisUp")]
        public BoundingBox AccSagittal5V23SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal5v49MediumDiesisDown")]
        public BoundingBox AccSagittal5V49MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal5v49MediumDiesisUp")]
        public BoundingBox AccSagittal5V49MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal5v7KleismaDown")]
        public BoundingBox AccSagittal5V7KleismaDown { get; set; }

        [JsonProperty("accSagittal5v7KleismaUp")]
        public BoundingBox AccSagittal5V7KleismaUp { get; set; }

        [JsonProperty("accSagittal7CommaDown")]
        public BoundingBox AccSagittal7CommaDown { get; set; }

        [JsonProperty("accSagittal7CommaUp")]
        public BoundingBox AccSagittal7CommaUp { get; set; }

        [JsonProperty("accSagittal7v11CommaDown")]
        public BoundingBox AccSagittal7V11CommaDown { get; set; }

        [JsonProperty("accSagittal7v11CommaUp")]
        public BoundingBox AccSagittal7V11CommaUp { get; set; }

        [JsonProperty("accSagittal7v11KleismaDown")]
        public BoundingBox AccSagittal7V11KleismaDown { get; set; }

        [JsonProperty("accSagittal7v11KleismaUp")]
        public BoundingBox AccSagittal7V11KleismaUp { get; set; }

        [JsonProperty("accSagittal7v19CommaDown")]
        public BoundingBox AccSagittal7V19CommaDown { get; set; }

        [JsonProperty("accSagittal7v19CommaUp")]
        public BoundingBox AccSagittal7V19CommaUp { get; set; }

        [JsonProperty("accSagittalAcute")]
        public BoundingBox AccSagittalAcute { get; set; }

        [JsonProperty("accSagittalDoubleFlat")]
        public BoundingBox AccSagittalDoubleFlat { get; set; }

        [JsonProperty("accSagittalDoubleFlat11v49CUp")]
        public BoundingBox AccSagittalDoubleFlat11V49CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat143CUp")]
        public BoundingBox AccSagittalDoubleFlat143CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat17CUp")]
        public BoundingBox AccSagittalDoubleFlat17CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat17kUp")]
        public BoundingBox AccSagittalDoubleFlat17KUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat19CUp")]
        public BoundingBox AccSagittalDoubleFlat19CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat19sUp")]
        public BoundingBox AccSagittalDoubleFlat19SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat23CUp")]
        public BoundingBox AccSagittalDoubleFlat23CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat23SUp")]
        public BoundingBox AccSagittalDoubleFlat23SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat25SUp")]
        public BoundingBox AccSagittalDoubleFlat25SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat49SUp")]
        public BoundingBox AccSagittalDoubleFlat49SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat55CUp")]
        public BoundingBox AccSagittalDoubleFlat55CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5CUp")]
        public BoundingBox AccSagittalDoubleFlat5CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5v11SUp")]
        public BoundingBox AccSagittalDoubleFlat5V11SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5v19CUp")]
        public BoundingBox AccSagittalDoubleFlat5V19CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5v23SUp")]
        public BoundingBox AccSagittalDoubleFlat5V23SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5v7kUp")]
        public BoundingBox AccSagittalDoubleFlat5V7KUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat7CUp")]
        public BoundingBox AccSagittalDoubleFlat7CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat7v11CUp")]
        public BoundingBox AccSagittalDoubleFlat7V11CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat7v11kUp")]
        public BoundingBox AccSagittalDoubleFlat7V11KUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat7v19CUp")]
        public BoundingBox AccSagittalDoubleFlat7V19CUp { get; set; }

        [JsonProperty("accSagittalDoubleSharp")]
        public BoundingBox AccSagittalDoubleSharp { get; set; }

        [JsonProperty("accSagittalDoubleSharp11v49CDown")]
        public BoundingBox AccSagittalDoubleSharp11V49CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp143CDown")]
        public BoundingBox AccSagittalDoubleSharp143CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp17CDown")]
        public BoundingBox AccSagittalDoubleSharp17CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp17kDown")]
        public BoundingBox AccSagittalDoubleSharp17KDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp19CDown")]
        public BoundingBox AccSagittalDoubleSharp19CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp19sDown")]
        public BoundingBox AccSagittalDoubleSharp19SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp23CDown")]
        public BoundingBox AccSagittalDoubleSharp23CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp23SDown")]
        public BoundingBox AccSagittalDoubleSharp23SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp25SDown")]
        public BoundingBox AccSagittalDoubleSharp25SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp49SDown")]
        public BoundingBox AccSagittalDoubleSharp49SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp55CDown")]
        public BoundingBox AccSagittalDoubleSharp55CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5CDown")]
        public BoundingBox AccSagittalDoubleSharp5CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5v11SDown")]
        public BoundingBox AccSagittalDoubleSharp5V11SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5v19CDown")]
        public BoundingBox AccSagittalDoubleSharp5V19CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5v23SDown")]
        public BoundingBox AccSagittalDoubleSharp5V23SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5v7kDown")]
        public BoundingBox AccSagittalDoubleSharp5V7KDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp7CDown")]
        public BoundingBox AccSagittalDoubleSharp7CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp7v11CDown")]
        public BoundingBox AccSagittalDoubleSharp7V11CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp7v11kDown")]
        public BoundingBox AccSagittalDoubleSharp7V11KDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp7v19CDown")]
        public BoundingBox AccSagittalDoubleSharp7V19CDown { get; set; }

        [JsonProperty("accSagittalFlat")]
        public BoundingBox AccSagittalFlat { get; set; }

        [JsonProperty("accSagittalFlat11LDown")]
        public BoundingBox AccSagittalFlat11LDown { get; set; }

        [JsonProperty("accSagittalFlat11MDown")]
        public BoundingBox AccSagittalFlat11MDown { get; set; }

        [JsonProperty("accSagittalFlat11v19LDown")]
        public BoundingBox AccSagittalFlat11V19LDown { get; set; }

        [JsonProperty("accSagittalFlat11v19MDown")]
        public BoundingBox AccSagittalFlat11V19MDown { get; set; }

        [JsonProperty("accSagittalFlat11v49CDown")]
        public BoundingBox AccSagittalFlat11V49CDown { get; set; }

        [JsonProperty("accSagittalFlat11v49CUp")]
        public BoundingBox AccSagittalFlat11V49CUp { get; set; }

        [JsonProperty("accSagittalFlat143CDown")]
        public BoundingBox AccSagittalFlat143CDown { get; set; }

        [JsonProperty("accSagittalFlat143CUp")]
        public BoundingBox AccSagittalFlat143CUp { get; set; }

        [JsonProperty("accSagittalFlat17CDown")]
        public BoundingBox AccSagittalFlat17CDown { get; set; }

        [JsonProperty("accSagittalFlat17CUp")]
        public BoundingBox AccSagittalFlat17CUp { get; set; }

        [JsonProperty("accSagittalFlat17kDown")]
        public BoundingBox AccSagittalFlat17KDown { get; set; }

        [JsonProperty("accSagittalFlat17kUp")]
        public BoundingBox AccSagittalFlat17KUp { get; set; }

        [JsonProperty("accSagittalFlat19CDown")]
        public BoundingBox AccSagittalFlat19CDown { get; set; }

        [JsonProperty("accSagittalFlat19CUp")]
        public BoundingBox AccSagittalFlat19CUp { get; set; }

        [JsonProperty("accSagittalFlat19sDown")]
        public BoundingBox AccSagittalFlat19SDown { get; set; }

        [JsonProperty("accSagittalFlat19sUp")]
        public BoundingBox AccSagittalFlat19SUp { get; set; }

        [JsonProperty("accSagittalFlat23CDown")]
        public BoundingBox AccSagittalFlat23CDown { get; set; }

        [JsonProperty("accSagittalFlat23CUp")]
        public BoundingBox AccSagittalFlat23CUp { get; set; }

        [JsonProperty("accSagittalFlat23SDown")]
        public BoundingBox AccSagittalFlat23SDown { get; set; }

        [JsonProperty("accSagittalFlat23SUp")]
        public BoundingBox AccSagittalFlat23SUp { get; set; }

        [JsonProperty("accSagittalFlat25SDown")]
        public BoundingBox AccSagittalFlat25SDown { get; set; }

        [JsonProperty("accSagittalFlat25SUp")]
        public BoundingBox AccSagittalFlat25SUp { get; set; }

        [JsonProperty("accSagittalFlat35LDown")]
        public BoundingBox AccSagittalFlat35LDown { get; set; }

        [JsonProperty("accSagittalFlat35MDown")]
        public BoundingBox AccSagittalFlat35MDown { get; set; }

        [JsonProperty("accSagittalFlat49LDown")]
        public BoundingBox AccSagittalFlat49LDown { get; set; }

        [JsonProperty("accSagittalFlat49MDown")]
        public BoundingBox AccSagittalFlat49MDown { get; set; }

        [JsonProperty("accSagittalFlat49SDown")]
        public BoundingBox AccSagittalFlat49SDown { get; set; }

        [JsonProperty("accSagittalFlat49SUp")]
        public BoundingBox AccSagittalFlat49SUp { get; set; }

        [JsonProperty("accSagittalFlat55CDown")]
        public BoundingBox AccSagittalFlat55CDown { get; set; }

        [JsonProperty("accSagittalFlat55CUp")]
        public BoundingBox AccSagittalFlat55CUp { get; set; }

        [JsonProperty("accSagittalFlat5CDown")]
        public BoundingBox AccSagittalFlat5CDown { get; set; }

        [JsonProperty("accSagittalFlat5CUp")]
        public BoundingBox AccSagittalFlat5CUp { get; set; }

        [JsonProperty("accSagittalFlat5v11SDown")]
        public BoundingBox AccSagittalFlat5V11SDown { get; set; }

        [JsonProperty("accSagittalFlat5v11SUp")]
        public BoundingBox AccSagittalFlat5V11SUp { get; set; }

        [JsonProperty("accSagittalFlat5v13LDown")]
        public BoundingBox AccSagittalFlat5V13LDown { get; set; }

        [JsonProperty("accSagittalFlat5v13MDown")]
        public BoundingBox AccSagittalFlat5V13MDown { get; set; }

        [JsonProperty("accSagittalFlat5v19CDown")]
        public BoundingBox AccSagittalFlat5V19CDown { get; set; }

        [JsonProperty("accSagittalFlat5v19CUp")]
        public BoundingBox AccSagittalFlat5V19CUp { get; set; }

        [JsonProperty("accSagittalFlat5v23SDown")]
        public BoundingBox AccSagittalFlat5V23SDown { get; set; }

        [JsonProperty("accSagittalFlat5v23SUp")]
        public BoundingBox AccSagittalFlat5V23SUp { get; set; }

        [JsonProperty("accSagittalFlat5v49MDown")]
        public BoundingBox AccSagittalFlat5V49MDown { get; set; }

        [JsonProperty("accSagittalFlat5v7kDown")]
        public BoundingBox AccSagittalFlat5V7KDown { get; set; }

        [JsonProperty("accSagittalFlat5v7kUp")]
        public BoundingBox AccSagittalFlat5V7KUp { get; set; }

        [JsonProperty("accSagittalFlat7CDown")]
        public BoundingBox AccSagittalFlat7CDown { get; set; }

        [JsonProperty("accSagittalFlat7CUp")]
        public BoundingBox AccSagittalFlat7CUp { get; set; }

        [JsonProperty("accSagittalFlat7v11CDown")]
        public BoundingBox AccSagittalFlat7V11CDown { get; set; }

        [JsonProperty("accSagittalFlat7v11CUp")]
        public BoundingBox AccSagittalFlat7V11CUp { get; set; }

        [JsonProperty("accSagittalFlat7v11kDown")]
        public BoundingBox AccSagittalFlat7V11KDown { get; set; }

        [JsonProperty("accSagittalFlat7v11kUp")]
        public BoundingBox AccSagittalFlat7V11KUp { get; set; }

        [JsonProperty("accSagittalFlat7v19CDown")]
        public BoundingBox AccSagittalFlat7V19CDown { get; set; }

        [JsonProperty("accSagittalFlat7v19CUp")]
        public BoundingBox AccSagittalFlat7V19CUp { get; set; }

        [JsonProperty("accSagittalGrave")]
        public BoundingBox AccSagittalGrave { get; set; }

        [JsonProperty("accSagittalShaftDown")]
        public BoundingBox AccSagittalShaftDown { get; set; }

        [JsonProperty("accSagittalShaftUp")]
        public BoundingBox AccSagittalShaftUp { get; set; }

        [JsonProperty("accSagittalSharp")]
        public BoundingBox AccSagittalSharp { get; set; }

        [JsonProperty("accSagittalSharp11LUp")]
        public BoundingBox AccSagittalSharp11LUp { get; set; }

        [JsonProperty("accSagittalSharp11MUp")]
        public BoundingBox AccSagittalSharp11MUp { get; set; }

        [JsonProperty("accSagittalSharp11v19LUp")]
        public BoundingBox AccSagittalSharp11V19LUp { get; set; }

        [JsonProperty("accSagittalSharp11v19MUp")]
        public BoundingBox AccSagittalSharp11V19MUp { get; set; }

        [JsonProperty("accSagittalSharp11v49CDown")]
        public BoundingBox AccSagittalSharp11V49CDown { get; set; }

        [JsonProperty("accSagittalSharp11v49CUp")]
        public BoundingBox AccSagittalSharp11V49CUp { get; set; }

        [JsonProperty("accSagittalSharp143CDown")]
        public BoundingBox AccSagittalSharp143CDown { get; set; }

        [JsonProperty("accSagittalSharp143CUp")]
        public BoundingBox AccSagittalSharp143CUp { get; set; }

        [JsonProperty("accSagittalSharp17CDown")]
        public BoundingBox AccSagittalSharp17CDown { get; set; }

        [JsonProperty("accSagittalSharp17CUp")]
        public BoundingBox AccSagittalSharp17CUp { get; set; }

        [JsonProperty("accSagittalSharp17kDown")]
        public BoundingBox AccSagittalSharp17KDown { get; set; }

        [JsonProperty("accSagittalSharp17kUp")]
        public BoundingBox AccSagittalSharp17KUp { get; set; }

        [JsonProperty("accSagittalSharp19CDown")]
        public BoundingBox AccSagittalSharp19CDown { get; set; }

        [JsonProperty("accSagittalSharp19CUp")]
        public BoundingBox AccSagittalSharp19CUp { get; set; }

        [JsonProperty("accSagittalSharp19sDown")]
        public BoundingBox AccSagittalSharp19SDown { get; set; }

        [JsonProperty("accSagittalSharp19sUp")]
        public BoundingBox AccSagittalSharp19SUp { get; set; }

        [JsonProperty("accSagittalSharp23CDown")]
        public BoundingBox AccSagittalSharp23CDown { get; set; }

        [JsonProperty("accSagittalSharp23CUp")]
        public BoundingBox AccSagittalSharp23CUp { get; set; }

        [JsonProperty("accSagittalSharp23SDown")]
        public BoundingBox AccSagittalSharp23SDown { get; set; }

        [JsonProperty("accSagittalSharp23SUp")]
        public BoundingBox AccSagittalSharp23SUp { get; set; }

        [JsonProperty("accSagittalSharp25SDown")]
        public BoundingBox AccSagittalSharp25SDown { get; set; }

        [JsonProperty("accSagittalSharp25SUp")]
        public BoundingBox AccSagittalSharp25SUp { get; set; }

        [JsonProperty("accSagittalSharp35LUp")]
        public BoundingBox AccSagittalSharp35LUp { get; set; }

        [JsonProperty("accSagittalSharp35MUp")]
        public BoundingBox AccSagittalSharp35MUp { get; set; }

        [JsonProperty("accSagittalSharp49LUp")]
        public BoundingBox AccSagittalSharp49LUp { get; set; }

        [JsonProperty("accSagittalSharp49MUp")]
        public BoundingBox AccSagittalSharp49MUp { get; set; }

        [JsonProperty("accSagittalSharp49SDown")]
        public BoundingBox AccSagittalSharp49SDown { get; set; }

        [JsonProperty("accSagittalSharp49SUp")]
        public BoundingBox AccSagittalSharp49SUp { get; set; }

        [JsonProperty("accSagittalSharp55CDown")]
        public BoundingBox AccSagittalSharp55CDown { get; set; }

        [JsonProperty("accSagittalSharp55CUp")]
        public BoundingBox AccSagittalSharp55CUp { get; set; }

        [JsonProperty("accSagittalSharp5CDown")]
        public BoundingBox AccSagittalSharp5CDown { get; set; }

        [JsonProperty("accSagittalSharp5CUp")]
        public BoundingBox AccSagittalSharp5CUp { get; set; }

        [JsonProperty("accSagittalSharp5v11SDown")]
        public BoundingBox AccSagittalSharp5V11SDown { get; set; }

        [JsonProperty("accSagittalSharp5v11SUp")]
        public BoundingBox AccSagittalSharp5V11SUp { get; set; }

        [JsonProperty("accSagittalSharp5v13LUp")]
        public BoundingBox AccSagittalSharp5V13LUp { get; set; }

        [JsonProperty("accSagittalSharp5v13MUp")]
        public BoundingBox AccSagittalSharp5V13MUp { get; set; }

        [JsonProperty("accSagittalSharp5v19CDown")]
        public BoundingBox AccSagittalSharp5V19CDown { get; set; }

        [JsonProperty("accSagittalSharp5v19CUp")]
        public BoundingBox AccSagittalSharp5V19CUp { get; set; }

        [JsonProperty("accSagittalSharp5v23SDown")]
        public BoundingBox AccSagittalSharp5V23SDown { get; set; }

        [JsonProperty("accSagittalSharp5v23SUp")]
        public BoundingBox AccSagittalSharp5V23SUp { get; set; }

        [JsonProperty("accSagittalSharp5v49MUp")]
        public BoundingBox AccSagittalSharp5V49MUp { get; set; }

        [JsonProperty("accSagittalSharp5v7kDown")]
        public BoundingBox AccSagittalSharp5V7KDown { get; set; }

        [JsonProperty("accSagittalSharp5v7kUp")]
        public BoundingBox AccSagittalSharp5V7KUp { get; set; }

        [JsonProperty("accSagittalSharp7CDown")]
        public BoundingBox AccSagittalSharp7CDown { get; set; }

        [JsonProperty("accSagittalSharp7CUp")]
        public BoundingBox AccSagittalSharp7CUp { get; set; }

        [JsonProperty("accSagittalSharp7v11CDown")]
        public BoundingBox AccSagittalSharp7V11CDown { get; set; }

        [JsonProperty("accSagittalSharp7v11CUp")]
        public BoundingBox AccSagittalSharp7V11CUp { get; set; }

        [JsonProperty("accSagittalSharp7v11kDown")]
        public BoundingBox AccSagittalSharp7V11KDown { get; set; }

        [JsonProperty("accSagittalSharp7v11kUp")]
        public BoundingBox AccSagittalSharp7V11KUp { get; set; }

        [JsonProperty("accSagittalSharp7v19CDown")]
        public BoundingBox AccSagittalSharp7V19CDown { get; set; }

        [JsonProperty("accSagittalSharp7v19CUp")]
        public BoundingBox AccSagittalSharp7V19CUp { get; set; }

        [JsonProperty("accdnCombDot")]
        public BoundingBox AccdnCombDot { get; set; }

        [JsonProperty("accdnCombLH2RanksEmpty")]
        public BoundingBox AccdnCombLh2RanksEmpty { get; set; }

        [JsonProperty("accdnCombLH3RanksEmptySquare")]
        public BoundingBox AccdnCombLh3RanksEmptySquare { get; set; }

        [JsonProperty("accdnCombRH3RanksEmpty")]
        public BoundingBox AccdnCombRh3RanksEmpty { get; set; }

        [JsonProperty("accdnCombRH4RanksEmpty")]
        public BoundingBox AccdnCombRh4RanksEmpty { get; set; }

        [JsonProperty("accdnDiatonicClef")]
        public BoundingBox AccdnDiatonicClef { get; set; }

        [JsonProperty("accdnLH2Ranks16Round")]
        public BoundingBox AccdnLh2Ranks16Round { get; set; }

        [JsonProperty("accdnLH2Ranks8Plus16Round")]
        public BoundingBox AccdnLh2Ranks8Plus16Round { get; set; }

        [JsonProperty("accdnLH2Ranks8Round")]
        public BoundingBox AccdnLh2Ranks8Round { get; set; }

        [JsonProperty("accdnLH2RanksFullMasterRound")]
        public BoundingBox AccdnLh2RanksFullMasterRound { get; set; }

        [JsonProperty("accdnLH2RanksMasterPlus16Round")]
        public BoundingBox AccdnLh2RanksMasterPlus16Round { get; set; }

        [JsonProperty("accdnLH2RanksMasterRound")]
        public BoundingBox AccdnLh2RanksMasterRound { get; set; }

        [JsonProperty("accdnLH3Ranks2Plus8Square")]
        public BoundingBox AccdnLh3Ranks2Plus8Square { get; set; }

        [JsonProperty("accdnLH3Ranks2Square")]
        public BoundingBox AccdnLh3Ranks2Square { get; set; }

        [JsonProperty("accdnLH3Ranks8Square")]
        public BoundingBox AccdnLh3Ranks8Square { get; set; }

        [JsonProperty("accdnLH3RanksDouble8Square")]
        public BoundingBox AccdnLh3RanksDouble8Square { get; set; }

        [JsonProperty("accdnLH3RanksTuttiSquare")]
        public BoundingBox AccdnLh3RanksTuttiSquare { get; set; }

        [JsonProperty("accdnPull")]
        public BoundingBox AccdnPull { get; set; }

        [JsonProperty("accdnPush")]
        public BoundingBox AccdnPush { get; set; }

        [JsonProperty("accdnPushAlt")]
        public BoundingBox AccdnPushAlt { get; set; }

        [JsonProperty("accdnRH3RanksAccordion")]
        public BoundingBox AccdnRh3RanksAccordion { get; set; }

        [JsonProperty("accdnRH3RanksAuthenticMusette")]
        public BoundingBox AccdnRh3RanksAuthenticMusette { get; set; }

        [JsonProperty("accdnRH3RanksBandoneon")]
        public BoundingBox AccdnRh3RanksBandoneon { get; set; }

        [JsonProperty("accdnRH3RanksBassoon")]
        public BoundingBox AccdnRh3RanksBassoon { get; set; }

        [JsonProperty("accdnRH3RanksClarinet")]
        public BoundingBox AccdnRh3RanksClarinet { get; set; }

        [JsonProperty("accdnRH3RanksDoubleTremoloLower8ve")]
        public BoundingBox AccdnRh3RanksDoubleTremoloLower8Ve { get; set; }

        [JsonProperty("accdnRH3RanksDoubleTremoloUpper8ve")]
        public BoundingBox AccdnRh3RanksDoubleTremoloUpper8Ve { get; set; }

        [JsonProperty("accdnRH3RanksFullFactory")]
        public BoundingBox AccdnRh3RanksFullFactory { get; set; }

        [JsonProperty("accdnRH3RanksHarmonium")]
        public BoundingBox AccdnRh3RanksHarmonium { get; set; }

        [JsonProperty("accdnRH3RanksImitationMusette")]
        public BoundingBox AccdnRh3RanksImitationMusette { get; set; }

        [JsonProperty("accdnRH3RanksLowerTremolo8")]
        public BoundingBox AccdnRh3RanksLowerTremolo8 { get; set; }

        [JsonProperty("accdnRH3RanksMaster")]
        public BoundingBox AccdnRh3RanksMaster { get; set; }

        [JsonProperty("accdnRH3RanksOboe")]
        public BoundingBox AccdnRh3RanksOboe { get; set; }

        [JsonProperty("accdnRH3RanksOrgan")]
        public BoundingBox AccdnRh3RanksOrgan { get; set; }

        [JsonProperty("accdnRH3RanksPiccolo")]
        public BoundingBox AccdnRh3RanksPiccolo { get; set; }

        [JsonProperty("accdnRH3RanksTremoloLower8ve")]
        public BoundingBox AccdnRh3RanksTremoloLower8Ve { get; set; }

        [JsonProperty("accdnRH3RanksTremoloUpper8ve")]
        public BoundingBox AccdnRh3RanksTremoloUpper8Ve { get; set; }

        [JsonProperty("accdnRH3RanksTwoChoirs")]
        public BoundingBox AccdnRh3RanksTwoChoirs { get; set; }

        [JsonProperty("accdnRH3RanksUpperTremolo8")]
        public BoundingBox AccdnRh3RanksUpperTremolo8 { get; set; }

        [JsonProperty("accdnRH3RanksViolin")]
        public BoundingBox AccdnRh3RanksViolin { get; set; }

        [JsonProperty("accdnRH4RanksAlto")]
        public BoundingBox AccdnRh4RanksAlto { get; set; }

        [JsonProperty("accdnRH4RanksBassAlto")]
        public BoundingBox AccdnRh4RanksBassAlto { get; set; }

        [JsonProperty("accdnRH4RanksMaster")]
        public BoundingBox AccdnRh4RanksMaster { get; set; }

        [JsonProperty("accdnRH4RanksSoftBass")]
        public BoundingBox AccdnRh4RanksSoftBass { get; set; }

        [JsonProperty("accdnRH4RanksSoftTenor")]
        public BoundingBox AccdnRh4RanksSoftTenor { get; set; }

        [JsonProperty("accdnRH4RanksSoprano")]
        public BoundingBox AccdnRh4RanksSoprano { get; set; }

        [JsonProperty("accdnRH4RanksTenor")]
        public BoundingBox AccdnRh4RanksTenor { get; set; }

        [JsonProperty("accdnRicochet2")]
        public BoundingBox AccdnRicochet2 { get; set; }

        [JsonProperty("accdnRicochet3")]
        public BoundingBox AccdnRicochet3 { get; set; }

        [JsonProperty("accdnRicochet4")]
        public BoundingBox AccdnRicochet4 { get; set; }

        [JsonProperty("accdnRicochet5")]
        public BoundingBox AccdnRicochet5 { get; set; }

        [JsonProperty("accdnRicochet6")]
        public BoundingBox AccdnRicochet6 { get; set; }

        [JsonProperty("accdnRicochetStem2")]
        public BoundingBox AccdnRicochetStem2 { get; set; }

        [JsonProperty("accdnRicochetStem3")]
        public BoundingBox AccdnRicochetStem3 { get; set; }

        [JsonProperty("accdnRicochetStem4")]
        public BoundingBox AccdnRicochetStem4 { get; set; }

        [JsonProperty("accdnRicochetStem5")]
        public BoundingBox AccdnRicochetStem5 { get; set; }

        [JsonProperty("accdnRicochetStem6")]
        public BoundingBox AccdnRicochetStem6 { get; set; }

        [JsonProperty("accidental1CommaFlat")]
        public BoundingBox Accidental1CommaFlat { get; set; }

        [JsonProperty("accidental1CommaSharp")]
        public BoundingBox Accidental1CommaSharp { get; set; }

        [JsonProperty("accidental2CommaFlat")]
        public BoundingBox Accidental2CommaFlat { get; set; }

        [JsonProperty("accidental2CommaSharp")]
        public BoundingBox Accidental2CommaSharp { get; set; }

        [JsonProperty("accidental3CommaFlat")]
        public BoundingBox Accidental3CommaFlat { get; set; }

        [JsonProperty("accidental3CommaSharp")]
        public BoundingBox Accidental3CommaSharp { get; set; }

        [JsonProperty("accidental4CommaFlat")]
        public BoundingBox Accidental4CommaFlat { get; set; }

        [JsonProperty("accidental5CommaSharp")]
        public BoundingBox Accidental5CommaSharp { get; set; }

        [JsonProperty("accidentalArrowDown")]
        public BoundingBox AccidentalArrowDown { get; set; }

        [JsonProperty("accidentalArrowUp")]
        public BoundingBox AccidentalArrowUp { get; set; }

        [JsonProperty("accidentalBakiyeFlat")]
        public BoundingBox AccidentalBakiyeFlat { get; set; }

        [JsonProperty("accidentalBakiyeSharp")]
        public BoundingBox AccidentalBakiyeSharp { get; set; }

        [JsonProperty("accidentalBracketLeft")]
        public BoundingBox AccidentalBracketLeft { get; set; }

        [JsonProperty("accidentalBracketRight")]
        public BoundingBox AccidentalBracketRight { get; set; }

        [JsonProperty("accidentalBuyukMucennebFlat")]
        public BoundingBox AccidentalBuyukMucennebFlat { get; set; }

        [JsonProperty("accidentalBuyukMucennebSharp")]
        public BoundingBox AccidentalBuyukMucennebSharp { get; set; }

        [JsonProperty("accidentalCombiningCloseCurlyBrace")]
        public BoundingBox AccidentalCombiningCloseCurlyBrace { get; set; }

        [JsonProperty("accidentalCombiningLower17Schisma")]
        public BoundingBox AccidentalCombiningLower17Schisma { get; set; }

        [JsonProperty("accidentalCombiningLower19Schisma")]
        public BoundingBox AccidentalCombiningLower19Schisma { get; set; }

        [JsonProperty("accidentalCombiningLower23Limit29LimitComma")]
        public BoundingBox AccidentalCombiningLower23Limit29LimitComma { get; set; }

        [JsonProperty("accidentalCombiningLower31Schisma")]
        public BoundingBox AccidentalCombiningLower31Schisma { get; set; }

        [JsonProperty("accidentalCombiningLower53LimitComma")]
        public BoundingBox AccidentalCombiningLower53LimitComma { get; set; }

        [JsonProperty("accidentalCombiningOpenCurlyBrace")]
        public BoundingBox AccidentalCombiningOpenCurlyBrace { get; set; }

        [JsonProperty("accidentalCombiningRaise17Schisma")]
        public BoundingBox AccidentalCombiningRaise17Schisma { get; set; }

        [JsonProperty("accidentalCombiningRaise19Schisma")]
        public BoundingBox AccidentalCombiningRaise19Schisma { get; set; }

        [JsonProperty("accidentalCombiningRaise23Limit29LimitComma")]
        public BoundingBox AccidentalCombiningRaise23Limit29LimitComma { get; set; }

        [JsonProperty("accidentalCombiningRaise31Schisma")]
        public BoundingBox AccidentalCombiningRaise31Schisma { get; set; }

        [JsonProperty("accidentalCombiningRaise53LimitComma")]
        public BoundingBox AccidentalCombiningRaise53LimitComma { get; set; }

        [JsonProperty("accidentalCommaSlashDown")]
        public BoundingBox AccidentalCommaSlashDown { get; set; }

        [JsonProperty("accidentalCommaSlashUp")]
        public BoundingBox AccidentalCommaSlashUp { get; set; }

        [JsonProperty("accidentalDoubleFlat")]
        public BoundingBox AccidentalDoubleFlat { get; set; }

        [JsonProperty("accidentalDoubleFlatArabic")]
        public BoundingBox AccidentalDoubleFlatArabic { get; set; }

        [JsonProperty("accidentalDoubleFlatEqualTempered")]
        public BoundingBox AccidentalDoubleFlatEqualTempered { get; set; }

        [JsonProperty("accidentalDoubleFlatJoinedStems")]
        public BoundingBox AccidentalDoubleFlatJoinedStems { get; set; }

        [JsonProperty("accidentalDoubleFlatOneArrowDown")]
        public BoundingBox AccidentalDoubleFlatOneArrowDown { get; set; }

        [JsonProperty("accidentalDoubleFlatOneArrowUp")]
        public BoundingBox AccidentalDoubleFlatOneArrowUp { get; set; }

        [JsonProperty("accidentalDoubleFlatParens")]
        public BoundingBox AccidentalDoubleFlatParens { get; set; }

        [JsonProperty("accidentalDoubleFlatReversed")]
        public BoundingBox AccidentalDoubleFlatReversed { get; set; }

        [JsonProperty("accidentalDoubleFlatThreeArrowsDown")]
        public BoundingBox AccidentalDoubleFlatThreeArrowsDown { get; set; }

        [JsonProperty("accidentalDoubleFlatThreeArrowsUp")]
        public BoundingBox AccidentalDoubleFlatThreeArrowsUp { get; set; }

        [JsonProperty("accidentalDoubleFlatTurned")]
        public BoundingBox AccidentalDoubleFlatTurned { get; set; }

        [JsonProperty("accidentalDoubleFlatTwoArrowsDown")]
        public BoundingBox AccidentalDoubleFlatTwoArrowsDown { get; set; }

        [JsonProperty("accidentalDoubleFlatTwoArrowsUp")]
        public BoundingBox AccidentalDoubleFlatTwoArrowsUp { get; set; }

        [JsonProperty("accidentalDoubleSharp")]
        public BoundingBox AccidentalDoubleSharp { get; set; }

        [JsonProperty("accidentalDoubleSharpArabic")]
        public BoundingBox AccidentalDoubleSharpArabic { get; set; }

        [JsonProperty("accidentalDoubleSharpEqualTempered")]
        public BoundingBox AccidentalDoubleSharpEqualTempered { get; set; }

        [JsonProperty("accidentalDoubleSharpOneArrowDown")]
        public BoundingBox AccidentalDoubleSharpOneArrowDown { get; set; }

        [JsonProperty("accidentalDoubleSharpOneArrowUp")]
        public BoundingBox AccidentalDoubleSharpOneArrowUp { get; set; }

        [JsonProperty("accidentalDoubleSharpParens")]
        public BoundingBox AccidentalDoubleSharpParens { get; set; }

        [JsonProperty("accidentalDoubleSharpThreeArrowsDown")]
        public BoundingBox AccidentalDoubleSharpThreeArrowsDown { get; set; }

        [JsonProperty("accidentalDoubleSharpThreeArrowsUp")]
        public BoundingBox AccidentalDoubleSharpThreeArrowsUp { get; set; }

        [JsonProperty("accidentalDoubleSharpTwoArrowsDown")]
        public BoundingBox AccidentalDoubleSharpTwoArrowsDown { get; set; }

        [JsonProperty("accidentalDoubleSharpTwoArrowsUp")]
        public BoundingBox AccidentalDoubleSharpTwoArrowsUp { get; set; }

        [JsonProperty("accidentalEnharmonicAlmostEqualTo")]
        public BoundingBox AccidentalEnharmonicAlmostEqualTo { get; set; }

        [JsonProperty("accidentalEnharmonicEquals")]
        public BoundingBox AccidentalEnharmonicEquals { get; set; }

        [JsonProperty("accidentalEnharmonicTilde")]
        public BoundingBox AccidentalEnharmonicTilde { get; set; }

        [JsonProperty("accidentalFilledReversedFlatAndFlat")]
        public BoundingBox AccidentalFilledReversedFlatAndFlat { get; set; }

        [JsonProperty("accidentalFilledReversedFlatAndFlatArrowDown")]
        public BoundingBox AccidentalFilledReversedFlatAndFlatArrowDown { get; set; }

        [JsonProperty("accidentalFilledReversedFlatAndFlatArrowUp")]
        public BoundingBox AccidentalFilledReversedFlatAndFlatArrowUp { get; set; }

        [JsonProperty("accidentalFilledReversedFlatArrowDown")]
        public BoundingBox AccidentalFilledReversedFlatArrowDown { get; set; }

        [JsonProperty("accidentalFilledReversedFlatArrowUp")]
        public BoundingBox AccidentalFilledReversedFlatArrowUp { get; set; }

        [JsonProperty("accidentalFiveQuarterTonesFlatArrowDown")]
        public BoundingBox AccidentalFiveQuarterTonesFlatArrowDown { get; set; }

        [JsonProperty("accidentalFiveQuarterTonesSharpArrowUp")]
        public BoundingBox AccidentalFiveQuarterTonesSharpArrowUp { get; set; }

        [JsonProperty("accidentalFlat")]
        public BoundingBox AccidentalFlat { get; set; }

        [JsonProperty("accidentalFlatArabic")]
        public BoundingBox AccidentalFlatArabic { get; set; }

        [JsonProperty("accidentalFlatEqualTempered")]
        public BoundingBox AccidentalFlatEqualTempered { get; set; }

        [JsonProperty("accidentalFlatJohnstonDown")]
        public BoundingBox AccidentalFlatJohnstonDown { get; set; }

        [JsonProperty("accidentalFlatJohnstonEl")]
        public BoundingBox AccidentalFlatJohnstonEl { get; set; }

        [JsonProperty("accidentalFlatJohnstonElDown")]
        public BoundingBox AccidentalFlatJohnstonElDown { get; set; }

        [JsonProperty("accidentalFlatJohnstonUp")]
        public BoundingBox AccidentalFlatJohnstonUp { get; set; }

        [JsonProperty("accidentalFlatJohnstonUpEl")]
        public BoundingBox AccidentalFlatJohnstonUpEl { get; set; }

        [JsonProperty("accidentalFlatLoweredStockhausen")]
        public BoundingBox AccidentalFlatLoweredStockhausen { get; set; }

        [JsonProperty("accidentalFlatOneArrowDown")]
        public BoundingBox AccidentalFlatOneArrowDown { get; set; }

        [JsonProperty("accidentalFlatOneArrowUp")]
        public BoundingBox AccidentalFlatOneArrowUp { get; set; }

        [JsonProperty("accidentalFlatParens")]
        public BoundingBox AccidentalFlatParens { get; set; }

        [JsonProperty("accidentalFlatRaisedStockhausen")]
        public BoundingBox AccidentalFlatRaisedStockhausen { get; set; }

        [JsonProperty("accidentalFlatRepeatedLineStockhausen")]
        public BoundingBox AccidentalFlatRepeatedLineStockhausen { get; set; }

        [JsonProperty("accidentalFlatRepeatedSpaceStockhausen")]
        public BoundingBox AccidentalFlatRepeatedSpaceStockhausen { get; set; }

        [JsonProperty("accidentalFlatSmall")]
        public BoundingBox AccidentalFlatSmall { get; set; }

        [JsonProperty("accidentalFlatThreeArrowsDown")]
        public BoundingBox AccidentalFlatThreeArrowsDown { get; set; }

        [JsonProperty("accidentalFlatThreeArrowsUp")]
        public BoundingBox AccidentalFlatThreeArrowsUp { get; set; }

        [JsonProperty("accidentalFlatTurned")]
        public BoundingBox AccidentalFlatTurned { get; set; }

        [JsonProperty("accidentalFlatTwoArrowsDown")]
        public BoundingBox AccidentalFlatTwoArrowsDown { get; set; }

        [JsonProperty("accidentalFlatTwoArrowsUp")]
        public BoundingBox AccidentalFlatTwoArrowsUp { get; set; }

        [JsonProperty("accidentalHalfSharpArrowDown")]
        public BoundingBox AccidentalHalfSharpArrowDown { get; set; }

        [JsonProperty("accidentalHalfSharpArrowUp")]
        public BoundingBox AccidentalHalfSharpArrowUp { get; set; }

        [JsonProperty("accidentalJohnston13")]
        public BoundingBox AccidentalJohnston13 { get; set; }

        [JsonProperty("accidentalJohnston31")]
        public BoundingBox AccidentalJohnston31 { get; set; }

        [JsonProperty("accidentalJohnstonDown")]
        public BoundingBox AccidentalJohnstonDown { get; set; }

        [JsonProperty("accidentalJohnstonDownEl")]
        public BoundingBox AccidentalJohnstonDownEl { get; set; }

        [JsonProperty("accidentalJohnstonEl")]
        public BoundingBox AccidentalJohnstonEl { get; set; }

        [JsonProperty("accidentalJohnstonMinus")]
        public BoundingBox AccidentalJohnstonMinus { get; set; }

        [JsonProperty("accidentalJohnstonPlus")]
        public BoundingBox AccidentalJohnstonPlus { get; set; }

        [JsonProperty("accidentalJohnstonSeven")]
        public BoundingBox AccidentalJohnstonSeven { get; set; }

        [JsonProperty("accidentalJohnstonSevenDown")]
        public BoundingBox AccidentalJohnstonSevenDown { get; set; }

        [JsonProperty("accidentalJohnstonSevenFlat")]
        public BoundingBox AccidentalJohnstonSevenFlat { get; set; }

        [JsonProperty("accidentalJohnstonSevenFlatDown")]
        public BoundingBox AccidentalJohnstonSevenFlatDown { get; set; }

        [JsonProperty("accidentalJohnstonSevenFlatUp")]
        public BoundingBox AccidentalJohnstonSevenFlatUp { get; set; }

        [JsonProperty("accidentalJohnstonSevenSharp")]
        public BoundingBox AccidentalJohnstonSevenSharp { get; set; }

        [JsonProperty("accidentalJohnstonSevenSharpDown")]
        public BoundingBox AccidentalJohnstonSevenSharpDown { get; set; }

        [JsonProperty("accidentalJohnstonSevenSharpUp")]
        public BoundingBox AccidentalJohnstonSevenSharpUp { get; set; }

        [JsonProperty("accidentalJohnstonSevenUp")]
        public BoundingBox AccidentalJohnstonSevenUp { get; set; }

        [JsonProperty("accidentalJohnstonUp")]
        public BoundingBox AccidentalJohnstonUp { get; set; }

        [JsonProperty("accidentalJohnstonUpEl")]
        public BoundingBox AccidentalJohnstonUpEl { get; set; }

        [JsonProperty("accidentalKomaFlat")]
        public BoundingBox AccidentalKomaFlat { get; set; }

        [JsonProperty("accidentalKomaSharp")]
        public BoundingBox AccidentalKomaSharp { get; set; }

        [JsonProperty("accidentalKoron")]
        public BoundingBox AccidentalKoron { get; set; }

        [JsonProperty("accidentalKucukMucennebFlat")]
        public BoundingBox AccidentalKucukMucennebFlat { get; set; }

        [JsonProperty("accidentalKucukMucennebSharp")]
        public BoundingBox AccidentalKucukMucennebSharp { get; set; }

        [JsonProperty("accidentalLargeDoubleSharp")]
        public BoundingBox AccidentalLargeDoubleSharp { get; set; }

        [JsonProperty("accidentalLowerOneSeptimalComma")]
        public BoundingBox AccidentalLowerOneSeptimalComma { get; set; }

        [JsonProperty("accidentalLowerOneTridecimalQuartertone")]
        public BoundingBox AccidentalLowerOneTridecimalQuartertone { get; set; }

        [JsonProperty("accidentalLowerOneUndecimalQuartertone")]
        public BoundingBox AccidentalLowerOneUndecimalQuartertone { get; set; }

        [JsonProperty("accidentalLowerTwoSeptimalCommas")]
        public BoundingBox AccidentalLowerTwoSeptimalCommas { get; set; }

        [JsonProperty("accidentalLoweredStockhausen")]
        public BoundingBox AccidentalLoweredStockhausen { get; set; }

        [JsonProperty("accidentalNarrowReversedFlat")]
        public BoundingBox AccidentalNarrowReversedFlat { get; set; }

        [JsonProperty("accidentalNarrowReversedFlatAndFlat")]
        public BoundingBox AccidentalNarrowReversedFlatAndFlat { get; set; }

        [JsonProperty("accidentalNatural")]
        public BoundingBox AccidentalNatural { get; set; }

        [JsonProperty("accidentalNaturalArabic")]
        public BoundingBox AccidentalNaturalArabic { get; set; }

        [JsonProperty("accidentalNaturalEqualTempered")]
        public BoundingBox AccidentalNaturalEqualTempered { get; set; }

        [JsonProperty("accidentalNaturalFlat")]
        public BoundingBox AccidentalNaturalFlat { get; set; }

        [JsonProperty("accidentalNaturalLoweredStockhausen")]
        public BoundingBox AccidentalNaturalLoweredStockhausen { get; set; }

        [JsonProperty("accidentalNaturalOneArrowDown")]
        public BoundingBox AccidentalNaturalOneArrowDown { get; set; }

        [JsonProperty("accidentalNaturalOneArrowUp")]
        public BoundingBox AccidentalNaturalOneArrowUp { get; set; }

        [JsonProperty("accidentalNaturalParens")]
        public BoundingBox AccidentalNaturalParens { get; set; }

        [JsonProperty("accidentalNaturalRaisedStockhausen")]
        public BoundingBox AccidentalNaturalRaisedStockhausen { get; set; }

        [JsonProperty("accidentalNaturalReversed")]
        public BoundingBox AccidentalNaturalReversed { get; set; }

        [JsonProperty("accidentalNaturalSharp")]
        public BoundingBox AccidentalNaturalSharp { get; set; }

        [JsonProperty("accidentalNaturalSmall")]
        public BoundingBox AccidentalNaturalSmall { get; set; }

        [JsonProperty("accidentalNaturalThreeArrowsDown")]
        public BoundingBox AccidentalNaturalThreeArrowsDown { get; set; }

        [JsonProperty("accidentalNaturalThreeArrowsUp")]
        public BoundingBox AccidentalNaturalThreeArrowsUp { get; set; }

        [JsonProperty("accidentalNaturalTwoArrowsDown")]
        public BoundingBox AccidentalNaturalTwoArrowsDown { get; set; }

        [JsonProperty("accidentalNaturalTwoArrowsUp")]
        public BoundingBox AccidentalNaturalTwoArrowsUp { get; set; }

        [JsonProperty("accidentalOneAndAHalfSharpsArrowDown")]
        public BoundingBox AccidentalOneAndAHalfSharpsArrowDown { get; set; }

        [JsonProperty("accidentalOneAndAHalfSharpsArrowUp")]
        public BoundingBox AccidentalOneAndAHalfSharpsArrowUp { get; set; }

        [JsonProperty("accidentalOneQuarterToneFlatFerneyhough")]
        public BoundingBox AccidentalOneQuarterToneFlatFerneyhough { get; set; }

        [JsonProperty("accidentalOneQuarterToneFlatStockhausen")]
        public BoundingBox AccidentalOneQuarterToneFlatStockhausen { get; set; }

        [JsonProperty("accidentalOneQuarterToneSharpFerneyhough")]
        public BoundingBox AccidentalOneQuarterToneSharpFerneyhough { get; set; }

        [JsonProperty("accidentalOneQuarterToneSharpStockhausen")]
        public BoundingBox AccidentalOneQuarterToneSharpStockhausen { get; set; }

        [JsonProperty("accidentalOneThirdToneFlatFerneyhough")]
        public BoundingBox AccidentalOneThirdToneFlatFerneyhough { get; set; }

        [JsonProperty("accidentalOneThirdToneSharpFerneyhough")]
        public BoundingBox AccidentalOneThirdToneSharpFerneyhough { get; set; }

        [JsonProperty("accidentalParensLeft")]
        public BoundingBox AccidentalParensLeft { get; set; }

        [JsonProperty("accidentalParensRight")]
        public BoundingBox AccidentalParensRight { get; set; }

        [JsonProperty("accidentalQuarterFlatEqualTempered")]
        public BoundingBox AccidentalQuarterFlatEqualTempered { get; set; }

        [JsonProperty("accidentalQuarterSharpEqualTempered")]
        public BoundingBox AccidentalQuarterSharpEqualTempered { get; set; }

        [JsonProperty("accidentalQuarterToneFlat4")]
        public BoundingBox AccidentalQuarterToneFlat4 { get; set; }

        [JsonProperty("accidentalQuarterToneFlatArabic")]
        public BoundingBox AccidentalQuarterToneFlatArabic { get; set; }

        [JsonProperty("accidentalQuarterToneFlatArrowUp")]
        public BoundingBox AccidentalQuarterToneFlatArrowUp { get; set; }

        [JsonProperty("accidentalQuarterToneFlatFilledReversed")]
        public BoundingBox AccidentalQuarterToneFlatFilledReversed { get; set; }

        [JsonProperty("accidentalQuarterToneFlatNaturalArrowDown")]
        public BoundingBox AccidentalQuarterToneFlatNaturalArrowDown { get; set; }

        [JsonProperty("accidentalQuarterToneFlatPenderecki")]
        public BoundingBox AccidentalQuarterToneFlatPenderecki { get; set; }

        [JsonProperty("accidentalQuarterToneFlatStein")]
        public BoundingBox AccidentalQuarterToneFlatStein { get; set; }

        [JsonProperty("accidentalQuarterToneFlatVanBlankenburg")]
        public BoundingBox AccidentalQuarterToneFlatVanBlankenburg { get; set; }

        [JsonProperty("accidentalQuarterToneSharp4")]
        public BoundingBox AccidentalQuarterToneSharp4 { get; set; }

        [JsonProperty("accidentalQuarterToneSharpArabic")]
        public BoundingBox AccidentalQuarterToneSharpArabic { get; set; }

        [JsonProperty("accidentalQuarterToneSharpArrowDown")]
        public BoundingBox AccidentalQuarterToneSharpArrowDown { get; set; }

        [JsonProperty("accidentalQuarterToneSharpBusotti")]
        public BoundingBox AccidentalQuarterToneSharpBusotti { get; set; }

        [JsonProperty("accidentalQuarterToneSharpNaturalArrowUp")]
        public BoundingBox AccidentalQuarterToneSharpNaturalArrowUp { get; set; }

        [JsonProperty("accidentalQuarterToneSharpStein")]
        public BoundingBox AccidentalQuarterToneSharpStein { get; set; }

        [JsonProperty("accidentalQuarterToneSharpWiggle")]
        public BoundingBox AccidentalQuarterToneSharpWiggle { get; set; }

        [JsonProperty("accidentalRaiseOneSeptimalComma")]
        public BoundingBox AccidentalRaiseOneSeptimalComma { get; set; }

        [JsonProperty("accidentalRaiseOneTridecimalQuartertone")]
        public BoundingBox AccidentalRaiseOneTridecimalQuartertone { get; set; }

        [JsonProperty("accidentalRaiseOneUndecimalQuartertone")]
        public BoundingBox AccidentalRaiseOneUndecimalQuartertone { get; set; }

        [JsonProperty("accidentalRaiseTwoSeptimalCommas")]
        public BoundingBox AccidentalRaiseTwoSeptimalCommas { get; set; }

        [JsonProperty("accidentalRaisedStockhausen")]
        public BoundingBox AccidentalRaisedStockhausen { get; set; }

        [JsonProperty("accidentalReversedFlatAndFlatArrowDown")]
        public BoundingBox AccidentalReversedFlatAndFlatArrowDown { get; set; }

        [JsonProperty("accidentalReversedFlatAndFlatArrowUp")]
        public BoundingBox AccidentalReversedFlatAndFlatArrowUp { get; set; }

        [JsonProperty("accidentalReversedFlatArrowDown")]
        public BoundingBox AccidentalReversedFlatArrowDown { get; set; }

        [JsonProperty("accidentalReversedFlatArrowUp")]
        public BoundingBox AccidentalReversedFlatArrowUp { get; set; }

        [JsonProperty("accidentalSharp")]
        public BoundingBox AccidentalSharp { get; set; }

        [JsonProperty("accidentalSharpArabic")]
        public BoundingBox AccidentalSharpArabic { get; set; }

        [JsonProperty("accidentalSharpEqualTempered")]
        public BoundingBox AccidentalSharpEqualTempered { get; set; }

        [JsonProperty("accidentalSharpJohnstonDown")]
        public BoundingBox AccidentalSharpJohnstonDown { get; set; }

        [JsonProperty("accidentalSharpJohnstonDownEl")]
        public BoundingBox AccidentalSharpJohnstonDownEl { get; set; }

        [JsonProperty("accidentalSharpJohnstonEl")]
        public BoundingBox AccidentalSharpJohnstonEl { get; set; }

        [JsonProperty("accidentalSharpJohnstonUp")]
        public BoundingBox AccidentalSharpJohnstonUp { get; set; }

        [JsonProperty("accidentalSharpJohnstonUpEl")]
        public BoundingBox AccidentalSharpJohnstonUpEl { get; set; }

        [JsonProperty("accidentalSharpLoweredStockhausen")]
        public BoundingBox AccidentalSharpLoweredStockhausen { get; set; }

        [JsonProperty("accidentalSharpOneArrowDown")]
        public BoundingBox AccidentalSharpOneArrowDown { get; set; }

        [JsonProperty("accidentalSharpOneArrowUp")]
        public BoundingBox AccidentalSharpOneArrowUp { get; set; }

        [JsonProperty("accidentalSharpOneHorizontalStroke")]
        public BoundingBox AccidentalSharpOneHorizontalStroke { get; set; }

        [JsonProperty("accidentalSharpParens")]
        public BoundingBox AccidentalSharpParens { get; set; }

        [JsonProperty("accidentalSharpRaisedStockhausen")]
        public BoundingBox AccidentalSharpRaisedStockhausen { get; set; }

        [JsonProperty("accidentalSharpRepeatedLineStockhausen")]
        public BoundingBox AccidentalSharpRepeatedLineStockhausen { get; set; }

        [JsonProperty("accidentalSharpRepeatedSpaceStockhausen")]
        public BoundingBox AccidentalSharpRepeatedSpaceStockhausen { get; set; }

        [JsonProperty("accidentalSharpReversed")]
        public BoundingBox AccidentalSharpReversed { get; set; }

        [JsonProperty("accidentalSharpSharp")]
        public BoundingBox AccidentalSharpSharp { get; set; }

        [JsonProperty("accidentalSharpSmall")]
        public BoundingBox AccidentalSharpSmall { get; set; }

        [JsonProperty("accidentalSharpThreeArrowsDown")]
        public BoundingBox AccidentalSharpThreeArrowsDown { get; set; }

        [JsonProperty("accidentalSharpThreeArrowsUp")]
        public BoundingBox AccidentalSharpThreeArrowsUp { get; set; }

        [JsonProperty("accidentalSharpTwoArrowsDown")]
        public BoundingBox AccidentalSharpTwoArrowsDown { get; set; }

        [JsonProperty("accidentalSharpTwoArrowsUp")]
        public BoundingBox AccidentalSharpTwoArrowsUp { get; set; }

        [JsonProperty("accidentalSims12Down")]
        public BoundingBox AccidentalSims12Down { get; set; }

        [JsonProperty("accidentalSims12Up")]
        public BoundingBox AccidentalSims12Up { get; set; }

        [JsonProperty("accidentalSims4Down")]
        public BoundingBox AccidentalSims4Down { get; set; }

        [JsonProperty("accidentalSims4Up")]
        public BoundingBox AccidentalSims4Up { get; set; }

        [JsonProperty("accidentalSims6Down")]
        public BoundingBox AccidentalSims6Down { get; set; }

        [JsonProperty("accidentalSims6Up")]
        public BoundingBox AccidentalSims6Up { get; set; }

        [JsonProperty("accidentalSori")]
        public BoundingBox AccidentalSori { get; set; }

        [JsonProperty("accidentalTavenerFlat")]
        public BoundingBox AccidentalTavenerFlat { get; set; }

        [JsonProperty("accidentalTavenerSharp")]
        public BoundingBox AccidentalTavenerSharp { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatArabic")]
        public BoundingBox AccidentalThreeQuarterTonesFlatArabic { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatArrowDown")]
        public BoundingBox AccidentalThreeQuarterTonesFlatArrowDown { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatArrowUp")]
        public BoundingBox AccidentalThreeQuarterTonesFlatArrowUp { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatCouper")]
        public BoundingBox AccidentalThreeQuarterTonesFlatCouper { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatGrisey")]
        public BoundingBox AccidentalThreeQuarterTonesFlatGrisey { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatTartini")]
        public BoundingBox AccidentalThreeQuarterTonesFlatTartini { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatZimmermann")]
        public BoundingBox AccidentalThreeQuarterTonesFlatZimmermann { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpArabic")]
        public BoundingBox AccidentalThreeQuarterTonesSharpArabic { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpArrowDown")]
        public BoundingBox AccidentalThreeQuarterTonesSharpArrowDown { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpArrowUp")]
        public BoundingBox AccidentalThreeQuarterTonesSharpArrowUp { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpBusotti")]
        public BoundingBox AccidentalThreeQuarterTonesSharpBusotti { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpStein")]
        public BoundingBox AccidentalThreeQuarterTonesSharpStein { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpStockhausen")]
        public BoundingBox AccidentalThreeQuarterTonesSharpStockhausen { get; set; }

        [JsonProperty("accidentalTripleFlat")]
        public BoundingBox AccidentalTripleFlat { get; set; }

        [JsonProperty("accidentalTripleFlatJoinedStems")]
        public BoundingBox AccidentalTripleFlatJoinedStems { get; set; }

        [JsonProperty("accidentalTripleSharp")]
        public BoundingBox AccidentalTripleSharp { get; set; }

        [JsonProperty("accidentalTwoThirdTonesFlatFerneyhough")]
        public BoundingBox AccidentalTwoThirdTonesFlatFerneyhough { get; set; }

        [JsonProperty("accidentalTwoThirdTonesSharpFerneyhough")]
        public BoundingBox AccidentalTwoThirdTonesSharpFerneyhough { get; set; }

        [JsonProperty("accidentalWilsonMinus")]
        public BoundingBox AccidentalWilsonMinus { get; set; }

        [JsonProperty("accidentalWilsonPlus")]
        public BoundingBox AccidentalWilsonPlus { get; set; }

        [JsonProperty("accidentalWyschnegradsky10TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky10TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky10TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky10TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky11TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky11TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky11TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky11TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky1TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky1TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky1TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky1TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky2TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky2TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky2TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky2TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky3TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky3TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky3TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky3TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky4TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky4TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky4TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky4TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky5TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky5TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky5TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky5TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky6TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky6TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky6TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky6TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky7TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky7TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky7TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky7TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky8TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky8TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky8TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky8TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky9TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky9TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky9TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky9TwelfthsSharp { get; set; }

        [JsonProperty("accidentalXenakisOneThirdToneSharp")]
        public BoundingBox AccidentalXenakisOneThirdToneSharp { get; set; }

        [JsonProperty("accidentalXenakisTwoThirdTonesSharp")]
        public BoundingBox AccidentalXenakisTwoThirdTonesSharp { get; set; }

        [JsonProperty("analyticsChoralmelodie")]
        public BoundingBox AnalyticsChoralmelodie { get; set; }

        [JsonProperty("analyticsEndStimme")]
        public BoundingBox AnalyticsEndStimme { get; set; }

        [JsonProperty("analyticsHauptrhythmus")]
        public BoundingBox AnalyticsHauptrhythmus { get; set; }

        [JsonProperty("analyticsHauptrhythmusR")]
        public BoundingBox AnalyticsHauptrhythmusR { get; set; }

        [JsonProperty("analyticsHauptstimme")]
        public BoundingBox AnalyticsHauptstimme { get; set; }

        [JsonProperty("analyticsInversion1")]
        public BoundingBox AnalyticsInversion1 { get; set; }

        [JsonProperty("analyticsNebenstimme")]
        public BoundingBox AnalyticsNebenstimme { get; set; }

        [JsonProperty("analyticsStartStimme")]
        public BoundingBox AnalyticsStartStimme { get; set; }

        [JsonProperty("analyticsTheme")]
        public BoundingBox AnalyticsTheme { get; set; }

        [JsonProperty("analyticsTheme1")]
        public BoundingBox AnalyticsTheme1 { get; set; }

        [JsonProperty("analyticsThemeInversion")]
        public BoundingBox AnalyticsThemeInversion { get; set; }

        [JsonProperty("analyticsThemeRetrograde")]
        public BoundingBox AnalyticsThemeRetrograde { get; set; }

        [JsonProperty("analyticsThemeRetrogradeInversion")]
        public BoundingBox AnalyticsThemeRetrogradeInversion { get; set; }

        [JsonProperty("arpeggiatoDown")]
        public BoundingBox ArpeggiatoDown { get; set; }

        [JsonProperty("arpeggiatoUp")]
        public BoundingBox ArpeggiatoUp { get; set; }

        [JsonProperty("arrowBlackDown")]
        public BoundingBox ArrowBlackDown { get; set; }

        [JsonProperty("arrowBlackDownLeft")]
        public BoundingBox ArrowBlackDownLeft { get; set; }

        [JsonProperty("arrowBlackDownRight")]
        public BoundingBox ArrowBlackDownRight { get; set; }

        [JsonProperty("arrowBlackLeft")]
        public BoundingBox ArrowBlackLeft { get; set; }

        [JsonProperty("arrowBlackRight")]
        public BoundingBox ArrowBlackRight { get; set; }

        [JsonProperty("arrowBlackUp")]
        public BoundingBox ArrowBlackUp { get; set; }

        [JsonProperty("arrowBlackUpLeft")]
        public BoundingBox ArrowBlackUpLeft { get; set; }

        [JsonProperty("arrowBlackUpRight")]
        public BoundingBox ArrowBlackUpRight { get; set; }

        [JsonProperty("arrowOpenDown")]
        public BoundingBox ArrowOpenDown { get; set; }

        [JsonProperty("arrowOpenDownLeft")]
        public BoundingBox ArrowOpenDownLeft { get; set; }

        [JsonProperty("arrowOpenDownRight")]
        public BoundingBox ArrowOpenDownRight { get; set; }

        [JsonProperty("arrowOpenLeft")]
        public BoundingBox ArrowOpenLeft { get; set; }

        [JsonProperty("arrowOpenRight")]
        public BoundingBox ArrowOpenRight { get; set; }

        [JsonProperty("arrowOpenUp")]
        public BoundingBox ArrowOpenUp { get; set; }

        [JsonProperty("arrowOpenUpLeft")]
        public BoundingBox ArrowOpenUpLeft { get; set; }

        [JsonProperty("arrowOpenUpRight")]
        public BoundingBox ArrowOpenUpRight { get; set; }

        [JsonProperty("arrowWhiteDown")]
        public BoundingBox ArrowWhiteDown { get; set; }

        [JsonProperty("arrowWhiteDownLeft")]
        public BoundingBox ArrowWhiteDownLeft { get; set; }

        [JsonProperty("arrowWhiteDownRight")]
        public BoundingBox ArrowWhiteDownRight { get; set; }

        [JsonProperty("arrowWhiteLeft")]
        public BoundingBox ArrowWhiteLeft { get; set; }

        [JsonProperty("arrowWhiteRight")]
        public BoundingBox ArrowWhiteRight { get; set; }

        [JsonProperty("arrowWhiteUp")]
        public BoundingBox ArrowWhiteUp { get; set; }

        [JsonProperty("arrowWhiteUpLeft")]
        public BoundingBox ArrowWhiteUpLeft { get; set; }

        [JsonProperty("arrowWhiteUpRight")]
        public BoundingBox ArrowWhiteUpRight { get; set; }

        [JsonProperty("arrowheadBlackDown")]
        public BoundingBox ArrowheadBlackDown { get; set; }

        [JsonProperty("arrowheadBlackDownLeft")]
        public BoundingBox ArrowheadBlackDownLeft { get; set; }

        [JsonProperty("arrowheadBlackDownRight")]
        public BoundingBox ArrowheadBlackDownRight { get; set; }

        [JsonProperty("arrowheadBlackLeft")]
        public BoundingBox ArrowheadBlackLeft { get; set; }

        [JsonProperty("arrowheadBlackRight")]
        public BoundingBox ArrowheadBlackRight { get; set; }

        [JsonProperty("arrowheadBlackUp")]
        public BoundingBox ArrowheadBlackUp { get; set; }

        [JsonProperty("arrowheadBlackUpLeft")]
        public BoundingBox ArrowheadBlackUpLeft { get; set; }

        [JsonProperty("arrowheadBlackUpRight")]
        public BoundingBox ArrowheadBlackUpRight { get; set; }

        [JsonProperty("arrowheadOpenDown")]
        public BoundingBox ArrowheadOpenDown { get; set; }

        [JsonProperty("arrowheadOpenDownLeft")]
        public BoundingBox ArrowheadOpenDownLeft { get; set; }

        [JsonProperty("arrowheadOpenDownRight")]
        public BoundingBox ArrowheadOpenDownRight { get; set; }

        [JsonProperty("arrowheadOpenLeft")]
        public BoundingBox ArrowheadOpenLeft { get; set; }

        [JsonProperty("arrowheadOpenRight")]
        public BoundingBox ArrowheadOpenRight { get; set; }

        [JsonProperty("arrowheadOpenUp")]
        public BoundingBox ArrowheadOpenUp { get; set; }

        [JsonProperty("arrowheadOpenUpLeft")]
        public BoundingBox ArrowheadOpenUpLeft { get; set; }

        [JsonProperty("arrowheadOpenUpRight")]
        public BoundingBox ArrowheadOpenUpRight { get; set; }

        [JsonProperty("arrowheadWhiteDown")]
        public BoundingBox ArrowheadWhiteDown { get; set; }

        [JsonProperty("arrowheadWhiteDownLeft")]
        public BoundingBox ArrowheadWhiteDownLeft { get; set; }

        [JsonProperty("arrowheadWhiteDownRight")]
        public BoundingBox ArrowheadWhiteDownRight { get; set; }

        [JsonProperty("arrowheadWhiteLeft")]
        public BoundingBox ArrowheadWhiteLeft { get; set; }

        [JsonProperty("arrowheadWhiteRight")]
        public BoundingBox ArrowheadWhiteRight { get; set; }

        [JsonProperty("arrowheadWhiteUp")]
        public BoundingBox ArrowheadWhiteUp { get; set; }

        [JsonProperty("arrowheadWhiteUpLeft")]
        public BoundingBox ArrowheadWhiteUpLeft { get; set; }

        [JsonProperty("arrowheadWhiteUpRight")]
        public BoundingBox ArrowheadWhiteUpRight { get; set; }

        [JsonProperty("articAccentAbove")]
        public BoundingBox ArticAccentAbove { get; set; }

        [JsonProperty("articAccentAboveLarge")]
        public BoundingBox ArticAccentAboveLarge { get; set; }

        [JsonProperty("articAccentAboveSmall")]
        public BoundingBox ArticAccentAboveSmall { get; set; }

        [JsonProperty("articAccentBelow")]
        public BoundingBox ArticAccentBelow { get; set; }

        [JsonProperty("articAccentBelowLarge")]
        public BoundingBox ArticAccentBelowLarge { get; set; }

        [JsonProperty("articAccentBelowSmall")]
        public BoundingBox ArticAccentBelowSmall { get; set; }

        [JsonProperty("articAccentStaccatoAbove")]
        public BoundingBox ArticAccentStaccatoAbove { get; set; }

        [JsonProperty("articAccentStaccatoAboveSmall")]
        public BoundingBox ArticAccentStaccatoAboveSmall { get; set; }

        [JsonProperty("articAccentStaccatoBelow")]
        public BoundingBox ArticAccentStaccatoBelow { get; set; }

        [JsonProperty("articAccentStaccatoBelowSmall")]
        public BoundingBox ArticAccentStaccatoBelowSmall { get; set; }

        [JsonProperty("articLaissezVibrerAbove")]
        public BoundingBox ArticLaissezVibrerAbove { get; set; }

        [JsonProperty("articLaissezVibrerBelow")]
        public BoundingBox ArticLaissezVibrerBelow { get; set; }

        [JsonProperty("articMarcatoAbove")]
        public BoundingBox ArticMarcatoAbove { get; set; }

        [JsonProperty("articMarcatoAboveSmall")]
        public BoundingBox ArticMarcatoAboveSmall { get; set; }

        [JsonProperty("articMarcatoBelow")]
        public BoundingBox ArticMarcatoBelow { get; set; }

        [JsonProperty("articMarcatoBelowSmall")]
        public BoundingBox ArticMarcatoBelowSmall { get; set; }

        [JsonProperty("articMarcatoStaccatoAbove")]
        public BoundingBox ArticMarcatoStaccatoAbove { get; set; }

        [JsonProperty("articMarcatoStaccatoAboveSmall")]
        public BoundingBox ArticMarcatoStaccatoAboveSmall { get; set; }

        [JsonProperty("articMarcatoStaccatoBelow")]
        public BoundingBox ArticMarcatoStaccatoBelow { get; set; }

        [JsonProperty("articMarcatoStaccatoBelowSmall")]
        public BoundingBox ArticMarcatoStaccatoBelowSmall { get; set; }

        [JsonProperty("articMarcatoTenutoAbove")]
        public BoundingBox ArticMarcatoTenutoAbove { get; set; }

        [JsonProperty("articMarcatoTenutoBelow")]
        public BoundingBox ArticMarcatoTenutoBelow { get; set; }

        [JsonProperty("articSoftAccentAbove")]
        public BoundingBox ArticSoftAccentAbove { get; set; }

        [JsonProperty("articSoftAccentBelow")]
        public BoundingBox ArticSoftAccentBelow { get; set; }

        [JsonProperty("articSoftAccentStaccatoAbove")]
        public BoundingBox ArticSoftAccentStaccatoAbove { get; set; }

        [JsonProperty("articSoftAccentStaccatoBelow")]
        public BoundingBox ArticSoftAccentStaccatoBelow { get; set; }

        [JsonProperty("articSoftAccentTenutoAbove")]
        public BoundingBox ArticSoftAccentTenutoAbove { get; set; }

        [JsonProperty("articSoftAccentTenutoBelow")]
        public BoundingBox ArticSoftAccentTenutoBelow { get; set; }

        [JsonProperty("articSoftAccentTenutoStaccatoAbove")]
        public BoundingBox ArticSoftAccentTenutoStaccatoAbove { get; set; }

        [JsonProperty("articSoftAccentTenutoStaccatoBelow")]
        public BoundingBox ArticSoftAccentTenutoStaccatoBelow { get; set; }

        [JsonProperty("articStaccatissimoAbove")]
        public BoundingBox ArticStaccatissimoAbove { get; set; }

        [JsonProperty("articStaccatissimoAboveSmall")]
        public BoundingBox ArticStaccatissimoAboveSmall { get; set; }

        [JsonProperty("articStaccatissimoBelow")]
        public BoundingBox ArticStaccatissimoBelow { get; set; }

        [JsonProperty("articStaccatissimoBelowSmall")]
        public BoundingBox ArticStaccatissimoBelowSmall { get; set; }

        [JsonProperty("articStaccatissimoStrokeAbove")]
        public BoundingBox ArticStaccatissimoStrokeAbove { get; set; }

        [JsonProperty("articStaccatissimoStrokeAboveSmall")]
        public BoundingBox ArticStaccatissimoStrokeAboveSmall { get; set; }

        [JsonProperty("articStaccatissimoStrokeBelow")]
        public BoundingBox ArticStaccatissimoStrokeBelow { get; set; }

        [JsonProperty("articStaccatissimoStrokeBelowSmall")]
        public BoundingBox ArticStaccatissimoStrokeBelowSmall { get; set; }

        [JsonProperty("articStaccatissimoWedgeAbove")]
        public BoundingBox ArticStaccatissimoWedgeAbove { get; set; }

        [JsonProperty("articStaccatissimoWedgeAboveSmall")]
        public BoundingBox ArticStaccatissimoWedgeAboveSmall { get; set; }

        [JsonProperty("articStaccatissimoWedgeBelow")]
        public BoundingBox ArticStaccatissimoWedgeBelow { get; set; }

        [JsonProperty("articStaccatissimoWedgeBelowSmall")]
        public BoundingBox ArticStaccatissimoWedgeBelowSmall { get; set; }

        [JsonProperty("articStaccatoAbove")]
        public BoundingBox ArticStaccatoAbove { get; set; }

        [JsonProperty("articStaccatoAboveSmall")]
        public BoundingBox ArticStaccatoAboveSmall { get; set; }

        [JsonProperty("articStaccatoBelow")]
        public BoundingBox ArticStaccatoBelow { get; set; }

        [JsonProperty("articStaccatoBelowSmall")]
        public BoundingBox ArticStaccatoBelowSmall { get; set; }

        [JsonProperty("articStressAbove")]
        public BoundingBox ArticStressAbove { get; set; }

        [JsonProperty("articStressBelow")]
        public BoundingBox ArticStressBelow { get; set; }

        [JsonProperty("articTenutoAbove")]
        public BoundingBox ArticTenutoAbove { get; set; }

        [JsonProperty("articTenutoAboveSmall")]
        public BoundingBox ArticTenutoAboveSmall { get; set; }

        [JsonProperty("articTenutoAccentAbove")]
        public BoundingBox ArticTenutoAccentAbove { get; set; }

        [JsonProperty("articTenutoAccentAboveSmall")]
        public BoundingBox ArticTenutoAccentAboveSmall { get; set; }

        [JsonProperty("articTenutoAccentBelow")]
        public BoundingBox ArticTenutoAccentBelow { get; set; }

        [JsonProperty("articTenutoAccentBelowSmall")]
        public BoundingBox ArticTenutoAccentBelowSmall { get; set; }

        [JsonProperty("articTenutoBelow")]
        public BoundingBox ArticTenutoBelow { get; set; }

        [JsonProperty("articTenutoBelowSmall")]
        public BoundingBox ArticTenutoBelowSmall { get; set; }

        [JsonProperty("articTenutoStaccatoAbove")]
        public BoundingBox ArticTenutoStaccatoAbove { get; set; }

        [JsonProperty("articTenutoStaccatoAboveSmall")]
        public BoundingBox ArticTenutoStaccatoAboveSmall { get; set; }

        [JsonProperty("articTenutoStaccatoBelow")]
        public BoundingBox ArticTenutoStaccatoBelow { get; set; }

        [JsonProperty("articTenutoStaccatoBelowSmall")]
        public BoundingBox ArticTenutoStaccatoBelowSmall { get; set; }

        [JsonProperty("articUnstressAbove")]
        public BoundingBox ArticUnstressAbove { get; set; }

        [JsonProperty("articUnstressBelow")]
        public BoundingBox ArticUnstressBelow { get; set; }

        [JsonProperty("augmentationDot")]
        public BoundingBox AugmentationDot { get; set; }

        [JsonProperty("barlineDashed")]
        public BoundingBox BarlineDashed { get; set; }

        [JsonProperty("barlineDotted")]
        public BoundingBox BarlineDotted { get; set; }

        [JsonProperty("barlineDouble")]
        public BoundingBox BarlineDouble { get; set; }

        [JsonProperty("barlineFinal")]
        public BoundingBox BarlineFinal { get; set; }

        [JsonProperty("barlineHeavy")]
        public BoundingBox BarlineHeavy { get; set; }

        [JsonProperty("barlineHeavyHeavy")]
        public BoundingBox BarlineHeavyHeavy { get; set; }

        [JsonProperty("barlineReverseFinal")]
        public BoundingBox BarlineReverseFinal { get; set; }

        [JsonProperty("barlineShort")]
        public BoundingBox BarlineShort { get; set; }

        [JsonProperty("barlineSingle")]
        public BoundingBox BarlineSingle { get; set; }

        [JsonProperty("barlineTick")]
        public BoundingBox BarlineTick { get; set; }

        [JsonProperty("beamAccelRit1")]
        public BoundingBox BeamAccelRit1 { get; set; }

        [JsonProperty("beamAccelRit10")]
        public BoundingBox BeamAccelRit10 { get; set; }

        [JsonProperty("beamAccelRit11")]
        public BoundingBox BeamAccelRit11 { get; set; }

        [JsonProperty("beamAccelRit12")]
        public BoundingBox BeamAccelRit12 { get; set; }

        [JsonProperty("beamAccelRit13")]
        public BoundingBox BeamAccelRit13 { get; set; }

        [JsonProperty("beamAccelRit14")]
        public BoundingBox BeamAccelRit14 { get; set; }

        [JsonProperty("beamAccelRit15")]
        public BoundingBox BeamAccelRit15 { get; set; }

        [JsonProperty("beamAccelRit2")]
        public BoundingBox BeamAccelRit2 { get; set; }

        [JsonProperty("beamAccelRit3")]
        public BoundingBox BeamAccelRit3 { get; set; }

        [JsonProperty("beamAccelRit4")]
        public BoundingBox BeamAccelRit4 { get; set; }

        [JsonProperty("beamAccelRit5")]
        public BoundingBox BeamAccelRit5 { get; set; }

        [JsonProperty("beamAccelRit6")]
        public BoundingBox BeamAccelRit6 { get; set; }

        [JsonProperty("beamAccelRit7")]
        public BoundingBox BeamAccelRit7 { get; set; }

        [JsonProperty("beamAccelRit8")]
        public BoundingBox BeamAccelRit8 { get; set; }

        [JsonProperty("beamAccelRit9")]
        public BoundingBox BeamAccelRit9 { get; set; }

        [JsonProperty("beamAccelRitFinal")]
        public BoundingBox BeamAccelRitFinal { get; set; }

        [JsonProperty("brace")]
        public BoundingBox Brace { get; set; }

        [JsonProperty("braceFlat")]
        public BoundingBox BraceFlat { get; set; }

        [JsonProperty("braceLarge")]
        public BoundingBox BraceLarge { get; set; }

        [JsonProperty("braceLarger")]
        public BoundingBox BraceLarger { get; set; }

        [JsonProperty("braceSmall")]
        public BoundingBox BraceSmall { get; set; }

        [JsonProperty("bracket")]
        public BoundingBox Bracket { get; set; }

        [JsonProperty("bracketBottom")]
        public BoundingBox BracketBottom { get; set; }

        [JsonProperty("bracketTop")]
        public BoundingBox BracketTop { get; set; }

        [JsonProperty("brassBend")]
        public BoundingBox BrassBend { get; set; }

        [JsonProperty("brassDoitLong")]
        public BoundingBox BrassDoitLong { get; set; }

        [JsonProperty("brassDoitMedium")]
        public BoundingBox BrassDoitMedium { get; set; }

        [JsonProperty("brassDoitShort")]
        public BoundingBox BrassDoitShort { get; set; }

        [JsonProperty("brassFallLipLong")]
        public BoundingBox BrassFallLipLong { get; set; }

        [JsonProperty("brassFallLipMedium")]
        public BoundingBox BrassFallLipMedium { get; set; }

        [JsonProperty("brassFallLipShort")]
        public BoundingBox BrassFallLipShort { get; set; }

        [JsonProperty("brassFallRoughLong")]
        public BoundingBox BrassFallRoughLong { get; set; }

        [JsonProperty("brassFallRoughMedium")]
        public BoundingBox BrassFallRoughMedium { get; set; }

        [JsonProperty("brassFallRoughShort")]
        public BoundingBox BrassFallRoughShort { get; set; }

        [JsonProperty("brassFallSmoothLong")]
        public BoundingBox BrassFallSmoothLong { get; set; }

        [JsonProperty("brassFallSmoothMedium")]
        public BoundingBox BrassFallSmoothMedium { get; set; }

        [JsonProperty("brassFallSmoothShort")]
        public BoundingBox BrassFallSmoothShort { get; set; }

        [JsonProperty("brassFlip")]
        public BoundingBox BrassFlip { get; set; }

        [JsonProperty("brassHarmonMuteClosed")]
        public BoundingBox BrassHarmonMuteClosed { get; set; }

        [JsonProperty("brassHarmonMuteStemHalfLeft")]
        public BoundingBox BrassHarmonMuteStemHalfLeft { get; set; }

        [JsonProperty("brassHarmonMuteStemHalfRight")]
        public BoundingBox BrassHarmonMuteStemHalfRight { get; set; }

        [JsonProperty("brassHarmonMuteStemOpen")]
        public BoundingBox BrassHarmonMuteStemOpen { get; set; }

        [JsonProperty("brassJazzTurn")]
        public BoundingBox BrassJazzTurn { get; set; }

        [JsonProperty("brassLiftLong")]
        public BoundingBox BrassLiftLong { get; set; }

        [JsonProperty("brassLiftMedium")]
        public BoundingBox BrassLiftMedium { get; set; }

        [JsonProperty("brassLiftShort")]
        public BoundingBox BrassLiftShort { get; set; }

        [JsonProperty("brassLiftSmoothLong")]
        public BoundingBox BrassLiftSmoothLong { get; set; }

        [JsonProperty("brassLiftSmoothMedium")]
        public BoundingBox BrassLiftSmoothMedium { get; set; }

        [JsonProperty("brassLiftSmoothShort")]
        public BoundingBox BrassLiftSmoothShort { get; set; }

        [JsonProperty("brassMuteClosed")]
        public BoundingBox BrassMuteClosed { get; set; }

        [JsonProperty("brassMuteHalfClosed")]
        public BoundingBox BrassMuteHalfClosed { get; set; }

        [JsonProperty("brassMuteOpen")]
        public BoundingBox BrassMuteOpen { get; set; }

        [JsonProperty("brassPlop")]
        public BoundingBox BrassPlop { get; set; }

        [JsonProperty("brassScoop")]
        public BoundingBox BrassScoop { get; set; }

        [JsonProperty("brassSmear")]
        public BoundingBox BrassSmear { get; set; }

        [JsonProperty("brassValveTrill")]
        public BoundingBox BrassValveTrill { get; set; }

        [JsonProperty("breathMarkComma")]
        public BoundingBox BreathMarkComma { get; set; }

        [JsonProperty("breathMarkSalzedo")]
        public BoundingBox BreathMarkSalzedo { get; set; }

        [JsonProperty("breathMarkTick")]
        public BoundingBox BreathMarkTick { get; set; }

        [JsonProperty("breathMarkUpbow")]
        public BoundingBox BreathMarkUpbow { get; set; }

        [JsonProperty("bridgeClef")]
        public BoundingBox BridgeClef { get; set; }

        [JsonProperty("buzzRoll")]
        public BoundingBox BuzzRoll { get; set; }

        [JsonProperty("cClef")]
        public BoundingBox CClef { get; set; }

        [JsonProperty("cClef8vb")]
        public BoundingBox CClef8Vb { get; set; }

        [JsonProperty("cClefArrowDown")]
        public BoundingBox CClefArrowDown { get; set; }

        [JsonProperty("cClefArrowUp")]
        public BoundingBox CClefArrowUp { get; set; }

        [JsonProperty("cClefChange")]
        public BoundingBox CClefChange { get; set; }

        [JsonProperty("cClefCombining")]
        public BoundingBox CClefCombining { get; set; }

        [JsonProperty("cClefFrench")]
        public BoundingBox CClefFrench { get; set; }

        [JsonProperty("cClefFrench20C")]
        public BoundingBox CClefFrench20C { get; set; }

        [JsonProperty("cClefFrench20CChange")]
        public BoundingBox CClefFrench20CChange { get; set; }

        [JsonProperty("cClefReversed")]
        public BoundingBox CClefReversed { get; set; }

        [JsonProperty("cClefSmall")]
        public BoundingBox CClefSmall { get; set; }

        [JsonProperty("cClefSquare")]
        public BoundingBox CClefSquare { get; set; }

        [JsonProperty("caesura")]
        public BoundingBox Caesura { get; set; }

        [JsonProperty("caesuraCurved")]
        public BoundingBox CaesuraCurved { get; set; }

        [JsonProperty("caesuraShort")]
        public BoundingBox CaesuraShort { get; set; }

        [JsonProperty("caesuraSingleStroke")]
        public BoundingBox CaesuraSingleStroke { get; set; }

        [JsonProperty("caesuraThick")]
        public BoundingBox CaesuraThick { get; set; }

        [JsonProperty("chantAccentusAbove")]
        public BoundingBox ChantAccentusAbove { get; set; }

        [JsonProperty("chantAccentusBelow")]
        public BoundingBox ChantAccentusBelow { get; set; }

        [JsonProperty("chantAuctumAsc")]
        public BoundingBox ChantAuctumAsc { get; set; }

        [JsonProperty("chantAuctumDesc")]
        public BoundingBox ChantAuctumDesc { get; set; }

        [JsonProperty("chantAugmentum")]
        public BoundingBox ChantAugmentum { get; set; }

        [JsonProperty("chantCaesura")]
        public BoundingBox ChantCaesura { get; set; }

        [JsonProperty("chantCclef")]
        public BoundingBox ChantCclef { get; set; }

        [JsonProperty("chantCclefHufnagel")]
        public BoundingBox ChantCclefHufnagel { get; set; }

        [JsonProperty("chantCirculusAbove")]
        public BoundingBox ChantCirculusAbove { get; set; }

        [JsonProperty("chantCirculusBelow")]
        public BoundingBox ChantCirculusBelow { get; set; }

        [JsonProperty("chantConnectingLineAsc2nd")]
        public BoundingBox ChantConnectingLineAsc2Nd { get; set; }

        [JsonProperty("chantConnectingLineAsc3rd")]
        public BoundingBox ChantConnectingLineAsc3Rd { get; set; }

        [JsonProperty("chantConnectingLineAsc4th")]
        public BoundingBox ChantConnectingLineAsc4Th { get; set; }

        [JsonProperty("chantConnectingLineAsc5th")]
        public BoundingBox ChantConnectingLineAsc5Th { get; set; }

        [JsonProperty("chantConnectingLineAsc6th")]
        public BoundingBox ChantConnectingLineAsc6Th { get; set; }

        [JsonProperty("chantCustosStemDownPosHigh")]
        public BoundingBox ChantCustosStemDownPosHigh { get; set; }

        [JsonProperty("chantCustosStemDownPosHighest")]
        public BoundingBox ChantCustosStemDownPosHighest { get; set; }

        [JsonProperty("chantCustosStemDownPosMiddle")]
        public BoundingBox ChantCustosStemDownPosMiddle { get; set; }

        [JsonProperty("chantCustosStemUpPosLow")]
        public BoundingBox ChantCustosStemUpPosLow { get; set; }

        [JsonProperty("chantCustosStemUpPosLowest")]
        public BoundingBox ChantCustosStemUpPosLowest { get; set; }

        [JsonProperty("chantCustosStemUpPosMiddle")]
        public BoundingBox ChantCustosStemUpPosMiddle { get; set; }

        [JsonProperty("chantDeminutumLower")]
        public BoundingBox ChantDeminutumLower { get; set; }

        [JsonProperty("chantDeminutumUpper")]
        public BoundingBox ChantDeminutumUpper { get; set; }

        [JsonProperty("chantDivisioFinalis")]
        public BoundingBox ChantDivisioFinalis { get; set; }

        [JsonProperty("chantDivisioMaior")]
        public BoundingBox ChantDivisioMaior { get; set; }

        [JsonProperty("chantDivisioMaxima")]
        public BoundingBox ChantDivisioMaxima { get; set; }

        [JsonProperty("chantDivisioMinima")]
        public BoundingBox ChantDivisioMinima { get; set; }

        [JsonProperty("chantEntryLineAsc2nd")]
        public BoundingBox ChantEntryLineAsc2Nd { get; set; }

        [JsonProperty("chantEntryLineAsc3rd")]
        public BoundingBox ChantEntryLineAsc3Rd { get; set; }

        [JsonProperty("chantEntryLineAsc4th")]
        public BoundingBox ChantEntryLineAsc4Th { get; set; }

        [JsonProperty("chantEntryLineAsc5th")]
        public BoundingBox ChantEntryLineAsc5Th { get; set; }

        [JsonProperty("chantEntryLineAsc6th")]
        public BoundingBox ChantEntryLineAsc6Th { get; set; }

        [JsonProperty("chantEpisema")]
        public BoundingBox ChantEpisema { get; set; }

        [JsonProperty("chantFclef")]
        public BoundingBox ChantFclef { get; set; }

        [JsonProperty("chantFclefHufnagel")]
        public BoundingBox ChantFclefHufnagel { get; set; }

        [JsonProperty("chantIctusAbove")]
        public BoundingBox ChantIctusAbove { get; set; }

        [JsonProperty("chantIctusBelow")]
        public BoundingBox ChantIctusBelow { get; set; }

        [JsonProperty("chantLigaturaDesc2nd")]
        public BoundingBox ChantLigaturaDesc2Nd { get; set; }

        [JsonProperty("chantLigaturaDesc3rd")]
        public BoundingBox ChantLigaturaDesc3Rd { get; set; }

        [JsonProperty("chantLigaturaDesc4th")]
        public BoundingBox ChantLigaturaDesc4Th { get; set; }

        [JsonProperty("chantLigaturaDesc5th")]
        public BoundingBox ChantLigaturaDesc5Th { get; set; }

        [JsonProperty("chantOriscusAscending")]
        public BoundingBox ChantOriscusAscending { get; set; }

        [JsonProperty("chantOriscusDescending")]
        public BoundingBox ChantOriscusDescending { get; set; }

        [JsonProperty("chantOriscusLiquescens")]
        public BoundingBox ChantOriscusLiquescens { get; set; }

        [JsonProperty("chantPodatusLower")]
        public BoundingBox ChantPodatusLower { get; set; }

        [JsonProperty("chantPodatusUpper")]
        public BoundingBox ChantPodatusUpper { get; set; }

        [JsonProperty("chantPunctum")]
        public BoundingBox ChantPunctum { get; set; }

        [JsonProperty("chantPunctumCavum")]
        public BoundingBox ChantPunctumCavum { get; set; }

        [JsonProperty("chantPunctumDeminutum")]
        public BoundingBox ChantPunctumDeminutum { get; set; }

        [JsonProperty("chantPunctumInclinatum")]
        public BoundingBox ChantPunctumInclinatum { get; set; }

        [JsonProperty("chantPunctumInclinatumAuctum")]
        public BoundingBox ChantPunctumInclinatumAuctum { get; set; }

        [JsonProperty("chantPunctumInclinatumDeminutum")]
        public BoundingBox ChantPunctumInclinatumDeminutum { get; set; }

        [JsonProperty("chantPunctumLinea")]
        public BoundingBox ChantPunctumLinea { get; set; }

        [JsonProperty("chantPunctumLineaCavum")]
        public BoundingBox ChantPunctumLineaCavum { get; set; }

        [JsonProperty("chantPunctumVirga")]
        public BoundingBox ChantPunctumVirga { get; set; }

        [JsonProperty("chantPunctumVirgaReversed")]
        public BoundingBox ChantPunctumVirgaReversed { get; set; }

        [JsonProperty("chantQuilisma")]
        public BoundingBox ChantQuilisma { get; set; }

        [JsonProperty("chantSemicirculusAbove")]
        public BoundingBox ChantSemicirculusAbove { get; set; }

        [JsonProperty("chantSemicirculusBelow")]
        public BoundingBox ChantSemicirculusBelow { get; set; }

        [JsonProperty("chantStaff")]
        public BoundingBox ChantStaff { get; set; }

        [JsonProperty("chantStaffNarrow")]
        public BoundingBox ChantStaffNarrow { get; set; }

        [JsonProperty("chantStaffWide")]
        public BoundingBox ChantStaffWide { get; set; }

        [JsonProperty("chantStrophicus")]
        public BoundingBox ChantStrophicus { get; set; }

        [JsonProperty("chantStrophicusAuctus")]
        public BoundingBox ChantStrophicusAuctus { get; set; }

        [JsonProperty("chantStrophicusLiquescens2nd")]
        public BoundingBox ChantStrophicusLiquescens2Nd { get; set; }

        [JsonProperty("chantStrophicusLiquescens3rd")]
        public BoundingBox ChantStrophicusLiquescens3Rd { get; set; }

        [JsonProperty("chantStrophicusLiquescens4th")]
        public BoundingBox ChantStrophicusLiquescens4Th { get; set; }

        [JsonProperty("chantStrophicusLiquescens5th")]
        public BoundingBox ChantStrophicusLiquescens5Th { get; set; }

        [JsonProperty("chantVirgula")]
        public BoundingBox ChantVirgula { get; set; }

        [JsonProperty("clef15")]
        public BoundingBox Clef15 { get; set; }

        [JsonProperty("clef8")]
        public BoundingBox Clef8 { get; set; }

        [JsonProperty("coda")]
        public BoundingBox Coda { get; set; }

        [JsonProperty("codaJapanese")]
        public BoundingBox CodaJapanese { get; set; }

        [JsonProperty("codaSquare")]
        public BoundingBox CodaSquare { get; set; }

        [JsonProperty("conductorBeat2Compound")]
        public BoundingBox ConductorBeat2Compound { get; set; }

        [JsonProperty("conductorBeat2Simple")]
        public BoundingBox ConductorBeat2Simple { get; set; }

        [JsonProperty("conductorBeat3Compound")]
        public BoundingBox ConductorBeat3Compound { get; set; }

        [JsonProperty("conductorBeat3Simple")]
        public BoundingBox ConductorBeat3Simple { get; set; }

        [JsonProperty("conductorBeat4Compound")]
        public BoundingBox ConductorBeat4Compound { get; set; }

        [JsonProperty("conductorBeat4Simple")]
        public BoundingBox ConductorBeat4Simple { get; set; }

        [JsonProperty("conductorLeftBeat")]
        public BoundingBox ConductorLeftBeat { get; set; }

        [JsonProperty("conductorRightBeat")]
        public BoundingBox ConductorRightBeat { get; set; }

        [JsonProperty("conductorStrongBeat")]
        public BoundingBox ConductorStrongBeat { get; set; }

        [JsonProperty("conductorUnconducted")]
        public BoundingBox ConductorUnconducted { get; set; }

        [JsonProperty("conductorWeakBeat")]
        public BoundingBox ConductorWeakBeat { get; set; }

        [JsonProperty("csymAugmented")]
        public BoundingBox CsymAugmented { get; set; }

        [JsonProperty("csymBracketLeftTall")]
        public BoundingBox CsymBracketLeftTall { get; set; }

        [JsonProperty("csymBracketRightTall")]
        public BoundingBox CsymBracketRightTall { get; set; }

        [JsonProperty("csymDiminished")]
        public BoundingBox CsymDiminished { get; set; }

        [JsonProperty("csymHalfDiminished")]
        public BoundingBox CsymHalfDiminished { get; set; }

        [JsonProperty("csymMajorSeventh")]
        public BoundingBox CsymMajorSeventh { get; set; }

        [JsonProperty("csymMinor")]
        public BoundingBox CsymMinor { get; set; }

        [JsonProperty("csymParensLeftTall")]
        public BoundingBox CsymParensLeftTall { get; set; }

        [JsonProperty("csymParensRightTall")]
        public BoundingBox CsymParensRightTall { get; set; }

        [JsonProperty("curlewSign")]
        public BoundingBox CurlewSign { get; set; }

        [JsonProperty("daCapo")]
        public BoundingBox DaCapo { get; set; }

        [JsonProperty("dalSegno")]
        public BoundingBox DalSegno { get; set; }

        [JsonProperty("daseianExcellentes1")]
        public BoundingBox DaseianExcellentes1 { get; set; }

        [JsonProperty("daseianExcellentes2")]
        public BoundingBox DaseianExcellentes2 { get; set; }

        [JsonProperty("daseianExcellentes3")]
        public BoundingBox DaseianExcellentes3 { get; set; }

        [JsonProperty("daseianExcellentes4")]
        public BoundingBox DaseianExcellentes4 { get; set; }

        [JsonProperty("daseianFinales1")]
        public BoundingBox DaseianFinales1 { get; set; }

        [JsonProperty("daseianFinales2")]
        public BoundingBox DaseianFinales2 { get; set; }

        [JsonProperty("daseianFinales3")]
        public BoundingBox DaseianFinales3 { get; set; }

        [JsonProperty("daseianFinales4")]
        public BoundingBox DaseianFinales4 { get; set; }

        [JsonProperty("daseianGraves1")]
        public BoundingBox DaseianGraves1 { get; set; }

        [JsonProperty("daseianGraves2")]
        public BoundingBox DaseianGraves2 { get; set; }

        [JsonProperty("daseianGraves3")]
        public BoundingBox DaseianGraves3 { get; set; }

        [JsonProperty("daseianGraves4")]
        public BoundingBox DaseianGraves4 { get; set; }

        [JsonProperty("daseianResidua1")]
        public BoundingBox DaseianResidua1 { get; set; }

        [JsonProperty("daseianResidua2")]
        public BoundingBox DaseianResidua2 { get; set; }

        [JsonProperty("daseianSuperiores1")]
        public BoundingBox DaseianSuperiores1 { get; set; }

        [JsonProperty("daseianSuperiores2")]
        public BoundingBox DaseianSuperiores2 { get; set; }

        [JsonProperty("daseianSuperiores3")]
        public BoundingBox DaseianSuperiores3 { get; set; }

        [JsonProperty("daseianSuperiores4")]
        public BoundingBox DaseianSuperiores4 { get; set; }

        [JsonProperty("doubleTongueAbove")]
        public BoundingBox DoubleTongueAbove { get; set; }

        [JsonProperty("doubleTongueAboveNoSlur")]
        public BoundingBox DoubleTongueAboveNoSlur { get; set; }

        [JsonProperty("doubleTongueBelow")]
        public BoundingBox DoubleTongueBelow { get; set; }

        [JsonProperty("doubleTongueBelowNoSlur")]
        public BoundingBox DoubleTongueBelowNoSlur { get; set; }

        [JsonProperty("dynamicCombinedSeparatorColon")]
        public BoundingBox DynamicCombinedSeparatorColon { get; set; }

        [JsonProperty("dynamicCombinedSeparatorHyphen")]
        public BoundingBox DynamicCombinedSeparatorHyphen { get; set; }

        [JsonProperty("dynamicCrescendoHairpin")]
        public BoundingBox DynamicCrescendoHairpin { get; set; }

        [JsonProperty("dynamicDiminuendoHairpin")]
        public BoundingBox DynamicDiminuendoHairpin { get; set; }

        [JsonProperty("dynamicFF")]
        public BoundingBox DynamicFf { get; set; }

        [JsonProperty("dynamicFFF")]
        public BoundingBox DynamicFff { get; set; }

        [JsonProperty("dynamicFFFF")]
        public BoundingBox DynamicFfff { get; set; }

        [JsonProperty("dynamicFFFFF")]
        public BoundingBox DynamicFffff { get; set; }

        [JsonProperty("dynamicFFFFFF")]
        public BoundingBox DynamicFfffff { get; set; }

        [JsonProperty("dynamicForte")]
        public BoundingBox DynamicForte { get; set; }

        [JsonProperty("dynamicFortePiano")]
        public BoundingBox DynamicFortePiano { get; set; }

        [JsonProperty("dynamicForteSmall")]
        public BoundingBox DynamicForteSmall { get; set; }

        [JsonProperty("dynamicForzando")]
        public BoundingBox DynamicForzando { get; set; }

        [JsonProperty("dynamicHairpinBracketLeft")]
        public BoundingBox DynamicHairpinBracketLeft { get; set; }

        [JsonProperty("dynamicHairpinBracketRight")]
        public BoundingBox DynamicHairpinBracketRight { get; set; }

        [JsonProperty("dynamicHairpinParenthesisLeft")]
        public BoundingBox DynamicHairpinParenthesisLeft { get; set; }

        [JsonProperty("dynamicHairpinParenthesisRight")]
        public BoundingBox DynamicHairpinParenthesisRight { get; set; }

        [JsonProperty("dynamicMF")]
        public BoundingBox DynamicMf { get; set; }

        [JsonProperty("dynamicMP")]
        public BoundingBox DynamicMp { get; set; }

        [JsonProperty("dynamicMessaDiVoce")]
        public BoundingBox DynamicMessaDiVoce { get; set; }

        [JsonProperty("dynamicMezzo")]
        public BoundingBox DynamicMezzo { get; set; }

        [JsonProperty("dynamicMezzoSmall")]
        public BoundingBox DynamicMezzoSmall { get; set; }

        [JsonProperty("dynamicNiente")]
        public BoundingBox DynamicNiente { get; set; }

        [JsonProperty("dynamicNienteForHairpin")]
        public BoundingBox DynamicNienteForHairpin { get; set; }

        [JsonProperty("dynamicNienteSmall")]
        public BoundingBox DynamicNienteSmall { get; set; }

        [JsonProperty("dynamicPF")]
        public BoundingBox DynamicPf { get; set; }

        [JsonProperty("dynamicPP")]
        public BoundingBox DynamicPp { get; set; }

        [JsonProperty("dynamicPPP")]
        public BoundingBox DynamicPpp { get; set; }

        [JsonProperty("dynamicPPPP")]
        public BoundingBox DynamicPppp { get; set; }

        [JsonProperty("dynamicPPPPP")]
        public BoundingBox DynamicPpppp { get; set; }

        [JsonProperty("dynamicPPPPPP")]
        public BoundingBox DynamicPppppp { get; set; }

        [JsonProperty("dynamicPiano")]
        public BoundingBox DynamicPiano { get; set; }

        [JsonProperty("dynamicPianoSmall")]
        public BoundingBox DynamicPianoSmall { get; set; }

        [JsonProperty("dynamicRinforzando")]
        public BoundingBox DynamicRinforzando { get; set; }

        [JsonProperty("dynamicRinforzando1")]
        public BoundingBox DynamicRinforzando1 { get; set; }

        [JsonProperty("dynamicRinforzando2")]
        public BoundingBox DynamicRinforzando2 { get; set; }

        [JsonProperty("dynamicRinforzandoSmall")]
        public BoundingBox DynamicRinforzandoSmall { get; set; }

        [JsonProperty("dynamicSforzando")]
        public BoundingBox DynamicSforzando { get; set; }

        [JsonProperty("dynamicSforzando1")]
        public BoundingBox DynamicSforzando1 { get; set; }

        [JsonProperty("dynamicSforzandoPianissimo")]
        public BoundingBox DynamicSforzandoPianissimo { get; set; }

        [JsonProperty("dynamicSforzandoPiano")]
        public BoundingBox DynamicSforzandoPiano { get; set; }

        [JsonProperty("dynamicSforzandoSmall")]
        public BoundingBox DynamicSforzandoSmall { get; set; }

        [JsonProperty("dynamicSforzato")]
        public BoundingBox DynamicSforzato { get; set; }

        [JsonProperty("dynamicSforzatoFF")]
        public BoundingBox DynamicSforzatoFf { get; set; }

        [JsonProperty("dynamicSforzatoPiano")]
        public BoundingBox DynamicSforzatoPiano { get; set; }

        [JsonProperty("dynamicZ")]
        public BoundingBox DynamicZ { get; set; }

        [JsonProperty("dynamicZSmall")]
        public BoundingBox DynamicZSmall { get; set; }

        [JsonProperty("elecAudioChannelsEight")]
        public BoundingBox ElecAudioChannelsEight { get; set; }

        [JsonProperty("elecAudioChannelsFive")]
        public BoundingBox ElecAudioChannelsFive { get; set; }

        [JsonProperty("elecAudioChannelsFour")]
        public BoundingBox ElecAudioChannelsFour { get; set; }

        [JsonProperty("elecAudioChannelsOne")]
        public BoundingBox ElecAudioChannelsOne { get; set; }

        [JsonProperty("elecAudioChannelsSeven")]
        public BoundingBox ElecAudioChannelsSeven { get; set; }

        [JsonProperty("elecAudioChannelsSix")]
        public BoundingBox ElecAudioChannelsSix { get; set; }

        [JsonProperty("elecAudioChannelsThreeFrontal")]
        public BoundingBox ElecAudioChannelsThreeFrontal { get; set; }

        [JsonProperty("elecAudioChannelsThreeSurround")]
        public BoundingBox ElecAudioChannelsThreeSurround { get; set; }

        [JsonProperty("elecAudioChannelsTwo")]
        public BoundingBox ElecAudioChannelsTwo { get; set; }

        [JsonProperty("elecAudioIn")]
        public BoundingBox ElecAudioIn { get; set; }

        [JsonProperty("elecAudioMono")]
        public BoundingBox ElecAudioMono { get; set; }

        [JsonProperty("elecAudioOut")]
        public BoundingBox ElecAudioOut { get; set; }

        [JsonProperty("elecAudioStereo")]
        public BoundingBox ElecAudioStereo { get; set; }

        [JsonProperty("elecCamera")]
        public BoundingBox ElecCamera { get; set; }

        [JsonProperty("elecDataIn")]
        public BoundingBox ElecDataIn { get; set; }

        [JsonProperty("elecDataOut")]
        public BoundingBox ElecDataOut { get; set; }

        [JsonProperty("elecDisc")]
        public Dictionary<string, long[]> ElecDisc { get; set; }

        [JsonProperty("elecDownload")]
        public BoundingBox ElecDownload { get; set; }

        [JsonProperty("elecEject")]
        public BoundingBox ElecEject { get; set; }

        [JsonProperty("elecFastForward")]
        public BoundingBox ElecFastForward { get; set; }

        [JsonProperty("elecHeadphones")]
        public BoundingBox ElecHeadphones { get; set; }

        [JsonProperty("elecHeadset")]
        public BoundingBox ElecHeadset { get; set; }

        [JsonProperty("elecLineIn")]
        public BoundingBox ElecLineIn { get; set; }

        [JsonProperty("elecLineOut")]
        public BoundingBox ElecLineOut { get; set; }

        [JsonProperty("elecLoop")]
        public BoundingBox ElecLoop { get; set; }

        [JsonProperty("elecLoudspeaker")]
        public BoundingBox ElecLoudspeaker { get; set; }

        [JsonProperty("elecMIDIController0")]
        public BoundingBox ElecMidiController0 { get; set; }

        [JsonProperty("elecMIDIController100")]
        public BoundingBox ElecMidiController100 { get; set; }

        [JsonProperty("elecMIDIController20")]
        public BoundingBox ElecMidiController20 { get; set; }

        [JsonProperty("elecMIDIController40")]
        public BoundingBox ElecMidiController40 { get; set; }

        [JsonProperty("elecMIDIController60")]
        public BoundingBox ElecMidiController60 { get; set; }

        [JsonProperty("elecMIDIController80")]
        public BoundingBox ElecMidiController80 { get; set; }

        [JsonProperty("elecMIDIIn")]
        public BoundingBox ElecMidiIn { get; set; }

        [JsonProperty("elecMIDIOut")]
        public BoundingBox ElecMidiOut { get; set; }

        [JsonProperty("elecMicrophone")]
        public BoundingBox ElecMicrophone { get; set; }

        [JsonProperty("elecMicrophoneMute")]
        public BoundingBox ElecMicrophoneMute { get; set; }

        [JsonProperty("elecMicrophoneUnmute")]
        public BoundingBox ElecMicrophoneUnmute { get; set; }

        [JsonProperty("elecMixingConsole")]
        public BoundingBox ElecMixingConsole { get; set; }

        [JsonProperty("elecMonitor")]
        public BoundingBox ElecMonitor { get; set; }

        [JsonProperty("elecMute")]
        public BoundingBox ElecMute { get; set; }

        [JsonProperty("elecPause")]
        public BoundingBox ElecPause { get; set; }

        [JsonProperty("elecPlay")]
        public BoundingBox ElecPlay { get; set; }

        [JsonProperty("elecPowerOnOff")]
        public BoundingBox ElecPowerOnOff { get; set; }

        [JsonProperty("elecProjector")]
        public BoundingBox ElecProjector { get; set; }

        [JsonProperty("elecReplay")]
        public BoundingBox ElecReplay { get; set; }

        [JsonProperty("elecRewind")]
        public BoundingBox ElecRewind { get; set; }

        [JsonProperty("elecShuffle")]
        public BoundingBox ElecShuffle { get; set; }

        [JsonProperty("elecSkipBackwards")]
        public BoundingBox ElecSkipBackwards { get; set; }

        [JsonProperty("elecSkipForwards")]
        public BoundingBox ElecSkipForwards { get; set; }

        [JsonProperty("elecStop")]
        public BoundingBox ElecStop { get; set; }

        [JsonProperty("elecTape")]
        public BoundingBox ElecTape { get; set; }

        [JsonProperty("elecUSB")]
        public BoundingBox ElecUsb { get; set; }

        [JsonProperty("elecUnmute")]
        public BoundingBox ElecUnmute { get; set; }

        [JsonProperty("elecUpload")]
        public BoundingBox ElecUpload { get; set; }

        [JsonProperty("elecVideoCamera")]
        public BoundingBox ElecVideoCamera { get; set; }

        [JsonProperty("elecVideoIn")]
        public BoundingBox ElecVideoIn { get; set; }

        [JsonProperty("elecVideoOut")]
        public BoundingBox ElecVideoOut { get; set; }

        [JsonProperty("elecVolumeFader")]
        public BoundingBox ElecVolumeFader { get; set; }

        [JsonProperty("elecVolumeFaderThumb")]
        public BoundingBox ElecVolumeFaderThumb { get; set; }

        [JsonProperty("elecVolumeLevel0")]
        public BoundingBox ElecVolumeLevel0 { get; set; }

        [JsonProperty("elecVolumeLevel100")]
        public BoundingBox ElecVolumeLevel100 { get; set; }

        [JsonProperty("elecVolumeLevel20")]
        public BoundingBox ElecVolumeLevel20 { get; set; }

        [JsonProperty("elecVolumeLevel40")]
        public BoundingBox ElecVolumeLevel40 { get; set; }

        [JsonProperty("elecVolumeLevel60")]
        public BoundingBox ElecVolumeLevel60 { get; set; }

        [JsonProperty("elecVolumeLevel80")]
        public BoundingBox ElecVolumeLevel80 { get; set; }

        [JsonProperty("fClef")]
        public BoundingBox FClef { get; set; }

        [JsonProperty("fClef15ma")]
        public BoundingBox FClef15Ma { get; set; }

        [JsonProperty("fClef15mb")]
        public BoundingBox FClef15Mb { get; set; }

        [JsonProperty("fClef19thCentury")]
        public BoundingBox FClef19ThCentury { get; set; }

        [JsonProperty("fClef5Below")]
        public BoundingBox FClef5Below { get; set; }

        [JsonProperty("fClef8va")]
        public BoundingBox FClef8Va { get; set; }

        [JsonProperty("fClef8vb")]
        public BoundingBox FClef8Vb { get; set; }

        [JsonProperty("fClefArrowDown")]
        public BoundingBox FClefArrowDown { get; set; }

        [JsonProperty("fClefArrowUp")]
        public BoundingBox FClefArrowUp { get; set; }

        [JsonProperty("fClefChange")]
        public BoundingBox FClefChange { get; set; }

        [JsonProperty("fClefFrench")]
        public BoundingBox FClefFrench { get; set; }

        [JsonProperty("fClefReversed")]
        public BoundingBox FClefReversed { get; set; }

        [JsonProperty("fClefSmall")]
        public BoundingBox FClefSmall { get; set; }

        [JsonProperty("fClefTurned")]
        public BoundingBox FClefTurned { get; set; }

        [JsonProperty("fermataAbove")]
        public BoundingBox FermataAbove { get; set; }

        [JsonProperty("fermataBelow")]
        public BoundingBox FermataBelow { get; set; }

        [JsonProperty("fermataLongAbove")]
        public BoundingBox FermataLongAbove { get; set; }

        [JsonProperty("fermataLongBelow")]
        public BoundingBox FermataLongBelow { get; set; }

        [JsonProperty("fermataLongHenzeAbove")]
        public BoundingBox FermataLongHenzeAbove { get; set; }

        [JsonProperty("fermataLongHenzeBelow")]
        public BoundingBox FermataLongHenzeBelow { get; set; }

        [JsonProperty("fermataShortAbove")]
        public BoundingBox FermataShortAbove { get; set; }

        [JsonProperty("fermataShortBelow")]
        public BoundingBox FermataShortBelow { get; set; }

        [JsonProperty("fermataShortHenzeAbove")]
        public BoundingBox FermataShortHenzeAbove { get; set; }

        [JsonProperty("fermataShortHenzeBelow")]
        public BoundingBox FermataShortHenzeBelow { get; set; }

        [JsonProperty("fermataVeryLongAbove")]
        public BoundingBox FermataVeryLongAbove { get; set; }

        [JsonProperty("fermataVeryLongBelow")]
        public BoundingBox FermataVeryLongBelow { get; set; }

        [JsonProperty("fermataVeryShortAbove")]
        public BoundingBox FermataVeryShortAbove { get; set; }

        [JsonProperty("fermataVeryShortBelow")]
        public BoundingBox FermataVeryShortBelow { get; set; }

        [JsonProperty("figbass0")]
        public BoundingBox Figbass0 { get; set; }

        [JsonProperty("figbass1")]
        public BoundingBox Figbass1 { get; set; }

        [JsonProperty("figbass2")]
        public BoundingBox Figbass2 { get; set; }

        [JsonProperty("figbass2Raised")]
        public BoundingBox Figbass2Raised { get; set; }

        [JsonProperty("figbass3")]
        public BoundingBox Figbass3 { get; set; }

        [JsonProperty("figbass4")]
        public BoundingBox Figbass4 { get; set; }

        [JsonProperty("figbass4Raised")]
        public BoundingBox Figbass4Raised { get; set; }

        [JsonProperty("figbass5")]
        public BoundingBox Figbass5 { get; set; }

        [JsonProperty("figbass5Raised1")]
        public BoundingBox Figbass5Raised1 { get; set; }

        [JsonProperty("figbass5Raised2")]
        public BoundingBox Figbass5Raised2 { get; set; }

        [JsonProperty("figbass5Raised3")]
        public BoundingBox Figbass5Raised3 { get; set; }

        [JsonProperty("figbass6")]
        public BoundingBox Figbass6 { get; set; }

        [JsonProperty("figbass6Raised")]
        public BoundingBox Figbass6Raised { get; set; }

        [JsonProperty("figbass6Raised2")]
        public BoundingBox Figbass6Raised2 { get; set; }

        [JsonProperty("figbass7")]
        public BoundingBox Figbass7 { get; set; }

        [JsonProperty("figbass7Diminished")]
        public BoundingBox Figbass7Diminished { get; set; }

        [JsonProperty("figbass7Raised1")]
        public BoundingBox Figbass7Raised1 { get; set; }

        [JsonProperty("figbass7Raised2")]
        public BoundingBox Figbass7Raised2 { get; set; }

        [JsonProperty("figbass8")]
        public BoundingBox Figbass8 { get; set; }

        [JsonProperty("figbass9")]
        public BoundingBox Figbass9 { get; set; }

        [JsonProperty("figbass9Raised")]
        public BoundingBox Figbass9Raised { get; set; }

        [JsonProperty("figbassBracketLeft")]
        public BoundingBox FigbassBracketLeft { get; set; }

        [JsonProperty("figbassBracketRight")]
        public BoundingBox FigbassBracketRight { get; set; }

        [JsonProperty("figbassCombiningLowering")]
        public BoundingBox FigbassCombiningLowering { get; set; }

        [JsonProperty("figbassCombiningRaising")]
        public BoundingBox FigbassCombiningRaising { get; set; }

        [JsonProperty("figbassDoubleFlat")]
        public BoundingBox FigbassDoubleFlat { get; set; }

        [JsonProperty("figbassDoubleSharp")]
        public BoundingBox FigbassDoubleSharp { get; set; }

        [JsonProperty("figbassFlat")]
        public BoundingBox FigbassFlat { get; set; }

        [JsonProperty("figbassNatural")]
        public BoundingBox FigbassNatural { get; set; }

        [JsonProperty("figbassParensLeft")]
        public BoundingBox FigbassParensLeft { get; set; }

        [JsonProperty("figbassParensRight")]
        public BoundingBox FigbassParensRight { get; set; }

        [JsonProperty("figbassPlus")]
        public BoundingBox FigbassPlus { get; set; }

        [JsonProperty("figbassSharp")]
        public BoundingBox FigbassSharp { get; set; }

        [JsonProperty("fingering0")]
        public BoundingBox Fingering0 { get; set; }

        [JsonProperty("fingering1")]
        public BoundingBox Fingering1 { get; set; }

        [JsonProperty("fingering2")]
        public BoundingBox Fingering2 { get; set; }

        [JsonProperty("fingering3")]
        public BoundingBox Fingering3 { get; set; }

        [JsonProperty("fingering4")]
        public BoundingBox Fingering4 { get; set; }

        [JsonProperty("fingering5")]
        public BoundingBox Fingering5 { get; set; }

        [JsonProperty("fingeringALower")]
        public BoundingBox FingeringALower { get; set; }

        [JsonProperty("fingeringCLower")]
        public BoundingBox FingeringCLower { get; set; }

        [JsonProperty("fingeringELower")]
        public BoundingBox FingeringELower { get; set; }

        [JsonProperty("fingeringILower")]
        public BoundingBox FingeringILower { get; set; }

        [JsonProperty("fingeringMLower")]
        public BoundingBox FingeringMLower { get; set; }

        [JsonProperty("fingeringMultipleNotes")]
        public BoundingBox FingeringMultipleNotes { get; set; }

        [JsonProperty("fingeringOLower")]
        public BoundingBox FingeringOLower { get; set; }

        [JsonProperty("fingeringPLower")]
        public BoundingBox FingeringPLower { get; set; }

        [JsonProperty("fingeringSubstitutionAbove")]
        public BoundingBox FingeringSubstitutionAbove { get; set; }

        [JsonProperty("fingeringSubstitutionBelow")]
        public BoundingBox FingeringSubstitutionBelow { get; set; }

        [JsonProperty("fingeringSubstitutionDash")]
        public BoundingBox FingeringSubstitutionDash { get; set; }

        [JsonProperty("fingeringTLower")]
        public BoundingBox FingeringTLower { get; set; }

        [JsonProperty("fingeringTUpper")]
        public BoundingBox FingeringTUpper { get; set; }

        [JsonProperty("fingeringXLower")]
        public BoundingBox FingeringXLower { get; set; }

        [JsonProperty("flag1024thDown")]
        public BoundingBox Flag1024ThDown { get; set; }

        [JsonProperty("flag1024thDownSmall")]
        public BoundingBox Flag1024ThDownSmall { get; set; }

        [JsonProperty("flag1024thDownStraight")]
        public BoundingBox Flag1024ThDownStraight { get; set; }

        [JsonProperty("flag1024thUp")]
        public BoundingBox Flag1024ThUp { get; set; }

        [JsonProperty("flag1024thUpShort")]
        public BoundingBox Flag1024ThUpShort { get; set; }

        [JsonProperty("flag1024thUpSmall")]
        public BoundingBox Flag1024ThUpSmall { get; set; }

        [JsonProperty("flag1024thUpStraight")]
        public BoundingBox Flag1024ThUpStraight { get; set; }

        [JsonProperty("flag128thDown")]
        public BoundingBox Flag128ThDown { get; set; }

        [JsonProperty("flag128thDownSmall")]
        public BoundingBox Flag128ThDownSmall { get; set; }

        [JsonProperty("flag128thDownStraight")]
        public BoundingBox Flag128ThDownStraight { get; set; }

        [JsonProperty("flag128thUp")]
        public BoundingBox Flag128ThUp { get; set; }

        [JsonProperty("flag128thUpShort")]
        public BoundingBox Flag128ThUpShort { get; set; }

        [JsonProperty("flag128thUpSmall")]
        public BoundingBox Flag128ThUpSmall { get; set; }

        [JsonProperty("flag128thUpStraight")]
        public BoundingBox Flag128ThUpStraight { get; set; }

        [JsonProperty("flag16thDown")]
        public BoundingBox Flag16ThDown { get; set; }

        [JsonProperty("flag16thDownSmall")]
        public BoundingBox Flag16ThDownSmall { get; set; }

        [JsonProperty("flag16thDownStraight")]
        public BoundingBox Flag16ThDownStraight { get; set; }

        [JsonProperty("flag16thUp")]
        public BoundingBox Flag16ThUp { get; set; }

        [JsonProperty("flag16thUpShort")]
        public BoundingBox Flag16ThUpShort { get; set; }

        [JsonProperty("flag16thUpSmall")]
        public BoundingBox Flag16ThUpSmall { get; set; }

        [JsonProperty("flag16thUpStraight")]
        public BoundingBox Flag16ThUpStraight { get; set; }

        [JsonProperty("flag256thDown")]
        public BoundingBox Flag256ThDown { get; set; }

        [JsonProperty("flag256thDownSmall")]
        public BoundingBox Flag256ThDownSmall { get; set; }

        [JsonProperty("flag256thDownStraight")]
        public BoundingBox Flag256ThDownStraight { get; set; }

        [JsonProperty("flag256thUp")]
        public BoundingBox Flag256ThUp { get; set; }

        [JsonProperty("flag256thUpShort")]
        public BoundingBox Flag256ThUpShort { get; set; }

        [JsonProperty("flag256thUpSmall")]
        public BoundingBox Flag256ThUpSmall { get; set; }

        [JsonProperty("flag256thUpStraight")]
        public BoundingBox Flag256ThUpStraight { get; set; }

        [JsonProperty("flag32ndDown")]
        public BoundingBox Flag32NdDown { get; set; }

        [JsonProperty("flag32ndDownSmall")]
        public BoundingBox Flag32NdDownSmall { get; set; }

        [JsonProperty("flag32ndDownStraight")]
        public BoundingBox Flag32NdDownStraight { get; set; }

        [JsonProperty("flag32ndUp")]
        public BoundingBox Flag32NdUp { get; set; }

        [JsonProperty("flag32ndUpShort")]
        public BoundingBox Flag32NdUpShort { get; set; }

        [JsonProperty("flag32ndUpSmall")]
        public BoundingBox Flag32NdUpSmall { get; set; }

        [JsonProperty("flag32ndUpStraight")]
        public BoundingBox Flag32NdUpStraight { get; set; }

        [JsonProperty("flag512thDown")]
        public BoundingBox Flag512ThDown { get; set; }

        [JsonProperty("flag512thDownSmall")]
        public BoundingBox Flag512ThDownSmall { get; set; }

        [JsonProperty("flag512thDownStraight")]
        public BoundingBox Flag512ThDownStraight { get; set; }

        [JsonProperty("flag512thUp")]
        public BoundingBox Flag512ThUp { get; set; }

        [JsonProperty("flag512thUpShort")]
        public BoundingBox Flag512ThUpShort { get; set; }

        [JsonProperty("flag512thUpSmall")]
        public BoundingBox Flag512ThUpSmall { get; set; }

        [JsonProperty("flag512thUpStraight")]
        public BoundingBox Flag512ThUpStraight { get; set; }

        [JsonProperty("flag64thDown")]
        public BoundingBox Flag64ThDown { get; set; }

        [JsonProperty("flag64thDownSmall")]
        public BoundingBox Flag64ThDownSmall { get; set; }

        [JsonProperty("flag64thDownStraight")]
        public BoundingBox Flag64ThDownStraight { get; set; }

        [JsonProperty("flag64thUp")]
        public BoundingBox Flag64ThUp { get; set; }

        [JsonProperty("flag64thUpShort")]
        public BoundingBox Flag64ThUpShort { get; set; }

        [JsonProperty("flag64thUpSmall")]
        public BoundingBox Flag64ThUpSmall { get; set; }

        [JsonProperty("flag64thUpStraight")]
        public BoundingBox Flag64ThUpStraight { get; set; }

        [JsonProperty("flag8thDown")]
        public BoundingBox Flag8ThDown { get; set; }

        [JsonProperty("flag8thDownSmall")]
        public BoundingBox Flag8ThDownSmall { get; set; }

        [JsonProperty("flag8thDownStraight")]
        public BoundingBox Flag8ThDownStraight { get; set; }

        [JsonProperty("flag8thUp")]
        public BoundingBox Flag8ThUp { get; set; }

        [JsonProperty("flag8thUpShort")]
        public BoundingBox Flag8ThUpShort { get; set; }

        [JsonProperty("flag8thUpSmall")]
        public BoundingBox Flag8ThUpSmall { get; set; }

        [JsonProperty("flag8thUpStraight")]
        public BoundingBox Flag8ThUpStraight { get; set; }

        [JsonProperty("flagInternalDown")]
        public BoundingBox FlagInternalDown { get; set; }

        [JsonProperty("flagInternalUp")]
        public BoundingBox FlagInternalUp { get; set; }

        [JsonProperty("fretboard3String")]
        public BoundingBox Fretboard3String { get; set; }

        [JsonProperty("fretboard3StringNut")]
        public BoundingBox Fretboard3StringNut { get; set; }

        [JsonProperty("fretboard4String")]
        public BoundingBox Fretboard4String { get; set; }

        [JsonProperty("fretboard4StringNut")]
        public BoundingBox Fretboard4StringNut { get; set; }

        [JsonProperty("fretboard5String")]
        public BoundingBox Fretboard5String { get; set; }

        [JsonProperty("fretboard5StringNut")]
        public BoundingBox Fretboard5StringNut { get; set; }

        [JsonProperty("fretboard6String")]
        public BoundingBox Fretboard6String { get; set; }

        [JsonProperty("fretboard6StringNut")]
        public BoundingBox Fretboard6StringNut { get; set; }

        [JsonProperty("fretboardFilledCircle")]
        public BoundingBox FretboardFilledCircle { get; set; }

        [JsonProperty("fretboardO")]
        public BoundingBox FretboardO { get; set; }

        [JsonProperty("fretboardX")]
        public BoundingBox FretboardX { get; set; }

        [JsonProperty("functionAngleLeft")]
        public BoundingBox FunctionAngleLeft { get; set; }

        [JsonProperty("functionAngleRight")]
        public BoundingBox FunctionAngleRight { get; set; }

        [JsonProperty("functionBracketLeft")]
        public BoundingBox FunctionBracketLeft { get; set; }

        [JsonProperty("functionBracketRight")]
        public BoundingBox FunctionBracketRight { get; set; }

        [JsonProperty("functionDD")]
        public BoundingBox FunctionDd { get; set; }

        [JsonProperty("functionDLower")]
        public BoundingBox FunctionDLower { get; set; }

        [JsonProperty("functionDUpper")]
        public BoundingBox FunctionDUpper { get; set; }

        [JsonProperty("functionEight")]
        public BoundingBox FunctionEight { get; set; }

        [JsonProperty("functionFUpper")]
        public BoundingBox FunctionFUpper { get; set; }

        [JsonProperty("functionFive")]
        public BoundingBox FunctionFive { get; set; }

        [JsonProperty("functionFour")]
        public BoundingBox FunctionFour { get; set; }

        [JsonProperty("functionGLower")]
        public BoundingBox FunctionGLower { get; set; }

        [JsonProperty("functionGUpper")]
        public BoundingBox FunctionGUpper { get; set; }

        [JsonProperty("functionGreaterThan")]
        public BoundingBox FunctionGreaterThan { get; set; }

        [JsonProperty("functionILower")]
        public BoundingBox FunctionILower { get; set; }

        [JsonProperty("functionIUpper")]
        public BoundingBox FunctionIUpper { get; set; }

        [JsonProperty("functionKLower")]
        public BoundingBox FunctionKLower { get; set; }

        [JsonProperty("functionKUpper")]
        public BoundingBox FunctionKUpper { get; set; }

        [JsonProperty("functionLLower")]
        public BoundingBox FunctionLLower { get; set; }

        [JsonProperty("functionLUpper")]
        public BoundingBox FunctionLUpper { get; set; }

        [JsonProperty("functionLessThan")]
        public BoundingBox FunctionLessThan { get; set; }

        [JsonProperty("functionMLower")]
        public BoundingBox FunctionMLower { get; set; }

        [JsonProperty("functionMUpper")]
        public BoundingBox FunctionMUpper { get; set; }

        [JsonProperty("functionMinus")]
        public BoundingBox FunctionMinus { get; set; }

        [JsonProperty("functionNLower")]
        public BoundingBox FunctionNLower { get; set; }

        [JsonProperty("functionNUpper")]
        public BoundingBox FunctionNUpper { get; set; }

        [JsonProperty("functionNUpperSuperscript")]
        public BoundingBox FunctionNUpperSuperscript { get; set; }

        [JsonProperty("functionNine")]
        public BoundingBox FunctionNine { get; set; }

        [JsonProperty("functionOne")]
        public BoundingBox FunctionOne { get; set; }

        [JsonProperty("functionPLower")]
        public BoundingBox FunctionPLower { get; set; }

        [JsonProperty("functionPUpper")]
        public BoundingBox FunctionPUpper { get; set; }

        [JsonProperty("functionParensLeft")]
        public BoundingBox FunctionParensLeft { get; set; }

        [JsonProperty("functionParensRight")]
        public BoundingBox FunctionParensRight { get; set; }

        [JsonProperty("functionPlus")]
        public BoundingBox FunctionPlus { get; set; }

        [JsonProperty("functionRLower")]
        public BoundingBox FunctionRLower { get; set; }

        [JsonProperty("functionRepetition1")]
        public BoundingBox FunctionRepetition1 { get; set; }

        [JsonProperty("functionRepetition2")]
        public BoundingBox FunctionRepetition2 { get; set; }

        [JsonProperty("functionRing")]
        public BoundingBox FunctionRing { get; set; }

        [JsonProperty("functionSLower")]
        public BoundingBox FunctionSLower { get; set; }

        [JsonProperty("functionSSLower")]
        public BoundingBox FunctionSsLower { get; set; }

        [JsonProperty("functionSSUpper")]
        public BoundingBox FunctionSsUpper { get; set; }

        [JsonProperty("functionSUpper")]
        public BoundingBox FunctionSUpper { get; set; }

        [JsonProperty("functionSeven")]
        public BoundingBox FunctionSeven { get; set; }

        [JsonProperty("functionSix")]
        public BoundingBox FunctionSix { get; set; }

        [JsonProperty("functionSlashedDD")]
        public BoundingBox FunctionSlashedDd { get; set; }

        [JsonProperty("functionTLower")]
        public BoundingBox FunctionTLower { get; set; }

        [JsonProperty("functionTUpper")]
        public BoundingBox FunctionTUpper { get; set; }

        [JsonProperty("functionThree")]
        public BoundingBox FunctionThree { get; set; }

        [JsonProperty("functionTwo")]
        public BoundingBox FunctionTwo { get; set; }

        [JsonProperty("functionVLower")]
        public BoundingBox FunctionVLower { get; set; }

        [JsonProperty("functionVUpper")]
        public BoundingBox FunctionVUpper { get; set; }

        [JsonProperty("functionZero")]
        public BoundingBox FunctionZero { get; set; }

        [JsonProperty("gClef")]
        public BoundingBox GClef { get; set; }

        [JsonProperty("gClef0Below")]
        public BoundingBox GClef0Below { get; set; }

        [JsonProperty("gClef10Below")]
        public BoundingBox GClef10Below { get; set; }

        [JsonProperty("gClef11Below")]
        public BoundingBox GClef11Below { get; set; }

        [JsonProperty("gClef12Below")]
        public BoundingBox GClef12Below { get; set; }

        [JsonProperty("gClef13Below")]
        public BoundingBox GClef13Below { get; set; }

        [JsonProperty("gClef14Below")]
        public BoundingBox GClef14Below { get; set; }

        [JsonProperty("gClef15Below")]
        public BoundingBox GClef15Below { get; set; }

        [JsonProperty("gClef15ma")]
        public BoundingBox GClef15Ma { get; set; }

        [JsonProperty("gClef15mb")]
        public BoundingBox GClef15Mb { get; set; }

        [JsonProperty("gClef16Below")]
        public BoundingBox GClef16Below { get; set; }

        [JsonProperty("gClef17Below")]
        public BoundingBox GClef17Below { get; set; }

        [JsonProperty("gClef2Above")]
        public BoundingBox GClef2Above { get; set; }

        [JsonProperty("gClef2Below")]
        public BoundingBox GClef2Below { get; set; }

        [JsonProperty("gClef3Above")]
        public BoundingBox GClef3Above { get; set; }

        [JsonProperty("gClef3Below")]
        public BoundingBox GClef3Below { get; set; }

        [JsonProperty("gClef4Above")]
        public BoundingBox GClef4Above { get; set; }

        [JsonProperty("gClef4Below")]
        public BoundingBox GClef4Below { get; set; }

        [JsonProperty("gClef5Above")]
        public BoundingBox GClef5Above { get; set; }

        [JsonProperty("gClef5Below")]
        public BoundingBox GClef5Below { get; set; }

        [JsonProperty("gClef6Above")]
        public BoundingBox GClef6Above { get; set; }

        [JsonProperty("gClef6Below")]
        public BoundingBox GClef6Below { get; set; }

        [JsonProperty("gClef7Above")]
        public BoundingBox GClef7Above { get; set; }

        [JsonProperty("gClef7Below")]
        public BoundingBox GClef7Below { get; set; }

        [JsonProperty("gClef8Above")]
        public BoundingBox GClef8Above { get; set; }

        [JsonProperty("gClef8Below")]
        public BoundingBox GClef8Below { get; set; }

        [JsonProperty("gClef8va")]
        public BoundingBox GClef8Va { get; set; }

        [JsonProperty("gClef8vb")]
        public BoundingBox GClef8Vb { get; set; }

        [JsonProperty("gClef8vbCClef")]
        public BoundingBox GClef8VbCClef { get; set; }

        [JsonProperty("gClef8vbOld")]
        public BoundingBox GClef8VbOld { get; set; }

        [JsonProperty("gClef8vbParens")]
        public BoundingBox GClef8VbParens { get; set; }

        [JsonProperty("gClef9Above")]
        public BoundingBox GClef9Above { get; set; }

        [JsonProperty("gClef9Below")]
        public BoundingBox GClef9Below { get; set; }

        [JsonProperty("gClefArrowDown")]
        public BoundingBox GClefArrowDown { get; set; }

        [JsonProperty("gClefArrowUp")]
        public BoundingBox GClefArrowUp { get; set; }

        [JsonProperty("gClefChange")]
        public BoundingBox GClefChange { get; set; }

        [JsonProperty("gClefFlat10Below")]
        public BoundingBox GClefFlat10Below { get; set; }

        [JsonProperty("gClefFlat11Below")]
        public BoundingBox GClefFlat11Below { get; set; }

        [JsonProperty("gClefFlat13Below")]
        public BoundingBox GClefFlat13Below { get; set; }

        [JsonProperty("gClefFlat14Below")]
        public BoundingBox GClefFlat14Below { get; set; }

        [JsonProperty("gClefFlat15Below")]
        public BoundingBox GClefFlat15Below { get; set; }

        [JsonProperty("gClefFlat16Below")]
        public BoundingBox GClefFlat16Below { get; set; }

        [JsonProperty("gClefFlat1Below")]
        public BoundingBox GClefFlat1Below { get; set; }

        [JsonProperty("gClefFlat2Above")]
        public BoundingBox GClefFlat2Above { get; set; }

        [JsonProperty("gClefFlat2Below")]
        public BoundingBox GClefFlat2Below { get; set; }

        [JsonProperty("gClefFlat3Above")]
        public BoundingBox GClefFlat3Above { get; set; }

        [JsonProperty("gClefFlat3Below")]
        public BoundingBox GClefFlat3Below { get; set; }

        [JsonProperty("gClefFlat4Below")]
        public BoundingBox GClefFlat4Below { get; set; }

        [JsonProperty("gClefFlat5Above")]
        public BoundingBox GClefFlat5Above { get; set; }

        [JsonProperty("gClefFlat6Above")]
        public BoundingBox GClefFlat6Above { get; set; }

        [JsonProperty("gClefFlat6Below")]
        public BoundingBox GClefFlat6Below { get; set; }

        [JsonProperty("gClefFlat7Above")]
        public BoundingBox GClefFlat7Above { get; set; }

        [JsonProperty("gClefFlat7Below")]
        public BoundingBox GClefFlat7Below { get; set; }

        [JsonProperty("gClefFlat8Above")]
        public BoundingBox GClefFlat8Above { get; set; }

        [JsonProperty("gClefFlat9Above")]
        public BoundingBox GClefFlat9Above { get; set; }

        [JsonProperty("gClefFlat9Below")]
        public BoundingBox GClefFlat9Below { get; set; }

        [JsonProperty("gClefLigatedNumberAbove")]
        public BoundingBox GClefLigatedNumberAbove { get; set; }

        [JsonProperty("gClefLigatedNumberBelow")]
        public BoundingBox GClefLigatedNumberBelow { get; set; }

        [JsonProperty("gClefNat2Below")]
        public BoundingBox GClefNat2Below { get; set; }

        [JsonProperty("gClefNatural10Below")]
        public BoundingBox GClefNatural10Below { get; set; }

        [JsonProperty("gClefNatural13Below")]
        public BoundingBox GClefNatural13Below { get; set; }

        [JsonProperty("gClefNatural17Below")]
        public BoundingBox GClefNatural17Below { get; set; }

        [JsonProperty("gClefNatural2Above")]
        public BoundingBox GClefNatural2Above { get; set; }

        [JsonProperty("gClefNatural3Above")]
        public BoundingBox GClefNatural3Above { get; set; }

        [JsonProperty("gClefNatural3Below")]
        public BoundingBox GClefNatural3Below { get; set; }

        [JsonProperty("gClefNatural6Above")]
        public BoundingBox GClefNatural6Above { get; set; }

        [JsonProperty("gClefNatural6Below")]
        public BoundingBox GClefNatural6Below { get; set; }

        [JsonProperty("gClefNatural7Above")]
        public BoundingBox GClefNatural7Above { get; set; }

        [JsonProperty("gClefNatural9Above")]
        public BoundingBox GClefNatural9Above { get; set; }

        [JsonProperty("gClefNatural9Below")]
        public BoundingBox GClefNatural9Below { get; set; }

        [JsonProperty("gClefReversed")]
        public BoundingBox GClefReversed { get; set; }

        [JsonProperty("gClefSharp12Below")]
        public BoundingBox GClefSharp12Below { get; set; }

        [JsonProperty("gClefSharp1Above")]
        public BoundingBox GClefSharp1Above { get; set; }

        [JsonProperty("gClefSharp4Above")]
        public BoundingBox GClefSharp4Above { get; set; }

        [JsonProperty("gClefSharp5Below")]
        public BoundingBox GClefSharp5Below { get; set; }

        [JsonProperty("gClefSmall")]
        public BoundingBox GClefSmall { get; set; }

        [JsonProperty("gClefTurned")]
        public BoundingBox GClefTurned { get; set; }

        [JsonProperty("glissandoDown")]
        public BoundingBox GlissandoDown { get; set; }

        [JsonProperty("glissandoUp")]
        public BoundingBox GlissandoUp { get; set; }

        [JsonProperty("graceNoteAcciaccaturaStemDown")]
        public BoundingBox GraceNoteAcciaccaturaStemDown { get; set; }

        [JsonProperty("graceNoteAcciaccaturaStemUp")]
        public BoundingBox GraceNoteAcciaccaturaStemUp { get; set; }

        [JsonProperty("graceNoteAppoggiaturaStemDown")]
        public BoundingBox GraceNoteAppoggiaturaStemDown { get; set; }

        [JsonProperty("graceNoteAppoggiaturaStemUp")]
        public BoundingBox GraceNoteAppoggiaturaStemUp { get; set; }

        [JsonProperty("graceNoteSlashStemDown")]
        public BoundingBox GraceNoteSlashStemDown { get; set; }

        [JsonProperty("graceNoteSlashStemUp")]
        public BoundingBox GraceNoteSlashStemUp { get; set; }

        [JsonProperty("guitarBarreFull")]
        public BoundingBox GuitarBarreFull { get; set; }

        [JsonProperty("guitarBarreHalf")]
        public BoundingBox GuitarBarreHalf { get; set; }

        [JsonProperty("guitarBarreHalfHorizontalFractionSlash")]
        public BoundingBox GuitarBarreHalfHorizontalFractionSlash { get; set; }

        [JsonProperty("guitarClosePedal")]
        public BoundingBox GuitarClosePedal { get; set; }

        [JsonProperty("guitarFadeIn")]
        public BoundingBox GuitarFadeIn { get; set; }

        [JsonProperty("guitarFadeOut")]
        public BoundingBox GuitarFadeOut { get; set; }

        [JsonProperty("guitarGolpe")]
        public BoundingBox GuitarGolpe { get; set; }

        [JsonProperty("guitarGolpeFlamenco")]
        public BoundingBox GuitarGolpeFlamenco { get; set; }

        [JsonProperty("guitarHalfOpenPedal")]
        public BoundingBox GuitarHalfOpenPedal { get; set; }

        [JsonProperty("guitarLeftHandTapping")]
        public BoundingBox GuitarLeftHandTapping { get; set; }

        [JsonProperty("guitarOpenPedal")]
        public BoundingBox GuitarOpenPedal { get; set; }

        [JsonProperty("guitarRightHandTapping")]
        public BoundingBox GuitarRightHandTapping { get; set; }

        [JsonProperty("guitarShake")]
        public BoundingBox GuitarShake { get; set; }

        [JsonProperty("guitarString0")]
        public BoundingBox GuitarString0 { get; set; }

        [JsonProperty("guitarString1")]
        public BoundingBox GuitarString1 { get; set; }

        [JsonProperty("guitarString2")]
        public BoundingBox GuitarString2 { get; set; }

        [JsonProperty("guitarString3")]
        public BoundingBox GuitarString3 { get; set; }

        [JsonProperty("guitarString4")]
        public BoundingBox GuitarString4 { get; set; }

        [JsonProperty("guitarString5")]
        public BoundingBox GuitarString5 { get; set; }

        [JsonProperty("guitarString6")]
        public BoundingBox GuitarString6 { get; set; }

        [JsonProperty("guitarString7")]
        public BoundingBox GuitarString7 { get; set; }

        [JsonProperty("guitarString8")]
        public BoundingBox GuitarString8 { get; set; }

        [JsonProperty("guitarString9")]
        public BoundingBox GuitarString9 { get; set; }

        [JsonProperty("guitarStrumDown")]
        public BoundingBox GuitarStrumDown { get; set; }

        [JsonProperty("guitarStrumUp")]
        public BoundingBox GuitarStrumUp { get; set; }

        [JsonProperty("guitarVibratoBarDip")]
        public BoundingBox GuitarVibratoBarDip { get; set; }

        [JsonProperty("guitarVibratoBarScoop")]
        public BoundingBox GuitarVibratoBarScoop { get; set; }

        [JsonProperty("guitarVibratoStroke")]
        public BoundingBox GuitarVibratoStroke { get; set; }

        [JsonProperty("guitarVolumeSwell")]
        public BoundingBox GuitarVolumeSwell { get; set; }

        [JsonProperty("guitarWideVibratoStroke")]
        public BoundingBox GuitarWideVibratoStroke { get; set; }

        [JsonProperty("handbellsBelltree")]
        public BoundingBox HandbellsBelltree { get; set; }

        [JsonProperty("handbellsDamp3")]
        public BoundingBox HandbellsDamp3 { get; set; }

        [JsonProperty("handbellsEcho1")]
        public BoundingBox HandbellsEcho1 { get; set; }

        [JsonProperty("handbellsEcho2")]
        public BoundingBox HandbellsEcho2 { get; set; }

        [JsonProperty("handbellsGyro")]
        public BoundingBox HandbellsGyro { get; set; }

        [JsonProperty("handbellsHandMartellato")]
        public BoundingBox HandbellsHandMartellato { get; set; }

        [JsonProperty("handbellsMalletBellOnTable")]
        public BoundingBox HandbellsMalletBellOnTable { get; set; }

        [JsonProperty("handbellsMalletBellSuspended")]
        public BoundingBox HandbellsMalletBellSuspended { get; set; }

        [JsonProperty("handbellsMalletLft")]
        public BoundingBox HandbellsMalletLft { get; set; }

        [JsonProperty("handbellsMartellato")]
        public BoundingBox HandbellsMartellato { get; set; }

        [JsonProperty("handbellsMartellatoLift")]
        public BoundingBox HandbellsMartellatoLift { get; set; }

        [JsonProperty("handbellsMutedMartellato")]
        public BoundingBox HandbellsMutedMartellato { get; set; }

        [JsonProperty("handbellsPluckLift")]
        public BoundingBox HandbellsPluckLift { get; set; }

        [JsonProperty("handbellsSwing")]
        public BoundingBox HandbellsSwing { get; set; }

        [JsonProperty("handbellsSwingDown")]
        public BoundingBox HandbellsSwingDown { get; set; }

        [JsonProperty("handbellsSwingUp")]
        public BoundingBox HandbellsSwingUp { get; set; }

        [JsonProperty("handbellsTablePairBells")]
        public BoundingBox HandbellsTablePairBells { get; set; }

        [JsonProperty("handbellsTableSingleBell")]
        public BoundingBox HandbellsTableSingleBell { get; set; }

        [JsonProperty("harpMetalRod")]
        public BoundingBox HarpMetalRod { get; set; }

        [JsonProperty("harpMetalRodAlt")]
        public BoundingBox HarpMetalRodAlt { get; set; }

        [JsonProperty("harpPedalCentered")]
        public BoundingBox HarpPedalCentered { get; set; }

        [JsonProperty("harpPedalDivider")]
        public Dictionary<string, long[]> HarpPedalDivider { get; set; }

        [JsonProperty("harpPedalLowered")]
        public BoundingBox HarpPedalLowered { get; set; }

        [JsonProperty("harpPedalRaised")]
        public BoundingBox HarpPedalRaised { get; set; }

        [JsonProperty("harpSalzedoAeolianAscending")]
        public BoundingBox HarpSalzedoAeolianAscending { get; set; }

        [JsonProperty("harpSalzedoAeolianDescending")]
        public BoundingBox HarpSalzedoAeolianDescending { get; set; }

        [JsonProperty("harpSalzedoDampAbove")]
        public BoundingBox HarpSalzedoDampAbove { get; set; }

        [JsonProperty("harpSalzedoDampBelow")]
        public BoundingBox HarpSalzedoDampBelow { get; set; }

        [JsonProperty("harpSalzedoDampBothHands")]
        public BoundingBox HarpSalzedoDampBothHands { get; set; }

        [JsonProperty("harpSalzedoDampLowStrings")]
        public BoundingBox HarpSalzedoDampLowStrings { get; set; }

        [JsonProperty("harpSalzedoFluidicSoundsLeft")]
        public BoundingBox HarpSalzedoFluidicSoundsLeft { get; set; }

        [JsonProperty("harpSalzedoFluidicSoundsRight")]
        public BoundingBox HarpSalzedoFluidicSoundsRight { get; set; }

        [JsonProperty("harpSalzedoIsolatedSounds")]
        public BoundingBox HarpSalzedoIsolatedSounds { get; set; }

        [JsonProperty("harpSalzedoMetallicSounds")]
        public BoundingBox HarpSalzedoMetallicSounds { get; set; }

        [JsonProperty("harpSalzedoMetallicSoundsOneString")]
        public BoundingBox HarpSalzedoMetallicSoundsOneString { get; set; }

        [JsonProperty("harpSalzedoMuffleTotally")]
        public BoundingBox HarpSalzedoMuffleTotally { get; set; }

        [JsonProperty("harpSalzedoOboicFlux")]
        public BoundingBox HarpSalzedoOboicFlux { get; set; }

        [JsonProperty("harpSalzedoPlayUpperEnd")]
        public BoundingBox HarpSalzedoPlayUpperEnd { get; set; }

        [JsonProperty("harpSalzedoSlideWithSuppleness")]
        public BoundingBox HarpSalzedoSlideWithSuppleness { get; set; }

        [JsonProperty("harpSalzedoSnareDrum")]
        public Dictionary<string, long[]> HarpSalzedoSnareDrum { get; set; }

        [JsonProperty("harpSalzedoTamTamSounds")]
        public BoundingBox HarpSalzedoTamTamSounds { get; set; }

        [JsonProperty("harpSalzedoThunderEffect")]
        public BoundingBox HarpSalzedoThunderEffect { get; set; }

        [JsonProperty("harpSalzedoTimpanicSounds")]
        public BoundingBox HarpSalzedoTimpanicSounds { get; set; }

        [JsonProperty("harpSalzedoWhistlingSounds")]
        public BoundingBox HarpSalzedoWhistlingSounds { get; set; }

        [JsonProperty("harpStringNoiseStem")]
        public BoundingBox HarpStringNoiseStem { get; set; }

        [JsonProperty("harpTuningKey")]
        public BoundingBox HarpTuningKey { get; set; }

        [JsonProperty("harpTuningKeyAlt")]
        public BoundingBox HarpTuningKeyAlt { get; set; }

        [JsonProperty("harpTuningKeyGlissando")]
        public BoundingBox HarpTuningKeyGlissando { get; set; }

        [JsonProperty("harpTuningKeyHandle")]
        public BoundingBox HarpTuningKeyHandle { get; set; }

        [JsonProperty("harpTuningKeyShank")]
        public BoundingBox HarpTuningKeyShank { get; set; }

        [JsonProperty("keyboardBebung2DotsAbove")]
        public BoundingBox KeyboardBebung2DotsAbove { get; set; }

        [JsonProperty("keyboardBebung2DotsBelow")]
        public BoundingBox KeyboardBebung2DotsBelow { get; set; }

        [JsonProperty("keyboardBebung3DotsAbove")]
        public BoundingBox KeyboardBebung3DotsAbove { get; set; }

        [JsonProperty("keyboardBebung3DotsBelow")]
        public BoundingBox KeyboardBebung3DotsBelow { get; set; }

        [JsonProperty("keyboardBebung4DotsAbove")]
        public BoundingBox KeyboardBebung4DotsAbove { get; set; }

        [JsonProperty("keyboardBebung4DotsBelow")]
        public BoundingBox KeyboardBebung4DotsBelow { get; set; }

        [JsonProperty("keyboardLeftPedalPictogram")]
        public BoundingBox KeyboardLeftPedalPictogram { get; set; }

        [JsonProperty("keyboardMiddlePedalPictogram")]
        public BoundingBox KeyboardMiddlePedalPictogram { get; set; }

        [JsonProperty("keyboardPedalD")]
        public BoundingBox KeyboardPedalD { get; set; }

        [JsonProperty("keyboardPedalDot")]
        public BoundingBox KeyboardPedalDot { get; set; }

        [JsonProperty("keyboardPedalE")]
        public BoundingBox KeyboardPedalE { get; set; }

        [JsonProperty("keyboardPedalHalf")]
        public BoundingBox KeyboardPedalHalf { get; set; }

        [JsonProperty("keyboardPedalHalf2")]
        public BoundingBox KeyboardPedalHalf2 { get; set; }

        [JsonProperty("keyboardPedalHalf3")]
        public BoundingBox KeyboardPedalHalf3 { get; set; }

        [JsonProperty("keyboardPedalHeel1")]
        public BoundingBox KeyboardPedalHeel1 { get; set; }

        [JsonProperty("keyboardPedalHeel2")]
        public BoundingBox KeyboardPedalHeel2 { get; set; }

        [JsonProperty("keyboardPedalHeel3")]
        public Dictionary<string, long[]> KeyboardPedalHeel3 { get; set; }

        [JsonProperty("keyboardPedalHeelToToe")]
        public BoundingBox KeyboardPedalHeelToToe { get; set; }

        [JsonProperty("keyboardPedalHeelToe")]
        public BoundingBox KeyboardPedalHeelToe { get; set; }

        [JsonProperty("keyboardPedalHookEnd")]
        public BoundingBox KeyboardPedalHookEnd { get; set; }

        [JsonProperty("keyboardPedalHookStart")]
        public BoundingBox KeyboardPedalHookStart { get; set; }

        [JsonProperty("keyboardPedalHyphen")]
        public BoundingBox KeyboardPedalHyphen { get; set; }

        [JsonProperty("keyboardPedalP")]
        public BoundingBox KeyboardPedalP { get; set; }

        [JsonProperty("keyboardPedalPed")]
        public BoundingBox KeyboardPedalPed { get; set; }

        [JsonProperty("keyboardPedalPedNoDot")]
        public BoundingBox KeyboardPedalPedNoDot { get; set; }

        [JsonProperty("keyboardPedalS")]
        public BoundingBox KeyboardPedalS { get; set; }

        [JsonProperty("keyboardPedalSost")]
        public BoundingBox KeyboardPedalSost { get; set; }

        [JsonProperty("keyboardPedalSostNoDot")]
        public BoundingBox KeyboardPedalSostNoDot { get; set; }

        [JsonProperty("keyboardPedalToe1")]
        public BoundingBox KeyboardPedalToe1 { get; set; }

        [JsonProperty("keyboardPedalToe2")]
        public BoundingBox KeyboardPedalToe2 { get; set; }

        [JsonProperty("keyboardPedalToeToHeel")]
        public BoundingBox KeyboardPedalToeToHeel { get; set; }

        [JsonProperty("keyboardPedalUp")]
        public BoundingBox KeyboardPedalUp { get; set; }

        [JsonProperty("keyboardPedalUpNotch")]
        public BoundingBox KeyboardPedalUpNotch { get; set; }

        [JsonProperty("keyboardPedalUpSpecial")]
        public BoundingBox KeyboardPedalUpSpecial { get; set; }

        [JsonProperty("keyboardPlayWithLH")]
        public BoundingBox KeyboardPlayWithLh { get; set; }

        [JsonProperty("keyboardPlayWithLHEnd")]
        public BoundingBox KeyboardPlayWithLhEnd { get; set; }

        [JsonProperty("keyboardPlayWithRH")]
        public BoundingBox KeyboardPlayWithRh { get; set; }

        [JsonProperty("keyboardPlayWithRHEnd")]
        public BoundingBox KeyboardPlayWithRhEnd { get; set; }

        [JsonProperty("keyboardPluckInside")]
        public BoundingBox KeyboardPluckInside { get; set; }

        [JsonProperty("keyboardRightPedalPictogram")]
        public BoundingBox KeyboardRightPedalPictogram { get; set; }

        [JsonProperty("kievanAccidentalFlat")]
        public BoundingBox KievanAccidentalFlat { get; set; }

        [JsonProperty("kievanAccidentalSharp")]
        public BoundingBox KievanAccidentalSharp { get; set; }

        [JsonProperty("kievanAugmentationDot")]
        public BoundingBox KievanAugmentationDot { get; set; }

        [JsonProperty("kievanCClef")]
        public BoundingBox KievanCClef { get; set; }

        [JsonProperty("kievanEndingSymbol")]
        public BoundingBox KievanEndingSymbol { get; set; }

        [JsonProperty("kievanNote8thStemDown")]
        public BoundingBox KievanNote8ThStemDown { get; set; }

        [JsonProperty("kievanNote8thStemUp")]
        public BoundingBox KievanNote8ThStemUp { get; set; }

        [JsonProperty("kievanNoteBeam")]
        public BoundingBox KievanNoteBeam { get; set; }

        [JsonProperty("kievanNoteHalfStaffLine")]
        public BoundingBox KievanNoteHalfStaffLine { get; set; }

        [JsonProperty("kievanNoteHalfStaffSpace")]
        public BoundingBox KievanNoteHalfStaffSpace { get; set; }

        [JsonProperty("kievanNoteQuarterStemDown")]
        public BoundingBox KievanNoteQuarterStemDown { get; set; }

        [JsonProperty("kievanNoteQuarterStemUp")]
        public BoundingBox KievanNoteQuarterStemUp { get; set; }

        [JsonProperty("kievanNoteReciting")]
        public BoundingBox KievanNoteReciting { get; set; }

        [JsonProperty("kievanNoteWhole")]
        public BoundingBox KievanNoteWhole { get; set; }

        [JsonProperty("kievanNoteWholeFinal")]
        public BoundingBox KievanNoteWholeFinal { get; set; }

        [JsonProperty("kodalyHandDo")]
        public BoundingBox KodalyHandDo { get; set; }

        [JsonProperty("kodalyHandFa")]
        public BoundingBox KodalyHandFa { get; set; }

        [JsonProperty("kodalyHandLa")]
        public BoundingBox KodalyHandLa { get; set; }

        [JsonProperty("kodalyHandMi")]
        public BoundingBox KodalyHandMi { get; set; }

        [JsonProperty("kodalyHandRe")]
        public BoundingBox KodalyHandRe { get; set; }

        [JsonProperty("kodalyHandSo")]
        public BoundingBox KodalyHandSo { get; set; }

        [JsonProperty("kodalyHandTi")]
        public BoundingBox KodalyHandTi { get; set; }

        [JsonProperty("leftRepeatSmall")]
        public BoundingBox LeftRepeatSmall { get; set; }

        [JsonProperty("legerLine")]
        public BoundingBox LegerLine { get; set; }

        [JsonProperty("legerLineNarrow")]
        public BoundingBox LegerLineNarrow { get; set; }

        [JsonProperty("legerLineWide")]
        public BoundingBox LegerLineWide { get; set; }

        [JsonProperty("luteBarlineEndRepeat")]
        public BoundingBox LuteBarlineEndRepeat { get; set; }

        [JsonProperty("luteBarlineFinal")]
        public BoundingBox LuteBarlineFinal { get; set; }

        [JsonProperty("luteBarlineStartRepeat")]
        public BoundingBox LuteBarlineStartRepeat { get; set; }

        [JsonProperty("luteDuration16th")]
        public BoundingBox LuteDuration16Th { get; set; }

        [JsonProperty("luteDuration32nd")]
        public BoundingBox LuteDuration32Nd { get; set; }

        [JsonProperty("luteDuration8th")]
        public BoundingBox LuteDuration8Th { get; set; }

        [JsonProperty("luteDurationDoubleWhole")]
        public BoundingBox LuteDurationDoubleWhole { get; set; }

        [JsonProperty("luteDurationHalf")]
        public BoundingBox LuteDurationHalf { get; set; }

        [JsonProperty("luteDurationQuarter")]
        public BoundingBox LuteDurationQuarter { get; set; }

        [JsonProperty("luteDurationWhole")]
        public BoundingBox LuteDurationWhole { get; set; }

        [JsonProperty("luteFingeringRHFirst")]
        public BoundingBox LuteFingeringRhFirst { get; set; }

        [JsonProperty("luteFingeringRHSecond")]
        public BoundingBox LuteFingeringRhSecond { get; set; }

        [JsonProperty("luteFingeringRHThird")]
        public BoundingBox LuteFingeringRhThird { get; set; }

        [JsonProperty("luteFingeringRHThirdAlt")]
        public BoundingBox LuteFingeringRhThirdAlt { get; set; }

        [JsonProperty("luteFingeringRHThumb")]
        public BoundingBox LuteFingeringRhThumb { get; set; }

        [JsonProperty("luteFrench10thCourse")]
        public BoundingBox LuteFrench10ThCourse { get; set; }

        [JsonProperty("luteFrench10thCourseRight")]
        public BoundingBox LuteFrench10ThCourseRight { get; set; }

        [JsonProperty("luteFrench10thCourseStrikethru")]
        public BoundingBox LuteFrench10ThCourseStrikethru { get; set; }

        [JsonProperty("luteFrench10thCourseUnderline")]
        public BoundingBox LuteFrench10ThCourseUnderline { get; set; }

        [JsonProperty("luteFrench7thCourse")]
        public BoundingBox LuteFrench7ThCourse { get; set; }

        [JsonProperty("luteFrench7thCourseRight")]
        public BoundingBox LuteFrench7ThCourseRight { get; set; }

        [JsonProperty("luteFrench7thCourseStrikethru")]
        public BoundingBox LuteFrench7ThCourseStrikethru { get; set; }

        [JsonProperty("luteFrench7thCourseUnderline")]
        public BoundingBox LuteFrench7ThCourseUnderline { get; set; }

        [JsonProperty("luteFrench8thCourse")]
        public BoundingBox LuteFrench8ThCourse { get; set; }

        [JsonProperty("luteFrench8thCourseRight")]
        public BoundingBox LuteFrench8ThCourseRight { get; set; }

        [JsonProperty("luteFrench8thCourseStrikethru")]
        public BoundingBox LuteFrench8ThCourseStrikethru { get; set; }

        [JsonProperty("luteFrench8thCourseUnderline")]
        public BoundingBox LuteFrench8ThCourseUnderline { get; set; }

        [JsonProperty("luteFrench9thCourse")]
        public BoundingBox LuteFrench9ThCourse { get; set; }

        [JsonProperty("luteFrench9thCourseRight")]
        public BoundingBox LuteFrench9ThCourseRight { get; set; }

        [JsonProperty("luteFrench9thCourseStrikethru")]
        public BoundingBox LuteFrench9ThCourseStrikethru { get; set; }

        [JsonProperty("luteFrench9thCourseUnderline")]
        public BoundingBox LuteFrench9ThCourseUnderline { get; set; }

        [JsonProperty("luteFrenchAppoggiaturaAbove")]
        public BoundingBox LuteFrenchAppoggiaturaAbove { get; set; }

        [JsonProperty("luteFrenchAppoggiaturaBelow")]
        public BoundingBox LuteFrenchAppoggiaturaBelow { get; set; }

        [JsonProperty("luteFrenchFretA")]
        public BoundingBox LuteFrenchFretA { get; set; }

        [JsonProperty("luteFrenchFretB")]
        public BoundingBox LuteFrenchFretB { get; set; }

        [JsonProperty("luteFrenchFretC")]
        public BoundingBox LuteFrenchFretC { get; set; }

        [JsonProperty("luteFrenchFretCAlt")]
        public BoundingBox LuteFrenchFretCAlt { get; set; }

        [JsonProperty("luteFrenchFretD")]
        public BoundingBox LuteFrenchFretD { get; set; }

        [JsonProperty("luteFrenchFretE")]
        public BoundingBox LuteFrenchFretE { get; set; }

        [JsonProperty("luteFrenchFretF")]
        public BoundingBox LuteFrenchFretF { get; set; }

        [JsonProperty("luteFrenchFretG")]
        public BoundingBox LuteFrenchFretG { get; set; }

        [JsonProperty("luteFrenchFretH")]
        public BoundingBox LuteFrenchFretH { get; set; }

        [JsonProperty("luteFrenchFretI")]
        public BoundingBox LuteFrenchFretI { get; set; }

        [JsonProperty("luteFrenchFretK")]
        public BoundingBox LuteFrenchFretK { get; set; }

        [JsonProperty("luteFrenchFretL")]
        public BoundingBox LuteFrenchFretL { get; set; }

        [JsonProperty("luteFrenchFretM")]
        public BoundingBox LuteFrenchFretM { get; set; }

        [JsonProperty("luteFrenchFretN")]
        public BoundingBox LuteFrenchFretN { get; set; }

        [JsonProperty("luteFrenchMordentInverted")]
        public BoundingBox LuteFrenchMordentInverted { get; set; }

        [JsonProperty("luteFrenchMordentLower")]
        public BoundingBox LuteFrenchMordentLower { get; set; }

        [JsonProperty("luteFrenchMordentUpper")]
        public BoundingBox LuteFrenchMordentUpper { get; set; }

        [JsonProperty("luteGermanALower")]
        public BoundingBox LuteGermanALower { get; set; }

        [JsonProperty("luteGermanAUpper")]
        public BoundingBox LuteGermanAUpper { get; set; }

        [JsonProperty("luteGermanBLower")]
        public BoundingBox LuteGermanBLower { get; set; }

        [JsonProperty("luteGermanBUpper")]
        public BoundingBox LuteGermanBUpper { get; set; }

        [JsonProperty("luteGermanCLower")]
        public BoundingBox LuteGermanCLower { get; set; }

        [JsonProperty("luteGermanCUpper")]
        public BoundingBox LuteGermanCUpper { get; set; }

        [JsonProperty("luteGermanDLower")]
        public BoundingBox LuteGermanDLower { get; set; }

        [JsonProperty("luteGermanDUpper")]
        public BoundingBox LuteGermanDUpper { get; set; }

        [JsonProperty("luteGermanELower")]
        public BoundingBox LuteGermanELower { get; set; }

        [JsonProperty("luteGermanEUpper")]
        public BoundingBox LuteGermanEUpper { get; set; }

        [JsonProperty("luteGermanFLower")]
        public BoundingBox LuteGermanFLower { get; set; }

        [JsonProperty("luteGermanFUpper")]
        public BoundingBox LuteGermanFUpper { get; set; }

        [JsonProperty("luteGermanGLower")]
        public BoundingBox LuteGermanGLower { get; set; }

        [JsonProperty("luteGermanGUpper")]
        public BoundingBox LuteGermanGUpper { get; set; }

        [JsonProperty("luteGermanHLower")]
        public BoundingBox LuteGermanHLower { get; set; }

        [JsonProperty("luteGermanHUpper")]
        public BoundingBox LuteGermanHUpper { get; set; }

        [JsonProperty("luteGermanILower")]
        public BoundingBox LuteGermanILower { get; set; }

        [JsonProperty("luteGermanIUpper")]
        public BoundingBox LuteGermanIUpper { get; set; }

        [JsonProperty("luteGermanKLower")]
        public BoundingBox LuteGermanKLower { get; set; }

        [JsonProperty("luteGermanKUpper")]
        public BoundingBox LuteGermanKUpper { get; set; }

        [JsonProperty("luteGermanLLower")]
        public BoundingBox LuteGermanLLower { get; set; }

        [JsonProperty("luteGermanLUpper")]
        public BoundingBox LuteGermanLUpper { get; set; }

        [JsonProperty("luteGermanMLower")]
        public BoundingBox LuteGermanMLower { get; set; }

        [JsonProperty("luteGermanMUpper")]
        public BoundingBox LuteGermanMUpper { get; set; }

        [JsonProperty("luteGermanNLower")]
        public BoundingBox LuteGermanNLower { get; set; }

        [JsonProperty("luteGermanNUpper")]
        public BoundingBox LuteGermanNUpper { get; set; }

        [JsonProperty("luteGermanOLower")]
        public BoundingBox LuteGermanOLower { get; set; }

        [JsonProperty("luteGermanPLower")]
        public BoundingBox LuteGermanPLower { get; set; }

        [JsonProperty("luteGermanQLower")]
        public BoundingBox LuteGermanQLower { get; set; }

        [JsonProperty("luteGermanRLower")]
        public BoundingBox LuteGermanRLower { get; set; }

        [JsonProperty("luteGermanSLower")]
        public BoundingBox LuteGermanSLower { get; set; }

        [JsonProperty("luteGermanTLower")]
        public BoundingBox LuteGermanTLower { get; set; }

        [JsonProperty("luteGermanVLower")]
        public BoundingBox LuteGermanVLower { get; set; }

        [JsonProperty("luteGermanXLower")]
        public BoundingBox LuteGermanXLower { get; set; }

        [JsonProperty("luteGermanYLower")]
        public BoundingBox LuteGermanYLower { get; set; }

        [JsonProperty("luteGermanZLower")]
        public BoundingBox LuteGermanZLower { get; set; }

        [JsonProperty("luteItalianClefCSolFaUt")]
        public BoundingBox LuteItalianClefCSolFaUt { get; set; }

        [JsonProperty("luteItalianClefFFaUt")]
        public BoundingBox LuteItalianClefFFaUt { get; set; }

        [JsonProperty("luteItalianFret0")]
        public BoundingBox LuteItalianFret0 { get; set; }

        [JsonProperty("luteItalianFret1")]
        public BoundingBox LuteItalianFret1 { get; set; }

        [JsonProperty("luteItalianFret2")]
        public BoundingBox LuteItalianFret2 { get; set; }

        [JsonProperty("luteItalianFret3")]
        public BoundingBox LuteItalianFret3 { get; set; }

        [JsonProperty("luteItalianFret4")]
        public BoundingBox LuteItalianFret4 { get; set; }

        [JsonProperty("luteItalianFret5")]
        public BoundingBox LuteItalianFret5 { get; set; }

        [JsonProperty("luteItalianFret6")]
        public BoundingBox LuteItalianFret6 { get; set; }

        [JsonProperty("luteItalianFret7")]
        public BoundingBox LuteItalianFret7 { get; set; }

        [JsonProperty("luteItalianFret8")]
        public BoundingBox LuteItalianFret8 { get; set; }

        [JsonProperty("luteItalianFret9")]
        public BoundingBox LuteItalianFret9 { get; set; }

        [JsonProperty("luteItalianHoldFinger")]
        public BoundingBox LuteItalianHoldFinger { get; set; }

        [JsonProperty("luteItalianHoldNote")]
        public BoundingBox LuteItalianHoldNote { get; set; }

        [JsonProperty("luteItalianReleaseFinger")]
        public BoundingBox LuteItalianReleaseFinger { get; set; }

        [JsonProperty("luteItalianTempoFast")]
        public BoundingBox LuteItalianTempoFast { get; set; }

        [JsonProperty("luteItalianTempoNeitherFastNorSlow")]
        public BoundingBox LuteItalianTempoNeitherFastNorSlow { get; set; }

        [JsonProperty("luteItalianTempoSlow")]
        public BoundingBox LuteItalianTempoSlow { get; set; }

        [JsonProperty("luteItalianTempoSomewhatFast")]
        public BoundingBox LuteItalianTempoSomewhatFast { get; set; }

        [JsonProperty("luteItalianTempoVerySlow")]
        public BoundingBox LuteItalianTempoVerySlow { get; set; }

        [JsonProperty("luteItalianTimeTriple")]
        public BoundingBox LuteItalianTimeTriple { get; set; }

        [JsonProperty("luteItalianTremolo")]
        public BoundingBox LuteItalianTremolo { get; set; }

        [JsonProperty("luteItalianVibrato")]
        public BoundingBox LuteItalianVibrato { get; set; }

        [JsonProperty("luteStaff6Lines")]
        public BoundingBox LuteStaff6Lines { get; set; }

        [JsonProperty("luteStaff6LinesNarrow")]
        public BoundingBox LuteStaff6LinesNarrow { get; set; }

        [JsonProperty("luteStaff6LinesWide")]
        public BoundingBox LuteStaff6LinesWide { get; set; }

        [JsonProperty("lyricsElision")]
        public BoundingBox LyricsElision { get; set; }

        [JsonProperty("lyricsElisionNarrow")]
        public BoundingBox LyricsElisionNarrow { get; set; }

        [JsonProperty("lyricsElisionWide")]
        public BoundingBox LyricsElisionWide { get; set; }

        [JsonProperty("lyricsHyphenBaseline")]
        public BoundingBox LyricsHyphenBaseline { get; set; }

        [JsonProperty("lyricsHyphenBaselineNonBreaking")]
        public BoundingBox LyricsHyphenBaselineNonBreaking { get; set; }

        [JsonProperty("medRenFlatHardB")]
        public BoundingBox MedRenFlatHardB { get; set; }

        [JsonProperty("medRenFlatSoftB")]
        public BoundingBox MedRenFlatSoftB { get; set; }

        [JsonProperty("medRenFlatSoftBHufnagel")]
        public BoundingBox MedRenFlatSoftBHufnagel { get; set; }

        [JsonProperty("medRenFlatSoftBOld")]
        public BoundingBox MedRenFlatSoftBOld { get; set; }

        [JsonProperty("medRenFlatWithDot")]
        public BoundingBox MedRenFlatWithDot { get; set; }

        [JsonProperty("medRenGClefCMN")]
        public BoundingBox MedRenGClefCmn { get; set; }

        [JsonProperty("medRenLiquescenceCMN")]
        public BoundingBox MedRenLiquescenceCmn { get; set; }

        [JsonProperty("medRenLiquescentAscCMN")]
        public BoundingBox MedRenLiquescentAscCmn { get; set; }

        [JsonProperty("medRenLiquescentDescCMN")]
        public BoundingBox MedRenLiquescentDescCmn { get; set; }

        [JsonProperty("medRenNatural")]
        public BoundingBox MedRenNatural { get; set; }

        [JsonProperty("medRenNaturalWithCross")]
        public BoundingBox MedRenNaturalWithCross { get; set; }

        [JsonProperty("medRenOriscusCMN")]
        public BoundingBox MedRenOriscusCmn { get; set; }

        [JsonProperty("medRenPlicaCMN")]
        public BoundingBox MedRenPlicaCmn { get; set; }

        [JsonProperty("medRenPunctumCMN")]
        public BoundingBox MedRenPunctumCmn { get; set; }

        [JsonProperty("medRenQuilismaCMN")]
        public BoundingBox MedRenQuilismaCmn { get; set; }

        [JsonProperty("medRenSharpCroix")]
        public BoundingBox MedRenSharpCroix { get; set; }

        [JsonProperty("medRenStrophicusCMN")]
        public BoundingBox MedRenStrophicusCmn { get; set; }

        [JsonProperty("mensuralAlterationSign")]
        public BoundingBox MensuralAlterationSign { get; set; }

        [JsonProperty("mensuralBlackBrevis")]
        public BoundingBox MensuralBlackBrevis { get; set; }

        [JsonProperty("mensuralBlackBrevisVoid")]
        public BoundingBox MensuralBlackBrevisVoid { get; set; }

        [JsonProperty("mensuralBlackDragma")]
        public BoundingBox MensuralBlackDragma { get; set; }

        [JsonProperty("mensuralBlackLonga")]
        public BoundingBox MensuralBlackLonga { get; set; }

        [JsonProperty("mensuralBlackMaxima")]
        public BoundingBox MensuralBlackMaxima { get; set; }

        [JsonProperty("mensuralBlackMinima")]
        public BoundingBox MensuralBlackMinima { get; set; }

        [JsonProperty("mensuralBlackMinimaVoid")]
        public BoundingBox MensuralBlackMinimaVoid { get; set; }

        [JsonProperty("mensuralBlackSemibrevis")]
        public BoundingBox MensuralBlackSemibrevis { get; set; }

        [JsonProperty("mensuralBlackSemibrevisCaudata")]
        public BoundingBox MensuralBlackSemibrevisCaudata { get; set; }

        [JsonProperty("mensuralBlackSemibrevisOblique")]
        public BoundingBox MensuralBlackSemibrevisOblique { get; set; }

        [JsonProperty("mensuralBlackSemibrevisVoid")]
        public BoundingBox MensuralBlackSemibrevisVoid { get; set; }

        [JsonProperty("mensuralBlackSemiminima")]
        public BoundingBox MensuralBlackSemiminima { get; set; }

        [JsonProperty("mensuralCclef")]
        public BoundingBox MensuralCclef { get; set; }

        [JsonProperty("mensuralCclefBlack")]
        public BoundingBox MensuralCclefBlack { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosHigh")]
        public BoundingBox MensuralCclefPetrucciPosHigh { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosHighest")]
        public BoundingBox MensuralCclefPetrucciPosHighest { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosLow")]
        public BoundingBox MensuralCclefPetrucciPosLow { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosLowest")]
        public BoundingBox MensuralCclefPetrucciPosLowest { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosMiddle")]
        public BoundingBox MensuralCclefPetrucciPosMiddle { get; set; }

        [JsonProperty("mensuralCclefVoid")]
        public BoundingBox MensuralCclefVoid { get; set; }

        [JsonProperty("mensuralColorationEndRound")]
        public BoundingBox MensuralColorationEndRound { get; set; }

        [JsonProperty("mensuralColorationEndSquare")]
        public BoundingBox MensuralColorationEndSquare { get; set; }

        [JsonProperty("mensuralColorationStartRound")]
        public BoundingBox MensuralColorationStartRound { get; set; }

        [JsonProperty("mensuralColorationStartSquare")]
        public BoundingBox MensuralColorationStartSquare { get; set; }

        [JsonProperty("mensuralCombStemDiagonal")]
        public BoundingBox MensuralCombStemDiagonal { get; set; }

        [JsonProperty("mensuralCombStemDown")]
        public BoundingBox MensuralCombStemDown { get; set; }

        [JsonProperty("mensuralCombStemDownFlagExtended")]
        public BoundingBox MensuralCombStemDownFlagExtended { get; set; }

        [JsonProperty("mensuralCombStemDownFlagFlared")]
        public BoundingBox MensuralCombStemDownFlagFlared { get; set; }

        [JsonProperty("mensuralCombStemDownFlagFusa")]
        public BoundingBox MensuralCombStemDownFlagFusa { get; set; }

        [JsonProperty("mensuralCombStemDownFlagLeft")]
        public BoundingBox MensuralCombStemDownFlagLeft { get; set; }

        [JsonProperty("mensuralCombStemDownFlagRight")]
        public BoundingBox MensuralCombStemDownFlagRight { get; set; }

        [JsonProperty("mensuralCombStemDownFlagSemiminima")]
        public BoundingBox MensuralCombStemDownFlagSemiminima { get; set; }

        [JsonProperty("mensuralCombStemUp")]
        public BoundingBox MensuralCombStemUp { get; set; }

        [JsonProperty("mensuralCombStemUpFlagExtended")]
        public BoundingBox MensuralCombStemUpFlagExtended { get; set; }

        [JsonProperty("mensuralCombStemUpFlagFlared")]
        public BoundingBox MensuralCombStemUpFlagFlared { get; set; }

        [JsonProperty("mensuralCombStemUpFlagFusa")]
        public BoundingBox MensuralCombStemUpFlagFusa { get; set; }

        [JsonProperty("mensuralCombStemUpFlagLeft")]
        public BoundingBox MensuralCombStemUpFlagLeft { get; set; }

        [JsonProperty("mensuralCombStemUpFlagRight")]
        public BoundingBox MensuralCombStemUpFlagRight { get; set; }

        [JsonProperty("mensuralCombStemUpFlagSemiminima")]
        public BoundingBox MensuralCombStemUpFlagSemiminima { get; set; }

        [JsonProperty("mensuralCustosCheckmark")]
        public BoundingBox MensuralCustosCheckmark { get; set; }

        [JsonProperty("mensuralCustosDown")]
        public BoundingBox MensuralCustosDown { get; set; }

        [JsonProperty("mensuralCustosTurn")]
        public BoundingBox MensuralCustosTurn { get; set; }

        [JsonProperty("mensuralCustosUp")]
        public BoundingBox MensuralCustosUp { get; set; }

        [JsonProperty("mensuralFclef")]
        public BoundingBox MensuralFclef { get; set; }

        [JsonProperty("mensuralFclefPetrucci")]
        public BoundingBox MensuralFclefPetrucci { get; set; }

        [JsonProperty("mensuralFusaBlackStemDown")]
        public BoundingBox MensuralFusaBlackStemDown { get; set; }

        [JsonProperty("mensuralFusaBlackStemUp")]
        public BoundingBox MensuralFusaBlackStemUp { get; set; }

        [JsonProperty("mensuralFusaBlackVoidStemDown")]
        public BoundingBox MensuralFusaBlackVoidStemDown { get; set; }

        [JsonProperty("mensuralFusaBlackVoidStemUp")]
        public BoundingBox MensuralFusaBlackVoidStemUp { get; set; }

        [JsonProperty("mensuralFusaVoidStemDown")]
        public BoundingBox MensuralFusaVoidStemDown { get; set; }

        [JsonProperty("mensuralFusaVoidStemUp")]
        public BoundingBox MensuralFusaVoidStemUp { get; set; }

        [JsonProperty("mensuralGclef")]
        public BoundingBox MensuralGclef { get; set; }

        [JsonProperty("mensuralGclefPetrucci")]
        public BoundingBox MensuralGclefPetrucci { get; set; }

        [JsonProperty("mensuralLongaBlackStemDownLeft")]
        public BoundingBox MensuralLongaBlackStemDownLeft { get; set; }

        [JsonProperty("mensuralLongaBlackStemDownRight")]
        public BoundingBox MensuralLongaBlackStemDownRight { get; set; }

        [JsonProperty("mensuralLongaBlackStemUpLeft")]
        public BoundingBox MensuralLongaBlackStemUpLeft { get; set; }

        [JsonProperty("mensuralLongaBlackStemUpRight")]
        public BoundingBox MensuralLongaBlackStemUpRight { get; set; }

        [JsonProperty("mensuralLongaBlackVoidStemDownLeft")]
        public BoundingBox MensuralLongaBlackVoidStemDownLeft { get; set; }

        [JsonProperty("mensuralLongaBlackVoidStemDownRight")]
        public BoundingBox MensuralLongaBlackVoidStemDownRight { get; set; }

        [JsonProperty("mensuralLongaBlackVoidStemUpLeft")]
        public BoundingBox MensuralLongaBlackVoidStemUpLeft { get; set; }

        [JsonProperty("mensuralLongaBlackVoidStemUpRight")]
        public BoundingBox MensuralLongaBlackVoidStemUpRight { get; set; }

        [JsonProperty("mensuralLongaVoidStemDownLeft")]
        public BoundingBox MensuralLongaVoidStemDownLeft { get; set; }

        [JsonProperty("mensuralLongaVoidStemDownRight")]
        public BoundingBox MensuralLongaVoidStemDownRight { get; set; }

        [JsonProperty("mensuralLongaVoidStemUpLeft")]
        public BoundingBox MensuralLongaVoidStemUpLeft { get; set; }

        [JsonProperty("mensuralLongaVoidStemUpRight")]
        public BoundingBox MensuralLongaVoidStemUpRight { get; set; }

        [JsonProperty("mensuralMaximaBlackStemDownLeft")]
        public BoundingBox MensuralMaximaBlackStemDownLeft { get; set; }

        [JsonProperty("mensuralMaximaBlackStemDownRight")]
        public BoundingBox MensuralMaximaBlackStemDownRight { get; set; }

        [JsonProperty("mensuralMaximaBlackStemUpLeft")]
        public BoundingBox MensuralMaximaBlackStemUpLeft { get; set; }

        [JsonProperty("mensuralMaximaBlackStemUpRight")]
        public BoundingBox MensuralMaximaBlackStemUpRight { get; set; }

        [JsonProperty("mensuralMaximaBlackVoidStemDownLeft")]
        public BoundingBox MensuralMaximaBlackVoidStemDownLeft { get; set; }

        [JsonProperty("mensuralMaximaBlackVoidStemDownRight")]
        public BoundingBox MensuralMaximaBlackVoidStemDownRight { get; set; }

        [JsonProperty("mensuralMaximaBlackVoidStemUpLeft")]
        public BoundingBox MensuralMaximaBlackVoidStemUpLeft { get; set; }

        [JsonProperty("mensuralMaximaBlackVoidStemUpRight")]
        public BoundingBox MensuralMaximaBlackVoidStemUpRight { get; set; }

        [JsonProperty("mensuralMaximaVoidStemDownLeft")]
        public BoundingBox MensuralMaximaVoidStemDownLeft { get; set; }

        [JsonProperty("mensuralMaximaVoidStemDownRight")]
        public BoundingBox MensuralMaximaVoidStemDownRight { get; set; }

        [JsonProperty("mensuralMaximaVoidStemUpLeft")]
        public BoundingBox MensuralMaximaVoidStemUpLeft { get; set; }

        [JsonProperty("mensuralMaximaVoidStemUpRight")]
        public BoundingBox MensuralMaximaVoidStemUpRight { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDown")]
        public BoundingBox MensuralMinimaBlackStemDown { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDownExtendedFlag")]
        public BoundingBox MensuralMinimaBlackStemDownExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDownFlagLeft")]
        public BoundingBox MensuralMinimaBlackStemDownFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDownFlagRight")]
        public BoundingBox MensuralMinimaBlackStemDownFlagRight { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDownFlaredFlag")]
        public BoundingBox MensuralMinimaBlackStemDownFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUp")]
        public BoundingBox MensuralMinimaBlackStemUp { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUpExtendedFlag")]
        public BoundingBox MensuralMinimaBlackStemUpExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUpFlagLeft")]
        public BoundingBox MensuralMinimaBlackStemUpFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUpFlagRight")]
        public BoundingBox MensuralMinimaBlackStemUpFlagRight { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUpFlaredFlag")]
        public BoundingBox MensuralMinimaBlackStemUpFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDown")]
        public BoundingBox MensuralMinimaBlackVoidStemDown { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDownExtendedFlag")]
        public BoundingBox MensuralMinimaBlackVoidStemDownExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDownFlagLeft")]
        public BoundingBox MensuralMinimaBlackVoidStemDownFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDownFlagRight")]
        public BoundingBox MensuralMinimaBlackVoidStemDownFlagRight { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDownFlaredFlag")]
        public BoundingBox MensuralMinimaBlackVoidStemDownFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUp")]
        public BoundingBox MensuralMinimaBlackVoidStemUp { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUpExtendedFlag")]
        public BoundingBox MensuralMinimaBlackVoidStemUpExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUpFlagLeft")]
        public BoundingBox MensuralMinimaBlackVoidStemUpFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUpFlagRight")]
        public BoundingBox MensuralMinimaBlackVoidStemUpFlagRight { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUpFlaredFlag")]
        public BoundingBox MensuralMinimaBlackVoidStemUpFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDown")]
        public BoundingBox MensuralMinimaVoidStemDown { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDownExtendedFlag")]
        public BoundingBox MensuralMinimaVoidStemDownExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDownFlagLeft")]
        public BoundingBox MensuralMinimaVoidStemDownFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDownFlagRight")]
        public BoundingBox MensuralMinimaVoidStemDownFlagRight { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDownFlaredFlag")]
        public BoundingBox MensuralMinimaVoidStemDownFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUp")]
        public BoundingBox MensuralMinimaVoidStemUp { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUpExtendedFlag")]
        public BoundingBox MensuralMinimaVoidStemUpExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUpFlagLeft")]
        public BoundingBox MensuralMinimaVoidStemUpFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUpFlagRight")]
        public BoundingBox MensuralMinimaVoidStemUpFlagRight { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUpFlaredFlag")]
        public BoundingBox MensuralMinimaVoidStemUpFlaredFlag { get; set; }

        [JsonProperty("mensuralModusImperfectumVert")]
        public BoundingBox MensuralModusImperfectumVert { get; set; }

        [JsonProperty("mensuralModusPerfectumVert")]
        public BoundingBox MensuralModusPerfectumVert { get; set; }

        [JsonProperty("mensuralNoteheadLongaBlack")]
        public BoundingBox MensuralNoteheadLongaBlack { get; set; }

        [JsonProperty("mensuralNoteheadLongaBlackVoid")]
        public BoundingBox MensuralNoteheadLongaBlackVoid { get; set; }

        [JsonProperty("mensuralNoteheadLongaVoid")]
        public BoundingBox MensuralNoteheadLongaVoid { get; set; }

        [JsonProperty("mensuralNoteheadLongaWhite")]
        public BoundingBox MensuralNoteheadLongaWhite { get; set; }

        [JsonProperty("mensuralNoteheadMaximaBlack")]
        public BoundingBox MensuralNoteheadMaximaBlack { get; set; }

        [JsonProperty("mensuralNoteheadMaximaBlackVoid")]
        public BoundingBox MensuralNoteheadMaximaBlackVoid { get; set; }

        [JsonProperty("mensuralNoteheadMaximaVoid")]
        public BoundingBox MensuralNoteheadMaximaVoid { get; set; }

        [JsonProperty("mensuralNoteheadMaximaWhite")]
        public BoundingBox MensuralNoteheadMaximaWhite { get; set; }

        [JsonProperty("mensuralNoteheadMinimaWhite")]
        public BoundingBox MensuralNoteheadMinimaWhite { get; set; }

        [JsonProperty("mensuralNoteheadSemibrevisBlack")]
        public BoundingBox MensuralNoteheadSemibrevisBlack { get; set; }

        [JsonProperty("mensuralNoteheadSemibrevisBlackVoid")]
        public BoundingBox MensuralNoteheadSemibrevisBlackVoid { get; set; }

        [JsonProperty("mensuralNoteheadSemibrevisBlackVoidTurned")]
        public BoundingBox MensuralNoteheadSemibrevisBlackVoidTurned { get; set; }

        [JsonProperty("mensuralNoteheadSemibrevisVoid")]
        public BoundingBox MensuralNoteheadSemibrevisVoid { get; set; }

        [JsonProperty("mensuralNoteheadSemiminimaWhite")]
        public BoundingBox MensuralNoteheadSemiminimaWhite { get; set; }

        [JsonProperty("mensuralObliqueAsc2ndBlack")]
        public BoundingBox MensuralObliqueAsc2NdBlack { get; set; }

        [JsonProperty("mensuralObliqueAsc2ndBlackVoid")]
        public BoundingBox MensuralObliqueAsc2NdBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc2ndVoid")]
        public BoundingBox MensuralObliqueAsc2NdVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc2ndWhite")]
        public BoundingBox MensuralObliqueAsc2NdWhite { get; set; }

        [JsonProperty("mensuralObliqueAsc3rdBlack")]
        public BoundingBox MensuralObliqueAsc3RdBlack { get; set; }

        [JsonProperty("mensuralObliqueAsc3rdBlackVoid")]
        public BoundingBox MensuralObliqueAsc3RdBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc3rdVoid")]
        public BoundingBox MensuralObliqueAsc3RdVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc3rdWhite")]
        public BoundingBox MensuralObliqueAsc3RdWhite { get; set; }

        [JsonProperty("mensuralObliqueAsc4thBlack")]
        public BoundingBox MensuralObliqueAsc4ThBlack { get; set; }

        [JsonProperty("mensuralObliqueAsc4thBlackVoid")]
        public BoundingBox MensuralObliqueAsc4ThBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc4thVoid")]
        public BoundingBox MensuralObliqueAsc4ThVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc4thWhite")]
        public BoundingBox MensuralObliqueAsc4ThWhite { get; set; }

        [JsonProperty("mensuralObliqueAsc5thBlack")]
        public BoundingBox MensuralObliqueAsc5ThBlack { get; set; }

        [JsonProperty("mensuralObliqueAsc5thBlackVoid")]
        public BoundingBox MensuralObliqueAsc5ThBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc5thVoid")]
        public BoundingBox MensuralObliqueAsc5ThVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc5thWhite")]
        public BoundingBox MensuralObliqueAsc5ThWhite { get; set; }

        [JsonProperty("mensuralObliqueDesc2ndBlack")]
        public BoundingBox MensuralObliqueDesc2NdBlack { get; set; }

        [JsonProperty("mensuralObliqueDesc2ndBlackVoid")]
        public BoundingBox MensuralObliqueDesc2NdBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc2ndVoid")]
        public BoundingBox MensuralObliqueDesc2NdVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc2ndWhite")]
        public BoundingBox MensuralObliqueDesc2NdWhite { get; set; }

        [JsonProperty("mensuralObliqueDesc3rdBlack")]
        public BoundingBox MensuralObliqueDesc3RdBlack { get; set; }

        [JsonProperty("mensuralObliqueDesc3rdBlackVoid")]
        public BoundingBox MensuralObliqueDesc3RdBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc3rdVoid")]
        public BoundingBox MensuralObliqueDesc3RdVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc3rdWhite")]
        public BoundingBox MensuralObliqueDesc3RdWhite { get; set; }

        [JsonProperty("mensuralObliqueDesc4thBlack")]
        public BoundingBox MensuralObliqueDesc4ThBlack { get; set; }

        [JsonProperty("mensuralObliqueDesc4thBlackVoid")]
        public BoundingBox MensuralObliqueDesc4ThBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc4thVoid")]
        public BoundingBox MensuralObliqueDesc4ThVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc4thWhite")]
        public BoundingBox MensuralObliqueDesc4ThWhite { get; set; }

        [JsonProperty("mensuralObliqueDesc5thBlack")]
        public BoundingBox MensuralObliqueDesc5ThBlack { get; set; }

        [JsonProperty("mensuralObliqueDesc5thBlackVoid")]
        public BoundingBox MensuralObliqueDesc5ThBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc5thVoid")]
        public BoundingBox MensuralObliqueDesc5ThVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc5thWhite")]
        public BoundingBox MensuralObliqueDesc5ThWhite { get; set; }

        [JsonProperty("mensuralProlation1")]
        public BoundingBox MensuralProlation1 { get; set; }

        [JsonProperty("mensuralProlation10")]
        public BoundingBox MensuralProlation10 { get; set; }

        [JsonProperty("mensuralProlation11")]
        public BoundingBox MensuralProlation11 { get; set; }

        [JsonProperty("mensuralProlation2")]
        public BoundingBox MensuralProlation2 { get; set; }

        [JsonProperty("mensuralProlation3")]
        public BoundingBox MensuralProlation3 { get; set; }

        [JsonProperty("mensuralProlation4")]
        public BoundingBox MensuralProlation4 { get; set; }

        [JsonProperty("mensuralProlation5")]
        public BoundingBox MensuralProlation5 { get; set; }

        [JsonProperty("mensuralProlation6")]
        public BoundingBox MensuralProlation6 { get; set; }

        [JsonProperty("mensuralProlation7")]
        public BoundingBox MensuralProlation7 { get; set; }

        [JsonProperty("mensuralProlation8")]
        public BoundingBox MensuralProlation8 { get; set; }

        [JsonProperty("mensuralProlation9")]
        public BoundingBox MensuralProlation9 { get; set; }

        [JsonProperty("mensuralProlationCombiningDot")]
        public BoundingBox MensuralProlationCombiningDot { get; set; }

        [JsonProperty("mensuralProlationCombiningDotVoid")]
        public BoundingBox MensuralProlationCombiningDotVoid { get; set; }

        [JsonProperty("mensuralProlationCombiningStroke")]
        public BoundingBox MensuralProlationCombiningStroke { get; set; }

        [JsonProperty("mensuralProlationCombiningThreeDots")]
        public BoundingBox MensuralProlationCombiningThreeDots { get; set; }

        [JsonProperty("mensuralProlationCombiningThreeDotsTri")]
        public BoundingBox MensuralProlationCombiningThreeDotsTri { get; set; }

        [JsonProperty("mensuralProlationCombiningTwoDots")]
        public BoundingBox MensuralProlationCombiningTwoDots { get; set; }

        [JsonProperty("mensuralProportion1")]
        public BoundingBox MensuralProportion1 { get; set; }

        [JsonProperty("mensuralProportion2")]
        public BoundingBox MensuralProportion2 { get; set; }

        [JsonProperty("mensuralProportion3")]
        public BoundingBox MensuralProportion3 { get; set; }

        [JsonProperty("mensuralProportion4")]
        public BoundingBox MensuralProportion4 { get; set; }

        [JsonProperty("mensuralProportion4Old")]
        public BoundingBox MensuralProportion4Old { get; set; }

        [JsonProperty("mensuralProportionMajor")]
        public BoundingBox MensuralProportionMajor { get; set; }

        [JsonProperty("mensuralProportionMinor")]
        public BoundingBox MensuralProportionMinor { get; set; }

        [JsonProperty("mensuralProportionProportioDupla1")]
        public BoundingBox MensuralProportionProportioDupla1 { get; set; }

        [JsonProperty("mensuralProportionProportioDupla2")]
        public BoundingBox MensuralProportionProportioDupla2 { get; set; }

        [JsonProperty("mensuralProportionProportioQuadrupla")]
        public BoundingBox MensuralProportionProportioQuadrupla { get; set; }

        [JsonProperty("mensuralProportionProportioTripla")]
        public BoundingBox MensuralProportionProportioTripla { get; set; }

        [JsonProperty("mensuralProportionTempusPerfectum")]
        public BoundingBox MensuralProportionTempusPerfectum { get; set; }

        [JsonProperty("mensuralRestBrevis")]
        public BoundingBox MensuralRestBrevis { get; set; }

        [JsonProperty("mensuralRestFusa")]
        public BoundingBox MensuralRestFusa { get; set; }

        [JsonProperty("mensuralRestLongaImperfecta")]
        public BoundingBox MensuralRestLongaImperfecta { get; set; }

        [JsonProperty("mensuralRestLongaPerfecta")]
        public BoundingBox MensuralRestLongaPerfecta { get; set; }

        [JsonProperty("mensuralRestMaxima")]
        public BoundingBox MensuralRestMaxima { get; set; }

        [JsonProperty("mensuralRestMinima")]
        public BoundingBox MensuralRestMinima { get; set; }

        [JsonProperty("mensuralRestSemibrevis")]
        public BoundingBox MensuralRestSemibrevis { get; set; }

        [JsonProperty("mensuralRestSemifusa")]
        public BoundingBox MensuralRestSemifusa { get; set; }

        [JsonProperty("mensuralRestSemiminima")]
        public BoundingBox MensuralRestSemiminima { get; set; }

        [JsonProperty("mensuralSemiminimaBlackStemDown")]
        public BoundingBox MensuralSemiminimaBlackStemDown { get; set; }

        [JsonProperty("mensuralSemiminimaBlackStemUp")]
        public BoundingBox MensuralSemiminimaBlackStemUp { get; set; }

        [JsonProperty("mensuralSemiminimaBlackVoidStemDown")]
        public BoundingBox MensuralSemiminimaBlackVoidStemDown { get; set; }

        [JsonProperty("mensuralSemiminimaBlackVoidStemUp")]
        public BoundingBox MensuralSemiminimaBlackVoidStemUp { get; set; }

        [JsonProperty("mensuralSemiminimaVoidStemDown")]
        public BoundingBox MensuralSemiminimaVoidStemDown { get; set; }

        [JsonProperty("mensuralSemiminimaVoidStemUp")]
        public BoundingBox MensuralSemiminimaVoidStemUp { get; set; }

        [JsonProperty("mensuralSignumDown")]
        public BoundingBox MensuralSignumDown { get; set; }

        [JsonProperty("mensuralSignumUp")]
        public BoundingBox MensuralSignumUp { get; set; }

        [JsonProperty("mensuralTempusImperfectumHoriz")]
        public BoundingBox MensuralTempusImperfectumHoriz { get; set; }

        [JsonProperty("mensuralTempusPerfectumHoriz")]
        public BoundingBox MensuralTempusPerfectumHoriz { get; set; }

        [JsonProperty("mensuralWhiteBrevis")]
        public BoundingBox MensuralWhiteBrevis { get; set; }

        [JsonProperty("mensuralWhiteFusa")]
        public BoundingBox MensuralWhiteFusa { get; set; }

        [JsonProperty("mensuralWhiteLonga")]
        public BoundingBox MensuralWhiteLonga { get; set; }

        [JsonProperty("mensuralWhiteMaxima")]
        public BoundingBox MensuralWhiteMaxima { get; set; }

        [JsonProperty("mensuralWhiteMinima")]
        public BoundingBox MensuralWhiteMinima { get; set; }

        [JsonProperty("mensuralWhiteSemiminima")]
        public BoundingBox MensuralWhiteSemiminima { get; set; }

        [JsonProperty("metAugmentationDot")]
        public BoundingBox MetAugmentationDot { get; set; }

        [JsonProperty("metNote1024thDown")]
        public BoundingBox MetNote1024ThDown { get; set; }

        [JsonProperty("metNote1024thUp")]
        public BoundingBox MetNote1024ThUp { get; set; }

        [JsonProperty("metNote128thDown")]
        public BoundingBox MetNote128ThDown { get; set; }

        [JsonProperty("metNote128thUp")]
        public BoundingBox MetNote128ThUp { get; set; }

        [JsonProperty("metNote16thDown")]
        public BoundingBox MetNote16ThDown { get; set; }

        [JsonProperty("metNote16thUp")]
        public BoundingBox MetNote16ThUp { get; set; }

        [JsonProperty("metNote256thDown")]
        public BoundingBox MetNote256ThDown { get; set; }

        [JsonProperty("metNote256thUp")]
        public BoundingBox MetNote256ThUp { get; set; }

        [JsonProperty("metNote32ndDown")]
        public BoundingBox MetNote32NdDown { get; set; }

        [JsonProperty("metNote32ndUp")]
        public BoundingBox MetNote32NdUp { get; set; }

        [JsonProperty("metNote512thDown")]
        public BoundingBox MetNote512ThDown { get; set; }

        [JsonProperty("metNote512thUp")]
        public BoundingBox MetNote512ThUp { get; set; }

        [JsonProperty("metNote64thDown")]
        public BoundingBox MetNote64ThDown { get; set; }

        [JsonProperty("metNote64thUp")]
        public BoundingBox MetNote64ThUp { get; set; }

        [JsonProperty("metNote8thDown")]
        public BoundingBox MetNote8ThDown { get; set; }

        [JsonProperty("metNote8thUp")]
        public BoundingBox MetNote8ThUp { get; set; }

        [JsonProperty("metNoteDoubleWhole")]
        public BoundingBox MetNoteDoubleWhole { get; set; }

        [JsonProperty("metNoteDoubleWholeSquare")]
        public BoundingBox MetNoteDoubleWholeSquare { get; set; }

        [JsonProperty("metNoteHalfDown")]
        public BoundingBox MetNoteHalfDown { get; set; }

        [JsonProperty("metNoteHalfUp")]
        public BoundingBox MetNoteHalfUp { get; set; }

        [JsonProperty("metNoteQuarterDown")]
        public BoundingBox MetNoteQuarterDown { get; set; }

        [JsonProperty("metNoteQuarterUp")]
        public BoundingBox MetNoteQuarterUp { get; set; }

        [JsonProperty("metNoteWhole")]
        public BoundingBox MetNoteWhole { get; set; }

        [JsonProperty("metricModulationArrowLeft")]
        public BoundingBox MetricModulationArrowLeft { get; set; }

        [JsonProperty("metricModulationArrowRight")]
        public BoundingBox MetricModulationArrowRight { get; set; }

        [JsonProperty("miscDoNotCopy")]
        public BoundingBox MiscDoNotCopy { get; set; }

        [JsonProperty("miscDoNotPhotocopy")]
        public BoundingBox MiscDoNotPhotocopy { get; set; }

        [JsonProperty("miscEyeglasses")]
        public BoundingBox MiscEyeglasses { get; set; }

        [JsonProperty("note1024thDown")]
        public BoundingBox Note1024ThDown { get; set; }

        [JsonProperty("note1024thUp")]
        public BoundingBox Note1024ThUp { get; set; }

        [JsonProperty("note128thDown")]
        public BoundingBox Note128ThDown { get; set; }

        [JsonProperty("note128thUp")]
        public BoundingBox Note128ThUp { get; set; }

        [JsonProperty("note16thDown")]
        public BoundingBox Note16ThDown { get; set; }

        [JsonProperty("note16thUp")]
        public BoundingBox Note16ThUp { get; set; }

        [JsonProperty("note256thDown")]
        public BoundingBox Note256ThDown { get; set; }

        [JsonProperty("note256thUp")]
        public BoundingBox Note256ThUp { get; set; }

        [JsonProperty("note32ndDown")]
        public BoundingBox Note32NdDown { get; set; }

        [JsonProperty("note32ndUp")]
        public BoundingBox Note32NdUp { get; set; }

        [JsonProperty("note512thDown")]
        public BoundingBox Note512ThDown { get; set; }

        [JsonProperty("note512thUp")]
        public BoundingBox Note512ThUp { get; set; }

        [JsonProperty("note64thDown")]
        public BoundingBox Note64ThDown { get; set; }

        [JsonProperty("note64thUp")]
        public BoundingBox Note64ThUp { get; set; }

        [JsonProperty("note8thDown")]
        public BoundingBox Note8ThDown { get; set; }

        [JsonProperty("note8thUp")]
        public BoundingBox Note8ThUp { get; set; }

        [JsonProperty("noteABlack")]
        public BoundingBox NoteABlack { get; set; }

        [JsonProperty("noteAFlatBlack")]
        public BoundingBox NoteAFlatBlack { get; set; }

        [JsonProperty("noteAFlatHalf")]
        public BoundingBox NoteAFlatHalf { get; set; }

        [JsonProperty("noteAFlatWhole")]
        public BoundingBox NoteAFlatWhole { get; set; }

        [JsonProperty("noteAHalf")]
        public BoundingBox NoteAHalf { get; set; }

        [JsonProperty("noteASharpBlack")]
        public BoundingBox NoteASharpBlack { get; set; }

        [JsonProperty("noteASharpHalf")]
        public BoundingBox NoteASharpHalf { get; set; }

        [JsonProperty("noteASharpWhole")]
        public BoundingBox NoteASharpWhole { get; set; }

        [JsonProperty("noteAWhole")]
        public BoundingBox NoteAWhole { get; set; }

        [JsonProperty("noteBBlack")]
        public BoundingBox NoteBBlack { get; set; }

        [JsonProperty("noteBFlatBlack")]
        public BoundingBox NoteBFlatBlack { get; set; }

        [JsonProperty("noteBFlatHalf")]
        public BoundingBox NoteBFlatHalf { get; set; }

        [JsonProperty("noteBFlatWhole")]
        public BoundingBox NoteBFlatWhole { get; set; }

        [JsonProperty("noteBHalf")]
        public BoundingBox NoteBHalf { get; set; }

        [JsonProperty("noteBSharpBlack")]
        public BoundingBox NoteBSharpBlack { get; set; }

        [JsonProperty("noteBSharpHalf")]
        public BoundingBox NoteBSharpHalf { get; set; }

        [JsonProperty("noteBSharpWhole")]
        public BoundingBox NoteBSharpWhole { get; set; }

        [JsonProperty("noteBWhole")]
        public BoundingBox NoteBWhole { get; set; }

        [JsonProperty("noteCBlack")]
        public BoundingBox NoteCBlack { get; set; }

        [JsonProperty("noteCFlatBlack")]
        public BoundingBox NoteCFlatBlack { get; set; }

        [JsonProperty("noteCFlatHalf")]
        public BoundingBox NoteCFlatHalf { get; set; }

        [JsonProperty("noteCFlatWhole")]
        public BoundingBox NoteCFlatWhole { get; set; }

        [JsonProperty("noteCHalf")]
        public BoundingBox NoteCHalf { get; set; }

        [JsonProperty("noteCSharpBlack")]
        public BoundingBox NoteCSharpBlack { get; set; }

        [JsonProperty("noteCSharpHalf")]
        public BoundingBox NoteCSharpHalf { get; set; }

        [JsonProperty("noteCSharpWhole")]
        public BoundingBox NoteCSharpWhole { get; set; }

        [JsonProperty("noteCWhole")]
        public BoundingBox NoteCWhole { get; set; }

        [JsonProperty("noteDBlack")]
        public BoundingBox NoteDBlack { get; set; }

        [JsonProperty("noteDFlatBlack")]
        public BoundingBox NoteDFlatBlack { get; set; }

        [JsonProperty("noteDFlatHalf")]
        public BoundingBox NoteDFlatHalf { get; set; }

        [JsonProperty("noteDFlatWhole")]
        public BoundingBox NoteDFlatWhole { get; set; }

        [JsonProperty("noteDHalf")]
        public BoundingBox NoteDHalf { get; set; }

        [JsonProperty("noteDSharpBlack")]
        public BoundingBox NoteDSharpBlack { get; set; }

        [JsonProperty("noteDSharpHalf")]
        public BoundingBox NoteDSharpHalf { get; set; }

        [JsonProperty("noteDSharpWhole")]
        public BoundingBox NoteDSharpWhole { get; set; }

        [JsonProperty("noteDWhole")]
        public BoundingBox NoteDWhole { get; set; }

        [JsonProperty("noteDoBlack")]
        public BoundingBox NoteDoBlack { get; set; }

        [JsonProperty("noteDoHalf")]
        public BoundingBox NoteDoHalf { get; set; }

        [JsonProperty("noteDoWhole")]
        public BoundingBox NoteDoWhole { get; set; }

        [JsonProperty("noteDoubleWhole")]
        public BoundingBox NoteDoubleWhole { get; set; }

        [JsonProperty("noteDoubleWholeAlt")]
        public BoundingBox NoteDoubleWholeAlt { get; set; }

        [JsonProperty("noteDoubleWholeSquare")]
        public BoundingBox NoteDoubleWholeSquare { get; set; }

        [JsonProperty("noteEBlack")]
        public BoundingBox NoteEBlack { get; set; }

        [JsonProperty("noteEFlatBlack")]
        public BoundingBox NoteEFlatBlack { get; set; }

        [JsonProperty("noteEFlatHalf")]
        public BoundingBox NoteEFlatHalf { get; set; }

        [JsonProperty("noteEFlatWhole")]
        public BoundingBox NoteEFlatWhole { get; set; }

        [JsonProperty("noteEHalf")]
        public BoundingBox NoteEHalf { get; set; }

        [JsonProperty("noteESharpBlack")]
        public BoundingBox NoteESharpBlack { get; set; }

        [JsonProperty("noteESharpHalf")]
        public BoundingBox NoteESharpHalf { get; set; }

        [JsonProperty("noteESharpWhole")]
        public BoundingBox NoteESharpWhole { get; set; }

        [JsonProperty("noteEWhole")]
        public BoundingBox NoteEWhole { get; set; }

        [JsonProperty("noteEmptyBlack")]
        public BoundingBox NoteEmptyBlack { get; set; }

        [JsonProperty("noteEmptyHalf")]
        public BoundingBox NoteEmptyHalf { get; set; }

        [JsonProperty("noteEmptyWhole")]
        public BoundingBox NoteEmptyWhole { get; set; }

        [JsonProperty("noteFBlack")]
        public BoundingBox NoteFBlack { get; set; }

        [JsonProperty("noteFFlatBlack")]
        public BoundingBox NoteFFlatBlack { get; set; }

        [JsonProperty("noteFFlatHalf")]
        public BoundingBox NoteFFlatHalf { get; set; }

        [JsonProperty("noteFFlatWhole")]
        public BoundingBox NoteFFlatWhole { get; set; }

        [JsonProperty("noteFHalf")]
        public BoundingBox NoteFHalf { get; set; }

        [JsonProperty("noteFSharpBlack")]
        public BoundingBox NoteFSharpBlack { get; set; }

        [JsonProperty("noteFSharpHalf")]
        public BoundingBox NoteFSharpHalf { get; set; }

        [JsonProperty("noteFSharpWhole")]
        public BoundingBox NoteFSharpWhole { get; set; }

        [JsonProperty("noteFWhole")]
        public BoundingBox NoteFWhole { get; set; }

        [JsonProperty("noteFaBlack")]
        public BoundingBox NoteFaBlack { get; set; }

        [JsonProperty("noteFaHalf")]
        public BoundingBox NoteFaHalf { get; set; }

        [JsonProperty("noteFaWhole")]
        public BoundingBox NoteFaWhole { get; set; }

        [JsonProperty("noteGBlack")]
        public BoundingBox NoteGBlack { get; set; }

        [JsonProperty("noteGFlatBlack")]
        public BoundingBox NoteGFlatBlack { get; set; }

        [JsonProperty("noteGFlatHalf")]
        public BoundingBox NoteGFlatHalf { get; set; }

        [JsonProperty("noteGFlatWhole")]
        public BoundingBox NoteGFlatWhole { get; set; }

        [JsonProperty("noteGHalf")]
        public BoundingBox NoteGHalf { get; set; }

        [JsonProperty("noteGSharpBlack")]
        public BoundingBox NoteGSharpBlack { get; set; }

        [JsonProperty("noteGSharpHalf")]
        public BoundingBox NoteGSharpHalf { get; set; }

        [JsonProperty("noteGSharpWhole")]
        public BoundingBox NoteGSharpWhole { get; set; }

        [JsonProperty("noteGWhole")]
        public BoundingBox NoteGWhole { get; set; }

        [JsonProperty("noteHBlack")]
        public BoundingBox NoteHBlack { get; set; }

        [JsonProperty("noteHHalf")]
        public BoundingBox NoteHHalf { get; set; }

        [JsonProperty("noteHSharpBlack")]
        public BoundingBox NoteHSharpBlack { get; set; }

        [JsonProperty("noteHSharpHalf")]
        public BoundingBox NoteHSharpHalf { get; set; }

        [JsonProperty("noteHSharpWhole")]
        public BoundingBox NoteHSharpWhole { get; set; }

        [JsonProperty("noteHWhole")]
        public BoundingBox NoteHWhole { get; set; }

        [JsonProperty("noteHalfDown")]
        public BoundingBox NoteHalfDown { get; set; }

        [JsonProperty("noteHalfUp")]
        public BoundingBox NoteHalfUp { get; set; }

        [JsonProperty("noteLaBlack")]
        public BoundingBox NoteLaBlack { get; set; }

        [JsonProperty("noteLaHalf")]
        public BoundingBox NoteLaHalf { get; set; }

        [JsonProperty("noteLaWhole")]
        public BoundingBox NoteLaWhole { get; set; }

        [JsonProperty("noteMiBlack")]
        public BoundingBox NoteMiBlack { get; set; }

        [JsonProperty("noteMiHalf")]
        public BoundingBox NoteMiHalf { get; set; }

        [JsonProperty("noteMiWhole")]
        public BoundingBox NoteMiWhole { get; set; }

        [JsonProperty("noteQuarterDown")]
        public BoundingBox NoteQuarterDown { get; set; }

        [JsonProperty("noteQuarterUp")]
        public BoundingBox NoteQuarterUp { get; set; }

        [JsonProperty("noteReBlack")]
        public BoundingBox NoteReBlack { get; set; }

        [JsonProperty("noteReHalf")]
        public BoundingBox NoteReHalf { get; set; }

        [JsonProperty("noteReWhole")]
        public BoundingBox NoteReWhole { get; set; }

        [JsonProperty("noteShapeArrowheadLeftBlack")]
        public BoundingBox NoteShapeArrowheadLeftBlack { get; set; }

        [JsonProperty("noteShapeArrowheadLeftDoubleWhole")]
        public BoundingBox NoteShapeArrowheadLeftDoubleWhole { get; set; }

        [JsonProperty("noteShapeArrowheadLeftWhite")]
        public BoundingBox NoteShapeArrowheadLeftWhite { get; set; }

        [JsonProperty("noteShapeDiamondBlack")]
        public BoundingBox NoteShapeDiamondBlack { get; set; }

        [JsonProperty("noteShapeDiamondDoubleWhole")]
        public BoundingBox NoteShapeDiamondDoubleWhole { get; set; }

        [JsonProperty("noteShapeDiamondWhite")]
        public BoundingBox NoteShapeDiamondWhite { get; set; }

        [JsonProperty("noteShapeIsoscelesTriangleBlack")]
        public BoundingBox NoteShapeIsoscelesTriangleBlack { get; set; }

        [JsonProperty("noteShapeIsoscelesTriangleDoubleWhole")]
        public BoundingBox NoteShapeIsoscelesTriangleDoubleWhole { get; set; }

        [JsonProperty("noteShapeIsoscelesTriangleWhite")]
        public BoundingBox NoteShapeIsoscelesTriangleWhite { get; set; }

        [JsonProperty("noteShapeKeystoneBlack")]
        public BoundingBox NoteShapeKeystoneBlack { get; set; }

        [JsonProperty("noteShapeKeystoneDoubleWhole")]
        public BoundingBox NoteShapeKeystoneDoubleWhole { get; set; }

        [JsonProperty("noteShapeKeystoneWhite")]
        public BoundingBox NoteShapeKeystoneWhite { get; set; }

        [JsonProperty("noteShapeMoonBlack")]
        public BoundingBox NoteShapeMoonBlack { get; set; }

        [JsonProperty("noteShapeMoonDoubleWhole")]
        public BoundingBox NoteShapeMoonDoubleWhole { get; set; }

        [JsonProperty("noteShapeMoonLeftBlack")]
        public BoundingBox NoteShapeMoonLeftBlack { get; set; }

        [JsonProperty("noteShapeMoonLeftDoubleWhole")]
        public BoundingBox NoteShapeMoonLeftDoubleWhole { get; set; }

        [JsonProperty("noteShapeMoonLeftWhite")]
        public BoundingBox NoteShapeMoonLeftWhite { get; set; }

        [JsonProperty("noteShapeMoonWhite")]
        public BoundingBox NoteShapeMoonWhite { get; set; }

        [JsonProperty("noteShapeQuarterMoonBlack")]
        public BoundingBox NoteShapeQuarterMoonBlack { get; set; }

        [JsonProperty("noteShapeQuarterMoonDoubleWhole")]
        public BoundingBox NoteShapeQuarterMoonDoubleWhole { get; set; }

        [JsonProperty("noteShapeQuarterMoonWhite")]
        public BoundingBox NoteShapeQuarterMoonWhite { get; set; }

        [JsonProperty("noteShapeRoundBlack")]
        public BoundingBox NoteShapeRoundBlack { get; set; }

        [JsonProperty("noteShapeRoundDoubleWhole")]
        public BoundingBox NoteShapeRoundDoubleWhole { get; set; }

        [JsonProperty("noteShapeRoundWhite")]
        public BoundingBox NoteShapeRoundWhite { get; set; }

        [JsonProperty("noteShapeSquareBlack")]
        public BoundingBox NoteShapeSquareBlack { get; set; }

        [JsonProperty("noteShapeSquareDoubleWhole")]
        public BoundingBox NoteShapeSquareDoubleWhole { get; set; }

        [JsonProperty("noteShapeSquareWhite")]
        public BoundingBox NoteShapeSquareWhite { get; set; }

        [JsonProperty("noteShapeTriangleLeftBlack")]
        public BoundingBox NoteShapeTriangleLeftBlack { get; set; }

        [JsonProperty("noteShapeTriangleLeftDoubleWhole")]
        public BoundingBox NoteShapeTriangleLeftDoubleWhole { get; set; }

        [JsonProperty("noteShapeTriangleLeftWhite")]
        public BoundingBox NoteShapeTriangleLeftWhite { get; set; }

        [JsonProperty("noteShapeTriangleRightBlack")]
        public BoundingBox NoteShapeTriangleRightBlack { get; set; }

        [JsonProperty("noteShapeTriangleRightDoubleWhole")]
        public BoundingBox NoteShapeTriangleRightDoubleWhole { get; set; }

        [JsonProperty("noteShapeTriangleRightWhite")]
        public BoundingBox NoteShapeTriangleRightWhite { get; set; }

        [JsonProperty("noteShapeTriangleRoundBlack")]
        public BoundingBox NoteShapeTriangleRoundBlack { get; set; }

        [JsonProperty("noteShapeTriangleRoundDoubleWhole")]
        public BoundingBox NoteShapeTriangleRoundDoubleWhole { get; set; }

        [JsonProperty("noteShapeTriangleRoundLeftBlack")]
        public BoundingBox NoteShapeTriangleRoundLeftBlack { get; set; }

        [JsonProperty("noteShapeTriangleRoundLeftDoubleWhole")]
        public BoundingBox NoteShapeTriangleRoundLeftDoubleWhole { get; set; }

        [JsonProperty("noteShapeTriangleRoundLeftWhite")]
        public BoundingBox NoteShapeTriangleRoundLeftWhite { get; set; }

        [JsonProperty("noteShapeTriangleRoundWhite")]
        public BoundingBox NoteShapeTriangleRoundWhite { get; set; }

        [JsonProperty("noteShapeTriangleUpBlack")]
        public BoundingBox NoteShapeTriangleUpBlack { get; set; }

        [JsonProperty("noteShapeTriangleUpDoubleWhole")]
        public BoundingBox NoteShapeTriangleUpDoubleWhole { get; set; }

        [JsonProperty("noteShapeTriangleUpWhite")]
        public BoundingBox NoteShapeTriangleUpWhite { get; set; }

        [JsonProperty("noteSiBlack")]
        public BoundingBox NoteSiBlack { get; set; }

        [JsonProperty("noteSiHalf")]
        public BoundingBox NoteSiHalf { get; set; }

        [JsonProperty("noteSiWhole")]
        public BoundingBox NoteSiWhole { get; set; }

        [JsonProperty("noteSoBlack")]
        public BoundingBox NoteSoBlack { get; set; }

        [JsonProperty("noteSoHalf")]
        public BoundingBox NoteSoHalf { get; set; }

        [JsonProperty("noteSoWhole")]
        public BoundingBox NoteSoWhole { get; set; }

        [JsonProperty("noteTiBlack")]
        public BoundingBox NoteTiBlack { get; set; }

        [JsonProperty("noteTiHalf")]
        public BoundingBox NoteTiHalf { get; set; }

        [JsonProperty("noteTiWhole")]
        public BoundingBox NoteTiWhole { get; set; }

        [JsonProperty("noteWhole")]
        public BoundingBox NoteWhole { get; set; }

        [JsonProperty("noteheadBlack")]
        public BoundingBox NoteheadBlack { get; set; }

        [JsonProperty("noteheadBlackOversized")]
        public BoundingBox NoteheadBlackOversized { get; set; }

        [JsonProperty("noteheadBlackParens")]
        public BoundingBox NoteheadBlackParens { get; set; }

        [JsonProperty("noteheadBlackSmall")]
        public BoundingBox NoteheadBlackSmall { get; set; }

        [JsonProperty("noteheadCircleSlash")]
        public BoundingBox NoteheadCircleSlash { get; set; }

        [JsonProperty("noteheadCircleX")]
        public BoundingBox NoteheadCircleX { get; set; }

        [JsonProperty("noteheadCircleXDoubleWhole")]
        public BoundingBox NoteheadCircleXDoubleWhole { get; set; }

        [JsonProperty("noteheadCircleXHalf")]
        public BoundingBox NoteheadCircleXHalf { get; set; }

        [JsonProperty("noteheadCircleXWhole")]
        public BoundingBox NoteheadCircleXWhole { get; set; }

        [JsonProperty("noteheadCircledBlack")]
        public BoundingBox NoteheadCircledBlack { get; set; }

        [JsonProperty("noteheadCircledBlackLarge")]
        public BoundingBox NoteheadCircledBlackLarge { get; set; }

        [JsonProperty("noteheadCircledDoubleWhole")]
        public BoundingBox NoteheadCircledDoubleWhole { get; set; }

        [JsonProperty("noteheadCircledDoubleWholeLarge")]
        public BoundingBox NoteheadCircledDoubleWholeLarge { get; set; }

        [JsonProperty("noteheadCircledHalf")]
        public BoundingBox NoteheadCircledHalf { get; set; }

        [JsonProperty("noteheadCircledHalfLarge")]
        public BoundingBox NoteheadCircledHalfLarge { get; set; }

        [JsonProperty("noteheadCircledWhole")]
        public BoundingBox NoteheadCircledWhole { get; set; }

        [JsonProperty("noteheadCircledWholeLarge")]
        public BoundingBox NoteheadCircledWholeLarge { get; set; }

        [JsonProperty("noteheadCircledXLarge")]
        public BoundingBox NoteheadCircledXLarge { get; set; }

        [JsonProperty("noteheadClusterDoubleWhole2nd")]
        public BoundingBox NoteheadClusterDoubleWhole2Nd { get; set; }

        [JsonProperty("noteheadClusterDoubleWhole3rd")]
        public BoundingBox NoteheadClusterDoubleWhole3Rd { get; set; }

        [JsonProperty("noteheadClusterDoubleWholeBottom")]
        public BoundingBox NoteheadClusterDoubleWholeBottom { get; set; }

        [JsonProperty("noteheadClusterDoubleWholeMiddle")]
        public BoundingBox NoteheadClusterDoubleWholeMiddle { get; set; }

        [JsonProperty("noteheadClusterDoubleWholeTop")]
        public BoundingBox NoteheadClusterDoubleWholeTop { get; set; }

        [JsonProperty("noteheadClusterHalf2nd")]
        public BoundingBox NoteheadClusterHalf2Nd { get; set; }

        [JsonProperty("noteheadClusterHalf3rd")]
        public BoundingBox NoteheadClusterHalf3Rd { get; set; }

        [JsonProperty("noteheadClusterHalfBottom")]
        public BoundingBox NoteheadClusterHalfBottom { get; set; }

        [JsonProperty("noteheadClusterHalfMiddle")]
        public BoundingBox NoteheadClusterHalfMiddle { get; set; }

        [JsonProperty("noteheadClusterHalfTop")]
        public BoundingBox NoteheadClusterHalfTop { get; set; }

        [JsonProperty("noteheadClusterQuarter2nd")]
        public BoundingBox NoteheadClusterQuarter2Nd { get; set; }

        [JsonProperty("noteheadClusterQuarter3rd")]
        public BoundingBox NoteheadClusterQuarter3Rd { get; set; }

        [JsonProperty("noteheadClusterQuarterBottom")]
        public BoundingBox NoteheadClusterQuarterBottom { get; set; }

        [JsonProperty("noteheadClusterQuarterMiddle")]
        public BoundingBox NoteheadClusterQuarterMiddle { get; set; }

        [JsonProperty("noteheadClusterQuarterTop")]
        public BoundingBox NoteheadClusterQuarterTop { get; set; }

        [JsonProperty("noteheadClusterRoundBlack")]
        public BoundingBox NoteheadClusterRoundBlack { get; set; }

        [JsonProperty("noteheadClusterRoundWhite")]
        public BoundingBox NoteheadClusterRoundWhite { get; set; }

        [JsonProperty("noteheadClusterSquareBlack")]
        public BoundingBox NoteheadClusterSquareBlack { get; set; }

        [JsonProperty("noteheadClusterSquareWhite")]
        public BoundingBox NoteheadClusterSquareWhite { get; set; }

        [JsonProperty("noteheadClusterWhole2nd")]
        public BoundingBox NoteheadClusterWhole2Nd { get; set; }

        [JsonProperty("noteheadClusterWhole3rd")]
        public BoundingBox NoteheadClusterWhole3Rd { get; set; }

        [JsonProperty("noteheadClusterWholeBottom")]
        public BoundingBox NoteheadClusterWholeBottom { get; set; }

        [JsonProperty("noteheadClusterWholeMiddle")]
        public BoundingBox NoteheadClusterWholeMiddle { get; set; }

        [JsonProperty("noteheadClusterWholeTop")]
        public BoundingBox NoteheadClusterWholeTop { get; set; }

        [JsonProperty("noteheadDiamondBlack")]
        public BoundingBox NoteheadDiamondBlack { get; set; }

        [JsonProperty("noteheadDiamondBlackOld")]
        public BoundingBox NoteheadDiamondBlackOld { get; set; }

        [JsonProperty("noteheadDiamondBlackWide")]
        public BoundingBox NoteheadDiamondBlackWide { get; set; }

        [JsonProperty("noteheadDiamondClusterBlack2nd")]
        public BoundingBox NoteheadDiamondClusterBlack2Nd { get; set; }

        [JsonProperty("noteheadDiamondClusterBlack3rd")]
        public BoundingBox NoteheadDiamondClusterBlack3Rd { get; set; }

        [JsonProperty("noteheadDiamondClusterBlackBottom")]
        public BoundingBox NoteheadDiamondClusterBlackBottom { get; set; }

        [JsonProperty("noteheadDiamondClusterBlackMiddle")]
        public BoundingBox NoteheadDiamondClusterBlackMiddle { get; set; }

        [JsonProperty("noteheadDiamondClusterBlackTop")]
        public BoundingBox NoteheadDiamondClusterBlackTop { get; set; }

        [JsonProperty("noteheadDiamondClusterWhite2nd")]
        public BoundingBox NoteheadDiamondClusterWhite2Nd { get; set; }

        [JsonProperty("noteheadDiamondClusterWhite3rd")]
        public BoundingBox NoteheadDiamondClusterWhite3Rd { get; set; }

        [JsonProperty("noteheadDiamondClusterWhiteBottom")]
        public BoundingBox NoteheadDiamondClusterWhiteBottom { get; set; }

        [JsonProperty("noteheadDiamondClusterWhiteMiddle")]
        public BoundingBox NoteheadDiamondClusterWhiteMiddle { get; set; }

        [JsonProperty("noteheadDiamondClusterWhiteTop")]
        public BoundingBox NoteheadDiamondClusterWhiteTop { get; set; }

        [JsonProperty("noteheadDiamondDoubleWhole")]
        public BoundingBox NoteheadDiamondDoubleWhole { get; set; }

        [JsonProperty("noteheadDiamondDoubleWholeOld")]
        public BoundingBox NoteheadDiamondDoubleWholeOld { get; set; }

        [JsonProperty("noteheadDiamondHalf")]
        public BoundingBox NoteheadDiamondHalf { get; set; }

        [JsonProperty("noteheadDiamondHalfFilled")]
        public BoundingBox NoteheadDiamondHalfFilled { get; set; }

        [JsonProperty("noteheadDiamondHalfOld")]
        public BoundingBox NoteheadDiamondHalfOld { get; set; }

        [JsonProperty("noteheadDiamondHalfWide")]
        public BoundingBox NoteheadDiamondHalfWide { get; set; }

        [JsonProperty("noteheadDiamondOpen")]
        public BoundingBox NoteheadDiamondOpen { get; set; }

        [JsonProperty("noteheadDiamondWhite")]
        public BoundingBox NoteheadDiamondWhite { get; set; }

        [JsonProperty("noteheadDiamondWhiteWide")]
        public BoundingBox NoteheadDiamondWhiteWide { get; set; }

        [JsonProperty("noteheadDiamondWhole")]
        public BoundingBox NoteheadDiamondWhole { get; set; }

        [JsonProperty("noteheadDiamondWholeOld")]
        public BoundingBox NoteheadDiamondWholeOld { get; set; }

        [JsonProperty("noteheadDoubleWhole")]
        public BoundingBox NoteheadDoubleWhole { get; set; }

        [JsonProperty("noteheadDoubleWholeAlt")]
        public BoundingBox NoteheadDoubleWholeAlt { get; set; }

        [JsonProperty("noteheadDoubleWholeOversized")]
        public BoundingBox NoteheadDoubleWholeOversized { get; set; }

        [JsonProperty("noteheadDoubleWholeParens")]
        public BoundingBox NoteheadDoubleWholeParens { get; set; }

        [JsonProperty("noteheadDoubleWholeSmall")]
        public BoundingBox NoteheadDoubleWholeSmall { get; set; }

        [JsonProperty("noteheadDoubleWholeSquare")]
        public BoundingBox NoteheadDoubleWholeSquare { get; set; }

        [JsonProperty("noteheadDoubleWholeSquareOversized")]
        public BoundingBox NoteheadDoubleWholeSquareOversized { get; set; }

        [JsonProperty("noteheadDoubleWholeWithX")]
        public BoundingBox NoteheadDoubleWholeWithX { get; set; }

        [JsonProperty("noteheadHalf")]
        public BoundingBox NoteheadHalf { get; set; }

        [JsonProperty("noteheadHalfFilled")]
        public BoundingBox NoteheadHalfFilled { get; set; }

        [JsonProperty("noteheadHalfOversized")]
        public BoundingBox NoteheadHalfOversized { get; set; }

        [JsonProperty("noteheadHalfParens")]
        public BoundingBox NoteheadHalfParens { get; set; }

        [JsonProperty("noteheadHalfSmall")]
        public BoundingBox NoteheadHalfSmall { get; set; }

        [JsonProperty("noteheadHalfWithX")]
        public BoundingBox NoteheadHalfWithX { get; set; }

        [JsonProperty("noteheadHeavyX")]
        public BoundingBox NoteheadHeavyX { get; set; }

        [JsonProperty("noteheadHeavyXHat")]
        public BoundingBox NoteheadHeavyXHat { get; set; }

        [JsonProperty("noteheadLargeArrowDownBlack")]
        public BoundingBox NoteheadLargeArrowDownBlack { get; set; }

        [JsonProperty("noteheadLargeArrowDownDoubleWhole")]
        public BoundingBox NoteheadLargeArrowDownDoubleWhole { get; set; }

        [JsonProperty("noteheadLargeArrowDownHalf")]
        public BoundingBox NoteheadLargeArrowDownHalf { get; set; }

        [JsonProperty("noteheadLargeArrowDownWhole")]
        public BoundingBox NoteheadLargeArrowDownWhole { get; set; }

        [JsonProperty("noteheadLargeArrowUpBlack")]
        public BoundingBox NoteheadLargeArrowUpBlack { get; set; }

        [JsonProperty("noteheadLargeArrowUpDoubleWhole")]
        public BoundingBox NoteheadLargeArrowUpDoubleWhole { get; set; }

        [JsonProperty("noteheadLargeArrowUpHalf")]
        public BoundingBox NoteheadLargeArrowUpHalf { get; set; }

        [JsonProperty("noteheadLargeArrowUpWhole")]
        public BoundingBox NoteheadLargeArrowUpWhole { get; set; }

        [JsonProperty("noteheadMoonBlack")]
        public BoundingBox NoteheadMoonBlack { get; set; }

        [JsonProperty("noteheadMoonWhite")]
        public BoundingBox NoteheadMoonWhite { get; set; }

        [JsonProperty("noteheadParenthesis")]
        public BoundingBox NoteheadParenthesis { get; set; }

        [JsonProperty("noteheadParenthesisLeft")]
        public BoundingBox NoteheadParenthesisLeft { get; set; }

        [JsonProperty("noteheadParenthesisRight")]
        public BoundingBox NoteheadParenthesisRight { get; set; }

        [JsonProperty("noteheadPlusBlack")]
        public BoundingBox NoteheadPlusBlack { get; set; }

        [JsonProperty("noteheadPlusDoubleWhole")]
        public BoundingBox NoteheadPlusDoubleWhole { get; set; }

        [JsonProperty("noteheadPlusHalf")]
        public BoundingBox NoteheadPlusHalf { get; set; }

        [JsonProperty("noteheadPlusWhole")]
        public BoundingBox NoteheadPlusWhole { get; set; }

        [JsonProperty("noteheadRectangularClusterBlackBottom")]
        public BoundingBox NoteheadRectangularClusterBlackBottom { get; set; }

        [JsonProperty("noteheadRectangularClusterBlackMiddle")]
        public BoundingBox NoteheadRectangularClusterBlackMiddle { get; set; }

        [JsonProperty("noteheadRectangularClusterBlackTop")]
        public BoundingBox NoteheadRectangularClusterBlackTop { get; set; }

        [JsonProperty("noteheadRectangularClusterWhiteBottom")]
        public BoundingBox NoteheadRectangularClusterWhiteBottom { get; set; }

        [JsonProperty("noteheadRectangularClusterWhiteMiddle")]
        public BoundingBox NoteheadRectangularClusterWhiteMiddle { get; set; }

        [JsonProperty("noteheadRectangularClusterWhiteTop")]
        public BoundingBox NoteheadRectangularClusterWhiteTop { get; set; }

        [JsonProperty("noteheadRoundBlack")]
        public BoundingBox NoteheadRoundBlack { get; set; }

        [JsonProperty("noteheadRoundBlackDoubleSlashed")]
        public BoundingBox NoteheadRoundBlackDoubleSlashed { get; set; }

        [JsonProperty("noteheadRoundBlackLarge")]
        public Dictionary<string, long[]> NoteheadRoundBlackLarge { get; set; }

        [JsonProperty("noteheadRoundBlackSlashed")]
        public BoundingBox NoteheadRoundBlackSlashed { get; set; }

        [JsonProperty("noteheadRoundBlackSlashedLarge")]
        public BoundingBox NoteheadRoundBlackSlashedLarge { get; set; }

        [JsonProperty("noteheadRoundWhite")]
        public BoundingBox NoteheadRoundWhite { get; set; }

        [JsonProperty("noteheadRoundWhiteDoubleSlashed")]
        public BoundingBox NoteheadRoundWhiteDoubleSlashed { get; set; }

        [JsonProperty("noteheadRoundWhiteLarge")]
        public Dictionary<string, long[]> NoteheadRoundWhiteLarge { get; set; }

        [JsonProperty("noteheadRoundWhiteSlashed")]
        public BoundingBox NoteheadRoundWhiteSlashed { get; set; }

        [JsonProperty("noteheadRoundWhiteSlashedLarge")]
        public BoundingBox NoteheadRoundWhiteSlashedLarge { get; set; }

        [JsonProperty("noteheadRoundWhiteWithDot")]
        public BoundingBox NoteheadRoundWhiteWithDot { get; set; }

        [JsonProperty("noteheadRoundWhiteWithDotLarge")]
        public BoundingBox NoteheadRoundWhiteWithDotLarge { get; set; }

        [JsonProperty("noteheadSlashDiamondWhite")]
        public Dictionary<string, long[]> NoteheadSlashDiamondWhite { get; set; }

        [JsonProperty("noteheadSlashHorizontalEnds")]
        public BoundingBox NoteheadSlashHorizontalEnds { get; set; }

        [JsonProperty("noteheadSlashHorizontalEndsMuted")]
        public BoundingBox NoteheadSlashHorizontalEndsMuted { get; set; }

        [JsonProperty("noteheadSlashVerticalEnds")]
        public BoundingBox NoteheadSlashVerticalEnds { get; set; }

        [JsonProperty("noteheadSlashVerticalEndsMuted")]
        public BoundingBox NoteheadSlashVerticalEndsMuted { get; set; }

        [JsonProperty("noteheadSlashVerticalEndsSmall")]
        public BoundingBox NoteheadSlashVerticalEndsSmall { get; set; }

        [JsonProperty("noteheadSlashWhiteDoubleWhole")]
        public BoundingBox NoteheadSlashWhiteDoubleWhole { get; set; }

        [JsonProperty("noteheadSlashWhiteHalf")]
        public BoundingBox NoteheadSlashWhiteHalf { get; set; }

        [JsonProperty("noteheadSlashWhiteMuted")]
        public BoundingBox NoteheadSlashWhiteMuted { get; set; }

        [JsonProperty("noteheadSlashWhiteWhole")]
        public BoundingBox NoteheadSlashWhiteWhole { get; set; }

        [JsonProperty("noteheadSlashX")]
        public BoundingBox NoteheadSlashX { get; set; }

        [JsonProperty("noteheadSlashedBlack1")]
        public BoundingBox NoteheadSlashedBlack1 { get; set; }

        [JsonProperty("noteheadSlashedBlack2")]
        public BoundingBox NoteheadSlashedBlack2 { get; set; }

        [JsonProperty("noteheadSlashedDoubleWhole1")]
        public BoundingBox NoteheadSlashedDoubleWhole1 { get; set; }

        [JsonProperty("noteheadSlashedDoubleWhole2")]
        public BoundingBox NoteheadSlashedDoubleWhole2 { get; set; }

        [JsonProperty("noteheadSlashedHalf1")]
        public BoundingBox NoteheadSlashedHalf1 { get; set; }

        [JsonProperty("noteheadSlashedHalf2")]
        public BoundingBox NoteheadSlashedHalf2 { get; set; }

        [JsonProperty("noteheadSlashedWhole1")]
        public BoundingBox NoteheadSlashedWhole1 { get; set; }

        [JsonProperty("noteheadSlashedWhole2")]
        public BoundingBox NoteheadSlashedWhole2 { get; set; }

        [JsonProperty("noteheadSquareBlack")]
        public BoundingBox NoteheadSquareBlack { get; set; }

        [JsonProperty("noteheadSquareBlackLarge")]
        public Dictionary<string, long[]> NoteheadSquareBlackLarge { get; set; }

        [JsonProperty("noteheadSquareBlackWhite")]
        public Dictionary<string, long[]> NoteheadSquareBlackWhite { get; set; }

        [JsonProperty("noteheadSquareWhite")]
        public BoundingBox NoteheadSquareWhite { get; set; }

        [JsonProperty("noteheadTriangleDownBlack")]
        public BoundingBox NoteheadTriangleDownBlack { get; set; }

        [JsonProperty("noteheadTriangleDownDoubleWhole")]
        public BoundingBox NoteheadTriangleDownDoubleWhole { get; set; }

        [JsonProperty("noteheadTriangleDownHalf")]
        public BoundingBox NoteheadTriangleDownHalf { get; set; }

        [JsonProperty("noteheadTriangleDownWhite")]
        public BoundingBox NoteheadTriangleDownWhite { get; set; }

        [JsonProperty("noteheadTriangleDownWhole")]
        public BoundingBox NoteheadTriangleDownWhole { get; set; }

        [JsonProperty("noteheadTriangleLeftBlack")]
        public BoundingBox NoteheadTriangleLeftBlack { get; set; }

        [JsonProperty("noteheadTriangleLeftWhite")]
        public BoundingBox NoteheadTriangleLeftWhite { get; set; }

        [JsonProperty("noteheadTriangleRightBlack")]
        public BoundingBox NoteheadTriangleRightBlack { get; set; }

        [JsonProperty("noteheadTriangleRightWhite")]
        public BoundingBox NoteheadTriangleRightWhite { get; set; }

        [JsonProperty("noteheadTriangleRoundDownBlack")]
        public BoundingBox NoteheadTriangleRoundDownBlack { get; set; }

        [JsonProperty("noteheadTriangleRoundDownWhite")]
        public BoundingBox NoteheadTriangleRoundDownWhite { get; set; }

        [JsonProperty("noteheadTriangleUpBlack")]
        public BoundingBox NoteheadTriangleUpBlack { get; set; }

        [JsonProperty("noteheadTriangleUpDoubleWhole")]
        public BoundingBox NoteheadTriangleUpDoubleWhole { get; set; }

        [JsonProperty("noteheadTriangleUpHalf")]
        public BoundingBox NoteheadTriangleUpHalf { get; set; }

        [JsonProperty("noteheadTriangleUpRightBlack")]
        public BoundingBox NoteheadTriangleUpRightBlack { get; set; }

        [JsonProperty("noteheadTriangleUpRightWhite")]
        public BoundingBox NoteheadTriangleUpRightWhite { get; set; }

        [JsonProperty("noteheadTriangleUpWhite")]
        public BoundingBox NoteheadTriangleUpWhite { get; set; }

        [JsonProperty("noteheadTriangleUpWhole")]
        public BoundingBox NoteheadTriangleUpWhole { get; set; }

        [JsonProperty("noteheadVoidWithX")]
        public BoundingBox NoteheadVoidWithX { get; set; }

        [JsonProperty("noteheadWhole")]
        public BoundingBox NoteheadWhole { get; set; }

        [JsonProperty("noteheadWholeFilled")]
        public BoundingBox NoteheadWholeFilled { get; set; }

        [JsonProperty("noteheadWholeOversized")]
        public BoundingBox NoteheadWholeOversized { get; set; }

        [JsonProperty("noteheadWholeParens")]
        public BoundingBox NoteheadWholeParens { get; set; }

        [JsonProperty("noteheadWholeSmall")]
        public BoundingBox NoteheadWholeSmall { get; set; }

        [JsonProperty("noteheadWholeWithX")]
        public BoundingBox NoteheadWholeWithX { get; set; }

        [JsonProperty("noteheadXBlack")]
        public BoundingBox NoteheadXBlack { get; set; }

        [JsonProperty("noteheadXDoubleWhole")]
        public BoundingBox NoteheadXDoubleWhole { get; set; }

        [JsonProperty("noteheadXHalf")]
        public BoundingBox NoteheadXHalf { get; set; }

        [JsonProperty("noteheadXOrnate")]
        public BoundingBox NoteheadXOrnate { get; set; }

        [JsonProperty("noteheadXOrnateEllipse")]
        public BoundingBox NoteheadXOrnateEllipse { get; set; }

        [JsonProperty("noteheadXWhole")]
        public BoundingBox NoteheadXWhole { get; set; }

        [JsonProperty("octaveBaselineA")]
        public BoundingBox OctaveBaselineA { get; set; }

        [JsonProperty("octaveBaselineB")]
        public BoundingBox OctaveBaselineB { get; set; }

        [JsonProperty("octaveBaselineM")]
        public BoundingBox OctaveBaselineM { get; set; }

        [JsonProperty("octaveBaselineV")]
        public BoundingBox OctaveBaselineV { get; set; }

        [JsonProperty("octaveBassa")]
        public BoundingBox OctaveBassa { get; set; }

        [JsonProperty("octaveLoco")]
        public BoundingBox OctaveLoco { get; set; }

        [JsonProperty("octaveParensLeft")]
        public BoundingBox OctaveParensLeft { get; set; }

        [JsonProperty("octaveParensRight")]
        public BoundingBox OctaveParensRight { get; set; }

        [JsonProperty("octaveSuperscriptA")]
        public BoundingBox OctaveSuperscriptA { get; set; }

        [JsonProperty("octaveSuperscriptB")]
        public BoundingBox OctaveSuperscriptB { get; set; }

        [JsonProperty("octaveSuperscriptM")]
        public BoundingBox OctaveSuperscriptM { get; set; }

        [JsonProperty("octaveSuperscriptV")]
        public BoundingBox OctaveSuperscriptV { get; set; }

        [JsonProperty("ornamentBottomLeftConcaveStroke")]
        public BoundingBox OrnamentBottomLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentBottomLeftConcaveStrokeLarge")]
        public BoundingBox OrnamentBottomLeftConcaveStrokeLarge { get; set; }

        [JsonProperty("ornamentBottomLeftConvexStroke")]
        public BoundingBox OrnamentBottomLeftConvexStroke { get; set; }

        [JsonProperty("ornamentBottomRightConcaveStroke")]
        public BoundingBox OrnamentBottomRightConcaveStroke { get; set; }

        [JsonProperty("ornamentBottomRightConvexStroke")]
        public BoundingBox OrnamentBottomRightConvexStroke { get; set; }

        [JsonProperty("ornamentComma")]
        public BoundingBox OrnamentComma { get; set; }

        [JsonProperty("ornamentDoubleObliqueLinesAfterNote")]
        public BoundingBox OrnamentDoubleObliqueLinesAfterNote { get; set; }

        [JsonProperty("ornamentDoubleObliqueLinesBeforeNote")]
        public BoundingBox OrnamentDoubleObliqueLinesBeforeNote { get; set; }

        [JsonProperty("ornamentDownCurve")]
        public BoundingBox OrnamentDownCurve { get; set; }

        [JsonProperty("ornamentHaydn")]
        public BoundingBox OrnamentHaydn { get; set; }

        [JsonProperty("ornamentHighLeftConcaveStroke")]
        public BoundingBox OrnamentHighLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentHighLeftConvexStroke")]
        public BoundingBox OrnamentHighLeftConvexStroke { get; set; }

        [JsonProperty("ornamentHighRightConcaveStroke")]
        public BoundingBox OrnamentHighRightConcaveStroke { get; set; }

        [JsonProperty("ornamentHighRightConvexStroke")]
        public BoundingBox OrnamentHighRightConvexStroke { get; set; }

        [JsonProperty("ornamentHookAfterNote")]
        public BoundingBox OrnamentHookAfterNote { get; set; }

        [JsonProperty("ornamentHookBeforeNote")]
        public BoundingBox OrnamentHookBeforeNote { get; set; }

        [JsonProperty("ornamentLeftFacingHalfCircle")]
        public BoundingBox OrnamentLeftFacingHalfCircle { get; set; }

        [JsonProperty("ornamentLeftFacingHook")]
        public BoundingBox OrnamentLeftFacingHook { get; set; }

        [JsonProperty("ornamentLeftPlus")]
        public BoundingBox OrnamentLeftPlus { get; set; }

        [JsonProperty("ornamentLeftShakeT")]
        public BoundingBox OrnamentLeftShakeT { get; set; }

        [JsonProperty("ornamentLeftVerticalStroke")]
        public BoundingBox OrnamentLeftVerticalStroke { get; set; }

        [JsonProperty("ornamentLeftVerticalStrokeWithCross")]
        public BoundingBox OrnamentLeftVerticalStrokeWithCross { get; set; }

        [JsonProperty("ornamentLowLeftConcaveStroke")]
        public BoundingBox OrnamentLowLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentLowLeftConvexStroke")]
        public BoundingBox OrnamentLowLeftConvexStroke { get; set; }

        [JsonProperty("ornamentLowRightConcaveStroke")]
        public BoundingBox OrnamentLowRightConcaveStroke { get; set; }

        [JsonProperty("ornamentLowRightConvexStroke")]
        public BoundingBox OrnamentLowRightConvexStroke { get; set; }

        [JsonProperty("ornamentMiddleVerticalStroke")]
        public BoundingBox OrnamentMiddleVerticalStroke { get; set; }

        [JsonProperty("ornamentMordent")]
        public BoundingBox OrnamentMordent { get; set; }

        [JsonProperty("ornamentMordentInverted")]
        public BoundingBox OrnamentMordentInverted { get; set; }

        [JsonProperty("ornamentObliqueLineAfterNote")]
        public BoundingBox OrnamentObliqueLineAfterNote { get; set; }

        [JsonProperty("ornamentObliqueLineBeforeNote")]
        public BoundingBox OrnamentObliqueLineBeforeNote { get; set; }

        [JsonProperty("ornamentObliqueLineHorizAfterNote")]
        public BoundingBox OrnamentObliqueLineHorizAfterNote { get; set; }

        [JsonProperty("ornamentObliqueLineHorizBeforeNote")]
        public BoundingBox OrnamentObliqueLineHorizBeforeNote { get; set; }

        [JsonProperty("ornamentOriscus")]
        public BoundingBox OrnamentOriscus { get; set; }

        [JsonProperty("ornamentPinceCouperin")]
        public BoundingBox OrnamentPinceCouperin { get; set; }

        [JsonProperty("ornamentPortDeVoixV")]
        public BoundingBox OrnamentPortDeVoixV { get; set; }

        [JsonProperty("ornamentPrecompAppoggTrill")]
        public BoundingBox OrnamentPrecompAppoggTrill { get; set; }

        [JsonProperty("ornamentPrecompAppoggTrillSuffix")]
        public BoundingBox OrnamentPrecompAppoggTrillSuffix { get; set; }

        [JsonProperty("ornamentPrecompCadence")]
        public BoundingBox OrnamentPrecompCadence { get; set; }

        [JsonProperty("ornamentPrecompCadenceUpperPrefix")]
        public BoundingBox OrnamentPrecompCadenceUpperPrefix { get; set; }

        [JsonProperty("ornamentPrecompCadenceUpperPrefixTurn")]
        public BoundingBox OrnamentPrecompCadenceUpperPrefixTurn { get; set; }

        [JsonProperty("ornamentPrecompCadenceWithTurn")]
        public BoundingBox OrnamentPrecompCadenceWithTurn { get; set; }

        [JsonProperty("ornamentPrecompDescendingSlide")]
        public BoundingBox OrnamentPrecompDescendingSlide { get; set; }

        [JsonProperty("ornamentPrecompDoubleCadenceLowerPrefix")]
        public BoundingBox OrnamentPrecompDoubleCadenceLowerPrefix { get; set; }

        [JsonProperty("ornamentPrecompDoubleCadenceUpperPrefix")]
        public BoundingBox OrnamentPrecompDoubleCadenceUpperPrefix { get; set; }

        [JsonProperty("ornamentPrecompDoubleCadenceUpperPrefixTurn")]
        public BoundingBox OrnamentPrecompDoubleCadenceUpperPrefixTurn { get; set; }

        [JsonProperty("ornamentPrecompInvertedMordentUpperPrefix")]
        public BoundingBox OrnamentPrecompInvertedMordentUpperPrefix { get; set; }

        [JsonProperty("ornamentPrecompMordentRelease")]
        public BoundingBox OrnamentPrecompMordentRelease { get; set; }

        [JsonProperty("ornamentPrecompMordentUpperPrefix")]
        public BoundingBox OrnamentPrecompMordentUpperPrefix { get; set; }

        [JsonProperty("ornamentPrecompPortDeVoixMordent")]
        public BoundingBox OrnamentPrecompPortDeVoixMordent { get; set; }

        [JsonProperty("ornamentPrecompSlide")]
        public BoundingBox OrnamentPrecompSlide { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillBach")]
        public BoundingBox OrnamentPrecompSlideTrillBach { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillDAnglebert")]
        public BoundingBox OrnamentPrecompSlideTrillDAnglebert { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillMarpurg")]
        public BoundingBox OrnamentPrecompSlideTrillMarpurg { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillMuffat")]
        public BoundingBox OrnamentPrecompSlideTrillMuffat { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillSuffixMuffat")]
        public BoundingBox OrnamentPrecompSlideTrillSuffixMuffat { get; set; }

        [JsonProperty("ornamentPrecompTrillLowerSuffix")]
        public BoundingBox OrnamentPrecompTrillLowerSuffix { get; set; }

        [JsonProperty("ornamentPrecompTrillSuffixDandrieu")]
        public BoundingBox OrnamentPrecompTrillSuffixDandrieu { get; set; }

        [JsonProperty("ornamentPrecompTrillWithMordent")]
        public BoundingBox OrnamentPrecompTrillWithMordent { get; set; }

        [JsonProperty("ornamentPrecompTurnTrillBach")]
        public BoundingBox OrnamentPrecompTurnTrillBach { get; set; }

        [JsonProperty("ornamentPrecompTurnTrillDAnglebert")]
        public BoundingBox OrnamentPrecompTurnTrillDAnglebert { get; set; }

        [JsonProperty("ornamentQuilisma")]
        public BoundingBox OrnamentQuilisma { get; set; }

        [JsonProperty("ornamentRightFacingHalfCircle")]
        public BoundingBox OrnamentRightFacingHalfCircle { get; set; }

        [JsonProperty("ornamentRightFacingHook")]
        public BoundingBox OrnamentRightFacingHook { get; set; }

        [JsonProperty("ornamentRightVerticalStroke")]
        public BoundingBox OrnamentRightVerticalStroke { get; set; }

        [JsonProperty("ornamentSchleifer")]
        public BoundingBox OrnamentSchleifer { get; set; }

        [JsonProperty("ornamentShake3")]
        public BoundingBox OrnamentShake3 { get; set; }

        [JsonProperty("ornamentShakeMuffat1")]
        public BoundingBox OrnamentShakeMuffat1 { get; set; }

        [JsonProperty("ornamentShortObliqueLineAfterNote")]
        public BoundingBox OrnamentShortObliqueLineAfterNote { get; set; }

        [JsonProperty("ornamentShortObliqueLineBeforeNote")]
        public BoundingBox OrnamentShortObliqueLineBeforeNote { get; set; }

        [JsonProperty("ornamentTopLeftConcaveStroke")]
        public BoundingBox OrnamentTopLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentTopLeftConvexStroke")]
        public BoundingBox OrnamentTopLeftConvexStroke { get; set; }

        [JsonProperty("ornamentTopRightConcaveStroke")]
        public BoundingBox OrnamentTopRightConcaveStroke { get; set; }

        [JsonProperty("ornamentTopRightConvexStroke")]
        public BoundingBox OrnamentTopRightConvexStroke { get; set; }

        [JsonProperty("ornamentTremblement")]
        public BoundingBox OrnamentTremblement { get; set; }

        [JsonProperty("ornamentTremblementCouperin")]
        public BoundingBox OrnamentTremblementCouperin { get; set; }

        [JsonProperty("ornamentTrill")]
        public BoundingBox OrnamentTrill { get; set; }

        [JsonProperty("ornamentTrillFlatAbove")]
        public BoundingBox OrnamentTrillFlatAbove { get; set; }

        [JsonProperty("ornamentTrillNaturalAbove")]
        public BoundingBox OrnamentTrillNaturalAbove { get; set; }

        [JsonProperty("ornamentTrillSharpAbove")]
        public BoundingBox OrnamentTrillSharpAbove { get; set; }

        [JsonProperty("ornamentTurn")]
        public BoundingBox OrnamentTurn { get; set; }

        [JsonProperty("ornamentTurnFlatAbove")]
        public BoundingBox OrnamentTurnFlatAbove { get; set; }

        [JsonProperty("ornamentTurnFlatAboveSharpBelow")]
        public BoundingBox OrnamentTurnFlatAboveSharpBelow { get; set; }

        [JsonProperty("ornamentTurnFlatBelow")]
        public BoundingBox OrnamentTurnFlatBelow { get; set; }

        [JsonProperty("ornamentTurnInverted")]
        public BoundingBox OrnamentTurnInverted { get; set; }

        [JsonProperty("ornamentTurnNaturalAbove")]
        public BoundingBox OrnamentTurnNaturalAbove { get; set; }

        [JsonProperty("ornamentTurnNaturalBelow")]
        public BoundingBox OrnamentTurnNaturalBelow { get; set; }

        [JsonProperty("ornamentTurnSharpAbove")]
        public BoundingBox OrnamentTurnSharpAbove { get; set; }

        [JsonProperty("ornamentTurnSharpAboveFlatBelow")]
        public BoundingBox OrnamentTurnSharpAboveFlatBelow { get; set; }

        [JsonProperty("ornamentTurnSharpBelow")]
        public BoundingBox OrnamentTurnSharpBelow { get; set; }

        [JsonProperty("ornamentTurnSlash")]
        public BoundingBox OrnamentTurnSlash { get; set; }

        [JsonProperty("ornamentTurnUp")]
        public BoundingBox OrnamentTurnUp { get; set; }

        [JsonProperty("ornamentTurnUpS")]
        public BoundingBox OrnamentTurnUpS { get; set; }

        [JsonProperty("ornamentUpCurve")]
        public BoundingBox OrnamentUpCurve { get; set; }

        [JsonProperty("ornamentVerticalLine")]
        public BoundingBox OrnamentVerticalLine { get; set; }

        [JsonProperty("ornamentZigZagLineNoRightEnd")]
        public BoundingBox OrnamentZigZagLineNoRightEnd { get; set; }

        [JsonProperty("ornamentZigZagLineWithRightEnd")]
        public BoundingBox OrnamentZigZagLineWithRightEnd { get; set; }

        [JsonProperty("ottava")]
        public BoundingBox Ottava { get; set; }

        [JsonProperty("ottavaAlta")]
        public BoundingBox OttavaAlta { get; set; }

        [JsonProperty("ottavaBassa")]
        public BoundingBox OttavaBassa { get; set; }

        [JsonProperty("ottavaBassaBa")]
        public BoundingBox OttavaBassaBa { get; set; }

        [JsonProperty("ottavaBassaVb")]
        public BoundingBox OttavaBassaVb { get; set; }

        [JsonProperty("pendereckiTremolo")]
        public BoundingBox PendereckiTremolo { get; set; }

        [JsonProperty("pictAgogo")]
        public BoundingBox PictAgogo { get; set; }

        [JsonProperty("pictAlmglocken")]
        public BoundingBox PictAlmglocken { get; set; }

        [JsonProperty("pictAnvil")]
        public BoundingBox PictAnvil { get; set; }

        [JsonProperty("pictBambooChimes")]
        public BoundingBox PictBambooChimes { get; set; }

        [JsonProperty("pictBambooScraper")]
        public BoundingBox PictBambooScraper { get; set; }

        [JsonProperty("pictBassDrum")]
        public BoundingBox PictBassDrum { get; set; }

        [JsonProperty("pictBassDrumOnSide")]
        public BoundingBox PictBassDrumOnSide { get; set; }

        [JsonProperty("pictBassDrumPeinkofer")]
        public BoundingBox PictBassDrumPeinkofer { get; set; }

        [JsonProperty("pictBeaterBow")]
        public BoundingBox PictBeaterBow { get; set; }

        [JsonProperty("pictBeaterBox")]
        public BoundingBox PictBeaterBox { get; set; }

        [JsonProperty("pictBeaterBrassMalletsDown")]
        public BoundingBox PictBeaterBrassMalletsDown { get; set; }

        [JsonProperty("pictBeaterBrassMalletsUp")]
        public BoundingBox PictBeaterBrassMalletsUp { get; set; }

        [JsonProperty("pictBeaterCombiningDashedCircle")]
        public BoundingBox PictBeaterCombiningDashedCircle { get; set; }

        [JsonProperty("pictBeaterCombiningParentheses")]
        public BoundingBox PictBeaterCombiningParentheses { get; set; }

        [JsonProperty("pictBeaterDoubleBassDrumDown")]
        public BoundingBox PictBeaterDoubleBassDrumDown { get; set; }

        [JsonProperty("pictBeaterDoubleBassDrumUp")]
        public BoundingBox PictBeaterDoubleBassDrumUp { get; set; }

        [JsonProperty("pictBeaterFinger")]
        public BoundingBox PictBeaterFinger { get; set; }

        [JsonProperty("pictBeaterFingernails")]
        public BoundingBox PictBeaterFingernails { get; set; }

        [JsonProperty("pictBeaterFist")]
        public BoundingBox PictBeaterFist { get; set; }

        [JsonProperty("pictBeaterGuiroScraper")]
        public BoundingBox PictBeaterGuiroScraper { get; set; }

        [JsonProperty("pictBeaterHammer")]
        public BoundingBox PictBeaterHammer { get; set; }

        [JsonProperty("pictBeaterHammerMetalDown")]
        public BoundingBox PictBeaterHammerMetalDown { get; set; }

        [JsonProperty("pictBeaterHammerMetalUp")]
        public BoundingBox PictBeaterHammerMetalUp { get; set; }

        [JsonProperty("pictBeaterHammerPlasticDown")]
        public BoundingBox PictBeaterHammerPlasticDown { get; set; }

        [JsonProperty("pictBeaterHammerPlasticUp")]
        public BoundingBox PictBeaterHammerPlasticUp { get; set; }

        [JsonProperty("pictBeaterHammerWoodDown")]
        public BoundingBox PictBeaterHammerWoodDown { get; set; }

        [JsonProperty("pictBeaterHammerWoodUp")]
        public BoundingBox PictBeaterHammerWoodUp { get; set; }

        [JsonProperty("pictBeaterHand")]
        public BoundingBox PictBeaterHand { get; set; }

        [JsonProperty("pictBeaterHardBassDrumDown")]
        public BoundingBox PictBeaterHardBassDrumDown { get; set; }

        [JsonProperty("pictBeaterHardBassDrumUp")]
        public BoundingBox PictBeaterHardBassDrumUp { get; set; }

        [JsonProperty("pictBeaterHardGlockenspielDown")]
        public BoundingBox PictBeaterHardGlockenspielDown { get; set; }

        [JsonProperty("pictBeaterHardGlockenspielLeft")]
        public BoundingBox PictBeaterHardGlockenspielLeft { get; set; }

        [JsonProperty("pictBeaterHardGlockenspielRight")]
        public BoundingBox PictBeaterHardGlockenspielRight { get; set; }

        [JsonProperty("pictBeaterHardGlockenspielUp")]
        public BoundingBox PictBeaterHardGlockenspielUp { get; set; }

        [JsonProperty("pictBeaterHardTimpaniDown")]
        public BoundingBox PictBeaterHardTimpaniDown { get; set; }

        [JsonProperty("pictBeaterHardTimpaniLeft")]
        public BoundingBox PictBeaterHardTimpaniLeft { get; set; }

        [JsonProperty("pictBeaterHardTimpaniRight")]
        public BoundingBox PictBeaterHardTimpaniRight { get; set; }

        [JsonProperty("pictBeaterHardTimpaniUp")]
        public BoundingBox PictBeaterHardTimpaniUp { get; set; }

        [JsonProperty("pictBeaterHardXylophoneDown")]
        public BoundingBox PictBeaterHardXylophoneDown { get; set; }

        [JsonProperty("pictBeaterHardXylophoneLeft")]
        public BoundingBox PictBeaterHardXylophoneLeft { get; set; }

        [JsonProperty("pictBeaterHardXylophoneRight")]
        public BoundingBox PictBeaterHardXylophoneRight { get; set; }

        [JsonProperty("pictBeaterHardXylophoneUp")]
        public BoundingBox PictBeaterHardXylophoneUp { get; set; }

        [JsonProperty("pictBeaterHardYarnDown")]
        public BoundingBox PictBeaterHardYarnDown { get; set; }

        [JsonProperty("pictBeaterHardYarnLeft")]
        public BoundingBox PictBeaterHardYarnLeft { get; set; }

        [JsonProperty("pictBeaterHardYarnRight")]
        public BoundingBox PictBeaterHardYarnRight { get; set; }

        [JsonProperty("pictBeaterHardYarnUp")]
        public BoundingBox PictBeaterHardYarnUp { get; set; }

        [JsonProperty("pictBeaterJazzSticksDown")]
        public BoundingBox PictBeaterJazzSticksDown { get; set; }

        [JsonProperty("pictBeaterJazzSticksUp")]
        public BoundingBox PictBeaterJazzSticksUp { get; set; }

        [JsonProperty("pictBeaterKnittingNeedle")]
        public BoundingBox PictBeaterKnittingNeedle { get; set; }

        [JsonProperty("pictBeaterMallet")]
        public BoundingBox PictBeaterMallet { get; set; }

        [JsonProperty("pictBeaterMediumBassDrumDown")]
        public BoundingBox PictBeaterMediumBassDrumDown { get; set; }

        [JsonProperty("pictBeaterMediumBassDrumUp")]
        public BoundingBox PictBeaterMediumBassDrumUp { get; set; }

        [JsonProperty("pictBeaterMediumTimpaniDown")]
        public BoundingBox PictBeaterMediumTimpaniDown { get; set; }

        [JsonProperty("pictBeaterMediumTimpaniLeft")]
        public BoundingBox PictBeaterMediumTimpaniLeft { get; set; }

        [JsonProperty("pictBeaterMediumTimpaniRight")]
        public BoundingBox PictBeaterMediumTimpaniRight { get; set; }

        [JsonProperty("pictBeaterMediumTimpaniUp")]
        public BoundingBox PictBeaterMediumTimpaniUp { get; set; }

        [JsonProperty("pictBeaterMediumXylophoneDown")]
        public BoundingBox PictBeaterMediumXylophoneDown { get; set; }

        [JsonProperty("pictBeaterMediumXylophoneLeft")]
        public BoundingBox PictBeaterMediumXylophoneLeft { get; set; }

        [JsonProperty("pictBeaterMediumXylophoneRight")]
        public BoundingBox PictBeaterMediumXylophoneRight { get; set; }

        [JsonProperty("pictBeaterMediumXylophoneUp")]
        public BoundingBox PictBeaterMediumXylophoneUp { get; set; }

        [JsonProperty("pictBeaterMediumYarnDown")]
        public BoundingBox PictBeaterMediumYarnDown { get; set; }

        [JsonProperty("pictBeaterMediumYarnLeft")]
        public BoundingBox PictBeaterMediumYarnLeft { get; set; }

        [JsonProperty("pictBeaterMediumYarnRight")]
        public BoundingBox PictBeaterMediumYarnRight { get; set; }

        [JsonProperty("pictBeaterMediumYarnUp")]
        public BoundingBox PictBeaterMediumYarnUp { get; set; }

        [JsonProperty("pictBeaterMetalBassDrumDown")]
        public BoundingBox PictBeaterMetalBassDrumDown { get; set; }

        [JsonProperty("pictBeaterMetalBassDrumUp")]
        public BoundingBox PictBeaterMetalBassDrumUp { get; set; }

        [JsonProperty("pictBeaterMetalDown")]
        public BoundingBox PictBeaterMetalDown { get; set; }

        [JsonProperty("pictBeaterMetalHammer")]
        public BoundingBox PictBeaterMetalHammer { get; set; }

        [JsonProperty("pictBeaterMetalLeft")]
        public BoundingBox PictBeaterMetalLeft { get; set; }

        [JsonProperty("pictBeaterMetalRight")]
        public BoundingBox PictBeaterMetalRight { get; set; }

        [JsonProperty("pictBeaterMetalUp")]
        public BoundingBox PictBeaterMetalUp { get; set; }

        [JsonProperty("pictBeaterSnareSticksDown")]
        public BoundingBox PictBeaterSnareSticksDown { get; set; }

        [JsonProperty("pictBeaterSnareSticksUp")]
        public BoundingBox PictBeaterSnareSticksUp { get; set; }

        [JsonProperty("pictBeaterSoftBassDrumDown")]
        public BoundingBox PictBeaterSoftBassDrumDown { get; set; }

        [JsonProperty("pictBeaterSoftBassDrumUp")]
        public BoundingBox PictBeaterSoftBassDrumUp { get; set; }

        [JsonProperty("pictBeaterSoftGlockenspielDown")]
        public BoundingBox PictBeaterSoftGlockenspielDown { get; set; }

        [JsonProperty("pictBeaterSoftGlockenspielLeft")]
        public BoundingBox PictBeaterSoftGlockenspielLeft { get; set; }

        [JsonProperty("pictBeaterSoftGlockenspielRight")]
        public BoundingBox PictBeaterSoftGlockenspielRight { get; set; }

        [JsonProperty("pictBeaterSoftGlockenspielUp")]
        public BoundingBox PictBeaterSoftGlockenspielUp { get; set; }

        [JsonProperty("pictBeaterSoftTimpaniDown")]
        public BoundingBox PictBeaterSoftTimpaniDown { get; set; }

        [JsonProperty("pictBeaterSoftTimpaniLeft")]
        public BoundingBox PictBeaterSoftTimpaniLeft { get; set; }

        [JsonProperty("pictBeaterSoftTimpaniRight")]
        public BoundingBox PictBeaterSoftTimpaniRight { get; set; }

        [JsonProperty("pictBeaterSoftTimpaniUp")]
        public BoundingBox PictBeaterSoftTimpaniUp { get; set; }

        [JsonProperty("pictBeaterSoftXylophone")]
        public BoundingBox PictBeaterSoftXylophone { get; set; }

        [JsonProperty("pictBeaterSoftXylophoneDown")]
        public BoundingBox PictBeaterSoftXylophoneDown { get; set; }

        [JsonProperty("pictBeaterSoftXylophoneLeft")]
        public BoundingBox PictBeaterSoftXylophoneLeft { get; set; }

        [JsonProperty("pictBeaterSoftXylophoneRight")]
        public BoundingBox PictBeaterSoftXylophoneRight { get; set; }

        [JsonProperty("pictBeaterSoftXylophoneUp")]
        public BoundingBox PictBeaterSoftXylophoneUp { get; set; }

        [JsonProperty("pictBeaterSoftYarnDown")]
        public BoundingBox PictBeaterSoftYarnDown { get; set; }

        [JsonProperty("pictBeaterSoftYarnLeft")]
        public BoundingBox PictBeaterSoftYarnLeft { get; set; }

        [JsonProperty("pictBeaterSoftYarnRight")]
        public BoundingBox PictBeaterSoftYarnRight { get; set; }

        [JsonProperty("pictBeaterSoftYarnUp")]
        public BoundingBox PictBeaterSoftYarnUp { get; set; }

        [JsonProperty("pictBeaterSpoonWoodenMallet")]
        public BoundingBox PictBeaterSpoonWoodenMallet { get; set; }

        [JsonProperty("pictBeaterSuperballDown")]
        public BoundingBox PictBeaterSuperballDown { get; set; }

        [JsonProperty("pictBeaterSuperballLeft")]
        public BoundingBox PictBeaterSuperballLeft { get; set; }

        [JsonProperty("pictBeaterSuperballRight")]
        public BoundingBox PictBeaterSuperballRight { get; set; }

        [JsonProperty("pictBeaterSuperballUp")]
        public BoundingBox PictBeaterSuperballUp { get; set; }

        [JsonProperty("pictBeaterTriangleDown")]
        public BoundingBox PictBeaterTriangleDown { get; set; }

        [JsonProperty("pictBeaterTriangleUp")]
        public BoundingBox PictBeaterTriangleUp { get; set; }

        [JsonProperty("pictBeaterWireBrushesDown")]
        public BoundingBox PictBeaterWireBrushesDown { get; set; }

        [JsonProperty("pictBeaterWireBrushesUp")]
        public BoundingBox PictBeaterWireBrushesUp { get; set; }

        [JsonProperty("pictBeaterWoodTimpaniDown")]
        public BoundingBox PictBeaterWoodTimpaniDown { get; set; }

        [JsonProperty("pictBeaterWoodTimpaniLeft")]
        public BoundingBox PictBeaterWoodTimpaniLeft { get; set; }

        [JsonProperty("pictBeaterWoodTimpaniRight")]
        public BoundingBox PictBeaterWoodTimpaniRight { get; set; }

        [JsonProperty("pictBeaterWoodTimpaniUp")]
        public BoundingBox PictBeaterWoodTimpaniUp { get; set; }

        [JsonProperty("pictBeaterWoodXylophoneDown")]
        public BoundingBox PictBeaterWoodXylophoneDown { get; set; }

        [JsonProperty("pictBeaterWoodXylophoneLeft")]
        public BoundingBox PictBeaterWoodXylophoneLeft { get; set; }

        [JsonProperty("pictBeaterWoodXylophoneRight")]
        public BoundingBox PictBeaterWoodXylophoneRight { get; set; }

        [JsonProperty("pictBeaterWoodXylophoneUp")]
        public BoundingBox PictBeaterWoodXylophoneUp { get; set; }

        [JsonProperty("pictBell")]
        public BoundingBox PictBell { get; set; }

        [JsonProperty("pictBellOfCymbal")]
        public BoundingBox PictBellOfCymbal { get; set; }

        [JsonProperty("pictBellPlate")]
        public BoundingBox PictBellPlate { get; set; }

        [JsonProperty("pictBellTree")]
        public BoundingBox PictBellTree { get; set; }

        [JsonProperty("pictBirdWhistle")]
        public BoundingBox PictBirdWhistle { get; set; }

        [JsonProperty("pictBoardClapper")]
        public BoundingBox PictBoardClapper { get; set; }

        [JsonProperty("pictBongos")]
        public BoundingBox PictBongos { get; set; }

        [JsonProperty("pictBongosPeinkofer")]
        public BoundingBox PictBongosPeinkofer { get; set; }

        [JsonProperty("pictBrakeDrum")]
        public BoundingBox PictBrakeDrum { get; set; }

        [JsonProperty("pictCabasa")]
        public BoundingBox PictCabasa { get; set; }

        [JsonProperty("pictCannon")]
        public BoundingBox PictCannon { get; set; }

        [JsonProperty("pictCarHorn")]
        public BoundingBox PictCarHorn { get; set; }

        [JsonProperty("pictCastanets")]
        public BoundingBox PictCastanets { get; set; }

        [JsonProperty("pictCastanetsSmithBrindle")]
        public BoundingBox PictCastanetsSmithBrindle { get; set; }

        [JsonProperty("pictCastanetsWithHandle")]
        public BoundingBox PictCastanetsWithHandle { get; set; }

        [JsonProperty("pictCelesta")]
        public BoundingBox PictCelesta { get; set; }

        [JsonProperty("pictCencerro")]
        public BoundingBox PictCencerro { get; set; }

        [JsonProperty("pictCenter1")]
        public BoundingBox PictCenter1 { get; set; }

        [JsonProperty("pictCenter2")]
        public BoundingBox PictCenter2 { get; set; }

        [JsonProperty("pictCenter3")]
        public BoundingBox PictCenter3 { get; set; }

        [JsonProperty("pictChainRattle")]
        public BoundingBox PictChainRattle { get; set; }

        [JsonProperty("pictChimes")]
        public BoundingBox PictChimes { get; set; }

        [JsonProperty("pictChineseCymbal")]
        public BoundingBox PictChineseCymbal { get; set; }

        [JsonProperty("pictChokeCymbal")]
        public BoundingBox PictChokeCymbal { get; set; }

        [JsonProperty("pictClaves")]
        public BoundingBox PictClaves { get; set; }

        [JsonProperty("pictCoins")]
        public BoundingBox PictCoins { get; set; }

        [JsonProperty("pictConga")]
        public BoundingBox PictConga { get; set; }

        [JsonProperty("pictCongaPeinkofer")]
        public BoundingBox PictCongaPeinkofer { get; set; }

        [JsonProperty("pictCowBell")]
        public BoundingBox PictCowBell { get; set; }

        [JsonProperty("pictCowBellBerio")]
        public BoundingBox PictCowBellBerio { get; set; }

        [JsonProperty("pictCrashCymbals")]
        public BoundingBox PictCrashCymbals { get; set; }

        [JsonProperty("pictCrotales")]
        public BoundingBox PictCrotales { get; set; }

        [JsonProperty("pictCrushStem")]
        public BoundingBox PictCrushStem { get; set; }

        [JsonProperty("pictCuica")]
        public BoundingBox PictCuica { get; set; }

        [JsonProperty("pictCymbalTongs")]
        public BoundingBox PictCymbalTongs { get; set; }

        [JsonProperty("pictDamp1")]
        public BoundingBox PictDamp1 { get; set; }

        [JsonProperty("pictDamp2")]
        public BoundingBox PictDamp2 { get; set; }

        [JsonProperty("pictDamp3")]
        public BoundingBox PictDamp3 { get; set; }

        [JsonProperty("pictDamp4")]
        public BoundingBox PictDamp4 { get; set; }

        [JsonProperty("pictDeadNoteStem")]
        public BoundingBox PictDeadNoteStem { get; set; }

        [JsonProperty("pictDrumStick")]
        public BoundingBox PictDrumStick { get; set; }

        [JsonProperty("pictDuckCall")]
        public BoundingBox PictDuckCall { get; set; }

        [JsonProperty("pictEdgeOfCymbal")]
        public BoundingBox PictEdgeOfCymbal { get; set; }

        [JsonProperty("pictEmptyTrap")]
        public BoundingBox PictEmptyTrap { get; set; }

        [JsonProperty("pictFingerCymbals")]
        public BoundingBox PictFingerCymbals { get; set; }

        [JsonProperty("pictFlexatone")]
        public BoundingBox PictFlexatone { get; set; }

        [JsonProperty("pictFlexatonePeinkofer")]
        public BoundingBox PictFlexatonePeinkofer { get; set; }

        [JsonProperty("pictFootballRatchet")]
        public BoundingBox PictFootballRatchet { get; set; }

        [JsonProperty("pictGlassHarmonica")]
        public BoundingBox PictGlassHarmonica { get; set; }

        [JsonProperty("pictGlassHarp")]
        public BoundingBox PictGlassHarp { get; set; }

        [JsonProperty("pictGlassPlateChimes")]
        public BoundingBox PictGlassPlateChimes { get; set; }

        [JsonProperty("pictGlassTubeChimes")]
        public BoundingBox PictGlassTubeChimes { get; set; }

        [JsonProperty("pictGlsp")]
        public BoundingBox PictGlsp { get; set; }

        [JsonProperty("pictGlspPeinkofer")]
        public BoundingBox PictGlspPeinkofer { get; set; }

        [JsonProperty("pictGlspSmithBrindle")]
        public BoundingBox PictGlspSmithBrindle { get; set; }

        [JsonProperty("pictGobletDrum")]
        public BoundingBox PictGobletDrum { get; set; }

        [JsonProperty("pictGong")]
        public BoundingBox PictGong { get; set; }

        [JsonProperty("pictGongWithButton")]
        public BoundingBox PictGongWithButton { get; set; }

        [JsonProperty("pictGuiro")]
        public BoundingBox PictGuiro { get; set; }

        [JsonProperty("pictGuiroPeinkofer")]
        public BoundingBox PictGuiroPeinkofer { get; set; }

        [JsonProperty("pictGuiroSevsay")]
        public BoundingBox PictGuiroSevsay { get; set; }

        [JsonProperty("pictGumHardDown")]
        public BoundingBox PictGumHardDown { get; set; }

        [JsonProperty("pictGumHardLeft")]
        public BoundingBox PictGumHardLeft { get; set; }

        [JsonProperty("pictGumHardRight")]
        public BoundingBox PictGumHardRight { get; set; }

        [JsonProperty("pictGumHardUp")]
        public BoundingBox PictGumHardUp { get; set; }

        [JsonProperty("pictGumMediumDown")]
        public BoundingBox PictGumMediumDown { get; set; }

        [JsonProperty("pictGumMediumLeft")]
        public BoundingBox PictGumMediumLeft { get; set; }

        [JsonProperty("pictGumMediumRight")]
        public BoundingBox PictGumMediumRight { get; set; }

        [JsonProperty("pictGumMediumUp")]
        public BoundingBox PictGumMediumUp { get; set; }

        [JsonProperty("pictGumSoftDown")]
        public BoundingBox PictGumSoftDown { get; set; }

        [JsonProperty("pictGumSoftLeft")]
        public BoundingBox PictGumSoftLeft { get; set; }

        [JsonProperty("pictGumSoftRight")]
        public BoundingBox PictGumSoftRight { get; set; }

        [JsonProperty("pictGumSoftUp")]
        public BoundingBox PictGumSoftUp { get; set; }

        [JsonProperty("pictHalfOpen1")]
        public BoundingBox PictHalfOpen1 { get; set; }

        [JsonProperty("pictHalfOpen2")]
        public BoundingBox PictHalfOpen2 { get; set; }

        [JsonProperty("pictHandbell")]
        public BoundingBox PictHandbell { get; set; }

        [JsonProperty("pictHiHat")]
        public BoundingBox PictHiHat { get; set; }

        [JsonProperty("pictHiHatOnStand")]
        public BoundingBox PictHiHatOnStand { get; set; }

        [JsonProperty("pictJawHarp")]
        public Dictionary<string, long[]> PictJawHarp { get; set; }

        [JsonProperty("pictJingleBells")]
        public BoundingBox PictJingleBells { get; set; }

        [JsonProperty("pictKlaxonHorn")]
        public BoundingBox PictKlaxonHorn { get; set; }

        [JsonProperty("pictLeftHandCircle")]
        public BoundingBox PictLeftHandCircle { get; set; }

        [JsonProperty("pictLionsRoar")]
        public BoundingBox PictLionsRoar { get; set; }

        [JsonProperty("pictLithophone")]
        public BoundingBox PictLithophone { get; set; }

        [JsonProperty("pictLithophonePeinkofer")]
        public BoundingBox PictLithophonePeinkofer { get; set; }

        [JsonProperty("pictLogDrum")]
        public BoundingBox PictLogDrum { get; set; }

        [JsonProperty("pictLotusFlute")]
        public BoundingBox PictLotusFlute { get; set; }

        [JsonProperty("pictLotusFlutePeinkofer")]
        public BoundingBox PictLotusFlutePeinkofer { get; set; }

        [JsonProperty("pictMar")]
        public BoundingBox PictMar { get; set; }

        [JsonProperty("pictMarPeinkofer")]
        public BoundingBox PictMarPeinkofer { get; set; }

        [JsonProperty("pictMarSmithBrindle")]
        public BoundingBox PictMarSmithBrindle { get; set; }

        [JsonProperty("pictMaraca")]
        public BoundingBox PictMaraca { get; set; }

        [JsonProperty("pictMaracaSmithBrindle")]
        public BoundingBox PictMaracaSmithBrindle { get; set; }

        [JsonProperty("pictMaracas")]
        public BoundingBox PictMaracas { get; set; }

        [JsonProperty("pictMegaphone")]
        public BoundingBox PictMegaphone { get; set; }

        [JsonProperty("pictMetalPlateChimes")]
        public BoundingBox PictMetalPlateChimes { get; set; }

        [JsonProperty("pictMetalTubeChimes")]
        public BoundingBox PictMetalTubeChimes { get; set; }

        [JsonProperty("pictMusicalSaw")]
        public BoundingBox PictMusicalSaw { get; set; }

        [JsonProperty("pictMusicalSawPeinkofer")]
        public BoundingBox PictMusicalSawPeinkofer { get; set; }

        [JsonProperty("pictNormalPosition")]
        public BoundingBox PictNormalPosition { get; set; }

        [JsonProperty("pictOnRim")]
        public BoundingBox PictOnRim { get; set; }

        [JsonProperty("pictOpen")]
        public BoundingBox PictOpen { get; set; }

        [JsonProperty("pictOpenRimShot")]
        public BoundingBox PictOpenRimShot { get; set; }

        [JsonProperty("pictPistolShot")]
        public BoundingBox PictPistolShot { get; set; }

        [JsonProperty("pictPoliceWhistle")]
        public BoundingBox PictPoliceWhistle { get; set; }

        [JsonProperty("pictQuijada")]
        public BoundingBox PictQuijada { get; set; }

        [JsonProperty("pictRainstick")]
        public BoundingBox PictRainstick { get; set; }

        [JsonProperty("pictRatchet")]
        public BoundingBox PictRatchet { get; set; }

        [JsonProperty("pictRecoReco")]
        public BoundingBox PictRecoReco { get; set; }

        [JsonProperty("pictRightHandSquare")]
        public BoundingBox PictRightHandSquare { get; set; }

        [JsonProperty("pictRim1")]
        public BoundingBox PictRim1 { get; set; }

        [JsonProperty("pictRim2")]
        public BoundingBox PictRim2 { get; set; }

        [JsonProperty("pictRim3")]
        public BoundingBox PictRim3 { get; set; }

        [JsonProperty("pictRimShotOnStem")]
        public BoundingBox PictRimShotOnStem { get; set; }

        [JsonProperty("pictSandpaperBlocks")]
        public BoundingBox PictSandpaperBlocks { get; set; }

        [JsonProperty("pictScrapeAroundRim")]
        public BoundingBox PictScrapeAroundRim { get; set; }

        [JsonProperty("pictScrapeAroundRimClockwise")]
        public BoundingBox PictScrapeAroundRimClockwise { get; set; }

        [JsonProperty("pictScrapeCenterToEdge")]
        public BoundingBox PictScrapeCenterToEdge { get; set; }

        [JsonProperty("pictScrapeEdgeToCenter")]
        public BoundingBox PictScrapeEdgeToCenter { get; set; }

        [JsonProperty("pictShellBells")]
        public Dictionary<string, long[]> PictShellBells { get; set; }

        [JsonProperty("pictShellChimes")]
        public BoundingBox PictShellChimes { get; set; }

        [JsonProperty("pictSiren")]
        public BoundingBox PictSiren { get; set; }

        [JsonProperty("pictSistrum")]
        public BoundingBox PictSistrum { get; set; }

        [JsonProperty("pictSizzleCymbal")]
        public BoundingBox PictSizzleCymbal { get; set; }

        [JsonProperty("pictSleighBell")]
        public BoundingBox PictSleighBell { get; set; }

        [JsonProperty("pictSleighBellSmithBrindle")]
        public BoundingBox PictSleighBellSmithBrindle { get; set; }

        [JsonProperty("pictSlideBrushOnGong")]
        public BoundingBox PictSlideBrushOnGong { get; set; }

        [JsonProperty("pictSlideWhistle")]
        public BoundingBox PictSlideWhistle { get; set; }

        [JsonProperty("pictSlitDrum")]
        public BoundingBox PictSlitDrum { get; set; }

        [JsonProperty("pictSnareDrum")]
        public BoundingBox PictSnareDrum { get; set; }

        [JsonProperty("pictSnareDrumMilitary")]
        public BoundingBox PictSnareDrumMilitary { get; set; }

        [JsonProperty("pictSnareDrumSnaresOff")]
        public BoundingBox PictSnareDrumSnaresOff { get; set; }

        [JsonProperty("pictSteelDrums")]
        public BoundingBox PictSteelDrums { get; set; }

        [JsonProperty("pictStickShot")]
        public BoundingBox PictStickShot { get; set; }

        [JsonProperty("pictSuperball")]
        public BoundingBox PictSuperball { get; set; }

        [JsonProperty("pictSuspendedCymbal")]
        public BoundingBox PictSuspendedCymbal { get; set; }

        [JsonProperty("pictSwishStem")]
        public BoundingBox PictSwishStem { get; set; }

        [JsonProperty("pictTabla")]
        public BoundingBox PictTabla { get; set; }

        [JsonProperty("pictTamTam")]
        public BoundingBox PictTamTam { get; set; }

        [JsonProperty("pictTamTamWithBeater")]
        public BoundingBox PictTamTamWithBeater { get; set; }

        [JsonProperty("pictTambourine")]
        public BoundingBox PictTambourine { get; set; }

        [JsonProperty("pictTambourineStockhausen")]
        public BoundingBox PictTambourineStockhausen { get; set; }

        [JsonProperty("pictTempleBlocks")]
        public BoundingBox PictTempleBlocks { get; set; }

        [JsonProperty("pictTenorDrum")]
        public BoundingBox PictTenorDrum { get; set; }

        [JsonProperty("pictThundersheet")]
        public BoundingBox PictThundersheet { get; set; }

        [JsonProperty("pictTimbales")]
        public BoundingBox PictTimbales { get; set; }

        [JsonProperty("pictTimbalesPeinkofer")]
        public BoundingBox PictTimbalesPeinkofer { get; set; }

        [JsonProperty("pictTimpani")]
        public BoundingBox PictTimpani { get; set; }

        [JsonProperty("pictTimpaniPeinkofer")]
        public BoundingBox PictTimpaniPeinkofer { get; set; }

        [JsonProperty("pictTomTom")]
        public BoundingBox PictTomTom { get; set; }

        [JsonProperty("pictTomTomChinese")]
        public BoundingBox PictTomTomChinese { get; set; }

        [JsonProperty("pictTomTomChinesePeinkofer")]
        public BoundingBox PictTomTomChinesePeinkofer { get; set; }

        [JsonProperty("pictTomTomIndoAmerican")]
        public BoundingBox PictTomTomIndoAmerican { get; set; }

        [JsonProperty("pictTomTomJapanese")]
        public BoundingBox PictTomTomJapanese { get; set; }

        [JsonProperty("pictTomTomPeinkofer")]
        public BoundingBox PictTomTomPeinkofer { get; set; }

        [JsonProperty("pictTriangle")]
        public BoundingBox PictTriangle { get; set; }

        [JsonProperty("pictTubaphone")]
        public BoundingBox PictTubaphone { get; set; }

        [JsonProperty("pictTubaphonePeinkofer")]
        public BoundingBox PictTubaphonePeinkofer { get; set; }

        [JsonProperty("pictTubularBells")]
        public BoundingBox PictTubularBells { get; set; }

        [JsonProperty("pictTurnLeftStem")]
        public BoundingBox PictTurnLeftStem { get; set; }

        [JsonProperty("pictTurnRightLeftStem")]
        public BoundingBox PictTurnRightLeftStem { get; set; }

        [JsonProperty("pictTurnRightStem")]
        public BoundingBox PictTurnRightStem { get; set; }

        [JsonProperty("pictVib")]
        public BoundingBox PictVib { get; set; }

        [JsonProperty("pictVibMotorOff")]
        public BoundingBox PictVibMotorOff { get; set; }

        [JsonProperty("pictVibMotorOffPeinkofer")]
        public BoundingBox PictVibMotorOffPeinkofer { get; set; }

        [JsonProperty("pictVibPeinkofer")]
        public BoundingBox PictVibPeinkofer { get; set; }

        [JsonProperty("pictVibSmithBrindle")]
        public BoundingBox PictVibSmithBrindle { get; set; }

        [JsonProperty("pictVibraslap")]
        public BoundingBox PictVibraslap { get; set; }

        [JsonProperty("pictVietnameseHat")]
        public BoundingBox PictVietnameseHat { get; set; }

        [JsonProperty("pictWhip")]
        public BoundingBox PictWhip { get; set; }

        [JsonProperty("pictWindChimesGlass")]
        public BoundingBox PictWindChimesGlass { get; set; }

        [JsonProperty("pictWindMachine")]
        public BoundingBox PictWindMachine { get; set; }

        [JsonProperty("pictWindWhistle")]
        public BoundingBox PictWindWhistle { get; set; }

        [JsonProperty("pictWoodBlock")]
        public BoundingBox PictWoodBlock { get; set; }

        [JsonProperty("pictWoundHardDown")]
        public BoundingBox PictWoundHardDown { get; set; }

        [JsonProperty("pictWoundHardLeft")]
        public BoundingBox PictWoundHardLeft { get; set; }

        [JsonProperty("pictWoundHardRight")]
        public BoundingBox PictWoundHardRight { get; set; }

        [JsonProperty("pictWoundHardUp")]
        public BoundingBox PictWoundHardUp { get; set; }

        [JsonProperty("pictWoundSoftDown")]
        public BoundingBox PictWoundSoftDown { get; set; }

        [JsonProperty("pictWoundSoftLeft")]
        public BoundingBox PictWoundSoftLeft { get; set; }

        [JsonProperty("pictWoundSoftRight")]
        public BoundingBox PictWoundSoftRight { get; set; }

        [JsonProperty("pictWoundSoftUp")]
        public BoundingBox PictWoundSoftUp { get; set; }

        [JsonProperty("pictXyl")]
        public BoundingBox PictXyl { get; set; }

        [JsonProperty("pictXylBass")]
        public BoundingBox PictXylBass { get; set; }

        [JsonProperty("pictXylBassPeinkofer")]
        public BoundingBox PictXylBassPeinkofer { get; set; }

        [JsonProperty("pictXylPeinkofer")]
        public BoundingBox PictXylPeinkofer { get; set; }

        [JsonProperty("pictXylSmithBrindle")]
        public BoundingBox PictXylSmithBrindle { get; set; }

        [JsonProperty("pictXylTenor")]
        public BoundingBox PictXylTenor { get; set; }

        [JsonProperty("pictXylTenorPeinkofer")]
        public BoundingBox PictXylTenorPeinkofer { get; set; }

        [JsonProperty("pictXylTenorTrough")]
        public BoundingBox PictXylTenorTrough { get; set; }

        [JsonProperty("pictXylTrough")]
        public BoundingBox PictXylTrough { get; set; }

        [JsonProperty("pluckedBuzzPizzicato")]
        public BoundingBox PluckedBuzzPizzicato { get; set; }

        [JsonProperty("pluckedDamp")]
        public BoundingBox PluckedDamp { get; set; }

        [JsonProperty("pluckedDampAll")]
        public BoundingBox PluckedDampAll { get; set; }

        [JsonProperty("pluckedDampOnStem")]
        public BoundingBox PluckedDampOnStem { get; set; }

        [JsonProperty("pluckedFingernailFlick")]
        public BoundingBox PluckedFingernailFlick { get; set; }

        [JsonProperty("pluckedLeftHandPizzicato")]
        public BoundingBox PluckedLeftHandPizzicato { get; set; }

        [JsonProperty("pluckedPlectrum")]
        public BoundingBox PluckedPlectrum { get; set; }

        [JsonProperty("pluckedSnapPizzicatoAbove")]
        public BoundingBox PluckedSnapPizzicatoAbove { get; set; }

        [JsonProperty("pluckedSnapPizzicatoAboveGerman")]
        public BoundingBox PluckedSnapPizzicatoAboveGerman { get; set; }

        [JsonProperty("pluckedSnapPizzicatoBelow")]
        public BoundingBox PluckedSnapPizzicatoBelow { get; set; }

        [JsonProperty("pluckedSnapPizzicatoBelowGerman")]
        public BoundingBox PluckedSnapPizzicatoBelowGerman { get; set; }

        [JsonProperty("pluckedWithFingernails")]
        public BoundingBox PluckedWithFingernails { get; set; }

        [JsonProperty("quindicesima")]
        public BoundingBox Quindicesima { get; set; }

        [JsonProperty("quindicesimaAlta")]
        public BoundingBox QuindicesimaAlta { get; set; }

        [JsonProperty("quindicesimaBassa")]
        public BoundingBox QuindicesimaBassa { get; set; }

        [JsonProperty("quindicesimaBassaMb")]
        public BoundingBox QuindicesimaBassaMb { get; set; }

        [JsonProperty("repeat1Bar")]
        public BoundingBox Repeat1Bar { get; set; }

        [JsonProperty("repeat2Bars")]
        public BoundingBox Repeat2Bars { get; set; }

        [JsonProperty("repeat4Bars")]
        public BoundingBox Repeat4Bars { get; set; }

        [JsonProperty("repeatDot")]
        public BoundingBox RepeatDot { get; set; }

        [JsonProperty("repeatDots")]
        public BoundingBox RepeatDots { get; set; }

        [JsonProperty("repeatLeft")]
        public BoundingBox RepeatLeft { get; set; }

        [JsonProperty("repeatRight")]
        public BoundingBox RepeatRight { get; set; }

        [JsonProperty("repeatRightLeft")]
        public BoundingBox RepeatRightLeft { get; set; }

        [JsonProperty("repeatRightLeftThick")]
        public BoundingBox RepeatRightLeftThick { get; set; }

        [JsonProperty("rest1024th")]
        public BoundingBox Rest1024Th { get; set; }

        [JsonProperty("rest128th")]
        public BoundingBox Rest128Th { get; set; }

        [JsonProperty("rest16th")]
        public BoundingBox Rest16Th { get; set; }

        [JsonProperty("rest256th")]
        public BoundingBox Rest256Th { get; set; }

        [JsonProperty("rest32nd")]
        public BoundingBox Rest32Nd { get; set; }

        [JsonProperty("rest512th")]
        public BoundingBox Rest512Th { get; set; }

        [JsonProperty("rest64th")]
        public BoundingBox Rest64Th { get; set; }

        [JsonProperty("rest8th")]
        public BoundingBox Rest8Th { get; set; }

        [JsonProperty("restDoubleWhole")]
        public BoundingBox RestDoubleWhole { get; set; }

        [JsonProperty("restDoubleWholeLegerLine")]
        public BoundingBox RestDoubleWholeLegerLine { get; set; }

        [JsonProperty("restHBar")]
        public BoundingBox RestHBar { get; set; }

        [JsonProperty("restHBarLeft")]
        public BoundingBox RestHBarLeft { get; set; }

        [JsonProperty("restHBarMiddle")]
        public BoundingBox RestHBarMiddle { get; set; }

        [JsonProperty("restHBarRight")]
        public BoundingBox RestHBarRight { get; set; }

        [JsonProperty("restHalf")]
        public BoundingBox RestHalf { get; set; }

        [JsonProperty("restHalfLegerLine")]
        public BoundingBox RestHalfLegerLine { get; set; }

        [JsonProperty("restLonga")]
        public BoundingBox RestLonga { get; set; }

        [JsonProperty("restMaxima")]
        public BoundingBox RestMaxima { get; set; }

        [JsonProperty("restQuarter")]
        public BoundingBox RestQuarter { get; set; }

        [JsonProperty("restQuarterOld")]
        public BoundingBox RestQuarterOld { get; set; }

        [JsonProperty("restQuarterZ")]
        public BoundingBox RestQuarterZ { get; set; }

        [JsonProperty("restWhole")]
        public BoundingBox RestWhole { get; set; }

        [JsonProperty("restWholeLegerLine")]
        public BoundingBox RestWholeLegerLine { get; set; }

        [JsonProperty("reversedBrace")]
        public BoundingBox ReversedBrace { get; set; }

        [JsonProperty("reversedBracketBottom")]
        public BoundingBox ReversedBracketBottom { get; set; }

        [JsonProperty("reversedBracketTop")]
        public BoundingBox ReversedBracketTop { get; set; }

        [JsonProperty("rightRepeatSmall")]
        public BoundingBox RightRepeatSmall { get; set; }

        [JsonProperty("schaefferClef")]
        public BoundingBox SchaefferClef { get; set; }

        [JsonProperty("schaefferFClefToGClef")]
        public BoundingBox SchaefferFClefToGClef { get; set; }

        [JsonProperty("schaefferGClefToFClef")]
        public BoundingBox SchaefferGClefToFClef { get; set; }

        [JsonProperty("schaefferPreviousClef")]
        public BoundingBox SchaefferPreviousClef { get; set; }

        [JsonProperty("sedicesima")]
        public BoundingBox Sedicesima { get; set; }

        [JsonProperty("sedicesimaAlta")]
        public BoundingBox SedicesimaAlta { get; set; }

        [JsonProperty("sedicesimaBassa")]
        public BoundingBox SedicesimaBassa { get; set; }

        [JsonProperty("sedicesimaBassaMb")]
        public BoundingBox SedicesimaBassaMb { get; set; }

        [JsonProperty("segno")]
        public BoundingBox Segno { get; set; }

        [JsonProperty("segnoJapanese")]
        public BoundingBox SegnoJapanese { get; set; }

        [JsonProperty("segnoSerpent1")]
        public BoundingBox SegnoSerpent1 { get; set; }

        [JsonProperty("segnoSerpent2")]
        public BoundingBox SegnoSerpent2 { get; set; }

        [JsonProperty("semipitchedPercussionClef1")]
        public BoundingBox SemipitchedPercussionClef1 { get; set; }

        [JsonProperty("semipitchedPercussionClef2")]
        public BoundingBox SemipitchedPercussionClef2 { get; set; }

        [JsonProperty("smnFlat")]
        public BoundingBox SmnFlat { get; set; }

        [JsonProperty("smnFlatWhite")]
        public BoundingBox SmnFlatWhite { get; set; }

        [JsonProperty("smnHistoryDoubleFlat")]
        public BoundingBox SmnHistoryDoubleFlat { get; set; }

        [JsonProperty("smnHistoryDoubleSharp")]
        public BoundingBox SmnHistoryDoubleSharp { get; set; }

        [JsonProperty("smnHistoryFlat")]
        public BoundingBox SmnHistoryFlat { get; set; }

        [JsonProperty("smnHistorySharp")]
        public BoundingBox SmnHistorySharp { get; set; }

        [JsonProperty("smnNatural")]
        public BoundingBox SmnNatural { get; set; }

        [JsonProperty("smnSharp")]
        public BoundingBox SmnSharp { get; set; }

        [JsonProperty("smnSharpDown")]
        public BoundingBox SmnSharpDown { get; set; }

        [JsonProperty("smnSharpWhite")]
        public BoundingBox SmnSharpWhite { get; set; }

        [JsonProperty("smnSharpWhiteDown")]
        public BoundingBox SmnSharpWhiteDown { get; set; }

        [JsonProperty("splitBarDivider")]
        public BoundingBox SplitBarDivider { get; set; }

        [JsonProperty("staff1Line")]
        public BoundingBox Staff1Line { get; set; }

        [JsonProperty("staff1LineNarrow")]
        public BoundingBox Staff1LineNarrow { get; set; }

        [JsonProperty("staff1LineWide")]
        public BoundingBox Staff1LineWide { get; set; }

        [JsonProperty("staff2Lines")]
        public BoundingBox Staff2Lines { get; set; }

        [JsonProperty("staff2LinesNarrow")]
        public BoundingBox Staff2LinesNarrow { get; set; }

        [JsonProperty("staff2LinesWide")]
        public BoundingBox Staff2LinesWide { get; set; }

        [JsonProperty("staff3Lines")]
        public BoundingBox Staff3Lines { get; set; }

        [JsonProperty("staff3LinesNarrow")]
        public BoundingBox Staff3LinesNarrow { get; set; }

        [JsonProperty("staff3LinesWide")]
        public BoundingBox Staff3LinesWide { get; set; }

        [JsonProperty("staff4Lines")]
        public BoundingBox Staff4Lines { get; set; }

        [JsonProperty("staff4LinesNarrow")]
        public BoundingBox Staff4LinesNarrow { get; set; }

        [JsonProperty("staff4LinesWide")]
        public BoundingBox Staff4LinesWide { get; set; }

        [JsonProperty("staff5Lines")]
        public BoundingBox Staff5Lines { get; set; }

        [JsonProperty("staff5LinesNarrow")]
        public BoundingBox Staff5LinesNarrow { get; set; }

        [JsonProperty("staff5LinesWide")]
        public BoundingBox Staff5LinesWide { get; set; }

        [JsonProperty("staff6Lines")]
        public BoundingBox Staff6Lines { get; set; }

        [JsonProperty("staff6LinesNarrow")]
        public BoundingBox Staff6LinesNarrow { get; set; }

        [JsonProperty("staff6LinesWide")]
        public BoundingBox Staff6LinesWide { get; set; }

        [JsonProperty("staffDivideArrowDown")]
        public BoundingBox StaffDivideArrowDown { get; set; }

        [JsonProperty("staffDivideArrowUp")]
        public BoundingBox StaffDivideArrowUp { get; set; }

        [JsonProperty("staffDivideArrowUpDown")]
        public BoundingBox StaffDivideArrowUpDown { get; set; }

        [JsonProperty("stem")]
        public BoundingBox Stem { get; set; }

        [JsonProperty("stemBowOnBridge")]
        public BoundingBox StemBowOnBridge { get; set; }

        [JsonProperty("stemBowOnTailpiece")]
        public BoundingBox StemBowOnTailpiece { get; set; }

        [JsonProperty("stemBuzzRoll")]
        public BoundingBox StemBuzzRoll { get; set; }

        [JsonProperty("stemDamp")]
        public BoundingBox StemDamp { get; set; }

        [JsonProperty("stemHarpStringNoise")]
        public BoundingBox StemHarpStringNoise { get; set; }

        [JsonProperty("stemMultiphonicsBlack")]
        public BoundingBox StemMultiphonicsBlack { get; set; }

        [JsonProperty("stemMultiphonicsBlackWhite")]
        public BoundingBox StemMultiphonicsBlackWhite { get; set; }

        [JsonProperty("stemMultiphonicsWhite")]
        public BoundingBox StemMultiphonicsWhite { get; set; }

        [JsonProperty("stemPendereckiTremolo")]
        public BoundingBox StemPendereckiTremolo { get; set; }

        [JsonProperty("stemRimShot")]
        public BoundingBox StemRimShot { get; set; }

        [JsonProperty("stemSprechgesang")]
        public BoundingBox StemSprechgesang { get; set; }

        [JsonProperty("stemSulPonticello")]
        public BoundingBox StemSulPonticello { get; set; }

        [JsonProperty("stemSussurando")]
        public BoundingBox StemSussurando { get; set; }

        [JsonProperty("stemSwished")]
        public BoundingBox StemSwished { get; set; }

        [JsonProperty("stemVibratoPulse")]
        public BoundingBox StemVibratoPulse { get; set; }

        [JsonProperty("stockhausenTremolo")]
        public BoundingBox StockhausenTremolo { get; set; }

        [JsonProperty("stringsBowBehindBridge")]
        public BoundingBox StringsBowBehindBridge { get; set; }

        [JsonProperty("stringsBowBehindBridgeFourStrings")]
        public BoundingBox StringsBowBehindBridgeFourStrings { get; set; }

        [JsonProperty("stringsBowBehindBridgeOneString")]
        public BoundingBox StringsBowBehindBridgeOneString { get; set; }

        [JsonProperty("stringsBowBehindBridgeThreeStrings")]
        public BoundingBox StringsBowBehindBridgeThreeStrings { get; set; }

        [JsonProperty("stringsBowBehindBridgeTwoStrings")]
        public BoundingBox StringsBowBehindBridgeTwoStrings { get; set; }

        [JsonProperty("stringsBowOnBridge")]
        public BoundingBox StringsBowOnBridge { get; set; }

        [JsonProperty("stringsBowOnTailpiece")]
        public BoundingBox StringsBowOnTailpiece { get; set; }

        [JsonProperty("stringsChangeBowDirection")]
        public BoundingBox StringsChangeBowDirection { get; set; }

        [JsonProperty("stringsChangeBowDirectionImposed")]
        public BoundingBox StringsChangeBowDirectionImposed { get; set; }

        [JsonProperty("stringsChangeBowDirectionLiga")]
        public BoundingBox StringsChangeBowDirectionLiga { get; set; }

        [JsonProperty("stringsDownBow")]
        public BoundingBox StringsDownBow { get; set; }

        [JsonProperty("stringsDownBowTurned")]
        public BoundingBox StringsDownBowTurned { get; set; }

        [JsonProperty("stringsFouette")]
        public BoundingBox StringsFouette { get; set; }

        [JsonProperty("stringsHalfHarmonic")]
        public BoundingBox StringsHalfHarmonic { get; set; }

        [JsonProperty("stringsHarmonic")]
        public BoundingBox StringsHarmonic { get; set; }

        [JsonProperty("stringsJeteAbove")]
        public BoundingBox StringsJeteAbove { get; set; }

        [JsonProperty("stringsJeteBelow")]
        public BoundingBox StringsJeteBelow { get; set; }

        [JsonProperty("stringsMuteOff")]
        public BoundingBox StringsMuteOff { get; set; }

        [JsonProperty("stringsMuteOn")]
        public BoundingBox StringsMuteOn { get; set; }

        [JsonProperty("stringsOverpressureDownBow")]
        public BoundingBox StringsOverpressureDownBow { get; set; }

        [JsonProperty("stringsOverpressureNoDirection")]
        public BoundingBox StringsOverpressureNoDirection { get; set; }

        [JsonProperty("stringsOverpressurePossibileDownBow")]
        public BoundingBox StringsOverpressurePossibileDownBow { get; set; }

        [JsonProperty("stringsOverpressurePossibileUpBow")]
        public BoundingBox StringsOverpressurePossibileUpBow { get; set; }

        [JsonProperty("stringsOverpressureUpBow")]
        public BoundingBox StringsOverpressureUpBow { get; set; }

        [JsonProperty("stringsThumbPosition")]
        public BoundingBox StringsThumbPosition { get; set; }

        [JsonProperty("stringsThumbPositionTurned")]
        public BoundingBox StringsThumbPositionTurned { get; set; }

        [JsonProperty("stringsUpBow")]
        public BoundingBox StringsUpBow { get; set; }

        [JsonProperty("stringsUpBowTurned")]
        public BoundingBox StringsUpBowTurned { get; set; }

        [JsonProperty("stringsVibratoPulse")]
        public BoundingBox StringsVibratoPulse { get; set; }

        [JsonProperty("systemDivider")]
        public BoundingBox SystemDivider { get; set; }

        [JsonProperty("systemDividerExtraLong")]
        public BoundingBox SystemDividerExtraLong { get; set; }

        [JsonProperty("systemDividerLong")]
        public BoundingBox SystemDividerLong { get; set; }

        [JsonProperty("textAugmentationDot")]
        public BoundingBox TextAugmentationDot { get; set; }

        [JsonProperty("textBlackNoteFrac16thLongStem")]
        public BoundingBox TextBlackNoteFrac16ThLongStem { get; set; }

        [JsonProperty("textBlackNoteFrac16thShortStem")]
        public BoundingBox TextBlackNoteFrac16ThShortStem { get; set; }

        [JsonProperty("textBlackNoteFrac32ndLongStem")]
        public BoundingBox TextBlackNoteFrac32NdLongStem { get; set; }

        [JsonProperty("textBlackNoteFrac8thLongStem")]
        public BoundingBox TextBlackNoteFrac8ThLongStem { get; set; }

        [JsonProperty("textBlackNoteFrac8thShortStem")]
        public BoundingBox TextBlackNoteFrac8ThShortStem { get; set; }

        [JsonProperty("textBlackNoteLongStem")]
        public BoundingBox TextBlackNoteLongStem { get; set; }

        [JsonProperty("textBlackNoteShortStem")]
        public BoundingBox TextBlackNoteShortStem { get; set; }

        [JsonProperty("textCont16thBeamLongStem")]
        public BoundingBox TextCont16ThBeamLongStem { get; set; }

        [JsonProperty("textCont16thBeamShortStem")]
        public BoundingBox TextCont16ThBeamShortStem { get; set; }

        [JsonProperty("textCont32ndBeamLongStem")]
        public BoundingBox TextCont32NdBeamLongStem { get; set; }

        [JsonProperty("textCont8thBeamLongStem")]
        public BoundingBox TextCont8ThBeamLongStem { get; set; }

        [JsonProperty("textCont8thBeamShortStem")]
        public BoundingBox TextCont8ThBeamShortStem { get; set; }

        [JsonProperty("textTie")]
        public BoundingBox TextTie { get; set; }

        [JsonProperty("textTuplet3LongStem")]
        public BoundingBox TextTuplet3LongStem { get; set; }

        [JsonProperty("textTuplet3ShortStem")]
        public BoundingBox TextTuplet3ShortStem { get; set; }

        [JsonProperty("textTupletBracketEndLongStem")]
        public BoundingBox TextTupletBracketEndLongStem { get; set; }

        [JsonProperty("textTupletBracketEndShortStem")]
        public BoundingBox TextTupletBracketEndShortStem { get; set; }

        [JsonProperty("textTupletBracketStartLongStem")]
        public BoundingBox TextTupletBracketStartLongStem { get; set; }

        [JsonProperty("textTupletBracketStartShortStem")]
        public BoundingBox TextTupletBracketStartShortStem { get; set; }

        [JsonProperty("timeSig0")]
        public BoundingBox TimeSig0 { get; set; }

        [JsonProperty("timeSig0Denominator")]
        public BoundingBox TimeSig0Denominator { get; set; }

        [JsonProperty("timeSig0Large")]
        public BoundingBox TimeSig0Large { get; set; }

        [JsonProperty("timeSig0Numerator")]
        public BoundingBox TimeSig0Numerator { get; set; }

        [JsonProperty("timeSig0Reversed")]
        public BoundingBox TimeSig0Reversed { get; set; }

        [JsonProperty("timeSig0Small")]
        public BoundingBox TimeSig0Small { get; set; }

        [JsonProperty("timeSig0Turned")]
        public BoundingBox TimeSig0Turned { get; set; }

        [JsonProperty("timeSig1")]
        public BoundingBox TimeSig1 { get; set; }

        [JsonProperty("timeSig12over8")]
        public BoundingBox TimeSig12Over8 { get; set; }

        [JsonProperty("timeSig1Denominator")]
        public BoundingBox TimeSig1Denominator { get; set; }

        [JsonProperty("timeSig1Large")]
        public BoundingBox TimeSig1Large { get; set; }

        [JsonProperty("timeSig1Numerator")]
        public BoundingBox TimeSig1Numerator { get; set; }

        [JsonProperty("timeSig1Reversed")]
        public BoundingBox TimeSig1Reversed { get; set; }

        [JsonProperty("timeSig1Small")]
        public BoundingBox TimeSig1Small { get; set; }

        [JsonProperty("timeSig1Turned")]
        public BoundingBox TimeSig1Turned { get; set; }

        [JsonProperty("timeSig2")]
        public BoundingBox TimeSig2 { get; set; }

        [JsonProperty("timeSig2Denominator")]
        public BoundingBox TimeSig2Denominator { get; set; }

        [JsonProperty("timeSig2Large")]
        public BoundingBox TimeSig2Large { get; set; }

        [JsonProperty("timeSig2Numerator")]
        public BoundingBox TimeSig2Numerator { get; set; }

        [JsonProperty("timeSig2Reversed")]
        public BoundingBox TimeSig2Reversed { get; set; }

        [JsonProperty("timeSig2Small")]
        public BoundingBox TimeSig2Small { get; set; }

        [JsonProperty("timeSig2Turned")]
        public BoundingBox TimeSig2Turned { get; set; }

        [JsonProperty("timeSig2over2")]
        public BoundingBox TimeSig2Over2 { get; set; }

        [JsonProperty("timeSig2over4")]
        public BoundingBox TimeSig2Over4 { get; set; }

        [JsonProperty("timeSig3")]
        public BoundingBox TimeSig3 { get; set; }

        [JsonProperty("timeSig3Denominator")]
        public BoundingBox TimeSig3Denominator { get; set; }

        [JsonProperty("timeSig3Large")]
        public BoundingBox TimeSig3Large { get; set; }

        [JsonProperty("timeSig3Numerator")]
        public BoundingBox TimeSig3Numerator { get; set; }

        [JsonProperty("timeSig3Reversed")]
        public BoundingBox TimeSig3Reversed { get; set; }

        [JsonProperty("timeSig3Small")]
        public BoundingBox TimeSig3Small { get; set; }

        [JsonProperty("timeSig3Turned")]
        public BoundingBox TimeSig3Turned { get; set; }

        [JsonProperty("timeSig3over2")]
        public BoundingBox TimeSig3Over2 { get; set; }

        [JsonProperty("timeSig3over4")]
        public BoundingBox TimeSig3Over4 { get; set; }

        [JsonProperty("timeSig3over8")]
        public BoundingBox TimeSig3Over8 { get; set; }

        [JsonProperty("timeSig4")]
        public BoundingBox TimeSig4 { get; set; }

        [JsonProperty("timeSig4Denominator")]
        public BoundingBox TimeSig4Denominator { get; set; }

        [JsonProperty("timeSig4Large")]
        public BoundingBox TimeSig4Large { get; set; }

        [JsonProperty("timeSig4Numerator")]
        public BoundingBox TimeSig4Numerator { get; set; }

        [JsonProperty("timeSig4Reversed")]
        public BoundingBox TimeSig4Reversed { get; set; }

        [JsonProperty("timeSig4Small")]
        public BoundingBox TimeSig4Small { get; set; }

        [JsonProperty("timeSig4Turned")]
        public BoundingBox TimeSig4Turned { get; set; }

        [JsonProperty("timeSig4over4")]
        public BoundingBox TimeSig4Over4 { get; set; }

        [JsonProperty("timeSig5")]
        public BoundingBox TimeSig5 { get; set; }

        [JsonProperty("timeSig5Denominator")]
        public BoundingBox TimeSig5Denominator { get; set; }

        [JsonProperty("timeSig5Large")]
        public BoundingBox TimeSig5Large { get; set; }

        [JsonProperty("timeSig5Numerator")]
        public BoundingBox TimeSig5Numerator { get; set; }

        [JsonProperty("timeSig5Reversed")]
        public BoundingBox TimeSig5Reversed { get; set; }

        [JsonProperty("timeSig5Small")]
        public BoundingBox TimeSig5Small { get; set; }

        [JsonProperty("timeSig5Turned")]
        public BoundingBox TimeSig5Turned { get; set; }

        [JsonProperty("timeSig5over4")]
        public BoundingBox TimeSig5Over4 { get; set; }

        [JsonProperty("timeSig5over8")]
        public BoundingBox TimeSig5Over8 { get; set; }

        [JsonProperty("timeSig6")]
        public BoundingBox TimeSig6 { get; set; }

        [JsonProperty("timeSig6Denominator")]
        public BoundingBox TimeSig6Denominator { get; set; }

        [JsonProperty("timeSig6Large")]
        public BoundingBox TimeSig6Large { get; set; }

        [JsonProperty("timeSig6Numerator")]
        public BoundingBox TimeSig6Numerator { get; set; }

        [JsonProperty("timeSig6Reversed")]
        public BoundingBox TimeSig6Reversed { get; set; }

        [JsonProperty("timeSig6Small")]
        public BoundingBox TimeSig6Small { get; set; }

        [JsonProperty("timeSig6Turned")]
        public BoundingBox TimeSig6Turned { get; set; }

        [JsonProperty("timeSig6over4")]
        public BoundingBox TimeSig6Over4 { get; set; }

        [JsonProperty("timeSig6over8")]
        public BoundingBox TimeSig6Over8 { get; set; }

        [JsonProperty("timeSig7")]
        public BoundingBox TimeSig7 { get; set; }

        [JsonProperty("timeSig7Denominator")]
        public BoundingBox TimeSig7Denominator { get; set; }

        [JsonProperty("timeSig7Large")]
        public BoundingBox TimeSig7Large { get; set; }

        [JsonProperty("timeSig7Numerator")]
        public BoundingBox TimeSig7Numerator { get; set; }

        [JsonProperty("timeSig7Reversed")]
        public BoundingBox TimeSig7Reversed { get; set; }

        [JsonProperty("timeSig7Small")]
        public BoundingBox TimeSig7Small { get; set; }

        [JsonProperty("timeSig7Turned")]
        public BoundingBox TimeSig7Turned { get; set; }

        [JsonProperty("timeSig7over8")]
        public BoundingBox TimeSig7Over8 { get; set; }

        [JsonProperty("timeSig8")]
        public BoundingBox TimeSig8 { get; set; }

        [JsonProperty("timeSig8Denominator")]
        public BoundingBox TimeSig8Denominator { get; set; }

        [JsonProperty("timeSig8Large")]
        public BoundingBox TimeSig8Large { get; set; }

        [JsonProperty("timeSig8Numerator")]
        public BoundingBox TimeSig8Numerator { get; set; }

        [JsonProperty("timeSig8Reversed")]
        public BoundingBox TimeSig8Reversed { get; set; }

        [JsonProperty("timeSig8Small")]
        public BoundingBox TimeSig8Small { get; set; }

        [JsonProperty("timeSig8Turned")]
        public BoundingBox TimeSig8Turned { get; set; }

        [JsonProperty("timeSig9")]
        public BoundingBox TimeSig9 { get; set; }

        [JsonProperty("timeSig9Large")]
        public BoundingBox TimeSig9Large { get; set; }

        [JsonProperty("timeSig9Reversed")]
        public BoundingBox TimeSig9Reversed { get; set; }

        [JsonProperty("timeSig9Small")]
        public BoundingBox TimeSig9Small { get; set; }

        [JsonProperty("timeSig9Turned")]
        public BoundingBox TimeSig9Turned { get; set; }

        [JsonProperty("timeSig9over8")]
        public BoundingBox TimeSig9Over8 { get; set; }

        [JsonProperty("timeSigBracketLeft")]
        public BoundingBox TimeSigBracketLeft { get; set; }

        [JsonProperty("timeSigBracketLeftSmall")]
        public BoundingBox TimeSigBracketLeftSmall { get; set; }

        [JsonProperty("timeSigBracketRight")]
        public BoundingBox TimeSigBracketRight { get; set; }

        [JsonProperty("timeSigBracketRightSmall")]
        public BoundingBox TimeSigBracketRightSmall { get; set; }

        [JsonProperty("timeSigComma")]
        public BoundingBox TimeSigComma { get; set; }

        [JsonProperty("timeSigCommon")]
        public BoundingBox TimeSigCommon { get; set; }

        [JsonProperty("timeSigCommonLarge")]
        public BoundingBox TimeSigCommonLarge { get; set; }

        [JsonProperty("timeSigCommonReversed")]
        public BoundingBox TimeSigCommonReversed { get; set; }

        [JsonProperty("timeSigCommonTurned")]
        public BoundingBox TimeSigCommonTurned { get; set; }

        [JsonProperty("timeSigCut2")]
        public BoundingBox TimeSigCut2 { get; set; }

        [JsonProperty("timeSigCut3")]
        public BoundingBox TimeSigCut3 { get; set; }

        [JsonProperty("timeSigCutCommon")]
        public BoundingBox TimeSigCutCommon { get; set; }

        [JsonProperty("timeSigCutCommonLarge")]
        public BoundingBox TimeSigCutCommonLarge { get; set; }

        [JsonProperty("timeSigCutCommonReversed")]
        public BoundingBox TimeSigCutCommonReversed { get; set; }

        [JsonProperty("timeSigCutCommonTurned")]
        public BoundingBox TimeSigCutCommonTurned { get; set; }

        [JsonProperty("timeSigEquals")]
        public BoundingBox TimeSigEquals { get; set; }

        [JsonProperty("timeSigFractionHalf")]
        public BoundingBox TimeSigFractionHalf { get; set; }

        [JsonProperty("timeSigFractionOneThird")]
        public BoundingBox TimeSigFractionOneThird { get; set; }

        [JsonProperty("timeSigFractionQuarter")]
        public BoundingBox TimeSigFractionQuarter { get; set; }

        [JsonProperty("timeSigFractionThreeQuarters")]
        public BoundingBox TimeSigFractionThreeQuarters { get; set; }

        [JsonProperty("timeSigFractionTwoThirds")]
        public BoundingBox TimeSigFractionTwoThirds { get; set; }

        [JsonProperty("timeSigFractionalSlash")]
        public BoundingBox TimeSigFractionalSlash { get; set; }

        [JsonProperty("timeSigMinus")]
        public BoundingBox TimeSigMinus { get; set; }

        [JsonProperty("timeSigMultiply")]
        public BoundingBox TimeSigMultiply { get; set; }

        [JsonProperty("timeSigOpenPenderecki")]
        public BoundingBox TimeSigOpenPenderecki { get; set; }

        [JsonProperty("timeSigParensLeft")]
        public BoundingBox TimeSigParensLeft { get; set; }

        [JsonProperty("timeSigParensLeftSmall")]
        public BoundingBox TimeSigParensLeftSmall { get; set; }

        [JsonProperty("timeSigParensRight")]
        public BoundingBox TimeSigParensRight { get; set; }

        [JsonProperty("timeSigParensRightSmall")]
        public BoundingBox TimeSigParensRightSmall { get; set; }

        [JsonProperty("timeSigPlus")]
        public BoundingBox TimeSigPlus { get; set; }

        [JsonProperty("timeSigPlusLarge")]
        public BoundingBox TimeSigPlusLarge { get; set; }

        [JsonProperty("timeSigPlusSmall")]
        public BoundingBox TimeSigPlusSmall { get; set; }

        [JsonProperty("timeSigSlash")]
        public BoundingBox TimeSigSlash { get; set; }

        [JsonProperty("timeSigX")]
        public BoundingBox TimeSigX { get; set; }

        [JsonProperty("tremolo1")]
        public BoundingBox Tremolo1 { get; set; }

        [JsonProperty("tremolo2")]
        public BoundingBox Tremolo2 { get; set; }

        [JsonProperty("tremolo3")]
        public BoundingBox Tremolo3 { get; set; }

        [JsonProperty("tremolo4")]
        public BoundingBox Tremolo4 { get; set; }

        [JsonProperty("tremolo5")]
        public BoundingBox Tremolo5 { get; set; }

        [JsonProperty("tremoloDivisiDots2")]
        public BoundingBox TremoloDivisiDots2 { get; set; }

        [JsonProperty("tremoloDivisiDots3")]
        public BoundingBox TremoloDivisiDots3 { get; set; }

        [JsonProperty("tremoloDivisiDots4")]
        public BoundingBox TremoloDivisiDots4 { get; set; }

        [JsonProperty("tremoloDivisiDots6")]
        public BoundingBox TremoloDivisiDots6 { get; set; }

        [JsonProperty("tremoloFingered1")]
        public BoundingBox TremoloFingered1 { get; set; }

        [JsonProperty("tremoloFingered2")]
        public BoundingBox TremoloFingered2 { get; set; }

        [JsonProperty("tremoloFingered3")]
        public BoundingBox TremoloFingered3 { get; set; }

        [JsonProperty("tremoloFingered4")]
        public BoundingBox TremoloFingered4 { get; set; }

        [JsonProperty("tremoloFingered5")]
        public BoundingBox TremoloFingered5 { get; set; }

        [JsonProperty("tripleTongueAbove")]
        public BoundingBox TripleTongueAbove { get; set; }

        [JsonProperty("tripleTongueAboveNoSlur")]
        public BoundingBox TripleTongueAboveNoSlur { get; set; }

        [JsonProperty("tripleTongueBelow")]
        public BoundingBox TripleTongueBelow { get; set; }

        [JsonProperty("tripleTongueBelowNoSlur")]
        public BoundingBox TripleTongueBelowNoSlur { get; set; }

        [JsonProperty("tuplet0")]
        public BoundingBox Tuplet0 { get; set; }

        [JsonProperty("tuplet1")]
        public BoundingBox Tuplet1 { get; set; }

        [JsonProperty("tuplet2")]
        public BoundingBox Tuplet2 { get; set; }

        [JsonProperty("tuplet3")]
        public BoundingBox Tuplet3 { get; set; }

        [JsonProperty("tuplet4")]
        public BoundingBox Tuplet4 { get; set; }

        [JsonProperty("tuplet5")]
        public BoundingBox Tuplet5 { get; set; }

        [JsonProperty("tuplet6")]
        public BoundingBox Tuplet6 { get; set; }

        [JsonProperty("tuplet7")]
        public BoundingBox Tuplet7 { get; set; }

        [JsonProperty("tuplet8")]
        public BoundingBox Tuplet8 { get; set; }

        [JsonProperty("tuplet9")]
        public BoundingBox Tuplet9 { get; set; }

        [JsonProperty("tupletColon")]
        public BoundingBox TupletColon { get; set; }

        [JsonProperty("unmeasuredTremolo")]
        public BoundingBox UnmeasuredTremolo { get; set; }

        [JsonProperty("unmeasuredTremoloSimple")]
        public BoundingBox UnmeasuredTremoloSimple { get; set; }

        [JsonProperty("unpitchedPercussionClef1")]
        public BoundingBox UnpitchedPercussionClef1 { get; set; }

        [JsonProperty("unpitchedPercussionClef1Alt")]
        public BoundingBox UnpitchedPercussionClef1Alt { get; set; }

        [JsonProperty("unpitchedPercussionClef2")]
        public BoundingBox UnpitchedPercussionClef2 { get; set; }

        [JsonProperty("ventiduesima")]
        public BoundingBox Ventiduesima { get; set; }

        [JsonProperty("ventiduesimaAlta")]
        public BoundingBox VentiduesimaAlta { get; set; }

        [JsonProperty("ventiduesimaBassa")]
        public BoundingBox VentiduesimaBassa { get; set; }

        [JsonProperty("ventiduesimaBassaMb")]
        public BoundingBox VentiduesimaBassaMb { get; set; }

        [JsonProperty("ventiquattresima")]
        public BoundingBox Ventiquattresima { get; set; }

        [JsonProperty("ventiquattresimaAlta")]
        public BoundingBox VentiquattresimaAlta { get; set; }

        [JsonProperty("ventiquattresimaBassa")]
        public BoundingBox VentiquattresimaBassa { get; set; }

        [JsonProperty("ventiquattresimaBassaMb")]
        public BoundingBox VentiquattresimaBassaMb { get; set; }

        [JsonProperty("vocalFingerClickStockhausen")]
        public BoundingBox VocalFingerClickStockhausen { get; set; }

        [JsonProperty("vocalMouthClosed")]
        public BoundingBox VocalMouthClosed { get; set; }

        [JsonProperty("vocalMouthOpen")]
        public BoundingBox VocalMouthOpen { get; set; }

        [JsonProperty("vocalMouthPursed")]
        public BoundingBox VocalMouthPursed { get; set; }

        [JsonProperty("vocalMouthSlightlyOpen")]
        public BoundingBox VocalMouthSlightlyOpen { get; set; }

        [JsonProperty("vocalMouthWideOpen")]
        public BoundingBox VocalMouthWideOpen { get; set; }

        [JsonProperty("vocalNasalVoice")]
        public BoundingBox VocalNasalVoice { get; set; }

        [JsonProperty("vocalSprechgesang")]
        public BoundingBox VocalSprechgesang { get; set; }

        [JsonProperty("vocalTongueClickStockhausen")]
        public BoundingBox VocalTongueClickStockhausen { get; set; }

        [JsonProperty("vocalTongueFingerClickStockhausen")]
        public BoundingBox VocalTongueFingerClickStockhausen { get; set; }

        [JsonProperty("vocalsSussurando")]
        public BoundingBox VocalsSussurando { get; set; }

        [JsonProperty("wiggleArpeggiatoDown")]
        public BoundingBox WiggleArpeggiatoDown { get; set; }

        [JsonProperty("wiggleArpeggiatoDownArrow")]
        public BoundingBox WiggleArpeggiatoDownArrow { get; set; }

        [JsonProperty("wiggleArpeggiatoDownSwash")]
        public BoundingBox WiggleArpeggiatoDownSwash { get; set; }

        [JsonProperty("wiggleArpeggiatoDownSwashCouperin")]
        public BoundingBox WiggleArpeggiatoDownSwashCouperin { get; set; }

        [JsonProperty("wiggleArpeggiatoUp")]
        public BoundingBox WiggleArpeggiatoUp { get; set; }

        [JsonProperty("wiggleArpeggiatoUpArrow")]
        public BoundingBox WiggleArpeggiatoUpArrow { get; set; }

        [JsonProperty("wiggleArpeggiatoUpSwash")]
        public BoundingBox WiggleArpeggiatoUpSwash { get; set; }

        [JsonProperty("wiggleArpeggiatoUpSwashCouperin")]
        public BoundingBox WiggleArpeggiatoUpSwashCouperin { get; set; }

        [JsonProperty("wiggleCircular")]
        public BoundingBox WiggleCircular { get; set; }

        [JsonProperty("wiggleCircularConstant")]
        public BoundingBox WiggleCircularConstant { get; set; }

        [JsonProperty("wiggleCircularConstantFlipped")]
        public BoundingBox WiggleCircularConstantFlipped { get; set; }

        [JsonProperty("wiggleCircularConstantFlippedLarge")]
        public BoundingBox WiggleCircularConstantFlippedLarge { get; set; }

        [JsonProperty("wiggleCircularConstantLarge")]
        public BoundingBox WiggleCircularConstantLarge { get; set; }

        [JsonProperty("wiggleCircularEnd")]
        public BoundingBox WiggleCircularEnd { get; set; }

        [JsonProperty("wiggleCircularLarge")]
        public BoundingBox WiggleCircularLarge { get; set; }

        [JsonProperty("wiggleCircularLarger")]
        public BoundingBox WiggleCircularLarger { get; set; }

        [JsonProperty("wiggleCircularLargerStill")]
        public BoundingBox WiggleCircularLargerStill { get; set; }

        [JsonProperty("wiggleCircularLargest")]
        public BoundingBox WiggleCircularLargest { get; set; }

        [JsonProperty("wiggleCircularSmall")]
        public BoundingBox WiggleCircularSmall { get; set; }

        [JsonProperty("wiggleCircularStart")]
        public BoundingBox WiggleCircularStart { get; set; }

        [JsonProperty("wiggleGlissando")]
        public BoundingBox WiggleGlissando { get; set; }

        [JsonProperty("wiggleGlissandoGroup1")]
        public BoundingBox WiggleGlissandoGroup1 { get; set; }

        [JsonProperty("wiggleGlissandoGroup2")]
        public BoundingBox WiggleGlissandoGroup2 { get; set; }

        [JsonProperty("wiggleGlissandoGroup3")]
        public BoundingBox WiggleGlissandoGroup3 { get; set; }

        [JsonProperty("wiggleRandom1")]
        public BoundingBox WiggleRandom1 { get; set; }

        [JsonProperty("wiggleRandom2")]
        public BoundingBox WiggleRandom2 { get; set; }

        [JsonProperty("wiggleRandom3")]
        public BoundingBox WiggleRandom3 { get; set; }

        [JsonProperty("wiggleRandom4")]
        public BoundingBox WiggleRandom4 { get; set; }

        [JsonProperty("wiggleSawtooth")]
        public BoundingBox WiggleSawtooth { get; set; }

        [JsonProperty("wiggleSawtoothNarrow")]
        public BoundingBox WiggleSawtoothNarrow { get; set; }

        [JsonProperty("wiggleSawtoothWide")]
        public BoundingBox WiggleSawtoothWide { get; set; }

        [JsonProperty("wiggleSquareWave")]
        public BoundingBox WiggleSquareWave { get; set; }

        [JsonProperty("wiggleSquareWaveNarrow")]
        public BoundingBox WiggleSquareWaveNarrow { get; set; }

        [JsonProperty("wiggleSquareWaveWide")]
        public BoundingBox WiggleSquareWaveWide { get; set; }

        [JsonProperty("wiggleTrill")]
        public BoundingBox WiggleTrill { get; set; }

        [JsonProperty("wiggleTrillFast")]
        public BoundingBox WiggleTrillFast { get; set; }

        [JsonProperty("wiggleTrillFaster")]
        public BoundingBox WiggleTrillFaster { get; set; }

        [JsonProperty("wiggleTrillFasterStill")]
        public BoundingBox WiggleTrillFasterStill { get; set; }

        [JsonProperty("wiggleTrillFastest")]
        public BoundingBox WiggleTrillFastest { get; set; }

        [JsonProperty("wiggleTrillSlow")]
        public BoundingBox WiggleTrillSlow { get; set; }

        [JsonProperty("wiggleTrillSlower")]
        public BoundingBox WiggleTrillSlower { get; set; }

        [JsonProperty("wiggleTrillSlowerStill")]
        public BoundingBox WiggleTrillSlowerStill { get; set; }

        [JsonProperty("wiggleTrillSlowest")]
        public BoundingBox WiggleTrillSlowest { get; set; }

        [JsonProperty("wiggleVIbratoLargestSlower")]
        public BoundingBox WiggleVIbratoLargestSlower { get; set; }

        [JsonProperty("wiggleVIbratoMediumSlower")]
        public BoundingBox WiggleVIbratoMediumSlower { get; set; }

        [JsonProperty("wiggleVibrato")]
        public BoundingBox WiggleVibrato { get; set; }

        [JsonProperty("wiggleVibratoLargeFast")]
        public BoundingBox WiggleVibratoLargeFast { get; set; }

        [JsonProperty("wiggleVibratoLargeFaster")]
        public BoundingBox WiggleVibratoLargeFaster { get; set; }

        [JsonProperty("wiggleVibratoLargeFasterStill")]
        public BoundingBox WiggleVibratoLargeFasterStill { get; set; }

        [JsonProperty("wiggleVibratoLargeFastest")]
        public BoundingBox WiggleVibratoLargeFastest { get; set; }

        [JsonProperty("wiggleVibratoLargeSlow")]
        public BoundingBox WiggleVibratoLargeSlow { get; set; }

        [JsonProperty("wiggleVibratoLargeSlower")]
        public BoundingBox WiggleVibratoLargeSlower { get; set; }

        [JsonProperty("wiggleVibratoLargeSlowest")]
        public BoundingBox WiggleVibratoLargeSlowest { get; set; }

        [JsonProperty("wiggleVibratoLargestFast")]
        public BoundingBox WiggleVibratoLargestFast { get; set; }

        [JsonProperty("wiggleVibratoLargestFaster")]
        public BoundingBox WiggleVibratoLargestFaster { get; set; }

        [JsonProperty("wiggleVibratoLargestFasterStill")]
        public BoundingBox WiggleVibratoLargestFasterStill { get; set; }

        [JsonProperty("wiggleVibratoLargestFastest")]
        public BoundingBox WiggleVibratoLargestFastest { get; set; }

        [JsonProperty("wiggleVibratoLargestSlow")]
        public BoundingBox WiggleVibratoLargestSlow { get; set; }

        [JsonProperty("wiggleVibratoLargestSlowest")]
        public BoundingBox WiggleVibratoLargestSlowest { get; set; }

        [JsonProperty("wiggleVibratoMediumFast")]
        public BoundingBox WiggleVibratoMediumFast { get; set; }

        [JsonProperty("wiggleVibratoMediumFaster")]
        public BoundingBox WiggleVibratoMediumFaster { get; set; }

        [JsonProperty("wiggleVibratoMediumFasterStill")]
        public BoundingBox WiggleVibratoMediumFasterStill { get; set; }

        [JsonProperty("wiggleVibratoMediumFastest")]
        public BoundingBox WiggleVibratoMediumFastest { get; set; }

        [JsonProperty("wiggleVibratoMediumSlow")]
        public BoundingBox WiggleVibratoMediumSlow { get; set; }

        [JsonProperty("wiggleVibratoMediumSlowest")]
        public BoundingBox WiggleVibratoMediumSlowest { get; set; }

        [JsonProperty("wiggleVibratoSmallFast")]
        public BoundingBox WiggleVibratoSmallFast { get; set; }

        [JsonProperty("wiggleVibratoSmallFaster")]
        public BoundingBox WiggleVibratoSmallFaster { get; set; }

        [JsonProperty("wiggleVibratoSmallFasterStill")]
        public BoundingBox WiggleVibratoSmallFasterStill { get; set; }

        [JsonProperty("wiggleVibratoSmallFastest")]
        public BoundingBox WiggleVibratoSmallFastest { get; set; }

        [JsonProperty("wiggleVibratoSmallSlow")]
        public BoundingBox WiggleVibratoSmallSlow { get; set; }

        [JsonProperty("wiggleVibratoSmallSlower")]
        public BoundingBox WiggleVibratoSmallSlower { get; set; }

        [JsonProperty("wiggleVibratoSmallSlowest")]
        public BoundingBox WiggleVibratoSmallSlowest { get; set; }

        [JsonProperty("wiggleVibratoSmallestFast")]
        public BoundingBox WiggleVibratoSmallestFast { get; set; }

        [JsonProperty("wiggleVibratoSmallestFaster")]
        public BoundingBox WiggleVibratoSmallestFaster { get; set; }

        [JsonProperty("wiggleVibratoSmallestFasterStill")]
        public BoundingBox WiggleVibratoSmallestFasterStill { get; set; }

        [JsonProperty("wiggleVibratoSmallestFastest")]
        public BoundingBox WiggleVibratoSmallestFastest { get; set; }

        [JsonProperty("wiggleVibratoSmallestSlow")]
        public BoundingBox WiggleVibratoSmallestSlow { get; set; }

        [JsonProperty("wiggleVibratoSmallestSlower")]
        public BoundingBox WiggleVibratoSmallestSlower { get; set; }

        [JsonProperty("wiggleVibratoSmallestSlowest")]
        public BoundingBox WiggleVibratoSmallestSlowest { get; set; }

        [JsonProperty("wiggleVibratoStart")]
        public BoundingBox WiggleVibratoStart { get; set; }

        [JsonProperty("wiggleVibratoWide")]
        public BoundingBox WiggleVibratoWide { get; set; }

        [JsonProperty("wiggleWavy")]
        public BoundingBox WiggleWavy { get; set; }

        [JsonProperty("wiggleWavyNarrow")]
        public BoundingBox WiggleWavyNarrow { get; set; }

        [JsonProperty("wiggleWavyWide")]
        public BoundingBox WiggleWavyWide { get; set; }

        [JsonProperty("windClosedHole")]
        public BoundingBox WindClosedHole { get; set; }

        [JsonProperty("windFlatEmbouchure")]
        public BoundingBox WindFlatEmbouchure { get; set; }

        [JsonProperty("windHalfClosedHole1")]
        public BoundingBox WindHalfClosedHole1 { get; set; }

        [JsonProperty("windHalfClosedHole2")]
        public BoundingBox WindHalfClosedHole2 { get; set; }

        [JsonProperty("windHalfClosedHole3")]
        public BoundingBox WindHalfClosedHole3 { get; set; }

        [JsonProperty("windLessRelaxedEmbouchure")]
        public BoundingBox WindLessRelaxedEmbouchure { get; set; }

        [JsonProperty("windLessTightEmbouchure")]
        public BoundingBox WindLessTightEmbouchure { get; set; }

        [JsonProperty("windMouthpiecePop")]
        public BoundingBox WindMouthpiecePop { get; set; }

        [JsonProperty("windMultiphonicsBlackStem")]
        public BoundingBox WindMultiphonicsBlackStem { get; set; }

        [JsonProperty("windMultiphonicsBlackWhiteStem")]
        public BoundingBox WindMultiphonicsBlackWhiteStem { get; set; }

        [JsonProperty("windMultiphonicsWhiteStem")]
        public BoundingBox WindMultiphonicsWhiteStem { get; set; }

        [JsonProperty("windOpenHole")]
        public BoundingBox WindOpenHole { get; set; }

        [JsonProperty("windReedPositionIn")]
        public BoundingBox WindReedPositionIn { get; set; }

        [JsonProperty("windReedPositionNormal")]
        public BoundingBox WindReedPositionNormal { get; set; }

        [JsonProperty("windReedPositionOut")]
        public BoundingBox WindReedPositionOut { get; set; }

        [JsonProperty("windRelaxedEmbouchure")]
        public BoundingBox WindRelaxedEmbouchure { get; set; }

        [JsonProperty("windRimOnly")]
        public BoundingBox WindRimOnly { get; set; }

        [JsonProperty("windSharpEmbouchure")]
        public BoundingBox WindSharpEmbouchure { get; set; }

        [JsonProperty("windStrongAirPressure")]
        public BoundingBox WindStrongAirPressure { get; set; }

        [JsonProperty("windThreeQuartersClosedHole")]
        public BoundingBox WindThreeQuartersClosedHole { get; set; }

        [JsonProperty("windTightEmbouchure")]
        public BoundingBox WindTightEmbouchure { get; set; }

        [JsonProperty("windTrillKey")]
        public BoundingBox WindTrillKey { get; set; }

        [JsonProperty("windVeryTightEmbouchure")]
        public BoundingBox WindVeryTightEmbouchure { get; set; }

        [JsonProperty("windWeakAirPressure")]
        public BoundingBox WindWeakAirPressure { get; set; }
    }
}
