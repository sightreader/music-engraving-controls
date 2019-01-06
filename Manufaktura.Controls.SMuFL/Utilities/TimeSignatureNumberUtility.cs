using Manufaktura.Controls.Model.SMuFL;
using System;
using System.Text;

namespace Manufaktura.Controls.SMuFL.Utilities
{
    public class TimeSignatureNumberUtility : NumberUtility
    {
        public override string BuildNumber(int number)
        {
            var sb = new StringBuilder();
            var digits = number.ToString();
            foreach (var digit in digits)
            {
                if (digit == '0') sb.Append(SMuFLGlyphs.Instance.TimeSig0.Character);
                if (digit == '1') sb.Append(SMuFLGlyphs.Instance.TimeSig1.Character);
                if (digit == '2') sb.Append(SMuFLGlyphs.Instance.TimeSig2.Character);
                if (digit == '3') sb.Append(SMuFLGlyphs.Instance.TimeSig3.Character);
                if (digit == '4') sb.Append(SMuFLGlyphs.Instance.TimeSig4.Character);
                if (digit == '5') sb.Append(SMuFLGlyphs.Instance.TimeSig5.Character);
                if (digit == '6') sb.Append(SMuFLGlyphs.Instance.TimeSig6.Character);
                if (digit == '7') sb.Append(SMuFLGlyphs.Instance.TimeSig7.Character);
                if (digit == '8') sb.Append(SMuFLGlyphs.Instance.TimeSig8.Character);
                if (digit == '9') sb.Append(SMuFLGlyphs.Instance.TimeSig9.Character);
            }
            return sb.ToString();
        }

        public override BoundingBox GetBoundingBox(ISMuFLFontMetadata metadata, char digit)
        {
            if (digit == '0') return metadata.GlyphBBoxes.TimeSig0;
            if (digit == '1') return metadata.GlyphBBoxes.TimeSig1;
            if (digit == '2') return metadata.GlyphBBoxes.TimeSig2;
            if (digit == '3') return metadata.GlyphBBoxes.TimeSig3;
            if (digit == '4') return metadata.GlyphBBoxes.TimeSig4;
            if (digit == '5') return metadata.GlyphBBoxes.TimeSig5;
            if (digit == '6') return metadata.GlyphBBoxes.TimeSig6;
            if (digit == '7') return metadata.GlyphBBoxes.TimeSig7;
            if (digit == '8') return metadata.GlyphBBoxes.TimeSig8;
            if (digit == '9') return metadata.GlyphBBoxes.TimeSig9;
            throw new Exception($"Character {digit} is not a digit.");
        }
    }
}