using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class Score2HtmlCanvasBuilder
    {
        public IEnumerable<Score> Scores { get; protected set; }
        public Dictionary<FontStyles, HtmlFontInfo> Fonts { get; protected set; }
        public string CanvasPrefix { get; private set; }

        public Score2HtmlCanvasBuilder(IEnumerable<Score> scores, Dictionary<FontStyles, HtmlFontInfo> fonts, string canvasPrefix)
        {
            if (string.IsNullOrWhiteSpace(canvasPrefix)) throw new ArgumentNullException("canvasPrefix");
            Scores = scores;
            Fonts = fonts;
            CanvasPrefix = canvasPrefix;
        }

        public string Build()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<style type=\"text/css\">");
            Dictionary<string, string> fontFaceDictionary = new Dictionary<string, string>();
            foreach (var font in Fonts.Values)
            {
                if (!fontFaceDictionary.ContainsKey(font.Name)) fontFaceDictionary.Add(font.Name, font.Uri);
            }
            foreach (var fontFace in fontFaceDictionary)
            {
                stringBuilder.AppendLine("@font-face {");
                stringBuilder.AppendLine(string.Format("font-family: '{0}';", fontFace.Key));
                stringBuilder.AppendLine(string.Format("src: url('{0}') format('{1}');", fontFace.Value, GetFormatFromUri(fontFace.Value)));
                stringBuilder.AppendLine("}");
            }
            stringBuilder.AppendLine("</style>");

            for (int i = 0; i < Scores.Count(); i++)
            {
                string canvasName = string.Format("{0}{1}", CanvasPrefix, i);

                StringBuilder scoreStringBuilder = new StringBuilder();
                HtmlCanvasScoreRenderer renderer = new HtmlCanvasScoreRenderer(scoreStringBuilder, Fonts, canvasName);
                renderer.Render(Scores.ElementAt(i));

                stringBuilder.AppendLine(string.Format("<div><canvas id=\"{0}\" height=\"200\"></canvas>", canvasName));
                stringBuilder.AppendLine("<script>");
                string scriptBody = @"(function() {
                        var canvas = document.getElementById('{0}'),
                        context = canvas.getContext('2d');

                        window.addEventListener('resize', resizeCanvas, false);

                        function resizeCanvas() {
                                canvas.width = window.innerWidth;
                                drawScore(); 
                        }
                        resizeCanvas();

                        function drawScore() {
                                {1}
                        }
                    })();".Replace("{", "@@@").Replace("}", "***").Replace("@@@0***", "{0}").Replace("@@@1***", "{1}");
                scriptBody = string.Format(scriptBody, canvasName, scoreStringBuilder.ToString()).Replace("@@@", "{").Replace("***", "}");
                stringBuilder.AppendLine(scriptBody);
                stringBuilder.AppendLine("</script></div>");
            }
            return stringBuilder.ToString();
        }

        private string GetFormatFromUri(string uri)
        {
            uri = uri.ToLower();
            if (uri.EndsWith("ttf")) return "truetype";
            if (uri.EndsWith("woff")) return "woff";
            return null;
        }
    }
}
