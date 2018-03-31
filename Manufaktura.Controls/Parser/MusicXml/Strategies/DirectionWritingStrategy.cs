using Manufaktura.Controls.Model;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    /// <summary>
    /// Strategy of writing Direction element into MusicXml
    /// </summary>
    public class DirectionWritingStrategy : MusicXmlWritingStrategy<Direction>
    {
        public override string ElementName => "direction";

        public override bool IsAttributeElement => false;

        protected override void WriteElementInner(Direction symbol, XElement element, int quarterNoteDuration)
        {
        }
    }
}