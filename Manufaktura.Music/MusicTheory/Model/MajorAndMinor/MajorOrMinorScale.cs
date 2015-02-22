using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.MusicTheory.Model.MajorAndMinor
{
    public abstract class MajorOrMinorScale : Scale
    {
        public Key Key { get; protected set; }

        protected MajorOrMinorScale(Key key) : base(0)
        {
            Key = key;
        }

        
    }
}
