using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    public class MusicXmlNormalizer : XTransformerParser
    {
        public bool NormalizeSpaceBeforeFirstNotesOfMeasures { get; set; }

        public override XDocument Parse(XDocument source)
        {
            foreach (XElement staffNode in source.Descendants(XName.Get("part")))
            {
                List<double> measureWidths = new List<double>();
                List<double> spacesBeforeFirstNoteOfMeasure = new List<double>();
                foreach (XElement measureNode in staffNode.Descendants(XName.Get("part")))
                {
                    //Read widths of all measures:
                    double? measureWidth = null;
                    var widthAttribute = measureNode.Attributes().FirstOrDefault(a => a.Name == "width");
                    if (widthAttribute != null)
                    {
                        double w;
                        if (double.TryParse(widthAttribute.Value, out w)) measureWidth = w;
                    }
                    if (measureWidth.HasValue) measureWidths.Add(measureWidth.Value);
                }
            }
            return source;
        }

        public override XDocument ParseBack(XDocument score)
        {
            throw new NotImplementedException();
        }
    }
}
