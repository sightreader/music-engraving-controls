namespace Manufaktura.Controls.Parser.MusicXml
{
	public class MusicXmlParserState
	{
		private int currentDynamics = 80;
		private int currentTempo = 120;
		private bool firstLoop = true;
		private string partID = "";
		private int skipMeasures = 0;

		public bool BarlineAlreadyAdded { get; set; }

		public int CurrentDynamics
		{
			get { return currentDynamics; }
			set { currentDynamics = value; }
		}

		public int CurrentSystemNo { get; set; }

		public int CurrentTempo
		{
			get { return currentTempo; }
			set { currentTempo = value; }
		}

		public bool FirstLoop
		{
			get { return firstLoop; }
			set { firstLoop = value; }
		}

		public string PartID
		{
			get { return partID; }
			set { partID = value; }
		}

		public int SkipMeasures
		{
			get { return skipMeasures; }
			set { skipMeasures = value; }
		}
	}
}