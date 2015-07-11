using Manufaktura.Controls.Model;
using System.Collections.Generic;

namespace Manufaktura.Controls.Services
{
    public interface IScoreService
    {
        IEnumerable<Measure> AllMeasures { get; }

        double[] CurrentLinePositions { get; }

        Measure CurrentMeasure { get; }

        int CurrentMeasureNo { get; }

        Score CurrentScore { get; }

        Staff CurrentStaff { get; }

        double CurrentStaffHeight { get; }

        int CurrentStaffNo { get; }

        StaffSystem CurrentSystem { get; }

        int CurrentSystemNo { get; }

        LineDictionary LinePositions { get; }

        void BeginNewMeasure();

        void BeginNewScore(Score score);

        void BeginNewStaff();

        void BeginNewSystem();
    }
}