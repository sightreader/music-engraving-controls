using Manufaktura.Controls.Music;
using Manufaktura.Music.Tuning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public class Pitch : Step
    {
        private static Dictionary<string, int> pitches = new Dictionary<string, int>
        {
            {"C", 60}, {"D", 62}, {"E", 64}, {"F", 65}, {"G", 67}, {"A", 69}, {"B", 71}
        };

        public static Pitch G3 { get { return Pitch.FromStep(Step.G, 3); } }
        public static Pitch GSharp3 { get { return Pitch.FromStep(Step.GSharp, 3); } }
        public static Pitch A3 { get { return Pitch.FromStep(Step.A, 3); } }
        public static Pitch ASharp3 { get { return Pitch.FromStep(Step.ASharp, 3); } }
        public static Pitch B3 { get { return Pitch.FromStep(Step.B, 3); } }
        public static Pitch BSharp3 { get { return Pitch.FromStep(Step.BSharp, 3); } }
        public static Pitch C4 { get { return Pitch.FromStep(Step.C, 4); } }
        public static Pitch CSharp4 { get { return Pitch.FromStep(Step.CSharp, 4); } }
        public static Pitch D4 { get { return Pitch.FromStep(Step.D, 4); } }
        public static Pitch DSharp4 { get { return Pitch.FromStep(Step.DSharp, 4); } }
        public static Pitch E4 { get { return Pitch.FromStep(Step.E, 4); } }
        public static Pitch ESharp4 { get { return Pitch.FromStep(Step.ESharp, 4); } }
        public static Pitch F4 { get { return Pitch.FromStep(Step.F, 4); } }
        public static Pitch FSharp4 { get { return Pitch.FromStep(Step.FSharp, 4); } }
        public static Pitch G4 { get { return Pitch.FromStep(Step.G, 4); } }
        public static Pitch GSharp4 { get { return Pitch.FromStep(Step.GSharp, 4); } }
        public static Pitch A4 { get { return Pitch.FromStep(Step.A, 4); } }
        public static Pitch ASharp4 { get { return Pitch.FromStep(Step.ASharp, 4); } }
        public static Pitch B4 { get { return Pitch.FromStep(Step.B, 4); } }
        public static Pitch BSharp4 { get { return Pitch.FromStep(Step.BSharp, 4); } }
        public static Pitch C5 { get { return Pitch.FromStep(Step.C, 5); } }
        public static Pitch CSharp5 { get { return Pitch.FromStep(Step.CSharp, 5); } }
        public static Pitch D5 { get { return Pitch.FromStep(Step.D, 5); } }
        public static Pitch DSharp5 { get { return Pitch.FromStep(Step.DSharp, 5); } }
        public static Pitch E5 { get { return Pitch.FromStep(Step.E, 5); } }
        public static Pitch ESharp5 { get { return Pitch.FromStep(Step.ESharp, 5); } }
        public static Pitch F5 { get { return Pitch.FromStep(Step.F, 5); } }
        public static Pitch FSharp5 { get { return Pitch.FromStep(Step.FSharp, 5); } }
        public static Pitch G5 { get { return Pitch.FromStep(Step.G, 5); } }
        public static Pitch GSharp5 { get { return Pitch.FromStep(Step.GSharp, 5); } }
        public static Pitch A5 { get { return Pitch.FromStep(Step.A, 5); } }
        public static Pitch ASharp5 { get { return Pitch.FromStep(Step.ASharp, 5); } }
        public static Pitch B5 { get { return Pitch.FromStep(Step.B, 5); } }
        public static Pitch BSharp5 { get { return Pitch.FromStep(Step.BSharp, 5); } }
        public static Pitch C6 { get { return Pitch.FromStep(Step.C, 6); } }
        public static Pitch CSharp6 { get { return Pitch.FromStep(Step.CSharp, 6); } }
        public static Pitch D6 { get { return Pitch.FromStep(Step.D, 6); } }
        public static Pitch DSharp6 { get { return Pitch.FromStep(Step.DSharp, 6); } }
        public static Pitch E6 { get { return Pitch.FromStep(Step.E, 6); } }
        public static Pitch ESharp6 { get { return Pitch.FromStep(Step.ESharp, 6); } }
        public static Pitch F6 { get { return Pitch.FromStep(Step.F, 6); } }
        public static Pitch FSharp6 { get { return Pitch.FromStep(Step.FSharp, 6); } }
        public static Pitch G6 { get { return Pitch.FromStep(Step.G, 6); } }
        public static Pitch GSharp6 { get { return Pitch.FromStep(Step.GSharp, 6); } }
        public static Pitch A6 { get { return Pitch.FromStep(Step.A, 6); } }
        public static Pitch ASharp6 { get { return Pitch.FromStep(Step.ASharp, 6); } }
        public static Pitch B6 { get { return Pitch.FromStep(Step.B, 6); } }
        public static Pitch BSharp6 { get { return Pitch.FromStep(Step.BSharp, 6); } }
        public static Pitch C7 { get { return Pitch.FromStep(Step.C, 7); } }
        public static Pitch CSharp7 { get { return Pitch.FromStep(Step.CSharp, 7); } }

        public int MidiPitch { get; set; }
        public int Octave { get; set; }


        protected Pitch()
        {
        }

        public Pitch(string stepName, int alter, int octaveNumber)
        {
            StepName = stepName;
            Alter = alter;
            MidiPitch = pitches[stepName] + alter + (octaveNumber - 4) * 12;
            Octave = octaveNumber;
        }

        public Pitch OctaveUp()
        {
            return new Pitch(StepName, Alter, Octave + 1);
        }

        public Pitch OctaveDown()
        {
            return new Pitch(StepName, Alter, Octave - 1);
        }

        public Step ToStep()
        {
            return Step.FromPitch(this);
        }

        public TunedPitch Tune(TunedPitch standardPitch, TuningSystem tuningSystem)
        {
            var logarythmicProportion = tuningSystem.AllIntervalRatios[new BoundInterval(standardPitch, this)];
            var freq = standardPitch.Frequency * UsefulMath.CentsToLinear(logarythmicProportion);
            freq *= (this.Octave - standardPitch.Octave) + 1;
            return new TunedPitch(this, freq);
        }

        public static Pitch operator +(Pitch pitch, Interval interval)
        {
            return pitch.Translate(interval, MidiPitchTranslationMode.Auto);
        }

        public static Pitch operator -(Pitch pitch, Interval interval)
        {
            return pitch.Translate(interval.MakeDescending(), MidiPitchTranslationMode.Auto);
        }

        public Pitch Translate(Interval interval, MidiPitchTranslationMode mode)
        {
            return Pitch.FromMidiPitch(MidiPitch + interval.Halftones, mode);
        }

        public static Pitch FromStep(Step step, int octaveNumber = 4)
        {
            return new Pitch { StepName = step.StepName, Alter = step.Alter, MidiPitch = pitches[step.StepName] + step.Alter + (octaveNumber - 4) * 12, Octave = octaveNumber };
        }

        public static Pitch FromMidiPitch(int midiPitch, MidiPitchTranslationMode mode)
        {
            var pitch = new Pitch();
            pitch.ApplyMidiPitch(midiPitch, mode);
            return pitch;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", StepName, AlterToSigns(Alter), Octave);
        }

        public void ApplyMidiPitch(int midiPitch, MidiPitchTranslationMode mode)
        {
            int midiPitchInLowestOctave = midiPitch;

            while (midiPitchInLowestOctave > 32)
            {
                midiPitchInLowestOctave -= 12;
            }

            switch (mode)
            {
                case MidiPitchTranslationMode.Auto:
                    if (midiPitchInLowestOctave == 21) { StepName = "A"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 22) { StepName = "B"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 23) { StepName = "B"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 24) { StepName = "C"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 25) { StepName = "C"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 26) { StepName = "D"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 27) { StepName = "E"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 28) { StepName = "E"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 29) { StepName = "F"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 30) { StepName = "F"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 31) { StepName = "G"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 32) { StepName = "G"; Alter = 1; }
                    break;

                case MidiPitchTranslationMode.Sharps:
                    if (midiPitchInLowestOctave == 21) { StepName = "A"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 22) { StepName = "A"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 23) { StepName = "B"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 24) { StepName = "C"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 25) { StepName = "C"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 26) { StepName = "D"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 27) { StepName = "D"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 28) { StepName = "E"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 29) { StepName = "F"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 30) { StepName = "F"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 31) { StepName = "G"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 32) { StepName = "G"; Alter = 1; }
                    break;

                case MidiPitchTranslationMode.Flats:
                    if (midiPitchInLowestOctave == 21) { StepName = "A"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 22) { StepName = "B"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 23) { StepName = "B"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 24) { StepName = "C"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 25) { StepName = "D"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 26) { StepName = "D"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 27) { StepName = "E"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 28) { StepName = "E"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 29) { StepName = "F"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 30) { StepName = "G"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 31) { StepName = "G"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 32) { StepName = "A"; Alter = -1; }
                    break;

                default:
                    throw new NotImplementedException("Unsupported midi pitch translation mode.");
            }


            if (midiPitch < 24) Octave = 0;
            else if (midiPitch < 36) Octave = 1;
            else if (midiPitch < 48) Octave = 2;
            else if (midiPitch < 60) Octave = 3;
            else if (midiPitch < 72) Octave = 4;
            else if (midiPitch < 84) Octave = 5;
            else if (midiPitch < 96) Octave = 6;
            else if (midiPitch < 108) Octave = 7;
            else if (midiPitch < 120) Octave = 8;

            this.MidiPitch = midiPitch;
        }

        public static bool operator >(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch > p2.MidiPitch;
        }

        public static bool operator >=(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch >= p2.MidiPitch;
        }

        public static bool operator <(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch < p2.MidiPitch;
        }

        public static bool operator <=(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch <= p2.MidiPitch;
        }

        public static bool operator ==(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch == p2.MidiPitch;
        }

        public static bool operator !=(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch != p2.MidiPitch;
        }

        public static int StepDistance(Pitch p1, Pitch p2)
        {
            return (p1.ToStepNumber() - 1 + p1.Octave * 7) - (p2.ToStepNumber() -1 + p2.Octave * 7);    //Kolejność p1 - p2 jest dobra. Ze względów historycznych :)
        }

        public static int StepDistance(IHasPitch h1, Pitch p2)
        {
            return StepDistance(h1.Pitch, p2);
        }

        public static int StepDistance(Pitch p1, IHasPitch h2)
        {
            return StepDistance(p1, h2.Pitch);
        }

        public static int StepDistance(IHasPitch h1, IHasPitch h2)
        {
            return StepDistance(h1.Pitch, h2.Pitch);
        }

        public static IEnumerable<Pitch> ChromaticRange(Pitch p1, Pitch p2, MidiPitchTranslationMode translationMode)
        {
            if (p1 == p2) yield return p1;
            int direction = p1 < p2 ? 1 : -1;
            var pitch = p1;
            while (pitch != p2)
            {
                yield return pitch = Pitch.FromMidiPitch(pitch.MidiPitch + direction, translationMode);
            }
        }

        /// <summary>
        /// TODO: Sprawdzić czy ta metoda daje takie same efekty jak konstruktor klasy Pitch i ewentualnie wywalić
        /// </summary>
        /// <param name="stepName"></param>
        /// <param name="alter"></param>
        /// <param name="octave"></param>
        /// <returns></returns>
        public static int CalculateMidiPitch(string stepName, int alter, int octave)
        {
            int pitch;
            if (stepName == "A") pitch = 21;
            else if (stepName == "B") pitch = 23;
            else if (stepName == "C") pitch = 24;
            else if (stepName == "D") pitch = 26;
            else if (stepName == "E") pitch = 28;
            else if (stepName == "F") pitch = 29;
            else if (stepName == "G") pitch = 31;
            else return 0;
            //Dźwięki A i B(H) są w standardzie MIDI w oktawie 0:
            //Notes A0 and B0 are in octave 0 in MIDI standard:
            if ((stepName == "A") || (stepName == "B")) pitch = pitch + octave * 12;
            else pitch = pitch + (octave - 1) * 12;  //The other are in octave 1 / A pozostałe w pierwszej oktawie
            pitch = pitch + alter;
            return pitch;
        }

        /// <summary>
        /// Converts frequency to midi pitch in a simple naive way, using equal temperament.
        /// </summary>
        /// <param name="freq">Frequency</param>
        /// <returns>Midi pitch</returns>
        public static int FrequencyToMidiPitch(double freq)
        {
            double i = 0;
            //27,5 Hz to częstotliwość dźwięku A subkontra (najniższego w standardzie MIDI)
            //27,5 Hz is the frequency of note A0 (the lowest in MIDI standard)
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

        public enum MidiPitchTranslationMode
        {
            Auto, Sharps, Flats
        }
    }
}
