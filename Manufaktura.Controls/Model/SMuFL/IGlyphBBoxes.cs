using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Manufaktura.Controls.Model.SMuFL
{
    public interface IGlyphBBoxes
    {
        [DataMember(Name="4stringTabClef")]
        BoundingBox The4StringTabClef { get; set; }

        [DataMember(Name="4stringTabClefSerif")]
        BoundingBox The4StringTabClefSerif { get; set; }

        [DataMember(Name="4stringTabClefTall")]
        BoundingBox The4StringTabClefTall { get; set; }

        [DataMember(Name="6stringTabClef")]
        BoundingBox The6StringTabClef { get; set; }

        [DataMember(Name="6stringTabClefSerif")]
        BoundingBox The6StringTabClefSerif { get; set; }

        [DataMember(Name="6stringTabClefTall")]
        BoundingBox The6StringTabClefTall { get; set; }

        [DataMember(Name="accSagittal11LargeDiesisDown")]
        BoundingBox AccSagittal11LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal11LargeDiesisUp")]
        BoundingBox AccSagittal11LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal11MediumDiesisDown")]
        BoundingBox AccSagittal11MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal11MediumDiesisUp")]
        BoundingBox AccSagittal11MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal11v19LargeDiesisDown")]
        BoundingBox AccSagittal11V19LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal11v19LargeDiesisUp")]
        BoundingBox AccSagittal11V19LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal11v19MediumDiesisDown")]
        BoundingBox AccSagittal11V19MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal11v19MediumDiesisUp")]
        BoundingBox AccSagittal11V19MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal11v49CommaDown")]
        BoundingBox AccSagittal11V49CommaDown { get; set; }

        [DataMember(Name="accSagittal11v49CommaUp")]
        BoundingBox AccSagittal11V49CommaUp { get; set; }

        [DataMember(Name="accSagittal143CommaDown")]
        BoundingBox AccSagittal143CommaDown { get; set; }

        [DataMember(Name="accSagittal143CommaUp")]
        BoundingBox AccSagittal143CommaUp { get; set; }

        [DataMember(Name="accSagittal17CommaDown")]
        BoundingBox AccSagittal17CommaDown { get; set; }

        [DataMember(Name="accSagittal17CommaUp")]
        BoundingBox AccSagittal17CommaUp { get; set; }

        [DataMember(Name="accSagittal17KleismaDown")]
        BoundingBox AccSagittal17KleismaDown { get; set; }

        [DataMember(Name="accSagittal17KleismaUp")]
        BoundingBox AccSagittal17KleismaUp { get; set; }

        [DataMember(Name="accSagittal19CommaDown")]
        BoundingBox AccSagittal19CommaDown { get; set; }

        [DataMember(Name="accSagittal19CommaUp")]
        BoundingBox AccSagittal19CommaUp { get; set; }

        [DataMember(Name="accSagittal19SchismaDown")]
        BoundingBox AccSagittal19SchismaDown { get; set; }

        [DataMember(Name="accSagittal19SchismaUp")]
        BoundingBox AccSagittal19SchismaUp { get; set; }

        [DataMember(Name="accSagittal23CommaDown")]
        BoundingBox AccSagittal23CommaDown { get; set; }

        [DataMember(Name="accSagittal23CommaUp")]
        BoundingBox AccSagittal23CommaUp { get; set; }

        [DataMember(Name="accSagittal23SmallDiesisDown")]
        BoundingBox AccSagittal23SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal23SmallDiesisUp")]
        BoundingBox AccSagittal23SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal25SmallDiesisDown")]
        BoundingBox AccSagittal25SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal25SmallDiesisUp")]
        BoundingBox AccSagittal25SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal35LargeDiesisDown")]
        BoundingBox AccSagittal35LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal35LargeDiesisUp")]
        BoundingBox AccSagittal35LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal35MediumDiesisDown")]
        BoundingBox AccSagittal35MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal35MediumDiesisUp")]
        BoundingBox AccSagittal35MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal49LargeDiesisDown")]
        BoundingBox AccSagittal49LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal49LargeDiesisUp")]
        BoundingBox AccSagittal49LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal49MediumDiesisDown")]
        BoundingBox AccSagittal49MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal49MediumDiesisUp")]
        BoundingBox AccSagittal49MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal49SmallDiesisDown")]
        BoundingBox AccSagittal49SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal49SmallDiesisUp")]
        BoundingBox AccSagittal49SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal55CommaDown")]
        BoundingBox AccSagittal55CommaDown { get; set; }

        [DataMember(Name="accSagittal55CommaUp")]
        BoundingBox AccSagittal55CommaUp { get; set; }

        [DataMember(Name="accSagittal5CommaDown")]
        BoundingBox AccSagittal5CommaDown { get; set; }

        [DataMember(Name="accSagittal5CommaUp")]
        BoundingBox AccSagittal5CommaUp { get; set; }

        [DataMember(Name="accSagittal5v11SmallDiesisDown")]
        BoundingBox AccSagittal5V11SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v11SmallDiesisUp")]
        BoundingBox AccSagittal5V11SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v13LargeDiesisDown")]
        BoundingBox AccSagittal5V13LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v13LargeDiesisUp")]
        BoundingBox AccSagittal5V13LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v13MediumDiesisDown")]
        BoundingBox AccSagittal5V13MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v13MediumDiesisUp")]
        BoundingBox AccSagittal5V13MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v19CommaDown")]
        BoundingBox AccSagittal5V19CommaDown { get; set; }

        [DataMember(Name="accSagittal5v19CommaUp")]
        BoundingBox AccSagittal5V19CommaUp { get; set; }

        [DataMember(Name="accSagittal5v23SmallDiesisDown")]
        BoundingBox AccSagittal5V23SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v23SmallDiesisUp")]
        BoundingBox AccSagittal5V23SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v49MediumDiesisDown")]
        BoundingBox AccSagittal5V49MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v49MediumDiesisUp")]
        BoundingBox AccSagittal5V49MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v7KleismaDown")]
        BoundingBox AccSagittal5V7KleismaDown { get; set; }

        [DataMember(Name="accSagittal5v7KleismaUp")]
        BoundingBox AccSagittal5V7KleismaUp { get; set; }

        [DataMember(Name="accSagittal7CommaDown")]
        BoundingBox AccSagittal7CommaDown { get; set; }

        [DataMember(Name="accSagittal7CommaUp")]
        BoundingBox AccSagittal7CommaUp { get; set; }

        [DataMember(Name="accSagittal7v11CommaDown")]
        BoundingBox AccSagittal7V11CommaDown { get; set; }

        [DataMember(Name="accSagittal7v11CommaUp")]
        BoundingBox AccSagittal7V11CommaUp { get; set; }

        [DataMember(Name="accSagittal7v11KleismaDown")]
        BoundingBox AccSagittal7V11KleismaDown { get; set; }

        [DataMember(Name="accSagittal7v11KleismaUp")]
        BoundingBox AccSagittal7V11KleismaUp { get; set; }

        [DataMember(Name="accSagittal7v19CommaDown")]
        BoundingBox AccSagittal7V19CommaDown { get; set; }

        [DataMember(Name="accSagittal7v19CommaUp")]
        BoundingBox AccSagittal7V19CommaUp { get; set; }

        [DataMember(Name="accSagittalAcute")]
        BoundingBox AccSagittalAcute { get; set; }

        [DataMember(Name="accSagittalDoubleFlat")]
        BoundingBox AccSagittalDoubleFlat { get; set; }

        [DataMember(Name="accSagittalDoubleFlat11v49CUp")]
        BoundingBox AccSagittalDoubleFlat11V49CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat143CUp")]
        BoundingBox AccSagittalDoubleFlat143CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat17CUp")]
        BoundingBox AccSagittalDoubleFlat17CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat17kUp")]
        BoundingBox AccSagittalDoubleFlat17KUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat19CUp")]
        BoundingBox AccSagittalDoubleFlat19CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat19sUp")]
        BoundingBox AccSagittalDoubleFlat19SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat23CUp")]
        BoundingBox AccSagittalDoubleFlat23CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat23SUp")]
        BoundingBox AccSagittalDoubleFlat23SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat25SUp")]
        BoundingBox AccSagittalDoubleFlat25SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat49SUp")]
        BoundingBox AccSagittalDoubleFlat49SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat55CUp")]
        BoundingBox AccSagittalDoubleFlat55CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5CUp")]
        BoundingBox AccSagittalDoubleFlat5CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5v11SUp")]
        BoundingBox AccSagittalDoubleFlat5V11SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5v19CUp")]
        BoundingBox AccSagittalDoubleFlat5V19CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5v23SUp")]
        BoundingBox AccSagittalDoubleFlat5V23SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5v7kUp")]
        BoundingBox AccSagittalDoubleFlat5V7KUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat7CUp")]
        BoundingBox AccSagittalDoubleFlat7CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat7v11CUp")]
        BoundingBox AccSagittalDoubleFlat7V11CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat7v11kUp")]
        BoundingBox AccSagittalDoubleFlat7V11KUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat7v19CUp")]
        BoundingBox AccSagittalDoubleFlat7V19CUp { get; set; }

        [DataMember(Name="accSagittalDoubleSharp")]
        BoundingBox AccSagittalDoubleSharp { get; set; }

        [DataMember(Name="accSagittalDoubleSharp11v49CDown")]
        BoundingBox AccSagittalDoubleSharp11V49CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp143CDown")]
        BoundingBox AccSagittalDoubleSharp143CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp17CDown")]
        BoundingBox AccSagittalDoubleSharp17CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp17kDown")]
        BoundingBox AccSagittalDoubleSharp17KDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp19CDown")]
        BoundingBox AccSagittalDoubleSharp19CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp19sDown")]
        BoundingBox AccSagittalDoubleSharp19SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp23CDown")]
        BoundingBox AccSagittalDoubleSharp23CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp23SDown")]
        BoundingBox AccSagittalDoubleSharp23SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp25SDown")]
        BoundingBox AccSagittalDoubleSharp25SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp49SDown")]
        BoundingBox AccSagittalDoubleSharp49SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp55CDown")]
        BoundingBox AccSagittalDoubleSharp55CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5CDown")]
        BoundingBox AccSagittalDoubleSharp5CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5v11SDown")]
        BoundingBox AccSagittalDoubleSharp5V11SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5v19CDown")]
        BoundingBox AccSagittalDoubleSharp5V19CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5v23SDown")]
        BoundingBox AccSagittalDoubleSharp5V23SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5v7kDown")]
        BoundingBox AccSagittalDoubleSharp5V7KDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp7CDown")]
        BoundingBox AccSagittalDoubleSharp7CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp7v11CDown")]
        BoundingBox AccSagittalDoubleSharp7V11CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp7v11kDown")]
        BoundingBox AccSagittalDoubleSharp7V11KDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp7v19CDown")]
        BoundingBox AccSagittalDoubleSharp7V19CDown { get; set; }

        [DataMember(Name="accSagittalFlat")]
        BoundingBox AccSagittalFlat { get; set; }

        [DataMember(Name="accSagittalFlat11LDown")]
        BoundingBox AccSagittalFlat11LDown { get; set; }

        [DataMember(Name="accSagittalFlat11MDown")]
        BoundingBox AccSagittalFlat11MDown { get; set; }

        [DataMember(Name="accSagittalFlat11v19LDown")]
        BoundingBox AccSagittalFlat11V19LDown { get; set; }

        [DataMember(Name="accSagittalFlat11v19MDown")]
        BoundingBox AccSagittalFlat11V19MDown { get; set; }

        [DataMember(Name="accSagittalFlat11v49CDown")]
        BoundingBox AccSagittalFlat11V49CDown { get; set; }

        [DataMember(Name="accSagittalFlat11v49CUp")]
        BoundingBox AccSagittalFlat11V49CUp { get; set; }

        [DataMember(Name="accSagittalFlat143CDown")]
        BoundingBox AccSagittalFlat143CDown { get; set; }

        [DataMember(Name="accSagittalFlat143CUp")]
        BoundingBox AccSagittalFlat143CUp { get; set; }

        [DataMember(Name="accSagittalFlat17CDown")]
        BoundingBox AccSagittalFlat17CDown { get; set; }

        [DataMember(Name="accSagittalFlat17CUp")]
        BoundingBox AccSagittalFlat17CUp { get; set; }

        [DataMember(Name="accSagittalFlat17kDown")]
        BoundingBox AccSagittalFlat17KDown { get; set; }

        [DataMember(Name="accSagittalFlat17kUp")]
        BoundingBox AccSagittalFlat17KUp { get; set; }

        [DataMember(Name="accSagittalFlat19CDown")]
        BoundingBox AccSagittalFlat19CDown { get; set; }

        [DataMember(Name="accSagittalFlat19CUp")]
        BoundingBox AccSagittalFlat19CUp { get; set; }

        [DataMember(Name="accSagittalFlat19sDown")]
        BoundingBox AccSagittalFlat19SDown { get; set; }

        [DataMember(Name="accSagittalFlat19sUp")]
        BoundingBox AccSagittalFlat19SUp { get; set; }

        [DataMember(Name="accSagittalFlat23CDown")]
        BoundingBox AccSagittalFlat23CDown { get; set; }

        [DataMember(Name="accSagittalFlat23CUp")]
        BoundingBox AccSagittalFlat23CUp { get; set; }

        [DataMember(Name="accSagittalFlat23SDown")]
        BoundingBox AccSagittalFlat23SDown { get; set; }

        [DataMember(Name="accSagittalFlat23SUp")]
        BoundingBox AccSagittalFlat23SUp { get; set; }

        [DataMember(Name="accSagittalFlat25SDown")]
        BoundingBox AccSagittalFlat25SDown { get; set; }

        [DataMember(Name="accSagittalFlat25SUp")]
        BoundingBox AccSagittalFlat25SUp { get; set; }

        [DataMember(Name="accSagittalFlat35LDown")]
        BoundingBox AccSagittalFlat35LDown { get; set; }

        [DataMember(Name="accSagittalFlat35MDown")]
        BoundingBox AccSagittalFlat35MDown { get; set; }

        [DataMember(Name="accSagittalFlat49LDown")]
        BoundingBox AccSagittalFlat49LDown { get; set; }

        [DataMember(Name="accSagittalFlat49MDown")]
        BoundingBox AccSagittalFlat49MDown { get; set; }

        [DataMember(Name="accSagittalFlat49SDown")]
        BoundingBox AccSagittalFlat49SDown { get; set; }

        [DataMember(Name="accSagittalFlat49SUp")]
        BoundingBox AccSagittalFlat49SUp { get; set; }

        [DataMember(Name="accSagittalFlat55CDown")]
        BoundingBox AccSagittalFlat55CDown { get; set; }

        [DataMember(Name="accSagittalFlat55CUp")]
        BoundingBox AccSagittalFlat55CUp { get; set; }

        [DataMember(Name="accSagittalFlat5CDown")]
        BoundingBox AccSagittalFlat5CDown { get; set; }

        [DataMember(Name="accSagittalFlat5CUp")]
        BoundingBox AccSagittalFlat5CUp { get; set; }

        [DataMember(Name="accSagittalFlat5v11SDown")]
        BoundingBox AccSagittalFlat5V11SDown { get; set; }

        [DataMember(Name="accSagittalFlat5v11SUp")]
        BoundingBox AccSagittalFlat5V11SUp { get; set; }

        [DataMember(Name="accSagittalFlat5v13LDown")]
        BoundingBox AccSagittalFlat5V13LDown { get; set; }

        [DataMember(Name="accSagittalFlat5v13MDown")]
        BoundingBox AccSagittalFlat5V13MDown { get; set; }

        [DataMember(Name="accSagittalFlat5v19CDown")]
        BoundingBox AccSagittalFlat5V19CDown { get; set; }

        [DataMember(Name="accSagittalFlat5v19CUp")]
        BoundingBox AccSagittalFlat5V19CUp { get; set; }

        [DataMember(Name="accSagittalFlat5v23SDown")]
        BoundingBox AccSagittalFlat5V23SDown { get; set; }

        [DataMember(Name="accSagittalFlat5v23SUp")]
        BoundingBox AccSagittalFlat5V23SUp { get; set; }

        [DataMember(Name="accSagittalFlat5v49MDown")]
        BoundingBox AccSagittalFlat5V49MDown { get; set; }

        [DataMember(Name="accSagittalFlat5v7kDown")]
        BoundingBox AccSagittalFlat5V7KDown { get; set; }

        [DataMember(Name="accSagittalFlat5v7kUp")]
        BoundingBox AccSagittalFlat5V7KUp { get; set; }

        [DataMember(Name="accSagittalFlat7CDown")]
        BoundingBox AccSagittalFlat7CDown { get; set; }

        [DataMember(Name="accSagittalFlat7CUp")]
        BoundingBox AccSagittalFlat7CUp { get; set; }

        [DataMember(Name="accSagittalFlat7v11CDown")]
        BoundingBox AccSagittalFlat7V11CDown { get; set; }

        [DataMember(Name="accSagittalFlat7v11CUp")]
        BoundingBox AccSagittalFlat7V11CUp { get; set; }

        [DataMember(Name="accSagittalFlat7v11kDown")]
        BoundingBox AccSagittalFlat7V11KDown { get; set; }

        [DataMember(Name="accSagittalFlat7v11kUp")]
        BoundingBox AccSagittalFlat7V11KUp { get; set; }

        [DataMember(Name="accSagittalFlat7v19CDown")]
        BoundingBox AccSagittalFlat7V19CDown { get; set; }

        [DataMember(Name="accSagittalFlat7v19CUp")]
        BoundingBox AccSagittalFlat7V19CUp { get; set; }

        [DataMember(Name="accSagittalGrave")]
        BoundingBox AccSagittalGrave { get; set; }

        [DataMember(Name="accSagittalShaftDown")]
        BoundingBox AccSagittalShaftDown { get; set; }

        [DataMember(Name="accSagittalShaftUp")]
        BoundingBox AccSagittalShaftUp { get; set; }

        [DataMember(Name="accSagittalSharp")]
        BoundingBox AccSagittalSharp { get; set; }

        [DataMember(Name="accSagittalSharp11LUp")]
        BoundingBox AccSagittalSharp11LUp { get; set; }

        [DataMember(Name="accSagittalSharp11MUp")]
        BoundingBox AccSagittalSharp11MUp { get; set; }

        [DataMember(Name="accSagittalSharp11v19LUp")]
        BoundingBox AccSagittalSharp11V19LUp { get; set; }

        [DataMember(Name="accSagittalSharp11v19MUp")]
        BoundingBox AccSagittalSharp11V19MUp { get; set; }

        [DataMember(Name="accSagittalSharp11v49CDown")]
        BoundingBox AccSagittalSharp11V49CDown { get; set; }

        [DataMember(Name="accSagittalSharp11v49CUp")]
        BoundingBox AccSagittalSharp11V49CUp { get; set; }

        [DataMember(Name="accSagittalSharp143CDown")]
        BoundingBox AccSagittalSharp143CDown { get; set; }

        [DataMember(Name="accSagittalSharp143CUp")]
        BoundingBox AccSagittalSharp143CUp { get; set; }

        [DataMember(Name="accSagittalSharp17CDown")]
        BoundingBox AccSagittalSharp17CDown { get; set; }

        [DataMember(Name="accSagittalSharp17CUp")]
        BoundingBox AccSagittalSharp17CUp { get; set; }

        [DataMember(Name="accSagittalSharp17kDown")]
        BoundingBox AccSagittalSharp17KDown { get; set; }

        [DataMember(Name="accSagittalSharp17kUp")]
        BoundingBox AccSagittalSharp17KUp { get; set; }

        [DataMember(Name="accSagittalSharp19CDown")]
        BoundingBox AccSagittalSharp19CDown { get; set; }

        [DataMember(Name="accSagittalSharp19CUp")]
        BoundingBox AccSagittalSharp19CUp { get; set; }

        [DataMember(Name="accSagittalSharp19sDown")]
        BoundingBox AccSagittalSharp19SDown { get; set; }

        [DataMember(Name="accSagittalSharp19sUp")]
        BoundingBox AccSagittalSharp19SUp { get; set; }

        [DataMember(Name="accSagittalSharp23CDown")]
        BoundingBox AccSagittalSharp23CDown { get; set; }

        [DataMember(Name="accSagittalSharp23CUp")]
        BoundingBox AccSagittalSharp23CUp { get; set; }

        [DataMember(Name="accSagittalSharp23SDown")]
        BoundingBox AccSagittalSharp23SDown { get; set; }

        [DataMember(Name="accSagittalSharp23SUp")]
        BoundingBox AccSagittalSharp23SUp { get; set; }

        [DataMember(Name="accSagittalSharp25SDown")]
        BoundingBox AccSagittalSharp25SDown { get; set; }

        [DataMember(Name="accSagittalSharp25SUp")]
        BoundingBox AccSagittalSharp25SUp { get; set; }

        [DataMember(Name="accSagittalSharp35LUp")]
        BoundingBox AccSagittalSharp35LUp { get; set; }

        [DataMember(Name="accSagittalSharp35MUp")]
        BoundingBox AccSagittalSharp35MUp { get; set; }

        [DataMember(Name="accSagittalSharp49LUp")]
        BoundingBox AccSagittalSharp49LUp { get; set; }

        [DataMember(Name="accSagittalSharp49MUp")]
        BoundingBox AccSagittalSharp49MUp { get; set; }

        [DataMember(Name="accSagittalSharp49SDown")]
        BoundingBox AccSagittalSharp49SDown { get; set; }

        [DataMember(Name="accSagittalSharp49SUp")]
        BoundingBox AccSagittalSharp49SUp { get; set; }

        [DataMember(Name="accSagittalSharp55CDown")]
        BoundingBox AccSagittalSharp55CDown { get; set; }

        [DataMember(Name="accSagittalSharp55CUp")]
        BoundingBox AccSagittalSharp55CUp { get; set; }

        [DataMember(Name="accSagittalSharp5CDown")]
        BoundingBox AccSagittalSharp5CDown { get; set; }

        [DataMember(Name="accSagittalSharp5CUp")]
        BoundingBox AccSagittalSharp5CUp { get; set; }

        [DataMember(Name="accSagittalSharp5v11SDown")]
        BoundingBox AccSagittalSharp5V11SDown { get; set; }

        [DataMember(Name="accSagittalSharp5v11SUp")]
        BoundingBox AccSagittalSharp5V11SUp { get; set; }

        [DataMember(Name="accSagittalSharp5v13LUp")]
        BoundingBox AccSagittalSharp5V13LUp { get; set; }

        [DataMember(Name="accSagittalSharp5v13MUp")]
        BoundingBox AccSagittalSharp5V13MUp { get; set; }

        [DataMember(Name="accSagittalSharp5v19CDown")]
        BoundingBox AccSagittalSharp5V19CDown { get; set; }

        [DataMember(Name="accSagittalSharp5v19CUp")]
        BoundingBox AccSagittalSharp5V19CUp { get; set; }

        [DataMember(Name="accSagittalSharp5v23SDown")]
        BoundingBox AccSagittalSharp5V23SDown { get; set; }

        [DataMember(Name="accSagittalSharp5v23SUp")]
        BoundingBox AccSagittalSharp5V23SUp { get; set; }

        [DataMember(Name="accSagittalSharp5v49MUp")]
        BoundingBox AccSagittalSharp5V49MUp { get; set; }

        [DataMember(Name="accSagittalSharp5v7kDown")]
        BoundingBox AccSagittalSharp5V7KDown { get; set; }

        [DataMember(Name="accSagittalSharp5v7kUp")]
        BoundingBox AccSagittalSharp5V7KUp { get; set; }

        [DataMember(Name="accSagittalSharp7CDown")]
        BoundingBox AccSagittalSharp7CDown { get; set; }

        [DataMember(Name="accSagittalSharp7CUp")]
        BoundingBox AccSagittalSharp7CUp { get; set; }

        [DataMember(Name="accSagittalSharp7v11CDown")]
        BoundingBox AccSagittalSharp7V11CDown { get; set; }

        [DataMember(Name="accSagittalSharp7v11CUp")]
        BoundingBox AccSagittalSharp7V11CUp { get; set; }

        [DataMember(Name="accSagittalSharp7v11kDown")]
        BoundingBox AccSagittalSharp7V11KDown { get; set; }

        [DataMember(Name="accSagittalSharp7v11kUp")]
        BoundingBox AccSagittalSharp7V11KUp { get; set; }

        [DataMember(Name="accSagittalSharp7v19CDown")]
        BoundingBox AccSagittalSharp7V19CDown { get; set; }

        [DataMember(Name="accSagittalSharp7v19CUp")]
        BoundingBox AccSagittalSharp7V19CUp { get; set; }

        [DataMember(Name="accdnCombDot")]
        BoundingBox AccdnCombDot { get; set; }

        [DataMember(Name="accdnCombLH2RanksEmpty")]
        BoundingBox AccdnCombLh2RanksEmpty { get; set; }

        [DataMember(Name="accdnCombLH3RanksEmptySquare")]
        BoundingBox AccdnCombLh3RanksEmptySquare { get; set; }

        [DataMember(Name="accdnCombRH3RanksEmpty")]
        BoundingBox AccdnCombRh3RanksEmpty { get; set; }

        [DataMember(Name="accdnCombRH4RanksEmpty")]
        BoundingBox AccdnCombRh4RanksEmpty { get; set; }

        [DataMember(Name="accdnDiatonicClef")]
        BoundingBox AccdnDiatonicClef { get; set; }

        [DataMember(Name="accdnLH2Ranks16Round")]
        BoundingBox AccdnLh2Ranks16Round { get; set; }

        [DataMember(Name="accdnLH2Ranks8Plus16Round")]
        BoundingBox AccdnLh2Ranks8Plus16Round { get; set; }

        [DataMember(Name="accdnLH2Ranks8Round")]
        BoundingBox AccdnLh2Ranks8Round { get; set; }

        [DataMember(Name="accdnLH2RanksFullMasterRound")]
        BoundingBox AccdnLh2RanksFullMasterRound { get; set; }

        [DataMember(Name="accdnLH2RanksMasterPlus16Round")]
        BoundingBox AccdnLh2RanksMasterPlus16Round { get; set; }

        [DataMember(Name="accdnLH2RanksMasterRound")]
        BoundingBox AccdnLh2RanksMasterRound { get; set; }

        [DataMember(Name="accdnLH3Ranks2Plus8Square")]
        BoundingBox AccdnLh3Ranks2Plus8Square { get; set; }

        [DataMember(Name="accdnLH3Ranks2Square")]
        BoundingBox AccdnLh3Ranks2Square { get; set; }

        [DataMember(Name="accdnLH3Ranks8Square")]
        BoundingBox AccdnLh3Ranks8Square { get; set; }

        [DataMember(Name="accdnLH3RanksDouble8Square")]
        BoundingBox AccdnLh3RanksDouble8Square { get; set; }

        [DataMember(Name="accdnLH3RanksTuttiSquare")]
        BoundingBox AccdnLh3RanksTuttiSquare { get; set; }

        [DataMember(Name="accdnPull")]
        BoundingBox AccdnPull { get; set; }

        [DataMember(Name="accdnPush")]
        BoundingBox AccdnPush { get; set; }

        [DataMember(Name="accdnPushAlt")]
        BoundingBox AccdnPushAlt { get; set; }

        [DataMember(Name="accdnRH3RanksAccordion")]
        BoundingBox AccdnRh3RanksAccordion { get; set; }

        [DataMember(Name="accdnRH3RanksAuthenticMusette")]
        BoundingBox AccdnRh3RanksAuthenticMusette { get; set; }

        [DataMember(Name="accdnRH3RanksBandoneon")]
        BoundingBox AccdnRh3RanksBandoneon { get; set; }

        [DataMember(Name="accdnRH3RanksBassoon")]
        BoundingBox AccdnRh3RanksBassoon { get; set; }

        [DataMember(Name="accdnRH3RanksClarinet")]
        BoundingBox AccdnRh3RanksClarinet { get; set; }

        [DataMember(Name="accdnRH3RanksDoubleTremoloLower8ve")]
        BoundingBox AccdnRh3RanksDoubleTremoloLower8Ve { get; set; }

        [DataMember(Name="accdnRH3RanksDoubleTremoloUpper8ve")]
        BoundingBox AccdnRh3RanksDoubleTremoloUpper8Ve { get; set; }

        [DataMember(Name="accdnRH3RanksFullFactory")]
        BoundingBox AccdnRh3RanksFullFactory { get; set; }

        [DataMember(Name="accdnRH3RanksHarmonium")]
        BoundingBox AccdnRh3RanksHarmonium { get; set; }

        [DataMember(Name="accdnRH3RanksImitationMusette")]
        BoundingBox AccdnRh3RanksImitationMusette { get; set; }

        [DataMember(Name="accdnRH3RanksLowerTremolo8")]
        BoundingBox AccdnRh3RanksLowerTremolo8 { get; set; }

        [DataMember(Name="accdnRH3RanksMaster")]
        BoundingBox AccdnRh3RanksMaster { get; set; }

        [DataMember(Name="accdnRH3RanksOboe")]
        BoundingBox AccdnRh3RanksOboe { get; set; }

        [DataMember(Name="accdnRH3RanksOrgan")]
        BoundingBox AccdnRh3RanksOrgan { get; set; }

        [DataMember(Name="accdnRH3RanksPiccolo")]
        BoundingBox AccdnRh3RanksPiccolo { get; set; }

        [DataMember(Name="accdnRH3RanksTremoloLower8ve")]
        BoundingBox AccdnRh3RanksTremoloLower8Ve { get; set; }

        [DataMember(Name="accdnRH3RanksTremoloUpper8ve")]
        BoundingBox AccdnRh3RanksTremoloUpper8Ve { get; set; }

        [DataMember(Name="accdnRH3RanksTwoChoirs")]
        BoundingBox AccdnRh3RanksTwoChoirs { get; set; }

        [DataMember(Name="accdnRH3RanksUpperTremolo8")]
        BoundingBox AccdnRh3RanksUpperTremolo8 { get; set; }

        [DataMember(Name="accdnRH3RanksViolin")]
        BoundingBox AccdnRh3RanksViolin { get; set; }

        [DataMember(Name="accdnRH4RanksAlto")]
        BoundingBox AccdnRh4RanksAlto { get; set; }

        [DataMember(Name="accdnRH4RanksBassAlto")]
        BoundingBox AccdnRh4RanksBassAlto { get; set; }

        [DataMember(Name="accdnRH4RanksMaster")]
        BoundingBox AccdnRh4RanksMaster { get; set; }

        [DataMember(Name="accdnRH4RanksSoftBass")]
        BoundingBox AccdnRh4RanksSoftBass { get; set; }

        [DataMember(Name="accdnRH4RanksSoftTenor")]
        BoundingBox AccdnRh4RanksSoftTenor { get; set; }

        [DataMember(Name="accdnRH4RanksSoprano")]
        BoundingBox AccdnRh4RanksSoprano { get; set; }

        [DataMember(Name="accdnRH4RanksTenor")]
        BoundingBox AccdnRh4RanksTenor { get; set; }

        [DataMember(Name="accdnRicochet2")]
        BoundingBox AccdnRicochet2 { get; set; }

        [DataMember(Name="accdnRicochet3")]
        BoundingBox AccdnRicochet3 { get; set; }

        [DataMember(Name="accdnRicochet4")]
        BoundingBox AccdnRicochet4 { get; set; }

        [DataMember(Name="accdnRicochet5")]
        BoundingBox AccdnRicochet5 { get; set; }

        [DataMember(Name="accdnRicochet6")]
        BoundingBox AccdnRicochet6 { get; set; }

        [DataMember(Name="accdnRicochetStem2")]
        BoundingBox AccdnRicochetStem2 { get; set; }

        [DataMember(Name="accdnRicochetStem3")]
        BoundingBox AccdnRicochetStem3 { get; set; }

        [DataMember(Name="accdnRicochetStem4")]
        BoundingBox AccdnRicochetStem4 { get; set; }

        [DataMember(Name="accdnRicochetStem5")]
        BoundingBox AccdnRicochetStem5 { get; set; }

        [DataMember(Name="accdnRicochetStem6")]
        BoundingBox AccdnRicochetStem6 { get; set; }

        [DataMember(Name="accidental1CommaFlat")]
        BoundingBox Accidental1CommaFlat { get; set; }

        [DataMember(Name="accidental1CommaSharp")]
        BoundingBox Accidental1CommaSharp { get; set; }

        [DataMember(Name="accidental2CommaFlat")]
        BoundingBox Accidental2CommaFlat { get; set; }

        [DataMember(Name="accidental2CommaSharp")]
        BoundingBox Accidental2CommaSharp { get; set; }

        [DataMember(Name="accidental3CommaFlat")]
        BoundingBox Accidental3CommaFlat { get; set; }

        [DataMember(Name="accidental3CommaSharp")]
        BoundingBox Accidental3CommaSharp { get; set; }

        [DataMember(Name="accidental4CommaFlat")]
        BoundingBox Accidental4CommaFlat { get; set; }

        [DataMember(Name="accidental5CommaSharp")]
        BoundingBox Accidental5CommaSharp { get; set; }

        [DataMember(Name="accidentalArrowDown")]
        BoundingBox AccidentalArrowDown { get; set; }

        [DataMember(Name="accidentalArrowUp")]
        BoundingBox AccidentalArrowUp { get; set; }

        [DataMember(Name="accidentalBakiyeFlat")]
        BoundingBox AccidentalBakiyeFlat { get; set; }

        [DataMember(Name="accidentalBakiyeSharp")]
        BoundingBox AccidentalBakiyeSharp { get; set; }

        [DataMember(Name="accidentalBracketLeft")]
        BoundingBox AccidentalBracketLeft { get; set; }

        [DataMember(Name="accidentalBracketRight")]
        BoundingBox AccidentalBracketRight { get; set; }

        [DataMember(Name="accidentalBuyukMucennebFlat")]
        BoundingBox AccidentalBuyukMucennebFlat { get; set; }

        [DataMember(Name="accidentalBuyukMucennebSharp")]
        BoundingBox AccidentalBuyukMucennebSharp { get; set; }

        [DataMember(Name="accidentalCombiningCloseCurlyBrace")]
        BoundingBox AccidentalCombiningCloseCurlyBrace { get; set; }

        [DataMember(Name="accidentalCombiningLower17Schisma")]
        BoundingBox AccidentalCombiningLower17Schisma { get; set; }

        [DataMember(Name="accidentalCombiningLower19Schisma")]
        BoundingBox AccidentalCombiningLower19Schisma { get; set; }

        [DataMember(Name="accidentalCombiningLower23Limit29LimitComma")]
        BoundingBox AccidentalCombiningLower23Limit29LimitComma { get; set; }

        [DataMember(Name="accidentalCombiningLower31Schisma")]
        BoundingBox AccidentalCombiningLower31Schisma { get; set; }

        [DataMember(Name="accidentalCombiningLower53LimitComma")]
        BoundingBox AccidentalCombiningLower53LimitComma { get; set; }

        [DataMember(Name="accidentalCombiningOpenCurlyBrace")]
        BoundingBox AccidentalCombiningOpenCurlyBrace { get; set; }

        [DataMember(Name="accidentalCombiningRaise17Schisma")]
        BoundingBox AccidentalCombiningRaise17Schisma { get; set; }

        [DataMember(Name="accidentalCombiningRaise19Schisma")]
        BoundingBox AccidentalCombiningRaise19Schisma { get; set; }

        [DataMember(Name="accidentalCombiningRaise23Limit29LimitComma")]
        BoundingBox AccidentalCombiningRaise23Limit29LimitComma { get; set; }

        [DataMember(Name="accidentalCombiningRaise31Schisma")]
        BoundingBox AccidentalCombiningRaise31Schisma { get; set; }

        [DataMember(Name="accidentalCombiningRaise53LimitComma")]
        BoundingBox AccidentalCombiningRaise53LimitComma { get; set; }

        [DataMember(Name="accidentalCommaSlashDown")]
        BoundingBox AccidentalCommaSlashDown { get; set; }

        [DataMember(Name="accidentalCommaSlashUp")]
        BoundingBox AccidentalCommaSlashUp { get; set; }

        [DataMember(Name="accidentalDoubleFlat")]
        BoundingBox AccidentalDoubleFlat { get; set; }

        [DataMember(Name="accidentalDoubleFlatArabic")]
        BoundingBox AccidentalDoubleFlatArabic { get; set; }

        [DataMember(Name="accidentalDoubleFlatEqualTempered")]
        BoundingBox AccidentalDoubleFlatEqualTempered { get; set; }

        [DataMember(Name="accidentalDoubleFlatJoinedStems")]
        BoundingBox AccidentalDoubleFlatJoinedStems { get; set; }

        [DataMember(Name="accidentalDoubleFlatOneArrowDown")]
        BoundingBox AccidentalDoubleFlatOneArrowDown { get; set; }

        [DataMember(Name="accidentalDoubleFlatOneArrowUp")]
        BoundingBox AccidentalDoubleFlatOneArrowUp { get; set; }

        [DataMember(Name="accidentalDoubleFlatParens")]
        BoundingBox AccidentalDoubleFlatParens { get; set; }

        [DataMember(Name="accidentalDoubleFlatReversed")]
        BoundingBox AccidentalDoubleFlatReversed { get; set; }

        [DataMember(Name="accidentalDoubleFlatThreeArrowsDown")]
        BoundingBox AccidentalDoubleFlatThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalDoubleFlatThreeArrowsUp")]
        BoundingBox AccidentalDoubleFlatThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalDoubleFlatTurned")]
        BoundingBox AccidentalDoubleFlatTurned { get; set; }

        [DataMember(Name="accidentalDoubleFlatTwoArrowsDown")]
        BoundingBox AccidentalDoubleFlatTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalDoubleFlatTwoArrowsUp")]
        BoundingBox AccidentalDoubleFlatTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalDoubleSharp")]
        BoundingBox AccidentalDoubleSharp { get; set; }

        [DataMember(Name="accidentalDoubleSharpArabic")]
        BoundingBox AccidentalDoubleSharpArabic { get; set; }

        [DataMember(Name="accidentalDoubleSharpEqualTempered")]
        BoundingBox AccidentalDoubleSharpEqualTempered { get; set; }

        [DataMember(Name="accidentalDoubleSharpOneArrowDown")]
        BoundingBox AccidentalDoubleSharpOneArrowDown { get; set; }

        [DataMember(Name="accidentalDoubleSharpOneArrowUp")]
        BoundingBox AccidentalDoubleSharpOneArrowUp { get; set; }

        [DataMember(Name="accidentalDoubleSharpParens")]
        BoundingBox AccidentalDoubleSharpParens { get; set; }

        [DataMember(Name="accidentalDoubleSharpThreeArrowsDown")]
        BoundingBox AccidentalDoubleSharpThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalDoubleSharpThreeArrowsUp")]
        BoundingBox AccidentalDoubleSharpThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalDoubleSharpTwoArrowsDown")]
        BoundingBox AccidentalDoubleSharpTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalDoubleSharpTwoArrowsUp")]
        BoundingBox AccidentalDoubleSharpTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalEnharmonicAlmostEqualTo")]
        BoundingBox AccidentalEnharmonicAlmostEqualTo { get; set; }

        [DataMember(Name="accidentalEnharmonicEquals")]
        BoundingBox AccidentalEnharmonicEquals { get; set; }

        [DataMember(Name="accidentalEnharmonicTilde")]
        BoundingBox AccidentalEnharmonicTilde { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatAndFlat")]
        BoundingBox AccidentalFilledReversedFlatAndFlat { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatAndFlatArrowDown")]
        BoundingBox AccidentalFilledReversedFlatAndFlatArrowDown { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatAndFlatArrowUp")]
        BoundingBox AccidentalFilledReversedFlatAndFlatArrowUp { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatArrowDown")]
        BoundingBox AccidentalFilledReversedFlatArrowDown { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatArrowUp")]
        BoundingBox AccidentalFilledReversedFlatArrowUp { get; set; }

        [DataMember(Name="accidentalFiveQuarterTonesFlatArrowDown")]
        BoundingBox AccidentalFiveQuarterTonesFlatArrowDown { get; set; }

        [DataMember(Name="accidentalFiveQuarterTonesSharpArrowUp")]
        BoundingBox AccidentalFiveQuarterTonesSharpArrowUp { get; set; }

        [DataMember(Name="accidentalFlat")]
        BoundingBox AccidentalFlat { get; set; }

        [DataMember(Name="accidentalFlatArabic")]
        BoundingBox AccidentalFlatArabic { get; set; }

        [DataMember(Name="accidentalFlatEqualTempered")]
        BoundingBox AccidentalFlatEqualTempered { get; set; }

        [DataMember(Name="accidentalFlatJohnstonDown")]
        BoundingBox AccidentalFlatJohnstonDown { get; set; }

        [DataMember(Name="accidentalFlatJohnstonEl")]
        BoundingBox AccidentalFlatJohnstonEl { get; set; }

        [DataMember(Name="accidentalFlatJohnstonElDown")]
        BoundingBox AccidentalFlatJohnstonElDown { get; set; }

        [DataMember(Name="accidentalFlatJohnstonUp")]
        BoundingBox AccidentalFlatJohnstonUp { get; set; }

        [DataMember(Name="accidentalFlatJohnstonUpEl")]
        BoundingBox AccidentalFlatJohnstonUpEl { get; set; }

        [DataMember(Name="accidentalFlatLoweredStockhausen")]
        BoundingBox AccidentalFlatLoweredStockhausen { get; set; }

        [DataMember(Name="accidentalFlatOneArrowDown")]
        BoundingBox AccidentalFlatOneArrowDown { get; set; }

        [DataMember(Name="accidentalFlatOneArrowUp")]
        BoundingBox AccidentalFlatOneArrowUp { get; set; }

        [DataMember(Name="accidentalFlatParens")]
        BoundingBox AccidentalFlatParens { get; set; }

        [DataMember(Name="accidentalFlatRaisedStockhausen")]
        BoundingBox AccidentalFlatRaisedStockhausen { get; set; }

        [DataMember(Name="accidentalFlatRepeatedLineStockhausen")]
        BoundingBox AccidentalFlatRepeatedLineStockhausen { get; set; }

        [DataMember(Name="accidentalFlatRepeatedSpaceStockhausen")]
        BoundingBox AccidentalFlatRepeatedSpaceStockhausen { get; set; }

        [DataMember(Name="accidentalFlatSmall")]
        BoundingBox AccidentalFlatSmall { get; set; }

        [DataMember(Name="accidentalFlatThreeArrowsDown")]
        BoundingBox AccidentalFlatThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalFlatThreeArrowsUp")]
        BoundingBox AccidentalFlatThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalFlatTurned")]
        BoundingBox AccidentalFlatTurned { get; set; }

        [DataMember(Name="accidentalFlatTwoArrowsDown")]
        BoundingBox AccidentalFlatTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalFlatTwoArrowsUp")]
        BoundingBox AccidentalFlatTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalHalfSharpArrowDown")]
        BoundingBox AccidentalHalfSharpArrowDown { get; set; }

        [DataMember(Name="accidentalHalfSharpArrowUp")]
        BoundingBox AccidentalHalfSharpArrowUp { get; set; }

        [DataMember(Name="accidentalJohnston13")]
        BoundingBox AccidentalJohnston13 { get; set; }

        [DataMember(Name="accidentalJohnston31")]
        BoundingBox AccidentalJohnston31 { get; set; }

        [DataMember(Name="accidentalJohnstonDown")]
        BoundingBox AccidentalJohnstonDown { get; set; }

        [DataMember(Name="accidentalJohnstonDownEl")]
        BoundingBox AccidentalJohnstonDownEl { get; set; }

        [DataMember(Name="accidentalJohnstonEl")]
        BoundingBox AccidentalJohnstonEl { get; set; }

        [DataMember(Name="accidentalJohnstonMinus")]
        BoundingBox AccidentalJohnstonMinus { get; set; }

        [DataMember(Name="accidentalJohnstonPlus")]
        BoundingBox AccidentalJohnstonPlus { get; set; }

        [DataMember(Name="accidentalJohnstonSeven")]
        BoundingBox AccidentalJohnstonSeven { get; set; }

        [DataMember(Name="accidentalJohnstonSevenDown")]
        BoundingBox AccidentalJohnstonSevenDown { get; set; }

        [DataMember(Name="accidentalJohnstonSevenFlat")]
        BoundingBox AccidentalJohnstonSevenFlat { get; set; }

        [DataMember(Name="accidentalJohnstonSevenFlatDown")]
        BoundingBox AccidentalJohnstonSevenFlatDown { get; set; }

        [DataMember(Name="accidentalJohnstonSevenFlatUp")]
        BoundingBox AccidentalJohnstonSevenFlatUp { get; set; }

        [DataMember(Name="accidentalJohnstonSevenSharp")]
        BoundingBox AccidentalJohnstonSevenSharp { get; set; }

        [DataMember(Name="accidentalJohnstonSevenSharpDown")]
        BoundingBox AccidentalJohnstonSevenSharpDown { get; set; }

        [DataMember(Name="accidentalJohnstonSevenSharpUp")]
        BoundingBox AccidentalJohnstonSevenSharpUp { get; set; }

        [DataMember(Name="accidentalJohnstonSevenUp")]
        BoundingBox AccidentalJohnstonSevenUp { get; set; }

        [DataMember(Name="accidentalJohnstonUp")]
        BoundingBox AccidentalJohnstonUp { get; set; }

        [DataMember(Name="accidentalJohnstonUpEl")]
        BoundingBox AccidentalJohnstonUpEl { get; set; }

        [DataMember(Name="accidentalKomaFlat")]
        BoundingBox AccidentalKomaFlat { get; set; }

        [DataMember(Name="accidentalKomaSharp")]
        BoundingBox AccidentalKomaSharp { get; set; }

        [DataMember(Name="accidentalKoron")]
        BoundingBox AccidentalKoron { get; set; }

        [DataMember(Name="accidentalKucukMucennebFlat")]
        BoundingBox AccidentalKucukMucennebFlat { get; set; }

        [DataMember(Name="accidentalKucukMucennebSharp")]
        BoundingBox AccidentalKucukMucennebSharp { get; set; }

        [DataMember(Name="accidentalLargeDoubleSharp")]
        BoundingBox AccidentalLargeDoubleSharp { get; set; }

        [DataMember(Name="accidentalLowerOneSeptimalComma")]
        BoundingBox AccidentalLowerOneSeptimalComma { get; set; }

        [DataMember(Name="accidentalLowerOneTridecimalQuartertone")]
        BoundingBox AccidentalLowerOneTridecimalQuartertone { get; set; }

        [DataMember(Name="accidentalLowerOneUndecimalQuartertone")]
        BoundingBox AccidentalLowerOneUndecimalQuartertone { get; set; }

        [DataMember(Name="accidentalLowerTwoSeptimalCommas")]
        BoundingBox AccidentalLowerTwoSeptimalCommas { get; set; }

        [DataMember(Name="accidentalLoweredStockhausen")]
        BoundingBox AccidentalLoweredStockhausen { get; set; }

        [DataMember(Name="accidentalNarrowReversedFlat")]
        BoundingBox AccidentalNarrowReversedFlat { get; set; }

        [DataMember(Name="accidentalNarrowReversedFlatAndFlat")]
        BoundingBox AccidentalNarrowReversedFlatAndFlat { get; set; }

        [DataMember(Name="accidentalNatural")]
        BoundingBox AccidentalNatural { get; set; }

        [DataMember(Name="accidentalNaturalArabic")]
        BoundingBox AccidentalNaturalArabic { get; set; }

        [DataMember(Name="accidentalNaturalEqualTempered")]
        BoundingBox AccidentalNaturalEqualTempered { get; set; }

        [DataMember(Name="accidentalNaturalFlat")]
        BoundingBox AccidentalNaturalFlat { get; set; }

        [DataMember(Name="accidentalNaturalLoweredStockhausen")]
        BoundingBox AccidentalNaturalLoweredStockhausen { get; set; }

        [DataMember(Name="accidentalNaturalOneArrowDown")]
        BoundingBox AccidentalNaturalOneArrowDown { get; set; }

        [DataMember(Name="accidentalNaturalOneArrowUp")]
        BoundingBox AccidentalNaturalOneArrowUp { get; set; }

        [DataMember(Name="accidentalNaturalParens")]
        BoundingBox AccidentalNaturalParens { get; set; }

        [DataMember(Name="accidentalNaturalRaisedStockhausen")]
        BoundingBox AccidentalNaturalRaisedStockhausen { get; set; }

        [DataMember(Name="accidentalNaturalReversed")]
        BoundingBox AccidentalNaturalReversed { get; set; }

        [DataMember(Name="accidentalNaturalSharp")]
        BoundingBox AccidentalNaturalSharp { get; set; }

        [DataMember(Name="accidentalNaturalSmall")]
        BoundingBox AccidentalNaturalSmall { get; set; }

        [DataMember(Name="accidentalNaturalThreeArrowsDown")]
        BoundingBox AccidentalNaturalThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalNaturalThreeArrowsUp")]
        BoundingBox AccidentalNaturalThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalNaturalTwoArrowsDown")]
        BoundingBox AccidentalNaturalTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalNaturalTwoArrowsUp")]
        BoundingBox AccidentalNaturalTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalOneAndAHalfSharpsArrowDown")]
        BoundingBox AccidentalOneAndAHalfSharpsArrowDown { get; set; }

        [DataMember(Name="accidentalOneAndAHalfSharpsArrowUp")]
        BoundingBox AccidentalOneAndAHalfSharpsArrowUp { get; set; }

        [DataMember(Name="accidentalOneQuarterToneFlatFerneyhough")]
        BoundingBox AccidentalOneQuarterToneFlatFerneyhough { get; set; }

        [DataMember(Name="accidentalOneQuarterToneFlatStockhausen")]
        BoundingBox AccidentalOneQuarterToneFlatStockhausen { get; set; }

        [DataMember(Name="accidentalOneQuarterToneSharpFerneyhough")]
        BoundingBox AccidentalOneQuarterToneSharpFerneyhough { get; set; }

        [DataMember(Name="accidentalOneQuarterToneSharpStockhausen")]
        BoundingBox AccidentalOneQuarterToneSharpStockhausen { get; set; }

        [DataMember(Name="accidentalOneThirdToneFlatFerneyhough")]
        BoundingBox AccidentalOneThirdToneFlatFerneyhough { get; set; }

        [DataMember(Name="accidentalOneThirdToneSharpFerneyhough")]
        BoundingBox AccidentalOneThirdToneSharpFerneyhough { get; set; }

        [DataMember(Name="accidentalParensLeft")]
        BoundingBox AccidentalParensLeft { get; set; }

        [DataMember(Name="accidentalParensRight")]
        BoundingBox AccidentalParensRight { get; set; }

        [DataMember(Name="accidentalQuarterFlatEqualTempered")]
        BoundingBox AccidentalQuarterFlatEqualTempered { get; set; }

        [DataMember(Name="accidentalQuarterSharpEqualTempered")]
        BoundingBox AccidentalQuarterSharpEqualTempered { get; set; }

        [DataMember(Name="accidentalQuarterToneFlat4")]
        BoundingBox AccidentalQuarterToneFlat4 { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatArabic")]
        BoundingBox AccidentalQuarterToneFlatArabic { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatArrowUp")]
        BoundingBox AccidentalQuarterToneFlatArrowUp { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatFilledReversed")]
        BoundingBox AccidentalQuarterToneFlatFilledReversed { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatNaturalArrowDown")]
        BoundingBox AccidentalQuarterToneFlatNaturalArrowDown { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatPenderecki")]
        BoundingBox AccidentalQuarterToneFlatPenderecki { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatStein")]
        BoundingBox AccidentalQuarterToneFlatStein { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatVanBlankenburg")]
        BoundingBox AccidentalQuarterToneFlatVanBlankenburg { get; set; }

        [DataMember(Name="accidentalQuarterToneSharp4")]
        BoundingBox AccidentalQuarterToneSharp4 { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpArabic")]
        BoundingBox AccidentalQuarterToneSharpArabic { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpArrowDown")]
        BoundingBox AccidentalQuarterToneSharpArrowDown { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpBusotti")]
        BoundingBox AccidentalQuarterToneSharpBusotti { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpNaturalArrowUp")]
        BoundingBox AccidentalQuarterToneSharpNaturalArrowUp { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpStein")]
        BoundingBox AccidentalQuarterToneSharpStein { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpWiggle")]
        BoundingBox AccidentalQuarterToneSharpWiggle { get; set; }

        [DataMember(Name="accidentalRaiseOneSeptimalComma")]
        BoundingBox AccidentalRaiseOneSeptimalComma { get; set; }

        [DataMember(Name="accidentalRaiseOneTridecimalQuartertone")]
        BoundingBox AccidentalRaiseOneTridecimalQuartertone { get; set; }

        [DataMember(Name="accidentalRaiseOneUndecimalQuartertone")]
        BoundingBox AccidentalRaiseOneUndecimalQuartertone { get; set; }

        [DataMember(Name="accidentalRaiseTwoSeptimalCommas")]
        BoundingBox AccidentalRaiseTwoSeptimalCommas { get; set; }

        [DataMember(Name="accidentalRaisedStockhausen")]
        BoundingBox AccidentalRaisedStockhausen { get; set; }

        [DataMember(Name="accidentalReversedFlatAndFlatArrowDown")]
        BoundingBox AccidentalReversedFlatAndFlatArrowDown { get; set; }

        [DataMember(Name="accidentalReversedFlatAndFlatArrowUp")]
        BoundingBox AccidentalReversedFlatAndFlatArrowUp { get; set; }

        [DataMember(Name="accidentalReversedFlatArrowDown")]
        BoundingBox AccidentalReversedFlatArrowDown { get; set; }

        [DataMember(Name="accidentalReversedFlatArrowUp")]
        BoundingBox AccidentalReversedFlatArrowUp { get; set; }

        [DataMember(Name="accidentalSharp")]
        BoundingBox AccidentalSharp { get; set; }

        [DataMember(Name="accidentalSharpArabic")]
        BoundingBox AccidentalSharpArabic { get; set; }

        [DataMember(Name="accidentalSharpEqualTempered")]
        BoundingBox AccidentalSharpEqualTempered { get; set; }

        [DataMember(Name="accidentalSharpJohnstonDown")]
        BoundingBox AccidentalSharpJohnstonDown { get; set; }

        [DataMember(Name="accidentalSharpJohnstonDownEl")]
        BoundingBox AccidentalSharpJohnstonDownEl { get; set; }

        [DataMember(Name="accidentalSharpJohnstonEl")]
        BoundingBox AccidentalSharpJohnstonEl { get; set; }

        [DataMember(Name="accidentalSharpJohnstonUp")]
        BoundingBox AccidentalSharpJohnstonUp { get; set; }

        [DataMember(Name="accidentalSharpJohnstonUpEl")]
        BoundingBox AccidentalSharpJohnstonUpEl { get; set; }

        [DataMember(Name="accidentalSharpLoweredStockhausen")]
        BoundingBox AccidentalSharpLoweredStockhausen { get; set; }

        [DataMember(Name="accidentalSharpOneArrowDown")]
        BoundingBox AccidentalSharpOneArrowDown { get; set; }

        [DataMember(Name="accidentalSharpOneArrowUp")]
        BoundingBox AccidentalSharpOneArrowUp { get; set; }

        [DataMember(Name="accidentalSharpOneHorizontalStroke")]
        BoundingBox AccidentalSharpOneHorizontalStroke { get; set; }

        [DataMember(Name="accidentalSharpParens")]
        BoundingBox AccidentalSharpParens { get; set; }

        [DataMember(Name="accidentalSharpRaisedStockhausen")]
        BoundingBox AccidentalSharpRaisedStockhausen { get; set; }

        [DataMember(Name="accidentalSharpRepeatedLineStockhausen")]
        BoundingBox AccidentalSharpRepeatedLineStockhausen { get; set; }

        [DataMember(Name="accidentalSharpRepeatedSpaceStockhausen")]
        BoundingBox AccidentalSharpRepeatedSpaceStockhausen { get; set; }

        [DataMember(Name="accidentalSharpReversed")]
        BoundingBox AccidentalSharpReversed { get; set; }

        [DataMember(Name="accidentalSharpSharp")]
        BoundingBox AccidentalSharpSharp { get; set; }

        [DataMember(Name="accidentalSharpSmall")]
        BoundingBox AccidentalSharpSmall { get; set; }

        [DataMember(Name="accidentalSharpThreeArrowsDown")]
        BoundingBox AccidentalSharpThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalSharpThreeArrowsUp")]
        BoundingBox AccidentalSharpThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalSharpTwoArrowsDown")]
        BoundingBox AccidentalSharpTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalSharpTwoArrowsUp")]
        BoundingBox AccidentalSharpTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalSims12Down")]
        BoundingBox AccidentalSims12Down { get; set; }

        [DataMember(Name="accidentalSims12Up")]
        BoundingBox AccidentalSims12Up { get; set; }

        [DataMember(Name="accidentalSims4Down")]
        BoundingBox AccidentalSims4Down { get; set; }

        [DataMember(Name="accidentalSims4Up")]
        BoundingBox AccidentalSims4Up { get; set; }

        [DataMember(Name="accidentalSims6Down")]
        BoundingBox AccidentalSims6Down { get; set; }

        [DataMember(Name="accidentalSims6Up")]
        BoundingBox AccidentalSims6Up { get; set; }

        [DataMember(Name="accidentalSori")]
        BoundingBox AccidentalSori { get; set; }

        [DataMember(Name="accidentalTavenerFlat")]
        BoundingBox AccidentalTavenerFlat { get; set; }

        [DataMember(Name="accidentalTavenerSharp")]
        BoundingBox AccidentalTavenerSharp { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatArabic")]
        BoundingBox AccidentalThreeQuarterTonesFlatArabic { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatArrowDown")]
        BoundingBox AccidentalThreeQuarterTonesFlatArrowDown { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatArrowUp")]
        BoundingBox AccidentalThreeQuarterTonesFlatArrowUp { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatCouper")]
        BoundingBox AccidentalThreeQuarterTonesFlatCouper { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatGrisey")]
        BoundingBox AccidentalThreeQuarterTonesFlatGrisey { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatTartini")]
        BoundingBox AccidentalThreeQuarterTonesFlatTartini { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatZimmermann")]
        BoundingBox AccidentalThreeQuarterTonesFlatZimmermann { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpArabic")]
        BoundingBox AccidentalThreeQuarterTonesSharpArabic { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpArrowDown")]
        BoundingBox AccidentalThreeQuarterTonesSharpArrowDown { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpArrowUp")]
        BoundingBox AccidentalThreeQuarterTonesSharpArrowUp { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpBusotti")]
        BoundingBox AccidentalThreeQuarterTonesSharpBusotti { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpStein")]
        BoundingBox AccidentalThreeQuarterTonesSharpStein { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpStockhausen")]
        BoundingBox AccidentalThreeQuarterTonesSharpStockhausen { get; set; }

        [DataMember(Name="accidentalTripleFlat")]
        BoundingBox AccidentalTripleFlat { get; set; }

        [DataMember(Name="accidentalTripleFlatJoinedStems")]
        BoundingBox AccidentalTripleFlatJoinedStems { get; set; }

        [DataMember(Name="accidentalTripleSharp")]
        BoundingBox AccidentalTripleSharp { get; set; }

        [DataMember(Name="accidentalTwoThirdTonesFlatFerneyhough")]
        BoundingBox AccidentalTwoThirdTonesFlatFerneyhough { get; set; }

        [DataMember(Name="accidentalTwoThirdTonesSharpFerneyhough")]
        BoundingBox AccidentalTwoThirdTonesSharpFerneyhough { get; set; }

        [DataMember(Name="accidentalWilsonMinus")]
        BoundingBox AccidentalWilsonMinus { get; set; }

        [DataMember(Name="accidentalWilsonPlus")]
        BoundingBox AccidentalWilsonPlus { get; set; }

        [DataMember(Name="accidentalWyschnegradsky10TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky10TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky10TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky10TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky11TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky11TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky11TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky11TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky1TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky1TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky1TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky1TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky2TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky2TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky2TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky2TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky3TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky3TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky3TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky3TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky4TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky4TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky4TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky4TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky5TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky5TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky5TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky5TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky6TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky6TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky6TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky6TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky7TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky7TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky7TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky7TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky8TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky8TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky8TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky8TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky9TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky9TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky9TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky9TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalXenakisOneThirdToneSharp")]
        BoundingBox AccidentalXenakisOneThirdToneSharp { get; set; }

        [DataMember(Name="accidentalXenakisTwoThirdTonesSharp")]
        BoundingBox AccidentalXenakisTwoThirdTonesSharp { get; set; }

        [DataMember(Name="analyticsChoralmelodie")]
        BoundingBox AnalyticsChoralmelodie { get; set; }

        [DataMember(Name="analyticsEndStimme")]
        BoundingBox AnalyticsEndStimme { get; set; }

        [DataMember(Name="analyticsHauptrhythmus")]
        BoundingBox AnalyticsHauptrhythmus { get; set; }

        [DataMember(Name="analyticsHauptrhythmusR")]
        BoundingBox AnalyticsHauptrhythmusR { get; set; }

        [DataMember(Name="analyticsHauptstimme")]
        BoundingBox AnalyticsHauptstimme { get; set; }

        [DataMember(Name="analyticsInversion1")]
        BoundingBox AnalyticsInversion1 { get; set; }

        [DataMember(Name="analyticsNebenstimme")]
        BoundingBox AnalyticsNebenstimme { get; set; }

        [DataMember(Name="analyticsStartStimme")]
        BoundingBox AnalyticsStartStimme { get; set; }

        [DataMember(Name="analyticsTheme")]
        BoundingBox AnalyticsTheme { get; set; }

        [DataMember(Name="analyticsTheme1")]
        BoundingBox AnalyticsTheme1 { get; set; }

        [DataMember(Name="analyticsThemeInversion")]
        BoundingBox AnalyticsThemeInversion { get; set; }

        [DataMember(Name="analyticsThemeRetrograde")]
        BoundingBox AnalyticsThemeRetrograde { get; set; }

        [DataMember(Name="analyticsThemeRetrogradeInversion")]
        BoundingBox AnalyticsThemeRetrogradeInversion { get; set; }

        [DataMember(Name="arpeggiatoDown")]
        BoundingBox ArpeggiatoDown { get; set; }

        [DataMember(Name="arpeggiatoUp")]
        BoundingBox ArpeggiatoUp { get; set; }

        [DataMember(Name="arrowBlackDown")]
        BoundingBox ArrowBlackDown { get; set; }

        [DataMember(Name="arrowBlackDownLeft")]
        BoundingBox ArrowBlackDownLeft { get; set; }

        [DataMember(Name="arrowBlackDownRight")]
        BoundingBox ArrowBlackDownRight { get; set; }

        [DataMember(Name="arrowBlackLeft")]
        BoundingBox ArrowBlackLeft { get; set; }

        [DataMember(Name="arrowBlackRight")]
        BoundingBox ArrowBlackRight { get; set; }

        [DataMember(Name="arrowBlackUp")]
        BoundingBox ArrowBlackUp { get; set; }

        [DataMember(Name="arrowBlackUpLeft")]
        BoundingBox ArrowBlackUpLeft { get; set; }

        [DataMember(Name="arrowBlackUpRight")]
        BoundingBox ArrowBlackUpRight { get; set; }

        [DataMember(Name="arrowOpenDown")]
        BoundingBox ArrowOpenDown { get; set; }

        [DataMember(Name="arrowOpenDownLeft")]
        BoundingBox ArrowOpenDownLeft { get; set; }

        [DataMember(Name="arrowOpenDownRight")]
        BoundingBox ArrowOpenDownRight { get; set; }

        [DataMember(Name="arrowOpenLeft")]
        BoundingBox ArrowOpenLeft { get; set; }

        [DataMember(Name="arrowOpenRight")]
        BoundingBox ArrowOpenRight { get; set; }

        [DataMember(Name="arrowOpenUp")]
        BoundingBox ArrowOpenUp { get; set; }

        [DataMember(Name="arrowOpenUpLeft")]
        BoundingBox ArrowOpenUpLeft { get; set; }

        [DataMember(Name="arrowOpenUpRight")]
        BoundingBox ArrowOpenUpRight { get; set; }

        [DataMember(Name="arrowWhiteDown")]
        BoundingBox ArrowWhiteDown { get; set; }

        [DataMember(Name="arrowWhiteDownLeft")]
        BoundingBox ArrowWhiteDownLeft { get; set; }

        [DataMember(Name="arrowWhiteDownRight")]
        BoundingBox ArrowWhiteDownRight { get; set; }

        [DataMember(Name="arrowWhiteLeft")]
        BoundingBox ArrowWhiteLeft { get; set; }

        [DataMember(Name="arrowWhiteRight")]
        BoundingBox ArrowWhiteRight { get; set; }

        [DataMember(Name="arrowWhiteUp")]
        BoundingBox ArrowWhiteUp { get; set; }

        [DataMember(Name="arrowWhiteUpLeft")]
        BoundingBox ArrowWhiteUpLeft { get; set; }

        [DataMember(Name="arrowWhiteUpRight")]
        BoundingBox ArrowWhiteUpRight { get; set; }

        [DataMember(Name="arrowheadBlackDown")]
        BoundingBox ArrowheadBlackDown { get; set; }

        [DataMember(Name="arrowheadBlackDownLeft")]
        BoundingBox ArrowheadBlackDownLeft { get; set; }

        [DataMember(Name="arrowheadBlackDownRight")]
        BoundingBox ArrowheadBlackDownRight { get; set; }

        [DataMember(Name="arrowheadBlackLeft")]
        BoundingBox ArrowheadBlackLeft { get; set; }

        [DataMember(Name="arrowheadBlackRight")]
        BoundingBox ArrowheadBlackRight { get; set; }

        [DataMember(Name="arrowheadBlackUp")]
        BoundingBox ArrowheadBlackUp { get; set; }

        [DataMember(Name="arrowheadBlackUpLeft")]
        BoundingBox ArrowheadBlackUpLeft { get; set; }

        [DataMember(Name="arrowheadBlackUpRight")]
        BoundingBox ArrowheadBlackUpRight { get; set; }

        [DataMember(Name="arrowheadOpenDown")]
        BoundingBox ArrowheadOpenDown { get; set; }

        [DataMember(Name="arrowheadOpenDownLeft")]
        BoundingBox ArrowheadOpenDownLeft { get; set; }

        [DataMember(Name="arrowheadOpenDownRight")]
        BoundingBox ArrowheadOpenDownRight { get; set; }

        [DataMember(Name="arrowheadOpenLeft")]
        BoundingBox ArrowheadOpenLeft { get; set; }

        [DataMember(Name="arrowheadOpenRight")]
        BoundingBox ArrowheadOpenRight { get; set; }

        [DataMember(Name="arrowheadOpenUp")]
        BoundingBox ArrowheadOpenUp { get; set; }

        [DataMember(Name="arrowheadOpenUpLeft")]
        BoundingBox ArrowheadOpenUpLeft { get; set; }

        [DataMember(Name="arrowheadOpenUpRight")]
        BoundingBox ArrowheadOpenUpRight { get; set; }

        [DataMember(Name="arrowheadWhiteDown")]
        BoundingBox ArrowheadWhiteDown { get; set; }

        [DataMember(Name="arrowheadWhiteDownLeft")]
        BoundingBox ArrowheadWhiteDownLeft { get; set; }

        [DataMember(Name="arrowheadWhiteDownRight")]
        BoundingBox ArrowheadWhiteDownRight { get; set; }

        [DataMember(Name="arrowheadWhiteLeft")]
        BoundingBox ArrowheadWhiteLeft { get; set; }

        [DataMember(Name="arrowheadWhiteRight")]
        BoundingBox ArrowheadWhiteRight { get; set; }

        [DataMember(Name="arrowheadWhiteUp")]
        BoundingBox ArrowheadWhiteUp { get; set; }

        [DataMember(Name="arrowheadWhiteUpLeft")]
        BoundingBox ArrowheadWhiteUpLeft { get; set; }

        [DataMember(Name="arrowheadWhiteUpRight")]
        BoundingBox ArrowheadWhiteUpRight { get; set; }

        [DataMember(Name="articAccentAbove")]
        BoundingBox ArticAccentAbove { get; set; }

        [DataMember(Name="articAccentAboveLarge")]
        BoundingBox ArticAccentAboveLarge { get; set; }

        [DataMember(Name="articAccentAboveSmall")]
        BoundingBox ArticAccentAboveSmall { get; set; }

        [DataMember(Name="articAccentBelow")]
        BoundingBox ArticAccentBelow { get; set; }

        [DataMember(Name="articAccentBelowLarge")]
        BoundingBox ArticAccentBelowLarge { get; set; }

        [DataMember(Name="articAccentBelowSmall")]
        BoundingBox ArticAccentBelowSmall { get; set; }

        [DataMember(Name="articAccentStaccatoAbove")]
        BoundingBox ArticAccentStaccatoAbove { get; set; }

        [DataMember(Name="articAccentStaccatoAboveSmall")]
        BoundingBox ArticAccentStaccatoAboveSmall { get; set; }

        [DataMember(Name="articAccentStaccatoBelow")]
        BoundingBox ArticAccentStaccatoBelow { get; set; }

        [DataMember(Name="articAccentStaccatoBelowSmall")]
        BoundingBox ArticAccentStaccatoBelowSmall { get; set; }

        [DataMember(Name="articLaissezVibrerAbove")]
        BoundingBox ArticLaissezVibrerAbove { get; set; }

        [DataMember(Name="articLaissezVibrerBelow")]
        BoundingBox ArticLaissezVibrerBelow { get; set; }

        [DataMember(Name="articMarcatoAbove")]
        BoundingBox ArticMarcatoAbove { get; set; }

        [DataMember(Name="articMarcatoAboveSmall")]
        BoundingBox ArticMarcatoAboveSmall { get; set; }

        [DataMember(Name="articMarcatoBelow")]
        BoundingBox ArticMarcatoBelow { get; set; }

        [DataMember(Name="articMarcatoBelowSmall")]
        BoundingBox ArticMarcatoBelowSmall { get; set; }

        [DataMember(Name="articMarcatoStaccatoAbove")]
        BoundingBox ArticMarcatoStaccatoAbove { get; set; }

        [DataMember(Name="articMarcatoStaccatoAboveSmall")]
        BoundingBox ArticMarcatoStaccatoAboveSmall { get; set; }

        [DataMember(Name="articMarcatoStaccatoBelow")]
        BoundingBox ArticMarcatoStaccatoBelow { get; set; }

        [DataMember(Name="articMarcatoStaccatoBelowSmall")]
        BoundingBox ArticMarcatoStaccatoBelowSmall { get; set; }

        [DataMember(Name="articMarcatoTenutoAbove")]
        BoundingBox ArticMarcatoTenutoAbove { get; set; }

        [DataMember(Name="articMarcatoTenutoBelow")]
        BoundingBox ArticMarcatoTenutoBelow { get; set; }

        [DataMember(Name="articSoftAccentAbove")]
        BoundingBox ArticSoftAccentAbove { get; set; }

        [DataMember(Name="articSoftAccentBelow")]
        BoundingBox ArticSoftAccentBelow { get; set; }

        [DataMember(Name="articSoftAccentStaccatoAbove")]
        BoundingBox ArticSoftAccentStaccatoAbove { get; set; }

        [DataMember(Name="articSoftAccentStaccatoBelow")]
        BoundingBox ArticSoftAccentStaccatoBelow { get; set; }

        [DataMember(Name="articSoftAccentTenutoAbove")]
        BoundingBox ArticSoftAccentTenutoAbove { get; set; }

        [DataMember(Name="articSoftAccentTenutoBelow")]
        BoundingBox ArticSoftAccentTenutoBelow { get; set; }

        [DataMember(Name="articSoftAccentTenutoStaccatoAbove")]
        BoundingBox ArticSoftAccentTenutoStaccatoAbove { get; set; }

        [DataMember(Name="articSoftAccentTenutoStaccatoBelow")]
        BoundingBox ArticSoftAccentTenutoStaccatoBelow { get; set; }

        [DataMember(Name="articStaccatissimoAbove")]
        BoundingBox ArticStaccatissimoAbove { get; set; }

        [DataMember(Name="articStaccatissimoAboveSmall")]
        BoundingBox ArticStaccatissimoAboveSmall { get; set; }

        [DataMember(Name="articStaccatissimoBelow")]
        BoundingBox ArticStaccatissimoBelow { get; set; }

        [DataMember(Name="articStaccatissimoBelowSmall")]
        BoundingBox ArticStaccatissimoBelowSmall { get; set; }

        [DataMember(Name="articStaccatissimoStrokeAbove")]
        BoundingBox ArticStaccatissimoStrokeAbove { get; set; }

        [DataMember(Name="articStaccatissimoStrokeAboveSmall")]
        BoundingBox ArticStaccatissimoStrokeAboveSmall { get; set; }

        [DataMember(Name="articStaccatissimoStrokeBelow")]
        BoundingBox ArticStaccatissimoStrokeBelow { get; set; }

        [DataMember(Name="articStaccatissimoStrokeBelowSmall")]
        BoundingBox ArticStaccatissimoStrokeBelowSmall { get; set; }

        [DataMember(Name="articStaccatissimoWedgeAbove")]
        BoundingBox ArticStaccatissimoWedgeAbove { get; set; }

        [DataMember(Name="articStaccatissimoWedgeAboveSmall")]
        BoundingBox ArticStaccatissimoWedgeAboveSmall { get; set; }

        [DataMember(Name="articStaccatissimoWedgeBelow")]
        BoundingBox ArticStaccatissimoWedgeBelow { get; set; }

        [DataMember(Name="articStaccatissimoWedgeBelowSmall")]
        BoundingBox ArticStaccatissimoWedgeBelowSmall { get; set; }

        [DataMember(Name="articStaccatoAbove")]
        BoundingBox ArticStaccatoAbove { get; set; }

        [DataMember(Name="articStaccatoAboveSmall")]
        BoundingBox ArticStaccatoAboveSmall { get; set; }

        [DataMember(Name="articStaccatoBelow")]
        BoundingBox ArticStaccatoBelow { get; set; }

        [DataMember(Name="articStaccatoBelowSmall")]
        BoundingBox ArticStaccatoBelowSmall { get; set; }

        [DataMember(Name="articStressAbove")]
        BoundingBox ArticStressAbove { get; set; }

        [DataMember(Name="articStressBelow")]
        BoundingBox ArticStressBelow { get; set; }

        [DataMember(Name="articTenutoAbove")]
        BoundingBox ArticTenutoAbove { get; set; }

        [DataMember(Name="articTenutoAboveSmall")]
        BoundingBox ArticTenutoAboveSmall { get; set; }

        [DataMember(Name="articTenutoAccentAbove")]
        BoundingBox ArticTenutoAccentAbove { get; set; }

        [DataMember(Name="articTenutoAccentAboveSmall")]
        BoundingBox ArticTenutoAccentAboveSmall { get; set; }

        [DataMember(Name="articTenutoAccentBelow")]
        BoundingBox ArticTenutoAccentBelow { get; set; }

        [DataMember(Name="articTenutoAccentBelowSmall")]
        BoundingBox ArticTenutoAccentBelowSmall { get; set; }

        [DataMember(Name="articTenutoBelow")]
        BoundingBox ArticTenutoBelow { get; set; }

        [DataMember(Name="articTenutoBelowSmall")]
        BoundingBox ArticTenutoBelowSmall { get; set; }

        [DataMember(Name="articTenutoStaccatoAbove")]
        BoundingBox ArticTenutoStaccatoAbove { get; set; }

        [DataMember(Name="articTenutoStaccatoAboveSmall")]
        BoundingBox ArticTenutoStaccatoAboveSmall { get; set; }

        [DataMember(Name="articTenutoStaccatoBelow")]
        BoundingBox ArticTenutoStaccatoBelow { get; set; }

        [DataMember(Name="articTenutoStaccatoBelowSmall")]
        BoundingBox ArticTenutoStaccatoBelowSmall { get; set; }

        [DataMember(Name="articUnstressAbove")]
        BoundingBox ArticUnstressAbove { get; set; }

        [DataMember(Name="articUnstressBelow")]
        BoundingBox ArticUnstressBelow { get; set; }

        [DataMember(Name="augmentationDot")]
        BoundingBox AugmentationDot { get; set; }

        [DataMember(Name="barlineDashed")]
        BoundingBox BarlineDashed { get; set; }

        [DataMember(Name="barlineDotted")]
        BoundingBox BarlineDotted { get; set; }

        [DataMember(Name="barlineDouble")]
        BoundingBox BarlineDouble { get; set; }

        [DataMember(Name="barlineFinal")]
        BoundingBox BarlineFinal { get; set; }

        [DataMember(Name="barlineHeavy")]
        BoundingBox BarlineHeavy { get; set; }

        [DataMember(Name="barlineHeavyHeavy")]
        BoundingBox BarlineHeavyHeavy { get; set; }

        [DataMember(Name="barlineReverseFinal")]
        BoundingBox BarlineReverseFinal { get; set; }

        [DataMember(Name="barlineShort")]
        BoundingBox BarlineShort { get; set; }

        [DataMember(Name="barlineSingle")]
        BoundingBox BarlineSingle { get; set; }

        [DataMember(Name="barlineTick")]
        BoundingBox BarlineTick { get; set; }

        [DataMember(Name="beamAccelRit1")]
        BoundingBox BeamAccelRit1 { get; set; }

        [DataMember(Name="beamAccelRit10")]
        BoundingBox BeamAccelRit10 { get; set; }

        [DataMember(Name="beamAccelRit11")]
        BoundingBox BeamAccelRit11 { get; set; }

        [DataMember(Name="beamAccelRit12")]
        BoundingBox BeamAccelRit12 { get; set; }

        [DataMember(Name="beamAccelRit13")]
        BoundingBox BeamAccelRit13 { get; set; }

        [DataMember(Name="beamAccelRit14")]
        BoundingBox BeamAccelRit14 { get; set; }

        [DataMember(Name="beamAccelRit15")]
        BoundingBox BeamAccelRit15 { get; set; }

        [DataMember(Name="beamAccelRit2")]
        BoundingBox BeamAccelRit2 { get; set; }

        [DataMember(Name="beamAccelRit3")]
        BoundingBox BeamAccelRit3 { get; set; }

        [DataMember(Name="beamAccelRit4")]
        BoundingBox BeamAccelRit4 { get; set; }

        [DataMember(Name="beamAccelRit5")]
        BoundingBox BeamAccelRit5 { get; set; }

        [DataMember(Name="beamAccelRit6")]
        BoundingBox BeamAccelRit6 { get; set; }

        [DataMember(Name="beamAccelRit7")]
        BoundingBox BeamAccelRit7 { get; set; }

        [DataMember(Name="beamAccelRit8")]
        BoundingBox BeamAccelRit8 { get; set; }

        [DataMember(Name="beamAccelRit9")]
        BoundingBox BeamAccelRit9 { get; set; }

        [DataMember(Name="beamAccelRitFinal")]
        BoundingBox BeamAccelRitFinal { get; set; }

        [DataMember(Name="brace")]
        BoundingBox Brace { get; set; }

        [DataMember(Name="braceFlat")]
        BoundingBox BraceFlat { get; set; }

        [DataMember(Name="braceLarge")]
        BoundingBox BraceLarge { get; set; }

        [DataMember(Name="braceLarger")]
        BoundingBox BraceLarger { get; set; }

        [DataMember(Name="braceSmall")]
        BoundingBox BraceSmall { get; set; }

        [DataMember(Name="bracket")]
        BoundingBox Bracket { get; set; }

        [DataMember(Name="bracketBottom")]
        BoundingBox BracketBottom { get; set; }

        [DataMember(Name="bracketTop")]
        BoundingBox BracketTop { get; set; }

        [DataMember(Name="brassBend")]
        BoundingBox BrassBend { get; set; }

        [DataMember(Name="brassDoitLong")]
        BoundingBox BrassDoitLong { get; set; }

        [DataMember(Name="brassDoitMedium")]
        BoundingBox BrassDoitMedium { get; set; }

        [DataMember(Name="brassDoitShort")]
        BoundingBox BrassDoitShort { get; set; }

        [DataMember(Name="brassFallLipLong")]
        BoundingBox BrassFallLipLong { get; set; }

        [DataMember(Name="brassFallLipMedium")]
        BoundingBox BrassFallLipMedium { get; set; }

        [DataMember(Name="brassFallLipShort")]
        BoundingBox BrassFallLipShort { get; set; }

        [DataMember(Name="brassFallRoughLong")]
        BoundingBox BrassFallRoughLong { get; set; }

        [DataMember(Name="brassFallRoughMedium")]
        BoundingBox BrassFallRoughMedium { get; set; }

        [DataMember(Name="brassFallRoughShort")]
        BoundingBox BrassFallRoughShort { get; set; }

        [DataMember(Name="brassFallSmoothLong")]
        BoundingBox BrassFallSmoothLong { get; set; }

        [DataMember(Name="brassFallSmoothMedium")]
        BoundingBox BrassFallSmoothMedium { get; set; }

        [DataMember(Name="brassFallSmoothShort")]
        BoundingBox BrassFallSmoothShort { get; set; }

        [DataMember(Name="brassFlip")]
        BoundingBox BrassFlip { get; set; }

        [DataMember(Name="brassHarmonMuteClosed")]
        BoundingBox BrassHarmonMuteClosed { get; set; }

        [DataMember(Name="brassHarmonMuteStemHalfLeft")]
        BoundingBox BrassHarmonMuteStemHalfLeft { get; set; }

        [DataMember(Name="brassHarmonMuteStemHalfRight")]
        BoundingBox BrassHarmonMuteStemHalfRight { get; set; }

        [DataMember(Name="brassHarmonMuteStemOpen")]
        BoundingBox BrassHarmonMuteStemOpen { get; set; }

        [DataMember(Name="brassJazzTurn")]
        BoundingBox BrassJazzTurn { get; set; }

        [DataMember(Name="brassLiftLong")]
        BoundingBox BrassLiftLong { get; set; }

        [DataMember(Name="brassLiftMedium")]
        BoundingBox BrassLiftMedium { get; set; }

        [DataMember(Name="brassLiftShort")]
        BoundingBox BrassLiftShort { get; set; }

        [DataMember(Name="brassLiftSmoothLong")]
        BoundingBox BrassLiftSmoothLong { get; set; }

        [DataMember(Name="brassLiftSmoothMedium")]
        BoundingBox BrassLiftSmoothMedium { get; set; }

        [DataMember(Name="brassLiftSmoothShort")]
        BoundingBox BrassLiftSmoothShort { get; set; }

        [DataMember(Name="brassMuteClosed")]
        BoundingBox BrassMuteClosed { get; set; }

        [DataMember(Name="brassMuteHalfClosed")]
        BoundingBox BrassMuteHalfClosed { get; set; }

        [DataMember(Name="brassMuteOpen")]
        BoundingBox BrassMuteOpen { get; set; }

        [DataMember(Name="brassPlop")]
        BoundingBox BrassPlop { get; set; }

        [DataMember(Name="brassScoop")]
        BoundingBox BrassScoop { get; set; }

        [DataMember(Name="brassSmear")]
        BoundingBox BrassSmear { get; set; }

        [DataMember(Name="brassValveTrill")]
        BoundingBox BrassValveTrill { get; set; }

        [DataMember(Name="breathMarkComma")]
        BoundingBox BreathMarkComma { get; set; }

        [DataMember(Name="breathMarkSalzedo")]
        BoundingBox BreathMarkSalzedo { get; set; }

        [DataMember(Name="breathMarkTick")]
        BoundingBox BreathMarkTick { get; set; }

        [DataMember(Name="breathMarkUpbow")]
        BoundingBox BreathMarkUpbow { get; set; }

        [DataMember(Name="bridgeClef")]
        BoundingBox BridgeClef { get; set; }

        [DataMember(Name="buzzRoll")]
        BoundingBox BuzzRoll { get; set; }

        [DataMember(Name="cClef")]
        BoundingBox CClef { get; set; }

        [DataMember(Name="cClef8vb")]
        BoundingBox CClef8Vb { get; set; }

        [DataMember(Name="cClefArrowDown")]
        BoundingBox CClefArrowDown { get; set; }

        [DataMember(Name="cClefArrowUp")]
        BoundingBox CClefArrowUp { get; set; }

        [DataMember(Name="cClefChange")]
        BoundingBox CClefChange { get; set; }

        [DataMember(Name="cClefCombining")]
        BoundingBox CClefCombining { get; set; }

        [DataMember(Name="cClefFrench")]
        BoundingBox CClefFrench { get; set; }

        [DataMember(Name="cClefFrench20C")]
        BoundingBox CClefFrench20C { get; set; }

        [DataMember(Name="cClefFrench20CChange")]
        BoundingBox CClefFrench20CChange { get; set; }

        [DataMember(Name="cClefReversed")]
        BoundingBox CClefReversed { get; set; }

        [DataMember(Name="cClefSmall")]
        BoundingBox CClefSmall { get; set; }

        [DataMember(Name="cClefSquare")]
        BoundingBox CClefSquare { get; set; }

        [DataMember(Name="caesura")]
        BoundingBox Caesura { get; set; }

        [DataMember(Name="caesuraCurved")]
        BoundingBox CaesuraCurved { get; set; }

        [DataMember(Name="caesuraShort")]
        BoundingBox CaesuraShort { get; set; }

        [DataMember(Name="caesuraSingleStroke")]
        BoundingBox CaesuraSingleStroke { get; set; }

        [DataMember(Name="caesuraThick")]
        BoundingBox CaesuraThick { get; set; }

        [DataMember(Name="chantAccentusAbove")]
        BoundingBox ChantAccentusAbove { get; set; }

        [DataMember(Name="chantAccentusBelow")]
        BoundingBox ChantAccentusBelow { get; set; }

        [DataMember(Name="chantAuctumAsc")]
        BoundingBox ChantAuctumAsc { get; set; }

        [DataMember(Name="chantAuctumDesc")]
        BoundingBox ChantAuctumDesc { get; set; }

        [DataMember(Name="chantAugmentum")]
        BoundingBox ChantAugmentum { get; set; }

        [DataMember(Name="chantCaesura")]
        BoundingBox ChantCaesura { get; set; }

        [DataMember(Name="chantCclef")]
        BoundingBox ChantCclef { get; set; }

        [DataMember(Name="chantCclefHufnagel")]
        BoundingBox ChantCclefHufnagel { get; set; }

        [DataMember(Name="chantCirculusAbove")]
        BoundingBox ChantCirculusAbove { get; set; }

        [DataMember(Name="chantCirculusBelow")]
        BoundingBox ChantCirculusBelow { get; set; }

        [DataMember(Name="chantConnectingLineAsc2nd")]
        BoundingBox ChantConnectingLineAsc2Nd { get; set; }

        [DataMember(Name="chantConnectingLineAsc3rd")]
        BoundingBox ChantConnectingLineAsc3Rd { get; set; }

        [DataMember(Name="chantConnectingLineAsc4th")]
        BoundingBox ChantConnectingLineAsc4Th { get; set; }

        [DataMember(Name="chantConnectingLineAsc5th")]
        BoundingBox ChantConnectingLineAsc5Th { get; set; }

        [DataMember(Name="chantConnectingLineAsc6th")]
        BoundingBox ChantConnectingLineAsc6Th { get; set; }

        [DataMember(Name="chantCustosStemDownPosHigh")]
        BoundingBox ChantCustosStemDownPosHigh { get; set; }

        [DataMember(Name="chantCustosStemDownPosHighest")]
        BoundingBox ChantCustosStemDownPosHighest { get; set; }

        [DataMember(Name="chantCustosStemDownPosMiddle")]
        BoundingBox ChantCustosStemDownPosMiddle { get; set; }

        [DataMember(Name="chantCustosStemUpPosLow")]
        BoundingBox ChantCustosStemUpPosLow { get; set; }

        [DataMember(Name="chantCustosStemUpPosLowest")]
        BoundingBox ChantCustosStemUpPosLowest { get; set; }

        [DataMember(Name="chantCustosStemUpPosMiddle")]
        BoundingBox ChantCustosStemUpPosMiddle { get; set; }

        [DataMember(Name="chantDeminutumLower")]
        BoundingBox ChantDeminutumLower { get; set; }

        [DataMember(Name="chantDeminutumUpper")]
        BoundingBox ChantDeminutumUpper { get; set; }

        [DataMember(Name="chantDivisioFinalis")]
        BoundingBox ChantDivisioFinalis { get; set; }

        [DataMember(Name="chantDivisioMaior")]
        BoundingBox ChantDivisioMaior { get; set; }

        [DataMember(Name="chantDivisioMaxima")]
        BoundingBox ChantDivisioMaxima { get; set; }

        [DataMember(Name="chantDivisioMinima")]
        BoundingBox ChantDivisioMinima { get; set; }

        [DataMember(Name="chantEntryLineAsc2nd")]
        BoundingBox ChantEntryLineAsc2Nd { get; set; }

        [DataMember(Name="chantEntryLineAsc3rd")]
        BoundingBox ChantEntryLineAsc3Rd { get; set; }

        [DataMember(Name="chantEntryLineAsc4th")]
        BoundingBox ChantEntryLineAsc4Th { get; set; }

        [DataMember(Name="chantEntryLineAsc5th")]
        BoundingBox ChantEntryLineAsc5Th { get; set; }

        [DataMember(Name="chantEntryLineAsc6th")]
        BoundingBox ChantEntryLineAsc6Th { get; set; }

        [DataMember(Name="chantEpisema")]
        BoundingBox ChantEpisema { get; set; }

        [DataMember(Name="chantFclef")]
        BoundingBox ChantFclef { get; set; }

        [DataMember(Name="chantFclefHufnagel")]
        BoundingBox ChantFclefHufnagel { get; set; }

        [DataMember(Name="chantIctusAbove")]
        BoundingBox ChantIctusAbove { get; set; }

        [DataMember(Name="chantIctusBelow")]
        BoundingBox ChantIctusBelow { get; set; }

        [DataMember(Name="chantLigaturaDesc2nd")]
        BoundingBox ChantLigaturaDesc2Nd { get; set; }

        [DataMember(Name="chantLigaturaDesc3rd")]
        BoundingBox ChantLigaturaDesc3Rd { get; set; }

        [DataMember(Name="chantLigaturaDesc4th")]
        BoundingBox ChantLigaturaDesc4Th { get; set; }

        [DataMember(Name="chantLigaturaDesc5th")]
        BoundingBox ChantLigaturaDesc5Th { get; set; }

        [DataMember(Name="chantOriscusAscending")]
        BoundingBox ChantOriscusAscending { get; set; }

        [DataMember(Name="chantOriscusDescending")]
        BoundingBox ChantOriscusDescending { get; set; }

        [DataMember(Name="chantOriscusLiquescens")]
        BoundingBox ChantOriscusLiquescens { get; set; }

        [DataMember(Name="chantPodatusLower")]
        BoundingBox ChantPodatusLower { get; set; }

        [DataMember(Name="chantPodatusUpper")]
        BoundingBox ChantPodatusUpper { get; set; }

        [DataMember(Name="chantPunctum")]
        BoundingBox ChantPunctum { get; set; }

        [DataMember(Name="chantPunctumCavum")]
        BoundingBox ChantPunctumCavum { get; set; }

        [DataMember(Name="chantPunctumDeminutum")]
        BoundingBox ChantPunctumDeminutum { get; set; }

        [DataMember(Name="chantPunctumInclinatum")]
        BoundingBox ChantPunctumInclinatum { get; set; }

        [DataMember(Name="chantPunctumInclinatumAuctum")]
        BoundingBox ChantPunctumInclinatumAuctum { get; set; }

        [DataMember(Name="chantPunctumInclinatumDeminutum")]
        BoundingBox ChantPunctumInclinatumDeminutum { get; set; }

        [DataMember(Name="chantPunctumLinea")]
        BoundingBox ChantPunctumLinea { get; set; }

        [DataMember(Name="chantPunctumLineaCavum")]
        BoundingBox ChantPunctumLineaCavum { get; set; }

        [DataMember(Name="chantPunctumVirga")]
        BoundingBox ChantPunctumVirga { get; set; }

        [DataMember(Name="chantPunctumVirgaReversed")]
        BoundingBox ChantPunctumVirgaReversed { get; set; }

        [DataMember(Name="chantQuilisma")]
        BoundingBox ChantQuilisma { get; set; }

        [DataMember(Name="chantSemicirculusAbove")]
        BoundingBox ChantSemicirculusAbove { get; set; }

        [DataMember(Name="chantSemicirculusBelow")]
        BoundingBox ChantSemicirculusBelow { get; set; }

        [DataMember(Name="chantStaff")]
        BoundingBox ChantStaff { get; set; }

        [DataMember(Name="chantStaffNarrow")]
        BoundingBox ChantStaffNarrow { get; set; }

        [DataMember(Name="chantStaffWide")]
        BoundingBox ChantStaffWide { get; set; }

        [DataMember(Name="chantStrophicus")]
        BoundingBox ChantStrophicus { get; set; }

        [DataMember(Name="chantStrophicusAuctus")]
        BoundingBox ChantStrophicusAuctus { get; set; }

        [DataMember(Name="chantStrophicusLiquescens2nd")]
        BoundingBox ChantStrophicusLiquescens2Nd { get; set; }

        [DataMember(Name="chantStrophicusLiquescens3rd")]
        BoundingBox ChantStrophicusLiquescens3Rd { get; set; }

        [DataMember(Name="chantStrophicusLiquescens4th")]
        BoundingBox ChantStrophicusLiquescens4Th { get; set; }

        [DataMember(Name="chantStrophicusLiquescens5th")]
        BoundingBox ChantStrophicusLiquescens5Th { get; set; }

        [DataMember(Name="chantVirgula")]
        BoundingBox ChantVirgula { get; set; }

        [DataMember(Name="clef15")]
        BoundingBox Clef15 { get; set; }

        [DataMember(Name="clef8")]
        BoundingBox Clef8 { get; set; }

        [DataMember(Name="coda")]
        BoundingBox Coda { get; set; }

        [DataMember(Name="codaJapanese")]
        BoundingBox CodaJapanese { get; set; }

        [DataMember(Name="codaSquare")]
        BoundingBox CodaSquare { get; set; }

        [DataMember(Name="conductorBeat2Compound")]
        BoundingBox ConductorBeat2Compound { get; set; }

        [DataMember(Name="conductorBeat2Simple")]
        BoundingBox ConductorBeat2Simple { get; set; }

        [DataMember(Name="conductorBeat3Compound")]
        BoundingBox ConductorBeat3Compound { get; set; }

        [DataMember(Name="conductorBeat3Simple")]
        BoundingBox ConductorBeat3Simple { get; set; }

        [DataMember(Name="conductorBeat4Compound")]
        BoundingBox ConductorBeat4Compound { get; set; }

        [DataMember(Name="conductorBeat4Simple")]
        BoundingBox ConductorBeat4Simple { get; set; }

        [DataMember(Name="conductorLeftBeat")]
        BoundingBox ConductorLeftBeat { get; set; }

        [DataMember(Name="conductorRightBeat")]
        BoundingBox ConductorRightBeat { get; set; }

        [DataMember(Name="conductorStrongBeat")]
        BoundingBox ConductorStrongBeat { get; set; }

        [DataMember(Name="conductorUnconducted")]
        BoundingBox ConductorUnconducted { get; set; }

        [DataMember(Name="conductorWeakBeat")]
        BoundingBox ConductorWeakBeat { get; set; }

        [DataMember(Name="csymAugmented")]
        BoundingBox CsymAugmented { get; set; }

        [DataMember(Name="csymBracketLeftTall")]
        BoundingBox CsymBracketLeftTall { get; set; }

        [DataMember(Name="csymBracketRightTall")]
        BoundingBox CsymBracketRightTall { get; set; }

        [DataMember(Name="csymDiminished")]
        BoundingBox CsymDiminished { get; set; }

        [DataMember(Name="csymHalfDiminished")]
        BoundingBox CsymHalfDiminished { get; set; }

        [DataMember(Name="csymMajorSeventh")]
        BoundingBox CsymMajorSeventh { get; set; }

        [DataMember(Name="csymMinor")]
        BoundingBox CsymMinor { get; set; }

        [DataMember(Name="csymParensLeftTall")]
        BoundingBox CsymParensLeftTall { get; set; }

        [DataMember(Name="csymParensRightTall")]
        BoundingBox CsymParensRightTall { get; set; }

        [DataMember(Name="curlewSign")]
        BoundingBox CurlewSign { get; set; }

        [DataMember(Name="daCapo")]
        BoundingBox DaCapo { get; set; }

        [DataMember(Name="dalSegno")]
        BoundingBox DalSegno { get; set; }

        [DataMember(Name="daseianExcellentes1")]
        BoundingBox DaseianExcellentes1 { get; set; }

        [DataMember(Name="daseianExcellentes2")]
        BoundingBox DaseianExcellentes2 { get; set; }

        [DataMember(Name="daseianExcellentes3")]
        BoundingBox DaseianExcellentes3 { get; set; }

        [DataMember(Name="daseianExcellentes4")]
        BoundingBox DaseianExcellentes4 { get; set; }

        [DataMember(Name="daseianFinales1")]
        BoundingBox DaseianFinales1 { get; set; }

        [DataMember(Name="daseianFinales2")]
        BoundingBox DaseianFinales2 { get; set; }

        [DataMember(Name="daseianFinales3")]
        BoundingBox DaseianFinales3 { get; set; }

        [DataMember(Name="daseianFinales4")]
        BoundingBox DaseianFinales4 { get; set; }

        [DataMember(Name="daseianGraves1")]
        BoundingBox DaseianGraves1 { get; set; }

        [DataMember(Name="daseianGraves2")]
        BoundingBox DaseianGraves2 { get; set; }

        [DataMember(Name="daseianGraves3")]
        BoundingBox DaseianGraves3 { get; set; }

        [DataMember(Name="daseianGraves4")]
        BoundingBox DaseianGraves4 { get; set; }

        [DataMember(Name="daseianResidua1")]
        BoundingBox DaseianResidua1 { get; set; }

        [DataMember(Name="daseianResidua2")]
        BoundingBox DaseianResidua2 { get; set; }

        [DataMember(Name="daseianSuperiores1")]
        BoundingBox DaseianSuperiores1 { get; set; }

        [DataMember(Name="daseianSuperiores2")]
        BoundingBox DaseianSuperiores2 { get; set; }

        [DataMember(Name="daseianSuperiores3")]
        BoundingBox DaseianSuperiores3 { get; set; }

        [DataMember(Name="daseianSuperiores4")]
        BoundingBox DaseianSuperiores4 { get; set; }

        [DataMember(Name="doubleTongueAbove")]
        BoundingBox DoubleTongueAbove { get; set; }

        [DataMember(Name="doubleTongueAboveNoSlur")]
        BoundingBox DoubleTongueAboveNoSlur { get; set; }

        [DataMember(Name="doubleTongueBelow")]
        BoundingBox DoubleTongueBelow { get; set; }

        [DataMember(Name="doubleTongueBelowNoSlur")]
        BoundingBox DoubleTongueBelowNoSlur { get; set; }

        [DataMember(Name="dynamicCombinedSeparatorColon")]
        BoundingBox DynamicCombinedSeparatorColon { get; set; }

        [DataMember(Name="dynamicCombinedSeparatorHyphen")]
        BoundingBox DynamicCombinedSeparatorHyphen { get; set; }

        [DataMember(Name="dynamicCrescendoHairpin")]
        BoundingBox DynamicCrescendoHairpin { get; set; }

        [DataMember(Name="dynamicDiminuendoHairpin")]
        BoundingBox DynamicDiminuendoHairpin { get; set; }

        [DataMember(Name="dynamicFF")]
        BoundingBox DynamicFf { get; set; }

        [DataMember(Name="dynamicFFF")]
        BoundingBox DynamicFff { get; set; }

        [DataMember(Name="dynamicFFFF")]
        BoundingBox DynamicFfff { get; set; }

        [DataMember(Name="dynamicFFFFF")]
        BoundingBox DynamicFffff { get; set; }

        [DataMember(Name="dynamicFFFFFF")]
        BoundingBox DynamicFfffff { get; set; }

        [DataMember(Name="dynamicForte")]
        BoundingBox DynamicForte { get; set; }

        [DataMember(Name="dynamicFortePiano")]
        BoundingBox DynamicFortePiano { get; set; }

        [DataMember(Name="dynamicForteSmall")]
        BoundingBox DynamicForteSmall { get; set; }

        [DataMember(Name="dynamicForzando")]
        BoundingBox DynamicForzando { get; set; }

        [DataMember(Name="dynamicHairpinBracketLeft")]
        BoundingBox DynamicHairpinBracketLeft { get; set; }

        [DataMember(Name="dynamicHairpinBracketRight")]
        BoundingBox DynamicHairpinBracketRight { get; set; }

        [DataMember(Name="dynamicHairpinParenthesisLeft")]
        BoundingBox DynamicHairpinParenthesisLeft { get; set; }

        [DataMember(Name="dynamicHairpinParenthesisRight")]
        BoundingBox DynamicHairpinParenthesisRight { get; set; }

        [DataMember(Name="dynamicMF")]
        BoundingBox DynamicMf { get; set; }

        [DataMember(Name="dynamicMP")]
        BoundingBox DynamicMp { get; set; }

        [DataMember(Name="dynamicMessaDiVoce")]
        BoundingBox DynamicMessaDiVoce { get; set; }

        [DataMember(Name="dynamicMezzo")]
        BoundingBox DynamicMezzo { get; set; }

        [DataMember(Name="dynamicMezzoSmall")]
        BoundingBox DynamicMezzoSmall { get; set; }

        [DataMember(Name="dynamicNiente")]
        BoundingBox DynamicNiente { get; set; }

        [DataMember(Name="dynamicNienteForHairpin")]
        BoundingBox DynamicNienteForHairpin { get; set; }

        [DataMember(Name="dynamicNienteSmall")]
        BoundingBox DynamicNienteSmall { get; set; }

        [DataMember(Name="dynamicPF")]
        BoundingBox DynamicPf { get; set; }

        [DataMember(Name="dynamicPP")]
        BoundingBox DynamicPp { get; set; }

        [DataMember(Name="dynamicPPP")]
        BoundingBox DynamicPpp { get; set; }

        [DataMember(Name="dynamicPPPP")]
        BoundingBox DynamicPppp { get; set; }

        [DataMember(Name="dynamicPPPPP")]
        BoundingBox DynamicPpppp { get; set; }

        [DataMember(Name="dynamicPPPPPP")]
        BoundingBox DynamicPppppp { get; set; }

        [DataMember(Name="dynamicPiano")]
        BoundingBox DynamicPiano { get; set; }

        [DataMember(Name="dynamicPianoSmall")]
        BoundingBox DynamicPianoSmall { get; set; }

        [DataMember(Name="dynamicRinforzando")]
        BoundingBox DynamicRinforzando { get; set; }

        [DataMember(Name="dynamicRinforzando1")]
        BoundingBox DynamicRinforzando1 { get; set; }

        [DataMember(Name="dynamicRinforzando2")]
        BoundingBox DynamicRinforzando2 { get; set; }

        [DataMember(Name="dynamicRinforzandoSmall")]
        BoundingBox DynamicRinforzandoSmall { get; set; }

        [DataMember(Name="dynamicSforzando")]
        BoundingBox DynamicSforzando { get; set; }

        [DataMember(Name="dynamicSforzando1")]
        BoundingBox DynamicSforzando1 { get; set; }

        [DataMember(Name="dynamicSforzandoPianissimo")]
        BoundingBox DynamicSforzandoPianissimo { get; set; }

        [DataMember(Name="dynamicSforzandoPiano")]
        BoundingBox DynamicSforzandoPiano { get; set; }

        [DataMember(Name="dynamicSforzandoSmall")]
        BoundingBox DynamicSforzandoSmall { get; set; }

        [DataMember(Name="dynamicSforzato")]
        BoundingBox DynamicSforzato { get; set; }

        [DataMember(Name="dynamicSforzatoFF")]
        BoundingBox DynamicSforzatoFf { get; set; }

        [DataMember(Name="dynamicSforzatoPiano")]
        BoundingBox DynamicSforzatoPiano { get; set; }

        [DataMember(Name="dynamicZ")]
        BoundingBox DynamicZ { get; set; }

        [DataMember(Name="dynamicZSmall")]
        BoundingBox DynamicZSmall { get; set; }

        [DataMember(Name="elecAudioChannelsEight")]
        BoundingBox ElecAudioChannelsEight { get; set; }

        [DataMember(Name="elecAudioChannelsFive")]
        BoundingBox ElecAudioChannelsFive { get; set; }

        [DataMember(Name="elecAudioChannelsFour")]
        BoundingBox ElecAudioChannelsFour { get; set; }

        [DataMember(Name="elecAudioChannelsOne")]
        BoundingBox ElecAudioChannelsOne { get; set; }

        [DataMember(Name="elecAudioChannelsSeven")]
        BoundingBox ElecAudioChannelsSeven { get; set; }

        [DataMember(Name="elecAudioChannelsSix")]
        BoundingBox ElecAudioChannelsSix { get; set; }

        [DataMember(Name="elecAudioChannelsThreeFrontal")]
        BoundingBox ElecAudioChannelsThreeFrontal { get; set; }

        [DataMember(Name="elecAudioChannelsThreeSurround")]
        BoundingBox ElecAudioChannelsThreeSurround { get; set; }

        [DataMember(Name="elecAudioChannelsTwo")]
        BoundingBox ElecAudioChannelsTwo { get; set; }

        [DataMember(Name="elecAudioIn")]
        BoundingBox ElecAudioIn { get; set; }

        [DataMember(Name="elecAudioMono")]
        BoundingBox ElecAudioMono { get; set; }

        [DataMember(Name="elecAudioOut")]
        BoundingBox ElecAudioOut { get; set; }

        [DataMember(Name="elecAudioStereo")]
        BoundingBox ElecAudioStereo { get; set; }

        [DataMember(Name="elecCamera")]
        BoundingBox ElecCamera { get; set; }

        [DataMember(Name="elecDataIn")]
        BoundingBox ElecDataIn { get; set; }

        [DataMember(Name="elecDataOut")]
        BoundingBox ElecDataOut { get; set; }

        [DataMember(Name="elecDisc")]
        Dictionary<string, long[]> ElecDisc { get; set; }

        [DataMember(Name="elecDownload")]
        BoundingBox ElecDownload { get; set; }

        [DataMember(Name="elecEject")]
        BoundingBox ElecEject { get; set; }

        [DataMember(Name="elecFastForward")]
        BoundingBox ElecFastForward { get; set; }

        [DataMember(Name="elecHeadphones")]
        BoundingBox ElecHeadphones { get; set; }

        [DataMember(Name="elecHeadset")]
        BoundingBox ElecHeadset { get; set; }

        [DataMember(Name="elecLineIn")]
        BoundingBox ElecLineIn { get; set; }

        [DataMember(Name="elecLineOut")]
        BoundingBox ElecLineOut { get; set; }

        [DataMember(Name="elecLoop")]
        BoundingBox ElecLoop { get; set; }

        [DataMember(Name="elecLoudspeaker")]
        BoundingBox ElecLoudspeaker { get; set; }

        [DataMember(Name="elecMIDIController0")]
        BoundingBox ElecMidiController0 { get; set; }

        [DataMember(Name="elecMIDIController100")]
        BoundingBox ElecMidiController100 { get; set; }

        [DataMember(Name="elecMIDIController20")]
        BoundingBox ElecMidiController20 { get; set; }

        [DataMember(Name="elecMIDIController40")]
        BoundingBox ElecMidiController40 { get; set; }

        [DataMember(Name="elecMIDIController60")]
        BoundingBox ElecMidiController60 { get; set; }

        [DataMember(Name="elecMIDIController80")]
        BoundingBox ElecMidiController80 { get; set; }

        [DataMember(Name="elecMIDIIn")]
        BoundingBox ElecMidiIn { get; set; }

        [DataMember(Name="elecMIDIOut")]
        BoundingBox ElecMidiOut { get; set; }

        [DataMember(Name="elecMicrophone")]
        BoundingBox ElecMicrophone { get; set; }

        [DataMember(Name="elecMicrophoneMute")]
        BoundingBox ElecMicrophoneMute { get; set; }

        [DataMember(Name="elecMicrophoneUnmute")]
        BoundingBox ElecMicrophoneUnmute { get; set; }

        [DataMember(Name="elecMixingConsole")]
        BoundingBox ElecMixingConsole { get; set; }

        [DataMember(Name="elecMonitor")]
        BoundingBox ElecMonitor { get; set; }

        [DataMember(Name="elecMute")]
        BoundingBox ElecMute { get; set; }

        [DataMember(Name="elecPause")]
        BoundingBox ElecPause { get; set; }

        [DataMember(Name="elecPlay")]
        BoundingBox ElecPlay { get; set; }

        [DataMember(Name="elecPowerOnOff")]
        BoundingBox ElecPowerOnOff { get; set; }

        [DataMember(Name="elecProjector")]
        BoundingBox ElecProjector { get; set; }

        [DataMember(Name="elecReplay")]
        BoundingBox ElecReplay { get; set; }

        [DataMember(Name="elecRewind")]
        BoundingBox ElecRewind { get; set; }

        [DataMember(Name="elecShuffle")]
        BoundingBox ElecShuffle { get; set; }

        [DataMember(Name="elecSkipBackwards")]
        BoundingBox ElecSkipBackwards { get; set; }

        [DataMember(Name="elecSkipForwards")]
        BoundingBox ElecSkipForwards { get; set; }

        [DataMember(Name="elecStop")]
        BoundingBox ElecStop { get; set; }

        [DataMember(Name="elecTape")]
        BoundingBox ElecTape { get; set; }

        [DataMember(Name="elecUSB")]
        BoundingBox ElecUsb { get; set; }

        [DataMember(Name="elecUnmute")]
        BoundingBox ElecUnmute { get; set; }

        [DataMember(Name="elecUpload")]
        BoundingBox ElecUpload { get; set; }

        [DataMember(Name="elecVideoCamera")]
        BoundingBox ElecVideoCamera { get; set; }

        [DataMember(Name="elecVideoIn")]
        BoundingBox ElecVideoIn { get; set; }

        [DataMember(Name="elecVideoOut")]
        BoundingBox ElecVideoOut { get; set; }

        [DataMember(Name="elecVolumeFader")]
        BoundingBox ElecVolumeFader { get; set; }

        [DataMember(Name="elecVolumeFaderThumb")]
        BoundingBox ElecVolumeFaderThumb { get; set; }

        [DataMember(Name="elecVolumeLevel0")]
        BoundingBox ElecVolumeLevel0 { get; set; }

        [DataMember(Name="elecVolumeLevel100")]
        BoundingBox ElecVolumeLevel100 { get; set; }

        [DataMember(Name="elecVolumeLevel20")]
        BoundingBox ElecVolumeLevel20 { get; set; }

        [DataMember(Name="elecVolumeLevel40")]
        BoundingBox ElecVolumeLevel40 { get; set; }

        [DataMember(Name="elecVolumeLevel60")]
        BoundingBox ElecVolumeLevel60 { get; set; }

        [DataMember(Name="elecVolumeLevel80")]
        BoundingBox ElecVolumeLevel80 { get; set; }

        [DataMember(Name="fClef")]
        BoundingBox FClef { get; set; }

        [DataMember(Name="fClef15ma")]
        BoundingBox FClef15Ma { get; set; }

        [DataMember(Name="fClef15mb")]
        BoundingBox FClef15Mb { get; set; }

        [DataMember(Name="fClef19thCentury")]
        BoundingBox FClef19ThCentury { get; set; }

        [DataMember(Name="fClef5Below")]
        BoundingBox FClef5Below { get; set; }

        [DataMember(Name="fClef8va")]
        BoundingBox FClef8Va { get; set; }

        [DataMember(Name="fClef8vb")]
        BoundingBox FClef8Vb { get; set; }

        [DataMember(Name="fClefArrowDown")]
        BoundingBox FClefArrowDown { get; set; }

        [DataMember(Name="fClefArrowUp")]
        BoundingBox FClefArrowUp { get; set; }

        [DataMember(Name="fClefChange")]
        BoundingBox FClefChange { get; set; }

        [DataMember(Name="fClefFrench")]
        BoundingBox FClefFrench { get; set; }

        [DataMember(Name="fClefReversed")]
        BoundingBox FClefReversed { get; set; }

        [DataMember(Name="fClefSmall")]
        BoundingBox FClefSmall { get; set; }

        [DataMember(Name="fClefTurned")]
        BoundingBox FClefTurned { get; set; }

        [DataMember(Name="fermataAbove")]
        BoundingBox FermataAbove { get; set; }

        [DataMember(Name="fermataBelow")]
        BoundingBox FermataBelow { get; set; }

        [DataMember(Name="fermataLongAbove")]
        BoundingBox FermataLongAbove { get; set; }

        [DataMember(Name="fermataLongBelow")]
        BoundingBox FermataLongBelow { get; set; }

        [DataMember(Name="fermataLongHenzeAbove")]
        BoundingBox FermataLongHenzeAbove { get; set; }

        [DataMember(Name="fermataLongHenzeBelow")]
        BoundingBox FermataLongHenzeBelow { get; set; }

        [DataMember(Name="fermataShortAbove")]
        BoundingBox FermataShortAbove { get; set; }

        [DataMember(Name="fermataShortBelow")]
        BoundingBox FermataShortBelow { get; set; }

        [DataMember(Name="fermataShortHenzeAbove")]
        BoundingBox FermataShortHenzeAbove { get; set; }

        [DataMember(Name="fermataShortHenzeBelow")]
        BoundingBox FermataShortHenzeBelow { get; set; }

        [DataMember(Name="fermataVeryLongAbove")]
        BoundingBox FermataVeryLongAbove { get; set; }

        [DataMember(Name="fermataVeryLongBelow")]
        BoundingBox FermataVeryLongBelow { get; set; }

        [DataMember(Name="fermataVeryShortAbove")]
        BoundingBox FermataVeryShortAbove { get; set; }

        [DataMember(Name="fermataVeryShortBelow")]
        BoundingBox FermataVeryShortBelow { get; set; }

        [DataMember(Name="figbass0")]
        BoundingBox Figbass0 { get; set; }

        [DataMember(Name="figbass1")]
        BoundingBox Figbass1 { get; set; }

        [DataMember(Name="figbass2")]
        BoundingBox Figbass2 { get; set; }

        [DataMember(Name="figbass2Raised")]
        BoundingBox Figbass2Raised { get; set; }

        [DataMember(Name="figbass3")]
        BoundingBox Figbass3 { get; set; }

        [DataMember(Name="figbass4")]
        BoundingBox Figbass4 { get; set; }

        [DataMember(Name="figbass4Raised")]
        BoundingBox Figbass4Raised { get; set; }

        [DataMember(Name="figbass5")]
        BoundingBox Figbass5 { get; set; }

        [DataMember(Name="figbass5Raised1")]
        BoundingBox Figbass5Raised1 { get; set; }

        [DataMember(Name="figbass5Raised2")]
        BoundingBox Figbass5Raised2 { get; set; }

        [DataMember(Name="figbass5Raised3")]
        BoundingBox Figbass5Raised3 { get; set; }

        [DataMember(Name="figbass6")]
        BoundingBox Figbass6 { get; set; }

        [DataMember(Name="figbass6Raised")]
        BoundingBox Figbass6Raised { get; set; }

        [DataMember(Name="figbass6Raised2")]
        BoundingBox Figbass6Raised2 { get; set; }

        [DataMember(Name="figbass7")]
        BoundingBox Figbass7 { get; set; }

        [DataMember(Name="figbass7Diminished")]
        BoundingBox Figbass7Diminished { get; set; }

        [DataMember(Name="figbass7Raised1")]
        BoundingBox Figbass7Raised1 { get; set; }

        [DataMember(Name="figbass7Raised2")]
        BoundingBox Figbass7Raised2 { get; set; }

        [DataMember(Name="figbass8")]
        BoundingBox Figbass8 { get; set; }

        [DataMember(Name="figbass9")]
        BoundingBox Figbass9 { get; set; }

        [DataMember(Name="figbass9Raised")]
        BoundingBox Figbass9Raised { get; set; }

        [DataMember(Name="figbassBracketLeft")]
        BoundingBox FigbassBracketLeft { get; set; }

        [DataMember(Name="figbassBracketRight")]
        BoundingBox FigbassBracketRight { get; set; }

        [DataMember(Name="figbassCombiningLowering")]
        BoundingBox FigbassCombiningLowering { get; set; }

        [DataMember(Name="figbassCombiningRaising")]
        BoundingBox FigbassCombiningRaising { get; set; }

        [DataMember(Name="figbassDoubleFlat")]
        BoundingBox FigbassDoubleFlat { get; set; }

        [DataMember(Name="figbassDoubleSharp")]
        BoundingBox FigbassDoubleSharp { get; set; }

        [DataMember(Name="figbassFlat")]
        BoundingBox FigbassFlat { get; set; }

        [DataMember(Name="figbassNatural")]
        BoundingBox FigbassNatural { get; set; }

        [DataMember(Name="figbassParensLeft")]
        BoundingBox FigbassParensLeft { get; set; }

        [DataMember(Name="figbassParensRight")]
        BoundingBox FigbassParensRight { get; set; }

        [DataMember(Name="figbassPlus")]
        BoundingBox FigbassPlus { get; set; }

        [DataMember(Name="figbassSharp")]
        BoundingBox FigbassSharp { get; set; }

        [DataMember(Name="fingering0")]
        BoundingBox Fingering0 { get; set; }

        [DataMember(Name="fingering1")]
        BoundingBox Fingering1 { get; set; }

        [DataMember(Name="fingering2")]
        BoundingBox Fingering2 { get; set; }

        [DataMember(Name="fingering3")]
        BoundingBox Fingering3 { get; set; }

        [DataMember(Name="fingering4")]
        BoundingBox Fingering4 { get; set; }

        [DataMember(Name="fingering5")]
        BoundingBox Fingering5 { get; set; }

        [DataMember(Name="fingeringALower")]
        BoundingBox FingeringALower { get; set; }

        [DataMember(Name="fingeringCLower")]
        BoundingBox FingeringCLower { get; set; }

        [DataMember(Name="fingeringELower")]
        BoundingBox FingeringELower { get; set; }

        [DataMember(Name="fingeringILower")]
        BoundingBox FingeringILower { get; set; }

        [DataMember(Name="fingeringMLower")]
        BoundingBox FingeringMLower { get; set; }

        [DataMember(Name="fingeringMultipleNotes")]
        BoundingBox FingeringMultipleNotes { get; set; }

        [DataMember(Name="fingeringOLower")]
        BoundingBox FingeringOLower { get; set; }

        [DataMember(Name="fingeringPLower")]
        BoundingBox FingeringPLower { get; set; }

        [DataMember(Name="fingeringSubstitutionAbove")]
        BoundingBox FingeringSubstitutionAbove { get; set; }

        [DataMember(Name="fingeringSubstitutionBelow")]
        BoundingBox FingeringSubstitutionBelow { get; set; }

        [DataMember(Name="fingeringSubstitutionDash")]
        BoundingBox FingeringSubstitutionDash { get; set; }

        [DataMember(Name="fingeringTLower")]
        BoundingBox FingeringTLower { get; set; }

        [DataMember(Name="fingeringTUpper")]
        BoundingBox FingeringTUpper { get; set; }

        [DataMember(Name="fingeringXLower")]
        BoundingBox FingeringXLower { get; set; }

        [DataMember(Name="flag1024thDown")]
        BoundingBox Flag1024ThDown { get; set; }

        [DataMember(Name="flag1024thDownSmall")]
        BoundingBox Flag1024ThDownSmall { get; set; }

        [DataMember(Name="flag1024thDownStraight")]
        BoundingBox Flag1024ThDownStraight { get; set; }

        [DataMember(Name="flag1024thUp")]
        BoundingBox Flag1024ThUp { get; set; }

        [DataMember(Name="flag1024thUpShort")]
        BoundingBox Flag1024ThUpShort { get; set; }

        [DataMember(Name="flag1024thUpSmall")]
        BoundingBox Flag1024ThUpSmall { get; set; }

        [DataMember(Name="flag1024thUpStraight")]
        BoundingBox Flag1024ThUpStraight { get; set; }

        [DataMember(Name="flag128thDown")]
        BoundingBox Flag128ThDown { get; set; }

        [DataMember(Name="flag128thDownSmall")]
        BoundingBox Flag128ThDownSmall { get; set; }

        [DataMember(Name="flag128thDownStraight")]
        BoundingBox Flag128ThDownStraight { get; set; }

        [DataMember(Name="flag128thUp")]
        BoundingBox Flag128ThUp { get; set; }

        [DataMember(Name="flag128thUpShort")]
        BoundingBox Flag128ThUpShort { get; set; }

        [DataMember(Name="flag128thUpSmall")]
        BoundingBox Flag128ThUpSmall { get; set; }

        [DataMember(Name="flag128thUpStraight")]
        BoundingBox Flag128ThUpStraight { get; set; }

        [DataMember(Name="flag16thDown")]
        BoundingBox Flag16ThDown { get; set; }

        [DataMember(Name="flag16thDownSmall")]
        BoundingBox Flag16ThDownSmall { get; set; }

        [DataMember(Name="flag16thDownStraight")]
        BoundingBox Flag16ThDownStraight { get; set; }

        [DataMember(Name="flag16thUp")]
        BoundingBox Flag16ThUp { get; set; }

        [DataMember(Name="flag16thUpShort")]
        BoundingBox Flag16ThUpShort { get; set; }

        [DataMember(Name="flag16thUpSmall")]
        BoundingBox Flag16ThUpSmall { get; set; }

        [DataMember(Name="flag16thUpStraight")]
        BoundingBox Flag16ThUpStraight { get; set; }

        [DataMember(Name="flag256thDown")]
        BoundingBox Flag256ThDown { get; set; }

        [DataMember(Name="flag256thDownSmall")]
        BoundingBox Flag256ThDownSmall { get; set; }

        [DataMember(Name="flag256thDownStraight")]
        BoundingBox Flag256ThDownStraight { get; set; }

        [DataMember(Name="flag256thUp")]
        BoundingBox Flag256ThUp { get; set; }

        [DataMember(Name="flag256thUpShort")]
        BoundingBox Flag256ThUpShort { get; set; }

        [DataMember(Name="flag256thUpSmall")]
        BoundingBox Flag256ThUpSmall { get; set; }

        [DataMember(Name="flag256thUpStraight")]
        BoundingBox Flag256ThUpStraight { get; set; }

        [DataMember(Name="flag32ndDown")]
        BoundingBox Flag32NdDown { get; set; }

        [DataMember(Name="flag32ndDownSmall")]
        BoundingBox Flag32NdDownSmall { get; set; }

        [DataMember(Name="flag32ndDownStraight")]
        BoundingBox Flag32NdDownStraight { get; set; }

        [DataMember(Name="flag32ndUp")]
        BoundingBox Flag32NdUp { get; set; }

        [DataMember(Name="flag32ndUpShort")]
        BoundingBox Flag32NdUpShort { get; set; }

        [DataMember(Name="flag32ndUpSmall")]
        BoundingBox Flag32NdUpSmall { get; set; }

        [DataMember(Name="flag32ndUpStraight")]
        BoundingBox Flag32NdUpStraight { get; set; }

        [DataMember(Name="flag512thDown")]
        BoundingBox Flag512ThDown { get; set; }

        [DataMember(Name="flag512thDownSmall")]
        BoundingBox Flag512ThDownSmall { get; set; }

        [DataMember(Name="flag512thDownStraight")]
        BoundingBox Flag512ThDownStraight { get; set; }

        [DataMember(Name="flag512thUp")]
        BoundingBox Flag512ThUp { get; set; }

        [DataMember(Name="flag512thUpShort")]
        BoundingBox Flag512ThUpShort { get; set; }

        [DataMember(Name="flag512thUpSmall")]
        BoundingBox Flag512ThUpSmall { get; set; }

        [DataMember(Name="flag512thUpStraight")]
        BoundingBox Flag512ThUpStraight { get; set; }

        [DataMember(Name="flag64thDown")]
        BoundingBox Flag64ThDown { get; set; }

        [DataMember(Name="flag64thDownSmall")]
        BoundingBox Flag64ThDownSmall { get; set; }

        [DataMember(Name="flag64thDownStraight")]
        BoundingBox Flag64ThDownStraight { get; set; }

        [DataMember(Name="flag64thUp")]
        BoundingBox Flag64ThUp { get; set; }

        [DataMember(Name="flag64thUpShort")]
        BoundingBox Flag64ThUpShort { get; set; }

        [DataMember(Name="flag64thUpSmall")]
        BoundingBox Flag64ThUpSmall { get; set; }

        [DataMember(Name="flag64thUpStraight")]
        BoundingBox Flag64ThUpStraight { get; set; }

        [DataMember(Name="flag8thDown")]
        BoundingBox Flag8ThDown { get; set; }

        [DataMember(Name="flag8thDownSmall")]
        BoundingBox Flag8ThDownSmall { get; set; }

        [DataMember(Name="flag8thDownStraight")]
        BoundingBox Flag8ThDownStraight { get; set; }

        [DataMember(Name="flag8thUp")]
        BoundingBox Flag8ThUp { get; set; }

        [DataMember(Name="flag8thUpShort")]
        BoundingBox Flag8ThUpShort { get; set; }

        [DataMember(Name="flag8thUpSmall")]
        BoundingBox Flag8ThUpSmall { get; set; }

        [DataMember(Name="flag8thUpStraight")]
        BoundingBox Flag8ThUpStraight { get; set; }

        [DataMember(Name="flagInternalDown")]
        BoundingBox FlagInternalDown { get; set; }

        [DataMember(Name="flagInternalUp")]
        BoundingBox FlagInternalUp { get; set; }

        [DataMember(Name="fretboard3String")]
        BoundingBox Fretboard3String { get; set; }

        [DataMember(Name="fretboard3StringNut")]
        BoundingBox Fretboard3StringNut { get; set; }

        [DataMember(Name="fretboard4String")]
        BoundingBox Fretboard4String { get; set; }

        [DataMember(Name="fretboard4StringNut")]
        BoundingBox Fretboard4StringNut { get; set; }

        [DataMember(Name="fretboard5String")]
        BoundingBox Fretboard5String { get; set; }

        [DataMember(Name="fretboard5StringNut")]
        BoundingBox Fretboard5StringNut { get; set; }

        [DataMember(Name="fretboard6String")]
        BoundingBox Fretboard6String { get; set; }

        [DataMember(Name="fretboard6StringNut")]
        BoundingBox Fretboard6StringNut { get; set; }

        [DataMember(Name="fretboardFilledCircle")]
        BoundingBox FretboardFilledCircle { get; set; }

        [DataMember(Name="fretboardO")]
        BoundingBox FretboardO { get; set; }

        [DataMember(Name="fretboardX")]
        BoundingBox FretboardX { get; set; }

        [DataMember(Name="functionAngleLeft")]
        BoundingBox FunctionAngleLeft { get; set; }

        [DataMember(Name="functionAngleRight")]
        BoundingBox FunctionAngleRight { get; set; }

        [DataMember(Name="functionBracketLeft")]
        BoundingBox FunctionBracketLeft { get; set; }

        [DataMember(Name="functionBracketRight")]
        BoundingBox FunctionBracketRight { get; set; }

        [DataMember(Name="functionDD")]
        BoundingBox FunctionDd { get; set; }

        [DataMember(Name="functionDLower")]
        BoundingBox FunctionDLower { get; set; }

        [DataMember(Name="functionDUpper")]
        BoundingBox FunctionDUpper { get; set; }

        [DataMember(Name="functionEight")]
        BoundingBox FunctionEight { get; set; }

        [DataMember(Name="functionFUpper")]
        BoundingBox FunctionFUpper { get; set; }

        [DataMember(Name="functionFive")]
        BoundingBox FunctionFive { get; set; }

        [DataMember(Name="functionFour")]
        BoundingBox FunctionFour { get; set; }

        [DataMember(Name="functionGLower")]
        BoundingBox FunctionGLower { get; set; }

        [DataMember(Name="functionGUpper")]
        BoundingBox FunctionGUpper { get; set; }

        [DataMember(Name="functionGreaterThan")]
        BoundingBox FunctionGreaterThan { get; set; }

        [DataMember(Name="functionILower")]
        BoundingBox FunctionILower { get; set; }

        [DataMember(Name="functionIUpper")]
        BoundingBox FunctionIUpper { get; set; }

        [DataMember(Name="functionKLower")]
        BoundingBox FunctionKLower { get; set; }

        [DataMember(Name="functionKUpper")]
        BoundingBox FunctionKUpper { get; set; }

        [DataMember(Name="functionLLower")]
        BoundingBox FunctionLLower { get; set; }

        [DataMember(Name="functionLUpper")]
        BoundingBox FunctionLUpper { get; set; }

        [DataMember(Name="functionLessThan")]
        BoundingBox FunctionLessThan { get; set; }

        [DataMember(Name="functionMLower")]
        BoundingBox FunctionMLower { get; set; }

        [DataMember(Name="functionMUpper")]
        BoundingBox FunctionMUpper { get; set; }

        [DataMember(Name="functionMinus")]
        BoundingBox FunctionMinus { get; set; }

        [DataMember(Name="functionNLower")]
        BoundingBox FunctionNLower { get; set; }

        [DataMember(Name="functionNUpper")]
        BoundingBox FunctionNUpper { get; set; }

        [DataMember(Name="functionNUpperSuperscript")]
        BoundingBox FunctionNUpperSuperscript { get; set; }

        [DataMember(Name="functionNine")]
        BoundingBox FunctionNine { get; set; }

        [DataMember(Name="functionOne")]
        BoundingBox FunctionOne { get; set; }

        [DataMember(Name="functionPLower")]
        BoundingBox FunctionPLower { get; set; }

        [DataMember(Name="functionPUpper")]
        BoundingBox FunctionPUpper { get; set; }

        [DataMember(Name="functionParensLeft")]
        BoundingBox FunctionParensLeft { get; set; }

        [DataMember(Name="functionParensRight")]
        BoundingBox FunctionParensRight { get; set; }

        [DataMember(Name="functionPlus")]
        BoundingBox FunctionPlus { get; set; }

        [DataMember(Name="functionRLower")]
        BoundingBox FunctionRLower { get; set; }

        [DataMember(Name="functionRepetition1")]
        BoundingBox FunctionRepetition1 { get; set; }

        [DataMember(Name="functionRepetition2")]
        BoundingBox FunctionRepetition2 { get; set; }

        [DataMember(Name="functionRing")]
        BoundingBox FunctionRing { get; set; }

        [DataMember(Name="functionSLower")]
        BoundingBox FunctionSLower { get; set; }

        [DataMember(Name="functionSSLower")]
        BoundingBox FunctionSsLower { get; set; }

        [DataMember(Name="functionSSUpper")]
        BoundingBox FunctionSsUpper { get; set; }

        [DataMember(Name="functionSUpper")]
        BoundingBox FunctionSUpper { get; set; }

        [DataMember(Name="functionSeven")]
        BoundingBox FunctionSeven { get; set; }

        [DataMember(Name="functionSix")]
        BoundingBox FunctionSix { get; set; }

        [DataMember(Name="functionSlashedDD")]
        BoundingBox FunctionSlashedDd { get; set; }

        [DataMember(Name="functionTLower")]
        BoundingBox FunctionTLower { get; set; }

        [DataMember(Name="functionTUpper")]
        BoundingBox FunctionTUpper { get; set; }

        [DataMember(Name="functionThree")]
        BoundingBox FunctionThree { get; set; }

        [DataMember(Name="functionTwo")]
        BoundingBox FunctionTwo { get; set; }

        [DataMember(Name="functionVLower")]
        BoundingBox FunctionVLower { get; set; }

        [DataMember(Name="functionVUpper")]
        BoundingBox FunctionVUpper { get; set; }

        [DataMember(Name="functionZero")]
        BoundingBox FunctionZero { get; set; }

        [DataMember(Name="gClef")]
        BoundingBox GClef { get; set; }

        [DataMember(Name="gClef0Below")]
        BoundingBox GClef0Below { get; set; }

        [DataMember(Name="gClef10Below")]
        BoundingBox GClef10Below { get; set; }

        [DataMember(Name="gClef11Below")]
        BoundingBox GClef11Below { get; set; }

        [DataMember(Name="gClef12Below")]
        BoundingBox GClef12Below { get; set; }

        [DataMember(Name="gClef13Below")]
        BoundingBox GClef13Below { get; set; }

        [DataMember(Name="gClef14Below")]
        BoundingBox GClef14Below { get; set; }

        [DataMember(Name="gClef15Below")]
        BoundingBox GClef15Below { get; set; }

        [DataMember(Name="gClef15ma")]
        BoundingBox GClef15Ma { get; set; }

        [DataMember(Name="gClef15mb")]
        BoundingBox GClef15Mb { get; set; }

        [DataMember(Name="gClef16Below")]
        BoundingBox GClef16Below { get; set; }

        [DataMember(Name="gClef17Below")]
        BoundingBox GClef17Below { get; set; }

        [DataMember(Name="gClef2Above")]
        BoundingBox GClef2Above { get; set; }

        [DataMember(Name="gClef2Below")]
        BoundingBox GClef2Below { get; set; }

        [DataMember(Name="gClef3Above")]
        BoundingBox GClef3Above { get; set; }

        [DataMember(Name="gClef3Below")]
        BoundingBox GClef3Below { get; set; }

        [DataMember(Name="gClef4Above")]
        BoundingBox GClef4Above { get; set; }

        [DataMember(Name="gClef4Below")]
        BoundingBox GClef4Below { get; set; }

        [DataMember(Name="gClef5Above")]
        BoundingBox GClef5Above { get; set; }

        [DataMember(Name="gClef5Below")]
        BoundingBox GClef5Below { get; set; }

        [DataMember(Name="gClef6Above")]
        BoundingBox GClef6Above { get; set; }

        [DataMember(Name="gClef6Below")]
        BoundingBox GClef6Below { get; set; }

        [DataMember(Name="gClef7Above")]
        BoundingBox GClef7Above { get; set; }

        [DataMember(Name="gClef7Below")]
        BoundingBox GClef7Below { get; set; }

        [DataMember(Name="gClef8Above")]
        BoundingBox GClef8Above { get; set; }

        [DataMember(Name="gClef8Below")]
        BoundingBox GClef8Below { get; set; }

        [DataMember(Name="gClef8va")]
        BoundingBox GClef8Va { get; set; }

        [DataMember(Name="gClef8vb")]
        BoundingBox GClef8Vb { get; set; }

        [DataMember(Name="gClef8vbCClef")]
        BoundingBox GClef8VbCClef { get; set; }

        [DataMember(Name="gClef8vbOld")]
        BoundingBox GClef8VbOld { get; set; }

        [DataMember(Name="gClef8vbParens")]
        BoundingBox GClef8VbParens { get; set; }

        [DataMember(Name="gClef9Above")]
        BoundingBox GClef9Above { get; set; }

        [DataMember(Name="gClef9Below")]
        BoundingBox GClef9Below { get; set; }

        [DataMember(Name="gClefArrowDown")]
        BoundingBox GClefArrowDown { get; set; }

        [DataMember(Name="gClefArrowUp")]
        BoundingBox GClefArrowUp { get; set; }

        [DataMember(Name="gClefChange")]
        BoundingBox GClefChange { get; set; }

        [DataMember(Name="gClefFlat10Below")]
        BoundingBox GClefFlat10Below { get; set; }

        [DataMember(Name="gClefFlat11Below")]
        BoundingBox GClefFlat11Below { get; set; }

        [DataMember(Name="gClefFlat13Below")]
        BoundingBox GClefFlat13Below { get; set; }

        [DataMember(Name="gClefFlat14Below")]
        BoundingBox GClefFlat14Below { get; set; }

        [DataMember(Name="gClefFlat15Below")]
        BoundingBox GClefFlat15Below { get; set; }

        [DataMember(Name="gClefFlat16Below")]
        BoundingBox GClefFlat16Below { get; set; }

        [DataMember(Name="gClefFlat1Below")]
        BoundingBox GClefFlat1Below { get; set; }

        [DataMember(Name="gClefFlat2Above")]
        BoundingBox GClefFlat2Above { get; set; }

        [DataMember(Name="gClefFlat2Below")]
        BoundingBox GClefFlat2Below { get; set; }

        [DataMember(Name="gClefFlat3Above")]
        BoundingBox GClefFlat3Above { get; set; }

        [DataMember(Name="gClefFlat3Below")]
        BoundingBox GClefFlat3Below { get; set; }

        [DataMember(Name="gClefFlat4Below")]
        BoundingBox GClefFlat4Below { get; set; }

        [DataMember(Name="gClefFlat5Above")]
        BoundingBox GClefFlat5Above { get; set; }

        [DataMember(Name="gClefFlat6Above")]
        BoundingBox GClefFlat6Above { get; set; }

        [DataMember(Name="gClefFlat6Below")]
        BoundingBox GClefFlat6Below { get; set; }

        [DataMember(Name="gClefFlat7Above")]
        BoundingBox GClefFlat7Above { get; set; }

        [DataMember(Name="gClefFlat7Below")]
        BoundingBox GClefFlat7Below { get; set; }

        [DataMember(Name="gClefFlat8Above")]
        BoundingBox GClefFlat8Above { get; set; }

        [DataMember(Name="gClefFlat9Above")]
        BoundingBox GClefFlat9Above { get; set; }

        [DataMember(Name="gClefFlat9Below")]
        BoundingBox GClefFlat9Below { get; set; }

        [DataMember(Name="gClefLigatedNumberAbove")]
        BoundingBox GClefLigatedNumberAbove { get; set; }

        [DataMember(Name="gClefLigatedNumberBelow")]
        BoundingBox GClefLigatedNumberBelow { get; set; }

        [DataMember(Name="gClefNat2Below")]
        BoundingBox GClefNat2Below { get; set; }

        [DataMember(Name="gClefNatural10Below")]
        BoundingBox GClefNatural10Below { get; set; }

        [DataMember(Name="gClefNatural13Below")]
        BoundingBox GClefNatural13Below { get; set; }

        [DataMember(Name="gClefNatural17Below")]
        BoundingBox GClefNatural17Below { get; set; }

        [DataMember(Name="gClefNatural2Above")]
        BoundingBox GClefNatural2Above { get; set; }

        [DataMember(Name="gClefNatural3Above")]
        BoundingBox GClefNatural3Above { get; set; }

        [DataMember(Name="gClefNatural3Below")]
        BoundingBox GClefNatural3Below { get; set; }

        [DataMember(Name="gClefNatural6Above")]
        BoundingBox GClefNatural6Above { get; set; }

        [DataMember(Name="gClefNatural6Below")]
        BoundingBox GClefNatural6Below { get; set; }

        [DataMember(Name="gClefNatural7Above")]
        BoundingBox GClefNatural7Above { get; set; }

        [DataMember(Name="gClefNatural9Above")]
        BoundingBox GClefNatural9Above { get; set; }

        [DataMember(Name="gClefNatural9Below")]
        BoundingBox GClefNatural9Below { get; set; }

        [DataMember(Name="gClefReversed")]
        BoundingBox GClefReversed { get; set; }

        [DataMember(Name="gClefSharp12Below")]
        BoundingBox GClefSharp12Below { get; set; }

        [DataMember(Name="gClefSharp1Above")]
        BoundingBox GClefSharp1Above { get; set; }

        [DataMember(Name="gClefSharp4Above")]
        BoundingBox GClefSharp4Above { get; set; }

        [DataMember(Name="gClefSharp5Below")]
        BoundingBox GClefSharp5Below { get; set; }

        [DataMember(Name="gClefSmall")]
        BoundingBox GClefSmall { get; set; }

        [DataMember(Name="gClefTurned")]
        BoundingBox GClefTurned { get; set; }

        [DataMember(Name="glissandoDown")]
        BoundingBox GlissandoDown { get; set; }

        [DataMember(Name="glissandoUp")]
        BoundingBox GlissandoUp { get; set; }

        [DataMember(Name="graceNoteAcciaccaturaStemDown")]
        BoundingBox GraceNoteAcciaccaturaStemDown { get; set; }

        [DataMember(Name="graceNoteAcciaccaturaStemUp")]
        BoundingBox GraceNoteAcciaccaturaStemUp { get; set; }

        [DataMember(Name="graceNoteAppoggiaturaStemDown")]
        BoundingBox GraceNoteAppoggiaturaStemDown { get; set; }

        [DataMember(Name="graceNoteAppoggiaturaStemUp")]
        BoundingBox GraceNoteAppoggiaturaStemUp { get; set; }

        [DataMember(Name="graceNoteSlashStemDown")]
        BoundingBox GraceNoteSlashStemDown { get; set; }

        [DataMember(Name="graceNoteSlashStemUp")]
        BoundingBox GraceNoteSlashStemUp { get; set; }

        [DataMember(Name="guitarBarreFull")]
        BoundingBox GuitarBarreFull { get; set; }

        [DataMember(Name="guitarBarreHalf")]
        BoundingBox GuitarBarreHalf { get; set; }

        [DataMember(Name="guitarBarreHalfHorizontalFractionSlash")]
        BoundingBox GuitarBarreHalfHorizontalFractionSlash { get; set; }

        [DataMember(Name="guitarClosePedal")]
        BoundingBox GuitarClosePedal { get; set; }

        [DataMember(Name="guitarFadeIn")]
        BoundingBox GuitarFadeIn { get; set; }

        [DataMember(Name="guitarFadeOut")]
        BoundingBox GuitarFadeOut { get; set; }

        [DataMember(Name="guitarGolpe")]
        BoundingBox GuitarGolpe { get; set; }

        [DataMember(Name="guitarGolpeFlamenco")]
        BoundingBox GuitarGolpeFlamenco { get; set; }

        [DataMember(Name="guitarHalfOpenPedal")]
        BoundingBox GuitarHalfOpenPedal { get; set; }

        [DataMember(Name="guitarLeftHandTapping")]
        BoundingBox GuitarLeftHandTapping { get; set; }

        [DataMember(Name="guitarOpenPedal")]
        BoundingBox GuitarOpenPedal { get; set; }

        [DataMember(Name="guitarRightHandTapping")]
        BoundingBox GuitarRightHandTapping { get; set; }

        [DataMember(Name="guitarShake")]
        BoundingBox GuitarShake { get; set; }

        [DataMember(Name="guitarString0")]
        BoundingBox GuitarString0 { get; set; }

        [DataMember(Name="guitarString1")]
        BoundingBox GuitarString1 { get; set; }

        [DataMember(Name="guitarString2")]
        BoundingBox GuitarString2 { get; set; }

        [DataMember(Name="guitarString3")]
        BoundingBox GuitarString3 { get; set; }

        [DataMember(Name="guitarString4")]
        BoundingBox GuitarString4 { get; set; }

        [DataMember(Name="guitarString5")]
        BoundingBox GuitarString5 { get; set; }

        [DataMember(Name="guitarString6")]
        BoundingBox GuitarString6 { get; set; }

        [DataMember(Name="guitarString7")]
        BoundingBox GuitarString7 { get; set; }

        [DataMember(Name="guitarString8")]
        BoundingBox GuitarString8 { get; set; }

        [DataMember(Name="guitarString9")]
        BoundingBox GuitarString9 { get; set; }

        [DataMember(Name="guitarStrumDown")]
        BoundingBox GuitarStrumDown { get; set; }

        [DataMember(Name="guitarStrumUp")]
        BoundingBox GuitarStrumUp { get; set; }

        [DataMember(Name="guitarVibratoBarDip")]
        BoundingBox GuitarVibratoBarDip { get; set; }

        [DataMember(Name="guitarVibratoBarScoop")]
        BoundingBox GuitarVibratoBarScoop { get; set; }

        [DataMember(Name="guitarVibratoStroke")]
        BoundingBox GuitarVibratoStroke { get; set; }

        [DataMember(Name="guitarVolumeSwell")]
        BoundingBox GuitarVolumeSwell { get; set; }

        [DataMember(Name="guitarWideVibratoStroke")]
        BoundingBox GuitarWideVibratoStroke { get; set; }

        [DataMember(Name="handbellsBelltree")]
        BoundingBox HandbellsBelltree { get; set; }

        [DataMember(Name="handbellsDamp3")]
        BoundingBox HandbellsDamp3 { get; set; }

        [DataMember(Name="handbellsEcho1")]
        BoundingBox HandbellsEcho1 { get; set; }

        [DataMember(Name="handbellsEcho2")]
        BoundingBox HandbellsEcho2 { get; set; }

        [DataMember(Name="handbellsGyro")]
        BoundingBox HandbellsGyro { get; set; }

        [DataMember(Name="handbellsHandMartellato")]
        BoundingBox HandbellsHandMartellato { get; set; }

        [DataMember(Name="handbellsMalletBellOnTable")]
        BoundingBox HandbellsMalletBellOnTable { get; set; }

        [DataMember(Name="handbellsMalletBellSuspended")]
        BoundingBox HandbellsMalletBellSuspended { get; set; }

        [DataMember(Name="handbellsMalletLft")]
        BoundingBox HandbellsMalletLft { get; set; }

        [DataMember(Name="handbellsMartellato")]
        BoundingBox HandbellsMartellato { get; set; }

        [DataMember(Name="handbellsMartellatoLift")]
        BoundingBox HandbellsMartellatoLift { get; set; }

        [DataMember(Name="handbellsMutedMartellato")]
        BoundingBox HandbellsMutedMartellato { get; set; }

        [DataMember(Name="handbellsPluckLift")]
        BoundingBox HandbellsPluckLift { get; set; }

        [DataMember(Name="handbellsSwing")]
        BoundingBox HandbellsSwing { get; set; }

        [DataMember(Name="handbellsSwingDown")]
        BoundingBox HandbellsSwingDown { get; set; }

        [DataMember(Name="handbellsSwingUp")]
        BoundingBox HandbellsSwingUp { get; set; }

        [DataMember(Name="handbellsTablePairBells")]
        BoundingBox HandbellsTablePairBells { get; set; }

        [DataMember(Name="handbellsTableSingleBell")]
        BoundingBox HandbellsTableSingleBell { get; set; }

        [DataMember(Name="harpMetalRod")]
        BoundingBox HarpMetalRod { get; set; }

        [DataMember(Name="harpMetalRodAlt")]
        BoundingBox HarpMetalRodAlt { get; set; }

        [DataMember(Name="harpPedalCentered")]
        BoundingBox HarpPedalCentered { get; set; }

        [DataMember(Name="harpPedalDivider")]
        Dictionary<string, long[]> HarpPedalDivider { get; set; }

        [DataMember(Name="harpPedalLowered")]
        BoundingBox HarpPedalLowered { get; set; }

        [DataMember(Name="harpPedalRaised")]
        BoundingBox HarpPedalRaised { get; set; }

        [DataMember(Name="harpSalzedoAeolianAscending")]
        BoundingBox HarpSalzedoAeolianAscending { get; set; }

        [DataMember(Name="harpSalzedoAeolianDescending")]
        BoundingBox HarpSalzedoAeolianDescending { get; set; }

        [DataMember(Name="harpSalzedoDampAbove")]
        BoundingBox HarpSalzedoDampAbove { get; set; }

        [DataMember(Name="harpSalzedoDampBelow")]
        BoundingBox HarpSalzedoDampBelow { get; set; }

        [DataMember(Name="harpSalzedoDampBothHands")]
        BoundingBox HarpSalzedoDampBothHands { get; set; }

        [DataMember(Name="harpSalzedoDampLowStrings")]
        BoundingBox HarpSalzedoDampLowStrings { get; set; }

        [DataMember(Name="harpSalzedoFluidicSoundsLeft")]
        BoundingBox HarpSalzedoFluidicSoundsLeft { get; set; }

        [DataMember(Name="harpSalzedoFluidicSoundsRight")]
        BoundingBox HarpSalzedoFluidicSoundsRight { get; set; }

        [DataMember(Name="harpSalzedoIsolatedSounds")]
        BoundingBox HarpSalzedoIsolatedSounds { get; set; }

        [DataMember(Name="harpSalzedoMetallicSounds")]
        BoundingBox HarpSalzedoMetallicSounds { get; set; }

        [DataMember(Name="harpSalzedoMetallicSoundsOneString")]
        BoundingBox HarpSalzedoMetallicSoundsOneString { get; set; }

        [DataMember(Name="harpSalzedoMuffleTotally")]
        BoundingBox HarpSalzedoMuffleTotally { get; set; }

        [DataMember(Name="harpSalzedoOboicFlux")]
        BoundingBox HarpSalzedoOboicFlux { get; set; }

        [DataMember(Name="harpSalzedoPlayUpperEnd")]
        BoundingBox HarpSalzedoPlayUpperEnd { get; set; }

        [DataMember(Name="harpSalzedoSlideWithSuppleness")]
        BoundingBox HarpSalzedoSlideWithSuppleness { get; set; }

        [DataMember(Name="harpSalzedoSnareDrum")]
        Dictionary<string, long[]> HarpSalzedoSnareDrum { get; set; }

        [DataMember(Name="harpSalzedoTamTamSounds")]
        BoundingBox HarpSalzedoTamTamSounds { get; set; }

        [DataMember(Name="harpSalzedoThunderEffect")]
        BoundingBox HarpSalzedoThunderEffect { get; set; }

        [DataMember(Name="harpSalzedoTimpanicSounds")]
        BoundingBox HarpSalzedoTimpanicSounds { get; set; }

        [DataMember(Name="harpSalzedoWhistlingSounds")]
        BoundingBox HarpSalzedoWhistlingSounds { get; set; }

        [DataMember(Name="harpStringNoiseStem")]
        BoundingBox HarpStringNoiseStem { get; set; }

        [DataMember(Name="harpTuningKey")]
        BoundingBox HarpTuningKey { get; set; }

        [DataMember(Name="harpTuningKeyAlt")]
        BoundingBox HarpTuningKeyAlt { get; set; }

        [DataMember(Name="harpTuningKeyGlissando")]
        BoundingBox HarpTuningKeyGlissando { get; set; }

        [DataMember(Name="harpTuningKeyHandle")]
        BoundingBox HarpTuningKeyHandle { get; set; }

        [DataMember(Name="harpTuningKeyShank")]
        BoundingBox HarpTuningKeyShank { get; set; }

        [DataMember(Name="keyboardBebung2DotsAbove")]
        BoundingBox KeyboardBebung2DotsAbove { get; set; }

        [DataMember(Name="keyboardBebung2DotsBelow")]
        BoundingBox KeyboardBebung2DotsBelow { get; set; }

        [DataMember(Name="keyboardBebung3DotsAbove")]
        BoundingBox KeyboardBebung3DotsAbove { get; set; }

        [DataMember(Name="keyboardBebung3DotsBelow")]
        BoundingBox KeyboardBebung3DotsBelow { get; set; }

        [DataMember(Name="keyboardBebung4DotsAbove")]
        BoundingBox KeyboardBebung4DotsAbove { get; set; }

        [DataMember(Name="keyboardBebung4DotsBelow")]
        BoundingBox KeyboardBebung4DotsBelow { get; set; }

        [DataMember(Name="keyboardLeftPedalPictogram")]
        BoundingBox KeyboardLeftPedalPictogram { get; set; }

        [DataMember(Name="keyboardMiddlePedalPictogram")]
        BoundingBox KeyboardMiddlePedalPictogram { get; set; }

        [DataMember(Name="keyboardPedalD")]
        BoundingBox KeyboardPedalD { get; set; }

        [DataMember(Name="keyboardPedalDot")]
        BoundingBox KeyboardPedalDot { get; set; }

        [DataMember(Name="keyboardPedalE")]
        BoundingBox KeyboardPedalE { get; set; }

        [DataMember(Name="keyboardPedalHalf")]
        BoundingBox KeyboardPedalHalf { get; set; }

        [DataMember(Name="keyboardPedalHalf2")]
        BoundingBox KeyboardPedalHalf2 { get; set; }

        [DataMember(Name="keyboardPedalHalf3")]
        BoundingBox KeyboardPedalHalf3 { get; set; }

        [DataMember(Name="keyboardPedalHeel1")]
        BoundingBox KeyboardPedalHeel1 { get; set; }

        [DataMember(Name="keyboardPedalHeel2")]
        BoundingBox KeyboardPedalHeel2 { get; set; }

        [DataMember(Name="keyboardPedalHeel3")]
        Dictionary<string, long[]> KeyboardPedalHeel3 { get; set; }

        [DataMember(Name="keyboardPedalHeelToToe")]
        BoundingBox KeyboardPedalHeelToToe { get; set; }

        [DataMember(Name="keyboardPedalHeelToe")]
        BoundingBox KeyboardPedalHeelToe { get; set; }

        [DataMember(Name="keyboardPedalHookEnd")]
        BoundingBox KeyboardPedalHookEnd { get; set; }

        [DataMember(Name="keyboardPedalHookStart")]
        BoundingBox KeyboardPedalHookStart { get; set; }

        [DataMember(Name="keyboardPedalHyphen")]
        BoundingBox KeyboardPedalHyphen { get; set; }

        [DataMember(Name="keyboardPedalP")]
        BoundingBox KeyboardPedalP { get; set; }

        [DataMember(Name="keyboardPedalPed")]
        BoundingBox KeyboardPedalPed { get; set; }

        [DataMember(Name="keyboardPedalPedNoDot")]
        BoundingBox KeyboardPedalPedNoDot { get; set; }

        [DataMember(Name="keyboardPedalS")]
        BoundingBox KeyboardPedalS { get; set; }

        [DataMember(Name="keyboardPedalSost")]
        BoundingBox KeyboardPedalSost { get; set; }

        [DataMember(Name="keyboardPedalSostNoDot")]
        BoundingBox KeyboardPedalSostNoDot { get; set; }

        [DataMember(Name="keyboardPedalToe1")]
        BoundingBox KeyboardPedalToe1 { get; set; }

        [DataMember(Name="keyboardPedalToe2")]
        BoundingBox KeyboardPedalToe2 { get; set; }

        [DataMember(Name="keyboardPedalToeToHeel")]
        BoundingBox KeyboardPedalToeToHeel { get; set; }

        [DataMember(Name="keyboardPedalUp")]
        BoundingBox KeyboardPedalUp { get; set; }

        [DataMember(Name="keyboardPedalUpNotch")]
        BoundingBox KeyboardPedalUpNotch { get; set; }

        [DataMember(Name="keyboardPedalUpSpecial")]
        BoundingBox KeyboardPedalUpSpecial { get; set; }

        [DataMember(Name="keyboardPlayWithLH")]
        BoundingBox KeyboardPlayWithLh { get; set; }

        [DataMember(Name="keyboardPlayWithLHEnd")]
        BoundingBox KeyboardPlayWithLhEnd { get; set; }

        [DataMember(Name="keyboardPlayWithRH")]
        BoundingBox KeyboardPlayWithRh { get; set; }

        [DataMember(Name="keyboardPlayWithRHEnd")]
        BoundingBox KeyboardPlayWithRhEnd { get; set; }

        [DataMember(Name="keyboardPluckInside")]
        BoundingBox KeyboardPluckInside { get; set; }

        [DataMember(Name="keyboardRightPedalPictogram")]
        BoundingBox KeyboardRightPedalPictogram { get; set; }

        [DataMember(Name="kievanAccidentalFlat")]
        BoundingBox KievanAccidentalFlat { get; set; }

        [DataMember(Name="kievanAccidentalSharp")]
        BoundingBox KievanAccidentalSharp { get; set; }

        [DataMember(Name="kievanAugmentationDot")]
        BoundingBox KievanAugmentationDot { get; set; }

        [DataMember(Name="kievanCClef")]
        BoundingBox KievanCClef { get; set; }

        [DataMember(Name="kievanEndingSymbol")]
        BoundingBox KievanEndingSymbol { get; set; }

        [DataMember(Name="kievanNote8thStemDown")]
        BoundingBox KievanNote8ThStemDown { get; set; }

        [DataMember(Name="kievanNote8thStemUp")]
        BoundingBox KievanNote8ThStemUp { get; set; }

        [DataMember(Name="kievanNoteBeam")]
        BoundingBox KievanNoteBeam { get; set; }

        [DataMember(Name="kievanNoteHalfStaffLine")]
        BoundingBox KievanNoteHalfStaffLine { get; set; }

        [DataMember(Name="kievanNoteHalfStaffSpace")]
        BoundingBox KievanNoteHalfStaffSpace { get; set; }

        [DataMember(Name="kievanNoteQuarterStemDown")]
        BoundingBox KievanNoteQuarterStemDown { get; set; }

        [DataMember(Name="kievanNoteQuarterStemUp")]
        BoundingBox KievanNoteQuarterStemUp { get; set; }

        [DataMember(Name="kievanNoteReciting")]
        BoundingBox KievanNoteReciting { get; set; }

        [DataMember(Name="kievanNoteWhole")]
        BoundingBox KievanNoteWhole { get; set; }

        [DataMember(Name="kievanNoteWholeFinal")]
        BoundingBox KievanNoteWholeFinal { get; set; }

        [DataMember(Name="kodalyHandDo")]
        BoundingBox KodalyHandDo { get; set; }

        [DataMember(Name="kodalyHandFa")]
        BoundingBox KodalyHandFa { get; set; }

        [DataMember(Name="kodalyHandLa")]
        BoundingBox KodalyHandLa { get; set; }

        [DataMember(Name="kodalyHandMi")]
        BoundingBox KodalyHandMi { get; set; }

        [DataMember(Name="kodalyHandRe")]
        BoundingBox KodalyHandRe { get; set; }

        [DataMember(Name="kodalyHandSo")]
        BoundingBox KodalyHandSo { get; set; }

        [DataMember(Name="kodalyHandTi")]
        BoundingBox KodalyHandTi { get; set; }

        [DataMember(Name="leftRepeatSmall")]
        BoundingBox LeftRepeatSmall { get; set; }

        [DataMember(Name="legerLine")]
        BoundingBox LegerLine { get; set; }

        [DataMember(Name="legerLineNarrow")]
        BoundingBox LegerLineNarrow { get; set; }

        [DataMember(Name="legerLineWide")]
        BoundingBox LegerLineWide { get; set; }

        [DataMember(Name="luteBarlineEndRepeat")]
        BoundingBox LuteBarlineEndRepeat { get; set; }

        [DataMember(Name="luteBarlineFinal")]
        BoundingBox LuteBarlineFinal { get; set; }

        [DataMember(Name="luteBarlineStartRepeat")]
        BoundingBox LuteBarlineStartRepeat { get; set; }

        [DataMember(Name="luteDuration16th")]
        BoundingBox LuteDuration16Th { get; set; }

        [DataMember(Name="luteDuration32nd")]
        BoundingBox LuteDuration32Nd { get; set; }

        [DataMember(Name="luteDuration8th")]
        BoundingBox LuteDuration8Th { get; set; }

        [DataMember(Name="luteDurationDoubleWhole")]
        BoundingBox LuteDurationDoubleWhole { get; set; }

        [DataMember(Name="luteDurationHalf")]
        BoundingBox LuteDurationHalf { get; set; }

        [DataMember(Name="luteDurationQuarter")]
        BoundingBox LuteDurationQuarter { get; set; }

        [DataMember(Name="luteDurationWhole")]
        BoundingBox LuteDurationWhole { get; set; }

        [DataMember(Name="luteFingeringRHFirst")]
        BoundingBox LuteFingeringRhFirst { get; set; }

        [DataMember(Name="luteFingeringRHSecond")]
        BoundingBox LuteFingeringRhSecond { get; set; }

        [DataMember(Name="luteFingeringRHThird")]
        BoundingBox LuteFingeringRhThird { get; set; }

        [DataMember(Name="luteFingeringRHThirdAlt")]
        BoundingBox LuteFingeringRhThirdAlt { get; set; }

        [DataMember(Name="luteFingeringRHThumb")]
        BoundingBox LuteFingeringRhThumb { get; set; }

        [DataMember(Name="luteFrench10thCourse")]
        BoundingBox LuteFrench10ThCourse { get; set; }

        [DataMember(Name="luteFrench10thCourseRight")]
        BoundingBox LuteFrench10ThCourseRight { get; set; }

        [DataMember(Name="luteFrench10thCourseStrikethru")]
        BoundingBox LuteFrench10ThCourseStrikethru { get; set; }

        [DataMember(Name="luteFrench10thCourseUnderline")]
        BoundingBox LuteFrench10ThCourseUnderline { get; set; }

        [DataMember(Name="luteFrench7thCourse")]
        BoundingBox LuteFrench7ThCourse { get; set; }

        [DataMember(Name="luteFrench7thCourseRight")]
        BoundingBox LuteFrench7ThCourseRight { get; set; }

        [DataMember(Name="luteFrench7thCourseStrikethru")]
        BoundingBox LuteFrench7ThCourseStrikethru { get; set; }

        [DataMember(Name="luteFrench7thCourseUnderline")]
        BoundingBox LuteFrench7ThCourseUnderline { get; set; }

        [DataMember(Name="luteFrench8thCourse")]
        BoundingBox LuteFrench8ThCourse { get; set; }

        [DataMember(Name="luteFrench8thCourseRight")]
        BoundingBox LuteFrench8ThCourseRight { get; set; }

        [DataMember(Name="luteFrench8thCourseStrikethru")]
        BoundingBox LuteFrench8ThCourseStrikethru { get; set; }

        [DataMember(Name="luteFrench8thCourseUnderline")]
        BoundingBox LuteFrench8ThCourseUnderline { get; set; }

        [DataMember(Name="luteFrench9thCourse")]
        BoundingBox LuteFrench9ThCourse { get; set; }

        [DataMember(Name="luteFrench9thCourseRight")]
        BoundingBox LuteFrench9ThCourseRight { get; set; }

        [DataMember(Name="luteFrench9thCourseStrikethru")]
        BoundingBox LuteFrench9ThCourseStrikethru { get; set; }

        [DataMember(Name="luteFrench9thCourseUnderline")]
        BoundingBox LuteFrench9ThCourseUnderline { get; set; }

        [DataMember(Name="luteFrenchAppoggiaturaAbove")]
        BoundingBox LuteFrenchAppoggiaturaAbove { get; set; }

        [DataMember(Name="luteFrenchAppoggiaturaBelow")]
        BoundingBox LuteFrenchAppoggiaturaBelow { get; set; }

        [DataMember(Name="luteFrenchFretA")]
        BoundingBox LuteFrenchFretA { get; set; }

        [DataMember(Name="luteFrenchFretB")]
        BoundingBox LuteFrenchFretB { get; set; }

        [DataMember(Name="luteFrenchFretC")]
        BoundingBox LuteFrenchFretC { get; set; }

        [DataMember(Name="luteFrenchFretCAlt")]
        BoundingBox LuteFrenchFretCAlt { get; set; }

        [DataMember(Name="luteFrenchFretD")]
        BoundingBox LuteFrenchFretD { get; set; }

        [DataMember(Name="luteFrenchFretE")]
        BoundingBox LuteFrenchFretE { get; set; }

        [DataMember(Name="luteFrenchFretF")]
        BoundingBox LuteFrenchFretF { get; set; }

        [DataMember(Name="luteFrenchFretG")]
        BoundingBox LuteFrenchFretG { get; set; }

        [DataMember(Name="luteFrenchFretH")]
        BoundingBox LuteFrenchFretH { get; set; }

        [DataMember(Name="luteFrenchFretI")]
        BoundingBox LuteFrenchFretI { get; set; }

        [DataMember(Name="luteFrenchFretK")]
        BoundingBox LuteFrenchFretK { get; set; }

        [DataMember(Name="luteFrenchFretL")]
        BoundingBox LuteFrenchFretL { get; set; }

        [DataMember(Name="luteFrenchFretM")]
        BoundingBox LuteFrenchFretM { get; set; }

        [DataMember(Name="luteFrenchFretN")]
        BoundingBox LuteFrenchFretN { get; set; }

        [DataMember(Name="luteFrenchMordentInverted")]
        BoundingBox LuteFrenchMordentInverted { get; set; }

        [DataMember(Name="luteFrenchMordentLower")]
        BoundingBox LuteFrenchMordentLower { get; set; }

        [DataMember(Name="luteFrenchMordentUpper")]
        BoundingBox LuteFrenchMordentUpper { get; set; }

        [DataMember(Name="luteGermanALower")]
        BoundingBox LuteGermanALower { get; set; }

        [DataMember(Name="luteGermanAUpper")]
        BoundingBox LuteGermanAUpper { get; set; }

        [DataMember(Name="luteGermanBLower")]
        BoundingBox LuteGermanBLower { get; set; }

        [DataMember(Name="luteGermanBUpper")]
        BoundingBox LuteGermanBUpper { get; set; }

        [DataMember(Name="luteGermanCLower")]
        BoundingBox LuteGermanCLower { get; set; }

        [DataMember(Name="luteGermanCUpper")]
        BoundingBox LuteGermanCUpper { get; set; }

        [DataMember(Name="luteGermanDLower")]
        BoundingBox LuteGermanDLower { get; set; }

        [DataMember(Name="luteGermanDUpper")]
        BoundingBox LuteGermanDUpper { get; set; }

        [DataMember(Name="luteGermanELower")]
        BoundingBox LuteGermanELower { get; set; }

        [DataMember(Name="luteGermanEUpper")]
        BoundingBox LuteGermanEUpper { get; set; }

        [DataMember(Name="luteGermanFLower")]
        BoundingBox LuteGermanFLower { get; set; }

        [DataMember(Name="luteGermanFUpper")]
        BoundingBox LuteGermanFUpper { get; set; }

        [DataMember(Name="luteGermanGLower")]
        BoundingBox LuteGermanGLower { get; set; }

        [DataMember(Name="luteGermanGUpper")]
        BoundingBox LuteGermanGUpper { get; set; }

        [DataMember(Name="luteGermanHLower")]
        BoundingBox LuteGermanHLower { get; set; }

        [DataMember(Name="luteGermanHUpper")]
        BoundingBox LuteGermanHUpper { get; set; }

        [DataMember(Name="luteGermanILower")]
        BoundingBox LuteGermanILower { get; set; }

        [DataMember(Name="luteGermanIUpper")]
        BoundingBox LuteGermanIUpper { get; set; }

        [DataMember(Name="luteGermanKLower")]
        BoundingBox LuteGermanKLower { get; set; }

        [DataMember(Name="luteGermanKUpper")]
        BoundingBox LuteGermanKUpper { get; set; }

        [DataMember(Name="luteGermanLLower")]
        BoundingBox LuteGermanLLower { get; set; }

        [DataMember(Name="luteGermanLUpper")]
        BoundingBox LuteGermanLUpper { get; set; }

        [DataMember(Name="luteGermanMLower")]
        BoundingBox LuteGermanMLower { get; set; }

        [DataMember(Name="luteGermanMUpper")]
        BoundingBox LuteGermanMUpper { get; set; }

        [DataMember(Name="luteGermanNLower")]
        BoundingBox LuteGermanNLower { get; set; }

        [DataMember(Name="luteGermanNUpper")]
        BoundingBox LuteGermanNUpper { get; set; }

        [DataMember(Name="luteGermanOLower")]
        BoundingBox LuteGermanOLower { get; set; }

        [DataMember(Name="luteGermanPLower")]
        BoundingBox LuteGermanPLower { get; set; }

        [DataMember(Name="luteGermanQLower")]
        BoundingBox LuteGermanQLower { get; set; }

        [DataMember(Name="luteGermanRLower")]
        BoundingBox LuteGermanRLower { get; set; }

        [DataMember(Name="luteGermanSLower")]
        BoundingBox LuteGermanSLower { get; set; }

        [DataMember(Name="luteGermanTLower")]
        BoundingBox LuteGermanTLower { get; set; }

        [DataMember(Name="luteGermanVLower")]
        BoundingBox LuteGermanVLower { get; set; }

        [DataMember(Name="luteGermanXLower")]
        BoundingBox LuteGermanXLower { get; set; }

        [DataMember(Name="luteGermanYLower")]
        BoundingBox LuteGermanYLower { get; set; }

        [DataMember(Name="luteGermanZLower")]
        BoundingBox LuteGermanZLower { get; set; }

        [DataMember(Name="luteItalianClefCSolFaUt")]
        BoundingBox LuteItalianClefCSolFaUt { get; set; }

        [DataMember(Name="luteItalianClefFFaUt")]
        BoundingBox LuteItalianClefFFaUt { get; set; }

        [DataMember(Name="luteItalianFret0")]
        BoundingBox LuteItalianFret0 { get; set; }

        [DataMember(Name="luteItalianFret1")]
        BoundingBox LuteItalianFret1 { get; set; }

        [DataMember(Name="luteItalianFret2")]
        BoundingBox LuteItalianFret2 { get; set; }

        [DataMember(Name="luteItalianFret3")]
        BoundingBox LuteItalianFret3 { get; set; }

        [DataMember(Name="luteItalianFret4")]
        BoundingBox LuteItalianFret4 { get; set; }

        [DataMember(Name="luteItalianFret5")]
        BoundingBox LuteItalianFret5 { get; set; }

        [DataMember(Name="luteItalianFret6")]
        BoundingBox LuteItalianFret6 { get; set; }

        [DataMember(Name="luteItalianFret7")]
        BoundingBox LuteItalianFret7 { get; set; }

        [DataMember(Name="luteItalianFret8")]
        BoundingBox LuteItalianFret8 { get; set; }

        [DataMember(Name="luteItalianFret9")]
        BoundingBox LuteItalianFret9 { get; set; }

        [DataMember(Name="luteItalianHoldFinger")]
        BoundingBox LuteItalianHoldFinger { get; set; }

        [DataMember(Name="luteItalianHoldNote")]
        BoundingBox LuteItalianHoldNote { get; set; }

        [DataMember(Name="luteItalianReleaseFinger")]
        BoundingBox LuteItalianReleaseFinger { get; set; }

        [DataMember(Name="luteItalianTempoFast")]
        BoundingBox LuteItalianTempoFast { get; set; }

        [DataMember(Name="luteItalianTempoNeitherFastNorSlow")]
        BoundingBox LuteItalianTempoNeitherFastNorSlow { get; set; }

        [DataMember(Name="luteItalianTempoSlow")]
        BoundingBox LuteItalianTempoSlow { get; set; }

        [DataMember(Name="luteItalianTempoSomewhatFast")]
        BoundingBox LuteItalianTempoSomewhatFast { get; set; }

        [DataMember(Name="luteItalianTempoVerySlow")]
        BoundingBox LuteItalianTempoVerySlow { get; set; }

        [DataMember(Name="luteItalianTimeTriple")]
        BoundingBox LuteItalianTimeTriple { get; set; }

        [DataMember(Name="luteItalianTremolo")]
        BoundingBox LuteItalianTremolo { get; set; }

        [DataMember(Name="luteItalianVibrato")]
        BoundingBox LuteItalianVibrato { get; set; }

        [DataMember(Name="luteStaff6Lines")]
        BoundingBox LuteStaff6Lines { get; set; }

        [DataMember(Name="luteStaff6LinesNarrow")]
        BoundingBox LuteStaff6LinesNarrow { get; set; }

        [DataMember(Name="luteStaff6LinesWide")]
        BoundingBox LuteStaff6LinesWide { get; set; }

        [DataMember(Name="lyricsElision")]
        BoundingBox LyricsElision { get; set; }

        [DataMember(Name="lyricsElisionNarrow")]
        BoundingBox LyricsElisionNarrow { get; set; }

        [DataMember(Name="lyricsElisionWide")]
        BoundingBox LyricsElisionWide { get; set; }

        [DataMember(Name="lyricsHyphenBaseline")]
        BoundingBox LyricsHyphenBaseline { get; set; }

        [DataMember(Name="lyricsHyphenBaselineNonBreaking")]
        BoundingBox LyricsHyphenBaselineNonBreaking { get; set; }

        [DataMember(Name="medRenFlatHardB")]
        BoundingBox MedRenFlatHardB { get; set; }

        [DataMember(Name="medRenFlatSoftB")]
        BoundingBox MedRenFlatSoftB { get; set; }

        [DataMember(Name="medRenFlatSoftBHufnagel")]
        BoundingBox MedRenFlatSoftBHufnagel { get; set; }

        [DataMember(Name="medRenFlatSoftBOld")]
        BoundingBox MedRenFlatSoftBOld { get; set; }

        [DataMember(Name="medRenFlatWithDot")]
        BoundingBox MedRenFlatWithDot { get; set; }

        [DataMember(Name="medRenGClefCMN")]
        BoundingBox MedRenGClefCmn { get; set; }

        [DataMember(Name="medRenLiquescenceCMN")]
        BoundingBox MedRenLiquescenceCmn { get; set; }

        [DataMember(Name="medRenLiquescentAscCMN")]
        BoundingBox MedRenLiquescentAscCmn { get; set; }

        [DataMember(Name="medRenLiquescentDescCMN")]
        BoundingBox MedRenLiquescentDescCmn { get; set; }

        [DataMember(Name="medRenNatural")]
        BoundingBox MedRenNatural { get; set; }

        [DataMember(Name="medRenNaturalWithCross")]
        BoundingBox MedRenNaturalWithCross { get; set; }

        [DataMember(Name="medRenOriscusCMN")]
        BoundingBox MedRenOriscusCmn { get; set; }

        [DataMember(Name="medRenPlicaCMN")]
        BoundingBox MedRenPlicaCmn { get; set; }

        [DataMember(Name="medRenPunctumCMN")]
        BoundingBox MedRenPunctumCmn { get; set; }

        [DataMember(Name="medRenQuilismaCMN")]
        BoundingBox MedRenQuilismaCmn { get; set; }

        [DataMember(Name="medRenSharpCroix")]
        BoundingBox MedRenSharpCroix { get; set; }

        [DataMember(Name="medRenStrophicusCMN")]
        BoundingBox MedRenStrophicusCmn { get; set; }

        [DataMember(Name="mensuralAlterationSign")]
        BoundingBox MensuralAlterationSign { get; set; }

        [DataMember(Name="mensuralBlackBrevis")]
        BoundingBox MensuralBlackBrevis { get; set; }

        [DataMember(Name="mensuralBlackBrevisVoid")]
        BoundingBox MensuralBlackBrevisVoid { get; set; }

        [DataMember(Name="mensuralBlackDragma")]
        BoundingBox MensuralBlackDragma { get; set; }

        [DataMember(Name="mensuralBlackLonga")]
        BoundingBox MensuralBlackLonga { get; set; }

        [DataMember(Name="mensuralBlackMaxima")]
        BoundingBox MensuralBlackMaxima { get; set; }

        [DataMember(Name="mensuralBlackMinima")]
        BoundingBox MensuralBlackMinima { get; set; }

        [DataMember(Name="mensuralBlackMinimaVoid")]
        BoundingBox MensuralBlackMinimaVoid { get; set; }

        [DataMember(Name="mensuralBlackSemibrevis")]
        BoundingBox MensuralBlackSemibrevis { get; set; }

        [DataMember(Name="mensuralBlackSemibrevisCaudata")]
        BoundingBox MensuralBlackSemibrevisCaudata { get; set; }

        [DataMember(Name="mensuralBlackSemibrevisOblique")]
        BoundingBox MensuralBlackSemibrevisOblique { get; set; }

        [DataMember(Name="mensuralBlackSemibrevisVoid")]
        BoundingBox MensuralBlackSemibrevisVoid { get; set; }

        [DataMember(Name="mensuralBlackSemiminima")]
        BoundingBox MensuralBlackSemiminima { get; set; }

        [DataMember(Name="mensuralCclef")]
        BoundingBox MensuralCclef { get; set; }

        [DataMember(Name="mensuralCclefBlack")]
        BoundingBox MensuralCclefBlack { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosHigh")]
        BoundingBox MensuralCclefPetrucciPosHigh { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosHighest")]
        BoundingBox MensuralCclefPetrucciPosHighest { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosLow")]
        BoundingBox MensuralCclefPetrucciPosLow { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosLowest")]
        BoundingBox MensuralCclefPetrucciPosLowest { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosMiddle")]
        BoundingBox MensuralCclefPetrucciPosMiddle { get; set; }

        [DataMember(Name="mensuralCclefVoid")]
        BoundingBox MensuralCclefVoid { get; set; }

        [DataMember(Name="mensuralColorationEndRound")]
        BoundingBox MensuralColorationEndRound { get; set; }

        [DataMember(Name="mensuralColorationEndSquare")]
        BoundingBox MensuralColorationEndSquare { get; set; }

        [DataMember(Name="mensuralColorationStartRound")]
        BoundingBox MensuralColorationStartRound { get; set; }

        [DataMember(Name="mensuralColorationStartSquare")]
        BoundingBox MensuralColorationStartSquare { get; set; }

        [DataMember(Name="mensuralCombStemDiagonal")]
        BoundingBox MensuralCombStemDiagonal { get; set; }

        [DataMember(Name="mensuralCombStemDown")]
        BoundingBox MensuralCombStemDown { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagExtended")]
        BoundingBox MensuralCombStemDownFlagExtended { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagFlared")]
        BoundingBox MensuralCombStemDownFlagFlared { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagFusa")]
        BoundingBox MensuralCombStemDownFlagFusa { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagLeft")]
        BoundingBox MensuralCombStemDownFlagLeft { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagRight")]
        BoundingBox MensuralCombStemDownFlagRight { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagSemiminima")]
        BoundingBox MensuralCombStemDownFlagSemiminima { get; set; }

        [DataMember(Name="mensuralCombStemUp")]
        BoundingBox MensuralCombStemUp { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagExtended")]
        BoundingBox MensuralCombStemUpFlagExtended { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagFlared")]
        BoundingBox MensuralCombStemUpFlagFlared { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagFusa")]
        BoundingBox MensuralCombStemUpFlagFusa { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagLeft")]
        BoundingBox MensuralCombStemUpFlagLeft { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagRight")]
        BoundingBox MensuralCombStemUpFlagRight { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagSemiminima")]
        BoundingBox MensuralCombStemUpFlagSemiminima { get; set; }

        [DataMember(Name="mensuralCustosCheckmark")]
        BoundingBox MensuralCustosCheckmark { get; set; }

        [DataMember(Name="mensuralCustosDown")]
        BoundingBox MensuralCustosDown { get; set; }

        [DataMember(Name="mensuralCustosTurn")]
        BoundingBox MensuralCustosTurn { get; set; }

        [DataMember(Name="mensuralCustosUp")]
        BoundingBox MensuralCustosUp { get; set; }

        [DataMember(Name="mensuralFclef")]
        BoundingBox MensuralFclef { get; set; }

        [DataMember(Name="mensuralFclefPetrucci")]
        BoundingBox MensuralFclefPetrucci { get; set; }

        [DataMember(Name="mensuralFusaBlackStemDown")]
        BoundingBox MensuralFusaBlackStemDown { get; set; }

        [DataMember(Name="mensuralFusaBlackStemUp")]
        BoundingBox MensuralFusaBlackStemUp { get; set; }

        [DataMember(Name="mensuralFusaBlackVoidStemDown")]
        BoundingBox MensuralFusaBlackVoidStemDown { get; set; }

        [DataMember(Name="mensuralFusaBlackVoidStemUp")]
        BoundingBox MensuralFusaBlackVoidStemUp { get; set; }

        [DataMember(Name="mensuralFusaVoidStemDown")]
        BoundingBox MensuralFusaVoidStemDown { get; set; }

        [DataMember(Name="mensuralFusaVoidStemUp")]
        BoundingBox MensuralFusaVoidStemUp { get; set; }

        [DataMember(Name="mensuralGclef")]
        BoundingBox MensuralGclef { get; set; }

        [DataMember(Name="mensuralGclefPetrucci")]
        BoundingBox MensuralGclefPetrucci { get; set; }

        [DataMember(Name="mensuralLongaBlackStemDownLeft")]
        BoundingBox MensuralLongaBlackStemDownLeft { get; set; }

        [DataMember(Name="mensuralLongaBlackStemDownRight")]
        BoundingBox MensuralLongaBlackStemDownRight { get; set; }

        [DataMember(Name="mensuralLongaBlackStemUpLeft")]
        BoundingBox MensuralLongaBlackStemUpLeft { get; set; }

        [DataMember(Name="mensuralLongaBlackStemUpRight")]
        BoundingBox MensuralLongaBlackStemUpRight { get; set; }

        [DataMember(Name="mensuralLongaBlackVoidStemDownLeft")]
        BoundingBox MensuralLongaBlackVoidStemDownLeft { get; set; }

        [DataMember(Name="mensuralLongaBlackVoidStemDownRight")]
        BoundingBox MensuralLongaBlackVoidStemDownRight { get; set; }

        [DataMember(Name="mensuralLongaBlackVoidStemUpLeft")]
        BoundingBox MensuralLongaBlackVoidStemUpLeft { get; set; }

        [DataMember(Name="mensuralLongaBlackVoidStemUpRight")]
        BoundingBox MensuralLongaBlackVoidStemUpRight { get; set; }

        [DataMember(Name="mensuralLongaVoidStemDownLeft")]
        BoundingBox MensuralLongaVoidStemDownLeft { get; set; }

        [DataMember(Name="mensuralLongaVoidStemDownRight")]
        BoundingBox MensuralLongaVoidStemDownRight { get; set; }

        [DataMember(Name="mensuralLongaVoidStemUpLeft")]
        BoundingBox MensuralLongaVoidStemUpLeft { get; set; }

        [DataMember(Name="mensuralLongaVoidStemUpRight")]
        BoundingBox MensuralLongaVoidStemUpRight { get; set; }

        [DataMember(Name="mensuralMaximaBlackStemDownLeft")]
        BoundingBox MensuralMaximaBlackStemDownLeft { get; set; }

        [DataMember(Name="mensuralMaximaBlackStemDownRight")]
        BoundingBox MensuralMaximaBlackStemDownRight { get; set; }

        [DataMember(Name="mensuralMaximaBlackStemUpLeft")]
        BoundingBox MensuralMaximaBlackStemUpLeft { get; set; }

        [DataMember(Name="mensuralMaximaBlackStemUpRight")]
        BoundingBox MensuralMaximaBlackStemUpRight { get; set; }

        [DataMember(Name="mensuralMaximaBlackVoidStemDownLeft")]
        BoundingBox MensuralMaximaBlackVoidStemDownLeft { get; set; }

        [DataMember(Name="mensuralMaximaBlackVoidStemDownRight")]
        BoundingBox MensuralMaximaBlackVoidStemDownRight { get; set; }

        [DataMember(Name="mensuralMaximaBlackVoidStemUpLeft")]
        BoundingBox MensuralMaximaBlackVoidStemUpLeft { get; set; }

        [DataMember(Name="mensuralMaximaBlackVoidStemUpRight")]
        BoundingBox MensuralMaximaBlackVoidStemUpRight { get; set; }

        [DataMember(Name="mensuralMaximaVoidStemDownLeft")]
        BoundingBox MensuralMaximaVoidStemDownLeft { get; set; }

        [DataMember(Name="mensuralMaximaVoidStemDownRight")]
        BoundingBox MensuralMaximaVoidStemDownRight { get; set; }

        [DataMember(Name="mensuralMaximaVoidStemUpLeft")]
        BoundingBox MensuralMaximaVoidStemUpLeft { get; set; }

        [DataMember(Name="mensuralMaximaVoidStemUpRight")]
        BoundingBox MensuralMaximaVoidStemUpRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDown")]
        BoundingBox MensuralMinimaBlackStemDown { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDownExtendedFlag")]
        BoundingBox MensuralMinimaBlackStemDownExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDownFlagLeft")]
        BoundingBox MensuralMinimaBlackStemDownFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDownFlagRight")]
        BoundingBox MensuralMinimaBlackStemDownFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDownFlaredFlag")]
        BoundingBox MensuralMinimaBlackStemDownFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUp")]
        BoundingBox MensuralMinimaBlackStemUp { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUpExtendedFlag")]
        BoundingBox MensuralMinimaBlackStemUpExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUpFlagLeft")]
        BoundingBox MensuralMinimaBlackStemUpFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUpFlagRight")]
        BoundingBox MensuralMinimaBlackStemUpFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUpFlaredFlag")]
        BoundingBox MensuralMinimaBlackStemUpFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDown")]
        BoundingBox MensuralMinimaBlackVoidStemDown { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDownExtendedFlag")]
        BoundingBox MensuralMinimaBlackVoidStemDownExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDownFlagLeft")]
        BoundingBox MensuralMinimaBlackVoidStemDownFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDownFlagRight")]
        BoundingBox MensuralMinimaBlackVoidStemDownFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDownFlaredFlag")]
        BoundingBox MensuralMinimaBlackVoidStemDownFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUp")]
        BoundingBox MensuralMinimaBlackVoidStemUp { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUpExtendedFlag")]
        BoundingBox MensuralMinimaBlackVoidStemUpExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUpFlagLeft")]
        BoundingBox MensuralMinimaBlackVoidStemUpFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUpFlagRight")]
        BoundingBox MensuralMinimaBlackVoidStemUpFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUpFlaredFlag")]
        BoundingBox MensuralMinimaBlackVoidStemUpFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDown")]
        BoundingBox MensuralMinimaVoidStemDown { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDownExtendedFlag")]
        BoundingBox MensuralMinimaVoidStemDownExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDownFlagLeft")]
        BoundingBox MensuralMinimaVoidStemDownFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDownFlagRight")]
        BoundingBox MensuralMinimaVoidStemDownFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDownFlaredFlag")]
        BoundingBox MensuralMinimaVoidStemDownFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUp")]
        BoundingBox MensuralMinimaVoidStemUp { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUpExtendedFlag")]
        BoundingBox MensuralMinimaVoidStemUpExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUpFlagLeft")]
        BoundingBox MensuralMinimaVoidStemUpFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUpFlagRight")]
        BoundingBox MensuralMinimaVoidStemUpFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUpFlaredFlag")]
        BoundingBox MensuralMinimaVoidStemUpFlaredFlag { get; set; }

        [DataMember(Name="mensuralModusImperfectumVert")]
        BoundingBox MensuralModusImperfectumVert { get; set; }

        [DataMember(Name="mensuralModusPerfectumVert")]
        BoundingBox MensuralModusPerfectumVert { get; set; }

        [DataMember(Name="mensuralNoteheadLongaBlack")]
        BoundingBox MensuralNoteheadLongaBlack { get; set; }

        [DataMember(Name="mensuralNoteheadLongaBlackVoid")]
        BoundingBox MensuralNoteheadLongaBlackVoid { get; set; }

        [DataMember(Name="mensuralNoteheadLongaVoid")]
        BoundingBox MensuralNoteheadLongaVoid { get; set; }

        [DataMember(Name="mensuralNoteheadLongaWhite")]
        BoundingBox MensuralNoteheadLongaWhite { get; set; }

        [DataMember(Name="mensuralNoteheadMaximaBlack")]
        BoundingBox MensuralNoteheadMaximaBlack { get; set; }

        [DataMember(Name="mensuralNoteheadMaximaBlackVoid")]
        BoundingBox MensuralNoteheadMaximaBlackVoid { get; set; }

        [DataMember(Name="mensuralNoteheadMaximaVoid")]
        BoundingBox MensuralNoteheadMaximaVoid { get; set; }

        [DataMember(Name="mensuralNoteheadMaximaWhite")]
        BoundingBox MensuralNoteheadMaximaWhite { get; set; }

        [DataMember(Name="mensuralNoteheadMinimaWhite")]
        BoundingBox MensuralNoteheadMinimaWhite { get; set; }

        [DataMember(Name="mensuralNoteheadSemibrevisBlack")]
        BoundingBox MensuralNoteheadSemibrevisBlack { get; set; }

        [DataMember(Name="mensuralNoteheadSemibrevisBlackVoid")]
        BoundingBox MensuralNoteheadSemibrevisBlackVoid { get; set; }

        [DataMember(Name="mensuralNoteheadSemibrevisBlackVoidTurned")]
        BoundingBox MensuralNoteheadSemibrevisBlackVoidTurned { get; set; }

        [DataMember(Name="mensuralNoteheadSemibrevisVoid")]
        BoundingBox MensuralNoteheadSemibrevisVoid { get; set; }

        [DataMember(Name="mensuralNoteheadSemiminimaWhite")]
        BoundingBox MensuralNoteheadSemiminimaWhite { get; set; }

        [DataMember(Name="mensuralObliqueAsc2ndBlack")]
        BoundingBox MensuralObliqueAsc2NdBlack { get; set; }

        [DataMember(Name="mensuralObliqueAsc2ndBlackVoid")]
        BoundingBox MensuralObliqueAsc2NdBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc2ndVoid")]
        BoundingBox MensuralObliqueAsc2NdVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc2ndWhite")]
        BoundingBox MensuralObliqueAsc2NdWhite { get; set; }

        [DataMember(Name="mensuralObliqueAsc3rdBlack")]
        BoundingBox MensuralObliqueAsc3RdBlack { get; set; }

        [DataMember(Name="mensuralObliqueAsc3rdBlackVoid")]
        BoundingBox MensuralObliqueAsc3RdBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc3rdVoid")]
        BoundingBox MensuralObliqueAsc3RdVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc3rdWhite")]
        BoundingBox MensuralObliqueAsc3RdWhite { get; set; }

        [DataMember(Name="mensuralObliqueAsc4thBlack")]
        BoundingBox MensuralObliqueAsc4ThBlack { get; set; }

        [DataMember(Name="mensuralObliqueAsc4thBlackVoid")]
        BoundingBox MensuralObliqueAsc4ThBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc4thVoid")]
        BoundingBox MensuralObliqueAsc4ThVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc4thWhite")]
        BoundingBox MensuralObliqueAsc4ThWhite { get; set; }

        [DataMember(Name="mensuralObliqueAsc5thBlack")]
        BoundingBox MensuralObliqueAsc5ThBlack { get; set; }

        [DataMember(Name="mensuralObliqueAsc5thBlackVoid")]
        BoundingBox MensuralObliqueAsc5ThBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc5thVoid")]
        BoundingBox MensuralObliqueAsc5ThVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc5thWhite")]
        BoundingBox MensuralObliqueAsc5ThWhite { get; set; }

        [DataMember(Name="mensuralObliqueDesc2ndBlack")]
        BoundingBox MensuralObliqueDesc2NdBlack { get; set; }

        [DataMember(Name="mensuralObliqueDesc2ndBlackVoid")]
        BoundingBox MensuralObliqueDesc2NdBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc2ndVoid")]
        BoundingBox MensuralObliqueDesc2NdVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc2ndWhite")]
        BoundingBox MensuralObliqueDesc2NdWhite { get; set; }

        [DataMember(Name="mensuralObliqueDesc3rdBlack")]
        BoundingBox MensuralObliqueDesc3RdBlack { get; set; }

        [DataMember(Name="mensuralObliqueDesc3rdBlackVoid")]
        BoundingBox MensuralObliqueDesc3RdBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc3rdVoid")]
        BoundingBox MensuralObliqueDesc3RdVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc3rdWhite")]
        BoundingBox MensuralObliqueDesc3RdWhite { get; set; }

        [DataMember(Name="mensuralObliqueDesc4thBlack")]
        BoundingBox MensuralObliqueDesc4ThBlack { get; set; }

        [DataMember(Name="mensuralObliqueDesc4thBlackVoid")]
        BoundingBox MensuralObliqueDesc4ThBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc4thVoid")]
        BoundingBox MensuralObliqueDesc4ThVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc4thWhite")]
        BoundingBox MensuralObliqueDesc4ThWhite { get; set; }

        [DataMember(Name="mensuralObliqueDesc5thBlack")]
        BoundingBox MensuralObliqueDesc5ThBlack { get; set; }

        [DataMember(Name="mensuralObliqueDesc5thBlackVoid")]
        BoundingBox MensuralObliqueDesc5ThBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc5thVoid")]
        BoundingBox MensuralObliqueDesc5ThVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc5thWhite")]
        BoundingBox MensuralObliqueDesc5ThWhite { get; set; }

        [DataMember(Name="mensuralProlation1")]
        BoundingBox MensuralProlation1 { get; set; }

        [DataMember(Name="mensuralProlation10")]
        BoundingBox MensuralProlation10 { get; set; }

        [DataMember(Name="mensuralProlation11")]
        BoundingBox MensuralProlation11 { get; set; }

        [DataMember(Name="mensuralProlation2")]
        BoundingBox MensuralProlation2 { get; set; }

        [DataMember(Name="mensuralProlation3")]
        BoundingBox MensuralProlation3 { get; set; }

        [DataMember(Name="mensuralProlation4")]
        BoundingBox MensuralProlation4 { get; set; }

        [DataMember(Name="mensuralProlation5")]
        BoundingBox MensuralProlation5 { get; set; }

        [DataMember(Name="mensuralProlation6")]
        BoundingBox MensuralProlation6 { get; set; }

        [DataMember(Name="mensuralProlation7")]
        BoundingBox MensuralProlation7 { get; set; }

        [DataMember(Name="mensuralProlation8")]
        BoundingBox MensuralProlation8 { get; set; }

        [DataMember(Name="mensuralProlation9")]
        BoundingBox MensuralProlation9 { get; set; }

        [DataMember(Name="mensuralProlationCombiningDot")]
        BoundingBox MensuralProlationCombiningDot { get; set; }

        [DataMember(Name="mensuralProlationCombiningDotVoid")]
        BoundingBox MensuralProlationCombiningDotVoid { get; set; }

        [DataMember(Name="mensuralProlationCombiningStroke")]
        BoundingBox MensuralProlationCombiningStroke { get; set; }

        [DataMember(Name="mensuralProlationCombiningThreeDots")]
        BoundingBox MensuralProlationCombiningThreeDots { get; set; }

        [DataMember(Name="mensuralProlationCombiningThreeDotsTri")]
        BoundingBox MensuralProlationCombiningThreeDotsTri { get; set; }

        [DataMember(Name="mensuralProlationCombiningTwoDots")]
        BoundingBox MensuralProlationCombiningTwoDots { get; set; }

        [DataMember(Name="mensuralProportion1")]
        BoundingBox MensuralProportion1 { get; set; }

        [DataMember(Name="mensuralProportion2")]
        BoundingBox MensuralProportion2 { get; set; }

        [DataMember(Name="mensuralProportion3")]
        BoundingBox MensuralProportion3 { get; set; }

        [DataMember(Name="mensuralProportion4")]
        BoundingBox MensuralProportion4 { get; set; }

        [DataMember(Name="mensuralProportion4Old")]
        BoundingBox MensuralProportion4Old { get; set; }

        [DataMember(Name="mensuralProportionMajor")]
        BoundingBox MensuralProportionMajor { get; set; }

        [DataMember(Name="mensuralProportionMinor")]
        BoundingBox MensuralProportionMinor { get; set; }

        [DataMember(Name="mensuralProportionProportioDupla1")]
        BoundingBox MensuralProportionProportioDupla1 { get; set; }

        [DataMember(Name="mensuralProportionProportioDupla2")]
        BoundingBox MensuralProportionProportioDupla2 { get; set; }

        [DataMember(Name="mensuralProportionProportioQuadrupla")]
        BoundingBox MensuralProportionProportioQuadrupla { get; set; }

        [DataMember(Name="mensuralProportionProportioTripla")]
        BoundingBox MensuralProportionProportioTripla { get; set; }

        [DataMember(Name="mensuralProportionTempusPerfectum")]
        BoundingBox MensuralProportionTempusPerfectum { get; set; }

        [DataMember(Name="mensuralRestBrevis")]
        BoundingBox MensuralRestBrevis { get; set; }

        [DataMember(Name="mensuralRestFusa")]
        BoundingBox MensuralRestFusa { get; set; }

        [DataMember(Name="mensuralRestLongaImperfecta")]
        BoundingBox MensuralRestLongaImperfecta { get; set; }

        [DataMember(Name="mensuralRestLongaPerfecta")]
        BoundingBox MensuralRestLongaPerfecta { get; set; }

        [DataMember(Name="mensuralRestMaxima")]
        BoundingBox MensuralRestMaxima { get; set; }

        [DataMember(Name="mensuralRestMinima")]
        BoundingBox MensuralRestMinima { get; set; }

        [DataMember(Name="mensuralRestSemibrevis")]
        BoundingBox MensuralRestSemibrevis { get; set; }

        [DataMember(Name="mensuralRestSemifusa")]
        BoundingBox MensuralRestSemifusa { get; set; }

        [DataMember(Name="mensuralRestSemiminima")]
        BoundingBox MensuralRestSemiminima { get; set; }

        [DataMember(Name="mensuralSemiminimaBlackStemDown")]
        BoundingBox MensuralSemiminimaBlackStemDown { get; set; }

        [DataMember(Name="mensuralSemiminimaBlackStemUp")]
        BoundingBox MensuralSemiminimaBlackStemUp { get; set; }

        [DataMember(Name="mensuralSemiminimaBlackVoidStemDown")]
        BoundingBox MensuralSemiminimaBlackVoidStemDown { get; set; }

        [DataMember(Name="mensuralSemiminimaBlackVoidStemUp")]
        BoundingBox MensuralSemiminimaBlackVoidStemUp { get; set; }

        [DataMember(Name="mensuralSemiminimaVoidStemDown")]
        BoundingBox MensuralSemiminimaVoidStemDown { get; set; }

        [DataMember(Name="mensuralSemiminimaVoidStemUp")]
        BoundingBox MensuralSemiminimaVoidStemUp { get; set; }

        [DataMember(Name="mensuralSignumDown")]
        BoundingBox MensuralSignumDown { get; set; }

        [DataMember(Name="mensuralSignumUp")]
        BoundingBox MensuralSignumUp { get; set; }

        [DataMember(Name="mensuralTempusImperfectumHoriz")]
        BoundingBox MensuralTempusImperfectumHoriz { get; set; }

        [DataMember(Name="mensuralTempusPerfectumHoriz")]
        BoundingBox MensuralTempusPerfectumHoriz { get; set; }

        [DataMember(Name="mensuralWhiteBrevis")]
        BoundingBox MensuralWhiteBrevis { get; set; }

        [DataMember(Name="mensuralWhiteFusa")]
        BoundingBox MensuralWhiteFusa { get; set; }

        [DataMember(Name="mensuralWhiteLonga")]
        BoundingBox MensuralWhiteLonga { get; set; }

        [DataMember(Name="mensuralWhiteMaxima")]
        BoundingBox MensuralWhiteMaxima { get; set; }

        [DataMember(Name="mensuralWhiteMinima")]
        BoundingBox MensuralWhiteMinima { get; set; }

        [DataMember(Name="mensuralWhiteSemiminima")]
        BoundingBox MensuralWhiteSemiminima { get; set; }

        [DataMember(Name="metAugmentationDot")]
        BoundingBox MetAugmentationDot { get; set; }

        [DataMember(Name="metNote1024thDown")]
        BoundingBox MetNote1024ThDown { get; set; }

        [DataMember(Name="metNote1024thUp")]
        BoundingBox MetNote1024ThUp { get; set; }

        [DataMember(Name="metNote128thDown")]
        BoundingBox MetNote128ThDown { get; set; }

        [DataMember(Name="metNote128thUp")]
        BoundingBox MetNote128ThUp { get; set; }

        [DataMember(Name="metNote16thDown")]
        BoundingBox MetNote16ThDown { get; set; }

        [DataMember(Name="metNote16thUp")]
        BoundingBox MetNote16ThUp { get; set; }

        [DataMember(Name="metNote256thDown")]
        BoundingBox MetNote256ThDown { get; set; }

        [DataMember(Name="metNote256thUp")]
        BoundingBox MetNote256ThUp { get; set; }

        [DataMember(Name="metNote32ndDown")]
        BoundingBox MetNote32NdDown { get; set; }

        [DataMember(Name="metNote32ndUp")]
        BoundingBox MetNote32NdUp { get; set; }

        [DataMember(Name="metNote512thDown")]
        BoundingBox MetNote512ThDown { get; set; }

        [DataMember(Name="metNote512thUp")]
        BoundingBox MetNote512ThUp { get; set; }

        [DataMember(Name="metNote64thDown")]
        BoundingBox MetNote64ThDown { get; set; }

        [DataMember(Name="metNote64thUp")]
        BoundingBox MetNote64ThUp { get; set; }

        [DataMember(Name="metNote8thDown")]
        BoundingBox MetNote8ThDown { get; set; }

        [DataMember(Name="metNote8thUp")]
        BoundingBox MetNote8ThUp { get; set; }

        [DataMember(Name="metNoteDoubleWhole")]
        BoundingBox MetNoteDoubleWhole { get; set; }

        [DataMember(Name="metNoteDoubleWholeSquare")]
        BoundingBox MetNoteDoubleWholeSquare { get; set; }

        [DataMember(Name="metNoteHalfDown")]
        BoundingBox MetNoteHalfDown { get; set; }

        [DataMember(Name="metNoteHalfUp")]
        BoundingBox MetNoteHalfUp { get; set; }

        [DataMember(Name="metNoteQuarterDown")]
        BoundingBox MetNoteQuarterDown { get; set; }

        [DataMember(Name="metNoteQuarterUp")]
        BoundingBox MetNoteQuarterUp { get; set; }

        [DataMember(Name="metNoteWhole")]
        BoundingBox MetNoteWhole { get; set; }

        [DataMember(Name="metricModulationArrowLeft")]
        BoundingBox MetricModulationArrowLeft { get; set; }

        [DataMember(Name="metricModulationArrowRight")]
        BoundingBox MetricModulationArrowRight { get; set; }

        [DataMember(Name="miscDoNotCopy")]
        BoundingBox MiscDoNotCopy { get; set; }

        [DataMember(Name="miscDoNotPhotocopy")]
        BoundingBox MiscDoNotPhotocopy { get; set; }

        [DataMember(Name="miscEyeglasses")]
        BoundingBox MiscEyeglasses { get; set; }

        [DataMember(Name="note1024thDown")]
        BoundingBox Note1024ThDown { get; set; }

        [DataMember(Name="note1024thUp")]
        BoundingBox Note1024ThUp { get; set; }

        [DataMember(Name="note128thDown")]
        BoundingBox Note128ThDown { get; set; }

        [DataMember(Name="note128thUp")]
        BoundingBox Note128ThUp { get; set; }

        [DataMember(Name="note16thDown")]
        BoundingBox Note16ThDown { get; set; }

        [DataMember(Name="note16thUp")]
        BoundingBox Note16ThUp { get; set; }

        [DataMember(Name="note256thDown")]
        BoundingBox Note256ThDown { get; set; }

        [DataMember(Name="note256thUp")]
        BoundingBox Note256ThUp { get; set; }

        [DataMember(Name="note32ndDown")]
        BoundingBox Note32NdDown { get; set; }

        [DataMember(Name="note32ndUp")]
        BoundingBox Note32NdUp { get; set; }

        [DataMember(Name="note512thDown")]
        BoundingBox Note512ThDown { get; set; }

        [DataMember(Name="note512thUp")]
        BoundingBox Note512ThUp { get; set; }

        [DataMember(Name="note64thDown")]
        BoundingBox Note64ThDown { get; set; }

        [DataMember(Name="note64thUp")]
        BoundingBox Note64ThUp { get; set; }

        [DataMember(Name="note8thDown")]
        BoundingBox Note8ThDown { get; set; }

        [DataMember(Name="note8thUp")]
        BoundingBox Note8ThUp { get; set; }

        [DataMember(Name="noteABlack")]
        BoundingBox NoteABlack { get; set; }

        [DataMember(Name="noteAFlatBlack")]
        BoundingBox NoteAFlatBlack { get; set; }

        [DataMember(Name="noteAFlatHalf")]
        BoundingBox NoteAFlatHalf { get; set; }

        [DataMember(Name="noteAFlatWhole")]
        BoundingBox NoteAFlatWhole { get; set; }

        [DataMember(Name="noteAHalf")]
        BoundingBox NoteAHalf { get; set; }

        [DataMember(Name="noteASharpBlack")]
        BoundingBox NoteASharpBlack { get; set; }

        [DataMember(Name="noteASharpHalf")]
        BoundingBox NoteASharpHalf { get; set; }

        [DataMember(Name="noteASharpWhole")]
        BoundingBox NoteASharpWhole { get; set; }

        [DataMember(Name="noteAWhole")]
        BoundingBox NoteAWhole { get; set; }

        [DataMember(Name="noteBBlack")]
        BoundingBox NoteBBlack { get; set; }

        [DataMember(Name="noteBFlatBlack")]
        BoundingBox NoteBFlatBlack { get; set; }

        [DataMember(Name="noteBFlatHalf")]
        BoundingBox NoteBFlatHalf { get; set; }

        [DataMember(Name="noteBFlatWhole")]
        BoundingBox NoteBFlatWhole { get; set; }

        [DataMember(Name="noteBHalf")]
        BoundingBox NoteBHalf { get; set; }

        [DataMember(Name="noteBSharpBlack")]
        BoundingBox NoteBSharpBlack { get; set; }

        [DataMember(Name="noteBSharpHalf")]
        BoundingBox NoteBSharpHalf { get; set; }

        [DataMember(Name="noteBSharpWhole")]
        BoundingBox NoteBSharpWhole { get; set; }

        [DataMember(Name="noteBWhole")]
        BoundingBox NoteBWhole { get; set; }

        [DataMember(Name="noteCBlack")]
        BoundingBox NoteCBlack { get; set; }

        [DataMember(Name="noteCFlatBlack")]
        BoundingBox NoteCFlatBlack { get; set; }

        [DataMember(Name="noteCFlatHalf")]
        BoundingBox NoteCFlatHalf { get; set; }

        [DataMember(Name="noteCFlatWhole")]
        BoundingBox NoteCFlatWhole { get; set; }

        [DataMember(Name="noteCHalf")]
        BoundingBox NoteCHalf { get; set; }

        [DataMember(Name="noteCSharpBlack")]
        BoundingBox NoteCSharpBlack { get; set; }

        [DataMember(Name="noteCSharpHalf")]
        BoundingBox NoteCSharpHalf { get; set; }

        [DataMember(Name="noteCSharpWhole")]
        BoundingBox NoteCSharpWhole { get; set; }

        [DataMember(Name="noteCWhole")]
        BoundingBox NoteCWhole { get; set; }

        [DataMember(Name="noteDBlack")]
        BoundingBox NoteDBlack { get; set; }

        [DataMember(Name="noteDFlatBlack")]
        BoundingBox NoteDFlatBlack { get; set; }

        [DataMember(Name="noteDFlatHalf")]
        BoundingBox NoteDFlatHalf { get; set; }

        [DataMember(Name="noteDFlatWhole")]
        BoundingBox NoteDFlatWhole { get; set; }

        [DataMember(Name="noteDHalf")]
        BoundingBox NoteDHalf { get; set; }

        [DataMember(Name="noteDSharpBlack")]
        BoundingBox NoteDSharpBlack { get; set; }

        [DataMember(Name="noteDSharpHalf")]
        BoundingBox NoteDSharpHalf { get; set; }

        [DataMember(Name="noteDSharpWhole")]
        BoundingBox NoteDSharpWhole { get; set; }

        [DataMember(Name="noteDWhole")]
        BoundingBox NoteDWhole { get; set; }

        [DataMember(Name="noteDoBlack")]
        BoundingBox NoteDoBlack { get; set; }

        [DataMember(Name="noteDoHalf")]
        BoundingBox NoteDoHalf { get; set; }

        [DataMember(Name="noteDoWhole")]
        BoundingBox NoteDoWhole { get; set; }

        [DataMember(Name="noteDoubleWhole")]
        BoundingBox NoteDoubleWhole { get; set; }

        [DataMember(Name="noteDoubleWholeAlt")]
        BoundingBox NoteDoubleWholeAlt { get; set; }

        [DataMember(Name="noteDoubleWholeSquare")]
        BoundingBox NoteDoubleWholeSquare { get; set; }

        [DataMember(Name="noteEBlack")]
        BoundingBox NoteEBlack { get; set; }

        [DataMember(Name="noteEFlatBlack")]
        BoundingBox NoteEFlatBlack { get; set; }

        [DataMember(Name="noteEFlatHalf")]
        BoundingBox NoteEFlatHalf { get; set; }

        [DataMember(Name="noteEFlatWhole")]
        BoundingBox NoteEFlatWhole { get; set; }

        [DataMember(Name="noteEHalf")]
        BoundingBox NoteEHalf { get; set; }

        [DataMember(Name="noteESharpBlack")]
        BoundingBox NoteESharpBlack { get; set; }

        [DataMember(Name="noteESharpHalf")]
        BoundingBox NoteESharpHalf { get; set; }

        [DataMember(Name="noteESharpWhole")]
        BoundingBox NoteESharpWhole { get; set; }

        [DataMember(Name="noteEWhole")]
        BoundingBox NoteEWhole { get; set; }

        [DataMember(Name="noteEmptyBlack")]
        BoundingBox NoteEmptyBlack { get; set; }

        [DataMember(Name="noteEmptyHalf")]
        BoundingBox NoteEmptyHalf { get; set; }

        [DataMember(Name="noteEmptyWhole")]
        BoundingBox NoteEmptyWhole { get; set; }

        [DataMember(Name="noteFBlack")]
        BoundingBox NoteFBlack { get; set; }

        [DataMember(Name="noteFFlatBlack")]
        BoundingBox NoteFFlatBlack { get; set; }

        [DataMember(Name="noteFFlatHalf")]
        BoundingBox NoteFFlatHalf { get; set; }

        [DataMember(Name="noteFFlatWhole")]
        BoundingBox NoteFFlatWhole { get; set; }

        [DataMember(Name="noteFHalf")]
        BoundingBox NoteFHalf { get; set; }

        [DataMember(Name="noteFSharpBlack")]
        BoundingBox NoteFSharpBlack { get; set; }

        [DataMember(Name="noteFSharpHalf")]
        BoundingBox NoteFSharpHalf { get; set; }

        [DataMember(Name="noteFSharpWhole")]
        BoundingBox NoteFSharpWhole { get; set; }

        [DataMember(Name="noteFWhole")]
        BoundingBox NoteFWhole { get; set; }

        [DataMember(Name="noteFaBlack")]
        BoundingBox NoteFaBlack { get; set; }

        [DataMember(Name="noteFaHalf")]
        BoundingBox NoteFaHalf { get; set; }

        [DataMember(Name="noteFaWhole")]
        BoundingBox NoteFaWhole { get; set; }

        [DataMember(Name="noteGBlack")]
        BoundingBox NoteGBlack { get; set; }

        [DataMember(Name="noteGFlatBlack")]
        BoundingBox NoteGFlatBlack { get; set; }

        [DataMember(Name="noteGFlatHalf")]
        BoundingBox NoteGFlatHalf { get; set; }

        [DataMember(Name="noteGFlatWhole")]
        BoundingBox NoteGFlatWhole { get; set; }

        [DataMember(Name="noteGHalf")]
        BoundingBox NoteGHalf { get; set; }

        [DataMember(Name="noteGSharpBlack")]
        BoundingBox NoteGSharpBlack { get; set; }

        [DataMember(Name="noteGSharpHalf")]
        BoundingBox NoteGSharpHalf { get; set; }

        [DataMember(Name="noteGSharpWhole")]
        BoundingBox NoteGSharpWhole { get; set; }

        [DataMember(Name="noteGWhole")]
        BoundingBox NoteGWhole { get; set; }

        [DataMember(Name="noteHBlack")]
        BoundingBox NoteHBlack { get; set; }

        [DataMember(Name="noteHHalf")]
        BoundingBox NoteHHalf { get; set; }

        [DataMember(Name="noteHSharpBlack")]
        BoundingBox NoteHSharpBlack { get; set; }

        [DataMember(Name="noteHSharpHalf")]
        BoundingBox NoteHSharpHalf { get; set; }

        [DataMember(Name="noteHSharpWhole")]
        BoundingBox NoteHSharpWhole { get; set; }

        [DataMember(Name="noteHWhole")]
        BoundingBox NoteHWhole { get; set; }

        [DataMember(Name="noteHalfDown")]
        BoundingBox NoteHalfDown { get; set; }

        [DataMember(Name="noteHalfUp")]
        BoundingBox NoteHalfUp { get; set; }

        [DataMember(Name="noteLaBlack")]
        BoundingBox NoteLaBlack { get; set; }

        [DataMember(Name="noteLaHalf")]
        BoundingBox NoteLaHalf { get; set; }

        [DataMember(Name="noteLaWhole")]
        BoundingBox NoteLaWhole { get; set; }

        [DataMember(Name="noteMiBlack")]
        BoundingBox NoteMiBlack { get; set; }

        [DataMember(Name="noteMiHalf")]
        BoundingBox NoteMiHalf { get; set; }

        [DataMember(Name="noteMiWhole")]
        BoundingBox NoteMiWhole { get; set; }

        [DataMember(Name="noteQuarterDown")]
        BoundingBox NoteQuarterDown { get; set; }

        [DataMember(Name="noteQuarterUp")]
        BoundingBox NoteQuarterUp { get; set; }

        [DataMember(Name="noteReBlack")]
        BoundingBox NoteReBlack { get; set; }

        [DataMember(Name="noteReHalf")]
        BoundingBox NoteReHalf { get; set; }

        [DataMember(Name="noteReWhole")]
        BoundingBox NoteReWhole { get; set; }

        [DataMember(Name="noteShapeArrowheadLeftBlack")]
        BoundingBox NoteShapeArrowheadLeftBlack { get; set; }

        [DataMember(Name="noteShapeArrowheadLeftDoubleWhole")]
        BoundingBox NoteShapeArrowheadLeftDoubleWhole { get; set; }

        [DataMember(Name="noteShapeArrowheadLeftWhite")]
        BoundingBox NoteShapeArrowheadLeftWhite { get; set; }

        [DataMember(Name="noteShapeDiamondBlack")]
        BoundingBox NoteShapeDiamondBlack { get; set; }

        [DataMember(Name="noteShapeDiamondDoubleWhole")]
        BoundingBox NoteShapeDiamondDoubleWhole { get; set; }

        [DataMember(Name="noteShapeDiamondWhite")]
        BoundingBox NoteShapeDiamondWhite { get; set; }

        [DataMember(Name="noteShapeIsoscelesTriangleBlack")]
        BoundingBox NoteShapeIsoscelesTriangleBlack { get; set; }

        [DataMember(Name="noteShapeIsoscelesTriangleDoubleWhole")]
        BoundingBox NoteShapeIsoscelesTriangleDoubleWhole { get; set; }

        [DataMember(Name="noteShapeIsoscelesTriangleWhite")]
        BoundingBox NoteShapeIsoscelesTriangleWhite { get; set; }

        [DataMember(Name="noteShapeKeystoneBlack")]
        BoundingBox NoteShapeKeystoneBlack { get; set; }

        [DataMember(Name="noteShapeKeystoneDoubleWhole")]
        BoundingBox NoteShapeKeystoneDoubleWhole { get; set; }

        [DataMember(Name="noteShapeKeystoneWhite")]
        BoundingBox NoteShapeKeystoneWhite { get; set; }

        [DataMember(Name="noteShapeMoonBlack")]
        BoundingBox NoteShapeMoonBlack { get; set; }

        [DataMember(Name="noteShapeMoonDoubleWhole")]
        BoundingBox NoteShapeMoonDoubleWhole { get; set; }

        [DataMember(Name="noteShapeMoonLeftBlack")]
        BoundingBox NoteShapeMoonLeftBlack { get; set; }

        [DataMember(Name="noteShapeMoonLeftDoubleWhole")]
        BoundingBox NoteShapeMoonLeftDoubleWhole { get; set; }

        [DataMember(Name="noteShapeMoonLeftWhite")]
        BoundingBox NoteShapeMoonLeftWhite { get; set; }

        [DataMember(Name="noteShapeMoonWhite")]
        BoundingBox NoteShapeMoonWhite { get; set; }

        [DataMember(Name="noteShapeQuarterMoonBlack")]
        BoundingBox NoteShapeQuarterMoonBlack { get; set; }

        [DataMember(Name="noteShapeQuarterMoonDoubleWhole")]
        BoundingBox NoteShapeQuarterMoonDoubleWhole { get; set; }

        [DataMember(Name="noteShapeQuarterMoonWhite")]
        BoundingBox NoteShapeQuarterMoonWhite { get; set; }

        [DataMember(Name="noteShapeRoundBlack")]
        BoundingBox NoteShapeRoundBlack { get; set; }

        [DataMember(Name="noteShapeRoundDoubleWhole")]
        BoundingBox NoteShapeRoundDoubleWhole { get; set; }

        [DataMember(Name="noteShapeRoundWhite")]
        BoundingBox NoteShapeRoundWhite { get; set; }

        [DataMember(Name="noteShapeSquareBlack")]
        BoundingBox NoteShapeSquareBlack { get; set; }

        [DataMember(Name="noteShapeSquareDoubleWhole")]
        BoundingBox NoteShapeSquareDoubleWhole { get; set; }

        [DataMember(Name="noteShapeSquareWhite")]
        BoundingBox NoteShapeSquareWhite { get; set; }

        [DataMember(Name="noteShapeTriangleLeftBlack")]
        BoundingBox NoteShapeTriangleLeftBlack { get; set; }

        [DataMember(Name="noteShapeTriangleLeftDoubleWhole")]
        BoundingBox NoteShapeTriangleLeftDoubleWhole { get; set; }

        [DataMember(Name="noteShapeTriangleLeftWhite")]
        BoundingBox NoteShapeTriangleLeftWhite { get; set; }

        [DataMember(Name="noteShapeTriangleRightBlack")]
        BoundingBox NoteShapeTriangleRightBlack { get; set; }

        [DataMember(Name="noteShapeTriangleRightDoubleWhole")]
        BoundingBox NoteShapeTriangleRightDoubleWhole { get; set; }

        [DataMember(Name="noteShapeTriangleRightWhite")]
        BoundingBox NoteShapeTriangleRightWhite { get; set; }

        [DataMember(Name="noteShapeTriangleRoundBlack")]
        BoundingBox NoteShapeTriangleRoundBlack { get; set; }

        [DataMember(Name="noteShapeTriangleRoundDoubleWhole")]
        BoundingBox NoteShapeTriangleRoundDoubleWhole { get; set; }

        [DataMember(Name="noteShapeTriangleRoundLeftBlack")]
        BoundingBox NoteShapeTriangleRoundLeftBlack { get; set; }

        [DataMember(Name="noteShapeTriangleRoundLeftDoubleWhole")]
        BoundingBox NoteShapeTriangleRoundLeftDoubleWhole { get; set; }

        [DataMember(Name="noteShapeTriangleRoundLeftWhite")]
        BoundingBox NoteShapeTriangleRoundLeftWhite { get; set; }

        [DataMember(Name="noteShapeTriangleRoundWhite")]
        BoundingBox NoteShapeTriangleRoundWhite { get; set; }

        [DataMember(Name="noteShapeTriangleUpBlack")]
        BoundingBox NoteShapeTriangleUpBlack { get; set; }

        [DataMember(Name="noteShapeTriangleUpDoubleWhole")]
        BoundingBox NoteShapeTriangleUpDoubleWhole { get; set; }

        [DataMember(Name="noteShapeTriangleUpWhite")]
        BoundingBox NoteShapeTriangleUpWhite { get; set; }

        [DataMember(Name="noteSiBlack")]
        BoundingBox NoteSiBlack { get; set; }

        [DataMember(Name="noteSiHalf")]
        BoundingBox NoteSiHalf { get; set; }

        [DataMember(Name="noteSiWhole")]
        BoundingBox NoteSiWhole { get; set; }

        [DataMember(Name="noteSoBlack")]
        BoundingBox NoteSoBlack { get; set; }

        [DataMember(Name="noteSoHalf")]
        BoundingBox NoteSoHalf { get; set; }

        [DataMember(Name="noteSoWhole")]
        BoundingBox NoteSoWhole { get; set; }

        [DataMember(Name="noteTiBlack")]
        BoundingBox NoteTiBlack { get; set; }

        [DataMember(Name="noteTiHalf")]
        BoundingBox NoteTiHalf { get; set; }

        [DataMember(Name="noteTiWhole")]
        BoundingBox NoteTiWhole { get; set; }

        [DataMember(Name="noteWhole")]
        BoundingBox NoteWhole { get; set; }

        [DataMember(Name="noteheadBlack")]
        BoundingBox NoteheadBlack { get; set; }

        [DataMember(Name="noteheadBlackOversized")]
        BoundingBox NoteheadBlackOversized { get; set; }

        [DataMember(Name="noteheadBlackParens")]
        BoundingBox NoteheadBlackParens { get; set; }

        [DataMember(Name="noteheadBlackSmall")]
        BoundingBox NoteheadBlackSmall { get; set; }

        [DataMember(Name="noteheadCircleSlash")]
        BoundingBox NoteheadCircleSlash { get; set; }

        [DataMember(Name="noteheadCircleX")]
        BoundingBox NoteheadCircleX { get; set; }

        [DataMember(Name="noteheadCircleXDoubleWhole")]
        BoundingBox NoteheadCircleXDoubleWhole { get; set; }

        [DataMember(Name="noteheadCircleXHalf")]
        BoundingBox NoteheadCircleXHalf { get; set; }

        [DataMember(Name="noteheadCircleXWhole")]
        BoundingBox NoteheadCircleXWhole { get; set; }

        [DataMember(Name="noteheadCircledBlack")]
        BoundingBox NoteheadCircledBlack { get; set; }

        [DataMember(Name="noteheadCircledBlackLarge")]
        BoundingBox NoteheadCircledBlackLarge { get; set; }

        [DataMember(Name="noteheadCircledDoubleWhole")]
        BoundingBox NoteheadCircledDoubleWhole { get; set; }

        [DataMember(Name="noteheadCircledDoubleWholeLarge")]
        BoundingBox NoteheadCircledDoubleWholeLarge { get; set; }

        [DataMember(Name="noteheadCircledHalf")]
        BoundingBox NoteheadCircledHalf { get; set; }

        [DataMember(Name="noteheadCircledHalfLarge")]
        BoundingBox NoteheadCircledHalfLarge { get; set; }

        [DataMember(Name="noteheadCircledWhole")]
        BoundingBox NoteheadCircledWhole { get; set; }

        [DataMember(Name="noteheadCircledWholeLarge")]
        BoundingBox NoteheadCircledWholeLarge { get; set; }

        [DataMember(Name="noteheadCircledXLarge")]
        BoundingBox NoteheadCircledXLarge { get; set; }

        [DataMember(Name="noteheadClusterDoubleWhole2nd")]
        BoundingBox NoteheadClusterDoubleWhole2Nd { get; set; }

        [DataMember(Name="noteheadClusterDoubleWhole3rd")]
        BoundingBox NoteheadClusterDoubleWhole3Rd { get; set; }

        [DataMember(Name="noteheadClusterDoubleWholeBottom")]
        BoundingBox NoteheadClusterDoubleWholeBottom { get; set; }

        [DataMember(Name="noteheadClusterDoubleWholeMiddle")]
        BoundingBox NoteheadClusterDoubleWholeMiddle { get; set; }

        [DataMember(Name="noteheadClusterDoubleWholeTop")]
        BoundingBox NoteheadClusterDoubleWholeTop { get; set; }

        [DataMember(Name="noteheadClusterHalf2nd")]
        BoundingBox NoteheadClusterHalf2Nd { get; set; }

        [DataMember(Name="noteheadClusterHalf3rd")]
        BoundingBox NoteheadClusterHalf3Rd { get; set; }

        [DataMember(Name="noteheadClusterHalfBottom")]
        BoundingBox NoteheadClusterHalfBottom { get; set; }

        [DataMember(Name="noteheadClusterHalfMiddle")]
        BoundingBox NoteheadClusterHalfMiddle { get; set; }

        [DataMember(Name="noteheadClusterHalfTop")]
        BoundingBox NoteheadClusterHalfTop { get; set; }

        [DataMember(Name="noteheadClusterQuarter2nd")]
        BoundingBox NoteheadClusterQuarter2Nd { get; set; }

        [DataMember(Name="noteheadClusterQuarter3rd")]
        BoundingBox NoteheadClusterQuarter3Rd { get; set; }

        [DataMember(Name="noteheadClusterQuarterBottom")]
        BoundingBox NoteheadClusterQuarterBottom { get; set; }

        [DataMember(Name="noteheadClusterQuarterMiddle")]
        BoundingBox NoteheadClusterQuarterMiddle { get; set; }

        [DataMember(Name="noteheadClusterQuarterTop")]
        BoundingBox NoteheadClusterQuarterTop { get; set; }

        [DataMember(Name="noteheadClusterRoundBlack")]
        BoundingBox NoteheadClusterRoundBlack { get; set; }

        [DataMember(Name="noteheadClusterRoundWhite")]
        BoundingBox NoteheadClusterRoundWhite { get; set; }

        [DataMember(Name="noteheadClusterSquareBlack")]
        BoundingBox NoteheadClusterSquareBlack { get; set; }

        [DataMember(Name="noteheadClusterSquareWhite")]
        BoundingBox NoteheadClusterSquareWhite { get; set; }

        [DataMember(Name="noteheadClusterWhole2nd")]
        BoundingBox NoteheadClusterWhole2Nd { get; set; }

        [DataMember(Name="noteheadClusterWhole3rd")]
        BoundingBox NoteheadClusterWhole3Rd { get; set; }

        [DataMember(Name="noteheadClusterWholeBottom")]
        BoundingBox NoteheadClusterWholeBottom { get; set; }

        [DataMember(Name="noteheadClusterWholeMiddle")]
        BoundingBox NoteheadClusterWholeMiddle { get; set; }

        [DataMember(Name="noteheadClusterWholeTop")]
        BoundingBox NoteheadClusterWholeTop { get; set; }

        [DataMember(Name="noteheadDiamondBlack")]
        BoundingBox NoteheadDiamondBlack { get; set; }

        [DataMember(Name="noteheadDiamondBlackOld")]
        BoundingBox NoteheadDiamondBlackOld { get; set; }

        [DataMember(Name="noteheadDiamondBlackWide")]
        BoundingBox NoteheadDiamondBlackWide { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlack2nd")]
        BoundingBox NoteheadDiamondClusterBlack2Nd { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlack3rd")]
        BoundingBox NoteheadDiamondClusterBlack3Rd { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlackBottom")]
        BoundingBox NoteheadDiamondClusterBlackBottom { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlackMiddle")]
        BoundingBox NoteheadDiamondClusterBlackMiddle { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlackTop")]
        BoundingBox NoteheadDiamondClusterBlackTop { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhite2nd")]
        BoundingBox NoteheadDiamondClusterWhite2Nd { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhite3rd")]
        BoundingBox NoteheadDiamondClusterWhite3Rd { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhiteBottom")]
        BoundingBox NoteheadDiamondClusterWhiteBottom { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhiteMiddle")]
        BoundingBox NoteheadDiamondClusterWhiteMiddle { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhiteTop")]
        BoundingBox NoteheadDiamondClusterWhiteTop { get; set; }

        [DataMember(Name="noteheadDiamondDoubleWhole")]
        BoundingBox NoteheadDiamondDoubleWhole { get; set; }

        [DataMember(Name="noteheadDiamondDoubleWholeOld")]
        BoundingBox NoteheadDiamondDoubleWholeOld { get; set; }

        [DataMember(Name="noteheadDiamondHalf")]
        BoundingBox NoteheadDiamondHalf { get; set; }

        [DataMember(Name="noteheadDiamondHalfFilled")]
        BoundingBox NoteheadDiamondHalfFilled { get; set; }

        [DataMember(Name="noteheadDiamondHalfOld")]
        BoundingBox NoteheadDiamondHalfOld { get; set; }

        [DataMember(Name="noteheadDiamondHalfWide")]
        BoundingBox NoteheadDiamondHalfWide { get; set; }

        [DataMember(Name="noteheadDiamondOpen")]
        BoundingBox NoteheadDiamondOpen { get; set; }

        [DataMember(Name="noteheadDiamondWhite")]
        BoundingBox NoteheadDiamondWhite { get; set; }

        [DataMember(Name="noteheadDiamondWhiteWide")]
        BoundingBox NoteheadDiamondWhiteWide { get; set; }

        [DataMember(Name="noteheadDiamondWhole")]
        BoundingBox NoteheadDiamondWhole { get; set; }

        [DataMember(Name="noteheadDiamondWholeOld")]
        BoundingBox NoteheadDiamondWholeOld { get; set; }

        [DataMember(Name="noteheadDoubleWhole")]
        BoundingBox NoteheadDoubleWhole { get; set; }

        [DataMember(Name="noteheadDoubleWholeAlt")]
        BoundingBox NoteheadDoubleWholeAlt { get; set; }

        [DataMember(Name="noteheadDoubleWholeOversized")]
        BoundingBox NoteheadDoubleWholeOversized { get; set; }

        [DataMember(Name="noteheadDoubleWholeParens")]
        BoundingBox NoteheadDoubleWholeParens { get; set; }

        [DataMember(Name="noteheadDoubleWholeSmall")]
        BoundingBox NoteheadDoubleWholeSmall { get; set; }

        [DataMember(Name="noteheadDoubleWholeSquare")]
        BoundingBox NoteheadDoubleWholeSquare { get; set; }

        [DataMember(Name="noteheadDoubleWholeSquareOversized")]
        BoundingBox NoteheadDoubleWholeSquareOversized { get; set; }

        [DataMember(Name="noteheadDoubleWholeWithX")]
        BoundingBox NoteheadDoubleWholeWithX { get; set; }

        [DataMember(Name="noteheadHalf")]
        BoundingBox NoteheadHalf { get; set; }

        [DataMember(Name="noteheadHalfFilled")]
        BoundingBox NoteheadHalfFilled { get; set; }

        [DataMember(Name="noteheadHalfOversized")]
        BoundingBox NoteheadHalfOversized { get; set; }

        [DataMember(Name="noteheadHalfParens")]
        BoundingBox NoteheadHalfParens { get; set; }

        [DataMember(Name="noteheadHalfSmall")]
        BoundingBox NoteheadHalfSmall { get; set; }

        [DataMember(Name="noteheadHalfWithX")]
        BoundingBox NoteheadHalfWithX { get; set; }

        [DataMember(Name="noteheadHeavyX")]
        BoundingBox NoteheadHeavyX { get; set; }

        [DataMember(Name="noteheadHeavyXHat")]
        BoundingBox NoteheadHeavyXHat { get; set; }

        [DataMember(Name="noteheadLargeArrowDownBlack")]
        BoundingBox NoteheadLargeArrowDownBlack { get; set; }

        [DataMember(Name="noteheadLargeArrowDownDoubleWhole")]
        BoundingBox NoteheadLargeArrowDownDoubleWhole { get; set; }

        [DataMember(Name="noteheadLargeArrowDownHalf")]
        BoundingBox NoteheadLargeArrowDownHalf { get; set; }

        [DataMember(Name="noteheadLargeArrowDownWhole")]
        BoundingBox NoteheadLargeArrowDownWhole { get; set; }

        [DataMember(Name="noteheadLargeArrowUpBlack")]
        BoundingBox NoteheadLargeArrowUpBlack { get; set; }

        [DataMember(Name="noteheadLargeArrowUpDoubleWhole")]
        BoundingBox NoteheadLargeArrowUpDoubleWhole { get; set; }

        [DataMember(Name="noteheadLargeArrowUpHalf")]
        BoundingBox NoteheadLargeArrowUpHalf { get; set; }

        [DataMember(Name="noteheadLargeArrowUpWhole")]
        BoundingBox NoteheadLargeArrowUpWhole { get; set; }

        [DataMember(Name="noteheadMoonBlack")]
        BoundingBox NoteheadMoonBlack { get; set; }

        [DataMember(Name="noteheadMoonWhite")]
        BoundingBox NoteheadMoonWhite { get; set; }

        [DataMember(Name="noteheadParenthesis")]
        BoundingBox NoteheadParenthesis { get; set; }

        [DataMember(Name="noteheadParenthesisLeft")]
        BoundingBox NoteheadParenthesisLeft { get; set; }

        [DataMember(Name="noteheadParenthesisRight")]
        BoundingBox NoteheadParenthesisRight { get; set; }

        [DataMember(Name="noteheadPlusBlack")]
        BoundingBox NoteheadPlusBlack { get; set; }

        [DataMember(Name="noteheadPlusDoubleWhole")]
        BoundingBox NoteheadPlusDoubleWhole { get; set; }

        [DataMember(Name="noteheadPlusHalf")]
        BoundingBox NoteheadPlusHalf { get; set; }

        [DataMember(Name="noteheadPlusWhole")]
        BoundingBox NoteheadPlusWhole { get; set; }

        [DataMember(Name="noteheadRectangularClusterBlackBottom")]
        BoundingBox NoteheadRectangularClusterBlackBottom { get; set; }

        [DataMember(Name="noteheadRectangularClusterBlackMiddle")]
        BoundingBox NoteheadRectangularClusterBlackMiddle { get; set; }

        [DataMember(Name="noteheadRectangularClusterBlackTop")]
        BoundingBox NoteheadRectangularClusterBlackTop { get; set; }

        [DataMember(Name="noteheadRectangularClusterWhiteBottom")]
        BoundingBox NoteheadRectangularClusterWhiteBottom { get; set; }

        [DataMember(Name="noteheadRectangularClusterWhiteMiddle")]
        BoundingBox NoteheadRectangularClusterWhiteMiddle { get; set; }

        [DataMember(Name="noteheadRectangularClusterWhiteTop")]
        BoundingBox NoteheadRectangularClusterWhiteTop { get; set; }

        [DataMember(Name="noteheadRoundBlack")]
        BoundingBox NoteheadRoundBlack { get; set; }

        [DataMember(Name="noteheadRoundBlackDoubleSlashed")]
        BoundingBox NoteheadRoundBlackDoubleSlashed { get; set; }

        [DataMember(Name="noteheadRoundBlackLarge")]
        Dictionary<string, long[]> NoteheadRoundBlackLarge { get; set; }

        [DataMember(Name="noteheadRoundBlackSlashed")]
        BoundingBox NoteheadRoundBlackSlashed { get; set; }

        [DataMember(Name="noteheadRoundBlackSlashedLarge")]
        BoundingBox NoteheadRoundBlackSlashedLarge { get; set; }

        [DataMember(Name="noteheadRoundWhite")]
        BoundingBox NoteheadRoundWhite { get; set; }

        [DataMember(Name="noteheadRoundWhiteDoubleSlashed")]
        BoundingBox NoteheadRoundWhiteDoubleSlashed { get; set; }

        [DataMember(Name="noteheadRoundWhiteLarge")]
        Dictionary<string, long[]> NoteheadRoundWhiteLarge { get; set; }

        [DataMember(Name="noteheadRoundWhiteSlashed")]
        BoundingBox NoteheadRoundWhiteSlashed { get; set; }

        [DataMember(Name="noteheadRoundWhiteSlashedLarge")]
        BoundingBox NoteheadRoundWhiteSlashedLarge { get; set; }

        [DataMember(Name="noteheadRoundWhiteWithDot")]
        BoundingBox NoteheadRoundWhiteWithDot { get; set; }

        [DataMember(Name="noteheadRoundWhiteWithDotLarge")]
        BoundingBox NoteheadRoundWhiteWithDotLarge { get; set; }

        [DataMember(Name="noteheadSlashDiamondWhite")]
        Dictionary<string, long[]> NoteheadSlashDiamondWhite { get; set; }

        [DataMember(Name="noteheadSlashHorizontalEnds")]
        BoundingBox NoteheadSlashHorizontalEnds { get; set; }

        [DataMember(Name="noteheadSlashHorizontalEndsMuted")]
        BoundingBox NoteheadSlashHorizontalEndsMuted { get; set; }

        [DataMember(Name="noteheadSlashVerticalEnds")]
        BoundingBox NoteheadSlashVerticalEnds { get; set; }

        [DataMember(Name="noteheadSlashVerticalEndsMuted")]
        BoundingBox NoteheadSlashVerticalEndsMuted { get; set; }

        [DataMember(Name="noteheadSlashVerticalEndsSmall")]
        BoundingBox NoteheadSlashVerticalEndsSmall { get; set; }

        [DataMember(Name="noteheadSlashWhiteDoubleWhole")]
        BoundingBox NoteheadSlashWhiteDoubleWhole { get; set; }

        [DataMember(Name="noteheadSlashWhiteHalf")]
        BoundingBox NoteheadSlashWhiteHalf { get; set; }

        [DataMember(Name="noteheadSlashWhiteMuted")]
        BoundingBox NoteheadSlashWhiteMuted { get; set; }

        [DataMember(Name="noteheadSlashWhiteWhole")]
        BoundingBox NoteheadSlashWhiteWhole { get; set; }

        [DataMember(Name="noteheadSlashX")]
        BoundingBox NoteheadSlashX { get; set; }

        [DataMember(Name="noteheadSlashedBlack1")]
        BoundingBox NoteheadSlashedBlack1 { get; set; }

        [DataMember(Name="noteheadSlashedBlack2")]
        BoundingBox NoteheadSlashedBlack2 { get; set; }

        [DataMember(Name="noteheadSlashedDoubleWhole1")]
        BoundingBox NoteheadSlashedDoubleWhole1 { get; set; }

        [DataMember(Name="noteheadSlashedDoubleWhole2")]
        BoundingBox NoteheadSlashedDoubleWhole2 { get; set; }

        [DataMember(Name="noteheadSlashedHalf1")]
        BoundingBox NoteheadSlashedHalf1 { get; set; }

        [DataMember(Name="noteheadSlashedHalf2")]
        BoundingBox NoteheadSlashedHalf2 { get; set; }

        [DataMember(Name="noteheadSlashedWhole1")]
        BoundingBox NoteheadSlashedWhole1 { get; set; }

        [DataMember(Name="noteheadSlashedWhole2")]
        BoundingBox NoteheadSlashedWhole2 { get; set; }

        [DataMember(Name="noteheadSquareBlack")]
        BoundingBox NoteheadSquareBlack { get; set; }

        [DataMember(Name="noteheadSquareBlackLarge")]
        Dictionary<string, long[]> NoteheadSquareBlackLarge { get; set; }

        [DataMember(Name="noteheadSquareBlackWhite")]
        Dictionary<string, long[]> NoteheadSquareBlackWhite { get; set; }

        [DataMember(Name="noteheadSquareWhite")]
        BoundingBox NoteheadSquareWhite { get; set; }

        [DataMember(Name="noteheadTriangleDownBlack")]
        BoundingBox NoteheadTriangleDownBlack { get; set; }

        [DataMember(Name="noteheadTriangleDownDoubleWhole")]
        BoundingBox NoteheadTriangleDownDoubleWhole { get; set; }

        [DataMember(Name="noteheadTriangleDownHalf")]
        BoundingBox NoteheadTriangleDownHalf { get; set; }

        [DataMember(Name="noteheadTriangleDownWhite")]
        BoundingBox NoteheadTriangleDownWhite { get; set; }

        [DataMember(Name="noteheadTriangleDownWhole")]
        BoundingBox NoteheadTriangleDownWhole { get; set; }

        [DataMember(Name="noteheadTriangleLeftBlack")]
        BoundingBox NoteheadTriangleLeftBlack { get; set; }

        [DataMember(Name="noteheadTriangleLeftWhite")]
        BoundingBox NoteheadTriangleLeftWhite { get; set; }

        [DataMember(Name="noteheadTriangleRightBlack")]
        BoundingBox NoteheadTriangleRightBlack { get; set; }

        [DataMember(Name="noteheadTriangleRightWhite")]
        BoundingBox NoteheadTriangleRightWhite { get; set; }

        [DataMember(Name="noteheadTriangleRoundDownBlack")]
        BoundingBox NoteheadTriangleRoundDownBlack { get; set; }

        [DataMember(Name="noteheadTriangleRoundDownWhite")]
        BoundingBox NoteheadTriangleRoundDownWhite { get; set; }

        [DataMember(Name="noteheadTriangleUpBlack")]
        BoundingBox NoteheadTriangleUpBlack { get; set; }

        [DataMember(Name="noteheadTriangleUpDoubleWhole")]
        BoundingBox NoteheadTriangleUpDoubleWhole { get; set; }

        [DataMember(Name="noteheadTriangleUpHalf")]
        BoundingBox NoteheadTriangleUpHalf { get; set; }

        [DataMember(Name="noteheadTriangleUpRightBlack")]
        BoundingBox NoteheadTriangleUpRightBlack { get; set; }

        [DataMember(Name="noteheadTriangleUpRightWhite")]
        BoundingBox NoteheadTriangleUpRightWhite { get; set; }

        [DataMember(Name="noteheadTriangleUpWhite")]
        BoundingBox NoteheadTriangleUpWhite { get; set; }

        [DataMember(Name="noteheadTriangleUpWhole")]
        BoundingBox NoteheadTriangleUpWhole { get; set; }

        [DataMember(Name="noteheadVoidWithX")]
        BoundingBox NoteheadVoidWithX { get; set; }

        [DataMember(Name="noteheadWhole")]
        BoundingBox NoteheadWhole { get; set; }

        [DataMember(Name="noteheadWholeFilled")]
        BoundingBox NoteheadWholeFilled { get; set; }

        [DataMember(Name="noteheadWholeOversized")]
        BoundingBox NoteheadWholeOversized { get; set; }

        [DataMember(Name="noteheadWholeParens")]
        BoundingBox NoteheadWholeParens { get; set; }

        [DataMember(Name="noteheadWholeSmall")]
        BoundingBox NoteheadWholeSmall { get; set; }

        [DataMember(Name="noteheadWholeWithX")]
        BoundingBox NoteheadWholeWithX { get; set; }

        [DataMember(Name="noteheadXBlack")]
        BoundingBox NoteheadXBlack { get; set; }

        [DataMember(Name="noteheadXDoubleWhole")]
        BoundingBox NoteheadXDoubleWhole { get; set; }

        [DataMember(Name="noteheadXHalf")]
        BoundingBox NoteheadXHalf { get; set; }

        [DataMember(Name="noteheadXOrnate")]
        BoundingBox NoteheadXOrnate { get; set; }

        [DataMember(Name="noteheadXOrnateEllipse")]
        BoundingBox NoteheadXOrnateEllipse { get; set; }

        [DataMember(Name="noteheadXWhole")]
        BoundingBox NoteheadXWhole { get; set; }

        [DataMember(Name="octaveBaselineA")]
        BoundingBox OctaveBaselineA { get; set; }

        [DataMember(Name="octaveBaselineB")]
        BoundingBox OctaveBaselineB { get; set; }

        [DataMember(Name="octaveBaselineM")]
        BoundingBox OctaveBaselineM { get; set; }

        [DataMember(Name="octaveBaselineV")]
        BoundingBox OctaveBaselineV { get; set; }

        [DataMember(Name="octaveBassa")]
        BoundingBox OctaveBassa { get; set; }

        [DataMember(Name="octaveLoco")]
        BoundingBox OctaveLoco { get; set; }

        [DataMember(Name="octaveParensLeft")]
        BoundingBox OctaveParensLeft { get; set; }

        [DataMember(Name="octaveParensRight")]
        BoundingBox OctaveParensRight { get; set; }

        [DataMember(Name="octaveSuperscriptA")]
        BoundingBox OctaveSuperscriptA { get; set; }

        [DataMember(Name="octaveSuperscriptB")]
        BoundingBox OctaveSuperscriptB { get; set; }

        [DataMember(Name="octaveSuperscriptM")]
        BoundingBox OctaveSuperscriptM { get; set; }

        [DataMember(Name="octaveSuperscriptV")]
        BoundingBox OctaveSuperscriptV { get; set; }

        [DataMember(Name="ornamentBottomLeftConcaveStroke")]
        BoundingBox OrnamentBottomLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentBottomLeftConcaveStrokeLarge")]
        BoundingBox OrnamentBottomLeftConcaveStrokeLarge { get; set; }

        [DataMember(Name="ornamentBottomLeftConvexStroke")]
        BoundingBox OrnamentBottomLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentBottomRightConcaveStroke")]
        BoundingBox OrnamentBottomRightConcaveStroke { get; set; }

        [DataMember(Name="ornamentBottomRightConvexStroke")]
        BoundingBox OrnamentBottomRightConvexStroke { get; set; }

        [DataMember(Name="ornamentComma")]
        BoundingBox OrnamentComma { get; set; }

        [DataMember(Name="ornamentDoubleObliqueLinesAfterNote")]
        BoundingBox OrnamentDoubleObliqueLinesAfterNote { get; set; }

        [DataMember(Name="ornamentDoubleObliqueLinesBeforeNote")]
        BoundingBox OrnamentDoubleObliqueLinesBeforeNote { get; set; }

        [DataMember(Name="ornamentDownCurve")]
        BoundingBox OrnamentDownCurve { get; set; }

        [DataMember(Name="ornamentHaydn")]
        BoundingBox OrnamentHaydn { get; set; }

        [DataMember(Name="ornamentHighLeftConcaveStroke")]
        BoundingBox OrnamentHighLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentHighLeftConvexStroke")]
        BoundingBox OrnamentHighLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentHighRightConcaveStroke")]
        BoundingBox OrnamentHighRightConcaveStroke { get; set; }

        [DataMember(Name="ornamentHighRightConvexStroke")]
        BoundingBox OrnamentHighRightConvexStroke { get; set; }

        [DataMember(Name="ornamentHookAfterNote")]
        BoundingBox OrnamentHookAfterNote { get; set; }

        [DataMember(Name="ornamentHookBeforeNote")]
        BoundingBox OrnamentHookBeforeNote { get; set; }

        [DataMember(Name="ornamentLeftFacingHalfCircle")]
        BoundingBox OrnamentLeftFacingHalfCircle { get; set; }

        [DataMember(Name="ornamentLeftFacingHook")]
        BoundingBox OrnamentLeftFacingHook { get; set; }

        [DataMember(Name="ornamentLeftPlus")]
        BoundingBox OrnamentLeftPlus { get; set; }

        [DataMember(Name="ornamentLeftShakeT")]
        BoundingBox OrnamentLeftShakeT { get; set; }

        [DataMember(Name="ornamentLeftVerticalStroke")]
        BoundingBox OrnamentLeftVerticalStroke { get; set; }

        [DataMember(Name="ornamentLeftVerticalStrokeWithCross")]
        BoundingBox OrnamentLeftVerticalStrokeWithCross { get; set; }

        [DataMember(Name="ornamentLowLeftConcaveStroke")]
        BoundingBox OrnamentLowLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentLowLeftConvexStroke")]
        BoundingBox OrnamentLowLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentLowRightConcaveStroke")]
        BoundingBox OrnamentLowRightConcaveStroke { get; set; }

        [DataMember(Name="ornamentLowRightConvexStroke")]
        BoundingBox OrnamentLowRightConvexStroke { get; set; }

        [DataMember(Name="ornamentMiddleVerticalStroke")]
        BoundingBox OrnamentMiddleVerticalStroke { get; set; }

        [DataMember(Name="ornamentMordent")]
        BoundingBox OrnamentMordent { get; set; }

        [DataMember(Name="ornamentMordentInverted")]
        BoundingBox OrnamentMordentInverted { get; set; }

        [DataMember(Name="ornamentObliqueLineAfterNote")]
        BoundingBox OrnamentObliqueLineAfterNote { get; set; }

        [DataMember(Name="ornamentObliqueLineBeforeNote")]
        BoundingBox OrnamentObliqueLineBeforeNote { get; set; }

        [DataMember(Name="ornamentObliqueLineHorizAfterNote")]
        BoundingBox OrnamentObliqueLineHorizAfterNote { get; set; }

        [DataMember(Name="ornamentObliqueLineHorizBeforeNote")]
        BoundingBox OrnamentObliqueLineHorizBeforeNote { get; set; }

        [DataMember(Name="ornamentOriscus")]
        BoundingBox OrnamentOriscus { get; set; }

        [DataMember(Name="ornamentPinceCouperin")]
        BoundingBox OrnamentPinceCouperin { get; set; }

        [DataMember(Name="ornamentPortDeVoixV")]
        BoundingBox OrnamentPortDeVoixV { get; set; }

        [DataMember(Name="ornamentPrecompAppoggTrill")]
        BoundingBox OrnamentPrecompAppoggTrill { get; set; }

        [DataMember(Name="ornamentPrecompAppoggTrillSuffix")]
        BoundingBox OrnamentPrecompAppoggTrillSuffix { get; set; }

        [DataMember(Name="ornamentPrecompCadence")]
        BoundingBox OrnamentPrecompCadence { get; set; }

        [DataMember(Name="ornamentPrecompCadenceUpperPrefix")]
        BoundingBox OrnamentPrecompCadenceUpperPrefix { get; set; }

        [DataMember(Name="ornamentPrecompCadenceUpperPrefixTurn")]
        BoundingBox OrnamentPrecompCadenceUpperPrefixTurn { get; set; }

        [DataMember(Name="ornamentPrecompCadenceWithTurn")]
        BoundingBox OrnamentPrecompCadenceWithTurn { get; set; }

        [DataMember(Name="ornamentPrecompDescendingSlide")]
        BoundingBox OrnamentPrecompDescendingSlide { get; set; }

        [DataMember(Name="ornamentPrecompDoubleCadenceLowerPrefix")]
        BoundingBox OrnamentPrecompDoubleCadenceLowerPrefix { get; set; }

        [DataMember(Name="ornamentPrecompDoubleCadenceUpperPrefix")]
        BoundingBox OrnamentPrecompDoubleCadenceUpperPrefix { get; set; }

        [DataMember(Name="ornamentPrecompDoubleCadenceUpperPrefixTurn")]
        BoundingBox OrnamentPrecompDoubleCadenceUpperPrefixTurn { get; set; }

        [DataMember(Name="ornamentPrecompInvertedMordentUpperPrefix")]
        BoundingBox OrnamentPrecompInvertedMordentUpperPrefix { get; set; }

        [DataMember(Name="ornamentPrecompMordentRelease")]
        BoundingBox OrnamentPrecompMordentRelease { get; set; }

        [DataMember(Name="ornamentPrecompMordentUpperPrefix")]
        BoundingBox OrnamentPrecompMordentUpperPrefix { get; set; }

        [DataMember(Name="ornamentPrecompPortDeVoixMordent")]
        BoundingBox OrnamentPrecompPortDeVoixMordent { get; set; }

        [DataMember(Name="ornamentPrecompSlide")]
        BoundingBox OrnamentPrecompSlide { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillBach")]
        BoundingBox OrnamentPrecompSlideTrillBach { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillDAnglebert")]
        BoundingBox OrnamentPrecompSlideTrillDAnglebert { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillMarpurg")]
        BoundingBox OrnamentPrecompSlideTrillMarpurg { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillMuffat")]
        BoundingBox OrnamentPrecompSlideTrillMuffat { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillSuffixMuffat")]
        BoundingBox OrnamentPrecompSlideTrillSuffixMuffat { get; set; }

        [DataMember(Name="ornamentPrecompTrillLowerSuffix")]
        BoundingBox OrnamentPrecompTrillLowerSuffix { get; set; }

        [DataMember(Name="ornamentPrecompTrillSuffixDandrieu")]
        BoundingBox OrnamentPrecompTrillSuffixDandrieu { get; set; }

        [DataMember(Name="ornamentPrecompTrillWithMordent")]
        BoundingBox OrnamentPrecompTrillWithMordent { get; set; }

        [DataMember(Name="ornamentPrecompTurnTrillBach")]
        BoundingBox OrnamentPrecompTurnTrillBach { get; set; }

        [DataMember(Name="ornamentPrecompTurnTrillDAnglebert")]
        BoundingBox OrnamentPrecompTurnTrillDAnglebert { get; set; }

        [DataMember(Name="ornamentQuilisma")]
        BoundingBox OrnamentQuilisma { get; set; }

        [DataMember(Name="ornamentRightFacingHalfCircle")]
        BoundingBox OrnamentRightFacingHalfCircle { get; set; }

        [DataMember(Name="ornamentRightFacingHook")]
        BoundingBox OrnamentRightFacingHook { get; set; }

        [DataMember(Name="ornamentRightVerticalStroke")]
        BoundingBox OrnamentRightVerticalStroke { get; set; }

        [DataMember(Name="ornamentSchleifer")]
        BoundingBox OrnamentSchleifer { get; set; }

        [DataMember(Name="ornamentShake3")]
        BoundingBox OrnamentShake3 { get; set; }

        [DataMember(Name="ornamentShakeMuffat1")]
        BoundingBox OrnamentShakeMuffat1 { get; set; }

        [DataMember(Name="ornamentShortObliqueLineAfterNote")]
        BoundingBox OrnamentShortObliqueLineAfterNote { get; set; }

        [DataMember(Name="ornamentShortObliqueLineBeforeNote")]
        BoundingBox OrnamentShortObliqueLineBeforeNote { get; set; }

        [DataMember(Name="ornamentTopLeftConcaveStroke")]
        BoundingBox OrnamentTopLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentTopLeftConvexStroke")]
        BoundingBox OrnamentTopLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentTopRightConcaveStroke")]
        BoundingBox OrnamentTopRightConcaveStroke { get; set; }

        [DataMember(Name="ornamentTopRightConvexStroke")]
        BoundingBox OrnamentTopRightConvexStroke { get; set; }

        [DataMember(Name="ornamentTremblement")]
        BoundingBox OrnamentTremblement { get; set; }

        [DataMember(Name="ornamentTremblementCouperin")]
        BoundingBox OrnamentTremblementCouperin { get; set; }

        [DataMember(Name="ornamentTrill")]
        BoundingBox OrnamentTrill { get; set; }

        [DataMember(Name="ornamentTrillFlatAbove")]
        BoundingBox OrnamentTrillFlatAbove { get; set; }

        [DataMember(Name="ornamentTrillNaturalAbove")]
        BoundingBox OrnamentTrillNaturalAbove { get; set; }

        [DataMember(Name="ornamentTrillSharpAbove")]
        BoundingBox OrnamentTrillSharpAbove { get; set; }

        [DataMember(Name="ornamentTurn")]
        BoundingBox OrnamentTurn { get; set; }

        [DataMember(Name="ornamentTurnFlatAbove")]
        BoundingBox OrnamentTurnFlatAbove { get; set; }

        [DataMember(Name="ornamentTurnFlatAboveSharpBelow")]
        BoundingBox OrnamentTurnFlatAboveSharpBelow { get; set; }

        [DataMember(Name="ornamentTurnFlatBelow")]
        BoundingBox OrnamentTurnFlatBelow { get; set; }

        [DataMember(Name="ornamentTurnInverted")]
        BoundingBox OrnamentTurnInverted { get; set; }

        [DataMember(Name="ornamentTurnNaturalAbove")]
        BoundingBox OrnamentTurnNaturalAbove { get; set; }

        [DataMember(Name="ornamentTurnNaturalBelow")]
        BoundingBox OrnamentTurnNaturalBelow { get; set; }

        [DataMember(Name="ornamentTurnSharpAbove")]
        BoundingBox OrnamentTurnSharpAbove { get; set; }

        [DataMember(Name="ornamentTurnSharpAboveFlatBelow")]
        BoundingBox OrnamentTurnSharpAboveFlatBelow { get; set; }

        [DataMember(Name="ornamentTurnSharpBelow")]
        BoundingBox OrnamentTurnSharpBelow { get; set; }

        [DataMember(Name="ornamentTurnSlash")]
        BoundingBox OrnamentTurnSlash { get; set; }

        [DataMember(Name="ornamentTurnUp")]
        BoundingBox OrnamentTurnUp { get; set; }

        [DataMember(Name="ornamentTurnUpS")]
        BoundingBox OrnamentTurnUpS { get; set; }

        [DataMember(Name="ornamentUpCurve")]
        BoundingBox OrnamentUpCurve { get; set; }

        [DataMember(Name="ornamentVerticalLine")]
        BoundingBox OrnamentVerticalLine { get; set; }

        [DataMember(Name="ornamentZigZagLineNoRightEnd")]
        BoundingBox OrnamentZigZagLineNoRightEnd { get; set; }

        [DataMember(Name="ornamentZigZagLineWithRightEnd")]
        BoundingBox OrnamentZigZagLineWithRightEnd { get; set; }

        [DataMember(Name="ottava")]
        BoundingBox Ottava { get; set; }

        [DataMember(Name="ottavaAlta")]
        BoundingBox OttavaAlta { get; set; }

        [DataMember(Name="ottavaBassa")]
        BoundingBox OttavaBassa { get; set; }

        [DataMember(Name="ottavaBassaBa")]
        BoundingBox OttavaBassaBa { get; set; }

        [DataMember(Name="ottavaBassaVb")]
        BoundingBox OttavaBassaVb { get; set; }

        [DataMember(Name="pendereckiTremolo")]
        BoundingBox PendereckiTremolo { get; set; }

        [DataMember(Name="pictAgogo")]
        BoundingBox PictAgogo { get; set; }

        [DataMember(Name="pictAlmglocken")]
        BoundingBox PictAlmglocken { get; set; }

        [DataMember(Name="pictAnvil")]
        BoundingBox PictAnvil { get; set; }

        [DataMember(Name="pictBambooChimes")]
        BoundingBox PictBambooChimes { get; set; }

        [DataMember(Name="pictBambooScraper")]
        BoundingBox PictBambooScraper { get; set; }

        [DataMember(Name="pictBassDrum")]
        BoundingBox PictBassDrum { get; set; }

        [DataMember(Name="pictBassDrumOnSide")]
        BoundingBox PictBassDrumOnSide { get; set; }

        [DataMember(Name="pictBassDrumPeinkofer")]
        BoundingBox PictBassDrumPeinkofer { get; set; }

        [DataMember(Name="pictBeaterBow")]
        BoundingBox PictBeaterBow { get; set; }

        [DataMember(Name="pictBeaterBox")]
        BoundingBox PictBeaterBox { get; set; }

        [DataMember(Name="pictBeaterBrassMalletsDown")]
        BoundingBox PictBeaterBrassMalletsDown { get; set; }

        [DataMember(Name="pictBeaterBrassMalletsUp")]
        BoundingBox PictBeaterBrassMalletsUp { get; set; }

        [DataMember(Name="pictBeaterCombiningDashedCircle")]
        BoundingBox PictBeaterCombiningDashedCircle { get; set; }

        [DataMember(Name="pictBeaterCombiningParentheses")]
        BoundingBox PictBeaterCombiningParentheses { get; set; }

        [DataMember(Name="pictBeaterDoubleBassDrumDown")]
        BoundingBox PictBeaterDoubleBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterDoubleBassDrumUp")]
        BoundingBox PictBeaterDoubleBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterFinger")]
        BoundingBox PictBeaterFinger { get; set; }

        [DataMember(Name="pictBeaterFingernails")]
        BoundingBox PictBeaterFingernails { get; set; }

        [DataMember(Name="pictBeaterFist")]
        BoundingBox PictBeaterFist { get; set; }

        [DataMember(Name="pictBeaterGuiroScraper")]
        BoundingBox PictBeaterGuiroScraper { get; set; }

        [DataMember(Name="pictBeaterHammer")]
        BoundingBox PictBeaterHammer { get; set; }

        [DataMember(Name="pictBeaterHammerMetalDown")]
        BoundingBox PictBeaterHammerMetalDown { get; set; }

        [DataMember(Name="pictBeaterHammerMetalUp")]
        BoundingBox PictBeaterHammerMetalUp { get; set; }

        [DataMember(Name="pictBeaterHammerPlasticDown")]
        BoundingBox PictBeaterHammerPlasticDown { get; set; }

        [DataMember(Name="pictBeaterHammerPlasticUp")]
        BoundingBox PictBeaterHammerPlasticUp { get; set; }

        [DataMember(Name="pictBeaterHammerWoodDown")]
        BoundingBox PictBeaterHammerWoodDown { get; set; }

        [DataMember(Name="pictBeaterHammerWoodUp")]
        BoundingBox PictBeaterHammerWoodUp { get; set; }

        [DataMember(Name="pictBeaterHand")]
        BoundingBox PictBeaterHand { get; set; }

        [DataMember(Name="pictBeaterHardBassDrumDown")]
        BoundingBox PictBeaterHardBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterHardBassDrumUp")]
        BoundingBox PictBeaterHardBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterHardGlockenspielDown")]
        BoundingBox PictBeaterHardGlockenspielDown { get; set; }

        [DataMember(Name="pictBeaterHardGlockenspielLeft")]
        BoundingBox PictBeaterHardGlockenspielLeft { get; set; }

        [DataMember(Name="pictBeaterHardGlockenspielRight")]
        BoundingBox PictBeaterHardGlockenspielRight { get; set; }

        [DataMember(Name="pictBeaterHardGlockenspielUp")]
        BoundingBox PictBeaterHardGlockenspielUp { get; set; }

        [DataMember(Name="pictBeaterHardTimpaniDown")]
        BoundingBox PictBeaterHardTimpaniDown { get; set; }

        [DataMember(Name="pictBeaterHardTimpaniLeft")]
        BoundingBox PictBeaterHardTimpaniLeft { get; set; }

        [DataMember(Name="pictBeaterHardTimpaniRight")]
        BoundingBox PictBeaterHardTimpaniRight { get; set; }

        [DataMember(Name="pictBeaterHardTimpaniUp")]
        BoundingBox PictBeaterHardTimpaniUp { get; set; }

        [DataMember(Name="pictBeaterHardXylophoneDown")]
        BoundingBox PictBeaterHardXylophoneDown { get; set; }

        [DataMember(Name="pictBeaterHardXylophoneLeft")]
        BoundingBox PictBeaterHardXylophoneLeft { get; set; }

        [DataMember(Name="pictBeaterHardXylophoneRight")]
        BoundingBox PictBeaterHardXylophoneRight { get; set; }

        [DataMember(Name="pictBeaterHardXylophoneUp")]
        BoundingBox PictBeaterHardXylophoneUp { get; set; }

        [DataMember(Name="pictBeaterHardYarnDown")]
        BoundingBox PictBeaterHardYarnDown { get; set; }

        [DataMember(Name="pictBeaterHardYarnLeft")]
        BoundingBox PictBeaterHardYarnLeft { get; set; }

        [DataMember(Name="pictBeaterHardYarnRight")]
        BoundingBox PictBeaterHardYarnRight { get; set; }

        [DataMember(Name="pictBeaterHardYarnUp")]
        BoundingBox PictBeaterHardYarnUp { get; set; }

        [DataMember(Name="pictBeaterJazzSticksDown")]
        BoundingBox PictBeaterJazzSticksDown { get; set; }

        [DataMember(Name="pictBeaterJazzSticksUp")]
        BoundingBox PictBeaterJazzSticksUp { get; set; }

        [DataMember(Name="pictBeaterKnittingNeedle")]
        BoundingBox PictBeaterKnittingNeedle { get; set; }

        [DataMember(Name="pictBeaterMallet")]
        BoundingBox PictBeaterMallet { get; set; }

        [DataMember(Name="pictBeaterMediumBassDrumDown")]
        BoundingBox PictBeaterMediumBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterMediumBassDrumUp")]
        BoundingBox PictBeaterMediumBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterMediumTimpaniDown")]
        BoundingBox PictBeaterMediumTimpaniDown { get; set; }

        [DataMember(Name="pictBeaterMediumTimpaniLeft")]
        BoundingBox PictBeaterMediumTimpaniLeft { get; set; }

        [DataMember(Name="pictBeaterMediumTimpaniRight")]
        BoundingBox PictBeaterMediumTimpaniRight { get; set; }

        [DataMember(Name="pictBeaterMediumTimpaniUp")]
        BoundingBox PictBeaterMediumTimpaniUp { get; set; }

        [DataMember(Name="pictBeaterMediumXylophoneDown")]
        BoundingBox PictBeaterMediumXylophoneDown { get; set; }

        [DataMember(Name="pictBeaterMediumXylophoneLeft")]
        BoundingBox PictBeaterMediumXylophoneLeft { get; set; }

        [DataMember(Name="pictBeaterMediumXylophoneRight")]
        BoundingBox PictBeaterMediumXylophoneRight { get; set; }

        [DataMember(Name="pictBeaterMediumXylophoneUp")]
        BoundingBox PictBeaterMediumXylophoneUp { get; set; }

        [DataMember(Name="pictBeaterMediumYarnDown")]
        BoundingBox PictBeaterMediumYarnDown { get; set; }

        [DataMember(Name="pictBeaterMediumYarnLeft")]
        BoundingBox PictBeaterMediumYarnLeft { get; set; }

        [DataMember(Name="pictBeaterMediumYarnRight")]
        BoundingBox PictBeaterMediumYarnRight { get; set; }

        [DataMember(Name="pictBeaterMediumYarnUp")]
        BoundingBox PictBeaterMediumYarnUp { get; set; }

        [DataMember(Name="pictBeaterMetalBassDrumDown")]
        BoundingBox PictBeaterMetalBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterMetalBassDrumUp")]
        BoundingBox PictBeaterMetalBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterMetalDown")]
        BoundingBox PictBeaterMetalDown { get; set; }

        [DataMember(Name="pictBeaterMetalHammer")]
        BoundingBox PictBeaterMetalHammer { get; set; }

        [DataMember(Name="pictBeaterMetalLeft")]
        BoundingBox PictBeaterMetalLeft { get; set; }

        [DataMember(Name="pictBeaterMetalRight")]
        BoundingBox PictBeaterMetalRight { get; set; }

        [DataMember(Name="pictBeaterMetalUp")]
        BoundingBox PictBeaterMetalUp { get; set; }

        [DataMember(Name="pictBeaterSnareSticksDown")]
        BoundingBox PictBeaterSnareSticksDown { get; set; }

        [DataMember(Name="pictBeaterSnareSticksUp")]
        BoundingBox PictBeaterSnareSticksUp { get; set; }

        [DataMember(Name="pictBeaterSoftBassDrumDown")]
        BoundingBox PictBeaterSoftBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterSoftBassDrumUp")]
        BoundingBox PictBeaterSoftBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterSoftGlockenspielDown")]
        BoundingBox PictBeaterSoftGlockenspielDown { get; set; }

        [DataMember(Name="pictBeaterSoftGlockenspielLeft")]
        BoundingBox PictBeaterSoftGlockenspielLeft { get; set; }

        [DataMember(Name="pictBeaterSoftGlockenspielRight")]
        BoundingBox PictBeaterSoftGlockenspielRight { get; set; }

        [DataMember(Name="pictBeaterSoftGlockenspielUp")]
        BoundingBox PictBeaterSoftGlockenspielUp { get; set; }

        [DataMember(Name="pictBeaterSoftTimpaniDown")]
        BoundingBox PictBeaterSoftTimpaniDown { get; set; }

        [DataMember(Name="pictBeaterSoftTimpaniLeft")]
        BoundingBox PictBeaterSoftTimpaniLeft { get; set; }

        [DataMember(Name="pictBeaterSoftTimpaniRight")]
        BoundingBox PictBeaterSoftTimpaniRight { get; set; }

        [DataMember(Name="pictBeaterSoftTimpaniUp")]
        BoundingBox PictBeaterSoftTimpaniUp { get; set; }

        [DataMember(Name="pictBeaterSoftXylophone")]
        BoundingBox PictBeaterSoftXylophone { get; set; }

        [DataMember(Name="pictBeaterSoftXylophoneDown")]
        BoundingBox PictBeaterSoftXylophoneDown { get; set; }

        [DataMember(Name="pictBeaterSoftXylophoneLeft")]
        BoundingBox PictBeaterSoftXylophoneLeft { get; set; }

        [DataMember(Name="pictBeaterSoftXylophoneRight")]
        BoundingBox PictBeaterSoftXylophoneRight { get; set; }

        [DataMember(Name="pictBeaterSoftXylophoneUp")]
        BoundingBox PictBeaterSoftXylophoneUp { get; set; }

        [DataMember(Name="pictBeaterSoftYarnDown")]
        BoundingBox PictBeaterSoftYarnDown { get; set; }

        [DataMember(Name="pictBeaterSoftYarnLeft")]
        BoundingBox PictBeaterSoftYarnLeft { get; set; }

        [DataMember(Name="pictBeaterSoftYarnRight")]
        BoundingBox PictBeaterSoftYarnRight { get; set; }

        [DataMember(Name="pictBeaterSoftYarnUp")]
        BoundingBox PictBeaterSoftYarnUp { get; set; }

        [DataMember(Name="pictBeaterSpoonWoodenMallet")]
        BoundingBox PictBeaterSpoonWoodenMallet { get; set; }

        [DataMember(Name="pictBeaterSuperballDown")]
        BoundingBox PictBeaterSuperballDown { get; set; }

        [DataMember(Name="pictBeaterSuperballLeft")]
        BoundingBox PictBeaterSuperballLeft { get; set; }

        [DataMember(Name="pictBeaterSuperballRight")]
        BoundingBox PictBeaterSuperballRight { get; set; }

        [DataMember(Name="pictBeaterSuperballUp")]
        BoundingBox PictBeaterSuperballUp { get; set; }

        [DataMember(Name="pictBeaterTriangleDown")]
        BoundingBox PictBeaterTriangleDown { get; set; }

        [DataMember(Name="pictBeaterTriangleUp")]
        BoundingBox PictBeaterTriangleUp { get; set; }

        [DataMember(Name="pictBeaterWireBrushesDown")]
        BoundingBox PictBeaterWireBrushesDown { get; set; }

        [DataMember(Name="pictBeaterWireBrushesUp")]
        BoundingBox PictBeaterWireBrushesUp { get; set; }

        [DataMember(Name="pictBeaterWoodTimpaniDown")]
        BoundingBox PictBeaterWoodTimpaniDown { get; set; }

        [DataMember(Name="pictBeaterWoodTimpaniLeft")]
        BoundingBox PictBeaterWoodTimpaniLeft { get; set; }

        [DataMember(Name="pictBeaterWoodTimpaniRight")]
        BoundingBox PictBeaterWoodTimpaniRight { get; set; }

        [DataMember(Name="pictBeaterWoodTimpaniUp")]
        BoundingBox PictBeaterWoodTimpaniUp { get; set; }

        [DataMember(Name="pictBeaterWoodXylophoneDown")]
        BoundingBox PictBeaterWoodXylophoneDown { get; set; }

        [DataMember(Name="pictBeaterWoodXylophoneLeft")]
        BoundingBox PictBeaterWoodXylophoneLeft { get; set; }

        [DataMember(Name="pictBeaterWoodXylophoneRight")]
        BoundingBox PictBeaterWoodXylophoneRight { get; set; }

        [DataMember(Name="pictBeaterWoodXylophoneUp")]
        BoundingBox PictBeaterWoodXylophoneUp { get; set; }

        [DataMember(Name="pictBell")]
        BoundingBox PictBell { get; set; }

        [DataMember(Name="pictBellOfCymbal")]
        BoundingBox PictBellOfCymbal { get; set; }

        [DataMember(Name="pictBellPlate")]
        BoundingBox PictBellPlate { get; set; }

        [DataMember(Name="pictBellTree")]
        BoundingBox PictBellTree { get; set; }

        [DataMember(Name="pictBirdWhistle")]
        BoundingBox PictBirdWhistle { get; set; }

        [DataMember(Name="pictBoardClapper")]
        BoundingBox PictBoardClapper { get; set; }

        [DataMember(Name="pictBongos")]
        BoundingBox PictBongos { get; set; }

        [DataMember(Name="pictBongosPeinkofer")]
        BoundingBox PictBongosPeinkofer { get; set; }

        [DataMember(Name="pictBrakeDrum")]
        BoundingBox PictBrakeDrum { get; set; }

        [DataMember(Name="pictCabasa")]
        BoundingBox PictCabasa { get; set; }

        [DataMember(Name="pictCannon")]
        BoundingBox PictCannon { get; set; }

        [DataMember(Name="pictCarHorn")]
        BoundingBox PictCarHorn { get; set; }

        [DataMember(Name="pictCastanets")]
        BoundingBox PictCastanets { get; set; }

        [DataMember(Name="pictCastanetsSmithBrindle")]
        BoundingBox PictCastanetsSmithBrindle { get; set; }

        [DataMember(Name="pictCastanetsWithHandle")]
        BoundingBox PictCastanetsWithHandle { get; set; }

        [DataMember(Name="pictCelesta")]
        BoundingBox PictCelesta { get; set; }

        [DataMember(Name="pictCencerro")]
        BoundingBox PictCencerro { get; set; }

        [DataMember(Name="pictCenter1")]
        BoundingBox PictCenter1 { get; set; }

        [DataMember(Name="pictCenter2")]
        BoundingBox PictCenter2 { get; set; }

        [DataMember(Name="pictCenter3")]
        BoundingBox PictCenter3 { get; set; }

        [DataMember(Name="pictChainRattle")]
        BoundingBox PictChainRattle { get; set; }

        [DataMember(Name="pictChimes")]
        BoundingBox PictChimes { get; set; }

        [DataMember(Name="pictChineseCymbal")]
        BoundingBox PictChineseCymbal { get; set; }

        [DataMember(Name="pictChokeCymbal")]
        BoundingBox PictChokeCymbal { get; set; }

        [DataMember(Name="pictClaves")]
        BoundingBox PictClaves { get; set; }

        [DataMember(Name="pictCoins")]
        BoundingBox PictCoins { get; set; }

        [DataMember(Name="pictConga")]
        BoundingBox PictConga { get; set; }

        [DataMember(Name="pictCongaPeinkofer")]
        BoundingBox PictCongaPeinkofer { get; set; }

        [DataMember(Name="pictCowBell")]
        BoundingBox PictCowBell { get; set; }

        [DataMember(Name="pictCowBellBerio")]
        BoundingBox PictCowBellBerio { get; set; }

        [DataMember(Name="pictCrashCymbals")]
        BoundingBox PictCrashCymbals { get; set; }

        [DataMember(Name="pictCrotales")]
        BoundingBox PictCrotales { get; set; }

        [DataMember(Name="pictCrushStem")]
        BoundingBox PictCrushStem { get; set; }

        [DataMember(Name="pictCuica")]
        BoundingBox PictCuica { get; set; }

        [DataMember(Name="pictCymbalTongs")]
        BoundingBox PictCymbalTongs { get; set; }

        [DataMember(Name="pictDamp1")]
        BoundingBox PictDamp1 { get; set; }

        [DataMember(Name="pictDamp2")]
        BoundingBox PictDamp2 { get; set; }

        [DataMember(Name="pictDamp3")]
        BoundingBox PictDamp3 { get; set; }

        [DataMember(Name="pictDamp4")]
        BoundingBox PictDamp4 { get; set; }

        [DataMember(Name="pictDeadNoteStem")]
        BoundingBox PictDeadNoteStem { get; set; }

        [DataMember(Name="pictDrumStick")]
        BoundingBox PictDrumStick { get; set; }

        [DataMember(Name="pictDuckCall")]
        BoundingBox PictDuckCall { get; set; }

        [DataMember(Name="pictEdgeOfCymbal")]
        BoundingBox PictEdgeOfCymbal { get; set; }

        [DataMember(Name="pictEmptyTrap")]
        BoundingBox PictEmptyTrap { get; set; }

        [DataMember(Name="pictFingerCymbals")]
        BoundingBox PictFingerCymbals { get; set; }

        [DataMember(Name="pictFlexatone")]
        BoundingBox PictFlexatone { get; set; }

        [DataMember(Name="pictFlexatonePeinkofer")]
        BoundingBox PictFlexatonePeinkofer { get; set; }

        [DataMember(Name="pictFootballRatchet")]
        BoundingBox PictFootballRatchet { get; set; }

        [DataMember(Name="pictGlassHarmonica")]
        BoundingBox PictGlassHarmonica { get; set; }

        [DataMember(Name="pictGlassHarp")]
        BoundingBox PictGlassHarp { get; set; }

        [DataMember(Name="pictGlassPlateChimes")]
        BoundingBox PictGlassPlateChimes { get; set; }

        [DataMember(Name="pictGlassTubeChimes")]
        BoundingBox PictGlassTubeChimes { get; set; }

        [DataMember(Name="pictGlsp")]
        BoundingBox PictGlsp { get; set; }

        [DataMember(Name="pictGlspPeinkofer")]
        BoundingBox PictGlspPeinkofer { get; set; }

        [DataMember(Name="pictGlspSmithBrindle")]
        BoundingBox PictGlspSmithBrindle { get; set; }

        [DataMember(Name="pictGobletDrum")]
        BoundingBox PictGobletDrum { get; set; }

        [DataMember(Name="pictGong")]
        BoundingBox PictGong { get; set; }

        [DataMember(Name="pictGongWithButton")]
        BoundingBox PictGongWithButton { get; set; }

        [DataMember(Name="pictGuiro")]
        BoundingBox PictGuiro { get; set; }

        [DataMember(Name="pictGuiroPeinkofer")]
        BoundingBox PictGuiroPeinkofer { get; set; }

        [DataMember(Name="pictGuiroSevsay")]
        BoundingBox PictGuiroSevsay { get; set; }

        [DataMember(Name="pictGumHardDown")]
        BoundingBox PictGumHardDown { get; set; }

        [DataMember(Name="pictGumHardLeft")]
        BoundingBox PictGumHardLeft { get; set; }

        [DataMember(Name="pictGumHardRight")]
        BoundingBox PictGumHardRight { get; set; }

        [DataMember(Name="pictGumHardUp")]
        BoundingBox PictGumHardUp { get; set; }

        [DataMember(Name="pictGumMediumDown")]
        BoundingBox PictGumMediumDown { get; set; }

        [DataMember(Name="pictGumMediumLeft")]
        BoundingBox PictGumMediumLeft { get; set; }

        [DataMember(Name="pictGumMediumRight")]
        BoundingBox PictGumMediumRight { get; set; }

        [DataMember(Name="pictGumMediumUp")]
        BoundingBox PictGumMediumUp { get; set; }

        [DataMember(Name="pictGumSoftDown")]
        BoundingBox PictGumSoftDown { get; set; }

        [DataMember(Name="pictGumSoftLeft")]
        BoundingBox PictGumSoftLeft { get; set; }

        [DataMember(Name="pictGumSoftRight")]
        BoundingBox PictGumSoftRight { get; set; }

        [DataMember(Name="pictGumSoftUp")]
        BoundingBox PictGumSoftUp { get; set; }

        [DataMember(Name="pictHalfOpen1")]
        BoundingBox PictHalfOpen1 { get; set; }

        [DataMember(Name="pictHalfOpen2")]
        BoundingBox PictHalfOpen2 { get; set; }

        [DataMember(Name="pictHandbell")]
        BoundingBox PictHandbell { get; set; }

        [DataMember(Name="pictHiHat")]
        BoundingBox PictHiHat { get; set; }

        [DataMember(Name="pictHiHatOnStand")]
        BoundingBox PictHiHatOnStand { get; set; }

        [DataMember(Name="pictJawHarp")]
        Dictionary<string, long[]> PictJawHarp { get; set; }

        [DataMember(Name="pictJingleBells")]
        BoundingBox PictJingleBells { get; set; }

        [DataMember(Name="pictKlaxonHorn")]
        BoundingBox PictKlaxonHorn { get; set; }

        [DataMember(Name="pictLeftHandCircle")]
        BoundingBox PictLeftHandCircle { get; set; }

        [DataMember(Name="pictLionsRoar")]
        BoundingBox PictLionsRoar { get; set; }

        [DataMember(Name="pictLithophone")]
        BoundingBox PictLithophone { get; set; }

        [DataMember(Name="pictLithophonePeinkofer")]
        BoundingBox PictLithophonePeinkofer { get; set; }

        [DataMember(Name="pictLogDrum")]
        BoundingBox PictLogDrum { get; set; }

        [DataMember(Name="pictLotusFlute")]
        BoundingBox PictLotusFlute { get; set; }

        [DataMember(Name="pictLotusFlutePeinkofer")]
        BoundingBox PictLotusFlutePeinkofer { get; set; }

        [DataMember(Name="pictMar")]
        BoundingBox PictMar { get; set; }

        [DataMember(Name="pictMarPeinkofer")]
        BoundingBox PictMarPeinkofer { get; set; }

        [DataMember(Name="pictMarSmithBrindle")]
        BoundingBox PictMarSmithBrindle { get; set; }

        [DataMember(Name="pictMaraca")]
        BoundingBox PictMaraca { get; set; }

        [DataMember(Name="pictMaracaSmithBrindle")]
        BoundingBox PictMaracaSmithBrindle { get; set; }

        [DataMember(Name="pictMaracas")]
        BoundingBox PictMaracas { get; set; }

        [DataMember(Name="pictMegaphone")]
        BoundingBox PictMegaphone { get; set; }

        [DataMember(Name="pictMetalPlateChimes")]
        BoundingBox PictMetalPlateChimes { get; set; }

        [DataMember(Name="pictMetalTubeChimes")]
        BoundingBox PictMetalTubeChimes { get; set; }

        [DataMember(Name="pictMusicalSaw")]
        BoundingBox PictMusicalSaw { get; set; }

        [DataMember(Name="pictMusicalSawPeinkofer")]
        BoundingBox PictMusicalSawPeinkofer { get; set; }

        [DataMember(Name="pictNormalPosition")]
        BoundingBox PictNormalPosition { get; set; }

        [DataMember(Name="pictOnRim")]
        BoundingBox PictOnRim { get; set; }

        [DataMember(Name="pictOpen")]
        BoundingBox PictOpen { get; set; }

        [DataMember(Name="pictOpenRimShot")]
        BoundingBox PictOpenRimShot { get; set; }

        [DataMember(Name="pictPistolShot")]
        BoundingBox PictPistolShot { get; set; }

        [DataMember(Name="pictPoliceWhistle")]
        BoundingBox PictPoliceWhistle { get; set; }

        [DataMember(Name="pictQuijada")]
        BoundingBox PictQuijada { get; set; }

        [DataMember(Name="pictRainstick")]
        BoundingBox PictRainstick { get; set; }

        [DataMember(Name="pictRatchet")]
        BoundingBox PictRatchet { get; set; }

        [DataMember(Name="pictRecoReco")]
        BoundingBox PictRecoReco { get; set; }

        [DataMember(Name="pictRightHandSquare")]
        BoundingBox PictRightHandSquare { get; set; }

        [DataMember(Name="pictRim1")]
        BoundingBox PictRim1 { get; set; }

        [DataMember(Name="pictRim2")]
        BoundingBox PictRim2 { get; set; }

        [DataMember(Name="pictRim3")]
        BoundingBox PictRim3 { get; set; }

        [DataMember(Name="pictRimShotOnStem")]
        BoundingBox PictRimShotOnStem { get; set; }

        [DataMember(Name="pictSandpaperBlocks")]
        BoundingBox PictSandpaperBlocks { get; set; }

        [DataMember(Name="pictScrapeAroundRim")]
        BoundingBox PictScrapeAroundRim { get; set; }

        [DataMember(Name="pictScrapeAroundRimClockwise")]
        BoundingBox PictScrapeAroundRimClockwise { get; set; }

        [DataMember(Name="pictScrapeCenterToEdge")]
        BoundingBox PictScrapeCenterToEdge { get; set; }

        [DataMember(Name="pictScrapeEdgeToCenter")]
        BoundingBox PictScrapeEdgeToCenter { get; set; }

        [DataMember(Name="pictShellBells")]
        Dictionary<string, long[]> PictShellBells { get; set; }

        [DataMember(Name="pictShellChimes")]
        BoundingBox PictShellChimes { get; set; }

        [DataMember(Name="pictSiren")]
        BoundingBox PictSiren { get; set; }

        [DataMember(Name="pictSistrum")]
        BoundingBox PictSistrum { get; set; }

        [DataMember(Name="pictSizzleCymbal")]
        BoundingBox PictSizzleCymbal { get; set; }

        [DataMember(Name="pictSleighBell")]
        BoundingBox PictSleighBell { get; set; }

        [DataMember(Name="pictSleighBellSmithBrindle")]
        BoundingBox PictSleighBellSmithBrindle { get; set; }

        [DataMember(Name="pictSlideBrushOnGong")]
        BoundingBox PictSlideBrushOnGong { get; set; }

        [DataMember(Name="pictSlideWhistle")]
        BoundingBox PictSlideWhistle { get; set; }

        [DataMember(Name="pictSlitDrum")]
        BoundingBox PictSlitDrum { get; set; }

        [DataMember(Name="pictSnareDrum")]
        BoundingBox PictSnareDrum { get; set; }

        [DataMember(Name="pictSnareDrumMilitary")]
        BoundingBox PictSnareDrumMilitary { get; set; }

        [DataMember(Name="pictSnareDrumSnaresOff")]
        BoundingBox PictSnareDrumSnaresOff { get; set; }

        [DataMember(Name="pictSteelDrums")]
        BoundingBox PictSteelDrums { get; set; }

        [DataMember(Name="pictStickShot")]
        BoundingBox PictStickShot { get; set; }

        [DataMember(Name="pictSuperball")]
        BoundingBox PictSuperball { get; set; }

        [DataMember(Name="pictSuspendedCymbal")]
        BoundingBox PictSuspendedCymbal { get; set; }

        [DataMember(Name="pictSwishStem")]
        BoundingBox PictSwishStem { get; set; }

        [DataMember(Name="pictTabla")]
        BoundingBox PictTabla { get; set; }

        [DataMember(Name="pictTamTam")]
        BoundingBox PictTamTam { get; set; }

        [DataMember(Name="pictTamTamWithBeater")]
        BoundingBox PictTamTamWithBeater { get; set; }

        [DataMember(Name="pictTambourine")]
        BoundingBox PictTambourine { get; set; }

        [DataMember(Name="pictTambourineStockhausen")]
        BoundingBox PictTambourineStockhausen { get; set; }

        [DataMember(Name="pictTempleBlocks")]
        BoundingBox PictTempleBlocks { get; set; }

        [DataMember(Name="pictTenorDrum")]
        BoundingBox PictTenorDrum { get; set; }

        [DataMember(Name="pictThundersheet")]
        BoundingBox PictThundersheet { get; set; }

        [DataMember(Name="pictTimbales")]
        BoundingBox PictTimbales { get; set; }

        [DataMember(Name="pictTimbalesPeinkofer")]
        BoundingBox PictTimbalesPeinkofer { get; set; }

        [DataMember(Name="pictTimpani")]
        BoundingBox PictTimpani { get; set; }

        [DataMember(Name="pictTimpaniPeinkofer")]
        BoundingBox PictTimpaniPeinkofer { get; set; }

        [DataMember(Name="pictTomTom")]
        BoundingBox PictTomTom { get; set; }

        [DataMember(Name="pictTomTomChinese")]
        BoundingBox PictTomTomChinese { get; set; }

        [DataMember(Name="pictTomTomChinesePeinkofer")]
        BoundingBox PictTomTomChinesePeinkofer { get; set; }

        [DataMember(Name="pictTomTomIndoAmerican")]
        BoundingBox PictTomTomIndoAmerican { get; set; }

        [DataMember(Name="pictTomTomJapanese")]
        BoundingBox PictTomTomJapanese { get; set; }

        [DataMember(Name="pictTomTomPeinkofer")]
        BoundingBox PictTomTomPeinkofer { get; set; }

        [DataMember(Name="pictTriangle")]
        BoundingBox PictTriangle { get; set; }

        [DataMember(Name="pictTubaphone")]
        BoundingBox PictTubaphone { get; set; }

        [DataMember(Name="pictTubaphonePeinkofer")]
        BoundingBox PictTubaphonePeinkofer { get; set; }

        [DataMember(Name="pictTubularBells")]
        BoundingBox PictTubularBells { get; set; }

        [DataMember(Name="pictTurnLeftStem")]
        BoundingBox PictTurnLeftStem { get; set; }

        [DataMember(Name="pictTurnRightLeftStem")]
        BoundingBox PictTurnRightLeftStem { get; set; }

        [DataMember(Name="pictTurnRightStem")]
        BoundingBox PictTurnRightStem { get; set; }

        [DataMember(Name="pictVib")]
        BoundingBox PictVib { get; set; }

        [DataMember(Name="pictVibMotorOff")]
        BoundingBox PictVibMotorOff { get; set; }

        [DataMember(Name="pictVibMotorOffPeinkofer")]
        BoundingBox PictVibMotorOffPeinkofer { get; set; }

        [DataMember(Name="pictVibPeinkofer")]
        BoundingBox PictVibPeinkofer { get; set; }

        [DataMember(Name="pictVibSmithBrindle")]
        BoundingBox PictVibSmithBrindle { get; set; }

        [DataMember(Name="pictVibraslap")]
        BoundingBox PictVibraslap { get; set; }

        [DataMember(Name="pictVietnameseHat")]
        BoundingBox PictVietnameseHat { get; set; }

        [DataMember(Name="pictWhip")]
        BoundingBox PictWhip { get; set; }

        [DataMember(Name="pictWindChimesGlass")]
        BoundingBox PictWindChimesGlass { get; set; }

        [DataMember(Name="pictWindMachine")]
        BoundingBox PictWindMachine { get; set; }

        [DataMember(Name="pictWindWhistle")]
        BoundingBox PictWindWhistle { get; set; }

        [DataMember(Name="pictWoodBlock")]
        BoundingBox PictWoodBlock { get; set; }

        [DataMember(Name="pictWoundHardDown")]
        BoundingBox PictWoundHardDown { get; set; }

        [DataMember(Name="pictWoundHardLeft")]
        BoundingBox PictWoundHardLeft { get; set; }

        [DataMember(Name="pictWoundHardRight")]
        BoundingBox PictWoundHardRight { get; set; }

        [DataMember(Name="pictWoundHardUp")]
        BoundingBox PictWoundHardUp { get; set; }

        [DataMember(Name="pictWoundSoftDown")]
        BoundingBox PictWoundSoftDown { get; set; }

        [DataMember(Name="pictWoundSoftLeft")]
        BoundingBox PictWoundSoftLeft { get; set; }

        [DataMember(Name="pictWoundSoftRight")]
        BoundingBox PictWoundSoftRight { get; set; }

        [DataMember(Name="pictWoundSoftUp")]
        BoundingBox PictWoundSoftUp { get; set; }

        [DataMember(Name="pictXyl")]
        BoundingBox PictXyl { get; set; }

        [DataMember(Name="pictXylBass")]
        BoundingBox PictXylBass { get; set; }

        [DataMember(Name="pictXylBassPeinkofer")]
        BoundingBox PictXylBassPeinkofer { get; set; }

        [DataMember(Name="pictXylPeinkofer")]
        BoundingBox PictXylPeinkofer { get; set; }

        [DataMember(Name="pictXylSmithBrindle")]
        BoundingBox PictXylSmithBrindle { get; set; }

        [DataMember(Name="pictXylTenor")]
        BoundingBox PictXylTenor { get; set; }

        [DataMember(Name="pictXylTenorPeinkofer")]
        BoundingBox PictXylTenorPeinkofer { get; set; }

        [DataMember(Name="pictXylTenorTrough")]
        BoundingBox PictXylTenorTrough { get; set; }

        [DataMember(Name="pictXylTrough")]
        BoundingBox PictXylTrough { get; set; }

        [DataMember(Name="pluckedBuzzPizzicato")]
        BoundingBox PluckedBuzzPizzicato { get; set; }

        [DataMember(Name="pluckedDamp")]
        BoundingBox PluckedDamp { get; set; }

        [DataMember(Name="pluckedDampAll")]
        BoundingBox PluckedDampAll { get; set; }

        [DataMember(Name="pluckedDampOnStem")]
        BoundingBox PluckedDampOnStem { get; set; }

        [DataMember(Name="pluckedFingernailFlick")]
        BoundingBox PluckedFingernailFlick { get; set; }

        [DataMember(Name="pluckedLeftHandPizzicato")]
        BoundingBox PluckedLeftHandPizzicato { get; set; }

        [DataMember(Name="pluckedPlectrum")]
        BoundingBox PluckedPlectrum { get; set; }

        [DataMember(Name="pluckedSnapPizzicatoAbove")]
        BoundingBox PluckedSnapPizzicatoAbove { get; set; }

        [DataMember(Name="pluckedSnapPizzicatoAboveGerman")]
        BoundingBox PluckedSnapPizzicatoAboveGerman { get; set; }

        [DataMember(Name="pluckedSnapPizzicatoBelow")]
        BoundingBox PluckedSnapPizzicatoBelow { get; set; }

        [DataMember(Name="pluckedSnapPizzicatoBelowGerman")]
        BoundingBox PluckedSnapPizzicatoBelowGerman { get; set; }

        [DataMember(Name="pluckedWithFingernails")]
        BoundingBox PluckedWithFingernails { get; set; }

        [DataMember(Name="quindicesima")]
        BoundingBox Quindicesima { get; set; }

        [DataMember(Name="quindicesimaAlta")]
        BoundingBox QuindicesimaAlta { get; set; }

        [DataMember(Name="quindicesimaBassa")]
        BoundingBox QuindicesimaBassa { get; set; }

        [DataMember(Name="quindicesimaBassaMb")]
        BoundingBox QuindicesimaBassaMb { get; set; }

        [DataMember(Name="repeat1Bar")]
        BoundingBox Repeat1Bar { get; set; }

        [DataMember(Name="repeat2Bars")]
        BoundingBox Repeat2Bars { get; set; }

        [DataMember(Name="repeat4Bars")]
        BoundingBox Repeat4Bars { get; set; }

        [DataMember(Name="repeatDot")]
        BoundingBox RepeatDot { get; set; }

        [DataMember(Name="repeatDots")]
        BoundingBox RepeatDots { get; set; }

        [DataMember(Name="repeatLeft")]
        BoundingBox RepeatLeft { get; set; }

        [DataMember(Name="repeatRight")]
        BoundingBox RepeatRight { get; set; }

        [DataMember(Name="repeatRightLeft")]
        BoundingBox RepeatRightLeft { get; set; }

        [DataMember(Name="repeatRightLeftThick")]
        BoundingBox RepeatRightLeftThick { get; set; }

        [DataMember(Name="rest1024th")]
        BoundingBox Rest1024Th { get; set; }

        [DataMember(Name="rest128th")]
        BoundingBox Rest128Th { get; set; }

        [DataMember(Name="rest16th")]
        BoundingBox Rest16Th { get; set; }

        [DataMember(Name="rest256th")]
        BoundingBox Rest256Th { get; set; }

        [DataMember(Name="rest32nd")]
        BoundingBox Rest32Nd { get; set; }

        [DataMember(Name="rest512th")]
        BoundingBox Rest512Th { get; set; }

        [DataMember(Name="rest64th")]
        BoundingBox Rest64Th { get; set; }

        [DataMember(Name="rest8th")]
        BoundingBox Rest8Th { get; set; }

        [DataMember(Name="restDoubleWhole")]
        BoundingBox RestDoubleWhole { get; set; }

        [DataMember(Name="restDoubleWholeLegerLine")]
        BoundingBox RestDoubleWholeLegerLine { get; set; }

        [DataMember(Name="restHBar")]
        BoundingBox RestHBar { get; set; }

        [DataMember(Name="restHBarLeft")]
        BoundingBox RestHBarLeft { get; set; }

        [DataMember(Name="restHBarMiddle")]
        BoundingBox RestHBarMiddle { get; set; }

        [DataMember(Name="restHBarRight")]
        BoundingBox RestHBarRight { get; set; }

        [DataMember(Name="restHalf")]
        BoundingBox RestHalf { get; set; }

        [DataMember(Name="restHalfLegerLine")]
        BoundingBox RestHalfLegerLine { get; set; }

        [DataMember(Name="restLonga")]
        BoundingBox RestLonga { get; set; }

        [DataMember(Name="restMaxima")]
        BoundingBox RestMaxima { get; set; }

        [DataMember(Name="restQuarter")]
        BoundingBox RestQuarter { get; set; }

        [DataMember(Name="restQuarterOld")]
        BoundingBox RestQuarterOld { get; set; }

        [DataMember(Name="restQuarterZ")]
        BoundingBox RestQuarterZ { get; set; }

        [DataMember(Name="restWhole")]
        BoundingBox RestWhole { get; set; }

        [DataMember(Name="restWholeLegerLine")]
        BoundingBox RestWholeLegerLine { get; set; }

        [DataMember(Name="reversedBrace")]
        BoundingBox ReversedBrace { get; set; }

        [DataMember(Name="reversedBracketBottom")]
        BoundingBox ReversedBracketBottom { get; set; }

        [DataMember(Name="reversedBracketTop")]
        BoundingBox ReversedBracketTop { get; set; }

        [DataMember(Name="rightRepeatSmall")]
        BoundingBox RightRepeatSmall { get; set; }

        [DataMember(Name="schaefferClef")]
        BoundingBox SchaefferClef { get; set; }

        [DataMember(Name="schaefferFClefToGClef")]
        BoundingBox SchaefferFClefToGClef { get; set; }

        [DataMember(Name="schaefferGClefToFClef")]
        BoundingBox SchaefferGClefToFClef { get; set; }

        [DataMember(Name="schaefferPreviousClef")]
        BoundingBox SchaefferPreviousClef { get; set; }

        [DataMember(Name="sedicesima")]
        BoundingBox Sedicesima { get; set; }

        [DataMember(Name="sedicesimaAlta")]
        BoundingBox SedicesimaAlta { get; set; }

        [DataMember(Name="sedicesimaBassa")]
        BoundingBox SedicesimaBassa { get; set; }

        [DataMember(Name="sedicesimaBassaMb")]
        BoundingBox SedicesimaBassaMb { get; set; }

        [DataMember(Name="segno")]
        BoundingBox Segno { get; set; }

        [DataMember(Name="segnoJapanese")]
        BoundingBox SegnoJapanese { get; set; }

        [DataMember(Name="segnoSerpent1")]
        BoundingBox SegnoSerpent1 { get; set; }

        [DataMember(Name="segnoSerpent2")]
        BoundingBox SegnoSerpent2 { get; set; }

        [DataMember(Name="semipitchedPercussionClef1")]
        BoundingBox SemipitchedPercussionClef1 { get; set; }

        [DataMember(Name="semipitchedPercussionClef2")]
        BoundingBox SemipitchedPercussionClef2 { get; set; }

        [DataMember(Name="smnFlat")]
        BoundingBox SmnFlat { get; set; }

        [DataMember(Name="smnFlatWhite")]
        BoundingBox SmnFlatWhite { get; set; }

        [DataMember(Name="smnHistoryDoubleFlat")]
        BoundingBox SmnHistoryDoubleFlat { get; set; }

        [DataMember(Name="smnHistoryDoubleSharp")]
        BoundingBox SmnHistoryDoubleSharp { get; set; }

        [DataMember(Name="smnHistoryFlat")]
        BoundingBox SmnHistoryFlat { get; set; }

        [DataMember(Name="smnHistorySharp")]
        BoundingBox SmnHistorySharp { get; set; }

        [DataMember(Name="smnNatural")]
        BoundingBox SmnNatural { get; set; }

        [DataMember(Name="smnSharp")]
        BoundingBox SmnSharp { get; set; }

        [DataMember(Name="smnSharpDown")]
        BoundingBox SmnSharpDown { get; set; }

        [DataMember(Name="smnSharpWhite")]
        BoundingBox SmnSharpWhite { get; set; }

        [DataMember(Name="smnSharpWhiteDown")]
        BoundingBox SmnSharpWhiteDown { get; set; }

        [DataMember(Name="splitBarDivider")]
        BoundingBox SplitBarDivider { get; set; }

        [DataMember(Name="staff1Line")]
        BoundingBox Staff1Line { get; set; }

        [DataMember(Name="staff1LineNarrow")]
        BoundingBox Staff1LineNarrow { get; set; }

        [DataMember(Name="staff1LineWide")]
        BoundingBox Staff1LineWide { get; set; }

        [DataMember(Name="staff2Lines")]
        BoundingBox Staff2Lines { get; set; }

        [DataMember(Name="staff2LinesNarrow")]
        BoundingBox Staff2LinesNarrow { get; set; }

        [DataMember(Name="staff2LinesWide")]
        BoundingBox Staff2LinesWide { get; set; }

        [DataMember(Name="staff3Lines")]
        BoundingBox Staff3Lines { get; set; }

        [DataMember(Name="staff3LinesNarrow")]
        BoundingBox Staff3LinesNarrow { get; set; }

        [DataMember(Name="staff3LinesWide")]
        BoundingBox Staff3LinesWide { get; set; }

        [DataMember(Name="staff4Lines")]
        BoundingBox Staff4Lines { get; set; }

        [DataMember(Name="staff4LinesNarrow")]
        BoundingBox Staff4LinesNarrow { get; set; }

        [DataMember(Name="staff4LinesWide")]
        BoundingBox Staff4LinesWide { get; set; }

        [DataMember(Name="staff5Lines")]
        BoundingBox Staff5Lines { get; set; }

        [DataMember(Name="staff5LinesNarrow")]
        BoundingBox Staff5LinesNarrow { get; set; }

        [DataMember(Name="staff5LinesWide")]
        BoundingBox Staff5LinesWide { get; set; }

        [DataMember(Name="staff6Lines")]
        BoundingBox Staff6Lines { get; set; }

        [DataMember(Name="staff6LinesNarrow")]
        BoundingBox Staff6LinesNarrow { get; set; }

        [DataMember(Name="staff6LinesWide")]
        BoundingBox Staff6LinesWide { get; set; }

        [DataMember(Name="staffDivideArrowDown")]
        BoundingBox StaffDivideArrowDown { get; set; }

        [DataMember(Name="staffDivideArrowUp")]
        BoundingBox StaffDivideArrowUp { get; set; }

        [DataMember(Name="staffDivideArrowUpDown")]
        BoundingBox StaffDivideArrowUpDown { get; set; }

        [DataMember(Name="stem")]
        BoundingBox Stem { get; set; }

        [DataMember(Name="stemBowOnBridge")]
        BoundingBox StemBowOnBridge { get; set; }

        [DataMember(Name="stemBowOnTailpiece")]
        BoundingBox StemBowOnTailpiece { get; set; }

        [DataMember(Name="stemBuzzRoll")]
        BoundingBox StemBuzzRoll { get; set; }

        [DataMember(Name="stemDamp")]
        BoundingBox StemDamp { get; set; }

        [DataMember(Name="stemHarpStringNoise")]
        BoundingBox StemHarpStringNoise { get; set; }

        [DataMember(Name="stemMultiphonicsBlack")]
        BoundingBox StemMultiphonicsBlack { get; set; }

        [DataMember(Name="stemMultiphonicsBlackWhite")]
        BoundingBox StemMultiphonicsBlackWhite { get; set; }

        [DataMember(Name="stemMultiphonicsWhite")]
        BoundingBox StemMultiphonicsWhite { get; set; }

        [DataMember(Name="stemPendereckiTremolo")]
        BoundingBox StemPendereckiTremolo { get; set; }

        [DataMember(Name="stemRimShot")]
        BoundingBox StemRimShot { get; set; }

        [DataMember(Name="stemSprechgesang")]
        BoundingBox StemSprechgesang { get; set; }

        [DataMember(Name="stemSulPonticello")]
        BoundingBox StemSulPonticello { get; set; }

        [DataMember(Name="stemSussurando")]
        BoundingBox StemSussurando { get; set; }

        [DataMember(Name="stemSwished")]
        BoundingBox StemSwished { get; set; }

        [DataMember(Name="stemVibratoPulse")]
        BoundingBox StemVibratoPulse { get; set; }

        [DataMember(Name="stockhausenTremolo")]
        BoundingBox StockhausenTremolo { get; set; }

        [DataMember(Name="stringsBowBehindBridge")]
        BoundingBox StringsBowBehindBridge { get; set; }

        [DataMember(Name="stringsBowBehindBridgeFourStrings")]
        BoundingBox StringsBowBehindBridgeFourStrings { get; set; }

        [DataMember(Name="stringsBowBehindBridgeOneString")]
        BoundingBox StringsBowBehindBridgeOneString { get; set; }

        [DataMember(Name="stringsBowBehindBridgeThreeStrings")]
        BoundingBox StringsBowBehindBridgeThreeStrings { get; set; }

        [DataMember(Name="stringsBowBehindBridgeTwoStrings")]
        BoundingBox StringsBowBehindBridgeTwoStrings { get; set; }

        [DataMember(Name="stringsBowOnBridge")]
        BoundingBox StringsBowOnBridge { get; set; }

        [DataMember(Name="stringsBowOnTailpiece")]
        BoundingBox StringsBowOnTailpiece { get; set; }

        [DataMember(Name="stringsChangeBowDirection")]
        BoundingBox StringsChangeBowDirection { get; set; }

        [DataMember(Name="stringsChangeBowDirectionImposed")]
        BoundingBox StringsChangeBowDirectionImposed { get; set; }

        [DataMember(Name="stringsChangeBowDirectionLiga")]
        BoundingBox StringsChangeBowDirectionLiga { get; set; }

        [DataMember(Name="stringsDownBow")]
        BoundingBox StringsDownBow { get; set; }

        [DataMember(Name="stringsDownBowTurned")]
        BoundingBox StringsDownBowTurned { get; set; }

        [DataMember(Name="stringsFouette")]
        BoundingBox StringsFouette { get; set; }

        [DataMember(Name="stringsHalfHarmonic")]
        BoundingBox StringsHalfHarmonic { get; set; }

        [DataMember(Name="stringsHarmonic")]
        BoundingBox StringsHarmonic { get; set; }

        [DataMember(Name="stringsJeteAbove")]
        BoundingBox StringsJeteAbove { get; set; }

        [DataMember(Name="stringsJeteBelow")]
        BoundingBox StringsJeteBelow { get; set; }

        [DataMember(Name="stringsMuteOff")]
        BoundingBox StringsMuteOff { get; set; }

        [DataMember(Name="stringsMuteOn")]
        BoundingBox StringsMuteOn { get; set; }

        [DataMember(Name="stringsOverpressureDownBow")]
        BoundingBox StringsOverpressureDownBow { get; set; }

        [DataMember(Name="stringsOverpressureNoDirection")]
        BoundingBox StringsOverpressureNoDirection { get; set; }

        [DataMember(Name="stringsOverpressurePossibileDownBow")]
        BoundingBox StringsOverpressurePossibileDownBow { get; set; }

        [DataMember(Name="stringsOverpressurePossibileUpBow")]
        BoundingBox StringsOverpressurePossibileUpBow { get; set; }

        [DataMember(Name="stringsOverpressureUpBow")]
        BoundingBox StringsOverpressureUpBow { get; set; }

        [DataMember(Name="stringsThumbPosition")]
        BoundingBox StringsThumbPosition { get; set; }

        [DataMember(Name="stringsThumbPositionTurned")]
        BoundingBox StringsThumbPositionTurned { get; set; }

        [DataMember(Name="stringsUpBow")]
        BoundingBox StringsUpBow { get; set; }

        [DataMember(Name="stringsUpBowTurned")]
        BoundingBox StringsUpBowTurned { get; set; }

        [DataMember(Name="stringsVibratoPulse")]
        BoundingBox StringsVibratoPulse { get; set; }

        [DataMember(Name="systemDivider")]
        BoundingBox SystemDivider { get; set; }

        [DataMember(Name="systemDividerExtraLong")]
        BoundingBox SystemDividerExtraLong { get; set; }

        [DataMember(Name="systemDividerLong")]
        BoundingBox SystemDividerLong { get; set; }

        [DataMember(Name="textAugmentationDot")]
        BoundingBox TextAugmentationDot { get; set; }

        [DataMember(Name="textBlackNoteFrac16thLongStem")]
        BoundingBox TextBlackNoteFrac16ThLongStem { get; set; }

        [DataMember(Name="textBlackNoteFrac16thShortStem")]
        BoundingBox TextBlackNoteFrac16ThShortStem { get; set; }

        [DataMember(Name="textBlackNoteFrac32ndLongStem")]
        BoundingBox TextBlackNoteFrac32NdLongStem { get; set; }

        [DataMember(Name="textBlackNoteFrac8thLongStem")]
        BoundingBox TextBlackNoteFrac8ThLongStem { get; set; }

        [DataMember(Name="textBlackNoteFrac8thShortStem")]
        BoundingBox TextBlackNoteFrac8ThShortStem { get; set; }

        [DataMember(Name="textBlackNoteLongStem")]
        BoundingBox TextBlackNoteLongStem { get; set; }

        [DataMember(Name="textBlackNoteShortStem")]
        BoundingBox TextBlackNoteShortStem { get; set; }

        [DataMember(Name="textCont16thBeamLongStem")]
        BoundingBox TextCont16ThBeamLongStem { get; set; }

        [DataMember(Name="textCont16thBeamShortStem")]
        BoundingBox TextCont16ThBeamShortStem { get; set; }

        [DataMember(Name="textCont32ndBeamLongStem")]
        BoundingBox TextCont32NdBeamLongStem { get; set; }

        [DataMember(Name="textCont8thBeamLongStem")]
        BoundingBox TextCont8ThBeamLongStem { get; set; }

        [DataMember(Name="textCont8thBeamShortStem")]
        BoundingBox TextCont8ThBeamShortStem { get; set; }

        [DataMember(Name="textTie")]
        BoundingBox TextTie { get; set; }

        [DataMember(Name="textTuplet3LongStem")]
        BoundingBox TextTuplet3LongStem { get; set; }

        [DataMember(Name="textTuplet3ShortStem")]
        BoundingBox TextTuplet3ShortStem { get; set; }

        [DataMember(Name="textTupletBracketEndLongStem")]
        BoundingBox TextTupletBracketEndLongStem { get; set; }

        [DataMember(Name="textTupletBracketEndShortStem")]
        BoundingBox TextTupletBracketEndShortStem { get; set; }

        [DataMember(Name="textTupletBracketStartLongStem")]
        BoundingBox TextTupletBracketStartLongStem { get; set; }

        [DataMember(Name="textTupletBracketStartShortStem")]
        BoundingBox TextTupletBracketStartShortStem { get; set; }

        [DataMember(Name="timeSig0")]
        BoundingBox TimeSig0 { get; set; }

        [DataMember(Name="timeSig0Denominator")]
        BoundingBox TimeSig0Denominator { get; set; }

        [DataMember(Name="timeSig0Large")]
        BoundingBox TimeSig0Large { get; set; }

        [DataMember(Name="timeSig0Numerator")]
        BoundingBox TimeSig0Numerator { get; set; }

        [DataMember(Name="timeSig0Reversed")]
        BoundingBox TimeSig0Reversed { get; set; }

        [DataMember(Name="timeSig0Small")]
        BoundingBox TimeSig0Small { get; set; }

        [DataMember(Name="timeSig0Turned")]
        BoundingBox TimeSig0Turned { get; set; }

        [DataMember(Name="timeSig1")]
        BoundingBox TimeSig1 { get; set; }

        [DataMember(Name="timeSig12over8")]
        BoundingBox TimeSig12Over8 { get; set; }

        [DataMember(Name="timeSig1Denominator")]
        BoundingBox TimeSig1Denominator { get; set; }

        [DataMember(Name="timeSig1Large")]
        BoundingBox TimeSig1Large { get; set; }

        [DataMember(Name="timeSig1Numerator")]
        BoundingBox TimeSig1Numerator { get; set; }

        [DataMember(Name="timeSig1Reversed")]
        BoundingBox TimeSig1Reversed { get; set; }

        [DataMember(Name="timeSig1Small")]
        BoundingBox TimeSig1Small { get; set; }

        [DataMember(Name="timeSig1Turned")]
        BoundingBox TimeSig1Turned { get; set; }

        [DataMember(Name="timeSig2")]
        BoundingBox TimeSig2 { get; set; }

        [DataMember(Name="timeSig2Denominator")]
        BoundingBox TimeSig2Denominator { get; set; }

        [DataMember(Name="timeSig2Large")]
        BoundingBox TimeSig2Large { get; set; }

        [DataMember(Name="timeSig2Numerator")]
        BoundingBox TimeSig2Numerator { get; set; }

        [DataMember(Name="timeSig2Reversed")]
        BoundingBox TimeSig2Reversed { get; set; }

        [DataMember(Name="timeSig2Small")]
        BoundingBox TimeSig2Small { get; set; }

        [DataMember(Name="timeSig2Turned")]
        BoundingBox TimeSig2Turned { get; set; }

        [DataMember(Name="timeSig2over2")]
        BoundingBox TimeSig2Over2 { get; set; }

        [DataMember(Name="timeSig2over4")]
        BoundingBox TimeSig2Over4 { get; set; }

        [DataMember(Name="timeSig3")]
        BoundingBox TimeSig3 { get; set; }

        [DataMember(Name="timeSig3Denominator")]
        BoundingBox TimeSig3Denominator { get; set; }

        [DataMember(Name="timeSig3Large")]
        BoundingBox TimeSig3Large { get; set; }

        [DataMember(Name="timeSig3Numerator")]
        BoundingBox TimeSig3Numerator { get; set; }

        [DataMember(Name="timeSig3Reversed")]
        BoundingBox TimeSig3Reversed { get; set; }

        [DataMember(Name="timeSig3Small")]
        BoundingBox TimeSig3Small { get; set; }

        [DataMember(Name="timeSig3Turned")]
        BoundingBox TimeSig3Turned { get; set; }

        [DataMember(Name="timeSig3over2")]
        BoundingBox TimeSig3Over2 { get; set; }

        [DataMember(Name="timeSig3over4")]
        BoundingBox TimeSig3Over4 { get; set; }

        [DataMember(Name="timeSig3over8")]
        BoundingBox TimeSig3Over8 { get; set; }

        [DataMember(Name="timeSig4")]
        BoundingBox TimeSig4 { get; set; }

        [DataMember(Name="timeSig4Denominator")]
        BoundingBox TimeSig4Denominator { get; set; }

        [DataMember(Name="timeSig4Large")]
        BoundingBox TimeSig4Large { get; set; }

        [DataMember(Name="timeSig4Numerator")]
        BoundingBox TimeSig4Numerator { get; set; }

        [DataMember(Name="timeSig4Reversed")]
        BoundingBox TimeSig4Reversed { get; set; }

        [DataMember(Name="timeSig4Small")]
        BoundingBox TimeSig4Small { get; set; }

        [DataMember(Name="timeSig4Turned")]
        BoundingBox TimeSig4Turned { get; set; }

        [DataMember(Name="timeSig4over4")]
        BoundingBox TimeSig4Over4 { get; set; }

        [DataMember(Name="timeSig5")]
        BoundingBox TimeSig5 { get; set; }

        [DataMember(Name="timeSig5Denominator")]
        BoundingBox TimeSig5Denominator { get; set; }

        [DataMember(Name="timeSig5Large")]
        BoundingBox TimeSig5Large { get; set; }

        [DataMember(Name="timeSig5Numerator")]
        BoundingBox TimeSig5Numerator { get; set; }

        [DataMember(Name="timeSig5Reversed")]
        BoundingBox TimeSig5Reversed { get; set; }

        [DataMember(Name="timeSig5Small")]
        BoundingBox TimeSig5Small { get; set; }

        [DataMember(Name="timeSig5Turned")]
        BoundingBox TimeSig5Turned { get; set; }

        [DataMember(Name="timeSig5over4")]
        BoundingBox TimeSig5Over4 { get; set; }

        [DataMember(Name="timeSig5over8")]
        BoundingBox TimeSig5Over8 { get; set; }

        [DataMember(Name="timeSig6")]
        BoundingBox TimeSig6 { get; set; }

        [DataMember(Name="timeSig6Denominator")]
        BoundingBox TimeSig6Denominator { get; set; }

        [DataMember(Name="timeSig6Large")]
        BoundingBox TimeSig6Large { get; set; }

        [DataMember(Name="timeSig6Numerator")]
        BoundingBox TimeSig6Numerator { get; set; }

        [DataMember(Name="timeSig6Reversed")]
        BoundingBox TimeSig6Reversed { get; set; }

        [DataMember(Name="timeSig6Small")]
        BoundingBox TimeSig6Small { get; set; }

        [DataMember(Name="timeSig6Turned")]
        BoundingBox TimeSig6Turned { get; set; }

        [DataMember(Name="timeSig6over4")]
        BoundingBox TimeSig6Over4 { get; set; }

        [DataMember(Name="timeSig6over8")]
        BoundingBox TimeSig6Over8 { get; set; }

        [DataMember(Name="timeSig7")]
        BoundingBox TimeSig7 { get; set; }

        [DataMember(Name="timeSig7Denominator")]
        BoundingBox TimeSig7Denominator { get; set; }

        [DataMember(Name="timeSig7Large")]
        BoundingBox TimeSig7Large { get; set; }

        [DataMember(Name="timeSig7Numerator")]
        BoundingBox TimeSig7Numerator { get; set; }

        [DataMember(Name="timeSig7Reversed")]
        BoundingBox TimeSig7Reversed { get; set; }

        [DataMember(Name="timeSig7Small")]
        BoundingBox TimeSig7Small { get; set; }

        [DataMember(Name="timeSig7Turned")]
        BoundingBox TimeSig7Turned { get; set; }

        [DataMember(Name="timeSig7over8")]
        BoundingBox TimeSig7Over8 { get; set; }

        [DataMember(Name="timeSig8")]
        BoundingBox TimeSig8 { get; set; }

        [DataMember(Name="timeSig8Denominator")]
        BoundingBox TimeSig8Denominator { get; set; }

        [DataMember(Name="timeSig8Large")]
        BoundingBox TimeSig8Large { get; set; }

        [DataMember(Name="timeSig8Numerator")]
        BoundingBox TimeSig8Numerator { get; set; }

        [DataMember(Name="timeSig8Reversed")]
        BoundingBox TimeSig8Reversed { get; set; }

        [DataMember(Name="timeSig8Small")]
        BoundingBox TimeSig8Small { get; set; }

        [DataMember(Name="timeSig8Turned")]
        BoundingBox TimeSig8Turned { get; set; }

        [DataMember(Name="timeSig9")]
        BoundingBox TimeSig9 { get; set; }

        [DataMember(Name="timeSig9Large")]
        BoundingBox TimeSig9Large { get; set; }

        [DataMember(Name="timeSig9Reversed")]
        BoundingBox TimeSig9Reversed { get; set; }

        [DataMember(Name="timeSig9Small")]
        BoundingBox TimeSig9Small { get; set; }

        [DataMember(Name="timeSig9Turned")]
        BoundingBox TimeSig9Turned { get; set; }

        [DataMember(Name="timeSig9over8")]
        BoundingBox TimeSig9Over8 { get; set; }

        [DataMember(Name="timeSigBracketLeft")]
        BoundingBox TimeSigBracketLeft { get; set; }

        [DataMember(Name="timeSigBracketLeftSmall")]
        BoundingBox TimeSigBracketLeftSmall { get; set; }

        [DataMember(Name="timeSigBracketRight")]
        BoundingBox TimeSigBracketRight { get; set; }

        [DataMember(Name="timeSigBracketRightSmall")]
        BoundingBox TimeSigBracketRightSmall { get; set; }

        [DataMember(Name="timeSigComma")]
        BoundingBox TimeSigComma { get; set; }

        [DataMember(Name="timeSigCommon")]
        BoundingBox TimeSigCommon { get; set; }

        [DataMember(Name="timeSigCommonLarge")]
        BoundingBox TimeSigCommonLarge { get; set; }

        [DataMember(Name="timeSigCommonReversed")]
        BoundingBox TimeSigCommonReversed { get; set; }

        [DataMember(Name="timeSigCommonTurned")]
        BoundingBox TimeSigCommonTurned { get; set; }

        [DataMember(Name="timeSigCut2")]
        BoundingBox TimeSigCut2 { get; set; }

        [DataMember(Name="timeSigCut3")]
        BoundingBox TimeSigCut3 { get; set; }

        [DataMember(Name="timeSigCutCommon")]
        BoundingBox TimeSigCutCommon { get; set; }

        [DataMember(Name="timeSigCutCommonLarge")]
        BoundingBox TimeSigCutCommonLarge { get; set; }

        [DataMember(Name="timeSigCutCommonReversed")]
        BoundingBox TimeSigCutCommonReversed { get; set; }

        [DataMember(Name="timeSigCutCommonTurned")]
        BoundingBox TimeSigCutCommonTurned { get; set; }

        [DataMember(Name="timeSigEquals")]
        BoundingBox TimeSigEquals { get; set; }

        [DataMember(Name="timeSigFractionHalf")]
        BoundingBox TimeSigFractionHalf { get; set; }

        [DataMember(Name="timeSigFractionOneThird")]
        BoundingBox TimeSigFractionOneThird { get; set; }

        [DataMember(Name="timeSigFractionQuarter")]
        BoundingBox TimeSigFractionQuarter { get; set; }

        [DataMember(Name="timeSigFractionThreeQuarters")]
        BoundingBox TimeSigFractionThreeQuarters { get; set; }

        [DataMember(Name="timeSigFractionTwoThirds")]
        BoundingBox TimeSigFractionTwoThirds { get; set; }

        [DataMember(Name="timeSigFractionalSlash")]
        BoundingBox TimeSigFractionalSlash { get; set; }

        [DataMember(Name="timeSigMinus")]
        BoundingBox TimeSigMinus { get; set; }

        [DataMember(Name="timeSigMultiply")]
        BoundingBox TimeSigMultiply { get; set; }

        [DataMember(Name="timeSigOpenPenderecki")]
        BoundingBox TimeSigOpenPenderecki { get; set; }

        [DataMember(Name="timeSigParensLeft")]
        BoundingBox TimeSigParensLeft { get; set; }

        [DataMember(Name="timeSigParensLeftSmall")]
        BoundingBox TimeSigParensLeftSmall { get; set; }

        [DataMember(Name="timeSigParensRight")]
        BoundingBox TimeSigParensRight { get; set; }

        [DataMember(Name="timeSigParensRightSmall")]
        BoundingBox TimeSigParensRightSmall { get; set; }

        [DataMember(Name="timeSigPlus")]
        BoundingBox TimeSigPlus { get; set; }

        [DataMember(Name="timeSigPlusLarge")]
        BoundingBox TimeSigPlusLarge { get; set; }

        [DataMember(Name="timeSigPlusSmall")]
        BoundingBox TimeSigPlusSmall { get; set; }

        [DataMember(Name="timeSigSlash")]
        BoundingBox TimeSigSlash { get; set; }

        [DataMember(Name="timeSigX")]
        BoundingBox TimeSigX { get; set; }

        [DataMember(Name="tremolo1")]
        BoundingBox Tremolo1 { get; set; }

        [DataMember(Name="tremolo2")]
        BoundingBox Tremolo2 { get; set; }

        [DataMember(Name="tremolo3")]
        BoundingBox Tremolo3 { get; set; }

        [DataMember(Name="tremolo4")]
        BoundingBox Tremolo4 { get; set; }

        [DataMember(Name="tremolo5")]
        BoundingBox Tremolo5 { get; set; }

        [DataMember(Name="tremoloDivisiDots2")]
        BoundingBox TremoloDivisiDots2 { get; set; }

        [DataMember(Name="tremoloDivisiDots3")]
        BoundingBox TremoloDivisiDots3 { get; set; }

        [DataMember(Name="tremoloDivisiDots4")]
        BoundingBox TremoloDivisiDots4 { get; set; }

        [DataMember(Name="tremoloDivisiDots6")]
        BoundingBox TremoloDivisiDots6 { get; set; }

        [DataMember(Name="tremoloFingered1")]
        BoundingBox TremoloFingered1 { get; set; }

        [DataMember(Name="tremoloFingered2")]
        BoundingBox TremoloFingered2 { get; set; }

        [DataMember(Name="tremoloFingered3")]
        BoundingBox TremoloFingered3 { get; set; }

        [DataMember(Name="tremoloFingered4")]
        BoundingBox TremoloFingered4 { get; set; }

        [DataMember(Name="tremoloFingered5")]
        BoundingBox TremoloFingered5 { get; set; }

        [DataMember(Name="tripleTongueAbove")]
        BoundingBox TripleTongueAbove { get; set; }

        [DataMember(Name="tripleTongueAboveNoSlur")]
        BoundingBox TripleTongueAboveNoSlur { get; set; }

        [DataMember(Name="tripleTongueBelow")]
        BoundingBox TripleTongueBelow { get; set; }

        [DataMember(Name="tripleTongueBelowNoSlur")]
        BoundingBox TripleTongueBelowNoSlur { get; set; }

        [DataMember(Name="tuplet0")]
        BoundingBox Tuplet0 { get; set; }

        [DataMember(Name="tuplet1")]
        BoundingBox Tuplet1 { get; set; }

        [DataMember(Name="tuplet2")]
        BoundingBox Tuplet2 { get; set; }

        [DataMember(Name="tuplet3")]
        BoundingBox Tuplet3 { get; set; }

        [DataMember(Name="tuplet4")]
        BoundingBox Tuplet4 { get; set; }

        [DataMember(Name="tuplet5")]
        BoundingBox Tuplet5 { get; set; }

        [DataMember(Name="tuplet6")]
        BoundingBox Tuplet6 { get; set; }

        [DataMember(Name="tuplet7")]
        BoundingBox Tuplet7 { get; set; }

        [DataMember(Name="tuplet8")]
        BoundingBox Tuplet8 { get; set; }

        [DataMember(Name="tuplet9")]
        BoundingBox Tuplet9 { get; set; }

        [DataMember(Name="tupletColon")]
        BoundingBox TupletColon { get; set; }

        [DataMember(Name="unmeasuredTremolo")]
        BoundingBox UnmeasuredTremolo { get; set; }

        [DataMember(Name="unmeasuredTremoloSimple")]
        BoundingBox UnmeasuredTremoloSimple { get; set; }

        [DataMember(Name="unpitchedPercussionClef1")]
        BoundingBox UnpitchedPercussionClef1 { get; set; }

        [DataMember(Name="unpitchedPercussionClef1Alt")]
        BoundingBox UnpitchedPercussionClef1Alt { get; set; }

        [DataMember(Name="unpitchedPercussionClef2")]
        BoundingBox UnpitchedPercussionClef2 { get; set; }

        [DataMember(Name="ventiduesima")]
        BoundingBox Ventiduesima { get; set; }

        [DataMember(Name="ventiduesimaAlta")]
        BoundingBox VentiduesimaAlta { get; set; }

        [DataMember(Name="ventiduesimaBassa")]
        BoundingBox VentiduesimaBassa { get; set; }

        [DataMember(Name="ventiduesimaBassaMb")]
        BoundingBox VentiduesimaBassaMb { get; set; }

        [DataMember(Name="ventiquattresima")]
        BoundingBox Ventiquattresima { get; set; }

        [DataMember(Name="ventiquattresimaAlta")]
        BoundingBox VentiquattresimaAlta { get; set; }

        [DataMember(Name="ventiquattresimaBassa")]
        BoundingBox VentiquattresimaBassa { get; set; }

        [DataMember(Name="ventiquattresimaBassaMb")]
        BoundingBox VentiquattresimaBassaMb { get; set; }

        [DataMember(Name="vocalFingerClickStockhausen")]
        BoundingBox VocalFingerClickStockhausen { get; set; }

        [DataMember(Name="vocalMouthClosed")]
        BoundingBox VocalMouthClosed { get; set; }

        [DataMember(Name="vocalMouthOpen")]
        BoundingBox VocalMouthOpen { get; set; }

        [DataMember(Name="vocalMouthPursed")]
        BoundingBox VocalMouthPursed { get; set; }

        [DataMember(Name="vocalMouthSlightlyOpen")]
        BoundingBox VocalMouthSlightlyOpen { get; set; }

        [DataMember(Name="vocalMouthWideOpen")]
        BoundingBox VocalMouthWideOpen { get; set; }

        [DataMember(Name="vocalNasalVoice")]
        BoundingBox VocalNasalVoice { get; set; }

        [DataMember(Name="vocalSprechgesang")]
        BoundingBox VocalSprechgesang { get; set; }

        [DataMember(Name="vocalTongueClickStockhausen")]
        BoundingBox VocalTongueClickStockhausen { get; set; }

        [DataMember(Name="vocalTongueFingerClickStockhausen")]
        BoundingBox VocalTongueFingerClickStockhausen { get; set; }

        [DataMember(Name="vocalsSussurando")]
        BoundingBox VocalsSussurando { get; set; }

        [DataMember(Name="wiggleArpeggiatoDown")]
        BoundingBox WiggleArpeggiatoDown { get; set; }

        [DataMember(Name="wiggleArpeggiatoDownArrow")]
        BoundingBox WiggleArpeggiatoDownArrow { get; set; }

        [DataMember(Name="wiggleArpeggiatoDownSwash")]
        BoundingBox WiggleArpeggiatoDownSwash { get; set; }

        [DataMember(Name="wiggleArpeggiatoDownSwashCouperin")]
        BoundingBox WiggleArpeggiatoDownSwashCouperin { get; set; }

        [DataMember(Name="wiggleArpeggiatoUp")]
        BoundingBox WiggleArpeggiatoUp { get; set; }

        [DataMember(Name="wiggleArpeggiatoUpArrow")]
        BoundingBox WiggleArpeggiatoUpArrow { get; set; }

        [DataMember(Name="wiggleArpeggiatoUpSwash")]
        BoundingBox WiggleArpeggiatoUpSwash { get; set; }

        [DataMember(Name="wiggleArpeggiatoUpSwashCouperin")]
        BoundingBox WiggleArpeggiatoUpSwashCouperin { get; set; }

        [DataMember(Name="wiggleCircular")]
        BoundingBox WiggleCircular { get; set; }

        [DataMember(Name="wiggleCircularConstant")]
        BoundingBox WiggleCircularConstant { get; set; }

        [DataMember(Name="wiggleCircularConstantFlipped")]
        BoundingBox WiggleCircularConstantFlipped { get; set; }

        [DataMember(Name="wiggleCircularConstantFlippedLarge")]
        BoundingBox WiggleCircularConstantFlippedLarge { get; set; }

        [DataMember(Name="wiggleCircularConstantLarge")]
        BoundingBox WiggleCircularConstantLarge { get; set; }

        [DataMember(Name="wiggleCircularEnd")]
        BoundingBox WiggleCircularEnd { get; set; }

        [DataMember(Name="wiggleCircularLarge")]
        BoundingBox WiggleCircularLarge { get; set; }

        [DataMember(Name="wiggleCircularLarger")]
        BoundingBox WiggleCircularLarger { get; set; }

        [DataMember(Name="wiggleCircularLargerStill")]
        BoundingBox WiggleCircularLargerStill { get; set; }

        [DataMember(Name="wiggleCircularLargest")]
        BoundingBox WiggleCircularLargest { get; set; }

        [DataMember(Name="wiggleCircularSmall")]
        BoundingBox WiggleCircularSmall { get; set; }

        [DataMember(Name="wiggleCircularStart")]
        BoundingBox WiggleCircularStart { get; set; }

        [DataMember(Name="wiggleGlissando")]
        BoundingBox WiggleGlissando { get; set; }

        [DataMember(Name="wiggleGlissandoGroup1")]
        BoundingBox WiggleGlissandoGroup1 { get; set; }

        [DataMember(Name="wiggleGlissandoGroup2")]
        BoundingBox WiggleGlissandoGroup2 { get; set; }

        [DataMember(Name="wiggleGlissandoGroup3")]
        BoundingBox WiggleGlissandoGroup3 { get; set; }

        [DataMember(Name="wiggleRandom1")]
        BoundingBox WiggleRandom1 { get; set; }

        [DataMember(Name="wiggleRandom2")]
        BoundingBox WiggleRandom2 { get; set; }

        [DataMember(Name="wiggleRandom3")]
        BoundingBox WiggleRandom3 { get; set; }

        [DataMember(Name="wiggleRandom4")]
        BoundingBox WiggleRandom4 { get; set; }

        [DataMember(Name="wiggleSawtooth")]
        BoundingBox WiggleSawtooth { get; set; }

        [DataMember(Name="wiggleSawtoothNarrow")]
        BoundingBox WiggleSawtoothNarrow { get; set; }

        [DataMember(Name="wiggleSawtoothWide")]
        BoundingBox WiggleSawtoothWide { get; set; }

        [DataMember(Name="wiggleSquareWave")]
        BoundingBox WiggleSquareWave { get; set; }

        [DataMember(Name="wiggleSquareWaveNarrow")]
        BoundingBox WiggleSquareWaveNarrow { get; set; }

        [DataMember(Name="wiggleSquareWaveWide")]
        BoundingBox WiggleSquareWaveWide { get; set; }

        [DataMember(Name="wiggleTrill")]
        BoundingBox WiggleTrill { get; set; }

        [DataMember(Name="wiggleTrillFast")]
        BoundingBox WiggleTrillFast { get; set; }

        [DataMember(Name="wiggleTrillFaster")]
        BoundingBox WiggleTrillFaster { get; set; }

        [DataMember(Name="wiggleTrillFasterStill")]
        BoundingBox WiggleTrillFasterStill { get; set; }

        [DataMember(Name="wiggleTrillFastest")]
        BoundingBox WiggleTrillFastest { get; set; }

        [DataMember(Name="wiggleTrillSlow")]
        BoundingBox WiggleTrillSlow { get; set; }

        [DataMember(Name="wiggleTrillSlower")]
        BoundingBox WiggleTrillSlower { get; set; }

        [DataMember(Name="wiggleTrillSlowerStill")]
        BoundingBox WiggleTrillSlowerStill { get; set; }

        [DataMember(Name="wiggleTrillSlowest")]
        BoundingBox WiggleTrillSlowest { get; set; }

        [DataMember(Name="wiggleVIbratoLargestSlower")]
        BoundingBox WiggleVIbratoLargestSlower { get; set; }

        [DataMember(Name="wiggleVIbratoMediumSlower")]
        BoundingBox WiggleVIbratoMediumSlower { get; set; }

        [DataMember(Name="wiggleVibrato")]
        BoundingBox WiggleVibrato { get; set; }

        [DataMember(Name="wiggleVibratoLargeFast")]
        BoundingBox WiggleVibratoLargeFast { get; set; }

        [DataMember(Name="wiggleVibratoLargeFaster")]
        BoundingBox WiggleVibratoLargeFaster { get; set; }

        [DataMember(Name="wiggleVibratoLargeFasterStill")]
        BoundingBox WiggleVibratoLargeFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoLargeFastest")]
        BoundingBox WiggleVibratoLargeFastest { get; set; }

        [DataMember(Name="wiggleVibratoLargeSlow")]
        BoundingBox WiggleVibratoLargeSlow { get; set; }

        [DataMember(Name="wiggleVibratoLargeSlower")]
        BoundingBox WiggleVibratoLargeSlower { get; set; }

        [DataMember(Name="wiggleVibratoLargeSlowest")]
        BoundingBox WiggleVibratoLargeSlowest { get; set; }

        [DataMember(Name="wiggleVibratoLargestFast")]
        BoundingBox WiggleVibratoLargestFast { get; set; }

        [DataMember(Name="wiggleVibratoLargestFaster")]
        BoundingBox WiggleVibratoLargestFaster { get; set; }

        [DataMember(Name="wiggleVibratoLargestFasterStill")]
        BoundingBox WiggleVibratoLargestFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoLargestFastest")]
        BoundingBox WiggleVibratoLargestFastest { get; set; }

        [DataMember(Name="wiggleVibratoLargestSlow")]
        BoundingBox WiggleVibratoLargestSlow { get; set; }

        [DataMember(Name="wiggleVibratoLargestSlowest")]
        BoundingBox WiggleVibratoLargestSlowest { get; set; }

        [DataMember(Name="wiggleVibratoMediumFast")]
        BoundingBox WiggleVibratoMediumFast { get; set; }

        [DataMember(Name="wiggleVibratoMediumFaster")]
        BoundingBox WiggleVibratoMediumFaster { get; set; }

        [DataMember(Name="wiggleVibratoMediumFasterStill")]
        BoundingBox WiggleVibratoMediumFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoMediumFastest")]
        BoundingBox WiggleVibratoMediumFastest { get; set; }

        [DataMember(Name="wiggleVibratoMediumSlow")]
        BoundingBox WiggleVibratoMediumSlow { get; set; }

        [DataMember(Name="wiggleVibratoMediumSlowest")]
        BoundingBox WiggleVibratoMediumSlowest { get; set; }

        [DataMember(Name="wiggleVibratoSmallFast")]
        BoundingBox WiggleVibratoSmallFast { get; set; }

        [DataMember(Name="wiggleVibratoSmallFaster")]
        BoundingBox WiggleVibratoSmallFaster { get; set; }

        [DataMember(Name="wiggleVibratoSmallFasterStill")]
        BoundingBox WiggleVibratoSmallFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoSmallFastest")]
        BoundingBox WiggleVibratoSmallFastest { get; set; }

        [DataMember(Name="wiggleVibratoSmallSlow")]
        BoundingBox WiggleVibratoSmallSlow { get; set; }

        [DataMember(Name="wiggleVibratoSmallSlower")]
        BoundingBox WiggleVibratoSmallSlower { get; set; }

        [DataMember(Name="wiggleVibratoSmallSlowest")]
        BoundingBox WiggleVibratoSmallSlowest { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFast")]
        BoundingBox WiggleVibratoSmallestFast { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFaster")]
        BoundingBox WiggleVibratoSmallestFaster { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFasterStill")]
        BoundingBox WiggleVibratoSmallestFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFastest")]
        BoundingBox WiggleVibratoSmallestFastest { get; set; }

        [DataMember(Name="wiggleVibratoSmallestSlow")]
        BoundingBox WiggleVibratoSmallestSlow { get; set; }

        [DataMember(Name="wiggleVibratoSmallestSlower")]
        BoundingBox WiggleVibratoSmallestSlower { get; set; }

        [DataMember(Name="wiggleVibratoSmallestSlowest")]
        BoundingBox WiggleVibratoSmallestSlowest { get; set; }

        [DataMember(Name="wiggleVibratoStart")]
        BoundingBox WiggleVibratoStart { get; set; }

        [DataMember(Name="wiggleVibratoWide")]
        BoundingBox WiggleVibratoWide { get; set; }

        [DataMember(Name="wiggleWavy")]
        BoundingBox WiggleWavy { get; set; }

        [DataMember(Name="wiggleWavyNarrow")]
        BoundingBox WiggleWavyNarrow { get; set; }

        [DataMember(Name="wiggleWavyWide")]
        BoundingBox WiggleWavyWide { get; set; }

        [DataMember(Name="windClosedHole")]
        BoundingBox WindClosedHole { get; set; }

        [DataMember(Name="windFlatEmbouchure")]
        BoundingBox WindFlatEmbouchure { get; set; }

        [DataMember(Name="windHalfClosedHole1")]
        BoundingBox WindHalfClosedHole1 { get; set; }

        [DataMember(Name="windHalfClosedHole2")]
        BoundingBox WindHalfClosedHole2 { get; set; }

        [DataMember(Name="windHalfClosedHole3")]
        BoundingBox WindHalfClosedHole3 { get; set; }

        [DataMember(Name="windLessRelaxedEmbouchure")]
        BoundingBox WindLessRelaxedEmbouchure { get; set; }

        [DataMember(Name="windLessTightEmbouchure")]
        BoundingBox WindLessTightEmbouchure { get; set; }

        [DataMember(Name="windMouthpiecePop")]
        BoundingBox WindMouthpiecePop { get; set; }

        [DataMember(Name="windMultiphonicsBlackStem")]
        BoundingBox WindMultiphonicsBlackStem { get; set; }

        [DataMember(Name="windMultiphonicsBlackWhiteStem")]
        BoundingBox WindMultiphonicsBlackWhiteStem { get; set; }

        [DataMember(Name="windMultiphonicsWhiteStem")]
        BoundingBox WindMultiphonicsWhiteStem { get; set; }

        [DataMember(Name="windOpenHole")]
        BoundingBox WindOpenHole { get; set; }

        [DataMember(Name="windReedPositionIn")]
        BoundingBox WindReedPositionIn { get; set; }

        [DataMember(Name="windReedPositionNormal")]
        BoundingBox WindReedPositionNormal { get; set; }

        [DataMember(Name="windReedPositionOut")]
        BoundingBox WindReedPositionOut { get; set; }

        [DataMember(Name="windRelaxedEmbouchure")]
        BoundingBox WindRelaxedEmbouchure { get; set; }

        [DataMember(Name="windRimOnly")]
        BoundingBox WindRimOnly { get; set; }

        [DataMember(Name="windSharpEmbouchure")]
        BoundingBox WindSharpEmbouchure { get; set; }

        [DataMember(Name="windStrongAirPressure")]
        BoundingBox WindStrongAirPressure { get; set; }

        [DataMember(Name="windThreeQuartersClosedHole")]
        BoundingBox WindThreeQuartersClosedHole { get; set; }

        [DataMember(Name="windTightEmbouchure")]
        BoundingBox WindTightEmbouchure { get; set; }

        [DataMember(Name="windTrillKey")]
        BoundingBox WindTrillKey { get; set; }

        [DataMember(Name="windVeryTightEmbouchure")]
        BoundingBox WindVeryTightEmbouchure { get; set; }

        [DataMember(Name="windWeakAirPressure")]
        BoundingBox WindWeakAirPressure { get; set; }
    }
}
