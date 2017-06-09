using Manufaktura.Controls.Model;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public abstract class NoteOrRestWritingStrategy<TNoteOrRest> : MusicXmlWritingStrategy<TNoteOrRest> where TNoteOrRest : NoteOrRest
    {
        protected IEnumerable<XElement> CreateNotations(TNoteOrRest symbol)
        {
            if (symbol.Tuplet != TupletType.None)
            {
                var tuple = new XElement("tuplet", new XAttribute("number", 1));     //TODO: Multiple tuplets
                if (symbol.TupletPlacement.HasValue) tuple.Add(new XAttribute("placement", symbol.TupletPlacement.Value.ToString().ToLowerInvariant()));
                tuple.Add(new XAttribute("type", symbol.Tuplet.ToString().ToLowerInvariant()));
                yield return tuple;
            }
        }
    }
}