using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin.Shapes
{
	public class Arc : ManufakturaShape
	{
		// Using a DependencyProperty as the backing store for RX.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty RXProperty = BindableProperty.Create<Arc, double>(a => a.RX, 0);

		// Using a DependencyProperty as the backing store for RX.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty RYProperty = BindableProperty.Create<Arc, double>(a => a.RY, 0);

		// Using a DependencyProperty as the backing store for SweepAngle.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty SweepAngleProperty = BindableProperty.Create<Arc, double>(a => a.SweepAngle, 180);

		public double RX
		{
			get { return (double)GetValue(RXProperty); }
			set { SetValue(RXProperty, value); }
		}

		public double RY
		{
			get { return (double)GetValue(RYProperty); }
			set { SetValue(RYProperty, value); }
		}

		public double SweepAngle
		{
			get { return (double)GetValue(SweepAngleProperty); }
			set { SetValue(SweepAngleProperty, value); }
		}
	}
}