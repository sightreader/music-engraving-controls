using System;

namespace Manufaktura.Controls.Model.Assertions
{
    public class UnitsAttribute : Attribute
    {
        private Units UnitType { get; set; }

        public UnitsAttribute(Units unitType)
        {
            UnitType = unitType;
        }
    }
}