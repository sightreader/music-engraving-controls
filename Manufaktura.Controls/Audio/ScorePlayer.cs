using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Audio
{
    public abstract class ScorePlayer
    {
        public Score Score { get; protected set; }
        public MusicalSymbol CurrentElement { get; protected set; }
        public IEnumerator<MusicalSymbol> Enumerator { get; protected set; }
        public int Tempo { get; set; }
        public MusicalSymbolDuration TempoBase { get; set; }
        public PlaybackState State { get; set; }

        protected ScorePlayer(Score score)
        {
            Score = score;
            Tempo = 120;
            TempoBase = MusicalSymbolDuration.Quarter;
            State = PlaybackState.Idle;
        }

        public abstract void Start();
        public abstract void PlayElement(MusicalSymbol element, Staff staff);
        public abstract void Stop();
        public abstract void Pause();

        public enum PlaybackState
        {
            Idle,
            Paused,
            Playing
        }
    }
}
