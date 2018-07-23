using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Rendering.Charts
{
    public abstract class RadialChartRenderer<TControl, TCanvas>
    {
        public RadialChartRenderer(TControl control, TCanvas canvas)
        {
            Canvas = canvas;
            Control = control;
        }

        public TCanvas Canvas { get; private set; }
        public TControl Control { get; private set; }
        public Dictionary<RadialChartSample, double> SampleToAngleDictionary { get; } = new Dictionary<RadialChartSample, double>();
        protected abstract double CanvasHeight { get; }
        protected abstract double CanvasWidth { get; }

        public void DrawAxis(string axisName, double axisLength, double currentAngle)
        {
            var startPosition = new Primitives.Point(CanvasWidth / 2, CanvasHeight / 2);
            var endPosition = new Primitives.Point(startPosition.TranslateByAngle(currentAngle, axisLength).X, startPosition.TranslateByAngle(currentAngle, axisLength).Y);
            DrawAxisLine(startPosition, endPosition);
            DrawAxisLabel(endPosition, currentAngle, axisName);
        }
        public abstract void DrawPolygon(IEnumerable<Primitives.Point> innerPoints, IEnumerable<Primitives.Point> outerPoints);

        public abstract void DrawSamples(string axis, double lineLength, double currentAngle);

        public void DrawValueRangePolygon(RadialChartSample[] samples, double lineLength, double maxValue)
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
        protected abstract void DrawAxisLabel(Primitives.Point position, double currentAngle, string axisName);

        protected abstract void DrawAxisLine(Primitives.Point start, Primitives.Point end);
    }
}