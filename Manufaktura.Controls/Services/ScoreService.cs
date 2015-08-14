using Manufaktura.Controls.Model;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Services
{
    public class ScoreService : IScoreService
    {
        private List<Measure> allMeasures = new List<Measure>();

        private List<StaffSystem> systems = new List<StaffSystem>();

        public IEnumerable<Measure> AllMeasures
        {
            get { return allMeasures; }
        }

        public Clef CurrentClef { get; set; }

        public Key CurrentKey { get; set; }

        public double[] CurrentLinePositions
        {
            get { return LinePositions[CurrentSystemNo, CurrentStaffNo]; }
        }

        public Measure CurrentMeasure { get; private set; }

        public int CurrentMeasureNo
        {
            get { return AllMeasures.Where(m => m.Staff == CurrentStaff).ToList().IndexOf(CurrentMeasure) + 1; }
        }

        public Score CurrentScore { get; private set; }

        public Staff CurrentStaff { get; private set; }

        public double CurrentStaffHeight
        {
            get
            {
                return LinePositions[CurrentSystemNo, CurrentStaffNo].Max() - LinePositions[CurrentSystemNo, CurrentStaffNo].Min();
            }
        }

        public int CurrentStaffNo
        {
            get { return CurrentScore.Staves.IndexOf(CurrentStaff) + 1; }
        }

        public StaffSystem CurrentSystem { get; private set; }

        public int CurrentSystemNo
        {
            get { return systems.IndexOf(CurrentSystem) + 1; }
        }

        public int CurrentVoice { get; set; }

        public double CursorPositionX { get; set; }

        public LineDictionary LinePositions { get; private set; }

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
            var measure = new Measure(CurrentStaff, CurrentSystem);
            allMeasures.Add(measure);
            CurrentMeasure = measure;
            if (CurrentMeasureNo <= CurrentStaff.MeasureWidths.Count && CurrentStaff.MeasureWidths[CurrentMeasureNo - 1].HasValue)
            {
                measure.Width = CurrentStaff.MeasureWidths[CurrentMeasureNo - 1].Value;
            }
        }

        /// <summary>
        /// Resets settings to begin a new score.
        /// </summary>
        /// <param name="score">Score</param>
        public void BeginNewScore(Score score)
        {
            CurrentScore = score;
            systems.Clear();
            allMeasures.Clear();
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
            var measureIndex = allMeasures.Where(m => m.Staff == measure.Staff).ToList().IndexOf(measure);
            var measuresInOthersStaff = allMeasures.Where(m => m.Staff == otherStaff).ToList();
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