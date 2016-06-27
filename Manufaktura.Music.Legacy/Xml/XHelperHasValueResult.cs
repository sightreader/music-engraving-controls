using System;

namespace Manufaktura.Music.Xml
{
    public class XHelperHasValueResult<T> : IXHelperResult<T>
    {
        private T value;

        public bool HasValue { get; private set; }

        public T Value
        {
            get
            {
                if (!HasValue) throw new Exception("Value does not exist.");
                return value;
            }
        }

        internal XHelperHasValueResult(T value)
        {
            this.value = value;
            HasValue = true;
        }

        internal XHelperHasValueResult()
        {
            HasValue = false;
        }

        public T AndReturnResult()
        {
            return HasValue ? value : default(T);
        }

        public IXHelperResult Otherwise(Action action)
        {
            if (!HasValue && action != null) action();
            return this;
        }

        public IXHelperResult<T> Then(Action<T> action)
        {
            if (HasValue && action != null) action(Value);
            return this;
        }

        public IXHelperResult Then(Action action)
        {
            if (HasValue && action != null) action();
            return this;
        }

		public void OtherwiseThrowException()
		{
			if (!HasValue) throw new Exception("Value not found.");
		}

		public T ThenReturnResult()
        {
            return AndReturnResult();
        }
    }
}