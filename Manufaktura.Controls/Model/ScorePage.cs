using Manufaktura.Controls.Model.Collections;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Stores information about a score page
    /// </summary>
	public class ScorePage
    {
        internal ScorePage(Score score)
        {
            Score = score;
            Systems = new SystemCollection(this);
        }

        /// <summary>
        /// Default distance between staves. Corresponds to staff-distance MusicXml element
        /// </summary>
		public double? DefaultStaffDistance { get; set; }

        /// <summary>
        /// Default distance between systems. Corresponds to system-distance MusicXml element
        /// </summary>
		public double? DefaultSystemDistance { get; set; }

        /// <summary>
        /// Page height. Corresponds to page-height MusicXml element
        /// </summary>
		public double? Height { get; set; }

        /// <summary>
        /// Bottom margin. Corresponds to bottom-margin MusicXml element
        /// </summary>
		public double? MarginBottom { get; set; }

        /// <summary>
        /// Left margin. Corresponds to left-margin MusicXml element
        /// </summary>
		public double? MarginLeft { get; set; }

        /// <summary>
        /// right margin. Corresponds to right-margin MusicXml element
        /// </summary>
        public double? MarginRight { get; set; }

        /// <summary>
        /// Top margin. Corresponds to top-margin MusicXml element
        /// </summary>
        public double? MarginTop { get; set; }

        /// <summary>
        /// Score that contains this score page
        /// </summary>
        public Score Score { get; set; }

        /// <summary>
        /// Staff systems on this page
        /// </summary>
		public SystemCollection Systems { get; private set; }

        /// <summary>
        /// Page width. Corresponds to page-width MusicXml element
        /// </summary>
        public double? Width { get; set; }
    }
}