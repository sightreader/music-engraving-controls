using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    /// <summary>
    /// Strategy of parsing "encoding" MusicXml element
    /// </summary>
    public class EncodingParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "encoding"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var encoding = new ScoreEncoding();
            encoding.Software.AddRange(element.ParseChildElements("software"));
            staff.Score.Encoding = encoding;
        }
    }
}