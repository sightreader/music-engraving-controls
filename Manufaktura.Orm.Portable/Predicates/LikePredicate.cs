﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Orm.Portable.Predicates
{
    public class LikePredicate : ConditionPredicate
    {
        public override string OperatorText
        {
            get { return "LIKE"; }
        }

        public LikePredicate(string parameterName, object parameterValue) : base(parameterName, parameterValue)
        {
        }
    }
}