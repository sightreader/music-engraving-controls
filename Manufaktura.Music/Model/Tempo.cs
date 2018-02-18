using System;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents a tempo.
    /// </summary>
    public struct Tempo
    {
        /// <summary>
        /// Beat unit (i.e. quarter, half, etc.)
        /// </summary>
        public RhythmicDuration BeatUnit { get; set; }

        /// <summary>
        /// Indicates how many BeatUnits are played per minute.
        /// </summary>
        public int BeatsPerMinute { get; set; }

        /// <summary>
        /// Duration of a single beat.
        /// </summary>
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

        /// <summary>
        /// Returns a tempo of q=120.
        /// </summary>
        public static Tempo Allegro { get { return new Tempo(RhythmicDuration.Quarter, 120); } }

        /// <summary>
        /// Returns a tempo of q=80.
        /// </summary>
        public static Tempo Andante { get { return new Tempo(RhythmicDuration.Quarter, 80); } }

        /// <summary>
        /// Returns a tempo of q=40.
        /// </summary>
        public static Tempo Adagio { get { return new Tempo(RhythmicDuration.Quarter, 40); } }
    }
}