using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a symbol that is rendered completely or partially as a text block (with DrawString method).
    /// </summary>
    public interface IRenderedAsTextBlock
    {
        /// <summary>
        /// Text representing the musical symbol
        /// </summary>
        string MusicalCharacter { get; }

        /// <summary>
        /// Music font used to render this element
        /// </summary>
        IMusicFont MusicFont { get; set; }

        /// <summary>
        /// Location of text block with text representing the musical symbol
        /// </summary>
        Point TextBlockLocation { get; set; }
    }
}