using Manufaktura.Controls.Model;

namespace Manufaktura.Controls.Rendering.Strategies
{
    public interface IFinishingTouch
    {
        void PerformOnScore(Score score, ScoreRendererBase renderer);

        void PerformOnStaff(Staff staff, ScoreRendererBase renderer);
    }
}