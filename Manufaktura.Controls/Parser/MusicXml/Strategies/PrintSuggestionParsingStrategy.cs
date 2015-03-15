using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class PrintSuggestionParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "print"; }
        }

        public override void ParseElement(MusicXmlParserState state, Model.Staff staff, System.Xml.Linq.XElement element)
        {
            PrintSuggestion suggestion = new PrintSuggestion();

            var attribute = element.Attributes().FirstOrDefault(a => a.Name == "new-system");
            if (attribute != null) suggestion.IsSystemBreak = attribute.Value == "yes";

            var node = element.Descendants().FirstOrDefault(n => n.Name == "system-distance");
            if (node != null) suggestion.SystemDistance = UsefulMath.TryParse(node.Value) ?? 0;

            staff.Elements.Add(suggestion);
        }
    }
}
