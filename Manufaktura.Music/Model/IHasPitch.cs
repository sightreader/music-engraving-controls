using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Music
{
    /// <summary>
    /// Indicates that element has pitch.
    /// </summary>
    public interface IHasPitch
    {
        /// <summary>
        /// Pitch of element.
        /// </summary>
        Pitch Pitch { get; }
    }
}
