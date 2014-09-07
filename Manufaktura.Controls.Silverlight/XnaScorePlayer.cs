using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Microsoft.Xna.Framework.Audio;
using System;
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

namespace Manufaktura.Controls.Silverlight
{
    public class XnaScorePlayer : ThreadScorePlayer
    {
        public XnaScorePlayer(Score score) : base(score)
        {

        }

        public override void PlayElement(MusicalSymbol element)
        {
            if (element is Rest) return;
            Note note = element as Note;
            if (note == null) return;

            float pitch = (float)(note.MidiPitch - 69) / 12f;
            if (pitch < -1 || pitch > 1) return;

            var resourceStream = Application.GetResourceStream(new Uri("Manufaktura.Controls.Silverlight;component/piano_a.wav", UriKind.RelativeOrAbsolute));
            var effect = SoundEffect.FromStream(resourceStream.Stream);

            effect.Play(1, pitch, 0);
        }
    }
}
