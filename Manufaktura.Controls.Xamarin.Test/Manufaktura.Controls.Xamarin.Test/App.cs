using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin.Test
{
	public class App : Application
	{
		NoteViewer noteViewer1 = new NoteViewer();
		NoteViewer noteViewer2 = new NoteViewer() { RenderingMode = Rendering.ScoreRenderingModes.AllPages };
		Button button = new Button();
		TestViewModel vm = new TestViewModel();
		public App()
		{
			//noteViewer1.HeightRequest = 300;
			//noteViewer2.HeightRequest = 300;
			// The root page of your application
			MainPage = new ContentPage
			{
				Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        BackgroundColor = Color.White,
                        Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Manufaktura.Controls.Xamarin"
                        },
                        noteViewer1,
                        noteViewer2
                    }
                    }
                }
			};
			
		}


		protected override void OnStart()
		{
			MainPage.BindingContext = vm;
			vm.LoadTestData();
			noteViewer1.SetBinding<TestViewModel>(NoteViewer.ScoreSourceProperty, s => s.Data);
			noteViewer2.SetBinding<TestViewModel>(NoteViewer.ScoreSourceProperty, s => s.Data2);
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
