using Manufaktura.Controls.Model;
using Manufaktura.Music.Xml;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public abstract class GenericMusicXmlParsingStrategy<TSymbol> : MusicXmlParsingStrategy where TSymbol : MusicalSymbol, new()
    {
        public override sealed void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var symbol = new TSymbol();

            element.IfElement("staff").HasValue<int>()
                .Then(v => symbol.Staff = staff.Part.Staves.ElementAt(v - 1))
                .Otherwise(r => symbol.Staff = staff.Score.Staves.First());

            ParseElementInner(symbol, state, staff, element);
        }

        protected void AddToCorrectStaff(TSymbol symbol, Staff assumedStaff)
        {
            var correctStaff = symbol.Staff ?? assumedStaff;
            correctStaff.Elements.Add(symbol);
        }

        protected abstract void ParseElementInner(TSymbol symbol, MusicXmlParserState state, Staff staff, XElement element);
    }
}