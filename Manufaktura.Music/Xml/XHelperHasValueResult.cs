using System;

namespace Manufaktura.Music.Xml
{
	public class XHelperHasValueResult<T> : IXHelperResult<T>
	{
		private string rawValue;
		private T value;

		internal XHelperHasValueResult(T value, string rawValue, bool hasValue)
		{
			this.value = value;
			this.rawValue = rawValue;
			HasValue = hasValue;
		}


		public bool HasValue { get; private set; }

		public T Value
		{
			get
			{
				if (!HasValue) throw new Exception("Value does not exist.");
				return value;
			}
		}

		public T AndReturnResult()
		{
			return HasValue ? value : default(T);
		}

		public IXHelperResult Otherwise(Action<string> action)
		{
			if (!HasValue && action != null) action(rawValue);
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

		public T ThenReturnResult()
		{
			return AndReturnResult();
		}
	}
}