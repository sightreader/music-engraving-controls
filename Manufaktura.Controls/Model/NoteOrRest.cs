using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public abstract class NoteOrRest : MusicalSymbol, IHasDuration, ICanBeElementOfTuplet, IHasCustomXPosition, IRendererAsTextBlock
    {

        protected TupletType tuplet = TupletType.None;
        protected Point location = new Point();

        public int Voice { get; set; }
        public RhythmicDuration Duration { get; protected set; }
        public RhythmicDuration BaseDuration 
        { 
            get 
            {
                return Duration.WithoutDots();
            }
        }
        public int NumberOfDots
        {
            get
            {
                return Duration.Dots;
            }
            set
            {
                Duration = new RhythmicDuration(BaseDuration.Denominator, value);
            }
        }
        public TupletType Tuplet { get { return tuplet; } set { tuplet = value; } }
        public VerticalPlacement? TupletPlacement { get; set; }
        
        public double? DefaultXPosition { get; set; }
        public Point TextBlockLocation { get { return location; } set { location = value; } }

        protected NoteOrRest()
        {
            Voice = 1;
        }
    }
}
