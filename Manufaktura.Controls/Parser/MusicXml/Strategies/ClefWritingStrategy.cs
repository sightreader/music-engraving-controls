using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    class ClefWritingStrategy : MusicXmlWritingStrategy<Clef>
    {
        public override string ElementName
        {
            get { return "clef"; }
        }

        protected override void WriteElementInner(Clef symbol, XElement element)
        {
            element.Add("sign", symbol.Pitch.StepName);
            element.Add("line", symbol.Line);
        }
    }
}
