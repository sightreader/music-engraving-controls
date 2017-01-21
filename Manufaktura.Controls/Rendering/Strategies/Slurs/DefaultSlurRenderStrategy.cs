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
            Point endPoint;
            if (measurementService.SlurStartPlacement == VerticalPlacement.Above)
            {
                var xShiftConcerningStemDirectionEnd = element.StemDirection == VerticalDirection.Up ? 5 : 1;
                endPoint = new Point(scoreService.CursorPositionX + xShiftConcerningStemDirectionEnd, (element.StemDirection == VerticalDirection.Up ? element.StemEndLocation.Y + 25 : notePositionY + 18));
            }
            else if (measurementService.SlurStartPlacement == VerticalPlacement.Below)
            {
                endPoint = new Point(scoreService.CursorPositionX + 3, notePositionY + 30);
            }
            else throw new Exception("Unsupported placement type.");

            var controlPoints = GetBezierControlPoints(measurementService.SlurStartPoint, endPoint, measurementService.SlurStartPlacement, DetermineSlurHeight());
            renderer.DrawBezier(measurementService.SlurStartPoint, controlPoints.Item1, controlPoints.Item2, endPoint, element);
            controlPoints = GetBezierControlPoints(measurementService.SlurStartPoint, endPoint, measurementService.SlurStartPlacement, DetermineSlurHeight() + 1);
            renderer.DrawBezier(measurementService.SlurStartPoint, controlPoints.Item1, controlPoints.Item2, endPoint, element);
            controlPoints = GetBezierControlPoints(measurementService.SlurStartPoint, endPoint, measurementService.SlurStartPlacement, DetermineSlurHeight() + 2);
            renderer.DrawBezier(measurementService.SlurStartPoint, controlPoints.Item1, controlPoints.Item2, endPoint, element);

            //DrawSlurFrame(renderer, startPoint, controlPoints.Item1, controlPoints.Item2, endPoint, element);
        }

        protected override void ProcessSlurStart(ScoreRendererBase renderer, Note element, double notePositionY, VerticalPlacement slurPlacement)
        {
            measurementService.SlurStartPlacement = slurPlacement;
            measurementService.SlurStartPointStemDirection = element.StemDirection;
            if (slurPlacement == VerticalPlacement.Above)
            {
                var xShiftConcerningStemDirectionStart = measurementService.SlurStartPointStemDirection == VerticalDirection.Up ? 10 : 1;
                measurementService.SlurStartPoint = new Point(scoreService.CursorPositionX + xShiftConcerningStemDirectionStart, element.StemDirection == VerticalDirection.Down ? notePositionY + 18 : element.StemEndLocation.Y + 33);
            }
            else
                measurementService.SlurStartPoint = new Point(scoreService.CursorPositionX + 3, notePositionY + 30);
        }

        private static double DetermineSlurHeight()
        {
            return 10;
        }

        private static Tuple<Point, Point> GetBezierControlPoints(Point start, Point end, VerticalPlacement placement, double height)
        {
            var factor = placement == VerticalPlacement.Above ? -1 : 1;
            var angle = UsefulMath.BeamAngle(start.X, start.Y, end.X, end.Y);
            var angle2 = angle + (Math.PI / 2) * factor;
            var distance = Point.Distance(start, end);
            var startPointForControlPoints = start.TranslateByAngleOld(angle2, height);
            var control1 = startPointForControlPoints.TranslateByAngleOld(angle, distance * 0.25);
            var control2 = startPointForControlPoints.TranslateByAngleOld(angle, distance * 0.75);
            return new Tuple<Point, Point>(control1, control2);
        }
        /// <summary>
        /// For debug purposes. It will be used in slur edit mode in the future.
        /// </summary>
        private void DrawSlurFrame(ScoreRendererBase renderer, Point p1, Point p2, Point p3, Point p4, MusicalSymbol owner)
        {
            renderer.DrawLine(p1, p2, owner);
            renderer.DrawLine(p2, p3, owner);
            renderer.DrawLine(p3, p4, owner);
            renderer.DrawLine(p4, p1, owner);
        }
    }
}