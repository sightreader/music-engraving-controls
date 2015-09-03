using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public abstract class MusicalSymbolMusicXmlParsingStrategy : MusicXmlParsingStrategy
    {
        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            throw new NotImplementedException();
        }
    }
}
