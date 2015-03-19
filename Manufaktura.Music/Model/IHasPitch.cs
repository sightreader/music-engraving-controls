using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Music
{
    public interface IHasPitch
    {
        Pitch Pitch { get; }
    }
}
