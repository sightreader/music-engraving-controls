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

using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Rendering;
using Manufaktura.Controls.Xamarin.Shapes;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin
{
	public class NoteViewer : DrawableCanvas
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
		public static readonly BindableProperty RenderingModeProperty =
			BindableProperty.Create(nameof(RenderingMode), typeof(ScoreRenderingModes), typeof(NoteViewer), ScoreRenderingModes.Panorama);

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

		public ScoreRenderingModes RenderingMode
		{
			get { return (ScoreRenderingModes)GetValue(RenderingModeProperty); }
			set { SetValue(RenderingModeProperty, value); }
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

		protected DrawableCanvasScoreRenderer Renderer { get; set; }

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

		private static void ScoreSourceChanged(BindableObject obj, Score oldValue, Score newValue)
		{
			NoteViewer viewer = obj as NoteViewer;
			if (oldValue != null) oldValue.MeasureInvalidated -= viewer.Score_MeasureInvalidated;
			if (newValue == null) return;
			newValue.MeasureInvalidated -= viewer.Score_MeasureInvalidated;
			viewer.RenderOnCanvas(newValue);
			newValue.MeasureInvalidated += viewer.Score_MeasureInvalidated;
		}

		//protected override SizeRequest OnSizeRequest(double widthConstraint, double heightConstraint)
		//{
		//	return new SizeRequest(new Size(widthConstraint, heightConstraint));
		//}

		private static void XmlSourceChanged(BindableObject obj, string oldValue, string newValue)
		{
			NoteViewer viewer = obj as NoteViewer;

			if (string.IsNullOrWhiteSpace(newValue))
			{
				if (!string.IsNullOrWhiteSpace(oldValue)) viewer.Children.Clear();
				return;
			}

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

		private static void ZoomFactorChanged(BindableObject obj, double oldValue, double newValue)
		{
			((NoteViewer)obj).InvalidateMeasure();
		}

		private void ColorElement(MusicalSymbol selectedElement, Color black)
		{
			//TODO: Zaimplementować
		}

		private DrawableCanvasScoreRenderer CreateRenderer(DrawableCanvas canvas)
		{
			return new DrawableCanvasScoreRenderer(this);
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
			Renderer = CreateRenderer(this);
			Renderer.Settings.RenderingMode = RenderingMode;
			Renderer.Settings.DefaultColor = Renderer.ConvertColor(Color.Black);
			if (score.Staves.Count > 0) Renderer.Settings.PageWidth = score.Staves[0].Elements.Count * 26;
			Renderer.Render(score);
			if (SelectedElement != null) ColorElement(SelectedElement, Color.Fuchsia);
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