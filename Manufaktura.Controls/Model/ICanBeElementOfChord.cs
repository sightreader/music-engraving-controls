namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Indicates that element can be upper element od chord.
    /// </summary>
    public interface ICanBeUpperMemberOfChord
    {
        /// <summary>
        /// If true, the element is the upper element of a chord. If false, element is a base of the chord or is not a member of any chord.
        /// </summary>
        bool IsUpperMemberOfChord { get; }
    }
}