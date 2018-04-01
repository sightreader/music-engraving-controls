using Manufaktura.Controls.Model;
using Manufaktura.Music.Xml;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class BackupParsingStrategy : PlaybackSuggestionParsingStrategy
    {
        public override string ElementName => "backup";

        protected override bool IsBackward => true;
    }

    public class ForwardParsingStrategy : PlaybackSuggestionParsingStrategy
    {
        public override string ElementName => "forward";

        protected override bool IsBackward => false;
    }

    public abstract class PlaybackSuggestionParsingStrategy : MusicXmlParsingStrategy
    {
        protected abstract bool IsBackward { get; }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var suggestion = new PlaybackSuggestion { IsBackward = IsBackward };
            element.IfElement("duration").HasValue<int>().Then(d => suggestion.MusicXmlDuration = d);
            element.IfElement("voice").HasValue<int>().Then(v => suggestion.Voice = v);
            staff.Elements.Add(suggestion);
        }
    }
}