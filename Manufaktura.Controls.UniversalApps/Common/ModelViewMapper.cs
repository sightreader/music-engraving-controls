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

using Manufaktura.Controls.Model;
using Manufaktura.Model.MVVM;
using System;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace Manufaktura.Controls.UniversalApps.Common
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

            FrameworkElement view = MatchByConfiguration(viewModel, mapper.ViewKind) ?? MatchByConvention(viewModel);

            if (view != null) view.DataContext = e.NewValue;
            mapper.Content = view;
        }

        public ViewKinds? ViewKind
        {
            get { return (ViewKinds?)GetValue(ViewKindProperty); }
            set { SetValue(ViewKindProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ViewKind.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ViewKindProperty =
            DependencyProperty.Register("ViewKind", typeof(ViewKinds?), typeof(ModelViewMapper), new PropertyMetadata(null));

        

        public static FrameworkElement MatchByConfiguration(ViewModel viewModel, ViewKinds? desiredKind)
        {
            if (viewModel == null) return null;

            FrameworkElement view = null;
            try
            {
                var viewAttributes = viewModel.GetType().GetTypeInfo().GetCustomAttributes<ViewAttribute>(true);
                //Jeśli ViewKind na kontrolce jest ustawione, bierz tylko widoki odpowiadające temu ViewKind. Jeśli nie jest ustawione, bierz widoki bez ustawionego ViewKind.
                var viewAttribute = desiredKind.HasValue ? viewAttributes.Cast<ViewAttribute>().FirstOrDefault(va => va.ViewKind.HasValue && va.ViewKind.Value == desiredKind.Value)
                                                         : viewAttributes.Cast<ViewAttribute>().FirstOrDefault(va => !va.ViewKind.HasValue);
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
            return null;    //TODO: Znaleźć ekwiwalent dla AppDomain
            /*if (viewModel == null) return null;

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
             * */
        }

    }
}
