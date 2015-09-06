using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.Harmony;
using Manufaktura.Music.Model.MajorAndMinor;
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
            var stepName = element.ParseChildElement("root-step");
            staff.Elements.Add(new ChordSign(new TertianHarmony().CreateChord(new Pitch(stepName, 0, 4), 0, 2, MajorScale.C)));
        }
    }
}