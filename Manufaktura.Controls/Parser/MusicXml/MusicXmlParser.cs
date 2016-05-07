using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser.MusicXml;
using Manufaktura.Music.Xml;
using System;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser
{
	/// <summary>
	/// Parser that parsers xml documents into scores.
	/// </summary>
	public class MusicXmlParser : ScoreParser<XDocument>
	{
		public override Score Parse(XDocument xmlDocument)  //TODO: Exception handling!
		{
			Score score = new Score();
			var firstSystem = new StaffSystem(score);
			score.Pages.Last().Systems.Add(firstSystem);
			MusicXmlParserState state = new MusicXmlParserState();

			foreach (XElement defaultSettingsNode in xmlDocument.Descendants().Where(d => d.Name == "defaults" || d.Name == "identification"))
			{
				foreach (XElement settingNode in defaultSettingsNode.Elements())
				{
					var dummyStaff = new Staff { Score = score };   //Nasty workaround
					MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(settingNode);
					if (parsingStrategy != null) parsingStrategy.ParseElement(state, dummyStaff, settingNode);
				}
			}

			foreach (XElement partNode in xmlDocument.Descendants(XName.Get("part")))
			{
				var partId = partNode.ParseAttribute("id");
				state.FirstLoop = true;
				Staff staff = new Staff() { MeasureAddingRule = Staff.MeasureAddingRuleEnum.AddMeasuresManually };
				score.Staves.Add(staff);
				var part = score.Parts.FirstOrDefault(p => p.PartId == partId) ?? new Part(staff) { PartId = partId };
				staff.Part = part;
				score.Parts.Add(part);
				foreach (XElement node in partNode.Elements())
				{
					MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(node);
					if (parsingStrategy != null) parsingStrategy.ParseElement(state, staff, node);
				}
			}

			var partListNode = xmlDocument.Descendants(XName.Get("part-list"));
			PartGroup currentPartGroup = null;
			foreach (var partListElementNode in partListNode.Elements())
			{
				if (partListElementNode.Name == "part-group")
				{
					partListElementNode.IfAttribute("type").HasValue("start").Then(() =>
					{
						currentPartGroup = new PartGroup() { Number = score.PartGroups.Count + 1 };
						score.PartGroups.Add(currentPartGroup);
					});

					partListElementNode.IfAttribute("type").HasValue("stop").Then(() => currentPartGroup = null);
					if (currentPartGroup != null)
					{
						partListElementNode.IfElement("group-barline").HasValue<GroupBarlineType>(d =>
						{
							d.Add("Yes", GroupBarlineType.Enabled);
							d.Add("No", GroupBarlineType.Disabled);
							d.Add("Mensurstrich", GroupBarlineType.Mensurstrich);
							return d;
						}).Then(r => currentPartGroup.GroupBarline = r);
					}
				}
				if (partListElementNode.Name == "score-part" && currentPartGroup != null)
				{
					var scorePartId = partListElementNode.IfAttribute("id").HasAnyValue().ThenReturnResult();
					var matchingScorePart = score.Parts.FirstOrDefault(p => p.PartId == scorePartId);
					if (matchingScorePart != null) matchingScorePart.Group = currentPartGroup;
				}
			}

			//Sibelius hack:
			if (score.Encoding?.Software?.Any(s => s.Contains("Sibelius")) ?? false)
			{
				new DefaultScoreFormatter().Format(score);
			}

			foreach (var staff in score.Staves) staff.MeasureAddingRule = Staff.MeasureAddingRuleEnum.AddMeasureOnInsertingBarline;
			return score;
		}

		public override XDocument ParseBack(Score score)
		{
			throw new NotImplementedException("This parser does not support saving to MusicXml.");
		}
	}
}