/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Rendering.Implementations;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Manufaktura.Controls.AspNetMvc
{
	public static class ManufakturaInputExtensions
	{
		private static int canvasIdCount = 0;

		public static MvcHtmlString NoteViewer(this HtmlHelper htmlHelper, string musicXml, HtmlScoreRendererSettings settings)
		{
			return NoteViewerHelper(htmlHelper, musicXml, settings);
		}

		public static MvcHtmlString NoteViewer(this HtmlHelper htmlHelper, Score score, HtmlScoreRendererSettings settings)
		{
			return NoteViewerHelper(htmlHelper, score, settings);
		}

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

		[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
		public static MvcHtmlString NoteViewerFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, Score>> expression, Expression<Func<TModel, HtmlScoreRendererSettings>> settingsExpression)
		{
			if (expression == null) throw new ArgumentNullException("expression");
			if (settingsExpression == null) throw new ArgumentNullException("settingsExpression");

			ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
			Score score = metadata.Model == null ? null : metadata.Model as Score;
			ModelMetadata settingsMetadata = ModelMetadata.FromLambdaExpression(settingsExpression, htmlHelper.ViewData);
			HtmlScoreRendererSettings settings = settingsMetadata.Model == null ? null : settingsMetadata.Model as HtmlScoreRendererSettings;

			return NoteViewerHelper(htmlHelper, score, settings);
		}

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString NoteViewerFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, string>> expression, HtmlScoreRendererSettings settings)
        {
            if (expression == null) throw new ArgumentNullException(nameof(expression));
            if (settings == null) throw new ArgumentNullException(nameof(settings));

            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string musicXml = metadata.Model == null ? null : metadata.Model.ToString();
            return NoteViewerHelper(htmlHelper, musicXml, settings);
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString NoteViewerFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, Score>> expression, HtmlScoreRendererSettings settings)
        {
            if (expression == null) throw new ArgumentNullException(nameof(expression));
            if (settings == null) throw new ArgumentNullException(nameof(settings));

            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            Score score = metadata.Model == null ? null : metadata.Model as Score;
            return NoteViewerHelper(htmlHelper, score, settings);
        }

        private static MvcHtmlString NoteViewerHelper(HtmlHelper htmlHelper, Score score, HtmlScoreRendererSettings settings)
		{
			IScore2HtmlBuilder builder;
			if (settings.RenderSurface == HtmlScoreRendererSettings.HtmlRenderSurface.Canvas)
				builder = new Score2HtmlCanvasBuilder(score, string.Format("scoreCanvas{0}", canvasIdCount), settings);
			else if (settings.RenderSurface == HtmlScoreRendererSettings.HtmlRenderSurface.Svg)
				builder = new Score2HtmlSvgBuilder(score, string.Format("scoreCanvas{0}", canvasIdCount), settings);
			else throw new NotImplementedException("Unsupported rendering engine.");

			string html = builder.Build();

			canvasIdCount++;
			return MvcHtmlString.Create(html);
		}

		private static MvcHtmlString NoteViewerHelper(HtmlHelper htmlHelper, string musicXml, HtmlScoreRendererSettings settings)
		{
			MusicXmlParser parser = new MusicXmlParser();
			Score score = parser.Parse(XDocument.Parse(musicXml));

			return NoteViewerHelper(htmlHelper, score, settings);
		}
	}
}