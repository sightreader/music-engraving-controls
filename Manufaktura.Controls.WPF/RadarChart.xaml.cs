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
using Manufaktura.Controls.WPF.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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
            DependencyProperty.Register(nameof(Samples), typeof(RadarChartSample[]), typeof(RadialChart), new PropertyMetadata(null, ChartPropertyChanged));

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SampleValueChangedCommandProperty =
            DependencyProperty.Register(nameof(SampleValueChangedCommand), typeof(ICommand), typeof(RadialChart), new PropertyMetadata(null));

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WeblineStrokeProperty =
            DependencyProperty.Register(nameof(WeblineStroke), typeof(Brush), typeof(RadialChart), new PropertyMetadata(Brushes.Black, ChartPropertyChanged));

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WeblineStrokeThicknessProperty =
            DependencyProperty.Register(nameof(WeblineStrokeThickness), typeof(double), typeof(RadialChart), new PropertyMetadata(0.5d, ChartPropertyChanged));

        private readonly WPFRadarChartRenderer renderer;
        private Ellipse draggedElement;



        public RadialChart()
        {
            InitializeComponent();
            renderer = new WPFRadarChartRenderer(this, mainCanvas);

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

        public RadarChartSample[] Samples
        {
            get { return (RadarChartSample[])GetValue(SamplesProperty); }
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
            if (!renderer.AngleDictionary.ContainsKey(draggedElement)) return;
            var angle = renderer.AngleDictionary[draggedElement];
            var sample = renderer.SampleDictionary[draggedElement];

            var maxLength = mainCanvas.ActualWidth / 2;
            var newLength = Math.Sqrt(Math.Pow(position.X, 2) + Math.Pow(position.Y, 2));
            var delta = new PolarPoint(angle, newLength).ToCartesian();
            sample.Value = ((MaxValue * newLength) / renderer.CalculatedMaxLineLength) / sample.Scale;
            SampleValueChangedCommand?.Execute(sample);

            Canvas.SetLeft(draggedElement, (mainCanvas.ActualWidth / 2 - (SamplePointDiameter / 2)) + delta.X);
            Canvas.SetTop(draggedElement, (mainCanvas.ActualHeight / 2 - (SamplePointDiameter / 2)) + delta.Y);
        }

        private void mainCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            RedrawChart();
        }


        private void RedrawChart()
        {
            InvalidateArrange();
            InvalidateMeasure();
            renderer.RedrawChart(Samples);
        }
    }
}