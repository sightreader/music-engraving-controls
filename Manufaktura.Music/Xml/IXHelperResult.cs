using System;

namespace Manufaktura.Music.Xml
{
    public interface IXHelperResult<T> : IXHelperResult
    {
        void Then(Action<T> action);
    }

    public interface IXHelperResult
    {
        void Then(Action action);
    }
}