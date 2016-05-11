using Manufaktura.Controls.Model;
using Manufaktura.Model.MVVM;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;

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

		/// <summary>
		/// Currently played element.
		/// </summary>
		public virtual MusicalSymbol CurrentElement
		{
			get { return _currentElement; }
			protected set { _currentElement = value; OnPropertyChanged(() => CurrentElement); }
		}

		public PlaybackCursorPosition CurrentPosition
		{
			get
			{
				var textBlockElement = CurrentElement as IRenderedAsTextBlock;
				if (textBlockElement == null) return default(PlaybackCursorPosition);
				var musicalSymbol = CurrentElement as MusicalSymbol;
				if (musicalSymbol == null) return default(PlaybackCursorPosition); ;
				return new PlaybackCursorPosition(Score.Systems.IndexOf(musicalSymbol.Measure.System) + 1, textBlockElement.TextBlockLocation.X);
			}
		}

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
			set { _state = value; OnPropertyChanged(() => State); }
		}

		/// <summary>
		/// Playback tempo.
		/// </summary>
		public Tempo Tempo
		{
			get { return _tempo; }
			set { _tempo = value; OnPropertyChanged(() => Tempo); }
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
		/// <param name="staff">Staff</param>
		public abstract void PlayElement(MusicalSymbol element);

		/// <summary>
		/// Stop playback
		/// </summary>
		public abstract void Stop();
	}
}