using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.PeekStrategies;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Manufaktura.Controls.Audio
{
    public abstract class ThreadScorePlayer : ScorePlayer
    {
        protected Timer Timer { get; set; }
        private bool ShouldRestart { get; set; }
        private Tuplet TupletState { get; set; }

        public override MusicalSymbol CurrentElement
        {
            get
            {
                return base.CurrentElement;
            }
            protected set
            {
                base.CurrentElement = value;
                ThreadSafeCurrentElement = value;
            }
        }

        public abstract MusicalSymbol ThreadSafeCurrentElement
        {
            get;
            set;
        }

        private TimerState currentTimerState;

        public override Score Score
        {
            get
            {
                return base.Score;
            }
            set
            {
                if (Timer != null) Stop(); //Tell current timer to stop (it will take it some time)
                base.Score = value;     //Set new score
                if (currentTimerState != null) currentTimerState.CancellationToken = true;
                currentTimerState = new TimerState(value);
                Timer = new Timer(FetchNextElement, currentTimerState, Timeout.Infinite, Timeout.Infinite);  //Create a new timer and let previous timer stop uninterrupted
            }
        }

        protected ThreadScorePlayer(Score score) : base(score)
        {
        }

        /// <summary>
        /// Start playback.
        /// </summary>
        public override void Start()
        {
            if (State != PlaybackState.Paused) ShouldRestart = true;
            State = PlaybackState.Playing;
            Timer.Change(0, Timeout.Infinite);
        }

        /// <summary>
        /// Stop playback.
        /// </summary>
        public override void Stop()
        {
            Timer.Change(Timeout.Infinite, Timeout.Infinite);
            State = PlaybackState.Idle;
        }

        /// <summary>
        /// Pause playback.
        /// </summary>
        public override void Pause()
        {
            Timer.Change(Timeout.Infinite, Timeout.Infinite);
            State = PlaybackState.Paused;
        }

        private void FetchNextElement(object state)
        {
            try
            {
                if (ShouldRestart)
                {
                    CurrentElement = null;
                    Enumerator = null;
                    ShouldRestart = false;
                }

                TimerState timerState = state as TimerState;
                if (timerState == null) return;
                if (timerState.CancellationToken) return;
                if (timerState.Score == null) return;
                Staff staff = timerState.Score.Staves.FirstOrDefault();
                if (staff == null) return;

                if (Enumerator == null) Enumerator = staff.Elements.GetEnumerator();
                if (!Enumerator.MoveNext())
                {
                    Stop();
                    return;
                }
                CurrentElement = Enumerator.Current;

                NoteOrRest noteOrRest = GetCurrentNoteOrRestAndDetermineTupletState(staff);
                if (ProcessGraceNotesAndChordElements(staff))
                {
                    FetchNextElement(timerState);
                    return;
                }

                //
                // Determine duration == next note start time
                //
                IHasDuration durationElement = CurrentElement as IHasDuration;
                if (durationElement != null)
                {
                    double dueTime = MusicalSymbol.DurationToTime(durationElement, Tempo).TotalMilliseconds;
                    if (TupletState != null) dueTime = dueTime / TupletState.NumberOfNotesUnderTuplet * ((double)durationElement.BaseDuration.Denominator / (double)Tempo.BeatUnit.Denominator);
                    Debug.WriteLine("{0} with {1} dots will be played in {2} ms", durationElement.BaseDuration, durationElement.NumberOfDots, dueTime);
                    Timer.Change((int)dueTime, Timeout.Infinite);
                }
                else FetchNextElement(timerState); //If element does not have a duration, play next immediately

                if (noteOrRest != null && noteOrRest.Tuplet == TupletType.Stop) TupletState = null;

                PlayElement(CurrentElement, staff);
            }
            catch (Exception ex)
            {
                PlaybackExceptions.Add(ex);
                Stop();
            }
        }

        private bool ProcessGraceNotesAndChordElements(Staff staff)
        {
            Note note = CurrentElement as Note;
            if (note != null)
            {
                if (note.Voice > 1 || note.IsGraceNote) //Skip note if it's a grace note or it's in another voice
                {
                    return true;
                }

                Note nextNote = staff.Peek<Note>(note, PeekType.NextElement);   //If next note is chord element, play all notes in the chord simultaneously
                if (nextNote != null && nextNote.IsChordElement)
                {
                    PlayElement(CurrentElement, staff);
                    return true;
                }
            }
            return false;
        }

        private NoteOrRest GetCurrentNoteOrRestAndDetermineTupletState(Staff staff)
        {
            NoteOrRest noteOrRest = CurrentElement as NoteOrRest;
            if (noteOrRest != null && noteOrRest.Voice < 2)
            {
                if (noteOrRest.Tuplet == TupletType.Start)
                {
                    NoteOrRest tupletStart = staff.Peek<NoteOrRest>(noteOrRest, PeekType.BeginningOfTuplet);
                    NoteOrRest tupletEnd = staff.Peek<NoteOrRest>(noteOrRest, PeekType.EndOfTuplet);
                    if (tupletStart != null && tupletEnd != null)
                    {
                        TupletState = new Tuplet();
                        TupletState.NumberOfNotesUnderTuplet = staff.Elements.GetRange(staff.Elements.IndexOf(tupletStart), staff.Elements.IndexOf(tupletEnd) -
                            staff.Elements.IndexOf(tupletStart)).OfType<NoteOrRest>().Where(nr => !(nr is Note) || (nr is Note && !((Note)nr).IsChordElement)).Count() + 1;
                    }
                }
            }
            return noteOrRest;
        }

        class TimerState
        {
            public Score Score { get; private set; }
            public bool CancellationToken { get; set; }

            public TimerState(Score score)
            {
                Score = score;
            }
        }
    }
}
