using Manufaktura.Controls.WindowsPhoneSilverlight.Test.Resources;

namespace Manufaktura.Controls.WindowsPhoneSilverlight.Test
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}