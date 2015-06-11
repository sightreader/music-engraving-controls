using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class Score2HtmlCanvasBuilder : Score2HtmlBuilder<HtmlCanvasScoreRenderer, StringBuilder>
    {
        public Score2HtmlCanvasBuilder(IEnumerable<Score> scores, string canvasPrefix, HtmlScoreRendererSettings settings)
        {
            if (string.IsNullOrWhiteSpace(canvasPrefix)) throw new ArgumentNullException("canvasPrefix");
            Scores = scores;
            CanvasPrefix = canvasPrefix;
            Settings = settings;
        }

        public Score2HtmlCanvasBuilder(Score score, string canvasName, HtmlScoreRendererSettings settings)
            : this(new List<Score> { score }, canvasName, settings)
        {
        }

        public override void BuildFontInformation(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("<style type=\"text/css\">");

            Dictionary<string, string> fontFaceDictionary = new Dictionary<string, string>();
            foreach (var font in Settings.Fonts.Values)
            {
                if (!fontFaceDictionary.ContainsKey(font.Name)) fontFaceDictionary.Add(font.Name, font.Uri);
            }
            foreach (var fontFace in fontFaceDictionary)
            {
                stringBuilder.AppendLine("@font-face {");
                stringBuilder.AppendLine(string.Format("font-family: '{0}';", fontFace.Key));
                stringBuilder.AppendLine(string.Format("src: url('{0}') format('{1}');", fontFace.Value, GetFontFormatFromUri(fontFace.Value)));
                stringBuilder.AppendLine("}");
            }

            stringBuilder.AppendLine("</style>");
        }

        public override void BuildScoreElementWrapper(StringBuilder stringBuilder, StringBuilder scoreStringBuilder, Score score, string scoreElementName)
        {
            stringBuilder.AppendLine(string.Format("<div><canvas id=\"{0}\" height=\"{1}\"></canvas>", scoreElementName, Settings.Height.ToString(CultureInfo.InvariantCulture)));
            stringBuilder.AppendLine("<script>");

            string scriptBody = @"(function() {
                        var canvas = document.getElementById('{0}'),
                        context = canvas.getContext('2d');

                        window.addEventListener('resize', resizeCanvas, false);
                        window.setTimeout(resizeCanvas, 200);
                        window.setTimeout(resizeCanvas, 2000);

                        function resizeCanvas() {
                                canvas.width = window.innerWidth;
                                drawScore(); 
                        }
                        resizeCanvas();

                        function drawScore() {
                                {1}
                        }
                    })();".Replace("{", "@@@").Replace("}", "***").Replace("@@@0***", "{0}").Replace("@@@1***", "{1}");
            scriptBody = string.Format(scriptBody, scoreElementName, scoreStringBuilder.ToString()).Replace("@@@", "{").Replace("***", "}");
            stringBuilder.AppendLine(scriptBody);
            stringBuilder.AppendLine("</script></div>");
        }

        public override string GetHtmlStringFromCanvas(StringBuilder canvas)
        {
            return canvas.ToString();
        }

        public override StringBuilder CreateCanvas()
        {
            return new StringBuilder();
        }
    }
}
