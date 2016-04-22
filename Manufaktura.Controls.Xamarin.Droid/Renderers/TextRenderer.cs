using Android.Graphics;
using Manufaktura.Controls.Xamarin.Droid.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//[assembly: ExportRenderer(typeof(Text), typeof(TextRenderer))]

namespace Manufaktura.Controls.Xamarin.Droid.Renderers
{
	public class TextRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);
			//Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Polihymnia.ttf");
			//Control.Typeface = font;
		}

	}
}