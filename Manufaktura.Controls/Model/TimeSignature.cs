using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
	public class TimeSignature : MusicalSymbol
	{
		protected Proportion numberValue;
		protected TimeSignatureType signatureType;

		public TimeSignature(TimeSignatureType sType, int beats, int beatType)
		{
			numberValue = new Proportion(beats, beatType);
			signatureType = sType;
		}

		public static TimeSignature CommonTime
		{
			get
			{
				return new TimeSignature(TimeSignatureType.Common, 4, 4);
			}
		}

		public static TimeSignature CutTime
		{
			get
			{
				return new TimeSignature(TimeSignatureType.Cut, 2, 2);
			}
		}

		public int NumberOfBeats { get { return numberValue.Numerator; } }

		public Proportion NumberValue { get { return numberValue; } set { numberValue = value; OnPropertyChanged(() => NumberValue); } }

		public TimeSignatureType SignatureType { get { return signatureType; } set { signatureType = value; } }

		public override MusicalSymbolType Type
		{
			get
			{
				return MusicalSymbolType.TimeSignature;
			}
		}

		public int TypeOfBeats { get { return numberValue.Denominator; } }

		/// <summary>
		/// Returns how many whole notes can be fitted into one measure.
		/// </summary>
		public double WholeNoteCapacity
		{
			get
			{
				return numberValue.DoubleValue;
			}
		}
	}
}