using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Audio
{
    public abstract class ScorePlayer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private PlaybackState _state;
        public PlaybackState State
        {
            get { return _state; }
            set { _state = value; OnPropertyChanged("State"); }
        }

        public Score Score { get; protected set; }
        private MusicalSymbol _currentElement;
        public virtual MusicalSymbol CurrentElement
        {
            get { return _currentElement; }
            protected set { _currentElement = value; OnPropertyChanged("CurrentElement"); }
        }

        public IEnumerator<MusicalSymbol> Enumerator { get; protected set; }
        private int _tempo;
        public int Tempo
        {
            get { return _tempo; }
            set { _tempo = value; OnPropertyChanged("Tempo"); }
        }
        public MusicalSymbolDuration TempoBase { get; set; }

        public List<Exception> PlaybackExceptions { get; private set; }

        protected ScorePlayer(Score score)
        {
            Score = score;
            Tempo = 120;
            TempoBase = MusicalSymbolDuration.Quarter;
            State = PlaybackState.Idle;
            PlaybackExceptions = new List<Exception>();
        }

        public abstract void Start();
        public abstract void PlayElement(MusicalSymbol element, Staff staff);
        public abstract void Stop();
        public abstract void Pause();

        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public enum PlaybackState
        {
            Idle,
            Paused,
            Playing
        }

        
    }
}
