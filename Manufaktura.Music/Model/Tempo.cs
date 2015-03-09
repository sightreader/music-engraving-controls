using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public class Tempo
    {
        public Duration BeatUnit { get; set; }
        public int BeatsPerMinute {get; set;}
        public TimeSpan BeatTimeSpan
        {
            get
            {
                return TimeSpan.FromSeconds(60d / BeatsPerMinute);
            }
        }

        public Tempo(Duration beatUnit, int beatsPerMinute)
        {
            BeatUnit = beatUnit;
            BeatsPerMinute = BeatsPerMinute;
        }

        public static Tempo Allegro { get { return new Tempo(Duration.Quarter, 120); } }
        public static Tempo Andante { get { return new Tempo(Duration.Quarter, 80); } }
        public static Tempo Adagio { get { return new Tempo(Duration.Quarter, 40); } }
    }
}
