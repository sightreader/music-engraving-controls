using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin.Shapes
{
	public class BezierCurve : ManufakturaShape
	{
		// Using a DependencyProperty as the backing store for X2.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty X2Property = BindableProperty.Create<BezierCurve, double>(b => b.X2, 0);

		// Using a DependencyProperty as the backing store for X3.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty X3Property = BindableProperty.Create<BezierCurve, double>(b => b.X3, 0);

		// Using a DependencyProperty as the backing store for X4.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty X4Property = BindableProperty.Create<BezierCurve, double>(b => b.X4, 0);

		// Using a DependencyProperty as the backing store for X2.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty Y2Property = BindableProperty.Create<BezierCurve, double>(b => b.Y2, 0);

		// Using a DependencyProperty as the backing store for X3.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty Y3Property = BindableProperty.Create<BezierCurve, double>(b => b.Y3, 0);

		// Using a DependencyProperty as the backing store for X4.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty Y4Property = BindableProperty.Create<BezierCurve, double>(b => b.Y4, 0);

		public double X2
		{
			get { return (double)GetValue(X2Property); }
			set { SetValue(X2Property, value); }
		}

		public double X3
		{
			get { return (double)GetValue(X3Property); }
			set { SetValue(X3Property, value); }
		}

		public double X4
		{
			get { return (double)GetValue(X4Property); }
			set { SetValue(X4Property, value); }
		}

		public double Y2
		{
			get { return (double)GetValue(Y2Property); }
			set { SetValue(Y2Property, value); }
		}

		public double Y3
		{
			get { return (double)GetValue(Y3Property); }
			set { SetValue(Y3Property, value); }
		}

		public double Y4
		{
			get { return (double)GetValue(Y4Property); }
			set { SetValue(Y4Property, value); }
		}
	}
}