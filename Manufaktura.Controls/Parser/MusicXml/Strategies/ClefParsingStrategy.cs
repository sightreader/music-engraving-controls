using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class ClefParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "clef"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            ClefType typeOfClef = ClefType.GClef;
            int line = 1;
            foreach (XElement clefAttribute in element.Elements())
            {
                if (clefAttribute.Name == "sign")
                {
                    if (clefAttribute.Value.ToUpper() == "G")
                    {
                        typeOfClef = ClefType.GClef;
                    }
                    else if (clefAttribute.Value.ToUpper() == "C")
                    {
                        typeOfClef = ClefType.CClef;
                    }
                    else if (clefAttribute.Value.ToUpper() == "F")
                    {
                        typeOfClef = ClefType.FClef;
                    }
                    else throw (new Exception("Unknown clef"));
                }
                if (clefAttribute.Name == "line")
                {
                    line = Convert.ToInt16(clefAttribute.Value);
                }

            }
            staff.Elements.Add(new Clef(typeOfClef, line));
        }
    }
}
