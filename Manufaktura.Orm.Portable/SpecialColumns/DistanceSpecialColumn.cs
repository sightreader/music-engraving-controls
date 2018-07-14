/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Orm.Portable.SpecialColumns
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