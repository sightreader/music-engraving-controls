using Manufaktura.Controls.Model;
using Manufaktura.Model.MVVM;
using System;
using System.Net;
using System.Windows;
using System.Windows.Input;

namespace Manufaktura.Controls.UniversalApps.Commands
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
