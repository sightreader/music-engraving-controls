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
                    renderer.DrawString(GetSMuFLNumberCharacters(renderer, element.NumberOfBeats),
                        MusicFontStyles.MusicFont, scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(1), element);
                    renderer.DrawString(GetSMuFLNumberCharacters(renderer, element.TypeOfBeats),
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

        private string GetSMuFLNumberCharacters(ScoreRendererBase renderer, int number)
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
    }
}