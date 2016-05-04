using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Manufaktura.Controls.WPF
{
	/// <summary>
	/// Interaction logic for NoteViewer.xaml
	/// </summary>
	public partial class NoteViewer : UserControl
	{
		// Using a DependencyProperty as the backing store for InvalidatingMode.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty InvalidatingModeProperty =
			DependencyProperty.Register("InvalidatingMode", typeof(InvalidatingModes), typeof(NoteViewer), new PropertyMetadata(InvalidatingModes.RedrawInvalidatedRegion));

		// Using a DependencyProperty as the backing store for IsAsync.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty IsAsyncProperty =
			DependencyProperty.Register("IsAsync", typeof(bool), typeof(NoteViewer), new PropertyMetadata(false));

		// Using a DependencyProperty as the backing store for IsDebugMode.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty IsDebugModeProperty =
			DependencyProperty.Register("IsDebugMode", typeof(bool), typeof(NoteViewer), new PropertyMetadata(false));

		// Using a DependencyProperty as the backing store for IsInsertMode.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty IsInsertModeProperty =
			DependencyProperty.Register("IsInsertMode", typeof(bool), typeof(NoteViewer), new PropertyMetadata(false));

		// Using a DependencyProperty as the backing store for IsOccupyingSpace.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty IsOccupyingSpaceProperty =
			DependencyProperty.Register("IsOccupyingSpace", typeof(bool), typeof(NoteViewer), new PropertyMetadata(true));

		// Using a DependencyProperty as the backing store for IsPanoramaMode.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty IsPanoramaModeProperty =
			DependencyProperty.Register("IsPanoramaMode", typeof(bool), typeof(NoteViewer), new PropertyMetadata(true));

		// Using a DependencyProperty as the backing store for IsSelectable.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty IsSelectableProperty =
			DependencyProperty.Register("IsSelectable", typeof(bool), typeof(NoteViewer), new PropertyMetadata(true));

		// Using a DependencyProperty as the backing store for ScoreSource.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ScoreSourceProperty =
			DependencyProperty.Register("ScoreSource", typeof(Score), typeof(NoteViewer), new PropertyMetadata(null, ScoreSourceChanged));

		// Using a DependencyProperty as the backing store for SelectedElement.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty SelectedElementProperty =
			DependencyProperty.Register("SelectedElement", typeof(MusicalSymbol), typeof(NoteViewer), new PropertyMetadata(null));

		// Using a DependencyProperty as the backing store for XmlSourceProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty XmlSourceProperty =
			DependencyProperty.Register("XmlSource", typeof(string), typeof(NoteViewer), new PropertyMetadata(null, XmlSourceChanged));

		// Using a DependencyProperty as the backing store for XmlTransformations.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty XmlTransformationsProperty =
			DependencyProperty.Register("XmlTransformations", typeof(IEnumerable<XTransformerParser>), typeof(NoteViewer), new PropertyMetadata(null));

		// Using a DependencyProperty as the backing store for ZoomFactor.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ZoomFactorProperty =
			DependencyProperty.Register("ZoomFactor", typeof(double), typeof(NoteViewer), new PropertyMetadata(1d, ZoomFactorChanged));

		private DraggingState _draggingState = new DraggingState();

		private Score _innerScore;

		private Color previousColor;

		public NoteViewer()
		{
			InitializeComponent();
		}

		public Score InnerScore { get { return _innerScore; } }

		public InvalidatingModes InvalidatingMode
		{
			get { return (InvalidatingModes)GetValue(InvalidatingModeProperty); }
			set { SetValue(InvalidatingModeProperty, value); }
		}

		public bool IsAsync
		{
			get { return (bool)GetValue(IsAsyncProperty); }
			set { SetValue(IsAsyncProperty, value); }
		}

		public bool IsDebugMode
		{
			get { return (bool)GetValue(IsDebugModeProperty); }
			set { SetValue(IsDebugModeProperty, value); }
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

		protected CanvasScoreRenderer Renderer { get; set; }

		public void Select(MusicalSymbol element)
		{
			if (SelectedElement != null) ColorElement(SelectedElement, previousColor);   //Reset color on previously selected element
			SelectedElement = element;

			var note = SelectedElement as Note;
			if (note != null) _draggingState.MidiPitchOnStartDragging = note.MidiPitch;

			if (SelectedElement != null) ColorElement(SelectedElement, Colors.Magenta);      //Apply color on selected element

			var positionElement = element as IHasCustomXPosition;
			if (positionElement != null) Debug.WriteLine("Default-x for selected element: {0}",
				positionElement.DefaultXPosition.HasValue ? positionElement.DefaultXPosition.Value.ToString() : "(not set)");
		}

		protected override Size MeasureOverride(Size availableSize)
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
		}

		private static void ScoreSourceChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
			NoteViewer viewer = obj as NoteViewer;
			var score = args.NewValue as Score;
			score.MeasureInvalidated -= viewer.Score_MeasureInvalidated;
			viewer.RenderOnCanvas(score);
			score.MeasureInvalidated += viewer.Score_MeasureInvalidated;
		}

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
			var score = parser.Parse(xmlDocument);
			score.MeasureInvalidated -= viewer.Score_MeasureInvalidated;
			viewer.RenderOnCanvas(score);
			score.MeasureInvalidated += viewer.Score_MeasureInvalidated;
		}

		private static void ZoomFactorChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
			((NoteViewer)obj).InvalidateMeasure();
		}

		private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (!IsSelectable) return;
			MainCanvas.CaptureMouse();  //Capture mouse to receive events even if the pointer is outside the control

			//Start dragging:
			_draggingState.StartDragging(e.GetPosition(MainCanvas));

			//Check if element under cursor is staff element:
			FrameworkElement element = e.OriginalSource as FrameworkElement;
			if (element == null) return;
			if (!Renderer.OwnershipDictionary.ContainsKey(element)) return;

			//Set selected element:
			Select(Renderer.OwnershipDictionary[element]);
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

		private void MainCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			if (!IsSelectable) return;
			MainCanvas.ReleaseMouseCapture();
			_draggingState.StopDragging();
		}

		private void MainCanvas_MouseMove(object sender, MouseEventArgs e)
		{
			if (!IsSelectable) return;
			if (!_draggingState.IsDragging || _innerScore == null) return;

			Point currentPosition = e.GetPosition(MainCanvas);
			double horizontalDifference = Math.Abs(_draggingState.MousePositionOnStartDragging.X - currentPosition.X);
			if (horizontalDifference > 30)
			{
				_draggingState.StopDragging();
				return;
			}
			double difference = _draggingState.MousePositionOnStartDragging.Y - currentPosition.Y;

			Note note = SelectedElement as Note;
			if (note != null)
			{
				int midiPitch = _draggingState.MidiPitchOnStartDragging + (int)(difference / 2);
				Debug.WriteLine(string.Format("Difference: {0}   MidiPitch: {1}", difference, midiPitch));
				note.ApplyMidiPitch(midiPitch);     //TODO: Wstawianie kasownika, jeśli jest znak przykluczowy, a obniżyliśmy o pół tonu
													//TODO: Ustalanie kierunku ogonka. Sprawdzić czy gdzieś to nie jest już zrobione, np. w PSAMie
			}

			if (InvalidatingMode == InvalidatingModes.RedrawAllScore) RenderOnCanvas(_innerScore);
		}

		private void RenderOnCanvas(Measure measure)
		{
			if (Renderer == null) Renderer = new CanvasScoreRenderer(MainCanvas);
			foreach (var element in measure.Elements.Where(e => !(e is Barline)))
			{
				var frameworkElements = Renderer.OwnershipDictionary.Where(d => d.Value == element).Select(d => d.Key).ToList();
				foreach (var frameworkElement in frameworkElements)
				{
					Renderer.Canvas.Children.Remove(frameworkElement);
				}
			}

			var brush = Foreground as SolidColorBrush;
			if (brush != null) Renderer.Settings.DefaultColor = Renderer.ConvertColor(brush.Color);

			Renderer.Render(measure);
			if (SelectedElement != null) ColorElement(SelectedElement, Colors.Magenta);
			InvalidateMeasure();
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
			if (SelectedElement != null) ColorElement(SelectedElement, Colors.Magenta);
			InvalidateMeasure();
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

		private struct DraggingState
		{
			public bool IsDragging { get; private set; }

			public int MidiPitchOnStartDragging { get; set; }

			public Point MousePositionOnStartDragging { get; private set; }

			public void StartDragging(Point startingPosition)
			{
				IsDragging = true;
				MousePositionOnStartDragging = startingPosition;
			}

			public void StopDragging()
			{
				IsDragging = false;
				MousePositionOnStartDragging = default(Point);
				MidiPitchOnStartDragging = 0;
			}
		}
	}
}