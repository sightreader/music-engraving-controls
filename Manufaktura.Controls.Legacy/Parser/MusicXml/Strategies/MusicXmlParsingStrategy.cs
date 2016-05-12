using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
	public abstract class MusicXmlParsingStrategy
	{
		private static IEnumerable<MusicXmlParsingStrategy> _strategies;

		static MusicXmlParsingStrategy()
		{
			var strategyTypes = typeof(MusicXmlParsingStrategy).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(MusicXmlParsingStrategy)) && !t.IsAbstract);
			List<MusicXmlParsingStrategy> strategies = new List<MusicXmlParsingStrategy>();
			foreach (var type in strategyTypes)
			{
				strategies.Add(Activator.CreateInstance(type) as MusicXmlParsingStrategy);
			}
			_strategies = strategies.ToArray();
		}

		public abstract string ElementName { get; }

		public static MusicXmlParsingStrategy GetProperStrategy(XElement element)
		{
			return _strategies.FirstOrDefault(s => s.ElementName == element.Name);
		}

		public abstract void ParseElement(MusicXmlParserState state, Staff staff, XElement element);
	}
}