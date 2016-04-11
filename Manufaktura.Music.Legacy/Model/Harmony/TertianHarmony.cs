using Manufaktura.Music.Model.MajorAndMinor;
using System.Linq;

namespace Manufaktura.Music.Model.Harmony
{
    public class TertianHarmony : MajorAndMinorHarmony
    {
        public override DiatonicInterval GeneratorInterval
        {
            get { return DiatonicInterval.Third; }
        }

        public static Chord Create7thChord(Pitch basePitch, int inversion, MajorOrMinorScale scale)
        {
            return new TertianHarmony().CreateChord(basePitch, inversion, 3, scale).ApplyAlteration(3 - inversion, -1);
        }

        public static Chord CreateChord(Pitch basePitch, int inversion, MajorOrMinorScale scale)
        {
            return new TertianHarmony().CreateChord(basePitch, inversion, 2, scale);
        }
    }
}