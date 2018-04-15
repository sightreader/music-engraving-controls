using Manufaktura.Controls.Model.Assertions;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Rendering;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a barline.
    /// </summary>
    public class Barline : MusicalSymbol
    {
        private RepeatSignType repeatSign;

        /// <summary>
        /// Initializes a new instance of Barline.
        /// </summary>
        public Barline()
        {
            Location = HorizontalPlacement.Right;
            repeatSign = RepeatSignType.None;
        }

        /// <summary>
        /// Initializes a new instance of Barline with specific BarlineStyle
        /// </summary>
        public Barline(BarlineStyle style) : this()
        {
            Style = style;
        }

        /// <summary>
        /// Barline horizontal location
        /// </summary>
        public HorizontalPlacement Location { get; set; }

        public double RenderedXPositionForFirstStaffInMultiStaffPart { get; internal set; }
        /// <summary>
        /// Barline repeat sign
        /// </summary>
		public RepeatSignType RepeatSign { get { return repeatSign; } set { repeatSign = value; } }

        /// <summary>
        /// Barline style
        /// </summary>
		public BarlineStyle Style { get; set; } = BarlineStyle.Regular;

        public char GetCharacter(IMusicFont font)
        {
            if (RepeatSign == RepeatSignType.Backward) return font.RepeatBackward;
            else if (RepeatSign == RepeatSignType.Forward) return font.RepeatForward;
            else return '\0';
        }

        [Units(Units.Linespaces)]
        public BoundingBox GetSMuFLBoundingBox(SMuFLFontMetadata metadata)
        {
            if (RepeatSign == RepeatSignType.Backward) return metadata.GlyphBBoxes.RepeatRight;
            else if (RepeatSign == RepeatSignType.Forward) return metadata.GlyphBBoxes.RepeatLeft;
            else return null;
        }


        [Units(Units.Pixels)]
        public BoundingBox GetSMuFLBoundingBoxPx(SMuFLFontMetadata metadata, ScoreRendererSettings settings)
        {
            var bbox = GetSMuFLBoundingBox(metadata);
            return new BoundingBox
            {
                BBoxNe = new double[] { bbox.BBoxNe[0] * settings.LineSpacing, bbox.BBoxNe[1] * settings.LineSpacing },
                BBoxSw = new double[] { bbox.BBoxSw[0] * settings.LineSpacing, bbox.BBoxSw[1] * settings.LineSpacing }
            };
        }
    }
}