using Manufaktura.Controls.Model;
using System.Collections.Generic;

namespace Manufaktura.Controls.Formatting
{
	internal interface IRebeamStrategy
	{
		RebeamMode Mode { get; }

		IEnumerable<NoteOrRest> Rebeam(IEnumerable<NoteOrRest> notes);
	}
}