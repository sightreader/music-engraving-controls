using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.Portable.Predicates
{
    public class LesserThanPredicate : ConditionPredicate
    {
        public override string OperatorText
        {
            get { return "<"; }
        }

        public LesserThanPredicate(string parameterName, object parameterValue) : base(parameterName, parameterValue)
        {
        }
    }
}
