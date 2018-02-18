using System;

namespace Manufaktura.Music.Model.MajorAndMinor
{
    /// <summary>
    /// Represents major or minor scale
    /// </summary>
    public abstract class MajorOrMinorScale : Scale
    {
        /// <summary>
        /// Number of fifths (positive or negative)
        /// </summary>
        public int Fifths { get; protected set; }

        /// <summary>
        /// Tonic step (keynote)
        /// </summary>
        public Step Tonic { get; protected set; }

        /// <summary>
        /// Initializes a new instance of MajorOrMinorScale based on specific midiPitch and MajorAndMinorScaleFlags
        /// </summary>
        /// <param name="midiPitch"></param>
        /// <param name="flags"></param>
        protected MajorOrMinorScale(int midiPitch, MajorAndMinorScaleFlags flags)
            : base(GetMode(flags.IsMinor), midiPitch, flags.IsFlat ? Pitch.MidiPitchTranslationMode.Flats : Pitch.MidiPitchTranslationMode.Sharps)
        {
            Tonic = Pitch.FromMidiPitch(midiPitch, MidiPitchTranslationMode);
            Fifths = CircleOfFifths.CalculateFifths(Tonic, flags);
        }

        /// <summary>
        /// Initialized a new instance of MajorAndMinorScale based on specific step and MajorAndMinorScaleFlags
        /// </summary>
        /// <param name="step"></param>
        /// <param name="flags"></param>
        protected MajorOrMinorScale(Step step, MajorAndMinorScaleFlags flags)
            : base(GetMode(flags.IsMinor), Pitch.FromStep(step).MidiPitch, flags.IsFlat ? Pitch.MidiPitchTranslationMode.Flats : Pitch.MidiPitchTranslationMode.Sharps)
        {
            Fifths = CircleOfFifths.CalculateFifths(step, flags);
            if (CircleOfFifths.GetAlterOfStepFromNumberOfFifths(step, Fifths) != step.Alter)
            {
                throw new MalformedScaleException(string.Format("There is no {0} {1} scale beginning on step {2}.",
                    flags.IsMinor ? "minor" : "major", flags.IsFlat ? "flat" : (Math.Abs(Fifths) > 0 ? "sharp" : "natural"), step));
            }

            Tonic = step;
        }

        /// <summary>
        /// Returns a proper Mode class (MinorMode or MajorMode).
        /// </summary>
        /// <param name="isMinor">If true returns MinorMode. Otheerwise returnsa MajorMode.</param>
        /// <returns></returns>
        public static Mode GetMode(bool isMinor)
        {
            return isMinor ? (Mode)new MinorMode() : new MajorMode();
        }
    }
}