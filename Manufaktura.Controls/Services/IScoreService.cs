using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Collections;
using Manufaktura.Controls.Rendering;

namespace Manufaktura.Controls.Services
{
	public interface IScoreService
	{
		Clef CurrentClef { get; set; }

		Key CurrentKey { get; set; }

		double[] CurrentLinePositions { get; }

		Measure CurrentMeasure { get; }

		int CurrentMeasureNo { get; }

		ScorePage CurrentPage { get; set; }

		Score CurrentScore { get; }

		Staff CurrentStaff { get; }

		double CurrentStaffHeight { get; }

		int CurrentStaffNo { get; }

		double CurrentStaffTop { get; }
		StaffSystem CurrentSystem { get; }

		int CurrentSystemNo { get; }

		int CurrentVoice { get; set; }

		double CursorPositionX { get; set; }

		LineDictionary LinePositions { get; }
		SystemCollection Systems { get; }

		void BeginNewMeasure();

		void BeginNewScore(Score score);

		void BeginNewStaff();

		void BeginNewSystem();

		Measure GetCorrespondingMeasure(Measure measure, Staff otherStaff);

		void MoveTo(Measure measure, ScoreRendererSettings rendererSettings);

		void ReturnToFirstSystem();
	}
}