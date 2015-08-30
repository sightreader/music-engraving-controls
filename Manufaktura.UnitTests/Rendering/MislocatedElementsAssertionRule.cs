using Manufaktura.UnitTests.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.UnitTests.Rendering
{
    public class MislocatedElementsAssertionRule : IRenderingAssertionRule
    {
        public Dictionary<ScoreRenderingTestEntry, List<string>> Assert(IScoreRenderingTestResultsRepository currentResults, IScoreRenderingTestResultsRepository previousResults)
        {
            var results = new Dictionary<ScoreRenderingTestEntry, List<string>>();
            foreach (var previousResultsGrouped in previousResults.GroupBy(r => new { r.StaffIndex, r.StaffNo, r.Type }))
            {
                var currentElements = currentResults.Where(cr => cr.StaffIndex == previousResultsGrouped.Key.StaffIndex &&
                    cr.StaffNo == previousResultsGrouped.Key.StaffNo &&
                    cr.Type == previousResultsGrouped.Key.Type).ToArray();

                var currentCount = currentElements.Length;
                var previousCount = previousResults.Count(cr => cr.StaffIndex == previousResultsGrouped.Key.StaffIndex &&
                    cr.StaffNo == previousResultsGrouped.Key.StaffNo &&
                    cr.Type == previousResultsGrouped.Key.Type);

                if (currentCount != previousCount) continue;

                var previousResultsArray = previousResultsGrouped.ToArray();
                for (var i = 0; i < previousResultsArray.Length; i++)
                {
                    var locationXRatio = currentElements[i].Location.X / previousResultsArray[i].Location.X;
                    var locationYRatio = currentElements[i].Location.Y / previousResultsArray[i].Location.Y;
                    var fieldRatio = (currentElements[i].Size.X * currentElements[i].Size.Y) / (previousResultsArray[i].Size.X * previousResultsArray[i].Size.Y);
                    if (locationXRatio > 1.3 || locationXRatio < 0.7 || locationYRatio > 1.3 || locationYRatio < 0.7 || fieldRatio > 1.3 || fieldRatio < 0.7)
                    {
                        if (!results.ContainsKey(previousResultsGrouped.First())) results.Add(previousResultsGrouped.First(), new List<string>());
                        results[previousResultsGrouped.First()].Add(string.Format("Element {0} at index {1} on staff {2} might be mislocated.",
                            previousResultsGrouped.Key.Type,
                            previousResultsGrouped.Key.StaffIndex, previousResultsGrouped.Key.StaffNo));
                    }
                    
                }
                
            }
            return results;
        }
    }
}
