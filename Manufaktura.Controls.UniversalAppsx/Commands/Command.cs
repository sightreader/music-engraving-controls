using System;
using System.Net;
using System.Windows;
using System.Windows.Input;

namespace Manufaktura.Controls.UniversalApps.Commands
{
    public abstract class Command<TParameter> : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return CanExecuteCommand((TParameter)parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            ExecuteCommand((TParameter)parameter);
        }

        public abstract bool CanExecuteCommand(TParameter parameter);
        public abstract void ExecuteCommand(TParameter parameter);
    }

    public abstract class Command : ICommand
    {

        public bool CanExecute(object parameter)
        {
            return CanExecuteCommand();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            ExecuteCommand();
        }

        public abstract bool CanExecuteCommand();
        public abstract void ExecuteCommand();
    }
}
