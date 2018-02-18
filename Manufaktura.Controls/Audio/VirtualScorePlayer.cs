using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System;
using System.Linq;

namespace Manufaktura.Controls.Audio
{
	/// <summary>
	/// Score player used only for generating timeline as an array which can be used for various purposes.
    /// Currently it's only used by HtmlScoreRenderer to generate HTML attributes that guide playback performed by JS-based client-side MIDI player.
    /// VirtualScorePlayer can't perform playback by itself so Play, Pause and Stop methods throw an exception.
	/// </summary>
	public class VirtualScorePlayer : ScorePlayer
	{
        /// <summary>
        /// Initializes a new instance of VirtualScorePlayer for specific playback tempo
        /// </summary>
        /// <param name="score"></param>
        /// <param name="tempo"></param>
		public VirtualScorePlayer(Score score, Tempo tempo) : base(score)
		{
			Tempo = tempo;
		}

        /// <summary>
        /// Creates a timeline array
        /// </summary>
        /// <returns></returns>
		public TimelineElement<IHasDuration>[] CreateTimeline()
		{
			return EnumerateTimeline().ToArray();
		}

        /// <summary>
        /// This method is not relevant for this type of player. It always throws NotImplementedException.
        /// </summary>
		public override void Pause()
		{
			throw new NotImplementedException();
		}

        /// <summary>
        /// This method is not relevant for this type of player. It always throws NotImplementedException.
        /// </summary>
        public override void Play()
		{
			throw new NotImplementedException();
		}

        /// <summary>
        /// This method is not relevant for this type of player. It always throws NotImplementedException.
        /// </summary>
        public override void PlayElement(MusicalSymbol element)
		{
			throw new NotImplementedException();
		}

        /// <summary>
        /// This method is not relevant for this type of player. It always throws NotImplementedException.
        /// </summary>
        public override void Stop()
		{
			throw new NotImplementedException();
		}
	}
}