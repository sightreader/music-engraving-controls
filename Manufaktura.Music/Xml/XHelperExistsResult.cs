using System;
using System.Xml.Linq;

namespace Manufaktura.Music.Xml
{
    public class XHelperExistsResult : IXHelperResult<XElement>
    {
        private bool exists;
        private XElement existingElement;   //We don't need another version of this class for XAttribute because attribute can't have child elements

        internal XHelperExistsResult(bool exists, object existingElement)
        {
            this.exists = exists;
            this.existingElement = existingElement as XElement;
        }

        public IXHelperResult Otherwise(Action action)
        {
            if (!exists && action != null) action();
            return this;
        }

        public IXHelperResult Then(Action action)
        {
            if (exists && action != null) action();
            return this;
        }

        public IXHelperResult Then(Action<XElement> action)
        {
            if (exists && action != null) action(existingElement);
            return this;
        }
    }
}