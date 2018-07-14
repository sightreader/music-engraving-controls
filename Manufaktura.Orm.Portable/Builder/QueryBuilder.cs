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

using Manufaktura.Orm.Portable.SortModes;
using Manufaktura.Orm.Portable.SpecialColumns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.Portable.Builder
{
    public class QueryBuilder
    {
        public int Offset { get; protected set; }
        public int Limit { get; protected set; }
        public SqlPredicate WhereStatement { get; protected set; }
        public IEnumerable<string> Columns { get; protected set; }
        public List<SpecialColumn> SpecialColumns { get; protected set; }
        public List<SortMode> SortModes { get; protected set; }
        public bool AreColumnsSpecified { get; protected set; }

        protected QueryBuilder()
        {
            SpecialColumns = new List<SpecialColumn>();
            SortModes = new List<SortMode>();
            Columns = new List<string>();
        }

        public static QueryBuilder Create()
        {
            return new QueryBuilder();
        }

        public QueryBuilder SetWindow(int offset, int limit)
        {
            Offset = offset;
            Limit = limit;
            return this;
        }

        public QueryBuilder SetWhereStatement(SqlPredicate whereStatement)
        {
            WhereStatement = whereStatement;
            return this;
        }

        public QueryBuilder AddSpecialColumn(SpecialColumn column)
        {
            SpecialColumns.Add(column);
            return this;
        }

        public QueryBuilder AddSortMode(SortMode sortMode)
        {
            SortModes.Add(sortMode);
            return this;
        }

        public QueryBuilder SpecifyColumns(IEnumerable<string> columns)
        {
            if (columns == null) columns = new List<string>();
            Columns = columns;
            AreColumnsSpecified = true;
            return this;
        }
    }
}
