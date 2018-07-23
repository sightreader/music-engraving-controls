using Manufaktura.Controls.Rendering.Charts;
using System;
using System.Globalization;
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

        protected override double CanvasWidth => Canvas.ActualWidth;

        protected override double CanvasHeight => Canvas.ActualHeight;

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