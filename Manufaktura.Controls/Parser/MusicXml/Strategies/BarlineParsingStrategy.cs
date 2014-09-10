using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class BarlineParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "barline"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            Barline b = new Barline();
            foreach (XElement barlineAttribute in element.Elements())
            {
                if (barlineAttribute.Name == "repeat")
                {
                    var attribute = barlineAttribute.Attribute("direction");
                    if (attribute != null)
                    {
                        if (attribute.Value == "forward") b.RepeatSign = RepeatSignType.Forward;
                        else if (attribute.Value == "backward")
                        {
                            b.RepeatSign = RepeatSignType.Backward;
                            state.BarlineAlreadyAdded = true;
                        }

                        //Usuń pojedynczą kreskę taktową, jeśli już taka została dodana:
                        Barline existingBarline = staff.Elements.LastOrDefault() as Barline;
                        if (existingBarline != null) staff.Elements.Remove(existingBarline);

                        staff.Elements.Add(b);
                        
                    }

                }
            }
        }
    }
}
