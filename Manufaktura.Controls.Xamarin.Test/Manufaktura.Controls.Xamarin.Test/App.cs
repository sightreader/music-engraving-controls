using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Manufaktura.Controls.Xamarin.Test
{
	public class App : Application
	{
		NoteViewer noteViewer = new NoteViewer();
		Button button = new Button();
		TestViewModel vm = new TestViewModel();
		public App()
		{
			button.Clicked += Button_Clicked;
			noteViewer.HeightRequest = 100;
			// The root page of your application
			MainPage = new ContentPage
			{
				Content = new StackLayout
				{
					BackgroundColor = Color.White,
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						},
						noteViewer
					}
				}
			};
			
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			
		}

		protected override void OnStart()
		{
			MainPage.BindingContext = vm;
			vm.LoadTestData();
			noteViewer.SetBinding<TestViewModel>(NoteViewer.ScoreSourceProperty, s => s.Data);
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
