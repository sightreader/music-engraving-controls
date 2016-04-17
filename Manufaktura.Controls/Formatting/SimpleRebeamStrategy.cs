using Manufaktura.Controls.Model;
using System.Collections.Generic;

namespace Manufaktura.Controls.Formatting
{
	public class SimpleRebeamStrategy : IRebeamStrategy
	{
		public RebeamMode Mode => RebeamMode.Simple;

		public IEnumerable<NoteOrRest> Rebeam(IEnumerable<NoteOrRest> notes)
		{
			return null;
		}
	}
}