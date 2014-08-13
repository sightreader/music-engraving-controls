using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Manufaktura.Controls.WPF
{
    /// <summary>
    /// Interaction logic for NoteViewer.xaml
    /// </summary>
    public partial class NoteViewer : UserControl
    {

        public RenderModes RenderMode
        {
            get { return (RenderModes)GetValue(RenderModeProperty); }
            set { SetValue(RenderModeProperty, value); }
        }

        public static readonly DependencyProperty RenderModeProperty =
            DependencyProperty.Register("RenderMode", typeof(RenderModes), typeof(NoteViewer), new PropertyMetadata(RenderModes.DrawingContext, RenderModeChanged));

        private static void RenderModeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            NoteViewer viewer = obj as NoteViewer;
            if ((RenderModes)args.NewValue == RenderModes.DrawingContext)
            {
                viewer.Content = null;
                viewer.InvalidateVisual();
            }
            else if ((RenderModes)args.NewValue == RenderModes.Canvas) viewer.RenderOnCanvas();
        }

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
            viewer.ScoreSource = parser.Parse(xmlSource);   //TODO: Nie ustawiać ScoreSource, bo wywalamy binding!!!
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
            if (viewer.RenderMode == RenderModes.DrawingContext)
            {
                viewer.Content = null;
                viewer.InvalidateVisual();
            }
            else if (viewer.RenderMode == RenderModes.Canvas) viewer.RenderOnCanvas();
        }
        
        public NoteViewer()
        {
            InitializeComponent();
        }

        private void RenderOnCanvas()
        {
            if (ScoreSource == null) return;
            Canvas canvas = new Canvas();
            Content = canvas;
            var renderer = new CanvasScoreRenderer(canvas);
            renderer.Settings.PageWidth = 1200;
            renderer.Render(ScoreSource);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            if (RenderMode == RenderModes.DrawingContext && ScoreSource != null)
            {
                var renderer = new DrawingContextScoreRenderer(drawingContext);
                renderer.Settings.PageWidth = 1200;
                renderer.Render(ScoreSource);
            }
        }

        public enum RenderModes
        {
            DrawingContext, Canvas
        }
    }
}
