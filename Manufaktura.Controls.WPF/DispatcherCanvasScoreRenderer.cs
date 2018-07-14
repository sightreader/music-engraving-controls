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
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Manufaktura.Controls.WPF
{
	public class DispatcherCanvasScoreRenderer : WpfCanvasScoreRenderer
	{
		private NoteViewer control;
		private Queue<Action> renderingQueue = new Queue<Action>();

		public DispatcherCanvasScoreRenderer(Canvas canvas, NoteViewer control) : base(canvas)
		{
			this.control = control;
		}

        public DispatcherCanvasScoreRenderer(Canvas canvas, NoteViewer control, WpfScoreRendererSettings rendererSettings) : base(canvas, rendererSettings)
        {
            this.control = control;
        }

        public int BufferSize { get; } = 1600;

		public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, MusicalSymbol owner)
		{
			renderingQueue.Enqueue(() => base.DrawArc(rect, startAngle, sweepAngle, pen, owner));

			if (renderingQueue.Count > BufferSize) FlushBuffer();
		}

		public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, MusicalSymbol owner)
		{
			renderingQueue.Enqueue(() => base.DrawBezier(p1, p2, p3, p4, pen, owner));

			if (renderingQueue.Count > BufferSize) FlushBuffer();
		}

		public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, MusicalSymbol owner)
		{
			renderingQueue.Enqueue(() => base.DrawLine(startPoint, endPoint, pen, owner));

			if (renderingQueue.Count > BufferSize) FlushBuffer();
		}

		public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, MusicalSymbol owner)
		{
			renderingQueue.Enqueue(() => base.DrawString(text, fontStyle, location, color, owner));

			if (renderingQueue.Count > BufferSize) FlushBuffer();
		}

		public override void DrawCharacterInBounds(char character, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Size size, Primitives.Color color, MusicalSymbol owner)
		{
			renderingQueue.Enqueue(() => base.DrawCharacterInBounds(character, fontStyle, location, size, color, owner));

			if (renderingQueue.Count > BufferSize) FlushBuffer();
		}

		public void FlushBuffer()
		{
			control.Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
			{
				lock (renderingQueue)
				{
					while (renderingQueue.Any())
					{
						renderingQueue.Dequeue()();
					}
				}
				control.InvalidateMeasure();
			}));
		}
	}
}