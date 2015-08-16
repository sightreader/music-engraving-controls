﻿using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Base class that represents note or rest.
    /// </summary>
    public abstract class NoteOrRest : MusicalSymbol, IHasDuration, ICanBeElementOfTuplet, IHasCustomXPosition, IRenderedAsTextBlock
    {
        protected bool hasFermataSign = false;
        protected Point location = new Point();
        protected string musicalCharacter;
        protected TupletType tuplet = TupletType.None;
        private RhythmicDuration duration;
        private IMusicFont musicFont = new PolihymniaFont();

        public RhythmicDuration BaseDuration
        {
            get
            {
                return Duration.WithoutDots;
            }
        }

        public double? DefaultXPosition { get; set; }

        public RhythmicDuration Duration { get { return duration; } set { duration = value; OnPropertyChanged(() => Duration); } }

        /// <summary>
        /// Indicates if note has fermata sign
        /// </summary>
        public bool HasFermataSign { get { return hasFermataSign; } set { hasFermataSign = value; OnPropertyChanged(() => HasFermataSign); } }

        public string MusicalCharacter
        {
            get { return musicalCharacter; }
        }

        /// <summary>
        /// Music font used to draw the note
        /// </summary>
        public IMusicFont MusicFont { get { return musicFont; } set { musicFont = value; OnPropertyChanged(() => MusicFont); } }

        public int NumberOfDots
        {
            get
            {
                return Duration.Dots;
            }
            set
            {
                Duration = new RhythmicDuration(BaseDuration.Denominator, value);
            }
        }

        public Point TextBlockLocation { get { return location; } set { location = value; } }

        public TupletType Tuplet { get { return tuplet; } set { tuplet = value; } }

        public VerticalPlacement? TupletPlacement { get; set; }

        public int Voice { get; set; }

        protected NoteOrRest()
        {
            Voice = 1;
        }

        public static NoteOrRest FromRhythmicUnit(RhythmicUnit unit)
        {
            return unit.IsRest ? (NoteOrRest)new Rest(unit.Duration) : new Note(unit.Duration);
        }
    }
}