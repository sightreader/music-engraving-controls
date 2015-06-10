using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public abstract class Score2HtmlBuilder<TRenderer> where TRenderer : HtmlScoreRenderer, new()
    {
        public IEnumerable<Score> Scores { get; protected set; }
        public string CanvasPrefix { get; protected set; }
        public HtmlScoreRendererSettings Settings { get; protected set; }

        public abstract void BuildFontInformation(StringBuilder stringBuilder);
        public abstract void BuildScoreListHeaderStart(StringBuilder sbstringBuilder);
        public abstract void BuildScoreListHeaderEnd(StringBuilder stringBuilder);
        public abstract void BuildScoreElementWrapper(StringBuilder stringBuilder, StringBuilder scoreStringBuilder, Score score, string scoreElementName);

        public string Build()
        {
            StringBuilder stringBuilder = new StringBuilder();
            BuildScoreListHeaderStart(stringBuilder);
            BuildFontInformation(stringBuilder);
            BuildScoreListHeaderEnd(stringBuilder);

            int count = Scores.Count();
            for (int i = 0; i < count; i++)
            {
                string canvasName = count == 1 ? CanvasPrefix : string.Format("{0}{1}", CanvasPrefix, i);

                StringBuilder scoreStringBuilder = new StringBuilder();
                var renderer = new TRenderer()
                {
                    Canvas = scoreStringBuilder,
                    ScoreElementName = canvasName,
                    Settings = this.Settings
                };
                var score = Scores.ElementAt(i);
                renderer.Render(score);

                BuildScoreElementWrapper(stringBuilder, scoreStringBuilder, score, canvasName);
            }
            return stringBuilder.ToString();
        }
    }
}
