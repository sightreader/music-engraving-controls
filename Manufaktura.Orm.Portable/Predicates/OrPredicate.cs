using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Orm.Portable.Predicates
{
    public class OrPredicate : LogicPredicate
    {
        public override string LogicOperator
        {
            get { return " OR "; }
        }

        public OrPredicate(params SqlPredicate[] predicates) : base(predicates)
        {

        }
    }
}