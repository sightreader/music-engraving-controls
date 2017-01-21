using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using Manufaktura.Music.Model;
using System;
using System.Linq;

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

            var slurHeight = DetermineSlurHeight(element, endPoint);
            for (int i = 0; i < 3; i++) //Draw a few curves one by one to simulate a curve with variable thickness. It will be replaced by a path in future releases.
            {
                var controlPoints = GetBezierControlPoints(measurementService.SlurStartPoint, endPoint, measurementService.SlurStartPlacement, slurHeight + i);
                renderer.DrawBezier(measurementService.SlurStartPoint, controlPoints.Item1, controlPoints.Item2, endPoint, element);
            }

            //DrawSlurFrame(renderer, startPoint, controlPoints.Item1, controlPoints.Item2, endPoint, element);
        }

        protected override void ProcessSlurStart(ScoreRendererBase renderer, Note element, double notePositionY, VerticalPlacement slurPlacement)
        {
            measurementService.SlurStartPlacement = slurPlacement;
            measurementService.SlurStartPointStemDirection = element.StemDirection;
            if (slurPlacement == VerticalPlacement.Above)
            {
                bool hasFlagOrBeam = element.BaseDuration.Denominator > 4;  //If note has a flag or beam start the slur above the note. If not, start a bit to the right and down.
                var xShiftConcerningStemDirectionStart = measurementService.SlurStartPointStemDirection == VerticalDirection.Up ? (hasFlagOrBeam ? 5 : 10) : 1;
                measurementService.SlurStartPoint = new Point(scoreService.CursorPositionX + xShiftConcerningStemDirectionStart, element.StemDirection == VerticalDirection.Down ? notePositionY + 18 : element.StemEndLocation.Y + (hasFlagOrBeam ? 22 : 33));
            }
            else
                measurementService.SlurStartPoint = new Point(scoreService.CursorPositionX + 3, notePositionY + 30);
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
        /// Calculates slur height trying to avoid collisions with stems
        /// </summary>
        /// <param name="note"></param>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        private double DetermineSlurHeight(Note note, Point endPoint)
        {
            var notesUnderSlur = note.Staff.EnumerateUntilConditionMet<Note>(note, n => n.Slur?.Type == NoteSlurType.Start, true).ToArray();
            if (notesUnderSlur.Length < 3) return 10;

            var mostExtremePoint = ((measurementService.SlurStartPlacement == VerticalPlacement.Above) ?
                notesUnderSlur.First(n => n.StemEndLocation.Y == notesUnderSlur.Take(notesUnderSlur.Length - 1).Skip(1).Min(nus => nus.StemEndLocation.Y)) :
                notesUnderSlur.First(n => n.StemEndLocation.Y == notesUnderSlur.Take(notesUnderSlur.Length - 1).Skip(1).Max(nus => nus.StemEndLocation.Y))).StemEndLocation;

            var angle = UsefulMath.BeamAngle(measurementService.SlurStartPoint.X, measurementService.SlurStartPoint.Y, endPoint.X, endPoint.Y);
            var slurYPositionInMostExtremePoint = measurementService.SlurStartPoint.TranslateHorizontallyAndMaintainAngle(angle, mostExtremePoint.X - measurementService.SlurStartPoint.X).Y;
            var mostExtremeYPosition = mostExtremePoint.Y + 25;
            if (measurementService.SlurStartPlacement == VerticalPlacement.Above && mostExtremeYPosition < slurYPositionInMostExtremePoint) return Math.Abs(mostExtremeYPosition - slurYPositionInMostExtremePoint) + 10;
            if (measurementService.SlurStartPlacement == VerticalPlacement.Below && mostExtremeYPosition > slurYPositionInMostExtremePoint) return Math.Abs(slurYPositionInMostExtremePoint - mostExtremeYPosition) + 10;

            return 10;
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