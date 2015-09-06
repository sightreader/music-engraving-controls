using Manufaktura.Model.MVVM;
using Manufaktura.Music.Model;
using System;

namespace Manufaktura.Controls.Model
{
    public enum ArticulationType { None, Staccato, Accent };

    public enum ClefType { GClef, CClef, FClef };

    public enum DirectionPlacementType { Above, Below, Custom };

    public enum HorizontalPlacement { Left, Right };

    public enum MusicalSymbolType { Unknown, Clef, Note, Rest, Barline, Key, TimeSignature, Direction, Staff, PrintSuggestion };    //Comparing enum instead of casting supposedly improves performance: http://stackoverflow.com/questions/686412/c-sharp-is-operator-performance

    public enum NoteBeamType { Single, Start, Continue, End, ForwardHook, BackwardHook };

    public enum NoteSlurType { None, Start, Stop };

    public enum NoteTieType { None, Start, Stop, StopAndStartAnother };

    public enum NoteTrillMark { None, Above, Below };

    public enum RepeatSignType { None, Forward, Backward };

    public enum SyllableType { None, Begin, Middle, End, Single };

    public enum TimeSignatureType { Common, Cut, Numbers };

    public enum TupletType { None, Start, Stop };

    public enum VerticalDirection { Up, Down };

    public enum VerticalPlacement { Above, Below };

    /// <summary>
    /// Base class for all musical symbols
    /// </summary>
    public abstract class MusicalSymbol : ViewModel
    {
        private bool isVisible;

        /// <summary>
        /// Returns a new instance of null musical symbol
        /// </summary>
        public static NullMusicalSymbol Null
        {
            get
            {
                return new NullMusicalSymbol();
            }
        }

        public Guid Id { get; private set; }

        /// <summary>
        /// Gets or sets the symbol's visibility. Visibility can be treated differently varying on implementation of rendering.
        /// </summary>
        public bool IsVisible { get { return isVisible; } set { isVisible = value; OnPropertyChanged(() => IsVisible); } }

        public Staff Staff { get; internal set; }

        public virtual MusicalSymbolType Type { get { return MusicalSymbolType.Unknown; } }

        public MusicalSymbol()
        {
            isVisible = true;
            Id = Guid.NewGuid();
        }

        public static VerticalPlacement DirectionToPlacement(VerticalDirection direction)
        {
            return direction == VerticalDirection.Up ? VerticalPlacement.Above : VerticalPlacement.Below;
        }

        [Obsolete("Use Duration.ToTimeSpan() instead")]
        public static TimeSpan DurationToTime(IHasDuration durationElement, Tempo tempo)
        {
            double singleNoteDuration = 60d / tempo.BeatsPerMinute;
            double ratio = (double)tempo.BeatUnit.Denominator / (double)durationElement.BaseDuration.Denominator;
            if (durationElement.NumberOfDots > 0)
            {
                ratio += ratio * Math.Pow(0.5, durationElement.NumberOfDots);
            }
            return TimeSpan.FromSeconds(singleNoteDuration * ratio);
        }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
}