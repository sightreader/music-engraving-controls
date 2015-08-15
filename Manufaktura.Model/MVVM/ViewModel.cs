using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

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
    }
}
