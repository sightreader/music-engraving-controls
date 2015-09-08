using System;

namespace Manufaktura.Music.Xml
{
    public class XHelperExistsResult : IXHelperResult
    {
        private bool exists;

        internal XHelperExistsResult(bool exists)
        {
            this.exists = exists;
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
    }
}