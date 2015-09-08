using System;

namespace Manufaktura.Music.Xml
{
    public interface IXHelperResult<T> : IXHelperResult
    {
        IXHelperResult Then(Action<T> action);
    }

    public interface IXHelperResult
    {
        IXHelperResult Otherwise(Action action);

        IXHelperResult Then(Action action);
    }
}