using Android.Graphics;
using Manufaktura.Controls.Xamarin.Droid.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Line), typeof(LineRenderer))]
namespace Manufaktura.Controls.Xamarin.Droid.Renderers
{
	public class LineRenderer : ViewRenderer<Line, LineRenderer>
	{
		protected override void OnDraw(Canvas canvas)
		{
			base.OnDraw(canvas);
		}
	}
}