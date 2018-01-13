using Manufaktura.Controls.Model;
using System;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    /// <summary>
    /// Strategy of writing elements of specific type into MusicXml.
    /// </summary>
    /// <typeparam name="TSymbol"></typeparam>
    public abstract class MusicXmlWritingStrategy<TSymbol> : MusicXmlWritingStrategyBase where TSymbol : MusicalSymbol
    {
        /// <summary>
        /// Symbol type
        /// </summary>
        public override Type SymbolType
        {
            get { return typeof(TSymbol); }
        }

        /// <summary>
        /// Writes element int MusicXml.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="element"></param>
        /// <param name="quarterNoteDuration"></param>
        protected abstract void WriteElementInner(TSymbol symbol, XElement element, int quarterNoteDuration);

        /// <summary>
        /// Writes element into MusicXml
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="element"></param>
        /// <param name="quarterNoteDuration"></param>
        protected override void WriteElementInner(MusicalSymbol symbol, XElement element, int quarterNoteDuration)
        {
            if (symbol.Staff?.Part?.Staves.Count > 1)
            {
                var staffNumber = symbol.Staff.Part.Staves.IndexOf(symbol.Staff) + 1;
                element.Add(new XElement("staff", staffNumber));
            }
            WriteElementInner((TSymbol)symbol, element, quarterNoteDuration);
        }
    }
}