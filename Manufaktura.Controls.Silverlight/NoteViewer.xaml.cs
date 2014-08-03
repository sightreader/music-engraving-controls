using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Manufaktura.Controls.Silverlight
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
            viewer.RenderOnCanvas(parser.Parse(xmlSource));
        }

        public bool IsDebugMode
        {
            get { return (bool)GetValue(IsDebugModeProperty); }
            set { SetValue(IsDebugModeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsDebugMode.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsDebugModeProperty =
            DependencyProperty.Register("IsDebugMode", typeof(bool), typeof(NoteViewer), new PropertyMetadata(false));

        

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
            var score = args.NewValue as Score;
            viewer.RenderOnCanvas(score);
        }

        public NoteViewer()
        {
            InitializeComponent();
        }

        private void RenderOnCanvas(Score score)
        {
            if (score == null) return;
            Canvas canvas = new Canvas();
            Content = canvas;
            var renderer = new CanvasScoreRenderer(canvas);
            if (score.Staves.Count > 0) renderer.State.PageWidth = score.Staves[0].Elements.Count * 26;
            renderer.Render(score);

            if (IsDebugMode)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Kontrolki na kanwasie:");
                sb.AppendLine();
                foreach (var element in canvas.Children)
                {
                    sb.AppendLine(string.Format("{0} X:{1} Y{2}", element.ToString(), Canvas.GetLeft(element), Canvas.GetTop(element)));
                }
                MessageBox.Show(sb.ToString());

                sb.Clear();
                foreach (Exception ex in renderer.Exceptions)
                {
                    sb.AppendLine(ex.ToString());
                }
                if (renderer.Exceptions.Count > 0) MessageBox.Show(sb.ToString());
            }
        }

    }
}
