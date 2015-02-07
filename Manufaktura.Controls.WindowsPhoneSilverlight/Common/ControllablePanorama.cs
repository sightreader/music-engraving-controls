using Manufaktura.Model.MVVM;
using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Manufaktura.Controls.WindowsPhoneSilverlight.Common
{
    public class ControllablePanorama : Panorama
    {
        public ViewModel SelectedViewModel
        {
            get { return (ViewModel)GetValue(SelectedViewModelProperty); }
            set { SetValue(SelectedViewModelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedViewModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedViewModelProperty =
            DependencyProperty.Register("SelectedViewModel", typeof(ViewModel), typeof(ControllablePanorama), new PropertyMetadata(null, SelectedViewModelChanged));

        private static void SelectedViewModelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue == null) return;
            ControllablePanorama panorama = (ControllablePanorama)d;
            panorama.DefaultItem = panorama.Items.Cast<FrameworkElement>().FirstOrDefault(i => i.DataContext == e.NewValue);
        }
    }
}
