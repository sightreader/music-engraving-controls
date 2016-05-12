using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Windows.UI.Core;

namespace Manufaktura.Controls.UniversalApps.Audio
{
	public class TestTaskScorePlayer : TaskScorePlayer
	{
		private readonly CoreDispatcher dispatcher;

		public TestTaskScorePlayer(Score score, CoreDispatcher dispatcher) : base(score)
		{
			this.dispatcher = dispatcher;
		}

		public override void PlayElement(MusicalSymbol element)
		{
			Debug.WriteLine($"Played {element}.");
		}

		protected override async void PlayQueue(Queue<TimelineElement<IHasDuration>> simultaneousElements)
		{
			while (simultaneousElements.Any())
			{
				var element = simultaneousElements.Dequeue();
				if (ElapsedTime != element.When) await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => ElapsedTime = element.When);
				var note = element.What as Note;
				if (note == null) continue;
				PlayElement(note);
			}
		}
	}
}