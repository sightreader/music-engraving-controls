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