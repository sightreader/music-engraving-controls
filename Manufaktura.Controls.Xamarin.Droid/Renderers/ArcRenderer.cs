using Android.Graphics;
using Manufaktura.Controls.Xamarin.Droid.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Arc), typeof(ArcRenderer))]
namespace Manufaktura.Controls.Xamarin.Droid.Renderers
{
	public class ArcRenderer : ViewRenderer<Arc, ArcRenderer>
	{
		protected override void OnDraw(Canvas canvas)
		{
			base.OnDraw(canvas);
		}
	}
}