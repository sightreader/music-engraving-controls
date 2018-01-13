using Manufaktura.Controls.Model;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Audio
{
    /// <summary>
    /// TaskScorePlayer that automatically selects MIDI channels
    /// </summary>
    public abstract class ChannelSelectingTaskScorePlayer : TaskScorePlayer
    {
        protected Dictionary<int, List<int>> pitchesPlaying;

        public ChannelSelectingTaskScorePlayer(Score score) : base(score)
        {
            pitchesPlaying = Enumerable.Range(0, ChannelsCount).ToDictionary(i => i, i => new List<int>());
        }

        private int ChannelsCount => Score.Staves.Count < 5 ? Score.Staves.Count * 2 : Score.Staves.Count * 2 + 2;
        protected int GetChannelNumber(int staffIndex)
        {
            var channelIndex = staffIndex * 2;
            if (channelIndex > 7) channelIndex += 2;
            return channelIndex;
        }
    }
}