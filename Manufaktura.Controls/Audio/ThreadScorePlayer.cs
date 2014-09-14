using Manufaktura.Controls.Model;
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

                Note note = CurrentElement as Note;
                if (note != null)
                {
                    if (note.Voice > 1 || note.IsGraceNote)
                    {
                        PlayNextElement(null);
                        return;
                    }

                    Note nextNote = staff.Peek<Note>(note, Staff.PeekType.NextElement);
                    if (nextNote != null && nextNote.IsChordElement)
                    {
                        PlayElement(CurrentElement, staff);
                        PlayNextElement(null);
                        return;
                    }
                }
                NoteOrRest noteOrRest = CurrentElement as NoteOrRest;
                if (noteOrRest != null)
                {
                    if (noteOrRest.Tuplet == TupletType.Start)
                    {
                        NoteOrRest tupletStart = staff.Peek<NoteOrRest>(note, Staff.PeekType.BeginningOfTuplet);
                        NoteOrRest tupletEnd = staff.Peek<NoteOrRest>(note, Staff.PeekType.EndOfTuplet);
                        if (tupletStart != null && tupletEnd != null)
                        {
                            tupletState = new Tuplet();
                            tupletState.NumberOfNotesUnderTuplet = staff.Elements.GetRange(staff.Elements.IndexOf(tupletStart), staff.Elements.IndexOf(tupletEnd) -
                                staff.Elements.IndexOf(tupletStart)).OfType<NoteOrRest>().Count() + 1;
                        }
                    }
                }

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
