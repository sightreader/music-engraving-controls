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