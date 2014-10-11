using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.Predicates
{
    public class GreaterThanOrEqualPredicate : ConditionPredicate
    {
        public override string OperatorText
        {
            get { return ">="; }
        }

        public GreaterThanOrEqualPredicate(string parameterName, object parameterValue) : base(parameterName, parameterValue)
        {
        }
    }
}
