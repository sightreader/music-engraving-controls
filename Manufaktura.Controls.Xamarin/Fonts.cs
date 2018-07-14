/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Manufaktura.Controls.Model.Fonts;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin
{
	public static class Fonts
	{
		private static Dictionary<MusicFontStyles, FontInfo> _fonts = new Dictionary<MusicFontStyles, FontInfo>()
			{
				{MusicFontStyles.MusicFont, new FontInfo("Polihymnia", 27.5)},
				{MusicFontStyles.GraceNoteFont, new FontInfo("Polihymnia", 20)},
				{MusicFontStyles.StaffFont, new FontInfo("Polihymnia", 30.5)},
				{MusicFontStyles.LyricsFont, new FontInfo("Times New Roman", 11)},
				{MusicFontStyles.LyricsFontBold, new FontInfo("Times New Roman", 0.8)},
				{MusicFontStyles.MiscArticulationFont, new FontInfo("Microsoft Sans Serif", 14)},
				{MusicFontStyles.DirectionFont, new FontInfo("Microsoft Sans Serif", 11)},
				{MusicFontStyles.TrillFont, new FontInfo("Times New Roman", 14)},
				{MusicFontStyles.TimeSignatureFont, new FontInfo("Microsoft Sans Serif", FontAttributes.Bold, 14.5)}
			};

		public static FontInfo Get(MusicFontStyles style)
		{
			return _fonts[style];
		}
	}
}