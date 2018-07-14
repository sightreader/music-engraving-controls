/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

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