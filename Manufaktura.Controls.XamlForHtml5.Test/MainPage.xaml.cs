using Manufaktura.Controls.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Manufaktura.Controls.XamlForHtml5.Test
{
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
			var score = Score.CreateOneStaffScore(Clef.BaritoneC, MajorScale.C);
			foreach (var element in score.FirstStaff.Elements)
			{

			}
		}
	}
}
