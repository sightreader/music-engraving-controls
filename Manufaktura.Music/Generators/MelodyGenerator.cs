using Manufaktura.Music.Model;
using System.Collections.Generic;

namespace Manufaktura.Music.Generators
{
	public class MelodyGenerator
	{
		public Scale Scale { get; set; }

		public IEnumerable<Pitch> Generate()
		{
			foreach (var interval in Scale.Mode.Intervals)
			{
			}

			return null;
		}
	}
}