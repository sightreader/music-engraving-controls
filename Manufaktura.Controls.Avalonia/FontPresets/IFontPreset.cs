using Avalonia.Media;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;

namespace Manufaktura.Controls.Avalonia.FontPresets
{
    public interface IFontPreset
    {
        PredefinedMusicFonts PredefinedFont { get; }

        FontFamily Family { get; }

        double Baseline { get; }

        Typeface GetTypeface(MusicFontStyles style);

        void Load(ScoreRendererSettings settings);
    }
}