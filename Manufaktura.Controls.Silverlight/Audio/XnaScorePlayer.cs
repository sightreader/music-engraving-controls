using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.PeekStrategies;
using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Manufaktura.Controls.Silverlight
{
    public class XnaScorePlayer : ThreadScorePlayer
    {
        public event EventHandler<MusicalSymbolEventArgs> ElementPlayed;
        private Dictionary<int, string> _stepNames;
        private static Dictionary<string, SoundEffect> _soundEffectsCache;
        /// <summary>
        /// Optional Dispatcher object to prevent invalid cross-thread operations. If the player is databound to FrameworkElement,
        /// set Dispatcher property to FrameworkElement's dispatcher.
        /// </summary>
        public Dispatcher Dispatcher { get; set; }

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
                if (Dispatcher != null && !Dispatcher.CheckAccess()) Dispatcher.BeginInvoke(new Action(() => OnPropertyChanged(() => ThreadSafeCurrentElement)));
                else OnPropertyChanged(() => ThreadSafeCurrentElement);
                
            }
        }

        public XnaScorePlayer(Score score) : base(score)
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
            _soundEffectsCache = new Dictionary<string, SoundEffect>();
        }

        public XnaScorePlayer(Score score, Dispatcher dispatcher) : this(score)
        {
            Dispatcher = dispatcher;
        }

        public override void Start()
        {
            if (Dispatcher != null && !Dispatcher.CheckAccess())
            {
                Dispatcher.BeginInvoke(Start);
                return;
            }
            base.Start();
        }

        public override void Stop()
        {
            if (Dispatcher != null && !Dispatcher.CheckAccess())
            {
                Dispatcher.BeginInvoke(Stop);
                return;
            }
            base.Stop();
        }

        public override void Pause()
        {
            if (Dispatcher != null && !Dispatcher.CheckAccess())
            {
                Dispatcher.BeginInvoke(Pause);
                return;
            }
            base.Pause();
        }

        public override void PlayElement(MusicalSymbol element, Staff staff)
        {
            if (!(element is NoteOrRest)) return;
            OnElementPlayed(element);
            if (element is Rest) return;

            Note note = element as Note;
            if (note == null) return;
            if (note.MidiPitch > 92 || note.MidiPitch < 56) return;

            
            int octaveModifier = 0;
            if (note.MidiPitch > 79) octaveModifier = 1;
            if (note.MidiPitch < 68) octaveModifier = -1;
            
            SoundEffect effect;
            string soundUri = string.Format("Manufaktura.Controls.Silverlight;component/piano-{0}.wav", _stepNames[note.MidiPitch]);
            lock (_soundEffectsCache)
            {
                if (_soundEffectsCache.ContainsKey(soundUri)) effect = _soundEffectsCache[soundUri];
                else
                {
                    var resourceStream = Application.GetResourceStream(new Uri(soundUri, UriKind.RelativeOrAbsolute));
                    effect = SoundEffect.FromStream(resourceStream.Stream);
                    _soundEffectsCache.Add(soundUri, effect);
                }
            }
            
            var firstNoteInMeasure = staff.Peek<Note>(element, PeekType.BeginningOfMeasure);
            effect.Play(element == firstNoteInMeasure ? 0.4f : 0.3f, octaveModifier, 0);
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
