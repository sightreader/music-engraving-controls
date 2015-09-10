using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using Manufaktura.Music.Xml;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class PrintSuggestionParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "print"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            PrintSuggestion suggestion = null;
            if (staff.Part != null && staff.Part.Staves.Any())  //If part contains many staves, add to all staves
            {
                foreach (var s in staff.Part.Staves)
                {
                    suggestion = CreateSuggestion(element, state);
                    s.Elements.Add(suggestion);
                }
            }
            else
            {
                suggestion = CreateSuggestion(element, state);
                staff.Elements.Add(suggestion);
            }

            if (suggestion.IsPageBreak)
            {
                var page = new ScorePage();
                staff.Score.Pages.Add(page);
            }
            if (suggestion.IsSystemBreak)
            {
                var system = new StaffSystem(staff.Score);
                staff.Score.Pages.Last().Systems.Add(system);
                staff.Measures.Last().System = system;
                staff.Score.Systems.Add(system);
                if (staff.Part != null && staff.Part.Staves.Any())  //If part contains many staves, add to all staves
                {
                    foreach (var s in staff.Part.Staves)
                    {
                        s.Measures.Last().System = system;
                    }
                }
            }
        }

        private PrintSuggestion CreateSuggestion(XElement element, MusicXmlParserState state)
        {
            PrintSuggestion suggestion = new PrintSuggestion();

            element.IfAttribute("new-system").HasValue("yes").Then(() => suggestion.IsSystemBreak = true);
            element.IfAttribute("new-page").HasValue("yes").Then(() => suggestion.IsPageBreak = true);
            if (suggestion.IsPageBreak) suggestion.IsSystemBreak = true;    //Page breaks are treated as system breaks. Manufaktura.Controls currently doesn't support page breaks.

            element.IfDescendant("system-distance").Exists().Then(n =>
            {
                suggestion.SystemDistance = UsefulMath.TryParse(n.Value) ?? 0;
                state.LastSystemDistance = suggestion.SystemDistance.HasValue ? suggestion.SystemDistance.Value : 0;
            });
            if (suggestion.SystemDistance == 0) suggestion.SystemDistance = state.LastSystemDistance;

            return suggestion;
        }
    }
}