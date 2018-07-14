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

//#define DemoVersion

using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Manufaktura.Controls.WPF
{
	/// <summary>
	/// Interaction logic for RadialChart.xaml
	/// </summary>
	public partial class RadialChart : UserControl
	{
		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty AxisStrokeProperty =
			DependencyProperty.Register(nameof(AxisStroke), typeof(Brush), typeof(RadialChart), new PropertyMetadata(Brushes.Black));

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty AxisStrokeThicknessProperty =
			DependencyProperty.Register(nameof(AxisStrokeThickness), typeof(double), typeof(RadialChart), new PropertyMetadata(1d));

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty LabelToAxisDistanceProperty =
			DependencyProperty.Register(nameof(LabelToAxisDistance), typeof(double), typeof(RadialChart), new PropertyMetadata(10d, ChartPropertyChanged));

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty MaxValueProperty =
			DependencyProperty.Register(nameof(MaxValue), typeof(double), typeof(RadialChart), new PropertyMetadata(100d));

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty NumberOfTicksProperty =
			DependencyProperty.Register(nameof(NumberOfTicks), typeof(int), typeof(RadialChart), new PropertyMetadata(5, ChartPropertyChanged));

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty SamplePointDiameterProperty =
			DependencyProperty.Register(nameof(SamplePointDiameter), typeof(double), typeof(RadialChart), new PropertyMetadata(14d, ChartPropertyChanged));

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty SamplePointFillProperty =
			DependencyProperty.Register(nameof(SamplePointFill), typeof(Brush), typeof(RadialChart), new PropertyMetadata(Brushes.Aquamarine));

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty SamplePointStrokeProperty =
			DependencyProperty.Register(nameof(SamplePointStroke), typeof(Brush), typeof(RadialChart), new PropertyMetadata(Brushes.Blue));

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty SamplePointStrokeThicknessProperty =
			DependencyProperty.Register(nameof(SamplePointStrokeThickness), typeof(double), typeof(RadialChart), new PropertyMetadata(1d));

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty SamplesProperty =
			DependencyProperty.Register(nameof(Samples), typeof(RadialChartSample[]), typeof(RadialChart), new PropertyMetadata(null, ChartPropertyChanged));

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty SampleValueChangedCommandProperty =
			DependencyProperty.Register(nameof(SampleValueChangedCommand), typeof(ICommand), typeof(RadialChart), new PropertyMetadata(null));

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty WeblineStrokeProperty =
			DependencyProperty.Register(nameof(WeblineStroke), typeof(Brush), typeof(RadialChart), new PropertyMetadata(Brushes.Black, ChartPropertyChanged));

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty WeblineStrokeThicknessProperty =
			DependencyProperty.Register(nameof(WeblineStrokeThickness), typeof(double), typeof(RadialChart), new PropertyMetadata(0.5d, ChartPropertyChanged));

		private Dictionary<Ellipse, double> angleDictionary = new Dictionary<Ellipse, double>();

		private Ellipse draggedElement;

		private Dictionary<Ellipse, RadialChartSample> sampleDictionary = new Dictionary<Ellipse, RadialChartSample>();

		public RadialChart()
		{
			InitializeComponent();

			mainCanvas.MouseLeftButtonDown += MainCanvas_MouseLeftButtonDown;
			mainCanvas.MouseLeftButtonUp += MainCanvas_MouseLeftButtonUp;
			mainCanvas.MouseMove += MainCanvas_MouseMove;
		}

		public Brush AxisStroke
		{
			get { return (Brush)GetValue(AxisStrokeProperty); }
			set { SetValue(AxisStrokeProperty, value); }
		}

		public double AxisStrokeThickness
		{
			get { return (double)GetValue(AxisStrokeThicknessProperty); }
			set { SetValue(AxisStrokeThicknessProperty, value); }
		}

		public double LabelToAxisDistance
		{
			get { return (double)GetValue(LabelToAxisDistanceProperty); }
			set { SetValue(LabelToAxisDistanceProperty, value); }
		}

		public double MaxValue
		{
			get { return (double)GetValue(MaxValueProperty); }
			set { SetValue(MaxValueProperty, value); }
		}

		public int NumberOfTicks
		{
			get { return (int)GetValue(NumberOfTicksProperty); }
			set { SetValue(NumberOfTicksProperty, value); }
		}

		public double SamplePointDiameter
		{
			get { return (double)GetValue(SamplePointDiameterProperty); }
			set { SetValue(SamplePointDiameterProperty, value); }
		}

		public Brush SamplePointFill
		{
			get { return (Brush)GetValue(SamplePointFillProperty); }
			set { SetValue(SamplePointFillProperty, value); }
		}

		public Brush SamplePointStroke
		{
			get { return (Brush)GetValue(SamplePointStrokeProperty); }
			set { SetValue(SamplePointStrokeProperty, value); }
		}

		public double SamplePointStrokeThickness
		{
			get { return (double)GetValue(SamplePointStrokeThicknessProperty); }
			set { SetValue(SamplePointStrokeThicknessProperty, value); }
		}

		public RadialChartSample[] Samples
		{
			get { return (RadialChartSample[])GetValue(SamplesProperty); }
			set { SetValue(SamplesProperty, value); }
		}

		public ICommand SampleValueChangedCommand
		{
			get { return (ICommand)GetValue(SampleValueChangedCommandProperty); }
			set { SetValue(SampleValueChangedCommandProperty, value); }
		}

		public Brush WeblineStroke
		{
			get { return (Brush)GetValue(WeblineStrokeProperty); }
			set { SetValue(WeblineStrokeProperty, value); }
		}

		public double WeblineStrokeThickness
		{
			get { return (double)GetValue(WeblineStrokeThicknessProperty); }
			set { SetValue(WeblineStrokeThicknessProperty, value); }
		}

		private static void ChartPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadialChart)d).RedrawChart();
		}

		private void DrawAxis(string axisName, double axisLength, double currentAngle)
		{
			var line = new Line();
			line.Stroke = AxisStroke;
			line.SetBinding(Line.StrokeProperty, new Binding(nameof(AxisStroke)) { Source = this });
			line.StrokeThickness = AxisStrokeThickness;
			line.SetBinding(Line.StrokeThicknessProperty, new Binding(nameof(AxisStrokeThickness)) { Source = this });
			var position = new Primitives.Point(mainCanvas.ActualWidth / 2, mainCanvas.ActualHeight / 2);
			line.X1 = position.X;
			line.Y1 = position.Y;
			line.X2 = position.TranslateByAngle(currentAngle, axisLength).X;
			line.Y2 = position.TranslateByAngle(currentAngle, axisLength).Y;
			mainCanvas.Children.Add(line);

			var textBlock = new TextBlock();
			var formattedText = new FormattedText(axisName, CultureInfo.InvariantCulture, FlowDirection.LeftToRight, new Typeface(textBlock.FontFamily, textBlock.FontStyle, textBlock.FontWeight, textBlock.FontStretch), textBlock.FontSize, textBlock.Foreground);
			textBlock.Text = axisName;
			Canvas.SetLeft(textBlock, line.X2 - formattedText.Width / 2 + LabelToAxisDistance * Math.Sin(currentAngle));
			Canvas.SetTop(textBlock, line.Y2 - formattedText.Height / 2 + LabelToAxisDistance * Math.Cos(currentAngle));
			mainCanvas.Children.Add(textBlock);
		}

		private void DrawSamples(string axis, double lineLength, double currentAngle)
		{
			var axisSamples = Samples.Where(s => s.AxisShortName == axis);
			foreach (var sample in axisSamples)
			{
				var ellipse = new Ellipse();
				ellipse.Stroke = SamplePointStroke;
				ellipse.SetBinding(Ellipse.StrokeProperty, new Binding(nameof(SamplePointStroke)) { Source = this });
				ellipse.StrokeThickness = SamplePointStrokeThickness;
				ellipse.SetBinding(Ellipse.StrokeThicknessProperty, new Binding(nameof(SamplePointStrokeThickness)) { Source = this });
				ellipse.Fill = SamplePointFill;
				ellipse.SetBinding(Ellipse.FillProperty, new Binding(nameof(SamplePointFill)) { Source = this });
				ellipse.Width = SamplePointDiameter;
				ellipse.Height = SamplePointDiameter;
				Panel.SetZIndex(ellipse, 999);
				angleDictionary.Add(ellipse, currentAngle);
				sampleDictionary.Add(ellipse, sample);

				var valueLength = sample.Value * lineLength / MaxValue;
				var dx = valueLength * Math.Sin(currentAngle);
				var dy = valueLength * Math.Cos(currentAngle);
				Canvas.SetLeft(ellipse, mainCanvas.ActualWidth / 2 + dx - ellipse.Width / 2);
				Canvas.SetTop(ellipse, mainCanvas.ActualHeight / 2 + dy - ellipse.Height / 2);
				mainCanvas.Children.Add(ellipse);
			}
		}

		private void DrawWebLines(List<Tuple<double, double>> ticks1, List<Tuple<double, double>> ticks2)
		{
			for (int i = 0; i < NumberOfTicks; i++)
			{
				var webLine = new Line();
				webLine.Stroke = WeblineStroke;
				webLine.StrokeThickness = WeblineStrokeThickness;
				webLine.StrokeDashArray = new DoubleCollection(new double[] { 4, 4 });
				webLine.X1 = ticks1[i].Item1;
				webLine.Y1 = ticks1[i].Item2;
				webLine.X2 = ticks2[i].Item1;
				webLine.Y2 = ticks2[i].Item2;
				mainCanvas.Children.Add(webLine);
			}
		}

		private void MainCanvas_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			mainCanvas.CaptureMouse();  //Capture mouse to receive events even if the pointer is outside the control

			//Check if element under cursor is staff element:
			var element = e.OriginalSource as Ellipse;
			if (element == null) return;

			draggedElement = element;
		}

		private void MainCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			mainCanvas.ReleaseMouseCapture();
			draggedElement = null;
		}

		private void MainCanvas_MouseMove(object sender, MouseEventArgs e)
		{
			if (draggedElement == null) return;

			var position = e.GetPosition(mainCanvas);
			if (Primitives.Point.Distance(position.X, position.Y, Canvas.GetLeft(draggedElement), Canvas.GetTop(draggedElement)) > 30)
			{
				draggedElement = null;
				return;
			}

			position = new System.Windows.Point(position.X - mainCanvas.ActualWidth / 2, position.Y - mainCanvas.ActualHeight / 2);
			if (!angleDictionary.ContainsKey(draggedElement)) return;
			var angle = angleDictionary[draggedElement];
			var sample = sampleDictionary[draggedElement];

			var maxLength = mainCanvas.ActualWidth / 2;
			var newLength = Math.Sqrt(Math.Pow(position.X, 2) + Math.Pow(position.Y, 2));
			var delta = new PolarPoint(angle, newLength).ToCartesian();
			sample.Value = (MaxValue * newLength) / maxLength;
			SampleValueChangedCommand?.Execute(sample);

			Canvas.SetLeft(draggedElement, (mainCanvas.ActualWidth / 2 - (SamplePointDiameter / 2)) + delta.X);
			Canvas.SetTop(draggedElement, (mainCanvas.ActualHeight / 2 - (SamplePointDiameter / 2)) + delta.Y);
		}

		private void mainCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			RedrawChart();
		}

		private void DrawLinesBetweenSamples()
		{
			foreach (var sample in sampleDictionary)
			{
			}
		}

		private void RedrawChart()
		{
			InvalidateArrange();
			InvalidateMeasure();
			angleDictionary.Clear();
			sampleDictionary.Clear();
			mainCanvas.Children.Clear();
			if (Samples == null || !Samples.Any()) return;
			var axes = Samples.Select(s => s.AxisShortName).ToArray();
			var currentAngle = 0d;
			var angleChange = (2 * Math.PI) / axes.Length;
			var lineLength = mainCanvas.ActualHeight < mainCanvas.ActualWidth ? mainCanvas.ActualHeight / 2 : mainCanvas.ActualWidth / 2;

			List<Tuple<double, double>> previousTicks = null;
			List<Tuple<double, double>> firstTicks = null;
			foreach (var axis in axes)
			{
				DrawAxis(axis, lineLength, currentAngle);

				var ticks = new List<Tuple<double, double>>();
				for (int i = 0; i < NumberOfTicks; i++)
				{
					var tickOffset = (lineLength / NumberOfTicks) * (i + 1);
					var tickLocation = new Primitives.Point(mainCanvas.ActualWidth / 2, mainCanvas.ActualHeight / 2).TranslateByAngle(currentAngle, tickOffset);
					ticks.Add(new Tuple<double, double>(tickLocation.X + 0.5, tickLocation.Y + 0.5));

					if (axes.Length < 3)
					{
						var tick = new Line();
						tick.Stroke = Brushes.Black;
						tick.StrokeThickness = 6;
						tick.X1 = tickLocation.X;
						tick.Y1 = tickLocation.Y;
						tick.X2 = tickLocation.TranslateByAngle(currentAngle, 1).X;
						tick.Y2 = tickLocation.TranslateByAngle(currentAngle, 1).Y;
						mainCanvas.Children.Add(tick);
					}
				}
				if (axes.Length > 2)
				{
					if (firstTicks == null) firstTicks = new List<Tuple<double, double>>(ticks);
					if (previousTicks != null) DrawWebLines(previousTicks, ticks);
					previousTicks = ticks;
				}

				DrawSamples(axis, lineLength, currentAngle);

				currentAngle += angleChange;
			}
			if (axes.Length > 2)
			{
				DrawWebLines(firstTicks, previousTicks);
				DrawLinesBetweenSamples();
			}

#if DemoVersion
			foreach (var location in new[] {
				new System.Windows.Point(0, 0),
				new System.Windows.Point(mainCanvas.ActualWidth - 60, 0)})
			{
				var demoText = new TextBlock();
				demoText.Foreground = Brushes.Red;
				demoText.Text = "DEMO";
				mainCanvas.Children.Add(demoText);
				Canvas.SetLeft(mainCanvas, location.X);
				Canvas.SetTop(mainCanvas, location.Y);
			}
#endif
		}
	}
}