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
            ViewModel viewModel = e.NewValue as ViewModel;

            FrameworkElement view = MatchByConfiguration(viewModel) ?? MatchByConvention(viewModel);

            if (view != null) view.DataContext = e.NewValue;
            mapper.Content = view;
        }

        public static FrameworkElement MatchByConfiguration(ViewModel viewModel)
        {
            if (viewModel == null) return null;

            FrameworkElement view = null;
            try
            {
                var viewAttribute = viewModel.GetType().GetCustomAttributes(typeof(ViewAttribute), true).Cast<ViewAttribute>().FirstOrDefault();
                if (viewAttribute != null)
                {
                    view = Activator.CreateInstance(viewAttribute.ViewType) as FrameworkElement;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while matching ViewModel with view by configuration.", ex);
            }
            return view;
        }

        public static FrameworkElement MatchByConvention(ViewModel viewModel)
        {
            if (viewModel == null) return null;

            FrameworkElement view = null;
            try
            {
                AppDomain domain = AppDomain.CurrentDomain;
                Assembly[] assembliesLoaded = domain.GetAssemblies();
                foreach (var assembly in assembliesLoaded)
                {
                    var viewTypes = assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(UserControl)));
                    var matchingViewType = viewTypes.FirstOrDefault(t => t.Name == viewModel.GetType().Name.Replace("Model", ""));
                    if (matchingViewType != null) view = Activator.CreateInstance(matchingViewType) as FrameworkElement;
                    if (view != null) break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while matching ViewModel with view by convention.", ex);
            }
            return view;
        }

    }
}
