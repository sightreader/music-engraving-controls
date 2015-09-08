using System.Xml.Linq;

namespace Manufaktura.Music.Xml
{
    public class XAttributeHelper : XHelperBase
    {
        private XAttribute element;

        internal XAttributeHelper(XAttribute element)
        {
            this.element = element;
        }

        protected override bool ElementExists()
        {
            return element != null;
        }

        protected override string GetValue()
        {
            return element.Value;
        }
    }
}