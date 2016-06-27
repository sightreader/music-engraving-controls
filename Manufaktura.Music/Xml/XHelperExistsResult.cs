using System;
using System.Xml.Linq;

namespace Manufaktura.Music.Xml
{
    public class XHelperExistsResult : IXHelperResult<XElement>
    {
        private XElement existingElement;
        private bool exists;
		private string rawValue;
        //We don't need another version of this class for XAttribute because attribute can't have child elements

        internal XHelperExistsResult(bool exists, object existingElement, string rawValue)
        {
            this.exists = exists;
            this.existingElement = existingElement as XElement;
			this.rawValue = rawValue;
        }

        public XElement AndReturnResult()
        {
            return exists ? existingElement : null;
        }

        public XElement ThenReturnResult()
        {
            return AndReturnResult();
        }

        public IXHelperResult Otherwise(Action<string> action)
        {
            if (!exists && action != null) action(rawValue);
            return this;
        }

        public IXHelperResult Then(Action action)
        {
            if (exists && action != null) action();
            return this;
        }

        public IXHelperResult<XElement> Then(Action<XElement> action)
        {
            if (exists && action != null) action(existingElement);
            return this;
        }
    }
}