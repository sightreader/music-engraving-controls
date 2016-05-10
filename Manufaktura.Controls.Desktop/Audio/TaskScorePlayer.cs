using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Manufaktura.Controls.Desktop.Audio
{
	public abstract class TaskScorePlayer : ScorePlayer
	{
		public TaskScorePlayer(Score score) : base(score)
		{
		}

		public override void Pause()
		{
		}

		public override async void Start()
		{
			var simultaneousElements = new Queue<TimelineElement<IHasDuration>>();

			TimelineElement<IHasDuration> previousElement = null;
			TimeSpan lastAwaitedDuration = TimeSpan.Zero;

			foreach (var timelineElement in EnumerateTimeline())
			{
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

		public override void Stop()
		{
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
						elapsed += new RhythmicDuration(durationElement.BaseDuration.Denominator, durationElement.NumberOfDots).ToDecimal();
					}

				}
				var orderedElements = elements.OrderBy(e => e.Item1).ToList();
				foreach (var element in orderedElements)
				{
					yield return new TimelineElement<IHasDuration>(TimeSpan.FromMilliseconds((double)element.Item1 * Tempo.BeatUnit.Denominator * Tempo.BeatTimeSpan.TotalMilliseconds) + elapsedTime, element.Item2);
				}
				var lastItem = orderedElements.Last();
				var endOfMeasure = lastItem.Item1 + new RhythmicDuration(lastItem.Item2.BaseDuration.Denominator, lastItem.Item2.NumberOfDots).ToDecimal();
				elapsedTime += TimeSpan.FromMilliseconds((double)endOfMeasure * Tempo.BeatUnit.Denominator * Tempo.BeatTimeSpan.TotalMilliseconds);
			}
		}

		private void PlayQueue(Queue<TimelineElement<IHasDuration>> simultaneousElements)
		{
			lock (simultaneousElements)
			{
				Debug.WriteLine($"Playing: {string.Join(", ", simultaneousElements.Select(se => se.What).OfType<Note>().Select(n => n.Pitch).ToList())}");
				while (simultaneousElements.Any())
				{
					var element = simultaneousElements.Dequeue();
					var note = element.What as Note;
					if (note == null) continue;
					PlayElement(note, null);
				}
			}
		}
	}
}