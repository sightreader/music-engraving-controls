using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Manufaktura.Controls.Avalonia.Test.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            //var noteViewer = this.FindControl<NoteViewer>("testViewer");
            //noteViewer.SetCustomFont(new FontFamily("Arial"), 2, PolihymniaFont.CreateProfile());
        }
    }
}