using Avalonia.Media;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using Manufaktura.Controls.SMuFL;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Avalonia.FontPresets
{
    public abstract class SMuFLFontPreset : IFontPreset
    {
        public abstract PredefinedMusicFonts PredefinedFont { get; }
        public abstract string FontName { get; }
        public FontFamily Family { get; private set; }
        private Dictionary<MusicFontStyles, Typeface> fonts;
        public virtual double Baseline => 2.012;

        public Typeface GetTypeface(MusicFontStyles style) => fonts[style];

        public void Load(ScoreRendererSettings settings)
        {
            Family = new FontFamily(FontName, new Uri($"resm:Manufaktura.Controls.Avalonia.Assets.?assembly=Manufaktura.Controls.Avalonia#{FontName}"));
            var fontProfile = SMuFLMusicFont.CreateFromJsonResource<NoteViewer>($"Assets.{FontName.ToLowerInvariant()}_metadata.json", SMuFLMusicFont.JSONLoadingModes.LazyWithStaticProxy);
            fonts = new Dictionary<MusicFontStyles, Typeface>()
            {
                {MusicFontStyles.MusicFont, new Typeface(Family, 27.5, FontStyle.Normal, FontWeight.Normal)},
                {MusicFontStyles.GraceNoteFont, new Typeface(Family, 22, FontStyle.Normal, FontWeight.Normal)},
                {MusicFontStyles.StaffFont, new Typeface(Family, 30.5, FontStyle.Normal, FontWeight.Normal)},
                {MusicFontStyles.LyricsFont, new Typeface("Times New Roman", 11)},
                {MusicFontStyles.DirectionFont, new Typeface("Microsoft Sans Serif", 14.5)},
                {MusicFontStyles.TimeSignatureFont, new Typeface(new FontFamily("Microsoft Sans Serif"), 14.5, FontStyle.Normal, FontWeight.Bold)}
            };
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