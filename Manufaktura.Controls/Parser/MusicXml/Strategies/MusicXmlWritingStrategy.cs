using Manufaktura.Controls.Model;
using System;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public abstract class MusicXmlWritingStrategy<TSymbol> : MusicXmlWritingStrategyBase where TSymbol : MusicalSymbol
    {
        public override Type SymbolType
        {
            get { return typeof(TSymbol); }
        }

        protected abstract void WriteElementInner(TSymbol symbol, XElement element, int quarterNoteDuration);

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