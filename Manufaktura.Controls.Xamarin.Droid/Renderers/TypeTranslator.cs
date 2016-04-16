using Android.Graphics;

namespace Manufaktura.Controls.Xamarin.Droid.Renderers
{
	public static class TypeTranslator
	{
		public static Color ToAndroidColor(this Primitives.Color color)
		{
			return new Color(color.R, color.G, color.B, color.A);
		}
	}
}