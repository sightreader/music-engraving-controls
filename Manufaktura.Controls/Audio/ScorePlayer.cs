using Manufaktura.Controls.Model;
using Manufaktura.Model.MVVM;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Audio
{
    /// <summary>
    /// Base class for implementing audio players.
    /// </summary>
    public abstract class ScorePlayer : ViewModel
    {
        private PlaybackState _state;

        /// <summary>
        /// Current playback state.
        /// </summary>
        public PlaybackState State
        {
            get { return _state; }
            set { _state = value; OnPropertyChanged(() => State); }
        }

        /// <summary>
        /// Score to play.
        /// </summary>
        public virtual Score Score { get; set; }
        private MusicalSymbol _currentElement;

        /// <summary>
        /// Currently played element.
        /// </summary>
        public virtual MusicalSymbol CurrentElement
        {
            get { return _currentElement; }
            protected set { _currentElement = value; OnPropertyChanged(() => CurrentElement); }
        }

        /// <summary>
        /// Enumerator for iterating musical symbols in the score.
        /// </summary>
        public IEnumerator<MusicalSymbol> Enumerator { get; protected set; }
        private Tempo _tempo;

        /// <summary>
        /// Playback tempo.
        /// </summary>
        public Tempo Tempo
        {
            get { return _tempo; }
            set { _tempo = value; OnPropertyChanged(() => Tempo); }
        }

        /// <summary>
        /// List of exceptions that occured during playback.
        /// </summary>
        public List<Exception> PlaybackExceptions { get; private set; }

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
        /// Start playback.
        /// </summary>
        public abstract void Start();
        /// <summary>
        /// Play specific element from the score.
        /// </summary>
        /// <param name="element">Element</param>
        /// <param name="staff">Staff</param>
        public abstract void PlayElement(MusicalSymbol element, Staff staff);
        /// <summary>
        /// Stop playback
        /// </summary>
        public abstract void Stop();
        /// <summary>
        /// Pause playback
        /// </summary>
        public abstract void Pause();

        public enum PlaybackState
        {
            Idle,
            Paused,
            Playing
        }

        
    }
}
