using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin
{
	public abstract class NoteViewer : AbsoluteLayout
	{
		// Using a BindableProperty as the backing store for InvalidatingMode.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty InvalidatingModeProperty =
			BindableProperty.Create("InvalidatingMode", typeof(InvalidatingModes), typeof(NoteViewer), InvalidatingModes.RedrawInvalidatedRegion);

		// Using a BindableProperty as the backing store for IsAsync.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty IsAsyncProperty =
			BindableProperty.Create("IsAsync", typeof(bool), typeof(NoteViewer), false);

		// Using a BindableProperty as the backing store for IsDebugMode.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty IsDebugModeProperty =
			BindableProperty.Create("IsDebugMode", typeof(bool), typeof(NoteViewer), false);

		// Using a BindableProperty as the backing store for IsInsertMode.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty IsInsertModeProperty =
			BindableProperty.Create("IsInsertMode", typeof(bool), typeof(NoteViewer), false);

		// Using a BindableProperty as the backing store for IsOccupyingSpace.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty IsOccupyingSpaceProperty =
			BindableProperty.Create("IsOccupyingSpace", typeof(bool), typeof(NoteViewer), true);

		// Using a BindableProperty as the backing store for IsPanoramaMode.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty IsPanoramaModeProperty =
			BindableProperty.Create("IsPanoramaMode", typeof(bool), typeof(NoteViewer), true);

		// Using a BindableProperty as the backing store for IsSelectable.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty IsSelectableProperty =
			BindableProperty.Create("IsSelectable", typeof(bool), typeof(NoteViewer), true);

		// Using a BindableProperty as the backing store for ScoreSource.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty ScoreSourceProperty =
			BindableProperty.Create<NoteViewer, Score>(n => n.ScoreSource, null, BindingMode.OneWay, null, ScoreSourceChanged);

		// Using a BindableProperty as the backing store for SelectedElement.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty SelectedElementProperty =
			BindableProperty.Create("SelectedElement", typeof(MusicalSymbol), typeof(NoteViewer), null);

		// Using a BindableProperty as the backing store for XmlSourceProperty.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty XmlSourceProperty =
			BindableProperty.Create<NoteViewer, string>(n => n.XmlSource, null, BindingMode.OneWay, null, XmlSourceChanged);

		// Using a BindableProperty as the backing store for XmlTransformations.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty XmlTransformationsProperty =
			BindableProperty.Create("XmlTransformations", typeof(IEnumerable<XTransformerParser>), typeof(NoteViewer), null);

		// Using a BindableProperty as the backing store for ZoomFactor.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty ZoomFactorProperty =
			BindableProperty.Create<NoteViewer, double>(n => n.ZoomFactor, 1d, BindingMode.OneWay, null, ZoomFactorChanged);

		private DraggingState _draggingState = new DraggingState();

		private Score _innerScore;

		public NoteViewer()
		{
		}

		public enum InvalidatingModes
		{
			RedrawAllScore,
			RedrawInvalidatedRegion
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

		protected AbsoluteLayoutScoreRenderer Renderer { get; set; }

		public void Select(MusicalSymbol element)
		{
			if (SelectedElement != null) ColorElement(SelectedElement, Color.Black);   //Reset color on previously selected element
			SelectedElement = element;

			var note = SelectedElement as Note;
			if (note != null) _draggingState.MidiPitchOnStartDragging = note.MidiPitch;

			if (SelectedElement != null) ColorElement(SelectedElement, Color.Fuchsia);      //Apply color on selected element

			var positionElement = element as IHasCustomXPosition;
			if (positionElement != null) Debug.WriteLine("Default-x for selected element: {0}",
				positionElement.DefaultXPosition.HasValue ? positionElement.DefaultXPosition.Value.ToString() : "(not set)");
		}

		private static void ScoreSourceChanged(BindableObject obj, Score newValue, Score oldValue)
		{
			NoteViewer viewer = obj as NoteViewer;
			newValue.MeasureInvalidated -= viewer.Score_MeasureInvalidated;
			viewer.RenderOnCanvas(newValue);
			newValue.MeasureInvalidated += viewer.Score_MeasureInvalidated;
		}

		private static void XmlSourceChanged(BindableObject obj, string newValue, string oldValue)
		{
			NoteViewer viewer = obj as NoteViewer;

			XDocument xmlDocument = XDocument.Parse(newValue);
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

		private static void ZoomFactorChanged(BindableObject obj, double newValue, double oldValue)
		{
			((NoteViewer)obj).InvalidateMeasure();
		}

		private void ColorElement(MusicalSymbol selectedElement, Color black)
		{
			//TODO: Zaimplementować
		}

		private AbsoluteLayoutScoreRenderer CreateRenderer(AbsoluteLayout canvas)
		{
			return new AbsoluteLayoutScoreRenderer(this);
		}

		private void RenderOnCanvas(Measure measure)
		{
			if (Renderer == null) Renderer = CreateRenderer(this);
			foreach (var element in measure.Elements.Where(e => !(e is Barline)))
			{
				var frameworkElements = Renderer.OwnershipDictionary.Where(d => d.Value == element).Select(d => d.Key).ToList();
				foreach (var frameworkElement in frameworkElements)
				{
					Renderer.Canvas.Children.Remove((View)frameworkElement);
				}
			}


			Renderer.Render(measure);
			if (SelectedElement != null) ColorElement(SelectedElement, Color.Fuchsia);
			InvalidateMeasure();
		}

		private void RenderOnCanvas(Score score)
		{
			_innerScore = score;
			if (score == null) return;

			Children.Clear();
			//Renderer = CreateRenderer(this);
			Renderer.Settings.IsPanoramaMode = IsPanoramaMode;
			//Renderer.Settings.DefaultColor = Renderer.ConvertColor(Color.Black);
			if (score.Staves.Count > 0) Renderer.Settings.PageWidth = score.Staves[0].Elements.Count * 26;
			Renderer.Render(score);
			if (SelectedElement != null) ColorElement(SelectedElement, Color.Fuchsia);
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