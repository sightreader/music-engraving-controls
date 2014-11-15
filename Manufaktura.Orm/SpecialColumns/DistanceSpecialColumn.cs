using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Manufaktura.Orm.SpecialColumns
{
    public class DistanceSpecialColumn : SpecialColumn
    {
        const int NumberOfDistanceColumnsInDb = 8;
        public string CoordinateColumnPrefix { get; private set; }
        public int[] Coordinates { get; private set; }

        public DistanceSpecialColumn(string alias, string coordinateColumnPrefix, int[] coordinates) : base(alias)
        {
            CoordinateColumnPrefix = coordinateColumnPrefix;
            Coordinates = coordinates;
        }

        public override string GetColumnStatement()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SQRT(");
            bool first = true;
            for (int i = 0; i < Coordinates.Length && i < NumberOfDistanceColumnsInDb; i++)
            {
                if (!first) sb.Append(" + ");
                sb.Append(string.Format("POW({0} - {1},2)", Coordinates[i], string.Concat(CoordinateColumnPrefix, i + 1)));
                first = false;
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}