using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
	/// <summary>
	/// Represents a single word
	/// </summary>
	public class Lyrics : IHasCustomYPosition
	{
		/// <summary>
		/// Initializes a new insance of Lyrics.
		/// </summary>
		public Lyrics()
		{
		}

		public Lyrics(SyllableType type, string text, double? defaultY)
		{
			Syllables.Add(new Syllable(type, text));
			DefaultYPosition = defaultY;
		}

		public Lyrics(SyllableType type, string text)
			: this(type, text, null)
		{
		}

		public double? DefaultYPosition { get; set; }

		public int Number { get; set; }

		/// <summary>
		/// Syllables that form a single word
		/// </summary>
		public List<Syllable> Syllables { get; set; } = new List<Syllable>();

		/// <summary>
		/// String value of word
		/// </summary>
		public string Text
		{
			get
			{
				StringBuilder sb = new StringBuilder();
				foreach (Syllable syllable in Syllables)
				{
					sb.Append(syllable.ElisionMark);
					sb.Append(syllable.Text);
				}
				return sb.ToString();
			}
		}

		/// <summary>
		/// Type of last (or only) syllable in word.
		/// </summary>
		public SyllableType Type
		{
			get
			{
				Syllable lastSyllable = Syllables.LastOrDefault();
				if (lastSyllable == null) return SyllableType.Single;
				return lastSyllable.Type;
			}
		}

		public class Syllable
		{
			public Syllable()
			{
			}

			public Syllable(SyllableType type, string text)
			{
				Type = type;
				Text = text;
			}

			public string ElisionMark { get; set; }

			public string Text { get; set; }

			public SyllableType Type { get; set; }
		}
	}
}