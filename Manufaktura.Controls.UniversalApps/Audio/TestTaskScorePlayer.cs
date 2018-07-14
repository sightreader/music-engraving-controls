/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

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