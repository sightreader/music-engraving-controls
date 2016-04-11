using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Services
{
    public interface IAlterationService
    {
        void Reset();
        int Get(Step step);
        void Set(Step step, int value);
    }
}
