using System;
using System.Windows.Input;

namespace Manufaktura.Controls.Avalonia.Test.ViewModels
{
    public class ActionCommand : ICommand
    {
        private readonly Action action;

        public ActionCommand(Action action)
        {
            this.action = action;
        }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            action?.Invoke();
        }
    }
}