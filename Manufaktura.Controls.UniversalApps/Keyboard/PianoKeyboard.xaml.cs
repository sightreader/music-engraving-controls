/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Manufaktura.Control.UniversalApps.Keyboard;
using Manufaktura.Controls.UniversalApps.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Manufaktura.Controls.UniversalApps.Keyboard
{
    public sealed partial class PianoKeyboard : UserControl
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

        public event EventHandler<PianoKeyPressedEventArgs> PianoKeyPressed;

        public int StartingMidiPitch
        {
            get { return (int)GetValue(StartingMidiPitchProperty); }
            set { SetValue(StartingMidiPitchProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StartingMidiPitch.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StartingMidiPitchProperty =
            DependencyProperty.Register("StartingMidiPitch", typeof(int), typeof(PianoKeyboard), new PropertyMetadata(57, StartingMidiPitchChanged));


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

        public double KeyHeight
        {
            get { return (double)GetValue(KeyHeightProperty); }
            set { SetValue(KeyHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for KeyHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty KeyHeightProperty =
            DependencyProperty.Register("KeyHeight", typeof(double), typeof(PianoKeyboard), new PropertyMetadata(100d, KeyHeightChanged));

        private static void KeyHeightChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            if (args.NewValue == args.OldValue) return;
            ((PianoKeyboard)obj).DrawKeys();
        }

        public Style LargeKeyStyle
        {
            get { return (Style)GetValue(LargeKeyStyleProperty); }
            set { SetValue(LargeKeyStyleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LargeKeyStyle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LargeKeyStyleProperty =
            DependencyProperty.Register("LargeKeyStyle", typeof(Style), typeof(PianoKeyboard), new PropertyMetadata(null, LargeKeyStyleChanged));

        private static void LargeKeyStyleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            if (args.NewValue == args.OldValue) return;
            ((PianoKeyboard)obj).DrawKeys();
        }

        public Style SmallKeyStyle
        {
            get { return (Style)GetValue(SmallKeyStyleProperty); }
            set { SetValue(SmallKeyStyleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SmallKeyStyle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SmallKeyStyleProperty =
            DependencyProperty.Register("SmallKeyStyle", typeof(Style), typeof(PianoKeyboard), new PropertyMetadata(null, SmallKeyStyleChanged));

        private static void SmallKeyStyleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            if (args.NewValue == args.OldValue) return;
            ((PianoKeyboard)obj).DrawKeys();
        }

        public Command<PianoKey> PianoKeyPressedCommand
        {
            get { return (Command<PianoKey>)GetValue(PianoKeyPressedCommandProperty); }
            set { SetValue(PianoKeyPressedCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PianoKeyPressedCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PianoKeyPressedCommandProperty =
            DependencyProperty.Register("PianoKeyPressedCommand", typeof(Command<PianoKey>), typeof(PianoKeyboard), new PropertyMetadata(null));

        private void DrawKeys()
        {
            LayoutRoot.Children.Clear();
            double cursorX = 0;
            for (int pitch = StartingMidiPitch; pitch < StartingMidiPitch + NumberOfKeys; pitch++)
            {
                PianoKeyType keyType = KeyTypes[pitch % 12];

                double keyHeight = KeyHeight;
                int zIndex = 0;
                if (keyType == PianoKeyType.Small)
                {
                    keyHeight = KeyHeight * 0.6d;
                    zIndex = 10;
                }

                PianoKey button = new PianoKey();
                button.MidiPitch = pitch;
                button.Width = keyType == PianoKeyType.Large ? KeyWidth : KeyWidth / 2;
                button.Height = keyHeight;
                button.Style = keyType == PianoKeyType.Large ? LargeKeyStyle : SmallKeyStyle;
                button.Click += button_Click;

                Canvas.SetLeft(button, pitch > StartingMidiPitch && keyType == PianoKeyType.Small ? cursorX - KeyWidth / 4 : cursorX);
                Canvas.SetZIndex(button, zIndex);
                LayoutRoot.Children.Add(button);

                if (keyType == PianoKeyType.Large) cursorX += KeyWidth;
            }
        }

        void button_Click(object sender, RoutedEventArgs e)
        {
            PianoKey key = sender as PianoKey;
            OnPianoKeyPressed(key);
            if (PianoKeyPressedCommand == null) return;
            if (!PianoKeyPressedCommand.CanExecuteCommand(key)) return;
            PianoKeyPressedCommand.ExecuteCommand(key);
        }

        private void OnPianoKeyPressed(PianoKey key)
        {
            if (PianoKeyPressed != null) PianoKeyPressed(this, new PianoKeyPressedEventArgs(key));
        }

        public PianoKeyboard()
        {
            InitializeComponent();
            DrawKeys();
        }

        public class PianoKeyPressedEventArgs : EventArgs
        {
            public PianoKeyPressedEventArgs(PianoKey key)
            {
                Key = key;
            }

            public PianoKey Key { get; private set; }
        }
    }
}
