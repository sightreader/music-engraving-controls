using Manufaktura.Model.MVVM;
using System;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Manufaktura.Controls.Silverlight.Common
{
    public class ModelViewMapper : ContentControl
    {
        public ViewModel CurrentViewModel
        {
            get { return (ViewModel)GetValue(CurrentViewModelProperty); }
            set { SetValue(CurrentViewModelProperty, value); }
        }

        public static readonly DependencyProperty CurrentViewModelProperty =
            DependencyProperty.Register("CurrentViewModel", typeof(ViewModel), typeof(ModelViewMapper), new PropertyMetadata(null, CurrentViewModelChanged));

        public static void CurrentViewModelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ModelViewMapper mapper = d as ModelViewMapper;
            FrameworkElement view = null;

            if (e.NewValue == null)
            {
                mapper.Content = null;
                return;
            }
 
            //Dopasuj po konfiguracji / Match by configuration:
            try
            {
                var viewAttribute = e.NewValue.GetType().GetCustomAttributes(typeof(ViewAttribute), true).Cast<ViewAttribute>().FirstOrDefault();
                if (viewAttribute != null)
                {
                    view = Activator.CreateInstance(viewAttribute.ViewType) as FrameworkElement;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while matching ViewModel with view by configuration.", ex);
            }

            //Dopasuj po konwencji / Match by convention:
            try
            {
                if (view == null)
                {
                    var viewTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(UserControl)));
                    var matchingViewType = viewTypes.FirstOrDefault(t => t.Name == e.NewValue.GetType().Name.Replace("Model", ""));
                    if (matchingViewType != null) view = Activator.CreateInstance(matchingViewType) as FrameworkElement;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while matching ViewModel with view by convention.", ex);
            }

            if (view != null) view.DataContext = e.NewValue;
            mapper.Content = view;
        }

    }
}
