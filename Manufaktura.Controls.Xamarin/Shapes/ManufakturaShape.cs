using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin.Shapes
{
	public class ManufakturaShape : View
	{
		// Using a DependencyProperty as the backing store for Color.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty ColorProperty = BindableProperty.Create<ManufakturaShape, Primitives.Color>(s => s.Color, Primitives.Color.Black);

		// Using a DependencyProperty as the backing store for Thickness.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty ThicknessProperty = BindableProperty.Create<Line, double>(l => l.Thickness, 1);

		public Primitives.Color Color
		{
			get { return (Primitives.Color)GetValue(ColorProperty); }
			set { SetValue(ColorProperty, value); }
		}

		public double Thickness
		{
			get { return (double)GetValue(ThicknessProperty); }
			set { SetValue(ThicknessProperty, value); }
		}

		public float NonNativeScreenSize { get; set; }
	}
}