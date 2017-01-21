using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using Manufaktura.Music.Model;
using System;

namespace Manufaktura.Controls.Rendering.Strategies.Slurs
{
    public class DefaultSlurRenderStrategy : SlurRenderStrategy
    {
        public DefaultSlurRenderStrategy(IMeasurementService measurementService, IScoreService scoreService) : base(measurementService, scoreService)
        {
        }

        public override bool IsRelevant(Note element)
        {
            return !element.Slur.IsDefinedAsBezierCurve;
        }

        protected override void ProcessSlurEnd(ScoreRendererBase renderer, Note element, double notePositionY, VerticalPlacement slurPlacement)
        {
            if (measurementService.SlurStartPlacement == VerticalPlacement.Above)
            {
                var xShiftConcerningStemDirectionStart = measurementService.SlurStartPointStemDirection == VerticalDirection.Up ? 10 : 1;
                var xShiftConcerningStemDirectionEnd = element.StemDirection == VerticalDirection.Up ? 5 : 1;
                var startPoint = new Point(measurementService.SlurStartPoint.X + xShiftConcerningStemDirectionStart, measurementService.SlurStartPoint.Y + (measurementService.SlurStartPointStemDirection == VerticalDirection.Up ? 26 : 16));
                var endPoint = new Point(scoreService.CursorPositionX + xShiftConcerningStemDirectionEnd, (element.StemDirection == VerticalDirection.Up ? element.StemEndLocation.Y + 8 + 13.5 : notePositionY + 18));
                var controlPoints = GetBezierControlPoints(startPoint, endPoint, measurementService.SlurStartPlacement);
                renderer.DrawBezier(startPoint, controlPoints.Item1, controlPoints.Item2, endPoint, element);
            }
            else if (measurementService.SlurStartPlacement == VerticalPlacement.Below)
            {
                var startPoint = new Point(measurementService.SlurStartPoint.X + 3, measurementService.SlurStartPoint.Y + 30);
                var endPoint = new Point(scoreService.CursorPositionX + 3, notePositionY + 30);
                var controlPoints = GetBezierControlPoints(startPoint, endPoint, measurementService.SlurStartPlacement);
                renderer.DrawBezier(startPoint, controlPoints.Item1, controlPoints.Item2, endPoint, element);
            }
        }

        protected override void ProcessSlurStart(ScoreRendererBase renderer, Note element, double notePositionY, VerticalPlacement slurPlacement)
        {
            measurementService.SlurStartPlacement = slurPlacement;
            measurementService.SlurStartPointStemDirection = element.StemDirection;
            if (slurPlacement == VerticalPlacement.Above)
                measurementService.SlurStartPoint = new Point(scoreService.CursorPositionX, element.StemDirection == VerticalDirection.Down ? notePositionY + 2 : element.StemEndLocation.Y + 7);
            else
                measurementService.SlurStartPoint = new Point(scoreService.CursorPositionX, notePositionY);
        }

        private static Tuple<Point, Point> GetBezierControlPoints(Point start, Point end, VerticalPlacement placement)
        {
            var factor = placement == VerticalPlacement.Above ? -1 : 1;
            var angle = UsefulMath.BeamAngle(start.X, start.Y, end.X, end.Y);
            var distance = Point.Distance(start, end);
            var control1 = new Point(start.X, start.Y + 15 * factor).TranslateHorizontallyAndMaintainAngle(angle, distance * 0.25);
            var control2 = new Point(start.X, start.Y + 15 * factor).TranslateHorizontallyAndMaintainAngle(angle, distance * 0.75);
            return new Tuple<Point, Point>(control1, control2);
        }
    }
}