using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

namespace Manufaktura.Controls.UniversalApps
{
    public class UWPDispatcherCanvasScoreRenderer : UWPCanvasScoreRenderer
    {
        private NoteViewer control;
        private Queue<Action> renderingQueue = new Queue<Action>();

        public UWPDispatcherCanvasScoreRenderer(Canvas canvas, NoteViewer control) : base(canvas)
        {
            this.control = control;
        }

        public UWPDispatcherCanvasScoreRenderer(Canvas canvas, UWPScoreRendererSettings rendererSettings, NoteViewer control) : base(canvas, rendererSettings)
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

        public override void DrawCharacterInBounds(char character, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Size size, Primitives.Color color, MusicalSymbol owner)
        {
            renderingQueue.Enqueue(() => base.DrawCharacterInBounds(character, fontStyle, location, size, color, owner));

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
        public async void FlushBuffer()
        {
            await control.Dispatcher.RunAsync(CoreDispatcherPriority.Low, () =>
            {
                lock (renderingQueue)
                {
                    while (renderingQueue.Any())
                    {
                        renderingQueue.Dequeue()();
                    }
                }
                control.InvalidateMeasure();
            });
        }
    }
}