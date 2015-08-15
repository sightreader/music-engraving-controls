using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Music;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a clef.
    /// </summary>
    public class Clef : MusicalSymbol, IHasPitch, IRenderedAsTextBlock
    {
        #region Private fields

        private ClefType typeOfClef;
        private int line;
        private string musicalCharacter;
        private IMusicFont musicFont = new PolihymniaFont();

        #endregion

        #region Properties

        /// <summary>
        /// Pitch of clef.
        /// </summary>
        /// <remarks>
        /// Note that only some pitches (steps C, F, G) are valid for clefs.
        /// </remarks>
        public Pitch Pitch { get; private set; }

        /// <summary>
        /// Type of clef (C-clef, G-clef or F-clef)
        /// </summary>
        public ClefType TypeOfClef { get { return typeOfClef; } }

        /// <summary>
        /// Clef line
        /// </summary>
        public int Line { get { return line; } }


        public Point TextBlockLocation
        {
            get;
            set;
        }
        public IMusicFont MusicFont { get { return musicFont; } set { musicFont = value; OnPropertyChanged(() => MusicFont); } }

        public string MusicalCharacter
        {
            get { return musicalCharacter; }
        }
        
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of Clef.
        /// </summary>
        /// <param name="clefType">Type of clef (C, F, G)</param>
        /// <param name="whichLine">Line</param>
        public Clef(ClefType clefType, int whichLine)
        {
            type = MusicalSymbolType.Clef;
            typeOfClef = clefType;
            line = whichLine;
            if (typeOfClef == ClefType.GClef)
            {
                musicalCharacter = MusicFont.GClef;
                Pitch = Pitch.FromStep(Step.G, 4);
            }
            else if (typeOfClef == ClefType.FClef)
            {
                musicalCharacter = MusicFont.FClef;
                Pitch = Pitch.FromStep(Step.F, 3);
            }
            else if (typeOfClef == ClefType.CClef)
            {
                musicalCharacter = MusicFont.CClef;
                Pitch = Pitch.FromStep(Step.C, 4);
            }
        }

        #endregion

        #region Public static functions

        /// <summary>
        /// This methods selects a appropriate clef for a note to make the note comfortably visible in the staff.
        /// </summary>
        /// <param name="n">Note</param>
        /// <returns>Appropriate clef</returns>
        public static Clef SuggestClefForANote(Note n)
        {
            if (n.MidiPitch < 55) return new Clef(ClefType.FClef, 4);
            else return new Clef(ClefType.GClef, 2);
        }

        /// <summary>
        /// This methods selects a appropriate clef for a note to make the note comfortably visible in the staff.
        /// </summary>
        /// <param name="n">Note</param>
        /// <param name="currentClef">Current clef</param>
        /// <returns>Appropriate clef</returns>
        public static Clef SuggestClefForANote(Note n, Clef currentClef)
        {
            if (currentClef.TypeOfClef == ClefType.GClef)
            {
                if ((currentClef.Line == 1) && (n.MidiPitch < 59)) return new Clef(ClefType.FClef, 4);
                else if ((currentClef.Line == 2) && (n.MidiPitch < 55)) return new Clef(ClefType.FClef, 4);
                else if ((currentClef.Line == 3) && (n.MidiPitch < 52)) return new Clef(ClefType.FClef, 4);
                else if ((currentClef.Line == 4) && (n.MidiPitch < 48)) return new Clef(ClefType.FClef, 4);
                else if ((currentClef.Line == 5) && (n.MidiPitch < 45)) return new Clef(ClefType.FClef, 4);
                else return currentClef;
            }
            else if (currentClef.TypeOfClef == ClefType.FClef)
            {
                if ((currentClef.Line == 1) && (n.MidiPitch > 74)) return new Clef(ClefType.GClef, 2);
                else if ((currentClef.Line == 2) && (n.MidiPitch > 71)) return new Clef(ClefType.GClef, 2);
                else if ((currentClef.Line == 3) && (n.MidiPitch > 67)) return new Clef(ClefType.GClef, 2);
                else if ((currentClef.Line == 4) && (n.MidiPitch > 64)) return new Clef(ClefType.GClef, 2);
                else if ((currentClef.Line == 5) && (n.MidiPitch > 60)) return new Clef(ClefType.GClef, 2);
                else return currentClef;
            }
            else return new Clef(ClefType.GClef, 2);
        }

        /// <summary>
        /// Returns a new instance of treble clef.
        /// </summary>
        public static Clef Treble
        {
            get { return new Clef(ClefType.GClef, 2); }
        }

        /// <summary>
        /// Returns a new instance of french violin clef.
        /// </summary>
        public static Clef FrenchViolin
        {
            get { return new Clef(ClefType.GClef, 1); }
        }

        /// <summary>
        /// Returns a new instance of soprano clef.
        /// </summary>
        public static Clef Soprano
        {
            get { return new Clef(ClefType.CClef, 1); }
        }

        /// <summary>
        /// Returns a new instance of mezzosoprano clef.
        /// </summary>
        public static Clef Mezzosoprano
        {
            get { return new Clef(ClefType.CClef, 2); }
        }

        /// <summary>
        /// Returns a new instance of alto clef.
        /// </summary>
        public static Clef Alto
        {
            get { return new Clef(ClefType.CClef, 3); }
        }

        /// <summary>
        /// Returns a new instance of tenor clef.
        /// </summary>
        public static Clef Tenor
        {
            get { return new Clef(ClefType.CClef, 4); }
        }

        /// <summary>
        /// Returns a new instance of baritone "C" clef.
        /// </summary>
        public static Clef BaritoneC
        {
            get { return new Clef(ClefType.CClef, 5); }
        }

        /// <summary>
        /// Returns a new instance of baritone "F" clef.
        /// </summary>
        public static Clef BaritoneF
        {
            get { return new Clef(ClefType.FClef, 3); }
        }

        /// <summary>
        /// Returns a new instance of bass clef.
        /// </summary>
        public static Clef Bass
        {
            get { return new Clef(ClefType.FClef, 4); }
        }

        /// <summary>
        /// Returns a new instance of subbass clef.
        /// </summary>
        public static Clef Subbass
        {
            get { return new Clef(ClefType.FClef, 5); }
        }

        #endregion



    }
}
