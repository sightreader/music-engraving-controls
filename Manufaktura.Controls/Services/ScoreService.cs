using Manufaktura.Controls.Model;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Services
{
    public class ScoreService : IScoreService
    {

        private List<StaffSystem> systems = new List<StaffSystem>();


        /// <summary>
        /// Current clef.
        /// </summary>
        public Clef CurrentClef { get; set; }

        /// <summary>
        /// Current key.
        /// </summary>
        public Key CurrentKey { get; set; }

        public double[] CurrentLinePositions
        {
            get { return LinePositions[CurrentSystemNo, CurrentStaffNo]; }
        }

        /// <summary>
        /// Current measure.
        /// </summary>
        public Measure CurrentMeasure { get; private set; }

        /// <summary>
        /// Current measure number.
        /// </summary>
        public int CurrentMeasureNo
        {
            get { return CurrentStaff.Measures.IndexOf(CurrentMeasure) + 1; }
        }

        /// <summary>
        /// Current score.
        /// </summary>
        public Score CurrentScore { get; private set; }

        /// <summary>
        /// Current staff.
        /// </summary>
        public Staff CurrentStaff { get; private set; }

        /// <summary>
        /// Current staff height.
        /// </summary>
        public double CurrentStaffHeight
        {
            get
            {
                return LinePositions[CurrentSystemNo, CurrentStaffNo].Max() - LinePositions[CurrentSystemNo, CurrentStaffNo].Min();
            }
        }

        /// <summary>
        /// Current staff number.
        /// </summary>
        public int CurrentStaffNo
        {
            get { return CurrentScore.Staves.IndexOf(CurrentStaff) + 1; }
        }

        /// <summary>
        /// Current system.
        /// </summary>
        public StaffSystem CurrentSystem { get; private set; }

        /// <summary>
        /// Current system number.
        /// </summary>
        public int CurrentSystemNo
        {
            get { return systems.IndexOf(CurrentSystem) + 1; }
        }

        /// <summary>
        /// Current voice.
        /// </summary>
        public int CurrentVoice { get; set; }

        /// <summary>
        /// Current horizontal cursor position.
        /// </summary>
        public double CursorPositionX { get; set; }

        /// <summary>
        /// Dictionary of line positions in the score.
        /// </summary>
        public LineDictionary LinePositions { get; private set; }

        /// <summary>
        /// All systems in the score.
        /// </summary>
        public StaffSystem[] Systems
        {
            get { return systems.ToArray(); }
        }

        public ScoreService()
        {
            LinePositions = new LineDictionary();
            CurrentClef = new Clef(ClefType.CClef, 2);
            CurrentKey = new Key(0);
            CurrentVoice = 1;
        }

        /// <summary>
        /// Begins new measure.
        /// </summary>
        public void BeginNewMeasure()
        {
            if (CurrentMeasure == null) CurrentMeasure = CurrentStaff.Measures.First();
            else if (CurrentStaff.Measures.IndexOf(CurrentMeasure) + 1 >= CurrentStaff.Measures.Count) return;
            else CurrentMeasure = CurrentStaff.Measures[CurrentStaff.Measures.IndexOf(CurrentMeasure) + 1];

            if (CurrentMeasureNo <= CurrentStaff.Measures.Count && CurrentStaff.Measures[CurrentMeasureNo - 1].Width.HasValue)
            {
                CurrentMeasure.Width = CurrentStaff.Measures[CurrentMeasureNo - 1].Width.Value;
            }
        }

        /// <summary>
        /// Resets settings to begin a new score.
        /// </summary>
        /// <param name="score">Score</param>
        public void BeginNewScore(Score score)
        {
            CurrentScore = score;
            CurrentStaff = null;
            CurrentMeasure = null;
            CurrentClef = null;
            CurrentKey = null;
            systems.Clear();
            LinePositions.Clear();
        }

        /// <summary>
        /// Begins a new staff.
        /// </summary>
        public void BeginNewStaff()
        {
            if (!systems.Any()) BeginNewSystem();
            CurrentSystem = systems.First();

            if (CurrentStaff == null)
            {
                CurrentStaff = CurrentScore.Staves.FirstOrDefault();
                BeginNewMeasure();
                return;
            }

            var currentStaffIndex = CurrentScore.Staves.IndexOf(CurrentStaff);
            if (currentStaffIndex == CurrentScore.Staves.Count - 1)
            {
                CurrentStaff = null;
                return;
            }
            CurrentStaff = CurrentScore.Staves[currentStaffIndex + 1];
            BeginNewMeasure();
        }

        /// <summary>
        /// Begins a new system.
        /// </summary>
        public void BeginNewSystem()
        {
            var currentSystemIndex = systems.IndexOf(CurrentSystem);
            if (currentSystemIndex == systems.Count - 1)
            {
                var newSystem = new StaffSystem();
                systems.Add(newSystem);
                CurrentSystem = newSystem;
                return;
            }
            CurrentSystem = systems[currentSystemIndex + 1];
        }

        /// <summary>
        /// Searches for the corresponding measure (a measure with the same measure number) in other staff.
        /// </summary>
        /// <param name="measure">Examined measure</param>
        /// <param name="otherStaff">Searched staff</param>
        /// <returns>Corresponding measure</returns>
        public Measure GetCorrespondingMeasure(Measure measure, Staff otherStaff)
        {
            var measureIndex = measure.Staff.Measures.IndexOf(measure);
            var measuresInOthersStaff = otherStaff.Measures;
            if (measuresInOthersStaff.Count <= measureIndex) return null;
            return measuresInOthersStaff[measureIndex];
        }

        /// <summary>
        /// Resets CurrentSystem to first system.
        /// </summary>
        public void ReturnToFirstSystem()
        {
            CurrentSystem = systems.FirstOrDefault();
        }
    }
}