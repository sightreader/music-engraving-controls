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

        public void Then(Action action)
        {
            if (exists && action != null) action();
        }
    }
}