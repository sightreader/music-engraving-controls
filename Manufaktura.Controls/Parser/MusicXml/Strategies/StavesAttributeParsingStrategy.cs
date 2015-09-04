using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class StavesAttributeParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "staves"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var part = staff.Score.Parts.Last();
            staff.Part = part;
            var stavesCount = Convert.ToInt32(element.Value);
            for (var i = 1; i < stavesCount; i++)
            {
                var newStaff = new Staff();
                newStaff.Part = part;
                part.Staves.Add(newStaff);
                staff.Score.Staves.Add(newStaff);
            }
        }
    }
}
