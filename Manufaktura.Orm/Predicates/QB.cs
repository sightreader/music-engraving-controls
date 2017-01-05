using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufaktura.Orm.Predicates
{
    public static class QB
    {
        public static LikePredicate Like(string parameterName, object parameterValue)
        {
            return new LikePredicate(parameterName, parameterValue);
        }

        public static EqualsPredicate Eq(string parameterName, object parameterValue)
        {
            return new EqualsPredicate(parameterName, parameterValue);
        }

        public static NotEqualsPredicate NEq(string parameterName, object parameterValue)
        {
            return new NotEqualsPredicate(parameterName, parameterValue);
        }

        public static GreaterThanPredicate Gr(string parameterName, object parameterValue)
        {
            return new GreaterThanPredicate(parameterName, parameterValue);
        }

        public static LesserThanPredicate Le(string parameterName, object parameterValue)
        {
            return new LesserThanPredicate(parameterName, parameterValue);
        }

        public static GreaterThanOrEqualPredicate GEq(string parameterName, object parameterValue)
        {
            return new GreaterThanOrEqualPredicate(parameterName, parameterValue);
        }

        public static LesserThanOrEqualPredicate LEq(string parameterName, object parameterValue)
        {
            return new LesserThanOrEqualPredicate(parameterName, parameterValue);
        }

        public static OrPredicate Or(params SqlPredicate[] predicates)
        {
            return new OrPredicate(predicates);
        }

        public static AndPredicate And(params SqlPredicate[] predicates)
        {
            return new AndPredicate(predicates);
        }

        
    }
}
