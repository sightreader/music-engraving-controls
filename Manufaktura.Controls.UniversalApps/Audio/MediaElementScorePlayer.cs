using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.PeekStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Manufaktura.Controls.UniversalApps.Audio
{
    public class MediaElementScorePlayer : ThreadScorePlayer
    {
        public event EventHandler<MusicalSymbolEventArgs> ElementPlayed;
        private Dictionary<int, string> _stepNames;
        private static Dictionary<string, MediaElement> _soundEffectsCache;

        public CoreDispatcher Dispatcher { get; set; }

        private MusicalSymbol _threadSafeCurrentElement;
        public override MusicalSymbol ThreadSafeCurrentElement
        {
            get
            {
                return _threadSafeCurrentElement;
            }
            set
            {
                _threadSafeCurrentElement = value;
                if (Dispatcher != null && !Dispatcher.HasThreadAccess)
                {
                    Dispatcher.RunAsync(CoreDispatcherPriority.Normal, new DispatchedHandler(() => OnPropertyChanged(() => ThreadSafeCurrentElement)));
                }
                else OnPropertyChanged(() => ThreadSafeCurrentElement);

            }
        }

        public MediaElementScorePlayer(Score score) : base(score)
        {
            _stepNames = new Dictionary<int, string> { { 68, "gg" }, { 69, "a" }, { 70, "bb" }, { 71, "b" }, { 72, "c" }, { 73, "cc" }, { 74, "d" }, 
                                                                              { 75, "eb" }, { 76, "e" }, { 77, "f" }, { 78, "ff" }, { 79, "g" } };
            for (int i = 80; i < 93; i++)
            {
                _stepNames.Add(i, _stepNames[i - 12]);
            }
            for (int i = 56; i < 68; i++)
            {
                _stepNames.Add(i, _stepNames[i + 12]);
            }
            _soundEffectsCache = new Dictionary<string, MediaElement>();
        }

        public override void PlayElement(MusicalSymbol element, Staff staff)
        {
            if (!(element is NoteOrRest)) return;
            OnElementPlayed(element);
            if (element is Rest) return;

            Note note = element as Note;
            if (note == null) return;
            if (note.MidiPitch > 92 || note.MidiPitch < 56) return;


            int octaveModifier = 0; //TODO: Obsłużyć dźwięki w innych oktawach
            if (note.MidiPitch > 79) octaveModifier = 1;
            if (note.MidiPitch < 68) octaveModifier = -1;

            MediaElement mediaElement;
            string soundUri = string.Format("Manufaktura.Controls.UniversalApps;component/piano-{0}.wav", _stepNames[note.MidiPitch]);
            lock (_soundEffectsCache)
            {
                if (_soundEffectsCache.ContainsKey(soundUri)) mediaElement = _soundEffectsCache[soundUri];
                else
                {
                    mediaElement = new MediaElement
                    {
                        Source = new Uri(soundUri),
                        AudioCategory = AudioCategory.BackgroundCapableMedia
                    };
                    _soundEffectsCache.Add(soundUri, mediaElement);
                }
            }

            var firstNoteInMeasure = staff.Peek<Note>(element, PeekType.BeginningOfMeasure);
            mediaElement.Volume = element == firstNoteInMeasure ? 0.4f : 0.3f;
            mediaElement.Play();
        }

        protected void OnElementPlayed(MusicalSymbol symbol)
        {
            if (ElementPlayed != null) ElementPlayed(this, new MusicalSymbolEventArgs(symbol));
        }

        public class MusicalSymbolEventArgs : EventArgs
        {
            public MusicalSymbol Element { get; set; }

            public MusicalSymbolEventArgs(MusicalSymbol element)
            {
                Element = element;
            }
        }

    }
}
