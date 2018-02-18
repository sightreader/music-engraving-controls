namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Indicates that element can be positioned vertically.
    /// </summary>
    public interface IHasCustomYPosition
    {
        /// <summary>
        /// Default Y position for element
        /// </summary>
        double? DefaultYPosition { get; set; }
    }
}