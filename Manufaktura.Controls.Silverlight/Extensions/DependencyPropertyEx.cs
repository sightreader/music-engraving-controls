using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Controls;

namespace Manufaktura.Controls.Silverlight.Extensions
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

		public static IEnumerable<FrameworkElement> RemoveAllFrom(this IEnumerable<FrameworkElement> frameworkElements, Canvas canvas)
		{
			foreach (var frameworkElement in frameworkElements)
			{
				canvas.Children.Remove(frameworkElement);
			}
			return frameworkElements;
		}

		private static string GetPropertyName<TControl, TProperty>(Expression<Func<TControl, TProperty>> propertyLambda)
		{
			var memberExpression = propertyLambda.Body as MemberExpression;
			if (memberExpression == null) throw new Exception("Lambda expression should be in the following format: control => control.Property.");
			return memberExpression.Member.Name;
		}
	}
}