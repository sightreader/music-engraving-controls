using Manufaktura.Controls.Interactivity;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Manufaktura.Controls.WindowsPhoneSilverlight
{
	public partial class NoteViewer : UserControl
	{
		public static readonly DependencyProperty InvalidatingModeProperty = DependencyPropertyEx.Register<NoteViewer, InvalidatingModes>(v => v.InvalidatingMode, InvalidatingModes.RedrawInvalidatedRegion);
		public static readonly DependencyProperty IsInsertModeProperty = DependencyPropertyEx.Register<NoteViewer, bool>(v => v.IsInsertMode, false);
		public static readonly DependencyProperty IsOccupyingSpaceProperty = DependencyPropertyEx.Register<NoteViewer, bool>(v => v.IsOccupyingSpace, true);
		public static readonly DependencyProperty IsPanoramaModeProperty = DependencyPropertyEx.Register<NoteViewer, bool>(v => v.IsPanoramaMode, true);
		public static readonly DependencyProperty IsSelectableProperty = DependencyPropertyEx.Register<NoteViewer, bool>(v => v.IsSelectable, true);
		public static readonly DependencyProperty RenderingModeProperty = DependencyPropertyEx.Register<NoteViewer, ScoreRenderingModes>(v => v.RenderingMode, ScoreRenderingModes.Panorama, RenderingModeChanged);
		public static readonly DependencyProperty ScoreSourceProperty = DependencyPropertyEx.Register<NoteViewer, Score>(v => v.ScoreSource, null, ScoreSourceChanged);
		public static readonly DependencyProperty SelectedElementProperty = DependencyPropertyEx.Register<NoteViewer, MusicalSymbol>(v => v.SelectedElement, null);
		public static readonly DependencyProperty XmlSourceProperty = DependencyPropertyEx.Register<NoteViewer, string>(v => v.XmlSource, null, XmlSourceChanged);
		public static readonly DependencyProperty XmlTransformationsProperty = DependencyPropertyEx.Register<NoteViewer, IEnumerable<XTransformerParser>>(v => v.XmlTransformations, null);
		public static readonly DependencyProperty ZoomFactorProperty = DependencyPropertyEx.Register<NoteViewer, double>(v => v.ZoomFactor, 1d, ZoomFactorChanged);
		private DraggingState _draggingState = new DraggingState();

		private Score _innerScore;

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
			get { return SelectedElementInner; }
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

		protected MusicalSymbol SelectedElementInner { get; set; }

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

		protected override Size MeasureOverride(Size availableSize)
		{
			if (Renderer == null || !IsOccupyingSpace) return base.MeasureOverride(availableSize);
			double width = availableSize.Width;

			double maxWidth = Renderer.ScoreInformation.Systems.Max(s => s.Width);
			if (maxWidth > 0) width = maxWidth;

			return new Size(width * ZoomFactor, (Renderer.ScoreInformation.Systems.Sum(s => s.Height) + 100) * ZoomFactor);
		}

		private static void CurrentPageChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
		}

		private static void RenderingModeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
		}

		private static void ScoreSourceChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
			NoteViewer viewer = obj as NoteViewer;
			var oldScore = args.OldValue as Score;
			var score = args.NewValue as Score;
			if (oldScore != null) oldScore.Safety.BoundControl = null;
			Score.SanityCheck(score, viewer);

			score.MeasureInvalidated -= viewer.Score_MeasureInvalidated;
			viewer.RenderOnCanvas(score);
			score.MeasureInvalidated += viewer.Score_MeasureInvalidated;
		}

		private static void SelectedElementChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
			NoteViewer viewer = (NoteViewer)obj;
			viewer.Select(args.NewValue as MusicalSymbol);
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
			viewer.RenderOnCanvas(parser.Parse(xmlDocument));
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
			_draggingState.StartDragging(CanvasScoreRenderer.ConvertPoint(e.GetPosition(MainCanvas)));

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
			var ownerships = Renderer.OwnershipDictionary.Where(o => o.Value == SelectedElementInner);
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
			if (!IsSelectable) return;
			MainCanvas.ReleaseMouseCapture();
			_draggingState.StopDragging();
		}

		private void MainCanvas_MouseMove(object sender, MouseEventArgs e)
		{
			if (!IsSelectable) return;
			if (!_draggingState.IsDragging || _innerScore == null) return;

			Point currentPosition = e.GetPosition(MainCanvas);
			var strategy = DraggingStrategy.For(SelectedElement);
			if (strategy != null)
			{
				strategy.Drag(Renderer, SelectedElement, _draggingState, CanvasScoreRenderer.ConvertPoint(currentPosition));
			}

			if (InvalidatingMode == InvalidatingModes.RedrawAllScore) RenderOnCanvas(_innerScore);
		}

		private void RenderOnCanvas(Score score)
		{
			_innerScore = score;
			if (score == null) return;

			MainCanvas.Children.Clear();
			Renderer = new CanvasScoreRenderer(MainCanvas);
			Renderer.Settings.RenderingMode = RenderingMode;
			var brush = Foreground as SolidColorBrush;
			if (brush != null) Renderer.Settings.DefaultColor = Renderer.ConvertColor(brush.Color);
			if (score.Staves.Count > 0) Renderer.Settings.PageWidth = score.Staves[0].Elements.Count * 26;
			Renderer.Render(score);
			if (SelectedElementInner != null) ColorElement(SelectedElementInner, Colors.Magenta);
			InvalidateMeasure();
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
	}
}