using Manufaktura.Model;
using Manufaktura.Orm.Builder;
using Manufaktura.Orm.Predicates;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Manufaktura.Orm.Linq
{
    public class DbRepositoryQuery<T> where T : Entity, new()
    {
        private DbRepository repository;

        internal DbRepositoryQuery(DbRepository repository)
        {
            this.repository = repository;
            QueryBuilder = QueryBuilder.Create();
        }

        internal QueryBuilder QueryBuilder { get; private set; }

        public List<T> ToList()
        {
            return repository.Load<T>(QueryBuilder);
        }

        public DbRepositoryQuery<T> Where(Expression<Func<T, bool>> whereExpression)
        {
            var newWhereStatement = Linq2PredicateParser.Parse(whereExpression);
            QueryBuilder.SetWhereStatement(QueryBuilder.WhereStatement == null ? newWhereStatement : QB.And(QueryBuilder.WhereStatement, newWhereStatement));
            return this;
        }
    }
}