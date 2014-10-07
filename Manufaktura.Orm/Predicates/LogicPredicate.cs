using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Manufaktura.Orm.Predicates
{
    public abstract class LogicPredicate : SqlPredicate
    {
        public abstract string LogicOperator { get; }
        public SqlPredicate[] Predicates { get; protected set; }

        protected LogicPredicate(params SqlPredicate[] predicates)
        {
            Predicates = predicates;
        }

        public override string GetSql()
        {
            return string.Join(LogicOperator, Predicates.Where(p => p != null).Select(p => string.Format(" ({0}) ", p.GetSql())));
        }
    }
}