using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Services;
using System;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering a TimeSignature.
    /// </summary>
    public class TimeSignatureRenderStrategy : MusicalSymbolRenderStrategy<TimeSignature>
    {

        /// <summary>
        /// Initializes a new instance of TimeSignatureRenderStrategy
        /// </summary>
        /// <param name="scoreService"></param>
        public TimeSignatureRenderStrategy(IScoreService scoreService) : base(scoreService)
        {
        }

        /// <summary>
        /// Renders time signature symbol with specific score renderer
        /// </summary>
        /// <param name="element"></param>
        /// <param name="renderer"></param>
        public override void Render(TimeSignature element, ScoreRendererBase renderer)
        {
            var topLinePosition = scoreService.CurrentLinePositions[0];
            scoreService.CursorPositionX += renderer.LinespacesToPixels(1); //Żeby był lekki margines między kreską taktową a symbolem. Być może ta linijka będzie do usunięcia

            if (element.SignatureType != TimeSignatureType.Numbers)
            {
                renderer.DrawCharacter(element.GetCharacter(renderer.Settings.CurrentFont), MusicFontStyles.MusicFont,
                    scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(2), element);
                element.TextBlockLocation = new Primitives.Point(scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(2));
            }
            else
            {
                if (renderer.IsSMuFLFont)
                {
                    renderer.DrawString(SMuFLGlyphs.Instance.BuildTimeSignatureNumberFromGlyphs(element.NumberOfBeats),
                        MusicFontStyles.MusicFont, scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(1), element);
                    renderer.DrawString(SMuFLGlyphs.Instance.BuildTimeSignatureNumberFromGlyphs(element.TypeOfBeats),
                        MusicFontStyles.MusicFont, scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(3), element);

                    element.TextBlockLocation = new Primitives.Point(scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(3));
                }
                else
                {
                    renderer.DrawString(Convert.ToString(element.NumberOfBeats),
                        MusicFontStyles.TimeSignatureFont, scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(2), element);
                    renderer.DrawString(Convert.ToString(element.TypeOfBeats),
                        MusicFontStyles.TimeSignatureFont, scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(4), element);

                    element.TextBlockLocation = new Primitives.Point(scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(4));
                }
            }
            scoreService.CursorPositionX += 20;
        }


    }
}