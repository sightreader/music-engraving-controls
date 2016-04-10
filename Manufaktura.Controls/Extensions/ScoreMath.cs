namespace Manufaktura.Controls.Extensions
{
	public static class ScoreMath
	{
		/// <summary>
		/// Returns stem end position for middle note in a group of notes under one beam.
		/// </summary>
		/// <param name="firstNote"></param>
		/// <param name="lastNote"></param>
		/// <param name="searchedNote"></param>
		/// <returns></returns>
		public static double StemEnd(double firstNoteX, double firstNoteY, double middleNoteX, double lastNoteX, double lastNoteY)
		{
			var firstToMiddleX = middleNoteX - firstNoteX;
			var lastToFirstX = lastNoteX - firstNoteX;
			var lastToFirstY = lastNoteY - firstNoteY;
			return (firstToMiddleX * lastToFirstY) / lastToFirstX;
		}
	}
}