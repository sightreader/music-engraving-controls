using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    public abstract class MusicXmlParsingStrategy
    {
        private static readonly IEnumerable<MusicXmlParsingStrategy> _strategies;

        public abstract string ElementName { get; }

        static MusicXmlParsingStrategy()
        {
            var strategyTypes = typeof(MusicXmlParsingStrategy).GetTypeInfo().Assembly.DefinedTypes.Where(t => t.IsSubclassOf(typeof(MusicXmlParsingStrategy)) && !t.IsAbstract);
            List<MusicXmlParsingStrategy> strategies = new List<MusicXmlParsingStrategy>();
            foreach (var type in strategyTypes)
            {
                strategies.Add(Activator.CreateInstance(type.AsType()) as MusicXmlParsingStrategy);
            }
            _strategies = strategies.ToArray();
        }

        public abstract void ParseElement(MusicXmlParserState state, Staff staff, XElement element);

        public static MusicXmlParsingStrategy GetProperStrategy(XElement element)
        {
            return _strategies.FirstOrDefault(s => s.ElementName == element.Name);
        }
    }
}
