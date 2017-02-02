using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manufaktura.Controls.Audio
{
	public abstract class TaskScorePlayer : ScorePlayer
	{
		private IEnumerator<TimelineElement<IHasDuration>> timelineIterator;

		public TaskScorePlayer(Score score) : base(score)
		{
			timelineIterator = EnumerateTimeline().GetEnumerator();
		}

		public override MusicalSymbol CurrentElement
		{
			get
			{
				return EnumerateTimeline().FirstOrDefault(t => t.When == ElapsedTime)?.What as MusicalSymbol;
			}

			protected set
			{
				throw new Exception("CurrentElement method is readonly on this class.");
			}
		}

		public override TimeSpan ElapsedTime
		{
			get
			{
				return base.ElapsedTime;
			}

			set
			{
				base.ElapsedTime = value;
				OnPropertyChanged(() => CurrentElement);
				OnPropertyChanged(() => CurrentPosition);
			}
		}

		public override void Pause()
		{
			State = PlaybackState.Paused;
		}

		public override async void Play()
		{
			State = PlaybackState.Playing;
			await Task.Factory.StartNew(PlayInternal);
		}

		public override void Stop()
		{
			State = PlaybackState.Idle;
			timelineIterator = EnumerateTimeline().GetEnumerator();
		}

		protected virtual void PlayQueue(Queue<TimelineElement<IHasDuration>> simultaneousElements)
		{
			lock (simultaneousElements)
			{
				while (simultaneousElements.Any())
				{
					var element = simultaneousElements.Dequeue();
					if (ElapsedTime != element.When) ElapsedTime = element.When;
					var note = element.What as Note;
					if (note == null) continue;
					PlayElement(note);
				}
			}
		}

		private async void PlayInternal()
		{
			var simultaneousElements = new Queue<TimelineElement<IHasDuration>>();

			TimelineElement<IHasDuration> previousElement = null;
			TimeSpan lastAwaitedDuration = TimeSpan.Zero;

			while (timelineIterator.MoveNext())
			{
				var timelineElement = timelineIterator.Current;
				if (State != PlaybackState.Playing) break;

				if (previousElement != null && timelineElement.When > previousElement.When)
				{
					await Task.Delay(lastAwaitedDuration == TimeSpan.Zero ? previousElement.When : previousElement.When - lastAwaitedDuration);
					PlayQueue(simultaneousElements);
					lastAwaitedDuration = previousElement.When;
				}

				simultaneousElements.Enqueue(timelineElement);
				previousElement = timelineElement;
			}

			if (simultaneousElements.Any())
			{
				await Task.Delay(lastAwaitedDuration == TimeSpan.Zero ? previousElement.When : previousElement.When - lastAwaitedDuration);
				PlayQueue(simultaneousElements);
			}
		}
	}
}