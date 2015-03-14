using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public enum MusicalSymbolType { Unknown, Clef, Note, Rest, Barline, Key, TimeSignature, Direction };
    public enum ClefType { GClef, CClef, FClef };
    public enum VerticalDirection { Up, Down };
    public enum NoteBeamType { Single, Start, Continue, End, ForwardHook, BackwardHook };
    public enum NoteTieType { None, Start, Stop, StopAndStartAnother };
    public enum TupletType { None, Start, Stop };
    public enum SyllableType { None, Begin, Middle, End, Single };
    public enum ArticulationType { None, Staccato, Accent };
    public enum VerticalPlacement { Above, Below };
    public enum HorizontalPlacement { Left, Right };
    public enum DirectionPlacementType { Above, Below, Custom };
    public enum TimeSignatureType { Common, Cut, Numbers };
    public enum NoteTrillMark { None, Above, Below };
    public enum NoteSlurType { None, Start, Stop };
    public enum RepeatSignType { None, Forward, Backward };

    public abstract class MusicalSymbol
    {
        #region Protected fields

        protected MusicalSymbolType type;
        protected string musicalCharacter = " ";

        #endregion

        #region Properties

        public MusicalSymbolType Type { get { return type; } }
        public string MusicalCharacter { get { return musicalCharacter; } }
        public bool IsVisible { get; set; }

        #endregion

        #region Constructor

        public MusicalSymbol()
        {
            type = MusicalSymbolType.Unknown;
            IsVisible = true;
        }

        #endregion

        #region Public static functions

        public static VerticalPlacement DirectionToPlacement(VerticalDirection direction)
        {
            return direction == VerticalDirection.Up ? VerticalPlacement.Above : VerticalPlacement.Below;
        }

       
        public static int StepDifference(Clef a, Note b)
        {
            int step1int = 0, step2int = 0;
            string step1 = a.ClefPitch.StepName;
            string step2 = b.Step;
            if (step1 == "C") step1int = 0;
            else if (step1 == "D") step1int = 1;
            else if (step1 == "E") step1int = 2;
            else if (step1 == "F") step1int = 3;
            else if (step1 == "G") step1int = 4;
            else if (step1 == "A") step1int = 5;
            else if (step1 == "B") step1int = 6;

            step1int += a.ClefPitch.Octave * 7;

            if (step2 == "C") step2int = 0;
            else if (step2 == "D") step2int = 1;
            else if (step2 == "E") step2int = 2;
            else if (step2 == "F") step2int = 3;
            else if (step2 == "G") step2int = 4;
            else if (step2 == "A") step2int = 5;
            else if (step2 == "B") step2int = 6;

            step2int += b.Octave * 7;

            return step1int - step2int;
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

        #endregion

    }
}
