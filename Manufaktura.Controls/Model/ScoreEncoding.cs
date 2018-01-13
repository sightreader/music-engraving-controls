using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{

    /// <summary>
    /// Score encoding information.
    /// </summary>
    public class ScoreEncoding
    {
        /// <summary>
        /// List of software MusicXml elements
        /// </summary>
        public List<string> Software { get; private set; }

        /// <summary>
        /// Initializes a new instance of ScoreEncoding.
        /// </summary>
        public ScoreEncoding()
        {
            Software = new List<string>();
        }
    }
}