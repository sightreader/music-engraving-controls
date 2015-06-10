using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class Score2HtmlSvgBuilder : Score2HtmlBuilder<HtmlSvgScoreRenderer>
    {
        public Score2HtmlSvgBuilder(IEnumerable<Score> scores, string canvasPrefix, HtmlScoreRendererSettings settings)
        {
            if (string.IsNullOrWhiteSpace(canvasPrefix)) throw new ArgumentNullException("canvasPrefix");
            Scores = scores;
            CanvasPrefix = canvasPrefix;
            Settings = settings;
        }

        public Score2HtmlSvgBuilder(Score score, string canvasName, HtmlScoreRendererSettings settings)
            : this(new List<Score> { score }, canvasName, settings)
        {
        }

        public override void BuildFontInformation(StringBuilder stringBuilder)
        {
        }

        public override void BuildScoreListHeaderStart(StringBuilder sbstringBuilder)
        {
        }

        public override void BuildScoreListHeaderEnd(StringBuilder stringBuilder)
        {
        }

        public override void BuildScoreElementWrapper(StringBuilder stringBuilder, StringBuilder scoreStringBuilder, Score score, string scoreElementName)
        {
            var wrapper = string.Format(@"<svg width=""{0}"" height=""{1}"">{2}</svg>", Settings.PageWidth, Settings.Height, scoreStringBuilder.ToString());
            stringBuilder.Append(wrapper);
        }
    }
}
