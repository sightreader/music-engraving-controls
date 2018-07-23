using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering.Charts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Manufaktura.Controls.WPF.Renderers
{
    public class WPFRadialChartRenderer : RadialChartRenderer<RadialChart, Canvas>
    {
        public WPFRadialChartRenderer(RadialChart control, Canvas canvas) : base(control, canvas)
        {
        }

        public Dictionary<Ellipse, double> AngleDictionary { get; } = new Dictionary<Ellipse, double>();

        protected override double MaxValue => Control.MaxValue;
        protected override int NumberOfTicks => Control.NumberOfTicks;
        public Dictionary<Ellipse, RadialChartSample> SampleDictionary { get; } = new Dictionary<Ellipse, RadialChartSample>();
        protected override double CanvasHeight => Canvas.ActualHeight;
        protected override double CanvasWidth => Canvas.ActualWidth;

        public override void ClearCanvas()
        {
            AngleDictionary.Clear();
            SampleDictionary.Clear();
            Canvas.Children.Clear();
        }

        public override void DrawPolygon(IEnumerable<Primitives.Point> innerPoints, IEnumerable<Primitives.Point> outerPoints)
        {
            var polygon = new Polygon();
            polygon.Stroke = Brushes.Green;
            polygon.Fill = Brushes.LightGreen;
            polygon.Opacity = 0.5;
            polygon.StrokeThickness = 2;
            foreach (var p in innerPoints) polygon.Points.Add(new System.Windows.Point(p.X, p.Y));
            var firstPoint = innerPoints.First();
            polygon.Points.Add(new System.Windows.Point(firstPoint.X, firstPoint.Y));
            foreach (var p in outerPoints) polygon.Points.Add(new System.Windows.Point(p.X, p.Y));
            firstPoint = outerPoints.First();
            polygon.Points.Add(new System.Windows.Point(firstPoint.X, firstPoint.Y));

            Panel.SetZIndex(polygon, -2);
            Canvas.Children.Add(polygon);
        }

        protected override void DrawAxisLabel(Primitives.Point position, double currentAngle, string axisName)
        {
            var textBlock = new TextBlock();
            var formattedText = new FormattedText(axisName, CultureInfo.InvariantCulture, FlowDirection.LeftToRight, new Typeface(textBlock.FontFamily, textBlock.FontStyle, textBlock.FontWeight, textBlock.FontStretch), textBlock.FontSize, textBlock.Foreground);
            textBlock.Text = axisName;
            Canvas.SetLeft(textBlock, position.X - formattedText.Width / 2 + Control.LabelToAxisDistance * Math.Sin(currentAngle));
            Canvas.SetTop(textBlock, position.Y - formattedText.Height / 2 + Control.LabelToAxisDistance * Math.Cos(currentAngle));
            Canvas.Children.Add(textBlock);
        }

        protected override void DrawAxisLine(Primitives.Point start, Primitives.Point end)
        {
            var line = new Line();
            line.SetBinding(Shape.StrokeProperty, new Binding(nameof(RadialChart.AxisStroke)) { Source = Control });
            line.SetBinding(Shape.StrokeThicknessProperty, new Binding(nameof(RadialChart.AxisStrokeThickness)) { Source = Control });
            line.X1 = start.X;
            line.Y1 = start.Y;
            line.X2 = end.X;
            line.Y2 = end.Y;
            Canvas.Children.Add(line);
        }

        protected override void DrawSample(RadialChartSample sample, double dx, double dy, double currentAngle)
        {
            var ellipse = new Ellipse();
            ellipse.SetBinding(Shape.StrokeProperty, new Binding(nameof(RadialChart.SamplePointStroke)) { Source = Control });
            ellipse.SetBinding(Shape.StrokeThicknessProperty, new Binding(nameof(RadialChart.SamplePointStrokeThickness)) { Source = Control });
            ellipse.SetBinding(Shape.FillProperty, new Binding(nameof(RadialChart.SamplePointFill)) { Source = Control });
            ellipse.Width = Control.SamplePointDiameter;
            ellipse.Height = Control.SamplePointDiameter;
            Panel.SetZIndex(ellipse, 999);
            AngleDictionary.Add(ellipse, currentAngle);
            SampleDictionary.Add(ellipse, sample);

            Canvas.SetLeft(ellipse, CanvasWidth / 2 + dx - Control.SamplePointDiameter / 2);
            Canvas.SetTop(ellipse, CanvasHeight / 2 + dy - Control.SamplePointDiameter / 2);
            Canvas.Children.Add(ellipse);
        }

        protected override void DrawTick(double x1, double y1, double x2, double y2)
        {
            var tick = new Line
            {
                Stroke = Brushes.Black,
                StrokeThickness = 6,
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2
            };
            Canvas.Children.Add(tick);
        }

        protected override void DrawValueCompartmentsPolygons(double lineLength)
        {
            var compartmentIndex = 0;
            while (true)
            {
                if (Control.Samples.All(s => s.ValidationCompartments == null || s.ValidationCompartments.Length <= compartmentIndex)) break;

                var innerPoints = new List<System.Windows.Point>();
                var outerPoints = new List<System.Windows.Point>();
                foreach (var sample in Control.Samples)
                {
                    var compartment = (sample.ValidationCompartments?.Length ?? 0) > compartmentIndex ? sample.ValidationCompartments[compartmentIndex] : null;
                    var compartmentMinValue = compartment == null ? 0 : (compartment.From ?? 0);
                    var compartmentMaxValue = compartment == null ? 0 : (compartment.To ?? Control.MaxValue / sample.Scale);

                    var currentAngle = SampleToAngleDictionary[sample];

                    var valueLength = compartmentMaxValue * sample.Scale * lineLength / Control.MaxValue;
                    var dx = valueLength * Math.Sin(currentAngle);
                    var dy = valueLength * Math.Cos(currentAngle);
                    outerPoints.Add(new System.Windows.Point(CanvasWidth / 2 + dx, CanvasHeight / 2 + dy));

                    valueLength = compartmentMinValue * sample.Scale * lineLength / Control.MaxValue;
                    dx = valueLength * Math.Sin(currentAngle);
                    dy = valueLength * Math.Cos(currentAngle);
                    innerPoints.Add(new System.Windows.Point(CanvasWidth / 2 + dx, CanvasHeight / 2 + dy));
                }

                var polygon = new Polygon();
                polygon.Stroke = Brushes.Green;
                polygon.Fill = Brushes.LightGreen;
                polygon.Opacity = 0.5;
                polygon.StrokeThickness = 2;
                foreach (var p in innerPoints) polygon.Points.Add(p);
                polygon.Points.Add(innerPoints.First());
                foreach (var p in outerPoints) polygon.Points.Add(p);
                polygon.Points.Add(outerPoints.First());

                Panel.SetZIndex(polygon, -2);
                Canvas.Children.Add(polygon);

                compartmentIndex++;
            }
        }

        protected override void DrawWebLines(List<Tuple<double, double>> ticks1, List<Tuple<double, double>> ticks2)
        {
            for (int i = 0; i < Control.NumberOfTicks; i++)
            {
                var webLine = new Line();
                webLine.Stroke = Control.WeblineStroke;
                webLine.StrokeThickness = Control.WeblineStrokeThickness;
                webLine.StrokeDashArray = new DoubleCollection(new double[] { 4, 4 });
                webLine.X1 = ticks1[i].Item1;
                webLine.Y1 = ticks1[i].Item2;
                webLine.X2 = ticks2[i].Item1;
                webLine.Y2 = ticks2[i].Item2;
                Canvas.Children.Add(webLine);
            }
        }
    }
}