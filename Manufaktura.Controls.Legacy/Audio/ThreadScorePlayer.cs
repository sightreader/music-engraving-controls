using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.PeekStrategies;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Manufaktura.Controls.Audio
{
	/// <summary>
	/// Implementation of ScorePlayer that uses System.Threading.Timer to play notes at the appropriate time.
	/// </summary>
	public abstract class ThreadScorePlayer : ScorePlayer
	{
		private TimerState currentTimerState;

		/// <summary>
		/// Initializes a new instance of ThreadScorePlayer for specific score.
		/// </summary>
		/// <param name="score">Score</param>
		protected ThreadScorePlayer(Score score) : base(score)
		{
		}

		/// <summary>
		/// Currently played element
		/// </summary>
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

		public IEnumerator<MusicalSymbol> Enumerator { get; private set; }

		/// <summary>
		/// Score played by this instance of player
		/// </summary>
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

		/// <summary>
		/// Currently played element (thread-safe)
		/// </summary>
		public abstract MusicalSymbol ThreadSafeCurrentElement
		{
			get;
			set;
		}

		/// <summary>
		/// Timer used to play notes at the appropriate time.
		/// </summary>
		protected Timer Timer { get; set; }

		private bool ShouldRestart { get; set; }
		private Tuplet TupletState { get; set; }

		/// <summary>
		/// Pause playback.
		/// </summary>
		public override void Pause()
		{
			Timer.Change(Timeout.Infinite, Timeout.Infinite);
			State = PlaybackState.Paused;
		}

		/// <summary>
		/// Start playback.
		/// </summary>
		public override void Play()
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

				PlayElement(CurrentElement);
			}
			catch (Exception ex)
			{
				PlaybackExceptions.Add(ex);
				Stop();
			}
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
							staff.Elements.IndexOf(tupletStart)).OfType<NoteOrRest>().Where(nr => !(nr is Note) || (nr is Note && !((Note)nr).IsUpperMemberOfChord)).Count() + 1;
					}
				}
			}
			return noteOrRest;
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
				if (nextNote != null && nextNote.IsUpperMemberOfChord)
				{
					PlayElement(CurrentElement);
					return true;
				}
			}
			return false;
		}

		private class TimerState
		{
			public TimerState(Score score)
			{
				Score = score;
			}

			public bool CancellationToken { get; set; }
			public Score Score { get; private set; }
		}
	}
}