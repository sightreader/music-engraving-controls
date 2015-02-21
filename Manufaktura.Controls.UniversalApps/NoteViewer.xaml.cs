using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Manufaktura.Controls.UniversalApps
{
    public sealed partial class NoteViewer : UserControl
    {
        private DraggingState _draggingState = new DraggingState();
        private Score _innerScore;

        protected CanvasScoreRenderer Renderer { get; set; }

        public Score InnerScore { get { return _innerScore; } }


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

            XDocument xmlDocument = XDocument.Parse(xmlSource);
            //Apply transformations:
            if (viewer.XmlTransformations != null)
            {
                foreach (var transformation in viewer.XmlTransformations) xmlDocument = transformation.Parse(xmlDocument);
            }

            MusicXmlParser parser = new MusicXmlParser();
            viewer.RenderOnCanvas(parser.Parse(xmlDocument));
        }

        public IEnumerable<XTransformerParser> XmlTransformations
        {
            get { return (IEnumerable<XTransformerParser>)GetValue(XmlTransformationsProperty); }
            set { SetValue(XmlTransformationsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for XmlTransformations.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XmlTransformationsProperty =
            DependencyProperty.Register("XmlTransformations", typeof(IEnumerable<XTransformerParser>), typeof(NoteViewer), new PropertyMetadata(null));



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


        public bool IsPanoramaMode
        {
            get { return (bool)GetValue(IsPanoramaModeProperty); }
            set { SetValue(IsPanoramaModeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsPanoramaMode.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsPanoramaModeProperty =
            DependencyProperty.Register("IsPanoramaMode", typeof(bool), typeof(NoteViewer), new PropertyMetadata(true));


        /// <summary>
        /// If this property is set to True, the control will calculate it's size to be properly arranged in containers such as ScrollViewer.
        /// If it is set to False, the control will overlap other controls. Default: True.
        /// </summary>
        public bool IsOccupyingSpace
        {
            get { return (bool)GetValue(IsOccupyingSpaceProperty); }
            set { SetValue(IsOccupyingSpaceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsOccupyingSpace.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOccupyingSpaceProperty =
            DependencyProperty.Register("IsOccupyingSpace", typeof(bool), typeof(NoteViewer), new PropertyMetadata(true));

        protected MusicalSymbol SelectedElementInner { get; set; }

        public MusicalSymbol SelectedElement
        {
            get { return SelectedElementInner; }
            set { SetValue(SelectedElementProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedElement.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedElementProperty =
            DependencyProperty.Register("SelectedElement", typeof(MusicalSymbol), typeof(NoteViewer), new PropertyMetadata(null, SelectedElementChanged));

        private static void SelectedElementChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            NoteViewer viewer = (NoteViewer)obj;
            viewer.Select(args.NewValue as MusicalSymbol);
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
            var score = args.NewValue as Score;
            viewer.RenderOnCanvas(score);
        }


        public bool IsSelectable
        {
            get { return (bool)GetValue(IsSelectableProperty); }
            set { SetValue(IsSelectableProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsSelectable.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsSelectableProperty =
            DependencyProperty.Register("IsSelectable", typeof(bool), typeof(NoteViewer), new PropertyMetadata(true));



        public double ZoomFactor
        {
            get { return (double)GetValue(ZoomFactorProperty); }
            set { SetValue(ZoomFactorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ZoomFactor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ZoomFactorProperty =
            DependencyProperty.Register("ZoomFactor", typeof(double), typeof(NoteViewer), new PropertyMetadata(1d, ZoomFactorChanged));


        private static void ZoomFactorChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            ((NoteViewer)obj).InvalidateMeasure();
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
            Renderer.Settings.IsPanoramaMode = IsPanoramaMode;
            var brush = Foreground as SolidColorBrush;
            if (brush != null) Renderer.Settings.DefaultColor = Renderer.ConvertColor(brush.Color);
            if (score.Staves.Count > 0) Renderer.Settings.PageWidth = score.Staves[0].Elements.Count * 26;
            Renderer.Render(score);
            if (SelectedElementInner != null) ColorElement(SelectedElementInner, Colors.Magenta);
            InvalidateMeasure();
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            if (Renderer == null || !IsOccupyingSpace) return base.MeasureOverride(availableSize);
            double width = availableSize.Width;
            if (Renderer.State.CurrentStaff != null)
            {
                double maxWidth = Renderer.State.CurrentStaff.ActualSystemWidths.Max();
                if (maxWidth > 0) width = maxWidth;
            }
            return new Size(width * ZoomFactor, (Renderer.State.CurrentSystemShiftY + 100) * ZoomFactor);
        }

        private void ColorElement(MusicalSymbol element, Color color)
        {
            if (Renderer == null) return;   //If SelectedElement value has been changed by binding and renderer has not yet been created, just ignore this method.
            var ownerships = Renderer.OwnershipDictionary.Where(o => o.Value == SelectedElementInner);
            foreach (var ownership in ownerships)
            {
                TextBlock textBlock = ownership.Key as TextBlock;
                if (textBlock != null) textBlock.Foreground = new SolidColorBrush(color);

                Shape shape = ownership.Key as Shape;
                if (shape != null) shape.Stroke = new SolidColorBrush(color);
            }
        }

        public void Select(MusicalSymbol element)
        {
            if (SelectedElementInner != null) ColorElement(SelectedElementInner, Colors.Black);   //Reset color on previously selected element
            SelectedElementInner = element;

            Note note = SelectedElementInner as Note;
            if (note != null) _draggingState.MidiPitchOnStartDragging = note.MidiPitch;

            if (SelectedElementInner != null) ColorElement(SelectedElementInner, Colors.Magenta);      //Apply color on selected element

            var positionElement = element as IHasCustomXPosition;
            if (positionElement != null) Debug.WriteLine("Default-x for selected element: {0}",
                positionElement.DefaultXPosition.HasValue ? positionElement.DefaultXPosition.Value.ToString() : "(not set)");
        }



        private void MainCanvas_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (!IsSelectable) return;
            MainCanvas.CapturePointer(e.Pointer);  //Capture mouse to receive events even if the pointer is outside the control

            //Start dragging:
            _draggingState.StartDragging(e.GetCurrentPoint(MainCanvas).Position);

            //Check if element under cursor is staff element:
            FrameworkElement element = e.OriginalSource as FrameworkElement;
            if (element == null) return;
            if (!Renderer.OwnershipDictionary.ContainsKey(element)) return;

            //Set selected element:
            Select(Renderer.OwnershipDictionary[element]);
        }

        private void MainCanvas_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if (!IsSelectable) return;
            MainCanvas.ReleasePointerCapture(e.Pointer);
            _draggingState.StopDragging();
        }

        private void MainCanvas_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (!IsSelectable) return;
            if (!_draggingState.IsDragging || _innerScore == null) return;

            Point currentPosition = e.GetCurrentPoint(MainCanvas).Position;
            double horizontalDifference = Math.Abs(_draggingState.MousePositionOnStartDragging.X - currentPosition.X);
            if (horizontalDifference > 30)
            {
                _draggingState.StopDragging();
                return;
            }
            double difference = _draggingState.MousePositionOnStartDragging.Y - currentPosition.Y;

            Note note = SelectedElementInner as Note;
            if (note != null)
            {
                int midiPitch = _draggingState.MidiPitchOnStartDragging + (int)(difference / 2);
                Debug.WriteLine(string.Format("Difference: {0}   MidiPitch: {1}", difference, midiPitch));
                note.ApplyMidiPitch(midiPitch);     //TODO: Wstawianie kasownika, jeśli jest znak przykluczowy, a obniżyliśmy o pół tonu
                //TODO: Ustalanie kierunku ogonka. Sprawdzić czy gdzieś to nie jest już zrobione, np. w PSAMie
            }
            RenderOnCanvas(_innerScore);        //TODO: Przerysowywać tylko wszystkie na prawo od zmienianej nutki. Albo w ogóle tylko tą nutkę, a na MouseLeftButtonUp przerysowywać całość
            //Może najłatwiej to zrobić tak, że Draw... jak zobaczy że ma już taką samą figurę, to ma nie rysować
        }


        struct DraggingState
        {
            public bool IsDragging { get; private set; }
            public Point MousePositionOnStartDragging { get; private set; }
            public int MidiPitchOnStartDragging { get; set; }

            public void StopDragging()
            {
                IsDragging = false;
                MousePositionOnStartDragging = default(Point);
                MidiPitchOnStartDragging = 0;
            }

            public void StartDragging(Point startingPosition)
            {
                IsDragging = true;
                MousePositionOnStartDragging = startingPosition;
            }
        }


    }
}
