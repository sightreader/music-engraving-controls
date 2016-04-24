using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Formatting
{
	public class LyricsRebeamStrategy : IRebeamStrategy
	{
		public RebeamMode Mode => RebeamMode.ToLyrics;

		public IEnumerable<NoteOrRest> Rebeam(IEnumerable<NoteOrRest> notes)
		{
			throw new NotImplementedException();
		}
	}
}