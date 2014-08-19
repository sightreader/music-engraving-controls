using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    public class MusicXmlNormalizer : XTransformerParser
    {
        public bool NormalizeSpaceBeforeFirstNotesOfMeasures { get; set; }

        public override XDocument Parse(XDocument source)   //TODO: Przetestować dokładnie i zrefaktorować
        {
            if (!NormalizeSpaceBeforeFirstNotesOfMeasures) return source;

            foreach (XElement staffNode in source.Descendants(XName.Get("part")))
            {
                //
                // FIRST PASS: Determine median note default-x
                //
                List<double> measureWidths = new List<double>();
                List<double> spacesBeforeFirstNoteOfMeasure = new List<double>();
                foreach (XElement measureNode in staffNode.Descendants(XName.Get("measure")).Skip(1)) //Don't remove space in first measure
                {
                    //TODO: Nie uwzględniać taktu, który następuje zaraz po zmianie metrum/klucza/znaków przykluczowych

                    //Read widths of all measures:
                    double? measureWidth = null;
                    var widthAttribute = measureNode.Attributes().FirstOrDefault(a => a.Name == "width");
                    if (widthAttribute != null) measureWidth = UsefulMath.TryParse(widthAttribute.Value);
                    if (measureWidth.HasValue) measureWidths.Add(measureWidth.Value);

                    XElement firstNoteNode = measureNode.Descendants(XName.Get("note")).FirstOrDefault();
                    if (firstNoteNode != null)
                    {
                        double? noteDefaultX = null;
                        var defaultXAttribute = firstNoteNode.Attributes().FirstOrDefault(a => a.Name == "default-x");
                        if (defaultXAttribute != null) noteDefaultX = UsefulMath.TryParse(defaultXAttribute.Value);
                        if (noteDefaultX.HasValue) spacesBeforeFirstNoteOfMeasure.Add(noteDefaultX.Value);
                    }
                }
                double medianNoteDefaultX = UsefulMath.Median(spacesBeforeFirstNoteOfMeasure.ToArray());
                double averageNoteDefaultX = UsefulMath.Mean(spacesBeforeFirstNoteOfMeasure.ToArray());

                //
                // SECOND PASS: Apply calculated median note default-x to all measures
                //
                //TODO: Nie uwzględniać taktu, który następuje zaraz po zmianie metrum/klucza/znaków przykluczowych
                foreach (XElement measureNode in staffNode.Descendants(XName.Get("measure")).Skip(1))   //Don't remove space in first measure
                {
                    double? currentValue = null;
                    XElement firstNoteNode = measureNode.Descendants(XName.Get("note")).FirstOrDefault();
                    if (firstNoteNode == null) continue;

                    var defaultXAttribute = firstNoteNode.Attributes().FirstOrDefault(a => a.Name == "default-x");
                    if (defaultXAttribute == null) continue;

                    currentValue = UsefulMath.TryParse(defaultXAttribute.Value);
                    if (!currentValue.HasValue) continue;
                    double difference = currentValue.Value - medianNoteDefaultX;

                    if (currentValue > averageNoteDefaultX)
                    {
                        foreach (var noteNode in measureNode.Descendants(XName.Get("note")))
                        {
                            defaultXAttribute = noteNode.Attributes().FirstOrDefault(a => a.Name == "default-x");
                            if (defaultXAttribute == null) continue;

                            currentValue = UsefulMath.TryParse(defaultXAttribute.Value);
                            if (!currentValue.HasValue) continue;

                            defaultXAttribute.Value = (currentValue.Value - difference).ToString(CultureInfo.InvariantCulture);
                        }
                        var widthAttribute = measureNode.Attributes().FirstOrDefault(a => a.Name == "width");
                        currentValue = UsefulMath.TryParse(widthAttribute.Value);
                        if (!currentValue.HasValue) continue;
                        if (widthAttribute != null) widthAttribute.Value = (currentValue.Value - difference).ToString(CultureInfo.InvariantCulture);
                        
                    }
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
