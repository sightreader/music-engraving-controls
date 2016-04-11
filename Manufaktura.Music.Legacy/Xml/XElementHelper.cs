using System.Xml.Linq;

namespace Manufaktura.Music.Xml
{
    public class XElementHelper : XHelperBase
    {
        private XElement element;

        internal XElementHelper(XElement element)
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

        protected override object GetObject()
        {
            return element;
        }
    }
}