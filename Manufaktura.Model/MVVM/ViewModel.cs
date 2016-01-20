using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace Manufaktura.Model.MVVM
{
	public abstract class ViewModel : INotifyPropertyChanged
	{
		private static string GetPropertyName<T>(Expression<Func<T>> propertyLambda)
		{
			var memberExpression = propertyLambda.Body as MemberExpression;
			if (memberExpression == null) throw new Exception("Could not evaluate lambda expression.");
			var propertyInfo = memberExpression.Member as PropertyInfo;
			if (propertyInfo == null) throw new ArgumentException("Lambda should point at property.");
			return propertyInfo.Name;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged<T>(Expression<Func<T>> propertyLambda)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(GetPropertyName(propertyLambda)));
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}