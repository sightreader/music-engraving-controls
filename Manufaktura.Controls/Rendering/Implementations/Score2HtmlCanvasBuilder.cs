using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Extensions;
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

        /// <summary>
        /// Creates font styles declaration
        /// </summary>
        /// <param name="stringBuilder"></param>
        protected override void BuildFontInformation(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("<style type=\"text/css\">");
            stringBuilder.AppendLine(GetFontFaceDeclaration());
            stringBuilder.AppendLine("</style>");
        }

        protected override void BuildScoreElementWrapper(StringBuilder stringBuilder, StringBuilder scoreStringBuilder, Score score, string scoreElementName, Size calculatedScoreSize, double clippedAreaY)
        {
            stringBuilder.AppendLine(string.Format("<div><canvas id=\"{0}\" height=\"{1}\"></canvas>", scoreElementName, calculatedScoreSize.Height.ToStringInvariant()));
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

        /// <summary>
        /// Converts cancas to HTML string
        /// </summary>
        /// <param name="canvas"></param>
        /// <returns></returns>
        protected override string GetHtmlStringFromCanvas(StringBuilder canvas)
        {
            return canvas.ToString();
        }

        /// <summary>
        /// Returns a new instance of StringBuilder which will be used to build HTML canvas
        /// </summary>
        /// <returns></returns>
        public override StringBuilder CreateCanvas()
        {
            return new StringBuilder();
        }
    }
}
