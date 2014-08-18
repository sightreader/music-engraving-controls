using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class MeasureStyleParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "measure-style"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            foreach (XElement measureStyleAttribute in element.Elements())
            {
                if (measureStyleAttribute.Name == "multiple-rest")
                {
                    state.SkipMeasures = Convert.ToInt32(measureStyleAttribute.Value) - 1;
                }
            }
        }
    }
}
