using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public enum MusicalSymbolType { Unknown, Clef, Note, Rest, Barline, Key, TimeSignature, Direction };
    public enum MusicalSymbolDuration : int
    {
        Whole = 1, Half = 2, Quarter = 4, Eighth = 8, Sixteenth = 16,
        d32nd = 32, d64th = 64, d128th = 128, Unknown = 6
    };
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

        #endregion

        #region Constructor

        public MusicalSymbol()
        {
            type = MusicalSymbolType.Unknown;
        }

        #endregion

        #region Public static functions

        public static VerticalPlacement DirectionToPlacement(VerticalDirection direction)
        {
            return direction == VerticalDirection.Up ? VerticalPlacement.Above : VerticalPlacement.Below;
        }

        public static int ToMidiPitch(string step, int alter, int octave)
        {
            int pitch;
            if (step == "A") pitch = 21;
            else if (step == "B") pitch = 23;
            else if (step == "C") pitch = 24;
            else if (step == "D") pitch = 26;
            else if (step == "E") pitch = 28;
            else if (step == "F") pitch = 29;
            else if (step == "G") pitch = 31;
            else return 0;
            //Dźwięki A i B(H) są w standardzie MIDI w oktawie 0:
            //Notes A0 and B0 are in octave 0 in MIDI standard:
            if ((step == "A") || (step == "B")) pitch = pitch + octave * 12;
            else pitch = pitch + (octave - 1) * 12;  //The other are in octave 1 / A pozostałe w pierwszej oktawie
            pitch = pitch + alter;
            return pitch;
        }

        public static int FrequencyToMidiPitch(double freq)
        {
            double i = 0;
            //27,5 Hz to częstotliwość dźwięku A subkontra (najniższego w standardzie MIDI)
            //27,5 Hz is the frequency of note A subcontra (A0) (the lowest in MIDI standard)
            while (true)
            {
                if ((freq < 27.5f * Math.Pow(2, 1.0f / 36) * Math.Pow(2, i / 12)) &&
                    (freq >= 27.5f * Math.Pow(2, -1.0f / 18) * Math.Pow(2, i / 12)))
                    break;
                i++;
                if (i > 100) break;
            }
            return (int)i + 21;
        }



        public static int ToClefMidiPitch(ClefType type)
        {
            if (type == ClefType.CClef) return 60;
            else if (type == ClefType.FClef) return 53;
            else if (type == ClefType.GClef) return 67;
            else return 0;
        }
        public static int StepDifference(Clef a, Note b)
        {
            int step1int = 0, step2int = 0;
            string step1 = a.Step;
            string step2 = b.Step;
            if (step1 == "C") step1int = 0;
            else if (step1 == "D") step1int = 1;
            else if (step1 == "E") step1int = 2;
            else if (step1 == "F") step1int = 3;
            else if (step1 == "G") step1int = 4;
            else if (step1 == "A") step1int = 5;
            else if (step1 == "B") step1int = 6;

            step1int += a.Octave * 7;

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

        public static TimeSpan DurationToTime(IHasDuration durationElement, int tempo, MusicalSymbolDuration tempoBase)
        {
            double singleNoteDuration = 60d / tempo;
            double ratio = (double)tempoBase / (double)durationElement.Duration;
            if (durationElement.NumberOfDots > 0)
            {
                ratio += ratio * Math.Pow(0.5, durationElement.NumberOfDots);
            }
            return TimeSpan.FromSeconds(singleNoteDuration * ratio);
        }

        #endregion

    }
}
