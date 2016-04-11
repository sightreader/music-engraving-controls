namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Indicates that element can be positioned horizontally.
    /// </summary>
    public interface IHasCustomXPosition
    {

        /// <summary>
        /// Default X position of element
        /// </summary>
        double? DefaultXPosition { get; set; }
    }
}