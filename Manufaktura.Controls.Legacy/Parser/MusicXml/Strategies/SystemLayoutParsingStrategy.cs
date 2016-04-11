using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class SystemLayoutParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "system-layout"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var score = staff.Score;
            score.DefaultPageSettings.DefaultSystemDistance = element.ParseChildElement<double>("system-distance");
        }
    }
}