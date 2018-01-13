namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Barline types of part group. Corresponds to 'group-barline' MusicXml element.
    /// </summary>
	public enum GroupBarlineType
    {
        /// <summary>
        /// Barlines are drawn in staves and between staves
        /// </summary>
		Enabled,

        /// <summary>
        /// Barlines are not drawn
        /// </summary>
		Disabled,

        /// <summary>
        /// Barlines are drawn only between staves
        /// </summary>
		Mensurstrich
    }
}