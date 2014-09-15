using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Manufaktura.Controls.Silverlight.Keyboard
{
    public partial class PianoKeyboard : UserControl
    {
        private static Dictionary<int, PianoKeyType> _keyTypes;
        public static Dictionary<int, PianoKeyType> KeyTypes
        {
            get
            {
                if (_keyTypes == null)
                {
                    _keyTypes = new Dictionary<int, PianoKeyType>() 
                        {
                            { 0, PianoKeyType.Large },
                            { 1, PianoKeyType.Small },
                            { 2, PianoKeyType.Large },
                            { 3, PianoKeyType.Small },
                            { 4, PianoKeyType.Large },
                            { 5, PianoKeyType.Large },
                            { 6, PianoKeyType.Small },
                            { 7, PianoKeyType.Large },
                            { 8, PianoKeyType.Small },
                            { 9, PianoKeyType.Large },
                            { 10, PianoKeyType.Small },
                            { 11, PianoKeyType.Large }
                        };
                }
                return _keyTypes;
            }
        }

        public int StartingMidiPitch
        {
            get { return (int)GetValue(StartingMidiPitchProperty); }
            set { SetValue(StartingMidiPitchProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StartingMidiPitch.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StartingMidiPitchProperty =
            DependencyProperty.Register("StartingMidiPitch", typeof(int), typeof(PianoKeyboard), new PropertyMetadata(69, StartingMidiPitchChanged));


        private static void StartingMidiPitchChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args) 
        {
            if (args.NewValue == args.OldValue) return;
            ((PianoKeyboard)obj).DrawKeys();
        }
        
        public int NumberOfKeys
        {
            get { return (int)GetValue(NumberOfKeysProperty); }
            set { SetValue(NumberOfKeysProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NumberOfKeys.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NumberOfKeysProperty =
            DependencyProperty.Register("NumberOfKeys", typeof(int), typeof(PianoKeyboard), new PropertyMetadata(23, NumberOfKeysChanged));

        private static void NumberOfKeysChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args) 
        {
            if (args.NewValue == args.OldValue) return;
            ((PianoKeyboard)obj).DrawKeys();
        }

        public double KeyWidth
        {
            get { return (double)GetValue(KeyWidthProperty); }
            set { SetValue(KeyWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for KeyWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty KeyWidthProperty =
            DependencyProperty.Register("KeyWidth", typeof(double), typeof(PianoKeyboard), new PropertyMetadata(40d, KeyWidthChanged));

        private static void KeyWidthChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            if (args.NewValue == args.OldValue) return;
            ((PianoKeyboard)obj).DrawKeys();
        }
        

        private void DrawKeys()
        {
            double cursorX = 0;
            for (int pitch = StartingMidiPitch; pitch < StartingMidiPitch + NumberOfKeys; pitch++)
            {
                PianoKeyType keyType = KeyTypes[pitch % 12];

                double keyHeight = 100;
                int zIndex = 0;
                if (keyType == PianoKeyType.Small) 
                {
                    keyHeight = 60;
                    zIndex = 10;
                }

                Button button = new Button();
                button.Width = keyType == PianoKeyType.Large ? KeyWidth : KeyWidth / 2;
                button.Height = keyHeight;

                Canvas.SetLeft(button, pitch > StartingMidiPitch && keyType == PianoKeyType.Small ? cursorX - KeyWidth / 4 : cursorX);
                Canvas.SetZIndex(button, zIndex);
                LayoutRoot.Children.Add(button);

                if (keyType == PianoKeyType.Large) cursorX += KeyWidth;
            }
        }


        public PianoKeyboard()
        {
            InitializeComponent();
            DrawKeys();
        }
    }
}
