using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a symbol that is rendered completely or partially as a text block (with DrawString method).
    /// </summary>
    public interface IRenderedAsTextBlock
    {
        char GetCharacter(IMusicFont font);

        /// <summary>
        /// Location of text block with text representing the musical symbol
        /// </summary>
        Point TextBlockLocation { get; set; }
    }
}