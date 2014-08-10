using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class KeyParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "key"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            foreach (XElement keyAttribute in element.Elements())
            {
                if (keyAttribute.Name == "fifths")
                {
                    staff.Elements.Add(new Key(Convert.ToInt16(keyAttribute.Value)));
                }
            }
        }
    }
}
