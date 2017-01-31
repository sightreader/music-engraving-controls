using Manufaktura.Controls.Model;
using Manufaktura.Music.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    internal class ClefParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "clef"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            ClefType typeOfClef = ClefType.GClef;
            int line = 1;

            element.IfElement("sign").HasValue(new Dictionary<string, ClefType> {
                {"G", ClefType.GClef},
                {"C", ClefType.CClef},
                {"F", ClefType.FClef}
            }).Then(v => typeOfClef = v);
            element.IfElement("line").HasValue<int>().Then(v => line = v);
			
            var clef = new Clef(typeOfClef, line);
            element.IfAttribute("number").HasValue<int>().Then(v => clef.Staff = staff.Part.Staves.ElementAt(v - 1));
			element.IfElement("clef-octave-change").HasValue<int>().Then(c => clef.OctaveChange = c);

			var correctStaff = clef.Staff ?? staff;
            correctStaff.Elements.Add(clef);
        }
    }
}