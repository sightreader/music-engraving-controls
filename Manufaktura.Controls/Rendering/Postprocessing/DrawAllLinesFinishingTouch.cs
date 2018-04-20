using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
    /// <summary>
    /// Draws lines of the staff
    /// </summary>
    public class DrawAllLinesFinishingTouch : IFinishingTouch
    {
        private readonly IScoreService scoreService;

        public DrawAllLinesFinishingTouch(IScoreService scoreService)
        {
            this.scoreService = scoreService;
        }

        /// <summary>
        /// This method does nothing in this implementation of IFinishingTouch.
        /// </summary>
        /// <param name="measure">Measure</param>
        /// <param name="renderer">Score renderer</param>
        public void PerformOnMeasure(Measure measure, ScoreRendererBase renderer)
        {
        }

        public void PerformOnScore(Score score, ScoreRendererBase renderer)
        {
        }

        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
        {
            var staffLinePen = renderer.CreatePenFromDefaults(staff, "staffLineThickness", s => s.DefaultStaffLineThickness);
            staffLinePen.ZIndex = -1;

            foreach (var system in scoreService.Systems)
            {
                if (system.LinePositions == null) continue;
                var staffFragment = system.Staves[scoreService.CurrentStaffNo - 1];
                Draw(staff, renderer, staffFragment, system, staffLinePen);
            }
        }

        private void Draw(Staff staff, ScoreRendererBase renderer, StaffFragment staffFragment, StaffSystem system, Pen staffLinePen)
        {
            renderer.DrawLine(0, staffFragment.LinePositions[0], 0, staffFragment.LinePositions[4], staffLinePen, staffFragment);

            var lastMeasureInSystem = staff.Measures.LastOrDefault(m => m.System == system);
            var endPositionX = lastMeasureInSystem?.BarlineLocationX ?? system.Width;
            if (endPositionX == 0) endPositionX = system.Width;

            if (renderer.Settings.RenderingMode != ScoreRenderingModes.Panorama)
                endPositionX = ExtendXPositionForMemoElements(endPositionX, lastMeasureInSystem, staff, system);

            foreach (double linePositionY in staffFragment.LinePositions)
            {
                Point startPoint = new Point(0, linePositionY);
                Point endPoint = new Point(endPositionX, linePositionY);
                renderer.DrawLine(startPoint, endPoint, staffLinePen, staffFragment);
            }
        }

        /// <summary>
        /// Extends lines for clefs, keys and time signatures at the end of the system (which are actually members of the next measure)
        /// </summary>
        /// <param name="endPositionX"></param>
        /// <param name="lastMeasureInSystem"></param>
        /// <param name="staff"></param>
        /// <param name="system"></param>
        /// <returns></returns>
        private double ExtendXPositionForMemoElements(double endPositionX, Measure lastMeasureInSystem, Staff staff, StaffSystem system)
        {
            var elementWidth = 12;  //TODO: Pobrać prawdziwą szerokość

            var nextMeasure = lastMeasureInSystem == null ? null : staff.Measures.ElementAtOrDefault(staff.Measures.IndexOf(lastMeasureInSystem) + 1);
            if (nextMeasure != null)    //Wydłuż linie, jeśli są na końcu taktu nowe znaki przykluczowe lub nowe metrum
            {
                var elementsWithPosition = nextMeasure.Elements.OfType<IRenderedAsTextBlock>().Where(e => e is Clef || e is TimeSignature || e is Key);
                var memoElementPositionX = !elementsWithPosition.Any() ? 0 : elementsWithPosition.Max(e => e.TextBlockLocation.X);
                if (endPositionX < memoElementPositionX + elementWidth) endPositionX = memoElementPositionX + elementWidth;
            }

            return endPositionX;
        }
    }
}