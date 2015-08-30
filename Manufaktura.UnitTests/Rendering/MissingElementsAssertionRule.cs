using Manufaktura.UnitTests.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.UnitTests.Rendering
{
    public class MissingElementsAssertionRule : IRenderingAssertionRule
    {
        public Dictionary<ScoreRenderingTestEntry, List<string>> Assert(IScoreRenderingTestResultsRepository currentResults, IScoreRenderingTestResultsRepository previousResults)
        {
            var results = new Dictionary<ScoreRenderingTestEntry, List<string>>();
            foreach (var previousResultsGrouped in previousResults.GroupBy(r => new { r.StaffIndex, r.StaffNo, r.Type }))
            {
                var currentCount = currentResults.Count(cr => cr.StaffIndex == previousResultsGrouped.Key.StaffIndex &&
                    cr.StaffNo == previousResultsGrouped.Key.StaffNo &&
                    cr.Type == previousResultsGrouped.Key.Type);
                var previousCount = previousResults.Count(cr => cr.StaffIndex == previousResultsGrouped.Key.StaffIndex &&
                    cr.StaffNo == previousResultsGrouped.Key.StaffNo &&
                    cr.Type == previousResultsGrouped.Key.Type);
                if (currentCount < previousCount)
                {
                    if (!results.ContainsKey(previousResultsGrouped.First())) results.Add(previousResultsGrouped.First(), new List<string>());
                    results[previousResultsGrouped.First()].Add(string.Format("Some graphic elements of {0} at index {1} on staff {2} are missing.",
                        previousResultsGrouped.Key.Type,
                        previousResultsGrouped.Key.StaffIndex, previousResultsGrouped.Key.StaffNo));
                }
            }
            return results;
        }
    }
}