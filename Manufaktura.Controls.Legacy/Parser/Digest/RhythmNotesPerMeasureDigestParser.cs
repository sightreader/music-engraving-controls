using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser.Digest
{
    class RhythmNotesPerMeasureDigestParser : ScoreParser<double[]>
    {
        public override Model.Score Parse(double[] source)
        {
            throw new NotImplementedException();
        }

        public override double[] ParseBack(Score score) //TODO: Dokończyć
        {
            List<double> digest = new List<double>();
            int timeSignatureBase = 4;
            double remainingRhythmicPart = 0;
            foreach (Staff staff in score.Staves)
            {
                foreach (var element in staff.Elements)
                {
                    TimeSignature timeSignature = element as TimeSignature;
                    if (timeSignature != null)
                    {
                        timeSignatureBase = (int)timeSignature.TypeOfBeats;
                        continue;
                    }
                    IHasDuration rhythmicElement = element as IHasDuration;
                    if (rhythmicElement == null) continue;

                    double fractionOfMeasure = timeSignatureBase / (double)rhythmicElement.BaseDuration.Denominator;
                    if (rhythmicElement.NumberOfDots > 0)
                    {
                        fractionOfMeasure += fractionOfMeasure * (1 / Math.Pow(2, rhythmicElement.NumberOfDots));
                    }
                    //TODO: Obsłużyć też wiązanie nut łukami

                    int numberOfPartsOccupied = (int)Math.Ceiling(fractionOfMeasure);
                    while (fractionOfMeasure > 0)
                    {
                        remainingRhythmicPart = 1 / fractionOfMeasure;
                        digest.Add(remainingRhythmicPart);
                        fractionOfMeasure -= 1;
                    }
                }
            }
            return digest.ToArray();
        }
    }
}
