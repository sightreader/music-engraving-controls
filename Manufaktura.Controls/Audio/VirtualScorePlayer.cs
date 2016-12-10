using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System;
using System.Linq;

namespace Manufaktura.Controls.Audio
{
	/// <summary>
	/// Score player used only for generating timeline array
	/// </summary>
	public class VirtualScorePlayer : ScorePlayer
	{
		public VirtualScorePlayer(Score score, Tempo tempo) : base(score)
		{
			Tempo = tempo;
		}

		public TimelineElement<IHasDuration>[] CreateTimeline()
		{
			return EnumerateTimeline().ToArray();
		}

		public override void Pause()
		{
			throw new NotImplementedException();
		}

		public override void Play()
		{
			throw new NotImplementedException();
		}

		public override void PlayElement(MusicalSymbol element)
		{
			throw new NotImplementedException();
		}

		public override void Stop()
		{
			throw new NotImplementedException();
		}
	}
}