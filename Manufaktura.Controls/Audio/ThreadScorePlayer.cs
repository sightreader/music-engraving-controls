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
        private bool shouldRestart { get; set; }
        private Tuplet tupletState { get; set; }

        protected ThreadScorePlayer(Score score) : base(score)
        {
            Timer = new Timer(PlayNextElement, null, Timeout.Infinite, Timeout.Infinite);
        }

        public override void Start()
        {
            if (State != PlaybackState.Paused) shouldRestart = true;
            State = PlaybackState.Playing;
            Timer.Change(0, Timeout.Infinite);
        }

        public override void Stop()
        {
            Timer.Change(Timeout.Infinite, Timeout.Infinite);
            State = PlaybackState.Idle;
        }

        public override void Pause()
        {
            Timer.Change(Timeout.Infinite, Timeout.Infinite);
            State = PlaybackState.Paused;
        }

        private void PlayNextElement(object state)
        {
            try
            {
                if (shouldRestart)
                {
                    CurrentElement = null;
                    Enumerator = null;
                    shouldRestart = false;
                }

                Staff staff = Score.Staves.FirstOrDefault();
                if (staff == null) return;

                if (Enumerator == null) Enumerator = staff.Elements.GetEnumerator();
                if (!Enumerator.MoveNext())
                {
                    Stop();
                    return;
                }
                CurrentElement = Enumerator.Current;

                //
                // Determine tuplet state
                //
                NoteOrRest noteOrRest = CurrentElement as NoteOrRest;
                if (noteOrRest != null && noteOrRest.Voice < 2)
                {
                    if (noteOrRest.Tuplet == TupletType.Start)
                    {
                        NoteOrRest tupletStart = staff.Peek<NoteOrRest>(noteOrRest, PeekType.BeginningOfTuplet);
                        NoteOrRest tupletEnd = staff.Peek<NoteOrRest>(noteOrRest, PeekType.EndOfTuplet);
                        if (tupletStart != null && tupletEnd != null)
                        {
                            tupletState = new Tuplet();
                            tupletState.NumberOfNotesUnderTuplet = staff.Elements.GetRange(staff.Elements.IndexOf(tupletStart), staff.Elements.IndexOf(tupletEnd) -
                                staff.Elements.IndexOf(tupletStart)).OfType<NoteOrRest>().Where(nr => !(nr is Note) || (nr is Note && !((Note)nr).IsChordElement)).Count() + 1;
                        }
                    }
                }

                //
                // Treatment of grace notes and chord elements
                //
                Note note = CurrentElement as Note;
                if (note != null)
                {
                    if (note.Voice > 1 || note.IsGraceNote) //Skip note if it's a grace note or it's in another voice
                    {
                        PlayNextElement(null);
                        return;
                    }

                    Note nextNote = staff.Peek<Note>(note, PeekType.NextElement);   //If next note is chord element, play all notes in the chord simultaneously
                    if (nextNote != null && nextNote.IsChordElement)
                    {
                        PlayElement(CurrentElement, staff);
                        PlayNextElement(null);
                        return;
                    }
                }

                //
                // Determine duration == next note start time
                //
                IHasDuration durationElement = CurrentElement as IHasDuration;
                if (durationElement != null)
                {
                    double dueTime = MusicalSymbol.DurationToTime(durationElement, Tempo, TempoBase).TotalMilliseconds;
                    if (tupletState != null) dueTime = dueTime / tupletState.NumberOfNotesUnderTuplet * ((double)durationElement.Duration / (double)TempoBase);
                    Debug.WriteLine("{0} with {1} dots will be played in {2} ms", durationElement.Duration, durationElement.NumberOfDots, dueTime);
                    Timer.Change((int)dueTime, Timeout.Infinite);
                }
                else PlayNextElement(null); //If element does not have a duration, play next immediately

                if (noteOrRest != null && noteOrRest.Tuplet == TupletType.Stop) tupletState = null;

                PlayElement(CurrentElement, staff);
            }
            catch (Exception ex)
            {
                PlaybackExceptions.Add(ex);
                Stop();
            }
        }
    }
}
