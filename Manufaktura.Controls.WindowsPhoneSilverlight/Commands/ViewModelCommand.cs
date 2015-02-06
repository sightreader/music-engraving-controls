using Manufaktura.Model.MVVM;
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Manufaktura.Controls.WindowsPhoneSilverlight.Commands
{
    public abstract class ViewModelCommand<TViewModel, TParameter> : Command<TParameter> where TViewModel : ViewModel
    {
        public TViewModel CurrentViewModel { get; protected set; }

        protected ViewModelCommand(TViewModel currentViewModel)
        {
            CurrentViewModel = currentViewModel;
        }
    }

    public abstract class ViewModelCommand<TViewModel> : Command where TViewModel : ViewModel
    {
        public TViewModel CurrentViewModel { get; protected set; }

        protected ViewModelCommand(TViewModel currentViewModel)
        {
            CurrentViewModel = currentViewModel;
        }
    }
}
