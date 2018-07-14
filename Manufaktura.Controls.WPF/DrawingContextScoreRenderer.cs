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

using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Media;

namespace Manufaktura.Controls.WPF
{
	public class DrawingContextScoreRenderer : ScoreRenderer<DrawingContext>
	{
		private Dictionary<Primitives.Pen, Pen> _penCache = new Dictionary<Primitives.Pen, Pen>();
        public DrawingContextScoreRenderer(DrawingContext context) : base(context, new WpfScoreRendererSettings())
        {
        }

        public DrawingContextScoreRenderer(DrawingContext context, WpfScoreRendererSettings settings) : base(context, settings)
        {
        }

        public override bool CanDrawCharacterInBounds => false;
        public WpfScoreRendererSettings TypedSettings => Settings as WpfScoreRendererSettings;
        public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, MusicalSymbol owner)
		{
			PathGeometry pathGeom = new PathGeometry();
			PathFigure pf = new PathFigure();
			pf.StartPoint = new Point(rect.X, rect.Y);
			ArcSegment arcSeg = new ArcSegment(new Point(rect.X, rect.Y), new Size(rect.Width, rect.Height), startAngle, false, SweepDirection.Clockwise, true);
			pf.Segments.Add(arcSeg);
			pathGeom.Figures.Add(pf);
			Canvas.DrawGeometry(null, ConvertPen(pen), pathGeom);
		}

		public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, MusicalSymbol owner)
		{
		}

        public override void DrawCharacterInBounds(char character, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Size size, Primitives.Color color, MusicalSymbol owner)
        {
        }

        public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, MusicalSymbol owner)
        {
			Canvas.DrawLine(ConvertPen(pen), ConvertPoint(startPoint), ConvertPoint(endPoint));
		}

		public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, MusicalSymbol owner)
		{
			Canvas.DrawText(new FormattedText(text, Thread.CurrentThread.CurrentUICulture, FlowDirection.LeftToRight,
                            TypedSettings.GetFont(fontStyle), TypedSettings.GetFontSize(fontStyle), new SolidColorBrush(ConvertColor(color))),
							new System.Windows.Point(location.X + 3d, location.Y));
		}
        protected override void DrawPlaybackCursor(PlaybackCursorPosition position, Primitives.Point start, Primitives.Point end)
		{
		}

		private Color ConvertColor(Primitives.Color color)
		{
			return Color.FromArgb(color.A, color.R, color.G, color.B);
		}

		private Pen ConvertPen(Primitives.Pen pen)
		{
			Pen wpfPen;
			if (_penCache.ContainsKey(pen)) wpfPen = _penCache[pen];
			else
			{
				wpfPen = new Pen(new SolidColorBrush(ConvertColor(pen.Color)), pen.Thickness);
				_penCache.Add(pen, wpfPen);
			}
			return wpfPen;
		}

		private Point ConvertPoint(Primitives.Point point)
		{
			return new Point(point.X, point.Y);
		}
	}
}