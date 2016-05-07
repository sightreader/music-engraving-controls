using Manufaktura.Controls.Model;
using Manufaktura.Music.Xml;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
	internal class DirectionParsingStrategy : MusicXmlParsingStrategy
	{
		public override string ElementName
		{
			get { return "direction"; }
		}

		public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
		{
			var directionTypeNode = element.Elements().FirstOrDefault(e => e.Name.LocalName == "direction-type");
			if (directionTypeNode == null) return;

			foreach (var directionDefinitionNode in directionTypeNode.Elements())
			{
				Direction dir = new Direction();
				dir.DefaultYPosition = 0;
				dir.Placement = DirectionPlacementType.Above;

				directionDefinitionNode.IfAttribute("default-y").HasValue<int>().Then(v =>
				{
					dir.DefaultYPosition = v;
					dir.Placement = DirectionPlacementType.Custom;
				});

				//Placement can suposedly be set both on direction-type node and it's subnodes:
				directionTypeNode.IfAttribute("placement")
					.HasValue<DirectionPlacementType>(d =>
					{
						d.Add("above", DirectionPlacementType.Above);
						d.Add("below", DirectionPlacementType.Below);
						return d;
					})
				  .Then(v => dir.Placement = v);

				directionDefinitionNode.IfAttribute("placement")
					.HasValue<DirectionPlacementType>(d =>
					{
						d.Add("above", DirectionPlacementType.Above);
						d.Add("below", DirectionPlacementType.Below);
						return d;
					})
				  .Then(v => dir.Placement = v);

				switch (directionDefinitionNode.Name.LocalName)
				{
					case "dynamics":
						dir.Text = directionTypeNode.Elements().FirstOrDefault()?.Name.LocalName;
						break;

					case "words":
						dir.Text = directionTypeNode.Value;
						break;
				}

				staff.Elements.Add(dir);
			}
		}
	}
}