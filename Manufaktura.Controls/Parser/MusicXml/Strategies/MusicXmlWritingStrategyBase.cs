using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public abstract class MusicXmlWritingStrategyBase
    {
        static MusicXmlWritingStrategyBase()
        {
            var strategyTypes = typeof(MusicXmlWritingStrategyBase)
#if !CSHTML5
                .GetTypeInfo()
                .Assembly.DefinedTypes
#else
                .Assembly.GetTypes()
#endif
                .Where(t => t.IsSubclassOf(typeof(MusicXmlWritingStrategyBase)) && !t.IsAbstract);
            List<MusicXmlWritingStrategyBase> strategies = new List<MusicXmlWritingStrategyBase>();
            foreach (var type in strategyTypes)
            {
#if CSHTML5
                strategies.Add(Activator.CreateInstance(type) as MusicXmlWritingStrategyBase);
#else
                strategies.Add(Activator.CreateInstance(type.AsType()) as MusicXmlWritingStrategyBase);
#endif
            }
            _strategies = strategies.ToArray();
        }

        public static IEnumerable<Type> SupportedElements
        {
            get
            {
                return typeof(MusicalSymbol)
#if !CSHTML5
                    .GetTypeInfo()
                    .Assembly.DefinedTypes
#else
                    .Assembly.GetTypes()
#endif
                    .Where(d => !d.IsAbstract && d.IsSubclassOf(typeof(MusicalSymbol)))
#if !CSHTML5
                    .Select(d => d.AsType())
#endif
                    .Where(t => _strategies.Any(s => s.SymbolType == t))
                    .ToArray();
            }
        }

        public static IEnumerable<Type> UnsupportedElements
        {
            get
            {
                return typeof(MusicalSymbol)
#if !CSHTML5
                    .GetTypeInfo()
                    .Assembly.DefinedTypes
#else
                    .Assembly.GetTypes()
#endif

                    .Where(d => !d.IsAbstract && d.IsSubclassOf(typeof(MusicalSymbol)))
#if !CSHTML5
                    .Select(d => d.AsType())
#endif
                    .Where(t => !_strategies.Any(s => s.SymbolType == t))
                    .ToArray();
            }
        }

        public abstract string ElementName { get; }
        public abstract bool IsAttributeElement { get; }
        public abstract Type SymbolType { get; }

        public static MusicXmlWritingStrategyBase GetProperStrategy(Type symbolType)
        {
            return _strategies.FirstOrDefault(s => s.SymbolType == symbolType);
        }

        public void WriteElement(MusicalSymbol symbol, XElement parentElement, int quarterNoteDuration)
        {
            if (IsAttributeElement)
            {
                var attributesElement = parentElement.Elements().FirstOrDefault(e => e.Name == "attributes");
                if (attributesElement == null)
                {
                    attributesElement = new XElement("attributes");
                    parentElement.Add(attributesElement);
                }
                parentElement = attributesElement;
            }

            var newElement = new XElement(ElementName);
            parentElement.Add(newElement);
            WriteElementInner(symbol, newElement, quarterNoteDuration);
        }

        protected abstract void WriteElementInner(MusicalSymbol symbol, XElement element, int quarterNoteDuration);

        private static IEnumerable<MusicXmlWritingStrategyBase> _strategies;
    }
}