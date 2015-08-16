namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Indicates that element can be positioned horizontally.
    /// </summary>
    public interface IHasCustomXPosition
    {
        double? DefaultXPosition { get; set; }
    }
}