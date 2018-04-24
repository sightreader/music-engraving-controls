using System.Collections.Generic;

namespace Manufaktura.Controls.Rendering.Implementations
{
    /// <summary>
    /// Font information
    /// </summary>
    public struct HtmlFontInfo
    {
        public HtmlFontInfo(string name, double size, params string[] uris)
            : this()
        {
            Uris = new List<string>();
            Name = name;
            Uris.AddRange(uris);
            Size = size;
        }

        /// <summary>
        /// Font name
        /// </summary>
		public string Name { get; private set; }

        /// <summary>
        /// Font size
        /// </summary>
		public double Size { get; private set; }

        /// <summary>
        /// Font uris
        /// </summary>
		public List<string> Uris { get; private set; }
    }
}