using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manufaktura.Orm.Predicates
{
    public class OrPredicate : LogicPredicate
    {
        public override string LogicOperator
        {
            get { return "OR"; }
        }

        public OrPredicate(params SqlPredicate[] predicates) : base(predicates)
        {

        }
    }
}