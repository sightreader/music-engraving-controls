using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Charts
{
    public abstract class RadialChartRenderer<TControl, TCanvas>
    {
        public RadialChartRenderer(TControl control, TCanvas canvas)
        {
            Canvas = canvas;
            Control = control;
        }

        public double CalculatedMaxLineLength { get; private set; } = 0;
        public TCanvas Canvas { get; private set; }
        public TControl Control { get; private set; }
        public Dictionary<RadialChartSample, double> SampleToAngleDictionary { get; } = new Dictionary<RadialChartSample, double>();
        protected abstract double CanvasHeight { get; }
        protected abstract double CanvasWidth { get; }
        protected abstract double MaxValue { get; }
        protected abstract int NumberOfTicks { get; }
        public abstract void ClearCanvas();

        public abstract void DrawPolygon(IEnumerable<Primitives.Point> innerPoints, IEnumerable<Primitives.Point> outerPoints);

        public void RedrawChart(RadialChartSample[] samples)
        {
            SampleToAngleDictionary.Clear();
            ClearCanvas();
            if (samples == null || !samples.Any()) return;

            var axes = samples.Select(s => s.AxisShortName).ToArray();
            var currentAngle = 0d;
            var angleChange = (2 * Math.PI) / axes.Length;
            var lineLength = CanvasHeight < CanvasWidth ? CanvasHeight / 2 : CanvasWidth / 2;
            CalculatedMaxLineLength = lineLength;

            List<Tuple<double, double>> previousTicks = null;
            List<Tuple<double, double>> firstTicks = null;
            foreach (var axis in axes)
            {
                DrawAxis(axis, lineLength, currentAngle);

                var ticks = CalculateTicks(axis, currentAngle, lineLength, axes.Length < 3);
                if (axes.Length > 2)
                {
                    if (firstTicks == null) firstTicks = new List<Tuple<double, double>>(ticks);
                    if (previousTicks != null) DrawWebLines(previousTicks, ticks);
                    previousTicks = ticks;
                }

                DrawSamples(axis, lineLength, currentAngle);

                currentAngle += angleChange;
            }
            if (axes.Length > 2) DrawWebLines(firstTicks, previousTicks);

            DrawValueRangePolygon(samples, lineLength, MaxValue);
            DrawValueCompartmentsPolygons(lineLength);
        }

        protected abstract void DrawAxisLabel(Primitives.Point position, double currentAngle, string axisName);

        protected abstract void DrawAxisLine(Primitives.Point start, Primitives.Point end);

        protected abstract void DrawSamples(string axis, double lineLength, double currentAngle);

        protected abstract void DrawTick(double x1, double y1, double x2, double y2);

        protected abstract void DrawValueCompartmentsPolygons(double lineLength);

        protected abstract void DrawWebLines(List<Tuple<double, double>> ticks1, List<Tuple<double, double>> ticks2);

        private List<Tuple<double, double>> CalculateTicks(string axis, double currentAngle, double lineLength, bool alsoDraw)
        {
            var ticks = new List<Tuple<double, double>>();
            for (int i = 0; i < NumberOfTicks; i++)
            {
                var tickOffset = (lineLength / NumberOfTicks) * (i + 1);
                var tickLocation = new Primitives.Point(CanvasWidth / 2, CanvasHeight / 2).TranslateByAngle(currentAngle, tickOffset);
                ticks.Add(new Tuple<double, double>(tickLocation.X + 0.5, tickLocation.Y + 0.5));

                if (alsoDraw) DrawTick(tickLocation.X, tickLocation.Y, tickLocation.TranslateByAngle(currentAngle, 1).X, tickLocation.TranslateByAngle(currentAngle, 1).Y);
            }
            return ticks;
        }
        private void DrawAxis(string axisName, double axisLength, double currentAngle)
        {
            var startPosition = new Primitives.Point(CanvasWidth / 2, CanvasHeight / 2);
            var endPosition = new Primitives.Point(startPosition.TranslateByAngle(currentAngle, axisLength).X, startPosition.TranslateByAngle(currentAngle, axisLength).Y);
            DrawAxisLine(startPosition, endPosition);
            DrawAxisLabel(endPosition, currentAngle, axisName);
        }
        private void DrawValueRangePolygon(RadialChartSample[] samples, double lineLength, double maxValue)
        {
            var innerPoints = new List<Primitives.Point>();
            var outerPoints = new List<Primitives.Point>();
            foreach (var sample in samples)
            {
                var currentAngle = SampleToAngleDictionary[sample];

                var valueLength = sample.ValidationMaxValue * sample.Scale * lineLength / maxValue;
                var dx = valueLength * Math.Sin(currentAngle);
                var dy = valueLength * Math.Cos(currentAngle);
                outerPoints.Add(new Primitives.Point(CanvasWidth / 2 + dx, CanvasHeight / 2 + dy));

                valueLength = sample.ValidationMinValue * sample.Scale * lineLength / maxValue;
                dx = valueLength * Math.Sin(currentAngle);
                dy = valueLength * Math.Cos(currentAngle);
                innerPoints.Add(new Primitives.Point(CanvasWidth / 2 + dx, CanvasHeight / 2 + dy));
            }

            DrawPolygon(innerPoints, outerPoints);
        }
    }
}