using Manufaktura.Controls.Model;
using System;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    internal class KeyParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "key"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            foreach (XElement keyAttribute in element.Elements())
            {
                if (keyAttribute.Name == "fifths")
                {
                    if (staff.Part != null && staff.Part.Staves.Any())  //If part contains many staves, add to all staves
                    {
                        foreach (var s in staff.Part.Staves)
                        {
                            var key = new Key(Convert.ToInt16(keyAttribute.Value));
                            s.Elements.Add(key);
                        }
                    }
                    else
                    {
                        var key = new Key(Convert.ToInt16(keyAttribute.Value));
                        staff.Elements.Add(key);
                    }
                }
            }
        }
    }
}