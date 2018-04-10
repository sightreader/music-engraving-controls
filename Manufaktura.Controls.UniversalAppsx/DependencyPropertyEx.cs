using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Manufaktura.Controls.UniversalApps
{
	public static class DependencyPropertyEx
	{
		public delegate void PropertyChangedCallback<TControl, TProperty>(TControl control, TProperty oldValue, TProperty newValue) where TControl : DependencyObject;

		public static DependencyProperty Register<TControl, TProperty>(Expression<Func<TControl, TProperty>> property, TProperty defaultValue, PropertyChangedCallback<TControl, TProperty> propertyChangedCallback = null) where TControl : DependencyObject
		{
			if (propertyChangedCallback == null)
				return DependencyProperty.Register(GetPropertyName(property), typeof(TProperty), typeof(TControl), new PropertyMetadata(defaultValue));

			return DependencyProperty.Register(GetPropertyName(property), typeof(TProperty), typeof(TControl), new PropertyMetadata(defaultValue, (obj, args) =>
			{
				propertyChangedCallback(obj as TControl, (TProperty)args.OldValue, (TProperty)args.NewValue);
			}));
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