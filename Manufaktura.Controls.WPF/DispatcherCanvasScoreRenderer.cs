using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Manufaktura.Controls.WPF
{
	public class DispatcherCanvasScoreRenderer : CanvasScoreRenderer
	{
		private NoteViewer control;
		private Queue<Action> renderingQueue = new Queue<Action>();

		public DispatcherCanvasScoreRenderer(Canvas canvas, NoteViewer control) : base(canvas)
		{
			this.control = control;
		}

		public int BufferSize { get; } = 5;

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

		public override void DrawStringInBounds(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Size size, Primitives.Color color, MusicalSymbol owner)
		{
			renderingQueue.Enqueue(() => base.DrawStringInBounds(text, fontStyle, location, size, color, owner));

			if (renderingQueue.Count > BufferSize) FlushBuffer();
		}

		public void FlushBuffer()
		{
			control.Dispatcher.BeginInvoke(DispatcherPriority.Render, new Action(() =>
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