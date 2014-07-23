using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
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

namespace Manufaktura.Controls.WindowsPhoneSilverlight
{
    public partial class NoteViewer : UserControl
    {
        public string XmlSource
        {
            get { return (string)GetValue(XmlSourceProperty); }
            set { SetValue(XmlSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for XmlSourceProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XmlSourceProperty =
            DependencyProperty.Register("XmlSource", typeof(string), typeof(NoteViewer), new PropertyMetadata(null, XmlSourceChanged));

        private static void XmlSourceChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            NoteViewer viewer = obj as NoteViewer;
            string xmlSource = args.NewValue as string;
            MusicXmlParser parser = new MusicXmlParser();
            viewer.ScoreSource = parser.Parse(xmlSource); //TODO: Nie ustawiać ScoreSource, bo wywalamy binding!!!
        }

        public Score ScoreSource
        {
            get { return (Score)GetValue(ScoreSourceProperty); }
            set { SetValue(ScoreSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ScoreSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ScoreSourceProperty =
            DependencyProperty.Register("ScoreSource", typeof(Score), typeof(NoteViewer), new PropertyMetadata(null, ScoreSourceChanged));

        private static void ScoreSourceChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            NoteViewer viewer = obj as NoteViewer;
            Score scoreSource = args.NewValue as Score;
            viewer.RenderOnCanvas();
        }

        public NoteViewer()
        {
            InitializeComponent();
        }

        private void RenderOnCanvas()
        {
            if (ScoreSource == null) return;
            Canvas canvas = new Canvas();
            canvas.Background = new SolidColorBrush(Colors.White);
            Content = canvas;
            var renderer = new CanvasScoreRenderer(canvas);
            renderer.State.PageWidth = 1200;
            renderer.Render(ScoreSource);
        }

    }
}
