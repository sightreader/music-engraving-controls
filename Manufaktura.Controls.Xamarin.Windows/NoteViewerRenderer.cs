using System.ComponentModel;
using System.Reflection;
using Xamarin.Forms.Platform.UWP;
using ManUniversal = Manufaktura.Controls.UniversalApps;
using ManXamarin = Manufaktura.Controls.Xamarin;

namespace Manufaktura.Controls.Xamarin.Windows
{
	public class NoteViewerRenderer : ViewRenderer<ManXamarin.NoteViewer, ManUniversal.NoteViewer>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<NoteViewer> e)
		{
			base.OnElementChanged(e);

			foreach (var targetProperty in typeof(ManUniversal.NoteViewer).GetProperties())
			{
				var sourceProperty = typeof(ManXamarin.NoteViewer).GetProperty(targetProperty.Name);
				if (sourceProperty == null) continue;

				targetProperty.SetValue(Control, sourceProperty.GetValue(Element));
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			var sourceProperty = typeof(ManXamarin.NoteViewer).GetProperty(e.PropertyName);
			if (sourceProperty == null) return;

			var targetProperty = typeof(ManUniversal.NoteViewer).GetProperty(e.PropertyName);
			if (targetProperty == null) return;

			targetProperty.SetValue(Control, sourceProperty.GetValue(Element));
		}
	}
}