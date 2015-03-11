using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public struct Tempo
    {
        public RhythmicDuration BeatUnit { get; set; }
        public int BeatsPerMinute {get; set;}
        public TimeSpan BeatTimeSpan
        {
            get
            {
                return TimeSpan.FromSeconds(60d / BeatsPerMinute);
            }
        }

        public Tempo(RhythmicDuration beatUnit, int beatsPerMinute) : this()
        {
            BeatUnit = beatUnit;
            BeatsPerMinute = beatsPerMinute;
        }

        public static Tempo Allegro { get { return new Tempo(RhythmicDuration.Quarter, 120); } }
        public static Tempo Andante { get { return new Tempo(RhythmicDuration.Quarter, 80); } }
        public static Tempo Adagio { get { return new Tempo(RhythmicDuration.Quarter, 40); } }
    }
}
