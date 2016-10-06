using System.Collections.Generic;
using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin.Shapes
{
	public class DrawableCanvas : View
	{
		public List<View> Children { get; } = new List<View>();
	}
}