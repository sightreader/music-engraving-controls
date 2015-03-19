using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a symbol that is rendered completely or partially as a text block (with DrawString method).
    /// </summary>
    public interface IRenderedAsTextBlock
    {
        Point TextBlockLocation { get; set; }
        string MusicalCharacter { get; }
        MusicFont MusicFont { get; set; }
    }
}
