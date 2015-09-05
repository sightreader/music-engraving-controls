using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
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
            if (staff.Part != null && staff.Part.Staves.Any())  //If part contains many staves, add to all staves
            {
                foreach (var s in staff.Part.Staves)
                {
                    var suggestion = CreateSuggestion(element, state);
                    s.Elements.Add(suggestion);
                }
            }
            else
            {
                var suggestion = CreateSuggestion(element, state);
                staff.Elements.Add(suggestion);
            }
        }

        private PrintSuggestion CreateSuggestion(XElement element, MusicXmlParserState state)
        {
            PrintSuggestion suggestion = new PrintSuggestion();

            //Page breaks are treated as system breaks. Manufaktura.Controls currently doesn't support page breaks.
            var attribute = element.Attributes().FirstOrDefault(a => a.Name == "new-system" || a.Name == "new-page");   
            if (attribute != null) suggestion.IsSystemBreak = attribute.Value == "yes";

            var node = element.Descendants().FirstOrDefault(n => n.Name == "system-distance");
            if (node != null)
            {
                suggestion.SystemDistance = UsefulMath.TryParse(node.Value) ?? 0;
                state.LastSystemDistance = suggestion.SystemDistance.HasValue ? suggestion.SystemDistance.Value : 0;
            }
            if (suggestion.SystemDistance == 0) suggestion.SystemDistance = state.LastSystemDistance;

            return suggestion;
        }
    }
}