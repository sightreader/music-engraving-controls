using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
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
			score.DefaultPageSettings.DefaultStaffDistance = element.ParseChildElement<double>("staff-distance");
		}
	}
}