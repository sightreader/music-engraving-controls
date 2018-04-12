using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.Fonts
{
    /// <summary>
    /// Music font styles.
    /// </summary>
    public enum MusicFontStyles
    {
        MusicFont,
        [Obsolete("Only for Polihymnia font")]
        GraceNoteFont,
        LyricsFont,
        LyricsFontBold,
        [Obsolete("Only for Polihymnia font")]
        StaffFont,
        [Obsolete("Only for Polihymnia font")]
        MiscArticulationFont,
        [Obsolete("Only for Polihymnia font")]
        TrillFont,
        [Obsolete("Only for Polihymnia font")]
        DirectionFont,
        [Obsolete("Only for Polihymnia font")]
        TimeSignatureFont
    }
}
