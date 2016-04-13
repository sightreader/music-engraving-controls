using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
	public class MetronomeDirection : Direction
	{
		public MetronomeDirection(Tempo tempo, DirectionPlacementType placement)
		{
			Tempo = tempo;
			Placement = placement;
		}

		public Tempo Tempo { get; }
	}
}