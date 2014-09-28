using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public abstract class NoteOrRest : MusicalSymbol, IHasDuration, ICanBeElementOfTuplet, IHasCustomXPosition, IRendererAsTextBlock
    {
        protected MusicalSymbolDuration duration;
        protected TupletType tuplet = TupletType.None;
        protected Point location = new Point();

        public int Voice { get; set; }
        public MusicalSymbolDuration Duration { get { return duration; } }
        public TupletType Tuplet { get { return tuplet; } set { tuplet = value; } }
        public VerticalPlacement? TupletPlacement { get; set; }
        public int NumberOfDots { get; set; }
        public double? DefaultXPosition { get; set; }
        public Point TextBlockLocation { get { return location; } set { location = value; } }

        protected NoteOrRest()
        {
            Voice = 1;
        }
    }
}
