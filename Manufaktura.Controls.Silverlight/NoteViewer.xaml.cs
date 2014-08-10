using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private bool _isDragging = false;
        private Point _mousePositionOnStartDragging;
        private Score _innerScore;

        protected CanvasScoreRenderer Renderer { get; set; }

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



        public bool IsInsertMode
        {
            get { return (bool)GetValue(IsInsertModeProperty); }
            set { SetValue(IsInsertModeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsInsertMode.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsInsertModeProperty =
            DependencyProperty.Register("IsInsertMode", typeof(bool), typeof(NoteViewer), new PropertyMetadata(false));



        public MusicalSymbol SelectedElement
        {
            get { return (MusicalSymbol)GetValue(SelectedElementProperty); }
            set { SetValue(SelectedElementProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedElement.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedElementProperty =
            DependencyProperty.Register("SelectedElement", typeof(MusicalSymbol), typeof(NoteViewer), new PropertyMetadata(null));

        

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
            _innerScore = score;
            if (score == null) return;

            MainCanvas.Children.Clear();
            Renderer = new CanvasScoreRenderer(MainCanvas);
            if (score.Staves.Count > 0) Renderer.State.PageWidth = score.Staves[0].Elements.Count * 26;
            Renderer.Render(score);
            if (SelectedElement != null) ColorElement(SelectedElement, Colors.Magenta);

            if (IsDebugMode)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Controls on canvas:");
                sb.AppendLine();
                foreach (var element in MainCanvas.Children)
                {
                    sb.AppendLine(string.Format("{0} X:{1} Y{2}", element.ToString(), Canvas.GetLeft(element), Canvas.GetTop(element)));
                }
                MessageBox.Show(sb.ToString());

                sb.Clear();
                foreach (Exception ex in Renderer.Exceptions)
                {
                    sb.AppendLine(ex.ToString());
                }
                if (Renderer.Exceptions.Count > 0) MessageBox.Show(sb.ToString());
            }
        }



        private void ColorElement(MusicalSymbol element, Color color)
        {
            var ownerships = Renderer.OwnershipDictionary.Where(o => o.Value == SelectedElement);
            foreach (var ownership in ownerships)
            {
                TextBlock textBlock = ownership.Key as TextBlock;
                if (textBlock != null) textBlock.Foreground = new SolidColorBrush(color);

                Shape shape = ownership.Key as Shape;
                if (shape != null) shape.Stroke = new SolidColorBrush(color);
            } 
        }

        private void MainCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _isDragging = false;
            _mousePositionOnStartDragging = default(Point);
        }

        void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _isDragging = true;
            _mousePositionOnStartDragging = e.GetPosition(MainCanvas);

            FrameworkElement element = e.OriginalSource as FrameworkElement;
            if (element == null) return;
            if (!Renderer.OwnershipDictionary.ContainsKey(element)) return;

            if (SelectedElement != null) ColorElement(SelectedElement, Colors.Black);   //Reset color on previously selected element
            SelectedElement = Renderer.OwnershipDictionary[element];
            ColorElement(SelectedElement, Colors.Magenta);      //Apply color on selected element
        }

        private void MainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDragging || _innerScore == null)
            {
                _mousePositionOnStartDragging = default(Point);
                return;
            }

            Point currentPosition = e.GetPosition(MainCanvas);
            double difference = _mousePositionOnStartDragging.Y - currentPosition.Y;

            Note note = SelectedElement as Note;
            if (note != null)
            {
                int midiPitch = note.MidiPitch + (int)(difference / 3);
                Debug.WriteLine(string.Format("Difference: {0}   MidiPitch: {1}", difference, midiPitch));
                note.ApplyMidiPitch(midiPitch);
                //TODO: Ustalanie kierunku ogonka. Sprawdzić czy gdzieś to nie jest już zrobione, np. w PSAMie
            }
            RenderOnCanvas(_innerScore);
        }

    }
}
