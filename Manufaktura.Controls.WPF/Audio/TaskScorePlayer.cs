using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Manufaktura.Controls.WPF.Audio
{
	public class TaskScorePlayer : ScorePlayer
	{
		public TaskScorePlayer(Score score) : base(score)
		{
		}

		public override void Pause()
		{
		}

		public override void PlayElement(MusicalSymbol element, Staff staff)
		{
			Debug.WriteLine($"Element {element} played.");
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
				var elements = new List<Tuple<RhythmicDuration, IHasDuration>>();
				foreach (var staff in Score.Staves)
				{
					var measure = staff.Measures[i];
					var durationElements = measure.Elements.OfType<IHasDuration>().Select(o => new Tuple<RhythmicDuration, IHasDuration>(new RhythmicDuration(o.BaseDuration.Denominator, o.NumberOfDots), o)).ToList();
					for (int j = 1; j < durationElements.Count; j++)
					{
						durationElements[j] = new Tuple<RhythmicDuration, IHasDuration>(durationElements[j].Item1 + durationElements[j - 1].Item1, durationElements[j].Item2);
					}
					elements.AddRange(durationElements);
				}
				var orderedElements = elements.OrderBy(e => e.Item1.ToDecimal()).ToList();
				foreach (var element in orderedElements)
				{
					yield return new TimelineElement<IHasDuration>(element.Item1.ToTimeSpan(Tempo) + elapsedTime, element.Item2);
				}
				elapsedTime += orderedElements.Last().Item1.ToTimeSpan(Tempo);
			}
		}

		private void PlayQueue(Queue<TimelineElement<IHasDuration>> simultaneousElements)
		{
			lock (simultaneousElements)
			{
				while (simultaneousElements.Any())
				{
					var element = simultaneousElements.Dequeue();
					PlayElement(element.What as MusicalSymbol, null);
				}
			}
		}
	}
}