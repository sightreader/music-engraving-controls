using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Manufaktura.Controls.Audio
{
	public abstract class TaskScorePlayer : ScorePlayer
	{
		private IEnumerator<TimelineElement<IHasDuration>> timelineInterator;

		public TaskScorePlayer(Score score) : base(score)
		{
			timelineInterator = EnumerateTimeline().GetEnumerator();
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
			timelineInterator = EnumerateTimeline().GetEnumerator();
		}

		private IEnumerable<TimelineElement<IHasDuration>> EnumerateTimeline()
		{
			var elapsedTime = TimeSpan.Zero;
			for (var i = 0; i < Score.FirstStaff.Measures.Count; i++)
			{
				var elements = new List<Tuple<decimal, IHasDuration>>();
				foreach (var staff in Score.Staves)
				{
					var measure = staff.Measures[i];

					var elapsed = 0m;
					foreach (var durationElement in measure.Elements.OfType<IHasDuration>())
					{
						elements.Add(new Tuple<decimal, IHasDuration>(elapsed, durationElement));
						if (!((durationElement as Note)?.IsUpperMemberOfChord ?? false))
							elapsed += new RhythmicDuration(durationElement.BaseDuration.Denominator, durationElement.NumberOfDots).ToDecimal();
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

		private async void PlayInternal()
		{
			var simultaneousElements = new Queue<TimelineElement<IHasDuration>>();

			TimelineElement<IHasDuration> previousElement = null;
			TimeSpan lastAwaitedDuration = TimeSpan.Zero;

			while (timelineInterator.MoveNext())
			{
				var timelineElement = timelineInterator.Current;
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

		private void PlayQueue(Queue<TimelineElement<IHasDuration>> simultaneousElements)
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
	}
}