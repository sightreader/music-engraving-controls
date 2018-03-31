using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    public class PlaybackSuggestion : DurationElement
    {
        private bool isBackward;
        public bool IsBackward { get { return isBackward; } set { isBackward = value; OnPropertyChanged(); } }

        public int MusicXmlDuration { get; set; }

        public double DurationMultiplicator { get; set; }

        public void CalculateDurationFromMusicXmlDuration(int quarterNoteDuration)
        {
            DurationMultiplicator = MusicXmlDuration / quarterNoteDuration;
            Duration = RhythmicDuration.Quarter;
        }
    }
}