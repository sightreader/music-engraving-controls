using Windows.UI.Xaml.Media;

namespace Manufaktura.Controls.UniversalApps.Common
{
    public struct UWPFontInfo
    {
        public UWPFontInfo(string name, FontFamily family, double size, double cellAscent = 24.8) : this()
        {
            Family = family;
            Name = name;
            Size = size;
            CellAscent = cellAscent;
        }

        public double CellAscent { get; private set; }
        public FontFamily Family { get; set; }

        /// <summary>
        /// Font name
        /// </summary>
		public string Name { get; private set; }

        /// <summary>
        /// Font size
        /// </summary>
		public double Size { get; private set; }
    }
}