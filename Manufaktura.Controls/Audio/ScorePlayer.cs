using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.PeekStrategies;
using Manufaktura.Model.MVVM;
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
				var noteOrRest = CurrentElement as NoteOrRest;
				if (noteOrRest == null) return lastPosition;
				lastPosition = new PlaybackCursorPosition(Score.Systems.IndexOf(noteOrRest.Measure.System) + 1, noteOrRest.TextBlockLocation.X, DateTime.Now, new RhythmicDuration(noteOrRest.BaseDuration.Denominator, noteOrRest.NumberOfDots).ToTimeSpan(Tempo));
				return lastPosition;
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

		protected IEnumerable<TimelineElement<IHasDuration>> EnumerateTimeline()
		{
			var elapsedTime = TimeSpan.Zero;
			for (var i = 0; i < Score.FirstStaff.Measures.Count; i++)
			{
				var elements = new List<Tuple<decimal, IHasDuration>>();
				foreach (var staff in Score.Staves)
				{
					var measure = staff.Measures[i];

					var elapsed = 0m;
					Tuplet tupletState = null;
					foreach (var durationElement in measure.Elements.OfType<IHasDuration>())
					{
						var note = durationElement as Note;
						if (note != null && (note.IsGraceNote || note.IsCueNote)) continue;		//TODO: Playback of grace notes
                        if (((durationElement as Note)?.Voice ?? 1) > 1) continue;              //TODO: Playback of other voices

                        elements.Add(new Tuple<decimal, IHasDuration>(elapsed, durationElement));
						if ((durationElement as Note)?.IsUpperMemberOfChord ?? false) continue;    //Upper member of chords are played but they don't increase elapsed time
                        
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

						var dueTime = new RhythmicDuration(durationElement.BaseDuration.Denominator, durationElement.NumberOfDots).ToDecimal();
						if (tupletState != null) dueTime = dueTime / tupletState.NumberOfNotesUnderTuplet * (durationElement.BaseDuration.Denominator / Tempo.BeatUnit.Denominator);

						elapsed += dueTime;
						if (durationElement.Tuplet == TupletType.Stop) tupletState = null;
					}
				}
				var orderedElements = elements.OrderBy(e => e.Item1).ToList();
				foreach (var element in orderedElements)
				{
					yield return new TimelineElement<IHasDuration>(TimeSpan.FromMilliseconds((double)element.Item1 * (4 * 4 / Tempo.BeatUnit.Denominator) * Tempo.BeatTimeSpan.TotalMilliseconds) + elapsedTime, element.Item2);
				}
				var lastItem = orderedElements.Last();
				var endOfMeasure = lastItem.Item1 + new RhythmicDuration(lastItem.Item2.BaseDuration.Denominator, lastItem.Item2.NumberOfDots).ToDecimal();
				elapsedTime += TimeSpan.FromMilliseconds((double)endOfMeasure * (4 * 4 / Tempo.BeatUnit.Denominator) * Tempo.BeatTimeSpan.TotalMilliseconds);
			}
		}
	}
}