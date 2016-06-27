using System;

namespace Manufaktura.Controls.Audio
{
	public class TimelineElement<TElement>
	{
		public TimelineElement(TimeSpan when, TElement what)
		{
			When = when;
			What = what;
		}

		public TElement What { get; private set; }
		public TimeSpan When { get; private set; }
	}
}