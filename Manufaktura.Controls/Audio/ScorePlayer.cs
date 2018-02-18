using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.PeekStrategies;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Audio
{
    /// <summary>
    /// Base class for implementing audio players.
    /// </summary>
    public abstract class ScorePlayer : ViewModel
    {
        private MusicalSymbol _currentElement;
        private PlaybackState _state;

        private Tempo _tempo;

        private TimeSpan elapsedTime;

        private PlaybackCursorPosition lastPosition = default(PlaybackCursorPosition);

        /// <summary>
        /// Initializes a new instance of ScorePlayer.
        /// </summary>
        /// <param name="score">Score</param>
        protected ScorePlayer(Score score)
        {
            Score = score;
            Tempo = Tempo.Allegro;
            State = PlaybackState.Idle;
            PlaybackExceptions = new List<Exception>();
        }

        /// <summary>
        /// Playback state
        /// </summary>
        public enum PlaybackState
        {
            /// <summary>
            /// Playback has not started yet
            /// </summary>
            Idle,

            /// <summary>
            /// Playback is paused
            /// </summary>
            Paused,

            /// <summary>
            /// Playing in progress
            /// </summary>
            Playing
        }

        [Flags]
        private enum PlayElementStrategies
        {
            DoNothing = 0,
            Play = 1,
            IncreaseElapsedTime = 2
        }

        /// <summary>
        /// Currently played element.
        /// </summary>
        public virtual MusicalSymbol CurrentElement
        {
            get { return _currentElement; }
            protected set { _currentElement = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Position of playback cursor
        /// </summary>
        public PlaybackCursorPosition CurrentPosition
        {
            get
            {
                var noteOrRest = CurrentElement as NoteOrRest;
                if (noteOrRest == null) return lastPosition;
                lastPosition = new PlaybackCursorPosition(Score.Systems.IndexOf(noteOrRest.Measure.System) + 1, noteOrRest.TextBlockLocation.X, DateTime.Now, new RhythmicDuration(noteOrRest.BaseDuration.Denominator, noteOrRest.NumberOfDots).ToTimeSpan(Tempo));
                return lastPosition;
            }
        }

        /// <summary>
        /// Elapsed playback time
        /// </summary>
        public virtual TimeSpan ElapsedTime
        {
            get { return elapsedTime; }
            set { elapsedTime = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// List of exceptions that occured during playback.
        /// </summary>
        public List<Exception> PlaybackExceptions { get; private set; }

        /// <summary>
        /// Score to play.
        /// </summary>
        public virtual Score Score { get; set; }

        /// <summary>
        /// Current playback state.
        /// </summary>
        public PlaybackState State
        {
            get { return _state; }
            set { _state = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Playback tempo.
        /// </summary>
        public Tempo Tempo
        {
            get { return _tempo; }
            set { _tempo = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Pause playback
        /// </summary>
        public abstract void Pause();

        /// <summary>
        /// Start playback.
        /// </summary>
        public abstract void Play();

        /// <summary>
        /// Play specific element from the score.
        /// </summary>
        /// <param name="element">Element</param>
        public abstract void PlayElement(MusicalSymbol element);

        /// <summary>
        /// Stop playback
        /// </summary>
        public abstract void Stop();

        /// <summary>
        /// Enumerates playback timeline
        /// </summary>
        /// <returns></returns>
        protected IEnumerable<TimelineElement<IHasDuration>> EnumerateTimeline()
        {
            var elapsedTime = TimeSpan.Zero;
            for (var i = 0; i < Score.FirstStaff.Measures.Count; i++)
            {
                var orderedElements = BuildMeasureTimeLine(i).OrderBy(e => e.Item1).ToList();
                foreach (var element in orderedElements)
                {
                    yield return new TimelineElement<IHasDuration>(TimeSpan.FromMilliseconds(element.Item1 * (4 * 4 / Tempo.BeatUnit.Denominator) * Tempo.BeatTimeSpan.TotalMilliseconds) + elapsedTime, element.Item2);
                }
                var lastItem = orderedElements.Any() ? orderedElements.Last() : null;
                if (lastItem != null)
                {
                    var endOfMeasure = lastItem.Item1 + new RhythmicDuration(lastItem.Item2.BaseDuration.Denominator, lastItem.Item2.NumberOfDots).ToDouble();
                    elapsedTime += TimeSpan.FromMilliseconds(endOfMeasure * (4 * 4 / Tempo.BeatUnit.Denominator) * Tempo.BeatTimeSpan.TotalMilliseconds);
                }
            }
        }

        private List<Tuple<double, IHasDuration>> BuildMeasureTimeLine(int measureIndex)
        {
            var elements = new List<Tuple<double, IHasDuration>>();
            foreach (var staff in Score.Staves)
            {
                var measure = staff.Measures[measureIndex];

                var elapsed = 0d;
                var lastElementDuration = 0d;
                Tuplet tupletState = null;
                foreach (var durationElement in measure.Elements.OfType<IHasDuration>())
                {
                    var strategy = GetProperStrategy(durationElement);

                    if (strategy.HasFlag(PlayElementStrategies.Play))
                    {
                        var realElapsedTime = elapsed;
                        if ((durationElement as Note)?.IsUpperMemberOfChord ?? false)
                        {
                            realElapsedTime -= lastElementDuration;   //Rewind to chord root position
                        }

                        elements.Add(new Tuple<double, IHasDuration>(realElapsedTime, durationElement));
                    }
                    if (strategy.HasFlag(PlayElementStrategies.IncreaseElapsedTime))
                    {
                        if (durationElement.Tuplet == TupletType.Start)
                        {
                            NoteOrRest tupletStart = staff.Peek<NoteOrRest>((MusicalSymbol)durationElement, PeekType.BeginningOfTuplet);
                            NoteOrRest tupletEnd = staff.Peek<NoteOrRest>((MusicalSymbol)durationElement, PeekType.EndOfTuplet);
                            if (tupletStart != null && tupletEnd != null)
                            {
                                tupletState = new Tuplet();
                                tupletState.NumberOfNotesUnderTuplet = staff.Elements.GetRange(staff.Elements.IndexOf(tupletStart), staff.Elements.IndexOf(tupletEnd) -
                                    staff.Elements.IndexOf(tupletStart)).OfType<NoteOrRest>().Where(nr => !(nr is Note) || (nr is Note && !((Note)nr).IsUpperMemberOfChord)).Count() + 1;
                            }
                        }

                        var dueTime = new RhythmicDuration(durationElement.BaseDuration.Denominator, durationElement.NumberOfDots).ToDouble();
                        if (tupletState != null) dueTime = dueTime / tupletState.NumberOfNotesUnderTuplet * (durationElement.BaseDuration.Denominator / Tempo.BeatUnit.Denominator);

                        elapsed += dueTime;
                        lastElementDuration = dueTime;
                        if (durationElement.Tuplet == TupletType.Stop) tupletState = null;
                    }
                }
            }
            return elements;
        }

        private PlayElementStrategies GetProperStrategy(IHasDuration durationElement)
        {
            var note = durationElement as Note;
            if (note != null)
            {
                if (note.IsGraceNote || note.IsCueNote) return PlayElementStrategies.DoNothing;
                if (note.Voice > 1) return PlayElementStrategies.DoNothing;
                if (note.IsUpperMemberOfChord) return PlayElementStrategies.Play;
                if (note.TieType == NoteTieType.Stop || note.TieType == NoteTieType.StopAndStartAnother) return PlayElementStrategies.IncreaseElapsedTime;
            }

            return PlayElementStrategies.Play | PlayElementStrategies.IncreaseElapsedTime;
        }
    }
}