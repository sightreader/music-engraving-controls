using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Manufaktura.Controls.Model
{
	public abstract class ViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged<T>(Expression<Func<T>> propertyLambda)
		{
			OnPropertyChanged(GetPropertyName(propertyLambda));
		}

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private static string GetPropertyName<T>(Expression<Func<T>> propertyLambda)
		{
			var memberExpression = propertyLambda.Body as MemberExpression;
			if (memberExpression == null) throw new Exception("Could not evaluate lambda expression.");
			var propertyInfo = memberExpression.Member as PropertyInfo;
			if (propertyInfo == null) throw new ArgumentException("Lambda should point at property.");
			return propertyInfo.Name;
		}
	}
}