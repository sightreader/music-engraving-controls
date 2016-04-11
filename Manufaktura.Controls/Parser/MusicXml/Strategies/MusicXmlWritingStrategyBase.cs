using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public abstract class MusicXmlWritingStrategyBase
    {
        private static IEnumerable<MusicXmlWritingStrategyBase> _strategies;

        public abstract Type SymbolType { get; }
        public abstract string ElementName { get; }

        static MusicXmlWritingStrategyBase()
        {
            var strategyTypes = typeof(MusicXmlWritingStrategyBase).GetTypeInfo().Assembly.DefinedTypes.Where(t => t.IsSubclassOf(typeof(MusicXmlWritingStrategyBase)) && !t.IsAbstract);
            List<MusicXmlWritingStrategyBase> strategies = new List<MusicXmlWritingStrategyBase>();
            foreach (var type in strategyTypes)
            {
                strategies.Add(Activator.CreateInstance(type.AsType()) as MusicXmlWritingStrategyBase);
            }
            _strategies = strategies.ToArray();
        }

        public void WriteElement(MusicalSymbol symbol, XElement parentElement)
        {
            var newElement = new XElement(XName.Get(ElementName));
            parentElement.Add(newElement);
            WriteElementInner(symbol, newElement);
        }

        protected abstract void WriteElementInner(MusicalSymbol symbol, XElement element);

        public static MusicXmlWritingStrategyBase GetProperStrategy(Type symbolType)
        {
            return _strategies.FirstOrDefault(s => s.SymbolType == symbolType);
        }
    }
}
