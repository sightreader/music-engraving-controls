using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public abstract class Score2HtmlBuilder<TRenderer, TCanvas> : IScore2HtmlBuilder where TRenderer : HtmlScoreRenderer<TCanvas>, new()
    {
        public IEnumerable<Score> Scores { get; protected set; }
        public string CanvasPrefix { get; protected set; }
        public HtmlScoreRendererSettings Settings { get; protected set; }

        private readonly FontFormat[] fontFormats = new FontFormat[] {
            new FontFormat("ttf", "truetype", false),
            new FontFormat("woff", "woff", false),
            new FontFormat("woff2", "woff2", false),
            new FontFormat("otf", "opentype", false),
            new FontFormat("svg", "svg", true)
        };

        public abstract void BuildFontInformation(TCanvas canvas);
        public abstract void BuildScoreElementWrapper(TCanvas canvas, TCanvas scoreCanvas, Score score, string scoreElementName, double calculatedScoreHeight);
        public abstract string GetHtmlStringFromCanvas(TCanvas canvas);
        public abstract TCanvas CreateCanvas();

        public string Build()
        {
            TCanvas canvas = CreateCanvas();
            BuildFontInformation(canvas);

            int count = Scores.Count();
            for (int i = 0; i < count; i++)
            {
                string canvasName = count == 1 ? CanvasPrefix : string.Format("{0}{1}", CanvasPrefix, i);

                TCanvas scoreCanvas = CreateCanvas();
                var renderer = new TRenderer()
                {
                    Canvas = scoreCanvas,
                    ScoreElementName = canvasName,
                    Settings = this.Settings
                };
                var score = Scores.ElementAt(i);
                renderer.Render(score);

                BuildScoreElementWrapper(canvas, scoreCanvas, score, canvasName, renderer.ActualHeight + 20);
            }
            return GetHtmlStringFromCanvas(canvas);
        }

        protected FontFormat GetFontFormatFromUri(string uri)
        {
            return fontFormats.FirstOrDefault(ff => uri.EndsWith(ff.Extension, StringComparison.OrdinalIgnoreCase));
        }

        protected string GetFontFaceDeclaration()
        {
            var stringBuilder = new StringBuilder();
            Dictionary<string, List<string>> fontFaceDictionary = new Dictionary<string, List<string>>();
            foreach (var font in Settings.Fonts.Values)
            {
                if (!fontFaceDictionary.ContainsKey(font.Name)) fontFaceDictionary.Add(font.Name, font.Uris);
            }
            foreach (var fontFace in fontFaceDictionary)
            {
                stringBuilder.AppendLine("@font-face {");
                stringBuilder.AppendLine(string.Format("font-family: '{0}';", fontFace.Key));
                stringBuilder.Append("src: ");
                bool first = true;
                foreach (var uri in fontFace.Value)
                {
                    if (!first) stringBuilder.AppendLine(", ");
                    var fontFormat = GetFontFormatFromUri(uri);
                    stringBuilder.Append(string.Format("url('{0}{1}') format('{2}') ",
                        uri,
                        fontFormat.CanHaveMultipleFonts ? "#" + fontFace.Key : "",
                        fontFormat.FormatName));
                    first = false;
                }
                stringBuilder.AppendLine("}");
            }
            return stringBuilder.ToString();
        }

        public class FontFormat
        {
            public string Extension { get; set; }
            public string FormatName { get; set; }
            public bool CanHaveMultipleFonts { get; set; }

            public FontFormat(string extension, string name, bool canHaveMultipleFonts)
            {
                Extension = extension;
                FormatName = name;
                CanHaveMultipleFonts = canHaveMultipleFonts;
            }
        }
    }
}
