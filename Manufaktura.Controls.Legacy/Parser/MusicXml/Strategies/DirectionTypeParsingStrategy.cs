using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class DirectionTypeParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "direction-type"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            XElement elementNode = element.Parent;
            foreach (XElement directionTypeNode in element.Elements())
            {
                if (directionTypeNode.Name == "dynamics")
                {
                    DirectionPlacementType placement = DirectionPlacementType.Above;
                    int defaultY = 0;
                    string text = "";
                    var attribute = elementNode.Attribute(XName.Get("default-y"));
                    if (attribute != null)
                    {
                        defaultY = Convert.ToInt32(attribute.Value);
                        placement = DirectionPlacementType.Custom;
                    }
                    attribute = elementNode.Attribute(XName.Get("placement"));
                    if (attribute != null && placement != DirectionPlacementType.Custom)
                    {
                        if (attribute.Value == "above")
                            placement = DirectionPlacementType.Above;
                        else if (attribute.Value == "below")
                            placement = DirectionPlacementType.Below;
                    }
                    foreach (XElement dynamicsType in directionTypeNode.Elements())
                    {
                        text = dynamicsType.Name.LocalName;
                    }
                    Direction dir = new Direction();
                    dir.DefaultY = defaultY;
                    dir.Placement = placement;
                    dir.Text = text;
                    staff.Elements.Add(dir);
                }
            }
        }
    }
}
