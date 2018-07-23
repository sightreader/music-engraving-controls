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

        public Dictionary<Ellipse, RadialChartSample> SampleDictionary { get; } = new Dictionary<Ellipse, RadialChartSample>();
        protected override double CanvasHeight => Canvas.ActualHeight;
        protected override double CanvasWidth => Canvas.ActualWidth;

        public override void DrawSamples(string axis, double lineLength, double currentAngle)
        {
            var axisSamples = Control.Samples.Where(s => s.AxisShortName == axis);
            foreach (var sample in axisSamples)
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
                SampleToAngleDictionary.Add(sample, currentAngle);

                var valueLength = sample.Value * sample.Scale * lineLength / Control.MaxValue;
                var dx = valueLength * Math.Sin(currentAngle);
                var dy = valueLength * Math.Cos(currentAngle);
                Canvas.SetLeft(ellipse, CanvasWidth / 2 + dx - ellipse.Width / 2);
                Canvas.SetTop(ellipse, CanvasHeight / 2 + dy - ellipse.Height / 2);
                Canvas.Children.Add(ellipse);
            }
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
    }
}