using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    public abstract class ScoreRendererBase
    {
        public ScoreRendererState State { get; private set; }

        protected ScoreRendererBase()
        {
            State = new ScoreRendererState();
        }

        public MusicalSymbolRenderStrategy<TElement> GetProperRenderStrategy<TElement>(TElement element)    //TODO: Przetestować porządnie
        {
            var types = Assembly.GetCallingAssembly().GetTypes().Where(t => t.IsAssignableFrom(typeof(MusicalSymbolRenderStrategy<>)));
            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type) as MusicalSymbolRenderStrategy<TElement>;
                if (instance.SymbolType == element.GetType()) return instance;
            }
            return null;
        }

        public void DrawString(string text, FontStyles fontStyle, double x, double y)
        {
            DrawString(text, fontStyle, new Point(x, y));
        }
        public abstract void DrawString(string text, FontStyles fontStyle, Point location);

        public void DrawLine(double startX, double startY, double endX, double endY)
        {
            DrawLine(new Point(startX, startY), new Point(endX, endY), 1);
        }
        public void DrawLine(Point startPoint, Point endPoint)
        {
            DrawLine(startPoint, endPoint, 1);
        }
        public abstract void DrawLine(Point startPoint, Point endPoint, double thickness);

        public void DrawArc(Rectangle rect, double startAngle, double sweepAngle)
        {
            DrawArc(rect, startAngle, sweepAngle, 1);
        }
        public abstract void DrawArc(Rectangle rect, double startAngle, double sweepAngle, double thickness);

        public void DrawBezier(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            DrawBezier(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4), 1);
        }
        public void DrawBezier(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double thickness)
        {
            DrawBezier(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4), thickness);
        }
        public abstract void DrawBezier(Point p1, Point p2, Point p3, Point p4, double thickness);
        
    }
}
