using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Services
{
    public class AlterationService : IAlterationService
    {
        private int[] alterationsWithinOneBar;

        public void Reset()
        {
            alterationsWithinOneBar = new int[7];
        }

        public int Get(Step step)
        {
            return alterationsWithinOneBar[StepToIndex(step)];
        }

        public void Set(Step step, int value)
        {
            alterationsWithinOneBar[StepToIndex(step)] = value;
        }

        private int StepToIndex(Step step)
        {
            if (step == Step.C) return 0;
            else if (step == Step.D) return 1;
            else if (step == Step.E) return 2;
            else if (step == Step.F) return 3;
            else if (step == Step.G) return 4;
            else if (step == Step.A) return 5;
            else if (step == Step.B) return 6;
            else return 0;
        }

        public AlterationService()
        {
            alterationsWithinOneBar = new int[7];
        }
    }
}
