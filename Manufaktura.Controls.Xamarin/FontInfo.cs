using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin
{
	public struct FontInfo
	{
		public FontInfo(string fontFamily, FontAttributes fontAttributes, double fontSize)
		{
			FontFamily = fontFamily;
			Attributes = fontAttributes;
			FontSize = fontSize;
		}

		public FontInfo(string fontFamily, double fontSize)
		{
			FontFamily = fontFamily;
			Attributes = FontAttributes.None;
			FontSize = fontSize;
		}

		public FontAttributes Attributes { get; set; }
		public string FontFamily { get; set; }
		public double FontSize { get; set; }
	}
}