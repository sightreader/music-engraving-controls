using Manufaktura.Controls.Model.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public abstract class HtmlScoreRenderer<TCanvas> : ScoreRenderer<TCanvas>
    {
        public HtmlScoreRendererSettings TypedSettings { get { return Settings as HtmlScoreRendererSettings; } }
        public string ScoreElementName { get; set; }
        protected HtmlScoreRenderer(TCanvas canvas)
            : base(canvas)
        {
        }

        protected Primitives.Point TranslateTextLocation(Primitives.Point location, MusicFontStyles fontStyle)
        {
            double locationX = location.X + 3d + TypedSettings.MusicalFontShiftX;
            double locationY;
            switch (fontStyle)
            {
                case MusicFontStyles.MusicFont:
                    locationY = location.Y + 25d + TypedSettings.MusicalFontShiftY;
                    break;
                case MusicFontStyles.GraceNoteFont:
                    locationY = location.Y + 17.5d + TypedSettings.MusicalFontShiftY;
                    locationX += 0.7d;
                    break;
                default:
                    locationY = location.Y + 14d + TypedSettings.MusicalFontShiftY;
                    break;
            }
            return new Primitives.Point(locationX, locationY);
        }
    }
}
