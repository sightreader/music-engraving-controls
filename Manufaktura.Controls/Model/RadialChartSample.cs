using Manufaktura.Model.MVVM;

namespace Manufaktura.Controls.Model
{
	public class RadialChartSample : ViewModel
	{
		private string axisDisplayName;
		private string axisShortName;
		private double value;

		public RadialChartSample(string axisDisplayName, string axisShortName, double value)
		{
			this.axisDisplayName = axisDisplayName;
			this.axisShortName = axisShortName;
			this.value = value;
		}

		public string AxisDisplayName
		{
			get
			{
				return axisDisplayName;
			}

			set
			{
				axisDisplayName = value;
				OnPropertyChanged();
			}
		}

		public string AxisShortName
		{
			get
			{
				return axisShortName;
			}

			set
			{
				axisShortName = value;
				OnPropertyChanged();
			}
		}

		public double Value
		{
			get
			{
				return value;
			}

			set
			{
				this.value = value;
				OnPropertyChanged();
			}
		}
	}
}