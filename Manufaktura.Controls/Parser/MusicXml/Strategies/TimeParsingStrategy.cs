using Manufaktura.Controls.Model;
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
            foreach (XElement timeAttribute in element.Elements())
            {
                if (timeAttribute.Name == "beats")
                    numberOfBeats = int.Parse(timeAttribute.Value);
                if (timeAttribute.Name == "beat-type")
                    beatType = int.Parse(timeAttribute.Value);
            }
            if (element.Attributes().Count() > 0)
            {
                foreach (XAttribute a in element.Attributes())
                {
                    if (a.Name == "symbol")
                    {
                        if (a.Value == "common")
                            sType = TimeSignatureType.Common;
                        else if (a.Value == "cut")
                            sType = TimeSignatureType.Cut;
                    }
                }
            }


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
