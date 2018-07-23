namespace Manufaktura.Controls.Rendering.Charts
{
    public abstract class RadialChartRenderer<TControl, TCanvas>
    {
        public TControl Control { get; private set; }
        public TCanvas Canvas { get; private set; }

        public RadialChartRenderer(TControl control, TCanvas canvas)
        {
            Canvas = canvas;
            Control = control;
        }

        protected abstract double CanvasWidth { get; }
        protected abstract double CanvasHeight { get; }

        public void DrawAxis(string axisName, double axisLength, double currentAngle)
        {
            var startPosition = new Primitives.Point(CanvasWidth / 2, CanvasHeight / 2);
            var endPosition = new Primitives.Point(startPosition.TranslateByAngle(currentAngle, axisLength).X, startPosition.TranslateByAngle(currentAngle, axisLength).Y);
            DrawAxisLine(startPosition, endPosition);
            DrawAxisLabel(endPosition, currentAngle, axisName);
        }

        protected abstract void DrawAxisLine(Primitives.Point start, Primitives.Point end);

        protected abstract void DrawAxisLabel(Primitives.Point position, double currentAngle, string axisName);
    }
}