using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using Manufaktura.Music.Xml;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
	public class PrintSuggestionParsingStrategy : MusicXmlParsingStrategy
	{
		public override string ElementName
		{
			get { return "print"; }
		}

		public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
		{
			PrintSuggestion suggestion = null;
			if (staff.Part != null && staff.Part.Staves.Any())  //If part contains many staves, add to all staves
			{
				foreach (var s in staff.Part.Staves)
				{
					suggestion = CreateSuggestion(element, state, staff);
					s.Elements.Add(suggestion);
				}
			}
			else
			{
				suggestion = CreateSuggestion(element, state, staff);
				staff.Elements.Add(suggestion);
			}

			if (suggestion.IsPageBreak)
			{
				var page = new ScorePage(staff.Score);
				staff.Score.Pages.Add(page);
			}
			if (suggestion.IsSystemBreak)
			{
				state.CurrentSystemNo++;
				var system = NewSystem(state, staff);
				staff.Measures.Last().System = system;
				if (staff.Part != null && staff.Part.Staves.Any())  //If part contains many staves, add to all staves
				{
					foreach (var s in staff.Part.Staves)
					{
						s.Measures.Last().System = system;
					}
				}
			}
		}

		private static StaffSystem NewSystem(MusicXmlParserState state, Staff staff)
		{
			if (staff == staff.Score.Staves.First())
			{
				var system = new StaffSystem(staff.Score);
				staff.Score.Pages.Last().Systems.Add(system);
				return system;
			}
			return staff.Score.Systems[state.CurrentSystemNo - 1];
		}

		private PrintSuggestion CreateSuggestion(XElement element, MusicXmlParserState state, Staff staff)
		{
			PrintSuggestion suggestion = new PrintSuggestion();

			element.IfAttribute("new-system").HasValue("yes").Then(() => suggestion.IsSystemBreak = true);
			element.IfAttribute("new-page").HasValue("yes").Then(() => suggestion.IsPageBreak = true);
			if (suggestion.IsPageBreak) suggestion.IsSystemBreak = true;    //Page breaks are treated also as system breaks.

			element.IfDescendant("system-distance").Exists().Then(n =>
			{
				suggestion.SystemDistance = UsefulMath.TryParse(n.Value);
			});

			//Issue #45: Kopiujemy ustawienia z pierwszego staffa do wszystkich pozostałych staffów (bo są zdefiniowane tylko w pierwszym), innaczej się układ rozjedzie:
			if (!suggestion.SystemDistance.HasValue && staff != staff.Score.Staves.First())
			{
				var thisStaffPrintSuggestions = staff.Elements.OfType<PrintSuggestion>().ToList();
				var firstStaffPrintSuggestions = staff.Score.Staves.First().Elements.OfType<PrintSuggestion>().ToList();
				var indexOfThisBreak = (thisStaffPrintSuggestions.Any() ? thisStaffPrintSuggestions.IndexOf(thisStaffPrintSuggestions.Last()) : -1) + 1;
				if (firstStaffPrintSuggestions.Count > indexOfThisBreak) suggestion.SystemDistance = firstStaffPrintSuggestions[indexOfThisBreak].SystemDistance;
			}
			element.IfDescendant("staff-distance").Exists().Then(n =>
			{
				staff.Score.Pages.Last().DefaultStaffDistance = UsefulMath.TryParse(n.Value);
			});

			return suggestion;
		}
	}
}