using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model
{
    public class Lyrics
    {
        public LyricsType Type { get; set; }
        public string Text { get; set; }
        public double? DefaultY { get; set; }

        public Lyrics()
        {
            Text = string.Empty;
        }

        public Lyrics(LyricsType type, string text, double? defaultY)
        {
            Type = type;
            Text = text ?? string.Empty;
            DefaultY = defaultY;
        }

        public Lyrics(LyricsType type, string text) : this (type, text, null)
        { 
        }
    }
}
