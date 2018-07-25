using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manufaktura.Controls.Model.SMuFL
{
    public interface IGlyphBBoxes
    {
        [JsonProperty("4stringTabClef")]
        BoundingBox The4StringTabClef { get; set; }

        [JsonProperty("4stringTabClefSerif")]
        BoundingBox The4StringTabClefSerif { get; set; }

        [JsonProperty("4stringTabClefTall")]
        BoundingBox The4StringTabClefTall { get; set; }

        [JsonProperty("6stringTabClef")]
        BoundingBox The6StringTabClef { get; set; }

        [JsonProperty("6stringTabClefSerif")]
        BoundingBox The6StringTabClefSerif { get; set; }

        [JsonProperty("6stringTabClefTall")]
        BoundingBox The6StringTabClefTall { get; set; }

        [JsonProperty("accSagittal11LargeDiesisDown")]
        BoundingBox AccSagittal11LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal11LargeDiesisUp")]
        BoundingBox AccSagittal11LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal11MediumDiesisDown")]
        BoundingBox AccSagittal11MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal11MediumDiesisUp")]
        BoundingBox AccSagittal11MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal11v19LargeDiesisDown")]
        BoundingBox AccSagittal11V19LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal11v19LargeDiesisUp")]
        BoundingBox AccSagittal11V19LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal11v19MediumDiesisDown")]
        BoundingBox AccSagittal11V19MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal11v19MediumDiesisUp")]
        BoundingBox AccSagittal11V19MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal11v49CommaDown")]
        BoundingBox AccSagittal11V49CommaDown { get; set; }

        [JsonProperty("accSagittal11v49CommaUp")]
        BoundingBox AccSagittal11V49CommaUp { get; set; }

        [JsonProperty("accSagittal143CommaDown")]
        BoundingBox AccSagittal143CommaDown { get; set; }

        [JsonProperty("accSagittal143CommaUp")]
        BoundingBox AccSagittal143CommaUp { get; set; }

        [JsonProperty("accSagittal17CommaDown")]
        BoundingBox AccSagittal17CommaDown { get; set; }

        [JsonProperty("accSagittal17CommaUp")]
        BoundingBox AccSagittal17CommaUp { get; set; }

        [JsonProperty("accSagittal17KleismaDown")]
        BoundingBox AccSagittal17KleismaDown { get; set; }

        [JsonProperty("accSagittal17KleismaUp")]
        BoundingBox AccSagittal17KleismaUp { get; set; }

        [JsonProperty("accSagittal19CommaDown")]
        BoundingBox AccSagittal19CommaDown { get; set; }

        [JsonProperty("accSagittal19CommaUp")]
        BoundingBox AccSagittal19CommaUp { get; set; }

        [JsonProperty("accSagittal19SchismaDown")]
        BoundingBox AccSagittal19SchismaDown { get; set; }

        [JsonProperty("accSagittal19SchismaUp")]
        BoundingBox AccSagittal19SchismaUp { get; set; }

        [JsonProperty("accSagittal23CommaDown")]
        BoundingBox AccSagittal23CommaDown { get; set; }

        [JsonProperty("accSagittal23CommaUp")]
        BoundingBox AccSagittal23CommaUp { get; set; }

        [JsonProperty("accSagittal23SmallDiesisDown")]
        BoundingBox AccSagittal23SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal23SmallDiesisUp")]
        BoundingBox AccSagittal23SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal25SmallDiesisDown")]
        BoundingBox AccSagittal25SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal25SmallDiesisUp")]
        BoundingBox AccSagittal25SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal35LargeDiesisDown")]
        BoundingBox AccSagittal35LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal35LargeDiesisUp")]
        BoundingBox AccSagittal35LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal35MediumDiesisDown")]
        BoundingBox AccSagittal35MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal35MediumDiesisUp")]
        BoundingBox AccSagittal35MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal49LargeDiesisDown")]
        BoundingBox AccSagittal49LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal49LargeDiesisUp")]
        BoundingBox AccSagittal49LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal49MediumDiesisDown")]
        BoundingBox AccSagittal49MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal49MediumDiesisUp")]
        BoundingBox AccSagittal49MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal49SmallDiesisDown")]
        BoundingBox AccSagittal49SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal49SmallDiesisUp")]
        BoundingBox AccSagittal49SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal55CommaDown")]
        BoundingBox AccSagittal55CommaDown { get; set; }

        [JsonProperty("accSagittal55CommaUp")]
        BoundingBox AccSagittal55CommaUp { get; set; }

        [JsonProperty("accSagittal5CommaDown")]
        BoundingBox AccSagittal5CommaDown { get; set; }

        [JsonProperty("accSagittal5CommaUp")]
        BoundingBox AccSagittal5CommaUp { get; set; }

        [JsonProperty("accSagittal5v11SmallDiesisDown")]
        BoundingBox AccSagittal5V11SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal5v11SmallDiesisUp")]
        BoundingBox AccSagittal5V11SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal5v13LargeDiesisDown")]
        BoundingBox AccSagittal5V13LargeDiesisDown { get; set; }

        [JsonProperty("accSagittal5v13LargeDiesisUp")]
        BoundingBox AccSagittal5V13LargeDiesisUp { get; set; }

        [JsonProperty("accSagittal5v13MediumDiesisDown")]
        BoundingBox AccSagittal5V13MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal5v13MediumDiesisUp")]
        BoundingBox AccSagittal5V13MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal5v19CommaDown")]
        BoundingBox AccSagittal5V19CommaDown { get; set; }

        [JsonProperty("accSagittal5v19CommaUp")]
        BoundingBox AccSagittal5V19CommaUp { get; set; }

        [JsonProperty("accSagittal5v23SmallDiesisDown")]
        BoundingBox AccSagittal5V23SmallDiesisDown { get; set; }

        [JsonProperty("accSagittal5v23SmallDiesisUp")]
        BoundingBox AccSagittal5V23SmallDiesisUp { get; set; }

        [JsonProperty("accSagittal5v49MediumDiesisDown")]
        BoundingBox AccSagittal5V49MediumDiesisDown { get; set; }

        [JsonProperty("accSagittal5v49MediumDiesisUp")]
        BoundingBox AccSagittal5V49MediumDiesisUp { get; set; }

        [JsonProperty("accSagittal5v7KleismaDown")]
        BoundingBox AccSagittal5V7KleismaDown { get; set; }

        [JsonProperty("accSagittal5v7KleismaUp")]
        BoundingBox AccSagittal5V7KleismaUp { get; set; }

        [JsonProperty("accSagittal7CommaDown")]
        BoundingBox AccSagittal7CommaDown { get; set; }

        [JsonProperty("accSagittal7CommaUp")]
        BoundingBox AccSagittal7CommaUp { get; set; }

        [JsonProperty("accSagittal7v11CommaDown")]
        BoundingBox AccSagittal7V11CommaDown { get; set; }

        [JsonProperty("accSagittal7v11CommaUp")]
        BoundingBox AccSagittal7V11CommaUp { get; set; }

        [JsonProperty("accSagittal7v11KleismaDown")]
        BoundingBox AccSagittal7V11KleismaDown { get; set; }

        [JsonProperty("accSagittal7v11KleismaUp")]
        BoundingBox AccSagittal7V11KleismaUp { get; set; }

        [JsonProperty("accSagittal7v19CommaDown")]
        BoundingBox AccSagittal7V19CommaDown { get; set; }

        [JsonProperty("accSagittal7v19CommaUp")]
        BoundingBox AccSagittal7V19CommaUp { get; set; }

        [JsonProperty("accSagittalAcute")]
        BoundingBox AccSagittalAcute { get; set; }

        [JsonProperty("accSagittalDoubleFlat")]
        BoundingBox AccSagittalDoubleFlat { get; set; }

        [JsonProperty("accSagittalDoubleFlat11v49CUp")]
        BoundingBox AccSagittalDoubleFlat11V49CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat143CUp")]
        BoundingBox AccSagittalDoubleFlat143CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat17CUp")]
        BoundingBox AccSagittalDoubleFlat17CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat17kUp")]
        BoundingBox AccSagittalDoubleFlat17KUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat19CUp")]
        BoundingBox AccSagittalDoubleFlat19CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat19sUp")]
        BoundingBox AccSagittalDoubleFlat19SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat23CUp")]
        BoundingBox AccSagittalDoubleFlat23CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat23SUp")]
        BoundingBox AccSagittalDoubleFlat23SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat25SUp")]
        BoundingBox AccSagittalDoubleFlat25SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat49SUp")]
        BoundingBox AccSagittalDoubleFlat49SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat55CUp")]
        BoundingBox AccSagittalDoubleFlat55CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5CUp")]
        BoundingBox AccSagittalDoubleFlat5CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5v11SUp")]
        BoundingBox AccSagittalDoubleFlat5V11SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5v19CUp")]
        BoundingBox AccSagittalDoubleFlat5V19CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5v23SUp")]
        BoundingBox AccSagittalDoubleFlat5V23SUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat5v7kUp")]
        BoundingBox AccSagittalDoubleFlat5V7KUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat7CUp")]
        BoundingBox AccSagittalDoubleFlat7CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat7v11CUp")]
        BoundingBox AccSagittalDoubleFlat7V11CUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat7v11kUp")]
        BoundingBox AccSagittalDoubleFlat7V11KUp { get; set; }

        [JsonProperty("accSagittalDoubleFlat7v19CUp")]
        BoundingBox AccSagittalDoubleFlat7V19CUp { get; set; }

        [JsonProperty("accSagittalDoubleSharp")]
        BoundingBox AccSagittalDoubleSharp { get; set; }

        [JsonProperty("accSagittalDoubleSharp11v49CDown")]
        BoundingBox AccSagittalDoubleSharp11V49CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp143CDown")]
        BoundingBox AccSagittalDoubleSharp143CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp17CDown")]
        BoundingBox AccSagittalDoubleSharp17CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp17kDown")]
        BoundingBox AccSagittalDoubleSharp17KDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp19CDown")]
        BoundingBox AccSagittalDoubleSharp19CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp19sDown")]
        BoundingBox AccSagittalDoubleSharp19SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp23CDown")]
        BoundingBox AccSagittalDoubleSharp23CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp23SDown")]
        BoundingBox AccSagittalDoubleSharp23SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp25SDown")]
        BoundingBox AccSagittalDoubleSharp25SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp49SDown")]
        BoundingBox AccSagittalDoubleSharp49SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp55CDown")]
        BoundingBox AccSagittalDoubleSharp55CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5CDown")]
        BoundingBox AccSagittalDoubleSharp5CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5v11SDown")]
        BoundingBox AccSagittalDoubleSharp5V11SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5v19CDown")]
        BoundingBox AccSagittalDoubleSharp5V19CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5v23SDown")]
        BoundingBox AccSagittalDoubleSharp5V23SDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp5v7kDown")]
        BoundingBox AccSagittalDoubleSharp5V7KDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp7CDown")]
        BoundingBox AccSagittalDoubleSharp7CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp7v11CDown")]
        BoundingBox AccSagittalDoubleSharp7V11CDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp7v11kDown")]
        BoundingBox AccSagittalDoubleSharp7V11KDown { get; set; }

        [JsonProperty("accSagittalDoubleSharp7v19CDown")]
        BoundingBox AccSagittalDoubleSharp7V19CDown { get; set; }

        [JsonProperty("accSagittalFlat")]
        BoundingBox AccSagittalFlat { get; set; }

        [JsonProperty("accSagittalFlat11LDown")]
        BoundingBox AccSagittalFlat11LDown { get; set; }

        [JsonProperty("accSagittalFlat11MDown")]
        BoundingBox AccSagittalFlat11MDown { get; set; }

        [JsonProperty("accSagittalFlat11v19LDown")]
        BoundingBox AccSagittalFlat11V19LDown { get; set; }

        [JsonProperty("accSagittalFlat11v19MDown")]
        BoundingBox AccSagittalFlat11V19MDown { get; set; }

        [JsonProperty("accSagittalFlat11v49CDown")]
        BoundingBox AccSagittalFlat11V49CDown { get; set; }

        [JsonProperty("accSagittalFlat11v49CUp")]
        BoundingBox AccSagittalFlat11V49CUp { get; set; }

        [JsonProperty("accSagittalFlat143CDown")]
        BoundingBox AccSagittalFlat143CDown { get; set; }

        [JsonProperty("accSagittalFlat143CUp")]
        BoundingBox AccSagittalFlat143CUp { get; set; }

        [JsonProperty("accSagittalFlat17CDown")]
        BoundingBox AccSagittalFlat17CDown { get; set; }

        [JsonProperty("accSagittalFlat17CUp")]
        BoundingBox AccSagittalFlat17CUp { get; set; }

        [JsonProperty("accSagittalFlat17kDown")]
        BoundingBox AccSagittalFlat17KDown { get; set; }

        [JsonProperty("accSagittalFlat17kUp")]
        BoundingBox AccSagittalFlat17KUp { get; set; }

        [JsonProperty("accSagittalFlat19CDown")]
        BoundingBox AccSagittalFlat19CDown { get; set; }

        [JsonProperty("accSagittalFlat19CUp")]
        BoundingBox AccSagittalFlat19CUp { get; set; }

        [JsonProperty("accSagittalFlat19sDown")]
        BoundingBox AccSagittalFlat19SDown { get; set; }

        [JsonProperty("accSagittalFlat19sUp")]
        BoundingBox AccSagittalFlat19SUp { get; set; }

        [JsonProperty("accSagittalFlat23CDown")]
        BoundingBox AccSagittalFlat23CDown { get; set; }

        [JsonProperty("accSagittalFlat23CUp")]
        BoundingBox AccSagittalFlat23CUp { get; set; }

        [JsonProperty("accSagittalFlat23SDown")]
        BoundingBox AccSagittalFlat23SDown { get; set; }

        [JsonProperty("accSagittalFlat23SUp")]
        BoundingBox AccSagittalFlat23SUp { get; set; }

        [JsonProperty("accSagittalFlat25SDown")]
        BoundingBox AccSagittalFlat25SDown { get; set; }

        [JsonProperty("accSagittalFlat25SUp")]
        BoundingBox AccSagittalFlat25SUp { get; set; }

        [JsonProperty("accSagittalFlat35LDown")]
        BoundingBox AccSagittalFlat35LDown { get; set; }

        [JsonProperty("accSagittalFlat35MDown")]
        BoundingBox AccSagittalFlat35MDown { get; set; }

        [JsonProperty("accSagittalFlat49LDown")]
        BoundingBox AccSagittalFlat49LDown { get; set; }

        [JsonProperty("accSagittalFlat49MDown")]
        BoundingBox AccSagittalFlat49MDown { get; set; }

        [JsonProperty("accSagittalFlat49SDown")]
        BoundingBox AccSagittalFlat49SDown { get; set; }

        [JsonProperty("accSagittalFlat49SUp")]
        BoundingBox AccSagittalFlat49SUp { get; set; }

        [JsonProperty("accSagittalFlat55CDown")]
        BoundingBox AccSagittalFlat55CDown { get; set; }

        [JsonProperty("accSagittalFlat55CUp")]
        BoundingBox AccSagittalFlat55CUp { get; set; }

        [JsonProperty("accSagittalFlat5CDown")]
        BoundingBox AccSagittalFlat5CDown { get; set; }

        [JsonProperty("accSagittalFlat5CUp")]
        BoundingBox AccSagittalFlat5CUp { get; set; }

        [JsonProperty("accSagittalFlat5v11SDown")]
        BoundingBox AccSagittalFlat5V11SDown { get; set; }

        [JsonProperty("accSagittalFlat5v11SUp")]
        BoundingBox AccSagittalFlat5V11SUp { get; set; }

        [JsonProperty("accSagittalFlat5v13LDown")]
        BoundingBox AccSagittalFlat5V13LDown { get; set; }

        [JsonProperty("accSagittalFlat5v13MDown")]
        BoundingBox AccSagittalFlat5V13MDown { get; set; }

        [JsonProperty("accSagittalFlat5v19CDown")]
        BoundingBox AccSagittalFlat5V19CDown { get; set; }

        [JsonProperty("accSagittalFlat5v19CUp")]
        BoundingBox AccSagittalFlat5V19CUp { get; set; }

        [JsonProperty("accSagittalFlat5v23SDown")]
        BoundingBox AccSagittalFlat5V23SDown { get; set; }

        [JsonProperty("accSagittalFlat5v23SUp")]
        BoundingBox AccSagittalFlat5V23SUp { get; set; }

        [JsonProperty("accSagittalFlat5v49MDown")]
        BoundingBox AccSagittalFlat5V49MDown { get; set; }

        [JsonProperty("accSagittalFlat5v7kDown")]
        BoundingBox AccSagittalFlat5V7KDown { get; set; }

        [JsonProperty("accSagittalFlat5v7kUp")]
        BoundingBox AccSagittalFlat5V7KUp { get; set; }

        [JsonProperty("accSagittalFlat7CDown")]
        BoundingBox AccSagittalFlat7CDown { get; set; }

        [JsonProperty("accSagittalFlat7CUp")]
        BoundingBox AccSagittalFlat7CUp { get; set; }

        [JsonProperty("accSagittalFlat7v11CDown")]
        BoundingBox AccSagittalFlat7V11CDown { get; set; }

        [JsonProperty("accSagittalFlat7v11CUp")]
        BoundingBox AccSagittalFlat7V11CUp { get; set; }

        [JsonProperty("accSagittalFlat7v11kDown")]
        BoundingBox AccSagittalFlat7V11KDown { get; set; }

        [JsonProperty("accSagittalFlat7v11kUp")]
        BoundingBox AccSagittalFlat7V11KUp { get; set; }

        [JsonProperty("accSagittalFlat7v19CDown")]
        BoundingBox AccSagittalFlat7V19CDown { get; set; }

        [JsonProperty("accSagittalFlat7v19CUp")]
        BoundingBox AccSagittalFlat7V19CUp { get; set; }

        [JsonProperty("accSagittalGrave")]
        BoundingBox AccSagittalGrave { get; set; }

        [JsonProperty("accSagittalShaftDown")]
        BoundingBox AccSagittalShaftDown { get; set; }

        [JsonProperty("accSagittalShaftUp")]
        BoundingBox AccSagittalShaftUp { get; set; }

        [JsonProperty("accSagittalSharp")]
        BoundingBox AccSagittalSharp { get; set; }

        [JsonProperty("accSagittalSharp11LUp")]
        BoundingBox AccSagittalSharp11LUp { get; set; }

        [JsonProperty("accSagittalSharp11MUp")]
        BoundingBox AccSagittalSharp11MUp { get; set; }

        [JsonProperty("accSagittalSharp11v19LUp")]
        BoundingBox AccSagittalSharp11V19LUp { get; set; }

        [JsonProperty("accSagittalSharp11v19MUp")]
        BoundingBox AccSagittalSharp11V19MUp { get; set; }

        [JsonProperty("accSagittalSharp11v49CDown")]
        BoundingBox AccSagittalSharp11V49CDown { get; set; }

        [JsonProperty("accSagittalSharp11v49CUp")]
        BoundingBox AccSagittalSharp11V49CUp { get; set; }

        [JsonProperty("accSagittalSharp143CDown")]
        BoundingBox AccSagittalSharp143CDown { get; set; }

        [JsonProperty("accSagittalSharp143CUp")]
        BoundingBox AccSagittalSharp143CUp { get; set; }

        [JsonProperty("accSagittalSharp17CDown")]
        BoundingBox AccSagittalSharp17CDown { get; set; }

        [JsonProperty("accSagittalSharp17CUp")]
        BoundingBox AccSagittalSharp17CUp { get; set; }

        [JsonProperty("accSagittalSharp17kDown")]
        BoundingBox AccSagittalSharp17KDown { get; set; }

        [JsonProperty("accSagittalSharp17kUp")]
        BoundingBox AccSagittalSharp17KUp { get; set; }

        [JsonProperty("accSagittalSharp19CDown")]
        BoundingBox AccSagittalSharp19CDown { get; set; }

        [JsonProperty("accSagittalSharp19CUp")]
        BoundingBox AccSagittalSharp19CUp { get; set; }

        [JsonProperty("accSagittalSharp19sDown")]
        BoundingBox AccSagittalSharp19SDown { get; set; }

        [JsonProperty("accSagittalSharp19sUp")]
        BoundingBox AccSagittalSharp19SUp { get; set; }

        [JsonProperty("accSagittalSharp23CDown")]
        BoundingBox AccSagittalSharp23CDown { get; set; }

        [JsonProperty("accSagittalSharp23CUp")]
        BoundingBox AccSagittalSharp23CUp { get; set; }

        [JsonProperty("accSagittalSharp23SDown")]
        BoundingBox AccSagittalSharp23SDown { get; set; }

        [JsonProperty("accSagittalSharp23SUp")]
        BoundingBox AccSagittalSharp23SUp { get; set; }

        [JsonProperty("accSagittalSharp25SDown")]
        BoundingBox AccSagittalSharp25SDown { get; set; }

        [JsonProperty("accSagittalSharp25SUp")]
        BoundingBox AccSagittalSharp25SUp { get; set; }

        [JsonProperty("accSagittalSharp35LUp")]
        BoundingBox AccSagittalSharp35LUp { get; set; }

        [JsonProperty("accSagittalSharp35MUp")]
        BoundingBox AccSagittalSharp35MUp { get; set; }

        [JsonProperty("accSagittalSharp49LUp")]
        BoundingBox AccSagittalSharp49LUp { get; set; }

        [JsonProperty("accSagittalSharp49MUp")]
        BoundingBox AccSagittalSharp49MUp { get; set; }

        [JsonProperty("accSagittalSharp49SDown")]
        BoundingBox AccSagittalSharp49SDown { get; set; }

        [JsonProperty("accSagittalSharp49SUp")]
        BoundingBox AccSagittalSharp49SUp { get; set; }

        [JsonProperty("accSagittalSharp55CDown")]
        BoundingBox AccSagittalSharp55CDown { get; set; }

        [JsonProperty("accSagittalSharp55CUp")]
        BoundingBox AccSagittalSharp55CUp { get; set; }

        [JsonProperty("accSagittalSharp5CDown")]
        BoundingBox AccSagittalSharp5CDown { get; set; }

        [JsonProperty("accSagittalSharp5CUp")]
        BoundingBox AccSagittalSharp5CUp { get; set; }

        [JsonProperty("accSagittalSharp5v11SDown")]
        BoundingBox AccSagittalSharp5V11SDown { get; set; }

        [JsonProperty("accSagittalSharp5v11SUp")]
        BoundingBox AccSagittalSharp5V11SUp { get; set; }

        [JsonProperty("accSagittalSharp5v13LUp")]
        BoundingBox AccSagittalSharp5V13LUp { get; set; }

        [JsonProperty("accSagittalSharp5v13MUp")]
        BoundingBox AccSagittalSharp5V13MUp { get; set; }

        [JsonProperty("accSagittalSharp5v19CDown")]
        BoundingBox AccSagittalSharp5V19CDown { get; set; }

        [JsonProperty("accSagittalSharp5v19CUp")]
        BoundingBox AccSagittalSharp5V19CUp { get; set; }

        [JsonProperty("accSagittalSharp5v23SDown")]
        BoundingBox AccSagittalSharp5V23SDown { get; set; }

        [JsonProperty("accSagittalSharp5v23SUp")]
        BoundingBox AccSagittalSharp5V23SUp { get; set; }

        [JsonProperty("accSagittalSharp5v49MUp")]
        BoundingBox AccSagittalSharp5V49MUp { get; set; }

        [JsonProperty("accSagittalSharp5v7kDown")]
        BoundingBox AccSagittalSharp5V7KDown { get; set; }

        [JsonProperty("accSagittalSharp5v7kUp")]
        BoundingBox AccSagittalSharp5V7KUp { get; set; }

        [JsonProperty("accSagittalSharp7CDown")]
        BoundingBox AccSagittalSharp7CDown { get; set; }

        [JsonProperty("accSagittalSharp7CUp")]
        BoundingBox AccSagittalSharp7CUp { get; set; }

        [JsonProperty("accSagittalSharp7v11CDown")]
        BoundingBox AccSagittalSharp7V11CDown { get; set; }

        [JsonProperty("accSagittalSharp7v11CUp")]
        BoundingBox AccSagittalSharp7V11CUp { get; set; }

        [JsonProperty("accSagittalSharp7v11kDown")]
        BoundingBox AccSagittalSharp7V11KDown { get; set; }

        [JsonProperty("accSagittalSharp7v11kUp")]
        BoundingBox AccSagittalSharp7V11KUp { get; set; }

        [JsonProperty("accSagittalSharp7v19CDown")]
        BoundingBox AccSagittalSharp7V19CDown { get; set; }

        [JsonProperty("accSagittalSharp7v19CUp")]
        BoundingBox AccSagittalSharp7V19CUp { get; set; }

        [JsonProperty("accdnCombDot")]
        BoundingBox AccdnCombDot { get; set; }

        [JsonProperty("accdnCombLH2RanksEmpty")]
        BoundingBox AccdnCombLh2RanksEmpty { get; set; }

        [JsonProperty("accdnCombLH3RanksEmptySquare")]
        BoundingBox AccdnCombLh3RanksEmptySquare { get; set; }

        [JsonProperty("accdnCombRH3RanksEmpty")]
        BoundingBox AccdnCombRh3RanksEmpty { get; set; }

        [JsonProperty("accdnCombRH4RanksEmpty")]
        BoundingBox AccdnCombRh4RanksEmpty { get; set; }

        [JsonProperty("accdnDiatonicClef")]
        BoundingBox AccdnDiatonicClef { get; set; }

        [JsonProperty("accdnLH2Ranks16Round")]
        BoundingBox AccdnLh2Ranks16Round { get; set; }

        [JsonProperty("accdnLH2Ranks8Plus16Round")]
        BoundingBox AccdnLh2Ranks8Plus16Round { get; set; }

        [JsonProperty("accdnLH2Ranks8Round")]
        BoundingBox AccdnLh2Ranks8Round { get; set; }

        [JsonProperty("accdnLH2RanksFullMasterRound")]
        BoundingBox AccdnLh2RanksFullMasterRound { get; set; }

        [JsonProperty("accdnLH2RanksMasterPlus16Round")]
        BoundingBox AccdnLh2RanksMasterPlus16Round { get; set; }

        [JsonProperty("accdnLH2RanksMasterRound")]
        BoundingBox AccdnLh2RanksMasterRound { get; set; }

        [JsonProperty("accdnLH3Ranks2Plus8Square")]
        BoundingBox AccdnLh3Ranks2Plus8Square { get; set; }

        [JsonProperty("accdnLH3Ranks2Square")]
        BoundingBox AccdnLh3Ranks2Square { get; set; }

        [JsonProperty("accdnLH3Ranks8Square")]
        BoundingBox AccdnLh3Ranks8Square { get; set; }

        [JsonProperty("accdnLH3RanksDouble8Square")]
        BoundingBox AccdnLh3RanksDouble8Square { get; set; }

        [JsonProperty("accdnLH3RanksTuttiSquare")]
        BoundingBox AccdnLh3RanksTuttiSquare { get; set; }

        [JsonProperty("accdnPull")]
        BoundingBox AccdnPull { get; set; }

        [JsonProperty("accdnPush")]
        BoundingBox AccdnPush { get; set; }

        [JsonProperty("accdnPushAlt")]
        BoundingBox AccdnPushAlt { get; set; }

        [JsonProperty("accdnRH3RanksAccordion")]
        BoundingBox AccdnRh3RanksAccordion { get; set; }

        [JsonProperty("accdnRH3RanksAuthenticMusette")]
        BoundingBox AccdnRh3RanksAuthenticMusette { get; set; }

        [JsonProperty("accdnRH3RanksBandoneon")]
        BoundingBox AccdnRh3RanksBandoneon { get; set; }

        [JsonProperty("accdnRH3RanksBassoon")]
        BoundingBox AccdnRh3RanksBassoon { get; set; }

        [JsonProperty("accdnRH3RanksClarinet")]
        BoundingBox AccdnRh3RanksClarinet { get; set; }

        [JsonProperty("accdnRH3RanksDoubleTremoloLower8ve")]
        BoundingBox AccdnRh3RanksDoubleTremoloLower8Ve { get; set; }

        [JsonProperty("accdnRH3RanksDoubleTremoloUpper8ve")]
        BoundingBox AccdnRh3RanksDoubleTremoloUpper8Ve { get; set; }

        [JsonProperty("accdnRH3RanksFullFactory")]
        BoundingBox AccdnRh3RanksFullFactory { get; set; }

        [JsonProperty("accdnRH3RanksHarmonium")]
        BoundingBox AccdnRh3RanksHarmonium { get; set; }

        [JsonProperty("accdnRH3RanksImitationMusette")]
        BoundingBox AccdnRh3RanksImitationMusette { get; set; }

        [JsonProperty("accdnRH3RanksLowerTremolo8")]
        BoundingBox AccdnRh3RanksLowerTremolo8 { get; set; }

        [JsonProperty("accdnRH3RanksMaster")]
        BoundingBox AccdnRh3RanksMaster { get; set; }

        [JsonProperty("accdnRH3RanksOboe")]
        BoundingBox AccdnRh3RanksOboe { get; set; }

        [JsonProperty("accdnRH3RanksOrgan")]
        BoundingBox AccdnRh3RanksOrgan { get; set; }

        [JsonProperty("accdnRH3RanksPiccolo")]
        BoundingBox AccdnRh3RanksPiccolo { get; set; }

        [JsonProperty("accdnRH3RanksTremoloLower8ve")]
        BoundingBox AccdnRh3RanksTremoloLower8Ve { get; set; }

        [JsonProperty("accdnRH3RanksTremoloUpper8ve")]
        BoundingBox AccdnRh3RanksTremoloUpper8Ve { get; set; }

        [JsonProperty("accdnRH3RanksTwoChoirs")]
        BoundingBox AccdnRh3RanksTwoChoirs { get; set; }

        [JsonProperty("accdnRH3RanksUpperTremolo8")]
        BoundingBox AccdnRh3RanksUpperTremolo8 { get; set; }

        [JsonProperty("accdnRH3RanksViolin")]
        BoundingBox AccdnRh3RanksViolin { get; set; }

        [JsonProperty("accdnRH4RanksAlto")]
        BoundingBox AccdnRh4RanksAlto { get; set; }

        [JsonProperty("accdnRH4RanksBassAlto")]
        BoundingBox AccdnRh4RanksBassAlto { get; set; }

        [JsonProperty("accdnRH4RanksMaster")]
        BoundingBox AccdnRh4RanksMaster { get; set; }

        [JsonProperty("accdnRH4RanksSoftBass")]
        BoundingBox AccdnRh4RanksSoftBass { get; set; }

        [JsonProperty("accdnRH4RanksSoftTenor")]
        BoundingBox AccdnRh4RanksSoftTenor { get; set; }

        [JsonProperty("accdnRH4RanksSoprano")]
        BoundingBox AccdnRh4RanksSoprano { get; set; }

        [JsonProperty("accdnRH4RanksTenor")]
        BoundingBox AccdnRh4RanksTenor { get; set; }

        [JsonProperty("accdnRicochet2")]
        BoundingBox AccdnRicochet2 { get; set; }

        [JsonProperty("accdnRicochet3")]
        BoundingBox AccdnRicochet3 { get; set; }

        [JsonProperty("accdnRicochet4")]
        BoundingBox AccdnRicochet4 { get; set; }

        [JsonProperty("accdnRicochet5")]
        BoundingBox AccdnRicochet5 { get; set; }

        [JsonProperty("accdnRicochet6")]
        BoundingBox AccdnRicochet6 { get; set; }

        [JsonProperty("accdnRicochetStem2")]
        BoundingBox AccdnRicochetStem2 { get; set; }

        [JsonProperty("accdnRicochetStem3")]
        BoundingBox AccdnRicochetStem3 { get; set; }

        [JsonProperty("accdnRicochetStem4")]
        BoundingBox AccdnRicochetStem4 { get; set; }

        [JsonProperty("accdnRicochetStem5")]
        BoundingBox AccdnRicochetStem5 { get; set; }

        [JsonProperty("accdnRicochetStem6")]
        BoundingBox AccdnRicochetStem6 { get; set; }

        [JsonProperty("accidental1CommaFlat")]
        BoundingBox Accidental1CommaFlat { get; set; }

        [JsonProperty("accidental1CommaSharp")]
        BoundingBox Accidental1CommaSharp { get; set; }

        [JsonProperty("accidental2CommaFlat")]
        BoundingBox Accidental2CommaFlat { get; set; }

        [JsonProperty("accidental2CommaSharp")]
        BoundingBox Accidental2CommaSharp { get; set; }

        [JsonProperty("accidental3CommaFlat")]
        BoundingBox Accidental3CommaFlat { get; set; }

        [JsonProperty("accidental3CommaSharp")]
        BoundingBox Accidental3CommaSharp { get; set; }

        [JsonProperty("accidental4CommaFlat")]
        BoundingBox Accidental4CommaFlat { get; set; }

        [JsonProperty("accidental5CommaSharp")]
        BoundingBox Accidental5CommaSharp { get; set; }

        [JsonProperty("accidentalArrowDown")]
        BoundingBox AccidentalArrowDown { get; set; }

        [JsonProperty("accidentalArrowUp")]
        BoundingBox AccidentalArrowUp { get; set; }

        [JsonProperty("accidentalBakiyeFlat")]
        BoundingBox AccidentalBakiyeFlat { get; set; }

        [JsonProperty("accidentalBakiyeSharp")]
        BoundingBox AccidentalBakiyeSharp { get; set; }

        [JsonProperty("accidentalBracketLeft")]
        BoundingBox AccidentalBracketLeft { get; set; }

        [JsonProperty("accidentalBracketRight")]
        BoundingBox AccidentalBracketRight { get; set; }

        [JsonProperty("accidentalBuyukMucennebFlat")]
        BoundingBox AccidentalBuyukMucennebFlat { get; set; }

        [JsonProperty("accidentalBuyukMucennebSharp")]
        BoundingBox AccidentalBuyukMucennebSharp { get; set; }

        [JsonProperty("accidentalCombiningCloseCurlyBrace")]
        BoundingBox AccidentalCombiningCloseCurlyBrace { get; set; }

        [JsonProperty("accidentalCombiningLower17Schisma")]
        BoundingBox AccidentalCombiningLower17Schisma { get; set; }

        [JsonProperty("accidentalCombiningLower19Schisma")]
        BoundingBox AccidentalCombiningLower19Schisma { get; set; }

        [JsonProperty("accidentalCombiningLower23Limit29LimitComma")]
        BoundingBox AccidentalCombiningLower23Limit29LimitComma { get; set; }

        [JsonProperty("accidentalCombiningLower31Schisma")]
        BoundingBox AccidentalCombiningLower31Schisma { get; set; }

        [JsonProperty("accidentalCombiningLower53LimitComma")]
        BoundingBox AccidentalCombiningLower53LimitComma { get; set; }

        [JsonProperty("accidentalCombiningOpenCurlyBrace")]
        BoundingBox AccidentalCombiningOpenCurlyBrace { get; set; }

        [JsonProperty("accidentalCombiningRaise17Schisma")]
        BoundingBox AccidentalCombiningRaise17Schisma { get; set; }

        [JsonProperty("accidentalCombiningRaise19Schisma")]
        BoundingBox AccidentalCombiningRaise19Schisma { get; set; }

        [JsonProperty("accidentalCombiningRaise23Limit29LimitComma")]
        BoundingBox AccidentalCombiningRaise23Limit29LimitComma { get; set; }

        [JsonProperty("accidentalCombiningRaise31Schisma")]
        BoundingBox AccidentalCombiningRaise31Schisma { get; set; }

        [JsonProperty("accidentalCombiningRaise53LimitComma")]
        BoundingBox AccidentalCombiningRaise53LimitComma { get; set; }

        [JsonProperty("accidentalCommaSlashDown")]
        BoundingBox AccidentalCommaSlashDown { get; set; }

        [JsonProperty("accidentalCommaSlashUp")]
        BoundingBox AccidentalCommaSlashUp { get; set; }

        [JsonProperty("accidentalDoubleFlat")]
        BoundingBox AccidentalDoubleFlat { get; set; }

        [JsonProperty("accidentalDoubleFlatArabic")]
        BoundingBox AccidentalDoubleFlatArabic { get; set; }

        [JsonProperty("accidentalDoubleFlatEqualTempered")]
        BoundingBox AccidentalDoubleFlatEqualTempered { get; set; }

        [JsonProperty("accidentalDoubleFlatJoinedStems")]
        BoundingBox AccidentalDoubleFlatJoinedStems { get; set; }

        [JsonProperty("accidentalDoubleFlatOneArrowDown")]
        BoundingBox AccidentalDoubleFlatOneArrowDown { get; set; }

        [JsonProperty("accidentalDoubleFlatOneArrowUp")]
        BoundingBox AccidentalDoubleFlatOneArrowUp { get; set; }

        [JsonProperty("accidentalDoubleFlatParens")]
        BoundingBox AccidentalDoubleFlatParens { get; set; }

        [JsonProperty("accidentalDoubleFlatReversed")]
        BoundingBox AccidentalDoubleFlatReversed { get; set; }

        [JsonProperty("accidentalDoubleFlatThreeArrowsDown")]
        BoundingBox AccidentalDoubleFlatThreeArrowsDown { get; set; }

        [JsonProperty("accidentalDoubleFlatThreeArrowsUp")]
        BoundingBox AccidentalDoubleFlatThreeArrowsUp { get; set; }

        [JsonProperty("accidentalDoubleFlatTurned")]
        BoundingBox AccidentalDoubleFlatTurned { get; set; }

        [JsonProperty("accidentalDoubleFlatTwoArrowsDown")]
        BoundingBox AccidentalDoubleFlatTwoArrowsDown { get; set; }

        [JsonProperty("accidentalDoubleFlatTwoArrowsUp")]
        BoundingBox AccidentalDoubleFlatTwoArrowsUp { get; set; }

        [JsonProperty("accidentalDoubleSharp")]
        BoundingBox AccidentalDoubleSharp { get; set; }

        [JsonProperty("accidentalDoubleSharpArabic")]
        BoundingBox AccidentalDoubleSharpArabic { get; set; }

        [JsonProperty("accidentalDoubleSharpEqualTempered")]
        BoundingBox AccidentalDoubleSharpEqualTempered { get; set; }

        [JsonProperty("accidentalDoubleSharpOneArrowDown")]
        BoundingBox AccidentalDoubleSharpOneArrowDown { get; set; }

        [JsonProperty("accidentalDoubleSharpOneArrowUp")]
        BoundingBox AccidentalDoubleSharpOneArrowUp { get; set; }

        [JsonProperty("accidentalDoubleSharpParens")]
        BoundingBox AccidentalDoubleSharpParens { get; set; }

        [JsonProperty("accidentalDoubleSharpThreeArrowsDown")]
        BoundingBox AccidentalDoubleSharpThreeArrowsDown { get; set; }

        [JsonProperty("accidentalDoubleSharpThreeArrowsUp")]
        BoundingBox AccidentalDoubleSharpThreeArrowsUp { get; set; }

        [JsonProperty("accidentalDoubleSharpTwoArrowsDown")]
        BoundingBox AccidentalDoubleSharpTwoArrowsDown { get; set; }

        [JsonProperty("accidentalDoubleSharpTwoArrowsUp")]
        BoundingBox AccidentalDoubleSharpTwoArrowsUp { get; set; }

        [JsonProperty("accidentalEnharmonicAlmostEqualTo")]
        BoundingBox AccidentalEnharmonicAlmostEqualTo { get; set; }

        [JsonProperty("accidentalEnharmonicEquals")]
        BoundingBox AccidentalEnharmonicEquals { get; set; }

        [JsonProperty("accidentalEnharmonicTilde")]
        BoundingBox AccidentalEnharmonicTilde { get; set; }

        [JsonProperty("accidentalFilledReversedFlatAndFlat")]
        BoundingBox AccidentalFilledReversedFlatAndFlat { get; set; }

        [JsonProperty("accidentalFilledReversedFlatAndFlatArrowDown")]
        BoundingBox AccidentalFilledReversedFlatAndFlatArrowDown { get; set; }

        [JsonProperty("accidentalFilledReversedFlatAndFlatArrowUp")]
        BoundingBox AccidentalFilledReversedFlatAndFlatArrowUp { get; set; }

        [JsonProperty("accidentalFilledReversedFlatArrowDown")]
        BoundingBox AccidentalFilledReversedFlatArrowDown { get; set; }

        [JsonProperty("accidentalFilledReversedFlatArrowUp")]
        BoundingBox AccidentalFilledReversedFlatArrowUp { get; set; }

        [JsonProperty("accidentalFiveQuarterTonesFlatArrowDown")]
        BoundingBox AccidentalFiveQuarterTonesFlatArrowDown { get; set; }

        [JsonProperty("accidentalFiveQuarterTonesSharpArrowUp")]
        BoundingBox AccidentalFiveQuarterTonesSharpArrowUp { get; set; }

        [JsonProperty("accidentalFlat")]
        BoundingBox AccidentalFlat { get; set; }

        [JsonProperty("accidentalFlatArabic")]
        BoundingBox AccidentalFlatArabic { get; set; }

        [JsonProperty("accidentalFlatEqualTempered")]
        BoundingBox AccidentalFlatEqualTempered { get; set; }

        [JsonProperty("accidentalFlatJohnstonDown")]
        BoundingBox AccidentalFlatJohnstonDown { get; set; }

        [JsonProperty("accidentalFlatJohnstonEl")]
        BoundingBox AccidentalFlatJohnstonEl { get; set; }

        [JsonProperty("accidentalFlatJohnstonElDown")]
        BoundingBox AccidentalFlatJohnstonElDown { get; set; }

        [JsonProperty("accidentalFlatJohnstonUp")]
        BoundingBox AccidentalFlatJohnstonUp { get; set; }

        [JsonProperty("accidentalFlatJohnstonUpEl")]
        BoundingBox AccidentalFlatJohnstonUpEl { get; set; }

        [JsonProperty("accidentalFlatLoweredStockhausen")]
        BoundingBox AccidentalFlatLoweredStockhausen { get; set; }

        [JsonProperty("accidentalFlatOneArrowDown")]
        BoundingBox AccidentalFlatOneArrowDown { get; set; }

        [JsonProperty("accidentalFlatOneArrowUp")]
        BoundingBox AccidentalFlatOneArrowUp { get; set; }

        [JsonProperty("accidentalFlatParens")]
        BoundingBox AccidentalFlatParens { get; set; }

        [JsonProperty("accidentalFlatRaisedStockhausen")]
        BoundingBox AccidentalFlatRaisedStockhausen { get; set; }

        [JsonProperty("accidentalFlatRepeatedLineStockhausen")]
        BoundingBox AccidentalFlatRepeatedLineStockhausen { get; set; }

        [JsonProperty("accidentalFlatRepeatedSpaceStockhausen")]
        BoundingBox AccidentalFlatRepeatedSpaceStockhausen { get; set; }

        [JsonProperty("accidentalFlatSmall")]
        BoundingBox AccidentalFlatSmall { get; set; }

        [JsonProperty("accidentalFlatThreeArrowsDown")]
        BoundingBox AccidentalFlatThreeArrowsDown { get; set; }

        [JsonProperty("accidentalFlatThreeArrowsUp")]
        BoundingBox AccidentalFlatThreeArrowsUp { get; set; }

        [JsonProperty("accidentalFlatTurned")]
        BoundingBox AccidentalFlatTurned { get; set; }

        [JsonProperty("accidentalFlatTwoArrowsDown")]
        BoundingBox AccidentalFlatTwoArrowsDown { get; set; }

        [JsonProperty("accidentalFlatTwoArrowsUp")]
        BoundingBox AccidentalFlatTwoArrowsUp { get; set; }

        [JsonProperty("accidentalHalfSharpArrowDown")]
        BoundingBox AccidentalHalfSharpArrowDown { get; set; }

        [JsonProperty("accidentalHalfSharpArrowUp")]
        BoundingBox AccidentalHalfSharpArrowUp { get; set; }

        [JsonProperty("accidentalJohnston13")]
        BoundingBox AccidentalJohnston13 { get; set; }

        [JsonProperty("accidentalJohnston31")]
        BoundingBox AccidentalJohnston31 { get; set; }

        [JsonProperty("accidentalJohnstonDown")]
        BoundingBox AccidentalJohnstonDown { get; set; }

        [JsonProperty("accidentalJohnstonDownEl")]
        BoundingBox AccidentalJohnstonDownEl { get; set; }

        [JsonProperty("accidentalJohnstonEl")]
        BoundingBox AccidentalJohnstonEl { get; set; }

        [JsonProperty("accidentalJohnstonMinus")]
        BoundingBox AccidentalJohnstonMinus { get; set; }

        [JsonProperty("accidentalJohnstonPlus")]
        BoundingBox AccidentalJohnstonPlus { get; set; }

        [JsonProperty("accidentalJohnstonSeven")]
        BoundingBox AccidentalJohnstonSeven { get; set; }

        [JsonProperty("accidentalJohnstonSevenDown")]
        BoundingBox AccidentalJohnstonSevenDown { get; set; }

        [JsonProperty("accidentalJohnstonSevenFlat")]
        BoundingBox AccidentalJohnstonSevenFlat { get; set; }

        [JsonProperty("accidentalJohnstonSevenFlatDown")]
        BoundingBox AccidentalJohnstonSevenFlatDown { get; set; }

        [JsonProperty("accidentalJohnstonSevenFlatUp")]
        BoundingBox AccidentalJohnstonSevenFlatUp { get; set; }

        [JsonProperty("accidentalJohnstonSevenSharp")]
        BoundingBox AccidentalJohnstonSevenSharp { get; set; }

        [JsonProperty("accidentalJohnstonSevenSharpDown")]
        BoundingBox AccidentalJohnstonSevenSharpDown { get; set; }

        [JsonProperty("accidentalJohnstonSevenSharpUp")]
        BoundingBox AccidentalJohnstonSevenSharpUp { get; set; }

        [JsonProperty("accidentalJohnstonSevenUp")]
        BoundingBox AccidentalJohnstonSevenUp { get; set; }

        [JsonProperty("accidentalJohnstonUp")]
        BoundingBox AccidentalJohnstonUp { get; set; }

        [JsonProperty("accidentalJohnstonUpEl")]
        BoundingBox AccidentalJohnstonUpEl { get; set; }

        [JsonProperty("accidentalKomaFlat")]
        BoundingBox AccidentalKomaFlat { get; set; }

        [JsonProperty("accidentalKomaSharp")]
        BoundingBox AccidentalKomaSharp { get; set; }

        [JsonProperty("accidentalKoron")]
        BoundingBox AccidentalKoron { get; set; }

        [JsonProperty("accidentalKucukMucennebFlat")]
        BoundingBox AccidentalKucukMucennebFlat { get; set; }

        [JsonProperty("accidentalKucukMucennebSharp")]
        BoundingBox AccidentalKucukMucennebSharp { get; set; }

        [JsonProperty("accidentalLargeDoubleSharp")]
        BoundingBox AccidentalLargeDoubleSharp { get; set; }

        [JsonProperty("accidentalLowerOneSeptimalComma")]
        BoundingBox AccidentalLowerOneSeptimalComma { get; set; }

        [JsonProperty("accidentalLowerOneTridecimalQuartertone")]
        BoundingBox AccidentalLowerOneTridecimalQuartertone { get; set; }

        [JsonProperty("accidentalLowerOneUndecimalQuartertone")]
        BoundingBox AccidentalLowerOneUndecimalQuartertone { get; set; }

        [JsonProperty("accidentalLowerTwoSeptimalCommas")]
        BoundingBox AccidentalLowerTwoSeptimalCommas { get; set; }

        [JsonProperty("accidentalLoweredStockhausen")]
        BoundingBox AccidentalLoweredStockhausen { get; set; }

        [JsonProperty("accidentalNarrowReversedFlat")]
        BoundingBox AccidentalNarrowReversedFlat { get; set; }

        [JsonProperty("accidentalNarrowReversedFlatAndFlat")]
        BoundingBox AccidentalNarrowReversedFlatAndFlat { get; set; }

        [JsonProperty("accidentalNatural")]
        BoundingBox AccidentalNatural { get; set; }

        [JsonProperty("accidentalNaturalArabic")]
        BoundingBox AccidentalNaturalArabic { get; set; }

        [JsonProperty("accidentalNaturalEqualTempered")]
        BoundingBox AccidentalNaturalEqualTempered { get; set; }

        [JsonProperty("accidentalNaturalFlat")]
        BoundingBox AccidentalNaturalFlat { get; set; }

        [JsonProperty("accidentalNaturalLoweredStockhausen")]
        BoundingBox AccidentalNaturalLoweredStockhausen { get; set; }

        [JsonProperty("accidentalNaturalOneArrowDown")]
        BoundingBox AccidentalNaturalOneArrowDown { get; set; }

        [JsonProperty("accidentalNaturalOneArrowUp")]
        BoundingBox AccidentalNaturalOneArrowUp { get; set; }

        [JsonProperty("accidentalNaturalParens")]
        BoundingBox AccidentalNaturalParens { get; set; }

        [JsonProperty("accidentalNaturalRaisedStockhausen")]
        BoundingBox AccidentalNaturalRaisedStockhausen { get; set; }

        [JsonProperty("accidentalNaturalReversed")]
        BoundingBox AccidentalNaturalReversed { get; set; }

        [JsonProperty("accidentalNaturalSharp")]
        BoundingBox AccidentalNaturalSharp { get; set; }

        [JsonProperty("accidentalNaturalSmall")]
        BoundingBox AccidentalNaturalSmall { get; set; }

        [JsonProperty("accidentalNaturalThreeArrowsDown")]
        BoundingBox AccidentalNaturalThreeArrowsDown { get; set; }

        [JsonProperty("accidentalNaturalThreeArrowsUp")]
        BoundingBox AccidentalNaturalThreeArrowsUp { get; set; }

        [JsonProperty("accidentalNaturalTwoArrowsDown")]
        BoundingBox AccidentalNaturalTwoArrowsDown { get; set; }

        [JsonProperty("accidentalNaturalTwoArrowsUp")]
        BoundingBox AccidentalNaturalTwoArrowsUp { get; set; }

        [JsonProperty("accidentalOneAndAHalfSharpsArrowDown")]
        BoundingBox AccidentalOneAndAHalfSharpsArrowDown { get; set; }

        [JsonProperty("accidentalOneAndAHalfSharpsArrowUp")]
        BoundingBox AccidentalOneAndAHalfSharpsArrowUp { get; set; }

        [JsonProperty("accidentalOneQuarterToneFlatFerneyhough")]
        BoundingBox AccidentalOneQuarterToneFlatFerneyhough { get; set; }

        [JsonProperty("accidentalOneQuarterToneFlatStockhausen")]
        BoundingBox AccidentalOneQuarterToneFlatStockhausen { get; set; }

        [JsonProperty("accidentalOneQuarterToneSharpFerneyhough")]
        BoundingBox AccidentalOneQuarterToneSharpFerneyhough { get; set; }

        [JsonProperty("accidentalOneQuarterToneSharpStockhausen")]
        BoundingBox AccidentalOneQuarterToneSharpStockhausen { get; set; }

        [JsonProperty("accidentalOneThirdToneFlatFerneyhough")]
        BoundingBox AccidentalOneThirdToneFlatFerneyhough { get; set; }

        [JsonProperty("accidentalOneThirdToneSharpFerneyhough")]
        BoundingBox AccidentalOneThirdToneSharpFerneyhough { get; set; }

        [JsonProperty("accidentalParensLeft")]
        BoundingBox AccidentalParensLeft { get; set; }

        [JsonProperty("accidentalParensRight")]
        BoundingBox AccidentalParensRight { get; set; }

        [JsonProperty("accidentalQuarterFlatEqualTempered")]
        BoundingBox AccidentalQuarterFlatEqualTempered { get; set; }

        [JsonProperty("accidentalQuarterSharpEqualTempered")]
        BoundingBox AccidentalQuarterSharpEqualTempered { get; set; }

        [JsonProperty("accidentalQuarterToneFlat4")]
        BoundingBox AccidentalQuarterToneFlat4 { get; set; }

        [JsonProperty("accidentalQuarterToneFlatArabic")]
        BoundingBox AccidentalQuarterToneFlatArabic { get; set; }

        [JsonProperty("accidentalQuarterToneFlatArrowUp")]
        BoundingBox AccidentalQuarterToneFlatArrowUp { get; set; }

        [JsonProperty("accidentalQuarterToneFlatFilledReversed")]
        BoundingBox AccidentalQuarterToneFlatFilledReversed { get; set; }

        [JsonProperty("accidentalQuarterToneFlatNaturalArrowDown")]
        BoundingBox AccidentalQuarterToneFlatNaturalArrowDown { get; set; }

        [JsonProperty("accidentalQuarterToneFlatPenderecki")]
        BoundingBox AccidentalQuarterToneFlatPenderecki { get; set; }

        [JsonProperty("accidentalQuarterToneFlatStein")]
        BoundingBox AccidentalQuarterToneFlatStein { get; set; }

        [JsonProperty("accidentalQuarterToneFlatVanBlankenburg")]
        BoundingBox AccidentalQuarterToneFlatVanBlankenburg { get; set; }

        [JsonProperty("accidentalQuarterToneSharp4")]
        BoundingBox AccidentalQuarterToneSharp4 { get; set; }

        [JsonProperty("accidentalQuarterToneSharpArabic")]
        BoundingBox AccidentalQuarterToneSharpArabic { get; set; }

        [JsonProperty("accidentalQuarterToneSharpArrowDown")]
        BoundingBox AccidentalQuarterToneSharpArrowDown { get; set; }

        [JsonProperty("accidentalQuarterToneSharpBusotti")]
        BoundingBox AccidentalQuarterToneSharpBusotti { get; set; }

        [JsonProperty("accidentalQuarterToneSharpNaturalArrowUp")]
        BoundingBox AccidentalQuarterToneSharpNaturalArrowUp { get; set; }

        [JsonProperty("accidentalQuarterToneSharpStein")]
        BoundingBox AccidentalQuarterToneSharpStein { get; set; }

        [JsonProperty("accidentalQuarterToneSharpWiggle")]
        BoundingBox AccidentalQuarterToneSharpWiggle { get; set; }

        [JsonProperty("accidentalRaiseOneSeptimalComma")]
        BoundingBox AccidentalRaiseOneSeptimalComma { get; set; }

        [JsonProperty("accidentalRaiseOneTridecimalQuartertone")]
        BoundingBox AccidentalRaiseOneTridecimalQuartertone { get; set; }

        [JsonProperty("accidentalRaiseOneUndecimalQuartertone")]
        BoundingBox AccidentalRaiseOneUndecimalQuartertone { get; set; }

        [JsonProperty("accidentalRaiseTwoSeptimalCommas")]
        BoundingBox AccidentalRaiseTwoSeptimalCommas { get; set; }

        [JsonProperty("accidentalRaisedStockhausen")]
        BoundingBox AccidentalRaisedStockhausen { get; set; }

        [JsonProperty("accidentalReversedFlatAndFlatArrowDown")]
        BoundingBox AccidentalReversedFlatAndFlatArrowDown { get; set; }

        [JsonProperty("accidentalReversedFlatAndFlatArrowUp")]
        BoundingBox AccidentalReversedFlatAndFlatArrowUp { get; set; }

        [JsonProperty("accidentalReversedFlatArrowDown")]
        BoundingBox AccidentalReversedFlatArrowDown { get; set; }

        [JsonProperty("accidentalReversedFlatArrowUp")]
        BoundingBox AccidentalReversedFlatArrowUp { get; set; }

        [JsonProperty("accidentalSharp")]
        BoundingBox AccidentalSharp { get; set; }

        [JsonProperty("accidentalSharpArabic")]
        BoundingBox AccidentalSharpArabic { get; set; }

        [JsonProperty("accidentalSharpEqualTempered")]
        BoundingBox AccidentalSharpEqualTempered { get; set; }

        [JsonProperty("accidentalSharpJohnstonDown")]
        BoundingBox AccidentalSharpJohnstonDown { get; set; }

        [JsonProperty("accidentalSharpJohnstonDownEl")]
        BoundingBox AccidentalSharpJohnstonDownEl { get; set; }

        [JsonProperty("accidentalSharpJohnstonEl")]
        BoundingBox AccidentalSharpJohnstonEl { get; set; }

        [JsonProperty("accidentalSharpJohnstonUp")]
        BoundingBox AccidentalSharpJohnstonUp { get; set; }

        [JsonProperty("accidentalSharpJohnstonUpEl")]
        BoundingBox AccidentalSharpJohnstonUpEl { get; set; }

        [JsonProperty("accidentalSharpLoweredStockhausen")]
        BoundingBox AccidentalSharpLoweredStockhausen { get; set; }

        [JsonProperty("accidentalSharpOneArrowDown")]
        BoundingBox AccidentalSharpOneArrowDown { get; set; }

        [JsonProperty("accidentalSharpOneArrowUp")]
        BoundingBox AccidentalSharpOneArrowUp { get; set; }

        [JsonProperty("accidentalSharpOneHorizontalStroke")]
        BoundingBox AccidentalSharpOneHorizontalStroke { get; set; }

        [JsonProperty("accidentalSharpParens")]
        BoundingBox AccidentalSharpParens { get; set; }

        [JsonProperty("accidentalSharpRaisedStockhausen")]
        BoundingBox AccidentalSharpRaisedStockhausen { get; set; }

        [JsonProperty("accidentalSharpRepeatedLineStockhausen")]
        BoundingBox AccidentalSharpRepeatedLineStockhausen { get; set; }

        [JsonProperty("accidentalSharpRepeatedSpaceStockhausen")]
        BoundingBox AccidentalSharpRepeatedSpaceStockhausen { get; set; }

        [JsonProperty("accidentalSharpReversed")]
        BoundingBox AccidentalSharpReversed { get; set; }

        [JsonProperty("accidentalSharpSharp")]
        BoundingBox AccidentalSharpSharp { get; set; }

        [JsonProperty("accidentalSharpSmall")]
        BoundingBox AccidentalSharpSmall { get; set; }

        [JsonProperty("accidentalSharpThreeArrowsDown")]
        BoundingBox AccidentalSharpThreeArrowsDown { get; set; }

        [JsonProperty("accidentalSharpThreeArrowsUp")]
        BoundingBox AccidentalSharpThreeArrowsUp { get; set; }

        [JsonProperty("accidentalSharpTwoArrowsDown")]
        BoundingBox AccidentalSharpTwoArrowsDown { get; set; }

        [JsonProperty("accidentalSharpTwoArrowsUp")]
        BoundingBox AccidentalSharpTwoArrowsUp { get; set; }

        [JsonProperty("accidentalSims12Down")]
        BoundingBox AccidentalSims12Down { get; set; }

        [JsonProperty("accidentalSims12Up")]
        BoundingBox AccidentalSims12Up { get; set; }

        [JsonProperty("accidentalSims4Down")]
        BoundingBox AccidentalSims4Down { get; set; }

        [JsonProperty("accidentalSims4Up")]
        BoundingBox AccidentalSims4Up { get; set; }

        [JsonProperty("accidentalSims6Down")]
        BoundingBox AccidentalSims6Down { get; set; }

        [JsonProperty("accidentalSims6Up")]
        BoundingBox AccidentalSims6Up { get; set; }

        [JsonProperty("accidentalSori")]
        BoundingBox AccidentalSori { get; set; }

        [JsonProperty("accidentalTavenerFlat")]
        BoundingBox AccidentalTavenerFlat { get; set; }

        [JsonProperty("accidentalTavenerSharp")]
        BoundingBox AccidentalTavenerSharp { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatArabic")]
        BoundingBox AccidentalThreeQuarterTonesFlatArabic { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatArrowDown")]
        BoundingBox AccidentalThreeQuarterTonesFlatArrowDown { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatArrowUp")]
        BoundingBox AccidentalThreeQuarterTonesFlatArrowUp { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatCouper")]
        BoundingBox AccidentalThreeQuarterTonesFlatCouper { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatGrisey")]
        BoundingBox AccidentalThreeQuarterTonesFlatGrisey { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatTartini")]
        BoundingBox AccidentalThreeQuarterTonesFlatTartini { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesFlatZimmermann")]
        BoundingBox AccidentalThreeQuarterTonesFlatZimmermann { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpArabic")]
        BoundingBox AccidentalThreeQuarterTonesSharpArabic { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpArrowDown")]
        BoundingBox AccidentalThreeQuarterTonesSharpArrowDown { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpArrowUp")]
        BoundingBox AccidentalThreeQuarterTonesSharpArrowUp { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpBusotti")]
        BoundingBox AccidentalThreeQuarterTonesSharpBusotti { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpStein")]
        BoundingBox AccidentalThreeQuarterTonesSharpStein { get; set; }

        [JsonProperty("accidentalThreeQuarterTonesSharpStockhausen")]
        BoundingBox AccidentalThreeQuarterTonesSharpStockhausen { get; set; }

        [JsonProperty("accidentalTripleFlat")]
        BoundingBox AccidentalTripleFlat { get; set; }

        [JsonProperty("accidentalTripleFlatJoinedStems")]
        BoundingBox AccidentalTripleFlatJoinedStems { get; set; }

        [JsonProperty("accidentalTripleSharp")]
        BoundingBox AccidentalTripleSharp { get; set; }

        [JsonProperty("accidentalTwoThirdTonesFlatFerneyhough")]
        BoundingBox AccidentalTwoThirdTonesFlatFerneyhough { get; set; }

        [JsonProperty("accidentalTwoThirdTonesSharpFerneyhough")]
        BoundingBox AccidentalTwoThirdTonesSharpFerneyhough { get; set; }

        [JsonProperty("accidentalWilsonMinus")]
        BoundingBox AccidentalWilsonMinus { get; set; }

        [JsonProperty("accidentalWilsonPlus")]
        BoundingBox AccidentalWilsonPlus { get; set; }

        [JsonProperty("accidentalWyschnegradsky10TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky10TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky10TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky10TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky11TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky11TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky11TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky11TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky1TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky1TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky1TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky1TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky2TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky2TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky2TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky2TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky3TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky3TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky3TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky3TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky4TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky4TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky4TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky4TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky5TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky5TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky5TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky5TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky6TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky6TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky6TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky6TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky7TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky7TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky7TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky7TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky8TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky8TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky8TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky8TwelfthsSharp { get; set; }

        [JsonProperty("accidentalWyschnegradsky9TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky9TwelfthsFlat { get; set; }

        [JsonProperty("accidentalWyschnegradsky9TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky9TwelfthsSharp { get; set; }

        [JsonProperty("accidentalXenakisOneThirdToneSharp")]
        BoundingBox AccidentalXenakisOneThirdToneSharp { get; set; }

        [JsonProperty("accidentalXenakisTwoThirdTonesSharp")]
        BoundingBox AccidentalXenakisTwoThirdTonesSharp { get; set; }

        [JsonProperty("analyticsChoralmelodie")]
        BoundingBox AnalyticsChoralmelodie { get; set; }

        [JsonProperty("analyticsEndStimme")]
        BoundingBox AnalyticsEndStimme { get; set; }

        [JsonProperty("analyticsHauptrhythmus")]
        BoundingBox AnalyticsHauptrhythmus { get; set; }

        [JsonProperty("analyticsHauptrhythmusR")]
        BoundingBox AnalyticsHauptrhythmusR { get; set; }

        [JsonProperty("analyticsHauptstimme")]
        BoundingBox AnalyticsHauptstimme { get; set; }

        [JsonProperty("analyticsInversion1")]
        BoundingBox AnalyticsInversion1 { get; set; }

        [JsonProperty("analyticsNebenstimme")]
        BoundingBox AnalyticsNebenstimme { get; set; }

        [JsonProperty("analyticsStartStimme")]
        BoundingBox AnalyticsStartStimme { get; set; }

        [JsonProperty("analyticsTheme")]
        BoundingBox AnalyticsTheme { get; set; }

        [JsonProperty("analyticsTheme1")]
        BoundingBox AnalyticsTheme1 { get; set; }

        [JsonProperty("analyticsThemeInversion")]
        BoundingBox AnalyticsThemeInversion { get; set; }

        [JsonProperty("analyticsThemeRetrograde")]
        BoundingBox AnalyticsThemeRetrograde { get; set; }

        [JsonProperty("analyticsThemeRetrogradeInversion")]
        BoundingBox AnalyticsThemeRetrogradeInversion { get; set; }

        [JsonProperty("arpeggiatoDown")]
        BoundingBox ArpeggiatoDown { get; set; }

        [JsonProperty("arpeggiatoUp")]
        BoundingBox ArpeggiatoUp { get; set; }

        [JsonProperty("arrowBlackDown")]
        BoundingBox ArrowBlackDown { get; set; }

        [JsonProperty("arrowBlackDownLeft")]
        BoundingBox ArrowBlackDownLeft { get; set; }

        [JsonProperty("arrowBlackDownRight")]
        BoundingBox ArrowBlackDownRight { get; set; }

        [JsonProperty("arrowBlackLeft")]
        BoundingBox ArrowBlackLeft { get; set; }

        [JsonProperty("arrowBlackRight")]
        BoundingBox ArrowBlackRight { get; set; }

        [JsonProperty("arrowBlackUp")]
        BoundingBox ArrowBlackUp { get; set; }

        [JsonProperty("arrowBlackUpLeft")]
        BoundingBox ArrowBlackUpLeft { get; set; }

        [JsonProperty("arrowBlackUpRight")]
        BoundingBox ArrowBlackUpRight { get; set; }

        [JsonProperty("arrowOpenDown")]
        BoundingBox ArrowOpenDown { get; set; }

        [JsonProperty("arrowOpenDownLeft")]
        BoundingBox ArrowOpenDownLeft { get; set; }

        [JsonProperty("arrowOpenDownRight")]
        BoundingBox ArrowOpenDownRight { get; set; }

        [JsonProperty("arrowOpenLeft")]
        BoundingBox ArrowOpenLeft { get; set; }

        [JsonProperty("arrowOpenRight")]
        BoundingBox ArrowOpenRight { get; set; }

        [JsonProperty("arrowOpenUp")]
        BoundingBox ArrowOpenUp { get; set; }

        [JsonProperty("arrowOpenUpLeft")]
        BoundingBox ArrowOpenUpLeft { get; set; }

        [JsonProperty("arrowOpenUpRight")]
        BoundingBox ArrowOpenUpRight { get; set; }

        [JsonProperty("arrowWhiteDown")]
        BoundingBox ArrowWhiteDown { get; set; }

        [JsonProperty("arrowWhiteDownLeft")]
        BoundingBox ArrowWhiteDownLeft { get; set; }

        [JsonProperty("arrowWhiteDownRight")]
        BoundingBox ArrowWhiteDownRight { get; set; }

        [JsonProperty("arrowWhiteLeft")]
        BoundingBox ArrowWhiteLeft { get; set; }

        [JsonProperty("arrowWhiteRight")]
        BoundingBox ArrowWhiteRight { get; set; }

        [JsonProperty("arrowWhiteUp")]
        BoundingBox ArrowWhiteUp { get; set; }

        [JsonProperty("arrowWhiteUpLeft")]
        BoundingBox ArrowWhiteUpLeft { get; set; }

        [JsonProperty("arrowWhiteUpRight")]
        BoundingBox ArrowWhiteUpRight { get; set; }

        [JsonProperty("arrowheadBlackDown")]
        BoundingBox ArrowheadBlackDown { get; set; }

        [JsonProperty("arrowheadBlackDownLeft")]
        BoundingBox ArrowheadBlackDownLeft { get; set; }

        [JsonProperty("arrowheadBlackDownRight")]
        BoundingBox ArrowheadBlackDownRight { get; set; }

        [JsonProperty("arrowheadBlackLeft")]
        BoundingBox ArrowheadBlackLeft { get; set; }

        [JsonProperty("arrowheadBlackRight")]
        BoundingBox ArrowheadBlackRight { get; set; }

        [JsonProperty("arrowheadBlackUp")]
        BoundingBox ArrowheadBlackUp { get; set; }

        [JsonProperty("arrowheadBlackUpLeft")]
        BoundingBox ArrowheadBlackUpLeft { get; set; }

        [JsonProperty("arrowheadBlackUpRight")]
        BoundingBox ArrowheadBlackUpRight { get; set; }

        [JsonProperty("arrowheadOpenDown")]
        BoundingBox ArrowheadOpenDown { get; set; }

        [JsonProperty("arrowheadOpenDownLeft")]
        BoundingBox ArrowheadOpenDownLeft { get; set; }

        [JsonProperty("arrowheadOpenDownRight")]
        BoundingBox ArrowheadOpenDownRight { get; set; }

        [JsonProperty("arrowheadOpenLeft")]
        BoundingBox ArrowheadOpenLeft { get; set; }

        [JsonProperty("arrowheadOpenRight")]
        BoundingBox ArrowheadOpenRight { get; set; }

        [JsonProperty("arrowheadOpenUp")]
        BoundingBox ArrowheadOpenUp { get; set; }

        [JsonProperty("arrowheadOpenUpLeft")]
        BoundingBox ArrowheadOpenUpLeft { get; set; }

        [JsonProperty("arrowheadOpenUpRight")]
        BoundingBox ArrowheadOpenUpRight { get; set; }

        [JsonProperty("arrowheadWhiteDown")]
        BoundingBox ArrowheadWhiteDown { get; set; }

        [JsonProperty("arrowheadWhiteDownLeft")]
        BoundingBox ArrowheadWhiteDownLeft { get; set; }

        [JsonProperty("arrowheadWhiteDownRight")]
        BoundingBox ArrowheadWhiteDownRight { get; set; }

        [JsonProperty("arrowheadWhiteLeft")]
        BoundingBox ArrowheadWhiteLeft { get; set; }

        [JsonProperty("arrowheadWhiteRight")]
        BoundingBox ArrowheadWhiteRight { get; set; }

        [JsonProperty("arrowheadWhiteUp")]
        BoundingBox ArrowheadWhiteUp { get; set; }

        [JsonProperty("arrowheadWhiteUpLeft")]
        BoundingBox ArrowheadWhiteUpLeft { get; set; }

        [JsonProperty("arrowheadWhiteUpRight")]
        BoundingBox ArrowheadWhiteUpRight { get; set; }

        [JsonProperty("articAccentAbove")]
        BoundingBox ArticAccentAbove { get; set; }

        [JsonProperty("articAccentAboveLarge")]
        BoundingBox ArticAccentAboveLarge { get; set; }

        [JsonProperty("articAccentAboveSmall")]
        BoundingBox ArticAccentAboveSmall { get; set; }

        [JsonProperty("articAccentBelow")]
        BoundingBox ArticAccentBelow { get; set; }

        [JsonProperty("articAccentBelowLarge")]
        BoundingBox ArticAccentBelowLarge { get; set; }

        [JsonProperty("articAccentBelowSmall")]
        BoundingBox ArticAccentBelowSmall { get; set; }

        [JsonProperty("articAccentStaccatoAbove")]
        BoundingBox ArticAccentStaccatoAbove { get; set; }

        [JsonProperty("articAccentStaccatoAboveSmall")]
        BoundingBox ArticAccentStaccatoAboveSmall { get; set; }

        [JsonProperty("articAccentStaccatoBelow")]
        BoundingBox ArticAccentStaccatoBelow { get; set; }

        [JsonProperty("articAccentStaccatoBelowSmall")]
        BoundingBox ArticAccentStaccatoBelowSmall { get; set; }

        [JsonProperty("articLaissezVibrerAbove")]
        BoundingBox ArticLaissezVibrerAbove { get; set; }

        [JsonProperty("articLaissezVibrerBelow")]
        BoundingBox ArticLaissezVibrerBelow { get; set; }

        [JsonProperty("articMarcatoAbove")]
        BoundingBox ArticMarcatoAbove { get; set; }

        [JsonProperty("articMarcatoAboveSmall")]
        BoundingBox ArticMarcatoAboveSmall { get; set; }

        [JsonProperty("articMarcatoBelow")]
        BoundingBox ArticMarcatoBelow { get; set; }

        [JsonProperty("articMarcatoBelowSmall")]
        BoundingBox ArticMarcatoBelowSmall { get; set; }

        [JsonProperty("articMarcatoStaccatoAbove")]
        BoundingBox ArticMarcatoStaccatoAbove { get; set; }

        [JsonProperty("articMarcatoStaccatoAboveSmall")]
        BoundingBox ArticMarcatoStaccatoAboveSmall { get; set; }

        [JsonProperty("articMarcatoStaccatoBelow")]
        BoundingBox ArticMarcatoStaccatoBelow { get; set; }

        [JsonProperty("articMarcatoStaccatoBelowSmall")]
        BoundingBox ArticMarcatoStaccatoBelowSmall { get; set; }

        [JsonProperty("articMarcatoTenutoAbove")]
        BoundingBox ArticMarcatoTenutoAbove { get; set; }

        [JsonProperty("articMarcatoTenutoBelow")]
        BoundingBox ArticMarcatoTenutoBelow { get; set; }

        [JsonProperty("articSoftAccentAbove")]
        BoundingBox ArticSoftAccentAbove { get; set; }

        [JsonProperty("articSoftAccentBelow")]
        BoundingBox ArticSoftAccentBelow { get; set; }

        [JsonProperty("articSoftAccentStaccatoAbove")]
        BoundingBox ArticSoftAccentStaccatoAbove { get; set; }

        [JsonProperty("articSoftAccentStaccatoBelow")]
        BoundingBox ArticSoftAccentStaccatoBelow { get; set; }

        [JsonProperty("articSoftAccentTenutoAbove")]
        BoundingBox ArticSoftAccentTenutoAbove { get; set; }

        [JsonProperty("articSoftAccentTenutoBelow")]
        BoundingBox ArticSoftAccentTenutoBelow { get; set; }

        [JsonProperty("articSoftAccentTenutoStaccatoAbove")]
        BoundingBox ArticSoftAccentTenutoStaccatoAbove { get; set; }

        [JsonProperty("articSoftAccentTenutoStaccatoBelow")]
        BoundingBox ArticSoftAccentTenutoStaccatoBelow { get; set; }

        [JsonProperty("articStaccatissimoAbove")]
        BoundingBox ArticStaccatissimoAbove { get; set; }

        [JsonProperty("articStaccatissimoAboveSmall")]
        BoundingBox ArticStaccatissimoAboveSmall { get; set; }

        [JsonProperty("articStaccatissimoBelow")]
        BoundingBox ArticStaccatissimoBelow { get; set; }

        [JsonProperty("articStaccatissimoBelowSmall")]
        BoundingBox ArticStaccatissimoBelowSmall { get; set; }

        [JsonProperty("articStaccatissimoStrokeAbove")]
        BoundingBox ArticStaccatissimoStrokeAbove { get; set; }

        [JsonProperty("articStaccatissimoStrokeAboveSmall")]
        BoundingBox ArticStaccatissimoStrokeAboveSmall { get; set; }

        [JsonProperty("articStaccatissimoStrokeBelow")]
        BoundingBox ArticStaccatissimoStrokeBelow { get; set; }

        [JsonProperty("articStaccatissimoStrokeBelowSmall")]
        BoundingBox ArticStaccatissimoStrokeBelowSmall { get; set; }

        [JsonProperty("articStaccatissimoWedgeAbove")]
        BoundingBox ArticStaccatissimoWedgeAbove { get; set; }

        [JsonProperty("articStaccatissimoWedgeAboveSmall")]
        BoundingBox ArticStaccatissimoWedgeAboveSmall { get; set; }

        [JsonProperty("articStaccatissimoWedgeBelow")]
        BoundingBox ArticStaccatissimoWedgeBelow { get; set; }

        [JsonProperty("articStaccatissimoWedgeBelowSmall")]
        BoundingBox ArticStaccatissimoWedgeBelowSmall { get; set; }

        [JsonProperty("articStaccatoAbove")]
        BoundingBox ArticStaccatoAbove { get; set; }

        [JsonProperty("articStaccatoAboveSmall")]
        BoundingBox ArticStaccatoAboveSmall { get; set; }

        [JsonProperty("articStaccatoBelow")]
        BoundingBox ArticStaccatoBelow { get; set; }

        [JsonProperty("articStaccatoBelowSmall")]
        BoundingBox ArticStaccatoBelowSmall { get; set; }

        [JsonProperty("articStressAbove")]
        BoundingBox ArticStressAbove { get; set; }

        [JsonProperty("articStressBelow")]
        BoundingBox ArticStressBelow { get; set; }

        [JsonProperty("articTenutoAbove")]
        BoundingBox ArticTenutoAbove { get; set; }

        [JsonProperty("articTenutoAboveSmall")]
        BoundingBox ArticTenutoAboveSmall { get; set; }

        [JsonProperty("articTenutoAccentAbove")]
        BoundingBox ArticTenutoAccentAbove { get; set; }

        [JsonProperty("articTenutoAccentAboveSmall")]
        BoundingBox ArticTenutoAccentAboveSmall { get; set; }

        [JsonProperty("articTenutoAccentBelow")]
        BoundingBox ArticTenutoAccentBelow { get; set; }

        [JsonProperty("articTenutoAccentBelowSmall")]
        BoundingBox ArticTenutoAccentBelowSmall { get; set; }

        [JsonProperty("articTenutoBelow")]
        BoundingBox ArticTenutoBelow { get; set; }

        [JsonProperty("articTenutoBelowSmall")]
        BoundingBox ArticTenutoBelowSmall { get; set; }

        [JsonProperty("articTenutoStaccatoAbove")]
        BoundingBox ArticTenutoStaccatoAbove { get; set; }

        [JsonProperty("articTenutoStaccatoAboveSmall")]
        BoundingBox ArticTenutoStaccatoAboveSmall { get; set; }

        [JsonProperty("articTenutoStaccatoBelow")]
        BoundingBox ArticTenutoStaccatoBelow { get; set; }

        [JsonProperty("articTenutoStaccatoBelowSmall")]
        BoundingBox ArticTenutoStaccatoBelowSmall { get; set; }

        [JsonProperty("articUnstressAbove")]
        BoundingBox ArticUnstressAbove { get; set; }

        [JsonProperty("articUnstressBelow")]
        BoundingBox ArticUnstressBelow { get; set; }

        [JsonProperty("augmentationDot")]
        BoundingBox AugmentationDot { get; set; }

        [JsonProperty("barlineDashed")]
        BoundingBox BarlineDashed { get; set; }

        [JsonProperty("barlineDotted")]
        BoundingBox BarlineDotted { get; set; }

        [JsonProperty("barlineDouble")]
        BoundingBox BarlineDouble { get; set; }

        [JsonProperty("barlineFinal")]
        BoundingBox BarlineFinal { get; set; }

        [JsonProperty("barlineHeavy")]
        BoundingBox BarlineHeavy { get; set; }

        [JsonProperty("barlineHeavyHeavy")]
        BoundingBox BarlineHeavyHeavy { get; set; }

        [JsonProperty("barlineReverseFinal")]
        BoundingBox BarlineReverseFinal { get; set; }

        [JsonProperty("barlineShort")]
        BoundingBox BarlineShort { get; set; }

        [JsonProperty("barlineSingle")]
        BoundingBox BarlineSingle { get; set; }

        [JsonProperty("barlineTick")]
        BoundingBox BarlineTick { get; set; }

        [JsonProperty("beamAccelRit1")]
        BoundingBox BeamAccelRit1 { get; set; }

        [JsonProperty("beamAccelRit10")]
        BoundingBox BeamAccelRit10 { get; set; }

        [JsonProperty("beamAccelRit11")]
        BoundingBox BeamAccelRit11 { get; set; }

        [JsonProperty("beamAccelRit12")]
        BoundingBox BeamAccelRit12 { get; set; }

        [JsonProperty("beamAccelRit13")]
        BoundingBox BeamAccelRit13 { get; set; }

        [JsonProperty("beamAccelRit14")]
        BoundingBox BeamAccelRit14 { get; set; }

        [JsonProperty("beamAccelRit15")]
        BoundingBox BeamAccelRit15 { get; set; }

        [JsonProperty("beamAccelRit2")]
        BoundingBox BeamAccelRit2 { get; set; }

        [JsonProperty("beamAccelRit3")]
        BoundingBox BeamAccelRit3 { get; set; }

        [JsonProperty("beamAccelRit4")]
        BoundingBox BeamAccelRit4 { get; set; }

        [JsonProperty("beamAccelRit5")]
        BoundingBox BeamAccelRit5 { get; set; }

        [JsonProperty("beamAccelRit6")]
        BoundingBox BeamAccelRit6 { get; set; }

        [JsonProperty("beamAccelRit7")]
        BoundingBox BeamAccelRit7 { get; set; }

        [JsonProperty("beamAccelRit8")]
        BoundingBox BeamAccelRit8 { get; set; }

        [JsonProperty("beamAccelRit9")]
        BoundingBox BeamAccelRit9 { get; set; }

        [JsonProperty("beamAccelRitFinal")]
        BoundingBox BeamAccelRitFinal { get; set; }

        [JsonProperty("brace")]
        BoundingBox Brace { get; set; }

        [JsonProperty("braceFlat")]
        BoundingBox BraceFlat { get; set; }

        [JsonProperty("braceLarge")]
        BoundingBox BraceLarge { get; set; }

        [JsonProperty("braceLarger")]
        BoundingBox BraceLarger { get; set; }

        [JsonProperty("braceSmall")]
        BoundingBox BraceSmall { get; set; }

        [JsonProperty("bracket")]
        BoundingBox Bracket { get; set; }

        [JsonProperty("bracketBottom")]
        BoundingBox BracketBottom { get; set; }

        [JsonProperty("bracketTop")]
        BoundingBox BracketTop { get; set; }

        [JsonProperty("brassBend")]
        BoundingBox BrassBend { get; set; }

        [JsonProperty("brassDoitLong")]
        BoundingBox BrassDoitLong { get; set; }

        [JsonProperty("brassDoitMedium")]
        BoundingBox BrassDoitMedium { get; set; }

        [JsonProperty("brassDoitShort")]
        BoundingBox BrassDoitShort { get; set; }

        [JsonProperty("brassFallLipLong")]
        BoundingBox BrassFallLipLong { get; set; }

        [JsonProperty("brassFallLipMedium")]
        BoundingBox BrassFallLipMedium { get; set; }

        [JsonProperty("brassFallLipShort")]
        BoundingBox BrassFallLipShort { get; set; }

        [JsonProperty("brassFallRoughLong")]
        BoundingBox BrassFallRoughLong { get; set; }

        [JsonProperty("brassFallRoughMedium")]
        BoundingBox BrassFallRoughMedium { get; set; }

        [JsonProperty("brassFallRoughShort")]
        BoundingBox BrassFallRoughShort { get; set; }

        [JsonProperty("brassFallSmoothLong")]
        BoundingBox BrassFallSmoothLong { get; set; }

        [JsonProperty("brassFallSmoothMedium")]
        BoundingBox BrassFallSmoothMedium { get; set; }

        [JsonProperty("brassFallSmoothShort")]
        BoundingBox BrassFallSmoothShort { get; set; }

        [JsonProperty("brassFlip")]
        BoundingBox BrassFlip { get; set; }

        [JsonProperty("brassHarmonMuteClosed")]
        BoundingBox BrassHarmonMuteClosed { get; set; }

        [JsonProperty("brassHarmonMuteStemHalfLeft")]
        BoundingBox BrassHarmonMuteStemHalfLeft { get; set; }

        [JsonProperty("brassHarmonMuteStemHalfRight")]
        BoundingBox BrassHarmonMuteStemHalfRight { get; set; }

        [JsonProperty("brassHarmonMuteStemOpen")]
        BoundingBox BrassHarmonMuteStemOpen { get; set; }

        [JsonProperty("brassJazzTurn")]
        BoundingBox BrassJazzTurn { get; set; }

        [JsonProperty("brassLiftLong")]
        BoundingBox BrassLiftLong { get; set; }

        [JsonProperty("brassLiftMedium")]
        BoundingBox BrassLiftMedium { get; set; }

        [JsonProperty("brassLiftShort")]
        BoundingBox BrassLiftShort { get; set; }

        [JsonProperty("brassLiftSmoothLong")]
        BoundingBox BrassLiftSmoothLong { get; set; }

        [JsonProperty("brassLiftSmoothMedium")]
        BoundingBox BrassLiftSmoothMedium { get; set; }

        [JsonProperty("brassLiftSmoothShort")]
        BoundingBox BrassLiftSmoothShort { get; set; }

        [JsonProperty("brassMuteClosed")]
        BoundingBox BrassMuteClosed { get; set; }

        [JsonProperty("brassMuteHalfClosed")]
        BoundingBox BrassMuteHalfClosed { get; set; }

        [JsonProperty("brassMuteOpen")]
        BoundingBox BrassMuteOpen { get; set; }

        [JsonProperty("brassPlop")]
        BoundingBox BrassPlop { get; set; }

        [JsonProperty("brassScoop")]
        BoundingBox BrassScoop { get; set; }

        [JsonProperty("brassSmear")]
        BoundingBox BrassSmear { get; set; }

        [JsonProperty("brassValveTrill")]
        BoundingBox BrassValveTrill { get; set; }

        [JsonProperty("breathMarkComma")]
        BoundingBox BreathMarkComma { get; set; }

        [JsonProperty("breathMarkSalzedo")]
        BoundingBox BreathMarkSalzedo { get; set; }

        [JsonProperty("breathMarkTick")]
        BoundingBox BreathMarkTick { get; set; }

        [JsonProperty("breathMarkUpbow")]
        BoundingBox BreathMarkUpbow { get; set; }

        [JsonProperty("bridgeClef")]
        BoundingBox BridgeClef { get; set; }

        [JsonProperty("buzzRoll")]
        BoundingBox BuzzRoll { get; set; }

        [JsonProperty("cClef")]
        BoundingBox CClef { get; set; }

        [JsonProperty("cClef8vb")]
        BoundingBox CClef8Vb { get; set; }

        [JsonProperty("cClefArrowDown")]
        BoundingBox CClefArrowDown { get; set; }

        [JsonProperty("cClefArrowUp")]
        BoundingBox CClefArrowUp { get; set; }

        [JsonProperty("cClefChange")]
        BoundingBox CClefChange { get; set; }

        [JsonProperty("cClefCombining")]
        BoundingBox CClefCombining { get; set; }

        [JsonProperty("cClefFrench")]
        BoundingBox CClefFrench { get; set; }

        [JsonProperty("cClefFrench20C")]
        BoundingBox CClefFrench20C { get; set; }

        [JsonProperty("cClefFrench20CChange")]
        BoundingBox CClefFrench20CChange { get; set; }

        [JsonProperty("cClefReversed")]
        BoundingBox CClefReversed { get; set; }

        [JsonProperty("cClefSmall")]
        BoundingBox CClefSmall { get; set; }

        [JsonProperty("cClefSquare")]
        BoundingBox CClefSquare { get; set; }

        [JsonProperty("caesura")]
        BoundingBox Caesura { get; set; }

        [JsonProperty("caesuraCurved")]
        BoundingBox CaesuraCurved { get; set; }

        [JsonProperty("caesuraShort")]
        BoundingBox CaesuraShort { get; set; }

        [JsonProperty("caesuraSingleStroke")]
        BoundingBox CaesuraSingleStroke { get; set; }

        [JsonProperty("caesuraThick")]
        BoundingBox CaesuraThick { get; set; }

        [JsonProperty("chantAccentusAbove")]
        BoundingBox ChantAccentusAbove { get; set; }

        [JsonProperty("chantAccentusBelow")]
        BoundingBox ChantAccentusBelow { get; set; }

        [JsonProperty("chantAuctumAsc")]
        BoundingBox ChantAuctumAsc { get; set; }

        [JsonProperty("chantAuctumDesc")]
        BoundingBox ChantAuctumDesc { get; set; }

        [JsonProperty("chantAugmentum")]
        BoundingBox ChantAugmentum { get; set; }

        [JsonProperty("chantCaesura")]
        BoundingBox ChantCaesura { get; set; }

        [JsonProperty("chantCclef")]
        BoundingBox ChantCclef { get; set; }

        [JsonProperty("chantCclefHufnagel")]
        BoundingBox ChantCclefHufnagel { get; set; }

        [JsonProperty("chantCirculusAbove")]
        BoundingBox ChantCirculusAbove { get; set; }

        [JsonProperty("chantCirculusBelow")]
        BoundingBox ChantCirculusBelow { get; set; }

        [JsonProperty("chantConnectingLineAsc2nd")]
        BoundingBox ChantConnectingLineAsc2Nd { get; set; }

        [JsonProperty("chantConnectingLineAsc3rd")]
        BoundingBox ChantConnectingLineAsc3Rd { get; set; }

        [JsonProperty("chantConnectingLineAsc4th")]
        BoundingBox ChantConnectingLineAsc4Th { get; set; }

        [JsonProperty("chantConnectingLineAsc5th")]
        BoundingBox ChantConnectingLineAsc5Th { get; set; }

        [JsonProperty("chantConnectingLineAsc6th")]
        BoundingBox ChantConnectingLineAsc6Th { get; set; }

        [JsonProperty("chantCustosStemDownPosHigh")]
        BoundingBox ChantCustosStemDownPosHigh { get; set; }

        [JsonProperty("chantCustosStemDownPosHighest")]
        BoundingBox ChantCustosStemDownPosHighest { get; set; }

        [JsonProperty("chantCustosStemDownPosMiddle")]
        BoundingBox ChantCustosStemDownPosMiddle { get; set; }

        [JsonProperty("chantCustosStemUpPosLow")]
        BoundingBox ChantCustosStemUpPosLow { get; set; }

        [JsonProperty("chantCustosStemUpPosLowest")]
        BoundingBox ChantCustosStemUpPosLowest { get; set; }

        [JsonProperty("chantCustosStemUpPosMiddle")]
        BoundingBox ChantCustosStemUpPosMiddle { get; set; }

        [JsonProperty("chantDeminutumLower")]
        BoundingBox ChantDeminutumLower { get; set; }

        [JsonProperty("chantDeminutumUpper")]
        BoundingBox ChantDeminutumUpper { get; set; }

        [JsonProperty("chantDivisioFinalis")]
        BoundingBox ChantDivisioFinalis { get; set; }

        [JsonProperty("chantDivisioMaior")]
        BoundingBox ChantDivisioMaior { get; set; }

        [JsonProperty("chantDivisioMaxima")]
        BoundingBox ChantDivisioMaxima { get; set; }

        [JsonProperty("chantDivisioMinima")]
        BoundingBox ChantDivisioMinima { get; set; }

        [JsonProperty("chantEntryLineAsc2nd")]
        BoundingBox ChantEntryLineAsc2Nd { get; set; }

        [JsonProperty("chantEntryLineAsc3rd")]
        BoundingBox ChantEntryLineAsc3Rd { get; set; }

        [JsonProperty("chantEntryLineAsc4th")]
        BoundingBox ChantEntryLineAsc4Th { get; set; }

        [JsonProperty("chantEntryLineAsc5th")]
        BoundingBox ChantEntryLineAsc5Th { get; set; }

        [JsonProperty("chantEntryLineAsc6th")]
        BoundingBox ChantEntryLineAsc6Th { get; set; }

        [JsonProperty("chantEpisema")]
        BoundingBox ChantEpisema { get; set; }

        [JsonProperty("chantFclef")]
        BoundingBox ChantFclef { get; set; }

        [JsonProperty("chantFclefHufnagel")]
        BoundingBox ChantFclefHufnagel { get; set; }

        [JsonProperty("chantIctusAbove")]
        BoundingBox ChantIctusAbove { get; set; }

        [JsonProperty("chantIctusBelow")]
        BoundingBox ChantIctusBelow { get; set; }

        [JsonProperty("chantLigaturaDesc2nd")]
        BoundingBox ChantLigaturaDesc2Nd { get; set; }

        [JsonProperty("chantLigaturaDesc3rd")]
        BoundingBox ChantLigaturaDesc3Rd { get; set; }

        [JsonProperty("chantLigaturaDesc4th")]
        BoundingBox ChantLigaturaDesc4Th { get; set; }

        [JsonProperty("chantLigaturaDesc5th")]
        BoundingBox ChantLigaturaDesc5Th { get; set; }

        [JsonProperty("chantOriscusAscending")]
        BoundingBox ChantOriscusAscending { get; set; }

        [JsonProperty("chantOriscusDescending")]
        BoundingBox ChantOriscusDescending { get; set; }

        [JsonProperty("chantOriscusLiquescens")]
        BoundingBox ChantOriscusLiquescens { get; set; }

        [JsonProperty("chantPodatusLower")]
        BoundingBox ChantPodatusLower { get; set; }

        [JsonProperty("chantPodatusUpper")]
        BoundingBox ChantPodatusUpper { get; set; }

        [JsonProperty("chantPunctum")]
        BoundingBox ChantPunctum { get; set; }

        [JsonProperty("chantPunctumCavum")]
        BoundingBox ChantPunctumCavum { get; set; }

        [JsonProperty("chantPunctumDeminutum")]
        BoundingBox ChantPunctumDeminutum { get; set; }

        [JsonProperty("chantPunctumInclinatum")]
        BoundingBox ChantPunctumInclinatum { get; set; }

        [JsonProperty("chantPunctumInclinatumAuctum")]
        BoundingBox ChantPunctumInclinatumAuctum { get; set; }

        [JsonProperty("chantPunctumInclinatumDeminutum")]
        BoundingBox ChantPunctumInclinatumDeminutum { get; set; }

        [JsonProperty("chantPunctumLinea")]
        BoundingBox ChantPunctumLinea { get; set; }

        [JsonProperty("chantPunctumLineaCavum")]
        BoundingBox ChantPunctumLineaCavum { get; set; }

        [JsonProperty("chantPunctumVirga")]
        BoundingBox ChantPunctumVirga { get; set; }

        [JsonProperty("chantPunctumVirgaReversed")]
        BoundingBox ChantPunctumVirgaReversed { get; set; }

        [JsonProperty("chantQuilisma")]
        BoundingBox ChantQuilisma { get; set; }

        [JsonProperty("chantSemicirculusAbove")]
        BoundingBox ChantSemicirculusAbove { get; set; }

        [JsonProperty("chantSemicirculusBelow")]
        BoundingBox ChantSemicirculusBelow { get; set; }

        [JsonProperty("chantStaff")]
        BoundingBox ChantStaff { get; set; }

        [JsonProperty("chantStaffNarrow")]
        BoundingBox ChantStaffNarrow { get; set; }

        [JsonProperty("chantStaffWide")]
        BoundingBox ChantStaffWide { get; set; }

        [JsonProperty("chantStrophicus")]
        BoundingBox ChantStrophicus { get; set; }

        [JsonProperty("chantStrophicusAuctus")]
        BoundingBox ChantStrophicusAuctus { get; set; }

        [JsonProperty("chantStrophicusLiquescens2nd")]
        BoundingBox ChantStrophicusLiquescens2Nd { get; set; }

        [JsonProperty("chantStrophicusLiquescens3rd")]
        BoundingBox ChantStrophicusLiquescens3Rd { get; set; }

        [JsonProperty("chantStrophicusLiquescens4th")]
        BoundingBox ChantStrophicusLiquescens4Th { get; set; }

        [JsonProperty("chantStrophicusLiquescens5th")]
        BoundingBox ChantStrophicusLiquescens5Th { get; set; }

        [JsonProperty("chantVirgula")]
        BoundingBox ChantVirgula { get; set; }

        [JsonProperty("clef15")]
        BoundingBox Clef15 { get; set; }

        [JsonProperty("clef8")]
        BoundingBox Clef8 { get; set; }

        [JsonProperty("coda")]
        BoundingBox Coda { get; set; }

        [JsonProperty("codaJapanese")]
        BoundingBox CodaJapanese { get; set; }

        [JsonProperty("codaSquare")]
        BoundingBox CodaSquare { get; set; }

        [JsonProperty("conductorBeat2Compound")]
        BoundingBox ConductorBeat2Compound { get; set; }

        [JsonProperty("conductorBeat2Simple")]
        BoundingBox ConductorBeat2Simple { get; set; }

        [JsonProperty("conductorBeat3Compound")]
        BoundingBox ConductorBeat3Compound { get; set; }

        [JsonProperty("conductorBeat3Simple")]
        BoundingBox ConductorBeat3Simple { get; set; }

        [JsonProperty("conductorBeat4Compound")]
        BoundingBox ConductorBeat4Compound { get; set; }

        [JsonProperty("conductorBeat4Simple")]
        BoundingBox ConductorBeat4Simple { get; set; }

        [JsonProperty("conductorLeftBeat")]
        BoundingBox ConductorLeftBeat { get; set; }

        [JsonProperty("conductorRightBeat")]
        BoundingBox ConductorRightBeat { get; set; }

        [JsonProperty("conductorStrongBeat")]
        BoundingBox ConductorStrongBeat { get; set; }

        [JsonProperty("conductorUnconducted")]
        BoundingBox ConductorUnconducted { get; set; }

        [JsonProperty("conductorWeakBeat")]
        BoundingBox ConductorWeakBeat { get; set; }

        [JsonProperty("csymAugmented")]
        BoundingBox CsymAugmented { get; set; }

        [JsonProperty("csymBracketLeftTall")]
        BoundingBox CsymBracketLeftTall { get; set; }

        [JsonProperty("csymBracketRightTall")]
        BoundingBox CsymBracketRightTall { get; set; }

        [JsonProperty("csymDiminished")]
        BoundingBox CsymDiminished { get; set; }

        [JsonProperty("csymHalfDiminished")]
        BoundingBox CsymHalfDiminished { get; set; }

        [JsonProperty("csymMajorSeventh")]
        BoundingBox CsymMajorSeventh { get; set; }

        [JsonProperty("csymMinor")]
        BoundingBox CsymMinor { get; set; }

        [JsonProperty("csymParensLeftTall")]
        BoundingBox CsymParensLeftTall { get; set; }

        [JsonProperty("csymParensRightTall")]
        BoundingBox CsymParensRightTall { get; set; }

        [JsonProperty("curlewSign")]
        BoundingBox CurlewSign { get; set; }

        [JsonProperty("daCapo")]
        BoundingBox DaCapo { get; set; }

        [JsonProperty("dalSegno")]
        BoundingBox DalSegno { get; set; }

        [JsonProperty("daseianExcellentes1")]
        BoundingBox DaseianExcellentes1 { get; set; }

        [JsonProperty("daseianExcellentes2")]
        BoundingBox DaseianExcellentes2 { get; set; }

        [JsonProperty("daseianExcellentes3")]
        BoundingBox DaseianExcellentes3 { get; set; }

        [JsonProperty("daseianExcellentes4")]
        BoundingBox DaseianExcellentes4 { get; set; }

        [JsonProperty("daseianFinales1")]
        BoundingBox DaseianFinales1 { get; set; }

        [JsonProperty("daseianFinales2")]
        BoundingBox DaseianFinales2 { get; set; }

        [JsonProperty("daseianFinales3")]
        BoundingBox DaseianFinales3 { get; set; }

        [JsonProperty("daseianFinales4")]
        BoundingBox DaseianFinales4 { get; set; }

        [JsonProperty("daseianGraves1")]
        BoundingBox DaseianGraves1 { get; set; }

        [JsonProperty("daseianGraves2")]
        BoundingBox DaseianGraves2 { get; set; }

        [JsonProperty("daseianGraves3")]
        BoundingBox DaseianGraves3 { get; set; }

        [JsonProperty("daseianGraves4")]
        BoundingBox DaseianGraves4 { get; set; }

        [JsonProperty("daseianResidua1")]
        BoundingBox DaseianResidua1 { get; set; }

        [JsonProperty("daseianResidua2")]
        BoundingBox DaseianResidua2 { get; set; }

        [JsonProperty("daseianSuperiores1")]
        BoundingBox DaseianSuperiores1 { get; set; }

        [JsonProperty("daseianSuperiores2")]
        BoundingBox DaseianSuperiores2 { get; set; }

        [JsonProperty("daseianSuperiores3")]
        BoundingBox DaseianSuperiores3 { get; set; }

        [JsonProperty("daseianSuperiores4")]
        BoundingBox DaseianSuperiores4 { get; set; }

        [JsonProperty("doubleTongueAbove")]
        BoundingBox DoubleTongueAbove { get; set; }

        [JsonProperty("doubleTongueAboveNoSlur")]
        BoundingBox DoubleTongueAboveNoSlur { get; set; }

        [JsonProperty("doubleTongueBelow")]
        BoundingBox DoubleTongueBelow { get; set; }

        [JsonProperty("doubleTongueBelowNoSlur")]
        BoundingBox DoubleTongueBelowNoSlur { get; set; }

        [JsonProperty("dynamicCombinedSeparatorColon")]
        BoundingBox DynamicCombinedSeparatorColon { get; set; }

        [JsonProperty("dynamicCombinedSeparatorHyphen")]
        BoundingBox DynamicCombinedSeparatorHyphen { get; set; }

        [JsonProperty("dynamicCrescendoHairpin")]
        BoundingBox DynamicCrescendoHairpin { get; set; }

        [JsonProperty("dynamicDiminuendoHairpin")]
        BoundingBox DynamicDiminuendoHairpin { get; set; }

        [JsonProperty("dynamicFF")]
        BoundingBox DynamicFf { get; set; }

        [JsonProperty("dynamicFFF")]
        BoundingBox DynamicFff { get; set; }

        [JsonProperty("dynamicFFFF")]
        BoundingBox DynamicFfff { get; set; }

        [JsonProperty("dynamicFFFFF")]
        BoundingBox DynamicFffff { get; set; }

        [JsonProperty("dynamicFFFFFF")]
        BoundingBox DynamicFfffff { get; set; }

        [JsonProperty("dynamicForte")]
        BoundingBox DynamicForte { get; set; }

        [JsonProperty("dynamicFortePiano")]
        BoundingBox DynamicFortePiano { get; set; }

        [JsonProperty("dynamicForteSmall")]
        BoundingBox DynamicForteSmall { get; set; }

        [JsonProperty("dynamicForzando")]
        BoundingBox DynamicForzando { get; set; }

        [JsonProperty("dynamicHairpinBracketLeft")]
        BoundingBox DynamicHairpinBracketLeft { get; set; }

        [JsonProperty("dynamicHairpinBracketRight")]
        BoundingBox DynamicHairpinBracketRight { get; set; }

        [JsonProperty("dynamicHairpinParenthesisLeft")]
        BoundingBox DynamicHairpinParenthesisLeft { get; set; }

        [JsonProperty("dynamicHairpinParenthesisRight")]
        BoundingBox DynamicHairpinParenthesisRight { get; set; }

        [JsonProperty("dynamicMF")]
        BoundingBox DynamicMf { get; set; }

        [JsonProperty("dynamicMP")]
        BoundingBox DynamicMp { get; set; }

        [JsonProperty("dynamicMessaDiVoce")]
        BoundingBox DynamicMessaDiVoce { get; set; }

        [JsonProperty("dynamicMezzo")]
        BoundingBox DynamicMezzo { get; set; }

        [JsonProperty("dynamicMezzoSmall")]
        BoundingBox DynamicMezzoSmall { get; set; }

        [JsonProperty("dynamicNiente")]
        BoundingBox DynamicNiente { get; set; }

        [JsonProperty("dynamicNienteForHairpin")]
        BoundingBox DynamicNienteForHairpin { get; set; }

        [JsonProperty("dynamicNienteSmall")]
        BoundingBox DynamicNienteSmall { get; set; }

        [JsonProperty("dynamicPF")]
        BoundingBox DynamicPf { get; set; }

        [JsonProperty("dynamicPP")]
        BoundingBox DynamicPp { get; set; }

        [JsonProperty("dynamicPPP")]
        BoundingBox DynamicPpp { get; set; }

        [JsonProperty("dynamicPPPP")]
        BoundingBox DynamicPppp { get; set; }

        [JsonProperty("dynamicPPPPP")]
        BoundingBox DynamicPpppp { get; set; }

        [JsonProperty("dynamicPPPPPP")]
        BoundingBox DynamicPppppp { get; set; }

        [JsonProperty("dynamicPiano")]
        BoundingBox DynamicPiano { get; set; }

        [JsonProperty("dynamicPianoSmall")]
        BoundingBox DynamicPianoSmall { get; set; }

        [JsonProperty("dynamicRinforzando")]
        BoundingBox DynamicRinforzando { get; set; }

        [JsonProperty("dynamicRinforzando1")]
        BoundingBox DynamicRinforzando1 { get; set; }

        [JsonProperty("dynamicRinforzando2")]
        BoundingBox DynamicRinforzando2 { get; set; }

        [JsonProperty("dynamicRinforzandoSmall")]
        BoundingBox DynamicRinforzandoSmall { get; set; }

        [JsonProperty("dynamicSforzando")]
        BoundingBox DynamicSforzando { get; set; }

        [JsonProperty("dynamicSforzando1")]
        BoundingBox DynamicSforzando1 { get; set; }

        [JsonProperty("dynamicSforzandoPianissimo")]
        BoundingBox DynamicSforzandoPianissimo { get; set; }

        [JsonProperty("dynamicSforzandoPiano")]
        BoundingBox DynamicSforzandoPiano { get; set; }

        [JsonProperty("dynamicSforzandoSmall")]
        BoundingBox DynamicSforzandoSmall { get; set; }

        [JsonProperty("dynamicSforzato")]
        BoundingBox DynamicSforzato { get; set; }

        [JsonProperty("dynamicSforzatoFF")]
        BoundingBox DynamicSforzatoFf { get; set; }

        [JsonProperty("dynamicSforzatoPiano")]
        BoundingBox DynamicSforzatoPiano { get; set; }

        [JsonProperty("dynamicZ")]
        BoundingBox DynamicZ { get; set; }

        [JsonProperty("dynamicZSmall")]
        BoundingBox DynamicZSmall { get; set; }

        [JsonProperty("elecAudioChannelsEight")]
        BoundingBox ElecAudioChannelsEight { get; set; }

        [JsonProperty("elecAudioChannelsFive")]
        BoundingBox ElecAudioChannelsFive { get; set; }

        [JsonProperty("elecAudioChannelsFour")]
        BoundingBox ElecAudioChannelsFour { get; set; }

        [JsonProperty("elecAudioChannelsOne")]
        BoundingBox ElecAudioChannelsOne { get; set; }

        [JsonProperty("elecAudioChannelsSeven")]
        BoundingBox ElecAudioChannelsSeven { get; set; }

        [JsonProperty("elecAudioChannelsSix")]
        BoundingBox ElecAudioChannelsSix { get; set; }

        [JsonProperty("elecAudioChannelsThreeFrontal")]
        BoundingBox ElecAudioChannelsThreeFrontal { get; set; }

        [JsonProperty("elecAudioChannelsThreeSurround")]
        BoundingBox ElecAudioChannelsThreeSurround { get; set; }

        [JsonProperty("elecAudioChannelsTwo")]
        BoundingBox ElecAudioChannelsTwo { get; set; }

        [JsonProperty("elecAudioIn")]
        BoundingBox ElecAudioIn { get; set; }

        [JsonProperty("elecAudioMono")]
        BoundingBox ElecAudioMono { get; set; }

        [JsonProperty("elecAudioOut")]
        BoundingBox ElecAudioOut { get; set; }

        [JsonProperty("elecAudioStereo")]
        BoundingBox ElecAudioStereo { get; set; }

        [JsonProperty("elecCamera")]
        BoundingBox ElecCamera { get; set; }

        [JsonProperty("elecDataIn")]
        BoundingBox ElecDataIn { get; set; }

        [JsonProperty("elecDataOut")]
        BoundingBox ElecDataOut { get; set; }

        [JsonProperty("elecDisc")]
        Dictionary<string, long[]> ElecDisc { get; set; }

        [JsonProperty("elecDownload")]
        BoundingBox ElecDownload { get; set; }

        [JsonProperty("elecEject")]
        BoundingBox ElecEject { get; set; }

        [JsonProperty("elecFastForward")]
        BoundingBox ElecFastForward { get; set; }

        [JsonProperty("elecHeadphones")]
        BoundingBox ElecHeadphones { get; set; }

        [JsonProperty("elecHeadset")]
        BoundingBox ElecHeadset { get; set; }

        [JsonProperty("elecLineIn")]
        BoundingBox ElecLineIn { get; set; }

        [JsonProperty("elecLineOut")]
        BoundingBox ElecLineOut { get; set; }

        [JsonProperty("elecLoop")]
        BoundingBox ElecLoop { get; set; }

        [JsonProperty("elecLoudspeaker")]
        BoundingBox ElecLoudspeaker { get; set; }

        [JsonProperty("elecMIDIController0")]
        BoundingBox ElecMidiController0 { get; set; }

        [JsonProperty("elecMIDIController100")]
        BoundingBox ElecMidiController100 { get; set; }

        [JsonProperty("elecMIDIController20")]
        BoundingBox ElecMidiController20 { get; set; }

        [JsonProperty("elecMIDIController40")]
        BoundingBox ElecMidiController40 { get; set; }

        [JsonProperty("elecMIDIController60")]
        BoundingBox ElecMidiController60 { get; set; }

        [JsonProperty("elecMIDIController80")]
        BoundingBox ElecMidiController80 { get; set; }

        [JsonProperty("elecMIDIIn")]
        BoundingBox ElecMidiIn { get; set; }

        [JsonProperty("elecMIDIOut")]
        BoundingBox ElecMidiOut { get; set; }

        [JsonProperty("elecMicrophone")]
        BoundingBox ElecMicrophone { get; set; }

        [JsonProperty("elecMicrophoneMute")]
        BoundingBox ElecMicrophoneMute { get; set; }

        [JsonProperty("elecMicrophoneUnmute")]
        BoundingBox ElecMicrophoneUnmute { get; set; }

        [JsonProperty("elecMixingConsole")]
        BoundingBox ElecMixingConsole { get; set; }

        [JsonProperty("elecMonitor")]
        BoundingBox ElecMonitor { get; set; }

        [JsonProperty("elecMute")]
        BoundingBox ElecMute { get; set; }

        [JsonProperty("elecPause")]
        BoundingBox ElecPause { get; set; }

        [JsonProperty("elecPlay")]
        BoundingBox ElecPlay { get; set; }

        [JsonProperty("elecPowerOnOff")]
        BoundingBox ElecPowerOnOff { get; set; }

        [JsonProperty("elecProjector")]
        BoundingBox ElecProjector { get; set; }

        [JsonProperty("elecReplay")]
        BoundingBox ElecReplay { get; set; }

        [JsonProperty("elecRewind")]
        BoundingBox ElecRewind { get; set; }

        [JsonProperty("elecShuffle")]
        BoundingBox ElecShuffle { get; set; }

        [JsonProperty("elecSkipBackwards")]
        BoundingBox ElecSkipBackwards { get; set; }

        [JsonProperty("elecSkipForwards")]
        BoundingBox ElecSkipForwards { get; set; }

        [JsonProperty("elecStop")]
        BoundingBox ElecStop { get; set; }

        [JsonProperty("elecTape")]
        BoundingBox ElecTape { get; set; }

        [JsonProperty("elecUSB")]
        BoundingBox ElecUsb { get; set; }

        [JsonProperty("elecUnmute")]
        BoundingBox ElecUnmute { get; set; }

        [JsonProperty("elecUpload")]
        BoundingBox ElecUpload { get; set; }

        [JsonProperty("elecVideoCamera")]
        BoundingBox ElecVideoCamera { get; set; }

        [JsonProperty("elecVideoIn")]
        BoundingBox ElecVideoIn { get; set; }

        [JsonProperty("elecVideoOut")]
        BoundingBox ElecVideoOut { get; set; }

        [JsonProperty("elecVolumeFader")]
        BoundingBox ElecVolumeFader { get; set; }

        [JsonProperty("elecVolumeFaderThumb")]
        BoundingBox ElecVolumeFaderThumb { get; set; }

        [JsonProperty("elecVolumeLevel0")]
        BoundingBox ElecVolumeLevel0 { get; set; }

        [JsonProperty("elecVolumeLevel100")]
        BoundingBox ElecVolumeLevel100 { get; set; }

        [JsonProperty("elecVolumeLevel20")]
        BoundingBox ElecVolumeLevel20 { get; set; }

        [JsonProperty("elecVolumeLevel40")]
        BoundingBox ElecVolumeLevel40 { get; set; }

        [JsonProperty("elecVolumeLevel60")]
        BoundingBox ElecVolumeLevel60 { get; set; }

        [JsonProperty("elecVolumeLevel80")]
        BoundingBox ElecVolumeLevel80 { get; set; }

        [JsonProperty("fClef")]
        BoundingBox FClef { get; set; }

        [JsonProperty("fClef15ma")]
        BoundingBox FClef15Ma { get; set; }

        [JsonProperty("fClef15mb")]
        BoundingBox FClef15Mb { get; set; }

        [JsonProperty("fClef19thCentury")]
        BoundingBox FClef19ThCentury { get; set; }

        [JsonProperty("fClef5Below")]
        BoundingBox FClef5Below { get; set; }

        [JsonProperty("fClef8va")]
        BoundingBox FClef8Va { get; set; }

        [JsonProperty("fClef8vb")]
        BoundingBox FClef8Vb { get; set; }

        [JsonProperty("fClefArrowDown")]
        BoundingBox FClefArrowDown { get; set; }

        [JsonProperty("fClefArrowUp")]
        BoundingBox FClefArrowUp { get; set; }

        [JsonProperty("fClefChange")]
        BoundingBox FClefChange { get; set; }

        [JsonProperty("fClefFrench")]
        BoundingBox FClefFrench { get; set; }

        [JsonProperty("fClefReversed")]
        BoundingBox FClefReversed { get; set; }

        [JsonProperty("fClefSmall")]
        BoundingBox FClefSmall { get; set; }

        [JsonProperty("fClefTurned")]
        BoundingBox FClefTurned { get; set; }

        [JsonProperty("fermataAbove")]
        BoundingBox FermataAbove { get; set; }

        [JsonProperty("fermataBelow")]
        BoundingBox FermataBelow { get; set; }

        [JsonProperty("fermataLongAbove")]
        BoundingBox FermataLongAbove { get; set; }

        [JsonProperty("fermataLongBelow")]
        BoundingBox FermataLongBelow { get; set; }

        [JsonProperty("fermataLongHenzeAbove")]
        BoundingBox FermataLongHenzeAbove { get; set; }

        [JsonProperty("fermataLongHenzeBelow")]
        BoundingBox FermataLongHenzeBelow { get; set; }

        [JsonProperty("fermataShortAbove")]
        BoundingBox FermataShortAbove { get; set; }

        [JsonProperty("fermataShortBelow")]
        BoundingBox FermataShortBelow { get; set; }

        [JsonProperty("fermataShortHenzeAbove")]
        BoundingBox FermataShortHenzeAbove { get; set; }

        [JsonProperty("fermataShortHenzeBelow")]
        BoundingBox FermataShortHenzeBelow { get; set; }

        [JsonProperty("fermataVeryLongAbove")]
        BoundingBox FermataVeryLongAbove { get; set; }

        [JsonProperty("fermataVeryLongBelow")]
        BoundingBox FermataVeryLongBelow { get; set; }

        [JsonProperty("fermataVeryShortAbove")]
        BoundingBox FermataVeryShortAbove { get; set; }

        [JsonProperty("fermataVeryShortBelow")]
        BoundingBox FermataVeryShortBelow { get; set; }

        [JsonProperty("figbass0")]
        BoundingBox Figbass0 { get; set; }

        [JsonProperty("figbass1")]
        BoundingBox Figbass1 { get; set; }

        [JsonProperty("figbass2")]
        BoundingBox Figbass2 { get; set; }

        [JsonProperty("figbass2Raised")]
        BoundingBox Figbass2Raised { get; set; }

        [JsonProperty("figbass3")]
        BoundingBox Figbass3 { get; set; }

        [JsonProperty("figbass4")]
        BoundingBox Figbass4 { get; set; }

        [JsonProperty("figbass4Raised")]
        BoundingBox Figbass4Raised { get; set; }

        [JsonProperty("figbass5")]
        BoundingBox Figbass5 { get; set; }

        [JsonProperty("figbass5Raised1")]
        BoundingBox Figbass5Raised1 { get; set; }

        [JsonProperty("figbass5Raised2")]
        BoundingBox Figbass5Raised2 { get; set; }

        [JsonProperty("figbass5Raised3")]
        BoundingBox Figbass5Raised3 { get; set; }

        [JsonProperty("figbass6")]
        BoundingBox Figbass6 { get; set; }

        [JsonProperty("figbass6Raised")]
        BoundingBox Figbass6Raised { get; set; }

        [JsonProperty("figbass6Raised2")]
        BoundingBox Figbass6Raised2 { get; set; }

        [JsonProperty("figbass7")]
        BoundingBox Figbass7 { get; set; }

        [JsonProperty("figbass7Diminished")]
        BoundingBox Figbass7Diminished { get; set; }

        [JsonProperty("figbass7Raised1")]
        BoundingBox Figbass7Raised1 { get; set; }

        [JsonProperty("figbass7Raised2")]
        BoundingBox Figbass7Raised2 { get; set; }

        [JsonProperty("figbass8")]
        BoundingBox Figbass8 { get; set; }

        [JsonProperty("figbass9")]
        BoundingBox Figbass9 { get; set; }

        [JsonProperty("figbass9Raised")]
        BoundingBox Figbass9Raised { get; set; }

        [JsonProperty("figbassBracketLeft")]
        BoundingBox FigbassBracketLeft { get; set; }

        [JsonProperty("figbassBracketRight")]
        BoundingBox FigbassBracketRight { get; set; }

        [JsonProperty("figbassCombiningLowering")]
        BoundingBox FigbassCombiningLowering { get; set; }

        [JsonProperty("figbassCombiningRaising")]
        BoundingBox FigbassCombiningRaising { get; set; }

        [JsonProperty("figbassDoubleFlat")]
        BoundingBox FigbassDoubleFlat { get; set; }

        [JsonProperty("figbassDoubleSharp")]
        BoundingBox FigbassDoubleSharp { get; set; }

        [JsonProperty("figbassFlat")]
        BoundingBox FigbassFlat { get; set; }

        [JsonProperty("figbassNatural")]
        BoundingBox FigbassNatural { get; set; }

        [JsonProperty("figbassParensLeft")]
        BoundingBox FigbassParensLeft { get; set; }

        [JsonProperty("figbassParensRight")]
        BoundingBox FigbassParensRight { get; set; }

        [JsonProperty("figbassPlus")]
        BoundingBox FigbassPlus { get; set; }

        [JsonProperty("figbassSharp")]
        BoundingBox FigbassSharp { get; set; }

        [JsonProperty("fingering0")]
        BoundingBox Fingering0 { get; set; }

        [JsonProperty("fingering1")]
        BoundingBox Fingering1 { get; set; }

        [JsonProperty("fingering2")]
        BoundingBox Fingering2 { get; set; }

        [JsonProperty("fingering3")]
        BoundingBox Fingering3 { get; set; }

        [JsonProperty("fingering4")]
        BoundingBox Fingering4 { get; set; }

        [JsonProperty("fingering5")]
        BoundingBox Fingering5 { get; set; }

        [JsonProperty("fingeringALower")]
        BoundingBox FingeringALower { get; set; }

        [JsonProperty("fingeringCLower")]
        BoundingBox FingeringCLower { get; set; }

        [JsonProperty("fingeringELower")]
        BoundingBox FingeringELower { get; set; }

        [JsonProperty("fingeringILower")]
        BoundingBox FingeringILower { get; set; }

        [JsonProperty("fingeringMLower")]
        BoundingBox FingeringMLower { get; set; }

        [JsonProperty("fingeringMultipleNotes")]
        BoundingBox FingeringMultipleNotes { get; set; }

        [JsonProperty("fingeringOLower")]
        BoundingBox FingeringOLower { get; set; }

        [JsonProperty("fingeringPLower")]
        BoundingBox FingeringPLower { get; set; }

        [JsonProperty("fingeringSubstitutionAbove")]
        BoundingBox FingeringSubstitutionAbove { get; set; }

        [JsonProperty("fingeringSubstitutionBelow")]
        BoundingBox FingeringSubstitutionBelow { get; set; }

        [JsonProperty("fingeringSubstitutionDash")]
        BoundingBox FingeringSubstitutionDash { get; set; }

        [JsonProperty("fingeringTLower")]
        BoundingBox FingeringTLower { get; set; }

        [JsonProperty("fingeringTUpper")]
        BoundingBox FingeringTUpper { get; set; }

        [JsonProperty("fingeringXLower")]
        BoundingBox FingeringXLower { get; set; }

        [JsonProperty("flag1024thDown")]
        BoundingBox Flag1024ThDown { get; set; }

        [JsonProperty("flag1024thDownSmall")]
        BoundingBox Flag1024ThDownSmall { get; set; }

        [JsonProperty("flag1024thDownStraight")]
        BoundingBox Flag1024ThDownStraight { get; set; }

        [JsonProperty("flag1024thUp")]
        BoundingBox Flag1024ThUp { get; set; }

        [JsonProperty("flag1024thUpShort")]
        BoundingBox Flag1024ThUpShort { get; set; }

        [JsonProperty("flag1024thUpSmall")]
        BoundingBox Flag1024ThUpSmall { get; set; }

        [JsonProperty("flag1024thUpStraight")]
        BoundingBox Flag1024ThUpStraight { get; set; }

        [JsonProperty("flag128thDown")]
        BoundingBox Flag128ThDown { get; set; }

        [JsonProperty("flag128thDownSmall")]
        BoundingBox Flag128ThDownSmall { get; set; }

        [JsonProperty("flag128thDownStraight")]
        BoundingBox Flag128ThDownStraight { get; set; }

        [JsonProperty("flag128thUp")]
        BoundingBox Flag128ThUp { get; set; }

        [JsonProperty("flag128thUpShort")]
        BoundingBox Flag128ThUpShort { get; set; }

        [JsonProperty("flag128thUpSmall")]
        BoundingBox Flag128ThUpSmall { get; set; }

        [JsonProperty("flag128thUpStraight")]
        BoundingBox Flag128ThUpStraight { get; set; }

        [JsonProperty("flag16thDown")]
        BoundingBox Flag16ThDown { get; set; }

        [JsonProperty("flag16thDownSmall")]
        BoundingBox Flag16ThDownSmall { get; set; }

        [JsonProperty("flag16thDownStraight")]
        BoundingBox Flag16ThDownStraight { get; set; }

        [JsonProperty("flag16thUp")]
        BoundingBox Flag16ThUp { get; set; }

        [JsonProperty("flag16thUpShort")]
        BoundingBox Flag16ThUpShort { get; set; }

        [JsonProperty("flag16thUpSmall")]
        BoundingBox Flag16ThUpSmall { get; set; }

        [JsonProperty("flag16thUpStraight")]
        BoundingBox Flag16ThUpStraight { get; set; }

        [JsonProperty("flag256thDown")]
        BoundingBox Flag256ThDown { get; set; }

        [JsonProperty("flag256thDownSmall")]
        BoundingBox Flag256ThDownSmall { get; set; }

        [JsonProperty("flag256thDownStraight")]
        BoundingBox Flag256ThDownStraight { get; set; }

        [JsonProperty("flag256thUp")]
        BoundingBox Flag256ThUp { get; set; }

        [JsonProperty("flag256thUpShort")]
        BoundingBox Flag256ThUpShort { get; set; }

        [JsonProperty("flag256thUpSmall")]
        BoundingBox Flag256ThUpSmall { get; set; }

        [JsonProperty("flag256thUpStraight")]
        BoundingBox Flag256ThUpStraight { get; set; }

        [JsonProperty("flag32ndDown")]
        BoundingBox Flag32NdDown { get; set; }

        [JsonProperty("flag32ndDownSmall")]
        BoundingBox Flag32NdDownSmall { get; set; }

        [JsonProperty("flag32ndDownStraight")]
        BoundingBox Flag32NdDownStraight { get; set; }

        [JsonProperty("flag32ndUp")]
        BoundingBox Flag32NdUp { get; set; }

        [JsonProperty("flag32ndUpShort")]
        BoundingBox Flag32NdUpShort { get; set; }

        [JsonProperty("flag32ndUpSmall")]
        BoundingBox Flag32NdUpSmall { get; set; }

        [JsonProperty("flag32ndUpStraight")]
        BoundingBox Flag32NdUpStraight { get; set; }

        [JsonProperty("flag512thDown")]
        BoundingBox Flag512ThDown { get; set; }

        [JsonProperty("flag512thDownSmall")]
        BoundingBox Flag512ThDownSmall { get; set; }

        [JsonProperty("flag512thDownStraight")]
        BoundingBox Flag512ThDownStraight { get; set; }

        [JsonProperty("flag512thUp")]
        BoundingBox Flag512ThUp { get; set; }

        [JsonProperty("flag512thUpShort")]
        BoundingBox Flag512ThUpShort { get; set; }

        [JsonProperty("flag512thUpSmall")]
        BoundingBox Flag512ThUpSmall { get; set; }

        [JsonProperty("flag512thUpStraight")]
        BoundingBox Flag512ThUpStraight { get; set; }

        [JsonProperty("flag64thDown")]
        BoundingBox Flag64ThDown { get; set; }

        [JsonProperty("flag64thDownSmall")]
        BoundingBox Flag64ThDownSmall { get; set; }

        [JsonProperty("flag64thDownStraight")]
        BoundingBox Flag64ThDownStraight { get; set; }

        [JsonProperty("flag64thUp")]
        BoundingBox Flag64ThUp { get; set; }

        [JsonProperty("flag64thUpShort")]
        BoundingBox Flag64ThUpShort { get; set; }

        [JsonProperty("flag64thUpSmall")]
        BoundingBox Flag64ThUpSmall { get; set; }

        [JsonProperty("flag64thUpStraight")]
        BoundingBox Flag64ThUpStraight { get; set; }

        [JsonProperty("flag8thDown")]
        BoundingBox Flag8ThDown { get; set; }

        [JsonProperty("flag8thDownSmall")]
        BoundingBox Flag8ThDownSmall { get; set; }

        [JsonProperty("flag8thDownStraight")]
        BoundingBox Flag8ThDownStraight { get; set; }

        [JsonProperty("flag8thUp")]
        BoundingBox Flag8ThUp { get; set; }

        [JsonProperty("flag8thUpShort")]
        BoundingBox Flag8ThUpShort { get; set; }

        [JsonProperty("flag8thUpSmall")]
        BoundingBox Flag8ThUpSmall { get; set; }

        [JsonProperty("flag8thUpStraight")]
        BoundingBox Flag8ThUpStraight { get; set; }

        [JsonProperty("flagInternalDown")]
        BoundingBox FlagInternalDown { get; set; }

        [JsonProperty("flagInternalUp")]
        BoundingBox FlagInternalUp { get; set; }

        [JsonProperty("fretboard3String")]
        BoundingBox Fretboard3String { get; set; }

        [JsonProperty("fretboard3StringNut")]
        BoundingBox Fretboard3StringNut { get; set; }

        [JsonProperty("fretboard4String")]
        BoundingBox Fretboard4String { get; set; }

        [JsonProperty("fretboard4StringNut")]
        BoundingBox Fretboard4StringNut { get; set; }

        [JsonProperty("fretboard5String")]
        BoundingBox Fretboard5String { get; set; }

        [JsonProperty("fretboard5StringNut")]
        BoundingBox Fretboard5StringNut { get; set; }

        [JsonProperty("fretboard6String")]
        BoundingBox Fretboard6String { get; set; }

        [JsonProperty("fretboard6StringNut")]
        BoundingBox Fretboard6StringNut { get; set; }

        [JsonProperty("fretboardFilledCircle")]
        BoundingBox FretboardFilledCircle { get; set; }

        [JsonProperty("fretboardO")]
        BoundingBox FretboardO { get; set; }

        [JsonProperty("fretboardX")]
        BoundingBox FretboardX { get; set; }

        [JsonProperty("functionAngleLeft")]
        BoundingBox FunctionAngleLeft { get; set; }

        [JsonProperty("functionAngleRight")]
        BoundingBox FunctionAngleRight { get; set; }

        [JsonProperty("functionBracketLeft")]
        BoundingBox FunctionBracketLeft { get; set; }

        [JsonProperty("functionBracketRight")]
        BoundingBox FunctionBracketRight { get; set; }

        [JsonProperty("functionDD")]
        BoundingBox FunctionDd { get; set; }

        [JsonProperty("functionDLower")]
        BoundingBox FunctionDLower { get; set; }

        [JsonProperty("functionDUpper")]
        BoundingBox FunctionDUpper { get; set; }

        [JsonProperty("functionEight")]
        BoundingBox FunctionEight { get; set; }

        [JsonProperty("functionFUpper")]
        BoundingBox FunctionFUpper { get; set; }

        [JsonProperty("functionFive")]
        BoundingBox FunctionFive { get; set; }

        [JsonProperty("functionFour")]
        BoundingBox FunctionFour { get; set; }

        [JsonProperty("functionGLower")]
        BoundingBox FunctionGLower { get; set; }

        [JsonProperty("functionGUpper")]
        BoundingBox FunctionGUpper { get; set; }

        [JsonProperty("functionGreaterThan")]
        BoundingBox FunctionGreaterThan { get; set; }

        [JsonProperty("functionILower")]
        BoundingBox FunctionILower { get; set; }

        [JsonProperty("functionIUpper")]
        BoundingBox FunctionIUpper { get; set; }

        [JsonProperty("functionKLower")]
        BoundingBox FunctionKLower { get; set; }

        [JsonProperty("functionKUpper")]
        BoundingBox FunctionKUpper { get; set; }

        [JsonProperty("functionLLower")]
        BoundingBox FunctionLLower { get; set; }

        [JsonProperty("functionLUpper")]
        BoundingBox FunctionLUpper { get; set; }

        [JsonProperty("functionLessThan")]
        BoundingBox FunctionLessThan { get; set; }

        [JsonProperty("functionMLower")]
        BoundingBox FunctionMLower { get; set; }

        [JsonProperty("functionMUpper")]
        BoundingBox FunctionMUpper { get; set; }

        [JsonProperty("functionMinus")]
        BoundingBox FunctionMinus { get; set; }

        [JsonProperty("functionNLower")]
        BoundingBox FunctionNLower { get; set; }

        [JsonProperty("functionNUpper")]
        BoundingBox FunctionNUpper { get; set; }

        [JsonProperty("functionNUpperSuperscript")]
        BoundingBox FunctionNUpperSuperscript { get; set; }

        [JsonProperty("functionNine")]
        BoundingBox FunctionNine { get; set; }

        [JsonProperty("functionOne")]
        BoundingBox FunctionOne { get; set; }

        [JsonProperty("functionPLower")]
        BoundingBox FunctionPLower { get; set; }

        [JsonProperty("functionPUpper")]
        BoundingBox FunctionPUpper { get; set; }

        [JsonProperty("functionParensLeft")]
        BoundingBox FunctionParensLeft { get; set; }

        [JsonProperty("functionParensRight")]
        BoundingBox FunctionParensRight { get; set; }

        [JsonProperty("functionPlus")]
        BoundingBox FunctionPlus { get; set; }

        [JsonProperty("functionRLower")]
        BoundingBox FunctionRLower { get; set; }

        [JsonProperty("functionRepetition1")]
        BoundingBox FunctionRepetition1 { get; set; }

        [JsonProperty("functionRepetition2")]
        BoundingBox FunctionRepetition2 { get; set; }

        [JsonProperty("functionRing")]
        BoundingBox FunctionRing { get; set; }

        [JsonProperty("functionSLower")]
        BoundingBox FunctionSLower { get; set; }

        [JsonProperty("functionSSLower")]
        BoundingBox FunctionSsLower { get; set; }

        [JsonProperty("functionSSUpper")]
        BoundingBox FunctionSsUpper { get; set; }

        [JsonProperty("functionSUpper")]
        BoundingBox FunctionSUpper { get; set; }

        [JsonProperty("functionSeven")]
        BoundingBox FunctionSeven { get; set; }

        [JsonProperty("functionSix")]
        BoundingBox FunctionSix { get; set; }

        [JsonProperty("functionSlashedDD")]
        BoundingBox FunctionSlashedDd { get; set; }

        [JsonProperty("functionTLower")]
        BoundingBox FunctionTLower { get; set; }

        [JsonProperty("functionTUpper")]
        BoundingBox FunctionTUpper { get; set; }

        [JsonProperty("functionThree")]
        BoundingBox FunctionThree { get; set; }

        [JsonProperty("functionTwo")]
        BoundingBox FunctionTwo { get; set; }

        [JsonProperty("functionVLower")]
        BoundingBox FunctionVLower { get; set; }

        [JsonProperty("functionVUpper")]
        BoundingBox FunctionVUpper { get; set; }

        [JsonProperty("functionZero")]
        BoundingBox FunctionZero { get; set; }

        [JsonProperty("gClef")]
        BoundingBox GClef { get; set; }

        [JsonProperty("gClef0Below")]
        BoundingBox GClef0Below { get; set; }

        [JsonProperty("gClef10Below")]
        BoundingBox GClef10Below { get; set; }

        [JsonProperty("gClef11Below")]
        BoundingBox GClef11Below { get; set; }

        [JsonProperty("gClef12Below")]
        BoundingBox GClef12Below { get; set; }

        [JsonProperty("gClef13Below")]
        BoundingBox GClef13Below { get; set; }

        [JsonProperty("gClef14Below")]
        BoundingBox GClef14Below { get; set; }

        [JsonProperty("gClef15Below")]
        BoundingBox GClef15Below { get; set; }

        [JsonProperty("gClef15ma")]
        BoundingBox GClef15Ma { get; set; }

        [JsonProperty("gClef15mb")]
        BoundingBox GClef15Mb { get; set; }

        [JsonProperty("gClef16Below")]
        BoundingBox GClef16Below { get; set; }

        [JsonProperty("gClef17Below")]
        BoundingBox GClef17Below { get; set; }

        [JsonProperty("gClef2Above")]
        BoundingBox GClef2Above { get; set; }

        [JsonProperty("gClef2Below")]
        BoundingBox GClef2Below { get; set; }

        [JsonProperty("gClef3Above")]
        BoundingBox GClef3Above { get; set; }

        [JsonProperty("gClef3Below")]
        BoundingBox GClef3Below { get; set; }

        [JsonProperty("gClef4Above")]
        BoundingBox GClef4Above { get; set; }

        [JsonProperty("gClef4Below")]
        BoundingBox GClef4Below { get; set; }

        [JsonProperty("gClef5Above")]
        BoundingBox GClef5Above { get; set; }

        [JsonProperty("gClef5Below")]
        BoundingBox GClef5Below { get; set; }

        [JsonProperty("gClef6Above")]
        BoundingBox GClef6Above { get; set; }

        [JsonProperty("gClef6Below")]
        BoundingBox GClef6Below { get; set; }

        [JsonProperty("gClef7Above")]
        BoundingBox GClef7Above { get; set; }

        [JsonProperty("gClef7Below")]
        BoundingBox GClef7Below { get; set; }

        [JsonProperty("gClef8Above")]
        BoundingBox GClef8Above { get; set; }

        [JsonProperty("gClef8Below")]
        BoundingBox GClef8Below { get; set; }

        [JsonProperty("gClef8va")]
        BoundingBox GClef8Va { get; set; }

        [JsonProperty("gClef8vb")]
        BoundingBox GClef8Vb { get; set; }

        [JsonProperty("gClef8vbCClef")]
        BoundingBox GClef8VbCClef { get; set; }

        [JsonProperty("gClef8vbOld")]
        BoundingBox GClef8VbOld { get; set; }

        [JsonProperty("gClef8vbParens")]
        BoundingBox GClef8VbParens { get; set; }

        [JsonProperty("gClef9Above")]
        BoundingBox GClef9Above { get; set; }

        [JsonProperty("gClef9Below")]
        BoundingBox GClef9Below { get; set; }

        [JsonProperty("gClefArrowDown")]
        BoundingBox GClefArrowDown { get; set; }

        [JsonProperty("gClefArrowUp")]
        BoundingBox GClefArrowUp { get; set; }

        [JsonProperty("gClefChange")]
        BoundingBox GClefChange { get; set; }

        [JsonProperty("gClefFlat10Below")]
        BoundingBox GClefFlat10Below { get; set; }

        [JsonProperty("gClefFlat11Below")]
        BoundingBox GClefFlat11Below { get; set; }

        [JsonProperty("gClefFlat13Below")]
        BoundingBox GClefFlat13Below { get; set; }

        [JsonProperty("gClefFlat14Below")]
        BoundingBox GClefFlat14Below { get; set; }

        [JsonProperty("gClefFlat15Below")]
        BoundingBox GClefFlat15Below { get; set; }

        [JsonProperty("gClefFlat16Below")]
        BoundingBox GClefFlat16Below { get; set; }

        [JsonProperty("gClefFlat1Below")]
        BoundingBox GClefFlat1Below { get; set; }

        [JsonProperty("gClefFlat2Above")]
        BoundingBox GClefFlat2Above { get; set; }

        [JsonProperty("gClefFlat2Below")]
        BoundingBox GClefFlat2Below { get; set; }

        [JsonProperty("gClefFlat3Above")]
        BoundingBox GClefFlat3Above { get; set; }

        [JsonProperty("gClefFlat3Below")]
        BoundingBox GClefFlat3Below { get; set; }

        [JsonProperty("gClefFlat4Below")]
        BoundingBox GClefFlat4Below { get; set; }

        [JsonProperty("gClefFlat5Above")]
        BoundingBox GClefFlat5Above { get; set; }

        [JsonProperty("gClefFlat6Above")]
        BoundingBox GClefFlat6Above { get; set; }

        [JsonProperty("gClefFlat6Below")]
        BoundingBox GClefFlat6Below { get; set; }

        [JsonProperty("gClefFlat7Above")]
        BoundingBox GClefFlat7Above { get; set; }

        [JsonProperty("gClefFlat7Below")]
        BoundingBox GClefFlat7Below { get; set; }

        [JsonProperty("gClefFlat8Above")]
        BoundingBox GClefFlat8Above { get; set; }

        [JsonProperty("gClefFlat9Above")]
        BoundingBox GClefFlat9Above { get; set; }

        [JsonProperty("gClefFlat9Below")]
        BoundingBox GClefFlat9Below { get; set; }

        [JsonProperty("gClefLigatedNumberAbove")]
        BoundingBox GClefLigatedNumberAbove { get; set; }

        [JsonProperty("gClefLigatedNumberBelow")]
        BoundingBox GClefLigatedNumberBelow { get; set; }

        [JsonProperty("gClefNat2Below")]
        BoundingBox GClefNat2Below { get; set; }

        [JsonProperty("gClefNatural10Below")]
        BoundingBox GClefNatural10Below { get; set; }

        [JsonProperty("gClefNatural13Below")]
        BoundingBox GClefNatural13Below { get; set; }

        [JsonProperty("gClefNatural17Below")]
        BoundingBox GClefNatural17Below { get; set; }

        [JsonProperty("gClefNatural2Above")]
        BoundingBox GClefNatural2Above { get; set; }

        [JsonProperty("gClefNatural3Above")]
        BoundingBox GClefNatural3Above { get; set; }

        [JsonProperty("gClefNatural3Below")]
        BoundingBox GClefNatural3Below { get; set; }

        [JsonProperty("gClefNatural6Above")]
        BoundingBox GClefNatural6Above { get; set; }

        [JsonProperty("gClefNatural6Below")]
        BoundingBox GClefNatural6Below { get; set; }

        [JsonProperty("gClefNatural7Above")]
        BoundingBox GClefNatural7Above { get; set; }

        [JsonProperty("gClefNatural9Above")]
        BoundingBox GClefNatural9Above { get; set; }

        [JsonProperty("gClefNatural9Below")]
        BoundingBox GClefNatural9Below { get; set; }

        [JsonProperty("gClefReversed")]
        BoundingBox GClefReversed { get; set; }

        [JsonProperty("gClefSharp12Below")]
        BoundingBox GClefSharp12Below { get; set; }

        [JsonProperty("gClefSharp1Above")]
        BoundingBox GClefSharp1Above { get; set; }

        [JsonProperty("gClefSharp4Above")]
        BoundingBox GClefSharp4Above { get; set; }

        [JsonProperty("gClefSharp5Below")]
        BoundingBox GClefSharp5Below { get; set; }

        [JsonProperty("gClefSmall")]
        BoundingBox GClefSmall { get; set; }

        [JsonProperty("gClefTurned")]
        BoundingBox GClefTurned { get; set; }

        [JsonProperty("glissandoDown")]
        BoundingBox GlissandoDown { get; set; }

        [JsonProperty("glissandoUp")]
        BoundingBox GlissandoUp { get; set; }

        [JsonProperty("graceNoteAcciaccaturaStemDown")]
        BoundingBox GraceNoteAcciaccaturaStemDown { get; set; }

        [JsonProperty("graceNoteAcciaccaturaStemUp")]
        BoundingBox GraceNoteAcciaccaturaStemUp { get; set; }

        [JsonProperty("graceNoteAppoggiaturaStemDown")]
        BoundingBox GraceNoteAppoggiaturaStemDown { get; set; }

        [JsonProperty("graceNoteAppoggiaturaStemUp")]
        BoundingBox GraceNoteAppoggiaturaStemUp { get; set; }

        [JsonProperty("graceNoteSlashStemDown")]
        BoundingBox GraceNoteSlashStemDown { get; set; }

        [JsonProperty("graceNoteSlashStemUp")]
        BoundingBox GraceNoteSlashStemUp { get; set; }

        [JsonProperty("guitarBarreFull")]
        BoundingBox GuitarBarreFull { get; set; }

        [JsonProperty("guitarBarreHalf")]
        BoundingBox GuitarBarreHalf { get; set; }

        [JsonProperty("guitarBarreHalfHorizontalFractionSlash")]
        BoundingBox GuitarBarreHalfHorizontalFractionSlash { get; set; }

        [JsonProperty("guitarClosePedal")]
        BoundingBox GuitarClosePedal { get; set; }

        [JsonProperty("guitarFadeIn")]
        BoundingBox GuitarFadeIn { get; set; }

        [JsonProperty("guitarFadeOut")]
        BoundingBox GuitarFadeOut { get; set; }

        [JsonProperty("guitarGolpe")]
        BoundingBox GuitarGolpe { get; set; }

        [JsonProperty("guitarGolpeFlamenco")]
        BoundingBox GuitarGolpeFlamenco { get; set; }

        [JsonProperty("guitarHalfOpenPedal")]
        BoundingBox GuitarHalfOpenPedal { get; set; }

        [JsonProperty("guitarLeftHandTapping")]
        BoundingBox GuitarLeftHandTapping { get; set; }

        [JsonProperty("guitarOpenPedal")]
        BoundingBox GuitarOpenPedal { get; set; }

        [JsonProperty("guitarRightHandTapping")]
        BoundingBox GuitarRightHandTapping { get; set; }

        [JsonProperty("guitarShake")]
        BoundingBox GuitarShake { get; set; }

        [JsonProperty("guitarString0")]
        BoundingBox GuitarString0 { get; set; }

        [JsonProperty("guitarString1")]
        BoundingBox GuitarString1 { get; set; }

        [JsonProperty("guitarString2")]
        BoundingBox GuitarString2 { get; set; }

        [JsonProperty("guitarString3")]
        BoundingBox GuitarString3 { get; set; }

        [JsonProperty("guitarString4")]
        BoundingBox GuitarString4 { get; set; }

        [JsonProperty("guitarString5")]
        BoundingBox GuitarString5 { get; set; }

        [JsonProperty("guitarString6")]
        BoundingBox GuitarString6 { get; set; }

        [JsonProperty("guitarString7")]
        BoundingBox GuitarString7 { get; set; }

        [JsonProperty("guitarString8")]
        BoundingBox GuitarString8 { get; set; }

        [JsonProperty("guitarString9")]
        BoundingBox GuitarString9 { get; set; }

        [JsonProperty("guitarStrumDown")]
        BoundingBox GuitarStrumDown { get; set; }

        [JsonProperty("guitarStrumUp")]
        BoundingBox GuitarStrumUp { get; set; }

        [JsonProperty("guitarVibratoBarDip")]
        BoundingBox GuitarVibratoBarDip { get; set; }

        [JsonProperty("guitarVibratoBarScoop")]
        BoundingBox GuitarVibratoBarScoop { get; set; }

        [JsonProperty("guitarVibratoStroke")]
        BoundingBox GuitarVibratoStroke { get; set; }

        [JsonProperty("guitarVolumeSwell")]
        BoundingBox GuitarVolumeSwell { get; set; }

        [JsonProperty("guitarWideVibratoStroke")]
        BoundingBox GuitarWideVibratoStroke { get; set; }

        [JsonProperty("handbellsBelltree")]
        BoundingBox HandbellsBelltree { get; set; }

        [JsonProperty("handbellsDamp3")]
        BoundingBox HandbellsDamp3 { get; set; }

        [JsonProperty("handbellsEcho1")]
        BoundingBox HandbellsEcho1 { get; set; }

        [JsonProperty("handbellsEcho2")]
        BoundingBox HandbellsEcho2 { get; set; }

        [JsonProperty("handbellsGyro")]
        BoundingBox HandbellsGyro { get; set; }

        [JsonProperty("handbellsHandMartellato")]
        BoundingBox HandbellsHandMartellato { get; set; }

        [JsonProperty("handbellsMalletBellOnTable")]
        BoundingBox HandbellsMalletBellOnTable { get; set; }

        [JsonProperty("handbellsMalletBellSuspended")]
        BoundingBox HandbellsMalletBellSuspended { get; set; }

        [JsonProperty("handbellsMalletLft")]
        BoundingBox HandbellsMalletLft { get; set; }

        [JsonProperty("handbellsMartellato")]
        BoundingBox HandbellsMartellato { get; set; }

        [JsonProperty("handbellsMartellatoLift")]
        BoundingBox HandbellsMartellatoLift { get; set; }

        [JsonProperty("handbellsMutedMartellato")]
        BoundingBox HandbellsMutedMartellato { get; set; }

        [JsonProperty("handbellsPluckLift")]
        BoundingBox HandbellsPluckLift { get; set; }

        [JsonProperty("handbellsSwing")]
        BoundingBox HandbellsSwing { get; set; }

        [JsonProperty("handbellsSwingDown")]
        BoundingBox HandbellsSwingDown { get; set; }

        [JsonProperty("handbellsSwingUp")]
        BoundingBox HandbellsSwingUp { get; set; }

        [JsonProperty("handbellsTablePairBells")]
        BoundingBox HandbellsTablePairBells { get; set; }

        [JsonProperty("handbellsTableSingleBell")]
        BoundingBox HandbellsTableSingleBell { get; set; }

        [JsonProperty("harpMetalRod")]
        BoundingBox HarpMetalRod { get; set; }

        [JsonProperty("harpMetalRodAlt")]
        BoundingBox HarpMetalRodAlt { get; set; }

        [JsonProperty("harpPedalCentered")]
        BoundingBox HarpPedalCentered { get; set; }

        [JsonProperty("harpPedalDivider")]
        Dictionary<string, long[]> HarpPedalDivider { get; set; }

        [JsonProperty("harpPedalLowered")]
        BoundingBox HarpPedalLowered { get; set; }

        [JsonProperty("harpPedalRaised")]
        BoundingBox HarpPedalRaised { get; set; }

        [JsonProperty("harpSalzedoAeolianAscending")]
        BoundingBox HarpSalzedoAeolianAscending { get; set; }

        [JsonProperty("harpSalzedoAeolianDescending")]
        BoundingBox HarpSalzedoAeolianDescending { get; set; }

        [JsonProperty("harpSalzedoDampAbove")]
        BoundingBox HarpSalzedoDampAbove { get; set; }

        [JsonProperty("harpSalzedoDampBelow")]
        BoundingBox HarpSalzedoDampBelow { get; set; }

        [JsonProperty("harpSalzedoDampBothHands")]
        BoundingBox HarpSalzedoDampBothHands { get; set; }

        [JsonProperty("harpSalzedoDampLowStrings")]
        BoundingBox HarpSalzedoDampLowStrings { get; set; }

        [JsonProperty("harpSalzedoFluidicSoundsLeft")]
        BoundingBox HarpSalzedoFluidicSoundsLeft { get; set; }

        [JsonProperty("harpSalzedoFluidicSoundsRight")]
        BoundingBox HarpSalzedoFluidicSoundsRight { get; set; }

        [JsonProperty("harpSalzedoIsolatedSounds")]
        BoundingBox HarpSalzedoIsolatedSounds { get; set; }

        [JsonProperty("harpSalzedoMetallicSounds")]
        BoundingBox HarpSalzedoMetallicSounds { get; set; }

        [JsonProperty("harpSalzedoMetallicSoundsOneString")]
        BoundingBox HarpSalzedoMetallicSoundsOneString { get; set; }

        [JsonProperty("harpSalzedoMuffleTotally")]
        BoundingBox HarpSalzedoMuffleTotally { get; set; }

        [JsonProperty("harpSalzedoOboicFlux")]
        BoundingBox HarpSalzedoOboicFlux { get; set; }

        [JsonProperty("harpSalzedoPlayUpperEnd")]
        BoundingBox HarpSalzedoPlayUpperEnd { get; set; }

        [JsonProperty("harpSalzedoSlideWithSuppleness")]
        BoundingBox HarpSalzedoSlideWithSuppleness { get; set; }

        [JsonProperty("harpSalzedoSnareDrum")]
        Dictionary<string, long[]> HarpSalzedoSnareDrum { get; set; }

        [JsonProperty("harpSalzedoTamTamSounds")]
        BoundingBox HarpSalzedoTamTamSounds { get; set; }

        [JsonProperty("harpSalzedoThunderEffect")]
        BoundingBox HarpSalzedoThunderEffect { get; set; }

        [JsonProperty("harpSalzedoTimpanicSounds")]
        BoundingBox HarpSalzedoTimpanicSounds { get; set; }

        [JsonProperty("harpSalzedoWhistlingSounds")]
        BoundingBox HarpSalzedoWhistlingSounds { get; set; }

        [JsonProperty("harpStringNoiseStem")]
        BoundingBox HarpStringNoiseStem { get; set; }

        [JsonProperty("harpTuningKey")]
        BoundingBox HarpTuningKey { get; set; }

        [JsonProperty("harpTuningKeyAlt")]
        BoundingBox HarpTuningKeyAlt { get; set; }

        [JsonProperty("harpTuningKeyGlissando")]
        BoundingBox HarpTuningKeyGlissando { get; set; }

        [JsonProperty("harpTuningKeyHandle")]
        BoundingBox HarpTuningKeyHandle { get; set; }

        [JsonProperty("harpTuningKeyShank")]
        BoundingBox HarpTuningKeyShank { get; set; }

        [JsonProperty("keyboardBebung2DotsAbove")]
        BoundingBox KeyboardBebung2DotsAbove { get; set; }

        [JsonProperty("keyboardBebung2DotsBelow")]
        BoundingBox KeyboardBebung2DotsBelow { get; set; }

        [JsonProperty("keyboardBebung3DotsAbove")]
        BoundingBox KeyboardBebung3DotsAbove { get; set; }

        [JsonProperty("keyboardBebung3DotsBelow")]
        BoundingBox KeyboardBebung3DotsBelow { get; set; }

        [JsonProperty("keyboardBebung4DotsAbove")]
        BoundingBox KeyboardBebung4DotsAbove { get; set; }

        [JsonProperty("keyboardBebung4DotsBelow")]
        BoundingBox KeyboardBebung4DotsBelow { get; set; }

        [JsonProperty("keyboardLeftPedalPictogram")]
        BoundingBox KeyboardLeftPedalPictogram { get; set; }

        [JsonProperty("keyboardMiddlePedalPictogram")]
        BoundingBox KeyboardMiddlePedalPictogram { get; set; }

        [JsonProperty("keyboardPedalD")]
        BoundingBox KeyboardPedalD { get; set; }

        [JsonProperty("keyboardPedalDot")]
        BoundingBox KeyboardPedalDot { get; set; }

        [JsonProperty("keyboardPedalE")]
        BoundingBox KeyboardPedalE { get; set; }

        [JsonProperty("keyboardPedalHalf")]
        BoundingBox KeyboardPedalHalf { get; set; }

        [JsonProperty("keyboardPedalHalf2")]
        BoundingBox KeyboardPedalHalf2 { get; set; }

        [JsonProperty("keyboardPedalHalf3")]
        BoundingBox KeyboardPedalHalf3 { get; set; }

        [JsonProperty("keyboardPedalHeel1")]
        BoundingBox KeyboardPedalHeel1 { get; set; }

        [JsonProperty("keyboardPedalHeel2")]
        BoundingBox KeyboardPedalHeel2 { get; set; }

        [JsonProperty("keyboardPedalHeel3")]
        Dictionary<string, long[]> KeyboardPedalHeel3 { get; set; }

        [JsonProperty("keyboardPedalHeelToToe")]
        BoundingBox KeyboardPedalHeelToToe { get; set; }

        [JsonProperty("keyboardPedalHeelToe")]
        BoundingBox KeyboardPedalHeelToe { get; set; }

        [JsonProperty("keyboardPedalHookEnd")]
        BoundingBox KeyboardPedalHookEnd { get; set; }

        [JsonProperty("keyboardPedalHookStart")]
        BoundingBox KeyboardPedalHookStart { get; set; }

        [JsonProperty("keyboardPedalHyphen")]
        BoundingBox KeyboardPedalHyphen { get; set; }

        [JsonProperty("keyboardPedalP")]
        BoundingBox KeyboardPedalP { get; set; }

        [JsonProperty("keyboardPedalPed")]
        BoundingBox KeyboardPedalPed { get; set; }

        [JsonProperty("keyboardPedalPedNoDot")]
        BoundingBox KeyboardPedalPedNoDot { get; set; }

        [JsonProperty("keyboardPedalS")]
        BoundingBox KeyboardPedalS { get; set; }

        [JsonProperty("keyboardPedalSost")]
        BoundingBox KeyboardPedalSost { get; set; }

        [JsonProperty("keyboardPedalSostNoDot")]
        BoundingBox KeyboardPedalSostNoDot { get; set; }

        [JsonProperty("keyboardPedalToe1")]
        BoundingBox KeyboardPedalToe1 { get; set; }

        [JsonProperty("keyboardPedalToe2")]
        BoundingBox KeyboardPedalToe2 { get; set; }

        [JsonProperty("keyboardPedalToeToHeel")]
        BoundingBox KeyboardPedalToeToHeel { get; set; }

        [JsonProperty("keyboardPedalUp")]
        BoundingBox KeyboardPedalUp { get; set; }

        [JsonProperty("keyboardPedalUpNotch")]
        BoundingBox KeyboardPedalUpNotch { get; set; }

        [JsonProperty("keyboardPedalUpSpecial")]
        BoundingBox KeyboardPedalUpSpecial { get; set; }

        [JsonProperty("keyboardPlayWithLH")]
        BoundingBox KeyboardPlayWithLh { get; set; }

        [JsonProperty("keyboardPlayWithLHEnd")]
        BoundingBox KeyboardPlayWithLhEnd { get; set; }

        [JsonProperty("keyboardPlayWithRH")]
        BoundingBox KeyboardPlayWithRh { get; set; }

        [JsonProperty("keyboardPlayWithRHEnd")]
        BoundingBox KeyboardPlayWithRhEnd { get; set; }

        [JsonProperty("keyboardPluckInside")]
        BoundingBox KeyboardPluckInside { get; set; }

        [JsonProperty("keyboardRightPedalPictogram")]
        BoundingBox KeyboardRightPedalPictogram { get; set; }

        [JsonProperty("kievanAccidentalFlat")]
        BoundingBox KievanAccidentalFlat { get; set; }

        [JsonProperty("kievanAccidentalSharp")]
        BoundingBox KievanAccidentalSharp { get; set; }

        [JsonProperty("kievanAugmentationDot")]
        BoundingBox KievanAugmentationDot { get; set; }

        [JsonProperty("kievanCClef")]
        BoundingBox KievanCClef { get; set; }

        [JsonProperty("kievanEndingSymbol")]
        BoundingBox KievanEndingSymbol { get; set; }

        [JsonProperty("kievanNote8thStemDown")]
        BoundingBox KievanNote8ThStemDown { get; set; }

        [JsonProperty("kievanNote8thStemUp")]
        BoundingBox KievanNote8ThStemUp { get; set; }

        [JsonProperty("kievanNoteBeam")]
        BoundingBox KievanNoteBeam { get; set; }

        [JsonProperty("kievanNoteHalfStaffLine")]
        BoundingBox KievanNoteHalfStaffLine { get; set; }

        [JsonProperty("kievanNoteHalfStaffSpace")]
        BoundingBox KievanNoteHalfStaffSpace { get; set; }

        [JsonProperty("kievanNoteQuarterStemDown")]
        BoundingBox KievanNoteQuarterStemDown { get; set; }

        [JsonProperty("kievanNoteQuarterStemUp")]
        BoundingBox KievanNoteQuarterStemUp { get; set; }

        [JsonProperty("kievanNoteReciting")]
        BoundingBox KievanNoteReciting { get; set; }

        [JsonProperty("kievanNoteWhole")]
        BoundingBox KievanNoteWhole { get; set; }

        [JsonProperty("kievanNoteWholeFinal")]
        BoundingBox KievanNoteWholeFinal { get; set; }

        [JsonProperty("kodalyHandDo")]
        BoundingBox KodalyHandDo { get; set; }

        [JsonProperty("kodalyHandFa")]
        BoundingBox KodalyHandFa { get; set; }

        [JsonProperty("kodalyHandLa")]
        BoundingBox KodalyHandLa { get; set; }

        [JsonProperty("kodalyHandMi")]
        BoundingBox KodalyHandMi { get; set; }

        [JsonProperty("kodalyHandRe")]
        BoundingBox KodalyHandRe { get; set; }

        [JsonProperty("kodalyHandSo")]
        BoundingBox KodalyHandSo { get; set; }

        [JsonProperty("kodalyHandTi")]
        BoundingBox KodalyHandTi { get; set; }

        [JsonProperty("leftRepeatSmall")]
        BoundingBox LeftRepeatSmall { get; set; }

        [JsonProperty("legerLine")]
        BoundingBox LegerLine { get; set; }

        [JsonProperty("legerLineNarrow")]
        BoundingBox LegerLineNarrow { get; set; }

        [JsonProperty("legerLineWide")]
        BoundingBox LegerLineWide { get; set; }

        [JsonProperty("luteBarlineEndRepeat")]
        BoundingBox LuteBarlineEndRepeat { get; set; }

        [JsonProperty("luteBarlineFinal")]
        BoundingBox LuteBarlineFinal { get; set; }

        [JsonProperty("luteBarlineStartRepeat")]
        BoundingBox LuteBarlineStartRepeat { get; set; }

        [JsonProperty("luteDuration16th")]
        BoundingBox LuteDuration16Th { get; set; }

        [JsonProperty("luteDuration32nd")]
        BoundingBox LuteDuration32Nd { get; set; }

        [JsonProperty("luteDuration8th")]
        BoundingBox LuteDuration8Th { get; set; }

        [JsonProperty("luteDurationDoubleWhole")]
        BoundingBox LuteDurationDoubleWhole { get; set; }

        [JsonProperty("luteDurationHalf")]
        BoundingBox LuteDurationHalf { get; set; }

        [JsonProperty("luteDurationQuarter")]
        BoundingBox LuteDurationQuarter { get; set; }

        [JsonProperty("luteDurationWhole")]
        BoundingBox LuteDurationWhole { get; set; }

        [JsonProperty("luteFingeringRHFirst")]
        BoundingBox LuteFingeringRhFirst { get; set; }

        [JsonProperty("luteFingeringRHSecond")]
        BoundingBox LuteFingeringRhSecond { get; set; }

        [JsonProperty("luteFingeringRHThird")]
        BoundingBox LuteFingeringRhThird { get; set; }

        [JsonProperty("luteFingeringRHThirdAlt")]
        BoundingBox LuteFingeringRhThirdAlt { get; set; }

        [JsonProperty("luteFingeringRHThumb")]
        BoundingBox LuteFingeringRhThumb { get; set; }

        [JsonProperty("luteFrench10thCourse")]
        BoundingBox LuteFrench10ThCourse { get; set; }

        [JsonProperty("luteFrench10thCourseRight")]
        BoundingBox LuteFrench10ThCourseRight { get; set; }

        [JsonProperty("luteFrench10thCourseStrikethru")]
        BoundingBox LuteFrench10ThCourseStrikethru { get; set; }

        [JsonProperty("luteFrench10thCourseUnderline")]
        BoundingBox LuteFrench10ThCourseUnderline { get; set; }

        [JsonProperty("luteFrench7thCourse")]
        BoundingBox LuteFrench7ThCourse { get; set; }

        [JsonProperty("luteFrench7thCourseRight")]
        BoundingBox LuteFrench7ThCourseRight { get; set; }

        [JsonProperty("luteFrench7thCourseStrikethru")]
        BoundingBox LuteFrench7ThCourseStrikethru { get; set; }

        [JsonProperty("luteFrench7thCourseUnderline")]
        BoundingBox LuteFrench7ThCourseUnderline { get; set; }

        [JsonProperty("luteFrench8thCourse")]
        BoundingBox LuteFrench8ThCourse { get; set; }

        [JsonProperty("luteFrench8thCourseRight")]
        BoundingBox LuteFrench8ThCourseRight { get; set; }

        [JsonProperty("luteFrench8thCourseStrikethru")]
        BoundingBox LuteFrench8ThCourseStrikethru { get; set; }

        [JsonProperty("luteFrench8thCourseUnderline")]
        BoundingBox LuteFrench8ThCourseUnderline { get; set; }

        [JsonProperty("luteFrench9thCourse")]
        BoundingBox LuteFrench9ThCourse { get; set; }

        [JsonProperty("luteFrench9thCourseRight")]
        BoundingBox LuteFrench9ThCourseRight { get; set; }

        [JsonProperty("luteFrench9thCourseStrikethru")]
        BoundingBox LuteFrench9ThCourseStrikethru { get; set; }

        [JsonProperty("luteFrench9thCourseUnderline")]
        BoundingBox LuteFrench9ThCourseUnderline { get; set; }

        [JsonProperty("luteFrenchAppoggiaturaAbove")]
        BoundingBox LuteFrenchAppoggiaturaAbove { get; set; }

        [JsonProperty("luteFrenchAppoggiaturaBelow")]
        BoundingBox LuteFrenchAppoggiaturaBelow { get; set; }

        [JsonProperty("luteFrenchFretA")]
        BoundingBox LuteFrenchFretA { get; set; }

        [JsonProperty("luteFrenchFretB")]
        BoundingBox LuteFrenchFretB { get; set; }

        [JsonProperty("luteFrenchFretC")]
        BoundingBox LuteFrenchFretC { get; set; }

        [JsonProperty("luteFrenchFretCAlt")]
        BoundingBox LuteFrenchFretCAlt { get; set; }

        [JsonProperty("luteFrenchFretD")]
        BoundingBox LuteFrenchFretD { get; set; }

        [JsonProperty("luteFrenchFretE")]
        BoundingBox LuteFrenchFretE { get; set; }

        [JsonProperty("luteFrenchFretF")]
        BoundingBox LuteFrenchFretF { get; set; }

        [JsonProperty("luteFrenchFretG")]
        BoundingBox LuteFrenchFretG { get; set; }

        [JsonProperty("luteFrenchFretH")]
        BoundingBox LuteFrenchFretH { get; set; }

        [JsonProperty("luteFrenchFretI")]
        BoundingBox LuteFrenchFretI { get; set; }

        [JsonProperty("luteFrenchFretK")]
        BoundingBox LuteFrenchFretK { get; set; }

        [JsonProperty("luteFrenchFretL")]
        BoundingBox LuteFrenchFretL { get; set; }

        [JsonProperty("luteFrenchFretM")]
        BoundingBox LuteFrenchFretM { get; set; }

        [JsonProperty("luteFrenchFretN")]
        BoundingBox LuteFrenchFretN { get; set; }

        [JsonProperty("luteFrenchMordentInverted")]
        BoundingBox LuteFrenchMordentInverted { get; set; }

        [JsonProperty("luteFrenchMordentLower")]
        BoundingBox LuteFrenchMordentLower { get; set; }

        [JsonProperty("luteFrenchMordentUpper")]
        BoundingBox LuteFrenchMordentUpper { get; set; }

        [JsonProperty("luteGermanALower")]
        BoundingBox LuteGermanALower { get; set; }

        [JsonProperty("luteGermanAUpper")]
        BoundingBox LuteGermanAUpper { get; set; }

        [JsonProperty("luteGermanBLower")]
        BoundingBox LuteGermanBLower { get; set; }

        [JsonProperty("luteGermanBUpper")]
        BoundingBox LuteGermanBUpper { get; set; }

        [JsonProperty("luteGermanCLower")]
        BoundingBox LuteGermanCLower { get; set; }

        [JsonProperty("luteGermanCUpper")]
        BoundingBox LuteGermanCUpper { get; set; }

        [JsonProperty("luteGermanDLower")]
        BoundingBox LuteGermanDLower { get; set; }

        [JsonProperty("luteGermanDUpper")]
        BoundingBox LuteGermanDUpper { get; set; }

        [JsonProperty("luteGermanELower")]
        BoundingBox LuteGermanELower { get; set; }

        [JsonProperty("luteGermanEUpper")]
        BoundingBox LuteGermanEUpper { get; set; }

        [JsonProperty("luteGermanFLower")]
        BoundingBox LuteGermanFLower { get; set; }

        [JsonProperty("luteGermanFUpper")]
        BoundingBox LuteGermanFUpper { get; set; }

        [JsonProperty("luteGermanGLower")]
        BoundingBox LuteGermanGLower { get; set; }

        [JsonProperty("luteGermanGUpper")]
        BoundingBox LuteGermanGUpper { get; set; }

        [JsonProperty("luteGermanHLower")]
        BoundingBox LuteGermanHLower { get; set; }

        [JsonProperty("luteGermanHUpper")]
        BoundingBox LuteGermanHUpper { get; set; }

        [JsonProperty("luteGermanILower")]
        BoundingBox LuteGermanILower { get; set; }

        [JsonProperty("luteGermanIUpper")]
        BoundingBox LuteGermanIUpper { get; set; }

        [JsonProperty("luteGermanKLower")]
        BoundingBox LuteGermanKLower { get; set; }

        [JsonProperty("luteGermanKUpper")]
        BoundingBox LuteGermanKUpper { get; set; }

        [JsonProperty("luteGermanLLower")]
        BoundingBox LuteGermanLLower { get; set; }

        [JsonProperty("luteGermanLUpper")]
        BoundingBox LuteGermanLUpper { get; set; }

        [JsonProperty("luteGermanMLower")]
        BoundingBox LuteGermanMLower { get; set; }

        [JsonProperty("luteGermanMUpper")]
        BoundingBox LuteGermanMUpper { get; set; }

        [JsonProperty("luteGermanNLower")]
        BoundingBox LuteGermanNLower { get; set; }

        [JsonProperty("luteGermanNUpper")]
        BoundingBox LuteGermanNUpper { get; set; }

        [JsonProperty("luteGermanOLower")]
        BoundingBox LuteGermanOLower { get; set; }

        [JsonProperty("luteGermanPLower")]
        BoundingBox LuteGermanPLower { get; set; }

        [JsonProperty("luteGermanQLower")]
        BoundingBox LuteGermanQLower { get; set; }

        [JsonProperty("luteGermanRLower")]
        BoundingBox LuteGermanRLower { get; set; }

        [JsonProperty("luteGermanSLower")]
        BoundingBox LuteGermanSLower { get; set; }

        [JsonProperty("luteGermanTLower")]
        BoundingBox LuteGermanTLower { get; set; }

        [JsonProperty("luteGermanVLower")]
        BoundingBox LuteGermanVLower { get; set; }

        [JsonProperty("luteGermanXLower")]
        BoundingBox LuteGermanXLower { get; set; }

        [JsonProperty("luteGermanYLower")]
        BoundingBox LuteGermanYLower { get; set; }

        [JsonProperty("luteGermanZLower")]
        BoundingBox LuteGermanZLower { get; set; }

        [JsonProperty("luteItalianClefCSolFaUt")]
        BoundingBox LuteItalianClefCSolFaUt { get; set; }

        [JsonProperty("luteItalianClefFFaUt")]
        BoundingBox LuteItalianClefFFaUt { get; set; }

        [JsonProperty("luteItalianFret0")]
        BoundingBox LuteItalianFret0 { get; set; }

        [JsonProperty("luteItalianFret1")]
        BoundingBox LuteItalianFret1 { get; set; }

        [JsonProperty("luteItalianFret2")]
        BoundingBox LuteItalianFret2 { get; set; }

        [JsonProperty("luteItalianFret3")]
        BoundingBox LuteItalianFret3 { get; set; }

        [JsonProperty("luteItalianFret4")]
        BoundingBox LuteItalianFret4 { get; set; }

        [JsonProperty("luteItalianFret5")]
        BoundingBox LuteItalianFret5 { get; set; }

        [JsonProperty("luteItalianFret6")]
        BoundingBox LuteItalianFret6 { get; set; }

        [JsonProperty("luteItalianFret7")]
        BoundingBox LuteItalianFret7 { get; set; }

        [JsonProperty("luteItalianFret8")]
        BoundingBox LuteItalianFret8 { get; set; }

        [JsonProperty("luteItalianFret9")]
        BoundingBox LuteItalianFret9 { get; set; }

        [JsonProperty("luteItalianHoldFinger")]
        BoundingBox LuteItalianHoldFinger { get; set; }

        [JsonProperty("luteItalianHoldNote")]
        BoundingBox LuteItalianHoldNote { get; set; }

        [JsonProperty("luteItalianReleaseFinger")]
        BoundingBox LuteItalianReleaseFinger { get; set; }

        [JsonProperty("luteItalianTempoFast")]
        BoundingBox LuteItalianTempoFast { get; set; }

        [JsonProperty("luteItalianTempoNeitherFastNorSlow")]
        BoundingBox LuteItalianTempoNeitherFastNorSlow { get; set; }

        [JsonProperty("luteItalianTempoSlow")]
        BoundingBox LuteItalianTempoSlow { get; set; }

        [JsonProperty("luteItalianTempoSomewhatFast")]
        BoundingBox LuteItalianTempoSomewhatFast { get; set; }

        [JsonProperty("luteItalianTempoVerySlow")]
        BoundingBox LuteItalianTempoVerySlow { get; set; }

        [JsonProperty("luteItalianTimeTriple")]
        BoundingBox LuteItalianTimeTriple { get; set; }

        [JsonProperty("luteItalianTremolo")]
        BoundingBox LuteItalianTremolo { get; set; }

        [JsonProperty("luteItalianVibrato")]
        BoundingBox LuteItalianVibrato { get; set; }

        [JsonProperty("luteStaff6Lines")]
        BoundingBox LuteStaff6Lines { get; set; }

        [JsonProperty("luteStaff6LinesNarrow")]
        BoundingBox LuteStaff6LinesNarrow { get; set; }

        [JsonProperty("luteStaff6LinesWide")]
        BoundingBox LuteStaff6LinesWide { get; set; }

        [JsonProperty("lyricsElision")]
        BoundingBox LyricsElision { get; set; }

        [JsonProperty("lyricsElisionNarrow")]
        BoundingBox LyricsElisionNarrow { get; set; }

        [JsonProperty("lyricsElisionWide")]
        BoundingBox LyricsElisionWide { get; set; }

        [JsonProperty("lyricsHyphenBaseline")]
        BoundingBox LyricsHyphenBaseline { get; set; }

        [JsonProperty("lyricsHyphenBaselineNonBreaking")]
        BoundingBox LyricsHyphenBaselineNonBreaking { get; set; }

        [JsonProperty("medRenFlatHardB")]
        BoundingBox MedRenFlatHardB { get; set; }

        [JsonProperty("medRenFlatSoftB")]
        BoundingBox MedRenFlatSoftB { get; set; }

        [JsonProperty("medRenFlatSoftBHufnagel")]
        BoundingBox MedRenFlatSoftBHufnagel { get; set; }

        [JsonProperty("medRenFlatSoftBOld")]
        BoundingBox MedRenFlatSoftBOld { get; set; }

        [JsonProperty("medRenFlatWithDot")]
        BoundingBox MedRenFlatWithDot { get; set; }

        [JsonProperty("medRenGClefCMN")]
        BoundingBox MedRenGClefCmn { get; set; }

        [JsonProperty("medRenLiquescenceCMN")]
        BoundingBox MedRenLiquescenceCmn { get; set; }

        [JsonProperty("medRenLiquescentAscCMN")]
        BoundingBox MedRenLiquescentAscCmn { get; set; }

        [JsonProperty("medRenLiquescentDescCMN")]
        BoundingBox MedRenLiquescentDescCmn { get; set; }

        [JsonProperty("medRenNatural")]
        BoundingBox MedRenNatural { get; set; }

        [JsonProperty("medRenNaturalWithCross")]
        BoundingBox MedRenNaturalWithCross { get; set; }

        [JsonProperty("medRenOriscusCMN")]
        BoundingBox MedRenOriscusCmn { get; set; }

        [JsonProperty("medRenPlicaCMN")]
        BoundingBox MedRenPlicaCmn { get; set; }

        [JsonProperty("medRenPunctumCMN")]
        BoundingBox MedRenPunctumCmn { get; set; }

        [JsonProperty("medRenQuilismaCMN")]
        BoundingBox MedRenQuilismaCmn { get; set; }

        [JsonProperty("medRenSharpCroix")]
        BoundingBox MedRenSharpCroix { get; set; }

        [JsonProperty("medRenStrophicusCMN")]
        BoundingBox MedRenStrophicusCmn { get; set; }

        [JsonProperty("mensuralAlterationSign")]
        BoundingBox MensuralAlterationSign { get; set; }

        [JsonProperty("mensuralBlackBrevis")]
        BoundingBox MensuralBlackBrevis { get; set; }

        [JsonProperty("mensuralBlackBrevisVoid")]
        BoundingBox MensuralBlackBrevisVoid { get; set; }

        [JsonProperty("mensuralBlackDragma")]
        BoundingBox MensuralBlackDragma { get; set; }

        [JsonProperty("mensuralBlackLonga")]
        BoundingBox MensuralBlackLonga { get; set; }

        [JsonProperty("mensuralBlackMaxima")]
        BoundingBox MensuralBlackMaxima { get; set; }

        [JsonProperty("mensuralBlackMinima")]
        BoundingBox MensuralBlackMinima { get; set; }

        [JsonProperty("mensuralBlackMinimaVoid")]
        BoundingBox MensuralBlackMinimaVoid { get; set; }

        [JsonProperty("mensuralBlackSemibrevis")]
        BoundingBox MensuralBlackSemibrevis { get; set; }

        [JsonProperty("mensuralBlackSemibrevisCaudata")]
        BoundingBox MensuralBlackSemibrevisCaudata { get; set; }

        [JsonProperty("mensuralBlackSemibrevisOblique")]
        BoundingBox MensuralBlackSemibrevisOblique { get; set; }

        [JsonProperty("mensuralBlackSemibrevisVoid")]
        BoundingBox MensuralBlackSemibrevisVoid { get; set; }

        [JsonProperty("mensuralBlackSemiminima")]
        BoundingBox MensuralBlackSemiminima { get; set; }

        [JsonProperty("mensuralCclef")]
        BoundingBox MensuralCclef { get; set; }

        [JsonProperty("mensuralCclefBlack")]
        BoundingBox MensuralCclefBlack { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosHigh")]
        BoundingBox MensuralCclefPetrucciPosHigh { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosHighest")]
        BoundingBox MensuralCclefPetrucciPosHighest { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosLow")]
        BoundingBox MensuralCclefPetrucciPosLow { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosLowest")]
        BoundingBox MensuralCclefPetrucciPosLowest { get; set; }

        [JsonProperty("mensuralCclefPetrucciPosMiddle")]
        BoundingBox MensuralCclefPetrucciPosMiddle { get; set; }

        [JsonProperty("mensuralCclefVoid")]
        BoundingBox MensuralCclefVoid { get; set; }

        [JsonProperty("mensuralColorationEndRound")]
        BoundingBox MensuralColorationEndRound { get; set; }

        [JsonProperty("mensuralColorationEndSquare")]
        BoundingBox MensuralColorationEndSquare { get; set; }

        [JsonProperty("mensuralColorationStartRound")]
        BoundingBox MensuralColorationStartRound { get; set; }

        [JsonProperty("mensuralColorationStartSquare")]
        BoundingBox MensuralColorationStartSquare { get; set; }

        [JsonProperty("mensuralCombStemDiagonal")]
        BoundingBox MensuralCombStemDiagonal { get; set; }

        [JsonProperty("mensuralCombStemDown")]
        BoundingBox MensuralCombStemDown { get; set; }

        [JsonProperty("mensuralCombStemDownFlagExtended")]
        BoundingBox MensuralCombStemDownFlagExtended { get; set; }

        [JsonProperty("mensuralCombStemDownFlagFlared")]
        BoundingBox MensuralCombStemDownFlagFlared { get; set; }

        [JsonProperty("mensuralCombStemDownFlagFusa")]
        BoundingBox MensuralCombStemDownFlagFusa { get; set; }

        [JsonProperty("mensuralCombStemDownFlagLeft")]
        BoundingBox MensuralCombStemDownFlagLeft { get; set; }

        [JsonProperty("mensuralCombStemDownFlagRight")]
        BoundingBox MensuralCombStemDownFlagRight { get; set; }

        [JsonProperty("mensuralCombStemDownFlagSemiminima")]
        BoundingBox MensuralCombStemDownFlagSemiminima { get; set; }

        [JsonProperty("mensuralCombStemUp")]
        BoundingBox MensuralCombStemUp { get; set; }

        [JsonProperty("mensuralCombStemUpFlagExtended")]
        BoundingBox MensuralCombStemUpFlagExtended { get; set; }

        [JsonProperty("mensuralCombStemUpFlagFlared")]
        BoundingBox MensuralCombStemUpFlagFlared { get; set; }

        [JsonProperty("mensuralCombStemUpFlagFusa")]
        BoundingBox MensuralCombStemUpFlagFusa { get; set; }

        [JsonProperty("mensuralCombStemUpFlagLeft")]
        BoundingBox MensuralCombStemUpFlagLeft { get; set; }

        [JsonProperty("mensuralCombStemUpFlagRight")]
        BoundingBox MensuralCombStemUpFlagRight { get; set; }

        [JsonProperty("mensuralCombStemUpFlagSemiminima")]
        BoundingBox MensuralCombStemUpFlagSemiminima { get; set; }

        [JsonProperty("mensuralCustosCheckmark")]
        BoundingBox MensuralCustosCheckmark { get; set; }

        [JsonProperty("mensuralCustosDown")]
        BoundingBox MensuralCustosDown { get; set; }

        [JsonProperty("mensuralCustosTurn")]
        BoundingBox MensuralCustosTurn { get; set; }

        [JsonProperty("mensuralCustosUp")]
        BoundingBox MensuralCustosUp { get; set; }

        [JsonProperty("mensuralFclef")]
        BoundingBox MensuralFclef { get; set; }

        [JsonProperty("mensuralFclefPetrucci")]
        BoundingBox MensuralFclefPetrucci { get; set; }

        [JsonProperty("mensuralFusaBlackStemDown")]
        BoundingBox MensuralFusaBlackStemDown { get; set; }

        [JsonProperty("mensuralFusaBlackStemUp")]
        BoundingBox MensuralFusaBlackStemUp { get; set; }

        [JsonProperty("mensuralFusaBlackVoidStemDown")]
        BoundingBox MensuralFusaBlackVoidStemDown { get; set; }

        [JsonProperty("mensuralFusaBlackVoidStemUp")]
        BoundingBox MensuralFusaBlackVoidStemUp { get; set; }

        [JsonProperty("mensuralFusaVoidStemDown")]
        BoundingBox MensuralFusaVoidStemDown { get; set; }

        [JsonProperty("mensuralFusaVoidStemUp")]
        BoundingBox MensuralFusaVoidStemUp { get; set; }

        [JsonProperty("mensuralGclef")]
        BoundingBox MensuralGclef { get; set; }

        [JsonProperty("mensuralGclefPetrucci")]
        BoundingBox MensuralGclefPetrucci { get; set; }

        [JsonProperty("mensuralLongaBlackStemDownLeft")]
        BoundingBox MensuralLongaBlackStemDownLeft { get; set; }

        [JsonProperty("mensuralLongaBlackStemDownRight")]
        BoundingBox MensuralLongaBlackStemDownRight { get; set; }

        [JsonProperty("mensuralLongaBlackStemUpLeft")]
        BoundingBox MensuralLongaBlackStemUpLeft { get; set; }

        [JsonProperty("mensuralLongaBlackStemUpRight")]
        BoundingBox MensuralLongaBlackStemUpRight { get; set; }

        [JsonProperty("mensuralLongaBlackVoidStemDownLeft")]
        BoundingBox MensuralLongaBlackVoidStemDownLeft { get; set; }

        [JsonProperty("mensuralLongaBlackVoidStemDownRight")]
        BoundingBox MensuralLongaBlackVoidStemDownRight { get; set; }

        [JsonProperty("mensuralLongaBlackVoidStemUpLeft")]
        BoundingBox MensuralLongaBlackVoidStemUpLeft { get; set; }

        [JsonProperty("mensuralLongaBlackVoidStemUpRight")]
        BoundingBox MensuralLongaBlackVoidStemUpRight { get; set; }

        [JsonProperty("mensuralLongaVoidStemDownLeft")]
        BoundingBox MensuralLongaVoidStemDownLeft { get; set; }

        [JsonProperty("mensuralLongaVoidStemDownRight")]
        BoundingBox MensuralLongaVoidStemDownRight { get; set; }

        [JsonProperty("mensuralLongaVoidStemUpLeft")]
        BoundingBox MensuralLongaVoidStemUpLeft { get; set; }

        [JsonProperty("mensuralLongaVoidStemUpRight")]
        BoundingBox MensuralLongaVoidStemUpRight { get; set; }

        [JsonProperty("mensuralMaximaBlackStemDownLeft")]
        BoundingBox MensuralMaximaBlackStemDownLeft { get; set; }

        [JsonProperty("mensuralMaximaBlackStemDownRight")]
        BoundingBox MensuralMaximaBlackStemDownRight { get; set; }

        [JsonProperty("mensuralMaximaBlackStemUpLeft")]
        BoundingBox MensuralMaximaBlackStemUpLeft { get; set; }

        [JsonProperty("mensuralMaximaBlackStemUpRight")]
        BoundingBox MensuralMaximaBlackStemUpRight { get; set; }

        [JsonProperty("mensuralMaximaBlackVoidStemDownLeft")]
        BoundingBox MensuralMaximaBlackVoidStemDownLeft { get; set; }

        [JsonProperty("mensuralMaximaBlackVoidStemDownRight")]
        BoundingBox MensuralMaximaBlackVoidStemDownRight { get; set; }

        [JsonProperty("mensuralMaximaBlackVoidStemUpLeft")]
        BoundingBox MensuralMaximaBlackVoidStemUpLeft { get; set; }

        [JsonProperty("mensuralMaximaBlackVoidStemUpRight")]
        BoundingBox MensuralMaximaBlackVoidStemUpRight { get; set; }

        [JsonProperty("mensuralMaximaVoidStemDownLeft")]
        BoundingBox MensuralMaximaVoidStemDownLeft { get; set; }

        [JsonProperty("mensuralMaximaVoidStemDownRight")]
        BoundingBox MensuralMaximaVoidStemDownRight { get; set; }

        [JsonProperty("mensuralMaximaVoidStemUpLeft")]
        BoundingBox MensuralMaximaVoidStemUpLeft { get; set; }

        [JsonProperty("mensuralMaximaVoidStemUpRight")]
        BoundingBox MensuralMaximaVoidStemUpRight { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDown")]
        BoundingBox MensuralMinimaBlackStemDown { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDownExtendedFlag")]
        BoundingBox MensuralMinimaBlackStemDownExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDownFlagLeft")]
        BoundingBox MensuralMinimaBlackStemDownFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDownFlagRight")]
        BoundingBox MensuralMinimaBlackStemDownFlagRight { get; set; }

        [JsonProperty("mensuralMinimaBlackStemDownFlaredFlag")]
        BoundingBox MensuralMinimaBlackStemDownFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUp")]
        BoundingBox MensuralMinimaBlackStemUp { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUpExtendedFlag")]
        BoundingBox MensuralMinimaBlackStemUpExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUpFlagLeft")]
        BoundingBox MensuralMinimaBlackStemUpFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUpFlagRight")]
        BoundingBox MensuralMinimaBlackStemUpFlagRight { get; set; }

        [JsonProperty("mensuralMinimaBlackStemUpFlaredFlag")]
        BoundingBox MensuralMinimaBlackStemUpFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDown")]
        BoundingBox MensuralMinimaBlackVoidStemDown { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDownExtendedFlag")]
        BoundingBox MensuralMinimaBlackVoidStemDownExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDownFlagLeft")]
        BoundingBox MensuralMinimaBlackVoidStemDownFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDownFlagRight")]
        BoundingBox MensuralMinimaBlackVoidStemDownFlagRight { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemDownFlaredFlag")]
        BoundingBox MensuralMinimaBlackVoidStemDownFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUp")]
        BoundingBox MensuralMinimaBlackVoidStemUp { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUpExtendedFlag")]
        BoundingBox MensuralMinimaBlackVoidStemUpExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUpFlagLeft")]
        BoundingBox MensuralMinimaBlackVoidStemUpFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUpFlagRight")]
        BoundingBox MensuralMinimaBlackVoidStemUpFlagRight { get; set; }

        [JsonProperty("mensuralMinimaBlackVoidStemUpFlaredFlag")]
        BoundingBox MensuralMinimaBlackVoidStemUpFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDown")]
        BoundingBox MensuralMinimaVoidStemDown { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDownExtendedFlag")]
        BoundingBox MensuralMinimaVoidStemDownExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDownFlagLeft")]
        BoundingBox MensuralMinimaVoidStemDownFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDownFlagRight")]
        BoundingBox MensuralMinimaVoidStemDownFlagRight { get; set; }

        [JsonProperty("mensuralMinimaVoidStemDownFlaredFlag")]
        BoundingBox MensuralMinimaVoidStemDownFlaredFlag { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUp")]
        BoundingBox MensuralMinimaVoidStemUp { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUpExtendedFlag")]
        BoundingBox MensuralMinimaVoidStemUpExtendedFlag { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUpFlagLeft")]
        BoundingBox MensuralMinimaVoidStemUpFlagLeft { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUpFlagRight")]
        BoundingBox MensuralMinimaVoidStemUpFlagRight { get; set; }

        [JsonProperty("mensuralMinimaVoidStemUpFlaredFlag")]
        BoundingBox MensuralMinimaVoidStemUpFlaredFlag { get; set; }

        [JsonProperty("mensuralModusImperfectumVert")]
        BoundingBox MensuralModusImperfectumVert { get; set; }

        [JsonProperty("mensuralModusPerfectumVert")]
        BoundingBox MensuralModusPerfectumVert { get; set; }

        [JsonProperty("mensuralNoteheadLongaBlack")]
        BoundingBox MensuralNoteheadLongaBlack { get; set; }

        [JsonProperty("mensuralNoteheadLongaBlackVoid")]
        BoundingBox MensuralNoteheadLongaBlackVoid { get; set; }

        [JsonProperty("mensuralNoteheadLongaVoid")]
        BoundingBox MensuralNoteheadLongaVoid { get; set; }

        [JsonProperty("mensuralNoteheadLongaWhite")]
        BoundingBox MensuralNoteheadLongaWhite { get; set; }

        [JsonProperty("mensuralNoteheadMaximaBlack")]
        BoundingBox MensuralNoteheadMaximaBlack { get; set; }

        [JsonProperty("mensuralNoteheadMaximaBlackVoid")]
        BoundingBox MensuralNoteheadMaximaBlackVoid { get; set; }

        [JsonProperty("mensuralNoteheadMaximaVoid")]
        BoundingBox MensuralNoteheadMaximaVoid { get; set; }

        [JsonProperty("mensuralNoteheadMaximaWhite")]
        BoundingBox MensuralNoteheadMaximaWhite { get; set; }

        [JsonProperty("mensuralNoteheadMinimaWhite")]
        BoundingBox MensuralNoteheadMinimaWhite { get; set; }

        [JsonProperty("mensuralNoteheadSemibrevisBlack")]
        BoundingBox MensuralNoteheadSemibrevisBlack { get; set; }

        [JsonProperty("mensuralNoteheadSemibrevisBlackVoid")]
        BoundingBox MensuralNoteheadSemibrevisBlackVoid { get; set; }

        [JsonProperty("mensuralNoteheadSemibrevisBlackVoidTurned")]
        BoundingBox MensuralNoteheadSemibrevisBlackVoidTurned { get; set; }

        [JsonProperty("mensuralNoteheadSemibrevisVoid")]
        BoundingBox MensuralNoteheadSemibrevisVoid { get; set; }

        [JsonProperty("mensuralNoteheadSemiminimaWhite")]
        BoundingBox MensuralNoteheadSemiminimaWhite { get; set; }

        [JsonProperty("mensuralObliqueAsc2ndBlack")]
        BoundingBox MensuralObliqueAsc2NdBlack { get; set; }

        [JsonProperty("mensuralObliqueAsc2ndBlackVoid")]
        BoundingBox MensuralObliqueAsc2NdBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc2ndVoid")]
        BoundingBox MensuralObliqueAsc2NdVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc2ndWhite")]
        BoundingBox MensuralObliqueAsc2NdWhite { get; set; }

        [JsonProperty("mensuralObliqueAsc3rdBlack")]
        BoundingBox MensuralObliqueAsc3RdBlack { get; set; }

        [JsonProperty("mensuralObliqueAsc3rdBlackVoid")]
        BoundingBox MensuralObliqueAsc3RdBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc3rdVoid")]
        BoundingBox MensuralObliqueAsc3RdVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc3rdWhite")]
        BoundingBox MensuralObliqueAsc3RdWhite { get; set; }

        [JsonProperty("mensuralObliqueAsc4thBlack")]
        BoundingBox MensuralObliqueAsc4ThBlack { get; set; }

        [JsonProperty("mensuralObliqueAsc4thBlackVoid")]
        BoundingBox MensuralObliqueAsc4ThBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc4thVoid")]
        BoundingBox MensuralObliqueAsc4ThVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc4thWhite")]
        BoundingBox MensuralObliqueAsc4ThWhite { get; set; }

        [JsonProperty("mensuralObliqueAsc5thBlack")]
        BoundingBox MensuralObliqueAsc5ThBlack { get; set; }

        [JsonProperty("mensuralObliqueAsc5thBlackVoid")]
        BoundingBox MensuralObliqueAsc5ThBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc5thVoid")]
        BoundingBox MensuralObliqueAsc5ThVoid { get; set; }

        [JsonProperty("mensuralObliqueAsc5thWhite")]
        BoundingBox MensuralObliqueAsc5ThWhite { get; set; }

        [JsonProperty("mensuralObliqueDesc2ndBlack")]
        BoundingBox MensuralObliqueDesc2NdBlack { get; set; }

        [JsonProperty("mensuralObliqueDesc2ndBlackVoid")]
        BoundingBox MensuralObliqueDesc2NdBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc2ndVoid")]
        BoundingBox MensuralObliqueDesc2NdVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc2ndWhite")]
        BoundingBox MensuralObliqueDesc2NdWhite { get; set; }

        [JsonProperty("mensuralObliqueDesc3rdBlack")]
        BoundingBox MensuralObliqueDesc3RdBlack { get; set; }

        [JsonProperty("mensuralObliqueDesc3rdBlackVoid")]
        BoundingBox MensuralObliqueDesc3RdBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc3rdVoid")]
        BoundingBox MensuralObliqueDesc3RdVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc3rdWhite")]
        BoundingBox MensuralObliqueDesc3RdWhite { get; set; }

        [JsonProperty("mensuralObliqueDesc4thBlack")]
        BoundingBox MensuralObliqueDesc4ThBlack { get; set; }

        [JsonProperty("mensuralObliqueDesc4thBlackVoid")]
        BoundingBox MensuralObliqueDesc4ThBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc4thVoid")]
        BoundingBox MensuralObliqueDesc4ThVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc4thWhite")]
        BoundingBox MensuralObliqueDesc4ThWhite { get; set; }

        [JsonProperty("mensuralObliqueDesc5thBlack")]
        BoundingBox MensuralObliqueDesc5ThBlack { get; set; }

        [JsonProperty("mensuralObliqueDesc5thBlackVoid")]
        BoundingBox MensuralObliqueDesc5ThBlackVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc5thVoid")]
        BoundingBox MensuralObliqueDesc5ThVoid { get; set; }

        [JsonProperty("mensuralObliqueDesc5thWhite")]
        BoundingBox MensuralObliqueDesc5ThWhite { get; set; }

        [JsonProperty("mensuralProlation1")]
        BoundingBox MensuralProlation1 { get; set; }

        [JsonProperty("mensuralProlation10")]
        BoundingBox MensuralProlation10 { get; set; }

        [JsonProperty("mensuralProlation11")]
        BoundingBox MensuralProlation11 { get; set; }

        [JsonProperty("mensuralProlation2")]
        BoundingBox MensuralProlation2 { get; set; }

        [JsonProperty("mensuralProlation3")]
        BoundingBox MensuralProlation3 { get; set; }

        [JsonProperty("mensuralProlation4")]
        BoundingBox MensuralProlation4 { get; set; }

        [JsonProperty("mensuralProlation5")]
        BoundingBox MensuralProlation5 { get; set; }

        [JsonProperty("mensuralProlation6")]
        BoundingBox MensuralProlation6 { get; set; }

        [JsonProperty("mensuralProlation7")]
        BoundingBox MensuralProlation7 { get; set; }

        [JsonProperty("mensuralProlation8")]
        BoundingBox MensuralProlation8 { get; set; }

        [JsonProperty("mensuralProlation9")]
        BoundingBox MensuralProlation9 { get; set; }

        [JsonProperty("mensuralProlationCombiningDot")]
        BoundingBox MensuralProlationCombiningDot { get; set; }

        [JsonProperty("mensuralProlationCombiningDotVoid")]
        BoundingBox MensuralProlationCombiningDotVoid { get; set; }

        [JsonProperty("mensuralProlationCombiningStroke")]
        BoundingBox MensuralProlationCombiningStroke { get; set; }

        [JsonProperty("mensuralProlationCombiningThreeDots")]
        BoundingBox MensuralProlationCombiningThreeDots { get; set; }

        [JsonProperty("mensuralProlationCombiningThreeDotsTri")]
        BoundingBox MensuralProlationCombiningThreeDotsTri { get; set; }

        [JsonProperty("mensuralProlationCombiningTwoDots")]
        BoundingBox MensuralProlationCombiningTwoDots { get; set; }

        [JsonProperty("mensuralProportion1")]
        BoundingBox MensuralProportion1 { get; set; }

        [JsonProperty("mensuralProportion2")]
        BoundingBox MensuralProportion2 { get; set; }

        [JsonProperty("mensuralProportion3")]
        BoundingBox MensuralProportion3 { get; set; }

        [JsonProperty("mensuralProportion4")]
        BoundingBox MensuralProportion4 { get; set; }

        [JsonProperty("mensuralProportion4Old")]
        BoundingBox MensuralProportion4Old { get; set; }

        [JsonProperty("mensuralProportionMajor")]
        BoundingBox MensuralProportionMajor { get; set; }

        [JsonProperty("mensuralProportionMinor")]
        BoundingBox MensuralProportionMinor { get; set; }

        [JsonProperty("mensuralProportionProportioDupla1")]
        BoundingBox MensuralProportionProportioDupla1 { get; set; }

        [JsonProperty("mensuralProportionProportioDupla2")]
        BoundingBox MensuralProportionProportioDupla2 { get; set; }

        [JsonProperty("mensuralProportionProportioQuadrupla")]
        BoundingBox MensuralProportionProportioQuadrupla { get; set; }

        [JsonProperty("mensuralProportionProportioTripla")]
        BoundingBox MensuralProportionProportioTripla { get; set; }

        [JsonProperty("mensuralProportionTempusPerfectum")]
        BoundingBox MensuralProportionTempusPerfectum { get; set; }

        [JsonProperty("mensuralRestBrevis")]
        BoundingBox MensuralRestBrevis { get; set; }

        [JsonProperty("mensuralRestFusa")]
        BoundingBox MensuralRestFusa { get; set; }

        [JsonProperty("mensuralRestLongaImperfecta")]
        BoundingBox MensuralRestLongaImperfecta { get; set; }

        [JsonProperty("mensuralRestLongaPerfecta")]
        BoundingBox MensuralRestLongaPerfecta { get; set; }

        [JsonProperty("mensuralRestMaxima")]
        BoundingBox MensuralRestMaxima { get; set; }

        [JsonProperty("mensuralRestMinima")]
        BoundingBox MensuralRestMinima { get; set; }

        [JsonProperty("mensuralRestSemibrevis")]
        BoundingBox MensuralRestSemibrevis { get; set; }

        [JsonProperty("mensuralRestSemifusa")]
        BoundingBox MensuralRestSemifusa { get; set; }

        [JsonProperty("mensuralRestSemiminima")]
        BoundingBox MensuralRestSemiminima { get; set; }

        [JsonProperty("mensuralSemiminimaBlackStemDown")]
        BoundingBox MensuralSemiminimaBlackStemDown { get; set; }

        [JsonProperty("mensuralSemiminimaBlackStemUp")]
        BoundingBox MensuralSemiminimaBlackStemUp { get; set; }

        [JsonProperty("mensuralSemiminimaBlackVoidStemDown")]
        BoundingBox MensuralSemiminimaBlackVoidStemDown { get; set; }

        [JsonProperty("mensuralSemiminimaBlackVoidStemUp")]
        BoundingBox MensuralSemiminimaBlackVoidStemUp { get; set; }

        [JsonProperty("mensuralSemiminimaVoidStemDown")]
        BoundingBox MensuralSemiminimaVoidStemDown { get; set; }

        [JsonProperty("mensuralSemiminimaVoidStemUp")]
        BoundingBox MensuralSemiminimaVoidStemUp { get; set; }

        [JsonProperty("mensuralSignumDown")]
        BoundingBox MensuralSignumDown { get; set; }

        [JsonProperty("mensuralSignumUp")]
        BoundingBox MensuralSignumUp { get; set; }

        [JsonProperty("mensuralTempusImperfectumHoriz")]
        BoundingBox MensuralTempusImperfectumHoriz { get; set; }

        [JsonProperty("mensuralTempusPerfectumHoriz")]
        BoundingBox MensuralTempusPerfectumHoriz { get; set; }

        [JsonProperty("mensuralWhiteBrevis")]
        BoundingBox MensuralWhiteBrevis { get; set; }

        [JsonProperty("mensuralWhiteFusa")]
        BoundingBox MensuralWhiteFusa { get; set; }

        [JsonProperty("mensuralWhiteLonga")]
        BoundingBox MensuralWhiteLonga { get; set; }

        [JsonProperty("mensuralWhiteMaxima")]
        BoundingBox MensuralWhiteMaxima { get; set; }

        [JsonProperty("mensuralWhiteMinima")]
        BoundingBox MensuralWhiteMinima { get; set; }

        [JsonProperty("mensuralWhiteSemiminima")]
        BoundingBox MensuralWhiteSemiminima { get; set; }

        [JsonProperty("metAugmentationDot")]
        BoundingBox MetAugmentationDot { get; set; }

        [JsonProperty("metNote1024thDown")]
        BoundingBox MetNote1024ThDown { get; set; }

        [JsonProperty("metNote1024thUp")]
        BoundingBox MetNote1024ThUp { get; set; }

        [JsonProperty("metNote128thDown")]
        BoundingBox MetNote128ThDown { get; set; }

        [JsonProperty("metNote128thUp")]
        BoundingBox MetNote128ThUp { get; set; }

        [JsonProperty("metNote16thDown")]
        BoundingBox MetNote16ThDown { get; set; }

        [JsonProperty("metNote16thUp")]
        BoundingBox MetNote16ThUp { get; set; }

        [JsonProperty("metNote256thDown")]
        BoundingBox MetNote256ThDown { get; set; }

        [JsonProperty("metNote256thUp")]
        BoundingBox MetNote256ThUp { get; set; }

        [JsonProperty("metNote32ndDown")]
        BoundingBox MetNote32NdDown { get; set; }

        [JsonProperty("metNote32ndUp")]
        BoundingBox MetNote32NdUp { get; set; }

        [JsonProperty("metNote512thDown")]
        BoundingBox MetNote512ThDown { get; set; }

        [JsonProperty("metNote512thUp")]
        BoundingBox MetNote512ThUp { get; set; }

        [JsonProperty("metNote64thDown")]
        BoundingBox MetNote64ThDown { get; set; }

        [JsonProperty("metNote64thUp")]
        BoundingBox MetNote64ThUp { get; set; }

        [JsonProperty("metNote8thDown")]
        BoundingBox MetNote8ThDown { get; set; }

        [JsonProperty("metNote8thUp")]
        BoundingBox MetNote8ThUp { get; set; }

        [JsonProperty("metNoteDoubleWhole")]
        BoundingBox MetNoteDoubleWhole { get; set; }

        [JsonProperty("metNoteDoubleWholeSquare")]
        BoundingBox MetNoteDoubleWholeSquare { get; set; }

        [JsonProperty("metNoteHalfDown")]
        BoundingBox MetNoteHalfDown { get; set; }

        [JsonProperty("metNoteHalfUp")]
        BoundingBox MetNoteHalfUp { get; set; }

        [JsonProperty("metNoteQuarterDown")]
        BoundingBox MetNoteQuarterDown { get; set; }

        [JsonProperty("metNoteQuarterUp")]
        BoundingBox MetNoteQuarterUp { get; set; }

        [JsonProperty("metNoteWhole")]
        BoundingBox MetNoteWhole { get; set; }

        [JsonProperty("metricModulationArrowLeft")]
        BoundingBox MetricModulationArrowLeft { get; set; }

        [JsonProperty("metricModulationArrowRight")]
        BoundingBox MetricModulationArrowRight { get; set; }

        [JsonProperty("miscDoNotCopy")]
        BoundingBox MiscDoNotCopy { get; set; }

        [JsonProperty("miscDoNotPhotocopy")]
        BoundingBox MiscDoNotPhotocopy { get; set; }

        [JsonProperty("miscEyeglasses")]
        BoundingBox MiscEyeglasses { get; set; }

        [JsonProperty("note1024thDown")]
        BoundingBox Note1024ThDown { get; set; }

        [JsonProperty("note1024thUp")]
        BoundingBox Note1024ThUp { get; set; }

        [JsonProperty("note128thDown")]
        BoundingBox Note128ThDown { get; set; }

        [JsonProperty("note128thUp")]
        BoundingBox Note128ThUp { get; set; }

        [JsonProperty("note16thDown")]
        BoundingBox Note16ThDown { get; set; }

        [JsonProperty("note16thUp")]
        BoundingBox Note16ThUp { get; set; }

        [JsonProperty("note256thDown")]
        BoundingBox Note256ThDown { get; set; }

        [JsonProperty("note256thUp")]
        BoundingBox Note256ThUp { get; set; }

        [JsonProperty("note32ndDown")]
        BoundingBox Note32NdDown { get; set; }

        [JsonProperty("note32ndUp")]
        BoundingBox Note32NdUp { get; set; }

        [JsonProperty("note512thDown")]
        BoundingBox Note512ThDown { get; set; }

        [JsonProperty("note512thUp")]
        BoundingBox Note512ThUp { get; set; }

        [JsonProperty("note64thDown")]
        BoundingBox Note64ThDown { get; set; }

        [JsonProperty("note64thUp")]
        BoundingBox Note64ThUp { get; set; }

        [JsonProperty("note8thDown")]
        BoundingBox Note8ThDown { get; set; }

        [JsonProperty("note8thUp")]
        BoundingBox Note8ThUp { get; set; }

        [JsonProperty("noteABlack")]
        BoundingBox NoteABlack { get; set; }

        [JsonProperty("noteAFlatBlack")]
        BoundingBox NoteAFlatBlack { get; set; }

        [JsonProperty("noteAFlatHalf")]
        BoundingBox NoteAFlatHalf { get; set; }

        [JsonProperty("noteAFlatWhole")]
        BoundingBox NoteAFlatWhole { get; set; }

        [JsonProperty("noteAHalf")]
        BoundingBox NoteAHalf { get; set; }

        [JsonProperty("noteASharpBlack")]
        BoundingBox NoteASharpBlack { get; set; }

        [JsonProperty("noteASharpHalf")]
        BoundingBox NoteASharpHalf { get; set; }

        [JsonProperty("noteASharpWhole")]
        BoundingBox NoteASharpWhole { get; set; }

        [JsonProperty("noteAWhole")]
        BoundingBox NoteAWhole { get; set; }

        [JsonProperty("noteBBlack")]
        BoundingBox NoteBBlack { get; set; }

        [JsonProperty("noteBFlatBlack")]
        BoundingBox NoteBFlatBlack { get; set; }

        [JsonProperty("noteBFlatHalf")]
        BoundingBox NoteBFlatHalf { get; set; }

        [JsonProperty("noteBFlatWhole")]
        BoundingBox NoteBFlatWhole { get; set; }

        [JsonProperty("noteBHalf")]
        BoundingBox NoteBHalf { get; set; }

        [JsonProperty("noteBSharpBlack")]
        BoundingBox NoteBSharpBlack { get; set; }

        [JsonProperty("noteBSharpHalf")]
        BoundingBox NoteBSharpHalf { get; set; }

        [JsonProperty("noteBSharpWhole")]
        BoundingBox NoteBSharpWhole { get; set; }

        [JsonProperty("noteBWhole")]
        BoundingBox NoteBWhole { get; set; }

        [JsonProperty("noteCBlack")]
        BoundingBox NoteCBlack { get; set; }

        [JsonProperty("noteCFlatBlack")]
        BoundingBox NoteCFlatBlack { get; set; }

        [JsonProperty("noteCFlatHalf")]
        BoundingBox NoteCFlatHalf { get; set; }

        [JsonProperty("noteCFlatWhole")]
        BoundingBox NoteCFlatWhole { get; set; }

        [JsonProperty("noteCHalf")]
        BoundingBox NoteCHalf { get; set; }

        [JsonProperty("noteCSharpBlack")]
        BoundingBox NoteCSharpBlack { get; set; }

        [JsonProperty("noteCSharpHalf")]
        BoundingBox NoteCSharpHalf { get; set; }

        [JsonProperty("noteCSharpWhole")]
        BoundingBox NoteCSharpWhole { get; set; }

        [JsonProperty("noteCWhole")]
        BoundingBox NoteCWhole { get; set; }

        [JsonProperty("noteDBlack")]
        BoundingBox NoteDBlack { get; set; }

        [JsonProperty("noteDFlatBlack")]
        BoundingBox NoteDFlatBlack { get; set; }

        [JsonProperty("noteDFlatHalf")]
        BoundingBox NoteDFlatHalf { get; set; }

        [JsonProperty("noteDFlatWhole")]
        BoundingBox NoteDFlatWhole { get; set; }

        [JsonProperty("noteDHalf")]
        BoundingBox NoteDHalf { get; set; }

        [JsonProperty("noteDSharpBlack")]
        BoundingBox NoteDSharpBlack { get; set; }

        [JsonProperty("noteDSharpHalf")]
        BoundingBox NoteDSharpHalf { get; set; }

        [JsonProperty("noteDSharpWhole")]
        BoundingBox NoteDSharpWhole { get; set; }

        [JsonProperty("noteDWhole")]
        BoundingBox NoteDWhole { get; set; }

        [JsonProperty("noteDoBlack")]
        BoundingBox NoteDoBlack { get; set; }

        [JsonProperty("noteDoHalf")]
        BoundingBox NoteDoHalf { get; set; }

        [JsonProperty("noteDoWhole")]
        BoundingBox NoteDoWhole { get; set; }

        [JsonProperty("noteDoubleWhole")]
        BoundingBox NoteDoubleWhole { get; set; }

        [JsonProperty("noteDoubleWholeAlt")]
        BoundingBox NoteDoubleWholeAlt { get; set; }

        [JsonProperty("noteDoubleWholeSquare")]
        BoundingBox NoteDoubleWholeSquare { get; set; }

        [JsonProperty("noteEBlack")]
        BoundingBox NoteEBlack { get; set; }

        [JsonProperty("noteEFlatBlack")]
        BoundingBox NoteEFlatBlack { get; set; }

        [JsonProperty("noteEFlatHalf")]
        BoundingBox NoteEFlatHalf { get; set; }

        [JsonProperty("noteEFlatWhole")]
        BoundingBox NoteEFlatWhole { get; set; }

        [JsonProperty("noteEHalf")]
        BoundingBox NoteEHalf { get; set; }

        [JsonProperty("noteESharpBlack")]
        BoundingBox NoteESharpBlack { get; set; }

        [JsonProperty("noteESharpHalf")]
        BoundingBox NoteESharpHalf { get; set; }

        [JsonProperty("noteESharpWhole")]
        BoundingBox NoteESharpWhole { get; set; }

        [JsonProperty("noteEWhole")]
        BoundingBox NoteEWhole { get; set; }

        [JsonProperty("noteEmptyBlack")]
        BoundingBox NoteEmptyBlack { get; set; }

        [JsonProperty("noteEmptyHalf")]
        BoundingBox NoteEmptyHalf { get; set; }

        [JsonProperty("noteEmptyWhole")]
        BoundingBox NoteEmptyWhole { get; set; }

        [JsonProperty("noteFBlack")]
        BoundingBox NoteFBlack { get; set; }

        [JsonProperty("noteFFlatBlack")]
        BoundingBox NoteFFlatBlack { get; set; }

        [JsonProperty("noteFFlatHalf")]
        BoundingBox NoteFFlatHalf { get; set; }

        [JsonProperty("noteFFlatWhole")]
        BoundingBox NoteFFlatWhole { get; set; }

        [JsonProperty("noteFHalf")]
        BoundingBox NoteFHalf { get; set; }

        [JsonProperty("noteFSharpBlack")]
        BoundingBox NoteFSharpBlack { get; set; }

        [JsonProperty("noteFSharpHalf")]
        BoundingBox NoteFSharpHalf { get; set; }

        [JsonProperty("noteFSharpWhole")]
        BoundingBox NoteFSharpWhole { get; set; }

        [JsonProperty("noteFWhole")]
        BoundingBox NoteFWhole { get; set; }

        [JsonProperty("noteFaBlack")]
        BoundingBox NoteFaBlack { get; set; }

        [JsonProperty("noteFaHalf")]
        BoundingBox NoteFaHalf { get; set; }

        [JsonProperty("noteFaWhole")]
        BoundingBox NoteFaWhole { get; set; }

        [JsonProperty("noteGBlack")]
        BoundingBox NoteGBlack { get; set; }

        [JsonProperty("noteGFlatBlack")]
        BoundingBox NoteGFlatBlack { get; set; }

        [JsonProperty("noteGFlatHalf")]
        BoundingBox NoteGFlatHalf { get; set; }

        [JsonProperty("noteGFlatWhole")]
        BoundingBox NoteGFlatWhole { get; set; }

        [JsonProperty("noteGHalf")]
        BoundingBox NoteGHalf { get; set; }

        [JsonProperty("noteGSharpBlack")]
        BoundingBox NoteGSharpBlack { get; set; }

        [JsonProperty("noteGSharpHalf")]
        BoundingBox NoteGSharpHalf { get; set; }

        [JsonProperty("noteGSharpWhole")]
        BoundingBox NoteGSharpWhole { get; set; }

        [JsonProperty("noteGWhole")]
        BoundingBox NoteGWhole { get; set; }

        [JsonProperty("noteHBlack")]
        BoundingBox NoteHBlack { get; set; }

        [JsonProperty("noteHHalf")]
        BoundingBox NoteHHalf { get; set; }

        [JsonProperty("noteHSharpBlack")]
        BoundingBox NoteHSharpBlack { get; set; }

        [JsonProperty("noteHSharpHalf")]
        BoundingBox NoteHSharpHalf { get; set; }

        [JsonProperty("noteHSharpWhole")]
        BoundingBox NoteHSharpWhole { get; set; }

        [JsonProperty("noteHWhole")]
        BoundingBox NoteHWhole { get; set; }

        [JsonProperty("noteHalfDown")]
        BoundingBox NoteHalfDown { get; set; }

        [JsonProperty("noteHalfUp")]
        BoundingBox NoteHalfUp { get; set; }

        [JsonProperty("noteLaBlack")]
        BoundingBox NoteLaBlack { get; set; }

        [JsonProperty("noteLaHalf")]
        BoundingBox NoteLaHalf { get; set; }

        [JsonProperty("noteLaWhole")]
        BoundingBox NoteLaWhole { get; set; }

        [JsonProperty("noteMiBlack")]
        BoundingBox NoteMiBlack { get; set; }

        [JsonProperty("noteMiHalf")]
        BoundingBox NoteMiHalf { get; set; }

        [JsonProperty("noteMiWhole")]
        BoundingBox NoteMiWhole { get; set; }

        [JsonProperty("noteQuarterDown")]
        BoundingBox NoteQuarterDown { get; set; }

        [JsonProperty("noteQuarterUp")]
        BoundingBox NoteQuarterUp { get; set; }

        [JsonProperty("noteReBlack")]
        BoundingBox NoteReBlack { get; set; }

        [JsonProperty("noteReHalf")]
        BoundingBox NoteReHalf { get; set; }

        [JsonProperty("noteReWhole")]
        BoundingBox NoteReWhole { get; set; }

        [JsonProperty("noteShapeArrowheadLeftBlack")]
        BoundingBox NoteShapeArrowheadLeftBlack { get; set; }

        [JsonProperty("noteShapeArrowheadLeftDoubleWhole")]
        BoundingBox NoteShapeArrowheadLeftDoubleWhole { get; set; }

        [JsonProperty("noteShapeArrowheadLeftWhite")]
        BoundingBox NoteShapeArrowheadLeftWhite { get; set; }

        [JsonProperty("noteShapeDiamondBlack")]
        BoundingBox NoteShapeDiamondBlack { get; set; }

        [JsonProperty("noteShapeDiamondDoubleWhole")]
        BoundingBox NoteShapeDiamondDoubleWhole { get; set; }

        [JsonProperty("noteShapeDiamondWhite")]
        BoundingBox NoteShapeDiamondWhite { get; set; }

        [JsonProperty("noteShapeIsoscelesTriangleBlack")]
        BoundingBox NoteShapeIsoscelesTriangleBlack { get; set; }

        [JsonProperty("noteShapeIsoscelesTriangleDoubleWhole")]
        BoundingBox NoteShapeIsoscelesTriangleDoubleWhole { get; set; }

        [JsonProperty("noteShapeIsoscelesTriangleWhite")]
        BoundingBox NoteShapeIsoscelesTriangleWhite { get; set; }

        [JsonProperty("noteShapeKeystoneBlack")]
        BoundingBox NoteShapeKeystoneBlack { get; set; }

        [JsonProperty("noteShapeKeystoneDoubleWhole")]
        BoundingBox NoteShapeKeystoneDoubleWhole { get; set; }

        [JsonProperty("noteShapeKeystoneWhite")]
        BoundingBox NoteShapeKeystoneWhite { get; set; }

        [JsonProperty("noteShapeMoonBlack")]
        BoundingBox NoteShapeMoonBlack { get; set; }

        [JsonProperty("noteShapeMoonDoubleWhole")]
        BoundingBox NoteShapeMoonDoubleWhole { get; set; }

        [JsonProperty("noteShapeMoonLeftBlack")]
        BoundingBox NoteShapeMoonLeftBlack { get; set; }

        [JsonProperty("noteShapeMoonLeftDoubleWhole")]
        BoundingBox NoteShapeMoonLeftDoubleWhole { get; set; }

        [JsonProperty("noteShapeMoonLeftWhite")]
        BoundingBox NoteShapeMoonLeftWhite { get; set; }

        [JsonProperty("noteShapeMoonWhite")]
        BoundingBox NoteShapeMoonWhite { get; set; }

        [JsonProperty("noteShapeQuarterMoonBlack")]
        BoundingBox NoteShapeQuarterMoonBlack { get; set; }

        [JsonProperty("noteShapeQuarterMoonDoubleWhole")]
        BoundingBox NoteShapeQuarterMoonDoubleWhole { get; set; }

        [JsonProperty("noteShapeQuarterMoonWhite")]
        BoundingBox NoteShapeQuarterMoonWhite { get; set; }

        [JsonProperty("noteShapeRoundBlack")]
        BoundingBox NoteShapeRoundBlack { get; set; }

        [JsonProperty("noteShapeRoundDoubleWhole")]
        BoundingBox NoteShapeRoundDoubleWhole { get; set; }

        [JsonProperty("noteShapeRoundWhite")]
        BoundingBox NoteShapeRoundWhite { get; set; }

        [JsonProperty("noteShapeSquareBlack")]
        BoundingBox NoteShapeSquareBlack { get; set; }

        [JsonProperty("noteShapeSquareDoubleWhole")]
        BoundingBox NoteShapeSquareDoubleWhole { get; set; }

        [JsonProperty("noteShapeSquareWhite")]
        BoundingBox NoteShapeSquareWhite { get; set; }

        [JsonProperty("noteShapeTriangleLeftBlack")]
        BoundingBox NoteShapeTriangleLeftBlack { get; set; }

        [JsonProperty("noteShapeTriangleLeftDoubleWhole")]
        BoundingBox NoteShapeTriangleLeftDoubleWhole { get; set; }

        [JsonProperty("noteShapeTriangleLeftWhite")]
        BoundingBox NoteShapeTriangleLeftWhite { get; set; }

        [JsonProperty("noteShapeTriangleRightBlack")]
        BoundingBox NoteShapeTriangleRightBlack { get; set; }

        [JsonProperty("noteShapeTriangleRightDoubleWhole")]
        BoundingBox NoteShapeTriangleRightDoubleWhole { get; set; }

        [JsonProperty("noteShapeTriangleRightWhite")]
        BoundingBox NoteShapeTriangleRightWhite { get; set; }

        [JsonProperty("noteShapeTriangleRoundBlack")]
        BoundingBox NoteShapeTriangleRoundBlack { get; set; }

        [JsonProperty("noteShapeTriangleRoundDoubleWhole")]
        BoundingBox NoteShapeTriangleRoundDoubleWhole { get; set; }

        [JsonProperty("noteShapeTriangleRoundLeftBlack")]
        BoundingBox NoteShapeTriangleRoundLeftBlack { get; set; }

        [JsonProperty("noteShapeTriangleRoundLeftDoubleWhole")]
        BoundingBox NoteShapeTriangleRoundLeftDoubleWhole { get; set; }

        [JsonProperty("noteShapeTriangleRoundLeftWhite")]
        BoundingBox NoteShapeTriangleRoundLeftWhite { get; set; }

        [JsonProperty("noteShapeTriangleRoundWhite")]
        BoundingBox NoteShapeTriangleRoundWhite { get; set; }

        [JsonProperty("noteShapeTriangleUpBlack")]
        BoundingBox NoteShapeTriangleUpBlack { get; set; }

        [JsonProperty("noteShapeTriangleUpDoubleWhole")]
        BoundingBox NoteShapeTriangleUpDoubleWhole { get; set; }

        [JsonProperty("noteShapeTriangleUpWhite")]
        BoundingBox NoteShapeTriangleUpWhite { get; set; }

        [JsonProperty("noteSiBlack")]
        BoundingBox NoteSiBlack { get; set; }

        [JsonProperty("noteSiHalf")]
        BoundingBox NoteSiHalf { get; set; }

        [JsonProperty("noteSiWhole")]
        BoundingBox NoteSiWhole { get; set; }

        [JsonProperty("noteSoBlack")]
        BoundingBox NoteSoBlack { get; set; }

        [JsonProperty("noteSoHalf")]
        BoundingBox NoteSoHalf { get; set; }

        [JsonProperty("noteSoWhole")]
        BoundingBox NoteSoWhole { get; set; }

        [JsonProperty("noteTiBlack")]
        BoundingBox NoteTiBlack { get; set; }

        [JsonProperty("noteTiHalf")]
        BoundingBox NoteTiHalf { get; set; }

        [JsonProperty("noteTiWhole")]
        BoundingBox NoteTiWhole { get; set; }

        [JsonProperty("noteWhole")]
        BoundingBox NoteWhole { get; set; }

        [JsonProperty("noteheadBlack")]
        BoundingBox NoteheadBlack { get; set; }

        [JsonProperty("noteheadBlackOversized")]
        BoundingBox NoteheadBlackOversized { get; set; }

        [JsonProperty("noteheadBlackParens")]
        BoundingBox NoteheadBlackParens { get; set; }

        [JsonProperty("noteheadBlackSmall")]
        BoundingBox NoteheadBlackSmall { get; set; }

        [JsonProperty("noteheadCircleSlash")]
        BoundingBox NoteheadCircleSlash { get; set; }

        [JsonProperty("noteheadCircleX")]
        BoundingBox NoteheadCircleX { get; set; }

        [JsonProperty("noteheadCircleXDoubleWhole")]
        BoundingBox NoteheadCircleXDoubleWhole { get; set; }

        [JsonProperty("noteheadCircleXHalf")]
        BoundingBox NoteheadCircleXHalf { get; set; }

        [JsonProperty("noteheadCircleXWhole")]
        BoundingBox NoteheadCircleXWhole { get; set; }

        [JsonProperty("noteheadCircledBlack")]
        BoundingBox NoteheadCircledBlack { get; set; }

        [JsonProperty("noteheadCircledBlackLarge")]
        BoundingBox NoteheadCircledBlackLarge { get; set; }

        [JsonProperty("noteheadCircledDoubleWhole")]
        BoundingBox NoteheadCircledDoubleWhole { get; set; }

        [JsonProperty("noteheadCircledDoubleWholeLarge")]
        BoundingBox NoteheadCircledDoubleWholeLarge { get; set; }

        [JsonProperty("noteheadCircledHalf")]
        BoundingBox NoteheadCircledHalf { get; set; }

        [JsonProperty("noteheadCircledHalfLarge")]
        BoundingBox NoteheadCircledHalfLarge { get; set; }

        [JsonProperty("noteheadCircledWhole")]
        BoundingBox NoteheadCircledWhole { get; set; }

        [JsonProperty("noteheadCircledWholeLarge")]
        BoundingBox NoteheadCircledWholeLarge { get; set; }

        [JsonProperty("noteheadCircledXLarge")]
        BoundingBox NoteheadCircledXLarge { get; set; }

        [JsonProperty("noteheadClusterDoubleWhole2nd")]
        BoundingBox NoteheadClusterDoubleWhole2Nd { get; set; }

        [JsonProperty("noteheadClusterDoubleWhole3rd")]
        BoundingBox NoteheadClusterDoubleWhole3Rd { get; set; }

        [JsonProperty("noteheadClusterDoubleWholeBottom")]
        BoundingBox NoteheadClusterDoubleWholeBottom { get; set; }

        [JsonProperty("noteheadClusterDoubleWholeMiddle")]
        BoundingBox NoteheadClusterDoubleWholeMiddle { get; set; }

        [JsonProperty("noteheadClusterDoubleWholeTop")]
        BoundingBox NoteheadClusterDoubleWholeTop { get; set; }

        [JsonProperty("noteheadClusterHalf2nd")]
        BoundingBox NoteheadClusterHalf2Nd { get; set; }

        [JsonProperty("noteheadClusterHalf3rd")]
        BoundingBox NoteheadClusterHalf3Rd { get; set; }

        [JsonProperty("noteheadClusterHalfBottom")]
        BoundingBox NoteheadClusterHalfBottom { get; set; }

        [JsonProperty("noteheadClusterHalfMiddle")]
        BoundingBox NoteheadClusterHalfMiddle { get; set; }

        [JsonProperty("noteheadClusterHalfTop")]
        BoundingBox NoteheadClusterHalfTop { get; set; }

        [JsonProperty("noteheadClusterQuarter2nd")]
        BoundingBox NoteheadClusterQuarter2Nd { get; set; }

        [JsonProperty("noteheadClusterQuarter3rd")]
        BoundingBox NoteheadClusterQuarter3Rd { get; set; }

        [JsonProperty("noteheadClusterQuarterBottom")]
        BoundingBox NoteheadClusterQuarterBottom { get; set; }

        [JsonProperty("noteheadClusterQuarterMiddle")]
        BoundingBox NoteheadClusterQuarterMiddle { get; set; }

        [JsonProperty("noteheadClusterQuarterTop")]
        BoundingBox NoteheadClusterQuarterTop { get; set; }

        [JsonProperty("noteheadClusterRoundBlack")]
        BoundingBox NoteheadClusterRoundBlack { get; set; }

        [JsonProperty("noteheadClusterRoundWhite")]
        BoundingBox NoteheadClusterRoundWhite { get; set; }

        [JsonProperty("noteheadClusterSquareBlack")]
        BoundingBox NoteheadClusterSquareBlack { get; set; }

        [JsonProperty("noteheadClusterSquareWhite")]
        BoundingBox NoteheadClusterSquareWhite { get; set; }

        [JsonProperty("noteheadClusterWhole2nd")]
        BoundingBox NoteheadClusterWhole2Nd { get; set; }

        [JsonProperty("noteheadClusterWhole3rd")]
        BoundingBox NoteheadClusterWhole3Rd { get; set; }

        [JsonProperty("noteheadClusterWholeBottom")]
        BoundingBox NoteheadClusterWholeBottom { get; set; }

        [JsonProperty("noteheadClusterWholeMiddle")]
        BoundingBox NoteheadClusterWholeMiddle { get; set; }

        [JsonProperty("noteheadClusterWholeTop")]
        BoundingBox NoteheadClusterWholeTop { get; set; }

        [JsonProperty("noteheadDiamondBlack")]
        BoundingBox NoteheadDiamondBlack { get; set; }

        [JsonProperty("noteheadDiamondBlackOld")]
        BoundingBox NoteheadDiamondBlackOld { get; set; }

        [JsonProperty("noteheadDiamondBlackWide")]
        BoundingBox NoteheadDiamondBlackWide { get; set; }

        [JsonProperty("noteheadDiamondClusterBlack2nd")]
        BoundingBox NoteheadDiamondClusterBlack2Nd { get; set; }

        [JsonProperty("noteheadDiamondClusterBlack3rd")]
        BoundingBox NoteheadDiamondClusterBlack3Rd { get; set; }

        [JsonProperty("noteheadDiamondClusterBlackBottom")]
        BoundingBox NoteheadDiamondClusterBlackBottom { get; set; }

        [JsonProperty("noteheadDiamondClusterBlackMiddle")]
        BoundingBox NoteheadDiamondClusterBlackMiddle { get; set; }

        [JsonProperty("noteheadDiamondClusterBlackTop")]
        BoundingBox NoteheadDiamondClusterBlackTop { get; set; }

        [JsonProperty("noteheadDiamondClusterWhite2nd")]
        BoundingBox NoteheadDiamondClusterWhite2Nd { get; set; }

        [JsonProperty("noteheadDiamondClusterWhite3rd")]
        BoundingBox NoteheadDiamondClusterWhite3Rd { get; set; }

        [JsonProperty("noteheadDiamondClusterWhiteBottom")]
        BoundingBox NoteheadDiamondClusterWhiteBottom { get; set; }

        [JsonProperty("noteheadDiamondClusterWhiteMiddle")]
        BoundingBox NoteheadDiamondClusterWhiteMiddle { get; set; }

        [JsonProperty("noteheadDiamondClusterWhiteTop")]
        BoundingBox NoteheadDiamondClusterWhiteTop { get; set; }

        [JsonProperty("noteheadDiamondDoubleWhole")]
        BoundingBox NoteheadDiamondDoubleWhole { get; set; }

        [JsonProperty("noteheadDiamondDoubleWholeOld")]
        BoundingBox NoteheadDiamondDoubleWholeOld { get; set; }

        [JsonProperty("noteheadDiamondHalf")]
        BoundingBox NoteheadDiamondHalf { get; set; }

        [JsonProperty("noteheadDiamondHalfFilled")]
        BoundingBox NoteheadDiamondHalfFilled { get; set; }

        [JsonProperty("noteheadDiamondHalfOld")]
        BoundingBox NoteheadDiamondHalfOld { get; set; }

        [JsonProperty("noteheadDiamondHalfWide")]
        BoundingBox NoteheadDiamondHalfWide { get; set; }

        [JsonProperty("noteheadDiamondOpen")]
        BoundingBox NoteheadDiamondOpen { get; set; }

        [JsonProperty("noteheadDiamondWhite")]
        BoundingBox NoteheadDiamondWhite { get; set; }

        [JsonProperty("noteheadDiamondWhiteWide")]
        BoundingBox NoteheadDiamondWhiteWide { get; set; }

        [JsonProperty("noteheadDiamondWhole")]
        BoundingBox NoteheadDiamondWhole { get; set; }

        [JsonProperty("noteheadDiamondWholeOld")]
        BoundingBox NoteheadDiamondWholeOld { get; set; }

        [JsonProperty("noteheadDoubleWhole")]
        BoundingBox NoteheadDoubleWhole { get; set; }

        [JsonProperty("noteheadDoubleWholeAlt")]
        BoundingBox NoteheadDoubleWholeAlt { get; set; }

        [JsonProperty("noteheadDoubleWholeOversized")]
        BoundingBox NoteheadDoubleWholeOversized { get; set; }

        [JsonProperty("noteheadDoubleWholeParens")]
        BoundingBox NoteheadDoubleWholeParens { get; set; }

        [JsonProperty("noteheadDoubleWholeSmall")]
        BoundingBox NoteheadDoubleWholeSmall { get; set; }

        [JsonProperty("noteheadDoubleWholeSquare")]
        BoundingBox NoteheadDoubleWholeSquare { get; set; }

        [JsonProperty("noteheadDoubleWholeSquareOversized")]
        BoundingBox NoteheadDoubleWholeSquareOversized { get; set; }

        [JsonProperty("noteheadDoubleWholeWithX")]
        BoundingBox NoteheadDoubleWholeWithX { get; set; }

        [JsonProperty("noteheadHalf")]
        BoundingBox NoteheadHalf { get; set; }

        [JsonProperty("noteheadHalfFilled")]
        BoundingBox NoteheadHalfFilled { get; set; }

        [JsonProperty("noteheadHalfOversized")]
        BoundingBox NoteheadHalfOversized { get; set; }

        [JsonProperty("noteheadHalfParens")]
        BoundingBox NoteheadHalfParens { get; set; }

        [JsonProperty("noteheadHalfSmall")]
        BoundingBox NoteheadHalfSmall { get; set; }

        [JsonProperty("noteheadHalfWithX")]
        BoundingBox NoteheadHalfWithX { get; set; }

        [JsonProperty("noteheadHeavyX")]
        BoundingBox NoteheadHeavyX { get; set; }

        [JsonProperty("noteheadHeavyXHat")]
        BoundingBox NoteheadHeavyXHat { get; set; }

        [JsonProperty("noteheadLargeArrowDownBlack")]
        BoundingBox NoteheadLargeArrowDownBlack { get; set; }

        [JsonProperty("noteheadLargeArrowDownDoubleWhole")]
        BoundingBox NoteheadLargeArrowDownDoubleWhole { get; set; }

        [JsonProperty("noteheadLargeArrowDownHalf")]
        BoundingBox NoteheadLargeArrowDownHalf { get; set; }

        [JsonProperty("noteheadLargeArrowDownWhole")]
        BoundingBox NoteheadLargeArrowDownWhole { get; set; }

        [JsonProperty("noteheadLargeArrowUpBlack")]
        BoundingBox NoteheadLargeArrowUpBlack { get; set; }

        [JsonProperty("noteheadLargeArrowUpDoubleWhole")]
        BoundingBox NoteheadLargeArrowUpDoubleWhole { get; set; }

        [JsonProperty("noteheadLargeArrowUpHalf")]
        BoundingBox NoteheadLargeArrowUpHalf { get; set; }

        [JsonProperty("noteheadLargeArrowUpWhole")]
        BoundingBox NoteheadLargeArrowUpWhole { get; set; }

        [JsonProperty("noteheadMoonBlack")]
        BoundingBox NoteheadMoonBlack { get; set; }

        [JsonProperty("noteheadMoonWhite")]
        BoundingBox NoteheadMoonWhite { get; set; }

        [JsonProperty("noteheadParenthesis")]
        BoundingBox NoteheadParenthesis { get; set; }

        [JsonProperty("noteheadParenthesisLeft")]
        BoundingBox NoteheadParenthesisLeft { get; set; }

        [JsonProperty("noteheadParenthesisRight")]
        BoundingBox NoteheadParenthesisRight { get; set; }

        [JsonProperty("noteheadPlusBlack")]
        BoundingBox NoteheadPlusBlack { get; set; }

        [JsonProperty("noteheadPlusDoubleWhole")]
        BoundingBox NoteheadPlusDoubleWhole { get; set; }

        [JsonProperty("noteheadPlusHalf")]
        BoundingBox NoteheadPlusHalf { get; set; }

        [JsonProperty("noteheadPlusWhole")]
        BoundingBox NoteheadPlusWhole { get; set; }

        [JsonProperty("noteheadRectangularClusterBlackBottom")]
        BoundingBox NoteheadRectangularClusterBlackBottom { get; set; }

        [JsonProperty("noteheadRectangularClusterBlackMiddle")]
        BoundingBox NoteheadRectangularClusterBlackMiddle { get; set; }

        [JsonProperty("noteheadRectangularClusterBlackTop")]
        BoundingBox NoteheadRectangularClusterBlackTop { get; set; }

        [JsonProperty("noteheadRectangularClusterWhiteBottom")]
        BoundingBox NoteheadRectangularClusterWhiteBottom { get; set; }

        [JsonProperty("noteheadRectangularClusterWhiteMiddle")]
        BoundingBox NoteheadRectangularClusterWhiteMiddle { get; set; }

        [JsonProperty("noteheadRectangularClusterWhiteTop")]
        BoundingBox NoteheadRectangularClusterWhiteTop { get; set; }

        [JsonProperty("noteheadRoundBlack")]
        BoundingBox NoteheadRoundBlack { get; set; }

        [JsonProperty("noteheadRoundBlackDoubleSlashed")]
        BoundingBox NoteheadRoundBlackDoubleSlashed { get; set; }

        [JsonProperty("noteheadRoundBlackLarge")]
        Dictionary<string, long[]> NoteheadRoundBlackLarge { get; set; }

        [JsonProperty("noteheadRoundBlackSlashed")]
        BoundingBox NoteheadRoundBlackSlashed { get; set; }

        [JsonProperty("noteheadRoundBlackSlashedLarge")]
        BoundingBox NoteheadRoundBlackSlashedLarge { get; set; }

        [JsonProperty("noteheadRoundWhite")]
        BoundingBox NoteheadRoundWhite { get; set; }

        [JsonProperty("noteheadRoundWhiteDoubleSlashed")]
        BoundingBox NoteheadRoundWhiteDoubleSlashed { get; set; }

        [JsonProperty("noteheadRoundWhiteLarge")]
        Dictionary<string, long[]> NoteheadRoundWhiteLarge { get; set; }

        [JsonProperty("noteheadRoundWhiteSlashed")]
        BoundingBox NoteheadRoundWhiteSlashed { get; set; }

        [JsonProperty("noteheadRoundWhiteSlashedLarge")]
        BoundingBox NoteheadRoundWhiteSlashedLarge { get; set; }

        [JsonProperty("noteheadRoundWhiteWithDot")]
        BoundingBox NoteheadRoundWhiteWithDot { get; set; }

        [JsonProperty("noteheadRoundWhiteWithDotLarge")]
        BoundingBox NoteheadRoundWhiteWithDotLarge { get; set; }

        [JsonProperty("noteheadSlashDiamondWhite")]
        Dictionary<string, long[]> NoteheadSlashDiamondWhite { get; set; }

        [JsonProperty("noteheadSlashHorizontalEnds")]
        BoundingBox NoteheadSlashHorizontalEnds { get; set; }

        [JsonProperty("noteheadSlashHorizontalEndsMuted")]
        BoundingBox NoteheadSlashHorizontalEndsMuted { get; set; }

        [JsonProperty("noteheadSlashVerticalEnds")]
        BoundingBox NoteheadSlashVerticalEnds { get; set; }

        [JsonProperty("noteheadSlashVerticalEndsMuted")]
        BoundingBox NoteheadSlashVerticalEndsMuted { get; set; }

        [JsonProperty("noteheadSlashVerticalEndsSmall")]
        BoundingBox NoteheadSlashVerticalEndsSmall { get; set; }

        [JsonProperty("noteheadSlashWhiteDoubleWhole")]
        BoundingBox NoteheadSlashWhiteDoubleWhole { get; set; }

        [JsonProperty("noteheadSlashWhiteHalf")]
        BoundingBox NoteheadSlashWhiteHalf { get; set; }

        [JsonProperty("noteheadSlashWhiteMuted")]
        BoundingBox NoteheadSlashWhiteMuted { get; set; }

        [JsonProperty("noteheadSlashWhiteWhole")]
        BoundingBox NoteheadSlashWhiteWhole { get; set; }

        [JsonProperty("noteheadSlashX")]
        BoundingBox NoteheadSlashX { get; set; }

        [JsonProperty("noteheadSlashedBlack1")]
        BoundingBox NoteheadSlashedBlack1 { get; set; }

        [JsonProperty("noteheadSlashedBlack2")]
        BoundingBox NoteheadSlashedBlack2 { get; set; }

        [JsonProperty("noteheadSlashedDoubleWhole1")]
        BoundingBox NoteheadSlashedDoubleWhole1 { get; set; }

        [JsonProperty("noteheadSlashedDoubleWhole2")]
        BoundingBox NoteheadSlashedDoubleWhole2 { get; set; }

        [JsonProperty("noteheadSlashedHalf1")]
        BoundingBox NoteheadSlashedHalf1 { get; set; }

        [JsonProperty("noteheadSlashedHalf2")]
        BoundingBox NoteheadSlashedHalf2 { get; set; }

        [JsonProperty("noteheadSlashedWhole1")]
        BoundingBox NoteheadSlashedWhole1 { get; set; }

        [JsonProperty("noteheadSlashedWhole2")]
        BoundingBox NoteheadSlashedWhole2 { get; set; }

        [JsonProperty("noteheadSquareBlack")]
        BoundingBox NoteheadSquareBlack { get; set; }

        [JsonProperty("noteheadSquareBlackLarge")]
        Dictionary<string, long[]> NoteheadSquareBlackLarge { get; set; }

        [JsonProperty("noteheadSquareBlackWhite")]
        Dictionary<string, long[]> NoteheadSquareBlackWhite { get; set; }

        [JsonProperty("noteheadSquareWhite")]
        BoundingBox NoteheadSquareWhite { get; set; }

        [JsonProperty("noteheadTriangleDownBlack")]
        BoundingBox NoteheadTriangleDownBlack { get; set; }

        [JsonProperty("noteheadTriangleDownDoubleWhole")]
        BoundingBox NoteheadTriangleDownDoubleWhole { get; set; }

        [JsonProperty("noteheadTriangleDownHalf")]
        BoundingBox NoteheadTriangleDownHalf { get; set; }

        [JsonProperty("noteheadTriangleDownWhite")]
        BoundingBox NoteheadTriangleDownWhite { get; set; }

        [JsonProperty("noteheadTriangleDownWhole")]
        BoundingBox NoteheadTriangleDownWhole { get; set; }

        [JsonProperty("noteheadTriangleLeftBlack")]
        BoundingBox NoteheadTriangleLeftBlack { get; set; }

        [JsonProperty("noteheadTriangleLeftWhite")]
        BoundingBox NoteheadTriangleLeftWhite { get; set; }

        [JsonProperty("noteheadTriangleRightBlack")]
        BoundingBox NoteheadTriangleRightBlack { get; set; }

        [JsonProperty("noteheadTriangleRightWhite")]
        BoundingBox NoteheadTriangleRightWhite { get; set; }

        [JsonProperty("noteheadTriangleRoundDownBlack")]
        BoundingBox NoteheadTriangleRoundDownBlack { get; set; }

        [JsonProperty("noteheadTriangleRoundDownWhite")]
        BoundingBox NoteheadTriangleRoundDownWhite { get; set; }

        [JsonProperty("noteheadTriangleUpBlack")]
        BoundingBox NoteheadTriangleUpBlack { get; set; }

        [JsonProperty("noteheadTriangleUpDoubleWhole")]
        BoundingBox NoteheadTriangleUpDoubleWhole { get; set; }

        [JsonProperty("noteheadTriangleUpHalf")]
        BoundingBox NoteheadTriangleUpHalf { get; set; }

        [JsonProperty("noteheadTriangleUpRightBlack")]
        BoundingBox NoteheadTriangleUpRightBlack { get; set; }

        [JsonProperty("noteheadTriangleUpRightWhite")]
        BoundingBox NoteheadTriangleUpRightWhite { get; set; }

        [JsonProperty("noteheadTriangleUpWhite")]
        BoundingBox NoteheadTriangleUpWhite { get; set; }

        [JsonProperty("noteheadTriangleUpWhole")]
        BoundingBox NoteheadTriangleUpWhole { get; set; }

        [JsonProperty("noteheadVoidWithX")]
        BoundingBox NoteheadVoidWithX { get; set; }

        [JsonProperty("noteheadWhole")]
        BoundingBox NoteheadWhole { get; set; }

        [JsonProperty("noteheadWholeFilled")]
        BoundingBox NoteheadWholeFilled { get; set; }

        [JsonProperty("noteheadWholeOversized")]
        BoundingBox NoteheadWholeOversized { get; set; }

        [JsonProperty("noteheadWholeParens")]
        BoundingBox NoteheadWholeParens { get; set; }

        [JsonProperty("noteheadWholeSmall")]
        BoundingBox NoteheadWholeSmall { get; set; }

        [JsonProperty("noteheadWholeWithX")]
        BoundingBox NoteheadWholeWithX { get; set; }

        [JsonProperty("noteheadXBlack")]
        BoundingBox NoteheadXBlack { get; set; }

        [JsonProperty("noteheadXDoubleWhole")]
        BoundingBox NoteheadXDoubleWhole { get; set; }

        [JsonProperty("noteheadXHalf")]
        BoundingBox NoteheadXHalf { get; set; }

        [JsonProperty("noteheadXOrnate")]
        BoundingBox NoteheadXOrnate { get; set; }

        [JsonProperty("noteheadXOrnateEllipse")]
        BoundingBox NoteheadXOrnateEllipse { get; set; }

        [JsonProperty("noteheadXWhole")]
        BoundingBox NoteheadXWhole { get; set; }

        [JsonProperty("octaveBaselineA")]
        BoundingBox OctaveBaselineA { get; set; }

        [JsonProperty("octaveBaselineB")]
        BoundingBox OctaveBaselineB { get; set; }

        [JsonProperty("octaveBaselineM")]
        BoundingBox OctaveBaselineM { get; set; }

        [JsonProperty("octaveBaselineV")]
        BoundingBox OctaveBaselineV { get; set; }

        [JsonProperty("octaveBassa")]
        BoundingBox OctaveBassa { get; set; }

        [JsonProperty("octaveLoco")]
        BoundingBox OctaveLoco { get; set; }

        [JsonProperty("octaveParensLeft")]
        BoundingBox OctaveParensLeft { get; set; }

        [JsonProperty("octaveParensRight")]
        BoundingBox OctaveParensRight { get; set; }

        [JsonProperty("octaveSuperscriptA")]
        BoundingBox OctaveSuperscriptA { get; set; }

        [JsonProperty("octaveSuperscriptB")]
        BoundingBox OctaveSuperscriptB { get; set; }

        [JsonProperty("octaveSuperscriptM")]
        BoundingBox OctaveSuperscriptM { get; set; }

        [JsonProperty("octaveSuperscriptV")]
        BoundingBox OctaveSuperscriptV { get; set; }

        [JsonProperty("ornamentBottomLeftConcaveStroke")]
        BoundingBox OrnamentBottomLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentBottomLeftConcaveStrokeLarge")]
        BoundingBox OrnamentBottomLeftConcaveStrokeLarge { get; set; }

        [JsonProperty("ornamentBottomLeftConvexStroke")]
        BoundingBox OrnamentBottomLeftConvexStroke { get; set; }

        [JsonProperty("ornamentBottomRightConcaveStroke")]
        BoundingBox OrnamentBottomRightConcaveStroke { get; set; }

        [JsonProperty("ornamentBottomRightConvexStroke")]
        BoundingBox OrnamentBottomRightConvexStroke { get; set; }

        [JsonProperty("ornamentComma")]
        BoundingBox OrnamentComma { get; set; }

        [JsonProperty("ornamentDoubleObliqueLinesAfterNote")]
        BoundingBox OrnamentDoubleObliqueLinesAfterNote { get; set; }

        [JsonProperty("ornamentDoubleObliqueLinesBeforeNote")]
        BoundingBox OrnamentDoubleObliqueLinesBeforeNote { get; set; }

        [JsonProperty("ornamentDownCurve")]
        BoundingBox OrnamentDownCurve { get; set; }

        [JsonProperty("ornamentHaydn")]
        BoundingBox OrnamentHaydn { get; set; }

        [JsonProperty("ornamentHighLeftConcaveStroke")]
        BoundingBox OrnamentHighLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentHighLeftConvexStroke")]
        BoundingBox OrnamentHighLeftConvexStroke { get; set; }

        [JsonProperty("ornamentHighRightConcaveStroke")]
        BoundingBox OrnamentHighRightConcaveStroke { get; set; }

        [JsonProperty("ornamentHighRightConvexStroke")]
        BoundingBox OrnamentHighRightConvexStroke { get; set; }

        [JsonProperty("ornamentHookAfterNote")]
        BoundingBox OrnamentHookAfterNote { get; set; }

        [JsonProperty("ornamentHookBeforeNote")]
        BoundingBox OrnamentHookBeforeNote { get; set; }

        [JsonProperty("ornamentLeftFacingHalfCircle")]
        BoundingBox OrnamentLeftFacingHalfCircle { get; set; }

        [JsonProperty("ornamentLeftFacingHook")]
        BoundingBox OrnamentLeftFacingHook { get; set; }

        [JsonProperty("ornamentLeftPlus")]
        BoundingBox OrnamentLeftPlus { get; set; }

        [JsonProperty("ornamentLeftShakeT")]
        BoundingBox OrnamentLeftShakeT { get; set; }

        [JsonProperty("ornamentLeftVerticalStroke")]
        BoundingBox OrnamentLeftVerticalStroke { get; set; }

        [JsonProperty("ornamentLeftVerticalStrokeWithCross")]
        BoundingBox OrnamentLeftVerticalStrokeWithCross { get; set; }

        [JsonProperty("ornamentLowLeftConcaveStroke")]
        BoundingBox OrnamentLowLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentLowLeftConvexStroke")]
        BoundingBox OrnamentLowLeftConvexStroke { get; set; }

        [JsonProperty("ornamentLowRightConcaveStroke")]
        BoundingBox OrnamentLowRightConcaveStroke { get; set; }

        [JsonProperty("ornamentLowRightConvexStroke")]
        BoundingBox OrnamentLowRightConvexStroke { get; set; }

        [JsonProperty("ornamentMiddleVerticalStroke")]
        BoundingBox OrnamentMiddleVerticalStroke { get; set; }

        [JsonProperty("ornamentMordent")]
        BoundingBox OrnamentMordent { get; set; }

        [JsonProperty("ornamentMordentInverted")]
        BoundingBox OrnamentMordentInverted { get; set; }

        [JsonProperty("ornamentObliqueLineAfterNote")]
        BoundingBox OrnamentObliqueLineAfterNote { get; set; }

        [JsonProperty("ornamentObliqueLineBeforeNote")]
        BoundingBox OrnamentObliqueLineBeforeNote { get; set; }

        [JsonProperty("ornamentObliqueLineHorizAfterNote")]
        BoundingBox OrnamentObliqueLineHorizAfterNote { get; set; }

        [JsonProperty("ornamentObliqueLineHorizBeforeNote")]
        BoundingBox OrnamentObliqueLineHorizBeforeNote { get; set; }

        [JsonProperty("ornamentOriscus")]
        BoundingBox OrnamentOriscus { get; set; }

        [JsonProperty("ornamentPinceCouperin")]
        BoundingBox OrnamentPinceCouperin { get; set; }

        [JsonProperty("ornamentPortDeVoixV")]
        BoundingBox OrnamentPortDeVoixV { get; set; }

        [JsonProperty("ornamentPrecompAppoggTrill")]
        BoundingBox OrnamentPrecompAppoggTrill { get; set; }

        [JsonProperty("ornamentPrecompAppoggTrillSuffix")]
        BoundingBox OrnamentPrecompAppoggTrillSuffix { get; set; }

        [JsonProperty("ornamentPrecompCadence")]
        BoundingBox OrnamentPrecompCadence { get; set; }

        [JsonProperty("ornamentPrecompCadenceUpperPrefix")]
        BoundingBox OrnamentPrecompCadenceUpperPrefix { get; set; }

        [JsonProperty("ornamentPrecompCadenceUpperPrefixTurn")]
        BoundingBox OrnamentPrecompCadenceUpperPrefixTurn { get; set; }

        [JsonProperty("ornamentPrecompCadenceWithTurn")]
        BoundingBox OrnamentPrecompCadenceWithTurn { get; set; }

        [JsonProperty("ornamentPrecompDescendingSlide")]
        BoundingBox OrnamentPrecompDescendingSlide { get; set; }

        [JsonProperty("ornamentPrecompDoubleCadenceLowerPrefix")]
        BoundingBox OrnamentPrecompDoubleCadenceLowerPrefix { get; set; }

        [JsonProperty("ornamentPrecompDoubleCadenceUpperPrefix")]
        BoundingBox OrnamentPrecompDoubleCadenceUpperPrefix { get; set; }

        [JsonProperty("ornamentPrecompDoubleCadenceUpperPrefixTurn")]
        BoundingBox OrnamentPrecompDoubleCadenceUpperPrefixTurn { get; set; }

        [JsonProperty("ornamentPrecompInvertedMordentUpperPrefix")]
        BoundingBox OrnamentPrecompInvertedMordentUpperPrefix { get; set; }

        [JsonProperty("ornamentPrecompMordentRelease")]
        BoundingBox OrnamentPrecompMordentRelease { get; set; }

        [JsonProperty("ornamentPrecompMordentUpperPrefix")]
        BoundingBox OrnamentPrecompMordentUpperPrefix { get; set; }

        [JsonProperty("ornamentPrecompPortDeVoixMordent")]
        BoundingBox OrnamentPrecompPortDeVoixMordent { get; set; }

        [JsonProperty("ornamentPrecompSlide")]
        BoundingBox OrnamentPrecompSlide { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillBach")]
        BoundingBox OrnamentPrecompSlideTrillBach { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillDAnglebert")]
        BoundingBox OrnamentPrecompSlideTrillDAnglebert { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillMarpurg")]
        BoundingBox OrnamentPrecompSlideTrillMarpurg { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillMuffat")]
        BoundingBox OrnamentPrecompSlideTrillMuffat { get; set; }

        [JsonProperty("ornamentPrecompSlideTrillSuffixMuffat")]
        BoundingBox OrnamentPrecompSlideTrillSuffixMuffat { get; set; }

        [JsonProperty("ornamentPrecompTrillLowerSuffix")]
        BoundingBox OrnamentPrecompTrillLowerSuffix { get; set; }

        [JsonProperty("ornamentPrecompTrillSuffixDandrieu")]
        BoundingBox OrnamentPrecompTrillSuffixDandrieu { get; set; }

        [JsonProperty("ornamentPrecompTrillWithMordent")]
        BoundingBox OrnamentPrecompTrillWithMordent { get; set; }

        [JsonProperty("ornamentPrecompTurnTrillBach")]
        BoundingBox OrnamentPrecompTurnTrillBach { get; set; }

        [JsonProperty("ornamentPrecompTurnTrillDAnglebert")]
        BoundingBox OrnamentPrecompTurnTrillDAnglebert { get; set; }

        [JsonProperty("ornamentQuilisma")]
        BoundingBox OrnamentQuilisma { get; set; }

        [JsonProperty("ornamentRightFacingHalfCircle")]
        BoundingBox OrnamentRightFacingHalfCircle { get; set; }

        [JsonProperty("ornamentRightFacingHook")]
        BoundingBox OrnamentRightFacingHook { get; set; }

        [JsonProperty("ornamentRightVerticalStroke")]
        BoundingBox OrnamentRightVerticalStroke { get; set; }

        [JsonProperty("ornamentSchleifer")]
        BoundingBox OrnamentSchleifer { get; set; }

        [JsonProperty("ornamentShake3")]
        BoundingBox OrnamentShake3 { get; set; }

        [JsonProperty("ornamentShakeMuffat1")]
        BoundingBox OrnamentShakeMuffat1 { get; set; }

        [JsonProperty("ornamentShortObliqueLineAfterNote")]
        BoundingBox OrnamentShortObliqueLineAfterNote { get; set; }

        [JsonProperty("ornamentShortObliqueLineBeforeNote")]
        BoundingBox OrnamentShortObliqueLineBeforeNote { get; set; }

        [JsonProperty("ornamentTopLeftConcaveStroke")]
        BoundingBox OrnamentTopLeftConcaveStroke { get; set; }

        [JsonProperty("ornamentTopLeftConvexStroke")]
        BoundingBox OrnamentTopLeftConvexStroke { get; set; }

        [JsonProperty("ornamentTopRightConcaveStroke")]
        BoundingBox OrnamentTopRightConcaveStroke { get; set; }

        [JsonProperty("ornamentTopRightConvexStroke")]
        BoundingBox OrnamentTopRightConvexStroke { get; set; }

        [JsonProperty("ornamentTremblement")]
        BoundingBox OrnamentTremblement { get; set; }

        [JsonProperty("ornamentTremblementCouperin")]
        BoundingBox OrnamentTremblementCouperin { get; set; }

        [JsonProperty("ornamentTrill")]
        BoundingBox OrnamentTrill { get; set; }

        [JsonProperty("ornamentTrillFlatAbove")]
        BoundingBox OrnamentTrillFlatAbove { get; set; }

        [JsonProperty("ornamentTrillNaturalAbove")]
        BoundingBox OrnamentTrillNaturalAbove { get; set; }

        [JsonProperty("ornamentTrillSharpAbove")]
        BoundingBox OrnamentTrillSharpAbove { get; set; }

        [JsonProperty("ornamentTurn")]
        BoundingBox OrnamentTurn { get; set; }

        [JsonProperty("ornamentTurnFlatAbove")]
        BoundingBox OrnamentTurnFlatAbove { get; set; }

        [JsonProperty("ornamentTurnFlatAboveSharpBelow")]
        BoundingBox OrnamentTurnFlatAboveSharpBelow { get; set; }

        [JsonProperty("ornamentTurnFlatBelow")]
        BoundingBox OrnamentTurnFlatBelow { get; set; }

        [JsonProperty("ornamentTurnInverted")]
        BoundingBox OrnamentTurnInverted { get; set; }

        [JsonProperty("ornamentTurnNaturalAbove")]
        BoundingBox OrnamentTurnNaturalAbove { get; set; }

        [JsonProperty("ornamentTurnNaturalBelow")]
        BoundingBox OrnamentTurnNaturalBelow { get; set; }

        [JsonProperty("ornamentTurnSharpAbove")]
        BoundingBox OrnamentTurnSharpAbove { get; set; }

        [JsonProperty("ornamentTurnSharpAboveFlatBelow")]
        BoundingBox OrnamentTurnSharpAboveFlatBelow { get; set; }

        [JsonProperty("ornamentTurnSharpBelow")]
        BoundingBox OrnamentTurnSharpBelow { get; set; }

        [JsonProperty("ornamentTurnSlash")]
        BoundingBox OrnamentTurnSlash { get; set; }

        [JsonProperty("ornamentTurnUp")]
        BoundingBox OrnamentTurnUp { get; set; }

        [JsonProperty("ornamentTurnUpS")]
        BoundingBox OrnamentTurnUpS { get; set; }

        [JsonProperty("ornamentUpCurve")]
        BoundingBox OrnamentUpCurve { get; set; }

        [JsonProperty("ornamentVerticalLine")]
        BoundingBox OrnamentVerticalLine { get; set; }

        [JsonProperty("ornamentZigZagLineNoRightEnd")]
        BoundingBox OrnamentZigZagLineNoRightEnd { get; set; }

        [JsonProperty("ornamentZigZagLineWithRightEnd")]
        BoundingBox OrnamentZigZagLineWithRightEnd { get; set; }

        [JsonProperty("ottava")]
        BoundingBox Ottava { get; set; }

        [JsonProperty("ottavaAlta")]
        BoundingBox OttavaAlta { get; set; }

        [JsonProperty("ottavaBassa")]
        BoundingBox OttavaBassa { get; set; }

        [JsonProperty("ottavaBassaBa")]
        BoundingBox OttavaBassaBa { get; set; }

        [JsonProperty("ottavaBassaVb")]
        BoundingBox OttavaBassaVb { get; set; }

        [JsonProperty("pendereckiTremolo")]
        BoundingBox PendereckiTremolo { get; set; }

        [JsonProperty("pictAgogo")]
        BoundingBox PictAgogo { get; set; }

        [JsonProperty("pictAlmglocken")]
        BoundingBox PictAlmglocken { get; set; }

        [JsonProperty("pictAnvil")]
        BoundingBox PictAnvil { get; set; }

        [JsonProperty("pictBambooChimes")]
        BoundingBox PictBambooChimes { get; set; }

        [JsonProperty("pictBambooScraper")]
        BoundingBox PictBambooScraper { get; set; }

        [JsonProperty("pictBassDrum")]
        BoundingBox PictBassDrum { get; set; }

        [JsonProperty("pictBassDrumOnSide")]
        BoundingBox PictBassDrumOnSide { get; set; }

        [JsonProperty("pictBassDrumPeinkofer")]
        BoundingBox PictBassDrumPeinkofer { get; set; }

        [JsonProperty("pictBeaterBow")]
        BoundingBox PictBeaterBow { get; set; }

        [JsonProperty("pictBeaterBox")]
        BoundingBox PictBeaterBox { get; set; }

        [JsonProperty("pictBeaterBrassMalletsDown")]
        BoundingBox PictBeaterBrassMalletsDown { get; set; }

        [JsonProperty("pictBeaterBrassMalletsUp")]
        BoundingBox PictBeaterBrassMalletsUp { get; set; }

        [JsonProperty("pictBeaterCombiningDashedCircle")]
        BoundingBox PictBeaterCombiningDashedCircle { get; set; }

        [JsonProperty("pictBeaterCombiningParentheses")]
        BoundingBox PictBeaterCombiningParentheses { get; set; }

        [JsonProperty("pictBeaterDoubleBassDrumDown")]
        BoundingBox PictBeaterDoubleBassDrumDown { get; set; }

        [JsonProperty("pictBeaterDoubleBassDrumUp")]
        BoundingBox PictBeaterDoubleBassDrumUp { get; set; }

        [JsonProperty("pictBeaterFinger")]
        BoundingBox PictBeaterFinger { get; set; }

        [JsonProperty("pictBeaterFingernails")]
        BoundingBox PictBeaterFingernails { get; set; }

        [JsonProperty("pictBeaterFist")]
        BoundingBox PictBeaterFist { get; set; }

        [JsonProperty("pictBeaterGuiroScraper")]
        BoundingBox PictBeaterGuiroScraper { get; set; }

        [JsonProperty("pictBeaterHammer")]
        BoundingBox PictBeaterHammer { get; set; }

        [JsonProperty("pictBeaterHammerMetalDown")]
        BoundingBox PictBeaterHammerMetalDown { get; set; }

        [JsonProperty("pictBeaterHammerMetalUp")]
        BoundingBox PictBeaterHammerMetalUp { get; set; }

        [JsonProperty("pictBeaterHammerPlasticDown")]
        BoundingBox PictBeaterHammerPlasticDown { get; set; }

        [JsonProperty("pictBeaterHammerPlasticUp")]
        BoundingBox PictBeaterHammerPlasticUp { get; set; }

        [JsonProperty("pictBeaterHammerWoodDown")]
        BoundingBox PictBeaterHammerWoodDown { get; set; }

        [JsonProperty("pictBeaterHammerWoodUp")]
        BoundingBox PictBeaterHammerWoodUp { get; set; }

        [JsonProperty("pictBeaterHand")]
        BoundingBox PictBeaterHand { get; set; }

        [JsonProperty("pictBeaterHardBassDrumDown")]
        BoundingBox PictBeaterHardBassDrumDown { get; set; }

        [JsonProperty("pictBeaterHardBassDrumUp")]
        BoundingBox PictBeaterHardBassDrumUp { get; set; }

        [JsonProperty("pictBeaterHardGlockenspielDown")]
        BoundingBox PictBeaterHardGlockenspielDown { get; set; }

        [JsonProperty("pictBeaterHardGlockenspielLeft")]
        BoundingBox PictBeaterHardGlockenspielLeft { get; set; }

        [JsonProperty("pictBeaterHardGlockenspielRight")]
        BoundingBox PictBeaterHardGlockenspielRight { get; set; }

        [JsonProperty("pictBeaterHardGlockenspielUp")]
        BoundingBox PictBeaterHardGlockenspielUp { get; set; }

        [JsonProperty("pictBeaterHardTimpaniDown")]
        BoundingBox PictBeaterHardTimpaniDown { get; set; }

        [JsonProperty("pictBeaterHardTimpaniLeft")]
        BoundingBox PictBeaterHardTimpaniLeft { get; set; }

        [JsonProperty("pictBeaterHardTimpaniRight")]
        BoundingBox PictBeaterHardTimpaniRight { get; set; }

        [JsonProperty("pictBeaterHardTimpaniUp")]
        BoundingBox PictBeaterHardTimpaniUp { get; set; }

        [JsonProperty("pictBeaterHardXylophoneDown")]
        BoundingBox PictBeaterHardXylophoneDown { get; set; }

        [JsonProperty("pictBeaterHardXylophoneLeft")]
        BoundingBox PictBeaterHardXylophoneLeft { get; set; }

        [JsonProperty("pictBeaterHardXylophoneRight")]
        BoundingBox PictBeaterHardXylophoneRight { get; set; }

        [JsonProperty("pictBeaterHardXylophoneUp")]
        BoundingBox PictBeaterHardXylophoneUp { get; set; }

        [JsonProperty("pictBeaterHardYarnDown")]
        BoundingBox PictBeaterHardYarnDown { get; set; }

        [JsonProperty("pictBeaterHardYarnLeft")]
        BoundingBox PictBeaterHardYarnLeft { get; set; }

        [JsonProperty("pictBeaterHardYarnRight")]
        BoundingBox PictBeaterHardYarnRight { get; set; }

        [JsonProperty("pictBeaterHardYarnUp")]
        BoundingBox PictBeaterHardYarnUp { get; set; }

        [JsonProperty("pictBeaterJazzSticksDown")]
        BoundingBox PictBeaterJazzSticksDown { get; set; }

        [JsonProperty("pictBeaterJazzSticksUp")]
        BoundingBox PictBeaterJazzSticksUp { get; set; }

        [JsonProperty("pictBeaterKnittingNeedle")]
        BoundingBox PictBeaterKnittingNeedle { get; set; }

        [JsonProperty("pictBeaterMallet")]
        BoundingBox PictBeaterMallet { get; set; }

        [JsonProperty("pictBeaterMediumBassDrumDown")]
        BoundingBox PictBeaterMediumBassDrumDown { get; set; }

        [JsonProperty("pictBeaterMediumBassDrumUp")]
        BoundingBox PictBeaterMediumBassDrumUp { get; set; }

        [JsonProperty("pictBeaterMediumTimpaniDown")]
        BoundingBox PictBeaterMediumTimpaniDown { get; set; }

        [JsonProperty("pictBeaterMediumTimpaniLeft")]
        BoundingBox PictBeaterMediumTimpaniLeft { get; set; }

        [JsonProperty("pictBeaterMediumTimpaniRight")]
        BoundingBox PictBeaterMediumTimpaniRight { get; set; }

        [JsonProperty("pictBeaterMediumTimpaniUp")]
        BoundingBox PictBeaterMediumTimpaniUp { get; set; }

        [JsonProperty("pictBeaterMediumXylophoneDown")]
        BoundingBox PictBeaterMediumXylophoneDown { get; set; }

        [JsonProperty("pictBeaterMediumXylophoneLeft")]
        BoundingBox PictBeaterMediumXylophoneLeft { get; set; }

        [JsonProperty("pictBeaterMediumXylophoneRight")]
        BoundingBox PictBeaterMediumXylophoneRight { get; set; }

        [JsonProperty("pictBeaterMediumXylophoneUp")]
        BoundingBox PictBeaterMediumXylophoneUp { get; set; }

        [JsonProperty("pictBeaterMediumYarnDown")]
        BoundingBox PictBeaterMediumYarnDown { get; set; }

        [JsonProperty("pictBeaterMediumYarnLeft")]
        BoundingBox PictBeaterMediumYarnLeft { get; set; }

        [JsonProperty("pictBeaterMediumYarnRight")]
        BoundingBox PictBeaterMediumYarnRight { get; set; }

        [JsonProperty("pictBeaterMediumYarnUp")]
        BoundingBox PictBeaterMediumYarnUp { get; set; }

        [JsonProperty("pictBeaterMetalBassDrumDown")]
        BoundingBox PictBeaterMetalBassDrumDown { get; set; }

        [JsonProperty("pictBeaterMetalBassDrumUp")]
        BoundingBox PictBeaterMetalBassDrumUp { get; set; }

        [JsonProperty("pictBeaterMetalDown")]
        BoundingBox PictBeaterMetalDown { get; set; }

        [JsonProperty("pictBeaterMetalHammer")]
        BoundingBox PictBeaterMetalHammer { get; set; }

        [JsonProperty("pictBeaterMetalLeft")]
        BoundingBox PictBeaterMetalLeft { get; set; }

        [JsonProperty("pictBeaterMetalRight")]
        BoundingBox PictBeaterMetalRight { get; set; }

        [JsonProperty("pictBeaterMetalUp")]
        BoundingBox PictBeaterMetalUp { get; set; }

        [JsonProperty("pictBeaterSnareSticksDown")]
        BoundingBox PictBeaterSnareSticksDown { get; set; }

        [JsonProperty("pictBeaterSnareSticksUp")]
        BoundingBox PictBeaterSnareSticksUp { get; set; }

        [JsonProperty("pictBeaterSoftBassDrumDown")]
        BoundingBox PictBeaterSoftBassDrumDown { get; set; }

        [JsonProperty("pictBeaterSoftBassDrumUp")]
        BoundingBox PictBeaterSoftBassDrumUp { get; set; }

        [JsonProperty("pictBeaterSoftGlockenspielDown")]
        BoundingBox PictBeaterSoftGlockenspielDown { get; set; }

        [JsonProperty("pictBeaterSoftGlockenspielLeft")]
        BoundingBox PictBeaterSoftGlockenspielLeft { get; set; }

        [JsonProperty("pictBeaterSoftGlockenspielRight")]
        BoundingBox PictBeaterSoftGlockenspielRight { get; set; }

        [JsonProperty("pictBeaterSoftGlockenspielUp")]
        BoundingBox PictBeaterSoftGlockenspielUp { get; set; }

        [JsonProperty("pictBeaterSoftTimpaniDown")]
        BoundingBox PictBeaterSoftTimpaniDown { get; set; }

        [JsonProperty("pictBeaterSoftTimpaniLeft")]
        BoundingBox PictBeaterSoftTimpaniLeft { get; set; }

        [JsonProperty("pictBeaterSoftTimpaniRight")]
        BoundingBox PictBeaterSoftTimpaniRight { get; set; }

        [JsonProperty("pictBeaterSoftTimpaniUp")]
        BoundingBox PictBeaterSoftTimpaniUp { get; set; }

        [JsonProperty("pictBeaterSoftXylophone")]
        BoundingBox PictBeaterSoftXylophone { get; set; }

        [JsonProperty("pictBeaterSoftXylophoneDown")]
        BoundingBox PictBeaterSoftXylophoneDown { get; set; }

        [JsonProperty("pictBeaterSoftXylophoneLeft")]
        BoundingBox PictBeaterSoftXylophoneLeft { get; set; }

        [JsonProperty("pictBeaterSoftXylophoneRight")]
        BoundingBox PictBeaterSoftXylophoneRight { get; set; }

        [JsonProperty("pictBeaterSoftXylophoneUp")]
        BoundingBox PictBeaterSoftXylophoneUp { get; set; }

        [JsonProperty("pictBeaterSoftYarnDown")]
        BoundingBox PictBeaterSoftYarnDown { get; set; }

        [JsonProperty("pictBeaterSoftYarnLeft")]
        BoundingBox PictBeaterSoftYarnLeft { get; set; }

        [JsonProperty("pictBeaterSoftYarnRight")]
        BoundingBox PictBeaterSoftYarnRight { get; set; }

        [JsonProperty("pictBeaterSoftYarnUp")]
        BoundingBox PictBeaterSoftYarnUp { get; set; }

        [JsonProperty("pictBeaterSpoonWoodenMallet")]
        BoundingBox PictBeaterSpoonWoodenMallet { get; set; }

        [JsonProperty("pictBeaterSuperballDown")]
        BoundingBox PictBeaterSuperballDown { get; set; }

        [JsonProperty("pictBeaterSuperballLeft")]
        BoundingBox PictBeaterSuperballLeft { get; set; }

        [JsonProperty("pictBeaterSuperballRight")]
        BoundingBox PictBeaterSuperballRight { get; set; }

        [JsonProperty("pictBeaterSuperballUp")]
        BoundingBox PictBeaterSuperballUp { get; set; }

        [JsonProperty("pictBeaterTriangleDown")]
        BoundingBox PictBeaterTriangleDown { get; set; }

        [JsonProperty("pictBeaterTriangleUp")]
        BoundingBox PictBeaterTriangleUp { get; set; }

        [JsonProperty("pictBeaterWireBrushesDown")]
        BoundingBox PictBeaterWireBrushesDown { get; set; }

        [JsonProperty("pictBeaterWireBrushesUp")]
        BoundingBox PictBeaterWireBrushesUp { get; set; }

        [JsonProperty("pictBeaterWoodTimpaniDown")]
        BoundingBox PictBeaterWoodTimpaniDown { get; set; }

        [JsonProperty("pictBeaterWoodTimpaniLeft")]
        BoundingBox PictBeaterWoodTimpaniLeft { get; set; }

        [JsonProperty("pictBeaterWoodTimpaniRight")]
        BoundingBox PictBeaterWoodTimpaniRight { get; set; }

        [JsonProperty("pictBeaterWoodTimpaniUp")]
        BoundingBox PictBeaterWoodTimpaniUp { get; set; }

        [JsonProperty("pictBeaterWoodXylophoneDown")]
        BoundingBox PictBeaterWoodXylophoneDown { get; set; }

        [JsonProperty("pictBeaterWoodXylophoneLeft")]
        BoundingBox PictBeaterWoodXylophoneLeft { get; set; }

        [JsonProperty("pictBeaterWoodXylophoneRight")]
        BoundingBox PictBeaterWoodXylophoneRight { get; set; }

        [JsonProperty("pictBeaterWoodXylophoneUp")]
        BoundingBox PictBeaterWoodXylophoneUp { get; set; }

        [JsonProperty("pictBell")]
        BoundingBox PictBell { get; set; }

        [JsonProperty("pictBellOfCymbal")]
        BoundingBox PictBellOfCymbal { get; set; }

        [JsonProperty("pictBellPlate")]
        BoundingBox PictBellPlate { get; set; }

        [JsonProperty("pictBellTree")]
        BoundingBox PictBellTree { get; set; }

        [JsonProperty("pictBirdWhistle")]
        BoundingBox PictBirdWhistle { get; set; }

        [JsonProperty("pictBoardClapper")]
        BoundingBox PictBoardClapper { get; set; }

        [JsonProperty("pictBongos")]
        BoundingBox PictBongos { get; set; }

        [JsonProperty("pictBongosPeinkofer")]
        BoundingBox PictBongosPeinkofer { get; set; }

        [JsonProperty("pictBrakeDrum")]
        BoundingBox PictBrakeDrum { get; set; }

        [JsonProperty("pictCabasa")]
        BoundingBox PictCabasa { get; set; }

        [JsonProperty("pictCannon")]
        BoundingBox PictCannon { get; set; }

        [JsonProperty("pictCarHorn")]
        BoundingBox PictCarHorn { get; set; }

        [JsonProperty("pictCastanets")]
        BoundingBox PictCastanets { get; set; }

        [JsonProperty("pictCastanetsSmithBrindle")]
        BoundingBox PictCastanetsSmithBrindle { get; set; }

        [JsonProperty("pictCastanetsWithHandle")]
        BoundingBox PictCastanetsWithHandle { get; set; }

        [JsonProperty("pictCelesta")]
        BoundingBox PictCelesta { get; set; }

        [JsonProperty("pictCencerro")]
        BoundingBox PictCencerro { get; set; }

        [JsonProperty("pictCenter1")]
        BoundingBox PictCenter1 { get; set; }

        [JsonProperty("pictCenter2")]
        BoundingBox PictCenter2 { get; set; }

        [JsonProperty("pictCenter3")]
        BoundingBox PictCenter3 { get; set; }

        [JsonProperty("pictChainRattle")]
        BoundingBox PictChainRattle { get; set; }

        [JsonProperty("pictChimes")]
        BoundingBox PictChimes { get; set; }

        [JsonProperty("pictChineseCymbal")]
        BoundingBox PictChineseCymbal { get; set; }

        [JsonProperty("pictChokeCymbal")]
        BoundingBox PictChokeCymbal { get; set; }

        [JsonProperty("pictClaves")]
        BoundingBox PictClaves { get; set; }

        [JsonProperty("pictCoins")]
        BoundingBox PictCoins { get; set; }

        [JsonProperty("pictConga")]
        BoundingBox PictConga { get; set; }

        [JsonProperty("pictCongaPeinkofer")]
        BoundingBox PictCongaPeinkofer { get; set; }

        [JsonProperty("pictCowBell")]
        BoundingBox PictCowBell { get; set; }

        [JsonProperty("pictCowBellBerio")]
        BoundingBox PictCowBellBerio { get; set; }

        [JsonProperty("pictCrashCymbals")]
        BoundingBox PictCrashCymbals { get; set; }

        [JsonProperty("pictCrotales")]
        BoundingBox PictCrotales { get; set; }

        [JsonProperty("pictCrushStem")]
        BoundingBox PictCrushStem { get; set; }

        [JsonProperty("pictCuica")]
        BoundingBox PictCuica { get; set; }

        [JsonProperty("pictCymbalTongs")]
        BoundingBox PictCymbalTongs { get; set; }

        [JsonProperty("pictDamp1")]
        BoundingBox PictDamp1 { get; set; }

        [JsonProperty("pictDamp2")]
        BoundingBox PictDamp2 { get; set; }

        [JsonProperty("pictDamp3")]
        BoundingBox PictDamp3 { get; set; }

        [JsonProperty("pictDamp4")]
        BoundingBox PictDamp4 { get; set; }

        [JsonProperty("pictDeadNoteStem")]
        BoundingBox PictDeadNoteStem { get; set; }

        [JsonProperty("pictDrumStick")]
        BoundingBox PictDrumStick { get; set; }

        [JsonProperty("pictDuckCall")]
        BoundingBox PictDuckCall { get; set; }

        [JsonProperty("pictEdgeOfCymbal")]
        BoundingBox PictEdgeOfCymbal { get; set; }

        [JsonProperty("pictEmptyTrap")]
        BoundingBox PictEmptyTrap { get; set; }

        [JsonProperty("pictFingerCymbals")]
        BoundingBox PictFingerCymbals { get; set; }

        [JsonProperty("pictFlexatone")]
        BoundingBox PictFlexatone { get; set; }

        [JsonProperty("pictFlexatonePeinkofer")]
        BoundingBox PictFlexatonePeinkofer { get; set; }

        [JsonProperty("pictFootballRatchet")]
        BoundingBox PictFootballRatchet { get; set; }

        [JsonProperty("pictGlassHarmonica")]
        BoundingBox PictGlassHarmonica { get; set; }

        [JsonProperty("pictGlassHarp")]
        BoundingBox PictGlassHarp { get; set; }

        [JsonProperty("pictGlassPlateChimes")]
        BoundingBox PictGlassPlateChimes { get; set; }

        [JsonProperty("pictGlassTubeChimes")]
        BoundingBox PictGlassTubeChimes { get; set; }

        [JsonProperty("pictGlsp")]
        BoundingBox PictGlsp { get; set; }

        [JsonProperty("pictGlspPeinkofer")]
        BoundingBox PictGlspPeinkofer { get; set; }

        [JsonProperty("pictGlspSmithBrindle")]
        BoundingBox PictGlspSmithBrindle { get; set; }

        [JsonProperty("pictGobletDrum")]
        BoundingBox PictGobletDrum { get; set; }

        [JsonProperty("pictGong")]
        BoundingBox PictGong { get; set; }

        [JsonProperty("pictGongWithButton")]
        BoundingBox PictGongWithButton { get; set; }

        [JsonProperty("pictGuiro")]
        BoundingBox PictGuiro { get; set; }

        [JsonProperty("pictGuiroPeinkofer")]
        BoundingBox PictGuiroPeinkofer { get; set; }

        [JsonProperty("pictGuiroSevsay")]
        BoundingBox PictGuiroSevsay { get; set; }

        [JsonProperty("pictGumHardDown")]
        BoundingBox PictGumHardDown { get; set; }

        [JsonProperty("pictGumHardLeft")]
        BoundingBox PictGumHardLeft { get; set; }

        [JsonProperty("pictGumHardRight")]
        BoundingBox PictGumHardRight { get; set; }

        [JsonProperty("pictGumHardUp")]
        BoundingBox PictGumHardUp { get; set; }

        [JsonProperty("pictGumMediumDown")]
        BoundingBox PictGumMediumDown { get; set; }

        [JsonProperty("pictGumMediumLeft")]
        BoundingBox PictGumMediumLeft { get; set; }

        [JsonProperty("pictGumMediumRight")]
        BoundingBox PictGumMediumRight { get; set; }

        [JsonProperty("pictGumMediumUp")]
        BoundingBox PictGumMediumUp { get; set; }

        [JsonProperty("pictGumSoftDown")]
        BoundingBox PictGumSoftDown { get; set; }

        [JsonProperty("pictGumSoftLeft")]
        BoundingBox PictGumSoftLeft { get; set; }

        [JsonProperty("pictGumSoftRight")]
        BoundingBox PictGumSoftRight { get; set; }

        [JsonProperty("pictGumSoftUp")]
        BoundingBox PictGumSoftUp { get; set; }

        [JsonProperty("pictHalfOpen1")]
        BoundingBox PictHalfOpen1 { get; set; }

        [JsonProperty("pictHalfOpen2")]
        BoundingBox PictHalfOpen2 { get; set; }

        [JsonProperty("pictHandbell")]
        BoundingBox PictHandbell { get; set; }

        [JsonProperty("pictHiHat")]
        BoundingBox PictHiHat { get; set; }

        [JsonProperty("pictHiHatOnStand")]
        BoundingBox PictHiHatOnStand { get; set; }

        [JsonProperty("pictJawHarp")]
        Dictionary<string, long[]> PictJawHarp { get; set; }

        [JsonProperty("pictJingleBells")]
        BoundingBox PictJingleBells { get; set; }

        [JsonProperty("pictKlaxonHorn")]
        BoundingBox PictKlaxonHorn { get; set; }

        [JsonProperty("pictLeftHandCircle")]
        BoundingBox PictLeftHandCircle { get; set; }

        [JsonProperty("pictLionsRoar")]
        BoundingBox PictLionsRoar { get; set; }

        [JsonProperty("pictLithophone")]
        BoundingBox PictLithophone { get; set; }

        [JsonProperty("pictLithophonePeinkofer")]
        BoundingBox PictLithophonePeinkofer { get; set; }

        [JsonProperty("pictLogDrum")]
        BoundingBox PictLogDrum { get; set; }

        [JsonProperty("pictLotusFlute")]
        BoundingBox PictLotusFlute { get; set; }

        [JsonProperty("pictLotusFlutePeinkofer")]
        BoundingBox PictLotusFlutePeinkofer { get; set; }

        [JsonProperty("pictMar")]
        BoundingBox PictMar { get; set; }

        [JsonProperty("pictMarPeinkofer")]
        BoundingBox PictMarPeinkofer { get; set; }

        [JsonProperty("pictMarSmithBrindle")]
        BoundingBox PictMarSmithBrindle { get; set; }

        [JsonProperty("pictMaraca")]
        BoundingBox PictMaraca { get; set; }

        [JsonProperty("pictMaracaSmithBrindle")]
        BoundingBox PictMaracaSmithBrindle { get; set; }

        [JsonProperty("pictMaracas")]
        BoundingBox PictMaracas { get; set; }

        [JsonProperty("pictMegaphone")]
        BoundingBox PictMegaphone { get; set; }

        [JsonProperty("pictMetalPlateChimes")]
        BoundingBox PictMetalPlateChimes { get; set; }

        [JsonProperty("pictMetalTubeChimes")]
        BoundingBox PictMetalTubeChimes { get; set; }

        [JsonProperty("pictMusicalSaw")]
        BoundingBox PictMusicalSaw { get; set; }

        [JsonProperty("pictMusicalSawPeinkofer")]
        BoundingBox PictMusicalSawPeinkofer { get; set; }

        [JsonProperty("pictNormalPosition")]
        BoundingBox PictNormalPosition { get; set; }

        [JsonProperty("pictOnRim")]
        BoundingBox PictOnRim { get; set; }

        [JsonProperty("pictOpen")]
        BoundingBox PictOpen { get; set; }

        [JsonProperty("pictOpenRimShot")]
        BoundingBox PictOpenRimShot { get; set; }

        [JsonProperty("pictPistolShot")]
        BoundingBox PictPistolShot { get; set; }

        [JsonProperty("pictPoliceWhistle")]
        BoundingBox PictPoliceWhistle { get; set; }

        [JsonProperty("pictQuijada")]
        BoundingBox PictQuijada { get; set; }

        [JsonProperty("pictRainstick")]
        BoundingBox PictRainstick { get; set; }

        [JsonProperty("pictRatchet")]
        BoundingBox PictRatchet { get; set; }

        [JsonProperty("pictRecoReco")]
        BoundingBox PictRecoReco { get; set; }

        [JsonProperty("pictRightHandSquare")]
        BoundingBox PictRightHandSquare { get; set; }

        [JsonProperty("pictRim1")]
        BoundingBox PictRim1 { get; set; }

        [JsonProperty("pictRim2")]
        BoundingBox PictRim2 { get; set; }

        [JsonProperty("pictRim3")]
        BoundingBox PictRim3 { get; set; }

        [JsonProperty("pictRimShotOnStem")]
        BoundingBox PictRimShotOnStem { get; set; }

        [JsonProperty("pictSandpaperBlocks")]
        BoundingBox PictSandpaperBlocks { get; set; }

        [JsonProperty("pictScrapeAroundRim")]
        BoundingBox PictScrapeAroundRim { get; set; }

        [JsonProperty("pictScrapeAroundRimClockwise")]
        BoundingBox PictScrapeAroundRimClockwise { get; set; }

        [JsonProperty("pictScrapeCenterToEdge")]
        BoundingBox PictScrapeCenterToEdge { get; set; }

        [JsonProperty("pictScrapeEdgeToCenter")]
        BoundingBox PictScrapeEdgeToCenter { get; set; }

        [JsonProperty("pictShellBells")]
        Dictionary<string, long[]> PictShellBells { get; set; }

        [JsonProperty("pictShellChimes")]
        BoundingBox PictShellChimes { get; set; }

        [JsonProperty("pictSiren")]
        BoundingBox PictSiren { get; set; }

        [JsonProperty("pictSistrum")]
        BoundingBox PictSistrum { get; set; }

        [JsonProperty("pictSizzleCymbal")]
        BoundingBox PictSizzleCymbal { get; set; }

        [JsonProperty("pictSleighBell")]
        BoundingBox PictSleighBell { get; set; }

        [JsonProperty("pictSleighBellSmithBrindle")]
        BoundingBox PictSleighBellSmithBrindle { get; set; }

        [JsonProperty("pictSlideBrushOnGong")]
        BoundingBox PictSlideBrushOnGong { get; set; }

        [JsonProperty("pictSlideWhistle")]
        BoundingBox PictSlideWhistle { get; set; }

        [JsonProperty("pictSlitDrum")]
        BoundingBox PictSlitDrum { get; set; }

        [JsonProperty("pictSnareDrum")]
        BoundingBox PictSnareDrum { get; set; }

        [JsonProperty("pictSnareDrumMilitary")]
        BoundingBox PictSnareDrumMilitary { get; set; }

        [JsonProperty("pictSnareDrumSnaresOff")]
        BoundingBox PictSnareDrumSnaresOff { get; set; }

        [JsonProperty("pictSteelDrums")]
        BoundingBox PictSteelDrums { get; set; }

        [JsonProperty("pictStickShot")]
        BoundingBox PictStickShot { get; set; }

        [JsonProperty("pictSuperball")]
        BoundingBox PictSuperball { get; set; }

        [JsonProperty("pictSuspendedCymbal")]
        BoundingBox PictSuspendedCymbal { get; set; }

        [JsonProperty("pictSwishStem")]
        BoundingBox PictSwishStem { get; set; }

        [JsonProperty("pictTabla")]
        BoundingBox PictTabla { get; set; }

        [JsonProperty("pictTamTam")]
        BoundingBox PictTamTam { get; set; }

        [JsonProperty("pictTamTamWithBeater")]
        BoundingBox PictTamTamWithBeater { get; set; }

        [JsonProperty("pictTambourine")]
        BoundingBox PictTambourine { get; set; }

        [JsonProperty("pictTambourineStockhausen")]
        BoundingBox PictTambourineStockhausen { get; set; }

        [JsonProperty("pictTempleBlocks")]
        BoundingBox PictTempleBlocks { get; set; }

        [JsonProperty("pictTenorDrum")]
        BoundingBox PictTenorDrum { get; set; }

        [JsonProperty("pictThundersheet")]
        BoundingBox PictThundersheet { get; set; }

        [JsonProperty("pictTimbales")]
        BoundingBox PictTimbales { get; set; }

        [JsonProperty("pictTimbalesPeinkofer")]
        BoundingBox PictTimbalesPeinkofer { get; set; }

        [JsonProperty("pictTimpani")]
        BoundingBox PictTimpani { get; set; }

        [JsonProperty("pictTimpaniPeinkofer")]
        BoundingBox PictTimpaniPeinkofer { get; set; }

        [JsonProperty("pictTomTom")]
        BoundingBox PictTomTom { get; set; }

        [JsonProperty("pictTomTomChinese")]
        BoundingBox PictTomTomChinese { get; set; }

        [JsonProperty("pictTomTomChinesePeinkofer")]
        BoundingBox PictTomTomChinesePeinkofer { get; set; }

        [JsonProperty("pictTomTomIndoAmerican")]
        BoundingBox PictTomTomIndoAmerican { get; set; }

        [JsonProperty("pictTomTomJapanese")]
        BoundingBox PictTomTomJapanese { get; set; }

        [JsonProperty("pictTomTomPeinkofer")]
        BoundingBox PictTomTomPeinkofer { get; set; }

        [JsonProperty("pictTriangle")]
        BoundingBox PictTriangle { get; set; }

        [JsonProperty("pictTubaphone")]
        BoundingBox PictTubaphone { get; set; }

        [JsonProperty("pictTubaphonePeinkofer")]
        BoundingBox PictTubaphonePeinkofer { get; set; }

        [JsonProperty("pictTubularBells")]
        BoundingBox PictTubularBells { get; set; }

        [JsonProperty("pictTurnLeftStem")]
        BoundingBox PictTurnLeftStem { get; set; }

        [JsonProperty("pictTurnRightLeftStem")]
        BoundingBox PictTurnRightLeftStem { get; set; }

        [JsonProperty("pictTurnRightStem")]
        BoundingBox PictTurnRightStem { get; set; }

        [JsonProperty("pictVib")]
        BoundingBox PictVib { get; set; }

        [JsonProperty("pictVibMotorOff")]
        BoundingBox PictVibMotorOff { get; set; }

        [JsonProperty("pictVibMotorOffPeinkofer")]
        BoundingBox PictVibMotorOffPeinkofer { get; set; }

        [JsonProperty("pictVibPeinkofer")]
        BoundingBox PictVibPeinkofer { get; set; }

        [JsonProperty("pictVibSmithBrindle")]
        BoundingBox PictVibSmithBrindle { get; set; }

        [JsonProperty("pictVibraslap")]
        BoundingBox PictVibraslap { get; set; }

        [JsonProperty("pictVietnameseHat")]
        BoundingBox PictVietnameseHat { get; set; }

        [JsonProperty("pictWhip")]
        BoundingBox PictWhip { get; set; }

        [JsonProperty("pictWindChimesGlass")]
        BoundingBox PictWindChimesGlass { get; set; }

        [JsonProperty("pictWindMachine")]
        BoundingBox PictWindMachine { get; set; }

        [JsonProperty("pictWindWhistle")]
        BoundingBox PictWindWhistle { get; set; }

        [JsonProperty("pictWoodBlock")]
        BoundingBox PictWoodBlock { get; set; }

        [JsonProperty("pictWoundHardDown")]
        BoundingBox PictWoundHardDown { get; set; }

        [JsonProperty("pictWoundHardLeft")]
        BoundingBox PictWoundHardLeft { get; set; }

        [JsonProperty("pictWoundHardRight")]
        BoundingBox PictWoundHardRight { get; set; }

        [JsonProperty("pictWoundHardUp")]
        BoundingBox PictWoundHardUp { get; set; }

        [JsonProperty("pictWoundSoftDown")]
        BoundingBox PictWoundSoftDown { get; set; }

        [JsonProperty("pictWoundSoftLeft")]
        BoundingBox PictWoundSoftLeft { get; set; }

        [JsonProperty("pictWoundSoftRight")]
        BoundingBox PictWoundSoftRight { get; set; }

        [JsonProperty("pictWoundSoftUp")]
        BoundingBox PictWoundSoftUp { get; set; }

        [JsonProperty("pictXyl")]
        BoundingBox PictXyl { get; set; }

        [JsonProperty("pictXylBass")]
        BoundingBox PictXylBass { get; set; }

        [JsonProperty("pictXylBassPeinkofer")]
        BoundingBox PictXylBassPeinkofer { get; set; }

        [JsonProperty("pictXylPeinkofer")]
        BoundingBox PictXylPeinkofer { get; set; }

        [JsonProperty("pictXylSmithBrindle")]
        BoundingBox PictXylSmithBrindle { get; set; }

        [JsonProperty("pictXylTenor")]
        BoundingBox PictXylTenor { get; set; }

        [JsonProperty("pictXylTenorPeinkofer")]
        BoundingBox PictXylTenorPeinkofer { get; set; }

        [JsonProperty("pictXylTenorTrough")]
        BoundingBox PictXylTenorTrough { get; set; }

        [JsonProperty("pictXylTrough")]
        BoundingBox PictXylTrough { get; set; }

        [JsonProperty("pluckedBuzzPizzicato")]
        BoundingBox PluckedBuzzPizzicato { get; set; }

        [JsonProperty("pluckedDamp")]
        BoundingBox PluckedDamp { get; set; }

        [JsonProperty("pluckedDampAll")]
        BoundingBox PluckedDampAll { get; set; }

        [JsonProperty("pluckedDampOnStem")]
        BoundingBox PluckedDampOnStem { get; set; }

        [JsonProperty("pluckedFingernailFlick")]
        BoundingBox PluckedFingernailFlick { get; set; }

        [JsonProperty("pluckedLeftHandPizzicato")]
        BoundingBox PluckedLeftHandPizzicato { get; set; }

        [JsonProperty("pluckedPlectrum")]
        BoundingBox PluckedPlectrum { get; set; }

        [JsonProperty("pluckedSnapPizzicatoAbove")]
        BoundingBox PluckedSnapPizzicatoAbove { get; set; }

        [JsonProperty("pluckedSnapPizzicatoAboveGerman")]
        BoundingBox PluckedSnapPizzicatoAboveGerman { get; set; }

        [JsonProperty("pluckedSnapPizzicatoBelow")]
        BoundingBox PluckedSnapPizzicatoBelow { get; set; }

        [JsonProperty("pluckedSnapPizzicatoBelowGerman")]
        BoundingBox PluckedSnapPizzicatoBelowGerman { get; set; }

        [JsonProperty("pluckedWithFingernails")]
        BoundingBox PluckedWithFingernails { get; set; }

        [JsonProperty("quindicesima")]
        BoundingBox Quindicesima { get; set; }

        [JsonProperty("quindicesimaAlta")]
        BoundingBox QuindicesimaAlta { get; set; }

        [JsonProperty("quindicesimaBassa")]
        BoundingBox QuindicesimaBassa { get; set; }

        [JsonProperty("quindicesimaBassaMb")]
        BoundingBox QuindicesimaBassaMb { get; set; }

        [JsonProperty("repeat1Bar")]
        BoundingBox Repeat1Bar { get; set; }

        [JsonProperty("repeat2Bars")]
        BoundingBox Repeat2Bars { get; set; }

        [JsonProperty("repeat4Bars")]
        BoundingBox Repeat4Bars { get; set; }

        [JsonProperty("repeatDot")]
        BoundingBox RepeatDot { get; set; }

        [JsonProperty("repeatDots")]
        BoundingBox RepeatDots { get; set; }

        [JsonProperty("repeatLeft")]
        BoundingBox RepeatLeft { get; set; }

        [JsonProperty("repeatRight")]
        BoundingBox RepeatRight { get; set; }

        [JsonProperty("repeatRightLeft")]
        BoundingBox RepeatRightLeft { get; set; }

        [JsonProperty("repeatRightLeftThick")]
        BoundingBox RepeatRightLeftThick { get; set; }

        [JsonProperty("rest1024th")]
        BoundingBox Rest1024Th { get; set; }

        [JsonProperty("rest128th")]
        BoundingBox Rest128Th { get; set; }

        [JsonProperty("rest16th")]
        BoundingBox Rest16Th { get; set; }

        [JsonProperty("rest256th")]
        BoundingBox Rest256Th { get; set; }

        [JsonProperty("rest32nd")]
        BoundingBox Rest32Nd { get; set; }

        [JsonProperty("rest512th")]
        BoundingBox Rest512Th { get; set; }

        [JsonProperty("rest64th")]
        BoundingBox Rest64Th { get; set; }

        [JsonProperty("rest8th")]
        BoundingBox Rest8Th { get; set; }

        [JsonProperty("restDoubleWhole")]
        BoundingBox RestDoubleWhole { get; set; }

        [JsonProperty("restDoubleWholeLegerLine")]
        BoundingBox RestDoubleWholeLegerLine { get; set; }

        [JsonProperty("restHBar")]
        BoundingBox RestHBar { get; set; }

        [JsonProperty("restHBarLeft")]
        BoundingBox RestHBarLeft { get; set; }

        [JsonProperty("restHBarMiddle")]
        BoundingBox RestHBarMiddle { get; set; }

        [JsonProperty("restHBarRight")]
        BoundingBox RestHBarRight { get; set; }

        [JsonProperty("restHalf")]
        BoundingBox RestHalf { get; set; }

        [JsonProperty("restHalfLegerLine")]
        BoundingBox RestHalfLegerLine { get; set; }

        [JsonProperty("restLonga")]
        BoundingBox RestLonga { get; set; }

        [JsonProperty("restMaxima")]
        BoundingBox RestMaxima { get; set; }

        [JsonProperty("restQuarter")]
        BoundingBox RestQuarter { get; set; }

        [JsonProperty("restQuarterOld")]
        BoundingBox RestQuarterOld { get; set; }

        [JsonProperty("restQuarterZ")]
        BoundingBox RestQuarterZ { get; set; }

        [JsonProperty("restWhole")]
        BoundingBox RestWhole { get; set; }

        [JsonProperty("restWholeLegerLine")]
        BoundingBox RestWholeLegerLine { get; set; }

        [JsonProperty("reversedBrace")]
        BoundingBox ReversedBrace { get; set; }

        [JsonProperty("reversedBracketBottom")]
        BoundingBox ReversedBracketBottom { get; set; }

        [JsonProperty("reversedBracketTop")]
        BoundingBox ReversedBracketTop { get; set; }

        [JsonProperty("rightRepeatSmall")]
        BoundingBox RightRepeatSmall { get; set; }

        [JsonProperty("schaefferClef")]
        BoundingBox SchaefferClef { get; set; }

        [JsonProperty("schaefferFClefToGClef")]
        BoundingBox SchaefferFClefToGClef { get; set; }

        [JsonProperty("schaefferGClefToFClef")]
        BoundingBox SchaefferGClefToFClef { get; set; }

        [JsonProperty("schaefferPreviousClef")]
        BoundingBox SchaefferPreviousClef { get; set; }

        [JsonProperty("sedicesima")]
        BoundingBox Sedicesima { get; set; }

        [JsonProperty("sedicesimaAlta")]
        BoundingBox SedicesimaAlta { get; set; }

        [JsonProperty("sedicesimaBassa")]
        BoundingBox SedicesimaBassa { get; set; }

        [JsonProperty("sedicesimaBassaMb")]
        BoundingBox SedicesimaBassaMb { get; set; }

        [JsonProperty("segno")]
        BoundingBox Segno { get; set; }

        [JsonProperty("segnoJapanese")]
        BoundingBox SegnoJapanese { get; set; }

        [JsonProperty("segnoSerpent1")]
        BoundingBox SegnoSerpent1 { get; set; }

        [JsonProperty("segnoSerpent2")]
        BoundingBox SegnoSerpent2 { get; set; }

        [JsonProperty("semipitchedPercussionClef1")]
        BoundingBox SemipitchedPercussionClef1 { get; set; }

        [JsonProperty("semipitchedPercussionClef2")]
        BoundingBox SemipitchedPercussionClef2 { get; set; }

        [JsonProperty("smnFlat")]
        BoundingBox SmnFlat { get; set; }

        [JsonProperty("smnFlatWhite")]
        BoundingBox SmnFlatWhite { get; set; }

        [JsonProperty("smnHistoryDoubleFlat")]
        BoundingBox SmnHistoryDoubleFlat { get; set; }

        [JsonProperty("smnHistoryDoubleSharp")]
        BoundingBox SmnHistoryDoubleSharp { get; set; }

        [JsonProperty("smnHistoryFlat")]
        BoundingBox SmnHistoryFlat { get; set; }

        [JsonProperty("smnHistorySharp")]
        BoundingBox SmnHistorySharp { get; set; }

        [JsonProperty("smnNatural")]
        BoundingBox SmnNatural { get; set; }

        [JsonProperty("smnSharp")]
        BoundingBox SmnSharp { get; set; }

        [JsonProperty("smnSharpDown")]
        BoundingBox SmnSharpDown { get; set; }

        [JsonProperty("smnSharpWhite")]
        BoundingBox SmnSharpWhite { get; set; }

        [JsonProperty("smnSharpWhiteDown")]
        BoundingBox SmnSharpWhiteDown { get; set; }

        [JsonProperty("splitBarDivider")]
        BoundingBox SplitBarDivider { get; set; }

        [JsonProperty("staff1Line")]
        BoundingBox Staff1Line { get; set; }

        [JsonProperty("staff1LineNarrow")]
        BoundingBox Staff1LineNarrow { get; set; }

        [JsonProperty("staff1LineWide")]
        BoundingBox Staff1LineWide { get; set; }

        [JsonProperty("staff2Lines")]
        BoundingBox Staff2Lines { get; set; }

        [JsonProperty("staff2LinesNarrow")]
        BoundingBox Staff2LinesNarrow { get; set; }

        [JsonProperty("staff2LinesWide")]
        BoundingBox Staff2LinesWide { get; set; }

        [JsonProperty("staff3Lines")]
        BoundingBox Staff3Lines { get; set; }

        [JsonProperty("staff3LinesNarrow")]
        BoundingBox Staff3LinesNarrow { get; set; }

        [JsonProperty("staff3LinesWide")]
        BoundingBox Staff3LinesWide { get; set; }

        [JsonProperty("staff4Lines")]
        BoundingBox Staff4Lines { get; set; }

        [JsonProperty("staff4LinesNarrow")]
        BoundingBox Staff4LinesNarrow { get; set; }

        [JsonProperty("staff4LinesWide")]
        BoundingBox Staff4LinesWide { get; set; }

        [JsonProperty("staff5Lines")]
        BoundingBox Staff5Lines { get; set; }

        [JsonProperty("staff5LinesNarrow")]
        BoundingBox Staff5LinesNarrow { get; set; }

        [JsonProperty("staff5LinesWide")]
        BoundingBox Staff5LinesWide { get; set; }

        [JsonProperty("staff6Lines")]
        BoundingBox Staff6Lines { get; set; }

        [JsonProperty("staff6LinesNarrow")]
        BoundingBox Staff6LinesNarrow { get; set; }

        [JsonProperty("staff6LinesWide")]
        BoundingBox Staff6LinesWide { get; set; }

        [JsonProperty("staffDivideArrowDown")]
        BoundingBox StaffDivideArrowDown { get; set; }

        [JsonProperty("staffDivideArrowUp")]
        BoundingBox StaffDivideArrowUp { get; set; }

        [JsonProperty("staffDivideArrowUpDown")]
        BoundingBox StaffDivideArrowUpDown { get; set; }

        [JsonProperty("stem")]
        BoundingBox Stem { get; set; }

        [JsonProperty("stemBowOnBridge")]
        BoundingBox StemBowOnBridge { get; set; }

        [JsonProperty("stemBowOnTailpiece")]
        BoundingBox StemBowOnTailpiece { get; set; }

        [JsonProperty("stemBuzzRoll")]
        BoundingBox StemBuzzRoll { get; set; }

        [JsonProperty("stemDamp")]
        BoundingBox StemDamp { get; set; }

        [JsonProperty("stemHarpStringNoise")]
        BoundingBox StemHarpStringNoise { get; set; }

        [JsonProperty("stemMultiphonicsBlack")]
        BoundingBox StemMultiphonicsBlack { get; set; }

        [JsonProperty("stemMultiphonicsBlackWhite")]
        BoundingBox StemMultiphonicsBlackWhite { get; set; }

        [JsonProperty("stemMultiphonicsWhite")]
        BoundingBox StemMultiphonicsWhite { get; set; }

        [JsonProperty("stemPendereckiTremolo")]
        BoundingBox StemPendereckiTremolo { get; set; }

        [JsonProperty("stemRimShot")]
        BoundingBox StemRimShot { get; set; }

        [JsonProperty("stemSprechgesang")]
        BoundingBox StemSprechgesang { get; set; }

        [JsonProperty("stemSulPonticello")]
        BoundingBox StemSulPonticello { get; set; }

        [JsonProperty("stemSussurando")]
        BoundingBox StemSussurando { get; set; }

        [JsonProperty("stemSwished")]
        BoundingBox StemSwished { get; set; }

        [JsonProperty("stemVibratoPulse")]
        BoundingBox StemVibratoPulse { get; set; }

        [JsonProperty("stockhausenTremolo")]
        BoundingBox StockhausenTremolo { get; set; }

        [JsonProperty("stringsBowBehindBridge")]
        BoundingBox StringsBowBehindBridge { get; set; }

        [JsonProperty("stringsBowBehindBridgeFourStrings")]
        BoundingBox StringsBowBehindBridgeFourStrings { get; set; }

        [JsonProperty("stringsBowBehindBridgeOneString")]
        BoundingBox StringsBowBehindBridgeOneString { get; set; }

        [JsonProperty("stringsBowBehindBridgeThreeStrings")]
        BoundingBox StringsBowBehindBridgeThreeStrings { get; set; }

        [JsonProperty("stringsBowBehindBridgeTwoStrings")]
        BoundingBox StringsBowBehindBridgeTwoStrings { get; set; }

        [JsonProperty("stringsBowOnBridge")]
        BoundingBox StringsBowOnBridge { get; set; }

        [JsonProperty("stringsBowOnTailpiece")]
        BoundingBox StringsBowOnTailpiece { get; set; }

        [JsonProperty("stringsChangeBowDirection")]
        BoundingBox StringsChangeBowDirection { get; set; }

        [JsonProperty("stringsChangeBowDirectionImposed")]
        BoundingBox StringsChangeBowDirectionImposed { get; set; }

        [JsonProperty("stringsChangeBowDirectionLiga")]
        BoundingBox StringsChangeBowDirectionLiga { get; set; }

        [JsonProperty("stringsDownBow")]
        BoundingBox StringsDownBow { get; set; }

        [JsonProperty("stringsDownBowTurned")]
        BoundingBox StringsDownBowTurned { get; set; }

        [JsonProperty("stringsFouette")]
        BoundingBox StringsFouette { get; set; }

        [JsonProperty("stringsHalfHarmonic")]
        BoundingBox StringsHalfHarmonic { get; set; }

        [JsonProperty("stringsHarmonic")]
        BoundingBox StringsHarmonic { get; set; }

        [JsonProperty("stringsJeteAbove")]
        BoundingBox StringsJeteAbove { get; set; }

        [JsonProperty("stringsJeteBelow")]
        BoundingBox StringsJeteBelow { get; set; }

        [JsonProperty("stringsMuteOff")]
        BoundingBox StringsMuteOff { get; set; }

        [JsonProperty("stringsMuteOn")]
        BoundingBox StringsMuteOn { get; set; }

        [JsonProperty("stringsOverpressureDownBow")]
        BoundingBox StringsOverpressureDownBow { get; set; }

        [JsonProperty("stringsOverpressureNoDirection")]
        BoundingBox StringsOverpressureNoDirection { get; set; }

        [JsonProperty("stringsOverpressurePossibileDownBow")]
        BoundingBox StringsOverpressurePossibileDownBow { get; set; }

        [JsonProperty("stringsOverpressurePossibileUpBow")]
        BoundingBox StringsOverpressurePossibileUpBow { get; set; }

        [JsonProperty("stringsOverpressureUpBow")]
        BoundingBox StringsOverpressureUpBow { get; set; }

        [JsonProperty("stringsThumbPosition")]
        BoundingBox StringsThumbPosition { get; set; }

        [JsonProperty("stringsThumbPositionTurned")]
        BoundingBox StringsThumbPositionTurned { get; set; }

        [JsonProperty("stringsUpBow")]
        BoundingBox StringsUpBow { get; set; }

        [JsonProperty("stringsUpBowTurned")]
        BoundingBox StringsUpBowTurned { get; set; }

        [JsonProperty("stringsVibratoPulse")]
        BoundingBox StringsVibratoPulse { get; set; }

        [JsonProperty("systemDivider")]
        BoundingBox SystemDivider { get; set; }

        [JsonProperty("systemDividerExtraLong")]
        BoundingBox SystemDividerExtraLong { get; set; }

        [JsonProperty("systemDividerLong")]
        BoundingBox SystemDividerLong { get; set; }

        [JsonProperty("textAugmentationDot")]
        BoundingBox TextAugmentationDot { get; set; }

        [JsonProperty("textBlackNoteFrac16thLongStem")]
        BoundingBox TextBlackNoteFrac16ThLongStem { get; set; }

        [JsonProperty("textBlackNoteFrac16thShortStem")]
        BoundingBox TextBlackNoteFrac16ThShortStem { get; set; }

        [JsonProperty("textBlackNoteFrac32ndLongStem")]
        BoundingBox TextBlackNoteFrac32NdLongStem { get; set; }

        [JsonProperty("textBlackNoteFrac8thLongStem")]
        BoundingBox TextBlackNoteFrac8ThLongStem { get; set; }

        [JsonProperty("textBlackNoteFrac8thShortStem")]
        BoundingBox TextBlackNoteFrac8ThShortStem { get; set; }

        [JsonProperty("textBlackNoteLongStem")]
        BoundingBox TextBlackNoteLongStem { get; set; }

        [JsonProperty("textBlackNoteShortStem")]
        BoundingBox TextBlackNoteShortStem { get; set; }

        [JsonProperty("textCont16thBeamLongStem")]
        BoundingBox TextCont16ThBeamLongStem { get; set; }

        [JsonProperty("textCont16thBeamShortStem")]
        BoundingBox TextCont16ThBeamShortStem { get; set; }

        [JsonProperty("textCont32ndBeamLongStem")]
        BoundingBox TextCont32NdBeamLongStem { get; set; }

        [JsonProperty("textCont8thBeamLongStem")]
        BoundingBox TextCont8ThBeamLongStem { get; set; }

        [JsonProperty("textCont8thBeamShortStem")]
        BoundingBox TextCont8ThBeamShortStem { get; set; }

        [JsonProperty("textTie")]
        BoundingBox TextTie { get; set; }

        [JsonProperty("textTuplet3LongStem")]
        BoundingBox TextTuplet3LongStem { get; set; }

        [JsonProperty("textTuplet3ShortStem")]
        BoundingBox TextTuplet3ShortStem { get; set; }

        [JsonProperty("textTupletBracketEndLongStem")]
        BoundingBox TextTupletBracketEndLongStem { get; set; }

        [JsonProperty("textTupletBracketEndShortStem")]
        BoundingBox TextTupletBracketEndShortStem { get; set; }

        [JsonProperty("textTupletBracketStartLongStem")]
        BoundingBox TextTupletBracketStartLongStem { get; set; }

        [JsonProperty("textTupletBracketStartShortStem")]
        BoundingBox TextTupletBracketStartShortStem { get; set; }

        [JsonProperty("timeSig0")]
        BoundingBox TimeSig0 { get; set; }

        [JsonProperty("timeSig0Denominator")]
        BoundingBox TimeSig0Denominator { get; set; }

        [JsonProperty("timeSig0Large")]
        BoundingBox TimeSig0Large { get; set; }

        [JsonProperty("timeSig0Numerator")]
        BoundingBox TimeSig0Numerator { get; set; }

        [JsonProperty("timeSig0Reversed")]
        BoundingBox TimeSig0Reversed { get; set; }

        [JsonProperty("timeSig0Small")]
        BoundingBox TimeSig0Small { get; set; }

        [JsonProperty("timeSig0Turned")]
        BoundingBox TimeSig0Turned { get; set; }

        [JsonProperty("timeSig1")]
        BoundingBox TimeSig1 { get; set; }

        [JsonProperty("timeSig12over8")]
        BoundingBox TimeSig12Over8 { get; set; }

        [JsonProperty("timeSig1Denominator")]
        BoundingBox TimeSig1Denominator { get; set; }

        [JsonProperty("timeSig1Large")]
        BoundingBox TimeSig1Large { get; set; }

        [JsonProperty("timeSig1Numerator")]
        BoundingBox TimeSig1Numerator { get; set; }

        [JsonProperty("timeSig1Reversed")]
        BoundingBox TimeSig1Reversed { get; set; }

        [JsonProperty("timeSig1Small")]
        BoundingBox TimeSig1Small { get; set; }

        [JsonProperty("timeSig1Turned")]
        BoundingBox TimeSig1Turned { get; set; }

        [JsonProperty("timeSig2")]
        BoundingBox TimeSig2 { get; set; }

        [JsonProperty("timeSig2Denominator")]
        BoundingBox TimeSig2Denominator { get; set; }

        [JsonProperty("timeSig2Large")]
        BoundingBox TimeSig2Large { get; set; }

        [JsonProperty("timeSig2Numerator")]
        BoundingBox TimeSig2Numerator { get; set; }

        [JsonProperty("timeSig2Reversed")]
        BoundingBox TimeSig2Reversed { get; set; }

        [JsonProperty("timeSig2Small")]
        BoundingBox TimeSig2Small { get; set; }

        [JsonProperty("timeSig2Turned")]
        BoundingBox TimeSig2Turned { get; set; }

        [JsonProperty("timeSig2over2")]
        BoundingBox TimeSig2Over2 { get; set; }

        [JsonProperty("timeSig2over4")]
        BoundingBox TimeSig2Over4 { get; set; }

        [JsonProperty("timeSig3")]
        BoundingBox TimeSig3 { get; set; }

        [JsonProperty("timeSig3Denominator")]
        BoundingBox TimeSig3Denominator { get; set; }

        [JsonProperty("timeSig3Large")]
        BoundingBox TimeSig3Large { get; set; }

        [JsonProperty("timeSig3Numerator")]
        BoundingBox TimeSig3Numerator { get; set; }

        [JsonProperty("timeSig3Reversed")]
        BoundingBox TimeSig3Reversed { get; set; }

        [JsonProperty("timeSig3Small")]
        BoundingBox TimeSig3Small { get; set; }

        [JsonProperty("timeSig3Turned")]
        BoundingBox TimeSig3Turned { get; set; }

        [JsonProperty("timeSig3over2")]
        BoundingBox TimeSig3Over2 { get; set; }

        [JsonProperty("timeSig3over4")]
        BoundingBox TimeSig3Over4 { get; set; }

        [JsonProperty("timeSig3over8")]
        BoundingBox TimeSig3Over8 { get; set; }

        [JsonProperty("timeSig4")]
        BoundingBox TimeSig4 { get; set; }

        [JsonProperty("timeSig4Denominator")]
        BoundingBox TimeSig4Denominator { get; set; }

        [JsonProperty("timeSig4Large")]
        BoundingBox TimeSig4Large { get; set; }

        [JsonProperty("timeSig4Numerator")]
        BoundingBox TimeSig4Numerator { get; set; }

        [JsonProperty("timeSig4Reversed")]
        BoundingBox TimeSig4Reversed { get; set; }

        [JsonProperty("timeSig4Small")]
        BoundingBox TimeSig4Small { get; set; }

        [JsonProperty("timeSig4Turned")]
        BoundingBox TimeSig4Turned { get; set; }

        [JsonProperty("timeSig4over4")]
        BoundingBox TimeSig4Over4 { get; set; }

        [JsonProperty("timeSig5")]
        BoundingBox TimeSig5 { get; set; }

        [JsonProperty("timeSig5Denominator")]
        BoundingBox TimeSig5Denominator { get; set; }

        [JsonProperty("timeSig5Large")]
        BoundingBox TimeSig5Large { get; set; }

        [JsonProperty("timeSig5Numerator")]
        BoundingBox TimeSig5Numerator { get; set; }

        [JsonProperty("timeSig5Reversed")]
        BoundingBox TimeSig5Reversed { get; set; }

        [JsonProperty("timeSig5Small")]
        BoundingBox TimeSig5Small { get; set; }

        [JsonProperty("timeSig5Turned")]
        BoundingBox TimeSig5Turned { get; set; }

        [JsonProperty("timeSig5over4")]
        BoundingBox TimeSig5Over4 { get; set; }

        [JsonProperty("timeSig5over8")]
        BoundingBox TimeSig5Over8 { get; set; }

        [JsonProperty("timeSig6")]
        BoundingBox TimeSig6 { get; set; }

        [JsonProperty("timeSig6Denominator")]
        BoundingBox TimeSig6Denominator { get; set; }

        [JsonProperty("timeSig6Large")]
        BoundingBox TimeSig6Large { get; set; }

        [JsonProperty("timeSig6Numerator")]
        BoundingBox TimeSig6Numerator { get; set; }

        [JsonProperty("timeSig6Reversed")]
        BoundingBox TimeSig6Reversed { get; set; }

        [JsonProperty("timeSig6Small")]
        BoundingBox TimeSig6Small { get; set; }

        [JsonProperty("timeSig6Turned")]
        BoundingBox TimeSig6Turned { get; set; }

        [JsonProperty("timeSig6over4")]
        BoundingBox TimeSig6Over4 { get; set; }

        [JsonProperty("timeSig6over8")]
        BoundingBox TimeSig6Over8 { get; set; }

        [JsonProperty("timeSig7")]
        BoundingBox TimeSig7 { get; set; }

        [JsonProperty("timeSig7Denominator")]
        BoundingBox TimeSig7Denominator { get; set; }

        [JsonProperty("timeSig7Large")]
        BoundingBox TimeSig7Large { get; set; }

        [JsonProperty("timeSig7Numerator")]
        BoundingBox TimeSig7Numerator { get; set; }

        [JsonProperty("timeSig7Reversed")]
        BoundingBox TimeSig7Reversed { get; set; }

        [JsonProperty("timeSig7Small")]
        BoundingBox TimeSig7Small { get; set; }

        [JsonProperty("timeSig7Turned")]
        BoundingBox TimeSig7Turned { get; set; }

        [JsonProperty("timeSig7over8")]
        BoundingBox TimeSig7Over8 { get; set; }

        [JsonProperty("timeSig8")]
        BoundingBox TimeSig8 { get; set; }

        [JsonProperty("timeSig8Denominator")]
        BoundingBox TimeSig8Denominator { get; set; }

        [JsonProperty("timeSig8Large")]
        BoundingBox TimeSig8Large { get; set; }

        [JsonProperty("timeSig8Numerator")]
        BoundingBox TimeSig8Numerator { get; set; }

        [JsonProperty("timeSig8Reversed")]
        BoundingBox TimeSig8Reversed { get; set; }

        [JsonProperty("timeSig8Small")]
        BoundingBox TimeSig8Small { get; set; }

        [JsonProperty("timeSig8Turned")]
        BoundingBox TimeSig8Turned { get; set; }

        [JsonProperty("timeSig9")]
        BoundingBox TimeSig9 { get; set; }

        [JsonProperty("timeSig9Large")]
        BoundingBox TimeSig9Large { get; set; }

        [JsonProperty("timeSig9Reversed")]
        BoundingBox TimeSig9Reversed { get; set; }

        [JsonProperty("timeSig9Small")]
        BoundingBox TimeSig9Small { get; set; }

        [JsonProperty("timeSig9Turned")]
        BoundingBox TimeSig9Turned { get; set; }

        [JsonProperty("timeSig9over8")]
        BoundingBox TimeSig9Over8 { get; set; }

        [JsonProperty("timeSigBracketLeft")]
        BoundingBox TimeSigBracketLeft { get; set; }

        [JsonProperty("timeSigBracketLeftSmall")]
        BoundingBox TimeSigBracketLeftSmall { get; set; }

        [JsonProperty("timeSigBracketRight")]
        BoundingBox TimeSigBracketRight { get; set; }

        [JsonProperty("timeSigBracketRightSmall")]
        BoundingBox TimeSigBracketRightSmall { get; set; }

        [JsonProperty("timeSigComma")]
        BoundingBox TimeSigComma { get; set; }

        [JsonProperty("timeSigCommon")]
        BoundingBox TimeSigCommon { get; set; }

        [JsonProperty("timeSigCommonLarge")]
        BoundingBox TimeSigCommonLarge { get; set; }

        [JsonProperty("timeSigCommonReversed")]
        BoundingBox TimeSigCommonReversed { get; set; }

        [JsonProperty("timeSigCommonTurned")]
        BoundingBox TimeSigCommonTurned { get; set; }

        [JsonProperty("timeSigCut2")]
        BoundingBox TimeSigCut2 { get; set; }

        [JsonProperty("timeSigCut3")]
        BoundingBox TimeSigCut3 { get; set; }

        [JsonProperty("timeSigCutCommon")]
        BoundingBox TimeSigCutCommon { get; set; }

        [JsonProperty("timeSigCutCommonLarge")]
        BoundingBox TimeSigCutCommonLarge { get; set; }

        [JsonProperty("timeSigCutCommonReversed")]
        BoundingBox TimeSigCutCommonReversed { get; set; }

        [JsonProperty("timeSigCutCommonTurned")]
        BoundingBox TimeSigCutCommonTurned { get; set; }

        [JsonProperty("timeSigEquals")]
        BoundingBox TimeSigEquals { get; set; }

        [JsonProperty("timeSigFractionHalf")]
        BoundingBox TimeSigFractionHalf { get; set; }

        [JsonProperty("timeSigFractionOneThird")]
        BoundingBox TimeSigFractionOneThird { get; set; }

        [JsonProperty("timeSigFractionQuarter")]
        BoundingBox TimeSigFractionQuarter { get; set; }

        [JsonProperty("timeSigFractionThreeQuarters")]
        BoundingBox TimeSigFractionThreeQuarters { get; set; }

        [JsonProperty("timeSigFractionTwoThirds")]
        BoundingBox TimeSigFractionTwoThirds { get; set; }

        [JsonProperty("timeSigFractionalSlash")]
        BoundingBox TimeSigFractionalSlash { get; set; }

        [JsonProperty("timeSigMinus")]
        BoundingBox TimeSigMinus { get; set; }

        [JsonProperty("timeSigMultiply")]
        BoundingBox TimeSigMultiply { get; set; }

        [JsonProperty("timeSigOpenPenderecki")]
        BoundingBox TimeSigOpenPenderecki { get; set; }

        [JsonProperty("timeSigParensLeft")]
        BoundingBox TimeSigParensLeft { get; set; }

        [JsonProperty("timeSigParensLeftSmall")]
        BoundingBox TimeSigParensLeftSmall { get; set; }

        [JsonProperty("timeSigParensRight")]
        BoundingBox TimeSigParensRight { get; set; }

        [JsonProperty("timeSigParensRightSmall")]
        BoundingBox TimeSigParensRightSmall { get; set; }

        [JsonProperty("timeSigPlus")]
        BoundingBox TimeSigPlus { get; set; }

        [JsonProperty("timeSigPlusLarge")]
        BoundingBox TimeSigPlusLarge { get; set; }

        [JsonProperty("timeSigPlusSmall")]
        BoundingBox TimeSigPlusSmall { get; set; }

        [JsonProperty("timeSigSlash")]
        BoundingBox TimeSigSlash { get; set; }

        [JsonProperty("timeSigX")]
        BoundingBox TimeSigX { get; set; }

        [JsonProperty("tremolo1")]
        BoundingBox Tremolo1 { get; set; }

        [JsonProperty("tremolo2")]
        BoundingBox Tremolo2 { get; set; }

        [JsonProperty("tremolo3")]
        BoundingBox Tremolo3 { get; set; }

        [JsonProperty("tremolo4")]
        BoundingBox Tremolo4 { get; set; }

        [JsonProperty("tremolo5")]
        BoundingBox Tremolo5 { get; set; }

        [JsonProperty("tremoloDivisiDots2")]
        BoundingBox TremoloDivisiDots2 { get; set; }

        [JsonProperty("tremoloDivisiDots3")]
        BoundingBox TremoloDivisiDots3 { get; set; }

        [JsonProperty("tremoloDivisiDots4")]
        BoundingBox TremoloDivisiDots4 { get; set; }

        [JsonProperty("tremoloDivisiDots6")]
        BoundingBox TremoloDivisiDots6 { get; set; }

        [JsonProperty("tremoloFingered1")]
        BoundingBox TremoloFingered1 { get; set; }

        [JsonProperty("tremoloFingered2")]
        BoundingBox TremoloFingered2 { get; set; }

        [JsonProperty("tremoloFingered3")]
        BoundingBox TremoloFingered3 { get; set; }

        [JsonProperty("tremoloFingered4")]
        BoundingBox TremoloFingered4 { get; set; }

        [JsonProperty("tremoloFingered5")]
        BoundingBox TremoloFingered5 { get; set; }

        [JsonProperty("tripleTongueAbove")]
        BoundingBox TripleTongueAbove { get; set; }

        [JsonProperty("tripleTongueAboveNoSlur")]
        BoundingBox TripleTongueAboveNoSlur { get; set; }

        [JsonProperty("tripleTongueBelow")]
        BoundingBox TripleTongueBelow { get; set; }

        [JsonProperty("tripleTongueBelowNoSlur")]
        BoundingBox TripleTongueBelowNoSlur { get; set; }

        [JsonProperty("tuplet0")]
        BoundingBox Tuplet0 { get; set; }

        [JsonProperty("tuplet1")]
        BoundingBox Tuplet1 { get; set; }

        [JsonProperty("tuplet2")]
        BoundingBox Tuplet2 { get; set; }

        [JsonProperty("tuplet3")]
        BoundingBox Tuplet3 { get; set; }

        [JsonProperty("tuplet4")]
        BoundingBox Tuplet4 { get; set; }

        [JsonProperty("tuplet5")]
        BoundingBox Tuplet5 { get; set; }

        [JsonProperty("tuplet6")]
        BoundingBox Tuplet6 { get; set; }

        [JsonProperty("tuplet7")]
        BoundingBox Tuplet7 { get; set; }

        [JsonProperty("tuplet8")]
        BoundingBox Tuplet8 { get; set; }

        [JsonProperty("tuplet9")]
        BoundingBox Tuplet9 { get; set; }

        [JsonProperty("tupletColon")]
        BoundingBox TupletColon { get; set; }

        [JsonProperty("unmeasuredTremolo")]
        BoundingBox UnmeasuredTremolo { get; set; }

        [JsonProperty("unmeasuredTremoloSimple")]
        BoundingBox UnmeasuredTremoloSimple { get; set; }

        [JsonProperty("unpitchedPercussionClef1")]
        BoundingBox UnpitchedPercussionClef1 { get; set; }

        [JsonProperty("unpitchedPercussionClef1Alt")]
        BoundingBox UnpitchedPercussionClef1Alt { get; set; }

        [JsonProperty("unpitchedPercussionClef2")]
        BoundingBox UnpitchedPercussionClef2 { get; set; }

        [JsonProperty("ventiduesima")]
        BoundingBox Ventiduesima { get; set; }

        [JsonProperty("ventiduesimaAlta")]
        BoundingBox VentiduesimaAlta { get; set; }

        [JsonProperty("ventiduesimaBassa")]
        BoundingBox VentiduesimaBassa { get; set; }

        [JsonProperty("ventiduesimaBassaMb")]
        BoundingBox VentiduesimaBassaMb { get; set; }

        [JsonProperty("ventiquattresima")]
        BoundingBox Ventiquattresima { get; set; }

        [JsonProperty("ventiquattresimaAlta")]
        BoundingBox VentiquattresimaAlta { get; set; }

        [JsonProperty("ventiquattresimaBassa")]
        BoundingBox VentiquattresimaBassa { get; set; }

        [JsonProperty("ventiquattresimaBassaMb")]
        BoundingBox VentiquattresimaBassaMb { get; set; }

        [JsonProperty("vocalFingerClickStockhausen")]
        BoundingBox VocalFingerClickStockhausen { get; set; }

        [JsonProperty("vocalMouthClosed")]
        BoundingBox VocalMouthClosed { get; set; }

        [JsonProperty("vocalMouthOpen")]
        BoundingBox VocalMouthOpen { get; set; }

        [JsonProperty("vocalMouthPursed")]
        BoundingBox VocalMouthPursed { get; set; }

        [JsonProperty("vocalMouthSlightlyOpen")]
        BoundingBox VocalMouthSlightlyOpen { get; set; }

        [JsonProperty("vocalMouthWideOpen")]
        BoundingBox VocalMouthWideOpen { get; set; }

        [JsonProperty("vocalNasalVoice")]
        BoundingBox VocalNasalVoice { get; set; }

        [JsonProperty("vocalSprechgesang")]
        BoundingBox VocalSprechgesang { get; set; }

        [JsonProperty("vocalTongueClickStockhausen")]
        BoundingBox VocalTongueClickStockhausen { get; set; }

        [JsonProperty("vocalTongueFingerClickStockhausen")]
        BoundingBox VocalTongueFingerClickStockhausen { get; set; }

        [JsonProperty("vocalsSussurando")]
        BoundingBox VocalsSussurando { get; set; }

        [JsonProperty("wiggleArpeggiatoDown")]
        BoundingBox WiggleArpeggiatoDown { get; set; }

        [JsonProperty("wiggleArpeggiatoDownArrow")]
        BoundingBox WiggleArpeggiatoDownArrow { get; set; }

        [JsonProperty("wiggleArpeggiatoDownSwash")]
        BoundingBox WiggleArpeggiatoDownSwash { get; set; }

        [JsonProperty("wiggleArpeggiatoDownSwashCouperin")]
        BoundingBox WiggleArpeggiatoDownSwashCouperin { get; set; }

        [JsonProperty("wiggleArpeggiatoUp")]
        BoundingBox WiggleArpeggiatoUp { get; set; }

        [JsonProperty("wiggleArpeggiatoUpArrow")]
        BoundingBox WiggleArpeggiatoUpArrow { get; set; }

        [JsonProperty("wiggleArpeggiatoUpSwash")]
        BoundingBox WiggleArpeggiatoUpSwash { get; set; }

        [JsonProperty("wiggleArpeggiatoUpSwashCouperin")]
        BoundingBox WiggleArpeggiatoUpSwashCouperin { get; set; }

        [JsonProperty("wiggleCircular")]
        BoundingBox WiggleCircular { get; set; }

        [JsonProperty("wiggleCircularConstant")]
        BoundingBox WiggleCircularConstant { get; set; }

        [JsonProperty("wiggleCircularConstantFlipped")]
        BoundingBox WiggleCircularConstantFlipped { get; set; }

        [JsonProperty("wiggleCircularConstantFlippedLarge")]
        BoundingBox WiggleCircularConstantFlippedLarge { get; set; }

        [JsonProperty("wiggleCircularConstantLarge")]
        BoundingBox WiggleCircularConstantLarge { get; set; }

        [JsonProperty("wiggleCircularEnd")]
        BoundingBox WiggleCircularEnd { get; set; }

        [JsonProperty("wiggleCircularLarge")]
        BoundingBox WiggleCircularLarge { get; set; }

        [JsonProperty("wiggleCircularLarger")]
        BoundingBox WiggleCircularLarger { get; set; }

        [JsonProperty("wiggleCircularLargerStill")]
        BoundingBox WiggleCircularLargerStill { get; set; }

        [JsonProperty("wiggleCircularLargest")]
        BoundingBox WiggleCircularLargest { get; set; }

        [JsonProperty("wiggleCircularSmall")]
        BoundingBox WiggleCircularSmall { get; set; }

        [JsonProperty("wiggleCircularStart")]
        BoundingBox WiggleCircularStart { get; set; }

        [JsonProperty("wiggleGlissando")]
        BoundingBox WiggleGlissando { get; set; }

        [JsonProperty("wiggleGlissandoGroup1")]
        BoundingBox WiggleGlissandoGroup1 { get; set; }

        [JsonProperty("wiggleGlissandoGroup2")]
        BoundingBox WiggleGlissandoGroup2 { get; set; }

        [JsonProperty("wiggleGlissandoGroup3")]
        BoundingBox WiggleGlissandoGroup3 { get; set; }

        [JsonProperty("wiggleRandom1")]
        BoundingBox WiggleRandom1 { get; set; }

        [JsonProperty("wiggleRandom2")]
        BoundingBox WiggleRandom2 { get; set; }

        [JsonProperty("wiggleRandom3")]
        BoundingBox WiggleRandom3 { get; set; }

        [JsonProperty("wiggleRandom4")]
        BoundingBox WiggleRandom4 { get; set; }

        [JsonProperty("wiggleSawtooth")]
        BoundingBox WiggleSawtooth { get; set; }

        [JsonProperty("wiggleSawtoothNarrow")]
        BoundingBox WiggleSawtoothNarrow { get; set; }

        [JsonProperty("wiggleSawtoothWide")]
        BoundingBox WiggleSawtoothWide { get; set; }

        [JsonProperty("wiggleSquareWave")]
        BoundingBox WiggleSquareWave { get; set; }

        [JsonProperty("wiggleSquareWaveNarrow")]
        BoundingBox WiggleSquareWaveNarrow { get; set; }

        [JsonProperty("wiggleSquareWaveWide")]
        BoundingBox WiggleSquareWaveWide { get; set; }

        [JsonProperty("wiggleTrill")]
        BoundingBox WiggleTrill { get; set; }

        [JsonProperty("wiggleTrillFast")]
        BoundingBox WiggleTrillFast { get; set; }

        [JsonProperty("wiggleTrillFaster")]
        BoundingBox WiggleTrillFaster { get; set; }

        [JsonProperty("wiggleTrillFasterStill")]
        BoundingBox WiggleTrillFasterStill { get; set; }

        [JsonProperty("wiggleTrillFastest")]
        BoundingBox WiggleTrillFastest { get; set; }

        [JsonProperty("wiggleTrillSlow")]
        BoundingBox WiggleTrillSlow { get; set; }

        [JsonProperty("wiggleTrillSlower")]
        BoundingBox WiggleTrillSlower { get; set; }

        [JsonProperty("wiggleTrillSlowerStill")]
        BoundingBox WiggleTrillSlowerStill { get; set; }

        [JsonProperty("wiggleTrillSlowest")]
        BoundingBox WiggleTrillSlowest { get; set; }

        [JsonProperty("wiggleVIbratoLargestSlower")]
        BoundingBox WiggleVIbratoLargestSlower { get; set; }

        [JsonProperty("wiggleVIbratoMediumSlower")]
        BoundingBox WiggleVIbratoMediumSlower { get; set; }

        [JsonProperty("wiggleVibrato")]
        BoundingBox WiggleVibrato { get; set; }

        [JsonProperty("wiggleVibratoLargeFast")]
        BoundingBox WiggleVibratoLargeFast { get; set; }

        [JsonProperty("wiggleVibratoLargeFaster")]
        BoundingBox WiggleVibratoLargeFaster { get; set; }

        [JsonProperty("wiggleVibratoLargeFasterStill")]
        BoundingBox WiggleVibratoLargeFasterStill { get; set; }

        [JsonProperty("wiggleVibratoLargeFastest")]
        BoundingBox WiggleVibratoLargeFastest { get; set; }

        [JsonProperty("wiggleVibratoLargeSlow")]
        BoundingBox WiggleVibratoLargeSlow { get; set; }

        [JsonProperty("wiggleVibratoLargeSlower")]
        BoundingBox WiggleVibratoLargeSlower { get; set; }

        [JsonProperty("wiggleVibratoLargeSlowest")]
        BoundingBox WiggleVibratoLargeSlowest { get; set; }

        [JsonProperty("wiggleVibratoLargestFast")]
        BoundingBox WiggleVibratoLargestFast { get; set; }

        [JsonProperty("wiggleVibratoLargestFaster")]
        BoundingBox WiggleVibratoLargestFaster { get; set; }

        [JsonProperty("wiggleVibratoLargestFasterStill")]
        BoundingBox WiggleVibratoLargestFasterStill { get; set; }

        [JsonProperty("wiggleVibratoLargestFastest")]
        BoundingBox WiggleVibratoLargestFastest { get; set; }

        [JsonProperty("wiggleVibratoLargestSlow")]
        BoundingBox WiggleVibratoLargestSlow { get; set; }

        [JsonProperty("wiggleVibratoLargestSlowest")]
        BoundingBox WiggleVibratoLargestSlowest { get; set; }

        [JsonProperty("wiggleVibratoMediumFast")]
        BoundingBox WiggleVibratoMediumFast { get; set; }

        [JsonProperty("wiggleVibratoMediumFaster")]
        BoundingBox WiggleVibratoMediumFaster { get; set; }

        [JsonProperty("wiggleVibratoMediumFasterStill")]
        BoundingBox WiggleVibratoMediumFasterStill { get; set; }

        [JsonProperty("wiggleVibratoMediumFastest")]
        BoundingBox WiggleVibratoMediumFastest { get; set; }

        [JsonProperty("wiggleVibratoMediumSlow")]
        BoundingBox WiggleVibratoMediumSlow { get; set; }

        [JsonProperty("wiggleVibratoMediumSlowest")]
        BoundingBox WiggleVibratoMediumSlowest { get; set; }

        [JsonProperty("wiggleVibratoSmallFast")]
        BoundingBox WiggleVibratoSmallFast { get; set; }

        [JsonProperty("wiggleVibratoSmallFaster")]
        BoundingBox WiggleVibratoSmallFaster { get; set; }

        [JsonProperty("wiggleVibratoSmallFasterStill")]
        BoundingBox WiggleVibratoSmallFasterStill { get; set; }

        [JsonProperty("wiggleVibratoSmallFastest")]
        BoundingBox WiggleVibratoSmallFastest { get; set; }

        [JsonProperty("wiggleVibratoSmallSlow")]
        BoundingBox WiggleVibratoSmallSlow { get; set; }

        [JsonProperty("wiggleVibratoSmallSlower")]
        BoundingBox WiggleVibratoSmallSlower { get; set; }

        [JsonProperty("wiggleVibratoSmallSlowest")]
        BoundingBox WiggleVibratoSmallSlowest { get; set; }

        [JsonProperty("wiggleVibratoSmallestFast")]
        BoundingBox WiggleVibratoSmallestFast { get; set; }

        [JsonProperty("wiggleVibratoSmallestFaster")]
        BoundingBox WiggleVibratoSmallestFaster { get; set; }

        [JsonProperty("wiggleVibratoSmallestFasterStill")]
        BoundingBox WiggleVibratoSmallestFasterStill { get; set; }

        [JsonProperty("wiggleVibratoSmallestFastest")]
        BoundingBox WiggleVibratoSmallestFastest { get; set; }

        [JsonProperty("wiggleVibratoSmallestSlow")]
        BoundingBox WiggleVibratoSmallestSlow { get; set; }

        [JsonProperty("wiggleVibratoSmallestSlower")]
        BoundingBox WiggleVibratoSmallestSlower { get; set; }

        [JsonProperty("wiggleVibratoSmallestSlowest")]
        BoundingBox WiggleVibratoSmallestSlowest { get; set; }

        [JsonProperty("wiggleVibratoStart")]
        BoundingBox WiggleVibratoStart { get; set; }

        [JsonProperty("wiggleVibratoWide")]
        BoundingBox WiggleVibratoWide { get; set; }

        [JsonProperty("wiggleWavy")]
        BoundingBox WiggleWavy { get; set; }

        [JsonProperty("wiggleWavyNarrow")]
        BoundingBox WiggleWavyNarrow { get; set; }

        [JsonProperty("wiggleWavyWide")]
        BoundingBox WiggleWavyWide { get; set; }

        [JsonProperty("windClosedHole")]
        BoundingBox WindClosedHole { get; set; }

        [JsonProperty("windFlatEmbouchure")]
        BoundingBox WindFlatEmbouchure { get; set; }

        [JsonProperty("windHalfClosedHole1")]
        BoundingBox WindHalfClosedHole1 { get; set; }

        [JsonProperty("windHalfClosedHole2")]
        BoundingBox WindHalfClosedHole2 { get; set; }

        [JsonProperty("windHalfClosedHole3")]
        BoundingBox WindHalfClosedHole3 { get; set; }

        [JsonProperty("windLessRelaxedEmbouchure")]
        BoundingBox WindLessRelaxedEmbouchure { get; set; }

        [JsonProperty("windLessTightEmbouchure")]
        BoundingBox WindLessTightEmbouchure { get; set; }

        [JsonProperty("windMouthpiecePop")]
        BoundingBox WindMouthpiecePop { get; set; }

        [JsonProperty("windMultiphonicsBlackStem")]
        BoundingBox WindMultiphonicsBlackStem { get; set; }

        [JsonProperty("windMultiphonicsBlackWhiteStem")]
        BoundingBox WindMultiphonicsBlackWhiteStem { get; set; }

        [JsonProperty("windMultiphonicsWhiteStem")]
        BoundingBox WindMultiphonicsWhiteStem { get; set; }

        [JsonProperty("windOpenHole")]
        BoundingBox WindOpenHole { get; set; }

        [JsonProperty("windReedPositionIn")]
        BoundingBox WindReedPositionIn { get; set; }

        [JsonProperty("windReedPositionNormal")]
        BoundingBox WindReedPositionNormal { get; set; }

        [JsonProperty("windReedPositionOut")]
        BoundingBox WindReedPositionOut { get; set; }

        [JsonProperty("windRelaxedEmbouchure")]
        BoundingBox WindRelaxedEmbouchure { get; set; }

        [JsonProperty("windRimOnly")]
        BoundingBox WindRimOnly { get; set; }

        [JsonProperty("windSharpEmbouchure")]
        BoundingBox WindSharpEmbouchure { get; set; }

        [JsonProperty("windStrongAirPressure")]
        BoundingBox WindStrongAirPressure { get; set; }

        [JsonProperty("windThreeQuartersClosedHole")]
        BoundingBox WindThreeQuartersClosedHole { get; set; }

        [JsonProperty("windTightEmbouchure")]
        BoundingBox WindTightEmbouchure { get; set; }

        [JsonProperty("windTrillKey")]
        BoundingBox WindTrillKey { get; set; }

        [JsonProperty("windVeryTightEmbouchure")]
        BoundingBox WindVeryTightEmbouchure { get; set; }

        [JsonProperty("windWeakAirPressure")]
        BoundingBox WindWeakAirPressure { get; set; }
    }
}
