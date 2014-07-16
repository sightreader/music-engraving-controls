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
        public ScoreRendererState State { get; protected set; }
        public MusicalSymbolRenderStrategyBase[] Strategies { get; private set; } 

        protected ScoreRendererBase()
        {
            State = new ScoreRendererState();
            Strategies = Assembly.GetCallingAssembly().GetTypes().Where(t => !t.IsAbstract && t.IsSubclassOf(typeof(MusicalSymbolRenderStrategyBase))).
                Select(t => Activator.CreateInstance(t)).Cast<MusicalSymbolRenderStrategyBase>().ToArray();
        }

        public MusicalSymbolRenderStrategyBase GetProperRenderStrategy(MusicalSymbol element)
        {
            return Strategies.FirstOrDefault(s => s.SymbolType == element.GetType());
        }

        public void DrawString(string text, FontStyles fontStyle, double x, double y)
        {
            DrawString(text, fontStyle, new Point(x, y), Color.Black);
        }

        public void DrawString(string text, FontStyles fontStyle, Point location)
        {
            DrawString(text, fontStyle, location, Color.Black);
        }
        public abstract void DrawString(string text, FontStyles fontStyle, Point location, Color color);

        public void DrawLine(double startX, double startY, double endX, double endY)
        {
            DrawLine(new Point(startX, startY), new Point(endX, endY), new Pen(Color.Black, 1));
        }
        public void DrawLine(Point startPoint, Point endPoint)
        {
            DrawLine(startPoint, endPoint, new Pen(Color.Black, 1));
        }
        public abstract void DrawLine(Point startPoint, Point endPoint, Pen pen);

        public void DrawArc(Rectangle rect, double startAngle, double sweepAngle)
        {
            DrawArc(rect, startAngle, sweepAngle, new Pen(Color.Black, 1));
        }
        public abstract void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen);

        public void DrawBezier(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            DrawBezier(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4), new Pen(Color.Black, 1));
        }
        public void DrawBezier(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, Pen pen)
        {
            DrawBezier(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4), pen);
        }
        public abstract void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen);
        
    }
}
