using Manufaktura.Controls.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class HarmonyParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "harmony"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            //element.IfElement("root-step").HasAnyValue().Then(s =>
            //    staff.Elements.Add(new ChordSign(new TertianHarmony().CreateChord(new Pitch(s, 0, 4), 0, 2, MajorScale.C))));
        }
    }
}