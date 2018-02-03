using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Interactivity;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Manufaktura.Controls.XamlForHtml5
{
    public sealed partial class NoteViewer : UserControl
    {
        public static readonly DependencyProperty CurrentPageProperty = DependencyProperty.Register(nameof(CurrentPage), typeof(int), typeof(NoteViewer), new PropertyMetadata(1, CurrentPageChanged));
        public static readonly DependencyProperty InvalidatingModeProperty = DependencyProperty.Register(nameof(InvalidatingMode), typeof(InvalidatingModes), typeof(NoteViewer), new PropertyMetadata(InvalidatingModes.RedrawInvalidatedRegion));
        public static readonly DependencyProperty IsInsertModeProperty = DependencyProperty.Register(nameof(IsInsertMode), typeof(bool), typeof(NoteViewer), new PropertyMetadata(false));
        public static readonly DependencyProperty IsOccupyingSpaceProperty = DependencyProperty.Register(nameof(IsOccupyingSpace), typeof(bool), typeof(NoteViewer), new PropertyMetadata(true));
        public static readonly DependencyProperty IsPanoramaModeProperty = DependencyProperty.Register(nameof(IsPanoramaMode), typeof(bool), typeof(NoteViewer), new PropertyMetadata(true));
        public static readonly DependencyProperty IsSelectableProperty = DependencyProperty.Register(nameof(IsSelectable), typeof(bool), typeof(NoteViewer), new PropertyMetadata(true));
        public static readonly DependencyProperty PlaybackCursorPositionProperty = DependencyProperty.Register(nameof(PlaybackCursorPosition), typeof(PlaybackCursorPosition), typeof(NoteViewer), new PropertyMetadata(default(PlaybackCursorPosition), PlaybackCursorPositionChanged));
        public static readonly DependencyProperty RenderingModeProperty = DependencyProperty.Register(nameof(RenderingMode), typeof(NoteViewer), typeof(ScoreRenderingModes), new PropertyMetadata(ScoreRenderingModes.Panorama, RenderingModeChanged));
        public static readonly DependencyProperty ScoreSourceProperty = DependencyProperty.Register(nameof(ScoreSource), typeof(Score), typeof(NoteViewer), new PropertyMetadata(null, ScoreSourceChanged));
        public static readonly DependencyProperty SelectedElementProperty = DependencyProperty.Register(nameof(SelectedElement), typeof(MusicalSymbol), typeof(NoteViewer), new PropertyMetadata(null));
        public static readonly DependencyProperty XmlSourceProperty = DependencyProperty.Register(nameof(XmlSource), typeof(string), typeof(NoteViewer), new PropertyMetadata(null, XmlSourceChanged));
        public static readonly DependencyProperty XmlTransformationsProperty = DependencyProperty.Register(nameof(XmlTransformations), typeof(IEnumerable<XTransformerParser>), typeof(NoteViewer), new PropertyMetadata(null));
        public static readonly DependencyProperty ZoomFactorProperty = DependencyProperty.Register(nameof(ZoomFactor), typeof(double), typeof(NoteViewer), new PropertyMetadata(1d, ZoomFactorChanged));

        private DraggingState _draggingState = new DraggingState();

        private Score _innerScore;

        private Color previousColor;

        public NoteViewer()
        {
            InitializeComponent();
        }

        public int CurrentPage
        {
            get { return (int)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }

        public Score InnerScore { get { return _innerScore; } }

        public InvalidatingModes InvalidatingMode
        {
            get { return (InvalidatingModes)GetValue(InvalidatingModeProperty); }
            set { SetValue(InvalidatingModeProperty, value); }
        }

        public bool IsInsertMode
        {
            get { return (bool)GetValue(IsInsertModeProperty); }
            set { SetValue(IsInsertModeProperty, value); }
        }

        /// <summary>
        /// If this property is set to True, the control will calculate it's size to be properly arranged in containers such as ScrollViewer.
        /// If it is set to False, the control will overlap other controls. Default: True.
        /// </summary>
        public bool IsOccupyingSpace
        {
            get { return (bool)GetValue(IsOccupyingSpaceProperty); }
            set { SetValue(IsOccupyingSpaceProperty, value); }
        }

        public bool IsPanoramaMode
        {
            get { return (bool)GetValue(IsPanoramaModeProperty); }
            set { SetValue(IsPanoramaModeProperty, value); }
        }

        public bool IsSelectable
        {
            get { return (bool)GetValue(IsSelectableProperty); }
            set { SetValue(IsSelectableProperty, value); }
        }

        public PlaybackCursorPosition PlaybackCursorPosition
        {
            get { return (PlaybackCursorPosition)GetValue(PlaybackCursorPositionProperty); }
            set { SetValue(PlaybackCursorPositionProperty, value); }
        }

        public ScoreRenderingModes RenderingMode
        {
            get { return (ScoreRenderingModes)GetValue(RenderingModeProperty); }
            set { SetValue(RenderingModeProperty, value); }
        }

        public Score ScoreSource
        {
            get { return (Score)GetValue(ScoreSourceProperty); }
            set { SetValue(ScoreSourceProperty, value); }
        }

        public MusicalSymbol SelectedElement
        {
            get { return (MusicalSymbol)GetValue(SelectedElementProperty); }
            set { SetValue(SelectedElementProperty, value); }
        }

        public string XmlSource
        {
            get { return (string)GetValue(XmlSourceProperty); }
            set { SetValue(XmlSourceProperty, value); }
        }

        public IEnumerable<XTransformerParser> XmlTransformations
        {
            get { return (IEnumerable<XTransformerParser>)GetValue(XmlTransformationsProperty); }
            set { SetValue(XmlTransformationsProperty, value); }
        }

        public double ZoomFactor
        {
            get { return (double)GetValue(ZoomFactorProperty); }
            set { SetValue(ZoomFactorProperty, value); }
        }

        private CanvasScoreRenderer Renderer { get; set; }

        public void Select(MusicalSymbol element)
        {
            if (SelectedElement != null) ColorElement(SelectedElement, previousColor);   //Reset color on previously selected element
            SelectedElement = element;

            var note = SelectedElement as Note;
            if (note != null) _draggingState.MidiPitchOnStartDragging = note.MidiPitch;

            if (SelectedElement != null) ColorElement(SelectedElement, Colors.Magenta);      //Apply color on selected element
        }

        /*protected override Size MeasureOverride(Size availableSize)
		{
			if (Renderer == null || !IsOccupyingSpace) return base.MeasureOverride(availableSize);
			var children = MainCanvas.Children.OfType<UIElement>();
			foreach (var child in children) child.Measure(availableSize);

			if (children.Any())
			{
				var xx = children.Max(c => Canvas.GetLeft(c) + c.DesiredSize.Width);
				var yy = children.Max(c => Canvas.GetTop(c) + c.DesiredSize.Height);
				return new Size(xx, yy);
			}
			return base.MeasureOverride(availableSize);
		}*/

        private static void CurrentPageChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
        }

        private static void CurrentPageChanged(NoteViewer control, int oldValue, int newValue)
        {
            control.RenderOnCanvas(control.InnerScore);
        }

        private static void PlaybackCursorPositionChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            NoteViewer control = (NoteViewer)obj;
            PlaybackCursorPosition oldValue = (PlaybackCursorPosition)args.OldValue;
            PlaybackCursorPosition newValue = (PlaybackCursorPosition)args.NewValue;

            if (control.InnerScore == null) return;
            if (control.Renderer == null) return;

            if (!newValue.IsValid) return;

            control.Renderer.DrawPlaybackCursor(newValue);
        }

        private static void RenderingModeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            NoteViewer control = (NoteViewer)obj;
            ScoreRenderingModes oldValue = (ScoreRenderingModes)args.OldValue;
            ScoreRenderingModes newValue = (ScoreRenderingModes)args.NewValue;

            if (control.InnerScore == null) return;
            control.RenderOnCanvas(control.InnerScore);
        }

        private static void ScoreSourceChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            NoteViewer control = (NoteViewer)obj;
            Score oldValue = args.OldValue as Score;
            Score newValue = args.NewValue as Score;

            if (oldValue != null) oldValue.Safety.BoundControl = null;
            Score.SanityCheck(newValue, control);

            control.RenderOnCanvas(newValue);
        }

        private static void XmlSourceChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            NoteViewer contol = (NoteViewer)obj;
            string oldValue = args.OldValue as string;
            string newValue = args.NewValue as string;

            var xmlDocument = XDocument.Parse(newValue);
            //Apply transformations:
            if (contol.XmlTransformations != null)
            {
                //foreach (var transformation in contol.XmlTransformations) xmlDocument = transformation.Parse(xmlDocument);
            }

            MusicXmlParser parser = new MusicXmlParser();
            var score = parser.Parse(xmlDocument);
            contol.RenderOnCanvas(score);
        }

        private static void ZoomFactorChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            //control.InvalidateMeasure();
        }

        private void ColorElement(MusicalSymbol element, Color color)
        {
            if (Renderer == null) return;   //If SelectedElement value has been changed by binding and renderer has not yet been created, just ignore this method.
            var ownerships = Renderer.OwnershipDictionary.Where(o => o.Value == SelectedElement);
            foreach (var ownership in ownerships)
            {
                TextBlock textBlock = ownership.Key as TextBlock;
                if (textBlock != null)
                {
                    var brush = textBlock.Foreground as SolidColorBrush;
                    if (brush != null) previousColor = brush.Color;
                    textBlock.Foreground = new SolidColorBrush(color);
                }

                Shape shape = ownership.Key as Shape;
                if (shape != null)
                {
                    var brush = shape.Stroke as SolidColorBrush;
                    if (brush != null) previousColor = brush.Color;
                    shape.Stroke = new SolidColorBrush(color);
                }
            }
        }

        private void MainCanvas_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (!IsSelectable) return;
            if (!_draggingState.IsDragging || _innerScore == null) return;

            Point currentPosition = e.GetCurrentPoint(MainCanvas).Position;
            var strategy = DraggingStrategy.For(SelectedElement);
            if (strategy != null)
            {
                strategy.Drag(Renderer, SelectedElement, _draggingState, CanvasScoreRenderer.ConvertPoint(currentPosition));
            }

            if (InvalidatingMode == InvalidatingModes.RedrawAllScore) RenderOnCanvas(_innerScore);
        }

        private void MainCanvas_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (!IsSelectable) return;
            MainCanvas.CapturePointer(e.Pointer);  //Capture mouse to receive events even if the pointer is outside the control

            //Start dragging:
            _draggingState.StartDragging(CanvasScoreRenderer.ConvertPoint(e.GetCurrentPoint(MainCanvas).Position));

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

        private async void RenderOnCanvas(Score score)
        {
            _innerScore = score;
            if (score == null) return;

            score.MeasureInvalidated -= Score_MeasureInvalidated;

            MainCanvas.Children.Clear();
            Renderer = new CanvasScoreRenderer(MainCanvas);
            Renderer.Settings.RenderingMode = RenderingMode;
            Renderer.Settings.CurrentPage = CurrentPage;
            var brush = Foreground as SolidColorBrush;
            if (brush != null) Renderer.Settings.DefaultColor = Renderer.ConvertColor(brush.Color);
            if (score.Staves.Count > 0) Renderer.Settings.PageWidth = score.Staves[0].Elements.Count * 26;

            Renderer.Render(score);

            if (SelectedElement != null) ColorElement(SelectedElement, Colors.Magenta);
            //InvalidateMeasure();

            score.MeasureInvalidated += Score_MeasureInvalidated;
        }

        private void RenderOnCanvas(Measure measure)
        {
            if (Renderer == null) Renderer = new CanvasScoreRenderer(MainCanvas);
            var beamGroupsForThisMeasure = measure.Staff.BeamGroups.Where(bg => bg.Members.Any(m => m.Measure == measure));
            foreach (var beamGroup in beamGroupsForThisMeasure)
            {
                var frameworkElements = Renderer.OwnershipDictionary.Where(d => d.Value == beamGroup).Select(d => d.Key).ToList();
                frameworkElements.RemoveAllFrom(Renderer.Canvas);
            }

            foreach (var element in measure.Elements.Where(e => !(e is Barline)))
            {
                var note = element as Note;
                if (note != null)
                {
                    foreach (var lyric in note.Lyrics)
                    {
                        var lyricsFrameworkElements = Renderer.OwnershipDictionary.Where(d => d.Value == lyric).Select(d => d.Key).ToList();
                        lyricsFrameworkElements.RemoveAllFrom(Renderer.Canvas);
                    }
                }
                var frameworkElements = Renderer.OwnershipDictionary.Where(d => d.Value == element).Select(d => d.Key).ToList();
                frameworkElements.RemoveAllFrom(Renderer.Canvas);
            }

            var brush = Foreground as SolidColorBrush;
            if (brush != null) Renderer.Settings.DefaultColor = Renderer.ConvertColor(brush.Color);

            Renderer.Render(measure);
            if (SelectedElement != null) ColorElement(SelectedElement, Colors.Magenta);
            //InvalidateMeasure();
        }

        private void Score_MeasureInvalidated(object sender, Model.Events.InvalidateEventArgs<Measure> e)
        {
            if (InvalidatingMode != InvalidatingModes.RedrawInvalidatedRegion) return;
            var score = (sender as MusicalSymbol)?.Staff?.Score;
            if (score == null) return;
            score.MeasureInvalidated -= Score_MeasureInvalidated;
            RenderOnCanvas(e.InvalidatedObject);
            score.MeasureInvalidated += Score_MeasureInvalidated;
        }
    }
}