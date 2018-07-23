/*
Copyright 2018 Manufaktura Programów Jacek Salamon
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

using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering.Charts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class HtmSvgRadialChartRenderer : RadialChartRenderer<object, StringBuilder>
    {
        public HtmSvgRadialChartRenderer(object control, StringBuilder canvas) : base(control, canvas)
        {
        }

        protected override double CanvasHeight => throw new NotImplementedException();

        protected override double CanvasWidth => throw new NotImplementedException();

        protected override double MaxValue => throw new NotImplementedException();

        protected override int NumberOfTicks => throw new NotImplementedException();

        public override void ClearCanvas()
        {
            throw new NotImplementedException();
        }

        public override void DrawPolygon(IEnumerable<Point> innerPoints, IEnumerable<Point> outerPoints)
        {
            throw new NotImplementedException();
        }

        protected override void DrawAxisLabel(Point position, double currentAngle, string axisName)
        {
            throw new NotImplementedException();
        }

        protected override void DrawAxisLine(Point start, Point end)
        {
            throw new NotImplementedException();
        }

        protected override void DrawSample(RadialChartSample sample, double dx, double dy, double currentAngle)
        {
            throw new NotImplementedException();
        }

        protected override void DrawTick(double x1, double y1, double x2, double y2)
        {
            throw new NotImplementedException();
        }

        protected override void DrawValueCompartmentsPolygons(double lineLength)
        {
            throw new NotImplementedException();
        }

        protected override void DrawWebLines(List<Tuple<double, double>> ticks1, List<Tuple<double, double>> ticks2)
        {
            throw new NotImplementedException();
        }
    }
}