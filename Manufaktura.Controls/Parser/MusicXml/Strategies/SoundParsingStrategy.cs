using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class SoundParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "sound"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var attribute = element.Attribute(XName.Get("tempo"));
            if (attribute != null) state.CurrentTempo = Convert.ToInt32(attribute.Value);
            attribute = element.Attribute(XName.Get("dynamics"));
            if (attribute != null) state.CurrentDynamics = Convert.ToInt32(attribute.Value);
        }
    }
}
