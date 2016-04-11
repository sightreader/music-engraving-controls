using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class DirectionParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "direction"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            foreach (XElement directionNode in element.Elements())
            {
                MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(directionNode);
                if (parsingStrategy != null) parsingStrategy.ParseElement(state, staff, element);
            }
        }
    }
}
