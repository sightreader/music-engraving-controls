using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Rendering.Implementations;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using System.Xml.Linq;

namespace Manufaktura.Controls.AspNetMvc
{
    public static class ManufakturaInputExtensions
    {
        private static int canvasIdCount = 0;

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString NoteViewerFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, string>> expression, Expression<Func<TModel, HtmlScoreRendererSettings>> settingsExpression)
        {
            if (expression == null) throw new ArgumentNullException("expression");
            if (settingsExpression == null) throw new ArgumentNullException("settingsExpression");

            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string musicXml = metadata.Model == null ? null : metadata.Model.ToString();
            ModelMetadata settingsMetadata = ModelMetadata.FromLambdaExpression(settingsExpression, htmlHelper.ViewData);
            HtmlScoreRendererSettings settings = settingsMetadata.Model == null ? null : settingsMetadata.Model as HtmlScoreRendererSettings;

            return NoteViewerHelper(htmlHelper, musicXml, settings);
        }

        private static MvcHtmlString NoteViewerHelper(HtmlHelper htmlHelper, string musicXml, HtmlScoreRendererSettings settings)
        {
            if (settings.RenderSurface == HtmlScoreRendererSettings.HtmlRenderSurface.Svg)
                throw new NotImplementedException("Svg support is currently not implemented.");

            MusicXmlParser parser = new MusicXmlParser();
            Score score = parser.Parse(XDocument.Parse(musicXml));

            Score2HtmlCanvasBuilder builder = new Score2HtmlCanvasBuilder(score, string.Format("scoreCanvas{0}", canvasIdCount), settings);          
            string html = builder.Build();

            canvasIdCount++;
            return MvcHtmlString.Create(html);
        }
    }
}
