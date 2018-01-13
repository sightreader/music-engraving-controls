using System.Xml.Linq;

namespace Manufaktura.Controls.Parser
{
    /// <summary>
    /// Parser that converts one xml document to another
    /// </summary>
    public abstract class XTransformerParser : Parser<XDocument, XDocument>
    {
    }
}