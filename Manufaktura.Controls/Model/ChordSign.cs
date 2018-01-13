using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Chord sign
    /// </summary>
	public class ChordSign : MusicalSymbol, IHasCustomYPosition, IRenderedAsTextBlock
	{
		public ChordSign(Chord chord)
		{
			Chord = chord;
		}

        /// <summary>
        /// Chord
        /// </summary>
		public Chord Chord { get; private set; }

		public double? DefaultYPosition
		{
			get;
			set;
		}

		public string MusicalCharacter
		{
			get { return Text; }
		}

		public Fonts.IMusicFont MusicFont
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
				throw new System.NotImplementedException();
			}
		}

        /// <summary>
        /// Chord symbol text
        /// </summary>
		public string Text { get; set; }

		public Primitives.Point TextBlockLocation
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
				throw new System.NotImplementedException();
			}
		}

		public override string ToString()
		{
			return string.Format("{0} {1}", base.ToString(), Chord.ToString());
		}
	}
}