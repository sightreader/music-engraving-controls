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

        public abstract void BuildFontInformation(TCanvas canvas);
        public abstract void BuildScoreElementWrapper(TCanvas canvas, TCanvas scoreCanvas, Score score, string scoreElementName);
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

                BuildScoreElementWrapper(canvas, scoreCanvas, score, canvasName);
            }
            return GetHtmlStringFromCanvas(canvas);
        }

        protected string GetFontFormatFromUri(string uri)
        {
            if (uri.EndsWith("ttf", StringComparison.OrdinalIgnoreCase)) return "truetype";
            if (uri.EndsWith("woff", StringComparison.OrdinalIgnoreCase)) return "woff";
            if (uri.EndsWith("svg", StringComparison.OrdinalIgnoreCase)) return "svg";
            return null;
        }
    }
}
