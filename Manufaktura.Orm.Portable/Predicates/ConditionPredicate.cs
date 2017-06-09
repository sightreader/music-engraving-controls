using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.Portable.Predicates
{
    public abstract class ConditionPredicate : SqlPredicate
    {
        public string ParameterName { get; protected set; }
        public object ParameterValue { get; protected set; }
        public abstract string OperatorText { get; }

        protected ConditionPredicate(string parameterName, object parameterValue) 
        {
            ParameterName = parameterName;
            ParameterValue = parameterValue;
        }

        public override string GetSql(ref int parameterCounter)
        {
            return string.Format(" {0} {1} @P{2} ", ParameterName, OperatorText, parameterCounter++);
        }

        public override object[] GetParameterValues()
        {
            return new[] { ParameterValue };
        }
    }
}
