using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
