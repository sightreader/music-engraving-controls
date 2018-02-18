namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a part group
    /// </summary>
	public class PartGroup
	{
        /// <summary>
        /// Barline for the group
        /// </summary>
		public GroupBarlineType GroupBarline { get; set; } = GroupBarlineType.Enabled;

        /// <summary>
        /// Part group number
        /// </summary>
		public int Number { get; set; }
	}
}