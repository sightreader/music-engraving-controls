using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser.MusicXml
{
    public class MusicXmlParserState
    {
        int skipMeasures = 0;

        public int SkipMeasures
        {
            get { return skipMeasures; }
            set { skipMeasures = value; }
        }
        string partID = "";

        public string PartID
        {
            get { return partID; }
            set { partID = value; }
        }
        bool firstLoop = true;

        public bool FirstLoop
        {
            get { return firstLoop; }
            set { firstLoop = value; }
        }
        int currentTempo = 120;

        public int CurrentTempo
        {
            get { return currentTempo; }
            set { currentTempo = value; }
        }
        int currentDynamics = 80;

        public int CurrentDynamics
        {
            get { return currentDynamics; }
            set { currentDynamics = value; }
        }

        public bool BarlineAlreadyAdded { get; set; }

        public double LastSystemDistance { get; set; }
    }
}
