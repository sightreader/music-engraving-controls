using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin.Shapes
{
	public class Line : ManufakturaShape
	{
		// Using a DependencyProperty as the backing store for EndX.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty EndXProperty = BindableProperty.Create<Line, double>(l => l.EndX, 0);

		public static readonly BindableProperty EndYProperty = BindableProperty.Create<Line, double>(l => l.EndY, 0);

		public double EndX
		{
			get { return (double)GetValue(EndXProperty); }
			set { SetValue(EndXProperty, value); }
		}

		public double EndY
		{
			get { return (double)GetValue(EndYProperty); }
			set { SetValue(EndYProperty, value); }
		}
	}
}