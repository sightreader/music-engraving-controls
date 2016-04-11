using Manufaktura.Controls.Model;
using Manufaktura.Music.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class TimeParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "time"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            int numberOfBeats = 4;
            int beatType = 4;
            TimeSignatureType sType = TimeSignatureType.Numbers;

            element.IfElement("beats").HasValue<int>().Then(v => numberOfBeats = v);
            element.IfElement("beat-type").HasValue<int>().Then(v => beatType = v);
            element.IfAttribute("symbol").HasValue(new Dictionary<string, TimeSignatureType> {
                    {"common", TimeSignatureType.Common},
                    {"cut", TimeSignatureType.Cut}
                }).Then(s => sType = s);

            if (staff.Part != null && staff.Part.Staves.Any())  //If part contains many staves, add to all staves
            {
                foreach (var s in staff.Part.Staves)
                {
                    var t = new TimeSignature(sType, numberOfBeats, beatType);
                    s.Elements.Add(t);
                }
            }
            else
            {
                var t = new TimeSignature(sType, numberOfBeats, beatType);
                staff.Elements.Add(t);
            }
        }
    }
}
