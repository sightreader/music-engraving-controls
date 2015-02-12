using System;
using System.Net;
using System.Windows;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Manufaktura.Control.UniversalApps.Keyboard
{
    public class PianoKey : Button
    {
        public int MidiPitch
        {
            get { return (int)GetValue(MidiPitchProperty); }
            set { SetValue(MidiPitchProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MidiPitch.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MidiPitchProperty =
            DependencyProperty.Register("MidiPitch", typeof(int), typeof(PianoKey), new PropertyMetadata(69));

        
    }
}
