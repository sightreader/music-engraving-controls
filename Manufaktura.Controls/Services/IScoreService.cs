using Manufaktura.Controls.Model;
using System.Collections.Generic;

namespace Manufaktura.Controls.Services
{
    public interface IScoreService
    {
        Clef CurrentClef { get; set; }

        Key CurrentKey { get; set; }

        int CurrentVoice { get; set; }
        IEnumerable<Measure> AllMeasures { get; }
        StaffSystem[] Systems { get; }

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

        void ReturnToFirstSystem();
    }
}