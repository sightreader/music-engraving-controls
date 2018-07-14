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

using Manufaktura.Orm.Portable.Builder;
using Manufaktura.Orm.Portable.Linq;
using Manufaktura.Orm.Portable.Predicates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Manufaktura.Orm.Linq
{
    public class DbRepositoryQuery<T> where T : new()
    {
        private DbRepository repository;

        internal DbRepositoryQuery(DbRepository repository)
        {
            this.repository = repository;
            QueryBuilder = QueryBuilder.Create();
        }

        internal QueryBuilder QueryBuilder { get; private set; }

        public long Count()
        {
            return repository.Count<T>("*", QueryBuilder.WhereStatement);
        }

        public long Count(Expression<Func<T, bool>> whereExpression)
        {
            Where(whereExpression);
            return repository.Count<T>("*", QueryBuilder.WhereStatement);
        }

        public T FirstOrDefault()
        {
            return ToList().FirstOrDefault();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> whereExpression)
        {
            return Where(whereExpression).ToList().FirstOrDefault();
        }

        public List<T> ToList()
        {
            return repository.Load<T>(QueryBuilder);
        }
        public DbRepositoryQuery<T> Where(Expression<Func<T, bool>> whereExpression)
        {
            var newWhereStatement = Linq2PredicateParser.Parse(whereExpression.Body);
            QueryBuilder.SetWhereStatement(QueryBuilder.WhereStatement == null ? newWhereStatement : QB.And(QueryBuilder.WhereStatement, newWhereStatement));
            return this;
        }
    }
}