using Manufaktura.Controls.Model;
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
    }
}
