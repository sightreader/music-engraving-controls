using System;
using System.Collections.Generic;
using System.Text;

namespace Manufaktura.Core.Models
{
    public class Compartment
    {
        public double? From { get; set; }
        public double? To { get; set; }

        public override string ToString()
        {
            if (From.HasValue && To.HasValue) return $"{From:0.00} - {To:0.00}";
            else if (From.HasValue) return $"{From:0.00} - inf.";
            else if (To.HasValue) return $"-inf. - {To:0.00}";
            else return base.ToString();
        }

        public Compartment CorrectOrder()
        {
            if (!From.HasValue || !To.HasValue) return this;
            if (From < To) return this;
            var from = From;
            From = To;
            To = from;
            return this;
        }
    }
}
