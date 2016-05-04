using Manufaktura.Controls.Xamarin.IoS.Renderers;
using Manufaktura.Controls.Xamarin.Shapes;
using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Text), typeof(TextRenderer))]

namespace Manufaktura.Controls.Xamarin.IoS.Renderers
{
	public class TextRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);
			Control.Font = UIFont.FromName(Element.FontFamily, (nfloat)Element.FontSize);
		}
	}
}