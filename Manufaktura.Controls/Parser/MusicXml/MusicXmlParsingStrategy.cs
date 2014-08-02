using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    public abstract class MusicXmlParsingStrategy
    {
        public Score Score { get; protected set; }
        public XElement Element { get; protected set; }

        

        protected MusicXmlParsingStrategy(Score score, XElement element)
        {
            Score = score;
            Element = element;
        }

        public abstract void ParseElement();
    }
}
