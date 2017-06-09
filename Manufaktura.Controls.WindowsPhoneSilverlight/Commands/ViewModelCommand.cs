using Manufaktura.Controls.Model;

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
