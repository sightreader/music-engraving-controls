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
        public static MvcHtmlString NoteViewerFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, string>> expression, object htmlAttributes)
        {
            return NoteViewerFor(htmlHelper, expression, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString NoteViewerFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, string>> expression, IDictionary<string, object> htmlAttributes)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string musicXml = metadata.Model == null ? null : metadata.Model.ToString();

            return NoteViewerHelper(htmlHelper, metadata, ExpressionHelper.GetExpressionText(expression), musicXml, htmlAttributes);
        }

        private static MvcHtmlString NoteViewerHelper(HtmlHelper htmlHelper, ModelMetadata metadata, string name, string musicXml, IDictionary<string, object> htmlAttributes)
        {
            RouteValueDictionary attributes = ToRouteValueDictionary(htmlAttributes);
            attributes.Remove("musicXml"); // TODO: Do czego to służy?

            //TODO: Gdzie konfigurować fonty?
            Dictionary<FontStyles, HtmlFontInfo> fonts = new Dictionary<FontStyles, HtmlFontInfo>();
            fonts.Add(FontStyles.MusicFont, new HtmlFontInfo("Polihymnia", "../fonts/Polihymnia.ttf", 24d));
            fonts.Add(FontStyles.GraceNoteFont, new HtmlFontInfo("Polihymnia", "../fonts/Polihymnia.ttf", 12d));
            fonts.Add(FontStyles.LyricsFont, new HtmlFontInfo("Open Sans", "../fonts/OpenSans-Regular.ttf", 10d));
            fonts.Add(FontStyles.TimeSignatureFont, new HtmlFontInfo("Open Sans", "../fonts/OpenSans-Regular.ttf", 14d));
            fonts.Add(FontStyles.DirectionFont, new HtmlFontInfo("Open Sans", "../fonts/OpenSans-Regular.ttf", 10d));

            MusicXmlParser parser = new MusicXmlParser();
            Score score = parser.Parse(XDocument.Parse(musicXml));

            Score2HtmlCanvasBuilder builder = new Score2HtmlCanvasBuilder(score, fonts, string.Format("scoreCanvas{0}", canvasIdCount));
            string html = builder.Build();

            canvasIdCount++;
            return MvcHtmlString.Create(html);
        }

        private static RouteValueDictionary ToRouteValueDictionary(IDictionary<string, object> dictionary)
        {
            return dictionary == null ? new RouteValueDictionary() : new RouteValueDictionary(dictionary);
        }
    }
}
