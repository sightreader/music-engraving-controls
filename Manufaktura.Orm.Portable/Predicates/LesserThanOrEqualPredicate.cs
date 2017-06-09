using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.Portable.Predicates
{
    public class LesserThanOrEqualPredicate : ConditionPredicate
    {
        public override string OperatorText
        {
            get { return "<="; }
        }

        public LesserThanOrEqualPredicate(string parameterName, object parameterValue) : base(parameterName, parameterValue)
        {
        }
    }
}
