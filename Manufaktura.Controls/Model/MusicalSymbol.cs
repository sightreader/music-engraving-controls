using Manufaktura.Model.MVVM;
using Manufaktura.Music.Model;
using System;

namespace Manufaktura.Controls.Model
{
    public enum ArticulationType { None, Staccato, Accent };

    public enum ClefType { GClef, CClef, FClef };

    public enum DirectionPlacementType { Above, Below, Custom };

    public enum HorizontalPlacement { Left, Right };

    public enum MusicalSymbolType { Unknown, Clef, Note, Rest, Barline, Key, TimeSignature, Direction };    //Comparing enum instead of casting supposedly improves performance: http://stackoverflow.com/questions/686412/c-sharp-is-operator-performance

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

    public abstract class MusicalSymbol : ViewModel
    {
        protected MusicalSymbolType type;
        private bool isVisible;

        #region Properties

        public static NullMusicalSymbol Null
        {
            get
            {
                return new NullMusicalSymbol();
            }
        }

        public bool IsVisible { get { return isVisible; } set { isVisible = value; OnPropertyChanged(() => IsVisible); } }

        public MusicalSymbolType Type { get { return type; } }

        #endregion Properties

        #region Constructor

        public MusicalSymbol()
        {
            type = MusicalSymbolType.Unknown;
            isVisible = true;
        }

        #endregion Constructor

        #region Public static functions

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

        #endregion Public static functions
    }
}