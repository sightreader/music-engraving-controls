namespace Manufaktura.Music.Model.MajorAndMinor
{
    /// <summary>
    /// Represents flags that describe a Minor or Major scale
    /// </summary>
    public struct MajorAndMinorScaleFlags
    {
        private MajorAndMinorScaleFlags(bool isMinor, bool isFlat)
                    : this()
        {
            IsMinor = isMinor;
            IsFlat = isFlat;
        }

        /// <summary>
        /// Returns MajorAndMinorScaleFlags for Major flat scale
        /// </summary>
        public static MajorAndMinorScaleFlags MajorFlat { get { return new MajorAndMinorScaleFlags(false, true); } }

        /// <summary>
        /// Returns MajorAndMinorScaleFlags for Major sharp scale
        /// </summary>

        public static MajorAndMinorScaleFlags MajorSharp { get { return new MajorAndMinorScaleFlags(false, false); } }

        /// <summary>
        /// Returns MajorAndMinorScaleFlags for Minor flat scale
        /// </summary>

        public static MajorAndMinorScaleFlags MinorFlat { get { return new MajorAndMinorScaleFlags(true, true); } }

        /// <summary>
        /// Returns MajorAndMinorScaleFlags for Minor sharp scale
        /// </summary>

        public static MajorAndMinorScaleFlags MinorSharp { get { return new MajorAndMinorScaleFlags(true, false); } }

        /// <summary>
        /// Idicates that this scale is flat scale.
        /// </summary>
        public bool IsFlat { get; set; }

        /// <summary>
        /// Indicates that this scale is minor scale.
        /// </summary>
        public bool IsMinor { get; set; }
    }
}