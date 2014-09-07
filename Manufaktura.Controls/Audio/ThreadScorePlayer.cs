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
            if (note != null && note.Voice > 1) 
            { 
                PlayNextElement(null); return; 
            }

            IHasDuration durationElement = CurrentElement as IHasDuration;
            if (durationElement != null)
            {
                int dueTime = (int)MusicalSymbol.DurationToTime(durationElement, Tempo, TempoBase).TotalMilliseconds;
                Debug.WriteLine("{0} with {1} dots will be played in {2} ms", durationElement.Duration, durationElement.NumberOfDots, dueTime);
                Timer.Change(dueTime, Timeout.Infinite);
            }
            else PlayNextElement(null); //If element does not have a duration, play next immediately

            PlayElement(CurrentElement, staff);
        }
    }
}
