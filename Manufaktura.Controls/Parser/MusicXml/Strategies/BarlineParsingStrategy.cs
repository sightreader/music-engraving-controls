using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
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
            var attr = element.Attributes().FirstOrDefault(a => a.Name == "location");
            if (attr != null)
            {
                b.Location = attr.Value == "left" ? HorizontalPlacement.Left : HorizontalPlacement.Right;
            }
            var staffElement = element.Elements().Where(a => a.Name == "staff").FirstOrDefault();
            if (staffElement != null)
            {
                int? staffNumber = UsefulMath.TryParseInt(staffElement.Value) ?? 1;
                b.Staff = staff.Score.Staves.ElementAt(staffNumber.Value - 1);    //TODO: Sprawdzić czy staff to numer liczony od góry strony czy numer w obrębie parta
            }
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
                        //Barline existingBarline = staff.Elements.LastOrDefault() as Barline;
                        //if (existingBarline != null) staff.Elements.Remove(existingBarline);

                        staff.Elements.Add(b);
                        
                    }

                }
            }
        }
    }
}
