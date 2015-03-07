using System;
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

        public override string ToString()
        {
            return string.Format("{0}{1}", StepName, AlterToSigns(Alter));
        }

        protected static string AlterToSigns(int alter)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < Math.Abs(alter); i++)
            {
                sb.Append(alter < 0 ? "b" : "#");
            }
            return sb.ToString();
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

        public override bool Equals(object obj)
        {
            if (obj is Step) return this == (Step)obj;
            return base.Equals(obj);
        }

        public static bool operator ==(Step s1, Step s2)
        {
            return s1.StepName.Equals(s2.StepName, StringComparison.OrdinalIgnoreCase) && s1.Alter == s2.Alter;
        }

        public static bool operator !=(Step s1, Step s2)
        {
            return !s1.StepName.Equals(s2.StepName, StringComparison.OrdinalIgnoreCase) || !(s1.Alter == s2.Alter);
        }

        public static implicit operator Step(string s)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (!new[] { "A", "B", "C", "D", "E", "F", "G" }.Contains(s.ToUpper()))
                throw new InvalidCastException(string.Format("{0} is not a valid step name.", s));

            return new Step { StepName = s, Alter = 0 };
        }

        public static implicit operator string(Step s)
        {
            return s.StepName;
        }
    }
}
