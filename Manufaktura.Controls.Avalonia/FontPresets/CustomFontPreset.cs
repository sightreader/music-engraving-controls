using Avalonia.Media;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;

namespace Manufaktura.Controls.Avalonia.FontPresets
{
    public class CustomFontPreset : IFontPreset
    {
        public PredefinedMusicFonts PredefinedFont => PredefinedMusicFonts.Custom;

        public FontFamily Family { get; private set; }

        public double Baseline { get; private set; }
        private readonly Dictionary<MusicFontStyles, Typeface> fonts;
        private readonly FontProfile fontProfile;

        public CustomFontPreset(FontFamily fontFamily, double baseline, FontProfile fontProfile)
        {
            Family = fontFamily;
            Baseline = baseline;
            this.fontProfile = fontProfile;
            fonts = new Dictionary<MusicFontStyles, Typeface>()
            {
                {MusicFontStyles.MusicFont, new Typeface(Family, 27.5, FontStyle.Normal, FontWeight.Normal)},
                {MusicFontStyles.GraceNoteFont, new Typeface(Family, 22, FontStyle.Normal, FontWeight.Normal)},
                {MusicFontStyles.StaffFont, new Typeface(Family, 30.5, FontStyle.Normal, FontWeight.Normal)},
                {MusicFontStyles.LyricsFont, new Typeface("Times New Roman", 11)},
                {MusicFontStyles.DirectionFont, new Typeface("Microsoft Sans Serif", 14.5)},
                {MusicFontStyles.TimeSignatureFont, new Typeface(new FontFamily("Microsoft Sans Serif"), 14.5, FontStyle.Normal, FontWeight.Bold)}
            };
        }

        public Typeface GetTypeface(MusicFontStyles style) => fonts[style];

        public void Load(ScoreRendererSettings settings)
        {
            foreach (var size in fontProfile.FontSizes)
            {
                if (!fonts.ContainsKey(size.Key)) continue;
                var tf = fonts[size.Key];
                fonts[size.Key] = new Typeface(tf.FontFamily, size.Value, tf.Style, tf.Weight);
            }
            settings.SetMusicFontProfile(fontProfile);
        }
    }
}