﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    public class Step
    {
        public string StepName { get; set; }
        public int Alter { get; set; }

        protected Step()
        {
        }


        public static Step FromPitch(Pitch pitch)
        {
            return new Step { StepName = pitch.StepName, Alter = pitch.Alter };
        }

        public Pitch ToPitch(int octaveNumber = 4)
        {
            return Pitch.FromStep(this, octaveNumber);
        }

        public static Step Cb
        {
            get { return new Step { StepName = "C", Alter = -1 }; }
        }

        public static Step C
        {
            get { return new Step { StepName = "C", Alter = 0 }; }
        }

        public static Step CSharp
        {
            get { return new Step { StepName = "C", Alter = 1 }; }
        }

        public static Step Db
        {
            get { return new Step { StepName = "D", Alter = -1 }; }
        }

        public static Step D
        {
            get { return new Step { StepName = "D", Alter = 0 }; }
        }

        public static Step DSharp
        {
            get { return new Step { StepName = "D", Alter = 1 }; }
        }

        public static Step Eb
        {
            get { return new Step { StepName = "E", Alter = -1 }; }
        }

        public static Step E
        {
            get { return new Step { StepName = "E", Alter = 0 }; }
        }

        public static Step ESharp
        {
            get { return new Step { StepName = "E", Alter = 1 }; }
        }

        public static Step Fb
        {
            get { return new Step { StepName = "F", Alter = -1 }; }
        }

        public static Step F
        {
            get { return new Step { StepName = "F", Alter = 0 }; }
        }

        public static Step FSharp
        {
            get { return new Step { StepName = "F", Alter = 1 }; }
        }

        public static Step Gb
        {
            get { return new Step { StepName = "G", Alter = -1 }; }
        }

        public static Step G
        {
            get { return new Step { StepName = "G", Alter = 0 }; }
        }

        public static Step GSharp
        {
            get { return new Step { StepName = "G", Alter = 1 }; }
        }

        public static Step Ab
        {
            get { return new Step { StepName = "A", Alter = -1 }; }
        }

        public static Step A
        {
            get { return new Step { StepName = "A", Alter = 0 }; }
        }

        public static Step ASharp
        {
            get { return new Step { StepName = "A", Alter = 1 }; }
        }

        public static Step Bb
        {
            get { return new Step { StepName = "B", Alter = -1 }; }
        }

        public static Step B
        {
            get { return new Step { StepName = "B", Alter = 0 }; }
        }

        public static Step BSharp
        {
            get { return new Step { StepName = "B", Alter = 1 }; }
        }

        public static bool operator ==(Step s1, Step s2)
        {
            return s1.StepName.Equals(s2.StepName, StringComparison.OrdinalIgnoreCase) && s1.Alter == s2.Alter;
        }

        public static bool operator !=(Step s1, Step s2)
        {
            return !s1.StepName.Equals(s2.StepName, StringComparison.OrdinalIgnoreCase) || !(s1.Alter == s2.Alter);
        }

        public static bool operator ==(Step s1, string s)
        {
            return s1.StepName.Equals(s, StringComparison.OrdinalIgnoreCase);
        }

        public static bool operator !=(Step s1, string s)
        {
            return !s1.StepName.Equals(s, StringComparison.OrdinalIgnoreCase);
        }
    }
}