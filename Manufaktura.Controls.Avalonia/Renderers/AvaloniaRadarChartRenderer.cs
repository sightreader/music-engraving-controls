﻿/*
Copyright 2019 Manufaktura Programów Jacek Salamon
Website: http://musicengravingcontrols.com/
Patreon: https://www.patreon.com/jacek_salamon

MIT LICENCE

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

namespace Manufaktura.Controls.Avalonia.Renderers
{
    /*public class AvaloniaRadarChartRenderer : RadarChartRenderer<RadialChart, Canvas>
    {
        public AvaloniaRadarChartRenderer(RadialChart control, Canvas canvas) : base(control, canvas)
        {
        }

        public Dictionary<Ellipse, double> AngleDictionary { get; } = new Dictionary<Ellipse, double>();

        protected override double MaxValue => Control.MaxValue;
        protected override int NumberOfTicks => Control.NumberOfTicks;
        public Dictionary<Ellipse, RadarChartSample> SampleDictionary { get; } = new Dictionary<Ellipse, RadarChartSample>();
        protected override double CanvasHeight => Canvas.ActualHeight;
        protected override double CanvasWidth => Canvas.ActualWidth;

        protected override void ClearCanvas()
        {
            AngleDictionary.Clear();
            SampleDictionary.Clear();
            Canvas.Children.Clear();
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

        protected override void DrawPolygon(IEnumerable<Primitives.Point> innerPoints, IEnumerable<Primitives.Point> outerPoints)
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
        protected override void DrawSample(RadarChartSample sample, double dx, double dy, double currentAngle)
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

            Canvas.SetLeft(ellipse, dx - Control.SamplePointDiameter / 2);
            Canvas.SetTop(ellipse, dy - Control.SamplePointDiameter / 2);
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

        protected override void DrawWebLine(Primitives.Point p1, Primitives.Point p2)
        {
            var webLine = new Line
            {
                Stroke = Control.WeblineStroke,
                StrokeThickness = Control.WeblineStrokeThickness,
                StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }),
                X1 = p1.X,
                Y1 = p1.Y,
                X2 = p2.X,
                Y2 = p2.Y
            };
            Canvas.Children.Add(webLine);
        }
    }*/
}