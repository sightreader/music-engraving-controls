using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public abstract class MusicXmlWritingStrategy<TSymbol> : MusicXmlWritingStrategyBase where TSymbol:MusicalSymbol
    {
        public override Type SymbolType
        {
            get { return typeof(TSymbol); }
        }

        protected abstract void WriteElementInner(TSymbol symbol, XElement element);

        protected override void WriteElementInner(MusicalSymbol symbol, XElement element)
        {
            WriteElementInner((TSymbol)symbol, element);
        }
    }
}
