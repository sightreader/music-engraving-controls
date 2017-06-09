using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Orm.Portable.Predicates
{
    public class AndPredicate : LogicPredicate
    {
        public override string LogicOperator
        {
            get { return " AND "; }
        }

        public AndPredicate(params SqlPredicate[] predicates) : base(predicates)
        {

        }
    }
}