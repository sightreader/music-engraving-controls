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

        public override string GetSql(ref int parameterCounter)
        {
            List<string> predicates = new List<string>();
            foreach (var predicate in Predicates.Where(p => p != null)) 
            {
                predicates.Add(predicate.GetSql(ref parameterCounter));
            }
            return string.Join(LogicOperator, predicates);
        }

        public override object[] GetParameterValues()
        {
            List<object> parameterValues = new List<object>();
            foreach (var predicate in Predicates.Where(p => p != null))
            {
                parameterValues.AddRange(predicate.GetParameterValues());
            }
            return parameterValues.ToArray();
        }
    }
}