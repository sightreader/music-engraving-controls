using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manufaktura.Orm.Predicates
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