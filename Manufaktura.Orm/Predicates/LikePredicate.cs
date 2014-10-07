using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manufaktura.Orm
{
    public class LikePredicate : SqlPredicate
    {
        public LikePredicate(string parameterName, object parameterValue) 
        {
            ParameterName = parameterName;
            ParameterValue = parameterValue;
        }

        public override string GetSql()
        {
            return string.Format (" {0} LIKE '{1}' ", ParameterName, ParameterValue);
        }
    }
}