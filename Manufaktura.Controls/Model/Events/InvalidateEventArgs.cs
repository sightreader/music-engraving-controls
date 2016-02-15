using System;

namespace Manufaktura.Controls.Model.Events
{
	public class InvalidateEventArgs<TObject> : EventArgs
	{
		public InvalidateEventArgs(TObject invalidatedObject)
		{
			InvalidatedObject = invalidatedObject;
		}

		public TObject InvalidatedObject { get; private set; }
	}
}