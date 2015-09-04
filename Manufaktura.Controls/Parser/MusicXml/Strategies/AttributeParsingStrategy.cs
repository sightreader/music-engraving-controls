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
            var elementList = element.Elements().ToList();

            //Element "staves" must be the first element:
            var stavesElement = elementList.FirstOrDefault(e => e.Name == "staves");
            if (stavesElement != null)
            {
                elementList.Remove(stavesElement);
                elementList.Insert(0, stavesElement);
            }

            foreach (XElement attribute in elementList)
            {
                MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(attribute);
                if (parsingStrategy != null) parsingStrategy.ParseElement(state, staff, attribute);
            }
        }
    }
}
