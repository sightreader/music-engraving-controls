using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
	public class StaffLayoutParsingStrategy : MusicXmlParsingStrategy
	{
		public override string ElementName
		{
			get { return "staff-layout"; }
		}

		public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
		{
			var score = staff.Score;
			if (element.Parent.Name.LocalName == "defaults")
				score.DefaultPageSettings.DefaultStaffDistance = element.ParseChildElement<double>("staff-distance");
			else
				score.Pages.Last().DefaultStaffDistance = element.ParseChildElement<double>("staff-distance");
		}
	}
}