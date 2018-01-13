using System;

namespace Manufaktura.Controls.Audio
{
    /// <summary>
    /// Class that indicates that a specific element has to be played at specific time
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
	public class TimelineElement<TElement>
    {
        /// <summary>
        /// Initializes a new instance of TimelineElement which indicates that element "what" has to be played at specific time "when".
        /// </summary>
        /// <param name="when"></param>
        /// <param name="what"></param>
		public TimelineElement(TimeSpan when, TElement what)
        {
            When = when;
            What = what;
        }

        /// <summary>
        /// Element to be played
        /// </summary>
		public TElement What { get; private set; }

        /// <summary>
        /// Time of playing element
        /// </summary>
		public TimeSpan When { get; private set; }
    }
}