/*
 * Copyright 2019 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Avalonia.Media;
using Manufaktura.Controls.Avalonia.FontPresets;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System;
using System.Linq;

namespace Manufaktura.Controls.Avalonia.Renderers
{
    public class AvaloniaScoreRendererSettings : ScoreRendererSettings
    {
        private Lazy<IFontPreset[]> availableFontPresets = new Lazy<IFontPreset[]>(() => typeof(IFontPreset).Assembly.GetTypes()
            .Where(t => !t.IsAbstract && typeof(IFontPreset).IsAssignableFrom(t) && t != typeof(CustomFontPreset))
            .Select(t => Activator.CreateInstance(t))
            .Cast<IFontPreset>()
            .ToArray());

        public IFontPreset SelectedFontPreset { get; private set; } = new PolihymniaFontPreset();

        public void SetFontPreset(PredefinedMusicFonts predefinedFont)
        {
            if (predefinedFont == PredefinedMusicFonts.Custom)
                throw new Exception($"You can't set font preset directly to {PredefinedMusicFonts.Custom}. Use {nameof(SetCustomFontPreset)} instead.");

            var matchingPreset = availableFontPresets.Value.FirstOrDefault(p => p.PredefinedFont == predefinedFont);
            if (matchingPreset == null)
                throw new Exception($"Unknown font preset {predefinedFont}.");

            matchingPreset.Load(this);
            SelectedFontPreset = matchingPreset;
        }

        public void SetCustomFontPreset(FontFamily family, double baseline, FontProfile musicFontProfile)
        {
            SelectedFontPreset = new CustomFontPreset(family, baseline, musicFontProfile);
        }
    }
}