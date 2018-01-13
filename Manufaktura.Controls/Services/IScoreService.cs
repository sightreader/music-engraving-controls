using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;

namespace Manufaktura.Controls.Services
{
    /// <summary>
    /// Service that stores temporary information during score rendering
    /// </summary>
	public interface IScoreService
	{
        /// <summary>
        /// Current clef
        /// </summary>
		Clef CurrentClef { get; set; }

        /// <summary>
        /// Current key
        /// </summary>
		Key CurrentKey { get; set; }

        /// <summary>
        /// Current line positions
        /// </summary>
		double[] CurrentLinePositions { get; }

        /// <summary>
        /// Current measure
        /// </summary>
		Measure CurrentMeasure { get; }

        /// <summary>
        /// Current measure number
        /// </summary>
		int CurrentMeasureNo { get; }

        /// <summary>
        /// Current page
        /// </summary>
		ScorePage CurrentPage { get; set; }

        /// <summary>
        /// Current score
        /// </summary>
		Score CurrentScore { get; }

        /// <summary>
        /// Current staff
        /// </summary>
		Staff CurrentStaff { get; }

        /// <summary>
        /// Current staff height
        /// </summary>
		double CurrentStaffHeight { get; }

        /// <summary>
        /// Current staff number
        /// </summary>
		int CurrentStaffNo { get; }

        /// <summary>
        /// Current staff Y position
        /// </summary>
        double CurrentStaffTop { get; }
        /// <summary>
        /// Current system
        /// </summary>
		StaffSystem CurrentSystem { get; }

        /// <summary>
        /// Current system number
        /// </summary>
		int CurrentSystemNo { get; }

        /// <summary>
        /// Current voice number
        /// </summary>
		int CurrentVoice { get; set; }

        /// <summary>
        /// Current cursor position X - position where the next note will be rendered
        /// </summary>
		double CursorPositionX { get; set; }

        /// <summary>
        /// Staff line positions
        /// </summary>
		LineDictionary LinePositions { get; }

        /// <summary>
        /// All systems in the score.
        /// </summary>
        IList<StaffSystem> Systems { get; }

        /// <summary>
        /// Begins a new measure. Performs specific logic connected with beginning a new measure.
        /// </summary>
		void BeginNewMeasure();

        /// <summary>
        /// Begins a new score.
        /// </summary>
        /// <param name="score"></param>
		void BeginNewScore(Score score);

        /// <summary>
        /// Begins a new staff.
        /// </summary>
		void BeginNewStaff();

		void BeginNewSystem();

		Measure GetCorrespondingMeasure(Measure measure, Staff otherStaff);

		void MoveTo(Measure measure, ScoreRendererSettings rendererSettings);

		void ReturnToFirstSystem();
	}
}