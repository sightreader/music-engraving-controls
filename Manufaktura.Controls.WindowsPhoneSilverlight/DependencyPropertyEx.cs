using System;
using System.Linq.Expressions;
using System.Windows;

namespace Manufaktura.Controls.WindowsPhoneSilverlight
{
	public static class DependencyPropertyEx
	{
		public static DependencyProperty Register<TControl, TProperty>(Expression<Func<TControl, TProperty>> property, TProperty defaultValue)
		{
			return DependencyProperty.Register(GetPropertyName(property), typeof(TProperty), typeof(TControl), new PropertyMetadata(defaultValue));
		}

		public static DependencyProperty Register<TControl, TProperty>(Expression<Func<TControl, TProperty>> property, TProperty defaultValue, PropertyChangedCallback propertyChangedCallback)
		{
			return DependencyProperty.Register(GetPropertyName(property), typeof(TProperty), typeof(TControl), new PropertyMetadata(defaultValue, propertyChangedCallback));
		}

		private static string GetPropertyName<TControl, TProperty>(Expression<Func<TControl, TProperty>> propertyLambda)
		{
			var memberExpression = propertyLambda.Body as MemberExpression;
			if (memberExpression == null) throw new Exception("Lambda expression should be in the following format: control => control.Property.");
			return memberExpression.Member.Name;
		}
	}
}