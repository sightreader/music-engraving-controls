using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public static class HistoricIntervalNames
    {
        public static Interval Unisonus { get { return Interval.PerfectUnison; } }
        public static Interval UnisonusSuperflua { get { return Interval.AugmentedUnison; } }
        public static Interval Semitonus { get { return Interval.MinorSecond; } }
        public static Interval Tonus { get { return Interval.MajorSecond; } }
        public static Interval Semiditonus { get { return Interval.MinorThird; } }
        public static Interval Ditonus { get { return Interval.MajorThird; } }
        public static Interval Semidiatessaron { get { return Interval.DimnishedFourth; } }
        public static Interval Diatessaron { get { return Interval.PerfectFourth; } }
        public static Interval Tritonus { get { return Interval.AugmentedFourth; } }
        public static Interval Semitritonus { get { return Interval.DimnishedFifth; } }
        public static Interval Semidiapente { get { return Interval.DimnishedFifth; } }
        public static Interval Diapente { get { return Interval.PerfectFifth; } }
        public static Interval DiapenteSuperflua { get { return Interval.AugmentedFifth; } }
        public static Interval Semihexachordum { get { return Interval.DimnishedSixth; } }
        public static Interval HexachordumMinus { get { return Interval.MinorSixth; } }
        public static Interval HexachordumMaius { get { return Interval.MajorSixth; } }
        public static Interval TonusCumDiapente { get { return Interval.MajorSixth; } }
        public static Interval Pentatonus { get { return Interval.MinorSeventh; } }
        public static Interval HeptachordumMinus { get { return Interval.MinorSeventh; } }
        public static Interval HeptachordumMaius { get { return Interval.MajorSeventh; } }
        public static Interval HeptachordumSuperflua { get { return Interval.AugmentedSeventh; } }
        public static Interval Semidiapason { get { return Interval.DimnishedOctave; } }
        public static Interval Diapason { get { return Interval.PerfectOctave; } }

    }
}
