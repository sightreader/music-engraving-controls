using Manufaktura.Controls.Model;
using Manufaktura.Music.Xml;
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
            element.IfAttribute("tempo").HasValue<int>().Then(v => state.CurrentTempo = v);
            element.IfAttribute("dynamics").HasValue<int>().Then(v => state.CurrentDynamics = v);
        }
    }
}
