using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class AttributeParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "attributes"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            foreach (XElement attribute in element.Elements())
            {
                MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(attribute);
                if (parsingStrategy != null) parsingStrategy.ParseElement(state, staff, attribute);
            }
        }
    }
}
