namespace Manufaktura.Music.Model.Harmony
{
    /// <summary>
    /// Interface for implementing rules of creating chords for specific scale type
    /// </summary>
    /// <typeparam name="TScale"></typeparam>
    public interface IHarmony<TScale> where TScale : Scale
    {
        /// <summary>
        /// Creates a chord from base pitch, inversion and number of generator intervals for a specific scale.
        /// </summary>
        /// <param name="basePitch">Base pitch, for example C in C Major</param>
        /// <param name="inversion">Inversion of a chord</param>
        /// <param name="generatorIntervals">Number of chord members, for example 4 in C7 Major, 5 in C9 Major, etc.</param>
        /// <param name="scale">Scale for which a chord will be created</param>
        /// <returns>Chord</returns>
        Chord CreateChord(Pitch basePitch, int inversion, int generatorIntervals, TScale scale);
    }
}