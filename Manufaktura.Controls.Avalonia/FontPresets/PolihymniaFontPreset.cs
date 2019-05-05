using Avalonia.Media;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Avalonia.FontPresets
{
    public class PolihymniaFontPreset : IFontPreset
    {
        public PredefinedMusicFonts PredefinedFont => PredefinedMusicFonts.Polihymnia;

        public FontFamily Family { get; } = new FontFamily("Polihymnia", new Uri("resm:Manufaktura.Controls.Avalonia.Assets.?assembly=Manufaktura.Controls.Avalonia#Polihymnia"));

        public double Baseline => 0.9052734375;

        private readonly Dictionary<MusicFontStyles, Typeface> fonts;

        public PolihymniaFontPreset()
        {
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
            settings.SetPolihymniaFont();
        }
    }
}