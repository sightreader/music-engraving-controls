namespace Manufaktura.Music.Model.MajorAndMinor
{
    public struct MajorAndMinorScaleFlags
    {
        public static MajorAndMinorScaleFlags MajorFlat { get { return new MajorAndMinorScaleFlags(false, true); } }

        public static MajorAndMinorScaleFlags MajorSharp { get { return new MajorAndMinorScaleFlags(false, false); } }

        public static MajorAndMinorScaleFlags MinorFlat { get { return new MajorAndMinorScaleFlags(true, true); } }

        public static MajorAndMinorScaleFlags MinorSharp { get { return new MajorAndMinorScaleFlags(true, false); } }

        /// <summary>
        /// Idicates that this scale is flat scale.
        /// </summary>
        public bool IsFlat { get; set; }

        /// <summary>
        /// Indicates that this scale is minor scale.
        /// </summary>
        public bool IsMinor { get; set; }

        private MajorAndMinorScaleFlags(bool isMinor, bool isFlat)
            : this()
        {
            IsMinor = isMinor;
            IsFlat = isFlat;
        }
    }
}