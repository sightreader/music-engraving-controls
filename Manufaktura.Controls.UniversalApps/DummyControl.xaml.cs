using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Manufaktura.Controls.UniversalApps
{
    public partial class DummyControl : UserControl
    {
        public DummyControl()
        {
            InitializeComponent();
        }

        public FontFamily DummyFontFamily => dummyTextBlock.FontFamily;
    }
}