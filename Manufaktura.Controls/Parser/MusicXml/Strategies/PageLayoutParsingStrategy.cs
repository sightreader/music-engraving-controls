using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Manufaktura.Controls.Extensions;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class PageLayoutParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "page-layout"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var score = staff.Score;
            score.DefaultPageSettings.Width = element.ParseChildElement<double>("page-width");
            score.DefaultPageSettings.Height = element.ParseChildElement<double>("page-height");
            score.DefaultPageSettings.MarginLeft = element.ParseChildElement<double>("left-margin");
            score.DefaultPageSettings.MarginRight = element.ParseChildElement<double>("right-margin");
            score.DefaultPageSettings.MarginTop = element.ParseChildElement<double>("top-margin");
            score.DefaultPageSettings.MarginBottom = element.ParseChildElement<double>("bottom-margin");
        }
    }
}
