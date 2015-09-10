using System;

namespace Manufaktura.Music.Xml
{
    public interface IXHelperResult<T> : IXHelperResult
    {
        T AndReturnResult();

        IXHelperResult<T> Then(Action<T> action);

        T ThenReturnResult();
    }

    public interface IXHelperResult
    {
        IXHelperResult Otherwise(Action action);

        IXHelperResult Then(Action action);
    }
}